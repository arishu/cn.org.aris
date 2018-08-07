package cn.org.aris.java.enterprisespring.chap6.junittesting.calculator;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

import org.junit.Before;
import org.junit.Test;

public class SimpleCalculatorJUnit4Tests {
	
	private SimpleCalculator calculator;
	
	@Before
	public void init() {
		calculator = new SimpleCalculatorImpl();
	}
	
	@Test
	public void verifyAdd() {
		long sum = calculator.add(3, 7);
		assertEquals(10, sum);
	}
	
	@Test
	public void verifyAddFail() {
		long sum = calculator.add(3, 7);
		assertNotEquals(11, sum);
	}
}