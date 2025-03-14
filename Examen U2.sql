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
   VALUES('González', 'Méndez', 'Alejandro', '8714321987', 'gma@gmail.com');  

INSERT INTO Usuarios  
   VALUES('López', 'Hernández', 'Mariana', '8716785432', 'lhm@hotmail.com');  

INSERT INTO Usuarios  
   VALUES('Ramírez', 'Torres', 'Javier', '8711239876', 'rtj@yahoo.com');  

INSERT INTO Usuarios  
   VALUES('Martínez', 'Pérez', 'Sofía', '8718906543', 'mps@outlook.com');


