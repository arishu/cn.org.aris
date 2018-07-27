package cn.org.aris.webmvc.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import cn.org.aris.webmvc.config.AppConfig;
import cn.org.aris.webmvc.domain.User;

public class Main {

	public static void main(String[] args) {
		try (AnnotationConfigApplicationContext context = 
					new AnnotationConfigApplicationContext(AppConfig.class)) {
			
			User admin = (User) context.getBean("admin");
			
			System.out.println("admin's name: " + admin.getName());
			System.out.println("admin's skill: " + admin.getSkill());
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
