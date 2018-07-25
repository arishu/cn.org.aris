package cn.org.aris.java.springinaction.chap3.environmentsandprofiles;

import javax.activation.DataSource;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Profile;
import org.springframework.jdbc.datasource.embedded.EmbeddedDatabaseBuilder;
import org.springframework.jdbc.datasource.embedded.EmbeddedDatabaseType;

@Configuration
@Profile("dev")
public class DevelopmentProfileConfig {
	
	@Bean(destroyMethod="shoutdown")
	public DataSource dataSource() {
		return (DataSource) new EmbeddedDatabaseBuilder()
				.setType(EmbeddedDatabaseType.H2)		// database type
				.addScript("classpath:schema.sql")		// database schema sql
				.addScript("classpath:test-data.sql")	// database initial data for testing
				.build();
	}
}
