-- JOIN

SELECT * -- colimns from both tables
FROM table1 JOIN table2
ON table1.column_id = table2.column_id;

-- AS
SELECT *
FROM table1 AS a JOIN table2 AS b
ON a.column_id = table2.column_id;

SELECT *
FROM table1 a JOIN table2 b
ON a.column_id = b.column;

use geography;

SELECT peak_name, mountain_range 
FROM peaks AS p JOIN mountains AS m
ON p.mountain_id = m.id;
