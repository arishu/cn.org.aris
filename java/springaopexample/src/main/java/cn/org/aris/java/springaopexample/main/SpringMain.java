package cn.org.aris.java.springaopexample.main;

import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.springaopexample.service.EmployeeService;

public class SpringMain {

	public static void main(String[] args) {
		ClassPathXmlApplicationContext ctx = new 
				ClassPathXmlApplicationContext("spring.xml");
		
		EmployeeService employeeService = ctx
				.getBean("employeeService", EmployeeService.class);
		
		System.out.println(employeeService.getEmployee().getName());
		
		employeeService.getEmployee().setName("Aris");
		employeeService.getEmployee().throwException();
		
		ctx.close();
		
	}

}
