package cn.org.aris.java.enterprisespring.springtest.service;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotSame;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.verifyNoMoreInteractions;
import static org.mockito.Mockito.verifyZeroInteractions;
import static org.mockito.Mockito.when;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.junit.MockitoJUnitRunner;

import cn.org.aris.java.enterprisespring.springtest.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.springtest.model.Employee;

@RunWith(MockitoJUnitRunner.class)
public class EmployeeServiceTest {
	
	private static final String OLD_EMPLOYEE_ID = "12121";
	private Employee oldEmployee;
	private EmployeeService employeeService;
	
	@Mock
	private EmployeeDao employeeDao;
	
	@Before
	public void setUp() {
		employeeService = new EmployeeServiceImpl(employeeDao);
		oldEmployee = new Employee(OLD_EMPLOYEE_ID, "Ravi", "Soni", "Teacher", "Meddle School", 6000);
	}
	
	@Test
	public void findEmployeeTest() {
		when(employeeDao.findEmployee(OLD_EMPLOYEE_ID)).thenReturn(oldEmployee);
		Employee employee = employeeService.findEmployee(OLD_EMPLOYEE_ID);
		assertEquals(oldEmployee, employee);
		
		// Verifies findEmployee behavior happendd once
		verify(employeeDao).findEmployee(OLD_EMPLOYEE_ID);
				
		// Verifies that during the test, 
		// there are no other calls to the mock object
		verifyNoMoreInteractions(employeeDao);
	}
	
	@Test
	public void notFindEmployeeTest() {
		when(employeeDao.findEmployee(OLD_EMPLOYEE_ID)).thenReturn(null);
		Employee employee = employeeService.findEmployee(OLD_EMPLOYEE_ID);
		assertNotSame(oldEmployee, employee);
		
		verify(employeeDao).findEmployee(OLD_EMPLOYEE_ID);

		// Verifies that no interactions happened on employeeDao mocks
		verifyZeroInteractions(employeeDao);
		verifyNoMoreInteractions(employeeDao);
	}
}
