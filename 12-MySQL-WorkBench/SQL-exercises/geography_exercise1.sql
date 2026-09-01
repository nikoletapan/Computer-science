SELECT * FROM continents;

SELECT COUNT(*) FROM continents;

SELECT *
FROM countries
WHERE continent_code = 'EU';

SELECT * 
FROM countries
WHERE currency_code = 'EUR';

SELECT * 
FROM countries
WHERE currency_code = 'EUR' AND continent_code = 'EU';

SELECT * 
FROM countries 
WHERE currency_code = 'EUR' AND NOT continent_code = 'EU';

SELECT DISTINCT currency_code
FROM countries;

SELECT * 
FROM countries
WHERE currency_code = 'USD' AND population >= 50000;

SELECT * 
FROM countries
WHERE currency_code = 'USD' AND population BETWEEN 50000 AND 100000;

SELECT country_name, capital, continent_code
FROM countries;

SELECT *
FROM peaks
WHERE mountain_id = 4;

SELECT *
from mountains
WHERE mountain_range='Pirin';

SELECT *
from mountains
WHERE id = '17';

SELECT distinct outflow
FROM rivers;

SELECT CONCAT_WS(' - ', country_name, capital) AS COUNTRY
FROM countries;

SELECT country_name AS country,
capital, population
FROM countries
WHERE continent_code IN ('AF', 'AN', 'AS');

INSERT INTO continents
VALUES
('LM', 'Lemuria_');

SET SQL_SAFE_UPDATES = 0;

UPDATE continents
SET continent_name = 'Lemuria'
WHERE continent_name = 'Lemuria_';

DELETE 
FROM continents
WHERE continent_name = 'Lemuria';