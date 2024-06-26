CREATE DATABASE RAFAELREIS;

-- @BLOCK
USE RAFAELREIS;

-- @BLOCK
CREATE TABLE PRODUTO
(
    ID_PRODUTO INT AUTO_INCREMENT,
    NOME VARCHAR(255) NOT NULL,
    PRECO FLOAT NOT NULL,
    ATIVO VARCHAR(1) DEFAULT "S",
    PRIMARY KEY(ID_PRODUTO)
);

-- @BLOCK
CREATE TABLE CLIENTE
(
    ID_CLIENTE INT AUTO_INCREMENT,
    NOME VARCHAR(255) NOT NULL,
    ENDERECO VARCHAR(255),
    CELULAR VARCHAR(11),
    ATIVO VARCHAR(1) DEFAULT "S",
    PRIMARY KEY(ID_CLIENTE)
);

-- @BLOCK
CREATE TABLE FUNCIONARIO
(
    ID_FUNCIONARIO INT AUTO_INCREMENT,
    NOME VARCHAR(255) NOT NULL,
    MATRICULA VARCHAR(15),
    ENDERECO VARCHAR(255),
    ATIVO VARCHAR(1) DEFAULT "S",
    PRIMARY KEY(ID_FUNCIONARIO)
);


-- @BLOCK
CREATE TABLE VENDAS
(
    ID_VENDA INT AUTO_INCREMENT,
    ID_FUNCIONARIO INT,
    ID_CLIENTE INT,
    VALOR FLOAT DEFAULT 0,
    DATAHORA DATETIME,
    `STATUS` VARCHAR(1) DEFAULT "S",
    PRIMARY KEY(ID_VENDA),
    FOREIGN KEY(ID_FUNCIONARIO) REFERENCES FUNCIONARIO(ID_FUNCIONARIO),
    FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE)
);
