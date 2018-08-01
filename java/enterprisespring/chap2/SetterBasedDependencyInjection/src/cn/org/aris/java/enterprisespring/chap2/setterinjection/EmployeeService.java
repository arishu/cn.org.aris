package cn.org.aris.java.enterprisespring.chap2.setterinjection;

@SuppressWarnings("unused")
public class EmployeeService {
	
	private Employee employee;
	
	private void setEmployee(Employee employee) {
		this.employee = employee;
	}

	@Override
	public String toString() {
		return "EmployeeService [employee=" + employee + "]";
	}
}
