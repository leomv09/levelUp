
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


-- -------------------------------------------------------------------------------------------
-- Consulta XML
-- -------------------------------------------------------------------------------------------
-- Se tiene que repetir los inner join porque se usa "UNION ALL", entonces
-- cada bloque debe contener la misma cantidad de info.
SELECT 1 AS TAG,
	   NULL AS PARENT,
	   U.Nombre AS [Nombre!1!Nombre],
	   NULL AS [Logro!2!],
	   NULL AS [Departamento!3!]
FROM Usuario AS U
INNER JOIN LogrosPorUsuario AS LU ON
	U.idUsuario = LU.fk_idUsuario
INNER JOIN Logros AS L ON
	LU.fk_idLogro = L.idLogro
INNER JOIN LogrosPorDepartamento AS LD ON
	L.idLogro = LD.fk_idLogro
INNER JOIN Departamento AS D ON 
	LD.fk_idDepartamento = D.idDepartamento
UNION ALL
SELECT 2 AS TAG,
	   1 AS PARENT,
	   U.Nombre,
	   L.Descripcion,
	   NULL
FROM Usuario AS U
INNER JOIN LogrosPorUsuario AS LU ON
	U.idUsuario = LU.fk_idUsuario
INNER JOIN Logros AS L ON
	LU.fk_idLogro = L.idLogro
INNER JOIN LogrosPorDepartamento AS LD ON
	L.idLogro = LD.fk_idLogro
INNER JOIN Departamento AS D ON 
	LD.fk_idDepartamento = D.idDepartamento
UNION ALL
SELECT 3 AS TAG,
	   1 AS PARENT,
	   U.Nombre,
	   L.Descripcion,
	   D.Nombre
FROM Usuario AS U
INNER JOIN LogrosPorUsuario AS LU ON
	U.idUsuario = LU.fk_idUsuario
INNER JOIN Logros AS L ON
	LU.fk_idLogro = L.idLogro
INNER JOIN LogrosPorDepartamento AS LD ON
	L.idLogro = LD.fk_idLogro
INNER JOIN Departamento AS D ON 
	LD.fk_idDepartamento = D.idDepartamento
ORDER BY [Nombre!1!Nombre], [Logro!2!], [Departamento!3!]
FOR XML EXPLICIT;

-- -------------------------------------------------------------------------------------------
-- Creacion del CSV
-- -------------------------------------------------------------------------------------------
-- Los primeros 3 parrafos son configuracion

EXECUTE SP_CONFIGURE 'show advanced options', 1
RECONFIGURE WITH OVERRIDE
GO

EXECUTE SP_CONFIGURE 'xp_cmdshell', '1'
RECONFIGURE WITH OVERRIDE
GO

EXECUTE SP_CONFIGURE 'show advanced options', 0
RECONFIGURE WITH OVERRIDE
GO
declare @sql nvarchar(4000)

select @sql = 'bcp "SELECT p.Nombre Provincia,Pa.Nombre Pais  FROM LevelUp.dbo.Pais Pa INNER JOIN LevelUp.dbo.Provincia p ON Pa.idPais=p.fk_idPais;" queryout D:\file.csv -c -t, -T -S'+ @@servername
exec xp_cmdshell @sql