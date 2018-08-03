package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.BatchPreparedStatementSetter;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Types;
import java.util.List;

@Repository
public class EmployeeDaoImpl implements EmployeeDao {

	@Autowired
	private JdbcTemplate jdbcTemplate;
	
	@Override
	public void deleteEmployee() {
		this.jdbcTemplate.execute("drop table employee");
	}
	
	@Override
	public void createEmployee() {
		this.jdbcTemplate.execute("create table employee (EmpId integer, Name char(30))");
	}

	@Override
	public int getEmployeeCount() {
		String sql = "select count(*) from employee";
		return this.jdbcTemplate.queryForObject(sql, int.class);
	}

	@Override
	public void insertEmployee(Employee employee) {
		String insertQuery = "insert into employee (EmpId, Name) values (?, ?, ?) ";
		Object[] params = new Object[] { employee.getId(), employee.getName()};
		int[] types = new int[] { Types.INTEGER, Types.VARCHAR, Types.INTEGER };
		this.jdbcTemplate.update(insertQuery, params, types);
	}
	
	@Override
	public void insertEmployees(List<Employee> employees) {
		this.jdbcTemplate.batchUpdate("INSERT INTO employee "
				+ " (EmpId, Name) VALUES (?, ?)",new BatchPreparedStatementSetter() {
					
					@Override
					public void setValues(PreparedStatement ps, int i) throws SQLException {
						Employee employee = employees.get(i);
						ps.setLong(1, employee.getId());
						ps.setString(2, employee.getName());
					}
					
					@Override
					public int getBatchSize() {
						return employees.size();
					}
				});
			
	}

	@Override
	public Employee getEmployeeById(int empId) {
		String query = "select * from Employee where EmpId = ?";
		
		Employee employee = this.jdbcTemplate.queryForObject(query, new Object[] { empId }, new RowMapper<Employee>() {
			@Override
			public Employee mapRow(ResultSet rs, int rowNum) throws SQLException {
				Employee employee = new Employee(rs.getInt("EmpId"), rs.getString("Name"));
				return employee;
			}
		});
		return employee;
	}
	
	@Override
	public int deleteEmployeeById(int empId) {
		String deleteQuery = "delete from employee where EmpId = ?";
		return this.jdbcTemplate.update(deleteQuery, new Object[] {empId});
	}
}
