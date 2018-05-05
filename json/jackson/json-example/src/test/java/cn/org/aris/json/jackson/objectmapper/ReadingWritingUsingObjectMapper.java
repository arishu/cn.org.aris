package cn.org.aris.json.jackson.objectmapper;

import java.io.File;
import java.io.IOException;
import java.util.List;
import java.util.Map;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.fasterxml.jackson.core.JsonGenerationException;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;

import cn.org.aris.java.log.LogConfig;

import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;

public class ReadingWritingUsingObjectMapper {
	private static Logger logger;
	private static final String resourcesPath;
	
	static {
		LogConfig.setLogPath("json/jackson/json-example/");
		resourcesPath = ReadingWritingUsingObjectMapper.class.getClassLoader().getResource("").getPath().toString();
		logger = LoggerFactory.getLogger(ReadingWritingUsingObjectMapper.class);
	}
	
	/**
	 * Convert Java Object to JSON
	 * @throws JsonGenerationException
	 * @throws JsonMappingException
	 * @throws IOException
	 */
	@Test
	public void java_object_to_json() {
		ObjectMapper mapper = new ObjectMapper();
		Car car = new Car("yellow", "renault");

		try {
			logger.info("Convert Java Object to Json: ");
			mapper.writeValue(new File(resourcesPath + "car.json"), car);
			logger.info("Write to file: " + resourcesPath + "car.json");
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonGenerationException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	/**
	 * Convert Json string to Java Object
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
		
		logger.info("Convert Jason string to Java Object: ");
		logger.info("The Json string to be converted is: " + jsonBuilder.toString());
		ObjectMapper mapper = new ObjectMapper();
		Car car = mapper.readValue(jsonBuilder.toString(), Car.class);
		logger.info("The Converted Java Object is: " + car);
		logger.info(WINDOWS_NEWLINE);
	}
	
	/**
	 * Convert Json to Json Node
	 * @throws IOException
	 */
	@Test
	public void json_to_jsonnode() throws IOException {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		logger.info("Convert json to json node: ");
		logger.info("The json string to be converted is: " + jsonBuilder.toString());
		ObjectMapper mapper = new ObjectMapper();
		JsonNode jsonNode = mapper.readTree(jsonBuilder.toString());
		logger.info("Get Node From Json Node: color=" + jsonNode.get("color").asText());
		logger.info(WINDOWS_NEWLINE);
	}
	
	/**
	 * Convert Json Array to Java List
	 * @throws IOException 
	 * @throws JsonMappingException 
	 * @throws JsonParseException 
	 */
	@Test
	public void json_array_to_java_list() throws JsonParseException, JsonMappingException, IOException {
		StringBuilder jsonArrBuilder = new StringBuilder();
		jsonArrBuilder.append("[");
		jsonArrBuilder.append("{ \"color\" : \"Black\", \"type\" : \"BMW\" }, ");
		jsonArrBuilder.append("{ \"color\" : \"Red\", \"type\" : \"FIAT\" } ");
		jsonArrBuilder.append("]");
		
		String jsonArray = jsonArrBuilder.toString();
		logger.info("Json Array to Java List: ");
		logger.info("Json Array to be converted: " + jsonArray);
		ObjectMapper mapper = new ObjectMapper();
		List<Car> carList = mapper.readValue(jsonArray, new TypeReference<List<Car>>() {});
		
		logger.info("The Java list: " + carList.toString());
		logger.info(WINDOWS_NEWLINE);
	}
	
	/**
	 * Convert JSON String to Java Map
	 * @throws JsonParseException
	 * @throws JsonMappingException
	 * @throws IOException
	 */
	@Test
	public void json_to_java_map() throws JsonParseException, JsonMappingException, IOException {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		String json = jsonBuilder.toString();
		ObjectMapper mapper = new ObjectMapper();
		Map<String, String> map = mapper.readValue(json, new TypeReference<Map<String, String>>() {});
		
		logger.info("Convert Json to Java Map: ");
		logger.info("Json to be converted: " + json);
		logger.info("The map is: " + map);
		logger.info(WINDOWS_NEWLINE);
	}
	
}
