package cn.org.aris.java.eterprisespring.springsecurity.dao;

import java.util.List;
import cn.org.aris.java.eterprisespring.springsecurity.model.Employee;

public interface EmployeeDao {
	
	public List<Employee> listEmployee();

	public void insertEmployee(Employee employee);

	public void deleteEmployee(Integer empId);
}
