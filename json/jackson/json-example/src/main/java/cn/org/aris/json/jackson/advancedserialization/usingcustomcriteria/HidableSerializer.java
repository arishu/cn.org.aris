package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

import java.io.IOException;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.databind.JsonSerializer;
import com.fasterxml.jackson.databind.SerializerProvider;

/**
 * Custom Serializer
 * @author 50362
 */
public class HidableSerializer extends JsonSerializer<Hidable>{

	private JsonSerializer<Object> defaultSerializer;
	
	public HidableSerializer(JsonSerializer<Object> serializer) {
		defaultSerializer = serializer;
	}
	
	@Override
	public void serialize(Hidable value, JsonGenerator gen, SerializerProvider serializers) throws IOException {
		if (value.isHidden()) {
			return;
		}
		defaultSerializer.serialize(value, gen, serializers);
	}

	@Override
	public boolean isEmpty(SerializerProvider provider, Hidable value) {
		return value == null || value.isHidden();
	}
}
