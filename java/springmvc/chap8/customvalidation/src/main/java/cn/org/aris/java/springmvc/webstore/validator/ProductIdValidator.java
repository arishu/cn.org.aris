package cn.org.aris.java.springmvc.webstore.validator;

import javax.validation.ConstraintValidator;
import javax.validation.ConstraintValidatorContext;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.exception.ProductNotFoundException;
import cn.org.aris.java.springmvc.webstore.service.ProductService;

@Component
public class ProductIdValidator implements ConstraintValidator<ProductId, String> {

	@Autowired
	private ProductService productService;
	
	@Override
	public void initialize(ProductId constraintAnnotation) {
		
	}

	@Override
	public boolean isValid(String value, ConstraintValidatorContext context) {
		Product product = null;
		
		// Try searching the database for the given productId
		try {
			product = productService.getProductById(value);
		} catch (ProductNotFoundException e) {
			return true;
		}
		
		// If find the related product, then return false
		if (product != null) {
			return false;
		}
		
		return true;
	}

}
