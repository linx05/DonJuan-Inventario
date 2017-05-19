﻿--
-- Script was generated by Devart dbForge Studio for SQL Server, Version 5.4.275.0
-- Product home page: http://devart.com/dbforge/sql/studio
-- Script date 05/18/2017 7:24:51 PM
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
-- Create foreign key on table [dbo].[EMPLEADO]
--
PRINT (N'Create foreign key on table [dbo].[EMPLEADO]')
GO
ALTER TABLE dbo.EMPLEADO
  ADD FOREIGN KEY (PUESTO_ID) REFERENCES dbo.PUESTO (PUESTO_ID) ON DELETE CASCADE
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
-- Create foreign key on table [dbo].[VENTA]
--
PRINT (N'Create foreign key on table [dbo].[VENTA]')
GO
ALTER TABLE dbo.VENTA
  ADD FOREIGN KEY (EMPLEADO_ID) REFERENCES dbo.EMPLEADO (EMPLEADO_ID) ON DELETE CASCADE
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
-- Create foreign key on table [dbo].[FACTURACION]
--
PRINT (N'Create foreign key on table [dbo].[FACTURACION]')
GO
ALTER TABLE dbo.FACTURACION
  ADD FOREIGN KEY (VENTA_ID) REFERENCES dbo.VENTA (VENTA_ID) ON DELETE CASCADE
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
-- Create foreign key on table [dbo].[NOMINA]
--
PRINT (N'Create foreign key on table [dbo].[NOMINA]')
GO
ALTER TABLE dbo.NOMINA
  ADD FOREIGN KEY (EMPLEADO_ID) REFERENCES dbo.EMPLEADO (EMPLEADO_ID) ON DELETE CASCADE
GO

--
-- Create table [dbo].[ASISTENCIA]
--
PRINT (N'Create table [dbo].[ASISTENCIA]')
GO
CREATE TABLE dbo.ASISTENCIA (
  ASISTENCIA_ID int IDENTITY,
  EMPLEADO_ID int NOT NULL,
  FECHA date NULL,
  HORA_ENTRADA date NULL,
  HORA_SALIDA date NULL,
  PRIMARY KEY CLUSTERED (ASISTENCIA_ID)
)
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
-- Create table [dbo].[PROVEEDOR]
--
PRINT (N'Create table [dbo].[PROVEEDOR]')
GO
CREATE TABLE dbo.PROVEEDOR (
  PROVEEDOR_ID int IDENTITY,
  NOMBRE varchar(30) NULL,
  DIRECCION varchar(50) NULL,
  TELEFONO varchar(200) NULL,
  RFC varchar(200) NULL,
  EMAIL varchar(50) NULL,
  PRIMARY KEY CLUSTERED (PROVEEDOR_ID)
)
GO

--
-- Create table [dbo].[COMPRA]
--
PRINT (N'Create table [dbo].[COMPRA]')
GO
CREATE TABLE dbo.COMPRA (
  COMPRA_ID int IDENTITY,
  PROVEEDOR_ID int NOT NULL,
  SUBTOTAL money NULL,
  TOTAL money NULL,
  ESTADO varchar(30) NULL,
  FECHA date NULL,
  PRIMARY KEY CLUSTERED (COMPRA_ID)
)
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
-- Create foreign key on table [dbo].[PEDIDO_RECIBIDO]
--
PRINT (N'Create foreign key on table [dbo].[PEDIDO_RECIBIDO]')
GO
ALTER TABLE dbo.PEDIDO_RECIBIDO
  ADD FOREIGN KEY (PEDIDO_ID) REFERENCES dbo.PEDIDO (PEDIDO_ID) ON DELETE CASCADE
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
-- Create foreign key on table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[PEDIDO_RECIBIDO_PRODUCTO]')
GO
ALTER TABLE dbo.PEDIDO_RECIBIDO_PRODUCTO
  ADD FOREIGN KEY (PEDIDO_REC_ID) REFERENCES dbo.PEDIDO_RECIBIDO (PEDIDO_REC_ID) ON DELETE CASCADE
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
-- Create table [dbo].[PRODUCTO]
--
PRINT (N'Create table [dbo].[PRODUCTO]')
GO
CREATE TABLE dbo.PRODUCTO (
  PRODUCTO_ID int IDENTITY,
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
-- Create foreign key on table [dbo].[PRODUCTO]
--
PRINT (N'Create foreign key on table [dbo].[PRODUCTO]')
GO
ALTER TABLE dbo.PRODUCTO WITH NOCHECK
  ADD FOREIGN KEY (PROVEEDOR_ID) REFERENCES dbo.PROVEEDOR (PROVEEDOR_ID) ON DELETE CASCADE
GO

--
-- Create foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]
--
PRINT (N'Create foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]')
GO
ALTER TABLE dbo.PRODUCTO WITH NOCHECK
  ADD CONSTRAINT FK_PRODUCTO_CATEGORIA FOREIGN KEY (CATEGORIA_ID) REFERENCES dbo.CATEGORIA (CATEGORIA_ID)
GO

--
-- Disable foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]
--
PRINT (N'Disable foreign key [FK_PRODUCTO_CATEGORIA] on table [dbo].[PRODUCTO]')
GO
ALTER TABLE dbo.PRODUCTO
  NOCHECK CONSTRAINT FK_PRODUCTO_CATEGORIA
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
-- Create foreign key on table [dbo].[STOCK]
--
PRINT (N'Create foreign key on table [dbo].[STOCK]')
GO
ALTER TABLE dbo.STOCK
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID) ON DELETE CASCADE
GO

--
-- Create table [dbo].[PRODUCTO_MOVIMIENTO]
--
PRINT (N'Create table [dbo].[PRODUCTO_MOVIMIENTO]')
GO
CREATE TABLE dbo.PRODUCTO_MOVIMIENTO (
  PRODUCTO_MOVIMIENTO_ID int IDENTITY,
  PRODUCTO_ID int NOT NULL,
  PROVEEDOR_ID int NULL,
  COMPRA_ID int NULL,
  PEDIDO_ID int NULL,
  CANTIDAD int NULL,
  TIPO varchar(30) NULL,
  PRIMARY KEY CLUSTERED (PRODUCTO_MOVIMIENTO_ID)
)
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
-- Create table [dbo].[INVENTARIO]
--
PRINT (N'Create table [dbo].[INVENTARIO]')
GO
CREATE TABLE dbo.INVENTARIO (
  INVENTARIO_ID int IDENTITY,
  PRODUCTO_ID int NOT NULL,
  CANTIDAD int NOT NULL,
  PRIMARY KEY CLUSTERED (INVENTARIO_ID)
)
GO

--
-- Create foreign key on table [dbo].[INVENTARIO]
--
PRINT (N'Create foreign key on table [dbo].[INVENTARIO]')
GO
ALTER TABLE dbo.INVENTARIO
  ADD FOREIGN KEY (PRODUCTO_ID) REFERENCES dbo.PRODUCTO (PRODUCTO_ID) ON DELETE CASCADE
GO

SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

--
-- Create procedure [dbo].[sp_MSforeach_worker]
--
GO
PRINT (N'Create procedure [dbo].[sp_MSforeach_worker]')
GO



CREATE proc dbo.sp_MSforeach_worker
	@command1 nvarchar(2000), @replacechar nchar(1) = N'?', @command2 nvarchar(2000) = null, @command3 nvarchar(2000) = null, @worker_type int =1
as

	create table #qtemp (	/* Temp command storage */
		qnum				int				NOT NULL,
		qchar				nvarchar(2000)	COLLATE database_default NULL
	)

	set nocount on
	declare @name nvarchar(517), @namelen int, @q1 nvarchar(2000), @q2 nvarchar(2000)
   declare @q3 nvarchar(2000), @q4 nvarchar(2000), @q5 nvarchar(2000)
	declare @q6 nvarchar(2000), @q7 nvarchar(2000), @q8 nvarchar(2000), @q9 nvarchar(2000), @q10 nvarchar(2000)
	declare @cmd nvarchar(2000), @replacecharindex int, @useq tinyint, @usecmd tinyint, @nextcmd nvarchar(2000)
   declare @namesave nvarchar(517), @nametmp nvarchar(517), @nametmp2 nvarchar(258)

	declare @local_cursor cursor
	if @worker_type=1	
		set @local_cursor = hCForEachDatabase
	else
		set @local_cursor = hCForEachTable
	
	open @local_cursor
	fetch @local_cursor into @name

	while (@@fetch_status >= 0) begin

      select @namesave = @name
		select @useq = 1, @usecmd = 1, @cmd = @command1, @namelen = datalength(@name)
		while (@cmd is not null) begin		/* Generate @q* for exec() */
			select @replacecharindex = charindex(@replacechar, @cmd)
			while (@replacecharindex <> 0) begin

            /* 7.0, if name contains ' character, and the name has been single quoted in command, double all of them in dbname */
            /* if the name has not been single quoted in command, do not doulbe them */
            /* if name contains ] character, and the name has been [] quoted in command, double all of ] in dbname */
            select @name = @namesave
            select @namelen = datalength(@name)
            declare @tempindex int
            if (substring(@cmd, @replacecharindex - 1, 1) = N'''') begin
               /* if ? is inside of '', we need to double all the ' in name */
               select @name = REPLACE(@name, N'''', N'''''')
            end else if (substring(@cmd, @replacecharindex - 1, 1) = N'[') begin
               /* if ? is inside of [], we need to double all the ] in name */
               select @name = REPLACE(@name, N']', N']]')
            end else if ((@name LIKE N'%].%]') and (substring(@name, 1, 1) = N'[')) begin
               /* ? is NOT inside of [] nor '', and the name is in [owner].[name] format, handle it */
               /* !!! work around, when using LIKE to find string pattern, can't use '[', since LIKE operator is treating '[' as a wide char */
               select @tempindex = charindex(N'].[', @name)
               select @nametmp  = substring(@name, 2, @tempindex-2 )
               select @nametmp2 = substring(@name, @tempindex+3, len(@name)-@tempindex-3 )
               select @nametmp  = REPLACE(@nametmp, N']', N']]')
               select @nametmp2 = REPLACE(@nametmp2, N']', N']]')
               select @name = N'[' + @nametmp + N'].[' + @nametmp2 + ']'
            end else if ((@name LIKE N'%]') and (substring(@name, 1, 1) = N'[')) begin
               /* ? is NOT inside of [] nor '', and the name is in [name] format, handle it */
               /* j.i.c., since we should not fall into this case */
               /* !!! work around, when using LIKE to find string pattern, can't use '[', since LIKE operator is treating '[' as a wide char */
               select @nametmp = substring(@name, 2, len(@name)-2 )
               select @nametmp = REPLACE(@nametmp, N']', N']]')
               select @name = N'[' + @nametmp + N']'
            end
            /* Get the new length */
            select @namelen = datalength(@name)

            /* start normal process */
				if (datalength(@cmd) + @namelen - 1 > 2000) begin
					/* Overflow; put preceding stuff into the temp table */
					if (@useq > 9) begin
						close @local_cursor
						if @worker_type=1	
							deallocate hCForEachDatabase
						else
							deallocate hCForEachTable
						return 1
					end
					if (@replacecharindex < @namelen) begin
						/* If this happened close to beginning, make sure expansion has enough room. */
						/* In this case no trailing space can occur as the row ends with @name. */
						select @nextcmd = substring(@cmd, 1, @replacecharindex)
						select @cmd = substring(@cmd, @replacecharindex + 1, 2000)
						select @nextcmd = stuff(@nextcmd, @replacecharindex, 1, @name)
						select @replacecharindex = charindex(@replacechar, @cmd)
						insert #qtemp values (@useq, @nextcmd)
						select @useq = @useq + 1
						continue
					end
					/* Move the string down and stuff() in-place. */
					/* Because varchar columns trim trailing spaces, we may need to prepend one to the following string. */
					/* In this case, the char to be replaced is moved over by one. */
					insert #qtemp values (@useq, substring(@cmd, 1, @replacecharindex - 1))
					if (substring(@cmd, @replacecharindex - 1, 1) = N' ') begin
						select @cmd = N' ' + substring(@cmd, @replacecharindex, 2000)
						select @replacecharindex = 2
					end else begin
						select @cmd = substring(@cmd, @replacecharindex, 2000)
						select @replacecharindex = 1
					end
					select @useq = @useq + 1
				end
				select @cmd = stuff(@cmd, @replacecharindex, 1, @name)
				select @replacecharindex = charindex(@replacechar, @cmd)
			end

			/* Done replacing for current @cmd.  Get the next one and see if it's to be appended. */
			select @usecmd = @usecmd + 1
			select @nextcmd = case (@usecmd) when 2 then @command2 when 3 then @command3 else null end
			if (@nextcmd is not null and substring(@nextcmd, 1, 2) = N'++') begin
				insert #qtemp values (@useq, @cmd)
				select @cmd = substring(@nextcmd, 3, 2000), @useq = @useq + 1
				continue
			end

			/* Now exec() the generated @q*, and see if we had more commands to exec().  Continue even if errors. */
			/* Null them first as the no-result-set case won't. */
			select @q1 = null, @q2 = null, @q3 = null, @q4 = null, @q5 = null, @q6 = null, @q7 = null, @q8 = null, @q9 = null, @q10 = null
			select @q1 = qchar from #qtemp where qnum = 1
			select @q2 = qchar from #qtemp where qnum = 2
			select @q3 = qchar from #qtemp where qnum = 3
			select @q4 = qchar from #qtemp where qnum = 4
			select @q5 = qchar from #qtemp where qnum = 5
			select @q6 = qchar from #qtemp where qnum = 6
			select @q7 = qchar from #qtemp where qnum = 7
			select @q8 = qchar from #qtemp where qnum = 8
			select @q9 = qchar from #qtemp where qnum = 9
			select @q10 = qchar from #qtemp where qnum = 10
			truncate table #qtemp
			exec (@q1 + @q2 + @q3 + @q4 + @q5 + @q6 + @q7 + @q8 + @q9 + @q10 + @cmd)
			select @cmd = @nextcmd, @useq = 1
		end
    fetch @local_cursor into @name
	end /* while FETCH_SUCCESS */
	close @local_cursor
	if @worker_type=1	
		deallocate hCForEachDatabase
	else
		deallocate hCForEachTable
		
	return 0

GO

--
-- Create procedure [dbo].[sp_MSforeachtable]
--
GO
PRINT (N'Create procedure [dbo].[sp_MSforeachtable]')
GO

CREATE proc dbo.sp_MSforeachtable
	@command1 nvarchar(2000), @replacechar nchar(1) = N'?', @command2 nvarchar(2000) = null,
  @command3 nvarchar(2000) = null, @whereand nvarchar(2000) = null,
	@precommand nvarchar(2000) = null, @postcommand nvarchar(2000) = null
AS
	declare @mscat nvarchar(12)
	select @mscat = ltrim(str(convert(int, 0x0002)))
	if (@precommand is not null)
		exec(@precommand)
   exec(N'declare hCForEachTable cursor global for select ''['' + REPLACE(schema_name(syso.schema_id), N'']'', N'']]'') + '']'' + ''.'' + ''['' + REPLACE(object_name(o.id), N'']'', N'']]'') + '']'' from dbo.sysobjects o join sys.all_objects syso on o.id = syso.object_id '
         + N' where OBJECTPROPERTY(o.id, N''IsUserTable'') = 1 ' + N' and o.category & ' + @mscat + N' = 0 '
         + @whereand)
	declare @retval int
	select @retval = @@error
	if (@retval = 0)
		exec @retval = dbo.sp_MSforeach_worker @command1, @replacechar, @command2, @command3, 0
	if (@retval = 0 and @postcommand is not null)
		exec(@postcommand)
	return @retval
GO
SET NOEXEC OFF
GO