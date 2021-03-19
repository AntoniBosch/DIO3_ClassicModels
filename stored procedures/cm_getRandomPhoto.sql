CREATE PROCEDURE  `cm_getRandomPhoto`(
in _name VARCHAR(250)
)
BEGIN
select image
from productlines
where productline = _name;
END