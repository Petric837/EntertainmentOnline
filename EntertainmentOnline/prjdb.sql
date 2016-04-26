CREATE TABLE Users
(
   username       varchar(30)     NOT NULL,
   password       varchar(30) 	  NOT NULL,
   address        varchar(50)     NOT NULL,
   phone          char(12)        NOT NULL,
   cardType       varchar(30)     NOT NULL,
   cardNumber     char(19)        NOT NULL,
   role           char(7)         NOT NULL,

   PRIMARY KEY(username)
);

ALTER TABLE Users ADD CONSTRAINT 
roleConstraint CHECK (role = 'regular' OR role = 'admin');

insert into Users (username, password, address, phone, cardType, cardNumber, role)
values ('jgp18', 'Goose123', '77 Fir Hill Akron, OH', '440-759-0356', 'Visa', '1234-4321-5678-8765', 'admin');

insert into Users (username, password, address, phone, cardType, cardNumber, role)
values ('user', 'pass', '123 Main Street Cleveland, OH', '330-282-2828', 'Discover', '2233-4422-0909-3465', 'regular');



CREATE TABLE Rentals
(
   id               int             NOT NULL AUTO_INCREMENT,
   type             char(9) 	    NOT NULL,
   title            varchar(60)     NOT NULL,
   genre            char(50)        NOT NULL,
   releaseDate      varchar(10)     NOT NULL,
   price            varchar(10)     NOT NULL,
   reviewScore      varchar(3)      NOT NULL,

   PRIMARY KEY(id)
);

ALTER TABLE Rentals ADD CONSTRAINT 
typeConstraint CHECK (type = 'movie' OR type = 'videogame');

insert into Rentals (type, title, genre, releaseDate, price, reviewScore)
values ('movie', 'Titanic 3', 'Romantic Comedy', '4/18/2016', '3.99', '5.6');

insert into Rentals (type, title, genre, releaseDate, price, reviewScore)
values ('videogame', 'Mario Fiesta 5', 'Party Game', '5/23/2016', '5.99', '8.1');

