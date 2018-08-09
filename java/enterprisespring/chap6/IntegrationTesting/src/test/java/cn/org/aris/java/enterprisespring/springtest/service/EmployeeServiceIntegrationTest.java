package cn.org.aris.java.enterprisespring.springtest.service;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import org.junit.Before;
import org.junit.Test;

import cn.org.aris.java.enterprisespring.springtest.dao.InMemoryEmployeeDaoImpl;
import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public class EmployeeServiceIntegrationTest {

	private static final String OLD_EMPLOYEE_ID = "12121";
	private static final String NEW_EMPLOYEE_ID = "53535";
	
	private Employee oldEmployee;
	private Employee newEmployee;
	private EmployeeService employeeService;
	
	@Before
	public void setUp() {
		oldEmployee = new Employee(OLD_EMPLOYEE_ID, "Ravi", "Soni", "Teacher", "High School", 10000);
		newEmployee = new Employee(NEW_EMPLOYEE_ID, "Shashi", "Soni", "Teacher", "High School", 16000);
		
		employeeService = new EmployeeServiceImpl(new InMemoryEmployeeDaoImpl());
		employeeService.createEmployee(oldEmployee);
	}
	
	@Test
	public void isOldEmployeeTest() {
		assertTrue(employeeService.isOldEmployee(OLD_EMPLOYEE_ID));
		assertFalse(employeeService.isOldEmployee(NEW_EMPLOYEE_ID));
	}
	
	@Test
	public void createNewEmployeeTest() {
		employeeService.createEmployee(newEmployee);
		assertTrue(employeeService.isOldEmployee(NEW_EMPLOYEE_ID));
	}
	
	@Test
	public void updateEmployeeTest() {
		String firstName = "Sharee";
		oldEmployee.setFirstName(firstName);
		employeeService.updateEmployee(oldEmployee);
		assertEquals(firstName, employeeService.findEmployee(OLD_EMPLOYEE_ID).getFirstName());
	}
	
	@Test
	public void deleteEmployeeTest() { 
		employeeService.deleteEmployee(OLD_EMPLOYEE_ID);
		assertFalse(employeeService.isOldEmployee(OLD_EMPLOYEE_ID));
	}
}
