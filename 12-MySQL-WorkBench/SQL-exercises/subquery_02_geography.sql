use geography;
/* зад: 1 всички върхове в България по височина */

-- 1) всички върхове в България от едната таблица
SELECT * FROM mountains_countries
WHERE country_code = "BG";

-- 2) име на връх от едната таблица и номер на планина от другата
SELECT * FROM peaks
WHERE mountain_id IN
(
SELECT mountain_id FROM mountains_countries
WHERE country_code='BG'
);

-- 3) подреждаме колони и височина
SELECT peak_name, elevation FROM peaks
WHERE mountain_id IN
(
SELECT mountain_id FROM mountains_countries
WHERE country_code='BG'
)
ORDER BY elevation DESC;

