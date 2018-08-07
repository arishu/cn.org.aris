package cn.org.aris.java.enterprisespring.springtest.dao;

import java.util.Collections;
import java.util.HashMap;
import java.util.Map;

import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public class InMemoryEmployeeDaoImpl implements EmployeeDao {

	private Map<String, Employee> employees;
	
	public InMemoryEmployeeDaoImpl() {
		employees = Collections.synchronizedMap(new HashMap<String, Employee>());
	}

	public boolean isOldEmployee(String employeeId) {
		return employees.containsKey(employeeId);
	}
	
	@Override
	public void createEmployee(Employee employee) {
		if (!isOldEmployee(employee.getEmpId())) {
			employees.put(employee.getEmpId(), employee);
		}
	}

	@Override
	public void updateEmployee(Employee employee) {
		if (isOldEmployee(employee.getEmpId())) {
			employees.put(employee.getEmpId(), employee);
		}
	}

	@Override
	public void deleteEmployee(String employeeId) {
		if (isOldEmployee(employeeId)) {
			employees.remove(employeeId);
		}
	}

	@Override
	public Employee findEmployee(String employeeId) {
		return employees.get(employeeId);
	}

}
