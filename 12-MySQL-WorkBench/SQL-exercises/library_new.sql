CREATE DATABASE library_new;

USE library_new;

CREATE TABLE books(
book_id CHAR(5) PRIMARY KEY NOT NULL,
title VARCHAR(50) NOT NULL,
publication_year YEAR(4),
isbn VARCHAR(17),
price DECIMAL(5,2)
);

INSERT INTO books (book_id, title, price)
VALUES 
('BG001', 'Под игото', 9.90),
('EN002', 'Аз преди тебе', 14.90),
('EN003', 'Гневът и зората', 15.00),
('EN004', 'Добри поличби', 19.90),
('BG005', 'Немили-недраги', 5.90)
;

INSERT INTO books (book_id, title, price)
VALUES
('BG005', 'Немили-недраги', 5.90);

SELECT * FROM books;

CREATE TABLE authors(
author_id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
first_name VARCHAR(45) NOT NULL,
last_name VARCHAR(45) NOT NULL,
nationality ENUM('BG', 'EN', 'DE', 'RU', 'FR', 'IT'),
gender CHAR(1), CHECK (gender = 'm' OR gender = 'f'),
alive TINYINT
);

TRUNCATE TABLE authors;

INSERT INTO authors (first_name, last_name, nationality, gender, alive)
VALUES
('Иван', 'Вазов', 'bg', 'm', 0),
('Джорджо', 'Мойс', 'en', 'f', 1),
('Рене', 'Ахдие', 'en', 'f', 1),
('Тери', 'Пратчет', 'en', 'm', 0),
('Нийлс', 'Геймън', 'en', 'm', 1)
;

SELECT * FROM authors;

CREATE TABLE books_authors (
author_id INT NOT NULL,
book_id CHAR(5) NOT NULL, 
CONSTRAINT fk_authors FOREIGN KEY (author_id) REFERENCES authors (author_id),
CONSTRAINT fk_books FOREIGN KEY (book_id) REFERENCES books (book_id)
);
SELECT * FROM authors;
SELECT * FROM books;

INSERT INTO books_authors
VALUES
(1, 'BG001'),
(2, 'EN002'),
(3, 'EN003'),
(1, 'BG005'),
(4, 'EN004'),
(5, 'EN004')
;

SELECT * FROM books_authors;

SELECT * FROM authors 
WHERE
(first_name = 'Иван');

SELECT * FROM books_authors 
WHERE
(author_id = 1);

