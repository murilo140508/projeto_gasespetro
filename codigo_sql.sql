create database projeto;
use projeto;
create table cargo(
codigocargo int primary key auto_increment,
cargo varchar(100)
);
create table usuario(
codigo int primary key auto_increment,
nome varchar(60),
email varchar(60),
senha varchar(255),
cargo int,
ativo tinyint,
constraint fk_cargo foreign key (cargo) references cargo(codigocargo)
);

create table tipo(
codigotipo int primary key auto_increment,
descricao varchar(100)
);
insert into tipo(descricao) values("Bom Bom");
insert into tipo(descricao) values("Barra de chocolate");

create table produto(
codigoproduto int primary key auto_increment,
descricao varchar(100),
valor decimal(5,2),
quantidade int,
foto varchar(100),
nome varchar(45),
tipo int,
constraint fk_tipo foreign key (tipo) references tipo(codigotipo)
);

create table cliente(
codigocliente int primary key auto_increment,
nome varchar(60),
email varchar(100),
cpf_cnpj varchar(45),
cep varchar(20),
num_casa varchar(20),
complemento varchar(45),
telefone varchar(45)
);

create table pedido(
codigopedido int primary key auto_increment,
datapedido datetime,
data_entrega datetime,
codigocliente int,
formapagamento varchar(100),
dataentrega varchar(45),
codigoUsuario int,
formapagamento varchar(60),
status varchar(60),
constraint fk_usuario foreign key (codigousuario) references usuario(codigo),
constraint fk_cliente foreign key (codigocliente) references cliente(codigocliente)
);

create table pedido_itens(
codigoItens int primary key auto_increment,
codigopedido int,
codigoproduto int,
quantidade int,
valor decimal(5,2),
total decimal(5,2),
constraint fk_pedido foreign key (codigopedido) references pedido(codigopedido),
constraint fk_produto foreign key (codigoproduto) references produto(codigoproduto)
);

create table fluxocaixa(
descricao varchar(100),
tipo varchar(45),
valor decimal(5,2)
);

insert into cargo(cargo) values("administrador");
insert into usuario (nome, email, senha, cargo, ativo) values
 ("murilo", "murilo@gmail.com", "aluno123", 1, 1);


























