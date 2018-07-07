package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.aspectapplying;

import org.springframework.context.support.ClassPathXmlApplicationContext;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Knight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.QuestException;

public class KnightMain {

	public static void main(String[] args) throws QuestException {

		ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("META-INF/spring/minstrel.xml");

		Knight knight = context.getBean(Knight.class);

		knight.embarkOnQuest();

		context.close();
	}

}
