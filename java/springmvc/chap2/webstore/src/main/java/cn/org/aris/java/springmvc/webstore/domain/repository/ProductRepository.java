package cn.org.aris.java.springmvc.webstore.domain.repository;

import java.util.List;

import cn.org.aris.java.springmvc.webstore.domain.Product;

public interface ProductRepository {
	
	List<Product> getAllProducts();
	
	void updateStock(String productId, long noOfUnits);
}
