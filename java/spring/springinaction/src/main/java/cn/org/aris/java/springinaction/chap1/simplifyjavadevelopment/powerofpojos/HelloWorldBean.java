package cn.org.aris.java.springinaction.chap1.simplifyjavadevelopment.powerofpojos;

/**
 * A Simple POJO
 * Spring doesn't make any 
 * unreasonable demands on this class
 * @author 50362
 *
 */
public class HelloWorldBean {
	
	@SuppressWarnings("unused")
	private String sayHello() {
		return "Hello World";
	}
	
}
