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

INSERT INTO Puestos(idPuesto, Puesto,fk_idDepartamento) VALUES
(1, 'Conserge', 3),
(2, 'Administrador', 4),
(3, 'Obrero', 3),
(4, 'Chofer', 4),
(5, 'Mecánico', 2),
(6, 'Oficinista', 6),
(7, 'Dependiente', 7),
(8, 'Empleador', 2),
(9, 'Asistente', 4),
(10, 'Agente', 7),
(11, 'Archivero', 1),
(12, 'Informático', 1),
(13, 'Modelo', 7),
(14, 'Peón', 3),
(15, 'Socorrista', 2),
(16, 'Técnico', 1),
(17, 'Traductor', 7),
(18, 'Gerente', 4);

INSERT INTO TipoContacto(idTipoContacto,Tipo) VALUES
(1, 'Correo Electrónico'),
(2, 'Teléfono Fijo'),
(3, 'Teléfono Móvil'),
(4, 'Código Postal'),
(5, 'Red Social'),
(6, 'Página web');

INSERT INTO EstadoUsuario(idEstado,Estado) VALUES
(1, 'Activo'),
(2, 'Desactivo'),
(3, 'Temporalmente Suspendido'),
(3, 'Despedido');

-- Voy a ir actualizando esta parte --

INSERT INTO Logros(idLogro,Descripcion,FechaInicio,FechaFinal, fk_idCreador,FechaCreacion) VALUES
(1, 'Aprender portugués','2011-02-10', '2012-02-10', 2, '2011-01-01'),
(2, 'Cursar Maestría','2011-02-10', , 3, '2011-01-01'),
(3, 'Asistir a 5 seminarios','2011-01-01', , 6, '2011-01-01'),
(4, 'Llegar temprano durante 1 mes','2011-02-10', '2011-02-10', 2, '2011-01-01'),
(5, 'Aprender a programar en Ruby on Rails','2011-02-10', , 8, '2011-01-01'),
(6, 'Participar en carrera de la empresa','2012-08-10', , 2, '2011-01-02'),
(7, 'Ganar carrera de la empresa', '2011-08-10', , 2, '2011-01-02');


INSERT INTO Premio(idPremio, Titulo, Descripcion, Foto, Cantidad, Monto, fk_idMoneda, fk_idTipoPremio, FechaCreacion) VALUES
(1, 'Fin de semana en Hotel Barceló playa Tambor', 'Fin de semana en el hotel Barceló playa tambor bajo la modalidad todo incluido para 2 adultos.', 'img/photos/1/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(2, 'Orden de compra en tienda Arenas', 'Orden de compra por $1000 en tiendas Arenas.', 'img/photos/2/photo.jpg', , 1000, 1, tipoPremio, '2011-01-01'),
(3, 'Día libre', 'Día libre a elegir por parte del usuario.', 'img/photos/3/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(4, 'Bono', 'Bono de $500.', 'img/photos/4/photo.jpg', , 500, 1, tipoPremio, '2011-01-01'),
(5, 'Bono', 'Bono de $1000.', 'img/photos/4/photo.jpg', 1000, , ,1, tipoPremio, '2011-01-01'),
(6, 'Laptop Dell inspiron 17R', 'Computadora portátil Dell inspiron 17R.', 'img/photos/6/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(7, 'Pase especial Parque de Diversiones', '4 Pases especiales para el Parque Nacional de Diversiones.', 'img/photos/7/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(8, 'Seminario sobre Recursos Humanos', 'Seminario sobre recursos humanos en Estados Unidos todo pago.', 'img/photos/8/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(9, 'Curso de Portugués avanzado', 'Curso pagado de portugués avanzado.', 'img/photos/9/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(10, 'Curso de Inglés Avanzado', 'Curso pagado de Inglés avanzado.', 'img/photos/10/photo.jpg', , , 1, tipoPremio, '2013-01-01'),
(11, 'Capacitación Bases de Datos.', 'Capacitación sobre bases de datos en Argentian todo pago.', 'img/photos/11/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(12, 'Fin de semana en Hotel Tabacón', 'Fin de semana en el hotel Tabacón bajo la modalidad todo incluido para 2 adultos.', 'img/photos/3/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(13, 'Seminario sobre Finanzas', 'Seminario sobre finazas en Colombia todo pago.', 'img/photos/8/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(14, 'DVD', 'The Beatles Best Hits + AC/DC Live.', 'img/photos/14/photo.jpg', , , 1, tipoPremio, '2011-01-09'),
(15, 'Orden de Compra en Subway', 'Cupón para almuerzo en subway.', 'img/photos/15/photo.jpg', , , 1, tipoPremio, '2012-01-01'),
(16, 'Tenis Nike', 'Par de tenis Nike.', 'img/photos/16/photo.jpg', , , 1, tipoPremio, '2011-09-01'),
(17, 'Orden de compra en Gollo', 'Orden de compra por $1000 en tiendas Gollo.', 'img/photos/17/photo.jpg', , 1000, 1, tipoPremio, '2011-01-01'),
(18, 'PS4', 'Play Sation 4 + GTA 5.', 'img/photos/18/photo.jpg', , , 1, tipoPremio, '2011-09-09'),
(19, 'PS3', 'Play Sation 3 + Gran Turismo 6.', 'img/photos/19/photo.jpg', , , 1, tipoPremio, '2010-01-01'),
(20, 'iPod Touch', 'iPod Touch + $5 iTunes gift card.', 'img/photos/20/photo.jpg', , , 1, tipoPremio, '2011-07-01'),
(21, 'iPod Nano', 'iPod Nano + $5 iTunes gift card.', 'img/photos/21/photo.jpg', , , 1, tipoPremio, '2011-01-01'),
(22, 'Orden de Compra Runners', 'Orden de compra por $500 en tiendas Runners.', 'img/photos/22/photo.jpg', , 500, 1, tipoPremio, '2011-03-08'),
(23, 'Orden de Compra Librería Internacional', 'Orden de compra por $100 en Librería Internacional.', 'img/photos/23/photo.jpg', , 100, 1, tipoPremio, '2012-09-03'),
(25, 'Tratamiento Dental', 'Tratamiento dental por un valor de $1000.', 'img/photos/24/photo.jpg', , 1000, 1, tipoPremio, '2013-02-05'),
(26, '', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(27, '', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(28, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(29, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(30, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(31, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(32, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(33, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(34, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(35, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(36, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(37, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(38, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(39, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(40, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(41, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(40, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(42, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(43, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(44, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(45, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(46, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(47, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(48, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(49, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05'),
(50, 'DVD', 'Pearl Jam Unplugged.', 'img/photos/24/photo.jpg', , , 1, tipoPremio, '2013/02/05');

-- --------------------------------------------------------------------------------------------------------------------------