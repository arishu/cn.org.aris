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
		
		employeeDao.deleteEmployee();

		employeeDao.createEmployee();
		
		System.out.println("Employee count: " + employeeDao.getEmployeeCount());
		
		Employee emp = new Employee(1, "James", 28);
		employeeDao.insertEmployee(emp);
		
		Employee employee = employeeDao.getEmployeeById(1);
		System.out.println(employee.getId() + "-" + employee.getName());
		
		System.out.println("delete employee: " + employeeDao.deleteEmployeeById(1));
		
		((AbstractApplicationContext) context).close();
	}

}
