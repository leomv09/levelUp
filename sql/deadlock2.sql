USE LevelUp

BEGIN TRAN
UPDATE Pais SET Nombre = 'Madrigal'
	where idPais = 1
UPDATE Provincia SET Nombre = 'Milan'
	where idProvincia = 1


