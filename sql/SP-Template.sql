-----------------------------------------------------------
-- Autor: Nombre o Usuario
-- Fecha: 12/17/2011
-- Descripcion: ----
-- @ParameterName: Agregar explicacion de parametros complejos.
-----------------------------------------------------------
--Autor: Nombre o Usuario
--Fecha: 07/10/2012
--Descripcion: Se describe una modificacion que sufrio el SP en el tiempo.
-----------------------------------------------------------
CREATE PROCEDURE [dbo].[SENSP_ActualizarCliente]  --<Prefijo>SP_accionObjeto
	@ParametroUno VARCHAR(18),
	@ParametroDos NVARCHAR(30),
	@ParametroN BIT = D0
AS	
	SET NOCOUNT ON  -- Apagar el envio de metadatos.
	
	-- Variables para control de transaccion.
	DECLARE @ErrorNumber INT, @ErrorSeverity INT, @ErrorState INT, @CustomError INT
	DECLARE @Message VARCHAR(200)
	DECLARE @InicieTransaccion BIT

	-- Realizar todas las operaciones de lectura posibles y precalculos que 
	-- no sean parte o que puedan realizarse fuera de la transaccion.
	
	
	SET @InicieTransaccion = 0 -- Control de transacciones.
	IF @@TRANCOUNT = 0 BEGIN
		SET @InicieTransaccion = 1
		SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRANSACTION		
	END			
	
	BEGIN TRY -- Control de excepciones
		-- Aca el codigo de la transaccion.

		IF @InicieTransaccion = 1 BEGIN
			COMMIT
		END		
	END TRY
	BEGIN CATCH
		SET @ErrorNumber = ERROR_NUMBER()
		SET @ErrorSeverity = ERROR_SEVERITY()
		SET @ErrorState = ERROR_STATE()
		SET @Message = ERROR_MESSAGE()
		
		IF @InicieTransaccion = 1 BEGIN
			ROLLBACK
		END
		RAISERROR('%s - Error Number: %i', 
			@ErrorSeverity, @ErrorState, @Message, @CustomError)
	END CATCH	
	
RETURN 0