CREATE DATABASE CONTROLE_ESTOQUE;


USE CONTROLE_ESTOQUE;


CREATE TABLE Categoria(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL
);
GO

CREATE TABLE Armazem(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL
);
GO

CREATE TABLE TipoTransacao(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL
);

GO

CREATE TABLE Prestador(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL
);

GO

CREATE TABLE Item(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL,
numeroLoteRequerido VARCHAR(30),
FornecedorID INT FOREIGN KEY REFERENCES Prestador(ID),
CategoriaID INT FOREIGN KEY REFERENCES Categoria(ID),
localID INT FOREIGN KEY REFERENCES Armazem(ID)
);
GO
CREATE TABLE Pedido(
ID INT PRIMARY KEY IDENTITY NOT NULL,
tipoTransacaoID INT FOREIGN KEY REFERENCES TipoTransacao(ID),
transportadoraID INT FOREIGN KEY REFERENCES Prestador(ID),
lojaID INT FOREIGN KEY REFERENCES Prestador(ID),
armazemOrigemID INT FOREIGN KEY REFERENCES Armazem(ID),
armazemDestinoID INT FOREIGN KEY REFERENCES Armazem(ID),
dataPedido VARCHAR(50),
dataEntrega VARCHAR(50)
);

GO


CREATE TABLE ItemPedido(
ID INT PRIMARY KEY IDENTITY NOT NULL,
nome VARCHAR(255) NOT NULL,
numeroLote VARCHAR(30) NOT NULL,
quantidade INT NOT NULL,
pedidoID INT FOREIGN KEY REFERENCES Pedido(ID),
itemID INT FOREIGN KEY REFERENCES Item(ID)
);


GO

SELECT * FROM Categoria;
SELECT * FROM Armazem;
SELECT * FROM TipoTransacao;
SELECT * FROM Prestador;
SELECT * FROM Item;
SELECT * FROM Pedido;
SELECT * FROM ItemPedido;


-- 5. Mostrar as entradas e saídas dos itens
-- Tipo Transação, Id Item, Nome Item , Nome Transportadora, Qtd, Data, DataEntrega


select i.id, i.nome, numeroLoteRequerido,quantidadeMinima,p.nome 'Fornecedor',a.nome 'Loja'
from item I, Armazem A, Prestador P
where i.FornecedorID = p.id and i.localID = a.id

select * from Item
select * from TipoTransacao


SET IDENTITY_INSERT TipoTransacao ON


INSERT TipoTransacao (ID , nome) VALUES (1, 'Ordem de Compra');
INSERT TipoTransacao (ID , nome) VALUES (2, 'Gerenciamento de armazenagem');
INSERT TipoTransacao (ID , nome) VALUES (3, 'Ordem de Venda');

SET IDENTITY_INSERT TipoTransacao OFF

SELECT * FROM TipoTransacao;



SET IDENTITY_INSERT TipoTransacao ON


INSERT TipoTransacao (ID , nome) VALUES (1, 'Ordem de Compra');
INSERT TipoTransacao (ID , nome) VALUES (2, 'Gerenciamento de armazenagem');
INSERT TipoTransacao (ID , nome) VALUES (3, 'Ordem de Venda');

SET IDENTITY_INSERT TipoTransacao OFF

SELECT * FROM TipoTransacao;





SET IDENTITY_INSERT Armazem ON

INSERT Armazem (ID , nome) VALUES (1, 'Central Warehouse');
INSERT Armazem (ID , nome) VALUES (2, 'Volka Warehouse');

SET IDENTITY_INSERT Armazem OFF

SELECT * FROM Armazem;



SET IDENTITY_INSERT Prestador ON

INSERT Prestador (ID , nome) VALUES (1, 'MJOK petroleum');
INSERT Prestador (ID , nome) VALUES (2, 'Kazam Bosch Center');
INSERT Prestador (ID , nome) VALUES (3, 'Denso Corp');
INSERT Prestador (ID , nome) VALUES (4, 'Castrol Crop');

SET IDENTITY_INSERT Prestador OFF



INSERT Armazem (ID , nome) VALUES (1, 'Central Warehouse');

SELECT * FROM Armazem;





INSERT INTO Pedido ( tipoTransacaoID, transportadoraID,lojaID,armazemOrigemID, armazemDestinoID,dataPedido,dataEntrega) 
			VALUES (1,1,1, 1, 2, '20/01/2020','25/01/2020');
	
SELECT * FROM Pedido;
SELECT * FROM Armazem;

SELECT * FROM Prestador;

UPDATE Prestador SET Prestador.nome = 'Denso Corporation' WHERE ID = 3;

SELECT * FROM Prestador;


alter table Categoria ADD descricao VARCHAR(255
)











SET IDENTITY_INSERT Categoria OFF

insert into Categoria(ID,nome,descricao)  select id, Nome, Descricao from carga

SET IDENTITY_INSERT Categoria ON

SELECT * FROM Categoria;
SELECT * FROM carga;
