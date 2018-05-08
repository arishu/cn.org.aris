package cn.org.aris.json.jackson.converttojsonnode;

import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;
import static org.hamcrest.core.IsEqual.equalTo;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertThat;

import java.io.IOException;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.core.JsonParser;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import cn.org.aris.json.jackson.JacksonExampleTest;

public class MarshallStringToJsonNode extends JacksonExampleTest {
	
	private static final Logger logger = LoggerFactory.getLogger(MarshallStringToJsonNode.class);
	
	/**
	 * Simply use ObjectMapper.readTree method to convert
	 * json string into json node
	 */
	@Test
	public void parseJsonStringToJsonNode_simplyUsingObjectMapper() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append(" \"userName\" : \"xiaohu\", ");
		jsonBuilder.append(" \"password\" : \"123456\" ");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		try {
			JsonNode actualObj = mapper.readTree(jsonBuilder.toString());
			logger.info("Original Json String is: " + jsonBuilder.toString());
			logger.info("The Json node is: " + actualObj.toString());
			logger.info(WINDOWS_NEWLINE);
			assertNotNull(actualObj);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Parsing Json String to Json Node reading content from a Json Parser
	 */
	@Test
	public void parseJsonStringToJsonNode_usingLowLevelApi() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append(" \"userName\" : \"xiaohu\", ");
		jsonBuilder.append(" \"password\" : \"123456\" ");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		try {
			JsonParser parser = mapper.getFactory().createParser(jsonBuilder.toString());
			JsonNode actualObj = mapper.readTree(parser);
			logger.info("Original Json String is: " + jsonBuilder.toString());
			logger.info("The Json Node is: " + actualObj.toString());
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Using Json Node
	 */
	@Test
	public void usingJsonNode() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append(" \"userName\" : \"xiaohu\", ");
		jsonBuilder.append(" \"password\" : \"123456\" ");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		try {
			JsonNode actualObj = mapper.readTree(jsonBuilder.toString());
			JsonNode jsonNodel = actualObj.get("userName");
			assertThat(jsonNodel.textValue(), equalTo("xiaohu"));
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
