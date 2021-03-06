create TABLE Usuario(
id int not null IDENTITY(1,1) PRIMARY KEY, 
nombre VARCHAR(50),
apellido VARCHAR(50),
contrasena VARCHAR(50),
cedula VARCHAR(50),
direccion VARCHAR(150),
telefono VARCHAR(50),
correo VARCHAR(100),
rol VARCHAR(100)

);

create table Clientes(
id_cliente int not null IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(50),
apellido VARCHAR(50),
cedula VARCHAR(50),
direccion VARCHAR(150),
telefono VARCHAR(50),
SituacionVehiculo varchar(500),
fecha_registro datetime
 

);

create TABLE Vehiculos(
id_vehiculo int not null IDENTITY(1,1) PRIMARY KEY,
id_vehiculo_cliente int,
matricula VARCHAR(50),
modelo VARCHAR(50),
color VARCHAR(50),
marca VARCHAR(50),
FOREIGN KEY(id_vehiculo_cliente) REFERENCES clientes (id_Cliente)

);

create table Taller(
id_taller int not null IDENTITY(1,1) PRIMARY KEY,
rnc VARCHAR(100),
direccion VARCHAR(100),
nombre VARCHAR(100),
telefono VARCHAR(50),
correo VARCHAR(100)

);

create TABLE Mecanicos(
id_mecanico int not null IDENTITY(1,1) PRIMARY KEY,
taller_nombre int,
nombre VARCHAR(50),
apellido VARCHAR(50),
cedula VARCHAR(50),
fecha_nacimiento VARCHAR(100),
estatus bit,
FOREIGN KEY(taller_nombre) REFERENCES Taller(nombre)

);
create TABLE Inventario_Respuesto(
id int not null IDENTITY(1,1) PRIMARY KEY,
nombre_pieza VARCHAR(50),
cantidad_pieza int,
precio_pieza int,
cantidad_disponible int,
estado_piezas VARCHAR(50)

);

create TABLE Servicios(
id int not null IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(150),
tipo_servicio VARCHAR(150),
costo int

);

CREATE TABLE Facturacion(
id int not null IDENTITY(1,1) PRIMARY KEY,
rnc_taller VARCHAR(100),
modelo_vehiculo VARCHAR(100),
marca_vehiculo VARCHAR(100),
color_vehiculo varchar(100),
nombre_servicio varchar(100),
nombre_taller VARCHAR(100),
direccion_taller VARCHAR(100),
telefono_taller VARCHAR(100),
costo_trabajo int
);

create TABLE Detalle_Reparacion(
id int not null IDENTITY(1,1) PRIMARY KEY,
nombre_servicio varchar(100),
tipo_servicio varchar(100),
nombre_mecanico VARCHAR(100),
costo_trabajo int


);
