--3.	Apresentar o Nome do Transportadora e seus itens (ok)
-- Apresentar a transportadora e a Qtd de itens Entrada
-- Apresentar a transportadora e a Qtd de itens Saída
-- Requisito: A transportadora será outro item importante na análise, pois devemos saber qual transportadora é mais utilizada 
-- para fazer a entrega dos produtos e qual é a mais utilizada para fazer a saída.

-- Inserir dados da Loja para as transações de Venda

select * from armazem
update pedido set lojaId = 3  where id between 27 and 33
update pedido set lojaId = 4  where id > 33

-- Insere dados nas transportadoras que estão sem registro (=null)
select * from prestador

select * from item
select * from Pedido
select * from ItemPedido

--Nome da transportadoras que fizeram os transportes
select distinct transportadoraID, pr.nome
from pedido P, Prestador Pr
where p.transportadoraID = pr.ID

-- Mostra os itens que foram transportados
select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID

-- Apresentar a transportadora e a Qtd de itens Entrada

select * from TipoTransacao

select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i, TipoTransacao tt
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID and p.tipoTransacaoID = tt.ID
      and tt.nome = 'Ordem de Compra'

-- Apresentar a transportadora e a Qtd de itens Saída
select transportadoraID, pr.nome, p.id, i.nome, ip.quantidade
from pedido P, Prestador Pr, itemPedido ip, item i, TipoTransacao tt
where p.transportadoraID = pr.ID and p.id = ip.pedidoID and i.id = ip.itemID and p.tipoTransacaoID = tt.ID
      and tt.nome = 'Ordem de Venda'


