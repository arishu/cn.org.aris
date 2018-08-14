package cn.org.aris.java.springmvc.webstore.exception;

public class ProductNotFoundException extends RuntimeException {

	private static final long serialVersionUID = -2143776763130281403L;
	
	private String productId;

	public ProductNotFoundException() {}
	
	public ProductNotFoundException(String productId, Throwable e) {
		super("Product not found in database", e);
		this.productId = productId;
	}

	public String getProductId() {
		return productId;
	}
}
