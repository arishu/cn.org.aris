package cn.org.aris.java.spittr.web;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.Errors;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import cn.org.aris.java.spittr.Spitter;
import cn.org.aris.java.spittr.data.SpitterRepository;

@Controller
@RequestMapping("/spitter")
public class SpitterController {
	
	private SpitterRepository spitterRepository;
	
	@Autowired
	public SpitterController(SpitterRepository spitterRepository) {
		this.spitterRepository = spitterRepository;
	}
	
	/**
	 * 返回注册界面
	 * @return
	 */
	@RequestMapping(value="/register", method=RequestMethod.GET)
	public String showRegistrationForm() {
		return "registerForm";
	}
	
	/**
	 * 注册表单提交时的处理：重定向界面
	 * @param spitter 
	 * @param errors
	 * @return
	 */
	@RequestMapping(value="/register", method=RequestMethod.POST)
	public String processRegistration(
			@Valid Spitter spitter,
			Errors errors) {
		
		if (errors.hasErrors()) {
			return "registerForm";
		}
		
		spitterRepository.save(spitter);
		return "redirect:/spitter/" + spitter.getUsername();
	}
	
	/**
	 * 注册成功后，返回用户信息界面
	 * @param username	请求的URL路径
	 * @param model		
	 * @return
	 */
	@RequestMapping(value="/{username}", method=RequestMethod.GET)
	public String showSpitterProfile(@PathVariable String username, Model model) {
		Spitter spitter = spitterRepository.findByUserName(username);
		model.addAttribute(spitter);
		return "profile";
	}
}
