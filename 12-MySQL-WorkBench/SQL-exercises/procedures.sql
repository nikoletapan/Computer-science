USE geography;

DELIMITER $$

-- Държава, столица, население
CREATE PROCEDURE usp_get_countries()
BEGIN 
	SELECT 
		country_name, 
		capital, 
		population 
	FROM
		countries
	ORDER BY population DESC, country_name ASC;
END $$

-- Държава, столица, континент
CREATE PROCEDURE usp_countries_continents()
BEGIN 
	SELECT 
		country_name AS Country, 
		capital AS Capital,
        continent_name AS Continent
	FROM
		countries a
	JOIN 
    continents b
    ON a.continent_code = b.continent_code
	ORDER BY population DESC, country_name ASC;
END $$

-- Европейско първенство по футбол
CREATE PROCEDURE usp_eu_football()
BEGIN
	SELECT a.capital AS Place, 
		   a.country_name AS "Player 1 (Host)", " " AS "Host", " " AS "Guest", 
		   b.country_name AS "Player 2 (Guest)"
	FROM countries a
	CROSS JOIN countries b
	WHERE a.continent_code = "EU" AND b.continent_code = "EU" AND a.country_code <> b.country_code
	ORDER BY RAND();
END $$

DELIMITER ;