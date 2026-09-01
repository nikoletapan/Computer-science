USE geography;

-- Намерете най-високите върхове от всяка планина
-- 1) начин - order by + limit
SELECT peak_name, elevation, mountain_id
from peaks as p
where elevation = 
(
select elevation
from peaks
where mountain_id = p.mountain_id
order by elevation desc
limit 1
)
order by mountain_id;

-- 2) Max + group by 
SELECT peak_name, elevation, mountain_id
from peaks
where elevation IN
(
SELECT Max(elevation)
FROM peaks
GROUP BY mountain_id
)
order by mountain_id;

-- Планините в България с техните най-високи върхове, подредени по височина
SELECT mountain_range,  
(
    SELECT peak_name 
    FROM peaks 
    WHERE mountain_id = m.id 
    ORDER by elevation DESC 
    LIMIT 1
) AS peak_name,
(
    SELECT elevation 
    FROM peaks 
    WHERE mountain_id = m.id 
    ORDER by elevation DESC 
    LIMIT 1
) AS elevation
FROM mountains AS m  
WHERE id IN 
(
    SELECT mountain_id 
    FROM mountains_countries 
    WHERE country_code = 'BG'
)
ORDER BY elevation DESC;
