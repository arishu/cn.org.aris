package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection;

import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Knight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.QuestException;

public class KnightMain {

	public static void main(String[] args) throws QuestException {
		// Loading Spring Application context
		ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("META-INF/spring/knight.xml");
		
		// Get 'knight' bean from the Spring container
		Knight knight = context.getBean(Knight.class);
		
		// Use 'knight' bean
		knight.embarkOnQuest();
		
		// Close the Application context
		context.close();
	}

}
