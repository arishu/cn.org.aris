package cn.org.aris.java.enterprisespring.chap2.setterinjection;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext();
		
		EmployeeService employeeService = (EmployeeService) context.getBean("employeeServiceBean");
		System.out.println(employeeService);
		
		((AbstractApplicationContext) context).close();
	}

}
