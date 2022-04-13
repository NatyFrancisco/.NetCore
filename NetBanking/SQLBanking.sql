CREATE DATABASE dbBanking

--Entrada a la BD
SET QUOTED_IDENTIFIER OFF;
GO
USE dbBanking
GO



IF SCHEMA_ID(N'dbo')IS NULL EXECUTE (N'CREATE SCHEMA[dbo]');
GO

--Crecacion de las tablas

CREATE TABLE [dbo].[user](

 [id] int  identity (1,1),
 [cedula] bigint primary key NOT NULL,
 [nombre] varchar (50) NOT NULL,
 [apellido] varchar (50) NOT NULL,
  [usuario] varchar (50) NOT NULL,
 [passw] varchar(50) NOT NULL,


 );
GO




CREATE TABLE [dbo].[cuenta](

 [id] int  identity(1,1),
 [noCuenta] bigint primary key NOT NULL,
 [balance] bigint NOT NULL

 );
GO

CREATE TABLE [dbo].[transferencia](
 [id] int primary key identity (1,1),
fecha datetime not null,
 [tipoCuenta] varchar (50) NOT NULL,
  [banco] varchar (50) NOT NULL,
 [noCuenta] bigint NOT NULL,
  [monto] bigint NOT NULL
 );

 
GO



 select * from [user]

select * from cuenta