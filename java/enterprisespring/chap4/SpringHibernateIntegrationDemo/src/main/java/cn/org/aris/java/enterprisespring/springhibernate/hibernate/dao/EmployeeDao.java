package cn.org.aris.java.enterprisespring.springhibernate.hibernate.dao;

import java.util.List;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

public interface EmployeeDao {
	
	// Get all employees
	public List<Employee> getAllEmployees();
	
	// Insert a new Employee
	public void insertEmployee(Employee employee);
}
