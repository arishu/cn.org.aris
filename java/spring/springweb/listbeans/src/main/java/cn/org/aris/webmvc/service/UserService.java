package cn.org.aris.webmvc.service;

import org.springframework.stereotype.Component;

@Component("userService")
public class UserService {
	public int findNumberOfUsers() {
		return 10;
	}
}
