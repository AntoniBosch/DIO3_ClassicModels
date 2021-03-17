CREATE PROCEDURE `cm_getOrdersByName` (
in _name VARCHAR(250)
)
BEGIN
	select distinct(orderNumber) 
	from orders
	NATURAL JOIN customers
	where customerName = _name ;

END
