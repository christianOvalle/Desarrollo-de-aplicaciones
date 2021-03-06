create table safe_journey(
id_safe int not NULL identity(1,1) PRIMARY KEY,
nombre_empresa varchar(100),
RNC_empresa VARCHAR(100),
direccion_empresa VARCHAR(250)

);


create table cliente(
id_cliente int not null identity(1,1) PRIMARY KEY,
nombre_cliente varchar(100),
apellido_cliente VARCHAR(100),
cedula_cliente varchar(50),
direccion_cliente varchar(100),
numero_de_tarjeta varchar(100),
cantidad_de_personas int

);

create table eventos(
id_evento int not null identity(1,1) PRIMARY KEY,
nombre_evento varchar(200),
ciudad_evento varchar(150),
tipo_de_evento varchar(100),
fecha_de_evento varchar(100),
fecha_registro_de_evento datetime,
id_cliente int REFERENCES cliente(id_cliente)

);


create TABLE coordinacion_viaje(
id int not null identity(1,1) PRIMARY KEY,
nombre_cliente varchar(100),
cedula_cliente varchar(50),
nombre_evento varchar(200),
fecha_hacia_evento VARCHAR(50),
fecha_hacia_casa VARCHAR(80),
tipo_transporte varchar(100),
id_cliente int REFERENCES cliente(id_cliente),
id_evento int REFERENCES eventos(id_evento)


);


create table companiaproveedoras(
id_compania int not null identity(1,1) primary KEY,
nombre varchar(100),
rnc varchar(100),
direccion varchar(250),
cantidad_Buses VARCHAR(100),
id_safe int REFERENCES safe_journey(id_safe)

);

create table vehiculos(
id_vehiculo int not null identity(1,1) primary KEY,
tipo_de_vehiculo varchar(100),
chofer varchar(100),
chofer_extra varchar(100),
placa varchar(20),
cantidad_asientas int,
tipo varchar(100),
precio_por_asiento float,
precio float,
id_compania int REFERENCES companiaproveedoras(id_compania)

);


create table detalle_de_viaje(
id_compania int not null identity(1,1) primary KEY,
kilometros_recorridos float,
subtotal float,
costo_total float,
id_cliente int REFERENCES cliente(id_cliente),
id_evento int REFERENCES eventos(id_evento),
id_vehiculo int REFERENCES vehiculos(id_vehiculo)



);