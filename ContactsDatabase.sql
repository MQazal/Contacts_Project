CREATE DATABASE ContactsDatabase;

RESTORE DATABASE ContactsDatabase
FROM DISK = 'C:\Programming_Path\Programming Advices.com\Backend Development Track\Course#18\ContactsDatabase.bak'
WITH REPLACE;

USE ContactsDatabase;

SELECT * FROM Contacts;

SELECT * FROM Contacts WHERE ContactID = 2;

SELECT * FROM Countries;

SELECT * FROM Contacts WHERE ContactID = 1;

SELECT Found = 'True' FROM Contacts WHERE Contacts.ContactID = 1;

SELECT Found = 'True' FROM Contacts WHERE Contacts.ContactID = 100;

SELECT Found = 'true' FROM Countries WHERE CountryID = 3;

SELECT Found = 'True' FROM Countries WHERE CountryName = 'Saudi Arabia';

DELETE FROM Contacts WHERE ContactID = 10;

ALTER TABLE Contacts ALTER Column DateOfBirth DATE NOT NULL;

INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID)
VALUES ('C#', 'Key', 'C#@Key.com', '9999999', 'Address500', '2001-11-17', 2);

SELECT SCOPE_IDENTITY();

TRUNCATE TABLE Contacts;

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Ahmed', 'Ali', 'ahmed.ali@gmail.com', '0551234567', 'Madinah', '1998-03-14', 1, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Sara', 'Maher', 'sara.maher@gmail.com', '0552345678', 'Jeddah', '2000-07-22', 2, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Khalid', 'Omar', 'khalid.omar@gmail.com', '0553456789', 'Riyadh', '1995-11-09', 3, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Noura', 'Hassan', 'noura.hassan@gmail.com', '0554567890', 'Dammam', '1999-01-30', 4, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Faisal', 'Yousef', 'faisal.yousef@gmail.com', '0555678901', 'Tabuk', '1997-06-18', 5, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Reem', 'Sami', 'reem.sami@gmail.com', '0556789012', 'Abha', '2001-09-12', 2, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Omar', 'Fadi', 'omar.fadi@gmail.com', '0557890123', 'Makkah', '1996-12-05', 3, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Lama', 'Tariq', 'lama.tariq@gmail.com', '0558901234', 'Taif', '2002-04-27', 4, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Yousef', 'Nader', 'yousef.nader@gmail.com', '0559012345', 'Yanbu', '1994-08-16', 1, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Huda', 'Karim', 'huda.karim@gmail.com', '0550123456', 'AlUla', '2003-02-11', 1, 'C:\Favorite\wall1.jpg');

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Sameha', 'Karim', 'huda.karim@gmail.com', '0550123456', 'AlUla', '2003-02-11', 1, NULL);

INSERT INTO Contacts
(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES
('Jaber', 'Murad', 'huda.karim@gmail.com', '0550123456', 'AlUla', '2003-02-11', 3, NULL);