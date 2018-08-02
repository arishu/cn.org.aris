package cn.org.aris.java.enterprisespring.chap3.JDBC.dao.impl;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import cn.org.aris.java.enterprisespring.chap3.JDBC.dao.EmployeeDao;
import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

public class EmployeeDaoImpl implements EmployeeDao {

	static final String JDBC_DRIVER = "org.apache.derby.jdbc.ClientDriver";
	static final String DB_URL = "jdbc:derby://localhost:1527/db";
	
	private void registerDriver() {
		try {
			Class.forName(JDBC_DRIVER).newInstance();
		} catch (InstantiationException e) {
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	@Override
	public Employee getEmployeeById(int id) {
		Connection conn = null;
		Employee employee = null;
		try {
			// Register Apache Derby Driver
			registerDriver();
			
			// Open a connection using DB url
			conn = DriverManager.getConnection(DB_URL);
			
			// Set designed parameter to the given java int value
			PreparedStatement ps = conn.prepareStatement("select * from employee where id = ?");
			ps.setInt(1, id);
			
			// Execute the SQL query in the PreparedStatement object and
			// returns the ResultSet object
			ResultSet rs = ps.executeQuery();
			
			if (rs.next()) {
				employee = new Employee(id, rs.getString("name").trim());
			}
			
			// close the ResultSet and PreparedStatement object
			rs.close();
			ps.close();
		} catch (SQLException e) {
			throw new RuntimeException(e);
		} finally {
			if (conn != null) {
				try {
					conn.close();
				} catch (SQLException e) {
				}
			}
		}
		return employee;
	}

	@Override
	public void createEmployee() {
		Connection conn = null;
		
		try {
			registerDriver();
			
			conn = DriverManager.getConnection(DB_URL);
			
			Statement stmt = conn.createStatement();
			
			stmt.executeUpdate("create table employee(id integer, name char(30))");
			
			stmt.close();
		} catch (SQLException e) {
			throw new RuntimeException(e);
		} finally {
			if (conn != null) {
				try {
					conn.close();
				} catch (SQLException e) {
				}
			}
		}
	}

	@Override
	public void insertEmployee(Employee employee) {
		Connection conn = null;
		
		try {
			registerDriver();
			
			conn = DriverManager.getConnection(DB_URL);
			
			Statement stmt = conn.createStatement();
			
			stmt.executeUpdate("insert into employee values("
					+ employee.getId() + ",'" 
					+ employee.getName() + "')");
			
			stmt.close();
		} catch (SQLException e) {
			throw new RuntimeException(e);
		} finally {
			if (conn != null) {
				try {
					conn.close();
				} catch (SQLException e) {
				}
			}
		}
	}

	@Override
	public void deleteEmployeeById(int id) {
		Connection conn = null;
		
		try {
			registerDriver();
			
			conn = DriverManager.getConnection(DB_URL);
			
			Statement stmt = conn.createStatement();
			
			stmt.executeUpdate("delete from employee where id = " + id);
			
			stmt.close();
		} catch (SQLException e) {
			throw new RuntimeException(e);
		} finally {
			if (conn != null) {
				try {
					conn.close();
				} catch (SQLException e) {
				}
			}
		}
	}
}
