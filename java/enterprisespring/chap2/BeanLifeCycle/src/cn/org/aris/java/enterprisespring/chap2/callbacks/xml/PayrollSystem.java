package cn.org.aris.java.enterprisespring.chap2.callbacks.xml;

import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		
		ConfigurableApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		XmlEmployeeServiceImpl xmlEmployeeService = (XmlEmployeeServiceImpl) context.getBean("xmlEmployeeServiceBean");
		
		System.out.println(xmlEmployeeService.generateEmployeeID());
		
		context.close();
	}

}
