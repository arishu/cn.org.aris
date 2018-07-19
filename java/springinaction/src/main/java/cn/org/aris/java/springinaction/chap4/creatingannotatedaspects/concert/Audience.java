package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert;

import org.aspectj.lang.annotation.AfterReturning;
import org.aspectj.lang.annotation.AfterThrowing;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;

@Aspect
public class Audience {
	
	@Pointcut("execution(** cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance.perform(...))")
	public void performance() {}							// Defining named pointcut
	
	@Before("performance()")
	public void silenceCellPhones() {						// Before Performance
		System.out.println("Silencing cell phones");
	}
	
	@Before("performance()")
	public void takeSeats() {								// Before Performance
		System.out.println("Taking seats");
	}
	@AfterReturning("performance()")
	public void applause() {								// After Performance
		System.out.println("CLAP CLAP CLAP!!! ");
	}
	
	@AfterThrowing("performance()")
	public void demandRefund() {							// After bad Performance
		System.out.println("Demanding a refund");
	}
}
