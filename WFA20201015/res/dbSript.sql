--CREATE DATABASE turautvonalak;
--USE turautvonalak;

CREATE TABLE turazo(
id INT PRIMARY KEY IDENTITY,
vezeteknev VARCHAR(255),
keresztnev VARCHAR(255),
varos VARCHAR(255),
telefonszam VARCHAR(255));

CREATE TABLE utvonal(
id INT PRIMARY KEY IDENTITY,
turazoId INT FOREIGN KEY REFERENCES turazo(id),
honnan VARCHAR(255),
hova VARCHAR(255),
km INT);

INSERT INTO turazo (vezeteknev, keresztnev, varos, telefonszam) VALUES 
('Kiss','Manyi','Velence','06701234567'),
('Nagy','Imre','Budapest','06304545452'),
('Tompa','Mihály','Budapest','06701023545');
INSERT INTO utvonal (turazoId, honnan, hova, km) VALUES
(2,'Budapest', 'Monor', 38),
(3,'Budapest', 'Esztergom', 54);