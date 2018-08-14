<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags" %>
<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8" http-equiv="Content-Type" content="text/html">
	<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">
	<title>Products</title>
</head>
<body>
	
	<section>
		<div class="jumbotron">
			<div class="container">
				<h1>Products</h1>
			</div>
		</div>
	</section>
	
	<section class="container">
		<div class="row">
			
			<div class="col-md-5">
				<img alt="image" src="<c:url value="/img/${product.productId}.png"></c:url>" style="width:100%" />
			</div>
			
			<div class="col-md-5">
				<h3>${product.name}</h3>
				<p>${product.description}</p>
				<p>
					<strong>Item Code: </strong>
					<span class="label label-warning">${product.productId}</span>
				</p>
				
				<p>
					<strong>manufacturer</strong>: ${product.manufacturer}
				</p>
				
				<p>
					<strong>category</strong>: ${product.category}
				</p>
				
				<p>
					<strong>Available units in stock</strong>: ${product.unitsInStock}
				</p>
				
				<p>
					<h4>${product.unitPrice}</h4>
				</p>
				
				<p>
					<a href="<spring:url value="/market/products"/>"
						class="btn btn-default">
						
						<span class="glyphicon-hand-left glyphicon"></span> back
					</a>
				
					<a href="#" class="btn btn-warning btn-large">
						<span class="glyphicon-shopping-cart glyphicon">Order Now</span>
					</a>
				</p>
				
			</div>
		</div>
	</section>
</body>
</html>