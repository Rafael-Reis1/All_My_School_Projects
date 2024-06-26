CREATE DATABASE vendas_fomedemais;

USE vendas_fomedemais;

CREATE TABLE cliente (
  IDCLIENTE int(11) NOT NULL AUTO_INCREMENT,
  NOME varchar(100) NOT NULL,
  SOBRENOME varchar(150) DEFAULT NULL,
  DATANASC datetime DEFAULT NULL,
  CELULAR varchar(11) DEFAULT NULL,
  EMAIL varchar(255) DEFAULT NULL,
  CPF varchar(11) DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDCLIENTE)
);

CREATE TABLE cliente_enderecos (
  IDENDERECO int(11) NOT NULL AUTO_INCREMENT,
  IDCLIENTE int(11) NOT NULL,
  CEP varchar(7) DEFAULT NULL,
  LOGRADOURO varchar(150) DEFAULT NULL,
  NUMERO varchar(15) DEFAULT NULL,
  COMPLEMENTO varchar(100) DEFAULT NULL,
  BAIRRO varchar(100) DEFAULT NULL,
  CIDADE varchar(100) DEFAULT NULL,
  ESTADO varchar(100) DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDENDERECO)
);

CREATE TABLE empresa (
  IDEMPRESA int(11) NOT NULL AUTO_INCREMENT,
  NOMEFANTASIA varchar(150) NOT NULL,
  RAZAOSOCIAL varchar(150) DEFAULT NULL,
  CNPJ varchar(14) DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDEMPRESA)
);

CREATE TABLE funcionario (
  IDFUNCIONARIO int(11) NOT NULL AUTO_INCREMENT,
  IDEMPRESA int(11) NOT NULL,
  NOME varchar(100) NOT NULL,
  NOMECOMPLETO varchar(255) DEFAULT NULL,
  CELULAR varchar(11) DEFAULT NULL,
  CPF varchar(11) DEFAULT NULL,
  CARGO varchar(100) DEFAULT NULL,
  CEP varchar(7) DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDFUNCIONARIO),
  CONSTRAINT FK_FUNCIONARIO_EMPRESA FOREIGN KEY (IDEMPRESA) REFERENCES empresa (IDEMPRESA)
);

CREATE TABLE grupo (
  IDGRUPO int(11) NOT NULL AUTO_INCREMENT,
  NOME varchar(100) NOT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDGRUPO)
) ;

CREATE TABLE produto (
  IDPRODUTO int(11) NOT NULL AUTO_INCREMENT,
  IDGRUPO int(11) NOT NULL,
  NOME varchar(100) NOT NULL,
  DESCRICAO varchar(255) DEFAULT NULL,
  PRECO float DEFAULT NULL,
  DIRIMAGEM varchar(255) DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  ATIVO varchar(1) DEFAULT 'S',
  PRIMARY KEY (IDPRODUTO),
  CONSTRAINT FK_PRODUTO_GRUPO FOREIGN KEY (IDGRUPO) REFERENCES grupo (IDGRUPO)
);

CREATE TABLE venda (
  IDVENDA int(11) NOT NULL AUTO_INCREMENT,
  IDEMPRESA int(11) NOT NULL,
  IDCLIENTE int(11) NOT NULL,
  IDENDERECO int(11) DEFAULT NULL,
  IDFUNCIONARIO int(11) NOT NULL,
  TIPOVENDA varchar(1) DEFAULT '',
  VALORPRODUTOS float DEFAULT NULL,
  TAXAENTREGA float DEFAULT NULL,
  TOTALVENDA float DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  STATUSVENDA varchar(1) DEFAULT 'N',
  PRIMARY KEY (IDVENDA),
  CONSTRAINT FK_VENDA_EMPRESA FOREIGN KEY (IDEMPRESA) REFERENCES empresa (IDEMPRESA),
  CONSTRAINT FK_VENDA_CLIENTE FOREIGN KEY (IDCLIENTE) REFERENCES cliente (IDCLIENTE),
  CONSTRAINT FK_VENDA_CLIENTEENDERECOS FOREIGN KEY (IDENDERECO) REFERENCES cliente_enderecos (IDENDERECO),
  CONSTRAINT FK_VENDA_FUNCIONARIO FOREIGN KEY (IDFUNCIONARIO) REFERENCES funcionario (IDFUNCIONARIO)
);

CREATE TABLE venda_itens (
  IDVENDAITEM int(11) NOT NULL AUTO_INCREMENT,
  IDITEM int(11) NOT NULL,
  IDVENDA int(11) NOT NULL,
  IDPRODUTO int(11) NOT NULL,
  QTDE float DEFAULT NULL,
  PRECOVENDA float DEFAULT NULL,
  DATACAD datetime DEFAULT NULL,
  PRIMARY KEY (IDVENDAITEM),
  CONSTRAINT FK_VENDAITENS_PRODUTO FOREIGN KEY (IDPRODUTO) REFERENCES produto (IDPRODUTO),
  CONSTRAINT FK_VENDAITENS_VENDA FOREIGN KEY (IDVENDA) REFERENCES venda (IDVENDA)
);