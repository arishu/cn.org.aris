package cn.org.aris.json.jackson.objectmapper;

import java.io.IOException;

import com.fasterxml.jackson.core.JsonParser;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.ObjectCodec;
import com.fasterxml.jackson.databind.DeserializationContext;
import com.fasterxml.jackson.databind.JsonNode;
import com.fasterxml.jackson.databind.deser.std.StdDeserializer;

public class CustomCarDeserializer extends StdDeserializer<Car> {

	private static final long serialVersionUID = 7175171748008873812L;

	public CustomCarDeserializer() {
		this(null);
	}
	
	protected CustomCarDeserializer(Class<?> vc) {
		super(vc);
	}

	@Override
	public Car deserialize(JsonParser parser, DeserializationContext ctxt) throws IOException, JsonProcessingException {
		Car car = new Car();
		
		// Get codec from JSON parser
		ObjectCodec codec = parser.getCodec();
		// Create a JSON node using codec
		JsonNode node = codec.readTree(parser);
		String color = node.asText();
		car.setColor(color);
		return car;
	}

}
