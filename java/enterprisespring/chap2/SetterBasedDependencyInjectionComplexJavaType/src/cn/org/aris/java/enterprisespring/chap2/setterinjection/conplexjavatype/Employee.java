package cn.org.aris.java.enterprisespring.chap2.setterinjection.conplexjavatype;

public class Employee {
	
	String employeeName;

	public String getEmployeeName() {
		return employeeName;
	}

	public void setEmployeeName(String employeeName) {
		this.employeeName = employeeName;
	}

	@Override
	public String toString() {
		return "Employee [employeeName=" + employeeName + "]";
	}
}
