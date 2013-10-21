
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


-- 4 Joins sobre tablas.....

SELECT CONCAT(Nombre,' ',Apellido1,' ',CONVERT(VARCHAR(1),Apellido2),'.') AS Nombre, 
	Dir.Señal1 AS Residencia,
	est.Estado AS Estado,
	gen.Genero Genero 
FROM Usuario Us
INNER JOIN DireccionesPorUsuario dirXus ON dirXus.fk_idUsuario=Us.idUsuario
INNER JOIN Direccion Dir ON dirXus.fk_idDireccion=Dir.idDireccion
INNER JOIN EstadoUsuario est ON us.fk_idEstadoUsuario=est.idEstadoUsuario
INNER JOIN Genero gen ON gen.idGenero=us.fk_idGenero
GROUP BY Estado,Nombre,Apellido1,Apellido2,Señal1,Genero
HAVING Nombre NOT IN
    (SELECT Nombre
     FROM Usuario
     WHERE Nombre = 'Administrador')
ORDER BY NEWID();
-- Falta el case
-- -----------------------
