create table CONTACTO(
	idContacto int identity primary key,
	Nombre varchar(50),
	Telefono varchar(15),
	Correo varchar(50)
);

create procedure sp_listar as begin select * from CONTACTO end;

create procedure sp_obtener(
	@idContacto int
) as
begin
	select * from CONTACTO where idContacto = @idContacto end;

create procedure sp_guardar(
	@Nombre varchar(100),
	@Telefono varchar(100),
	@Correo varchar(100)
)
as 
begin insert into CONTACTO(Nombre, Telefono, Correo) values
(@Nombre, @Telefono, @Correo) end;

create procedure sp_editar(
	@idContacto int,
	@Nombre varchar(50),
	@Telefono varchar(50),
	@Correo varchar(50)
)
as 
begin 
	update CONTACTO set Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo
	where idContacto = @idContacto end;

create procedure sp_eliminar(
	@idContacto int
)
as 
begin
	delete from CONTACTO where idContacto = @idContacto end;