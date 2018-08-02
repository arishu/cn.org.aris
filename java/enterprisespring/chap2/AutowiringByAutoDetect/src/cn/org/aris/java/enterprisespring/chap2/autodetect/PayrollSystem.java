package cn.org.aris.java.enterprisespring.chap2.autodetect;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

/**
 * Doesn't work, need to be fixed
 * @author hwc
 *
 */
public class PayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		EmployeeService employeeService = context.getBean("employeeService", EmployeeService.class);
		System.out.println(employeeService);
		
		((AbstractApplicationContext) context).close();
	}

}
