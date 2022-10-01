CREATE TABLE PMI(
	idPMI SERIAL NOT NULL PRIMARY KEY,
	idUser INT REFERENCES doDonor_user NOT NULL,
	nama VARCHAR (255) NOT NULL,
	region VARCHAR(255) not null,
	address varchar(255) not null,
	phoneNumber varchar(12) not null
);

SELECT * FROM PMI;

CREATE TABLE BloodStock(
	idBloodStock SERIAL PRIMARY KEY NOT NULL,
	idPMI INT REFERENCES PMI,
	stockO INT,
	stockA INT,
	stockB INT,
	stockAB INT,
	lastUpdate DATE
);

SELECT * FROM BloodStock;

CREATE TABLE Schedule(
	idSchedule SERIAL PRIMARY KEY NOT NULL,
	idPMI INT REFERENCES PMI,
	dateTime DATE,
	location VARCHAR(255),
	address VARCHAR (255)
);

SELECT * FROM Schedule;

CREATE TABLE DonorRequest(
	idDonorRequest SERIAL PRIMARY KEY NOT NULL,
	idPersonal INT REFERENCES doDonor_personal,
	patientName VARCHAR(255) NOT NULL,
	bloodTypeNeeded VARCHAR(255) NOT NULL,
	bagQuantity INT NOT NULL,
	donorType VARCHAR(5) NOT NULL,
	region VARCHAR(255) NOT NULL,
	hospitalName VARCHAR(255) NOT NULL,
	cpName VARCHAR (255) NOT NULL,
	cpPhoneNumber VARCHAR(255) NOT NULL
);

SELECT * FROM DonorRequest;