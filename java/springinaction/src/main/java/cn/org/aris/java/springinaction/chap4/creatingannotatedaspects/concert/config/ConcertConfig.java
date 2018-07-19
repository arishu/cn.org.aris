package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

import cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Audience;

@Configuration
@ComponentScan(basePackages="cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert")
@EnableAspectJAutoProxy
public class ConcertConfig {
	
	@Bean
	public Audience audience() {
		return new Audience();
	}
	
}
