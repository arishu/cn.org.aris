package cn.org.aris.java.springinaction.chap3.environmentsandprofiles;

import javax.activation.DataSource;

import org.apache.commons.dbcp2.BasicDataSource;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Profile;

@Configuration
@Profile("qa")
public class QaProfileConfig {
	@Bean
	public DataSource dataSource() {
		BasicDataSource dataSource = new BasicDataSource();
		dataSource.setDriverClassName("org.h2.Driver");
		dataSource.setUrl("jdbc:h2:~/test");
		dataSource.setUsername("sa");
		dataSource.setPassword("password");
		dataSource.setInitialSize(20);
		dataSource.setMaxTotal(30);
		return (DataSource) dataSource;
	}
}
