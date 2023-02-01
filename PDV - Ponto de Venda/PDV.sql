create database PDV;
use PDV;


create table funcionarios(
id int not null auto_increment primary key,
cpf char(14) not null,
nome varchar(80) not null,
telefone char(14) not null,
endereco varchar(150) not null,
cargo varchar(30) not null,
foto longblob not null
)engine=innodb;



