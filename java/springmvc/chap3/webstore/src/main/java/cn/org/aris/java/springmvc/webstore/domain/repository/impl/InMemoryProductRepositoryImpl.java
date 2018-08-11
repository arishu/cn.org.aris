package cn.org.aris.java.springmvc.webstore.domain.repository.impl;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.jdbc.core.namedparam.NamedParameterJdbcTemplate;
import org.springframework.jdbc.core.namedparam.SqlParameterSource;
import org.springframework.jdbc.core.namedparam.SqlParameterSourceUtils;
import org.springframework.stereotype.Repository;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.domain.repository.ProductRepository;

@Repository
public class InMemoryProductRepositoryImpl implements ProductRepository {

	private static final Logger logger = LoggerFactory.getLogger(InMemoryProductRepositoryImpl.class);
	
	@Autowired
	private NamedParameterJdbcTemplate jdbcTemplate;
	
	@Override
	public List<Product> getAllProducts() {
		Map<String, Object> params = new HashMap<String, Object>();
		List<Product> result = jdbcTemplate.query("SELECT * FROM PRODUCTS", params, new ProductMapper());
		return result;
	}

	private static final class ProductMapper implements RowMapper<Product> {

		@Override
		public Product mapRow(ResultSet rs, int rowNum) throws SQLException {
			Product product = new Product();
			product.setProductId(rs.getString("ID"));
			product.setName(rs.getString("NAME"));
			product.setDescription(rs.getString("DESCRIPTION"));
			product.setUnitPrice(rs.getBigDecimal("UNIT_PRICE"));
			product.setManufacturer(rs.getString("MANUFACTURER"));
			product.setCategory(rs.getString("CATEGORY"));
			product.setCondition(rs.getString("CONDITION"));
			product.setUnitsInStock(rs.getLong("UNITS_IN_STOCK"));
			product.setUnitsInOrder(rs.getLong("UNITS_IN_ORDER"));
			product.setDiscontinued(rs.getBoolean("DISCONTINUED"));
			return product;
		}
	}

	@Override
	public void updateStock(String productId, long noOfUnits) {
		String SQL = "UPDATE PRODUCTS SET UNITS_IN_STOCK = :unitsInStock WHERE ID = :id";
		Map<String, Object> params = new HashMap<String, Object>();
		params.put("unitsInStock", noOfUnits);
		params.put("id", productId);
		this.jdbcTemplate.update(SQL, params);
	}

	@Override
	public List<Product> getProductsByCategory(String category) {
		String SQL = "SELECT * FROM PRODUCTS WHERE CATEGORY = :category";
		Map<String, Object> params = new HashMap<String, Object>();
		params.put("category", category);
		return jdbcTemplate.query(SQL, params, new ProductMapper());
	}

	@Override
	public List<Product> getProductsByFilter(Map<String, List<String>> filterParams) {
		String SQL = "SELECT * FROM PRODUCTS WHERE CATEGORY IN ( :categories ) AND MANUFACTURER IN ( :brands )";
		return jdbcTemplate.query(SQL, filterParams, new ProductMapper());
	}

	@Override
	public Product getProductById(String productID) {
		String SQL = "SELECT * FROM PRODUCTS WHERE ID = :id";
		Map<String, Object> params = new HashMap<String, Object>();
		params.put("id", productID);
		return jdbcTemplate.queryForObject(SQL, params, new ProductMapper());
	}

	@Override
	public List<Product> filterProducts(Map<String, Object> prices, String category, String brand) {
		String SQL = "SELECT * FROM PRODUCTS "
				+ "WHERE "
				+ " UNIT_PRICE >= :low"
				+ " and UNIT_PRICE <= :high"
				+ " and MANUFACTURER = :brand"
				+ " and CATEGORY = :mycategory";
		
		logger.info("SQL: " + SQL);
		logger.debug("prices: " + prices + ", category: " + category + ", brand: " + brand);
		
		Map<String, Object> params = new HashMap<String, Object>();
		params.put("low", Integer.parseInt(prices.get("low").toString()));
		params.put("high", Integer.parseInt(prices.get("high").toString()));
		params.put("mycategory", category);
		params.put("brand", brand);
		
		List<Product> products =  jdbcTemplate.query(SQL, params, new ProductMapper());
		
		return products;
	}
}
