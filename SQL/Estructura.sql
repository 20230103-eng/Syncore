CREATE DATABASE DbSyncore;
GO

USE DbSyncore;
GO

SET DATEFORMAT ymd;
GO

CREATE TABLE TbTipoUsuario
(
    IdTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
    Descripcion NVARCHAR(200) NULL
);
GO

CREATE TABLE TbArea
(
    IdArea INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbTipoProyecto
(
    IdTipoProyecto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbRolProyecto
(
    IdRolProyecto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL UNIQUE,
    Descripcion NVARCHAR(200) NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbPrioridad
(
    IdPrioridad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(15) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbEstadoProyecto
(
    IdEstadoProyecto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(30) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbEstadoHito
(
    IdEstadoHito INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(30) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbEstadoTarea
(
    IdEstadoTarea INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(30) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbEstadoRevision
(
    IdResultadoRevision INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(40) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbTipoNotificacion
(
    IdTipoNotificacion INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(40) NOT NULL UNIQUE,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE TbUsuario
(
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    Contrasena VARCHAR(255) NOT NULL,
    NombreCompleto NVARCHAR(150) NOT NULL,
    IdTipoUsuario INT NOT NULL,
    IdArea INT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),

 
        FOREIGN KEY (IdTipoUsuario)
        REFERENCES tbTipoUsuario(IdTipoUsuario),

 
        FOREIGN KEY (IdArea)
        REFERENCES tbArea(IdArea)
);
GO

CREATE TABLE TbProyecto
(
    IdProyecto INT IDENTITY(1,1) PRIMARY KEY,
    Codigo VARCHAR(20) NOT NULL UNIQUE,
    Nombre NVARCHAR(150) NOT NULL,
    Objetivo NVARCHAR(500) NOT NULL,
    Justificacion NVARCHAR(500) NULL,
    Alcance NVARCHAR(500) NULL,
    ResultadoEsperado NVARCHAR(500) NOT NULL,
    Observacion NVARCHAR(500) NULL,

    IdArea INT NOT NULL,
    IdTipoProyecto INT NOT NULL,
    IdResponsable INT NOT NULL,

    IdPrioridad INT NOT NULL,
    IdEstadoProyecto INT NOT NULL,

    FechaInicio DATE NOT NULL,
    FechaCierreEstimada DATE NOT NULL,
    FechaCierreReal DATE NULL,

    AvancePlanificado DECIMAL(5,2) NOT NULL DEFAULT 0,

    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
    UltimaModificacion DATETIME NULL,

        FOREIGN KEY (IdArea)
        REFERENCES tbArea(IdArea),

        FOREIGN KEY (IdTipoProyecto)
        REFERENCES tbTipoProyecto(IdTipoProyecto),

        FOREIGN KEY (IdResponsable)
        REFERENCES tbUsuario(IdUsuario),

    
        FOREIGN KEY (IdPrioridad)
        REFERENCES tbPrioridad(IdPrioridad),

 
        FOREIGN KEY (IdEstadoProyecto)
        REFERENCES tbEstadoProyecto(IdEstadoProyecto),

    CHECK (AvancePlanificado BETWEEN 0 AND 100),

    CHECK (FechaCierreEstimada >= FechaInicio)
);
GO

CREATE TABLE TbEquipoProyecto
(
    IdEquipo INT IDENTITY(1,1) PRIMARY KEY,

    IdProyecto INT NOT NULL,

    IdUsuario INT NOT NULL,

    IdRolProyecto INT NOT NULL,

    FechaAsignacion DATETIME NOT NULL DEFAULT GETDATE(),

    Activo BIT NOT NULL DEFAULT 1,

   
        FOREIGN KEY (IdProyecto)
        REFERENCES tbProyecto(IdProyecto),

 
        FOREIGN KEY (IdUsuario)
        REFERENCES tbUsuario(IdUsuario),

    
        FOREIGN KEY (IdRolProyecto)
        REFERENCES tbRolProyecto(IdRolProyecto),

    
        UNIQUE(IdProyecto, IdUsuario)
);
GO

CREATE TABLE TbHito
(
    IdHito INT IDENTITY(1,1) PRIMARY KEY,

    IdProyecto INT NOT NULL,

    Nombre NVARCHAR(150) NOT NULL,

    Descripcion NVARCHAR(500) NULL,

    FechaObjetivo DATE NOT NULL,

    IdResponsable INT NULL,

    IdEstadoHito INT NOT NULL,

    FechaCumplimiento DATE NULL,

  
        FOREIGN KEY (IdProyecto)
        REFERENCES tbProyecto(IdProyecto),

   
        FOREIGN KEY (IdResponsable)
        REFERENCES tbUsuario(IdUsuario),

        FOREIGN KEY (IdEstadoHito)
        REFERENCES tbEstadoHito(IdEstadoHito)
);
GO

CREATE TABLE TbTarea
(
    IdTarea INT IDENTITY(1,1) PRIMARY KEY,
    IdProyecto INT NOT NULL,
    IdHito INT NULL,

    Nombre NVARCHAR(150) NOT NULL,
    Descripcion NVARCHAR(1000) NOT NULL,
    Observacion NVARCHAR(500) NULL,

    IdResponsable INT NOT NULL,
    IdCreador INT NOT NULL,

    IdPrioridad INT NOT NULL,
    IdEstadoTarea INT NOT NULL,

    FechaInicio DATE NOT NULL,
    FechaLimite DATE NOT NULL,

    AvanceActual DECIMAL(5,2) NOT NULL DEFAULT 0,

    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
    FechaCompletada DATETIME NULL,


        FOREIGN KEY (IdProyecto)
        REFERENCES tbProyecto(IdProyecto),

 
        FOREIGN KEY (IdHito)
        REFERENCES tbHito(IdHito),

  
        FOREIGN KEY (IdResponsable)
        REFERENCES tbUsuario(IdUsuario),

   
        FOREIGN KEY (IdCreador)
        REFERENCES tbUsuario(IdUsuario),

  
        FOREIGN KEY (IdPrioridad)
        REFERENCES tbPrioridad(IdPrioridad),

 
        FOREIGN KEY (IdEstadoTarea)
        REFERENCES tbEstadoTarea(IdEstadoTarea),

    CHECK (AvanceActual BETWEEN 0 AND 100),

    CHECK (FechaLimite >= FechaInicio)
);
GO

CREATE TABLE TbAvance
(
    IdAvance INT IDENTITY(1,1) PRIMARY KEY,

    IdTarea INT NOT NULL,

    IdUsuario INT NOT NULL,

    Porcentaje DECIMAL(5,2) NOT NULL,

    FechaRegistro DATE NOT NULL DEFAULT GETDATE(),

    Descripcion NVARCHAR(1000) NOT NULL,

    Dificultad NVARCHAR(500) NULL,

    ProximoPaso NVARCHAR(500) NULL,

        FOREIGN KEY (IdTarea)
        REFERENCES tbTarea(IdTarea),
  
        FOREIGN KEY (IdUsuario)
        REFERENCES tbUsuario(IdUsuario),

    CHECK (Porcentaje BETWEEN 0 AND 100)
);
GO

CREATE TABLE TbEvidencia
(
    IdEvidencia INT IDENTITY(1,1) PRIMARY KEY,

    IdAvance INT NOT NULL,

    NombreArchivo NVARCHAR(255) NOT NULL,

    RutaArchivo VARCHAR(500) NOT NULL,

    TipoArchivo VARCHAR(50) NULL,

    FechaSubida DATETIME NOT NULL DEFAULT GETDATE(),

  
        FOREIGN KEY (IdAvance)
        REFERENCES tbAvance(IdAvance)
);
GO

CREATE TABLE TbRevisionTarea
(
    IdRevision INT IDENTITY(1,1) PRIMARY KEY,

    IdTarea INT NOT NULL,

    IdRevisor INT NOT NULL,

    FechaEnvio DATETIME NOT NULL,

    FechaRevision DATETIME NULL,

    IdResultadoRevision INT NOT NULL,

    Comentario NVARCHAR(500) NULL,

  
        FOREIGN KEY (IdTarea)
        REFERENCES tbTarea(IdTarea),

    CONSTRAINT FK_Revision_Revisor
        FOREIGN KEY (IdRevisor)
        REFERENCES tbUsuario(IdUsuario),

   
        FOREIGN KEY (IdResultadoRevision)
        REFERENCES tbEstadoRevision(IdResultadoRevision)
);  
GO

CREATE TABLE TbComentarioTarea
(
    IdComentario INT IDENTITY(1,1) PRIMARY KEY,

    IdTarea INT NOT NULL,

    IdUsuario INT NOT NULL,

    Comentario NVARCHAR(500) NOT NULL,

    FechaComentario DATETIME NOT NULL DEFAULT GETDATE(),

   
        FOREIGN KEY (IdTarea)
        REFERENCES tbTarea(IdTarea),

    
        FOREIGN KEY (IdUsuario)
        REFERENCES tbUsuario(IdUsuario)
);
GO

CREATE TABLE TbNotificacion
(
    IdNotificacion INT IDENTITY(1,1) PRIMARY KEY,

    IdUsuario INT NOT NULL,

    IdTipoNotificacion INT NOT NULL,

    Titulo NVARCHAR(150) NOT NULL,

    Mensaje NVARCHAR(500) NOT NULL,

    IdPrioridad INT NOT NULL,

    IdTarea INT NULL,

    IdProyecto INT NULL,

    Leida BIT NOT NULL DEFAULT 0,

    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),

  
        FOREIGN KEY (IdUsuario)
        REFERENCES tbUsuario(IdUsuario),

        FOREIGN KEY (IdTipoNotificacion)
        REFERENCES tbTipoNotificacion(IdTipoNotificacion),

        FOREIGN KEY (IdPrioridad)
        REFERENCES tbPrioridad(IdPrioridad),

        FOREIGN KEY (IdTarea)
        REFERENCES tbTarea(IdTarea),

        FOREIGN KEY (IdProyecto)
        REFERENCES tbProyecto(IdProyecto)
);
GO