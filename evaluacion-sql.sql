CREATE TABLE Alumno (
    NumeroDocumento varchar(20) PRIMARY KEY,
    Nombres varchar(50) NOT NULL,
    Apellidos varchar(100) NOT NULL,
    Email varchar(50) NOT NULL,
    TipoDocumento varchar(20) NOT NULL,
    FechaNacimiento date NOT NULL,
    Sexo bit NOT NULL,
    Telefono varchar(15) NULL,
    Nacionalidad varchar(50) NOT NULL,
    Imagen varbinary(MAX) NOT NULL,
    FechaCreacion date NOT NULL,
    FechaModificacion date NOT NULL
);
GO