package cn.org.aris.java.enterprisespring.chap3.JDBC.dao;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.namedparam.MapSqlParameterSource;
import org.springframework.jdbc.core.namedparam.SqlParameterSource;
import org.springframework.jdbc.core.simple.SimpleJdbcCall;
import org.springframework.stereotype.Repository;

import cn.org.aris.java.enterprisespring.chap3.JDBC.model.Employee;

import java.sql.Types;
import java.util.Map;

import javax.sql.DataSource;

@Repository
public class EmployeeDaoImpl implements EmployeeDao {

	@Autowired
	private DataSource dataSource;
	
	@Autowired
	private JdbcTemplate jdbcTemplate;
	
	private SimpleJdbcCall jdbcCall;
	
	@Autowired
	public void setDataSource(DataSource dataSource) {
		this.dataSource = dataSource;
		this.jdbcCall = new SimpleJdbcCall(dataSource).withProcedureName("getEmployee");
	}
	
	@Override
	public void deleteEmployee() {
		this.jdbcTemplate.execute("drop table employee");
	}
	
	@Override
	public void createEmployee() {
		this.jdbcTemplate.execute("create table employee (EmpId integer, Name char(30), Age integer)");
	}

	@Override
	public int getEmployeeCount() {
		String sql = "select count(*) from employee";
		return this.jdbcTemplate.queryForObject(sql, int.class);
	}

	@Override
	public void insertEmployee(Employee employee) {
		String insertQuery = "insert into employee (EmpId, Name, Age) values (?, ?, ?) ";
		Object[] params = new Object[] { employee.getId(), employee.getName(), employee.getAge()};
		int[] types = new int[] { Types.INTEGER, Types.VARCHAR, Types.INTEGER };
		this.jdbcTemplate.update(insertQuery, params, types);
	}

	@Override
	public Employee getEmployeeById(int empId) {
		SqlParameterSource in = new MapSqlParameterSource().addValue("id", empId);
		Map<String, Object> simpleJdbcCallResult = jdbcCall.execute(in);
		Employee employee = new Employee(empId, (String)simpleJdbcCallResult.get("name"));
		return employee;
	}
	
	@Override
	public int deleteEmployeeById(int empId) {
		String deleteQuery = "delete from employee where EmpId = ?";
		return this.jdbcTemplate.update(deleteQuery, new Object[] {empId});
	}
}
