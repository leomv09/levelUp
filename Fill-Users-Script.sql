USE LevelUp;

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
DECLARE @Username varchar (70);
DECLARE @Nombre varchar(50);
DECLARE @Apellido1 varchar(50);
DECLARE @Apellido2 varchar(50);
DECLARE @Count INT;
SET @Count = 1;

DECLARE @Nombres TABLE (Name varchar (50));
DECLARE @Npellidos TABLE (Name varchar (50));
INSERT INTO @Nombres (Name) VALUES ('Juan'), ('Pedro'), ('Pablo'), ('Alex'), ('Daniel'), ('David'), ('Alejandra'), ('Susan'), ('Tatiana'), ('María'), ('Cindy'), ('Alexa'), ('Jorge'), ('Alejandro'), ('Ariana'), ('Jose'), ('Eduardo'), ('Christina'), ('Emanuel'), ('Anthony'), ('Johanna'), ('Brenda'), ('Andrea'), ('Karla'), ('Luis'), ('Edgardo'), ('Denis'), ('Katherine'), ('Marta'), ('Marcia');
INSERT INTO @Npellidos (Name) VALUES ('Chacon'), ('Lobo'), ('Fernandez'), ('Lopez'), ('Arias'), ('Cordero'), ('Salazar'), ('Campos'), ('Solis'), ('Vargas'), ('Cartin'), ('Morales'), ('Nuñez'), ('Rodriguez'), ('Delgado'), ('Alvarez'), ('mora'), ('Rojas'), ('Loria');

SET IDENTITY_INSERT dbo.Usuario ON;
INSERT INTO Usuario (idUsuario, Nombre, Apellido1, Username, Contraseña, fk_idEstadoUsuario, fk_idGenero)
VALUES (1, "Administrador", "", "admin", HASHBYTES('SHA2_256', "admin"), 1, 1);
WHILE @Count < 299
BEGIN
  SET @Count = @Count + 1;
  SELECT TOP 1 @Nombre = name FROM @nombres ORDER BY NEWID();
  SELECT TOP 1 @Apellido1 = name FROM @apellidos ORDER BY NEWID();
  SELECT TOP 1 @Apellido2 = name FROM @apellidos ORDER BY NEWID();
  SET @Username = @Nombre + @Apellido1 + CAST(@Count AS varchar);
  INSERT INTO Usuario (idUsuario, Nombre, Apellido1, Apellido2, Username, Contraseña, fk_idEstadoUsuario, fk_idGenero)
  VALUES (@Count, @Nombre, @Apellido1, @Apellido2, @Username, HASHBYTES('SHA2_256', @Username), 1, 1);
END
SET IDENTITY_INSERT dbo.Usuario OFF;