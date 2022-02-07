-- Criando trigger para cada vez que adicione um pedido ele atualize os valores da tabela finanças
delimiter $$
create trigger Financas_TR_Insert after insert
on Pedido
for each row
begin
update Financas 
set Vendas_Total = (select sum(p.Valor_Total) from Pedido p);

update Financas 
set Custo_Total = (select sum(p.Custo) from Pedido p);

update Financas 
set Lucro_Total = (select (sum(p.Valor_Total)-sum(p.Custo)) from Pedido p);

update Financas 
set Maluart_50 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.5) from Pedido p);

update Financas 
set Salario_30 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.3) from Pedido p);

update Financas 
set Investimento_20 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.2) from Pedido p);
end$$
delimiter ;

-- Criando trigger para cada vez que Edite um pedido ele atualize os valores da tabela finanças
delimiter $$
create trigger Financas_TR_Update after update
on Pedido
for each row
begin
update Financas 
set Vendas_Total = (select sum(p.Valor_Total) from Pedido p);

update Financas 
set Custo_Total = (select sum(p.Custo) from Pedido p);

update Financas 
set Lucro_Total = (select (sum(p.Valor_Total)-sum(p.Custo)) from Pedido p);

update Financas 
set Maluart_50 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.5) from Pedido p);

update Financas 
set Salario_30 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.3) from Pedido p);

update Financas 
set Investimento_20 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.2) from Pedido p);
end$$
delimiter ;

-- Criando trigger para cada vez que delete um pedido ele atualize os valores da tabela finanças
delimiter $$
create trigger Financas_TR_Delete after delete
on Pedido
for each row
begin
update Financas 
set Vendas_Total = (select sum(p.Valor_Total) from Pedido p);

update Financas 
set Custo_Total = (select sum(p.Custo) from Pedido p);

update Financas 
set Lucro_Total = (select (sum(p.Valor_Total)-sum(p.Custo)) from Pedido p);

update Financas 
set Maluart_50 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.5) from Pedido p);

update Financas 
set Salario_30 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.3) from Pedido p);

update Financas 
set Investimento_20 = (select ((sum(p.Valor_Total)-sum(p.Custo))*0.2) from Pedido p);
end$$
delimiter ;

-- Criando Trigger para cada vez que inserir um pedido calcule o valor restante do Pedido
delimiter $$
create trigger Pedido_TR_Insert before insert
on Pedido
for each row
begin
set new.Restante = (new.Valor_Total - new.Valor_Pago);
end$$
delimiter ;

-- Criando Trigger para cada vez que Editar um pedido atualize o valor restante do pedido
delimiter $$
create trigger Pedido_TR_Update before update
on Pedido
for each row
begin
set new.Restante = (new.Valor_Total - new.Valor_Pago);
end$$
delimiter ;