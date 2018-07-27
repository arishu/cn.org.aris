package cn.org.aris.webmvc.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import cn.org.aris.webmvc.domain.User;

@Configuration
public class AppConfig {
	
	@Bean
	public User admin() {
		User u = new User();
		u.setName("Aris");
		u.setSkill("Java Programming");
		return u;
	}
}
