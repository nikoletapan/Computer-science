Use company;

-- Подзаявки:
SELECT * FROM employees
WHERE department_id = 4;

-- department_id = 10 в таблица 1 departments съответства на name = 'Marketing'
-- ако не знаем id, но знаем името от главната таблица 1:
SELECT * FROM employees
WHERE department_id IN 
( 
	SELECT department_id -- трябва колоната да съвпада
	FROM departments -- бръкваме във втората таблица
	WHERE name = 'Sales'
);

-- = ANY, = SOME
SELECT * FROM employees
WHERE department_id = SOME 
( 
	SELECT department_id 
	FROM departments 
	WHERE name = 'Sales'
);

SELECT * FROM employees 
WHERE department_id IN -- външен ключ
( 
SELECT department_id -- първичен ключ
FROM departments 
WHERE name = 'Marketing'
);

-- вместо * слагаме няколко колони
SELECT first_name, last_name, department_id, salary
FROM employees 
WHERE department_id IN -- външен ключ
( 
SELECT department_id -- първичен ключ
 FROM departments 
WHERE name = 'Marketing'
);

-- Най-високата заплата
SELECT * FROM employees
ORDER BY salary DESC
LIMIT 1;

-- Определени колони на човек с най-висока заплата
SELECT first_name, last_name, salary
FROM employees
ORDER BY salary DESC
LIMIT 1;

-- Възможни са няколко души с най-висока заплата
SELECT first_name, last_name, salary
FROM employees
WHERE salary =
(
SELECT salary 
FROM employees
ORDER BY salary DESC
LIMIT 1
);

SELECT first_name, last_name, department_id, salary
FROM employees
WHERE department_id IN
(
SELECT department_id
FROM departments
WHERE name = 'Sales'
);




