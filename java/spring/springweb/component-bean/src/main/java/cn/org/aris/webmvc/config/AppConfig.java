package cn.org.aris.webmvc.config;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;

@Configuration
@EnableWebMvc
@ComponentScan(basePackages = { "cn.org.aris.webmvc.controller", "cn.org.aris.webmvc.service" })
public class AppConfig {
}
