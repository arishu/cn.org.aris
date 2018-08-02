package cn.org.aris.java.enterprisespring.chap2.callbacks;

import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		ConfigurableApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		EmployeeService employeeService = (EmployeeService) context.getBean("employeeServiceBean");
		
		System.out.println(employeeService.generateEmployeeID());
		
		context.close();
	}

}
