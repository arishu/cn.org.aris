package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Knight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.Quest;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection.BraveKnight;
import cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.dependencyinjection.SlayDragonQuest;

@Configuration
public class KnightConfig {
	
	/*@Bean
	public Knight knight() {
		return new BraveKnight(quest());
	}

	@Bean
	private Quest quest() {
		return new SlayDragonQuest(System.out);
	}*/
	
	
}
