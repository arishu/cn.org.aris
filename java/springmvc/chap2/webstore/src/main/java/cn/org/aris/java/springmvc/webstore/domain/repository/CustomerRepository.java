package cn.org.aris.java.springmvc.webstore.domain.repository;

import java.util.List;

import cn.org.aris.java.springmvc.webstore.domain.Customer;

public interface CustomerRepository {
	
	List<Customer> getAllCustomers();
}
