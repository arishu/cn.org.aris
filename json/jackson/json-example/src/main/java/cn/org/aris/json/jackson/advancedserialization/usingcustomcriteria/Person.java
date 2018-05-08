package cn.org.aris.json.jackson.advancedserialization.usingcustomcriteria;

public class Person implements Hidable {

	private String name;
	private Address address;
	private boolean hidden;
	
	public Person() {
	}
	
	public Person(String name, Address address) {
		this.name = name;
		this.address = address;
	}
	
	public String getName() {
		return name;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public Address getAddress() {
		return address;
	}
	
	public void setAddress(Address address) {
		this.address = address;
	}
	
	public boolean isHidden() {
		return hidden;
	}
	
	public void setHidden(boolean hidden) {
		this.hidden = hidden;
	}
	
	@Override
	public String toString() {
		return "Person: [ name=\"" + name + "\", hidden=" + hidden + ", address= " + address.toString() + "]";
	}

}
