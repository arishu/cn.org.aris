package cn.org.aris.java.enterprisespring.chap2.callbacks.xml;

public class XmlEmployeeServiceImpl implements EmployeeService {

	public void myInit() {
		System.out.println("New Employee My Init...");
	}
	
	@Override
	public Long generateEmployeeID() {
		return System.currentTimeMillis();
	}

	public void cleanUp() {
		System.out.println("New Employee Cleanup");
	}
}
