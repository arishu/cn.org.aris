package cn.org.aris.java.enterprisespring.springhibernate.hibernate.dao;

import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

@Repository
@Transactional(readOnly = true)
@SuppressWarnings("unchecked")
public class EmployeeDaoImpl implements EmployeeDao {

	@Autowired
	private SessionFactory 	sessionFactory;
	
	@Override
	public List<Employee> getAllEmployees() {
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee";
		return session.createQuery(hql).list();
	}

	@Override
	public void insertEmployee(Employee employee) {
		Session session = sessionFactory.openSession();
		session.save(employee);
	}

	@Override
	public List<Employee> hqlUsingFromClause() {
		System.out.println("HQL Using From Clause");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingFromClauseFullyQualified() {
		System.out.println("HQL Using From Clause Fullly Qualified");
		Session session = sessionFactory.openSession();
		String hql = "FROM cn.org.aris.java.enterprisespring.springhibernate.model.Employee";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingAsClause() {
		System.out.println("HQL Using AS Clause");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee AS E";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingAsClauseOptional() {
		System.out.println("HQL Using AS Clause Optional");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee E";
		return session.createQuery(hql).list();
	}

	@Override
	public List<String> hqlUsingSelectClause() {
		System.out.println("HQL Using Select Clause");
		Session session = sessionFactory.openSession();
		String hql = "SELECT E.firstName FROM Employee E";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingWhereClause() {
		System.out.println("HQL Using Where Clause");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee E WHERE E.firstName = 'Aris'";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingOrderByClause() {
		System.out.println("HQL Using Order By Clause");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee E ORDER BY E.firstName DESC";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingOrderByClauseForMore() {
		System.out.println("HQL Using ORDER BY Clause");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee E ORDER BY E.firstName DESC,E.empId DESC";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Long> hqlUsingGroupByClause() {
		System.out.println("HQL Using Group By Clause");
		Session session = sessionFactory.openSession();
		String hql = "SELECT SUM(E.salary) FROM Employee E GROUP BY E.firstName";
		return session.createQuery(hql).list();
	}

	@Override
	public List<Employee> hqlUsingNamedParameter() {
		System.out.println("HQL Using Named Paramerer");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee E WHERE E.firstName = :emp_firstName";
		return session.createQuery(hql).setParameter("emp_firstName", "Shree").list();
	}

	@Override
	public void hqlUsingUpdate() {
		System.out.println("HQL Using Update");
		Session session = sessionFactory.openSession();
		String hql = "UPDATE Employee E set E.firstName = :name WHERE E.empId = :employee_id";
		Query query = session.createQuery(hql);
		query.setParameter("name", "Shashi");
		query.setParameter("employee_id", 3);
		int result = query.executeUpdate();
		System.out.println("Row affected: " + result);
	}

	@Override
	public void hqlUsingDelete() {
		System.out.println("HQL Using Delete");
		Session session = sessionFactory.openSession();
		String hql = "DELETE from Employee E WHERE E.empId = :employee_id";
		Query query = session.createSQLQuery(hql);
		query.setParameter("employee_id", 3);
		int result = query.executeUpdate();
		System.out.println("Row affected: " + result);
	}

	@Override
	public List<Employee> hqlUsingPagination() {
		System.out.println("HQL Using Pagination");
		Session session = sessionFactory.openSession();
		String hql = "FROM Employee";
		Query query = session.createQuery(hql);
		query.setFirstResult(0);
		query.setMaxResults(1);
		return query.list();
	}

}
