package cn.org.aris.java.enterprisespring.chap6.junittesting.calculator;

import static org.testng.AssertJUnit.assertEquals;

import org.testng.annotations.AfterClass;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

public class SimpleCalculatorTestNGTests {
	
	private SimpleCalculator calculator;
	
	@BeforeClass
	public static void beforeClass() {
		System.out.println("@BeforeClass method");
	}
	
	@AfterClass
	public static void afterClass() {
		System.out.println("@AfterClass method");
	}
	
	@BeforeMethod
	public void init() {
		System.out.println();
		System.out.println("@BeforeMethod method");
		calculator = new SimpleCalculatorImpl();
	}
	
	@AfterMethod
	public void finish() {
		System.out.println("@AfterMethod method");
		System.out.println();
	}
	
	@BeforeTest
	public void beforeTest() {
		System.out.println("@BeforeTest method");
	}
	
	@AfterTest
	public void afterTest() {
		System.out.println("@AfterTest method");
	}
	
	@Test
	public void verifyAdd() {
		long sum = calculator.add(3, 7);
		assertEquals(10, sum);
		System.out.println("verifyAdd executed");
	}
	
	@Test
	public void verifySub() {
		long sum = calculator.sub(3, 7);
		assertEquals(-4, sum);
		System.out.println("verifySub executed");
	}
	
	
}