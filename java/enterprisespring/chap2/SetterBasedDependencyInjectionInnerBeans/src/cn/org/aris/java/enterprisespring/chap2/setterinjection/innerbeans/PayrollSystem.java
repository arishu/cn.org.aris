package cn.org.aris.java.enterprisespring.chap2.setterinjection.innerbeans;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class PayrollSystem {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		
		ATM atm = (ATM) context.getBean("atmBean");
		atm.printBalance("100");
		
		((AbstractApplicationContext) context).close();
	}

}
