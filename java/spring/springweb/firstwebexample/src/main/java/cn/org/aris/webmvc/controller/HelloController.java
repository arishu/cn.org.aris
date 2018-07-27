package cn.org.aris.webmvc.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller
public class HelloController {

	@RequestMapping("hi")
	@ResponseBody
	public String hello() {
		return "Hello World";
	}
}
