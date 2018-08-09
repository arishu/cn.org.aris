package cn.org.aris.java.springmvc.webstore.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import cn.org.aris.java.springmvc.webstore.domain.Customer;
import cn.org.aris.java.springmvc.webstore.service.CustomerService;

@Controller
public class CustomerController {

	@Autowired
	private CustomerService customerService;
	
	@RequestMapping("/customers/list.do")
	public String listCustomers(Model model) {
		List<Customer> customers = this.customerService.getAllCustomers();
		model.addAttribute("customers", customers);
		return "customers";
	}
}
