<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="spring" uri="http://www.springframework.org/tags" %>
<%@ taglib prefix="sf" uri="http://www.springframework.org/tags/form"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">
<title>Products</title>
</head>
<body>
	<section>
		<div class="pull-right" style="padding-right:50px">
			<a href="?lang=en">English</a>|<a href="?lang=zh">Chinese</a>
		</div>
	</section>

	<section>
		<div class="jumbotron">
			<div class="container">
				<h1>Products</h1>
				<p>Add products</p>
			</div>
		</div>
	</section>

	<section class="container">
		<sf:form method="POST" modelAttribute="newProduct"
			class="form-horizontal" enctype="multipart/form-data">
			
			<sf:errors path="*" cssClass="alert alert-danger" element="div" />
			
			<fieldset>
				<legend>Add New Product</legend>

				<!-- Product ID -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="productId">
						<!-- Product Id -->
						<spring:message code="addProduct.form.productId.label"/>
					</label>
					<div class="col-lg-10">
						<sf:input id="productId" path="productId" type="text"
							class="form:input-large" />
						<sf:errors path="productId" cssClass="text-danger" />
					</div>
				</div>

				<!-- Name -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="name">
						<!-- Name -->
						<spring:message code="addProduct.form.name.label" />
					</label>
					<div class="col-lg-10">
						<sf:input id="name" path="name" type="text"
							class="form:input-large" />
						<sf:errors path="name" cssClass="text-danger"/>
					</div>
				</div>
				
				<!-- Unit Price -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="unitPrice">
						<!-- Unit Price -->
						<spring:message code="addProduct.form.unitPrice.label" />
					</label>
					<div class="col-lg-10">
						<sf:input id="unitPrice" path="unitPrice" type="text"
							class="form:input-large" />
						<sf:errors path="unitPrice" cssClass="text-danger"/>
					</div>
				</div>

				<!-- Manufacturer -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="manufacturer">
						<!-- Manufacturer -->
						<spring:message code="addProduct.form.manufacturer.label" />
					</label>
					<div class="col-lg-10">
						<sf:input id="manufacturer" path="manufacturer" type="text"
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
						<sf:input id="category" path="category" type="text"
							class="form:input-large" />
						<sf:errors path="category" cssClass="text-danger"/>
					</div>
				</div>

				<!-- Unit In Stock -->
				<div class="form-group">
					<label class="control-label col-lg-2 col-lg-2" for="unitsInStock">
						<!-- Unit In Stock -->
						<spring:message code="addProduct.form.unitsInStock.label" />
					</label>
					<div class="col-lg-10">
						<sf:input id="unitsInStock" path="unitsInStock" type="text"
							class="form:input-large" />
						<sf:errors path="unitsInStock" cssClass="text-danger"/>
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
						<sf:textarea id="description" path="description" rows="2" />
					</div>
				</div>

				<!-- Condition -->
				<div class="form-group">
					<label class="control-label col-lg-2" for="condition">
						<!-- Condition -->
						<spring:message code="addProduct.form.condition.label" />
					</label>
					<div class="col-lg-10">
						<sf:radiobutton path="condition" value="New" />
						New
						<sf:radiobutton path="condition" value="Old" />
						Old
						<sf:radiobutton path="condition" value="Refurbished" />
						Refurbished
					</div>
				</div>
				
				<!-- Product Image -->
				<div class="form-group">
					<label class="control-label col-lg-2" for="productImage">
						<spring:message code="addProduct.form.productImage.label" />
					</label>
					
					<div class="col-lg-10">
						<sf:input id="productImage" path="productImage" type="file" class="form:input-large"/>
					</div>
				</div>
				
				<!-- Product Manual PDF -->
				<div class="field-group">
					<label class="control-label col-lg-2" for="productManualPdf">
						<spring:message code="addProduct.form.productManualPdf.label"/>
					</label>
					
					<div class="col-lg-10">
						<sf:input id="productManualPdf" path="productManualPdf" type="file" class="form:input-large"/>
					</div>
				</div>
				
				<div class="form-group">
					<div class="col-lg-offset-2 col-lg-10">
						<input type="submit" id="btnAdd" class="btn btn-primary"
							value="Add" />
					</div>
				</div>
			</fieldset>
		</sf:form>
	</section>
</body>
</html>