USE [LevelUp];
GO

-- =============================================
-- Author:    Jose Garcia
-- Description: Vista de los logros.
-- =============================================
CREATE VIEW [dbo].[VW_Logros]
AS
SELECT L.idLogro AS ID, L.Nombre, ISNULL(L.Descripcion, '') AS Descripcion, L.FechaInicio, 
ISNULL(L.FechaFinal, GETDATE()) AS FechaFinal, ISNULL(L.NumMaximo, 2147483647) AS NumMaximo,
EsGlobal FROM Logros AS L
INNER JOIN EstadoLogro AS EL ON EL.idEstadoLogro = L.fk_idEstadoLogro
WHERE EL.Estado = 'Activo';
GO

-- =============================================
-- Author:    Jose Garcia
-- Description: Vista de los logros por departamento.
-- =============================================
CREATE VIEW [dbo].[VW_LogrosPorDepartamento]
AS
SELECT L.idLogro AS ID, LPD.fk_idDepartamento AS idDepartamento, L.Nombre, 
ISNULL(L.Descripcion, '') AS Descripcion, L.FechaInicio, ISNULL(L.FechaFinal, GETDATE()) AS FechaFinal, 
ISNULL(L.NumMaximo, 2147483647) AS NumMaximo FROM Logros AS L
INNER JOIN LogrosPorDepartamento AS LPD ON LPD.fk_idLogro = L.idLogro
INNER JOIN EstadoLogro AS EL ON EL.idEstadoLogro = L.fk_idEstadoLogro
WHERE EL.Estado = 'Activo';
GO

-- =============================================
-- Author:    Jose Garcia
-- Description: Vista de los premios.
-- =============================================
CREATE VIEW [dbo].[VW_Premios]
AS
SELECT P.idPremio AS ID, P.Titulo AS Nombre, ISNULL(P.Descripcion, '') AS Descripcion, 
ISNULL(P.Foto, '') AS Foto, ISNULL(P.Cantidad, 0) AS Cantidad, ISNULL(P.Monto, 0.0) AS Monto,
TP.Tipo, M.Nombre AS Moneda, P.EsGlobal FROM Premio AS P
INNER JOIN TipoPremio AS TP ON TP.idTipoPremio = P.fk_idTipoPremio
INNER JOIN Moneda AS M ON M.idMoneda = P.fk_idMoneda
INNER JOIN EstadoPremio AS EP ON EP.idEstadoPremio = P.fk_idEstadoPremio;
WHERE EP.Estado = 'Activo';
GO

-- =============================================
-- Author:    Jose Garcia
-- Description: Vista de los premios por departamento.
-- =============================================
CREATE VIEW [dbo].[VW_PremiosPorDepartamento]
AS
SELECT P.idPremio AS ID, PPD.fk_idDepartamento AS idDepartamento, P.Titulo AS Nombre, 
ISNULL(P.Descripcion, '') AS Descripcion, ISNULL(P.Foto, '') AS Foto, 
ISNULL(P.Cantidad, 0) AS Cantidad, ISNULL(P.Monto, 0.0) AS Monto, TP.Tipo, M.Nombre AS Moneda 
FROM Premio AS P
INNER JOIN TipoPremio AS TP ON TP.idTipoPremio = P.fk_idTipoPremio
INNER JOIN Moneda AS M ON M.idMoneda = P.fk_idMoneda
INNER JOIN PremiosPorDepartamento AS PPD ON PPD.fk_idPremio = P.idPremio
INNER JOIN EstadoPremio AS EP ON EP.idEstadoPremio = P.fk_idEstadoPremio;
WHERE EP.Estado = 'Activo';
GO