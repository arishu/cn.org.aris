package cn.org.aris.java.enterprisespring.chap2.autowire.autowirebyname;

public class EmployeeService {

	private Employee employee;

	public Employee getEmployee() {
		return employee;
	}

	public void setEmployee(Employee employee) {
		this.employee = employee;
	}

	@Override
	public String toString() {
		return "EmployeeService [employee=" + employee + "]";
	}
}
