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


