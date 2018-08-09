package cn.org.aris.java.enterprisespring.springtest.service;

import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public interface EmployeeService {

	public boolean isOldEmployee(String employeeId);
	
	public void createEmployee(Employee employee);

	public void updateEmployee(Employee employee);

	public void deleteEmployee(String employeeId);

	public Employee findEmployee(String employeeId);

}
