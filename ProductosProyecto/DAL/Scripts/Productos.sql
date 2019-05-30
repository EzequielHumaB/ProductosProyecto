create database RegistroProductos
go

use RegistroProductos
go

create table Productos
(
   ProductoID int primary key identity,
   Descripcion varchar(40),
   Existencia int,
   Costo money,
   ValorInventario money
)

create table InventarioTotal
(
   ProductoID int primary key identity,
   TotalInventario money,
   constraint llave_foranea foreign key (ProductoID) references Productos(ProductoID)
)

