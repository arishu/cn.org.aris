package cn.org.aris.java.springinaction.chap1.eliminateboilerplatecodes;

import java.util.Objects;

public class Employee {
	private String empId;
	
	private String empName;
	
	private String firstName;
	
	private String lastName;
	
	private short age;
	
	private double salary;
	
	private String dept;

	public String getEmpId() {
		return empId;
	}

	public void setEmpId(String empId) {
		this.empId = empId;
	}

	public String getEmpName() {
		return empName;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public short getAge() {
		return age;
	}

	public void setAge(short age) {
		this.age = age;
	}

	public double getSalary() {
		return salary;
	}

	public void setSalary(double salary) {
		this.salary = salary;
	}

	public String getDept() {
		return dept;
	}

	public void setDept(String dept) {
		this.dept = dept;
	}

	@Override
	public int hashCode() {
		return Objects.hash(empId, age, firstName, lastName, salary);
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null) {
			return false;
		}
		
		if (obj instanceof Employee) {
			Employee tmp = (Employee)obj;
			return tmp.toString().equals(this.toString());
		}
		
		return false;
	}

	@Override
	public String toString() {
		return "Employee [empId = " + this.empId
				+ ",firstName = " + this.firstName
				+ ",lastName = " + this.lastName
				+ ",age = " + this.age
				+ ", salary = " + this.salary + "]";
	}
}
