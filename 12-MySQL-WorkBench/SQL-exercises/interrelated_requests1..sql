use company;

/*3*/
-- Най-висока заплата по длъжности = 58 rows
SELECT DISTINCT job_title, salary
FROM employees AS e
WHERE salary =
(
SELECT salary
FROM employees
WHERE job_title = e.job_title
ORDER BY salary DESC
LIMIT 1
)
ORDER BY salary DESC, job_title ASC;

-- втори начин 1 заявка, 58 rows, не разрешава ORDER BY salary DESC
SELECT DISTINCT job_title, MAX(salary)
FROM employees
GROUP BY job_title
ORDER BY job_title asc; -- GROUP BY -||- ORDER BY 1 и съща колона

-- трети начин - 61 реда външна заявка, 58 вътрешна.
SELECT DISTINCT job_title, salary -- без salary 58 реда
FROM employees 
WHERE salary IN
(
SELECT max(salary)
FROM employees
GROUP BY job_title
ORDER BY salary desc, job_title asc
);

/*4*/
-- Най-ниско платени служители по отдели
-- 76 rows
SELECT CONCAT(first_name, ' ', last_name) AS 'Full name',
(
    SELECT d.name 
    FROM departments AS d 
    WHERE e.department_id = d.department_id
) AS department, salary 
FROM employees AS e 
WHERE e.salary = 
(
    SELECT salary 
    FROM employees 
    WHERE department_id = e.department_id
    ORDER BY salary ASC 
    LIMIT 1
)
ORDER BY e.salary, e.first_name, e.last_name;

-- 116 rows
SELECT CONCAT(first_name, ' ', last_name) AS 'Full name',
(
    SELECT d.name 
    FROM departments AS d 
    WHERE e.department_id = d.department_id
) AS department, salary 
FROM employees AS e 
WHERE e.salary IN 
(
    SELECT MIN(salary) 
    FROM employees 
    GROUP BY department_id
    ORDER BY salary ASC 
)
ORDER BY e.salary, e.first_name, e.last_name;

select * from employees;
/*5*/
-- Мениджъри с точно 5 подчинени
SELECT first_name, last_name
FROM employees AS e 
WHERE employee_id IN 
(
    SELECT DISTINCT manager_id 
    FROM employees
) 
AND EXISTS 
(
    SELECT 1 
    FROM employees 
    WHERE manager_id = e.employee_id 
    LIMIT 4, 1 -- limit 1 offset 4
)
AND NOT EXISTS 
(
    SELECT 1 
    FROM employees 
    WHERE manager_id = e.employee_id
    LIMIT 5, 1
)
ORDER BY first_name, last_name;
