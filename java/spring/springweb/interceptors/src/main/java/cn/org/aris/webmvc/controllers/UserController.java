package cn.org.aris.webmvc.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class UserController {
	
	@RequestMapping("/user_list")
	public String userList() {
		return "user_list";
	}
}
