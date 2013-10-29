
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


-- ---------------------------------------------------------------------
-- Prodedimiento que inserta en una tabla tomando los datos desde un XML
-- ---------------------------------------------------------------------

CREATE TABLE dbo.LogrosUsuarios(
	Nombre VARCHAR(50),
	Logro VARCHAR(100),
	Departamento VARCHAR(50)
);
GO
CREATE PROCEDURE dbo.ReadXML
	@XML XML
AS
BEGIN
	INSERT INTO LogrosUsuarios(Nombre, Logro, Departamento)
	SELECT Nmbre = U.COL.value('@Nombre','VARCHAR(50)'),
		   Logro = U.COL.value('@Logro', 'VARCHAR(100)'),
		   Departamento = U.COL.value('@Departamento', 'VARCHAR(50)')
	FROM @XML.nodes('/Nombre') AS U(COL)
END
GO

-- ----------------------------------------------------------------------------------------
-- Prodedimiento que inserta en una tabla tomando los datos desde un Table-Valued Parameter
-- ----------------------------------------------------------------------------------------

CREATE TYPE UsuarioLogros AS TABLE
(	Nombre VARCHAR(50), 
	Logro VARCHAR(100), 
	Departamento VARCHAR(50)
);
GO

CREATE PROCEDURE dbo.TVP_ReadXML
	@UsersInfo UsuarioLogros READONLY
AS
BEGIN 	
	SELECT NOCOUNT ON;
	INSERT INTO LogrosUsuarios
	SELECT * FROM @UsersInfo
END
GO

DECLARE @XMLFILE XML
SELECT @XMLFILE = SRC
FROM OPENROWSET(BULK 'C:\Users\Leo\Documents\levelUp\Usuarios.xml', SINGLE_BLOB) AS NewXML(SRC)
DECLARE @UsersInfo2 UsuarioLogros
INSERT INTO UsersInfo2(Nombre, Logro, Departamento)
	SELECT Nmbre = U.COL.value('@Nombre','VARCHAR(50)'),
		   Logro = U.COL.value('@Logro', 'VARCHAR(100)'),
		   Departamento = U.COL.value('@Departamento', 'VARCHAR(50)')
	FROM @XMLFILE.nodes('/Nombre') AS U(COL);
GO
EXEC TVP_ReadXML @NuevasDirecciones;

-- ---------------------------------------------------------------------
-- Consulta que soluciona problema de SET INTERSECTION.
-- Interseca los datos entre permisos por usuario y permisos por grupo.
-- Retorna los idPermiso que se repiten en ambas tablas.
-- ---------------------------------------------------------------------

SELECT DISTINCT T.idPermiso FROM 
(SELECT PU.fk_idPermiso AS idPermiso FROM PermisosPorUsuario AS PU
INNER JOIN Permisos AS P ON PU.fk_idPermiso = P.idPermiso
INNER JOIN PermisosPorGrupo AS PG ON P.idPermiso = PG.fk_idPermiso
INNER JOIN GruposDeUsuarios AS GU ON PG.fk_idGrupo = GU.idGrupoDeUsuarios
) AS T


-- ------------------------------------------------------------------------------------------------------------------------
-- Consulta que soluciona problema de SET DIFFERENCE.
-- Le resta los datos que están en la intersección de Permisos por usuarios y permisos por grupos a permisos por usuarios.
-- Retorna los idPermiso que solamente están Permisos por usuarios.
-- ------------------------------------------------------------------------------------------------------------------------

SELECT PU.fk_idPermiso AS idPermiso FROM
PermisosPorUsuario AS PU
 WHERE PU.fk_idPermiso NOT IN
(SELECT PG.fk_idPermiso AS idPermiso FROM PermisosPorGrupo AS PG
INNER JOIN Permisos AS P ON PU.fk_idPermiso = P.idPermiso
INNER JOIN PermisosPorUsuario AS PU ON P.idPermiso = PU.fk_idPermiso
INNER JOIN GruposDeUsuarios AS GU ON PG.fk_idGrupo = GU.idGrupoDeUsuarios
) 