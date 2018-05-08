package cn.org.aris.json.jackson;

import cn.org.aris.java.log.LogConfig;

public class JacksonExampleTest {
	
	protected static final String resources;
	
	static {
		resources = JacksonExampleTest.class.getClassLoader().getResource("").getFile().toString();
		LogConfig.setLogPath("json/jackson/json-example/");
	}
}
