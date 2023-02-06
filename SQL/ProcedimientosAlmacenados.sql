create or alter procedure SP_Insertar_UsuarioEmpleado(
	@DNI bigint,
	@nombre varchar(150),
	@apellido varchar(150),
	@direccion varchar(150),
	@fecha_nacimiento datetime,
	@telefono bigint,
	@alias varchar(150),
	@contrase�a varchar(32),
	@id_rol int,
	@baja_logica_user int,
	@baja_logica_empleado int
)as
begin
	declare @UltimoId int

	insert into Empleado values(@DNI,@nombre,@apellido,@direccion,@fecha_nacimiento,@telefono,@baja_logica_empleado)
	
	set @UltimoId = SCOPE_IDENTITY()

	insert into Usuarios values(@alias,@contrase�a,@UltimoId,@id_rol,@baja_logica_user)
end

go

create or alter procedure SP_Actualizar_UsuarioEmpleado(
	@id_empleado int,
	@id_usuario int,
	@direccion varchar(150),
	@telefono bigint,
	@alias varchar(150),
	@contrase�a varchar(32),
	@id_rol int,
	@baja_logica_usuario int,
	@baja_logica_empleado int
)as
begin
	update Usuarios
	set alias = @alias,
		contrase�a = @contrase�a,
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
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contrase�a,r.id_rol,u.baja_logica, r.roles
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 1
	end

	if @condicion = 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contrase�a,r.id_rol,u.baja_logica, r.roles
	from Usuarios u
	join Empleado E on e.id_empleado = u.id_empleado
	join Roles r on r.id_rol = u.id_rol
	where u.baja_logica = 0
	end

	if @condicion != 1 and @condicion != 0
	begin
	select e.id_empleado,u.id_usuario,dni,nombre,apellido,direccion,fecha_nac,telefono,e.baja_logica,alias,contrase�a,r.id_rol,u.baja_logica, r.roles
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
	@contrase�a varchar(32)
)as
	select id_usuario
	from Usuarios
	where @alias = alias and contrase�a = @contrase�a


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
	set id_socio = @cod_socio
	where id_cliente = @id_cliente


go
	






execute  SP_Insertar_Cliente 2,'Fede','Tahan','asdasd',3575417784

select * from Socio



SELECT GETDATE()



select * from cliente


























delete Empleado


delete Usuarios 


delete Bitacora

select * from Usuarios

insert into Bitacora values(7,GETDATE(),'Logeo')
