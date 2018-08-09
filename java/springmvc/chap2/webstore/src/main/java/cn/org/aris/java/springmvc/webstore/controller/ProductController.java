package cn.org.aris.java.springmvc.webstore.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import cn.org.aris.java.springmvc.webstore.domain.repository.ProductRepository;
import cn.org.aris.java.springmvc.webstore.service.ProductService;

@Controller
public class ProductController {

	@Autowired
	private ProductRepository productRepository;
	
	@Autowired
	private ProductService productService;
	
	@RequestMapping("/products")
	public String list(Model model) {
		/*Product iphone = new Product("P1234", "iPhone 6s", new BigDecimal(500));
		iphone.setDescription("Apple iPhone 6s smartphone\r\n" + 
				"with 4.00-inch 640x1136 display and 8-megapixel rear\r\n" + 
				"camera");
		iphone.setCategory("Smartphone");
		iphone.setManufacturer("Apple");
		iphone.setUnitsInStock(1000);
		model.addAttribute("product", iphone);*/
		model.addAttribute("products", productRepository.getAllProducts());
		return "products";
	}
	
	@RequestMapping("/update/stock")
	public String updateStock(Model model) {
		this.productService.updateAllStock();
		return "redirect:/products";
	}
	
}
