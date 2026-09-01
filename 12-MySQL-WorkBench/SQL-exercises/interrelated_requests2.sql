use geography;

SELECT mountain_range
FROM mountains AS m
WHERE id IN
(
	SELECT mountain_id
    FROM mountains_countries
    WHERE country_code='BG'
)
AND NOT EXISTS
(
	SELECT *
    FROM peaks
    WHERE mountain_id = m.id
);

