<%@ taglib prefix="spring" uri="http://www.springframework.org/tags" %>

<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
</head>
<body>
	<h1><spring:message code="home.title"/></h1>
	<p><spring:message code="home.intro"/></p>
	
	<p>
		<a href="?lang=en">English</a>
		<a href="?lang=cn">中文</a>
	</p>
	
</body>
</html>