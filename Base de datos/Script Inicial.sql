Use GD1C2016
Go

/*	****************************************	CREACION DEL SCHEMA	*********************************************** */
IF NOT EXISTS (SELECT [schema_id] FROM [sys].[schemas] WHERE [name] = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO')
BEGIN
	EXECUTE ('CREATE SCHEMA gd_GESTORES_DEL_AIRE_ACONDICIONADO AUTHORIZATION gd;');
END
GO
/* ******************************************************************************************************************/

/******************************************** BORRO TABLAS SI YA EXISTEN  ********************************************/

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_estado_usuario ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_estado_usuario
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_usuario ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_cliente ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_empresa ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_rol ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_rol
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_funcion ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_funcion
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla funciones_por_rol ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.funciones_por_rol
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla roles_por_usuario ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.roles_por_usarios
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla log_ingresos ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.log_ingresos
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_calificacion ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_calificacion
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_estado_publi ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_estado_publi
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_visibilidad ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_visibilidad
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_tipo_publi ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_tipo_publi
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_rubro ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_rubro
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_publicacion ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_compra ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_subasta ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_subasta
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla lk_forma_pago ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_forma_pago
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_factura ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'gd_GESTORES_DEL_AIRE_ACONDICIONADO' AND  TABLE_NAME = 'lk_estado_usuario')
BEGIN
	Print 'La tabla ft_item ya existe, SE BORRARA';
	DROP TABLE gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_item
END
/*************************************************************************************************************************************************************/


/* ******************************************* CREACION DE TABLAS ********************************************************************************************/
BEGIN TRANSACTION CREACION_TABLAS

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_estado_usuario	(	 id_estado_usuario int identity(1,1)
																		,desc_estado nvarchar(100)
																		,primary key (id_estado_usuario)
																	)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_usuario	(	 id_usuario int identity(1,1)
																,desc_username nvarchar(250)
																,desc_password nvarchar(250)
																,id_estado int
																,primary key (id_usuario)
																,foreign key (id_estado) references lk_estado_usuario(id_estado_usuario)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_cliente	(	 id_cliente int identity(1,1)
																,id_usuario int
																,desc_Dni numeric(18,0)
																,desc_Apeliido nvarchar(255)
																,desc_Nombre nvarchar(255)
																,desc_Fecha_Nac datetime
																,desc_Mail nvarchar(255)
																,desc_Dom_Calle nvarchar(255)
																,desc_Nro_Calle numeric(18,0)
																,desc_Piso numeric(18,0)
																,desc_Depto nvarchar(50)
																,desc_Cod_Postal nvarchar(50)
																,primary key (id_cliente)	
																,foreign key (id_usuario) references ft_usuario(id_usuario)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_empresa	(	 id_empresa int identity(1,1)
																,id_usuario int
																,desc_Razon_Social nvarchar(255)
																,desc_Cuit nvarchar(50)
																,desc_Fecha_Creacion datetime
																,desc_Mail nvarchar(50)
																,desc_Dom_Calle nvarchar(100)
																,desc_Nro_Calle numeric(18,0)
																,desc_Piso numeric(18,0)
																,desc_Depto nvarchar(50)
																,desc_Cod_Postal nvarchar(50)
																,primary key (id_empresa)
																,foreign key (id_usuario) references ft_usuario(id_usuario)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_rol	(	 id_rol int
															,desc_rol nvarchar(50)
															,primary key (id_rol)
														)
																
Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_funcion	(	 id_funcion int identity(1,1)
																,desc_funcion nvarchar(200)
																,primary key (id_funcion)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.funciones_por_rol	(	 id_relacion int identity
																		,id_rol int
																		,id_funcion int
																		,primary key (id_relacion)
																		,foreign key (id_rol) references lk_rol(id_rol)
																		,foreign key (id_funcion) references lk_funcion(id_funcion)
																	) 
	
Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.roles_por_usarios	(	 id_relacion int identity(1,1)
																		,id_usuario int
																		,id_rol int
																		,primary key (id_relacion)
																		,foreign key (id_usuario) references ft_usuario(id_usuario)
																		,foreign key (id_rol) references lk_rol(id_rol)
																	)
																		
Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.log_ingresos	(	 id_log int identity(1,1)
																	,id_usuario int --En caso de corresponder
																	,desc_username nvarchar(250)
																	,desc_fecha_log datetime
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_calificacion	(	 id_calificacion int identity(1,1)
																	,desc_codigo numeric(18,0)
																	,desc_cantidad_estrellas numeric(18,0)
																	,descripcion nvarchar(255)
																	,id_usuario_origen int
																	,id_usuario_destino int
																	,primary key (id_calificacion)
																	,foreign key (id_usuario_origen) references ft_usuario(id_usuario)
																	,foreign key (id_usuario_origen) references ft_usuario(id_usuario)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_estado_publi	(	 id_estado_publi int identity(1,1)
																	,desc_estado nvarchar(100)
																	,primary key (id_estado_publi)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_visibilidad	(	 id_visibilidad int identity(1,1)
																	,desc_codigo numeric(18,0)
																	,desc_tipo nvarchar(255)
																	,desc_precio numeric(18,2)
																	,desc_porcentaje numeric(18,2)
																	,primary key (id_visibilidad)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_tipo_publi	(	 id_tipo_publi int identity(1,1)
																	,desc_tipo_public nvarchar(255)
																	,primary key (id_tipo_publi)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_rubro	(	 id_rubro int identity(1,1)
																,desc_rubro nvarchar(255)
																,primary key (id_rubro)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_publicacion	(	 id_publicacion int identity(1,1)
																	,desc_codigo numeric(18,0)
																	,desc_publicacion nvarchar(255)
																	,desc_stock numeric(18,0)
																	,desc_fecha_publi datetime
																	,desc_fecha_venc datetime
																	,desc_precio numeric(18,2)
																	,id_estado_publi int
																	,id_visibilidad int
																	,id_tipo_publi int
																	,id_rubro int
																	,primary key (id_publicacion)
																	,foreign key (id_estado_publi) references lk_estado_publi(id_estado_publi)
																	,foreign key (id_visibilidad) references lk_visibilidad(id_visibilidad)
																	,foreign key (id_tipo_publi) references lk_tipo_publi(id_tipo_publi)
																	,foreign key (id_rubro) references lk_rubro(id_rubro)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_compra	(	 id_compra int identity(1,1)
																,desc_fecha datetime
																,desc_cantidad numeric(18,0)
																,id_publicacion int
																,id_usuario int
																,primary key (id_compra)
																,foreign key (id_publicacion) references ft_publicacion(id_publicacion)
																,foreign key (id_usuario) references ft_usuario(id_usuario)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_subasta	(	 id_subasta int identity(1,1)
																,desc_fecha datetime
																,desc_monto numeric(18,2)
																,id_publicacion int
																,id_usuario int
																,primary key (id_subasta)
																,foreign key (id_publicacion) references ft_publicacion(id_publicacion)
																,foreign key (id_usuario) references ft_usuario(id_usuario)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.lk_forma_pago	(	 id_forma_pago int identity(1,1)
																	,desc_tipo_pago nvarchar(255)
																	,primary key (id_forma_pago)
																)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_factura	(	 id_factura int identity(1,1)
																,desc_factura_nro numeric(18,0)
																,desc_fecha datetime
																,desc_total numeric(18,2)
																,id_forma_pago int
																,id_usuario int
																,primary key (id_factura)
																,foreign key (id_forma_pago) references lk_forma_pago(id_forma_pago)
																,foreign key (id_usuario) references ft_usuario(id_usuario)
															)

Create Table gd_GESTORES_DEL_AIRE_ACONDICIONADO.ft_item	(	 id_item int identity(1,1)
															,desc_item_monto numeric(18,2)
															,desc_item_cant numeric(18,0)
															,id_factura int
															,primary key (id_item)
															,foreign key (id_factura) references ft_factura(id_factura)
														)

COMMIT TRANSACTION CREACION_TABLAS
/***********************************************************************************************************************************/


/* BORRA TODAS LAS TABLAS (LO DEJO POR SI ACASO) */
/*
 EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
 GO
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"
-- Ahora volver a habilitar la integridad referencial
 EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
 GO
*/