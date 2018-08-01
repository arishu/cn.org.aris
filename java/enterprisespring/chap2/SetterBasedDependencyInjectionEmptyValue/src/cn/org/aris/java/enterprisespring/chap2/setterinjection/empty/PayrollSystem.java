package cn.org.aris.java.enterprisespring.chap2.setterinjection.empty;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		Employee employeeService = (Employee) context.getBean("employeeBean");
		System.out.println("Employee Name: " + employeeService.getEmployeeName());
		System.out.println("Employee Dept: " + employeeService.getEmployeeDept());
		
		((AbstractApplicationContext) context).close();
	}

}
