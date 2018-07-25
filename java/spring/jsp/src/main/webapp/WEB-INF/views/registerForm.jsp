<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="sf" %>
<%@ page session="false" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<title>Spitter</title>
</head>
<body>
	<h1>Register</h1>
	
	<sf:form method="POST" commandName="spitter">
		<sf:errors path="*" element="div" cssClass="errors"/>
		<sf:label path="firstName" cssErrorClass="error">First Name</sf:label>:
		<sf:input path="fileName" cssErrorClass="error"/> <br/>
		
		<sf:label path="lastName" cssErrorClass="error">Last Name</sf:label>:
		<sf:input path="lastName" cssErrorClass="error"/> <br/>
		
		<sf:label path="email" cssErrorClass="error">email</sf:label>:
		<sf:input path="email" cssErrorClass="error"/> <br/>
		
		<sf:label path="username" cssErrorClass="error">UserName</sf:label>:
		<sf:input path="username" cssErrorClass="error"/> <br/>
		
		<sf:label path="password" cssErrorClass="error">Password</sf:label>:
		<sf:password path="password" cssErrorClass="error"/> <br/>
		
		<input type="submit" value="Register">
	</sf:form>
</body>
</html>