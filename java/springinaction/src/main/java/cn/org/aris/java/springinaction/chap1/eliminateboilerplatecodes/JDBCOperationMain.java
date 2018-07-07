package cn.org.aris.java.springinaction.chap1.eliminateboilerplatecodes;

public class JDBCOperationMain {

	public static void main(String[] args) {
		try {
			JDBCManager manager = new JDBCManager();
			Employee emp = manager.getEmployeeById("171107001");
			
			System.out.println(emp.toString());
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
