package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

@JsonIgnoreProperties("hidden")
public interface Hidable {
	boolean isHidden();
}
