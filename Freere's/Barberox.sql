create database Barberox
use Barberox

create table Clientes(
id int primary key identity(1,1) not null,
CodCliente int not null,
NOMBRE varchar(50) not null
)

create table Turnos(
id int primary key identity(1,1) not null,
DNI int not null,
FECHA varchar(50) not null,
HORA int not null,
PAGADO varchar(10) not null,
BARBERO varchar(50) not null,
IDCLIENTE int not null
)

