create database Bibliotecass; use Bibliotecass;

create table Cliente(
cliente_id int auto_increment not null,
nome varchar(255) not null,
email varchar(255) not null,
senha char(18) not null,
telefone char(14) not null,
CEP char(9) not null,
numero_residencia char(3) not null,
primary key(cliente_id));
select * from Cliente;

create table Vendedor(
vendedor_id int auto_increment not null,
nome varchar(255) not null,
email varchar(255) not null,
senha char(18) not null,
CNPJ char(14) not null,
CPF char(11) not null,
primary key(vendedor_id) );

create table Livros(
livro_id int auto_increment not null,
nome_livro varchar(255) not null,
img_livro mediumblob not null,
url_img_livro varchar(255),
autor varchar(255) not null,
preco decimal(10,2) not null,
paginas varchar(4) not null,
editora varchar(255) not null,
publicacao varchar(255) not null,
primary key(livro_id) );

create table Pedidos(
pedido_id int auto_increment not null,
id_livro int not null,
id_cliente int not null,
data_pedido varchar(255) not null,
valor_total decimal(10,2) not null,
foreign key(id_cliente) references Cliente (cliente_id),
foreign key(id_livro) references Livros (livro_id),
primary key(pedido_id) );

create table Carrinho(
carrinho_id int primary key auto_increment,
id_livro int not null,
quantidade int not null,
id_cliente int not null,
foreign key(id_cliente) references Cliente (cliente_id),
foreign key(id_livro) references Livros (livro_id)
);

select * from Pedidos;

select * from livros; Insert into Livros(nome_livro, autor, preco, paginas, localizacao, editora, publicacao) values ('Política','Aristóteles','54.00','352','Português','Edipro','1 Fevereiro de 2019'), ('A República','Platão','15.00','363','Português','Lafonte','7 Agosto de 2021');