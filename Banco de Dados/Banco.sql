-- DDL - Linguagem de definição de dados

-- APAGAR BASE DE DADOS (caso existia)
-- DROP DATABASE Clinica_Medica

-- CRIAR A BASE DE DADOS (Clínica médica)
CREATE DATABASE Clinica_Medica;
GO

USE Clinica_Medica
GO

-- TABLE PACIENTE
CREATE TABLE Paciente(
	CPF VARCHAR(14) PRIMARY KEY,
	Nome VARCHAR(40),
	Telefone VARCHAR(30),
	NumeroPlano INT,
	NomePlano VARCHAR(20),
	TipoPlano VARCHAR(10)
);
GO

-- TABLE MEDICO
CREATE TABLE Medico(
	CRM INT PRIMARY KEY,
	NomeMedico VARCHAR(30),
	Especialidade VARCHAR(20)
);
GO

-- TABLE CONSULTA
CREATE TABLE Consulta(
	NumeroConsulta INT PRIMARY KEY IDENTITY(100, 1),
	DataConsulta DATE,
	HorarioConsulta TIME,
	CRM_Medico INT FOREIGN KEY REFERENCES Medico(CRM),
	CPF_Paciente VARCHAR(14) FOREIGN KEY REFERENCES Paciente(CPF)
);
GO

SELECT * FROM Paciente;
SELECT * FROM Medico;
SELECT * FROM Consulta;