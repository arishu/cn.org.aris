package cn.org.aris.java.enterprisespring.mail;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class MailerTest {
	
	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("Spring.xml");		
		
		EmailService emailService = (EmailService) context.getBean("emailService");
		
		emailService.sendEmail("1729116521@qq.com", 
				"Spring XML Test", "This a test email from Spring email");
	
		((AbstractApplicationContext) context).close();
	}
	
}
