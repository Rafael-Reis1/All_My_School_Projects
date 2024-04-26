CREATE DATABASE ATIVIDADE11;
USE ATIVIDADE11;

CREATE TABLE CLIENTE
(
	ID_CLIENTE INT PRIMARY KEY AUTO_INCREMENT,
    NOME_COMPLETO VARCHAR(100) NOT NULL,
    CPF VARCHAR(15) UNIQUE NOT NULL,
    ENDERECO VARCHAR(200)
);

CREATE TABLE VENDA
(
	ID_VENDA INT PRIMARY KEY AUTO_INCREMENT,
    NUMERO_NOTA_FISCAL INT NOT NULL,
    DATA_VENDA DATE NOT NULL,
    DESCONTO DECIMAL(10,2),
    ENDERECO_ENTREGA VARCHAR(200) NOT NULL,
    ID_CLIENTE INT NOT NULL,
    FOREIGN KEY(ID_CLIENTE) REFERENCES CLIENTE(ID_CLIENTE)
);

CREATE TABLE PRODUTO
(
	ID_PRODUTO INT PRIMARY KEY AUTO_INCREMENT,
    PRECO_TABELA DECIMAL(10,2) NOT NULL,
    NOME_PRODUTO VARCHAR(100) NOT NULL,
    DESCRICAO VARCHAR(200)
);

CREATE TABLE PRODUTO_VENDA
(
	ID_PRODUTO_VENDA INT PRIMARY KEY AUTO_INCREMENT,
    QTD_VENDIDA INT NOT NULL,
    PRECO_VENDA DECIMAL(10,2) NOT NULL,
    ID_VENDA INT NOT NULL,
    ID_PRODUTO INT NOT NULL,
    FOREIGN KEY(ID_VENDA) REFERENCES VENDA(ID_VENDA),
    FOREIGN KEY(ID_PRODUTO) REFERENCES PRODUTO(ID_PRODUTO)
);