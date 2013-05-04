/**
 * Laboratoire 1 partie 2
 * @author Hassen Ben Tanfous
 * @author Jonathan Lafleur
 * Date: 24/02/2006
*/

DROP SEQUENCE OptSimulation_noOption;
DROP SEQUENCE Client_noClient;
DROP SEQUENCE Simulation_noSimulation;
DROP TABLE Reservation;
DROP TABLE Client;
DROP TABLE Type;
DROP TABLE Categorie;
DROP TABLE Simulation;
DROP TABLE OptionSimulation;

CREATE SEQUENCE Simulation_noSimulation
	INCREMENT BY 1;

CREATE SEQUENCE OptSimulation_noOption 
	INCREMENT BY 1; 

CREATE SEQUENCE Client_noClient
	INCREMENT BY 1;
 
 
CREATE TABLE OptionSimulation
(	noOption 		INTEGER CONSTRAINT OptSimulation_noOption_nn NOT NULL,
	nomHotel 		VARCHAR(12) CONSTRAINT OptSimulation_nomHotel_nn NOT NULL,
	villeHotel 		VARCHAR(12) CONSTRAINT OptSimulation_villeHotel_nn NOT NULL,
	paysHotel 		VARCHAR(12) CONSTRAINT OptSimulation_paysHotel_nn NOT NULL,
	adresseHotel 	VARCHAR(20) CONSTRAINT OptSimulation_adresseHotel_nn NOT NULL,
	nomLieu 		VARCHAR(12) CONSTRAINT OptSimulation_nomLieu NOT NULL,
	villeLieu 		VARCHAR(12) CONSTRAINT OptSimulation_villeLieu NOT NULL,
	paysLieu 		VARCHAR(12) CONSTRAINT OptSimulation_paysLieu NOT NULL,
	noIdent 		VARCHAR(5) CONSTRAINT OptSimulation_noIdent NOT NULL,
	CONSTRAINT OptSimulation_noOption_pk PRIMARY KEY (noOption),
	CONSTRAINT OptSimulation_hotel_fk FOREIGN KEY (nomHotel, villeHotel, paysHotel, adresseHotel) REFERENCES Hotel(nomHotel, ville, pays, adresse),
	CONSTRAINT OptSimulation_lieu_fk FOREIGN KEY (nomLieu, villeLieu, paysLieu) REFERENCES LieuAVisiter(lieu, ville, pays),
	CONSTRAINT OptSimulation_circuit_fk FOREIGN KEY (noIdent) REFERENCES Circuit (noIdent)
);


CREATE TABLE Simulation 
(	noSimulation 	INTEGER CONSTRAINT Simulation_noSimulation_nn NOT NULL,
	nom				VARCHAR(20) CONSTRAINT Simulation_nom_nn NOT NULL,
	dateCreation 	DATE DEFAULT CURRENT_DATE,
	dateDepart 		DATE,
	dateArrivee 	DATE,
	nbPersonnes 	INTEGER DEFAULT 1, 
	noOption 		INTEGER,
	cout 			INTEGER DEFAULT 0,
	CONSTRAINT Simulation_noSimulation_pk PRIMARY KEY (noSimulation),
	CONSTRAINT Simulation_nbPersonnes_ck CHECK (nbPersonnes>=1),
	CONSTRAINT Simulation_cout_ck CHECK (cout>=0),
	CONSTRAINT Simulation_noOption_fk FOREIGN KEY (noOption) REFERENCES OptionSimulation(noOption)
);


CREATE TABLE Type
( 	symbole 	VARCHAR(1),
	description VARCHAR(20),
	CONSTRAINT Type_symbole_pk PRIMARY KEY (symbole)
);

CREATE TABLE Categorie 
(	symbole 	VARCHAR(2),
	description VARCHAR(20),
	CONSTRAINT Categorie_symbole_pk PRIMARY KEY (symbole)
);


CREATE TABLE Client 
(	noClient 			INTEGER CONSTRAINT Client_noClient_nn NOT NULL,
	nom 				VARCHAR(20) CONSTRAINT Client_nom_nn NOT NULL, 
	password 			VARCHAR(20) CONSTRAINT Client_password_nn NOT NULL,
	dateCreation 		DATE DEFAULT CURRENT_DATE,
	symboleType 		VARCHAR(1) DEFAULT 'I',
	symboleCategorie 	VARCHAR(2) DEFAULT 'P',
	CONSTRAINT Client_noClient_pk PRIMARY KEY (noClient),
	CONSTRAINT Client_type_fk FOREIGN KEY (symboleType) REFERENCES Type(symbole),
	CONSTRAINT Client_categorie_fk FOREIGN KEY (symboleCategorie) REFERENCES Categorie(symbole)
);


CREATE TABLE Reservation 
(	noReservation 			INTEGER CONSTRAINT Reservation_noReservation_nn NOT NULL,
	noClientReservation 	INTEGER CONSTRAINT Reservation_noClient_nn NOT NULL,
	CONSTRAINT Reservation_noReservation_pk PRIMARY KEY(noReservation),
	CONSTRAINT Reservation_noReservation_fk FOREIGN KEY (noReservation) REFERENCES Simulation(noSimulation),
	CONSTRAINT Reservation_noClient_fk FOREIGN KEY (noClientReservation) REFERENCES Client (noClient)
);


INSERT INTO Categorie VALUES ('Pu','Public');
INSERT INTO Categorie VALUES ('Cl','Client');
INSERT INTO Categorie VALUES ('Ag','Agence');
INSERT INTO Categorie VALUES ('Ad','Administration');

INSERT INTO Type VALUES ('I','Individuel');
INSERT INTO Type VALUES ('G','Groupe');
INSERT INTO Type VALUES ('S','Société');

INSERT INTO OptionSimulation (noOption, nomHotel, villeHotel, paysHotel, adresseHotel, nomLieu, villeLieu, paysLieu, noIdent) VALUES (OptSimulation_noOption.nextval,'TalkingPur','Terrebonne','Canada','122 fr','Tour Eiffel','Montréal','Canada','1234');
INSERT INTO OptionSimulation (noOption, nomHotel, villeHotel, paysHotel, adresseHotel, nomLieu, villeLieu, paysLieu, noIdent) VALUES (OptSimulation_noOption.nextval,'GetAway','Vancouvert','Canada','666 là','Murraille','Terrebonne','Canada','2345');
INSERT INTO OptionSimulation (noOption, nomHotel, villeHotel, paysHotel, adresseHotel, nomLieu, villeLieu, paysLieu, noIdent) VALUES (OptSimulation_noOption.nextval,'DontEnter','Montréal','Canada','65 fr','Apalache','Québec','Canada','5678');

INSERT INTO Simulation (noSimulation, nom, dateCreation, dateDepart, dateArrivee, nbPersonnes, noOption, cout) VALUES (Simulation_noSimulation.nextval,'John',CURRENT_DATE,'14-OCT-06','16-OCT-06',10,1,1000.00);
INSERT INTO Simulation (noSimulation, nom, dateCreation, dateDepart, dateArrivee, nbPersonnes, noOption, cout) VALUES (Simulation_noSimulation.nextval,'Hassen',CURRENT_DATE,'14-DEC-06','19-DEC-06',200,2,500.00);
INSERT INTO Simulation (noSimulation, nom, dateCreation, dateDepart, dateArrivee, nbPersonnes, noOption, cout) VALUES (Simulation_noSimulation.nextval,'Lui',CURRENT_DATE,'10-DEC-06','20-DEC-06',350,3,1250.00);

INSERT INTO Client VALUES (1,'John','12345',CURRENT_DATE,'I','Cl');
INSERT INTO Client VALUES (2,'Hassen','hahahaha',CURRENT_DATE,'G','Ag');
INSERT INTO Client VALUES (3,'Lui','uhf-5',CURRENT_DATE,'S','Ad');

INSERT INTO Reservation VALUES (1,1);
INSERT INTO Reservation VALUES (2,2);
INSERT INTO Reservation VALUES (3,3);

SELECT * FROM Simulation;
SELECT * FROM OptionSimulation;
SELECT * FROM Reservation;
SELECT * FROM Client;
SELECT * FROM Categorie;
SELECT * FROM Type;

DESCRIBE Simulation;
DESC OptionSimulation;
DESC Reservation;
DESC Client;
DESC Categorie;
DESC Type;
