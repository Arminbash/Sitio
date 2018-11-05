create database muestra
use muestra
create table imagenes(
id int primary key identity(1,1),
imagen image,
active bit
)
create table users(
id int primary key identity(1,1),
correo varchar(50),
pass varchar(50),
active bit
)
create table personas(
id int primary key identity(1,1),
users_id int foreign key references users(id),
imagen_id int foreign key references imagenes(id),
nombre varchar(50),
fecha_nacimiento date,
active bit
)
create table productos(
id int primary key identity(1,1),
nombre varchar(50),
imagen_id int foreign key references imagenes(id),
descripcion varchar(100),
precio money,
existencia int,
active bit
)
create table visitas(
id int primary key identity(1,1),
users_id int foreign key references users(id),
fecha date,
active bit
)
create table pagina(
id int primary key identity(1,1),
users_id int foreign key references users(id),
producto_id int foreign key references productos(id),
fecha date,
active bit
)

