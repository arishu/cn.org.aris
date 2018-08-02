package cn.org.aris.java.enterprisespring.chap2.callbacks;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;

public class EmployeeServiceImpl implements EmployeeService, InitializingBean, DisposableBean {

	@Override
	public void afterPropertiesSet() throws Exception {
		System.out.println("Employee afterPropertiesSet ");
	}
	
	@Override
	public Long generateEmployeeID() {
		return System.currentTimeMillis();
	}

	@Override
	public void destroy() throws Exception {
		System.out.println("Employee destroy ");
	}
}
