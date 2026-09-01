CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_get_customers`()
BEGIN
	SELECT 
		customerName, 
		city, 
		state, 
		postalCode, 
		country
	FROM
		customers
	ORDER BY customerName;    
END