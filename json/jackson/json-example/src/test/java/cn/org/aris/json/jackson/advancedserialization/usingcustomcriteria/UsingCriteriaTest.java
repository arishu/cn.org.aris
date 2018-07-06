package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

import static org.junit.Assert.assertThat;

import java.util.Arrays;

import org.junit.Test;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import static org.hamcrest.core.IsNot.not;
import static org.hamcrest.core.StringContains.containsString;
import static cn.org.aris.java.common.Consants.WINDOWS_NEWLINE;

import com.fasterxml.jackson.annotation.JsonInclude.Include;
import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.BeanDescription;
import com.fasterxml.jackson.databind.JsonSerializer;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationConfig;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.module.SimpleModule;
import com.fasterxml.jackson.databind.ser.BeanPropertyWriter;
import com.fasterxml.jackson.databind.ser.BeanSerializerModifier;
import com.fasterxml.jackson.databind.ser.FilterProvider;
import com.fasterxml.jackson.databind.ser.PropertyFilter;
import com.fasterxml.jackson.databind.ser.PropertyWriter;
import com.fasterxml.jackson.databind.ser.impl.SimpleBeanPropertyFilter;
import com.fasterxml.jackson.databind.ser.impl.SimpleFilterProvider;

import cn.org.aris.json.jackson.JacksonExampleTest;

public class UsingCriteriaTest extends JacksonExampleTest {
	
	private static final Logger logger = LoggerFactory.getLogger(UsingCriteriaTest.class);
	
	/**
	 * Serialization using custom filter
	 */
	@Test
	public void serialization_using_custom_filter() {
		
		// create a filter
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
		
		// add filter to a filter provider
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
	 * Skip Object Conditionally
	 */
	@Test
	public void usingHidableClass() {
		logger.info("Try to serialize hidable class: ");
		ObjectMapper mapper = new ObjectMapper();
		try {
			// First case, Nothing is hidden
			Person person = new Person("hwc", new Address("ShangHai", "China"));
			logger.info("Nothing is hidden: " + person.toString());
			String jsonAsString = mapper.writeValueAsString(person);
			logger.info("The generated json string is: " + jsonAsString);
			logger.info(WINDOWS_NEWLINE);
			
			// Second Case, only address is hidden
			person = new Person("John", new Address("NY", "USA", true), false);
			logger.info("Only address is hidden: " + person.toString());
			jsonAsString = mapper.writeValueAsString(person);
			logger.info("The generated json string is: " + jsonAsString);
			logger.info(WINDOWS_NEWLINE);

			// Third Case, entire person is hidden
			
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
	
	/**
	 * 
	 */
	@Test
	public void usingBeanSerializerModifier() {
		ObjectMapper mapper = new ObjectMapper();
		mapper.setSerializationInclusion(Include.NON_EMPTY);
		mapper.registerModule(new SimpleModule() {
			private static final long serialVersionUID = 8047161677692505749L;
			@Override
			public void setupModule(SetupContext context) {
				super.setupModule(context);
				context.addBeanSerializerModifier(new BeanSerializerModifier() {
					@SuppressWarnings("unchecked")
					@Override
					public JsonSerializer<?> modifySerializer(SerializationConfig config, BeanDescription beanDesc,
							JsonSerializer<?> serializer) {
						if (Hidable.class.isAssignableFrom(beanDesc.getBeanClass())) {
							return new HidableSerializer((JsonSerializer<Object>) serializer);
						}
						return serializer;
					}
				});
			}
		});
		
		Address ad1 = new Address("Tokyo", "jp", true);
		Address ad2 = new Address("London", "UK", false);
		Address ad3 = new Address("NY", "USA", false);
		
		Person p1 = new Person("John", ad1, false);
		Person p2 = new Person("Tom", ad2, true);
		Person p3 = new Person("Adam", ad3, false);
		
		try {
			String jsonAsString = mapper.writeValueAsString(Arrays.asList(p1, p2, p3));
			logger.info("The generated json string is: " + jsonAsString);
			logger.info(WINDOWS_NEWLINE);
		} catch (JsonProcessingException e) {
			e.printStackTrace();
		}
	}
}
;
