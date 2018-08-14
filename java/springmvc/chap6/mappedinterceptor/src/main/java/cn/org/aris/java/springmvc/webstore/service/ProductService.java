package cn.org.aris.java.springmvc.webstore.service;

import java.util.List;
import java.util.Map;

import cn.org.aris.java.springmvc.webstore.domain.Product;

public interface ProductService {

	List<Product> getAllProducts();
	
	void updateAllStock();
	
	List<Product> getProductsByCategory(String category);
	
	List<Product> getProductsByFilter(Map<String, List<String>> filterParams);
	
	Product getProductById(String productID);
	
	List<Product> filterProducts(Map<String, Object> prices, String category, String brand);
	
	void addProduct(Product product);
}
