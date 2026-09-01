-- Подготовка за контролно
USE geography;

-- 1 зад: Име на връх, планина, държава - 65 реда
SELECT peak_name AS Peak, mountain_range AS Mountain, country_name AS Country
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

-- 2 зад: За всяка планина в България да се изброят на един ред 
-- върховете низходящо по височина - 4 реда  
SELECT m.mountain_range AS 'Mountain name', 
		GROUP_CONCAT(' ', p.peak_name ORDER BY p.elevation DESC) AS Peaks     
FROM peaks p
JOIN 
mountains m
ON p.mountain_id = m.id
JOIN
mountains_countries mc
ON m.id = mc.mountain_id
WHERE mc.country_code = 'BG'
GROUP BY m.id;

-- 3 зад: За всяка планина в Азиа да се преброят върховете в нея 
-- и да се изброят на един ред низходящо по височина - 7 реда  
SELECT m.mountain_range AS Mountain, COUNT(p.peak_name) AS Count,
		GROUP_CONCAT(' ', p.peak_name ORDER BY p.elevation DESC) AS Peaks 
FROM peaks p
JOIN 
mountains m
ON p.mountain_id = m.id
JOIN
mountains_countries mc
ON m.id = mc.mountain_id
JOIN 
countries c
ON mc.country_code = c.country_code
WHERE c.continent_code = 'AS'
GROUP BY m.id;

-- 4 зад: Да се намери общата дължина на реките, които се вливат в Атлантическия океан 
SELECT outflow AS Outflow, 
	   group_concat(' ', river_name) AS Rivers, 
       SUM(length) AS 'Total Length'
FROM rivers 
-- WHERE outflow = 'Atlantic ocean'
GROUP BY outflow
HAVING outflow = 'Atlantic ocean';                 

-- 5 зад: Да се намерят, реките, които се вливат в заливи Gulf 
SELECT outflow AS Outflow, 
	   group_concat(' ', river_name) AS Rivers, 
       AVG(length) AS 'Average Length'
FROM rivers 
WHERE outflow LIKE '%Gulf%'                                                         
GROUP BY outflow;
-- HAVING OUTFLOW = '%Gulf%';         

-- 6 зад: Запазете като изглед обединяването на 
-- 3, 4, 5-те най-къси реки и 3, 4, 5-те най-ниски върхове
CREATE OR REPLACE VIEW v_rivers_peaks_union AS
(SELECT river_name AS Name, length AS Meters
FROM rivers
ORDER BY length ASC
-- LIMIT 2, 3
LIMIT 3 OFFSET 2)
UNION                                                          
(SELECT peak_name, elevation
FROM peaks
ORDER BY elevation ASC
-- LIMIT 2, 3
LIMIT 3 OFFSET 2);

-- Намерете имената и височините на най-ниските върхове за всяка планина в България,
-- подредени по възходящ ред според височината и името
-- 7 зад: Първи начин                                                                           
SELECT peak_name AS Peak, elevation AS Elevation
FROM peaks p
JOIN mountains_countries mc
ON p.mountain_id = mc.mountain_id
WHERE elevation =
(
SELECT elevation
FROM peaks
WHERE p.mountain_id = mountain_id
ORDER BY elevation ASC
LIMIT 1
)
AND mc.country_code = 'BG'
ORDER BY elevation ASC, peak_name;         

-- Намерете имената и височините на най-ниските върхове за всяка планина в България,
-- подредени по възходящ ред според височината и името
-- 7 зад: Втори начин                                                                           
SELECT peak_name AS Peak, elevation AS Elevation
FROM peaks p
JOIN mountains_countries mc
ON p.mountain_id = mc.mountain_id
WHERE elevation IN
(
SELECT MIN(elevation)
FROM peaks
GROUP BY mountain_id
)
AND mc.country_code = 'BG'
ORDER BY elevation ASC, peak_name;                                     

-- 8 зад: Да се намерят всички валути, които използват долари и 
-- думата Dollar да се замени със знака $
SELECT currency_code AS Currency,
(CASE WHEN description LIKE '%dollar' THEN                                         
        REPLACE(description, RIGHT(description,6), '$')                       
        ELSE description END) AS Description                  
FROM currencies
WHERE description LIKE '%dollar%';

-- 9 зад: Всички върхове над 8000 метра 
SELECT peak_name, elevation FROM peaks 
WHERE elevation >= 8000;

-- 10 зад: Всички върхове между 5000 - 6000 метра и в коя планина се намират
SELECT p.peak_name, p.elevation, m.mountain_range 
FROM peaks p
JOIN
mountains m
ON p.mountain_id = m.id
where elevation Between 5000 AND 6000;

-- 11 зад: Всички върхове в Kilimandjaro или региона    
SELECT p.peak_name, p.elevation, m.mountain_range 
FROM peaks p
JOIN
mountains m
ON p.mountain_id = m.id
where mountain_range LIKE '%Kilimanjaro%';

-- 12 зад: Всички държави, които използват валута паунд и се намират в Африка 
SELECT a.currency_code, a.description, c.continent_name                  
FROM currencies a
JOIN
countries b
ON a.currency_code = b.currency_code
JOIN
continents c
ON b.continent_code = c.continent_code
WHERE a.description LIKE '%Pound%'
AND c.continent_code = 'AF';


