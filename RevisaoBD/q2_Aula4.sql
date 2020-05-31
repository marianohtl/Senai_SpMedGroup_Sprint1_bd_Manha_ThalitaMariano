--2.	Apresentar o Nome do Fornecedor e seus itens
-- Requisito: Cada item ter� um fornecedor relacionado a ele, sendo poss�vel controlar os itens divididos por fornecedores.

select * from item
select * from prestador
-- Mostra os fornecedores e seus Itens
select FornecedorID,p.nome, i.id,i.nome
from item I, prestador P
where i.FornecedorID=p.id

-- Mostra a quantidade de itens por Fornecedor
select FornecedorID,p.nome, count(i.id) as 'Qtd itens'
from item I, prestador P
where i.FornecedorID=p.id
group by  FornecedorID,p.nome 


--******* explica��o do Group By
select * from Item
select count(id) from Item

-- Fun��es Count, Max, Min, Avg, Sum

select FornecedorID,count(id) from item
group by FornecedorID
