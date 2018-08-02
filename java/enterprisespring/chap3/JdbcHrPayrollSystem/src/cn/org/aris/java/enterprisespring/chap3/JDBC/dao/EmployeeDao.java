package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public interface EmployeeDao {
	
	void deleteEmployeeById(int id);
	
	// get employee data based on employee id
	Employee getEmployeeById(int id);
	
	// create employee table
	void createEmployee();
	
	// insert values to employee table
	void insertEmployee(Employee employee);
}
