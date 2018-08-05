package cn.org.aris.java.enterprisespring.springhibernate.hibernate.service;

import java.util.List;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

public interface EmployeeService {
	
	public List<Employee> getAllEmployees();
	
	public void insertEmployee(Employee employee);
}
