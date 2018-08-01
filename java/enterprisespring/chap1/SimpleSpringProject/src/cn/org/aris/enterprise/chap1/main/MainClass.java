package cn.org.aris.enterprise.chap1.main;

import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.enterprise.chap1.service.GreetingMessageService;

public class MainClass {

	public static void main(String[] args) {
		ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");
		GreetingMessageService greetingMessageService = context
				.getBean("greetingMessageServiceImpl", GreetingMessageService.class);
		
		System.out.println(greetingMessageService.greetUser());
		context.close();
	}

}
