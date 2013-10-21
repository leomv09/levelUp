USE [LevelUp]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los departamentos.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartments]
AS
BEGIN
	SELECT D.idDepartamento AS ID, D.Nombre AS Departamento FROM Departamento AS D;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los premios de una regla.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartmentAwards]
	@DepartmentID int
AS
BEGIN
	SELECT P.idPremio AS ID FROM Premio AS P
	INNER JOIN PremiosPorDepartamento AS PPD
	ON PPD.fk_idDepartamento = @DepartmentID AND PPD.fk_idPremio = P.idPremio;
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
	SELECT R.idRegla AS ID, R.Nombre, R.Descripcion, R.FechaInicio, R.FechaFinal
	FROM Regla AS R
	INNER JOIN ReglasPorDepartamento AS RPD 
	ON RPD.fk_idDepartamento = @DepartmentID AND RPD.fk_idRegla = R.idRegla;
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
	SELECT LPR.fk_Logro AS ID, LPR.Cantidad FROM Logros AS L
	INNER JOIN LogrosPorRegla AS LPR
	ON LPR.fk_idRegla = @RuleID AND LPR.fk_Logro = L.idLogro;
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
	SELECT P.idPremio AS ID FROM Premio AS P
	INNER JOIN PremiosPorRegla AS PPR
	ON PPR.fk_idRegla = @RuleID AND PPR.fk_idPremio = P.idPremio
END;

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
-- Description:	Obtiene un logro.
-- =============================================
CREATE PROCEDURE [dbo].[GetAchievementByID]
	@AchievementID int
AS
BEGIN
	SELECT L.idLogro AS ID, L.Nombre, L.Descripcion, L.FechaInicio, L.FechaFinal,
	L.NumMaximo FROM Logros AS L
	WHERE L.idLogro = @AchievementID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene un premio.
-- =============================================
CREATE PROCEDURE [dbo].[GetAwardByID]
	@AwardID int
AS
BEGIN
	SELECT P.idPremio AS ID, P.Titulo AS Nombre, P.Descripcion, P.Foto,
	P.Cantidad, P.Monto, TP.Tipo, M.Nombre AS Moneda FROM Premio AS P
	INNER JOIN TipoPremio AS TP ON TP.idTipoPremio = P.fk_idTipoPremio
	INNER JOIN Moneda AS M ON M.idMoneda = P.fk_idMoneda
	WHERE P.idPremio = @AwardID;
END;
GO

-- =============================================
-- Author:		Jose Garcia
-- Description:	Obtiene todos los premios de una regla.
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
-- Description:	Obtiene los logros asociados a un departamento.
-- =============================================
CREATE PROCEDURE [dbo].[GetDepartmentAchievements]
	@DepartmentID int
AS
BEGIN
	SELECT LPD.fk_idLogro AS ID FROM LogrosPorDepartamento AS LPD
	INNER JOIN Departamento AS D ON D.idDepartamento = LPD.fk_idDepartamento
	WHERE D.idDepartamento = @DepartmentID OR D.Nombre = 'Global';
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
-- Description:	Agrega un logro a una regla.
-- =============================================
CREATE PROCEDURE [dbo].[AddAchievementToRule]
	@RuleID int, 
	@AchievementID int,
	@CreatorID int,
	@Amount int,
	@CreationDate date
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM LogrosPorRegla WHERE fk_idRegla = @RuleID AND fk_Logro = @AchievementID)
		INSERT INTO LogrosPorRegla (fk_idRegla, fk_Logro, fk_idCreador, Cantidad, FechaCreacion) VALUES
		(@RuleID, @AchievementID, @CreatorID, @Amount, @CreationDate);
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
-- Description:	Agrega una nueva regla.
ALTER PROCEDURE [dbo].[AddRule]
	@Name varchar(100),
	@Description varchar(500),
	@StartDate date,
	@EndDate date,
	@CreationDate date,
	@CreatorID int
AS
BEGIN
	INSERT INTO Regla (Nombre, Descripcion, FechaInicio, FechaFinal, FechaCreacion, fk_idCreador, fk_idEstadoRegla)
	VALUES (@Name, @Description, @StartDate, @EndDate, @CreationDate, @CreatorID, 1);
	SELECT SCOPE_IDENTITY() AS RuleID;
END;