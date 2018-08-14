package cn.org.aris.java.springmvc.webstore.domain.repository;

import java.util.List;
import java.util.Map;

import cn.org.aris.java.springmvc.webstore.domain.Product;

public interface ProductRepository {
	
	/**
	 * Get all products
	 * @return
	 */
	List<Product> getAllProducts();
	
	/**
	 * Update product's UnitInStock value
	 * @param productId
	 * @param noOfUnits
	 */
	void updateStock(String productId, long noOfUnits);
	
	/**
	 * Retrieve products according to products' category
	 * @param category product's category
	 * @return
	 */
	List<Product> getProductsByCategory(String category);
	
	/**
	 * Retrieve products according to a specified filter
	 * @param filterParams
	 * @return
	 */
	List<Product> getProductsByFilter(Map<String, List<String>> filterParams);
	
	/**
	 * Get Product according to productID
	 * @param productID
	 * @return
	 */
	Product getProductById(String productID);
	
	
	/**
	 * 
	 * @param prices
	 * @param brand
	 * @param category
	 * @return
	 */
	List<Product> filterProducts(Map<String, Object> prices, String category, String brand);
	
	/**
	 * Add a new Product to the database
	 * @param product
	 */
	void addProduct(Product product);
}
