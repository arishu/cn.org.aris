package cn.org.aris.json.jackson.annotations.serialization;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonInclude.Include;

/**
 * Using @JsonInclude to include specific field 
 * @author hwc
 */
@JsonInclude(Include.NON_NULL)
public class MyDtoIgnoreNullFields {
	private String stringValue;
	private int intValue;
	private boolean booleanValue;
	
	public MyDtoIgnoreNullFields() {
		super();
	}
	public String getStringValue() {
		return stringValue;
	}

	public void setStringValue(String stringValue) {
		this.stringValue = stringValue;
	}

	public int getIntValue() {
		return intValue;
	}

	public void setIntValue(int intValue) {
		this.intValue = intValue;
	}

	public boolean isBooleanValue() {
		return booleanValue;
	}

	public void setBooleanValue(boolean booleanValue) {
		this.booleanValue = booleanValue;
	}
}
