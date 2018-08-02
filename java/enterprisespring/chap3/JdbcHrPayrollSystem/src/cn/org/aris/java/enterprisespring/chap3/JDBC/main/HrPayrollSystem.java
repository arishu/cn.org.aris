package cn.org.aris.java.enterprisespring.chap3.JDBC.main;

import cn.org.aris.java.enterprisespring.chap3.JDBC.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.chap3.JDBC.dao.impl.EmployeeDaoImpl;
import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public class HrPayrollSystem {

	public static void main(String[] args) {
		EmployeeDao employeeDao = new EmployeeDaoImpl();
		
		// delete employee based on id
		employeeDao.deleteEmployeeById(2);;
		
		// Insert into employee table
		employeeDao.insertEmployee(new Employee(2, "Taylor"));
		
		// Get employee based on id
		Employee employee = employeeDao.getEmployeeById(2);
		
		System.out.println(employee);
	}

}
