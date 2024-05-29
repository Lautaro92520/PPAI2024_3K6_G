USE PPAI_Bonvino
GO

INSERT INTO Pais (nombre) VALUES ('Argentina');
INSERT INTO Pais (nombre) VALUES ('Chile');
GO

INSERT INTO Provincia (nombre, id_pais) VALUES ('Mendoza', 1);
INSERT INTO Provincia (nombre, id_pais) VALUES ('San Juan', 1);
INSERT INTO Provincia (nombre, id_pais) VALUES ('Cordoba', 1);
GO

INSERT INTO RegionVitivinicola (descripcion, nombre, id_provincia) VALUES ('Region famosa por sus vinos', 'Valle de Uco', 1);
INSERT INTO RegionVitivinicola (descripcion, nombre, id_provincia) VALUES ('Otra región vinícola', 'Valle del Pedernal', 2);
GO

INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region) VALUES ('-32.889458, -68.845839', 'Bodega con historia', 'Fundada en 1900', 'Bodega Norton', '0000-04-00', 1);
INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region) VALUES ('-31.537500, -68.525000', 'Bodega reconocida', 'Fundada en 1950', 'Bodega Graffigna', '0000-04-00', 2);
GO

INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('López', 'Pedro', 'pedro.jpg');
INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('Rodríguez', 'Ana', 'ana.jpg');
GO

INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Malbec Reserva', 2018, 'Notas de frutas rojas y roble', 'malbec.jpg', 1500.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Cabernet Sauvignon', 2017, 'Cuerpo completo con notas de vainilla', 'cabernet.jpg', 2000.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Merlot Gran Reserva', 2019, 'Aromas de frutas negras maduras con toques de chocolate y vainilla', 'merlot.jpg', 1800.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Chardonnay Reserva', 2020, 'Notas de manzana verde, piña y ligeros toques de roble', 'chardonnay.jpg', 1600.00, 1, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Syrah Premium', 2018, 'Sabores intensos de ciruela y mora, con un final especiado', 'syrah.jpg', 2200.00, 2, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Pinot Noir Select', 2019, 'Aromas de cereza y frambuesa con un toque de tierra', 'pinot_noir.jpg', 2100.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Torrontés Especial', 2021, 'Notas florales de jazmín y azahar con un toque cítrico', 'torrontes.jpg', 1300.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Bonarda Clásico', 2017, 'Frutas rojas maduras y toques de hierbas frescas', 'bonarda.jpg', 1400.00, 1, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Tempranillo Reserva', 2018, 'Aromas de frutos del bosque con notas de vainilla y tabaco', 'tempranillo.jpg', 1900.00, 2, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Sauvignon Blanc Fresco', 2021, 'Aromas de limón, pomelo y toques herbales', 'sauvignon_blanc.jpg', 1500.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Cabernet Franc', 2019, 'Notas de frutas rojas, pimiento verde y un toque mineral', 'cabernet_franc.jpg', 2000.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Rosado de Syrah', 2020, 'Aromas de fresas y frambuesas con un final refrescante', 'rosado_syrah.jpg', 1200.00, 1, 2)
GO


INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Malbec')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Cabernet Sauvignon')
GO

INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva) VALUES (100, 'Varietal puro', 1, 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva) VALUES (100, 'Varietal puro', 2, 1);
GO

INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2024-05-28', 'Juan Pérez', 'Especialista en vinos tintos')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2024-05-28', 'María González', 'Experta en vinos blancos')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-03-15', 'Carlos Martínez', 'Amplia experiencia en vinos tintos de alta gama.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-11-20', 'Lucía Fernández', 'Especialista en vinos blancos y rosados.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-05-10', 'Martín López', 'Conocedor de vinos espumosos y champagnes.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-01-05', 'Valeria Torres', 'Experta en maridaje de vinos con comida italiana.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-12-15', 'Andrés Gómez', 'Especialista en vinos de regiones emergentes.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-02-28', 'Sofía Rodríguez', 'Enfocada en vinos biodinámicos y naturales.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-10-18', 'Esteban Díaz', 'Gran conocimiento en vinos fortificados y licores.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-04-20', 'Mariana Ramírez', 'Pasión por los vinos de pequeñas bodegas artesanales.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-03-05', 'Diego Pérez', 'Enólogo y sommelier, con énfasis en vinos orgánicos.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-11-30', 'Ana Silva', 'Experta en vinos franceses y sus denominaciones.')
GO

INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Excelente vino, muy recomendable', 1, '2024-05-28', 5, 1, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Buen vino pero un poco caro', 0, '2024-05-28', 4, 2, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Excelente cuerpo y aroma, uno de los mejores Merlot que he probado.', 1, '2024-05-28', 5, 1, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un Chardonnay fresco y bien equilibrado, perfecto para el verano.', 0, '2024-05-28', 4, 9, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Intenso y especiado, ideal para acompañar carnes rojas.', 1, '2024-05-28', 5, 1, 3)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Elegante y suave, con notas de cereza que destacan.', 0, '2024-05-28', 4, 2, 4)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Aromas florales encantadores, perfecto como aperitivo.', 0, '2024-05-28', 4, 1, 5)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Frutal y fresco, buen vino para el precio.', 0, '2024-05-28', 4, 2, 6)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Complejo y con buen cuerpo, destaca por sus notas de tabaco.', 1, '2024-05-28', 4, 7, 7)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Cítrico y refrescante, ideal para mariscos.', 0, '2024-05-28', 4, 2, 8)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas de frutas rojas y pimiento, muy interesante.', 1, '2024-05-28', 4, 1, 9)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Fresco y ligero, perfecto para días calurosos.', 0, '2024-05-28', 4, 2, 10)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un Merlot redondo, con taninos suaves y un final persistente.', 0, '2024-05-29', 5, 10, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Chardonnay con un buen equilibrio entre acidez y fruta.', 1, '2024-05-29', 4, 1, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Syrah con mucha personalidad, especiado y robusto.', 0, '2024-05-29', 4, 2, 3)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Pinot Noir elegante, con notas de frutas rojas y un toque terroso.', 1, '2024-05-29', 4, 1, 4)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Torrontés fresco y aromático, ideal para una tarde de verano.', 0, '2024-05-29', 4, 6, 5)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Bonarda fácil de beber, con buena relación calidad-precio.', 0, '2024-05-29', 4, 1, 6)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Tempranillo bien estructurado, con notas de fruta madura y especias.', 1, '2024-05-29', 4, 2, 7)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sauvignon Blanc vivaz, con una acidez refrescante.', 0, '2024-05-29', 4, 5, 8)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Cabernet Franc equilibrado, con notas herbales y frutales.', 1, '2024-05-29', 4, 2, 9)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Rosado de Syrah ligero y refrescante, perfecto para un día caluroso.', 0, '2024-05-29', 4, 4, 10)
GO
