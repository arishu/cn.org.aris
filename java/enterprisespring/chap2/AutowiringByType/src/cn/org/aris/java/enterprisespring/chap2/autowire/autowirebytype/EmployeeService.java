package cn.org.aris.java.enterprisespring.chap2.autowire.autowirebytype;

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
