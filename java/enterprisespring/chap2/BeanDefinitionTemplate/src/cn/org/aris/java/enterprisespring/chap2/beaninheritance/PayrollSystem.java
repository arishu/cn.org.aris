package cn.org.aris.java.enterprisespring.chap2.beaninheritance;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		// As 'indianBean' is defined as abstract,
		// so the following code will result in " 'BeanIsAbstractException': Bean definition is abstract "
//		Employee employeeB = (Employee) context.getBean("indianEmployee");
//		System.out.println(employeeB);
		
		// using child bean 'employeeBean'
		Employee employeeA = (Employee) context.getBean("employeeBean");
		System.out.println(employeeA);
		
		
		((AbstractApplicationContext) context).close();
	}

}
