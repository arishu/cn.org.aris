package cn.org.aris.java.enterprisespring.springhibernate.hibernate.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

@Service
public class EmployeeServiceImpl implements EmployeeService {

	@Autowired
	private EmployeeDao employeeDao;
	
	@Override
	public List<Employee> getAllEmployees() {
		return employeeDao.getAllEmployees();
	}

	@Override
	public void insertEmployee(Employee employee) {
		employeeDao.insertEmployee(employee);
	}

	@Override
	public List<Employee> hqlUsingFromClause() {
		return employeeDao.hqlUsingFromClause();
	}

	@Override
	public List<Employee> hqlUsingFromClauseFullyQualified() {
		return employeeDao.hqlUsingFromClauseFullyQualified();
	}

	@Override
	public List<Employee> hqlUsingAsClause() {
		return employeeDao.hqlUsingAsClause();
	}

	@Override
	public List<Employee> hqlUsingAsClauseOptional() {
		return employeeDao.hqlUsingAsClauseOptional();
	}

	@Override
	public List<String> hqlUsingSelectClause() {
		return employeeDao.hqlUsingSelectClause();
	}

}
