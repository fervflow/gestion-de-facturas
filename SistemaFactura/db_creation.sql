CREATE DATABASE sistema_factura
use sistema_factura

CREATE TABLE usuario(
id_usuario		INT IDENTITY(1,1)PRIMARY KEY NOT NULL,
nit				INT NOT NULL,
nombre			VARCHAR(40)

);

CREATE TABLE factura(
id_factura			INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
nit					INT NOT NULL,
nro_factura			INT NOT NULL,
cod_autorizacion	VARCHAR(60)NOT NULL,
fecha				DATE NOT NULL,
monto				MONEY NOT NULL,
monto_imponible		DECIMAL NOT NULL,
cod_verificacion	VARCHAR(30) NOT NULL,
nit_usuario			INT,
FOREIGN KEY (nro_factura) REFERENCES usuario(id_usuario),
);