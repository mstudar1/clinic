USE cs6232-g2;

DROP PROCEDURE IF EXISTS getMostPerformedTestsDuringDates;
DELIMITER $

CREATE PROCEDURE getMostPerformedTestsDuringDates( 
    IN startDate DATE,
    IN endDate DATE
    )
BEGIN
	DECLARE newOrderID INT DEFAULT 0;   

	/* Verify that dates are nto in the future */
	IF startDate > CURDATE() OR endDate > CURDATE() THEN
		SIGNAL SQLSTATE '22003'
        SET MESSAGE_TEXT = 'Date cannot be in the future', 
        MYSQL_ERRNO = 1264;
	END IF;
    
    /* Verify that dates are not the same */
	IF startDate = endDate  THEN
		SIGNAL SQLSTATE '22003'
        SET MESSAGE_TEXT = 'Dates cannot be the same', 
        MYSQL_ERRNO = 1264;
	END IF;
    
	/* Verify that endDate is after startDate */
	IF startDate > endDate  THEN
		SIGNAL SQLSTATE '22003'
        SET MESSAGE_TEXT = 'End date cannot be before start date', 
        MYSQL_ERRNO = 1264;
	END IF;
    
    /* Build result */
	SELECT
		c.CategoryName AS `Category Name`,
        s.CompanyName AS `Supplier Company Name`,
        CONCAT("$ ", FORMAT(SUM(od.Quantity * (od.unitPrice - (od.unitPrice * od.Discount))), 2)) 
			AS `Total Dollar Amount`,
        COUNT(*) AS `Number of Orders`
	FROM
		orders o
        JOIN `order details` od ON o.OrderID = od.OrderID
        JOIN products p ON od.ProductID = p.ProductID
        JOIN categories c ON p.CategoryID = c.CategoryID
        JOIN suppliers s ON p.SupplierID = s.SupplierID
	WHERE
		o.OrderDate > startDate
        AND o.OrderDate < endDate
	GROUP BY
		c.CategoryID, s.SupplierID
	ORDER BY
		c.CategoryName, s.CompanyName
	;	
        

END$
DELIMITER ;
