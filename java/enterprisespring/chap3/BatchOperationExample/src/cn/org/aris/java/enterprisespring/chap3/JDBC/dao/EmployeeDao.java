package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import java.util.List;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public interface EmployeeDao {
	
	// delete employee table
	void deleteEmployee();
	
	// create employee table
	void createEmployee();
	
	// get employees' count
	int getEmployeeCount();
	
	// insert values to employee table
	void insertEmployee(Employee employee);
	
	// insert employees using batch operation
	void insertEmployees(List<Employee> employees);
	
	// get employee data based on employee id
	Employee getEmployeeById(int empId);
	
	// delete employee data based on employee id
	int deleteEmployeeById(int empId);
}
