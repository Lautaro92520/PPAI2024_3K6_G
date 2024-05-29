USE PPAI_Bonvino --Crear primero la base de datos
GO

CREATE TABLE Pais(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50)
);

INSERT INTO Pais (nombre) VALUES ('Argentina');
INSERT INTO Pais (nombre) VALUES ('Chile');


CREATE TABLE Provincia(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50),
	id_pais INT,
FOREIGN KEY (id_pais) REFERENCES Pais(id)
);

INSERT INTO Provincia (nombre, id_pais) VALUES ('Mendoza', 1);
INSERT INTO Provincia (nombre, id_pais) VALUES ('San Juan', 1);


CREATE TABLE RegionVitivinicola(
	id INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR (100),
	nombre VARCHAR(50),
	id_provincia INT,
FOREIGN KEY (id_provincia) REFERENCES Provincia(id)
);

INSERT INTO RegionVitivinicola (descripcion, nombre, id_provincia) VALUES ('Region famosa por sus vinos', 'Valle de Uco', 1);
INSERT INTO RegionVitivinicola (descripcion, nombre, id_provincia) VALUES ('Otra región vinícola', 'Valle del Pedernal', 2);


CREATE TABLE Bodega(
	id INT PRIMARY KEY IDENTITY,
	coordenadas_ubicacion VARCHAR(100),
	descripcion VARCHAR(200),
	historia VARCHAR(200),
	nombre VARCHAR(50),
	periodo_actualizacion DATETIME,
	id_region INT,
FOREIGN KEY (id_region) REFERENCES RegionVitivinicola(id)
);

INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region)
VALUES ('-32.889458, -68.845839', 'Bodega con historia', 'Fundada en 1900', 'Bodega Norton', '2024-05-28', 1);

INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region)
VALUES ('-31.537500, -68.525000', 'Bodega reconocida', 'Fundada en 1950', 'Bodega Graffigna', '2024-05-28', 2);


CREATE TABLE Enofilo(
	id INT PRIMARY KEY IDENTITY, 
	apellido VARCHAR(50),
	nombre VARCHAR(50),
	imagen_perfil VARCHAR(100),
);

INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('López', 'Pedro', 'pedro.jpg');
INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('Rodríguez', 'Ana', 'ana.jpg');


CREATE TABLE Vino(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR (50) CONSTRAINT nombre_vino NOT NULL,
	anada INT,
	nota_cata_bodega VARCHAR(200),
	ruta_imagen_etiqueta VARCHAR (100), 
	precio_ars DECIMAL(11,2),
	id_bodega INT,
	id_enofilo INT,
FOREIGN KEY (id_bodega) REFERENCES Bodega(id),
FOREIGN KEY (id_enofilo) REFERENCES Enofilo(id)
);

INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo)
VALUES ('Malbec Reserva', 2018, 'Notas de frutas rojas y roble', 'malbec.jpg', 1500.00, 1, 1),
	('Cabernet Sauvignon', 2017, 'Cuerpo completo con notas de vainilla', 'cabernet.jpg', 2000.00, 2, 2),
	('Merlot Gran Reserva', 2019, 'Aromas de frutas negras maduras con toques de chocolate y vainilla', 'merlot.jpg', 1800.00, 1, 1),
	('Chardonnay Reserva', 2020, 'Notas de manzana verde, piña y ligeros toques de roble', 'chardonnay.jpg', 1600.00, 1, 2),
	('Syrah Premium', 2018, 'Sabores intensos de ciruela y mora, con un final especiado', 'syrah.jpg', 2200.00, 2, 1),
	('Pinot Noir Select', 2019, 'Aromas de cereza y frambuesa con un toque de tierra', 'pinot_noir.jpg', 2100.00, 2, 2),
	('Torrontés Especial', 2021, 'Notas florales de jazmín y azahar con un toque cítrico', 'torrontes.jpg', 1300.00, 1, 1),
	('Bonarda Clásico', 2017, 'Frutas rojas maduras y toques de hierbas frescas', 'bonarda.jpg', 1400.00, 1, 2),
	('Tempranillo Reserva', 2018, 'Aromas de frutos del bosque con notas de vainilla y tabaco', 'tempranillo.jpg', 1900.00, 2, 1),
	('Sauvignon Blanc Fresco', 2021, 'Aromas de limón, pomelo y toques herbales', 'sauvignon_blanc.jpg', 1500.00, 2, 2),
	('Cabernet Franc', 2019, 'Notas de frutas rojas, pimiento verde y un toque mineral', 'cabernet_franc.jpg', 2000.00, 1, 1),
	('Rosado de Syrah', 2020, 'Aromas de fresas y frambuesas con un final refrescante', 'rosado_syrah.jpg', 1200.00, 1, 2);


CREATE TABLE TipoUva(
	id INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100),
	nombre VARCHAR (50)
);

INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Malbec');
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Cabernet Sauvignon');


CREATE TABLE Varietal (
	id INT PRIMARY KEY IDENTITY,
	porcentaje_composicion INT,
	descripcion VARCHAR(100),
	tipo_uva INT,
FOREIGN KEY (tipo_uva) REFERENCES TipoUva (id)
);

INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva) VALUES (100, 'Varietal puro', 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva) VALUES (100, 'Varietal puro', 2);


CREATE TABLE Sommelier(
	id INT PRIMARY KEY IDENTITY,
	fecha_validacion DATETIME,
	nombre VARCHAR(50),
	nota_presentacion VARCHAR(100)
);

INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2024-05-28', 'Juan Pérez', 'Especialista en vinos tintos'),
('2024-05-28', 'María González', 'Experta en vinos blancos'),
('2023-03-15', 'Carlos Martínez', 'Amplia experiencia en vinos tintos de alta gama.'),
('2022-11-20', 'Lucía Fernández', 'Especialista en vinos blancos y rosados.'),
('2023-05-10', 'Martín López', 'Conocedor de vinos espumosos y champagnes.'),
('2023-01-05', 'Valeria Torres', 'Experta en maridaje de vinos con comida italiana.'),
('2022-12-15', 'Andrés Gómez', 'Especialista en vinos de regiones emergentes.'),
('2023-02-28', 'Sofía Rodríguez', 'Enfocada en vinos biodinámicos y naturales.'),
('2022-10-18', 'Esteban Díaz', 'Gran conocimiento en vinos fortificados y licores.'),
('2023-04-20', 'Mariana Ramírez', 'Pasión por los vinos de pequeñas bodegas artesanales.'),
('2023-03-05', 'Diego Pérez', 'Enólogo y sommelier, con énfasis en vinos orgánicos.'),
('2022-11-30', 'Ana Silva', 'Experta en vinos franceses y sus denominaciones.');


CREATE TABLE Resena(
	id INT PRIMARY KEY IDENTITY,
	comentario VARCHAR(100),
	es_premium BIT,
	fecha_rese�a DATETIME,
	puntaje INT,
	id_sommelier INT,
	id_vino INT,
	id_enofilo INT,
FOREIGN KEY (id_sommelier) REFERENCES Sommelier(id),
FOREIGN KEY (id_vino) REFERENCES Vino(id),
FOREIGN KEY (id_enofilo) REFERENCES Enofilo(id)
);

INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino, id_enofilo)
VALUES ('Excelente vino, muy recomendable', 1, '2024-05-28', 95, 1, 1, 1),
	('Buen vino pero un poco caro', 0, '2024-05-28', 88, 2, 2, 2),
	('Excelente cuerpo y aroma, uno de los mejores Merlot que he probado.', 1, '2024-05-28', 92, 1, 1, 1),
	('Un Chardonnay fresco y bien equilibrado, perfecto para el verano.', 0, '2024-05-28', 88, 9, 2, 2),
	('Intenso y especiado, ideal para acompañar carnes rojas.', 1, '2024-05-28', 90, 1, 3, 1),
	('Elegante y suave, con notas de cereza que destacan.', 0, '2024-05-28', 91, 2, 4, 2),
	('Aromas florales encantadores, perfecto como aperitivo.', 0, '2024-05-28', 85, 1, 5, 1),
	('Frutal y fresco, buen vino para el precio.', 0, '2024-05-28', 84, 2, 6, 2),
	('Complejo y con buen cuerpo, destaca por sus notas de tabaco.', 1, '2024-05-28', 89, 7, 7, 1),
	('Cítrico y refrescante, ideal para mariscos.', 0, '2024-05-28', 87, 2, 8, 2),
	('Notas de frutas rojas y pimiento, muy interesante.', 1, '2024-05-28', 86, 1, 9, 1),
	('Fresco y ligero, perfecto para días calurosos.', 0, '2024-05-28', 83, 2, 10, 2);,
	('Un Merlot redondo, con taninos suaves y un final persistente.', 0, '2024-05-29', 90, 10, 1, 2),
	('Chardonnay con un buen equilibrio entre acidez y fruta.', 1, '2024-05-29', 89, 1, 2, 1),
	('Syrah con mucha personalidad, especiado y robusto.', 0, '2024-05-29', 88, 2, 3, 2),
	('Pinot Noir elegante, con notas de frutas rojas y un toque terroso.', 1, '2024-05-29', 92, 1, 4, 1),
	('Torrontés fresco y aromático, ideal para una tarde de verano.', 0, '2024-05-29', 86, 6, 5, 2),
	('Bonarda fácil de beber, con buena relación calidad-precio.', 0, '2024-05-29', 85, 1, 6, 1),
	('Tempranillo bien estructurado, con notas de fruta madura y especias.', 1, '2024-05-29', 87, 2, 7, 2),
	('Sauvignon Blanc vivaz, con una acidez refrescante.', 0, '2024-05-29', 89, 5, 8, 1),
	('Cabernet Franc equilibrado, con notas herbales y frutales.', 1, '2024-05-29', 88, 2, 9, 2),
	('Rosado de Syrah ligero y refrescante, perfecto para un día caluroso.', 0, '2024-05-29', 84, 4, 10, 1);
