-- One-To-One Relationship 
CREATE SCHEMA `security_data`;

CREATE TABLE `security_data`.`passports`(
  `passport_id` INT PRIMARY KEY,
  `passport_number` VARCHAR(50)
);

CREATE TABLE `security_data`.`people`(
  `person_id` INT PRIMARY KEY,
  `first_name` VARCHAR(50),
  `family_name` VARCHAR(45),
  `photo` BLOB,
  `gender` CHAR(1), CHECK (gender = 'm' OR gender = 'f'),
  `age` INT, CHECK (age >= 18),
  `salary` DECIMAL(8,2),
  `passport_id` INT UNIQUE,
  CONSTRAINT `fk_persons_passports` FOREIGN KEY(`passport_id`) REFERENCES `passports`(`passport_id`)
);

INSERT INTO `security_data`.`passports`(`passport_id`, `passport_number`)
VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2');

INSERT INTO `security_data`.`people`(`person_id`, `first_name`, `family_name`, `gender`, `age`, `salary`, `passport_id`)
VALUES
(1, 'Ivan', 'Petrov', 'm', 29, 43300.00, 102),
(2, 'Dimiter', 'Vasilev', 'm', 37, 56100.00, 103),
(3, 'Yana', 'Naydenova', 'f', 32, 60200.00, 101);

-- TRUNCATE TABLE `security_data`.`people`;

-- DROP TABLE `security_data`.`people`;

/* test the DB */