package cn.org.aris.enterprise.chap2.construcioninjection.multiplejavatype;

public class EmployeeService {
	private String employeeName;
	private int employeeAge;
	private String employeeId;
	
	public EmployeeService(String employeeName, int employeeAge, String employeeId) {
		super();
		this.employeeName = employeeName;
		this.employeeAge = employeeAge;
		this.employeeId = employeeId;
	}
	
	public EmployeeService(String employeeName, String employeeId, int employeeAge) {
		super();
		this.employeeName = employeeName;
		this.employeeAge = employeeAge;
		this.employeeId = employeeId;
	}

	@Override
	public String toString() {
		return "EmployeeService [employeeName=" + employeeName + ", employeeAge=" + employeeAge + ", employeeId="
				+ employeeId + "]";
	}
}
