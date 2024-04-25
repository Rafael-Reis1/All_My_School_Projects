CREATE DATABASE ATIVIDADE7;
USE ATIVIDADE7;

CREATE TABLE MEDICO
(
	ID_MEDICO INT PRIMARY KEY AUTO_INCREMENT,
    NOME VARCHAR(100) NOT NULL,
    CRM VARCHAR(15) UNIQUE NOT NULL,
    DATA_ADMISSAO DATE NOT NULL,
    SALARIO DECIMAL(10,2) NOT NULL
);

CREATE TABLE PACIENTE
(
	ID_PACIENTE INT PRIMARY KEY AUTO_INCREMENT,
    NOME VARCHAR(100) NOT NULL,
    RG VARCHAR(15) UNIQUE NOT NULL,
    CPF VARCHAR(15) UNIQUE NOT NULL,
    TELEFONE VARCHAR(15),
    ENDERECO VARCHAR(200)
);

CREATE TABLE CONSULTA
(
	ID_CONSULTA INT PRIMARY KEY AUTO_INCREMENT,
    ID_MEDICO INT NOT NULL,
    ID_PACIENTE INT NOT NULL,
    DATA_HORA_VISITA DATETIME NOT NULL,
    FOREIGN KEY(ID_MEDICO) REFERENCES MEDICO(ID_MEDICO),
    FOREIGN KEY(ID_PACIENTE) REFERENCES PACIENTE(ID_PACIENTE)
);

CREATE TABLE QUARTO
(
	ID_QUARTO INT PRIMARY KEY AUTO_INCREMENT,
    ANDAR INT NOT NULL,
    ID_PACIENTE INT,
    FOREIGN KEY(ID_PACIENTE) REFERENCES PACIENTE(ID_PACIENTE)
);