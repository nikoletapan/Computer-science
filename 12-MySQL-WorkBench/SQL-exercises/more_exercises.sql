SELECT * FROM projects
WHERE MONTH(start_date)=06 AND YEAR(start_date)=2001; 

-- Да се заменят последните 4 цифри от ЕГН със **** по подобен на C# начин
-- 1)
SELECT first_name, last_name, LEFT(EGN,6) + '****' AS EGN FROM employees;
-- 2)
SELECT first_name, last_name, REPLACE(EGN, RIGHT(EGN,4), '****') FROM employees;

-- всички служители извън отдел 4, друг запис на !=
SELECT first_name, last_name
FROM employees
WHERE department_id <> 4;

-- по-сложна конкатенация - ако съществува бащино име, да се изпише
CREATE VIEW v_employees_job_titles AS
SELECT 
CONCAT(first_name, ' ', (case when middle_name IS NULL THEN '' ELSE middle_name END), ' ', last_name) 
AS "Full Name", job_title
FROM employees;

-- вместо update за view
CREATE OR REPLACE VIEW v_employees_salary AS
SELECT salary + salary * 0.1 as salary_new
FROM employees
WHERE department_id IN (1, 2, 4, 11);

-- DROP VIEW - имената започват винаги с v_





