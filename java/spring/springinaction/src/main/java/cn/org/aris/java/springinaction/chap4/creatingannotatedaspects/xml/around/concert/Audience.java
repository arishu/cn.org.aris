package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.xml.around.concert;

import org.aspectj.lang.ProceedingJoinPoint;

public class Audience {
	
	public void watchPerformance(ProceedingJoinPoint jp) {
		try {
			
			System.out.println("Silencing cell phones");
			
			System.out.println("Taking seats");
			
			jp.proceed();
			
			System.out.println("CLAP CLAP CLAP!!! ");
			
		} catch (Throwable e) {
			System.out.println("Demanding a refund");
		}
	}
	
}
