package cn.org.aris.java.enterprisespring.chap2.autowire.autowireusingconstructor;

public class EmployeeService {

	private Employee employee;

	public EmployeeService(Employee employee) {
		this.employee = employee;
	}

	public Employee getEmployee() {
		return employee;
	}

	@Override
	public String toString() {
		return "EmployeeService [employee=" + employee + "]";
	}
}
