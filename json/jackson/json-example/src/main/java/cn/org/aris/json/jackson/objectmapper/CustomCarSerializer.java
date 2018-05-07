package cn.org.aris.json.jackson.objectmapper;

import java.io.IOException;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.ser.std.StdSerializer;

/**
 * Custom Serializer
 * @author hwc
 */
public class CustomCarSerializer extends StdSerializer<Car> {
	
	private static final long serialVersionUID = -3879451867955712588L;

	public CustomCarSerializer() {
		this(null);
	}
	
	public CustomCarSerializer(Class<Car> t) {
		super(t);
	}

	@Override
	public void serialize(Car car, JsonGenerator gen, SerializerProvider provider) throws IOException {
		gen.writeStartObject();
		gen.writeStringField("car_brand", car.getType());
		gen.writeEndObject();
	}

}
