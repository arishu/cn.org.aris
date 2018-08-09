package cn.org.aris.java.enterprisespring.jms.main;

import java.util.HashMap;
import java.util.Map;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.enterprisespring.jms.message.MessageReceiver;
import cn.org.aris.java.enterprisespring.jms.message.MessageSender;

public class App {

	public static void main(String[] args) {
		
		ApplicationContext context = new ClassPathXmlApplicationContext("Spring.xml");
		
		MessageSender messageSender = (MessageSender) context.getBean("messageSender");
		
		Map<String, String> message = new HashMap<String, String>();
		message.put("Hello", "World");
		message.put("city", "Sasaram");
		message.put("state", "Bihar");
		message.put("country", "India");
		
		messageSender.send(message);
		System.out.println("Message Sent to JMS Queue: " + message);
		
		
		MessageReceiver messageReceiver = (MessageReceiver) context.getBean("messageReceiver");
		messageReceiver.receive();
		
		((AbstractApplicationContext) context).close();
	}

}
