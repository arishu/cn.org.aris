package cn.org.aris.json.jackson.objectmapper;

import java.util.Date;

public class Request {
	private Car car;
	private Date datePurchased;
	
	public Request() {
		super();
	}
	
	public Request(Car car, Date date) {
		this.car = car;
		this.datePurchased = date;
	}
	
	public Car getCar() {
		return car;
	}
	
	public void setCar(Car car) {
		this.car = car;
	}
	
	public Date getDatePurchased() {
		return datePurchased;
	}
	
	public void setDatePurchased(Date datePurchased) {
		this.datePurchased = datePurchased;
	}

	@Override
	public String toString() {
		return "Request: [ car=" + car.toString() + ", date=" + datePurchased.toString() + "]";
	}
}
