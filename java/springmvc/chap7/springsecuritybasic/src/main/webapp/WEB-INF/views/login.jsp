<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="s" uri="http://www.springframework.org/tags" %>
<%@ taglib prefix="sf" uri="http://www.springframework.org/tags/form" %>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">
	<link rel="stylesheet" href="/springsecuritybasic/font-awesome/font-awesome.min.css">
	<title>Products</title>
</head>
<body>
	<section>
		<div class="jumbotron">
			<div class="container">
				<h1>Welcome to Web Store</h1>
				<p>The one and only amazing web store</p>
			</div>
		</div>
	</section>
	
	<div class="container">
		<div class="row">
			<div class="col-md-4 col-md-offset-4">
				<div class="panel panel-default">
					
					<div class="panel-heading">
						<div class="panel-title">Please Sign in</div>
					</div>
					
					<div class="panel-body">
						<c:url var="loginUrl" value="/login"/>
						
						<sf:form action="${loginUrl}" method="post" class="form-horizontal">
							
							<c:if test="${param.error != null }">
								<div class="alert alert-danger">
									<p>Invalid username and password</p>
								</div>
							</c:if>
							
							<c:if test="${param.logout != null}">
								<div class="alert alert-success">
									<p>You have been logged out successfully.</p>
								</div>
							</c:if>
							
							<c:if test="${param.accessDenied != null}">
								<div class="alert alert-danger">
									<p>Access Denied: you are not authorized!</p>
								</div>
							</c:if>
							
							<div class="input-group input-sm">
								<label class="input-group-addon" for="username">
									<i class="fa fa-user"></i>
								</label>
								<input type="text" class="form-control" id="userId" name="userId" required="required">
							</div>
							
							<div class="input-group input-sm">
								<label class="input-group-addon" for="password">
									<i class="fa fa-lock"></i>
								</label>
								<input type="password" class="form-control" id="password" name="password" 
									placeholder="EnterPassword" required="required">
							</div>
							
							<div class="form-actions">
								<input type="submit" class="btn btn-block btn-primary btn-default" value="Log in">
							</div>
							
						</sf:form>
					</div>
				</div>
			</div>
		</div>
	</div>
</body>
</html>