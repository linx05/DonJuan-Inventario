﻿--
-- Script was generated by Devart dbForge Studio for SQL Server, Version 5.4.275.0
-- Product home page: http://devart.com/dbforge/sql/studio
-- Script date 05/16/2017 8:36:24 AM
-- Server version: 12.00.0304
-- Client version: 
--



--
-- Create table [dbo].[PUESTO]
--
PRINT (N'Create table [dbo].[PUESTO]')
GO
CREATE TABLE dbo.PUESTO (
  PUESTO_ID int NOT NULL,
  TIPO_PUESTO varchar(30) NULL,
  SUELDO_BASE money NULL,
  PRIMARY KEY CLUSTERED (PUESTO_ID)
)
GO

--
-- Create table [dbo].[PROVEEDOR]
--
PRINT (N'Create table [dbo].[PROVEEDOR]')
GO
CREATE TABLE dbo.PROVEEDOR (
  PROVEEDOR_ID int NOT NULL,
  NOMBRE varchar(30) NULL,
  DIRECCION varchar(50) NULL,
  TELEFONO varchar(200) NULL,
  RFC varchar(12) NULL,
  EMAIL varchar(50) NULL,
  PRIMARY KEY CLUSTERED (PROVEEDOR_ID)
)
GO

--
-- Create table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
CREATE TABLE dbo.PRODUCTO_MOVIMIENTO (
  PRODUCTO_MOVIMIENTO_ID int IDENTITY,
  PRODUCTO_ID int NULL,
  PROVEEDOR_ID int NULL,
  COMPRA_ID int NULL,
  PEDIDO_ID int NULL,
  CANTIDAD int NULL,
  TIPO varchar(30) NULL,
  PRIMARY KEY CLUSTERED (PRODUCTO_MOVIMIENTO_ID)
)
GO

--
-- Create table [dbo].[PRODUCTO]
--
PRINT (N'Create table [dbo].[PRODUCTO]')
GO
CREATE TABLE dbo.PRODUCTO (
  PRODUCTO_ID int NOT NULL,
  CATEGORIA_ID int NOT NULL,
  PROVEEDOR_ID int NULL,
  NOMBRE varchar(30) NULL,
  PRECIO money NULL,
  COSTO money NULL,
  UNIDAD varchar(30) NULL,
  MARCA varchar(30) NULL,
  PRIMARY KEY CLUSTERED (PRODUCTO_ID)
)
GO

--
-- Create table [dbo].[PEDIDO]
--
PRINT (N'Create table [dbo].[PEDIDO]')
GO
CREATE TABLE dbo.PEDIDO (
  PEDIDO_ID int IDENTITY,
  ESTADO varchar(50) NULL,
  FECHA date NULL,
  PRIMARY KEY CLUSTERED (PEDIDO_ID)
)
GO

--
-- Create table [dbo].[EMPLEADO]
--
PRINT (N'Create table [dbo].[EMPLEADO]')
GO
CREATE TABLE dbo.EMPLEADO (
  EMPLEADO_ID int NOT NULL,
  PUESTO_ID int NOT NULL,
  NOMBRE varchar(30) NULL,
  RFC varchar(12) NULL,
  DIRECCION varchar(50) NULL,
  TELEFONO varchar(30) NULL,
  PRIMARY KEY CLUSTERED (EMPLEADO_ID)
)
GO

--
-- Create table [dbo].[COMPRA]
--
PRINT (N'Create table [dbo].[COMPRA]')
GO
CREATE TABLE dbo.COMPRA (
  COMPRA_ID int NOT NULL,
  PROVEEDOR_ID int NOT NULL,
  SUBTOTAL money NULL,
  TOTAL money NULL,
  ESTADO varchar(30) NULL,
  FECHA date NULL,
  PRIMARY KEY CLUSTERED (COMPRA_ID)
)
GO

--
-- Create table [dbo].[CLIENTE]
--
PRINT (N'Create table [dbo].[CLIENTE]')
GO
CREATE TABLE dbo.CLIENTE (
  NOMBRE varchar(30) NULL,
  TELEFONO varbinary(max) NULL,
  EMAIL varchar(50) NULL,
  ESTILISTA bit NULL,
  RFC varchar(12) NULL,
  DIRECCION varchar(50) NULL,
  CODIGO_POSTAL int NULL,
  CIUDAD varchar(30) NULL,
  ESTADO varchar(30) NULL,
  CLIENTE_ID int IDENTITY
)
GO

--
-- Create table [dbo].[CATEGORIA]
--
PRINT (N'Create table [dbo].[CATEGORIA]')
GO
CREATE TABLE dbo.CATEGORIA (
  NOMBRE varchar(50) NULL,
  CATEGORIA_ID int IDENTITY,
  CONSTRAINT PK_CATEGORIA_CATEGORIA_ID PRIMARY KEY CLUSTERED (CATEGORIA_ID)
)
GO

--
-- Create table [dbo].[VENTA_PRODUCTO]
--
PRINT (N'Create table [dbo].[VENTA_PRODUCTO]')
GO
CREATE TABLE dbo.VENTA_PRODUCTO (
  VENTA_PRODUCTO_ID int IDENTITY,
  VENTA_ID int NOT NULL,
  CANTIDAD int NOT NULL,
  PRODUCTO_ID int NOT NULL,
  PRECIO_ACTUAL money NULL,
  PRIMARY KEY CLUSTERED (VENTA_PRODUCTO_ID)
)
GO

--
-- Create table [dbo].[VENTA]
--
PRINT (N'Create table [dbo].[VENTA]')
GO
CREATE TABLE dbo.VENTA (
  VENTA_ID int IDENTITY,
  EMPLEADO_ID int NOT NULL,
  TOTAL money NULL,
  FECHA date NULL,
  DESCUENTO bit NULL,
  PRIMARY KEY CLUSTERED (VENTA_ID)
)
GO

--
-- Create table [dbo].[STOCK]
--
PRINT (N'Create table [dbo].[STOCK]')
GO
CREATE TABLE dbo.STOCK (
  STOCK_ID int NOT NULL,
  PRODUCTO_ID int NOT NULL,
  CANTIDAD int NOT NULL,
  PRIMARY KEY CLUSTERED (STOCK_ID)
)
GO

--
-- Create table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]
--
PRINT (N'Create table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]')
GO
CREATE TABLE dbo.PEDIDO_RECIBIDO_PRODUCTO (
  PEDIDO_REC_PRODUCTO_ID int IDENTITY,
  PEDIDO_REC_ID int NOT NULL,
  PRODUCTO_ID int NOT NULL,
  CANTIDAD int NOT NULL,
  PRIMARY KEY CLUSTERED (PEDIDO_REC_PRODUCTO_ID)
)
GO

--
-- Create table [dbo].[PEDIDO_RECIBIDO]
--
PRINT (N'Create table [dbo].[PEDIDO_RECIBIDO]')
GO
CREATE TABLE dbo.PEDIDO_RECIBIDO (
  PEDIDO_REC_ID int IDENTITY,
  PEDIDO_ID int NOT NULL,
  FECHA date NULL,
  PRIMARY KEY CLUSTERED (PEDIDO_REC_ID)
)
GO

--
-- Create table [dbo].[NOMINA]
--
PRINT (N'Create table [dbo].[NOMINA]')
GO
CREATE TABLE dbo.NOMINA (
  NOMINA_ID int NOT NULL,
  EMPLEADO_ID int NOT NULL,
  SUELDO_TOTAL money NULL,
  BONO money NULL,
  PRIMARY KEY CLUSTERED (NOMINA_ID)
)
GO

--
-- Create table [dbo].[INVENTARIO]
--
PRINT (N'Create table [dbo].[INVENTARIO]')
GO
CREATE TABLE dbo.INVENTARIO (
  INVENTARIO_ID int NOT NULL,
  PRODUCTO_ID int NOT NULL,
  CANTIDAD int NOT NULL,
  PRIMARY KEY CLUSTERED (INVENTARIO_ID)
)
GO

--
-- Create table [dbo].[FACTURACION]
--
PRINT (N'Create table [dbo].[FACTURACION]')
GO
CREATE TABLE dbo.FACTURACION (
  FACTURACION_ID int IDENTITY,
  VENTA_ID int NOT NULL,
  CLIENTE_ID int NOT NULL,
  PRIMARY KEY CLUSTERED (FACTURACION_ID)
)
GO

--
-- Create table [dbo].[ASISTENCIA]
--
PRINT (N'Create table [dbo].[ASISTENCIA]')
GO
CREATE TABLE dbo.ASISTENCIA (
  ASISTENCIA_ID int NOT NULL,
  EMPLEADO_ID int NOT NULL,
  FECHA date NULL,
  HORA_ENTRADA date NULL,
  HORA_SALIDA date NULL,
  PRIMARY KEY CLUSTERED (ASISTENCIA_ID)
)
GO
-- 
-- Dumping data for table ASISTENCIA
--
-- Table BD_DONJUAN.dbo.ASISTENCIA does not contain any data (it is empty)
-- 
-- Dumping data for table CATEGORIA
--
SET IDENTITY_INSERT dbo.CATEGORIA ON
GO
INSERT dbo.CATEGORIA(NOMBRE, CATEGORIA_ID) VALUES (N'Pinta Labios', 1)
INSERT dbo.CATEGORIA(NOMBRE, CATEGORIA_ID) VALUES (N'Categoria Prueba', 2)
INSERT dbo.CATEGORIA(NOMBRE, CATEGORIA_ID) VALUES (N'Categoria 2 Prueba', 3)
INSERT dbo.CATEGORIA(NOMBRE, CATEGORIA_ID) VALUES (N'Categoria 3', 4)
GO
SET IDENTITY_INSERT dbo.CATEGORIA OFF
GO
-- 
-- Dumping data for table CLIENTE
--
SET IDENTITY_INSERT dbo.CLIENTE ON
GO
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Alex Ortega', 0x03F2F5F5, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 1)
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Alex', 0x00001858, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 2)
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Jordan', 0x0000007B, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 3)
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Alex Ortega', 0x00000000, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 4)
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Alex Ortega', 0x00000000, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 5)
INSERT dbo.CLIENTE(NOMBRE, TELEFONO, EMAIL, ESTILISTA, RFC, DIRECCION, CODIGO_POSTAL, CIUDAD, ESTADO, CLIENTE_ID) VALUES (N'Alex Ortega', 0x00000000, N'', CONVERT(bit, 'False'), N'', N'', 0, N'', N'', 6)
GO
SET IDENTITY_INSERT dbo.CLIENTE OFF
GO
-- 
-- Dumping data for table COMPRA
--
INSERT dbo.COMPRA VALUES (1, 1, 100.0000, 200.0000, N'Bien', '2017-05-01')
GO
-- 
-- Dumping data for table EMPLEADO
--
INSERT dbo.EMPLEADO VALUES (0, 2, N'Jorge', N'8888', N'La cabañita', N'666777')
GO
-- 
-- Dumping data for table FACTURACION
--
SET IDENTITY_INSERT dbo.FACTURACION ON
GO
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (3, 22, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (4, 23, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (5, 24, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (6, 25, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (7, 26, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (8, 27, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (9, 28, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (10, 29, 1)
INSERT dbo.FACTURACION(FACTURACION_ID, VENTA_ID, CLIENTE_ID) VALUES (11, 32, 1)
GO
SET IDENTITY_INSERT dbo.FACTURACION OFF
GO
-- 
-- Dumping data for table INVENTARIO
--
INSERT dbo.INVENTARIO VALUES (0, 3, 2)
GO
-- 
-- Dumping data for table NOMINA
--
-- Table BD_DONJUAN.dbo.NOMINA does not contain any data (it is empty)
-- 
-- Dumping data for table PEDIDO
--
SET IDENTITY_INSERT dbo.PEDIDO ON
GO
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (1, N'Entregado', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (2, N'Entregado', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (3, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (4, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (5, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (6, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (7, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (8, N'Entregado', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (9, N'Activo', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (10, N'Entregado', '2017-05-03')
INSERT dbo.PEDIDO(PEDIDO_ID, ESTADO, FECHA) VALUES (11, N'Entregado', '2017-05-03')
GO
SET IDENTITY_INSERT dbo.PEDIDO OFF
GO
-- 
-- Dumping data for table PEDIDO_RECIBIDO
--
-- Table BD_DONJUAN.dbo.PEDIDO_RECIBIDO does not contain any data (it is empty)
-- 
-- Dumping data for table PEDIDO_RECIBIDO_PRODUCTO
--
-- Table BD_DONJUAN.dbo.PEDIDO_RECIBIDO_PRODUCTO does not contain any data (it is empty)
-- 
-- Dumping data for table PRODUCTO
--
INSERT dbo.PRODUCTO VALUES (1, 1, 1, N'Pinta Rosa', 50.0000, 100.0000, N'Mililitros', N'Xiomara')
INSERT dbo.PRODUCTO VALUES (2, 1, 1, N'Gel', 20.0000, 40.0000, N'Piezas', N'Gel')
INSERT dbo.PRODUCTO VALUES (3, 1, 1, N'Ejemplo', 14.0000, 20.0000, N'Kilogramos', N'Gel')
GO
-- 
-- Dumping data for table PRODUCTO_MOVIMIENTO
--
SET IDENTITY_INSERT dbo.PRODUCTO_MOVIMIENTO ON
GO
INSERT dbo.PRODUCTO_MOVIMIENTO(PRODUCTO_MOVIMIENTO_ID, PRODUCTO_ID, PROVEEDOR_ID, COMPRA_ID, PEDIDO_ID, CANTIDAD, TIPO) VALUES (3, 1, 1, 1, 9, 1, N'Pedido')
INSERT dbo.PRODUCTO_MOVIMIENTO(PRODUCTO_MOVIMIENTO_ID, PRODUCTO_ID, PROVEEDOR_ID, COMPRA_ID, PEDIDO_ID, CANTIDAD, TIPO) VALUES (4, 1, 1, 1, 10, 12, N'Pedido')
INSERT dbo.PRODUCTO_MOVIMIENTO(PRODUCTO_MOVIMIENTO_ID, PRODUCTO_ID, PROVEEDOR_ID, COMPRA_ID, PEDIDO_ID, CANTIDAD, TIPO) VALUES (5, 1, 1, 1, 11, 44, N'Pedido')
INSERT dbo.PRODUCTO_MOVIMIENTO(PRODUCTO_MOVIMIENTO_ID, PRODUCTO_ID, PROVEEDOR_ID, COMPRA_ID, PEDIDO_ID, CANTIDAD, TIPO) VALUES (6, 1, 1, 1, 11, 25, N'Pedido')
GO
SET IDENTITY_INSERT dbo.PRODUCTO_MOVIMIENTO OFF
GO
-- 
-- Dumping data for table PROVEEDOR
--
INSERT dbo.PROVEEDOR VALUES (1, N'Xiomara', N'Salazar #33', N'3321133', N'JJFFEE34', N'XioContacto@Xiomara.com')
GO
-- 
-- Dumping data for table PUESTO
--
INSERT dbo.PUESTO VALUES (2, N'Vendedor', 3000.0000)
GO
-- 
-- Dumping data for table STOCK
--
-- Table BD_DONJUAN.dbo.STOCK does not contain any data (it is empty)
-- 
-- Dumping data for table VENTA
--
SET IDENTITY_INSERT dbo.VENTA ON
GO
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (1, 0, 100.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (2, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (3, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (4, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (5, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (6, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (7, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (8, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (9, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (10, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (11, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (12, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (13, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (14, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (15, 0, 100.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (16, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (17, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (18, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (19, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (20, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (21, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (22, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (23, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (24, 0, 150.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (25, 0, 650.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (26, 0, 650.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (27, 0, 600.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (28, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (29, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (30, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (31, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (32, 0, 650.0000, '2017-05-03', CONVERT(bit, 'False'))
INSERT dbo.VENTA(VENTA_ID, EMPLEADO_ID, TOTAL, FECHA, DESCUENTO) VALUES (33, 0, 50.0000, '2017-05-03', CONVERT(bit, 'False'))
GO
SET IDENTITY_INSERT dbo.VENTA OFF
GO
-- 
-- Dumping data for table VENTA_PRODUCTO
--
SET IDENTITY_INSERT dbo.VENTA_PRODUCTO ON
GO
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (3, 18, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (4, 19, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (5, 20, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (6, 21, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (7, 22, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (8, 23, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (9, 24, 3, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (10, 25, 13, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (11, 26, 13, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (12, 27, 12, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (13, 28, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (14, 29, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (15, 30, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (16, 31, 1, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (17, 32, 13, 1, 50.0000)
INSERT dbo.VENTA_PRODUCTO(VENTA_PRODUCTO_ID, VENTA_ID, CANTIDAD, PRODUCTO_ID, PRECIO_ACTUAL) VALUES (18, 33, 1, 1, 50.0000)
GO
SET IDENTITY_INSERT dbo.VENTA_PRODUCTO OFF
GO

--
-- Create foreign key on table [dbo].[PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO]')
GO
ALTER TABLE dbo.PRODUCTO
  ADD FOREIGN KEY (PROVEEDOR_ID) REFERENCES dbo.PROVEEDOR (PROVEEDOR_ID) ON DELETE CASCADE
GO

--
-- Create foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]
--
PRINT (N'Create foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]')
GO
ALTER TABLE dbo.PRODUCTO
  ADD CONSTRAINT FK_PRODUCTO_CATEGORIA FOREIGN KEY (CATEGORIA_ID) REFERENCES dbo.CATEGORIA (CATEGORIA_ID)
GO

--
-- Create foreign key on table [dbo].[STOCK]
--
PRINT (N'Create foreign key on table [dbo].[STOCK]')
GO
ALTER TABLE dbo.STOCK
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[INVENTARIO]
--
PRINT (N'Create foreign key on table [dbo].[INVENTARIO]')
GO
ALTER TABLE dbo.INVENTARIO
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[EMPLEADO]
--
PRINT (N'Create foreign key on table [dbo].[EMPLEADO]')
GO
ALTER TABLE dbo.EMPLEADO
  ADD FOREIGN KEY (PUESTO_ID) REFERENCES dbo.PUESTO (PUESTO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[VENTA]
--
PRINT (N'Create foreign key on table [dbo].[VENTA]')
GO
ALTER TABLE dbo.VENTA
  ADD FOREIGN KEY (EMPLEADO_ID) REFERENCES dbo.EMPLEADO (EMPLEADO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[VENTA_PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[VENTA_PRODUCTO]')
GO
ALTER TABLE dbo.VENTA_PRODUCTO
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[VENTA_PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[VENTA_PRODUCTO]')
GO
ALTER TABLE dbo.VENTA_PRODUCTO
  ADD FOREIGN KEY (VENTA_ID) REFERENCES dbo.VENTA (VENTA_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[FACTURACION]
--
PRINT (N'Create foreign key on table [dbo].[FACTURACION]')
GO
ALTER TABLE dbo.FACTURACION
  ADD FOREIGN KEY (VENTA_ID) REFERENCES dbo.VENTA (VENTA_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[NOMINA]
--
PRINT (N'Create foreign key on table [dbo].[NOMINA]')
GO
ALTER TABLE dbo.NOMINA
  ADD FOREIGN KEY (EMPLEADO_ID) REFERENCES dbo.EMPLEADO (EMPLEADO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[ASISTENCIA]
--
PRINT (N'Create foreign key on table [dbo].[ASISTENCIA]')
GO
ALTER TABLE dbo.ASISTENCIA
  ADD FOREIGN KEY (EMPLEADO_ID) REFERENCES dbo.EMPLEADO (EMPLEADO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[COMPRA]
--
PRINT (N'Create foreign key on table [dbo].[COMPRA]')
GO
ALTER TABLE dbo.COMPRA
  ADD FOREIGN KEY (PROVEEDOR_ID) REFERENCES dbo.PROVEEDOR (PROVEEDOR_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
ALTER TABLE dbo.PRODUCTO_MOVIMIENTO
  ADD FOREIGN KEY (COMPRA_ID) REFERENCES dbo.COMPRA (COMPRA_ID)
GO

--
-- Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
ALTER TABLE dbo.PRODUCTO_MOVIMIENTO
  ADD FOREIGN KEY (PEDIDO_ID) REFERENCES dbo.PEDIDO (PEDIDO_ID)
GO

--
-- Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
ALTER TABLE dbo.PRODUCTO_MOVIMIENTO
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID)
GO

--
-- Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
ALTER TABLE dbo.PRODUCTO_MOVIMIENTO
  ADD FOREIGN KEY (PROVEEDOR_ID) REFERENCES dbo.PROVEEDOR (PROVEEDOR_ID)
GO

--
-- Create foreign key on table [dbo].[PEDIDO_RECIBIDO]
--
PRINT (N'Create foreign key on table [dbo].[PEDIDO_RECIBIDO]')
GO
ALTER TABLE dbo.PEDIDO_RECIBIDO
  ADD FOREIGN KEY (PEDIDO_ID) REFERENCES dbo.PEDIDO (PEDIDO_ID) ON DELETE CASCADE
GO

--
-- Create foreign key on table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]')
GO
ALTER TABLE dbo.PEDIDO_RECIBIDO_PRODUCTO
  ADD FOREIGN KEY (PEDIDO_REC_ID) REFERENCES dbo.PEDIDO_RECIBIDO (PEDIDO_REC_ID) ON DELETE CASCADE
GO
SET NOEXEC OFF
GO