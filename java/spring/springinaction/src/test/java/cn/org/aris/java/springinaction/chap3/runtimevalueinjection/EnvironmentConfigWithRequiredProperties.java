package cn.org.aris.java.springinaction.chap3.runtimevalueinjection;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.env.Environment;

@Configuration
public class EnvironmentConfigWithRequiredProperties {
	
	@Autowired
	Environment env;
	
	@Bean
	public BlankDisc blanDisc() {
		return new BlankDisc(
			env.getProperty("disc.length"),
			env.getProperty("disc.comment")
		);
	}
}
