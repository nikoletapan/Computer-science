USE company;

DELIMITER $$

CREATE FUNCTION udf_project_weeks(start_date DATETIME, end_date DATETIME)
RETURNS INT
BEGIN
	DECLARE project_weeks INT;
		IF(end_date IS NULL) THEN
		SET end_date := NOW();
		END IF;
	SET project_weeks := DATEDIFF(DATE(end_date), DATE(start_date)) / 7;
	RETURN project_weeks;
END $$

CREATE FUNCTION udf_get_salary_level(salary DECIMAL(19,4))
RETURNS VARCHAR(10)
BEGIN
	DECLARE salary_level VARCHAR(10);
	IF (salary < 30000) THEN                                       
		SET salary_level := 'Low';
		ELSEIF(salary >= 30000 AND salary <= 50000) THEN
		SET salary_level := 'Average';
		ELSE
		SET salary_level := 'High';
		END IF;
	RETURN salary_level;
END $$
