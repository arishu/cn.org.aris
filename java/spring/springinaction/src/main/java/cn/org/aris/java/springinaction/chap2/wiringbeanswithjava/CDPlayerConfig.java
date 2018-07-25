package cn.org.aris.java.springinaction.chap2.wiringbeanswithjava;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class CDPlayerConfig {
	
	@Bean
	public CompactDisc compactDisc() {
		return new SgtPeppers();
	}
	
	@Bean
	public CDPlayer cdplayer(CompactDisc compactDisc) {
		return new CDPlayer(compactDisc);
	}
}
