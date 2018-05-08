package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

import com.fasterxml.jackson.annotation.JsonFilter;

@JsonFilter("myFilter")
public class MyDtoWithFilter {
	
	private int intValue;
	
	public MyDtoWithFilter() {
		super();
	}

	public int getIntValue() {
		return intValue;
	}

	public void setIntValue(int intValue) {
		this.intValue = intValue;
	}

	@Override
	public String toString() {
		return "MyDtoWithFilter: [ intValue=" + intValue + "]";
	}
}
