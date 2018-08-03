package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.sql.DataSource;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

@Repository
public class EmployeeDaoImpl implements EmployeeDao {
	
	@Autowired
	private DataSource dataSource;
	
	@Override
	public void deleteEmployee() {
		Connection conn = null;
		
		try {
			conn = dataSource.getConnection();
			Statement stmt = conn.createStatement();
			stmt.execute("drop table employee");
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
	public Employee getEmployeeById(int id) {
		Connection conn = null;
		Employee employee = null;
		try {
			
			// Open a connection using DB url
			conn = dataSource.getConnection();
			
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
			conn = dataSource.getConnection();
			
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
			conn = dataSource.getConnection();
			
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
			conn = dataSource.getConnection();
			
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
