USE geography;

/*1*/
-- държава 7 и 8 по население и площ
CREATE OR REPLACE VIEW v_countries_quantites AS
(SELECT country_name AS Country, population AS Quantity
FROM countries
ORDER BY population DESC
LIMIT 2 OFFSET 6)
UNION
(SELECT country_name, are_in_sq_km
FROM countries
ORDER BY are_in_sq_km DESC
LIMIT 2 OFFSET 6);

/*2*/
-- Реките за всяка държава в Северна Америка
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
WHERE c.continent_code = 'NA'
GROUP BY c.country_code;

/*3*/
-- Паунди
SELECT currency_code AS Currency, 
(CASE WHEN description LIKE '%Pound' THEN 
REPLACE(description, RIGHT(description, 5), '£') 
ELSE description END) AS Description
FROM currencies
WHERE description LIKE '%Pound';