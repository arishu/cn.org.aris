package cn.org.aris.enterprise.chap1.service;

import org.springframework.stereotype.Service;

@Service
public class GreetingMessageServiceImpl implements GreetingMessageService {

	@Override
	public String greetUser() {
		return "Welcome to Chapter-1 of book Learning\r\n" + 
				"Spring Application Development";
	}

}
