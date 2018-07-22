package cn.org.aris.java.spittr.web;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import cn.org.aris.java.spittr.data.SpittleRepository;

@Controller
@RequestMapping("/spittles")
public class SpittleController {

	@SuppressWarnings("unused")
	private static final String MAX_LONG_AS_STRING = "9223372036854775807";
	
	private SpittleRepository spittleReository;
	
	@Autowired
	public SpittleController(SpittleRepository spittleRepository) {
		this.spittleReository = spittleRepository;
	}
	
	@RequestMapping(method=RequestMethod.GET)
	public String spittles(Model model) {
		// Add spittles to model
		model.addAttribute(spittleReository.findSpittles(Long.MAX_VALUE, 20));
		
		// Return view name
		return "spittles";
	}
}
