-- Criando base de dados 
create database cad_clientes;
use cad_clientes;

create table Cliente(
Id int auto_increment primary key,
Nome varchar(50), 
Telefone varchar(50),
Estado varchar(50) ,
Cidade varchar(50) , 
Endereço varchar(50) ,
Numero varchar(50), 
CEP varchar(50), 
Instagram varchar(50)
);

create table Pedido(
Id int auto_increment primary key,
Produto varchar(100) ,
Cliente_Cadastrado varchar(100),
Status_Pedido varchar(100),
Valor_Total float, 
Valor_Pago float,
Lucro float null,
Restante float null,
Custo float,
Forma_Pagamento varchar(50), 
Data_Pedido Date,
Data_Entrega Date,
FK_Id_Cliente int not null,
foreign key (FK_Id_Cliente) references Cliente(Id)
);

