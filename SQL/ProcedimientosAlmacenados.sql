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
	@baja_logica_empleado int,
	@id_usuario_admin int
)as
begin
	declare @UltimoId int

	insert into Empleado values(@DNI,@nombre,@apellido,@direccion,@fecha_nacimiento,@telefono,@baja_logica_empleado)
	
	set @UltimoId = SCOPE_IDENTITY()

	insert into Usuarios values(@alias,@contraseña,@UltimoId,@id_rol,@baja_logica_user)
	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Registrar usuario')

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
	@baja_logica_empleado int,
	@id_usuario_admin int

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

	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Modificar Usuario')
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
	@youtube varchar(50),
	@contraseña varchar(50)
)as
	update Configuracion
	set Email = @email,
		instagram = @instagram,
		facebook = @facebook,
		twitter = @twitter,
		youtube = @youtube,
		contraseña = @contraseña
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
	order by fecha desc


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

	select id_usuario, nombre,apellido,dni,direccion,fecha_nac,telefono,e.baja_logica,u.baja_logica, u.id_rol
	from Usuarios u
	join Empleado e on e.id_empleado = u.id_empleado
	where @alias = alias and contraseña = @contraseña
go

create or alter procedure SP_Insertar_Cliente(
	@id_tipo_cliente int,
	@nombre varchar(50),
	@apellido varchar(50),
	@direccion varchar(150),
	@telefono bigint,
	@id_usuario int
)as
	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@direccion,@telefono, null,0)
		insert into Bitacora values(@id_usuario,GETDATE(),'Ingreso Cliente')


go


create or alter procedure SP_Insertar_ClienteSocio(
	@id_tipo_cliente int,
	@nombre varchar(50),
	@apellido varchar(50),
	@direccion varchar(150),
	@telefono bigint,
	@DNI bigint,
	@email varchar (100),
	@id_usuario int
)as
	insert into Socio values(@DNI,@email,GETDATE(),0)
	declare @cod int
	set @cod = SCOPE_IDENTITY()


	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@direccion,@telefono, @cod,0)
	insert into Bitacora values(@id_usuario,GETDATE(),'Adhesion al club')

go


create or alter procedure SP_Cargar_TodosCLientes
as
	select id_cliente,s.id_socio, nombre, apellido,direccion,telefono, s.DNI,s.email, s.fecha_adhesion, s.baja_logica,id_tipo_cliente
	from Cliente c
	left join Socio s on s.id_socio = c.id_socio
	ORDER by id_cliente desc


go

create or alter procedure SP_ModificarSocio(
	@id_cliente int,
	@id_tipo_cliente int,
	@direccion varchar(150),
	@telefono bigint,
	@email varchar (100),
	@id_usuario int
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


	if(@id_tipo_cliente = 2)
	begin
		update Socio
		set baja_logica = 1
		where id_socio in (select id_socio
							from Cliente
							where id_cliente = @id_cliente)

		update Cliente
		set id_tipo_cliente = @id_tipo_cliente
		where id_cliente = @id_cliente
	end

	if (@id_tipo_cliente = 1)
	begin
		update Socio
		set baja_logica = 0
		where id_socio in (select id_socio
							from Cliente
							where id_cliente = @id_cliente)

		update Cliente
		set id_tipo_cliente = @id_tipo_cliente
		where id_cliente = @id_cliente
	end
	insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion Cliente')

go


create or alter procedure SP_Insertar_Socio(
	@id_cliente int,
	@dni bigint,
	@email varchar(100),
	@id_usuario int
)as	
	insert into Socio VALUES(@dni,@email,GETDATE(),0)

	declare @cod_socio int

	set @cod_socio = SCOPE_IDENTITY()

	update Cliente
	set id_socio = @cod_socio,
		id_tipo_cliente = 1
	where id_cliente = @id_cliente
	insert into Bitacora values(@id_usuario,GETDATE(),'Adhesion al club')



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
	@baja_logica int,
	@id_usuario int
)as
	insert into Producto values (@nombre,@precio,@detalle,@stock,@id_unidad_medida,@id_tipo_producto,@id_clasificacion,@baja_logica)
	insert into Bitacora values(@id_usuario,GETDATE(),'Ingresar Producto')


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
	@baja_logica int,
	@id_usuario int
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
	insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion del producto')


go

create or alter procedure SP_DetalleVenta(
	@id_nrofactura int,
	@id_producto int,
	@cantidad int,
	@importe money,
	@descripcion varchar(400)
)as
	insert into detalle_factura values (@id_nrofactura,@id_producto,@cantidad,@importe,@descripcion,0)

	update Producto
	set stock = stock - @cantidad
	where id_producto = @id_producto

	declare @stockactual int

	select @stockactual = stock 
	from Producto
	where id_producto = @id_producto

	if(@stockactual = 0)
	begin
		update Producto
		set baja_logica = 1
		where id_producto = @id_producto
	end


go
create or alter procedure SP_AltaVenta(
	@id_cliente int,
	@id_usuario int,
	@id_forma_compra int,
	@id_forma_entrega int,
	@tienedescuento int,
	@id_usuario_admin int,
	@IDFACTURA int Output
)as
	declare @diaweek int
	if (DATEPART(DW,GETDATE()) = 0)
		begin
			set @diaweek = 7
		end
	else
		begin
			set @diaweek = DATEPART(DW,GETDATE() - 1)
		end

	if(@tienedescuento = 0)
	begin 
		insert into Factura values(GETDATE(),@id_cliente,@id_usuario,@id_forma_compra,@id_forma_entrega,@diaweek,0)
	set @IDFACTURA = SCOPE_IDENTITY()
	end
	else
	begin
		insert into Factura values(GETDATE(),@id_cliente,@id_usuario,@id_forma_compra,@id_forma_entrega,null,0)
	set @IDFACTURA = SCOPE_IDENTITY()
	end

	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Registro de venta')


go

create or alter procedure SP_ObtenerFormaCompra
as
	select * from Forma_compra 

go

create or alter procedure SP_ObtenerFormaEntrega
as
	select * from forma_entrega 

go


create or alter procedure SP_ObtenerCondicionesDescuento
as
begin
	declare @diaweek int
	if (DATEPART(DW,GETDATE()) = 0)
		begin
			set @diaweek = 7
		end
	else
		begin
			set @diaweek = DATEPART(DW,GETDATE() - 1)
		end

	
	SELECT descuentos_socios,compras_presenciales, d.porcentaje_descuento
	from Configuracion C
	join Descuento d on d.id_descuento = @diaweek
end

go

create or alter procedure SP_TraerClientesCbo(
	@socios int
)
as
	if(@socios = 0)
	begin
		select id_cliente, nombre + SPACE(1) + apellido'Nombre Completo'
		from Cliente c
		join Socio s on c.id_socio = s.id_socio
		where s.baja_logica = 0
	end
	else
	begin
		select id_cliente, c.nombre + SPACE(1) + c.apellido'Nombre Completo'
		from Cliente c
		left join Socio s on s.id_socio = c.id_socio
		where (s.id_socio is null) or (s.baja_logica = 1)
	end
go



create or alter procedure SP_ObtenerFactura
as
	select nro_factura, CONVERT(VARCHAR, fecha, 108)'Hora',CONVERT(VARCHAR, fecha, 105)'Fecha', c.nombre + SPACE(1) + c.apellido'Nombre_Completo'
	, e.nombre + SPACE(1) + e.apellido 'Nombre_CompletoUsuario', fc.forma_compra,fe.forma_entrega, d.porcentaje_descuento,fecha
	from Factura f
	left join Descuento d on f.id_descuento = d.id_descuento
	join Cliente c on c.id_cliente = f.id_cliente
	join Usuarios u on u.id_usuario = f.id_usuario
	join Empleado e on e.id_empleado = u.id_empleado
	join forma_entrega fe on fe.id_forma_entrega = f.id_forma_entrega
	join Forma_compra fc on fc.id_forma_compra = f.id_forma_compra

go

create or alter procedure SP_ObtenerDetalles(
	@id_f int
)as
		select df.id_producto,nombre,detalle,p.id_unidad_medida,um.unidad_Medida,c.id_clasificacion,c.clasificacion,tp.id_tipo_producto,tp.tipo_producto,df.cantidad,df.descripcion,df.importe
		from Producto p 
		join unidad_Medida um on um.id_unidad_medida = p.id_unidad_medida
		join Clasificacion c on c.id_clasificacion = p.id_clasificacion
		join Tipo_producto tp on tp.id_tipo_producto = p.id_tipo_producto
		join detalle_factura df on df.id_producto = p.id_producto
		where nro_factura = @id_f

go


create or alter procedure SP_RegistroBitacoraLogin(
	@id_usuario int
)as
	insert into Bitacora values(@id_usuario,GETDATE(),'Inicio de sesion')


go

create or alter procedure SP_RegistroBitacoraLogout(
	@id_usuario int
)as
	insert into Bitacora values(@id_usuario,GETDATE(),'Cierre de sesion')

go

create or alter procedure SP_GetTipoProducto(
	@a int
)as
	if(@a = 0)
	begin
		select * from Tipo_producto where baja_logica = 0
	end
	else if (@a = 1)
	begin
			select * from Tipo_producto where baja_logica = 1

	end
	else 
	begin
			select * from Tipo_producto
	end

go

create or alter procedure SP_GetClasificacion(
	@a int
)as
	if(@a = 0)
	begin
		select * from Clasificacion where baja_logica = 0
	end
	else if (@a = 1)
	begin
			select * from Clasificacion where baja_logica = 1

	end
	else 
	begin
			select * from Clasificacion
	end

go

create or alter procedure SP_GetUnidadMedida(
	@a int
)as
	if(@a = 0)
	begin
		select * from Unidad_Medida where baja_logica = 0
	end
	else if (@a = 1)
	begin
			select * from Unidad_Medida where baja_logica = 1

	end
	else 
	begin
			select * from Unidad_Medida
	end

go


create or alter procedure SP_AltaClasificacion(
	@nombre varchar(50)
)as
	insert into Clasificacion values(@nombre,0)

go


create or alter procedure SP_AltaUnidadMed(
	@nombre varchar(50)
)as
	insert into Unidad_Medida values(@nombre,0)

go


create or alter procedure SP_AltaTipoProd(
	@nombre varchar(50)
)as
	insert into Tipo_producto values(@nombre,0)


go

create or alter procedure SP_MODClasificacion(
	@id int,
	@nombre  varchar(50),
	@baja_logica int
)as	
	update Clasificacion
	set baja_logica = @baja_logica,
		clasificacion = @nombre
	where id_clasificacion = @id

go

create or alter procedure SP_MODUnidadMed(
	@id int,
	@nombre  varchar(50),
	@baja_logica int
)as	
	update Unidad_Medida
	set baja_logica = @baja_logica,
		Unidad_Medida = @nombre
	where id_unidad_medida = @id


go


create or alter procedure SP_MODTipoProd(
	@id int,
	@nombre  varchar(50),
	@baja_logica int
)as	
	update Tipo_producto
	set baja_logica = @baja_logica,
		tipo_producto = @nombre
	where id_tipo_producto = @id

go


create or alter procedure SP_RecaudoDiario
as
	Select SUM(cantidad * importe)'Recaudado Hoy'
	from detalle_factura df
	join Factura f on df.nro_factura = f.nro_factura
	where day(f.fecha) = day(GETDATE()) and MONTH(f.fecha) = Month(GETDATE()) and YEAR(f.fecha) = Year(GETDATE())
	group by day(f.fecha), MONTH(f.fecha),YEAR(f.fecha)

go

create or alter procedure SP_VentasHoy
as
	Select COUNT(nro_factura)'Ventas Hoy'
	from Factura
	where day(fecha) = day(GETDATE()) and MONTH(fecha) = Month(GETDATE()) and YEAR(fecha) = Year(GETDATE())
	group by day(fecha), MONTH(fecha),YEAR(fecha)

go

create or alter procedure SP_VentasMes
as
	Select COUNT(nro_factura)'Ventas Mes'
	from Factura
	where MONTH(fecha) = Month(GETDATE()) and YEAR(fecha) = Year(GETDATE())
	group by MONTH(fecha),YEAR(fecha)

go


create or alter procedure SP_BajarAlias(
	@Alias varchar(50)
)as
	update Usuarios
	set baja_logica = 1
	where alias = @Alias