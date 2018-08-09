package cn.org.aris.java.enterprisespring.springtest.dao;

import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public interface EmployeeDao {

	public boolean isOldEmployee(String employeeId);
	
	public void createEmployee(Employee employee);
	
	public void updateEmployee(Employee employee);
	
	public void deleteEmployee(String employeeId);
	
	public Employee findEmployee(String employeeId);
	
}
