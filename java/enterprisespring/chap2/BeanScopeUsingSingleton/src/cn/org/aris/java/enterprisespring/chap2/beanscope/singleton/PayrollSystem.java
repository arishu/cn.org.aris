package cn.org.aris.java.enterprisespring.chap2.beanscope.singleton;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		// Create a ApplicationContext from an XML file
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");

		// Retrieve for the first time
		EmployeeService employeeServiceA = (EmployeeService) context.getBean("employeeServiceBean");
		employeeServiceA.setMessage("Message by service A");
		System.out.println(employeeServiceA.getMessage());
		
		// Retrieve it again
		EmployeeService employeeServiceB = (EmployeeService) context.getBean("employeeServiceBean");
		System.out.println(employeeServiceB.getMessage());
		
		// Close the context
		((AbstractApplicationContext) context).close();
	}

}
