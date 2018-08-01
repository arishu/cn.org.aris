package cn.org.aris.java.enterprisespring.chap2.setterinjection.innerbeans;

public class ATM {

	private Printer printer;

	public Printer getPrinter() {
		return printer;
	}

	public void setPrinter(Printer printer) {
		this.printer = printer;
	}
	
	public void printBalance(String accountNumber) {
		getPrinter().printBalance(accountNumber);
	}
	
}
