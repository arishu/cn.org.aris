package cn.org.aris.java.springinaction.chap3.runtimevalueinjection;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.PropertySource;
import org.springframework.core.env.Environment;

@Configuration
@PropertySource("classpath:/META-INF/spring/chap3/app.properties")
public class EnvironmentConfigWithDefaults {
	
	@Autowired
	Environment env;
	
	@Bean
	public BlankDisc disc() {
		return new BlankDisc(env.getProperty("disc.title", "Rattle an Hum"), env.getProperty("disc.artist", "U2"));
	}
}
