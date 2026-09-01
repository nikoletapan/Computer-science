-- all keywords are uppercase, blue
CREATE SCHEMA library_sql; -- `database_name` lower case, snake_case convention, 

-- CREATE DATABASE library_sql;

USE library_sql; -- use only this DB

CREATE TABLE genres (
genre_id INT NOT NULL,
genre_name VARCHAR(45),
CONSTRAINT pk_genre_id PRIMARY KEY (genre_id)
);



CREATE TABLE authors( -- plural
author_id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
nationality ENUM('UK', 'BG', 'DE', 'FR', 'RU', 'USA'),
alive TINYINT
-- CONSTRAINT pk_author_id PRIMARY KEY (author_id)
);

INSERT INTO authors (first_name, last_name, nationality, alive)
VALUES 
('Иван', 'Вазов', 'bg', 0),
('George', 'Martin', 'usa', 1),
('Terry', 'Pratchett', 'usa', 0),
('Neil', 'Gaiman', 'uk', 1)
;

CREATE TABLE books(
book_id CHAR(5) PRIMARY KEY NOT NULL,
title VARCHAR(50) NOT NULL,
isbn VARCHAR(17),
genre_id INT,
price DECIMAL(5,2),
CONSTRAINT fk_books_genres FOREIGN KEY (genre_id) REFERENCES genres (genre_id)
);

INSERT INTO books 
VALUES 
('BG001', 'Под игото', '954-657-295-0', 1, 9.90),
('EN002', 'Good Omens', '9780060853969', 1, 19.00),
('BG003', 'Немили-недраги', '9546572756' ,2, 5.90 )
;

CREATE TABLE books_authors (
author_id INT NOT NULL AUTO_INCREMENT,
book_id char(5),
CONSTRAINT fk_books_authors_authors FOREIGN KEY (author_id) REFERENCES authors (author_id),
CONSTRAINT fk_books_authors_books FOREIGN KEY (book_id) REFERENCES books (book_id)
);

INSERT INTO books_authors 
VALUES
(1, 'BG001'),
(3, 'EN002'),
(4, 'EN002'),
(1, 'BG003')
;







