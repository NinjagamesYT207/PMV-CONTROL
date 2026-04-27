-- Banco de Dados Generico -- 
CREATE DATABASE BD_GENERICO
USE BD_GENERICO

-- Tabela Produtos generica --
CREATE TABLE PRODUTOS
(
	ProdutoID int identity primary key,
	Item		varchar(80) not null,
	Material    varchar(80) not null,
	Peso	Decimal  not null,
	Espessura Decimal not null,
	Qtde_Chapa		Int not null 
)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica A', 'Aço Carbono (Fina Frio)',17,0.90,100)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica B', 'Aço Carbono (Fina Quente)',22.6,0.40,200)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica C', 'Aço Galvanizado',37,0.10,100)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica D', 'Alumínio (Liso)',47,0.20,100)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica E', 'Aço Carbono (Fina Frio)',67,0.30,300)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica F', 'Aço Carbono (Fina Frio)',27,0.50,400)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica G', 'Aço Galvanizado',78,0.90,100)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica H', 'Aço Carbono (Fina Frio)',80,0.60,500)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica I', 'Aço Carbono (Fina Frio)',90,0.70,600)
INSERT INTO PRODUTOS(Item,Material,Peso,Espessura,Qtde_Chapa) VALUES('Peça Genérica J', 'Alumínio (Liso)',45,0.80,100)

SELECT*FROM PRODUTOS


-- Peças Prontas -- 
CREATE TABLE PEÇASPRONTAS
(
	ProdutoID int identity primary key,
	Item		varchar(80) not null,
	Material    varchar(80) not null,
	Peso	Decimal  not null,
	Espessura Decimal not null,
	Qtde		Int not null,
	Preco_Unitario Decimal not null 
)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica A', 'Aço Carbono (Fina Frio)',17,0.90,100,100)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica B', 'Aço Carbono (Fina Quente)',17,0.90,200,200)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica C', 'Aço Galvanizado',17,0.90,300,300)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica D', 'Alumínio (Liso)',17,0.90,400,400)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica E', 'Aço Carbono (Fina Frio)',17,0.90,500,500)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica F', 'Aço Carbono (Fina Frio)',17,0.90,600,600)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica G', 'Aço Galvanizado',17,0.90,700,700)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica H', 'Aço Carbono (Fina Frio)',17,0.90,800,800)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica I', 'Aço Carbono (Fina Frio)',17,0.90,900,900)
INSERT INTO PEÇASPRONTAS(Item,Material,Peso,Espessura,Qtde,Preco_Unitario) VALUES('Peça Genérica J', 'Alumínio (Liso)',17,0.90,1000,1000)

SELECT*FROM PEÇASPRONTAS

CREATE TABLE usuarios (
usuario varchar(50) not null,
senha int primary key)

insert into usuarios values ('admin', 123)