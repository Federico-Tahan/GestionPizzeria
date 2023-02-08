create or alter procedure SP_Insertar_UsuarioEmpleado(
	@DNI bigint,
	@nombre varchar(150),
	@apellido varchar(150),
	@direccion varchar(150),
	@fecha_nacimiento datetime,
	@telefono bigint,
	@alias varchar(150),
	@contraseña varchar(32),
	@id_rol int,
	@baja_logica_user int,
	@baja_logica_empleado int
)as
begin
	declare @UltimoId int

	insert into Empleado values(@DNI,@nombre,@apellido,@direccion,@fecha_nacimiento,@telefono,@baja_logica_empleado)
	
	set @UltimoId = SCOPE_IDENTITY()

	insert into Usuarios values(@alias,@contraseña,@UltimoId,@id_rol,@baja_logica_user)
end

go

create or alter procedure SP_Actualizar_UsuarioEmpleado(
	@id_empleado int,
	@id_usuario int,
	@direccion varchar(150),
	@telefono bigint,
	@alias varchar(150),
	@contraseña varchar(32),
	@id_rol int,
	@baja_logica_usuario int,
	@baja_logica_empleado int
)as
begin
	update Usuarios
	set alias = @alias,
		contraseña = @contraseña,
		id_rol = @id_rol, 
		baja_logica= @baja_logica_usuario
	where id_usuario = @id_usuario

	update Empleado
	set direccion =@direccion,
		telefono = @telefono,
		baja_logica = @baja_logica_empleado
	where id_empleado = @id_empleado	
end

go

create or alter procedure SP_Obtener_usuarios(
	@condicion int
)
as
begin
	
	if @condicion = 1
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 1
	end

	if @condicion = 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 0
	end

	if @condicion != 1 and @condicion != 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	join Roles r on r.id_rol = u.id_rol
	end

end

go

create or alter procedure SP_Buscar_usuario(
	@id int
)as
	select id_usuario
	from Usuarios
	where @id = id_usuario

go

create or alter procedure SP_Obtener_Roles
as
	select * from Roles

go

create or alter procedure SP_Obtener_Configuracion
as
select * from Configuracion


go

create or alter procedure SP_Actualizar_Redes(
	@email varchar(50),
	@instagram varchar(50),
	@facebook varchar(50),
	@twitter varchar(50),
	@youtube varchar(50)
)as
	update Configuracion
	set Email = @email,
		instagram = @instagram,
		facebook = @facebook,
		twitter = @twitter,
		youtube = @youtube
	where id_configuracion = 1


go


create or alter procedure SP_Obtener_Descuentos
as
select * from Descuento


go


create or alter procedure SP_ActualizarConfigDescuentos(
	@dia1 int,
	@dia2 int,
	@dia3 int,
	@dia4 int,
	@dia5 int,
	@dia6 int,
	@dia7 int,
	@descuentoSocio int,
	@descuentoPresencial int
)as
	update Descuento
	set porcentaje_descuento = @dia1
	where id_descuento = 1

	update Descuento
	set porcentaje_descuento = @dia2
	where id_descuento = 2	

	update Descuento
	set porcentaje_descuento = @dia3
	where id_descuento = 3	

	update Descuento
	set porcentaje_descuento = @dia4
	where id_descuento = 4	
	
	update Descuento
	set porcentaje_descuento = @dia5
	where id_descuento = 5
	
	update Descuento
	set porcentaje_descuento = @dia6
	where id_descuento = 6	
	
	update Descuento
	set porcentaje_descuento = @dia7
	where id_descuento = 7

	update Configuracion
	set descuentos_socios = @descuentoSocio,
		compras_presenciales = @descuentoPresencial
	where id_configuracion = 1

go

create or alter procedure SP_Obtener_Bitacora
as
	select id_bitacora, u.id_usuario, e.nombre,e.apellido,fecha,accion from Bitacora b
	join Usuarios u on  b.id_usuario =u.id_usuario
	join Empleado e on e.id_empleado = u.id_empleado


go

create or alter procedure SP_Verificar_Login(
	@alias varchar(150),
	@contraseña varchar(32)
)as
	select id_usuario
	from Usuarios
	where (@alias = alias and contraseña = @contraseña) and baja_logica = 0
go

create or alter procedure SP_DatosUserLogin(
	@alias varchar(150),
	@contraseña varchar(32)
)as
	select id_usuario, nombre,apellido,dni,direccion,fecha_nac,telefono,e.baja_logica,u.baja_logica
	from Usuarios u
	join Empleado e on e.id_empleado = u.id_empleado
	where @alias = alias and contraseña = @contraseña


go

create or alter procedure SP_Insertar_Cliente(
	@id_tipo_cliente int,
	@nombre varchar(50),
	@apellido varchar(50),
	@direccion varchar(150),
	@telefono bigint
)as
	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@direccion,@telefono, null,0)

go


create or alter procedure SP_Insertar_ClienteSocio(
	@id_tipo_cliente int,
	@nombre varchar(50),
	@apellido varchar(50),
	@direccion varchar(150),
	@telefono bigint,
	@DNI bigint,
	@email varchar (100)
)as
	insert into Socio values(@DNI,@email,GETDATE(),0)
	declare @cod int
	set @cod = SCOPE_IDENTITY()


	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@direccion,@telefono, @cod,0)

go


create or alter procedure SP_Cargar_TodosCLientes
as
	select id_cliente,s.id_socio, nombre, apellido,direccion,telefono, s.DNI,s.email, s.fecha_adhesion, s.baja_logica,id_tipo_cliente
	from Cliente c
	left join Socio s on s.id_socio = c.id_socio


go

create or alter procedure SP_ModificarSocio(
	@id_cliente int,
	@id_tipo_cliente int,
	@direccion varchar(150),
	@telefono bigint,
	@email varchar (100)
)as
	update Cliente
	set direccion = @direccion,
		telefono= @telefono,
		id_tipo_cliente = @id_tipo_cliente
	where id_cliente = @id_cliente

	update socio
	set email = @email
	where id_socio in (select id_socio
							from Cliente
							where id_cliente = @id_cliente)


	if(@id_tipo_cliente = 1)
	begin
		update Socio
		set baja_logica = 1
		where id_socio in (select id_socio
							from Cliente
							where id_cliente = @id_cliente)
	end

	if (@id_tipo_cliente = 2)
	begin
		update Socio
		set baja_logica = 0
		where id_socio in (select id_socio
							from Cliente
							where id_cliente = @id_cliente)
	end

go


create or alter procedure SP_Insertar_Socio(
	@id_cliente int,
	@dni bigint,
	@email varchar(100)
)as	
	insert into Socio VALUES(@dni,@email,GETDATE(),0)

	declare @cod_socio int

	set @cod_socio = SCOPE_IDENTITY()

	update Cliente
	set id_socio = @cod_socio,
		id_tipo_cliente = 1
	where id_cliente = @id_cliente


go

create or alter procedure SP_BuscarSocioDni(
	 @DNI bigint
)as
	select id_socio
	from Socio
	where DNI = @DNI

go	

create or alter procedure SP_BuscarCliente(
	@id int
)as
	select id_cliente
	from Cliente
	where id_cliente = @id

go

create or alter procedure SP_Traer_TipoCliente
as
	select* from tipo_cliente

go

create or alter procedure SP_BuscarUsuarioDNI(
	 @DNI bigint
)as
	select id_empleado
	from Empleado 
	where DNI = @DNI

go

create or alter procedure SP_BuscarUsuarioAlias(
	 @Alias varchar(50)
)as
	select id_usuario
	from Usuarios 
	where alias = @Alias

go
create or alter procedure SP_BuscarUsuarioID(
	 @id int,
	 @alias varchar(50)
)as
	select id_usuario
	from Usuarios 
	where id_usuario = @id and alias = @alias

go


create or alter procedure SP_ObtenerClasificacion
as
	select * from Clasificacion where baja_logica = 0


go
create or alter procedure SP_ObtenerTipoProducto
as
	select * from Tipo_producto where baja_logica = 0

go
create or alter procedure SP_ObtenerUnidadMedida
as
	select * from Unidad_Medida where baja_logica = 0

go



create or alter procedure SP_ObtenerProducto(
	@codicion int
)
as
	if (@codicion = 2)
	begin
		select id_producto,nombre,precio,detalle,stock,p.id_unidad_medida,um.unidad_Medida,c.id_clasificacion,c.clasificacion,tp.id_tipo_producto,tp.tipo_producto,p.baja_logica
		from Producto p 
		join unidad_Medida um on um.id_unidad_medida = p.id_unidad_medida
		join Clasificacion c on c.id_clasificacion = p.id_clasificacion
		join Tipo_producto tp on tp.id_tipo_producto = p.id_tipo_producto
	end
	else if(@codicion = 1)
	begin
		select id_producto,nombre,precio,detalle,stock,p.id_unidad_medida,um.unidad_Medida,c.id_clasificacion,c.clasificacion,tp.id_tipo_producto,tp.tipo_producto,p.baja_logica
		from Producto p 
		join unidad_Medida um on um.id_unidad_medida = p.id_unidad_medida
		join Clasificacion c on c.id_clasificacion = p.id_clasificacion
		join Tipo_producto tp on tp.id_tipo_producto = p.id_tipo_producto
		where p.baja_logica = 1

	end
	else if (@codicion = 0)
	begin
		select id_producto,nombre,precio,detalle,stock,p.id_unidad_medida,um.unidad_Medida,c.id_clasificacion,c.clasificacion,tp.id_tipo_producto,tp.tipo_producto,p.baja_logica
		from Producto p 
		join unidad_Medida um on um.id_unidad_medida = p.id_unidad_medida
		join Clasificacion c on c.id_clasificacion = p.id_clasificacion
		join Tipo_producto tp on tp.id_tipo_producto = p.id_tipo_producto
		where p.baja_logica = 0
	end

go

create or alter procedure SP_AltaProducto(
	@nombre varchar(100) ,
	@precio money ,
	@detalle varchar(600),
	@stock int,
	@id_unidad_medida int,
	@id_tipo_producto int,
	@id_clasificacion int ,
	@baja_logica int
)as
	insert into Producto values (@nombre,@precio,@detalle,@stock,@id_unidad_medida,@id_tipo_producto,@id_clasificacion,@baja_logica)

go

create or alter procedure SP_ModificarProducto(
	@id_producto int,
	@nombre varchar(100) ,
	@precio money ,
	@detalle varchar(600),
	@stock int,
	@id_unidad_medida int,
	@id_tipo_producto int,
	@id_clasificacion int ,
	@baja_logica int
)as
	update Producto
	set nombre = @nombre,
		precio = @precio,
		detalle = @detalle,
		stock = @stock,
		id_unidad_medida = @id_unidad_medida,
		id_tipo_producto = @id_tipo_producto,
		id_clasificacion = @id_clasificacion,
		baja_logica = @baja_logica
	where id_producto = @id_producto

go


create or alter procedure SP_DetalleVenta(
	@id_nrofactura int,
	@id_producto int,
	@cantidad int,
	@importe money,
	@descripcion varchar(400)
)as
	insert into detalle_factura values (@id_nrofactura,@id_producto,@cantidad,@importe,@descripcion,0)

go
create or alter procedure SP_AltaVenta(
	@fecha datetime,
	@id_cliente int,
	@id_usuario int,
	@id_forma_compra int,
	@id_forma_entrega int,
	@id_descuento int,
	@IDFACTURA int Output
)as
	insert into Factura values(@fecha,@id_cliente,@id_usuario,@id_forma_compra,@id_forma_entrega,@id_descuento,0)
	set @IDFACTURA = SCOPE_IDENTITY()

go














select * from Factura







select * from detalle_factura

