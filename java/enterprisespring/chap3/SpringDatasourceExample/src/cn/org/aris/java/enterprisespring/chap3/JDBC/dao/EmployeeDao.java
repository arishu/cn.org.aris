package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public interface EmployeeDao {
	// delete employee table
	void deleteEmployee();

	// delete employee data based on employeeId
	void deleteEmployeeById(int empId);

	// get employee data based on employee id
	Employee getEmployeeById(int empId);

	// create employee table
	void createEmployee();

	// insert values to employee table
	void insertEmployee(Employee employee);
}
