create table clientes 
(

codigo int not null,
nome varchar(100) not null,
cpf varchar(16) primary key not null,
telefone varchar(15) not null,
endereco varchar(100)

);

create table login
(

usuario varchar(50) not null,
senha varchar(50) not null,
nivel_usuario int not null

);

insert into login (usuario, senha, nivel_usuario) values ('andre', '123', 0);

select * from login;

select * from clientes;

alter table clientes add column email varchar(50);

alter table clientes add column variacao varchar(20);

alter table clientes add column tipo_sanguineo varchar(20);