SELECT * FROM users;
insert into users (first_name, last_name, email) values ('Jane', 'Doe', 'jane@doe.com'), ('Bob', 'Ross', 'bob@ross.com'), ('Frodo', 'Baggins', 'frodo@baggins.com');
DELETE FROM users;
SET SQL_SAFE_UPDATES = 0;
SELECT * from users WHERE email = 'jane@doe.com';
SELECT * from users WHERE id = 6;
UPDATE users SET
last_name = "Pancakes"
WHERE id = 3;
TRUNCATE TABLE users;
DELETE FROM users WHERE id = 2;
SELECT * FROM users
ORDER BY first_name;