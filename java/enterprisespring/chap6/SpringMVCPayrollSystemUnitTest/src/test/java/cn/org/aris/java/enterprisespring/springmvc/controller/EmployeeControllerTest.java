package cn.org.aris.java.enterprisespring.springmvc.controller;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;

import org.junit.Test;
import org.springframework.ui.ModelMap;

public class EmployeeControllerTest {

	@Test
	public void testWelcomeEmployee() {
		EmployeeController controller = new EmployeeController();
		ModelMap modelMap = new ModelMap();
		String view = controller.welcocmeEmployee(modelMap);
		
		assertNotNull(view);
		assertEquals("hello", view);
		
		// Verify page title
		String titlename = modelMap.get("name").toString();
		assertEquals("Hello World", titlename);
		
		// Verify message
		String greetings = modelMap.get("greetings").toString();
		assertEquals("Welcome to Packt Publishing - Spring MVC !!!", greetings);
		
	}
	
}
