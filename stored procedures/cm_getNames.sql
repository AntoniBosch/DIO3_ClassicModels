CREATE PROCEDURE `cm_getNames` (
in _name VARCHAR(250)
)
BEGIN
select customerName 
from customers
WHERE customerName LIKE CONCAT('%', _name, '%') ;
END