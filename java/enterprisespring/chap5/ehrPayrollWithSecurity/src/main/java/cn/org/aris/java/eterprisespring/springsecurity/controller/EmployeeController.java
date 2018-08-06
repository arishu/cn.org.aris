package cn.org.aris.java.eterprisespring.springsecurity.controller;

import java.util.List;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;

import cn.org.aris.java.eterprisespring.springsecurity.model.Employee;
import cn.org.aris.java.eterprisespring.springsecurity.service.EmployeeService;

@Controller
@RequestMapping("/employee")
public class EmployeeController {

	private static final Logger logger = LoggerFactory.getLogger(EmployeeController.class);
	
	@Autowired
	private EmployeeService employeeService;
	
	
	@RequestMapping(value = "/listemployee", method=RequestMethod.GET)
	public String listEmployees(ModelMap model) {
		List<Employee> empList = employeeService.listEmployee();
		model.addAttribute("employeeList", empList);
		logger.debug("[Search]GET Employee From Database: ", empList);
		return "employee";
	}
	
	@RequestMapping(value = "/addemployee", method = RequestMethod.GET)
	public ModelAndView addEmployee(ModelMap model) {
		return new ModelAndView("addEmployee", "command", new Employee());
	}
	
	@RequestMapping(value = "/updateemployee", method = RequestMethod.POST)
	public String updateEmployee(
			@ModelAttribute("employeeForm") Employee employee, ModelMap model) {
		this.employeeService.insertEmployee(employee);
		List<Employee> empList = employeeService.listEmployee();
		model.addAttribute("employeeList", empList);
		logger.debug("[UPDATE]GET Employee From Database: ", empList);
		return "employee";
	}
	
	@RequestMapping(value = "/delete/{empId}", method = RequestMethod.GET)
	public String deleteEmployee(
			@PathVariable("empId") Integer empId, ModelMap model) {
		this.employeeService.deleteEmployee(empId);
		List<Employee> empList = employeeService.listEmployee();
		model.addAttribute("employeeList", empList);
		logger.debug("[DELETE]GET Employee From Database: ", empList);
		return "employee";
	}
}
