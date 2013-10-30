
SET NUMERIC_ROUNDABORT OFF;
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT,
    QUOTED_IDENTIFIER, ANSI_NULLS ON;

IF OBJECT_ID ('VistaLogros', 'view') IS NOT NULL
DROP VIEW VistaLogros ;
GO
CREATE VIEW VistaLogros
WITH SCHEMABINDING
AS
	SELECT U.idUsuario, U.Nombre AS Nombre, U.Apellido1 AS Apellido1, U.Apellido2 AS Apellido2,
		L.Descripcion AS Logro, LU.fechaObtencion AS Fecha, COUNT_BIG(*) AS temp 
	FROM Usuario AS U
	INNER JOIN LogrosPorUsuario AS LU 
	ON U.idUsuario = LU.fk_idUsuario
	INNER JOIN Logros AS L 
	ON LU.fk_idLogro = L.idLogro
	GROUP BY Fecha, idUsuario;
GO
CREATE UNIQUE CLUSTERED INDEX IDX_view 
    ON VistaLogros (idUsuario);
GO