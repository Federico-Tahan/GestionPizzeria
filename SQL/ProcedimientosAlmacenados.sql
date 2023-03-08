create or alter procedure SP_Insertar_UsuarioEmpleado(
	@DNI bigint,
	@nombre varchar(150),
	@apellido varchar(150),
	@direccion varchar(150),
	@altura int,
	@piso int,
	@departamento varchar(100),
	@localidad int,
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

	insert into Empleado values(@DNI,@nombre,@apellido,@direccion,@fecha_nacimiento,@telefono,@baja_logica_empleado,@localidad,@altura,@piso,@departamento)
	
	set @UltimoId = SCOPE_IDENTITY()

	insert into Usuarios values(@alias,@contraseña,@UltimoId,@id_rol,@baja_logica_user,GETDATE(),null)
	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Registrar usuario')

end





select * from roles


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
	@id_usuario_admin int,
	@nombre varchar(50),
	@apellido varchar(50),
	@dni bigint,
	@fecha_nac datetime,
	@departamento varchar(100),
	@altura int,
	@piso int,
	@id_localidad int

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
		baja_logica = @baja_logica_empleado,
		dni = @dni,
		nombre = @nombre,
		apellido = @apellido,
		fecha_nac = @fecha_nac,
		departamento = @departamento,
		altura = @altura,
		piso = @piso,
		id_localidad = @id_localidad
	where id_empleado = @id_empleado	

	if(@baja_logica_usuario = 1)
	begin
		update Usuarios
		set fechaBaja = GETDATE()
		where id_usuario = @id_usuario
	end
	else if (@baja_logica_usuario = 0)
	begin
		update Usuarios
		set fechaBaja = null
		where id_usuario = @id_usuario
	end

	if (@baja_logica_usuario = 1)
	begin
		insert into Bitacora values(@id_usuario_admin,GETDATE(),'Usuario dado de baja')

	end
	else
	begin
		insert into Bitacora values(@id_usuario_admin,GETDATE(),'Modificar Usuario')

	end
end

go

create or alter procedure SP_Obtener_usuarios(
	@condicion int
)
as
begin
	
	if @condicion = 1
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles,u.fechaAlta,u.fechaBaja,
	e.altura,e.piso,e.departamento,e.id_localidad, l.localidad
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	left join Localidad l on l.id_localidad =e.id_localidad
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 1
	end
	if @condicion = 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles,u.fechaAlta,u.fechaBaja,
	e.altura,e.piso,e.departamento,e.id_localidad, l.localidad
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	left join Localidad l on l.id_localidad =e.id_localidad
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 0
	end

	if @condicion != 1 and @condicion != 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles,u.fechaAlta,u.fechaBaja,
	e.altura,e.piso,e.departamento,e.id_localidad, l.localidad
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	left join Localidad l on l.id_localidad =e.id_localidad
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
	@contraseña varchar(50),
	@id_usuario int
)as
	update Configuracion
	set Email = @email,
		instagram = @instagram,
		facebook = @facebook,
		twitter = @twitter,
		youtube = @youtube,
		contraseña = @contraseña
	where id_configuracion = 1
	insert into Bitacora values(@id_usuario,GETDATE(),'Modificar Redes')


go


create or alter procedure SP_Obtener_Descuentos
as
select * from Descuento


go


create or alter procedure SP_ActualizarConfigDescuentos(
	@dia1 money,
	@dia2 money,
	@dia3 money,
	@dia4 money,
	@dia5 money,
	@dia6 money,
	@dia7 money,
	@descuentoSocio int,
	@descuentoPresencial int,
	@id_usuario int

)as
	


	declare @modificacionBeneficio int

	declare @actualdescuentopresencial int
	declare @actualdescuentoSocio int
	declare @diauno money
	declare @diados money
	declare @diatres money
	declare @diacuatro money
	declare @diacinco money
	declare @diaseis money
	declare @diasiete money

	select @diauno = porcentaje_descuento 
	from Descuento
	where id_descuento = 1

	select @diados= porcentaje_descuento 
	from Descuento
	where id_descuento =2

		select @diatres = porcentaje_descuento 
	from Descuento
	where id_descuento = 3

		select @diacuatro = porcentaje_descuento 
	from Descuento
	where id_descuento = 4

		select @diacinco = porcentaje_descuento 
	from Descuento
	where id_descuento = 5

		select @diaseis = porcentaje_descuento 
	from Descuento
	where id_descuento = 6

		select @diasiete = porcentaje_descuento 
	from Descuento
	where id_descuento = 7

	select @actualdescuentopresencial = compras_presenciales, @actualdescuentoSocio = descuentos_socios
	from Configuracion
	where id_configuracion = 1


	if(@actualdescuentopresencial != @descuentoPresencial or @descuentoSocio != @actualdescuentoSocio)
	begin
		insert into Bitacora values(@id_usuario,GETDATE(),'Modificar Beneficio')

	end

	if(@dia1 != @diauno or @dia2 != @diados or @dia3 != @diatres or @dia4 != @diacuatro or @dia5 != @diacinco or @dia6 != @diaseis or @dia7 != @diasiete)
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificar Descuento')

	end


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
	left join Usuarios u on  b.id_usuario =u.id_usuario
	left join Empleado e on e.id_empleado = u.id_empleado
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
	@direccion varchar(500),
	@telefono varchar(100),
	@id_usuario int,
	@altura int,
	@piso int,
	@departamento varchar(30),
	@id_localidad int
)as
	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@telefono, null,0,@direccion,@altura,@departamento,@piso,@id_localidad)
		insert into Bitacora values(@id_usuario,GETDATE(),'Ingreso Cliente')


go


create or alter procedure SP_Insertar_ClienteSocio(
	@id_tipo_cliente int,
	@nombre varchar(50),
	@apellido varchar(50),
	@direccion varchar(500),
	@telefono varchar(100),
	@DNI bigint,
	@email varchar (100),
	@id_usuario int,
	@altura int,
	@piso int,
	@departamento varchar(30),
	@id_localidad int
)as
	insert into Socio values(@DNI,@email,GETDATE(),0)
	declare @cod int
	set @cod = SCOPE_IDENTITY()


	insert into Cliente values(@id_tipo_cliente,@nombre,@apellido,@telefono, @cod,0,@direccion,@altura,@departamento,@piso,@id_localidad)
	insert into Bitacora values(@id_usuario,GETDATE(),'Adhesion al club')

go


create or alter procedure SP_Cargar_TodosCLientes
as
	select id_cliente,s.id_socio, nombre, apellido,calle,telefono, s.DNI,s.email, s.fecha_adhesion, s.baja_logica,id_tipo_cliente,altura,piso,departamento,l.id_localidad,l.localidad
	from Cliente c
	left join Socio s on s.id_socio = c.id_socio
	join localidad l on c.id_localidad = l.id_localidad
	ORDER by id_cliente desc


go

create or alter procedure SP_ModificarSocio(
	@id_cliente int,
	@id_tipo_cliente int,
	@direccion varchar(500),
	@telefono varchar(100),
	@email varchar (100),
	@id_usuario int,
	@altura int,
	@piso int,
	@departamento varchar(30),
	@localidad int,	
	@nombre varchar(30),
	@apellido varchar(30),
	@dni bigint
)as
	update Cliente
	set calle = @direccion,
		altura = @altura,
		piso = @piso,
		departamento = @departamento,
		id_localidad = @localidad,
		telefono= @telefono,
		id_tipo_cliente = @id_tipo_cliente,
		nombre = @nombre,
		apellido = @apellido
	where id_cliente = @id_cliente

	update socio
	set email = @email,
		dni = @dni
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
		else if (@codicion = 3)
	begin
		select id_producto,nombre,precio,detalle,stock,p.id_unidad_medida,um.unidad_Medida,c.id_clasificacion,c.clasificacion,tp.id_tipo_producto,tp.tipo_producto,p.baja_logica
		from Producto p 
		join unidad_Medida um on um.id_unidad_medida = p.id_unidad_medida
		join Clasificacion c on c.id_clasificacion = p.id_clasificacion
		join Tipo_producto tp on tp.id_tipo_producto = p.id_tipo_producto
		where p.baja_logica = 0 and c.id_clasificacion = 1
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



	if(@id_clasificacion = 1)
	begin
		if(@baja_logica = 1)
		begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Producto')

		end
		else
		begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion del producto')

		end
	end




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
	@nombre varchar(50),
	@apellido varchar(50),
	@id_localidad int,
	@calle varchar(500),
	@altura int,
	@piso int,
	@departamento varchar(50),
	@dni bigint,
	@telefono bigint,
	@descuento money,
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

	declare @clienteestado int
	if(@id_cliente = 0)
	begin
		set @clienteestado = null
	end
	else
	begin
		set @clienteestado = @id_cliente
	end


	declare @document bigint
	if(@dni = 0)
	begin
		set @document = null
	end
	else
	begin
		set @document = @dni
	end

		declare @tel bigint
	if(@telefono = 0)
	begin
		set @tel = null
	end
	else
	begin
		set @tel = @telefono
	end

	if(@tienedescuento = 0)
	begin 
		insert into Factura values(GETDATE(),@clienteestado,@id_usuario,@id_forma_compra,@id_forma_entrega,@diaweek,0,@nombre,@apellido,@id_localidad,@calle,@altura,@piso,@departamento,@document,@tel,@descuento)
	set @IDFACTURA = SCOPE_IDENTITY()
	end
	else
	begin
		insert into Factura values(GETDATE(),@clienteestado,@id_usuario,@id_forma_compra,@id_forma_entrega,null,0,@nombre,@apellido,@id_localidad,@calle,@altura,@piso,@departamento,@document,@tel,@descuento)
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
	@dni bigint
)
as
		select id_cliente, nombre,apellido,id_localidad,calle,altura,piso,departamento,s.baja_logica,telefono
		from Cliente c
		join Socio s on c.id_socio = s.id_socio
		where s.baja_logica = 0 and DNI = @dni
go



create or alter procedure SP_ObtenerFactura(
	 @id_vendedor int
)
as
	if(@id_vendedor = 0)
	begin
	select nro_factura, CONVERT(VARCHAR, fecha, 108)'Hora',CONVERT(VARCHAR, fecha, 105)'Fecha', f.nombre + SPACE(1) + f.apellido'Nombre_Completo'
	, e.nombre + SPACE(1) + e.apellido 'Nombre_CompletoUsuario', fc.forma_compra,fe.forma_entrega, Descuento,fecha,loc.localidad,f.altura,f.piso,f.departamento,f.calle,f.baja_logica,loc.id_localidad
	, f.nombre, f.apellido,f.id_forma_entrega,f.id_forma_compra,f.DNI,f.telefono
	from Factura f
	left join Cliente c on c.id_cliente = f.id_cliente
	join Usuarios u on u.id_usuario = f.id_usuario
	join Localidad loc on loc.id_localidad = f.id_localidad
	join Empleado e on e.id_empleado = u.id_empleado
	join forma_entrega fe on fe.id_forma_entrega = f.id_forma_entrega
	join Forma_compra fc on fc.id_forma_compra = f.id_forma_compra
	left join Socio s on s.id_socio = c.id_socio
	order by nro_factura desc
	end
	else
	begin
			select nro_factura, CONVERT(VARCHAR, fecha, 108)'Hora',CONVERT(VARCHAR, fecha, 105)'Fecha', f.nombre + SPACE(1) + f.apellido'Nombre_Completo'
		, e.nombre + SPACE(1) + e.apellido 'Nombre_CompletoUsuario', fc.forma_compra,fe.forma_entrega, Descuento,fecha,loc.localidad,f.altura,f.piso,f.departamento,f.calle,f.baja_logica,loc.id_localidad
		, f.nombre, f.apellido,f.id_forma_entrega,f.id_forma_compra,f.DNI,f.telefono
		from Factura f
		left join Descuento d on f.id_descuento = d.id_descuento
		left join Cliente c on c.id_cliente = f.id_cliente
		join Usuarios u on u.id_usuario = f.id_usuario
		join Localidad loc on loc.id_localidad = f.id_localidad
		join Empleado e on e.id_empleado = u.id_empleado
		join forma_entrega fe on fe.id_forma_entrega = f.id_forma_entrega
		join Forma_compra fc on fc.id_forma_compra = f.id_forma_compra
		left join Socio s on s.id_socio = c.id_socio
		where f.id_usuario = @id_vendedor
		order by nro_factura desc
	end
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

create or alter procedure SP_GetLocalidad(
	@a int
)as
	if(@a = 0)
	begin
		select * from localidad where baja_logica = 0
	end
	else if (@a = 1)
	begin
			select * from localidad where baja_logica = 1

	end
	else 
	begin
			select * from localidad
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
	@nombre varchar(50),
			@id_usuario int

)as
	insert into Clasificacion values(@nombre,0)
				insert into Bitacora values(@id_usuario,GETDATE(),'Alta Clasificacion')

go


create or alter procedure SP_AltaLocalidad(
	@nombre varchar(50),
		@id_usuario int

)as
	insert into Localidad values(@nombre,0)
			insert into Bitacora values(@id_usuario,GETDATE(),'Alta Localidad')


go


create or alter procedure SP_AltaUnidadMed(
	@nombre varchar(50),
	@id_usuario int
)as
	insert into Unidad_Medida values(@nombre,0)
		insert into Bitacora values(@id_usuario,GETDATE(),'Alta Unidad Medida')

go


create or alter procedure SP_AltaTipoProd(
	@nombre varchar(50),
	@id_usuario int

)as
	insert into Tipo_producto values(@nombre,0)
		insert into Bitacora values(@id_usuario,GETDATE(),'Alta Tipo Producto')


go

create or alter procedure SP_MODClasificacion(
	@id int,
	@nombre  varchar(50),
	@baja_logica int,		@id_usuario int

)as	
	update Clasificacion
	set baja_logica = @baja_logica,
		clasificacion = @nombre
	where id_clasificacion = @id

	if(@baja_logica =1 )
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Clasificacion')

	end
	else
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion Clasificacion')

	end
go

create or alter procedure SP_ModLocalidad(
	@id int,
	@nombre  varchar(50),
	@baja_logica int,
	@id_usuario int
)as	
	update localidad
	set baja_logica = @baja_logica,
		localidad = @nombre
	where id_localidad = @id


		if(@baja_logica =1 )
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Localidad')

	end
	else
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion Localidad')

	end
go

create or alter procedure SP_MODUnidadMed(
	@id int,
	@nombre  varchar(50),
	@baja_logica int,
		@id_usuario int

)as	
	update Unidad_Medida
	set baja_logica = @baja_logica,
		Unidad_Medida = @nombre
	where id_unidad_medida = @id


			if(@baja_logica =1 )
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Unidad de Medida')

	end
	else
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion Unidad de Medida')

	end


go


create or alter procedure SP_MODTipoProd(
	@id int,
	@nombre  varchar(50),
	@baja_logica int,
		@id_usuario int
)as	
	update Tipo_producto
	set baja_logica = @baja_logica,
		tipo_producto = @nombre
	where id_tipo_producto = @id

				if(@baja_logica =1 )
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Tipo de Producto')

	end
	else
	begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion Tipo de Producto')

	end

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
		insert into Bitacora values(null,GETDATE(),'Usuario ' + @Alias + ' bloqueado por alcanzar 3 intentos de Logeo Fallidos')

go

create or alter procedure SP_UsuarioAltaoBaja(
	@Alias varchar(50)
)as
	select baja_logica
	from Usuarios
	where alias = @Alias

go


create or alter procedure SP_ModificarIngrediente(
	@id_producto int,
	@nombre varchar(100) ,
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
		detalle = @detalle,
		stock = @stock,
		id_unidad_medida = @id_unidad_medida,
		id_tipo_producto = @id_tipo_producto,
		id_clasificacion = @id_clasificacion,
		baja_logica = @baja_logica
	where id_producto = @id_producto

	 if(@id_clasificacion = 2)
	begin
		if(@baja_logica = 0)
		begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Modificacion de Ingrediente')
		end
		else
		begin
			insert into Bitacora values(@id_usuario,GETDATE(),'Baja Ingrediente')
		end
	end

go

create or alter procedure SP_AltaIngrediente(
	@nombre varchar(100) ,
	@detalle varchar(600),
	@stock int,
	@id_unidad_medida int,
	@id_tipo_producto int,
	@id_clasificacion int ,
	@baja_logica int,
	@id_usuario int
)as
	insert into Producto values (@nombre,0,@detalle,@stock,@id_unidad_medida,@id_tipo_producto,@id_clasificacion,@baja_logica)
	insert into Bitacora values(@id_usuario,GETDATE(),'Ingresar Ingrediente')
go


create or alter procedure SP_TRAER_Localidad
as
	select * from localidad where baja_logica = 0

go



create or alter procedure SP_CancelarVenta(
	@id_fac int,
	@id_usuario int
)as
	UPDATE producto
	SET stock = stock + cantidad,
		baja_logica = 0
	FROM Producto t1
	INNER JOIN detalle_factura t2 ON t1.id_producto = t2.id_producto
	where t2.nro_factura = @id_fac

	update Factura
	set baja_logica = 1
	where @id_fac  = nro_factura

	insert into Bitacora values(@id_usuario,GETDATE(),'Cancelar venta')

go

create or alter procedure SP_ModVenta(
	@id_Factura int,
	@id_cliente int,
	@id_usuario int,
	@id_forma_compra int,
	@id_forma_entrega int,
	@tienedescuento int,
	@id_usuario_admin int,
	@nombre varchar(50),
	@apellido varchar(50),
	@id_localidad int,
	@calle varchar(500),
	@altura int,
	@piso int,
	@departamento varchar(50),
	@telefono bigint,
	@descuento money
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

	declare @clienteestado int
	if(@id_cliente = 0)
	begin
		set @clienteestado = null
	end
	else
	begin
		set @clienteestado = @id_cliente
	end

	declare @tel bigint
	if(@telefono = 0)
	begin
	set @tel = null
	end
	else
	begin
		set @tel = @telefono
	end


	if(@tienedescuento = 0)
	begin 
		update Factura
		set id_cliente = @clienteestado,
			id_usuario = @id_usuario,
			id_forma_compra = @id_forma_compra,
			id_forma_entrega = @id_forma_entrega,
			id_descuento = @diaweek,
			baja_logica = 0,
			nombre = @nombre,
			apellido = @apellido,
			id_localidad = @id_localidad,
			calle = @calle,
			altura = @altura,
			piso = @piso,
			departamento = @departamento,
			telefono = @telefono,
			descuento = @descuento
		where nro_factura = @id_Factura
	end
	else
	begin
			update Factura
		set id_cliente = @clienteestado,
			id_usuario = @id_usuario,
			id_forma_compra = @id_forma_compra,
			id_forma_entrega = @id_forma_entrega,
			id_descuento = null,
			baja_logica = 0,
			nombre = @nombre,
			apellido = @apellido,
			id_localidad = @id_localidad,
			calle = @calle,
			altura = @altura,
			piso = @piso,
			departamento = @departamento,
			telefono = @telefono,
			descuento = @descuento
		where nro_factura = @id_Factura
	end

	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Modificacion de venta')

go

create or alter procedure SP_CancelarVentaMod(
	@id_fac int
)as
	UPDATE producto
	SET stock = stock + cantidad,
		baja_logica = 0
	FROM Producto t1
	INNER JOIN detalle_factura t2 ON t1.id_producto = t2.id_producto
	where t2.nro_factura = @id_fac

	delete detalle_factura
	where @id_fac = nro_factura
go



create or alter procedure SP_EliminarCliente(
	@cliente int,
	@id_usuario_admin int

)as
	declare @id_socio int
	 select @id_socio = id_socio
					from Cliente
					where id_cliente = @cliente
	delete cliente
	where id_cliente = @cliente

	delete Socio
	where id_socio = @cliente

	insert into Bitacora values(@id_usuario_admin,GETDATE(),'Dar de baja un socio')





create or alter procedure SP_Obtener_usuario(
	@id_user int
)
as
begin
	
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contraseña,r.id_rol,u.baja_logica, r.roles,u.fechaAlta,u.fechaBaja,
	e.altura,e.piso,e.departamento,e.id_localidad, l.localidad
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	left join Localidad l on l.id_localidad =e.id_localidad
	join Roles r on r.id_rol = u.id_rol
	where  u.id_usuario = @id_user

end











	select * from Usuarios
	update Usuarios
	set baja_logica = 0
	
	
	select * from Socio

DBCC CHECKIDENT ('a', RESEED,0) 
select * from Cliente

alter table factura
drop constraint fk_id_cliente

































select * from Factura






insert into localidad values('Obispo Trejo',0)



Delete Bitacora
DBCC CHECKIDENT ('Bitacora', RESEED,0) 
Delete detalle_factura
DBCC CHECKIDENT ('detalle_factura', RESEED,0) 
Delete Factura
DBCC CHECKIDENT ('Factura', RESEED,0) 
Delete Cliente
DBCC CHECKIDENT ('Cliente', RESEED,0) 
Delete Usuarios
DBCC CHECKIDENT ('Usuarios', RESEED,0) 
Delete Empleado
DBCC CHECKIDENT ('Empleado', RESEED,0) 
Delete Producto
DBCC CHECKIDENT ('Producto', RESEED,0) 
Delete Unidad_Medida
DBCC CHECKIDENT ('Unidad_Medida', RESEED,0) 
Delete Tipo_producto
DBCC CHECKIDENT ('Tipo_producto', RESEED,0) 
Delete Socio
DBCC CHECKIDENT ('Socio', RESEED,0) 
Delete Clasificacion
DBCC CHECKIDENT ('Clasificacion', RESEED,0) 
Delete Roles
DBCC CHECKIDENT ('Roles', RESEED,0) 
Delete Forma_compra
DBCC CHECKIDENT ('Forma_compra', RESEED,0)
Delete forma_entrega
DBCC CHECKIDENT ('forma_entrega', RESEED,0) 
Delete tipo_cliente
DBCC CHECKIDENT ('tipo_cliente', RESEED,0) 
Delete Descuento
DBCC CHECKIDENT ('Descuento', RESEED,0) 
Delete Localidad
DBCC CHECKIDENT ('Localidad', RESEED,0) 
Delete Configuracion
