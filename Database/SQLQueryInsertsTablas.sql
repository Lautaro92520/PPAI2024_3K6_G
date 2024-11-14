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
INSERT INTO RegionVitivinicola (descripcion, nombre, id_provincia) VALUES ('Otra regi�n vin�cola', 'Valle del Pedernal', 2);
GO

INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region) VALUES ('-32.889458, -68.845839', 'Bodega con historia', 'Fundada en 1900', 'Bodega Norton', '2024-04-01 00:00:00', 1);
INSERT INTO Bodega (coordenadas_ubicacion, descripcion, historia, nombre, periodo_actualizacion, id_region) VALUES ('-31.537500, -68.525000', 'Bodega reconocida', 'Fundada en 1950', 'Bodega Graffigna', '2024-04-01 00:00:00', 2);
GO

INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('Lopez', 'Pedro', 'pedro.jpg');
INSERT INTO Enofilo (apellido, nombre, imagen_perfil) VALUES ('Rodriguez', 'Ana', 'ana.jpg');
GO

INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Malbec Reserva', 2018, 'Notas de frutas rojas y roble', 'malbec.jpg', 1500.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Cabernet Sauvignon', 2017, 'Cuerpo completo con notas de vainilla', 'cabernet.jpg', 2000.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Merlot Gran Reserva', 2019, 'Aromas de frutas negras maduras con toques de chocolate y vainilla', 'merlot.jpg', 1800.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Chardonnay Reserva', 2020, 'Notas de manzana verde, pi�a y ligeros toques de roble', 'chardonnay.jpg', 1600.00, 1, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Syrah Premium', 2018, 'Sabores intensos de ciruela y mora, con un final especiado', 'syrah.jpg', 2200.00, 2, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Pinot Noir Select', 2019, 'Aromas de cereza y frambuesa con un toque de tierra', 'pinot_noir.jpg', 2100.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Torront�s Especial', 2021, 'Notas florales de jazm�n y azahar con un toque c�trico', 'torrontes.jpg', 1300.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Bonarda Cl�sico', 2017, 'Frutas rojas maduras y toques de hierbas frescas', 'bonarda.jpg', 1400.00, 1, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Tempranillo Reserva', 2018, 'Aromas de frutos del bosque con notas de vainilla y tabaco', 'tempranillo.jpg', 1900.00, 2, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Sauvignon Blanc Fresco', 2021, 'Aromas de lim�n, pomelo y toques herbales', 'sauvignon_blanc.jpg', 1500.00, 2, 2)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Cabernet Franc', 2019, 'Notas de frutas rojas, pimiento verde y un toque mineral', 'cabernet_franc.jpg', 2000.00, 1, 1)
INSERT INTO Vino (nombre, anada, nota_cata_bodega, ruta_imagen_etiqueta, precio_ars, id_bodega, id_enofilo) VALUES ('Rosado de Syrah', 2020, 'Aromas de fresas y frambuesas con un final refrescante', 'rosado_syrah.jpg', 1200.00, 1, 2)
GO

INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Malbec')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Cabernet Sauvignon')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva roja', 'Merlot')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva blanca', 'Chardonnay')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Syrah')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Pinot Noir')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva blanca', 'Torrontés')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Bonarda')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Tempranillo')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva blanca', 'Sauvignon Blanc')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Cabernet Franc')
INSERT INTO TipoUva (descripcion, nombre) VALUES ('Uva tinta', 'Syrah Rosado')
GO

INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, id_vino) VALUES (100, 'Varietal puro', 1, 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, id_vino) VALUES (100, 'Varietal puro', 2, 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 3, 2);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 4, 3);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 5, 4);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 6, 5);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 7, 6);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 8, 7);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 9, 8);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 10, 9);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 11, 10);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 12, 11);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (100, 'Varietal puro', 1, 12);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (70, 'Mezcla con notas de Merlot', 3, 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (30, 'Complemento de Cabernet Sauvignon', 4, 1);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (60, 'Mezcla con notas de Syrah', 5, 2);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (40, 'Complemento de Pinot Noir', 6, 2);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (80, 'Mezcla con notas de Chardonnay', 7, 3);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (20, 'Complemento de Sauvignon Blanc', 8, 3);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (50, 'Mezcla con notas de Malbec', 9, 4);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (50, 'Complemento de Torrontés', 10, 4);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (90, 'Mezcla con notas de Bonarda', 11, 5);
INSERT INTO Varietal (porcentaje_composicion, descripcion, tipo_uva, Id_Vino) VALUES (10, 'Complemento de Tempranillo', 12, 5);
GO


INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2024-05-28', 'Juan P�rez', 'Especialista en vinos tintos')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2024-05-28', 'Mar�a Gonz�lez', 'Experta en vinos blancos')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-03-15', 'Carlos Mart�nez', 'Amplia experiencia en vinos tintos de alta gama.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-11-20', 'Luc�a Fern�ndez', 'Especialista en vinos blancos y rosados.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-05-10', 'Mart�n L�pez', 'Conocedor de vinos espumosos y champagnes.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-01-05', 'Valeria Torres', 'Experta en maridaje de vinos con comida italiana.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-12-15', 'Andr�s G�mez', 'Especialista en vinos de regiones emergentes.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-02-28', 'Sof�a Rodr�guez', 'Enfocada en vinos biodin�micos y naturales.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-10-18', 'Esteban D�az', 'Gran conocimiento en vinos fortificados y licores.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-04-20', 'Mariana Ram�rez', 'Pasi�n por los vinos de peque�as bodegas artesanales.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2023-03-05', 'Diego P�rez', 'En�logo y sommelier, con �nfasis en vinos org�nicos.')
INSERT INTO Sommelier (fecha_validacion, nombre, nota_presentacion) VALUES ('2022-11-30', 'Ana Silva', 'Experta en vinos franceses y sus denominaciones.')
GO

INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Excelente vino, muy recomendable', 1, '2024-05-28', 5, 1, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Buen vino pero un poco caro', 0, '2024-05-28', 4, 2, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Excelente cuerpo y aroma, uno de los mejores Merlot que he probado.', 1, '2024-05-28', 5, 1, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un Chardonnay fresco y bien equilibrado, perfecto para el verano.', 0, '2024-05-28', 4, 9, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Intenso y especiado, ideal para acompa�ar carnes rojas.', 1, '2024-05-28', 5, 1, 3)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Elegante y suave, con notas de cereza que destacan.', 0, '2024-05-28', 4, 2, 4)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Aromas florales encantadores, perfecto como aperitivo.', 0, '2024-05-28', 4, 1, 5)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Frutal y fresco, buen vino para el precio.', 0, '2024-05-28', 4, 2, 6)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Complejo y con buen cuerpo, destaca por sus notas de tabaco.', 1, '2024-05-28', 4, 7, 7)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Citrico y refrescante, ideal para mariscos.', 0, '2024-05-28', 4, 2, 8)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas de frutas rojas y pimiento, muy interesante.', 1, '2024-05-28', 4, 1, 9)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Fresco y ligero, perfecto para d�as calurosos.', 0, '2024-05-28', 4, 2, 10)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un Merlot redondo, con taninos suaves y un final persistente.', 0, '2024-05-29', 5, 10, 1)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Chardonnay con un buen equilibrio entre acidez y fruta.', 1, '2024-05-29', 4, 1, 2)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Syrah con mucha personalidad, especiado y robusto.', 0, '2024-05-29', 4, 2, 3)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Pinot Noir elegante, con notas de frutas rojas y un toque terroso.', 1, '2024-05-29', 4, 1, 4)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Torrontos fresco y arom�tico, ideal para una tarde de verano.', 0, '2024-05-29', 4, 6, 5)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Bonarda facil de beber, con buena relaci�n calidad-precio.', 0, '2024-05-29', 4, 1, 6)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Tempranillo bien estructurado, con notas de fruta madura y especias.', 1, '2024-05-29', 4, 2, 7)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sauvignon Blanc vivaz, con una acidez refrescante.', 0, '2024-05-29', 4, 5, 8)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Cabernet Franc equilibrado, con notas herbales y frutales.', 1, '2024-05-29', 4, 2, 9)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Rosado de Syrah ligero y refrescante, perfecto para un dia caluroso.', 0, '2024-05-29', 4, 4, 10)
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Equilibrado y con buen cuerpo, un vino tinto excelente.', 1, '2024-05-29', 5, 3, 1);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas cítricas y frescas, perfecto para un día soleado.', 0, '2024-05-30', 4, 4, 2);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un vino robusto con toques de chocolate.', 1, '2024-05-27', 5, 5, 3);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un vino con gran personalidad y sabor complejo.', 0, '2024-05-25', 4, 6, 4);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Aromático y delicioso, un excelente vino blanco.', 1, '2024-05-24', 5, 7, 5);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un vino refrescante con un toque frutal.', 0, '2024-05-22', 4, 8, 6);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas especiadas y un final largo.', 1, '2024-05-21', 5, 9, 7);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Un vino muy bien balanceado.', 0, '2024-05-20', 4, 10, 8);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Gran vino con toques de frutos secos.', 1, '2024-05-19', 5, 1, 9);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Refrescante y afrutado, excelente para el verano.', 0, '2024-05-18', 4, 2, 10);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Intenso y con buen cuerpo.', 1, '2024-05-17', 5, 3, 11);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sutil y elegante, con notas de frutas rojas.', 0, '2024-05-16', 4, 4, 12);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Equilibrado y con buen cuerpo, un vino tinto excelente.', 1, '2024-05-29', 5, 3, 1);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Notas cítricas y frescas, perfecto para un día soleado.', 0, '2024-05-30', 4, 4, 2);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Un vino robusto con toques de chocolate.', 1, '2024-05-27', 5, 5, 3);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Un vino con gran personalidad y sabor complejo.', 0, '2024-05-25', 4, 6, 4);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Aromático y delicioso, un excelente vino blanco.', 1, '2024-05-24', 5, 7, 5);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Un vino refrescante con un toque frutal.', 0, '2024-05-22', 4, 8, 6);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Notas especiadas y un final largo.', 1, '2024-05-21', 5, 9, 7);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Un vino muy bien balanceado.', 0, '2024-05-20', 4, 10, 8);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Gran vino con toques de frutos secos.', 1, '2024-05-19', 5, 1, 9);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Refrescante y afrutado, excelente para el verano.', 0, '2024-05-18', 4, 2, 10);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Intenso y con buen cuerpo.', 1, '2024-05-17', 5, 3, 11);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_enofilo, id_vino) VALUES ('Sutil y elegante, con notas de frutas rojas.', 0, '2024-05-16', 4, 4, 12);

INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sabor intenso y equilibrado', 0, '2024-02-03 14:20:45', 4, 6, 4);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Fresco y afrutado', 1, '2024-03-22 10:15:30', 3, 2, 5);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Textura rica y suave', 0, '2024-04-05 09:45:20', 4, 1, 7);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Muy refrescante', 1, '2024-05-11 16:40:12', 5, 4, 3);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Persistente en boca', 0, '2024-06-07 11:24:50', 2, 8, 9);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Delicado y floral', 1, '2024-07-19 08:35:24', 4, 5, 6);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Equilibrio perfecto', 0, '2024-08-14 17:50:31', 5, 10, 2);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sutil toque de madera', 1, '2024-09-03 19:10:43', 3, 7, 10);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Aroma profundo', 0, '2024-10-25 15:55:18', 4, 9, 11);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Ligeramente dulce', 1, '2024-11-09 14:30:52', 5, 12, 1);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Sabor complejo', 0, '2024-01-20 13:45:39', 3, 3, 12);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Toque cítrico', 1, '2024-02-15 09:05:47', 4, 6, 5);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas de especias', 0, '2024-03-30 20:10:22', 5, 2, 7);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Taninos suaves', 1, '2024-04-21 18:25:36', 3, 8, 4);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Final largo', 0, '2024-05-07 08:45:10', 4, 11, 9);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Frutal y fresco', 1, '2024-06-29 12:00:15', 5, 5, 2);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Excelente cuerpo', 0, '2024-07-12 14:34:28', 2, 10, 6);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Muy aromático', 1, '2024-08-23 09:10:55', 4, 1, 8);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Equilibrio notable', 0, '2024-09-19 11:20:45', 5, 7, 3);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas de chocolate', 1, '2024-10-13 19:15:30', 3, 4, 11);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Final persistente', 0, '2024-11-02 13:40:18', 4, 9, 10);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Muy bien estructurado', 1, '2024-01-18 18:05:09', 5, 12, 5);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Cuerpo medio', 0, '2024-02-27 16:22:37', 3, 6, 1);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Fresco y ligero', 1, '2024-03-08 17:15:50', 4, 2, 4);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Notas herbales', 0, '2024-04-16 10:55:22', 2, 8, 7);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Muy frutal', 1, '2024-05-28 15:40:10', 5, 3, 9);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Acidez balanceada', 0, '2024-06-15 14:22:33', 4, 11, 6);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Buena estructura', 1, '2024-07-05 09:10:48', 3, 10, 12);
INSERT INTO Resena (comentario, es_premium, fecha_reseña, puntaje, id_sommelier, id_vino) VALUES ('Ligero en boca', 0, '2024-08-21 19:30:55', 5, 5, 8);
GO
