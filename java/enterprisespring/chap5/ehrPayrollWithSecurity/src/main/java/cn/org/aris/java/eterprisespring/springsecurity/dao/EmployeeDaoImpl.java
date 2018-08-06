package cn.org.aris.java.eterprisespring.springsecurity.dao;

import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import cn.org.aris.java.eterprisespring.springsecurity.model.Employee;

@Repository
public class EmployeeDaoImpl implements EmployeeDao {

	private static final Logger logger = LoggerFactory.getLogger(EmployeeDaoImpl.class);
	
	@Autowired
	private SessionFactory sessionFactory;
	
	@SuppressWarnings("unchecked")
	@Override
	public List<Employee> listEmployee() {
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee";
		Query query = session.createQuery(hql);
		List<Employee> empList = query.list();
		logger.info("Person List: " + empList);
		return empList;
	}

	@Override
	public void insertEmployee(Employee employee) {
		logger.debug("Begin saving object");
		Session session = sessionFactory.openSession();
		session.beginTransaction();
		session.save(employee);
		session.getTransaction().commit();
		logger.info("Object saved to the database");
	}

	@Override
	public void deleteEmployee(Integer empId) {
		System.out.println("HQL Using Delete");
		logger.debug("HQL Using Delete");
		Session session = sessionFactory.openSession();
		String hql = "DELETE from Employee E WHERE E.empId = :employee_id";
		Query query = session.createQuery(hql);
		query.setParameter("employee_id", empId);
		int result = query.executeUpdate();
		System.out.println("Row affected: " + result);
		logger.debug("Row affected: " + result);
	}

}
