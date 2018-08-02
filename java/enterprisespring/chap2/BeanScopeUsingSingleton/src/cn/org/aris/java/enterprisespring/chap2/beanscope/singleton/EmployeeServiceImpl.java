package cn.org.aris.java.enterprisespring.chap2.beanscope.singleton;

public class EmployeeServiceImpl implements EmployeeService {

	private String message;
	
	@Override
	public void setMessage(String message) {
		this.message = message;
	}

	@Override
	public String getMessage() {
		return this.message;
	}

}
