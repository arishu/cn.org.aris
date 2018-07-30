package cn.org.aris.webmvc.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.HandlerInterceptor;
import org.springframework.web.servlet.ViewResolver;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;
import org.springframework.web.servlet.config.annotation.InterceptorRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurerAdapter;
import org.springframework.web.servlet.view.InternalResourceViewResolver;
import org.springframework.web.servlet.view.JstlView;

import cn.org.aris.webmvc.interceptors.PerformanceInterceptor;

@Configuration
@EnableWebMvc
@ComponentScan(basePackages = { "cn.org.aris.webmvc.controllers" })
public class AppConfig extends WebMvcConfigurerAdapter {
	
	@Bean
	public ViewResolver jspViewResolver() {
		InternalResourceViewResolver resolver = new InternalResourceViewResolver();
		resolver.setViewClass(JstlView.class);
		resolver.setPrefix("/WEB-INF/jsp/");
		resolver.setSuffix(".jsp");
		return resolver;
	}
	
	@Bean
	public HandlerInterceptor performanceInterceptor() {
		PerformanceInterceptor interceptor;
		interceptor = new PerformanceInterceptor();
		return interceptor;
	}

	@Override
	public void addInterceptors(InterceptorRegistry registry) {
		registry.addInterceptor(performanceInterceptor());
	}
}
