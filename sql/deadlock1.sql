
-- ------------------------------------------------------------------------------
-- Para crear el DeadLock
-- Se utilizan las tablas: Pais y Provincia.
-- Pasos:
-- 1. Correr el deadlock1 con las 2 últimas líneas comentadas.
-- 2. Correr el deadlock2.
-- 3. Volver a correr el deadlock1 pero con las 2 últimas líneas sin comentar.
-- ------------------------------------------------------------------------------
USE LevelUp
BEGIN TRAN
	UPDATE Provincia SET Nombre = 'Milan'
		where idProvincia = 1
	--SELECT * FROM Pais
		--where idPais = 1

-- ----------------------------------------------------------------------------------------
-- Lo que sucede:
-- Se ejecuta la primera transaccion donde se actualiza el nomnbre de la provincia.
-- En la segunda transacción se actualzia el nombre de un pais y se va intentar actualizar
-- la misma provincia que se actualizó en la primera transacción, pero no va a poder aún
-- poque la primera transacción no ha llegado a commit.
-- Al volver a ejecutar la primera transaccion, pero con las 2 lineas sin comentar, el motor 
-- se da cuenta que hay más de dos transacciones intentando leer/escribir sobre un mismo dato
-- por lo tanto cancela la transacción
-- ----------------------------------------------------------------------------------------