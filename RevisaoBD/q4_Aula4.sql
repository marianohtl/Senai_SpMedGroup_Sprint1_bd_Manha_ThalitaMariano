-- 4. Apresentar a categoria e os itens relacionados a ela
-- Apresentar a categoria e a quantidade de itens relacionados a ela
-- Requisito 1: Os itens devem ser divididos por categoria, ou seja, cada item terá uma categoria.
-- Requisito 2: Uma questão que o cliente deseja observar é em qual categoria possui mais item no local.

select * from Item
select * from Categoria

select i.* ,c.nome
from item i, categoria c
where i.CategoriaID = c.id


select c.nome, count(i.id)
from item i, categoria c
where i.CategoriaID = c.id
group by c.nome