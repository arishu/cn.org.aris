package cn.org.aris.java.enterprisespring.chap3.JDBC.main;

import java.util.ArrayList;
import java.util.List;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.enterprisespring.chap3.JDBC.dao.EmployeeDaoImpl;
import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public class HrPayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("Spring.xml");
		
		EmployeeDaoImpl employeeDaoImpl = context.getBean("employeeDaoImpl", EmployeeDaoImpl.class);
		
		employeeDaoImpl.deleteEmployee();

		employeeDaoImpl.createEmployee();
		
		System.out.println("Employee count before batch operation: " + employeeDaoImpl.getEmployeeCount());
		
		List<Employee> employeeList = new ArrayList<Employee>();
		Employee employee1 = new Employee(10001, "Ravi");
		Employee employee2 = new Employee(23330, "Kant");
		Employee employee3 = new Employee(12568, "Soni");
		employeeList.add(employee1);
		employeeList.add(employee2);
		employeeList.add(employee3);
		
		employeeDaoImpl.insertEmployees(employeeList);
		
		System.out.println("Employee count after batch operation: " + employeeDaoImpl.getEmployeeCount());
		
		((AbstractApplicationContext) context).close();
	}

}
