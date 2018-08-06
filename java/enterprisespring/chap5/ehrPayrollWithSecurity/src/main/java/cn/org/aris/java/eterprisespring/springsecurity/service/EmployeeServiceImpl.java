package cn.org.aris.java.eterprisespring.springsecurity.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import cn.org.aris.java.eterprisespring.springsecurity.dao.EmployeeDao;
import cn.org.aris.java.eterprisespring.springsecurity.model.Employee;

@Service
public class EmployeeServiceImpl implements EmployeeService {

	@Autowired
	private EmployeeDao employeeDao;
	
	@Override
	public List<Employee> listEmployee() {
		return employeeDao.listEmployee();
	}

	@Override
	public void insertEmployee(Employee employee) {
		employeeDao.insertEmployee(employee);
	}

	@Override
	public void deleteEmployee(Integer empId) {
		employeeDao.deleteEmployee(empId);
	}

}
