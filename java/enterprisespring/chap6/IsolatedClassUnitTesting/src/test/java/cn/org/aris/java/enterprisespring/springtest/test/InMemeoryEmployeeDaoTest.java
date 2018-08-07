package cn.org.aris.java.enterprisespring.springtest.test;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

import org.junit.Before;
import org.junit.Test;

import cn.org.aris.java.enterprisespring.springtest.dao.InMemeoryEmployeeDaoImpl;
import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public class InMemeoryEmployeeDaoTest {
	
	private static final String OLD_EMPLOYEE_ID = "12121";
	private static final String NEW_EMPLOYEE_ID = "53535";
	
	private Employee oldEmployee;
	private Employee newEmployee;
	private InMemeoryEmployeeDaoImpl empDao;
	
	@Before
	public void setUp() {
		oldEmployee = new Employee(OLD_EMPLOYEE_ID, "Ravi", "Soni", "Teacher", "MiddleSchool", 6000);
		newEmployee = new Employee(NEW_EMPLOYEE_ID, "Shashi", "Soni", "Teacher", "MiddleSchool", 8000);
		
		empDao = new InMemeoryEmployeeDaoImpl();
		empDao.createEmployee(oldEmployee);
	}
	
	@Test
	public void isOldEmployeeTest() {
		assertTrue(empDao.isOldEmployee(OLD_EMPLOYEE_ID));
		assertFalse(empDao.isOldEmployee(NEW_EMPLOYEE_ID));
	}
	
	@Test
	public void createEmployeeTest() {
		empDao.createEmployee(newEmployee);
		assertTrue(empDao.isOldEmployee(NEW_EMPLOYEE_ID));
	}
	
	@Test
	public void updateNewEmployeeTest() {
		String firstName = "Sharee";
		oldEmployee.setFirstName(firstName);
		empDao.updateEmployee(oldEmployee);
		assertEquals(firstName, empDao.findEmployee(OLD_EMPLOYEE_ID).getFirstName());
	}
	
	@Test
	public void deleteEmployeeTest() {
		empDao.deleteEmployee(OLD_EMPLOYEE_ID);
		assertFalse(empDao.isOldEmployee(OLD_EMPLOYEE_ID));
	}
	
}
