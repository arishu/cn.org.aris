package cn.org.aris.java.enterprisespring.chap2.autodetect;

public class EmployeeService {
	
	private Employee employee;

	public EmployeeService(Employee employee) {
		this.employee = employee;
	}
	
	/*public void setEmployee(Employee employee) {
		this.employee = employee;
	}*/

	@Override
	public String toString() {
		return "EmployeeService [employee=" + employee + "]";
	}
}
