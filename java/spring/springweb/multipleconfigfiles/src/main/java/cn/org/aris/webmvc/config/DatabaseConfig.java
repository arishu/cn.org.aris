package cn.org.aris.webmvc.config;

import javax.sql.DataSource;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.jdbc.datasource.DriverManagerDataSource;

@Configuration
public class DatabaseConfig {

	@Bean
	public DataSource dataSource() {
		DriverManagerDataSource dataSource = new DriverManagerDataSource();
		
		// we have to use 'com.mysql.cj.jdbc.Driver' in new version of mysql-connector
		// while in old version of mysql-connector, we can use 'com.mysql.jdbc.Driver'
		dataSource.setDriverClassName("com.mysql.cj.jdbc.Driver");
//		dataSource.setDriverClassName("com.mysql.jdbc.Driver");
		dataSource.setUrl("jdbc:mysql://localhost:3306/springdb");
		dataSource.setUsername("root");
		dataSource.setPassword("mingyi");
		return dataSource;
	}
}
