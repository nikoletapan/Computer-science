-- JOIN

USE geography; 

-- Столица, държава, континент
SELECT capital AS Capital, country_name AS Country, continent_name AS Continent
FROM countries
LEFT JOIN                                                                                
continents
ON countries.continent_code = continents.continent_code;

-- псевдоними за таблиците БЕЗ AS
SELECT a.capital AS Capital, a.country_name AS Country, b.continent_name AS Continent
FROM countries a -- AS
LEFT JOIN                                                                                                                                                                                                                                                                                                   
continents b -- AS
ON a.continent_code = b.continent_code;

-- Декартово произведение - без ON връзка 
SELECT a.capital AS Capital, a.country_name AS Country, b.continent_name AS Continent
FROM countries AS a
JOIN                                                                                     
continents AS b;   

-- Декартово произведение - без JOIN и без ON връзка 
SELECT a.capital AS Capital, a.country_name AS Country, b.continent_name AS Continent
FROM countries AS a, continents AS b;  

-- Декартово произведение - CROSS JOIN 
SELECT a.capital AS Capital, a.country_name AS Country, b.continent_name AS Continent
FROM countries AS a
CROSS JOIN continents AS b;

-- JOIN + WHERE + ORDER BY + LIMIT за Европа
SELECT a.capital AS Capital, a.country_name AS Country, b.continent_name AS Continent
FROM countries AS a
JOIN                                                                                                                                                                                                                                                                                      
continents AS b
ON a.continent_code = b.continent_code
WHERE b.continent_code = 'EU'
ORDER BY a.capital
LIMIT 5;                                                                                      

-- Коя река през кои държави минава, изредени                             
SELECT r.river_name, r. length, c.country_name 
FROM rivers as r
JOIN
countries_rivers AS cr
ON r.id = cr.river_id
JOIN
countries AS c
ON cr.country_code = c.country_code;  

-- Коя река през кои държави минава, групирани                                               
SELECT r.river_name AS River, c.country_name AS Countries
FROM rivers as r
JOIN
countries_rivers AS cr
ON r.id = cr.river_id
JOIN
countries AS c
ON cr.country_code = c.country_code
GROUP BY r.id;                           

SELECT COUNT(*) FROM rivers;

-- Всички реки, които минават през България:                    
SELECT r.river_name, r.length, c.country_name
FROM rivers as r
JOIN
countries_rivers AS cr
ON r.id = cr.river_id
JOIN
countries AS c
ON cr.country_code = c.country_code
WHERE c.country_code='BG';        

-- Задача: име на връх, планина, държава      
SELECT p.peak_name, m.mountain_range, c.country_name
FROM peaks p
JOIN 
mountains m
ON p.mountain_id = m.id
JOIN
mountains_countries mc
ON m.id = mc.mountain_id
JOIN
countries c
ON mc.country_code = c.country_code;
      
-- Държавите, в които няма планини
SELECT 	COUNT(*) AS country_count  
FROM countries AS c
LEFT JOIN mountains_countries AS mc     
	ON c.country_code = mc.country_code
WHERE mc.mountain_id IS NULL;              
