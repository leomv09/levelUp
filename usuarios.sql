DELETE FROM Usuario
declare @userName varchar (70)
DECLARE @nombre varchar(25)
DECLARE @apellido1 varchar(50)
DECLARE @apellido2 varchar(50)
DECLARE @count INT
set @count =0

DECLARE @nombres table (name varchar (25))
DECLARE @apellidos table (name varchar (25))
INSERT INTO @nombres (name) VALUES ('Juan'), ('Pedro'), ('Pablo'), ('Alex'), ('Daniel'), ('David'), ('Alejandra'), ('Susan'), ('Tatiana'), ('María'), ('Cindy'), ('Alexa'), ('Jorge'), ('Alejandro'), ('Ariana'), ('Jose'), ('Eduardo'), ('Christina'), ('Emanuel'), ('Anthony'), ('Johanna'), ('Brenda'), ('Andrea'), ('Karla'), ('Luis'), ('Edgardo'), ('Denis'), ('Katherine'), ('Marta'), ('Marcia')

INSERT INTO @apellidos (name) VALUES ('Chacon'), ('Lobo'), ('Fernandez'), ('Lopez'), ('Arias'), ('Cordero'), ('Salazar'), ('Campos'), ('Solis'), ('Vargas'), ('Cartin'), ('Morales'), ('Nuñez'), ('Rodriguez'), ('Delgado'), ('Alvarez'), ('mora'), ('Rojas'), ('Loria')


WHILE @count < 300
BEGIN
SELECT TOP 1 @nombre = name FROM @nombres ORDER BY RAND()
SELECT TOP 1 @apellido1 = name FROM @apellidos ORDER BY RAND()
SELECT TOP 1 @apellido2 = name FROM @apellidos ORDER BY RAND()
insert into usuario (Nombre, Apellido1, Apellido2, Contraseña, Username, fk_idEstadoUsuario)
VALUES (@nombre, @apellido1, @apellido2, 'testContraseña', 'usuario' + cast (@count+1 as varchar), 1)
SET @count = @count+1
END

