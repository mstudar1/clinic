USE [cs6232-g2]
GO

 /* Create fnction to determine if test subject fits age range */
CREATE OR ALTER FUNCTION isInAgeRange(
	@appointmentId INT, 
	@testDate DATETIME, 
	@lowAge INT, 
	@highAge INT)
RETURNS INT
AS
BEGIN
	DECLARE @dateOfBirth AS DATE;
	DECLARE @returnValue AS int;
	SET @returnValue = null;

	SELECT 
		@dateOfBirth = per.dateOfBirth 
	FROM 
		Appointment app
		JOIN Patient pat ON app.patientId = pat.patientId
		JOIN Person per ON pat.personId = per.personId 
	WHERE 
		app.appointmentId = appointmentId;

	IF (DATEDIFF(d, @testDate, @dateOfBirth) / 365.25) >= @lowAge 
		AND (DATEDIFF(d, @testDate, @dateOfBirth)) / 365.25 <= @highAge 
	BEGIN
		SET @returnValue = 1;
	END

	RETURN @returnValue;
END
GO