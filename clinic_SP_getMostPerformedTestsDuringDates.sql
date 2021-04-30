USE [cs6232-g2]
GO

 /* Create main procedure for getting tests stats */ 
DROP PROCEDURE IF EXISTS getMostPerformedTestsDuringDates
GO

CREATE PROCEDURE getMostPerformedTestsDuringDates( 
    @startDate AS DATE,
    @endDate AS DATE
    )
AS
BEGIN
	/* Verify that dates are nto in the future */
	IF @startDate > GETDATE()
	BEGIN
		RAISERROR('Invalid parameter: Start date cannot be in the future', 12, 1)
		RETURN
	END
    
    /* Verify that dates are not the same */
	IF @startDate = @endDate 
	BEGIN
		RAISERROR('Invalid parameter: Dates cannot be the same', 12, 1)
		RETURN
	END
    
	/* Verify that endDate is after startDate */
	IF @startDate > @endDate 
	BEGIN
		RAISERROR('Invalid parameter: End date cannot be before start date', 12, 1)
		RETURN
	END

	/* Declare variable to hold total test count */
	DECLARE @totalTestCount INT;

	/* Get and store count of total tests performed */
    SET @totalTestCount = (
		SELECT COUNT(*) AS totalTests
		FROM ConductedLabTest
		WHERE datePerformed > @startdate
			AND datePerformed < @enddate
	);
    
    /* Build result */
	SELECT
		clt.testCode, 
		lt.name, 
		COUNT(*) AS testCount,  
		@totalTestCount AS totalTests,
		CONCAT(ROUND((100 * COUNT(*) / @totalTestCount),1), '%') AS percentOfTests,   
		COUNT(CASE WHEN clt.isNormal = 1 THEN 1 ELSE NULL END) AS normalCount,
		COUNT(CASE WHEN clt.isNormal = 0 THEN 1 ELSE NULL END) AS abnormalCount,
		COUNT(CASE WHEN 
			DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) >= 0 
				AND DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) <= 17 
			THEN 1 ELSE NULL END) AS testsBirthTo17,
		COUNT(CASE WHEN 
			DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) >= 18 
				AND DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) <= 29 
			THEN 1 ELSE NULL END) AS tests18to29,
		COUNT(CASE WHEN 
			DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) >= 30 
				AND DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) <= 39 
			THEN 1 ELSE NULL END) AS tests30to39,
		COUNT(CASE WHEN 
			DATEDIFF(yy, per.dateOfBirth, clt.datePerformed) >= 40  
			THEN 1 ELSE NULL END) AS testsOver39
	FROM
		ConductedLabTest clt
        JOIN LabTest lt ON clt.testCode = lt.testCode
		JOIN Appointment a ON clt.appointmentId = a.appointmentId
		JOIN Patient pat ON a.patientId = pat.patientId
		JOIN Person per ON pat.personId = per.personId
	WHERE datePerformed > @startdate
		AND datePerformed < @enddate
	GROUP BY clt.testCode, lt.name
	HAVING COUNT(*) > 1
    ORDER BY COUNT(*) DESC, clt.testCode DESC
	;
END
