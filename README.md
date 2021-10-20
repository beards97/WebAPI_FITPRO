# WEB API .NET CORE 3.1 FITPRO

Este es un WEB API desarrollado en .NET CORE `3.1` con conexión a Base de Datos SQL SERVER por medio del Micro ORM llamado Dapper.

El cual se realizan los siguientes metodos:
ADD, LIST y DELETE.

# Creacion de la Base de Datos

Hay que crear la Base de Datos con el siguiente Script:

``CREATE DATABASE FPTBD
GO``

``USE FPTBD
GO``

``CREATE TABLE Customer
(
Id INT IDENTITY PRIMARY KEY NOT NULL,
Name VARCHAR(100) NOT NULL,
Phone VARCHAR(10) NOT NULL,
Email VARCHAR(100) NOT NULL,
Notes VARCHAR(100) NOT NULL
)
GO``

# String de Conexion en el WEB API

En el controllador llamado `FptController` tenemos que modificar nuestro string de conexion a la base de datos con las respectivas credenciales de la misma.

# Ejecución del WEB API

Una vez modificado el string de conexion podemos ejecutar nuestro WEB API de manera local para asi mismo poder consumirlo desde el FrontEnd.

# Consumir el WEB API desde POSTMAN

Podemos realizar las dichas pruebas del WEB API desde `POSTMAN`.
Con esta URL `https://localhost:44349/Fpt/` y con su respectivo metodo `GET`, `POST` y `DELETE` podemos realizar las consultas y asi mismo validar su funcionalidad.

