package cn.org.aris.java.enterprisespring.springtest.service;

import cn.org.aris.java.enterprisespring.springtest.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.springtest.model.Employee;

public class EmployeeServiceImpl implements EmployeeService {

	private EmployeeDao employeeDao = null;
	
	public EmployeeServiceImpl(EmployeeDao employeeDao) {
		this.employeeDao = employeeDao;
	}

	@Override
	public boolean isOldEmployee(String employeeId) {
		return employeeDao.isOldEmployee(employeeId);
	}

	@Override
	public void createEmployee(Employee employee) {
		employeeDao.createEmployee(employee);
	}

	@Override
	public void updateEmployee(Employee employee) {
		employeeDao.updateEmployee(employee);
	}

	@Override
	public void deleteEmployee(String employeeId) {
		employeeDao.deleteEmployee(employeeId);
	}
	
	@Override
	public Employee findEmployee(String employeeId) {
		return employeeDao.findEmployee(employeeId);
	}
}
