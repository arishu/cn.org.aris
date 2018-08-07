package cn.org.aris.java.enterprisespring.chap6.junittesting.calculator;

public class SimpleCalculatorImpl implements SimpleCalculator {

	@Override
	public long add(int a, int b) {
		return a + b;
	}

	@Override
	public long sub(int a, int b) {
		return a - b;
	}

}
