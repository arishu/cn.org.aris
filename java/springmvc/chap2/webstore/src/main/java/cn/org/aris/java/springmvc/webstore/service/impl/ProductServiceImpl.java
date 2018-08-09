package cn.org.aris.java.springmvc.webstore.service.impl;

import java.util.List;

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
	public void updateAllStock() {
		List<Product> allProducts = this.productRepository.getAllProducts();
		for (Product product: allProducts) {
			if (product.getUnitsInStock() < 500) {
				this.productRepository.updateStock(product.getProductId(), product.getUnitsInStock() + 1000);
			}
		}
	}

}
