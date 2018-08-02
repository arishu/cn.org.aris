package cn.org.aris.java.enterprisespring.chap2.autowire.autowirebyname;

public class Employee {

	private int employeeId;
	
	public void setEmployeeId(int employeeId) {
		this.employeeId = employeeId;
	}

	@Override
	public String toString() {
		return "Employee [employeeId=" + employeeId + "]";
	}
}
