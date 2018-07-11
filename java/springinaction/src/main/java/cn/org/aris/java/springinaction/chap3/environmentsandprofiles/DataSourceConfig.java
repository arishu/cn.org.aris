package cn.org.aris.java.springinaction.chap3.environmentsandprofiles;

import javax.activation.DataSource;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Profile;
import org.springframework.jdbc.datasource.embedded.EmbeddedDatabaseBuilder;
import org.springframework.jdbc.datasource.embedded.EmbeddedDatabaseType;
import org.springframework.jndi.JndiObjectFactoryBean;

@Configuration
public class DataSourceConfig {

	@Bean
	@Profile("dev")		// Wired for “dev” profile(给开发环境下的profile进行装配)
	public DataSource embeddedDataSource() {
		return (DataSource) new EmbeddedDatabaseBuilder()
				.setType(EmbeddedDatabaseType.H2)
				.addScript("classpath:META_INF/spring/chap3/schema.sql")
				.addScript("classpath:META_INF/spring/chap3/test-data.sql")
				.build();
	}
	
	
	@Bean
	@Profile("prod")	// Wired for “prod” profile(给生产环境下的profile进行装配)
	public DataSource jndiDataSource() {
		JndiObjectFactoryBean jndiObjectFactoryBean = new JndiObjectFactoryBean();
		jndiObjectFactoryBean.setJndiName("jdbc.myDS");
		jndiObjectFactoryBean.setResourceRef(true);
		jndiObjectFactoryBean.setProxyInterface(javax.sql.DataSource.class);
		return (DataSource) jndiObjectFactoryBean.getObject(); 
	}
}
