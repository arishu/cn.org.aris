package cn.org.aris.enterprise.chap2.construcioninjection.simplejavatype;

public class Employee {

	private String employeeName;
	private int employeeAge;
	private boolean married;
	
	public Employee(String employeeName, int employeeAge, boolean married) {
		super();
		this.employeeName = employeeName;
		this.employeeAge = employeeAge;
		this.married = married;
	}

	@Override
	public String toString() {
		return "Employee [employeeName=" + employeeName + ", employeeAge=" + employeeAge + ", married=" + married + "]";
	}
}
