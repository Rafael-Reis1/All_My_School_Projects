CREATE DATABASE ATIVIDADE3;
USE ATIVIDADE3;

CREATE TABLE FORNECEDOR
(
	ID_FORNECEDOR INT PRIMARY KEY AUTO_INCREMENT,
    NOME_FORNECEDOR VARCHAR(100) NOT NULL,
    CNPJ VARCHAR(15) UNIQUE NOT NULL,
    ENDERECO VARCHAR(150)
);

CREATE TABLE PRODUTO
(
	ID_PRODUTO INT PRIMARY KEY AUTO_INCREMENT,
    NOME_PRODUTO VARCHAR(50) NOT NULL,
    DESCRICAO VARCHAR(200)
);

CREATE TABLE FORNECEDOR_PRODUTO
(
	ID_FORNECEDOR_PRODUTO INT PRIMARY KEY AUTO_INCREMENT,
    ID_FORNECEDOR INT NOT NULL,
    ID_PRODUTO INT NOT NULL,
    FOREIGN KEY(ID_FORNECEDOR) REFERENCES FORNECEDOR(ID_FORNECEDOR),
    FOREIGN KEY(ID_PRODUTO) REFERENCES PRODUTO(ID_PRODUTO)
);

CREATE TABLE CLIENTE
(
	ID_CLIENTE INT PRIMARY KEY AUTO_INCREMENT,
    NOME_CLIENTE VARCHAR(100) NOT NULL,
    ENDERECO VARCHAR(200)
);

CREATE TABLE EMPRESA
(
	ID_EMPRESA INT PRIMARY KEY AUTO_INCREMENT,
    NOME_EMPRESA VARCHAR(100) NOT NULL,
    CNPJ VARCHAR(15) UNIQUE NOT NULL
);

CREATE TABLE VENDA
(
	ID_VENDA INT PRIMARY KEY AUTO_INCREMENT,
    NUMERO_NOTA_FISCAL VARCHAR(20) NOT NULL,
    DATA DATE NOT NULL,
    VALOR_TOTAL DECIMAL(10,2) NOT NULL,
    ID_EMPRESA INT NOT NULL,
    ID_CLIENTE INT NOT NULL,
    FOREIGN KEY(ID_EMPRESA) REFERENCES EMPRESA(ID_EMPRESA),
    FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE)
);

CREATE TABLE ITENS_VENDA
(
	ID_ITENS_VENDA INT PRIMARY KEY AUTO_INCREMENT,
    VALOR_UNITARIO DECIMAL(10,2) NOT NULL,
    QUANTIDADE INT NOT NULL,
    ID_VENDA INT NOT NULL,
    ID_PRODUTO INT NOT NULL,
    FOREIGN KEY(ID_VENDA) REFERENCES VENDA(ID_VENDA),
    FOREIGN KEY(ID_PRODUTO) REFERENCES PRODUTO(ID_PRODUTO)
);