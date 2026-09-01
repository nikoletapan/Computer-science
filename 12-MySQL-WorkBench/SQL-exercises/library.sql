DROP DATABASE IF EXISTS library;

CREATE DATABASE library;

USE library;
SET SQL_SAFE_UPDATES = 0;

CREATE TABLE authors (
id_author INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
first_name varchar(45) NOT NULL,
last_name VARCHAR(45) NOT NULL,
nationality ENUM('BG', 'EN', 'DE', 'RU', 'FR'),
gender CHAR(1), CHECK(gender = 'm' OR gender = 'f'),
alive TINYINT
);

CREATE TABLE books (
id_book CHAR(4) PRIMARY KEY NOT NULL,
title VARCHAR(45) NOT NULL,
publishing_year YEAR,
isbn VARCHAR(17),
price DECIMAL(10,2)
);

CREATE TABLE books_authors (
id_author INT NOT NULL,
id_book CHAR(4),
CONSTRAINT fk_books_authors_authors FOREIGN KEY (id_author) REFERENCES authors (id_author),
CONSTRAINT fk_books_authors_books FOREIGN KEY (id_book) REFERENCES books (id_book)
);

INSERT INTO authors (first_name, last_name, nationality, gender, alive)
VALUES 
('Карл', 'Май', 'DE', 'm', 0),
('Иван', 'Вазов', 'BG', 'm', 0),
('Стивън', 'Кинг', 'EN', 'm', 0),
('Емилиян', 'Станев', 'BG', 'm', 0),
('Тери', 'Пратчет', 'EN', 'm', 0),
('Нийл', 'Геймън', 'EN', 'm', 1),
('Джордж', 'Мартин', 'EN', 'm', 1);

SELECT * FROM authors;

ALTER TABLE authors
RENAME COLUMN nationality
TO language;

ALTER TABLE authors
ADD COLUMN Email VARCHAR(45);

ALTER TABLE authors
DROP COLUMN Email;

-- ALTER TABLE authors 
-- CHANGE COLUMN nationality language ENUM('BG', 'EN', 'DE', 'RU', 'FR');


INSERT INTO authors (first_name, last_name, language, gender, alive)
VALUES 
('Джоан', 'Ро_линг', 'EN', 'f', 1);

UPDATE authors
SET last_name = 'Роулинг'
WHERE last_name = 'Ро_линг';

INSERT INTO authors (first_name, last_name, language, gender, alive)
VALUES 
('Петко Р.', 'Славейков', 'bg', 'm', 0),
('Пенчо', 'Славейков', 'bg', 'm', 0),
('Димчо', 'Дебелянов', 'bg', 'm', 0);

INSERT INTO books (id_book, title, price)
VALUES
('de01', 'Винету', 15.00),
('de02', 'Горски призрак', 10.00),
('bg01', 'Под игото', 9.90),
('en01', 'Коли', 19.90),
('bg02', 'Крадецът на праскови', 10.00),
('bg03', 'Под води и гори', 12.00),
('en02', 'Добри поличби', 19.90),
('en03', 'Песен за огън и лед', 200.00),
('en04', 'Хари Потър', 25.00),
('bg04', 'Изворът на белоногата', 5.50),
('bg05', 'Епически песни', 40.00),
('bg06', 'Сън за щастие', 18.00),
('bg08', 'Готварската книга на Дядо Славейков', 12.00), 
('bg07', 'Стихотворения', 3.99);

INSERT INTO books_authors
VALUES 
(1, 'de01'),
(1, 'de02'),
(2, 'bg01'),
(3, 'en01'),
(4, 'bg02'),
(4, 'bg03'),
(5, 'en02'),
(6, 'en02'),
(7, 'en03'),
(9, 'bg04'),
(10, 'bg05'),
(10, 'bg06'),
(11, 'bg07'),
(10, 'bg08');

SELECT * FROM authors;

SELECT * FROM books;

SELECT * FROM books_authors;

SELECT id_book AS 'номер на книга', 
title AS заглавие
FROM books;

SELECT last_name, first_name -- може и наобратно
FROM authors;

SELECT * FROM authors 
WHERE
last_name = 'Славейков';

SELECT * FROM authors 
WHERE
id_author = 8;

SELECT title FROM books ORDER BY title; -- asc / desc

SELECT id_book AS номер, 
title AS заглавие
FROM books;

SELECT first_name, last_name FROM authors;

SELECT first_name AS 'малко име',
last_name AS фамилия
FROM authors;

SELECT CONCAT(first_name, ' ', last_name) AS 'Пълно име' 
FROM authors;

SELECT first_name AS 'Малко име'
FROM AUTHORS;

-- DROP DATABASE library; (настройките)
-- DROP TABLE authors; (настройките)

-- TRUNCATE TABLE books; -- (записите, по-бързо)
-- DELETE FROM books; -- (записите, по-бавно)
-- DELETE FROM authors WHERE id_author = 3;
-- DELETE FROM books WHERE title = 'Песен за огън и лед';

SELECT id_author AS No,
    CONCAT(first_name, ' ', last_name) AS fullname
FROM
    authors;

-- WS = With separator ',' 
SELECT 
    CONCAT_WS(' ', first_name, last_name) AS fullname
FROM
    authors;
    
SELECT DISTINCT last_name
FROM authors
WHERE last_name = 'Славейков';

SELECT title, price
FROM books
WHERE price >= 10.00;

SELECT title, price
FROM books
WHERE price BETWEEN 10.00 AND 20.00;

SELECT * FROM books;

UPDATE books
SET price = price * 0.9
WHERE price > 10.00;

SELECT title 
FROM books
WHERE NOT (id_book = 'bg01' OR id_book = 'bg02');

SELECT title 
FROM books
WHERE id_book IN ('bg01', 'bg02', 'bg03');


-- books = a, books_authors = b, authors = c
SELECT  a.title,
        GROUP_CONCAT(c.first_name, ' ', c.last_name ORDER BY c.first_name) author
FROM    books a
        INNER JOIN books_authors b
            ON a.id_book = b.id_Book 
        INNER JOIN authors c
            ON b.id_author = c.id_author
GROUP   BY a.id_book, a.title;                                 

											