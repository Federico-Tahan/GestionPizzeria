insert into Descuento values ('Lunes',0,0)
insert into Descuento values ('Martes',0,0)
insert into Descuento values ('Miercoles',0,0)
insert into Descuento values ('Jueves',0,0)
insert into Descuento values ('Viernes',0,0)
insert into Descuento values ('Sabado',0,0)
insert into Descuento values ('Domingo',0,0)


insert into Roles values('Gerente','Encargado de la gestión del negocio, teniendo acceso a todos los módulos del sistema',0)
insert into Roles values('Representante Tècnico','Responsable de darle mantenimiento y futuras actualizaciones al sistema',0)
insert into Roles values('Administrativo','Responsable de la parte administrativa del negocio',0)
insert into Roles values('Contador','Encargado de la parte contable, sólo tendrá acceso a los módulos de facturación y ventas',0)
insert into Roles values('Encargados','Encargados de controlar el Productos y a los vendedores',0)
insert into Roles values('Vendedores','Responsables de las ventas de los productos a los clientes, además de informar ofertas y beneficios. También adhieren o desligan miembros del Club',0)

insert into Configuracion values (1,0,0,'-','-','-','-','-','-')

insert into tipo_cliente values ('Socio')
insert into tipo_cliente values ('No Socio')

insert into forma_entrega values ('Delivery a Domicilio')
insert into forma_entrega values ('Retiro en el local')

insert into Forma_compra values ('Telefonica')
insert into Forma_compra values ('Presencial')


insert into Empleado values (22222,'Admin','Admin','Admin','2022/02/02',3333333,0)
insert into Usuarios values ('Admin','seQjY0IBoCE=',1,1,0)
