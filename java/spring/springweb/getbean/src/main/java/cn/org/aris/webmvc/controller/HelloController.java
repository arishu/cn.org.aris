package cn.org.aris.webmvc.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.ApplicationContext;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import cn.org.aris.webmvc.service.UserService;

@Controller
public class HelloController {
	
	@Autowired
	private ApplicationContext applicationContext;
	
	@RequestMapping("hi")
	@ResponseBody
	public String hi() {
		UserService userService = applicationContext.getBean(UserService.class);
//		UserService userService = (UserService) applicationContext.getBean("userService");
		return "Val: " + userService.findNumberOfUsers();
	}
	
}
