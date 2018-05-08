package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

public class Address implements Hidable{

	private String city;
	private String country;
	private boolean hidden;
	
	public Address() {
	}

	public Address(String city, String country) {
		this.city = city;
		this.country = country;
	}
	
	public String getCity() {
		return city;
	}
	
	public void setCity(String city) {
		this.city = city;
	}
	
	public String getCountry() {
		return country;
	}
	
	public void setCountry(String country) {
		this.country = country;
	}
	
	public boolean isHidden() {
		return hidden;
	}
	
	public void setHidden(boolean hidden) {
		this.hidden = hidden;
	}

	@Override
	public String toString() {
		return "Address: [ city=\"" + city + "\", country=\"" + country + "\", hidden=" + hidden + "]";
	}
}
