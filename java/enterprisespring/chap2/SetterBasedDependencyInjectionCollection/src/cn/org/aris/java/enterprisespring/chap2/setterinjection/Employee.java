package cn.org.aris.java.enterprisespring.chap2.setterinjection;

import java.util.List;
import java.util.Map;
import java.util.Set;

public class Employee {

	private List<Object> lists;
	private Set<Object> sets;
	private Map<Object, Object> maps;
	
	public void setLists(List<Object> lists) {
		this.lists = lists;
	}
	
	public void setSets(Set<Object> sets) {
		this.sets = sets;
	}
	
	public void setMaps(Map<Object, Object> maps) {
		this.maps = maps;
	}

	@Override
	public String toString() {
		return "Employee [lists=" + lists + ", sets=" + sets + ", maps=" + maps + "]";
	}
}
