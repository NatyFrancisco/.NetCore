CREATE DATABASE dbMigracion

--Entrada a la BD
SET QUOTED_IDENTIFIER OFF;
GO
USE dbMigracion
GO

IF SCHEMA_ID(N'dbo')IS NULL EXECUTE (N'CREATE SCHEMA[dbo]');
GO

--Crecacion de las tablas

CREATE TABLE [dbo].[persona](

 [id] int primary key identity (1,1),
 [nombre] varchar (50) NOT NULL,
 [apellido] varchar (50) NOT NULL,
  [fecha_nacimiento] datetime NOT NULL,
 [pasaporte] bigint NOT NULL,
 [direccion] varchar(80) NOT NULL,
 [sexo] varchar (50) NOT NULL

 );
GO




CREATE TABLE [dbo].[solicitud](

 [id] int primary key identity(1,1),
 [nombre_estado] varchar(50) NOT NULL,
 [fecha_creacion] datetime NOT NULL

 );
GO

CREATE TABLE [dbo].[modeloequipo](
 [id] int primary key identity (1,1),
 [personaId] int NOT NULL,
  [estadoId] varchar (50) NOT NULL,
  [fecha_creacion] datetime NOT NULL,
  CONSTRAINT fk_persona FOREIGN KEY (personaId) REFERENCES persona (id),
  CONSTRAINT fk_estados FOREIGN KEY (estadoId) REFERENCES estados (estado)
 );
GO

CREATE TABLE [dbo].[estados](
 [estado] varchar (50) NOT NULL primary key
 

);
GO

insert into estados values ('Abierta')
 insert into estados values ('Aprobadas')
 insert into estados values ('Canceladas')

 select * from estados

select * from persona