package cn.org.aris.java.springmvc.webstore.service.impl;

import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.domain.repository.ProductRepository;
import cn.org.aris.java.springmvc.webstore.service.ProductService;

@Service
public class ProductServiceImpl implements ProductService {

	@Autowired
	private ProductRepository productRepository;
	
	@Override
	public List<Product> getAllProducts() {
		return productRepository.getAllProducts();
	}

	@Override
	public void updateAllStock() {
		List<Product> products = this.productRepository.getAllProducts();
		for (Product product: products) {
			if (product.getUnitsInStock() < 500) {
				this.productRepository.updateStock(product.getProductId(), product.getUnitsInStock() + 1000);
			}
		}
	}

	@Override
	public List<Product> getProductsByCategory(String category) {
		return productRepository.getProductsByCategory(category);
	}

	@Override
	public List<Product> getProductsByFilter(Map<String, List<String>> filterParams) {
		return productRepository.getProductsByFilter(filterParams);
	}

	@Override
	public Product getProductById(String productID) {
		return productRepository.getProductById(productID);
	}

	@Override
	public List<Product> filterProducts(Map<String, Object> prices, String category, String brand) {
		return productRepository.filterProducts(prices, category, brand);
	}

	@Override
	public void addProduct(Product product) {
		productRepository.addProduct(product);
	}
}
