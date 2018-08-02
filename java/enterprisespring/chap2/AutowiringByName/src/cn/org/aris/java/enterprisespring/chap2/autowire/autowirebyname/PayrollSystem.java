package cn.org.aris.java.enterprisespring.chap2.autowire.autowirebyname;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		EmployeeService employeeService = (EmployeeService) context.getBean("employeeServiceBean");
		
		System.out.println(employeeService.getEmployee());
		
		((AbstractApplicationContext) context).close();
	}

}
