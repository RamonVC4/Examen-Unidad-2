Create database Agenda
use Agenda

--TABLA USUARIOS - Id, APaterno, AMaterno, Nombre, Telefono, Correo
CREATE TABLE USUARIOS
(
	ID int IDENTITY(100,1) primary key not null,
	APATERNO varchar(50) not null,
	AMATERNO varchar(50) not null,
	NOMBRE varchar(50) not null,
	TELEFONO varchar(13),
	CORREO varchar(100)
)
go

--drop table Usuarios

INSERT INTO Usuarios
   values('Villanueva','Carmona','Ramon','8715666503','vcr@gmail.com');

INSERT INTO Usuarios  
   VALUES('Gonz�lez', 'M�ndez', 'Alejandro', '8714321987', 'gma@gmail.com');  

INSERT INTO Usuarios  
   VALUES('L�pez', 'Hern�ndez', 'Mariana', '8716785432', 'lhm@hotmail.com');  

INSERT INTO Usuarios  
   VALUES('Ram�rez', 'Torres', 'Javier', '8711239876', 'rtj@yahoo.com');  

INSERT INTO Usuarios  
   VALUES('Mart�nez', 'P�rez', 'Sof�a', '8718906543', 'mps@outlook.com');


