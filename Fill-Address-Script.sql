DELETE FROM Provincia;
SET IDENTITY_INSERT Provincia ON;
INSERT INTO Provincia (idProvincia, Nombre) VALUES
(1, 'San Jose'),
(2, 'Alajuela'),
(3, 'Cartago'),
(4, 'Heredia'),
(5, 'Guanacaste'),
(6, 'Puntarenas'),
(7, 'Limon');
SET IDENTITY_INSERT Provincia OFF;

DELETE FROM Ciudad;
SET IDENTITY_INSERT Ciudad ON;
INSERT INTO Ciudad (idCiudad, fk_idProvincia, Nombre) VALUES
(1, 1, 'San Jose'),
(2, 1, 'Escazu'),
(3, 1, 'Desamparados'),
(4, 1, 'Puriscal'),
(5, 1, 'Tarrazu'),
(6, 1, 'Aserri'),
(7, 1, 'Mora'),
(8, 1, 'Goicoechea'),
(9, 1, 'Santa Ana'),
(10, 1, 'Alajuelita'),
(11, 1, 'Vazquez de Coronado'),
(12, 1, 'Acosta'),
(13, 1, 'Tibas'),
(14, 1, 'Moravia'),
(15, 1, 'Montes de Oca'),
(16, 1, 'Turrubares'),
(17, 1, 'Dota'),
(18, 1, 'Curridabat'),
(19, 1, 'Perez Zeledon'),
(20, 1, 'Leon Cortes'),
(21, 2, 'Alajuela'),
(22, 2, 'San Ramon'),
(23, 2, 'Grecia'),
(24, 2, 'San Mateo'),
(25, 2, 'Atenas'),
(26, 2, 'Naranjo'),
(27, 2, 'Palmares'),
(28, 2, 'Poas'),
(29, 2, 'Orotina'),
(30, 2, 'San Carlos'),
(31, 2, 'Alfaro Ruiz'),
(32, 2, 'Valverde Vega'),
(33, 2, 'Upala'),
(34, 2, 'Los Chiles'),
(35, 2, 'Guatuso'),
(36, 3, 'Cartago'),
(37, 3, 'Paraiso'),
(38, 3, 'La Union'),
(39, 3, 'Jimenez'),
(40, 3, 'Turrialba'),
(41, 3, 'Alvarado'),
(42, 3, 'Oreamuno'),
(43, 3, 'El Guarco'),
(44, 4, 'Heredia'),
(45, 4, 'Barva'),
(46, 4, 'Santo Domingo'),
(47, 4, 'Santa Barbara'),
(48, 4, 'San Rafael'),
(49, 4, 'San Isidro'),
(50, 4, 'Belen'),
(51, 4, 'Flores'),
(52, 4, 'San Pablo'),
(53, 4, 'Sarapiqui'),
(54, 5, 'Liberia'),
(55, 5, 'Nicoya'),
(56, 5, 'Santa Cruz'),
(57, 5, 'Bagaces'),
(58, 5, 'Carrillo'),
(59, 5, 'Cañas'),
(60, 5, 'Abangares'),
(61, 5, 'Tilaran'),
(62, 5, 'Nandayure'),
(63, 5, 'La Cruz'),
(64, 5, 'Hojancha'),
(65, 6, 'Puntarenas'),
(66, 6, 'Esparza'),
(67, 6, 'Buenos Aires'),
(68, 6, 'Montes de Oro'),
(69, 6, 'Osa'),
(70, 6, 'Aguirre'),
(71, 6, 'Golfito'),
(72, 6, 'Coto Brus'),
(73, 6, 'Parrita'),
(74, 6, 'Corredores'),
(75, 6, 'Garabito'),
(76, 7, 'Limon'),
(77, 7, 'Pococí'),
(78, 7, 'Siquirres'),
(79, 7, 'Talamanca'),
(80, 7, 'Matina'),
(81, 7, 'Guacimo');
SET IDENTITY_INSERT Ciudad OFF;

DELETE FROM Direccion;
SET IDENTITY_INSERT Direccion ON;
INSERT INTO Direccion (idDireccion, fk_idCiudad, Señal1, ZipCode, Latitud, Longitud) VALUES
(1, 1, 'Carmen', '10101', '9.9359945', '-84.0669545'),
(2, 1, 'Merced', '10102', '9.9405627', '-84.0894043'),
(3, 1, 'Hospital', '10103', '9.9252418', '-84.0880839'),
(4, 1, 'Catedral', '10104', '9.9249628', '-84.0722375'),
(5, 1, 'Zapote', '10105', '9.9195070', '-84.0553590'),
(6, 1, 'San Francisco de Dos Rios', '10106', '9.9080918', '-84.0616709'),
(7, 1, 'Uruca', '10107', '9.9500000', '-84.1000000'),
(8, 1, 'Mata Redonda', '10108', '9.9305600', '-84.1072000'),
(9, 1, 'Pavas', '10109', '9.9442760', '-84.1358110'),
(10, 1, 'Hatillo', '10110', '9.9199576', '-84.1039262'),
(11, 1, 'San Sebastian', '10111', '9.9084637', '-84.0828023'),
(12, 2, 'Escazu', '10201', '9.9491851', '-84.1518295'),
(13, 2, 'San Antonio', '10202', '9.9050000', '-84.1291667'),
(14, 2, 'San Rafael', '10203', '9.9333333', '-84.1333333'),
(15, 3, 'Desamparados', '10301', '9.8983577', '-84.0647835'),
(16, 3, 'San Miguel', '10302', '9.1469810', '-83.6071240'),
(17, 3, 'San Juan de Dios', '10303', '9.9315369', '-84.0797961'),
(18, 3, 'San Rafael Arriba', '10304', '9.8766101', '-84.0836048'),
(19, 3, 'San Antonio', '10305', '9.9193029', '-84.0763854'),
(20, 3, 'Frailes', '10306', '9.8969706', '-84.0616709'),
(21, 3, 'Patarra', '10307', '9.8916667', '-84.0708333'),
(22, 3, 'San Cristobal', '10308', '9.8969706', '-84.0616709'),
(23, 3, 'Rosario', '10309', '16.2372168', '-92.1321636'),
(24, 3, 'Damas', '10310', '9.9357713', '-84.0797802'),
(25, 3, 'San Rafael Abajo', '10311', '9.9000000', '-84.0833333'),
(26, 3, 'Gravilias', '10312', '9.8952690', '-84.0594355'),
(27, 3, 'Los Guido', '10313', '9.8916667', '-84.0708333'),
(28, 4, 'Santiago', '10401', '9.8413220', '-84.3153990'),
(29, 4, 'Mercedes Sur', '10402', '9.9271280', '-84.0820120'),
(30, 4, 'Barbacoas', '10403', '9.9271280', '-84.0820120'),
(31, 4, 'Grifo Alto', '10404', '9.9271280', '-84.0820120'),
(32, 4, 'San Rafael', '10405', '9.8391500', '-84.2905200'),
(33, 4, 'Candelaria', '10406', '9.9271280', '-84.0820120'),
(34, 4, 'Desamparaditos', '10407', '9.9271280', '-84.0820120'),
(35, 4, 'San Antonio', '10408', '9.9271280', '-84.0820120'),
(36, 4, 'Chires', '10409', '9.9271280', '-84.0820120'),
(37, 5, 'San Marcos', '10501', '9.6527680', '-84.0212780'),
(38, 5, 'San Lorenzo', '10502', '9.6426690', '-84.0326160'),
(39, 5, 'San Carlos', '10503', '9.6174982', '-84.1118458'),
(40, 6, 'Aserri', '10601', '9.8613205', '-84.1041988'),
(41, 6, 'Tarbaca', '10602', '9.7891667', '-84.1091667'),
(42, 6, 'Vuelta de Jorco', '10603', '9.7950040', '-84.1276170'),
(43, 6, 'San Gabriel', '10604', '9.7895690', '-84.1067960'),
(44, 6, 'Legua', '10605', '9.7472222', '-84.1452778'),
(45, 6, 'Monterrey', '10606', '9.9306069', '-84.0761054'),
(46, 6, 'Salitrillos', '10607', '9.8573477', '-84.0905596'),
(47, 7, 'Colon', '10701', '9.9161468', '-84.2425659'),
(48, 7, 'Guayabo', '10702', '19.4127566', '-102.0137082'),
(49, 7, 'Tabarcia', '10703', '9.9331193', '-84.0777949'),
(50, 7, 'Piedras Negras', '10704', '19.4504074', '-99.2474496'),
(51, 7, 'Picagres', '10705', '9.9331193', '-84.0777949'),
(52, 8, 'Guadalupe', '10801', '9.9477778', '-84.0547222'),
(53, 8, 'San Francisco', '10802', '9.9423579', '-84.0728979'),
(54, 8, 'Calle Blancos', '10803', '9.9500000', '-84.0666667'),
(55, 8, 'Mata de Platano', '10804', '9.9540461', '-84.0155196'),
(56, 8, 'Ipis', '10805', '9.9643819', '-84.0207080'),
(57, 8, 'Rancho Redondo', '10806', '9.9619520', '-83.9509350'),
(58, 8, 'Purral', '10807', '9.9562534', '-84.0324242'),
(59, 9, 'Santa Ana', '10901', '9.9338889', '-84.1833333'),
(60, 9, 'Salitral', '10902', '9.9338889', '-84.1833333'),
(61, 9, 'Pozos', '10903', '9.9492247', '-84.1906410'),
(62, 9, 'Uruca', '10904', '9.9369015', '-84.0853536'),
(63, 9, 'Piedades', '10905', '9.9360177', '-84.2221892'),
(64, 9, 'Brasil', '10906', '19.8391047', '-90.5280054'),
(65, 10, 'Alajuelita', '11001', '9.9203042', '-84.1120322'),
(66, 10, 'San Josecito', '11002', '9.8968084', '-84.1008353'),
(67, 10, 'San Antonio', '11003', '9.8858110', '-84.1144180'),
(68, 10, 'Concepcion', '11004', '9.8901339', '-84.0888458'),
(69, 10, 'San Felipe', '11005', '9.9074670', '-84.1052462'),
(70, 11, 'San Isidro', '11101', '9.9760730', '-84.0068775'),
(71, 11, 'San Rafael', '11102', '9.9683658', '-84.0491207'),
(72, 11, 'Dulce Nombre de Jesus', '11103', '9.9844872', '-84.0191465'),
(73, 11, 'Patalillo', '11104', '9.9929583', '-83.9850080'),
(74, 11, 'Cascajal', '11105', '10.0065980', '-83.9581530'),
(75, 12, 'San Ignacio de Acosta', '11201', '9.7979876', '-84.1624188'),
(76, 12, 'Guaitil', '11202', '9.9271280', '-84.0820120'),
(77, 12, 'Palmichal', '11203', '9.9271280', '-84.0820120'),
(78, 12, 'Cangrejal', '11204', '9.9271280', '-84.0820120'),
(79, 12, 'Sabanillas', '11205', '9.9287998', '-84.0763092'),
(80, 13, 'San Juan', '11301', '9.9622000', '-84.0810090'),
(81, 13, 'Cinco esquinas', '11302', '9.9466936', '-84.0821420'),
(82, 13, 'Anselmo Llorente', '11303', '9.9553305', '-84.0693646'),
(83, 13, 'Leon XIII', '11304', '9.9602225', '-84.0999660'),
(84, 13, 'Colima', '11305', '9.9536717', '-84.0834625'),
(85, 14, 'San Vicente', '11401', '9.9634381', '-84.0458176'),
(86, 14, 'San Jeronimo', '11402', '9.9648240', '-84.0847830'),
(87, 14, 'Trinidad', '11403', '9.9799446', '-84.0352464'),
(88, 15, 'San Pedro', '11501', '9.9333333', '-84.0500000'),
(89, 15, 'Sabanilla', '11502', '9.9450974', '-84.0312817'),
(90, 15, 'Mercedes', '11503', '9.9425975', '-84.0471389'),
(91, 15, 'San Rafael', '11504', '9.9458041', '-83.9929431'),
(92, 16, 'San Pablo', '11601', '9.9271280', '-84.0820120'),
(93, 16, 'San Pedro', '11602', '9.9271280', '-84.0820120'),
(94, 16, 'San Juan de Mata', '11603', '9.9271280', '-84.0820120'),
(95, 16, 'San Luis', '11604', '9.9271280', '-84.0820120'),
(96, 16, 'Carara', '11605', '9.8560998', '-84.5158566'),
(97, 17, 'Santa Maria', '11701', '9.6500000', '-83.9666667'),
(98, 17, 'Jardin', '11702', '9.7142810', '-83.9694600'),
(99, 17, 'Copey', '11703', '9.6500000', '-83.9166667'),
(100, 18, 'Curridabat', '11801', '9.9136680', '-84.0390170'),
(101, 18, 'Granadilla', '11802', '9.9333333', '-84.0166667'),
(102, 18, 'Sanchez', '11803', '9.9103585', '-84.0326033'),
(103, 18, 'Tirrases', '11804', '9.9042578', '-84.0447908'),
(104, 19, 'San Isidro del General', '11901', '9.3689579', '-83.7069170'),
(105, 19, 'General', '11902', '9.3726440', '-83.6622469'),
(106, 19, 'Daniel Flores', '11903', '9.3291979', '-83.6734049'),
(107, 19, 'Rivas', '11904', '9.4193734', '-83.6594456'),
(108, 19, 'San Pedro', '11905', '9.2761690', '-83.5496060'),
(109, 19, 'Platanares', '11906', '9.3547300', '-83.6348430'),
(110, 19, 'Pejibaye', '11907', '9.1571660', '-83.5696330'),
(111, 19, 'Cajon', '11908', '9.2901120', '-83.5830460'),
(112, 19, 'Baru', '11909', '9.2817110', '-83.8450320'),
(113, 19, 'Rio Nuevo', '11910', '9.4191470', '-83.7951350'),
(114, 19, 'Paramo', '11911', '9.5333333', '-83.7166667'),
(115, 20, 'San Pablo', '12001', '9.6912136', '-84.0457159'),
(116, 20, 'San Andres', '12002', '9.7335125', '-84.0854432'),
(117, 20, 'Llano Bonito', '12003', '37.6570069', '-2.7715290'),
(118, 20, 'San Isidro', '12004', '9.6751243', '-84.0775201'),
(119, 20, 'Santa Cruz', '12005', '9.7325963', '-84.0326033'),
(120, 20, 'San Antonio', '12006', '9.9263803', '-84.1348003'),
(121, 21, 'Alajuela', '20101', '10.0164400', '-84.2212600'),
(122, 21, 'San Jose', '20102', '10.0170529', '-84.2463188'),
(123, 21, 'Carrizal', '20103', '10.0867332', '-84.1685722'),
(124, 21, 'San Antonio', '20104', '10.0164400', '-84.2212600'),
(125, 21, 'Guacima', '20105', '9.9666670', '-84.2500000'),
(126, 21, 'San Isidro', '20106', '10.8310630', '-84.6675720'),
(127, 21, 'Sabanilla', '20107', '10.0770030', '-84.2153010'),
(128, 21, 'San Rafael', '20108', '9.9691348', '-84.2120700'),
(129, 21, 'Rio Segundo', '20109', '10.0055599', '-84.1880259'),
(130, 21, 'Desamparados', '20110', '10.0166667', '-84.1833333'),
(131, 21, 'Turrucares', '20111', '9.9607710', '-84.3199080'),
(132, 21, 'Tambor', '20112', '10.0372585', '-84.2402458'),
(133, 21, 'Garita', '20113', '9.9854500', '-84.3381810'),
(134, 21, 'Sarapiqui', '20114', '10.4735230', '-84.0167423'),
(135, 22, 'San Ramon', '20201', '10.0869889', '-84.4700083'),
(136, 22, 'Santiago', '20202', '10.0618760', '-84.4869380'),
(137, 22, 'San Juan', '20203', '10.1170910', '-84.3988800'),
(138, 22, 'Piedades Norte', '20204', '10.1356500', '-84.5093230'),
(139, 22, 'Piedades Sur', '20205', '10.1177040', '-84.5329210'),
(140, 22, 'San Rafael', '20206', '10.0707740', '-84.4566458'),
(141, 22, 'San Isidro', '20207', '10.4695710', '-84.5478670'),
(142, 22, 'angeles', '20208', '10.4377052', '-84.5666599'),
(143, 22, 'Alfaro', '20209', '10.0786980', '-84.5098270'),
(144, 22, 'Volio', '20210', '10.1297710', '-84.4577940'),
(145, 22, 'Concepcion', '20211', '10.0923694', '-84.4146403'),
(146, 22, 'Zapotal', '20212', '10.1592740', '-84.6522449'),
(147, 22, 'Peñas Blancas', '20213', '10.1181660', '-84.6668470'),
(148, 23, 'Grecia', '20301', '10.0722222', '-84.3111111'),
(149, 23, 'San Isidro', '20302', '10.1165830', '-84.2746810'),
(150, 23, 'San Jose', '20303', '10.0170529', '-84.2463188'),
(151, 23, 'San Roque', '20304', '10.0966421', '-84.3007135'),
(152, 23, 'Tacares', '20305', '10.0324680', '-84.2923579'),
(153, 23, 'Rio Cuarto', '20306', '10.3305951', '-84.2291968'),
(154, 23, 'Puente de Piedra', '20307', '10.0474760', '-84.3164600'),
(155, 23, 'Bolivar', '20308', '10.0685650', '-84.3103520'),
(156, 24, 'San Mateo', '20401', '9.9367910', '-84.5235296'),
(157, 24, 'Desmonte', '20402', '9.9602210', '-84.4672700'),
(158, 24, 'Jesus Maria', '20403', '10.0304010', '-84.5140610'),
(159, 25, 'Atenas', '20501', '9.9815900', '-84.3803710'),
(160, 25, 'Jesus', '20502', '9.9700531', '-84.4303959'),
(161, 25, 'Mercedes', '20503', '9.9789910', '-84.3786700'),
(162, 25, 'San Isidro', '20504', '10.0062160', '-84.4342420'),
(163, 25, 'Concepcion', '20505', '9.9390470', '-84.4709320'),
(164, 25, 'San Jose', '20506', '9.9670507', '-84.4172666'),
(165, 25, 'Santa Eulalia', '20507', '10.0186320', '-84.3664320'),
(166, 25, 'Escobal', '20508', '9.9337610', '-84.4341280'),
(167, 26, 'Naranjo', '20601', '10.1000000', '-84.3833333'),
(168, 26, 'San Miguel', '20602', '10.1188473', '-84.2917338'),
(169, 26, 'San Jose', '20603', '10.0156769', '-84.2176428'),
(170, 26, 'Cirri Sur', '20604', '10.1000000', '-84.3833333'),
(171, 26, 'San Jeronimo', '20605', '10.1114740', '-84.3328090'),
(172, 26, 'San Juan', '20606', '10.1170910', '-84.3988800'),
(173, 26, 'Rosario', '20607', '10.0482530', '-84.3804780'),
(174, 26, 'Palmitos', '20608', '10.0939183', '-84.4238316'),
(175, 27, 'Palmares', '20701', '10.0607270', '-84.4378495'),
(176, 27, 'Zaragoza', '20702', '10.0455550', '-84.4301070'),
(177, 27, 'Buenos Aires', '20703', '10.0710930', '-84.4352110'),
(178, 27, 'Santiago', '20704', '10.0618760', '-84.4869380'),
(179, 27, 'Candelaria', '20705', '10.0607270', '-84.4378495'),
(180, 27, 'Esquipulas', '20706', '10.0666667', '-84.4166667'),
(181, 27, 'Granja', '20707', '10.0607270', '-84.4378495'),
(182, 28, 'San Pedro', '20801', '10.0712400', '-84.2465590'),
(183, 28, 'San Juan', '20802', '10.0991734', '-84.2423680'),
(184, 28, 'San Rafael', '20803', '10.0164400', '-84.2212600'),
(185, 28, 'Carrillos', '20804', '10.0333000', '-84.2667000'),
(186, 28, 'Sabana Redonda', '20805', '10.1166667', '-84.2166667'),
(187, 29, 'Orotina', '20901', '9.9113889', '-84.5236111'),
(188, 29, 'Mastate', '20902', '9.9140920', '-84.5635530'),
(189, 29, 'Hacienda Vieja', '20903', '9.9113889', '-84.5236111'),
(190, 29, 'Coyolar', '20904', '9.9017650', '-84.5546110'),
(191, 29, 'Ceiba', '20905', '9.9000000', '-84.6000000'),
(192, 30, 'Quesada', '21001', '10.3238966', '-84.4303232'),
(193, 30, 'Florencia', '21002', '9.9340874', '-84.0844941'),
(194, 30, 'Buenavista', '21003', '9.9340874', '-84.0844941'),
(195, 30, 'Aguas Zarcas', '21004', '10.3915830', '-84.4382721'),
(196, 30, 'Venecia', '21005', '10.3915830', '-84.4382721'),
(197, 30, 'Pital', '21006', '10.3238966', '-84.4303232'),
(198, 30, 'Fortuna', '21007', '10.4693443', '-84.6465629'),
(199, 30, 'Tigra', '21008', '10.3915830', '-84.4382721'),
(200, 30, 'Palmera', '21009', '9.9340874', '-84.0844941'),
(201, 30, 'Venado', '21010', '10.3915830', '-84.4382721'),
(202, 30, 'Cutris', '21011', '10.7651721', '-84.3893073'),
(203, 30, 'Monterrey', '21012', '9.9355488', '-84.0501711'),
(204, 30, 'Pocosol', '21013', '10.3915830', '-84.4382721'),
(205, 31, 'Zarcero', '21101', '10.1833333', '-84.4000000'),
(206, 31, 'Laguna', '21102', '10.2113680', '-84.4020770'),
(207, 31, 'Tapezco', '21103', '10.2220730', '-84.4060669'),
(208, 31, 'Guadalupe', '21104', '10.2347095', '-84.4172666'),
(209, 31, 'Palmira', '21105', '10.2117609', '-84.3809360'),
(210, 31, 'Zapote', '21106', '10.2290870', '-84.4261090'),
(211, 31, 'Brisas', '21107', '10.2347095', '-84.4172666'),
(212, 32, 'Sarchi Norte', '21201', '10.0912480', '-84.3504410'),
(213, 32, 'Sarchi Sur', '21202', '10.0841288', '-84.3397438'),
(214, 32, 'Toro Amarillo', '21203', '10.2325284', '-84.2910759'),
(215, 32, 'San Pedro', '21204', '10.2325284', '-84.2910759'),
(216, 32, 'Rodriguez', '21205', '10.2325284', '-84.2910759'),
(217, 33, 'Upala', '21301', '10.8894000', '-85.0177990'),
(218, 33, 'Aguas Claras', '21302', '10.8915800', '-85.0140610'),
(219, 33, 'San Jose (Pizote)', '21303', '10.8915800', '-85.0140610'),
(220, 33, 'Bijagua', '21304', '10.8915800', '-85.0140610'),
(221, 33, 'Delicias', '21305', '10.8915800', '-85.0140610'),
(222, 33, 'Dos Rios', '21306', '10.8915800', '-85.0140610'),
(223, 33, 'Yoliyllal', '21307', '10.8915800', '-85.0140610'),
(224, 34, 'Los Chiles', '21401', '11.0352770', '-84.7061080'),
(225, 34, 'Caño Negro', '21402', '10.8924100', '-84.7956700'),
(226, 34, 'El Amparo', '21403', '10.8500000', '-84.7000000'),
(227, 34, 'San Jorge', '21404', '10.8997520', '-84.9152070'),
(228, 35, 'San Rafael', '21501', '10.6724500', '-84.8255770'),
(229, 35, 'Buenavista', '21502', '10.7425979', '-84.8325270'),
(230, 35, 'Cote', '21503', '10.5833333', '-84.9333333'),
(231, 35, 'Katira', '21504', '10.6724500', '-84.8255770'),
(232, 36, 'Oriental', '30101', '9.9297787', '-84.0767360'),
(233, 36, 'Occidental', '30102', '9.8568719', '-83.9208300'),
(234, 36, 'Carmen', '30103', '9.8652201', '-83.9222344'),
(235, 36, 'San Nicolas', '30104', '9.8750945', '-83.9329493'),
(236, 36, 'Aguacaliente (San Francisco)', '30105', '9.8568719', '-83.9208300'),
(237, 36, 'Guadalupe (Arenilla)', '30106', '9.8568719', '-83.9208300'),
(238, 36, 'Corralillo', '30107', '9.7943070', '-84.0366590'),
(239, 36, 'Tierra Blanca', '30108', '9.9170480', '-83.8923870'),
(240, 36, 'Dulce Nombre', '30109', '9.9832590', '-83.6579498'),
(241, 36, 'Llano Grande', '30110', '9.9412610', '-83.9107820'),
(242, 36, 'Quebradilla', '30111', '9.8436129', '-83.9909594'),
(243, 37, 'Paraiso', '30201', '9.8273563', '-83.8684595'),
(244, 37, 'Santiago', '30202', '-12.1362243', '-76.9565094'),
(245, 37, 'Orosi', '30203', '9.8397031', '-83.8647802'),
(246, 37, 'Cachi', '30204', '9.8245610', '-83.8194578'),
(247, 37, 'Llanos de Santa Lucia', '30205', '9.8386460', '-83.8675839'),
(248, 38, 'Tres Rios', '30301', '9.9075360', '-83.9850820'),
(249, 38, 'San Diego', '30302', '9.9091751', '-84.0103464'),
(250, 38, 'San Juan', '30303', '1.6180200', '-77.1391100'),
(251, 38, 'San Rafael', '30304', '9.9166667', '-83.9833333'),
(252, 38, 'Concepcion', '30305', '9.9235557', '-83.9929431'),
(253, 38, 'Dulce Nombre', '30306', '9.9166667', '-83.9833333'),
(254, 38, 'San Ramon', '30307', '9.9412369', '-83.9928060'),
(255, 38, 'Rio Azul', '30308', '9.9355356', '-84.0502314'),
(256, 39, 'Juan Viñas', '30401', '9.8918145', '-83.7629414'),
(257, 39, 'Tucurrique', '30402', '9.8530730', '-83.7231260'),
(258, 39, 'Pejibaye', '30403', '9.7539596', '-83.6773928'),
(259, 40, 'Turrialba', '30501', '9.9011070', '-83.6845470'),
(260, 40, 'La Suiza', '30502', '9.8523330', '-83.6135100'),
(261, 40, 'Peralta', '30503', '9.9683440', '-83.6143340'),
(262, 40, 'Santa Cruz', '30504', '9.9011070', '-83.6845470'),
(263, 40, 'Santa Teresita', '30505', '9.9763010', '-83.6459500'),
(264, 40, 'Pavones', '30506', '9.9026669', '-83.6231230'),
(265, 40, 'Tuis', '30507', '9.8405862', '-83.5849231'),
(266, 40, 'Tayutic', '30508', '9.8349306', '-83.5727969'),
(267, 40, 'Santa Rosa', '30509', '9.9263900', '-83.6978759'),
(268, 40, 'Tres Equis', '30510', '9.9585319', '-83.5961187'),
(269, 40, 'La Isabel', '30511', '9.9198432', '-83.6767281'),
(270, 40, 'Chirripo', '30512', '9.9011070', '-83.6845470'),
(271, 41, 'Pacayas', '30601', '9.9162604', '-83.8106257'),
(272, 41, 'Cervantes', '30602', '9.7539596', '-83.6773928'),
(273, 41, 'Capellades', '30603', '9.7539596', '-83.6773928'),
(274, 42, 'San Rafael', '30701', '9.8693551', '-83.9043871'),
(275, 42, 'Cot', '30702', '9.7539596', '-83.6773928'),
(276, 42, 'Potrero Cerrado', '30703', '9.7539596', '-83.6773928'),
(277, 42, 'Cipreses', '30704', '9.7539596', '-83.6773928'),
(278, 42, 'Santa Rosa', '30705', '9.7539596', '-83.6773928'),
(279, 43, 'Tejar', '30801', '9.8416110', '-83.9460450'),
(280, 43, 'San Isidro', '30802', '9.8283590', '-83.9528880'),
(281, 43, 'Tobosi', '30803', '9.8449899', '-83.9840930'),
(282, 43, 'Patio de Agua', '30804', '9.7539596', '-83.6773928'),
(283, 44, 'Heredia', '40101', '9.9980483', '-84.1144854'),
(284, 44, 'Mercedes', '40102', '10.0102670', '-84.1320190'),
(285, 44, 'San Francisco', '40103', '9.9927599', '-84.1303207'),
(286, 44, 'Ulloa', '40104', '9.9752080', '-84.1418070'),
(287, 44, 'Varablanca', '40105', '10.1679900', '-84.1581570'),
(288, 45, 'Barva', '40201', '10.0208333', '-84.1233333'),
(289, 45, 'San Pedro', '40202', '10.0291780', '-84.1381544'),
(290, 45, 'San Pablo', '40203', '10.0224327', '-84.1275876'),
(291, 45, 'San Roque', '40204', '10.0166667', '-84.1333333'),
(292, 45, 'Santa Lucia', '40205', '10.0163370', '-84.1205066'),
(293, 45, 'San Jose de la Montaña', '40206', '10.0439199', '-84.1105259'),
(294, 46, 'Santo Domingo', '40301', '9.9796973', '-84.0896612'),
(295, 46, 'San Vicente', '40302', '9.9643133', '-84.0408022'),
(296, 46, 'San Miguel', '40303', '9.9654930', '-84.0595078'),
(297, 46, 'Paracito', '40304', '9.9795612', '-84.0920449'),
(298, 46, 'Santo Tomas', '40305', '9.9449061', '-84.0596895'),
(299, 46, 'Santa Rosa', '40306', '9.9721316', '-84.0982845'),
(300, 46, 'Tures', '40307', '9.9795612', '-84.0920449'),
(301, 46, 'Para', '40308', '9.9795612', '-84.0920449'),
(302, 47, 'Santa Barbara', '40401', '19.2716957', '-103.7469651'),
(303, 47, 'San Pedro', '40402', '10.0415462', '-84.1599361'),
(304, 47, 'San Juan', '40403', '9.9434937', '-84.1375772'),
(305, 47, 'Jesus', '40404', '9.9971778', '-84.1192795'),
(306, 47, 'Santo Domingo', '40405', '9.9971778', '-84.1192795'),
(307, 47, 'Puraba', '40406', '10.0415462', '-84.1599361'),
(308, 48, 'San Rafael', '40501', '10.0147500', '-84.0989900'),
(309, 48, 'San Josecito', '40502', '10.0144716', '-84.0986459'),
(310, 48, 'Santiago', '40503', '10.0166667', '-84.1000000'),
(311, 48, 'angeles', '40504', '9.9683658', '-84.0491207'),
(312, 48, 'Concepcion', '40505', '10.0144716', '-84.0986459'),
(313, 49, 'San Isidro', '40601', '10.0173978', '-84.0550661'),
(314, 49, 'San Jose', '40602', '10.0187130', '-84.0580290'),
(315, 49, 'Concepcion', '40603', '10.0263345', '-84.0468371'),
(316, 49, 'San Francisco', '40604', '9.9959773', '-84.1312254'),
(317, 50, 'San Antonio', '40701', '9.9769817', '-84.1830750'),
(318, 50, 'Ribera', '40702', '9.9883945', '-84.1835205'),
(319, 50, 'Asuncion', '40703', '9.9439007', '-84.1210840'),
(320, 51, 'San Joaquín de Flores', '40801', '10.0034605', '-84.1517705'),
(321, 51, 'Barrantes', '40802', '10.0016198', '-84.1593413'),
(322, 51, 'Llorente', '40803', '9.9988380', '-84.1579664'),
(323, 52, 'San Pablo', '40901', '9.9976754', '-84.0933652'),
(324, 52, 'Rincón de Sabanilla', '40902', '9.9329504', '-84.0790316'),
(325, 53, 'Puerto Viejo', '41001', '10.4555556', '-84.0055556'),
(326, 53, 'La Virgen', '41002', '10.4050350', '-84.1355210'),
(327, 53, 'Horquetas', '41003', '10.3352857', '-83.9506104'),
(328, 53, 'Llanuras del Gaspar', '41004', '10.4555556', '-84.0055556'),
(329, 53, 'Cureña', '41005', '10.4555556', '-84.0055556'),
(330, 54, 'Liberia', '50101', '10.6293130', '-85.4416020'),
(331, 54, 'Cañas Dulces', '50102', '10.6306500', '-85.4400790'),
(332, 54, 'Mayorga', '50103', '10.6306500', '-85.4400790'),
(333, 54, 'Nacascolo', '50104', '10.6306500', '-85.4400790'),
(334, 54, 'Curubande', '50105', '10.6306500', '-85.4400790'),
(335, 55, 'Nicoya', '50201', '10.1400307', '-85.4494500'),
(336, 55, 'Mansion', '50202', '10.1446600', '-85.4522710'),
(337, 55, 'San Antonio', '50203', '10.1446600', '-85.4522710'),
(338, 55, 'Quebrada Honda', '50204', '10.1446600', '-85.4522710'),
(339, 55, 'Samara', '50205', '10.1446600', '-85.4522710'),
(340, 55, 'Nosara', '50206', '10.1446600', '-85.4522710'),
(341, 55, 'Belen de Nosarita', '50207', '10.1446600', '-85.4522710'),
(342, 56, 'Santa Cruz', '50301', '10.2613353', '-85.5840701'),
(343, 56, 'Bolson', '50302', '10.2666667', '-85.5833333'),
(344, 56, 'Veintisiete de Abril', '50303', '10.2666667', '-85.5833333'),
(345, 56, 'Tempate', '50304', '10.2666667', '-85.5833333'),
(346, 56, 'Cartagena', '50305', '10.2666667', '-85.5833333'),
(347, 56, 'Cuajiniquil', '50306', '10.2666667', '-85.5833333'),
(348, 56, 'Diria', '50307', '10.2694853', '-85.5875355'),
(349, 56, 'Cabo Velas', '50308', '10.2666667', '-85.5833333'),
(350, 56, 'Tamarindo', '50309', '10.2666667', '-85.5833333'),
(351, 57, 'Bagaces', '50401', '10.5188300', '-85.2542500'),
(352, 57, 'Fortuna', '50402', '10.5188300', '-85.2542500'),
(353, 57, 'Mogote', '50403', '10.5188300', '-85.2542500'),
(354, 57, 'Rio Naranjo', '50404', '10.5188300', '-85.2542500'),
(355, 58, 'Filadelfia', '50501', '10.4469743', '-85.5516180'),
(356, 58, 'Palmira', '50502', '9.8688580', '-85.4813835'),
(357, 58, 'Sardinal', '50503', '10.5161573', '-85.6469357'),
(358, 58, 'Belen', '50504', '10.4077723', '-85.5867898'),
(359, 59, 'Cañas', '50601', '10.7666670', '-85.4833300'),
(360, 59, 'Palmira', '50602', '10.4266550', '-85.0958060'),
(361, 59, 'San Miguel', '50603', '9.9110714', '-84.0991008'),
(362, 59, 'Bebedero', '50604', '10.4266550', '-85.0958060'),
(363, 59, 'Porozal', '50605', '10.4266550', '-85.0958060'),
(364, 60, 'Juntas', '50701', '10.2818658', '-84.9649921'),
(365, 60, 'Sierra', '50702', '10.4957971', '-85.3549650'),
(366, 60, 'San Juan', '50703', '10.4957971', '-85.3549650'),
(367, 60, 'Colorado', '50704', '10.4957971', '-85.3549650'),
(368, 61, 'Tilaran', '50801', '10.4716667', '-84.9691667'),
(369, 61, 'Quebrada Grande', '50802', '10.4666667', '-84.9666667'),
(370, 61, 'Tronadora', '50803', '10.4666667', '-84.9666667'),
(371, 61, 'Santa Rosa', '50804', '10.4666667', '-84.9666667'),
(372, 61, 'Libano', '50805', '10.4255736', '-85.0011778'),
(373, 61, 'Tierras Morenas', '50806', '10.5641815', '-85.0322055'),
(374, 61, 'Arenal', '50807', '10.4748485', '-85.0001168'),
(375, 62, 'Carmona', '50901', '9.9946116', '-85.2527905'),
(376, 62, 'Santa Rita', '50902', '10.0252325', '-85.2036520'),
(377, 62, 'Zapotal', '50903', '10.0252325', '-85.2036520'),
(378, 62, 'San Pablo', '50904', '10.0405916', '-85.2131367'),
(379, 62, 'Porvenir', '50905', '10.0252325', '-85.2036520'),
(380, 62, 'Bejuco', '50906', '10.0252325', '-85.2036520'),
(381, 63, 'La Cruz', '51001', '11.0793852', '-85.6308805'),
(382, 63, 'Santa Cecilia', '51002', '11.0741900', '-85.6290970'),
(383, 63, 'Garita', '51003', '11.0741900', '-85.6290970'),
(384, 63, 'Santa Elena', '51004', '11.0741900', '-85.6290970'),
(385, 64, 'Hojancha', '51101', '10.0588889', '-85.4194444'),
(386, 64, 'Monte Romo', '51102', '10.0333333', '-85.3333333'),
(387, 64, 'Puerto Carrillo', '51103', '10.0562900', '-85.4184570'),
(388, 64, 'Huacas', '51104', '10.0549234', '-85.4142047'),
(389, 65, 'Puntarenas', '60101', '9.2169531', '-83.3361880'),
(390, 65, 'Pitahaya', '60102', '10.0167000', '-84.8111570'),
(391, 65, 'Chomes', '60103', '10.0438519', '-84.9082428'),
(392, 65, 'Lepanto', '60104', '9.9423250', '-85.0343320'),
(393, 65, 'Paquera', '60105', '9.8214963', '-84.9355768'),
(394, 65, 'Manzanillo', '60106', '9.6968440', '-85.2026600'),
(395, 65, 'Guacimal', '60107', '10.2101550', '-84.8458940'),
(396, 65, 'Barranca', '60108', '9.9833333', '-84.7166667'),
(397, 65, 'Monte Verde', '60109', '10.3069820', '-84.8097310'),
(398, 65, 'Isla del Coco', '60110', '5.5230608', '-87.0724164'),
(399, 65, 'Cobano', '60111', '9.6988010', '-85.1153790'),
(400, 65, 'Chacarita', '60112', '9.9833333', '-84.7833333'),
(401, 65, 'Chira', '60113', '10.1012919', '-85.1583064'),
(402, 65, 'Acapulco', '60114', '9.9778439', '-84.8294211'),
(403, 65, 'El Roble', '60115', '9.3722940', '-83.7483520'),
(404, 65, 'Arancibia', '60116', '10.2333330', '-84.7000000'),
(405, 66, 'Espiritu Santo', '60201', '9.9995353', '-84.6623021'),
(406, 66, 'San Juan Grande', '60202', '9.9906919', '-84.6673740'),
(407, 66, 'Macacona', '60203', '9.9779632', '-84.7536793'),
(408, 66, 'San Rafael', '60204', '9.9906919', '-84.6673740'),
(409, 66, 'San Jeronimo', '60205', '9.9779632', '-84.7536793'),
(410, 67, 'Buenos Aires', '60301', '9.1658329', '-83.3324970'),
(411, 67, 'Volcan', '60302', '9.2133327', '-83.4554201'),
(412, 67, 'Potrero Grande', '60303', '9.1672952', '-83.3308421'),
(413, 67, 'Boruca', '60304', '9.1672952', '-83.3308421'),
(414, 67, 'Pilas', '60305', '9.1672952', '-83.3308421'),
(415, 67, 'Colinas', '60306', '13.6798366', '-89.2003452'),
(416, 67, 'Changena', '60307', '9.1672952', '-83.3308421'),
(417, 67, 'Briolley', '60308', '9.1672952', '-83.3308421'),
(418, 67, 'Brunka', '60309', '9.1672952', '-83.3308421'),
(419, 68, 'Miramar', '60401', '9.2169531', '-83.3361880'),
(420, 68, 'Union', '60402', '9.2169531', '-83.3361880'),
(421, 68, 'San Isidro', '60403', '9.2169531', '-83.3361880'),
(422, 69, 'Puerto Cortes', '60501', '8.9556403', '-83.5245681'),
(423, 69, 'Palmar', '60502', '9.2169531', '-83.3361880'),
(424, 69, 'Sierpe', '60503', '9.2169531', '-83.3361880'),
(425, 69, 'Bahia Ballena', '60504', '9.2169531', '-83.3361880'),
(426, 69, 'Piedras Blancas', '60505', '9.2169531', '-83.3361880'),
(427, 70, 'Quepos', '60601', '9.2169531', '-83.3361880'),
(428, 70, 'Savegre', '60602', '9.2169531', '-83.3361880'),
(429, 70, 'Naranjito', '60603', '9.2169531', '-83.3361880'),
(430, 71, 'Golfito', '60701', '8.6538870', '-83.1814426'),
(431, 71, 'Puerto Jimenez', '60702', '8.6392330', '-83.1624070'),
(432, 71, 'Guaycara', '60703', '8.6392330', '-83.1624070'),
(433, 71, 'Pavon', '60704', '8.6392330', '-83.1624070'),
(434, 72, 'San Vito', '60801', '8.9093889', '-82.9331050'),
(435, 72, 'Sabalito', '60802', '8.9093889', '-82.9331050'),
(436, 72, 'Aguabuena', '60803', '8.9093889', '-82.9331050'),
(437, 72, 'Limoncito', '60804', '8.9093889', '-82.9331050'),
(438, 72, 'Pittier', '60805', '8.9093889', '-82.9331050'),
(439, 73, 'Parrita', '60901', '9.5218987', '-84.3285870'),
(440, 74, 'Corredor', '61001', '9.2169531', '-83.3361880'),
(441, 74, 'La Cuesta', '61002', '9.2169531', '-83.3361880'),
(442, 74, 'Canoas', '61003', '9.2169531', '-83.3361880'),
(443, 74, 'Laurel', '61004', '9.2169531', '-83.3361880'),
(444, 75, 'Jaco', '61101', '9.2169531', '-83.3361880'),
(445, 75, 'Tarcoles', '61102', '9.2169531', '-83.3361880'),
(446, 76, 'Limon', '70101', '9.9894240', '-83.0373940'),
(447, 76, 'Valle La Estrella', '70102', '16.7693242', '-93.1083422'),
(448, 76, 'Rio Blanco', '70103', '10.1800976', '-83.8335049'),
(449, 76, 'Matama', '70104', '9.7833333', '-83.2500000'),
(450, 77, 'Guapiles', '70201', '10.2167912', '-83.7801397'),
(451, 77, 'Jimenez', '70202', '10.1064393', '-83.5070203'),
(452, 77, 'Rita', '70203', '10.1064393', '-83.5070203'),
(453, 77, 'Roxana', '70204', '10.1064393', '-83.5070203'),
(454, 77, 'Cariari', '70205', '10.1064393', '-83.5070203'),
(455, 77, 'Colorado', '70206', '10.1064393', '-83.5070203'),
(456, 78, 'Siquirres', '70301', '10.1000000', '-83.5166667'),
(457, 78, 'Pacuarito', '70302', '10.0983532', '-83.5041672'),
(458, 78, 'Florida', '70303', '10.0962200', '-83.5115280'),
(459, 78, 'Germania', '70304', '10.0962200', '-83.5115280'),
(460, 78, 'Cairo', '70305', '10.1000000', '-83.5166667'),
(461, 78, 'Alegria', '70306', '10.0962200', '-83.5115280'),
(462, 79, 'Bratsi', '70401', '9.6239267', '-82.8543376'),
(463, 79, 'Sixaola', '70402', '10.1064393', '-83.5070203'),
(464, 79, 'Cahuita', '70403', '10.1064393', '-83.5070203'),
(465, 79, 'Telire', '70404', '9.5436145', '-83.1555604'),
(466, 80, 'Matina', '70501', '10.0786111', '-83.2922222'),
(467, 80, 'Battan', '70502', '10.0833333', '-83.2833333'),
(468, 80, 'Carrandi', '70503', '10.0833333', '-83.2833333'),
(469, 81, 'Guacimo', '70601', '10.2166667', '-83.6833333'),
(470, 81, 'Mercedes', '70602', '10.2127778', '-83.6866667'),
(471, 81, 'Pocora', '70603', '10.2127778', '-83.6866667'),
(472, 81, 'Rio Jimenez', '70604', '10.2127778', '-83.6866667'),
(473, 81, 'Duacari', '70605', '10.2127778', '-83.6866667');
SET IDENTITY_INSERT Direccion OFF;