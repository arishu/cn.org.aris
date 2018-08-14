package cn.org.aris.java.springmvc.webstore.validator;

import java.util.ArrayList;
import java.util.List;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.service.ProductService;

@Component
public class CategoryValidator implements ConstraintValidator<Category, String> {

	private static Logger logger = LoggerFactory.getLogger(CategoryValidator.class);
	
	List<String> allowedCategories;
	
	@Autowired
	private ProductService productService;
	
	public CategoryValidator() {
		allowedCategories = new ArrayList<String>();
	}

	@Override
	public void initialize(Category constraintAnnotation) {
		logger.info("[Initialize CategoryValidator]");
		List<Product> products = productService.getAllProducts();
		logger.debug("【" + products.toString() + "】");
		for (Product product: products) {
			if (!allowedCategories.contains(product.getCategory())) {
				allowedCategories.add(product.getCategory().toLowerCase());
			}
		}
	}

	@Override
	public boolean isValid(String value, ConstraintValidatorContext context) {
		return allowedCategories.contains(value.toLowerCase());
	}

}
