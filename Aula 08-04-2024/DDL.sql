CREATE DATABASE `vendas_delivery`;
USE `vendas_delivery`;

-- ----------------------------
-- Table structure for `cliente`
-- ----------------------------
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `IDCLIENTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `SOBRENOME` varchar(150) DEFAULT NULL,
  `DATANASC` datetime DEFAULT NULL,
  `CELULAR` varchar(11) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  `CPF` varchar(11) DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDCLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cliente
-- ----------------------------
INSERT INTO `cliente` VALUES ('1', 'Ádrian', 'Soares', null, '33912341234', 'cliente_1@email.com', null, '2024-04-08 14:42:50', 'S');
INSERT INTO `cliente` VALUES ('2', 'Álecs ', 'Santos', null, '33912341234', 'cliente_2@email.com', null, '2024-04-08 14:42:50', 'S');
INSERT INTO `cliente` VALUES ('3', 'Alexandre ', 'Corrêa', null, '33912341234', 'cliente_3@email.com', null, '2024-04-08 14:42:50', 'S');
INSERT INTO `cliente` VALUES ('4', 'Aline ', 'Oliveira', null, '33912341234', 'cliente_4@email.com', null, '2024-04-08 14:42:50', 'S');
INSERT INTO `cliente` VALUES ('5', 'Alisson ', 'Pereira', null, '33912341234', 'cliente_5@email.com', null, '2024-04-08 14:42:50', 'S');
INSERT INTO `cliente` VALUES ('6', 'Amilton ', 'Cruz', null, '33912341234', 'cliente_6@email.com', null, '2024-04-08 14:42:50', 'S');

-- ----------------------------
-- Table structure for `cliente_enderecos`
-- ----------------------------
DROP TABLE IF EXISTS `cliente_enderecos`;
CREATE TABLE `cliente_enderecos` (
  `IDENDERECO` int(11) NOT NULL AUTO_INCREMENT,
  `IDCLIENTE` int(11) NOT NULL,
  `CEP` varchar(8) DEFAULT NULL,
  `LOGRADOURO` varchar(150) DEFAULT NULL,
  `NUMERO` varchar(15) DEFAULT NULL,
  `COMPLEMENTO` varchar(100) DEFAULT NULL,
  `BAIRRO` varchar(100) DEFAULT NULL,
  `CIDADE` varchar(100) DEFAULT NULL,
  `ESTADO` varchar(100) DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDENDERECO`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of cliente_enderecos
-- ----------------------------
INSERT INTO `cliente_enderecos` VALUES ('1', '1', '35065000', 'RUA 01', '101', 'APT', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');
INSERT INTO `cliente_enderecos` VALUES ('2', '2', '35065000', 'RUA 02', '102', 'CASA', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');
INSERT INTO `cliente_enderecos` VALUES ('3', '3', '35065000', 'RUA 03', '103', 'APT', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');
INSERT INTO `cliente_enderecos` VALUES ('4', '4', '35065000', 'RUA 04', '104', 'CASA', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');
INSERT INTO `cliente_enderecos` VALUES ('5', '5', '35065000', 'RUA 05', '105', 'APT', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');
INSERT INTO `cliente_enderecos` VALUES ('6', '6', '35065000', 'RUA 06', '106', 'CASA', 'Centro', 'Gov. Valadares', 'MG', '2024-04-08 14:44:45', 'S');

-- ----------------------------
-- Table structure for `empresa`
-- ----------------------------
DROP TABLE IF EXISTS `empresa`;
CREATE TABLE `empresa` (
  `IDEMPRESA` int(11) NOT NULL,
  `NOMEFANTASIA` varchar(150) NOT NULL,
  `RAZAOSOCIAL` varchar(150) DEFAULT NULL,
  `CNPJ` varchar(14) DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `CEP` varchar(8) DEFAULT NULL,
  `LOGRADOURO` varchar(255) DEFAULT NULL,
  `NUMERO` varchar(10) DEFAULT NULL,
  `CIDADE` varchar(100) DEFAULT NULL,
  `ESTADO` varchar(50) DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDEMPRESA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of empresa
-- ----------------------------
INSERT INTO `empresa` VALUES ('1', 'Lanches Mais', 'Matriz LTDA', '81854324000175', '2024-04-08 14:45:17', '35065000', 'RUA 0', '100', 'Gov. Valadares', 'MG', 'S');

-- ----------------------------
-- Table structure for `funcionario`
-- ----------------------------
DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `IDFUNCIONARIO` int(11) NOT NULL AUTO_INCREMENT,
  `IDEMPRESA` int(11) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `NOMECOMPLETO` varchar(255) DEFAULT NULL,
  `CELULAR` varchar(11) DEFAULT NULL,
  `CPF` varchar(11) DEFAULT NULL,
  `CARGO` varchar(100) DEFAULT NULL,
  `CEP` varchar(8) DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDFUNCIONARIO`),
  KEY `FK_FUNCIONARIO_EMPRESA` (`IDEMPRESA`),
  CONSTRAINT `FK_FUNCIONARIO_EMPRESA` FOREIGN KEY (`IDEMPRESA`) REFERENCES `empresa` (`IDEMPRESA`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of funcionario
-- ----------------------------
INSERT INTO `funcionario` VALUES ('1', '1', 'Wallyson ', 'Wallyson Freitas da Silva', null, null, 'Caixa', '35065000', '2024-04-08 14:46:51', 'S');
INSERT INTO `funcionario` VALUES ('2', '1', 'Vinicius ', '	Vinicius Handre Marques Coelho', null, null, 'Caixa', '35065000', '2024-04-08 14:46:51', 'S');
INSERT INTO `funcionario` VALUES ('3', '1', 'Victor ', 'Victor Felipe de Oliveira Nery', null, null, 'Caixa', '35065000', '2024-04-08 14:46:51', 'S');
INSERT INTO `funcionario` VALUES ('4', '1', 'VICTOR ', '	VICTOR EMMANUEL ARAUJO SILVA', null, null, 'Caixa', '35065000', '2024-04-08 14:46:51', 'S');

-- ----------------------------
-- Table structure for `grupo`
-- ----------------------------
DROP TABLE IF EXISTS `grupo`;
CREATE TABLE `grupo` (
  `IDGRUPO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDGRUPO`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of grupo
-- ----------------------------
INSERT INTO `grupo` VALUES ('1', 'Lanches', '2024-04-08 14:47:48', 'S');
INSERT INTO `grupo` VALUES ('2', 'Pizzas', '2024-04-08 14:47:48', 'S');
INSERT INTO `grupo` VALUES ('3', 'Bebidas', '2024-04-08 14:47:48', 'S');

-- ----------------------------
-- Table structure for `produto`
-- ----------------------------
DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `IDPRODUTO` int(11) NOT NULL AUTO_INCREMENT,
  `IDGRUPO` int(11) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `DESCRICAO` varchar(255) DEFAULT NULL,
  `PRECO` float DEFAULT NULL,
  `DIRIMAGEM` varchar(255) DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `ATIVO` varchar(1) DEFAULT 'S',
  PRIMARY KEY (`IDPRODUTO`),
  KEY `FK_PRODUTO_GRUPO` (`IDGRUPO`),
  CONSTRAINT `FK_PRODUTO_GRUPO` FOREIGN KEY (`IDGRUPO`) REFERENCES `grupo` (`IDGRUPO`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of produto
-- ----------------------------
INSERT INTO `produto` VALUES ('1', '1', ' Hamburguer', ' ', '18.99', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('2', '1', 'X-Tudo', ' ', '25.99', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('3', '1', 'X-Bacon', ' ', '22.99', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('4', '2', 'Pizza de Calabresa', ' ', '44.5', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('5', '2', 'Pizza de Frango Com Catupiry', ' ', '44.5', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('6', '2', 'Pizza de Bacon', ' ', '44.5', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('7', '3', 'Coca Coca Lata', ' ', '6.5', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('8', '3', 'Água Mineral 500m', ' ', '3.5', null, '2024-04-08 14:50:51', 'S');
INSERT INTO `produto` VALUES ('9', '3', 'H2OH Limoneto', ' ', '5.5', null, '2024-04-08 14:50:51', 'S');

-- ----------------------------
-- Table structure for `venda`
-- ----------------------------
DROP TABLE IF EXISTS `venda`;
CREATE TABLE `venda` (
  `IDVENDA` int(11) NOT NULL AUTO_INCREMENT,
  `IDEMPRESA` int(11) NOT NULL,
  `IDCLIENTE` int(11) NOT NULL,
  `IDENDERECO` int(11) DEFAULT NULL,
  `IDFUNCIONARIO` int(11) NOT NULL,
  `TIPOVENDA` varchar(1) DEFAULT '',
  `VALORPRODUTOS` float DEFAULT NULL,
  `TAXAENTREGA` float DEFAULT NULL,
  `TOTALVENDA` float DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  `STATUSVENDA` varchar(1) DEFAULT 'N',
  PRIMARY KEY (`IDVENDA`),
  KEY `FK_VENDA_EMPRESA` (`IDEMPRESA`),
  KEY `FK_VENDA_CLIENTE` (`IDCLIENTE`),
  KEY `FK_VENDA_CLIENTEENDERECOS` (`IDENDERECO`),
  KEY `FK_VENDA_FUNCIONARIO` (`IDFUNCIONARIO`),
  CONSTRAINT `FK_VENDA_CLIENTE` FOREIGN KEY (`IDCLIENTE`) REFERENCES `cliente` (`IDCLIENTE`),
  CONSTRAINT `FK_VENDA_CLIENTEENDERECOS` FOREIGN KEY (`IDENDERECO`) REFERENCES `cliente_enderecos` (`IDENDERECO`),
  CONSTRAINT `FK_VENDA_EMPRESA` FOREIGN KEY (`IDEMPRESA`) REFERENCES `empresa` (`IDEMPRESA`),
  CONSTRAINT `FK_VENDA_FUNCIONARIO` FOREIGN KEY (`IDFUNCIONARIO`) REFERENCES `funcionario` (`IDFUNCIONARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of venda
-- ----------------------------
INSERT INTO `venda` VALUES ('1', '1', '1', '1', '1', 'D', '50', '5', '55', '2024-04-08 14:51:46', 'A');
INSERT INTO `venda` VALUES ('2', '1', '2', '1', '2', 'B', '50', '0', '50', '2024-04-08 14:51:46', 'E');
INSERT INTO `venda` VALUES ('3', '1', '3', '1', '3', 'B', '50', '0', '50', '2024-04-08 14:51:46', 'E');
INSERT INTO `venda` VALUES ('4', '1', '4', '1', '4', 'D', '50', '5', '55', '2024-04-08 14:51:46', 'C');

-- ----------------------------
-- Table structure for `venda_itens`
-- ----------------------------
DROP TABLE IF EXISTS `venda_itens`;
CREATE TABLE `venda_itens` (
  `IDVENDAITEM` int(11) NOT NULL AUTO_INCREMENT,
  `IDITEM` int(11) NOT NULL,
  `IDVENDA` int(11) NOT NULL,
  `IDPRODUTO` int(11) NOT NULL,
  `QTDE` float DEFAULT NULL,
  `PRECOVENDA` float DEFAULT NULL,
  `DATACAD` datetime DEFAULT NULL,
  PRIMARY KEY (`IDVENDAITEM`),
  KEY `FK_VENDAITENS_PRODUTO` (`IDPRODUTO`),
  KEY `FK_VENDAITENS_VENDA` (`IDVENDA`),
  CONSTRAINT `FK_VENDAITENS_PRODUTO` FOREIGN KEY (`IDPRODUTO`) REFERENCES `produto` (`IDPRODUTO`),
  CONSTRAINT `FK_VENDAITENS_VENDA` FOREIGN KEY (`IDVENDA`) REFERENCES `venda` (`IDVENDA`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of venda_itens
-- ----------------------------
INSERT INTO `venda_itens` VALUES ('1', '1', '1', '4', '1', '44.5', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('2', '2', '1', '7', '1', '6.5', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('3', '1', '2', '1', '1', '18.99', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('4', '2', '2', '8', '1', '3.5', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('5', '1', '3', '2', '1', '25.99', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('6', '2', '3', '5', '1', '44.5', '2024-04-08 14:54:12');
INSERT INTO `venda_itens` VALUES ('7', '3', '3', '9', '2', '11', '2024-04-08 14:54:12');