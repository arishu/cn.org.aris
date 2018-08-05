package cn.org.aris.java.enterprisespring.springhibernate.hibernate.dao;

import java.util.List;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

@Repository
public class EmployeeDaoImpl implements EmployeeDao {

	@Autowired
	private SessionFactory sessionFactory;
	
	@Override
	@SuppressWarnings({ "unchecked" })
	@Transactional
	public List<Employee> getAllEmployees() {
		Session session = sessionFactory.openSession();
		List<Employee> emList = session.createQuery("From Employee").list();
		return emList;
	}

	@Override
	public void insertEmployee(Employee employee) {
		Session session = sessionFactory.openSession();
		session.beginTransaction();
		session.save(employee);
		session.getTransaction().commit();
	}

}
