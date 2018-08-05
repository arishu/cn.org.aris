package cn.org.aris.java.enterprisespring.springhibernate;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import cn.org.aris.java.enterprisespring.springhibernate.hibernate.model.Employee;
import cn.org.aris.java.enterprisespring.springhibernate.hibernate.service.EmployeeService;

public class SpringHibernateMain {

	public static void main(String[] args) {
		ApplicationContext context = new ClassPathXmlApplicationContext("/META-INF/spring/app-context.xml");
		
		EmployeeService employeeService = context.getBean("employeeServiceImpl", EmployeeService.class);
		
		Employee emp = new Employee();
		emp.setFirstName("Shree");
		emp.setLastName("Kant");
		emp.setJobTitle("Software Engineer");
		emp.setDepartment("Technology");
		emp.setSalary(6000);
		
		employeeService.insertEmployee(emp);
		
		for (Employee employee : employeeService.getAllEmployees()) {
			System.out.println(employee);
		}
		
		((AbstractApplicationContext) context).close();
	}

}
