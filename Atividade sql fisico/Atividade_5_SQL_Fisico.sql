CREATE DATABASE ATIVIDADE5;
USE ATIVIDADE5;

CREATE TABLE CLIENTE
(
	ID_CLIENTE INT PRIMARY KEY AUTO_INCREMENT,
    NOME_COMPLETO VARCHAR(100) NOT NULL,
    RG VARCHAR(15) UNIQUE NOT NULL,
    CPF VARCHAR(15) UNIQUE NOT NULL,
    ENDERECO VARCHAR(200)
);

CREATE TABLE VEICULO
(
	ID_VEICULO INT PRIMARY KEY AUTO_INCREMENT,
    COD_RENAVAN VARCHAR(20) UNIQUE NOT NULL,
    FABRICANTE VARCHAR(50) NOT NULL,
    MODELO VARCHAR(50) NOT NULL,
    ANO INT NOT NULL,
    ID_CLIENTE INT NOT NULL,
    FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE)
);

CREATE TABLE OCORRENCIA
(
	ID_OCORRENCIA INT PRIMARY KEY AUTO_INCREMENT,
    DATA DATE NOT NULL,
    LOCAL VARCHAR(200) NOT NULL,
    DESCRICAO VARCHAR(200),
    ID_VEICULO INT,
    FOREIGN KEY(ID_VEICULO) REFERENCES VEICULO(ID_VEICULO)
);