use company;

/*1*/
-- Да се намерят всички най-нископлатени служители
SELECT first_name, last_name, job_title
FROM employees
where employee_id in
(
    SELECT DISTINCT manager_id 
    FROM employees
)
ORDER BY first_name, last_name
;

/*2*/
-- Всички служители с до 10% по-висока заплата от минималната 
-- salary <= 1.1 * (salary)
SELECT first_name, last_name, salary from employees
WHERE salary <= 1.1 *   
(
SELECT salary FROM employees
ORDER BY salary ASC
LIMIT 1
) 
ORDER BY salary ASC
;

/*3*/
-- име, фамилия, длъжност на всички мениджъри, сортирани по име и фамилия
SELECT first_name, last_name, job_title 
FROM employees
WHERE employee_id IN 
(
	SELECT DISTINCT manager_id
	FROM employees 
)
ORDER BY first_name, last_name;

/*4*/
-- имената на всички служители, живеещи в Сан Франциско
SELECT first_name, last_name, address_id
FROM employees
WHERE address_id IN
(
	SELECT address_id FROM addresses
	WHERE town_id IN
	(
		SELECT town_id 
		FROM towns 
		WHERE NAME = 'San Francisco'
))
ORDER BY first_name, last_name;

/*5*/
USE geography;
    
-- Намерете всички върхове в България и ги подредете по височина    
SELECT peak_name, elevation
FROM peaks
WHERE mountain_id IN
(
    SELECT mountain_id 
    FROM mountains_countries   
    WHERE country_code = 'BG'
)
ORDER BY elevation DESC;