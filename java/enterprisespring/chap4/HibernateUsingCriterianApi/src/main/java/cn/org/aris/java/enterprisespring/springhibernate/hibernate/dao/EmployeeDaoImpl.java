package cn.org.aris.java.enterprisespring.springhibernate.hibernate.dao;

import java.util.List;

import org.hibernate.Criteria;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.criterion.Criterion;
import org.hibernate.criterion.LogicalExpression;
import org.hibernate.criterion.Order;
import org.hibernate.criterion.Restrictions;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;

@SuppressWarnings("unchecked")
@Repository
@Transactional(readOnly = true)
public class EmployeeDaoImpl implements EmployeeDao {

	@Autowired
	private SessionFactory sessionFactory;
	
	@Override
	public List<Employee> getAllEmployees() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingOrder() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.addOrder(Order.desc("empId"));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingOR() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		
		// Add two Criterion
		Criterion jobTitle = Restrictions.eq("jobTitle", "AUTHOR");
		Criterion firstName = Restrictions.like("lastName", "Kant");
		LogicalExpression andExp = Restrictions.or(jobTitle, firstName);
		criteria.add(andExp);
		
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingAND() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		Criterion salary = Restrictions.eq("salary", 5000);
		Criterion firstName = Restrictions.like("lastName", "Soni");
		LogicalExpression andExp = Restrictions.and(salary, firstName);
		criteria.add(andExp);
		return criteria.list();
	}

	public List<Employee> criteriaRestrictionUsingIsNull() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.isNull("salary"));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingBetween() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.between("salary", 4000, 7000));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingLike() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.like("fisrtName", "Aris"));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingEq() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.eq("salary", 6000));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingGt() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.gt("empId", 1));
		return criteria.list();
	}
	
	public List<Employee> criteriaRestrictionUsingLt() {
		Session session = sessionFactory.openSession();
		Criteria criteria = session.createCriteria(Employee.class);
		criteria.add(Restrictions.lt("empId", 3));
		return criteria.list();
	}
	
	@Override
	public void insertEmployee(Employee employee) {
	}

	@Override
	public List<Employee> hqlUsingFromClause() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Employee> hqlUsingFromClauseFullyQualified() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Employee> hqlUsingAsClause() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<Employee> hqlUsingAsClauseOptional() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<String> hqlUsingSelectClause() {
		// TODO Auto-generated method stub
		return null;
	}

}
