package cn.org.aris.java.springinaction.chap1.eliminateboilerplatecodes;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionSet {
	
	private static ConnectionSet instance;
	
	private ConnectionSet() {
	}
	
	public static ConnectionSet getInstance() {
		if (instance == null) {
			instance = new ConnectionSet();
		}
		return instance;
	}
	
	public Connection getConnection() {
		Connection conn = null;
		// we should put ‘serverTimezone=GMT’ at the end of jdbc connection url with ?
		String url = "jdbc:mysql://localhost:3306/springdb?serverTimezone=GMT" ;    
		String username = "root";   
		String password = "mingyi" ;   
		try {
			Class.forName("com.mysql.cj.jdbc.Driver").newInstance();
			
			conn = DriverManager.getConnection(url, username, password);
			
			return conn;
		} catch (ClassNotFoundException e) {
			 System.out.println("找不到驱动程序类 ，加载驱动失败!");
			 e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println("获取数据库链接失败!");
		} catch (InstantiationException e) {
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			e.printStackTrace();
		}
		return conn;
	}
}
