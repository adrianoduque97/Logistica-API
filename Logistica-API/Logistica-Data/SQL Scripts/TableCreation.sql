CREATE TABLE Responsables (
	ResponsableId int NOT NULL PRIMARY KEY,
	Nombre varchar(MAX),
	Cargo varchar(MAX),
	DocumentoIdentidad varchar(MAX)
)

CREATE TABLE Rutas(
	RutaId int NOT NULL PRIMARY KEY,
	Origen varchar(MAX),
	Destino varchar(MAX),
	Tiempo varchar(MAX),
	Distancia varchar(MAX)
)

CREATE TABLE Vehiculos (
	VehiculoId int NOT NULL PRIMARY KEY, 
	Placa varchar(MAX),
	Marca varchar(MAX),
	Peso varchar(MAX),
	Tipo varchar(MAX),
	Cantidad varchar(MAX),
)

CREATE TABLE Viaje(
	ViajeId int NOT NULL PRIMARY KEY,
	FechaCargue datetime, 
	FechaDescargue datetime,
	Caracteristicas varchar(MAX),
	Cliente varchar(MAX),
	ResponsableId int FOREIGN KEY REFERENCES Responsables(ResponsableId),
	VehiculoId int FOREIGN KEY REFERENCES Vehiculos(VehiculoId),
	RutaId int FOREIGN KEY REFERENCES Rutas(RutaId)
)

INSERT INTO Responsables( ResponsableId, Nombre, Cargo ,DocumentoIdentidad) 
VALUES (123 , 'Luis Vizcaino', 'VP', '929292');

INSERT INTO Rutas (RutaId, Origen, Destino, Tiempo) 
VALUES (456 , 'Guayaqui', 'Quito', '3')

INSERT INTO Vehiculos (VehiculoId, Placa, Marca, Peso, Tipo)
VALUES (908, 'POU-90S', 'Chevrolet', '45 T', 'Mula')

INSERT INTO Viaje (ViajeId, FechaCargue, FechaDescargue, Caracteristicas, Cliente, ResponsableId, VehiculoId, RutaId)
VALUES (1, '2008-11-11 13:23:44', '2008-11-11 13:23:44', 'Largo', 'Adrian Duque', 123, 908, 456)

SELECT * FROM Viaje v
JOIN Vehiculos h ON (v.VehiculoId = h.VehiculoId)