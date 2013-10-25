USE [LevelUp];
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene el nombre de todos los departamentos.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartments]
AS
BEGIN
	SELECT D.idDepartamento AS ID, D.Nombre AS Departamento FROM Departamento AS D;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todas las reglas de un asociadas a un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartmentRules]
	@DepartmentID int
AS
BEGIN
	SELECT R.idRegla AS ID, R.Nombre, ISNULL(R.Descripcion, '') AS Descripcion, R.FechaInicio, 
	ISNULL(R.FechaFinal, GETDATE()) AS FechaFinal FROM Regla AS R
	INNER JOIN ReglasPorDepartamento AS RPD
	ON RPD.fk_idRegla = R.idRegla AND RPD.fk_idDepartamento = @DepartmentID
	INNER JOIN EstadoRegla AS ER ON R.fk_idEstadoRegla = ER.idEstadoRegla
	WHERE ER.Estado = 'Activo';
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene los logros asociados a un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartmentAchievements]
	@DepartmentID int
AS
BEGIN
	SELECT ID, Nombre, Descripcion, FechaInicio, FechaFinal, NumMaximo
	FROM VW_Logros WHERE EsGlobal = 1
	UNION
	SELECT ID, Nombre, Descripcion, FechaInicio, FechaFinal, NumMaximo
	FROM VW_LogrosPorDepartamento WHERE idDepartamento = @DepartmentID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los premios de un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartmentAwards]
	@DepartmentID int
AS
BEGIN
	SELECT ID, Nombre, Descripcion, Foto, Cantidad, Monto, Tipo, Moneda
	FROM VW_Premios WHERE EsGlobal = 1
	UNION
	SELECT ID, Nombre, Descripcion, Foto, Cantidad, Monto, Tipo, Moneda
	FROM VW_PremiosPorDepartamento WHERE idDepartamento = @DepartmentID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los logros de una regla.
-- =============================================
CREATE PROCEDURE [dbo].[GetRuleAchievements]
	@RuleID int
AS
BEGIN
	SELECT L.idLogro AS ID, L.Nombre, ISNULL(L.Descripcion, '') AS Descripcion, L.FechaInicio, 
	ISNULL(L.FechaFinal, GETDATE()) AS FechaFinal, ISNULL(L.NumMaximo, 2147483647) AS NumMaximo,
	LPR.Cantidad FROM Logros AS L
	INNER JOIN LogrosPorRegla AS LPR
	ON LPR.fk_idRegla = @RuleID AND LPR.fk_Logro = L.idLogro
	INNER JOIN EstadoLogro AS EL ON EL.idEstadoLogro = L.fk_idEstadoLogro
	WHERE EL.Estado = 'Activo';
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los premios de una regla.
-- =============================================
CREATE PROCEDURE [dbo].[GetRuleAwards]
	@RuleID int
AS
BEGIN
SELECT P.idPremio AS ID, P.Titulo AS Nombre, ISNULL(P.Descripcion, '') AS Descripcion, 
	ISNULL(P.Foto, '') AS Foto, ISNULL(P.Cantidad, 0) AS Cantidad, ISNULL(P.Monto, 0.0) AS Monto,
	TP.Tipo, M.Nombre AS Moneda FROM Premio AS P
	INNER JOIN TipoPremio AS TP ON TP.idTipoPremio = P.fk_idTipoPremio
	INNER JOIN Moneda AS M ON M.idMoneda = P.fk_idMoneda
	INNER JOIN PremiosPorRegla AS PPR
	ON PPR.fk_idRegla = @RuleID AND PPR.fk_idPremio = P.idPremio
	INNER JOIN EstadoPremio AS EP ON EP.idEstadoPremio = P.fk_idEstadoPremio
	WHERE EP.Estado = 'Activo';
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Agrega una regla a un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[AddRuleToDepartment]
	@RuleID int,
	@DepartmentID int
AS
BEGIN
	INSERT INTO ReglasPorDepartamento (fk_idRegla, fk_idDepartamento) VALUES
	(@RuleID, @DepartmentID);
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Elimina una regla de un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[DeleteRuleFromDepartment]
	@RuleID int,
	@DepartmentID int
AS
BEGIN
	DELETE FROM ReglasPorDepartamento
	WHERE fk_idRegla = @RuleID AND fk_idDepartamento = @DepartmentID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Agrega un premio a una regla.
-- =============================================
CREATE PROCEDURE [dbo].[AddAwardToRule]
	@RuleID int, 
	@AwardID int
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM PremiosPorRegla WHERE fk_idRegla = @RuleID AND fk_idPremio = @AwardID)
		INSERT INTO PremiosPorRegla (fk_idRegla, fk_idPremio) VALUES
		(@RuleID, @AwardID);
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Agrega un logro a una regla.
-- =============================================
CREATE PROCEDURE [dbo].[AddAchievementToRule]
	@RuleID int, 
	@AchievementID int,
	@CreatorID int,
	@Amount int
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM LogrosPorRegla WHERE fk_idRegla = @RuleID AND fk_Logro = @AchievementID)
		INSERT INTO LogrosPorRegla (fk_idRegla, fk_Logro, fk_idCreador, Cantidad, FechaCreacion) VALUES
		(@RuleID, @AchievementID, @CreatorID, @Amount, GETDATE());
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Agrega una nueva regla.
CREATE PROCEDURE [dbo].[AddRule]
	@Name varchar(100),
	@Description varchar(500),
	@StartDate date,
	@EndDate date,
	@CreatorID int
AS
BEGIN
	INSERT INTO Regla (Nombre, Descripcion, FechaInicio, FechaFinal, FechaCreacion, fk_idCreador, fk_idEstadoRegla)
	VALUES (@Name, @Description, @StartDate, @EndDate, GETDATE(), @CreatorID, 1);
	SELECT SCOPE_IDENTITY() AS RuleID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Actualiza una regla.
-- =============================================
CREATE PROCEDURE [dbo].[UpdateRule]
	@RuleID int, 
	@Name varchar(100),
	@Description varchar(500),
	@StartDate date,
	@EndDate date
AS
BEGIN
	UPDATE Regla
	SET Nombre = @Name, Descripcion = @Description, FechaInicio = @StartDate, FechaFinal = @EndDate
	WHERE idRegla = @RuleID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene el nombre de usuario de todos los usuarios.
-- =============================================
CREATE PROCEDURE [dbo].[GetAllUsernames]
AS
BEGIN
	SELECT U.Username From Usuario AS U;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Busca un usuario por su username.
-- =============================================
CREATE PROCEDURE [dbo].[GetUserByUsername]
	@Username varchar(70)
AS
BEGIN
	SELECT U.idUsuario AS ID, U.Nombre, U.Apellido1, ISNULL(U.Apellido2, '') AS Apellido2,
	ISNULL(U.Foto, '') AS Foto, U.Username, G.Genero FROM Usuario AS U
	INNER JOIN Genero AS G ON G.idGenero = U.fk_idGenero
	INNER JOIN EstadoUsuario AS EU ON EU.idEstadoUsuario = U.fk_idEstadoUsuario
	WHERE U.Username = @Username AND EU.Estado = 'Activo';
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Comprueba si cierta contraseña pertenece a un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[CheckUserAuthentication]
	@Username varchar(70),
	@Password varchar(100)
AS
BEGIN
	SELECT CAST(CASE
            WHEN U.Contraseña = @Password THEN 1
            ELSE 0
           END AS BIT) AS IsValid
	FROM Usuario AS U
	WHERE U.Username = @Username;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene la informacion sobre cierta moneda.
-- =============================================
CREATE PROCEDURE [dbo].[GetCurrencyByName]
	@Name varchar(50)
AS
BEGIN
	SELECT M.idMoneda AS ID, M.Nombre, M.Codigo, M.Simbolo FROM Moneda AS M
	WHERE M.Nombre = @Name;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene los tipos de premio.
-- =============================================
CREATE PROCEDURE [dbo].[GetAwardTypes]
AS
BEGIN
	SELECT TP.Tipo FROM TipoPremio AS TP;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todas las monedas del sistema.
-- =============================================
CREATE PROCEDURE [dbo].[GetAllCurrency]
AS
BEGIN
	SELECT M.idMoneda AS ID, M.Nombre, M.Codigo, M.Simbolo FROM Moneda AS M;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene los permisos de un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[GetUserPermissions]
	@Username varchar(70)
AS
BEGIN
	SELECT P.Codigo, P.Descripcion FROM Permisos AS P
	INNER JOIN PermisosPorGrupo AS PPG ON PPG.fk_idPermiso = P.idPermiso
	INNER JOIN GruposDeUsuarios AS GDU ON GDU.idGrupoDeUsuarios = PPG.fk_idGrupo
	INNER JOIN UsuariosPorGrupo AS UPG ON UPG.fk_idGrupo = GDU.idGrupoDeUsuarios
	INNER JOIN Usuario AS U ON U.idUsuario = UPG.fk_idUsuario
	WHERE U.Username = @Username
	UNION
	SELECT P.Codigo, P.Descripcion FROM Permisos AS P
	INNER JOIN PermisosPorUsuario AS PPU ON PPU.fk_idPermiso = P.idPermiso
	INNER JOIN Usuario AS U ON U.idUsuario = PPU.fk_idUsuario
	WHERE U.Username = @Username;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene los logros asociados a un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[GetUserAchievements]
	@Username varchar(70)
AS
BEGIN
	SELECT L.idLogro AS ID, L.Nombre, ISNULL(L.Descripcion, '') AS Descripcion, L.FechaInicio, 
	ISNULL(L.FechaFinal, GETDATE()) AS FechaFinal, ISNULL(L.NumMaximo, 2147483647) AS NumMaximo,
	ISNULL(LPU.Detalles, '') AS Detalle FROM Logros AS L
	INNER JOIN LogrosPorUsuario AS LPU ON LPU.fk_idLogro = L.idLogro
	INNER JOIN EstadoLogro AS EL ON EL.idEstadoLogro = L.fk_idEstadoLogro
	INNER JOIN Usuario AS U ON U.idUsuario = LPU.fk_idUsuario AND U.Username = @Username
	WHERE EL.Estado = 'Activo';
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Asocia un logro a un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[AddAchievementToUser]
	@AchievementID int,
	@Username varchar(70),
	@CreatorUsername varchar(70),
	@Details varchar(200)
AS
BEGIN
	DECLARE @CreatorID int = (SELECT U.idUsuario FROM Usuario AS U WHERE U.Username = @CreatorUsername);
	DECLARE @UserID int = (SELECT U.idUsuario FROM Usuario AS U WHERE U.Username = @Username);
	INSERT INTO LogrosPorUsuario (fk_idLogro, fk_idCreador, fk_idUsuario, Detalles, FechaObtencion)
	VALUES (@AchievementID, @CreatorID, @UserID, @Details, GETDATE())
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Elimina un logro asociado a un usuario.
-- =============================================
CREATE PROCEDURE [dbo].[RemoveAchievementFromUser]
	@AchievementID int,
	@Username varchar(70)
AS
BEGIN
	DECLARE @UserID int;
	SELECT @UserID = U.idUsuario FROM Usuario AS U WHERE U.Username = @Username;
	DELETE FROM LogrosPorUsuario
	WHERE fk_idLogro = @AchievementID AND fk_idUsuario = @UserID;
END;
GO