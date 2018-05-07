package cn.org.aris.json.jackson.objectmapper;

import java.io.File;
import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.List;
import java.util.Map;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.fasterxml.jackson.core.JsonGenerationException;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.Version;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.module.SimpleModule;

import cn.org.aris.java.log.LogConfig;

import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;

public class ReadingWritingUsingObjectMapper {
	private static Logger logger;
	private static final String resourcesPath;
	
	static {
		LogConfig.setLogPath("json/jackson/json-example/");
		resourcesPath = ReadingWritingUsingObjectMapper.class.getClassLoader().getResource("").getFile().toString();
		logger = LoggerFactory.getLogger(ReadingWritingUsingObjectMapper.class);
	}
	
	/**
	 * Convert Java Object to JSON
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
	public void json_to_java_object() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		logger.info("Convert Jason string to Java Object: ");
		logger.info("The Json string to be converted is: " + jsonBuilder.toString());
		ObjectMapper mapper = new ObjectMapper();
		Car car;
		try {
			car = mapper.readValue(jsonBuilder.toString(), Car.class);
			logger.info("The Converted Java Object is: " + car.toString());
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Convert Json to Json Node
	 */
	@Test
	public void json_to_jsonnode() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		logger.info("Convert json to json node: ");
		logger.info("The json string to be converted is: " + jsonBuilder.toString());
		ObjectMapper mapper = new ObjectMapper();
		JsonNode jsonNode;
		try {
			jsonNode = mapper.readTree(jsonBuilder.toString());
			logger.info("Get Node From Json Node: color=" + jsonNode.get("color").asText());
			logger.info(WINDOWS_NEWLINE);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Convert Json Array to Java List
	 */
	@Test
	public void json_array_to_java_list() {
		StringBuilder jsonArrBuilder = new StringBuilder();
		jsonArrBuilder.append("[");
		jsonArrBuilder.append("{ \"color\" : \"Black\", \"type\" : \"BMW\" }, ");
		jsonArrBuilder.append("{ \"color\" : \"Red\", \"type\" : \"FIAT\" } ");
		jsonArrBuilder.append("]");
		
		String jsonArray = jsonArrBuilder.toString();
		logger.info("Json Array to Java List: ");
		logger.info("Json Array to be converted: " + jsonArray);
		ObjectMapper mapper = new ObjectMapper();
		List<Car> carList;
		try {
			carList = mapper.readValue(jsonArray, new TypeReference<List<Car>>() {});
			logger.info("The Java list: " + carList.toString());
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Convert Json Array to Java Array
	 */
	@Test
	public void json_array_to_java_array() {
		StringBuilder jsonArrBuilder = new StringBuilder();
		jsonArrBuilder.append("[");
		jsonArrBuilder.append("{ \"color\" : \"Black\", \"type\" : \"BMW\" }, ");
		jsonArrBuilder.append("{ \"color\" : \"Red\", \"type\" : \"FIAT\" } ");
		jsonArrBuilder.append("]");
		
		String jsonArray = jsonArrBuilder.toString();
		logger.info("Json Array to Java List: ");
		logger.info("Json Array to be converted: " + jsonArray);
		ObjectMapper mapper = new ObjectMapper();
		
		Car[] cars;
		try {
			mapper.configure(DeserializationFeature.USE_JAVA_ARRAY_FOR_JSON_ARRAY, true);
			cars = mapper.readValue(jsonArray, Car[].class);
			logger.info("The car array is: ");
			short index = (short)0;
			for (Car car: cars) {
				logger.info("Car " + (index++) + ": " + car.toString());
			}
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Convert JSON String to Java Map
	 */
	@Test
	public void json_to_java_map() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\"");
		jsonBuilder.append("}");
		
		String json = jsonBuilder.toString();
		ObjectMapper mapper = new ObjectMapper();
		Map<String, String> map;
		try {
			map = mapper.readValue(json, new TypeReference<Map<String, String>>() {});
			logger.info("Convert Json to Java Map: ");
			logger.info("Json to be converted: " + json);
			logger.info("The map is: " + map);
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Control if Unknown properties are allowed to be serialized
	 */
	@Test
	public void feture_configuration_when_deserialization() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"color\": \"Black\",");
		jsonBuilder.append("\"type\": \"BMW\", ");
		jsonBuilder.append("\"year\": 2017");
		jsonBuilder.append("}");
		
		ObjectMapper mapper = new ObjectMapper();
		mapper.configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
		try {
			String jsonString = jsonBuilder.toString();
			JsonNode jsonNodeRoot = mapper.readTree(jsonString);
			String year = jsonNodeRoot.get("year").asText();
			logger.info("Original Json String: " + jsonString);
			logger.info("Get value from parsed json node: year=" + year);
			logger.info(WINDOWS_NEWLINE);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	/**
	 * Using custom serializer
	 */
	@Test
	public void using_custom_serializer() {
		ObjectMapper mapper = new ObjectMapper();
		
		// create a module
		SimpleModule module = new SimpleModule("CustomCarSerializer", 
				new Version(1, 0, 0, null, null, null));
		// add serializer class to the module
		module.addSerializer(Car.class, new CustomCarSerializer());
		
		// register module using mapper
		mapper.registerModule(module);
		
		try {
			Car car = new Car("yellow", "BUILK");
			String carJson = mapper.writeValueAsString(car);
			logger.info("Java Object is: " + car.toString());
			logger.info("Json string using custom serializer: " + carJson);
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
	
	
	/**
	 * Format date configuration in object mapper
	 */
	@Test
	public void handle_data_format_using_objectmapper() {
		ObjectMapper mapper = new ObjectMapper();
		DateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		mapper.setDateFormat(df);
		Request request = new Request(new Car("Black", "BMW"),  Calendar.getInstance().getTime());
		try {
			String jsonString = mapper.writeValueAsString(request);
			logger.info("The request object is: " + request.toString());
			logger.info("The json string: " + jsonString);
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
}
