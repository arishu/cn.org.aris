package cn.org.aris.java.springmvc.webstore.config;

import java.util.ArrayList;
import java.util.Locale;

import org.springframework.context.MessageSource;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.support.ReloadableResourceBundleMessageSource;
import org.springframework.context.support.ResourceBundleMessageSource;
import org.springframework.oxm.jaxb.Jaxb2Marshaller;
import org.springframework.web.accept.ContentNegotiationManager;
import org.springframework.web.multipart.commons.CommonsMultipartResolver;
import org.springframework.web.servlet.LocaleResolver;
import org.springframework.web.servlet.View;
import org.springframework.web.servlet.ViewResolver;
import org.springframework.web.servlet.config.annotation.DefaultServletHandlerConfigurer;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;
import org.springframework.web.servlet.config.annotation.InterceptorRegistry;
import org.springframework.web.servlet.config.annotation.PathMatchConfigurer;
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurerAdapter;
import org.springframework.web.servlet.i18n.CookieLocaleResolver;
import org.springframework.web.servlet.i18n.LocaleChangeInterceptor;
import org.springframework.web.servlet.i18n.SessionLocaleResolver;
import org.springframework.web.servlet.view.ContentNegotiatingViewResolver;
import org.springframework.web.servlet.view.InternalResourceViewResolver;
import org.springframework.web.servlet.view.JstlView;
import org.springframework.web.servlet.view.json.MappingJackson2JsonView;
import org.springframework.web.servlet.view.xml.MarshallingView;
import org.springframework.web.util.UrlPathHelper;

import cn.org.aris.java.springmvc.webstore.domain.Product;
import cn.org.aris.java.springmvc.webstore.interceptor.ProcessingTimeLogInterceptor;
import cn.org.aris.java.springmvc.webstore.interceptor.SecurityInterceptor;

@Configuration
@EnableWebMvc
@ComponentScan("cn.org.aris.java.springmvc.webstore")
public class WebApplicationContextConfig extends WebMvcConfigurerAdapter {

	@Override
	public void configureDefaultServletHandling(DefaultServletHandlerConfigurer configurer) {
		configurer.enable();
	}

	@Bean
	public InternalResourceViewResolver getInternalResourceViewResolver() {
		InternalResourceViewResolver resolver = new InternalResourceViewResolver("/WEB-INF/views/", ".jsp");

		resolver.setViewClass(JstlView.class);
		return resolver;
	}

	/**
	 * Add Static Resources Support
	 */
	@Override
	public void addResourceHandlers(ResourceHandlerRegistry registry) {
		registry.addResourceHandler("/img/**", "/pdf/**").addResourceLocations("/resources/images/",
				"/resources/product/manuals/");
	}

	@Override
	public void configurePathMatch(PathMatchConfigurer configurer) {
		UrlPathHelper urlPathHelper = new UrlPathHelper();
		urlPathHelper.setRemoveSemicolonContent(false);
		configurer.setUrlPathHelper(urlPathHelper);
	}



	/**
	 * Add Multipart Request support
	 * 
	 * @return
	 */
	@Bean
	public CommonsMultipartResolver multipartResolver() {
		CommonsMultipartResolver resolver = new CommonsMultipartResolver();
		resolver.setDefaultEncoding("utf-8");

		// set max upload size to 10MB
		resolver.setMaxUploadSize(10240000);
		return resolver;
	}

	/**
	 * 
	 * @return
	 */
	@Bean
	public MappingJackson2JsonView jsonView() {
		MappingJackson2JsonView jsonView = new MappingJackson2JsonView();
		jsonView.setPrettyPrint(true);
		return jsonView;
	}

	/**
	 * 
	 * @return
	 */
	@Bean
	public MarshallingView xmlView() {
		Jaxb2Marshaller marshaller = new Jaxb2Marshaller();
		marshaller.setClassesToBeBound(Product.class);
		MarshallingView xmlView = new MarshallingView(marshaller);
		return xmlView;
	}

	@Bean
	public ViewResolver contentNegotiaingViewResolver(ContentNegotiationManager manager) {
		ContentNegotiatingViewResolver resolver = new ContentNegotiatingViewResolver();
		resolver.setContentNegotiationManager(manager);
		ArrayList<View> views = new ArrayList<View>();
		views.add(jsonView());
		views.add(xmlView());
		resolver.setDefaultViews(views);
		return resolver;
	}

	
	/**
	 * Add External message Support
	 */
	@Bean
	public MessageSource messageSource() {
		ResourceBundleMessageSource resource = new ResourceBundleMessageSource();
		resource.setBasename("/i18n/messages");
		resource.setDefaultEncoding("UTF-8");
		return resource;
	}

	/**
	 * Add Locale support
	 */
	@Bean
	public LocaleResolver localeResolver() {
		// Use Session to save User's Locale
		SessionLocaleResolver localeResolver = new SessionLocaleResolver();
		localeResolver.setDefaultLocale(new Locale("en"));
		
		// Use Cookie to save User's Locale
//		CookieLocaleResolver localeResolver = new CookieLocaleResolver();
//		localeResolver.setDefaultLocale(Locale.ENGLISH);
//		localeResolver.setCookieName("my-locale-cookie");
//		localeResolver.setCookieMaxAge(3600);
		
		return localeResolver;
	}
	
	/**
	 * Configure LocaleChangeInterceptor
	 */
	@Bean
	public LocaleChangeInterceptor localeIntercepter() {
		LocaleChangeInterceptor localeChangeInterceptor = new LocaleChangeInterceptor();
		localeChangeInterceptor.setParamName("lang");
		return localeChangeInterceptor;
	}
	
	
	/**
	 * Registry an interceptor to InterceptorRegistry
	 */
	@Override
	public void addInterceptors(InterceptorRegistry registry) {
		registry.addInterceptor(new ProcessingTimeLogInterceptor());
		registry.addInterceptor(new SecurityInterceptor());

		// Add into InterceptorRegistry
		registry.addInterceptor(localeIntercepter());
	}

}
