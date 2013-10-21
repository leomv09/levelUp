
-- Columna Dinámica
DECLARE @query AS NVARCHAR(MAX)

SET @query = 'SELECT LU.fk_idUsuario AS idTrabajador, U.Nombre AS Nombre, U.Apellido1 AS Apellido, "Nivel" = 
				CASE
					WHEN COUNT(LU.fk_idLogro) <= 5 THEN 1
					WHEN COUNT(LU.fk_idLogro) BETWEEN 6 AND 10 THEN 2
					WHEN COUNT(LU.fk_idLogro) BETWEEN 11 AND 20 THEN 3
					WHEN COUNT(LU.fk_idLogro) > 20 THEN 4
				END
			FROM LogrosPorUsuario AS LU
			INNER JOIN Usuario AS U ON LU.fk_idUsuario = U.idUsuario
			GROUP BY LU.fk_idUsuario, U.Nombre, U.Apellido1'
EXECUTE(@query)

-- -----------------------