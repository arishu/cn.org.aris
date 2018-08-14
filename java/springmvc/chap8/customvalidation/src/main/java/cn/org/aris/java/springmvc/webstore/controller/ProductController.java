package cn.org.aris.java.springmvc.webstore.controller;

import java.io.File;
import java.util.List;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;
import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.util.StringUtils;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.WebDataBinder;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.bind.annotation.InitBinder;
import org.springframework.web.bind.annotation.MatrixVariable;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.ModelAndView;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.exception.NoProductsFoundUnderCategoryException;
import cn.org.aris.java.springmvc.webstore.exception.ProductNotFoundException;
import cn.org.aris.java.springmvc.webstore.service.ProductService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

@Controller
@RequestMapping("market")
public class ProductController {

	private static final Logger logger = LoggerFactory.getLogger(ProductController.class);
	
	@Autowired
	private ProductService productService;
	
	@RequestMapping("/products")
	public String list(Model model) {
		model.addAttribute("products", productService.getAllProducts());
		logger.debug("[Get list of products]");
		return "products";
	}
	
	@RequestMapping("/update/stock")
	public String updateStock(Model model) {
		productService.updateAllStock();
		logger.debug("[Update Stock]");
		return "redirect:/market/products";
	}
	
	@RequestMapping("/products/{category}")
	public String getProductsByCategory(Model model,
			@PathVariable("category") String productCategory) {
		
		List<Product> products = productService.getProductsByCategory(productCategory);

		// Do some Checking
		if (products == null || products.isEmpty()) {
			throw new NoProductsFoundUnderCategoryException();
		}
		
		model.addAttribute("products", products);
		logger.debug("[Get products by category]");
		return "products";
	}
	
	@RequestMapping("/products/filter/{params}")
	public String getProductsByFilter(Model model,
			@MatrixVariable(pathVar="params") Map<String, List<String>> filterParams) {
		model.addAttribute("products", productService.getProductsByFilter(filterParams));
		logger.debug("[Get products by filter]");
		return "products";
	}
	
	@RequestMapping("/product")
	public String getProductById(Model model,
			@RequestParam("id") String productId) {
		model.addAttribute("product", productService.getProductById(productId));
		logger.debug("[Get product details by productId]");
		return "product";
	}
	
	@RequestMapping("/products/{category}/{price}")
	public String filterProducts(
			@PathVariable(value="category") String category,
			@MatrixVariable(pathVar="price") Map<String, Object> prices,
			@RequestParam(value = "brand") String brand,
			Model model) {
		logger.debug("category: " + category);
		logger.debug("prices: " + prices);
		logger.debug("brand: " + brand);
		model.addAttribute("products", productService.filterProducts(prices, category, brand));
		return "products";
	}
	
	@RequestMapping(value = "/products/add", method = RequestMethod.GET)
	public String getAddNewProductForm(Model model) {
		Product newProduct = new Product();
		model.addAttribute("newProduct", newProduct);
		logger.info("[Get Product Adding Page]");
		return "addProduct";
	}
	
	/*@RequestMapping(value = "/products/add", method=RequestMethod.POST)
	public String processAddNewProductForm(@ModelAttribute("newProduct") Product newProduct) {
		productService.addProduct(newProduct);
		return "redirect:/market/products";
	}*/
	
	@InitBinder
	public void initialiseBinder(WebDataBinder binder) {
		binder.setAllowedFields("productId",
				"name",
				"unitPrice",
				"description",
				"manufacturer",
				"category",
				"unitsInStock",
				"condition",
				"productImage",
				"productManualPdf",
				"language");
	}
	
	@RequestMapping(value = "/products/add", method=RequestMethod.POST)
	public String processAddNewProductForm(
			@ModelAttribute("newProduct") @Valid Product productToBeAdded, 
			BindingResult result, HttpServletRequest request) {

		// return the same jsp view if validation failed
		if (result.hasErrors()) {
			return "addProduct";
		}
		
		String[] suppressedFields = result.getSuppressedFields();
		if (suppressedFields.length > 0) {
			throw new RuntimeException("Attempting to bind disallowed fields: " 
					+ StringUtils.arrayToCommaDelimitedString(suppressedFields));
		}
		
		/*
		 * Uploading picture using Commons-fileupload
		 */
		MultipartFile productImage = productToBeAdded.getProductImage();
		String rootDirectory = request.getSession().getServletContext().getRealPath("/");
		
		if (productImage != null && !productImage.isEmpty()) {
			try {
				productImage.transferTo(new File(rootDirectory + "resources\\images\\" + productToBeAdded.getProductId() + ".png"));
			} catch (Exception e) {
				throw new RuntimeException("Product Image saving failed", e);
			}
		}
		
		/*
		 * Uploading product manual using Commons-fileupload
		 */
		MultipartFile productManualPdf = productToBeAdded.getProductManualPdf();
		if (productManualPdf != null && !productManualPdf.isEmpty()) {
			try {
				productManualPdf.transferTo(
					new File(rootDirectory + "resources\\product\\manuals\\manual-" 
								+ productToBeAdded.getProductId() + ".pdf") 
				);
			} catch (Exception e) {
				logger.error(e.getStackTrace().toString());
				throw new RuntimeException("Product Manual saving failed", e);
			}
		}
		
		productService.addProduct(productToBeAdded);
		return "redirect:/market/products";
	}
	
	@ExceptionHandler(ProductNotFoundException.class)
	public ModelAndView handler(HttpServletRequest req, ProductNotFoundException exception) {
		ModelAndView mav = new ModelAndView();
		mav.addObject("invalidProductId", exception.getProductId());
		mav.addObject("exception", exception);
		mav.addObject("url", req.getRequestURL() + "?" + req.getQueryString());
		mav.setViewName("productNotFound");
		return mav;
	}
	
}
