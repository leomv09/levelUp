DELETE FROM EstadoUsuario;
SET IDENTITY_INSERT dbo.EstadoUsuario ON;
INSERT INTO EstadoUsuario (idEstadoUsuario, Estado) VALUES
(1, 'Activo'),
(2, 'Inactivo'),
(3, 'Temporalmente Suspendido'),
(4, 'Despedido'),
(5, 'Retirado');
SET IDENTITY_INSERT dbo.EstadoUsuario OFF;

DELETE FROM Genero;
SET IDENTITY_INSERT dbo.Genero ON;
INSERT INTO Genero (idGenero, Genero) VALUES
(1, 'Indefinido'),
(2, 'Masculino'),
(3, 'Femenino');
SET IDENTITY_INSERT dbo.Genero OFF;

DELETE FROM Usuario;
DECLARE @userName varchar (70);
DECLARE @nombre varchar(50);
DECLARE @apellido1 varchar(50);
DECLARE @apellido2 varchar(50);
DECLARE @count INT;
SET @count = 0;

DECLARE @nombres TABLE (Name varchar (50));
DECLARE @apellidos TABLE (Name varchar (50));
INSERT INTO @nombres (Name) VALUES ('Juan'), ('Pedro'), ('Pablo'), ('Alex'), ('Daniel'), ('David'), ('Alejandra'), ('Susan'), ('Tatiana'), ('María'), ('Cindy'), ('Alexa'), ('Jorge'), ('Alejandro'), ('Ariana'), ('Jose'), ('Eduardo'), ('Christina'), ('Emanuel'), ('Anthony'), ('Johanna'), ('Brenda'), ('Andrea'), ('Karla'), ('Luis'), ('Edgardo'), ('Denis'), ('Katherine'), ('Marta'), ('Marcia');
INSERT INTO @apellidos (Name) VALUES ('Chacon'), ('Lobo'), ('Fernandez'), ('Lopez'), ('Arias'), ('Cordero'), ('Salazar'), ('Campos'), ('Solis'), ('Vargas'), ('Cartin'), ('Morales'), ('Nuñez'), ('Rodriguez'), ('Delgado'), ('Alvarez'), ('mora'), ('Rojas'), ('Loria');

SET IDENTITY_INSERT dbo.Usuario ON;
WHILE @count < 300
BEGIN
  SET @count = @count + 1
  SELECT TOP 1 @nombre = name FROM @nombres ORDER BY NEWID()
  SELECT TOP 1 @apellido1 = name FROM @apellidos ORDER BY NEWID()
  SELECT TOP 1 @apellido2 = name FROM @apellidos ORDER BY NEWID()
  SET @username = @nombre + @apellido1 + CAST(@count AS varchar)
  INSERT INTO Usuario (idUsuario, Nombre, Apellido1, Apellido2, Username, Contraseña, fk_idEstadoUsuario, fk_idGenero)
  VALUES (@count, @nombre, @apellido1, @apellido2, @username, HASHBYTES('SHA2_256', @username), 1, 1)
END
SET IDENTITY_INSERT dbo.Usuario OFF;