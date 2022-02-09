
-- Criando Trigger para cada vez que inserir um pedido calcule o valor do lucro e restante do Pedido
delimiter $$
create trigger Pedido_TR_Insert before insert
on Pedido
for each row
begin
set new.Restante = (new.Valor_Total - new.Valor_Pago);
set new.Lucro = (new.Valor_Total - new.Custo);
end$$
delimiter ;

-- Criando Trigger para cada vez que Editar um pedido atualize o valor do lucro e restante do pedido
delimiter $$
create trigger Pedido_TR_Update before update
on Pedido
for each row
begin
set new.Restante = (new.Valor_Total - new.Valor_Pago);
set new.Lucro = (new.Valor_Total - new.Custo);
end$$
delimiter ;