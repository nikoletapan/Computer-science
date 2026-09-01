use geography;

-- най-високият връх:
SELECT *
FROM peaks 
WHERE elevation = 
  (SELECT elevation FROM peaks 
   ORDER BY elevation DESC 
   LIMIT 1);


-- най-дългата река във всеки водоем
SELECT river_name, length, outflow
FROM rivers AS r 
WHERE length = 
  (SELECT length FROM rivers 
   WHERE outflow = r.outflow -- повторението 
   ORDER BY length DESC 
   LIMIT 1)
ORDER BY outflow;

-- най-високият връх за всяка планина
SELECT *
FROM peaks AS p 
WHERE elevation = 
  (SELECT elevation FROM peaks 
   WHERE mountain_id = p.mountain_id -- планина по веднъж
   ORDER BY elevation DESC 
   LIMIT 1)
ORDER BY mountain_id;
use company;

-- най-високата заплата и служителят, които я получава
SELECT first_name, last_name, department_id, salary
FROM employees WHERE salary = 
  (SELECT salary FROM employees
  ORDER BY salary DESC 
  LIMIT 1);

-- най-високата заплата от всеки отдел и служителя, който я получава
SELECT first_name, last_name, department_id, salary
FROM employees AS e 
WHERE Salary = 
  (SELECT salary FROM employees 
   WHERE department_id = e.department_id -- отдел по веднъж
   ORDER BY salary DESC 
   LIMIT 1)
ORDER BY department_id;

-- Изведете всички служители от отдел финанси, ако знаем id:
SELECT first_name, first_name, department_id, salary 
FROM employees AS e 
WHERE e.department_id = 10;
  
-- Изведете всички служители от отдел финанси, ако не знаем id: 
-- тогава трябва да използваме id като връзка между 2 таблици:
-- employee AS e и departments AS d 
-- и да погледнем името във втората таблица: 
SELECT first_name, first_name, department_id, salary 
FROM employees AS e WHERE EXISTS              
( SELECT d.department_id FROM departments AS d -- влизамв във втора таблица
  WHERE e.department_id = d.department_id      -- id_първа = id_втора (връзка)
  AND d.name = 'Finance' );                    -- името от втората
  
 -- Тримата най-високоплатени служители извън отдел Финанси: 
SELECT first_name, first_name, department_id, salary 
FROM employees e WHERE NOT EXISTS
( 
SELECT department_id FROM departments d
	WHERE e.department_id = d.department_id
		AND d.name = 'Finance' 
)
ORDER BY salary DESC LIMIT 3;

  
-- служители от отдел 6
SELECT employee_id, first_name, last_name, department_id, manager_id, salary
FROM employees
WHERE department_id = 1;

-- да се покажат служителите мениджър от отдел 6 с IN
SELECT employee_id, first_name, last_name, department_id, manager_id, salary 
FROM employees  
WHERE manager_id = ANY            
(SELECT employee_id FROM employees 
WHERE department_id = 1);  

-- да се покажат служители от отдел 6 с мениджър и EXISTS
SELECT employee_id, first_name, last_name, department_id, manager_id, salary 
FROM employees AS e 
WHERE EXISTS            
(SELECT employee_id FROM employees AS m
WHERE m.employee_id = e.manager_id
AND m.department_id = 1); 


  
  
SELECT first_name, first_name, department_id, salary 
FROM employees e WHERE NOT EXISTS
( 
SELECT d.department_id FROM departments d
	WHERE e.department_id = d.department_id
		AND d.name = 'Finance' 
ORDER BY salary DESC LIMIT 1;


