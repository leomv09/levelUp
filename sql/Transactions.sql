-----------------------------------------------------------
-- Autor: Leonardo
-- Fecha: 21/10/2013
-- Descripcion: Procedimiento que agrega un nuevo usuario al sistema.
-- @Nombre: Nombre del usuario a agregar.
-- @Apellido1: Primer apellido del usuario.
-- @Apellido2: Segundo apellido del usuario.
-- @Contraseña: Contraseña a usar para ingresar al sistema.
-- @Username: Nombre de usuario a utilizar para iniciar sesión en el sistema.
-- @Correo: Dirección de correo electrónico a registrar.
-- @Gnero: Genero del usuario.
-----------------------------------------------------------
-----------------------------------------------------------

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('CrearUsuario'))--Igual a DROP PROCEDURE IF EXISTS DE MYSQL
BEGIN
    DROP PROCEDURE [dbo].[CrearUsuario] 
END
GO

CREATE PROCEDURE [dbo].[CrearUsuario]  
	@Nombre VARCHAR(50),
	@Apellido1 VARCHAR(50),
	@Apellido2 VARCHAR(50),
	@Contraseña VARCHAR(200),
	@Username VARCHAR(70),
	@Correo VARCHAR(100),
	@Genero INT
AS	
	SET NOCOUNT ON  -- apagar el envio de metadatos
	
	-- Variables para control de transaccion
	DECLARE @ErrorNumber INT, @ErrorSeverity INT, @ErrorState INT, @CustomError INT
	DECLARE @Message VARCHAR(200)
	DECLARE @InicieTransaccion BIT

	-- Realizar todas las operaciones de lectura posibles y precalculos que 
	-- no sean parte o que puedan realizarse fuera de la transaccion
	
	
	SET @InicieTransaccion = 0 -- control de transacciones
	IF @@TRANCOUNT=0 BEGIN
		SET @InicieTransaccion = 1
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION		
	END			
	
	BEGIN TRY -- control de excepciones
		-- aca mi codigo de transaccion	
		DECLARE @idEstado INT, @idContacto INT, @idSeveridad INT, @idModulo INT, @idTipoEvento INT, @lastidUsuario INT 
		SELECT @idEstado = EU.idEstadoUsuario FROM EstadoUsuario AS EU
				WHERE EU.Estado = 'Activo'
		INSERT INTO Usuario(Nombre, Apellido1, Apellido2, Contraseña, fk_idEstadoUsuario, fk_idGenero, Username)
			VALUES (@Nombre, @Apellido1, ISNULL(@Apellido2, ' '), @Contraseña, @idEstadoUsuario, ISNULL(@Genero, 1), @Username)
		SET @lastidUsuario = SCOPE_IDENTITY()
		SELECT @idContacto = TC.idTipoContacto FROM TipoContacto AS TC  
				WHERE TC.Tipo = 'Correo Electrónico'
		SELECT @idSeveridad = S.idSeveridad FROM Severidad AS S
				WHERE S.Descripcion = 'Información'
		SELECT @idModulo = M.idModulo FROM Modulo AS M
				WHERE  M.Nombre = 'Aplicación de Administración PC'
		SELECT @idTipoEvento = TE.idTipoEvento
				WHERE TE.Tipo = 'Creación de Usuario'
		INSERT INTO ContactosPorUsuario(fk_idTipoContacto, fk_idUsuario, Valor)
			VALUES (@idContacto, @lastidUsuario, @Correo)
		INSERT INTO Evento(fk_idUsuario, fk_idSeveridad, fk_idModulo, fk_idTipoEvento, Descripcion)
			VALUES (@lastidUsuario, @idSeveridad, @idModulo, @idTipoEvento, 'Registro de Usuario')
		IF @InicieTransaccion=1 BEGIN
			COMMIT
		END		
	END TRY
	BEGIN CATCH
		SET @ErrorNumber = ERROR_NUMBER()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState = ERROR_STATE()
		SET @Message = ERROR_MESSAGE()
		
		IF @InicieTransaccion=1 BEGIN
			ROLLBACK
		END
		RAISERROR('%s - Error Number: %i', 
			@ErrorSeverity, @ErrorState, @Message, @CustomError)
	END CATCH	
	
RETURN 0


-----------------------------------------------------------
--Emmanuel
-- Fecha: 28/10/2013
-- Descripcion: Procedimiento anidado para agregar una direccion en el sistema.
--	El procedimiento [dbo].[guardarDireccion](o sea el de primer nivel) recibe los parámetros:
-- @nombrePais VARCHAR(70),
-- @nombreProvincia VARCHAR(70),
-- @nombreCiudad VARCHAR(100),
-- @Señal1 VARCHAR(200),
-- @Señal2 VARCHAR(200) = NULL,
-- @zipCode VARCHAR(50) = NULL,
-- @latitud VARCHAR(50) = NULL,
-- @longitud VARCHAR(50) = NULL
-- Registra cada campo en su respectiva tabla y al final guarda el evento en la bitácora
-- Ejemplo de llamado:
--		EXEC [dbo].[guardarDireccion] 'Costa Rica','Cartago','Turrialba', '100 sur del super del chino'
-- Note que los campos = NULL son predeterminados por lo que se pueden pasar o no.
-----------------------------------------------------------
-----------------------------------------------------------

/*Eliminación de los procedures en caso de que existan*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('guardarEnBitacora'))--Igual a DROP PROCEDURE IF EXISTS DE MYSQL
BEGIN
    DROP PROCEDURE [dbo].[guardarEnBitacora] 
END
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('guardarCiudad'))--Igual a DROP PROCEDURE IF EXISTS DE MYSQL
BEGIN
    DROP PROCEDURE [dbo].[guardarCiudad] 
END
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('guardarDireccion'))--Igual a DROP PROCEDURE IF EXISTS DE MYSQL
BEGIN
    DROP PROCEDURE [dbo].[guardarDireccion] 
END

/*Procedure para almacenar en bitácora el evento dado
Afecta tablas de tipoEvento y Evento
(**3ER NIVEL**)*/

GO
CREATE PROCEDURE [dbo].[guardarEnBitacora]  --INICIO DEL BLOQUE DEL PROCEDIMIENTO
	@NombreUsuario VARCHAR(50)
AS	
	SET NOCOUNT ON  -- apagar el envio de metadatos
	
	-- Variables para control de transaccion
	DECLARE @ErrorNumber INT, @ErrorSeverity INT, @ErrorState INT, @CustomError INT
	DECLARE @Message VARCHAR(200)
	DECLARE @InicieTransaccion BIT
	DECLARE @tipoEvento VARCHAR(200)

	-- Realizar todas las operaciones de lectura posibles y precalculos que 
	-- no sean parte o que puedan realizarse fuera de la transaccion
	
	
	SET @InicieTransaccion = 0 -- control de transacciones
	IF @@TRANCOUNT=0 BEGIN
		SET @InicieTransaccion = 1
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION		
	END			
	
	BEGIN TRY -- control de excepciones
		-- aca mi codigo de transaccion	
		DECLARE @idUsuario INT, @idContacto INT, @idSeveridad INT, @idModulo INT, @idTipoEvento INT, @lastidUsuario INT 
		SELECT @idUsuario = U.idUsuario FROM Usuario AS U
				WHERE U.Nombre = @NombreUsuario
		SELECT @idSeveridad = S.idSeveridad FROM Severidad AS S
				WHERE S.Descripcion = 'Información'
		SELECT @idModulo = M.idModulo FROM Modulo AS M
				WHERE  M.Nombre = 'Aplicación de Administración PC'
		SELECT @idTipoEvento = TE.idTipoEvento FROM TipoEvento AS TE
				WHERE TE.Tipo = 'Modificacion de Información de Usuario'
		INSERT INTO Evento(fk_idUsuario, fk_idSeveridad, fk_idModulo, fk_idTipoEvento, Descripcion)
			VALUES (@idUsuario, @idSeveridad, @idModulo, @idTipoEvento, 'Nueva dirección en la base de datos')
		IF @InicieTransaccion=1 BEGIN
			COMMIT
		END		
	END TRY
	BEGIN CATCH
		SET @ErrorNumber = ERROR_NUMBER()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState = ERROR_STATE()
		SET @Message = ERROR_MESSAGE()
		
		IF @InicieTransaccion=0 BEGIN
			ROLLBACK
		END
		RAISERROR('%s - Error Number: %i', 
			@ErrorSeverity, @ErrorState, @Message, @CustomError)
	END CATCH	
	
RETURN 0
GO

/*Procedure para crear una nueva direccion con una nueva ciudad
Afecta tablas de Direccion y Ciudad
(**2D0 NIVEL**)*/

CREATE PROCEDURE [dbo].[guardarCiudad]  --INICIO DEL BLOQUE DEL PROCEDIMIENTO
	@id_Provincia INT,
	@nombreCiudad VARCHAR(100),
	@Señal1 VARCHAR(200),
	@Señal2 VARCHAR(200) = NULL,
	@zipCode VARCHAR(50) = NULL,
	@latitud VARCHAR(50) = NULL,
	@longitud VARCHAR(50) = NULL
AS	
BEGIN
	SET NOCOUNT ON  -- apagar el envio de metadatos
	
	-- Variables para control de transaccion
	DECLARE @ErrorNumber INT, @ErrorSeverity INT, @ErrorState INT, @CustomError INT
	DECLARE @Message VARCHAR(200)
	DECLARE @InicieTransaccion BIT
	DECLARE @tipoEvento VARCHAR(200)

	DECLARE	@idCiudad INT

	-- Realizar todas las operaciones de lectura posibles y precalculos que 
	-- no sean parte o que puedan realizarse fuera de la transaccion
	
	
	SET @InicieTransaccion = 0 -- control de transacciones
	IF @@TRANCOUNT=0 BEGIN
		SET @InicieTransaccion = 1
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION		
	END			
	
	BEGIN TRY -- control de excepciones
		-- aca mi codigo de transaccion	

		SELECT @idCiudad=Ci.idCiudad FROM Ciudad AS Ci WHERE Ci.Nombre=@nombreCiudad

		INSERT INTO Direccion(fk_idCiudad,Señal1,Señal2,ZipCode,Latitud,Longitud) VALUES
		(@idCiudad,@Señal1,@Señal2,@zipCode,@latitud,@longitud)

		EXEC [dbo].[guardarEnBitacora] 'Administrador'

		IF @InicieTransaccion=1 BEGIN
			COMMIT
		END		
	END TRY
	BEGIN CATCH
		SET @ErrorNumber = ERROR_NUMBER()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState = ERROR_STATE()
		SET @Message = ERROR_MESSAGE()
		
		IF @InicieTransaccion=0 BEGIN
			ROLLBACK
		END
		RAISERROR('%s - Error Number: %i', 
			@ErrorSeverity, @ErrorState, @Message, @CustomError)
	END CATCH	
	
RETURN 0
END
GO

/*Procedure para Iniciar la transacción, guarda pais y una provincia de ese pais
Afecta tablas de Direccion y Ciudad
(**1ER NIVEL**) ó método para ejecutar*/
CREATE PROCEDURE [dbo].[guardarDireccion]  --INICIO DEL BLOQUE DEL PROCEDIMIENTO
	@nombrePais VARCHAR(70),
	@nombreProvincia VARCHAR(70),
	@nombreCiudad VARCHAR(100),
	@Señal1 VARCHAR(200),
	@Señal2 VARCHAR(200) = NULL,
	@zipCode VARCHAR(50) = NULL,
	@latitud VARCHAR(50) = NULL,
	@longitud VARCHAR(50) = NULL
AS
BEGIN
	SET NOCOUNT ON  -- apagar el envio de metadatos
	
	-- Variables para control de transaccion
	DECLARE @ErrorNumber INT, @ErrorSeverity INT, @ErrorState INT, @CustomError INT
	DECLARE @Message VARCHAR(200)
	DECLARE @InicieTransaccion BIT
	DECLARE @tipoEvento VARCHAR(200)

	DECLARE	@idPais INT
	DECLARE	@idProvincia INT

	-- Realizar todas las operaciones de lectura posibles y precalculos que 
	-- no sean parte o que puedan realizarse fuera de la transaccion
	
	
	SET @InicieTransaccion = 0 -- control de transacciones
	IF @@TRANCOUNT=0 BEGIN
		SET @InicieTransaccion = 1
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION		
	END			
	
	BEGIN TRY -- control de excepciones
		-- Codigo de transaccion	

		SELECT @idPais=Pa.idPais FROM Pais AS Pa WHERE Pa.Nombre=@nombrePais

		SELECT @idProvincia=Pro.idProvincia FROM Provincia AS Pro WHERE Pro.Nombre=@nombreProvincia

		EXEC [dbo].[guardarCiudad] @idProvincia,@nombreCiudad,@Señal1,@Señal2,@zipCode,@latitud,@longitud

		IF @InicieTransaccion=1 BEGIN
			COMMIT
		END		
	END TRY
	BEGIN CATCH
		SET @ErrorNumber = ERROR_NUMBER()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState = ERROR_STATE()
		SET @Message = ERROR_MESSAGE()
		
		IF @InicieTransaccion=0 BEGIN
			ROLLBACK
		END
		RAISERROR('%s - Error Number: %i', 
			@ErrorSeverity, @ErrorState, @Message, @CustomError)
	END CATCH	
	
RETURN 0
END
GO