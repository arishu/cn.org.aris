package cn.org.aris.java.enterprisespring.chap2.setterinjection.empty;

public class Employee {

	String employeeName;
	String employeeDept;

	public String getEmployeeName() {
		return employeeName;
	}

	public void setEmployeeName(String employeeName) {
		this.employeeName = employeeName;
	}

	public String getEmployeeDept() {
		return employeeDept;
	}

	public void setEmployeeDept(String employeeDept) {
		this.employeeDept = employeeDept;
	}

	@Override
	public String toString() {
		return "Employee [employeeName=" + employeeName + ", employeeDept=" + employeeDept + "]";
	}
}
