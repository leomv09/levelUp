TABLAS POR LLENAR
-----------------

Usuario
Regla
Contratos
TitulosPorUsuario
ContactosPorUsuario
LogrosPorDepartamento
PremiosPorDepartamento
ReglasPorDepartamento

-------------------------------------------------------------------------------------------------------------------------------------------

-- Truncate all tables.
DELETE FROM Evento;
DELETE FROM TipoEvento;
DELETE FROM Severidad;
DELETE FROM Modulo;

DELETE FROM DireccionesPorUsuario;
DELETE FROM Direccion;
DELETE FROM Ciudad;
DELETE FROM Provincia;
DELETE FROM Pais;

DELETE FROM PermisosPorGrupo;
DELETE FROM PermisosPorUsuario;
DELETE FROM UsuariosPorGrupo;
DELETE FROM GruposDeUsuarios;
DELETE FROM Permisos;

DELETE FROM TitulosPorUsuario;
DELETE FROM TitulosPorInstituciones;
DELETE FROM ContactosPorUsuario;
DELETE FROM Titulos;
DELETE FROM Institucion;
DELETE FROM Contratos;
DELETE FROM Puestos;
DELETE FROM TipoContacto;

DELETE FROM PremiosPorUsuario;
DELETE FROM LogrosPorUsuario;
DELETE FROM LogrosPorRegla;
DELETE FROM LogrosPorDepartamento;
DELETE FROM PremiosPorDepartamento;
DELETE FROM ReglasPorDepartamento;
DELETE FROM Departamento;
DELETE FROM Logros;
DELETE FROM Regla;
DELETE FROM EstadoRegla;
DELETE FROM EstadoLogro;
DELETE FROM EstadoPremio;
DELETE FROM Premio;
DELETE FROM TipoPremio;
DELETE FROM TasaCambio;
DELETE FROM Moneda;

DELETE FROM Usuario;
DELETE FROM EstadoUsuario;
-- End Truncate all tables.

-------------------------------------------------------------------------------------------------------------------------------------------

-- Fill Tables.
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
(7, 'Ventas')
(8, 'Conserjería');
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

SET IDENTITY_INSERT dbo.Puestos ON;
INSERT INTO Puestos (idPuesto, Puesto, fk_idDepartamento) VALUES
(1, 'Conserje', 3),
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
SET IDENTITY_INSERT dbo.Puestos OFF;

SET IDENTITY_INSERT dbo.TipoContacto ON;
INSERT INTO TipoContacto (idTipoContacto, Tipo) VALUES
(1, 'Correo Electrónico'),
(2, 'Teléfono Fijo'),
(3, 'Teléfono Móvil'),
(4, 'Código Postal'),
(5, 'Red Social'),
(6, 'Página Web');
SET IDENTITY_INSERT dbo.TipoContacto OFF;

SET IDENTITY_INSERT dbo.EstadoUsuario ON;
INSERT INTO EstadoUsuario (idEstadoUsuario, Estado) VALUES
(1, 'Activo'),
(2, 'Inactivo'),
(3, 'Temporalmente Suspendido'),
(4, 'Despedido'),
(5, 'Retirado');
SET IDENTITY_INSERT dbo.EstadoUsuario OFF;

SET IDENTITY_INSERT dbo.EstadoRegla ON;
INSERT INTO EstadoRegla (idEstadoRegla, Estado) VALUES
(1, 'Activa'),
(2, 'Inactiva'),
(3, 'Vencida');
SET IDENTITY_INSERT dbo.EstadoRegla OFF;

SET IDENTITY_INSERT dbo.EstadoLogro ON;
INSERT INTO EstadoLogro (idEstadoLogro, Estado) VALUES
(1, 'Activo'),
(2, 'Inactivo'),
(3, 'Vencido');
SET IDENTITY_INSERT dbo.EstadoLogro OFF;

SET IDENTITY_INSERT dbo.EstadoPremio ON;
INSERT INTO EstadoPremio (idEstadoPremio, Estado) VALUES
(1, 'Activo'),
(2, 'Inactivo'),
(3, 'Agotado');
SET IDENTITY_INSERT dbo.EstadoPremio OFF;

SET IDENTITY_INSERT dbo.Logros ON;
INSERT INTO Logros (idLogro, Descripcion, FechaInicio, FechaFinal, fk_idCreador, FechaCreacion,fk_idEstadoLogro) VALUES
(1, 'Aprender portugués.', '2011-02-10', '2012-02-10', 2, '2011-01-01', 1),
(2, 'Cursar Maestría.', '2011-02-10', '2012-02-10', 3, '2011-01-01', 1),
(3, 'Asistir a 5 seminarios.', '2011-01-01', '2012-02-10', 6, '2011-01-01', 1),
(4, 'Llegar temprano durante 1 mes.', '2011-02-10', '2011-02-10', 2, '2011-01-01',1),
(5, 'Aprender a programar en Ruby on Rails.', '2011-02-10', '2012-02-10', 8, '2011-01-01',1),
(6, 'Participar en carrera de la empresa.', '2012-08-10', '2012-02-10', 2, '2011-01-02',1),
(7, 'Ganar carrera de la empresa.', '2011-08-10', '2012-02-10', 2, '2011-01-02',1),
(8, 'Limpiar 2 parques de la ciudad.', '2010-08-12', '2012-02-10', 4, '2011-01-02',1),
(9, 'Cursar "HTML5 on W3C.', '2011-08-10', '2012-02-10', 1, '2011-01-02',1),
(10, 'Cerrar contrato con BMW.', '2011-08-10', '2012-02-10', 10, '2011-01-02',1),
(11, 'Crear asociación en la empresa.', '2011-08-10', '2012-02-10', 9, '2011-01-02',1),
(12, 'Componer himno organizacional.', '2011-08-10', '2012-02-10', 15, '2011-01-02',1),
(13, 'Llegar temprano durante 20 años laborales.', '2011-08-10', '2012-02-09', 19, '2011-01-02',1),
(14, 'Laborar 14 horas extra en un mes.', '2011-08-10', '2012-02-10', 20, '2011-01-02',1),
(15, 'Organizar fiesta anual.', '2011-08-10', '2012-02-10', 14, '2011-01-02',1);
SET IDENTITY_INSERT dbo.Logros OFF;

SET IDENTITY_INSERT dbo.TipoPremio ON;
INSERT INTO TipoPremio (idTipoPremio, Tipo)VALUES
(1, 'Viaje'),
(2, 'Dinero'),
(3, 'Orden de Compra'),
(4, 'Dispositivo Electrónico'),
(5, 'Seminario'),
(6, 'Capacitación'),
(7, 'Vestimenta'),
(8, 'DVD'),
(9, 'Transporte'),
(10, 'Membresía'),
(11, 'Tiquetes')
(12, 'Ocio'),
(13, 'Puntos'),
(14, 'Condecoracion');
SET IDENTITY_INSERT dbo.TipoPremio OFF;

SET IDENTITY_INSERT dbo.Premio ON;
INSERT INTO Premio (idPremio, Titulo, Descripcion, Foto, Cantidad, Monto, fk_idMoneda, fk_idTipoPremio, FechaCreacion) VALUES
(1, 'Fin de semana en Hotel Barceló playa Tambor', 'Fin de semana en el hotel Barceló playa tambor bajo la modalidad todo incluido para 2 adultos.', 'img/photos/1/photo.jpg', , , 1, 1, '2011-01-01'),
(2, 'Orden de compra en tienda Arenas', 'Orden de compra por $1000 en tiendas Arenas.', 'img/photos/2/photo.jpg', , 1000, 1, 3, '2011-01-01'),
(3, 'Día libre', 'Día libre a elegir por parte del usuario.', 'img/photos/3/photo.jpg', , , 1, 12, '2011-01-01'),
(4, 'Bono', 'Bono de $500.', 'img/photos/4/photo.jpg', , 500, 1, 2, '2011-01-01'),
(5, 'Bono', 'Bono de $1000.', 'img/photos/4/photo.jpg', 1000, , ,1, 2, '2011-01-01'),
(6, 'Laptop Dell inspiron 17R', 'Computadora portátil Dell inspiron 17R.', 'img/photos/6/photo.jpg', , , 1, 4, '2011-01-01'),
(7, 'Pase especial Parque de Diversiones', '4 Pases especiales para el Parque Nacional de Diversiones.', 'img/photos/7/photo.jpg', , , 1, 11, '2011-01-01'),
(8, 'Seminario sobre Recursos Humanos', 'Seminario sobre recursos humanos en Estados Unidos todo pago.', 'img/photos/8/photo.jpg', , , 1, 5, '2011-01-01'),
(9, 'Curso de Portugués avanzado', 'Curso pagado de portugués avanzado.', 'img/photos/9/photo.jpg', , , 1, 6, '2011-01-01'),
(10, 'Curso de Inglés Avanzado', 'Curso pagado de Inglés avanzado.', 'img/photos/10/photo.jpg', , , 1, 6, '2013-01-01'),
(11, 'Capacitación Bases de Datos.', 'Capacitación sobre bases de datos en Argentian todo pago.', 'img/photos/11/photo.jpg', , , 1, 6, '2011-01-01'),
(12, 'Fin de semana en Hotel Tabacón', 'Fin de semana en el hotel Tabacón bajo la modalidad todo incluido para 2 adultos.', 'img/photos/3/photo.jpg', , , 1, 1, '2011-01-01'),
(13, 'Seminario sobre Finanzas', 'Seminario sobre finazas en Colombia todo pago.', 'img/photos/8/photo.jpg', , , 1, 5, '2011-01-01'),
(14, 'DVD', 'The Beatles Best Hits + AC/DC Live.', 'img/photos/14/photo.jpg', , , 1, 8, '2011-01-09'),
(15, 'Orden de Compra en Subway', 'Cupón para almuerzo en subway.', 'img/photos/15/photo.jpg', , , 1, 3, '2012-01-01'),
(16, 'Tenis Nike', 'Par de tenis Nike.', 'img/photos/16/photo.jpg', , , 1, 7, '2011-09-01'),
(17, 'Orden de compra en Gollo', 'Orden de compra por $1000 en tiendas Gollo.', 'img/photos/17/photo.jpg', , 1000, 1, 3, '2011-01-01'),
(18, 'PS4', 'Play Sation 4 + GTA 5.', 'img/photos/18/photo.jpg', , , 1, 4, '2011-09-09'),
(19, 'PS3', 'Play Sation 3 + Gran Turismo 6.', 'img/photos/19/photo.jpg', , , 1, 4, '2010-01-01'),
(20, 'iPod Touch', 'iPod Touch + $5 iTunes gift card.', 'img/photos/20/photo.jpg', , , 1, 4, '2011-07-01'),
(21, 'iPod Nano', 'iPod Nano + $5 iTunes gift card.', 'img/photos/21/photo.jpg', , , 1, 4, '2011-01-01'),
(22, 'Orden de Compra Runners', 'Orden de compra por $500 en tiendas Runners.', 'img/photos/22/photo.jpg', , 500, 1, 3, '2011-03-08'),
(23, 'Orden de Compra Librería Internacional', 'Orden de compra por $100 en Librería Internacional.', 'img/photos/23/photo.jpg', , 100, 1, 3, '2012-09-03'),
(25, 'Tratamiento Dental', 'Tratamiento dental por un valor de $1000.', 'img/photos/25/photo.jpg', , 1000, 1, 3, '2013-02-05'),
(26, 'Membresía Saprissista', 'Membresía por 1 año en el estadio Ricardo Saprissa.', 'img/photos/26/photo.jpg', , , 1, 10, '2013-02-05'),
(27, 'Entradas Eliminatoria', '2 Entradas dobles para el partido de Costa Rica contra Estados Unidos', 'img/photos/27/photo.jpg', , , 1, 11, '2013-04-05'),
(28, 'Entradas Eliminatoria', '2 Entradas dobles para el partido de Costa Rica contra Mexico', 'img/photos/28/photo.jpg', , , 1, 11, '2013-06-01'),
(29, 'Computadora HP', 'Laptop HP Pavilion G42.', 'img/photos/29/photo.jpg', , , 1, 4, '2011-04-05'),
(30, 'Pantalla Plana', 'Pantalla FULL HD LG de 42 pulgadas.', 'img/photos/30/photo.jpg', , , 1, 4, '2012-12-20'),
(31, 'Botella Chivas Regal', '1 Botella de Wisky Chivas Regal.', 'img/photos/31/photo.jpg', , , 1, 3, '2013-02-05'),
(32, 'Samsung Galaxy S4', 'Celular Samsung Galaxy S4.', 'img/photos/32/photo.jpg', , , 1, 4, '2013-08-07'),
(33, 'Canopy Tour Monteverde', 'Canopy Tour en Monteverde Costa Rica para 2 adultos.', 'img/photos/33/photo.jpg', , , 1, 1, '2012-07-01'),
(34, 'Bicicleta Specialized', 'Bicicleta marca Spcialized.', 'img/photos/34/photo.jpg', , , 1, tipoPremio, '2013-01-05'),
(35, 'Kayak en San Carlos', 'Kayak tour para 2 adultos en Arenal.', 'img/photos/24/photo.jpg', , , 1, 9, '2013/02/05'),
(36, 'Tour Volcán Poás', 'Tour al Volcán Poás para 4 personas, desayuno y almuerzo incluido.', 'img/photos/36/photo.jpg', , , 1, 1, '2013-05-05'),
(37, 'Tableta Samsung', 'Samnsung Galaxy tab 3.', 'img/photos/37/photo.jpg', , , 1, 4, '2013-02-28'),
(38, 'Camisa Selección Nacional', 'Camisa original de la selección Nacional de Costa Rica.', 'img/photos/38/photo.jpg', , , 1, 7, '2012-05-05'),
(39, 'Viaje a Brazil', 'Viaje a Brazil para 2 adultos, todos los gastos pagados.', 'img/photos/39/photo.jpg', , , 1, 1, '2013-02-05'),
(40, 'Camisa de Bryan Ruiz', 'Camisa del Fulham + CR autografiadas por Bryan Ruiz González.', 'img/photos/40/photo.jpg', , , 1, 7, '2013-02-20'),
(41, 'Guantes de Keylor Navas', 'Guantes autografiados por Keylor Navas.', 'img/photos/41/photo.jpg', , , 1, 7, '2012-02-05'),
(42, 'Viaje a Panamá', 'Viaje a Panamá para 2 adultos con todos los gastos pagados.', 'img/photos/42/photo.jpg', , , 1, 1, '2011-02-05'),
(43, 'Almuerzo Gratis', 'Almuerzo gratis en Puzza Hut aplica para cualquier combo.', 'img/photos/43/photo.jpg', , , 1, 3, '2012-12-05'),
(44, 'Orden de Compra', 'Orden de compra por $200 en tiendas Forever 21.', 'img/photos/44/photo.jpg', , , 1, 3, '2013-06-21'),
(45, 'iPad', 'iPad de tercera generación 64GB color negro.', 'img/photos/45/photo.jpg', , , 1, 4, '2013-10-05'),
(46, 'Computadora Lenovo', 'Laptop Lenovo T430s.', 'img/photos/46/photo.jpg', , , 1, 4, '2013-01-05'),
(47, 'Entradas al Cine', '2 entradas dobles en cadenas de cine CCMM cinemas.', 'img/photos/47/photo.jpg', , , 1, 11, '2011-06-06'),
(48, 'Sillón Ortopédico', 'Sillón Ortopédico.', 'img/photos/48/photo.jpg', , , 1, 12, '2013-02-05'),
(49, 'Herramientas para Bicicleta', 'Caja de herramientas para bicicleta.', 'img/photos/49/photo.jpg', , , 1, 9, '2012-12-12'),
(50, 'DVD', 'DVD de la película Costarricense El Regreso.', 'img/photos/50/photo.jpg', , , 1, 8, '2013-04-04');
SET IDENTITY_INSERT dbo.Premio OFF;

SET IDENTITY_INSERT dbo.Permisos ON;
INSERT INTO Permisos (idPermiso, Descripcion, Codigo) VALUES
(1, 'Concede permiso para iniciar sesión en la aplicación de administracion', 'login_pc_admin'),
(2, 'Concede permiso para añadir una regla al sistema.', 'add_rule'),
(3, 'Concede permiso para remover una regla del sistema.', 'remove_rule'),
(4, 'Concede permiso para modificar una regla del sistema.', 'modify_rule'),
(5, 'Concede permiso para ver las reglas del sistema.', 'view_rules'),
(6, 'Concede permiso para agregar un logro al sistema.', 'add_achievement'),
(7, 'Concede permiso para modificar un logro del sistema.', 'modify_achievement'),
(8, 'Concede permiso para ver los logros del sistema.', 'view_achievements'),
(9, 'Concede permiso para conceder un logro a un usuario.', 'add_achievement_to_user'),
(10, 'Concede permiso para revocar un logro a un usuario.', 'remove_achievement_from_user'),
(11, 'Concede permiso para agregar un premio al sistema.', 'add_award'),
(12, 'Concede permiso para modificar un premio del sistema.', 'modify_award'),
(13, 'Concede permiso para ver los premios del sistema.', 'view_awards'),
(14, 'Concede permiso para entregarle un premio a un usuario.', 'give_award_to_user'),
(15, 'Concede permiso para añadir un usuario al sistema.', 'add_user'),
(16, 'Concede permiso para eliminar un usuario del sistema.', 'remove_user'),
(17, 'Concede permiso para ver la información pública de cualquier usuario del sistema.', 'view_any_user_public_info'),
(18, 'Concede permiso para ver la información privada de cualquier usuario del sistema.', 'view_any_user_private_info'),
(19, 'Concede permiso para ver la información pública de su propio usuario..', 'view_my_public_info'),
(20, 'Concede permiso para ver la información privada de su propio usuario.', 'view_my_private_info'),
(21, 'Concede permiso para modificar la información pública de cualquier usuario.', 'modify_any_user_public_info'),
(22, 'Concede permiso para modificar la información privada de cualquier usuario.', 'modify_any_user_private_info'),
(23, 'Concede permiso para modificar la información pública de su propio usuario..', 'modify_my_public_info'),
(24, 'Concede permiso para modificar la información privada de su propio usuario.', 'modify_my_private_info'),
(25, 'Concede permiso para agregar una moneda al sistema.', 'add_money'),
(26, 'Concede permiso para ver las monedas del sistema.', 'view_money'),
(27, 'Concede permiso para modificar las tasas de cambio de las monedas.', 'modify_exchange_rate'),
(28, 'Concede permiso para ver las tasas de cambio de las monedas.', 'view_exchange_rates'),
(29, 'Concede permiso para agregar un departamento al sistema.', 'add_department'),
(30, 'Concede permiso para ver los departamentos del sistema.', 'view_departments'),
(31, 'Concede permiso para agregar un puesto al sistema.', 'add_job'),
(32, 'Concede permiso para modificar un puesto del sistema.', 'modify_job'),
(33, 'Concede permiso para ver los puestos del sistema.', 'view_jobs'),
(34, 'Concede permiso para agregar un título al sistema.', 'add_degree'),
(35, 'Concede permiso para ver los títulos del sistema.', 'view_degrees'),
(36, 'Concede permiso para agregar una institución al sistema.', 'add_institution'),
(37, 'Concede permiso para ver las instituciones del sistema.', 'view_institutions'),
(38, 'Concede permiso para asociar un título a una institución.', 'add_degree_to_institution'),
(39, 'Concede permiso para asociar un título a un usuario.', 'add_degree_to_user'),
(40, 'Concede permiso para agregar un nuevo permiso.', 'add_permission'),
(41, 'Concede permiso para crear un grupo de usuarios.', 'add_user_group'),
(42, 'Concede permiso para agregar un usuario a un grupo de usuarios', 'add_user_to_group'),
(43, 'Concede permiso para remover un usuario de un grupo de usuarios.', 'remove_user_from_group'),
(44, 'Condece permiso para modificar los permisos de un usuario.', 'modify_user_permissions'),
(45, 'Concede permiso para modificar los permisos por grupos de usuarios', 'modify_permissions_per_group'),
(46, 'Concede permiso para ver los permisos de un usuario.', 'view_user_permissions'),
(47, 'Concede permiso para ver los permisos de un grupo de usuarios.', 'view_user_group_permissions');
SET IDENTITY_INSERT dbo.Permisos OFF;

SET IDENTITY_INSERT dbo.GruposDeUsuarios ON;
INSERT INTO GruposDeUsuarios (idGrupoDeUsuarios, Nombre, Activo) VALUES
(1, 'Empleado', 1),
(2, 'Administradores Globales', 1),
(3, 'Administradores de Reglas', 1),
(4, 'Administradores de Logros', 1),
(5, 'Administradores de Premios', 1),
(6, 'Administradores de Información', 1),
(7, 'Administradores de Usuarios', 1);
SET IDENTITY_INSERT dbo.GruposDeUsuarios OFF;

SET IDENTITY_INSERT dbo.Severidad ON;
INSERT INTO Severidad (idSeveridad, Descripcion) VALUES
(1, 'Información'),
(2, 'Advertencia'),
(3, 'Error');
SET IDENTITY_INSERT dbo.Severidad OFF;

SET IDENTITY_INSERT dbo.Modulo ON;
INSERT INTO Modulo (idModulo, Nombre) VALUES
(1, 'Aplicación de Administración PC');
SET IDENTITY_INSERT dbo.Modulo OFF;

SET IDENTITY_INSERT dbo.TipoEvento ON;
INSERT INTO TipoEvento (idTipoEvento, Tipo) VALUES
(1, 'Inicio de Sesion en Aplicación de Administracion Windows'),
(2, 'Cierre de Sesion en Aplicación de Administracion Windows'),
(3, 'Creacion de Regla'),
(4, 'Eliminacion de Regla'),
(5, 'Modificacion de Regla'),
(6, 'Creacion de Logro'),
(7, 'Modificacion de Logro'),
(8, 'Concesion de Logro a Usuario'),
(9, 'Revocamiento de Logro a Usuario'),
(10, 'Creacion de Premio'),
(11, 'Modificacion de Premio'),
(12, 'Entrega de Premio a Usuario'),
(13, 'Creacion de Usuario'),
(14, 'Eliminacion de Usuario'),
(15, 'Modificacion de Información de Usuario'),
(16, 'Creacion de Moneda'),
(17, 'Actualizacion Tasa de Cambio'),
(18, 'Creacion de Departamento'),
(19, 'Creacion de Puesto'),
(20, 'Modificacion de Puesto'),
(21, 'Creacion de Titulo'),
(22, 'Creacion de Institucion'),
(23, 'Asociacion de Titulo a Institucion'),
(24, 'Creacion de Permiso'),
(25, 'Creacion de Grupo de Usuarios'),
(26, 'Agregacion de Usuario a Grupo de Usuarios'),
(27, 'Eliminacion de Usuario de Grupo de Usuarios'),
(28, 'Modificacion de Permisos de Usuario'),
(29, 'Modificacion de Permisos de Grupo de Usuarios');
SET IDENTITY_INSERT dbo.TipoEvento OFF;
-- End Fill Tables.

-------------------------------------------------------------------------------------------------------------------------------------------

-- Fill Intersection Tables.
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

-- Se le concede a los administradores globales todos los permisos.
DECLARE @i int = 1
WHILE @i < 48 BEGIN
  INSERT INTO PermisosPorGrupo (fk_idGrupo, fk_idPermiso) VALUES (2, @i);
  SET @i = @i + 1
END

INSERT INTO PermisosPorGrupo (fk_idGrupo, fk_idPermiso) VALUES
(1, 5),
(1, 8),
(1, 13),
(1, 17),
(1, 19),
(1, 20),
(3, 1),
(3, 2),
(3, 3),
(3, 4),
(3, 5),
(3, 8),
(3, 13),
(3, 30),
(4, 1),
(4, 5),
(4, 6),
(4, 7),
(4, 8),
(4, 9),
(4, 10),
(4, 13),
(4, 30),
(5, 1),
(5, 5),
(5, 8),
(5, 11),
(5, 12),
(5, 13),
(5, 14),
(5, 26),
(5, 30),
(6, 1),
(6, 25),
(6, 26),
(6, 27),
(6, 28),
(6, 29),
(6, 30),
(6, 31),
(6, 32),
(6, 33),
(6, 34),
(6, 35),
(6, 36),
(6, 37),
(6, 38),
(7, 17),
(7, 18),
(7, 21),
(7, 22),
(7, 39);
-- End Fill Intersection Tables.

-------------------------------------------------------------------------------------------------------------------------------------------
