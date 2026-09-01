USE geography;

/*1*/
-- държава 10, 11, 12 по население и площ
CREATE OR REPLACE VIEW v_countries_quantites2 AS
(SELECT country_name AS Country, population AS Quantity
FROM countries
ORDER BY population DESC
LIMIT 3 OFFSET 9)
UNION
(SELECT country_name, are_in_sq_km
FROM countries
ORDER BY are_in_sq_km DESC
LIMIT 3 OFFSET 9);

/*2*/
-- реки с излаз на море
SELECT river_name AS River, outflow AS Outflow, length AS Length
FROM rivers R
WHERE outflow LIKE '%china sea%'
AND length IN
(SELECT MAX(length) 
FROM rivers
GROUP BY river_name)
ORDER BY length DESC;


/*3*/
-- Реките за всяка държава в Южна Америка, която започва с 'B'
SELECT c.country_name AS Country,
GROUP_CONCAT(" ", r.river_name ORDER BY length DESC) as Rivers,
Count(r.river_name) AS Count
FROM countries c
JOIN
countries_rivers as cr
ON c.country_code = cr.country_code
JOIN
rivers r
ON cr.river_id = r.id
WHERE c.continent_code = 'SA' AND country_name LIKE 'B%'
GROUP BY c.country_code;