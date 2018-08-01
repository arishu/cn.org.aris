package cn.org.aris.enterprise.chap2.construcioninjection.simplejavatype;

public class EmployeeService {
	
	private String greeting;

	public EmployeeService(String greeting) {
		this.greeting = greeting;
	}

	@Override
	public String toString() {
		return greeting;
	}
}
