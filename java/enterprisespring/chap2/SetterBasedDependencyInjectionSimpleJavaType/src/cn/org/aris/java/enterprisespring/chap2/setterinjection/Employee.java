package cn.org.aris.java.enterprisespring.chap2.setterinjection;

public class Employee {
	
	String employeeName;
	
	public void setEmployeeName(String employeeName) {
		this.employeeName = employeeName;
	}

	@Override
	public String toString() {
		return "Employee [employeeName=" + employeeName + "]";
	}
}
