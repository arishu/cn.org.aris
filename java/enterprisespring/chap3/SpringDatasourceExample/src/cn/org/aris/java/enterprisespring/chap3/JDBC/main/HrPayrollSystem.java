package cn.org.aris.java.enterprisespring.chap3.JDBC.main;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.enterprisespring.chap3.JDBC.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public class HrPayrollSystem {

	public static void main(String[] args) {

		ApplicationContext context = new ClassPathXmlApplicationContext("Spring.xml");
		
		EmployeeDao employeeDao = context.getBean("employeeDaoImpl", EmployeeDao.class);
		
		// delete employee based on id
		employeeDao.deleteEmployeeById(2);;
		
		// Insert into employee table
		employeeDao.insertEmployee(new Employee(2, "Taylor"));
		
		// Get employee based on id
		Employee employee = employeeDao.getEmployeeById(2);
		
		System.out.println(employee);
		
		((AbstractApplicationContext) context).close();
	}

}
