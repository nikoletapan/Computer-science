CREATE SCHEMA movies_db;

CREATE TABLE movies_db.genres (
genre_id INT PRIMARY KEY NOT NULL,
genre_name VARCHAR(45)
);

CREATE TABLE movies_db.actors (
actor_id INT PRIMARY KEY NOT NULL,
first_name VARCHAR(45),
family_name VARCHAR(45),
-- gender char(1), CHECK(gender = 'm' OR gender = 'f')
gender ENUM('M','F')
);

CREATE TABLE movies_db.movies (
movie_id INT PRIMARY KEY NOT NULL,
title VARCHAR(45) NOT NULL,
director VARCHAR(45),
copyright_year YEAR,
length TIME,
genre_id INT NOT NULL,
rating double(2,1), CHECK (rating >=1 && rating <= 10),
poster BLOB,
trailer VARCHAR(100),
notes TEXT,
CONSTRAINT fk_movies_genre FOREIGN KEY (genre_id) REFERENCES movies_db.genres (genre_id)
);

CREATE TABLE movies_db.cast (
actor_id INT NOT NULL,
movie_id INT NOT NULL,
movie_role varchar(45),
salary decimal(10,2),
CONSTRAINT fk_cast_actors FOREIGN KEY (actor_id) REFERENCES movies_db.actors(actor_id),
CONSTRAINT fk_cast_movies FOREIGN KEY (movie_id) REFERENCES movies_db.movies(movie_id)
); 

INSERT INTO movies_db.genres (genre_id, genre_name)
VALUES
(01, 'Fantasy'),
(02, 'Romance'),
(03, 'Comedy'),
(04, 'Drama'),
(05, 'Documentary');

INSERT INTO movies_db.actors (actor_id, first_name, family_name, gender)
VALUES
(201, 'Keanu', 'Reeves', 'm'),
(202, 'Liv', 'Tyler', 'f'),
(203, 'Al', 'Pacino', 'm');

INSERT INTO movies_db.movies (movie_id, title, director, copyright_year, length, genre_id, rating, trailer)
VALUES 
(401, 'The Matrix', 'Wachowski', 1999, '02:16', 01, 8.7, 'https://www.imdb.com/video/vi1032782617/?playlistId=tt0133093&ref_=tt_ov_vi'),
(402, 'The Lord Of The Rings', 'Peter Jackson', 2001, '02:58', 01, 8.9, 'https://www.imdb.com/video/vi684573465/?playlistId=tt0120737&ref_=tt_ov_vi'),
(403, 'The Godfather', 'Francis Ford Coppola', 1972, '02:55', 04, 9.2, 'https://www.imdb.com/video/vi1348706585/?playlistId=tt0068646&ref_=tt_ov_vi');

INSERT INTO movies_db.cast (actor_id, movie_id, movie_role, salary)
VALUES 
(201, 401, 'Neo', 10000000),
(202, 402, 'Arwen', 2000000),
(203, 403, 'Michael Corleone', 35000);