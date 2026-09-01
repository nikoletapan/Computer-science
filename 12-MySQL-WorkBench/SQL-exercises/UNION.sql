USE geography;

SELECT * FROM rivers; -- 30 Rrows

SELECT * FROM mountains; -- 26 rows
/*1*/
(SELECT river_name FROM rivers)         -- 30 rows
UNION                                   -- +
(SELECT mountain_range FROM mountains); -- 26 rows
                                        -- = 56 rows
/*2*/
(SELECT peak_name AS peak, elevation AS info FROM peaks)
UNION
(SELECT country_name, capital FROM countries); -- 298 rows

/*3*/
SELECT capital AS name FROM countries; -- 250 rows
SELECT country_name FROM countries;    -- 250 rows

(SELECT capital AS name FROM countries) 
UNION                                   -- 250 + 250 = 500
(SELECT country_name FROM countries);   -- 500 - 18 = 482

/*4*/
(SELECT capital AS name FROM countries) 
UNION ALL                              -- 250 + 250 = 500
(SELECT country_name FROM countries);   

/*5*/
SELECT mountain_range AS name FROM mountains 
WHERE id IN
(SELECT mountain_id from mountains_countries
WHERE country_code = 'BG')
UNION
SELECT river_name FROM rivers
WHERE id IN
(SELECT river_id FROM countries_rivers
WHERE country_code = 'BG');

/*6*/
(select river_name as name from rivers) 
UNION 
(select mountain_range from mountains)
ORDER BY name ASC LIMIT 10; -- instead of 56 rows

/*7*/
(SELECT river_name AS name 
FROM rivers 
ORDER BY length DESC LIMIT 3) 
UNION 
(SELECT peak_name FROM peaks
ORDER BY elevation DESC LIMIT 3)
ORDER BY name ASC;

/*8*/
-- Планините в България
SELECT mountain_range,  
    (SELECT peak_name FROM peaks 
	WHERE mountain_id = m.id 
	ORDER by elevation DESC LIMIT 1
    )AS peak_name,
    (SELECT elevation FROM peaks 
	WHERE mountain_id = m.id 
	ORDER by elevation DESC LIMIT 1
    ) AS elevation
    FROM mountains AS m  
    WHERE id IN 
    (SELECT mountain_id FROM mountains_countries 
	WHERE country_code = 'BG') AND id IN 
    (SELECT DISTINCT mountain_id FROM peaks)
UNION                                                    
    SELECT mountain_range, "no",  "info"
    FROM mountains AS m  
    WHERE id IN 
    (SELECT mountain_id FROM mountains_countries 
	WHERE country_code = 'BG') AND NOT EXISTS 
    (SELECT 1 FROM peaks 
	WHERE mountain_id = m.id)
ORDER BY mountain_range;

/*9*/


