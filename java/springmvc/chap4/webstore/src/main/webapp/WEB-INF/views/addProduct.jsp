<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet"
	href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">
<title>Products</title>
</head>
<body>
	<section>
		<div class="jumbotron">
			<div class="container">
				<h1>Products</h1>
				<p>Add products</p>
			</div>
		</div>
	</section>

	<section class="container">
		<form:form method="POST" modelAttribute="newProduct"
			class="form-horizontal">
			<fieldset>
				<legend>Add New Product</legend>

				<!-- Product ID -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="productId">
						<!-- Product Id -->
						<spring:message code="addProduct.form.productId.label"/>
					</label>
					<div class="col-lg-10">
						<form:input id="productId" path="productId" type="text"
							class="form:input-large" />
					</div>
				</div>

				<!-- Name -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="name">
						<!-- Name -->
						<spring:message code="addProduct.form.name.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="name" path="name" type="text"
							class="form:input-large" />
					</div>
				</div>
				
				<!-- Unit Price -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="unitPrice">
						<!-- Unit Price -->
						<spring:message code="addProduct.form.unitPrice.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="unitPrice" path="unitPrice" type="text"
							class="form:input-large" />
					</div>
				</div>

				<!-- Manufacturer -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="manufacturer">
						<!-- Manufacturer -->
						<spring:message code="addProduct.form.manufacturer.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="manufacturer" path="manufacturer" type="text"
							class="form:input-large" />
					</div>
				</div>

				<!-- Category -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="category">
						<!-- Category -->
						<spring:message code="addProduct.form.category.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="category" path="category" type="text"
							class="form:input-large" />
					</div>
				</div>

				<!-- Unit In Stock -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="unitsInStock">
						<!-- Unit In Stock -->
						<spring:message code="addProduct.form.unitsInStock.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="unitsInStock" path="unitsInStock" type="text"
							class="form:input-large" />
					</div>
				</div>
				
				<!-- Unit In Order -->
				<%-- <div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="unitsInOrder">
						Unit In Order
						<spring:message code="addProduct.form.unitsInOrder.label" />
					</label>
					<div class="col-lg-10">
						<form:input id="unitsInStock" path="unitsInOrder" type="text"
							class="form:input-large" />
					</div>
				</div> --%>
				
				<!-- Description -->
				<div class="form-group">
					<label class="control-label col-lg-2" for="description">
						<!-- Description -->
						<spring:message code="addProduct.form.description.label" />
					</label>
					<div class="col-lg-10">
						<form:textarea id="description" path="description" rows="2" />
					</div>
				</div>

				<!-- Condition -->
				<div class="form-group">
					<label class="control-label col-lg-2" for="condition">
						Condition
						<%-- <spring:message code="addProduct.form.condition.label" /> --%>
					</label>
					<div class="col-lg-10">
						<form:radiobutton path="condition" value="New" />
						New
						<form:radiobutton path="condition" value="Old" />
						Old
						<form:radiobutton path="condition" value="Refurbished" />
						Refurbished
					</div>
				</div>

				<div class="form-group">
					<div class="col-lg-offset-2 col-lg-10">
						<input type="submit" id="btnAdd" class="btn btn-primary"
							value="Add" />
					</div>
				</div>
			</fieldset>
		</form:form>
	</section>
</body>
</html>