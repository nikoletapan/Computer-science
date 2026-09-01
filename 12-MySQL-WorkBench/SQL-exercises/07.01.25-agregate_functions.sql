USE geography;

-- Намерете имената и височините на всички планини - резултат 48 реда
SELECT peak_name, elevation
FROM peaks;

-- Колко е броят на всички върхове?
SELECT COUNT(*) FROM peaks; -- 1 ред резултат за 48 записа

-- Агрегиращи функции
SELECT MAX(elevation) FROM peaks; -- 8848
SELECT MIN(elevation) FROM peaks; -- 2016
SELECT AVG(elevation) FROM peaks; -- 4891.2708
SELECT SUM(elevation) FROM peaks; -- 234781
SELECT SUM(elevation) / 48 FROM peaks; -- проверка на AVG
SELECT SUM(elevation) / COUNT(elevation) FROM peaks; -- проверка 2 на AVG

-- Намерете името и височината на най-високия връх
SELECT peak_name, elevation FROM peaks 
ORDER BY elevation DESC
LIMIT 1;

-- Име и височина на най-висок връх с MAX() - грешка:
SELECT peak_name, MAX(elevation) FROM peaks;

-- Име и височина на най-висок връх с MAX + GROUP BY - грешка:
SELECT peak_name, MAX(elevation) FROM peaks
GROUP BY mountain_id;

-- Най-високият връх за всяка планина с MAX + GROUP BY -- 22 реда:
SELECT mountain_id, MAX(elevation) FROM peaks
GROUP BY mountain_id;

-- Най-високият връх за всяка планина с MAX + GROUP BY -- 22 реда:
SELECT MAX(elevation) FROM peaks
GROUP BY mountain_id;

-- Най-високият връх за всяка планина, подредени по височина:
SELECT MAX(elevation) AS Elevation
FROM peaks
GROUP BY mountain_id
ORDER BY elevation DESC;

-- Извод: Limit дава много по-голяма гъвкавост
-- включват се повече колони и може да върне повече стойности:
SELECT elevation AS Elevation
FROM peaks
ORDER BY elevation DESC
LIMIT 1;

-- Името и височината на най-високите върхове за всяка планина, 
-- подредени по височина с MAX + GROUP BY: 
SELECT peak_name, elevation
FROM peaks
WHERE elevation IN -- =
(
SELECT Max(elevation)
FROM peaks
GROUP BY mountain_id
)
ORDER BY elevation DESC;

-- Нека се върнем към познатия начин и намерим отново 
-- височината на най-високия връх:
SELECT elevation
FROM peaks
ORDER BY elevation DESC
LIMIT 1;

-- Намерете най-високите върхове от всяка планина
-- по друг начин - order by + limit
SELECT peak_name, elevation
FROM peaks AS p
WHERE elevation = 
(
SELECT elevation
FROM peaks
WHERE mountain_id = p.mountain_id -- цикъл
ORDER BY elevation DESC
LIMIT 1
)
ORDER BY elevation DESC;

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

-- Запазване на по-сложните заявки като изглед:
CREATE VIEW v_elevation_peaks_by_mountains AS
SELECT peak_name, elevation
FROM peaks AS p
WHERE elevation = 
(
SELECT elevation
FROM peaks
WHERE mountain_id = p.mountain_id -- цикъл
ORDER BY elevation DESC
LIMIT 1
)
ORDER BY elevation DESC;

-- UNION - 3-те най-дълги реки и 3-те най-високи върха
(SELECT river_name AS Name, length AS Meters
FROM rivers 
ORDER BY length DESC 
LIMIT 3) 
UNION                                                                                            
(SELECT peak_name, elevation 
FROM peaks
ORDER BY elevation DESC 
LIMIT 3);
-- ORDER BY name ASC;

-- JOIN - Името на връховете и планините, в които се намират
SELECT peak_name AS Peak, mountain_range AS Mountain
FROM peaks  
JOIN -- INNER JOIN                                                                      
mountains 
ON peaks.mountain_id = mountains.id;

-- OFFSET - Пропускане
-- Втората и третата най-дълги реки:
SELECT river_name AS Name, length AS Meters
FROM rivers 
ORDER BY length DESC 
-- LIMIT 3; 
-- LIMIT 1, 2; -- пропуска 1, взема 2
LIMIT 2 OFFSET 1; -- взема 2, пропуска 1

USE company;
-- по-сложна конкатенация - ако съществува бащино име, да се изпише
CREATE VIEW v_employees_job_titles AS
SELECT 
CONCAT(first_name, ' ', (case when middle_name IS NULL THEN '' ELSE middle_name END), ' ', last_name) 
AS "Full Name", job_title
FROM employees;

-- вместо update за view 
-- едновременно увеличение на заплатите на служителите с 10% от някои отдели
CREATE OR REPLACE VIEW v_employees_salary AS
SELECT salary*1.1 as salary_new
FROM employees
WHERE department_id IN (1, 2, 4, 11);
-- DROP VIEW - имената започват винаги с v_

-- друг начин за условие на дата вместо BETWEEN AND
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


