package cn.org.aris.java.enterprisespring.chap2.setterinjection.conplexjavatype;

public class EmployeeService {

	private Employee employee;
	
	public void setEmployee(Employee employee) {
		this.employee = employee;
	}

	@Override
	public String toString() {
		return "EmployeeService [employee=" + employee + "]";
	}
}
