package cn.org.aris.json.jackson.objectmapper;

import java.io.File;
import java.io.IOException;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.fasterxml.jackson.core.JsonGenerationException;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;

public class ReadingWritingUsingObjectMapper {
	private static Logger logger = LoggerFactory.getLogger(ReadingWritingUsingObjectMapper.class);
	private static final String resourcesPath;
	
	static {
		resourcesPath = ReadingWritingUsingObjectMapper.class.getClassLoader().getResource("").toString();
	}
	
	/**
	 * Testing Java Object to JSON
	 * @throws JsonGenerationException
	 * @throws JsonMappingException
	 * @throws IOException
	 */
	@Test
	public void java_object_to_json() throws JsonGenerationException, JsonMappingException, IOException {
		ObjectMapper mapper = new ObjectMapper();
		Car car = new Car("yellow", "renault");
		mapper.writeValue(new File(resourcesPath + "target/car.json"), car);
	}
	
	
	/**
	 * Testing Json string to Java Object
	 * @throws JsonParseException
	 * @throws JsonMappingException
	 * @throws IOException
	 */
	@Test
	public void json_to_java_object() throws JsonParseException, JsonMappingException, IOException {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		Car car = mapper.readValue(jsonBuilder.toString(), Car.class);
		
		System.out.println(car);
	}
	
	/**
	 * Testing Json to Json Node
	 * @throws IOException
	 */
	@Test
	public void json_to_jsonnode() throws IOException {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		JsonNode jsonNode = mapper.readTree(jsonBuilder.toString());
		
		System.out.println(jsonNode.get("color").asText());
	}
	
	@Test
	public void json_array_to_java_list() {
		StringBuilder jsonArrBuilder = new StringBuilder();
		jsonArrBuilder.append("[");
		jsonArrBuilder.append("{ \"color\" : \"Black\", \"type\" : \"BMW\" } ");
		jsonArrBuilder.append("{ \"color\" : \"Red\", \"type\" : \"FIAT\" } ");
		jsonArrBuilder.append("]");
		
		
	}
}
