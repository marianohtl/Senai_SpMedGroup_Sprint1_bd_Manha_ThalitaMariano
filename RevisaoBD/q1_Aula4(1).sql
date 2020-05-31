--***** 
-- 1.	Apresentar os dados dos itens cadastrados. 
-- ID, Nome do Item, Se Registra Num Role, Quantidade Mínima, Nome do Fornecedor, Local de Armazenagem

-- Inserindo coluna descricao na tabela categoria
alter table categoria add descricao varchar(255)

alter table item add quantidadeMinima int

-- trazendo os dados do bd teste para s4_pt
insert into categoria select * from teste.dbo.categoria

select * from categoria

-- Iserindo dados na Categoria do Item
update item set categoriaid = 1 where quantidadeMinima = 0
update item set categoriaid = 2 where numeroLoteRequerido = 0
update item set categoriaid = 3 where quantidadeMinima = 1
update item set categoriaid = 4 where quantidadeMinima > 10
update item set categoriaid = 5 where CategoriaID is null

select * from item

-- -- Iserindo dados na Loja do Item

-- Cadastrando loja 1 e loja 2 na tabela Armazem
Insert into Armazem(nome) values ('Loja 1')
Insert into Armazem (nome) values ('Loja 2')

-- Alterar texto de Corp para Corporation
Update Prestador set nome = REPLACE (nome, 'Corp', 'Corporation') where nome like '%Corp'

select * from Armazem


-- alterar dados da loja Loja 1 para id pares e Loja 2 para ids impares
update item set localID = (select id from Armazem where nome = 'Loja 1') where id % 2 = 0
update item set localID = (select id from Armazem where nome = 'Loja 2') where id % 2 <> 0

select * from item
-- 1.	Apresentar os dados dos itens cadastrados. 
-- ID, Nome do Item, Se Registra Num Role, Quantidade Mínima, Nome do Fornecedor, Local de Armazenagem

select * from Item
select i.id, i.nome, numeroLoteRequerido,quantidadeMinima,p.nome 'Fornecedor',a.nome 'Loja'
from item I, Armazem A, Prestador P
where i.FornecedorID = p.id and i.localID = a.id

-- Mudando a apresentação de numeroLoteRequerido

select i.id, i.nome, iif(numeroLoteRequerido=0,'Não','Sim') 'Lote Requerido',quantidadeMinima,p.nome 'Fornecedor',a.nome 'Loja'
from item I, Armazem A, Prestador P
where i.FornecedorID = p.id and i.localID = a.id