SET IDENTITY_INSERT dbo.Moneda ON;
INSERT INTO  Moneda (idMoneda, Nombre, Codigo, Simbolo) VALUES
(1, 'Colón', 'CRC', N'¢'),
(2, 'Dolar', 'USD', N'$'),
(3, 'Bitcoin', 'BTC', N'฿');
SET IDENTITY_INSERT dbo.Moneda OFF;

INSERT INTO TasaCambio (fk_idMoneda1, fk_idMoneda2, Fecha, TasaCambio) VALUES
(2, 1, '2013-10-14', 506.457),
(1, 2, '2013-10-14', 0.00197450),
(1, 3, '2013-10-14', 0.0000131583),
(3, 1, '2013-10-14', 75997.63),
(2, 3, '2013-10-14', 0.00665197),
(3, 2, '2013-10-14', 150.331);

SET IDENTITY_INSERT dbo.Departamento ON;
INSERT INTO Departamento (idDepartamento, Nombre) VALUES
(1, 'Tecnologias de Información'),
(2, 'Recursos Humanos'),
(3, 'Limpieza'),
(4, 'Gerencia'),
(5, 'Control de Calidad'),
(6, 'Financiero'),
(7, 'Ventas');
SET IDENTITY_INSERT dbo.Departamento OFF;

SET IDENTITY_INSERT dbo.Institucion ON;
INSERT INTO Institucion (idInstitucion, Nombre) VALUES
(1, 'Instituto Tecnológico de Costa Rica'),
(2, 'Universidad de Costa Rica'),
(3, 'Universidad Nacional de Costa Rica'),
(4, 'Universidad Latina'),
(5, 'Universidad Veritas');
SET IDENTITY_INSERT dbo.Institucion OFF;

SET IDENTITY_INSERT dbo.Titulos ON;
INSERT INTO Titulos (idTitulo, Titulo, GradoAcademico) VALUES
(1, 'Administración de Empresas', 'Bachillerato'),
(2, 'Administración de Empresas', 'Maestría'),
(3, 'Ingeniería Agrícola', 'Bachillerato'),
(4, 'Ingeniería Ambiental', 'Bachillerato'),
(5, 'Ingeniería en Biotecnología', 'Bachillerato'),
(6, 'Ingeniería en Computación', 'Bachillerato'),
(7, 'Ingeniería en Computación', 'Licenciatura'),
(8, 'Ciencias de la Computación', 'Maestría'),
(9, 'Ingeniería en Construcción', 'Bachillerato'),
(10, 'Ingeniería en Diseño Industrial', 'Bachillerato'),
(11, 'Ingeniería en Electrónica', 'Bachillerato'),
(12, 'Arquitectura', 'Bachillerato'),
(13, 'Arquitectura', 'Licenciatura'),
(14, 'Ingeniería en Mantenimiento Industrial', 'Bachillerato'),
(15, 'Ingeniería Forestal', 'Bachillerato'),
(16, 'Contaduría Pública', 'Bachillerato'),
(17, 'Contaduría Pública', 'Licenciatura'),
(18, 'Economía', 'Bachillerato'),
(19, 'Estadística', 'Bachillerato'),
(20, 'Trabajo Social', 'Bachillerato'),
(21, 'Trabajo Social', 'Licenciatura'),
(22, 'Cartografía y Diseño Digital', 'Diplomado'),
(23, 'Negocios Internacionales', 'Bachillerato'),
(24, 'Ingeniería Agrícola', 'Licenciatura');
SET IDENTITY_INSERT dbo.Titulos OFF;

INSERT INTO TitulosPorInstituciones (fk_idInstitucion, fk_idTitulo) VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(1, 5),
(1, 6),
(1, 8),
(1, 9),
(1, 10),
(1, 11),
(1, 12),
(1, 13),
(1, 14),
(1, 15),
(2, 1),
(2, 3),
(2, 6),
(2, 7),
(2, 8),
(2, 11),
(2, 12),
(2, 13),
(2, 16),
(2, 17),
(2, 18),
(2, 19),
(2, 20),
(2, 21),
(3, 1),
(3, 4),
(3, 15),
(3, 18),
(3, 6),
(3, 7),
(3, 16),
(3, 17),
(3, 18),
(3, 19),
(3, 22),
(3, 23),
(3, 24),
(4, 1),
(4, 2),
(4, 6),
(4, 7),
(4, 8),
(4, 10),
(4, 12),
(4, 13),
(4, 16),
(4, 17),
(4, 18),
(4, 23),
(5, 12),
(5, 13);