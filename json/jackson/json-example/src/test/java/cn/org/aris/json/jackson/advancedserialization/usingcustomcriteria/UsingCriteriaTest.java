package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

import static org.junit.Assert.assertThat;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import static org.hamcrest.core.IsNot.not;
import static org.hamcrest.core.StringContains.containsString;
import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.ser.BeanPropertyWriter;
import com.fasterxml.jackson.databind.ser.FilterProvider;
import com.fasterxml.jackson.databind.ser.PropertyFilter;
import com.fasterxml.jackson.databind.ser.PropertyWriter;
import com.fasterxml.jackson.databind.ser.impl.SimpleBeanPropertyFilter;
import com.fasterxml.jackson.databind.ser.impl.SimpleFilterProvider;

import cn.org.aris.json.jackson.JacksonExampleTest;

public class UsingCriteriaTest extends JacksonExampleTest {
	
	private static final Logger logger = LoggerFactory.getLogger(UsingCriteriaTest.class);
	
	/**
	 * 
	 */
	@Test
	public void serialization_using_custom_filter() {
		
		// create a filter and add it to a filter provider
		PropertyFilter theFilter = new SimpleBeanPropertyFilter() {
			@Override
			protected boolean include(BeanPropertyWriter writer) {
				return true;
			}

			@Override
			protected boolean include(PropertyWriter writer) {
				return true;
			}

			@Override
			public void serializeAsField(Object pojo, JsonGenerator jgen, SerializerProvider provider,
					PropertyWriter writer) throws Exception {
				if (include(writer)) {
					if (!writer.getName().equals("intValue")) {
						writer.serializeAsField(pojo, jgen, provider);
						return;
					}
					
					int intValue = ((MyDtoWithFilter)pojo).getIntValue();
					if (intValue >= 0) {
						writer.serializeAsField(pojo, jgen, provider);
					}
				} else if (!jgen.canOmitFields()) { // since 2.3
					writer.serializeAsOmittedField(pojo, jgen, provider);
				}
			}
		};
		FilterProvider filters = new SimpleFilterProvider().addFilter("myFilter", theFilter);
		
		MyDtoWithFilter dtoObject = new MyDtoWithFilter();
		dtoObject.setIntValue(-1);
		ObjectMapper mapper = new ObjectMapper();
		try {
			// configure mapper's writer with the filter provider
			String dtoAsString = mapper.writer(filters).writeValueAsString(dtoObject);
			logger.info("serialization using custom filter:");
			logger.info("The generated json string is: " + dtoAsString);
			logger.info(WINDOWS_NEWLINE);
			assertThat(dtoAsString, not(containsString("intValue")));
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * 
	 */
	@Test
	public void usingHidableClass() {
		Person person = new Person("hwc", new Address("ShangHai", "China"));
		ObjectMapper mapper = new ObjectMapper();
		try {
			logger.info("Try to serialize hidable class: ");
			logger.info("The Object is: " + person.toString());
			String jsonAsString = mapper.writeValueAsString(person);
			logger.info("The generated json string is: " + jsonAsString);
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
}
