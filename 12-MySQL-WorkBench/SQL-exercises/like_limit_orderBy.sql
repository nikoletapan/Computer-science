/* LIKE 
е филтриращо условие, в което 
_ означава 1 символ
% означава всичко - 0, 1 или много символи */

SELECT * FROM rivers
WHERE outflow LIKE '%Ocean';

SELECT * FROM rivers
WHERE outflow LIKE '%sea';

-- всички имена на реки с поне 2 думи - съдържа 1 интервал
SELECT * FROM rivers
WHERE river_name LIKE '% %';

-- всички имена на реки с точно 5 букви
SELECT * FROM rivers
WHERE river_name LIKE '_____';

-- LIMIT брой редове - най-дългата река
-- ASC = възходящ ред, по подразбиране ако не пише нищо
-- DESC = низходящ
SELECT * FROM rivers
ORDER BY length desc
LIMIT 1;

-- OFFSET пропусни първите 2 записа и вземи следващите 5
SELECT * FROM rivers
ORDER BY length 
LIMIT 5 OFFSET 2;

-- няколко ORDER BY - пише се веднъж, разделя се със запетайки
SELECT * FROM countries
ORDER BY country_name ASC, population DESC;

-- CASE - като if-else (CASE WHEN ... THEN ... ELSE ... END)
select country_name, country_code, currency_code,
(case when currency_code='EUR'then 'Euro'
else 'Not euro' end) as Currency
from countries
order by country_name ASC;




