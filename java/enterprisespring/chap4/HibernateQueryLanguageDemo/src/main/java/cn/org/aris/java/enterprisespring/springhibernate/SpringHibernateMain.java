package cn.org.aris.java.enterprisespring.springhibernate;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.service.EmployeeService;

public class SpringHibernateMain {

	public static void main(String[] args) {
		
		ApplicationContext context = new ClassPathXmlApplicationContext("/META-INF/spring/app-context.xml");
		
		EmployeeService employeeService = context.getBean("employeeServiceImpl", EmployeeService.class);
		
		System.out.println(employeeService.hqlUsingFromClause());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingFromClauseFullyQualified());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingAsClause());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingAsClauseOptional());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingSelectClause());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingNamedParameter());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingWhereClause());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingOrderByClause());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingOrderByClauseForMore());
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingGroupByClause());
	
		System.out.println();
		
		employeeService.hqlUsingUpdate();
		
		System.out.println();
		
		System.out.println(employeeService.hqlUsingPagination());
		
		System.out.println();
		
		((AbstractApplicationContext) context).close();
	}

}
