USE [LevelUp]
GO
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID('bitacora'))--Igual a DROP TRIGGER IF EXISTS
BEGIN
    DROP TRIGGER [dbo].[bitacora] 
END
GO
CREATE TRIGGER bitacora
ON Usuario
AFTER INSERT, UPDATE
AS INSERT INTO Evento(fk_idUsuario,fk_idSeveridad,fk_idModulo,fk_idTipoEvento,Descripcion) VALUES
((SELECT idUsuario FROM Usuario WHERE Nombre='Administrador'),1,1,13,'Inserción de usuario');
GO