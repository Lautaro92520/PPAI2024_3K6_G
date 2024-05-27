USE PPAI_Bonvino --Crear primero la base de datos
GO

CREATE TABLE Pais(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50)
);

CREATE TABLE Provincia(
	id INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(50),
	id_pais INT,
FOREIGN KEY (id_pais) REFERENCES Pais(id)
);

CREATE TABLE RegionVitivinicola(
	id INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR (100),
	nombre VARCHAR(50),
	id_provincia INT,
FOREIGN KEY (id_provincia) REFERENCES Provincia(id)
);

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

CREATE TABLE Enofilo(
	id INT PRIMARY KEY IDENTITY, 
	apellido VARCHAR(50),
	nombre VARCHAR(50),
	imagen_perfil VARCHAR(100),
);

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

CREATE TABLE TipoUva(
	id INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100),
	nombre VARCHAR (50)
);

CREATE TABLE Varietal (
	id INT PRIMARY KEY IDENTITY,
	porcentaje_composicion INT,
	descripcion VARCHAR(100),
	tipo_uva INT,
FOREIGN KEY (tipo_uva) REFERENCES TipoUva (id)
);

CREATE TABLE Sommelier(
	id INT PRIMARY KEY IDENTITY,
	fecha_validacion DATETIME,
	nombre VARCHAR(50),
	nota_presentacion VARCHAR(100)
);

CREATE TABLE Resena(
	id INT PRIMARY KEY IDENTITY,
	comentario VARCHAR(100),
	es_premium BIT,
	fecha_reseña DATETIME,
	puntaje INT,
	id_sommelier INT,
	id_vino INT,
	id_enofilo INT,
FOREIGN KEY (id_sommelier) REFERENCES Sommelier(id),
FOREIGN KEY (id_vino) REFERENCES Vino(id),
FOREIGN KEY (id_enofilo) REFERENCES Enofilo(id)
);