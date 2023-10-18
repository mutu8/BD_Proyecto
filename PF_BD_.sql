--Creación de la BD
drop database BD_PF
create database BD_PF
-- Creaciòn tabla Origen
CREATE TABLE Origen (
    idOrigen INT NOT NULL,
    ciudadOrigen VARCHAR(50) NOT NULL,
    codCiudad VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Origen PRIMARY KEY (idOrigen)
);

-- Creación de la tabla Destino
CREATE TABLE Destino (
    idDestino INT NOT NULL,
    ciudadDestino VARCHAR(50) NOT NULL,
    codCiudad VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Destino PRIMARY KEY (idDestino)
);

--Creación de la tabla cliente
CREATE TABLE Cliente(
    idCliente int identity not null,
    nombre varchar(50) not null,
    dni varchar(30) not null,
    edad int null,
    telefono int null,
    email varchar(50) null,
    CONSTRAINT PK_Cliente PRIMARY KEY (idCliente)
)

-- Creación de la tabla Empresa
CREATE TABLE Empresa (
    idEmpresa INT IDENTITY NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    telefono INT NOT NULL,	
    CONSTRAINT PK_Empresa PRIMARY KEY (idEmpresa)
);

-- Creación de la tabla Itinerario
CREATE TABLE Itinerario (
    idItinerario INT IDENTITY(1,1) NOT NULL,
    hora DATETIME NOT NULL,
    fecha DATETIME NOT NULL,
    idOrigen INT NOT NULL,
    idDestino INT NOT NULL,
    CONSTRAINT PK_Itinerario PRIMARY KEY (idItinerario),
    CONSTRAINT FK_Itinerario_Origen FOREIGN KEY (idOrigen) REFERENCES Origen(idOrigen),
    CONSTRAINT FK_Itinerario_Destino FOREIGN KEY (idDestino) REFERENCES Destino(idDestino)
);

-- Creación de la tabla Viaje
CREATE TABLE Viaje (
    idViaje INT IDENTITY(1,1) NOT NULL,
    capacidad INT NOT NULL,
    idEmpresa INT NOT NULL,
    idItinerario INT NOT NULL,
    CONSTRAINT PK_Viaje PRIMARY KEY (idViaje),
    CONSTRAINT FK_Viaje_Empresa FOREIGN KEY (idEmpresa) REFERENCES Empresa(idEmpresa),
    CONSTRAINT FK_Viaje_Itinerario FOREIGN KEY (idItinerario) REFERENCES Itinerario(idItinerario)
);

-- Creación de la tabla Pasaje
CREATE TABLE Pasaje (
    idPasaje INT IDENTITY(1,1) NOT NULL,
    tipoPasaje VARCHAR(50) NOT NULL,
    asiento VARCHAR(50) NOT NULL,
    valor INT NOT NULL,
    idCliente INT NOT NULL,
    idViaje INT NOT NULL,
    CONSTRAINT PK_Pasaje PRIMARY KEY (idPasaje),
    CONSTRAINT FK_Pasaje_Cliente FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
    CONSTRAINT FK_Pasaje_Viaje FOREIGN KEY (idViaje) REFERENCES Viaje(idViaje),
    CONSTRAINT UQ_Pasaje_Asiento UNIQUE (asiento)
);


-- Aplicamos índices en columnas frecuentemente consultadas
CREATE INDEX IX_Itinerario_IdOrigen ON Itinerario (idOrigen);

-- Inserción de datos en la tabla Origen
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (1, 'Trujillo', 'COD001');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (2, 'Lima', 'COD002');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (3, 'Chimbote', 'COD003');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (4, 'Chiclayo', 'COD004');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (5, 'Cajamarca', 'COD005');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (6, 'Iquitos', 'COD006');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (7, 'Tarapoto', 'COD007');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (8, 'Huancayo', 'COD008');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (9, 'Puno', 'COD009');
INSERT INTO Origen (idOrigen, ciudadOrigen, codCiudad) VALUES (10,'Cuzco', 'COD010');
select * from Origen

-- Inserción de datos en la tabla Destino
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (1, 'Trujillo', 'COD001');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (2, 'Lima', 'COD002');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (3, 'Chimbote', 'COD003');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (4, 'Chiclayo', 'COD004');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (5, 'Cajamarca', 'COD005');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (6, 'Iquitos', 'COD006');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (7, 'Tarapoto', 'COD007');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (8, 'Huancayo', 'COD008');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (9, 'Puno', 'COD009');
INSERT INTO Destino (idDestino, ciudadDestino, codCiudad) VALUES (10, 'Cuzco', 'COD010');
select * from Destino

-- Inserción de datos en la tabla Itinerario
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('09:15', CONVERT(datetime, '21-05-2023', 105), 2, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('08:00', CONVERT(datetime, '21-05-2023', 105), 3, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('15:45', CONVERT(datetime, '21-05-2023', 105), 3, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('07:30', CONVERT(datetime, '21-05-2023', 105), 4, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('14:45', CONVERT(datetime, '21-05-2023', 105), 4, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('09:00', CONVERT(datetime, '21-05-2023', 105), 5, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('16:30', CONVERT(datetime, '21-05-2023', 105), 5, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('10:30', CONVERT(datetime, '21-05-2023', 105), 6, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('17:15', CONVERT(datetime, '21-05-2023', 105), 6, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('11:45', CONVERT(datetime, '21-05-2023', 105), 7, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('18:30', CONVERT(datetime, '21-05-2023', 105), 7, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('12:15', CONVERT(datetime, '21-05-2023', 105), 8, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('19:00', CONVERT(datetime, '21-05-2023', 105), 8, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('13:30', CONVERT(datetime, '21-05-2023', 105), 9, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('20:15', CONVERT(datetime, '21-05-2023', 105), 9, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('14:45', CONVERT(datetime, '21-05-2023', 105), 10, 1);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('21:30', CONVERT(datetime, '21-05-2023', 105), 10, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('12:00', CONVERT(datetime, '21-05-2023', 105), 1, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('13:00', CONVERT(datetime, '21-05-2023', 105), 1, 3);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('14:00', CONVERT(datetime, '21-05-2023', 105), 1, 4);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('15:00', CONVERT(datetime, '21-05-2023', 105), 1, 5);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('16:00', CONVERT(datetime, '21-05-2023', 105), 1, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('17:00', CONVERT(datetime, '21-05-2023', 105), 2, 3);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('18:00', CONVERT(datetime, '21-05-2023', 105), 3, 5);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('19:00', CONVERT(datetime, '21-05-2023', 105), 6, 2);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('20:00', CONVERT(datetime, '21-05-2023', 105), 7, 10);
INSERT INTO Itinerario (hora, fecha, idOrigen, idDestino) VALUES ('21:00', CONVERT(datetime, '21-05-2023', 105), 5, 8);
select * from Itinerario

-- Inserción de datos en la tabla Empresa
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Aries', 'Calle #536', 966767878);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Mobile', 'Calle #656', 967456357);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Itzza', 'Calle #768', 945785678);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Entrafesa', 'Calle #974', 974634723);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Cruz del sur', 'Calle #357', 976454676);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('El Dorado', 'Calle #858', 985756667);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Tepsa', 'Calle #793', 978675757);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Peru Bus', 'Calle #384', 975666461);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Oltursa', 'Calle #128', 925364657);
INSERT INTO Empresa (nombre, direccion, telefono) VALUES ('Civa', 'Calle #758', 956353636);
select * from Empresa

-- Inserción de datos en la tabla Viaje
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 1, 1);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 2, 2);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 3, 3);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 4, 4);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 5, 5);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 6, 6);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 7, 7);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 8, 8);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 9, 9);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 10, 10);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 1, 11);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 2, 12);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 3, 13);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 4, 14);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 5, 15);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 6, 16);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 7, 17);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 8, 18);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 9, 19);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 10, 20);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 1, 21);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 2, 22);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 3, 23);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 4, 24);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 5, 25);
INSERT INTO Viaje (capacidad, idEmpresa, idItinerario) VALUES (40, 6, 26);
select * from Viaje


-- Inserción de datos en la tabla Cliente
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Juan Pérez', '74543424', 30, 96745434, 'juan@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Mary Alvarran', '76657557', 20, 98535353, 'mary@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Yordy Cruz', '76342345', 24, 94564974, 'steven@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Adrian Cuba', '34657634', 19, 92354545, 'adrian@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Samuel Castillo', '76457623', 32, 94556565, 'samuel@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Gabriel Quintana', '65768686', 41, 91334657, 'gaui@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Joan Poter', '54658743', 35, 93536746, 'joan@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Leonel Ronaldo', '65852365', 21, 96364657, 'leo@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Manuel Nuñez', '35458756', 42, 92353464, 'manu@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Jean Andrade', '84586521', 45, 97869776, 'jean@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Josep Guardiola', '74598458', 45, 958126548 ,'pep@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad, telefono, email) VALUES ('Luis Enrique', '25784152', 60, 912545984,'padredelmadrid@hotmail.com');
INSERT INTO Cliente (nombre, dni, edad,  telefono, email) VALUES ('Juana Pérez', '35984574', 35,  945124548,'juan4prz@hotmail.com');
select * from Cliente


-- Inserción de datos en la tabla Pasaje
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('Regular', 'A01', 40, 1, 3);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('Premiun', 'A33', 40, 2, 4);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('Regular', 'A02', 40, 4, 6);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A38', 40, 5, 2);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('Regular', 'A08', 40, 6, 8);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A09', 40, 7, 7);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A12', 40, 8, 2);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A31', 40, 9, 3);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('Regular', 'A29', 40, 10, 5);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A32', 50, 12, 5);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje) VALUES ('VIP', 'A11', 60, 12, 6);
select * from Pasaje


--ALTER TABLE EN LA CANTIDAD DE CARACTERES EN LA TABLA CLIENTES
ALTER TABLE cliente
ALTER COLUMN email VARCHAR(40);

--UPDATES
	--UPDATE EN LA TABLA CLIENTES MAYORES A 40 AÑOS
		UPDATE Cliente	
		SET	edad = 45	
		WHERE edad>40 
	--UPDATE EN LA TABLA PASAJE A LOS QUE TENGAN EL VALOR MENOR O IGUAL A 40
		UPDATE Pasaje, idViaje) VALUES ('Regular', 'A23', 40, 3, 5);
INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente,
		SET valor = 50
		WHERE valor>=40
	 
--CONSULTAS
	--CONSULTAS BÁSICAS DE LAS TABLAS CREADAS
	SELECT * FROM Origen
	SELECT * FROM Destino
	SELECT * FROM Itinerario
	SELECT * FROM Empresa
	SELECT * FROM Viaje
	SELECT * FROM Cliente
	SELECT * FROM Pasaje

	--CONSULTAS USANDO CONDICIONES
	SELECT * FROM Cliente
	WHERE edad<=30

	SELECT * FROM Cliente
	SELECT * FROM Pasaje
	WHERE tipoPasaje='VIP'

	--CONSULTA DE VALORES DISTINTOS DE NULL EN LA TABLA CLIENTES
	SELECT nombre,  COUNT(telefono)
	FROM Cliente
	GROUP BY nombre 

	--CONSULTA DE VALORES DISTINTOS DE NULL EN LA TABLA CLIENTES
	SELECT nombre,  COUNT(*)
	FROM Cliente
	GROUP BY nombre 

	

	--CONSULTA USANDO MAX Y MIN
	SELECT idCliente,	
		MAX (valor) as mayor,
		MIN (valor) as menor
		FROM Pasaje
		GROUP BY idCliente
 
	--CONSULTA DE PROMEDIO DE CLIENTES ACORDE AL VALOR DEL PASAJE
	SELECT idCliente, AVG(valor)
	FROM Pasaje
	GROUP BY idCliente

	--CONSULTA USANDO SUM
	SELECT nombre, SUM(edad)
	FROM Cliente
	GROUP BY nombre

--Procedimientos de listado

	--Cliente
	CREATE PROCEDURE [dbo].[spListaCliente] 
	AS
		SELECT idCliente, nombre, dni, edad, telefono, email 
		from Cliente
	

	CREATE PROCEDURE [dbo].[spInsertaCliente] 
	(@nombre varchar(50),
	@dni varchar(30),
	@edad int,
	@telefono int,
	@email varchar(50)
	)
	as
	begin 

		insert into Cliente(nombre,dni,edad, telefono, email) values (@nombre, @dni,@edad,@telefono, @email)
	end

	--Pasaje	
	CREATE PROCEDURE [dbo].[spListaPasaje] 
	AS
		SELECT idPasaje ,tipoPasaje, asiento, valor, idCliente, idViaje
		from Pasaje

	--ObtenerPasajesPorCliente
	CREATE PROCEDURE ObtenerPasajesPorCliente
    @idCliente INT
	AS
	BEGIN
		SELECT idPasaje, tipoPasaje, asiento, valor ,idCliente, idViaje
		FROM Pasaje
		WHERE idCliente = @idCliente;
	END

	--InsertarPasajes
	CREATE PROCEDURE [dbo].[spInsertaPasaje] 
	@tipoPasaje VARCHAR(50),
	@asiento VARCHAR(50),
	@valor INT,
	@idCliente INT,
	@idViaje INT
		AS
		BEGIN
			INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje)
			VALUES (@tipoPasaje, @asiento, @valor, @idCliente, @idViaje)
		END

	--Test
	CREATE PROCEDURE InsertarPasaje
    @tipoPasaje VARCHAR(50),
    @asiento VARCHAR(50),
    @valor INT,
    @idCliente INT,
    @idViaje INT
	AS
	BEGIN
		SET NOCOUNT ON;

		INSERT INTO Pasaje (tipoPasaje, asiento, valor, idCliente, idViaje)
		VALUES (@tipoPasaje, @asiento, @valor, @idCliente, @idViaje);
	END


	--Viaje
	CREATE PROCEDURE [dbo].[spListaViaje] 
	AS
		SELECT idViaje,capacidad, idEmpresa, idItinerario
		from Viaje



	--ListaFiltradoparaItinerarioCbo
	CREATE PROCEDURE [dbo].[spListaViajeFiltrado]
    @idItineario int
	AS
	BEGIN
		SELECT idViaje,capacidad, idEmpresa, idItinerario
		FROM Viaje
		WHERE idItinerario = (SELECT idItinerario FROM Itinerario WHERE idItinerario = @idItineario)
	END



	--Empresa
	CREATE PROCEDURE [dbo].[spListaEmpresa] 
	AS
		SELECT idEmpresa,nombre, direccion, telefono
		from Empresa

	--Itinerario
	CREATE PROCEDURE [dbo].[spListaItinerario] 
	AS
		SELECT idItinerario ,hora, fecha, idOrigen, idDestino
		from Itinerario

	--ListaFiltradoparaItinerarioCbo
	CREATE PROCEDURE [dbo].[spListaItinerarioFiltrado]
    @idOrigen int,
    @idDestino int
	AS
	BEGIN
		SELECT idItinerario ,hora, fecha, idOrigen, idDestino
		FROM Itinerario
		WHERE idOrigen = (SELECT idOrigen FROM Origen WHERE idOrigen = @idOrigen)
		  AND idDestino = (SELECT idDestino FROM Destino WHERE idDestino = @idDestino)
	END

	
	--Destino
	CREATE PROCEDURE [dbo].[spListaDestino] 
	AS
		SELECT idDestino, ciudadDestino, codCiudad
		from Destino

	--Origen
	CREATE PROCEDURE [dbo].[spListaOrigen] 
	AS
		SELECT idOrigen, ciudadOrigen, codCiudad
		from Origen
