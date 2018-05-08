package cn.org.aris.json.jackson.deserialization;

import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertThat;
import static org.hamcrest.core.IsEqual.equalTo;
import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;

import java.io.IOException;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.databind.DeserializationFeature;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.exc.UnrecognizedPropertyException;

import cn.org.aris.json.jackson.JacksonExampleTest;

public class DeserializationTest extends JacksonExampleTest {
	
	private static Logger logger = LoggerFactory.getLogger(DeserializationTest.class);
	
	/**
	 * Unmarshalling Json with unknown values wiil throw
	 * UnrecognizedPropertyException exception
	 * @throws JsonParseException
	 * @throws JsonMappingException
	 * @throws IOException
	 */
	@Test(expected=UnrecognizedPropertyException.class)
	public void givenJsonHasUnknownValue_whendeserializing_thenException() 
			throws JsonParseException, JsonMappingException, IOException {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"stringValue\" : \"a\", ");
		jsonBuilder.append("\"intValue\" : 1, ");
		jsonBuilder.append("\"booleanValue\" : 1, ");
		jsonBuilder.append("\"stringValue2\" : \"something\" ");
		jsonBuilder.append("}");
		
		
		ObjectMapper mapper = new ObjectMapper();
		logger.info("Unmarshalling Json with unknown value: ");
		logger.info("The Json string is: " + jsonBuilder.toString());
		logger.info("Throwed UnrecognizedPropertyException exception");
		logger.info(WINDOWS_NEWLINE);
		MyDto readValue = mapper.readValue(jsonBuilder.toString(), MyDto.class);
		assertNotNull(readValue);
	}
	
	/**
	 * Allow UnMarshalling JSON string with unknown values
	 * by configuring mapper
	 */
	@Test
	public void givenJsonHasUnknownValuesButJsonIgnoreUnknowns_whenDeserializing_thenCorrect() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"stringValue\" : \"a\", ");
		jsonBuilder.append("\"intValue\" : 1, ");
		jsonBuilder.append("\"booleanValue\" : 1, ");
		jsonBuilder.append("\"stringValue2\" : \"something\" ");
		jsonBuilder.append("}");

		ObjectMapper mapper = new ObjectMapper().configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false);
		logger.info("Unmarshalling Json with unknown value: ");
		logger.info("The Json string is: " + jsonBuilder.toString());
		MyDto readValue;
		try {
			readValue = mapper.readValue(jsonBuilder.toString(), MyDto.class);
			logger.info("The generated object is: " + readValue.toString());
			logger.info(WINDOWS_NEWLINE);
			assertNotNull(readValue);
			assertThat(readValue.getStringValue(), equalTo("a"));
			assertThat(readValue.isBooleanValue(), equalTo(true));
			assertThat(readValue.getIntValue(), equalTo(1));
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * Allow UnMarshalling JSON string with unknown values
	 * by configuring class
	 */
	@Test
	public void givenJsonHasUnknownValuesButIgnoredOnClassLevel_whenDeserializing_thenCorrect() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"stringValue\" : \"a\", ");
		jsonBuilder.append("\"intValue\" : 1, ");
		jsonBuilder.append("\"booleanValue\" : 1, ");
		jsonBuilder.append("\"stringValue2\" : \"something\" ");
		jsonBuilder.append("}");

		ObjectMapper mapper = new ObjectMapper();
		logger.info("Unmarshalling Json with unknown value: ");
		logger.info("The Json string is: " + jsonBuilder.toString());
		MyDtoIgnoreUnknown readValue;
		try {
			readValue = mapper.readValue(jsonBuilder.toString(), MyDtoIgnoreUnknown.class);
			logger.info("The generated object is: " + readValue.toString());
			logger.info(WINDOWS_NEWLINE);
			assertNotNull(readValue);
			assertThat(readValue.getStringValue(), equalTo("a"));
			assertThat(readValue.isBooleanValue(), equalTo(true));
			assertThat(readValue.getIntValue(), equalTo(1));
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * UnMarshalling JSON string with unknown values
	 */
	@Test
	public void givenNotAllFieldsHaveValuesInJson_whenDeserializingAJsonToAClass_thenCorrect() {
		StringBuilder jsonBuilder = new StringBuilder();
		jsonBuilder.append("{");
		jsonBuilder.append("\"stringValue\" : \"a\", ");
		jsonBuilder.append("\"intValue\" : 1 ");
		jsonBuilder.append("}");

		ObjectMapper mapper = new ObjectMapper();
		logger.info("Unmarshalling Json with imcomplete value: ");
		logger.info("The Json string is: " + jsonBuilder.toString());
		try {
			MyDto readValue = mapper.readValue(jsonBuilder.toString(), MyDto.class);
			logger.info("The generated object is: " + readValue.toString());
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonParseException e) {
			e.printStackTrace();
		} catch (JsonMappingException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
