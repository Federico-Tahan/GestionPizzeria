create table Clasificacion
(
id_clasificacion int identity(1,1) not null,
clasificacion varchar(50) not null,
baja_logica int,
constraint pk_id_clasificacion primary key (id_clasificacion)
)

Create table Tipo_producto
(
id_tipo_producto int identity(1,1) not null,
tipo_producto varchar(50) not null,
baja_logica int,
constraint pk_id_tipo_p primary key(id_tipo_producto)
)

Create table Producto
(
id_producto int identity (1,1) not null,
nombre varchar(100) not null,
precio money not null,
detalle varchar(600) not null,
id_tipo_producto int not null,
id_clasificacion int not null,
baja_logica int,
constraint pk_id_producto primary key(id_producto),
constraint fk_id_tipo_producto foreign key (id_tipo_producto) references Tipo_producto,
constraint fk_id_clasificacion foreign key (id_clasificacion) references Clasificacion
)

Create table Socio 
(
id_socio int identity (1,1) not null,
DNI bigint not null,
email varchar(100) not null,
fecha_adhesion datetime not null,
baja_logica int
constraint pk_id_socio primary key (id_socio)
)

create table tipo_cliente(
id_tipo_cliente int identity(1,1),
tipo_cliente varchar(10),
constraint pk_id_tipo_cliente primary key(id_tipo_cliente)
)



Create table Cliente
(
id_cliente int identity(1,1) not null,
id_tipo_cliente int not null,
nombre varchar(50) not null,
apellido varchar(50) not null,
direccion varchar(150) not null,
telefono bigint,
id_socio int ,
baja_logica int
constraint pk_id_cliente primary key (id_cliente),
constraint fk_id_tipo_cliente foreign key(id_tipo_cliente)  references tipo_cliente
)

Create table Roles
(
id_rol int identity (1,1) not null,
roles varchar(50) not null,
descripcion varchar(600) not null,
baja_logica int
constraint pk_id_rol primary key (id_rol)
)

Create table Empleado(
id_empleado int identity(1,1) not null,
dni bigint not null,
nombre varchar(150) not null,
apellido varchar(150) not null,
direccion varchar(150) not null,
fecha_nac datetime not null,
telefono bigint not null,
baja_logica int,
constraint pk_id_empleado primary key (id_empleado)
)

Create table Descuento(
id_descuento int identity (1,1) not null,
nombre_dia varchar(10) not null,
porcentaje_descuento int not null,
baja_logica int
constraint pk_id_descuento primary key (id_descuento)
)

Create table Usuarios(
id_usuario int identity (1,1) not null,
alias varchar(150) not null,
contraseña varchar(32) not null,
id_empleado int not null,
id_rol int not null,
baja_logica int
constraint pk_id_usuario primary key (id_usuario),
constraint fk_id_empleado foreign key (id_empleado) references Empleado,
constraint fk_id_rol foreign key (id_rol) references Roles
)

Create table Bitacora(
id_bitacora int identity (1,1) not null,
id_usuario int not null,
fecha datetime not null,
accion varchar(200) not null,
constraint pk_id_bitacora primary key (id_bitacora),
constraint fk_id_usuario foreign key (id_usuario) references Usuarios
)


Create table Forma_compra(
id_forma_compra int identity(1,1) not null,
forma_compra varchar(50) not null,
constraint pk_id_forma_compra primary key (id_forma_compra),
)

Create table forma_entrega(
id_forma_entrega int identity (1,1) not null,
forma_entrega varchar(50) not null,
constraint pk_id_forma_entrega primary key (id_forma_entrega)
)

Create table Factura
(
nro_factura int identity(1,1) not null,
fecha datetime not null,
id_cliente int not null,
id_usuario int not null,
id_forma_compra int not null,
id_forma_entrega int  not null,
id_descuento int not null,
baja_logica int 
Constraint pk_id_nro_factura primary key (nro_factura),
constraint fk_id_cliente foreign key (id_cliente) references cliente,
constraint fk_id_usuarios foreign key (id_usuario) references usuarios,
constraint fk_id_forma_compra foreign key (id_forma_compra) references forma_compra,
constraint fk_id_forma_entrega foreign key (id_forma_entrega) references forma_entrega,
constraint fk_id_descuento foreign key (id_descuento) references Descuento
)

Create table detalle_factura(
id_detalle_factura int identity (1,1) not null,
nro_factura int not null,
id_producto int not null,
cantidad int not null,
importe money,
descripcion varchar(600) not null,
baja_logica int,
constraint pk_id_detalle_factura primary key(id_detalle_factura),
constraint fk_nro_factura foreign key(nro_factura) references factura,
constraint fk_id_producto foreign key (id_producto) references producto
)

create table Configuracion(
id_configuracion int,
descuentos_socios int,
compras_presenciales int,
Email varchar(50),
youtube varchar(50),
instagram varchar(50),
twitter varchar(50),
facebook varchar(50)
)



