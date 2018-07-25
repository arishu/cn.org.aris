package cn.org.aris.java.springinaction.chap1.eliminateboilerplatecodes;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;

public class JDBCManager {
	
	private static final ConnectionSet dataSource = ConnectionSet.getInstance();
	private static final JdbcTemplate jdbcTemplate = new JdbcTemplate();
	
	public Employee getEmployeeById(String id) {
		String sql = "select id, age, firstName, lastName, salary from "
				+ "employee where id = ?";
		return jdbcTemplate.queryForObject(sql, new RowMapper<Employee>() {

			@Override
			public Employee mapRow(ResultSet rs, int rowNum) throws SQLException {
				Employee emp = new Employee();
				emp.setEmpId(rs.getString("id"));
				emp.setFirstName(rs.getString("firstName"));
				emp.setLastName(rs.getString("lastName"));
				emp.setSalary(rs.getDouble("salary"));
				return emp;
			}
		}, id);
	}
	
	public Employee getEmployeeByIdWithJDBC(String id) {
		Connection conn = null;
		Statement stmt = null;
		ResultSet rs = null;
		
		try {
			conn = dataSource.getConnection();
			stmt = conn.createStatement();
			String sql = "select id, age, firstName, lastName, salary from "
					+ "employee where id = '" + id + "'";
			stmt.executeQuery(sql);
			
			if (stmt.execute(sql)) {
				rs = stmt.getResultSet();
			}
			
			Employee emp = null;
			if (rs.next()) {
				emp = new Employee();
				emp.setEmpId(rs.getString("id"));
				emp.setAge(rs.getShort("age"));
				emp.setFirstName(rs.getString("firstName"));
				emp.setLastName(rs.getString("lastName"));
				emp.setSalary(rs.getDouble("salary"));
			}
			return emp;
		} catch (SQLException e) {
			
		} finally {
			if (rs != null) {
				try {
					rs.close();
				} catch (SQLException e2) {}
			}
			
			if (stmt != null) {
				try {
					stmt.close();
				} catch (SQLException e2) {}
			}
			
			if (conn != null) {
				try {
					conn.close();
				} catch (SQLException e2) {}
			}
		}
		return null;
	}
	
}
