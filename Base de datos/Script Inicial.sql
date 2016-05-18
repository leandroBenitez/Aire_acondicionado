/*	**********************	CAMBIO DE BASE DE DATOS	******************** */
Use GD1C2016
Go

/*	***********************	CREACION DEL SCHEMA	************************ */
If NOT EXISTS (Select [schema_id] from [sys].[schemas] where [name] = 'GESTORES_DEL_AIRE_ACONDICIONADO')
	Execute ('CREATE SCHEMA GESTORES_DEL_AIRE_ACONDICIONADO AUTHORIZATION gd;');
Go

/*	***********************	BORRADO DE TABLAS	************************ */
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_item')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_item
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_factura')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_forma_pago')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_forma_pago

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_subasta')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_subasta

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_compra')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_calificacion')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_calificacion

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_pregunta')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_pregunta

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_publicacion')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_rubro')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_rubro

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_tipo_publicacion')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_tipo_publicacion

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_visibilidad')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_visibilidad

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_estado_publicacion')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_publicacion

If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'log_ingresos')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.log_ingresos	
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'rl_roles_usuarios')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.rl_roles_usuarios	
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'rl_funciones_roles')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles		
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_funcion')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion		
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_rol')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol		
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_empresa')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa	
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_cliente')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente	
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'ft_usuario')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario	
	
If exists (Select 'existe' from INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = 'GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'dm_estado_usuario')
	Drop table GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_usuario

/*	***********************	CREACION DE TABLAS	************************ */
Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_usuario
(	
	 id_estado_usuario int identity(1,1)
	,desc_estado nvarchar(100)
	,primary key (id_estado_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario
(	 
	 id_usuario int identity(1,1)
	,desc_username nvarchar(250)
	,desc_password varbinary(32)
	,id_estado int
	,primary key (id_usuario)
	,foreign key (id_estado) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_usuario(id_estado_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente
(	
	 id_cliente int identity(1,1)
	,id_usuario int
	,desc_Apellido nvarchar(255)
	,desc_Nombre nvarchar(255)
	,desc_Dni numeric(18,0)
	,desc_Mail nvarchar(255)
	,desc_Dom_Calle nvarchar(255)
	,desc_Nro_Calle numeric(18,0)
	,desc_Piso numeric(18,0)
	,desc_Depto nvarchar(50)
	,desc_Localidad nvarchar(45)
	,desc_Cod_Postal nvarchar(50)
	,desc_Telefono numeric(10,0)
	,desc_Fecha_Nac datetime
	,desc_Fecha_Creacion datetime
	,primary key (id_cliente)	
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa
(
	 id_empresa int identity(1,1)
	,id_usuario int
	,desc_Razon_Social nvarchar(255)
	,desc_Mail nvarchar(50)
	,desc_Telefono numeric(10,0)
	,desc_Fecha_Creacion datetime
	,desc_Dom_Calle nvarchar(100)
	,desc_Nro_Calle numeric(18,0)
	,desc_Piso numeric(18,0)
	,desc_Depto nvarchar(50)
	,desc_Localidad nvarchar(45)
	,desc_Cod_Postal nvarchar(50)
	,desc_Ciudad nvarchar(45)
	,desc_Cuit nvarchar(50)
	,desc_nombre_contacto nvarchar(100)
	,primary key (id_empresa)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol
(
	 id_rol int identity(1,1)
	,desc_rol nvarchar(50)
	,primary key (id_rol)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion
(
	 id_funcion int identity(1,1)
	,desc_funcion nvarchar(200)
	,primary key (id_funcion)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.rl_funciones_roles
(
	 id_relacion int identity(1,1)
	,id_rol int
	,id_funcion int
	,primary key (id_relacion)
	,foreign key (id_rol) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol(id_rol)
	,foreign key (id_funcion) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion(id_funcion)
) 

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.rl_roles_usuarios
(
	 id_relacion int identity(1,1)
	,id_usuario int
	,id_rol int
	,primary key (id_relacion)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
	,foreign key (id_rol) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol(id_rol)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.log_ingresos
(
	 id_log int identity(1,1)
	,id_usuario int --En caso de corresponder
	,desc_username nvarchar(250)
	,desc_fecha_log datetime
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_publicacion
(
	 id_estado_publi int identity(1,1)
	,desc_estado nvarchar(100)
	,primary key (id_estado_publi)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_visibilidad
(
	 id_visibilidad int identity(1,1)
	,desc_codigo numeric(18,0)
	,desc_tipo nvarchar(255)
	,desc_precio numeric(18,2)
	,desc_porcentaje numeric(18,2)
	,primary key (id_visibilidad)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_tipo_publicacion
(
	 id_tipo_publi int identity(1,1)
	,desc_tipo_public nvarchar(255)
	,primary key (id_tipo_publi)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_rubro
(
	 id_rubro int identity(1,1)
	,desc_rubro nvarchar(255)
	,primary key (id_rubro)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion
(
	 id_publicacion int identity(1,1)
	,desc_codigo numeric(18,0)
	,desc_publicacion nvarchar(255)
	,desc_stock numeric(18,0)
	,desc_fecha_publi datetime
	,desc_fecha_venc datetime
	,desc_precio numeric(18,2)
	,desc_preguntas nvarchar(10)
	,id_estado_publi int
	,id_visibilidad int
	,id_tipo_publi int
	,id_rubro int
	,id_usuario int
	,primary key (id_publicacion)
	,foreign key (id_estado_publi) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_publicacion(id_estado_publi)
	,foreign key (id_visibilidad) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_visibilidad(id_visibilidad)
	,foreign key (id_tipo_publi) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_tipo_publicacion(id_tipo_publi)
	,foreign key (id_rubro) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_rubro(id_rubro)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_pregunta
(
	 id_pregunta int identity(1,1)
	,desc_pregunta nvarchar(255)
	,id_publicacion int
	,primary key (id_pregunta)
	,foreign key (id_publicacion) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion(id_publicacion)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_calificacion
(
	 id_calificacion int identity(1,1)
	,desc_codigo numeric(18,0)
	,desc_cantidad_estrellas numeric(18,0)
	,descripcion nvarchar(255)
	,id_usuario_origen int
	,id_usuario_destino int
	,id_publicacion int
	,primary key (id_calificacion)
	,foreign key (id_usuario_origen) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
	,foreign key (id_usuario_destino) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
	,foreign key (id_publicacion) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion(id_publicacion)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra
(
	 id_compra int identity(1,1)
	,desc_fecha datetime
	,desc_cantidad numeric(18,0)
	,id_publicacion int
	,id_usuario int
	,primary key (id_compra)
	,foreign key (id_publicacion) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion(id_publicacion)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_subasta
(	
	 id_subasta int identity(1,1)
	,desc_fecha datetime
	,desc_monto numeric(18,2)
	,id_publicacion int
	,id_usuario int
	,primary key (id_subasta)
	,foreign key (id_publicacion) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion(id_publicacion)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.dm_forma_pago
(
	 id_forma_pago int identity(1,1)
	,desc_tipo_pago nvarchar(255)
	,primary key (id_forma_pago)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura
(	
	 id_factura int identity(1,1)
	,desc_factura_nro numeric(18,0)
	,desc_fecha datetime
	,desc_total numeric(18,2)
	,id_forma_pago int
	,id_usuario int
	,primary key (id_factura)
	,foreign key (id_forma_pago) references GESTORES_DEL_AIRE_ACONDICIONADO.dm_forma_pago(id_forma_pago)
	,foreign key (id_usuario) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario(id_usuario)
)

Create Table GESTORES_DEL_AIRE_ACONDICIONADO.ft_item	
(
	 id_item int identity(1,1)
	,desc_item_monto numeric(18,2)
	,desc_item_cant numeric(18,0)
	,id_factura int
	,id_publicacion int
	,primary key (id_item)
	,foreign key (id_factura) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura(id_factura)
	,foreign key (id_publicacion) references GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion(id_publicacion)
)

/*	***********************	CARGA DE DATOS	************************ */
Insert into GESTORES_DEL_AIRE_ACONDICIONADO.dm_rol	(desc_rol)
Values	('Cliente'),
		('Empresa'),
		('Administrador')
Go

Insert into GESTORES_DEL_AIRE_ACONDICIONADO.dm_funcion	(desc_funcion)
Values	('Login y seguridad'),
		('ABM de Rol'),
		('ABM de Usuarios'),
		('ABM de Rubro'),
		('ABM visibilidad de publicación'),
		('Generar Publicación'),
		('Comprar/Ofertar'),
		('Historial del cliente'),
		('Calificar al Vendedor'),
		('Consulta de facturas realizadas al vendedor'),
		('Listado Estadístico')
Go

Insert into GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_publicacion	(desc_estado)
Values	('Borrador'),
		('Activa'),
		('Pausada'),
		('Finalizada')
Go

Insert into GESTORES_DEL_AIRE_ACONDICIONADO.dm_estado_usuario	(desc_estado)
Values	('Habilitado'),
		('Bloqueado')
Go

/*	***********************	MIGRACION DE DATOS	************************ */
--Declaracion de variables para uso de cursor
Declare
	 @Publ_Cli_Dni numeric(18, 0)
	,@Publ_Cli_Apellido nvarchar(255)
	,@Publ_Cli_Nombre nvarchar(255)
	,@Publ_Cli_Fecha_Nac datetime
	,@Publ_Cli_Mail nvarchar(255)
	,@Publ_Cli_Dom_Calle nvarchar(255)
	,@Publ_Cli_Nro_Calle numeric(18, 0)
	,@Publ_Cli_Piso numeric(18, 0)
	,@Publ_Cli_Depto nvarchar(50)
	,@Publ_Cli_Cod_Postal nvarchar(50)
	,@Publ_Empresa_Razon_Social nvarchar(255)
	,@Publ_Empresa_Cuit nvarchar(50)
	,@Publ_Empresa_Fecha_Creacion datetime
	,@Publ_Empresa_Mail nvarchar(50)
	,@Publ_Empresa_Dom_Calle nvarchar(100)
	,@Publ_Empresa_Nro_Calle numeric(18, 0)
	,@Publ_Empresa_Piso numeric(18, 0)
	,@Publ_Empresa_Depto nvarchar(50)
	,@Publ_Empresa_Cod_Postal nvarchar(50)
	,@Publicacion_Cod numeric(18, 0)
	,@Publicacion_Descripcion nvarchar(255)
	,@Publicacion_Stock numeric(18, 0)
	,@Publicacion_Fecha datetime
	,@Publicacion_Fecha_Venc datetime
	,@Publicacion_Precio numeric(18, 2)
	,@Publicacion_Tipo nvarchar(255)
	,@Publicacion_Visibilidad_Cod numeric(18, 0)
	,@Publicacion_Visibilidad_Desc nvarchar(255)
	,@Publicacion_Visibilidad_Precio numeric(18, 2)
	,@Publicacion_Visibilidad_Porcentaje numeric(18, 2)
	,@Publicacion_Estado nvarchar(255)
	,@Publicacion_Rubro_Descripcion nvarchar(255)
	,@Cli_Dni numeric(18, 0)
	,@Cli_Apellido nvarchar(255)
	,@Cli_Nombre nvarchar(255)
	,@Cli_Fecha_Nac datetime
	,@Cli_Mail nvarchar(255)
	,@Cli_Dom_Calle nvarchar(255)
	,@Cli_Nro_Calle numeric(18, 0)
	,@Cli_Piso numeric(18, 0)
	,@Cli_Depto nvarchar(50)
	,@Cli_Cod_Postal nvarchar(50)
	,@Compra_Fecha datetime
	,@Compra_Cantidad numeric(18, 0)
	,@Oferta_Fecha datetime
	,@Oferta_Monto numeric(18, 2)
	,@Calificacion_Codigo numeric(18, 0)
	,@Calificacion_Cant_Estrellas numeric(18, 0)
	,@Calificacion_Descripcion nvarchar(255)
	,@Item_Factura_Monto numeric(18, 2)
	,@Item_Factura_Cantidad numeric(18, 0)
	,@Factura_Nro numeric(18, 0)
	,@Factura_Fecha datetime
	,@Factura_Total numeric(18, 2)
	,@Forma_Pago_Desc nvarchar(255)

--Declaracion del cursor
Declare cursor_maestro Cursor for select * from gd_esquema.Maestra

--Apertura del cursor en memoria
Open cursor_maestro

--Lectura del primer registro
Fetch next from cursor_maestro into	 @Publ_Cli_Dni
									,@Publ_Cli_Apellido
									,@Publ_Cli_Nombre
									,@Publ_Cli_Fecha_Nac
									,@Publ_Cli_Mail
									,@Publ_Cli_Dom_Calle
									,@Publ_Cli_Nro_Calle
									,@Publ_Cli_Piso
									,@Publ_Cli_Depto
									,@Publ_Cli_Cod_Postal
									,@Publ_Empresa_Razon_Social
									,@Publ_Empresa_Cuit
									,@Publ_Empresa_Fecha_Creacion
									,@Publ_Empresa_Mail
									,@Publ_Empresa_Dom_Calle
									,@Publ_Empresa_Nro_Calle
									,@Publ_Empresa_Piso
									,@Publ_Empresa_Depto
									,@Publ_Empresa_Cod_Postal
									,@Publicacion_Cod
									,@Publicacion_Descripcion
									,@Publicacion_Stock
									,@Publicacion_Fecha
									,@Publicacion_Fecha_Venc
									,@Publicacion_Precio
									,@Publicacion_Tipo
									,@Publicacion_Visibilidad_Cod
									,@Publicacion_Visibilidad_Desc
									,@Publicacion_Visibilidad_Precio
									,@Publicacion_Visibilidad_Porcentaje
									,@Publicacion_Estado
									,@Publicacion_Rubro_Descripcion
									,@Cli_Dni
									,@Cli_Apellido
									,@Cli_Nombre
									,@Cli_Fecha_Nac
									,@Cli_Mail
									,@Cli_Dom_Calle
									,@Cli_Nro_Calle
									,@Cli_Piso
									,@Cli_Depto
									,@Cli_Cod_Postal
									,@Compra_Fecha
									,@Compra_Cantidad
									,@Oferta_Fecha
									,@Oferta_Monto
									,@Calificacion_Codigo
									,@Calificacion_Cant_Estrellas
									,@Calificacion_Descripcion
									,@Item_Factura_Monto
									,@Item_Factura_Cantidad
									,@Factura_Nro
									,@Factura_Fecha
									,@Factura_Total
									,@Forma_Pago_Desc

While @@fetch_status = 0
Begin
--Captura de usuarios y clientes
If (not exists (Select 'existe' from GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente
				where desc_Dni = @Publ_Cli_Dni)
	and	@Publ_Cli_Dni is not null	)
	Begin
		--Creo el usuario para el cliente
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario	(	 desc_username
																		,desc_password
																		,id_estado	)
		Select	 left(@Publ_Cli_Mail, CHARINDEX('@', @Publ_Cli_Mail) - 1)
				,hashbytes('sha2_256', left(@Publ_Cli_Mail, CHARINDEX('@', @Publ_Cli_Mail) - 1))
				,1
		
		--Creo el cliente
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente	(	 id_usuario
																	,desc_Apellido
																	,desc_Nombre
																	,desc_Dni
																	,desc_Mail	
																	,desc_Dom_Calle
																	,desc_Nro_Calle
																	,desc_Piso
																	,desc_Depto
																	,desc_Cod_Postal
																	,desc_Fecha_Nac
																	,desc_Fecha_Creacion	)
		Select	 @@IDENTITY
				,@Publ_Cli_Apellido
				,@Publ_Cli_Nombre
				,@Publ_Cli_Dni
				,@Publ_Cli_Mail	
				,@Publ_Cli_Dom_Calle
				,@Publ_Cli_Nro_Calle
				,@Publ_Cli_Piso
				,@Publ_Cli_Depto
				,@Publ_Cli_Cod_Postal
				,@Publ_Cli_Fecha_Nac
				,getdate()
	End

If (not exists (Select 'existe' from GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente
				where desc_Dni = @Cli_Dni)
	and	@Cli_Dni is not null	)
	Begin
		--Creo el usuario para el cliente
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario	(	 desc_username
																	,desc_password
																	,id_estado	)
		Select	 left(@Publ_Cli_Mail, CHARINDEX('@', @Cli_Mail) - 1)
				,hashbytes('sha2_256', left(@Cli_Mail, CHARINDEX('@', @Cli_Mail) - 1))
				,1
		
		--Creo el cliente
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente	(	 id_usuario
																	,desc_Apellido
																	,desc_Nombre
																	,desc_Dni
																	,desc_Mail	
																	,desc_Dom_Calle
																	,desc_Nro_Calle
																	,desc_Piso
																	,desc_Depto
																	,desc_Cod_Postal
																	,desc_Fecha_Nac
																	,desc_Fecha_Creacion	)
		Select	 @@IDENTITY
				,@Cli_Apellido
				,@Cli_Nombre
				,@Cli_Dni
				,@Cli_Mail	
				,@Cli_Dom_Calle
				,@Cli_Nro_Calle
				,@Cli_Piso
				,@Cli_Depto
				,@Cli_Cod_Postal
				,@Cli_Fecha_Nac
				,getdate()
	End

--Captura de usuarios y empresas
If (not exists (Select 'existe' from GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa
				where desc_Cuit = @Publ_Empresa_Cuit)
	and	@Publ_Empresa_Cuit is not null	)
	Begin
		--Creo el usuario para la empresa
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario	(	 desc_username
																	,desc_password
																	,id_estado	)
		Select	 concat('razon', right(@Publ_Empresa_Razon_Social, len(@Publ_Empresa_Razon_Social) - CHARINDEX(':', @Publ_Empresa_Razon_Social)))
				,hashbytes('sha2_256', concat('razon', right(@Publ_Empresa_Razon_Social, len(@Publ_Empresa_Razon_Social) - CHARINDEX(':', @Publ_Empresa_Razon_Social))))
				,1

		--Creo la empresa
		Insert into GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa	(	 id_usuario
																	,desc_Razon_Social
																	,desc_Mail
																	,desc_Fecha_Creacion	
																	,desc_Dom_Calle
																	,desc_Nro_Calle
																	,desc_Piso
																	,desc_Depto
																	,desc_Cod_Postal
																	,desc_Cuit	)
		Select	 @@IDENTITY
				,@Publ_Empresa_Razon_Social
				,@Publ_Empresa_Mail
				,@Publ_Empresa_Fecha_Creacion	
				,@Publ_Empresa_Dom_Calle
				,@Publ_Empresa_Nro_Calle
				,@Publ_Empresa_Piso
				,@Publ_Empresa_Depto
				,@Publ_Empresa_Cod_Postal
				,@Publ_Empresa_Cuit
	End

--Muevo el cursor al siguiente registro
Fetch next from cursor_maestro into	 @Publ_Cli_Dni
									,@Publ_Cli_Apellido
									,@Publ_Cli_Nombre
									,@Publ_Cli_Fecha_Nac
									,@Publ_Cli_Mail
									,@Publ_Cli_Dom_Calle
									,@Publ_Cli_Nro_Calle
									,@Publ_Cli_Piso
									,@Publ_Cli_Depto
									,@Publ_Cli_Cod_Postal
									,@Publ_Empresa_Razon_Social
									,@Publ_Empresa_Cuit
									,@Publ_Empresa_Fecha_Creacion
									,@Publ_Empresa_Mail
									,@Publ_Empresa_Dom_Calle
									,@Publ_Empresa_Nro_Calle
									,@Publ_Empresa_Piso
									,@Publ_Empresa_Depto
									,@Publ_Empresa_Cod_Postal
									,@Publicacion_Cod
									,@Publicacion_Descripcion
									,@Publicacion_Stock
									,@Publicacion_Fecha
									,@Publicacion_Fecha_Venc
									,@Publicacion_Precio
									,@Publicacion_Tipo
									,@Publicacion_Visibilidad_Cod
									,@Publicacion_Visibilidad_Desc
									,@Publicacion_Visibilidad_Precio
									,@Publicacion_Visibilidad_Porcentaje
									,@Publicacion_Estado
									,@Publicacion_Rubro_Descripcion
									,@Cli_Dni
									,@Cli_Apellido
									,@Cli_Nombre
									,@Cli_Fecha_Nac
									,@Cli_Mail
									,@Cli_Dom_Calle
									,@Cli_Nro_Calle
									,@Cli_Piso
									,@Cli_Depto
									,@Cli_Cod_Postal
									,@Compra_Fecha
									,@Compra_Cantidad
									,@Oferta_Fecha
									,@Oferta_Monto
									,@Calificacion_Codigo
									,@Calificacion_Cant_Estrellas
									,@Calificacion_Descripcion
									,@Item_Factura_Monto
									,@Item_Factura_Cantidad
									,@Factura_Nro
									,@Factura_Fecha
									,@Factura_Total
									,@Forma_Pago_Desc

End

Close cursor_maestro
Deallocate cursor_maestro