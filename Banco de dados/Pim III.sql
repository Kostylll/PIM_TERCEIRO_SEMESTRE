#create database Pim_III
#use pim_iii

#create table colaboradores (
#colaborador_id int(5) not null primary key, 
#nome char(75) not null, 
#dat_nasci date not null, 
#setor char(20) not null
#)

#create table fornecedores(
#fornecedor_id int(5) not null primary key,
#nome_empresa char(80) not null, 
#quantidade float(30) not null, 
#valor float(30) not null, 
#nome_produto char(30) not null
#)

#create table producao(
#prod_id int(5) not null primary key,
#produto_pro char(30) not null,
#colaborador_Id int(5) not null
#)
 
#create table vendas(
#venda_id int(5) not null primary key, 
#valor_venda float(30) not null,
#colaborador_ID int(5) not null
#)

#alter table producao add foreign key(colaborador_Id) references colaboradores(colaborador_id)
#alter table vendas add foreign key(colaborador_ID) references colaboradores(colaborador_id)