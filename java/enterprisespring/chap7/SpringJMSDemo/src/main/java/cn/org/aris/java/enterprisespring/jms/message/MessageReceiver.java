package cn.org.aris.java.enterprisespring.jms.message;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.stereotype.Component;

@Component
public class MessageReceiver {

	@Autowired
	private JmsTemplate jmsTemplate;
	
	public void receive() {
		System.out.println(jmsTemplate.receiveAndConvert());
	}
}
