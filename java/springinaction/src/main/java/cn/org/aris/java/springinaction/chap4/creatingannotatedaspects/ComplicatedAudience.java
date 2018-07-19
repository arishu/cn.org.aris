package cn.org.aris.java.springinaction.chap4.creatingannotatedaspects;

import org.aspectj.lang.annotation.AfterReturning;
import org.aspectj.lang.annotation.AfterThrowing;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;

@Aspect
public class ComplicatedAudience {
	
	@Before("execution(** cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance.perform(...))")
	public void silenceCellPhones() {						// Before Performance
		System.out.println("Silencing cell phones");
	}
	
	@Before("execution(** cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance.perform(...))")
	public void takeSeats() {								// Before Performance
		System.out.println("Taking seats");
	}
	
	@AfterReturning("execution(** cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance.perform(...))")
	public void applause() {								// After Performance
		System.out.println("CLAP CLAP CLAP!!! ");
	}
	
	@AfterThrowing("execution(** cn.org.aris.java.springinaction.chap4.creatingannotatedaspects.concert.Performance.perform(...))")
	public void demandRefund() {							// After bad Performance
		System.out.println("Demanding a refund");
	}
}
