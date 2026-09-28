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

INSERT INTO TbTipoUsuario (Nombre, Descripcion) VALUES (N'Gestor', N'Usuario que administra y supervisa proyectos.');
INSERT INTO TbTipoUsuario (Nombre, Descripcion) VALUES (N'Colaborador', N'Usuario que ejecuta tareas asignadas.');
GO

INSERT INTO TbArea (Nombre, Activo) VALUES (N'Dirección', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Tecnología', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Mercadeo', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Operaciones', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Social', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Recursos Humanos', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Planificación', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Logística', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Administración', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Calidad', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Jurídica', 1);
INSERT INTO TbArea (Nombre, Activo) VALUES (N'Finanzas', 1);
GO

INSERT INTO TbTipoProyecto (Nombre, Activo) VALUES (N'Desarrollo de software', 1);
INSERT INTO TbTipoProyecto (Nombre, Activo) VALUES (N'Infraestructura', 1);
INSERT INTO TbTipoProyecto (Nombre, Activo) VALUES (N'Mejora continua', 1);
INSERT INTO TbTipoProyecto (Nombre, Activo) VALUES (N'Transformación digital', 1);
INSERT INTO TbTipoProyecto (Nombre, Activo) VALUES (N'Cumplimiento', 1);
GO

INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Coordinador', N'Coordina actividades dentro del proyecto.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Subcoordinador', N'Apoya la coordinación del proyecto.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Analista', N'Recopila y analiza los requerimientos del proyecto.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Desarrollador', N'Implementa las funcionalidades y soluciones técnicas.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Diseñador', N'Diseña interfaces y elementos de experiencia de usuario.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Tester', N'Ejecuta las pruebas y documenta los resultados.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Documentador', N'Elabora y actualiza la documentación técnica y de usuario.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Soporte técnico', N'Apoya la instalación, el mantenimiento y la atención de incidencias.', 1);
INSERT INTO TbRolProyecto (Nombre, Descripcion, Activo) VALUES (N'Especialista de calidad', N'Revisa entregables, procesos y controles de calidad.', 1);
GO

INSERT INTO TbPrioridad (Nombre, Activo) VALUES ('Alta', 1);
INSERT INTO TbPrioridad (Nombre, Activo) VALUES ('Media', 1);
INSERT INTO TbPrioridad (Nombre, Activo) VALUES ('Normal', 1);
GO

INSERT INTO TbEstadoProyecto (Nombre, Activo) VALUES (N'Activo', 1);
INSERT INTO TbEstadoProyecto (Nombre, Activo) VALUES (N'Observación', 1);
INSERT INTO TbEstadoProyecto (Nombre, Activo) VALUES (N'Crítico', 1);
INSERT INTO TbEstadoProyecto (Nombre, Activo) VALUES (N'Cerrado', 1);
GO

INSERT INTO TbEstadoHito (Nombre, Activo) VALUES (N'Planificado', 1);
INSERT INTO TbEstadoHito (Nombre, Activo) VALUES (N'Pendiente', 1);
INSERT INTO TbEstadoHito (Nombre, Activo) VALUES (N'En proceso', 1);
INSERT INTO TbEstadoHito (Nombre, Activo) VALUES (N'Cumplido', 1);
GO

INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'Pendiente', 1);
INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'En progreso', 1);
INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'En revisión', 1);
INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'Devuelta', 1);
INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'Vencida', 1);
INSERT INTO TbEstadoTarea (Nombre, Activo) VALUES (N'Completada', 1);
GO

INSERT INTO TbEstadoRevision (Nombre, Activo) VALUES (N'Pendiente', 1);
INSERT INTO TbEstadoRevision (Nombre, Activo) VALUES (N'Aprobada', 1);
INSERT INTO TbEstadoRevision (Nombre, Activo) VALUES (N'Corrección solicitada', 1);
GO

INSERT INTO TbTipoNotificacion (Nombre, Activo) VALUES (N'Tarea vencida', 1);
INSERT INTO TbTipoNotificacion (Nombre, Activo) VALUES (N'Tarea devuelta', 1);
INSERT INTO TbTipoNotificacion (Nombre, Activo) VALUES (N'Nueva tarea', 1);
INSERT INTO TbTipoNotificacion (Nombre, Activo) VALUES (N'Alerta proyecto', 1);
INSERT INTO TbTipoNotificacion (Nombre, Activo) VALUES (N'Recordatorio', 1);
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

    CONSTRAINT FkRevisionRevisor
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

CREATE TABLE TbConfiguracionEmpresa
(
    IdConfiguracion INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmpresa NVARCHAR(150) NOT NULL,
    RutaLogo NVARCHAR(500) NOT NULL,
    LogoImagen VARBINARY(MAX) NULL,
    InformacionGeneral NVARCHAR(500) NOT NULL,
    FechaConfiguracion DATETIME NOT NULL DEFAULT GETDATE()
);
GO

CREATE TABLE TbAuditoriaSistema
(
    IdAuditoria INT IDENTITY(1,1) PRIMARY KEY,
    Tabla NVARCHAR(50) NOT NULL,
    IdRegistro INT NOT NULL,
    Accion NVARCHAR(50) NOT NULL,
    ValorAnterior NVARCHAR(200) NULL,
    ValorNuevo NVARCHAR(200) NULL,
    UsuarioSql NVARCHAR(128) NOT NULL,
    FechaCambio DATETIME2(0) NOT NULL DEFAULT SYSDATETIME()
);
GO

CREATE TRIGGER trgTareaAuditarCambios
ON TbTarea
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbTarea',
        nuevo.IdTarea,
        N'Cambio de estado',
        estadoAnterior.Nombre,
        estadoNuevo.Nombre,
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdTarea = nuevo.IdTarea
    INNER JOIN TbEstadoTarea estadoAnterior ON estadoAnterior.IdEstadoTarea = anterior.IdEstadoTarea
    INNER JOIN TbEstadoTarea estadoNuevo ON estadoNuevo.IdEstadoTarea = nuevo.IdEstadoTarea
    WHERE nuevo.IdEstadoTarea <> anterior.IdEstadoTarea;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbTarea',
        nuevo.IdTarea,
        N'Cambio de responsable',
        responsableAnterior.NombreUsuario,
        responsableNuevo.NombreUsuario,
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdTarea = nuevo.IdTarea
    INNER JOIN TbUsuario responsableAnterior ON responsableAnterior.IdUsuario = anterior.IdResponsable
    INNER JOIN TbUsuario responsableNuevo ON responsableNuevo.IdUsuario = nuevo.IdResponsable
    WHERE nuevo.IdResponsable <> anterior.IdResponsable;
END;
GO

CREATE TRIGGER trgRevisionAuditarResultado
ON TbRevisionTarea
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbRevisionTarea',
        nuevo.IdRevision,
        N'Resultado de revisión',
        resultadoAnterior.Nombre,
        resultadoNuevo.Nombre,
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdRevision = nuevo.IdRevision
    INNER JOIN TbEstadoRevision resultadoAnterior ON resultadoAnterior.IdResultadoRevision = anterior.IdResultadoRevision
    INNER JOIN TbEstadoRevision resultadoNuevo ON resultadoNuevo.IdResultadoRevision = nuevo.IdResultadoRevision
    WHERE nuevo.IdResultadoRevision <> anterior.IdResultadoRevision;
END;
GO

CREATE TRIGGER trgUsuarioAuditarCambios
ON TbUsuario
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbUsuario',
        nuevo.IdUsuario,
        N'Cambio de estado de usuario',
        CASE WHEN anterior.Activo = 1 THEN N'Activo' ELSE N'Inactivo' END,
        CASE WHEN nuevo.Activo = 1 THEN N'Activo' ELSE N'Inactivo' END,
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdUsuario = nuevo.IdUsuario
    WHERE nuevo.Activo <> anterior.Activo;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbUsuario',
        nuevo.IdUsuario,
        N'Cambio de rol',
        rolAnterior.Nombre,
        rolNuevo.Nombre,
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdUsuario = nuevo.IdUsuario
    INNER JOIN TbTipoUsuario rolAnterior ON rolAnterior.IdTipoUsuario = anterior.IdTipoUsuario
    INNER JOIN TbTipoUsuario rolNuevo ON rolNuevo.IdTipoUsuario = nuevo.IdTipoUsuario
    WHERE nuevo.IdTipoUsuario <> anterior.IdTipoUsuario;

    INSERT INTO TbAuditoriaSistema
    (Tabla, IdRegistro, Accion, ValorAnterior, ValorNuevo, UsuarioSql)
    SELECT
        N'TbUsuario',
        nuevo.IdUsuario,
        N'Contraseña modificada',
        N'Valor protegido',
        N'Valor protegido',
        ORIGINAL_LOGIN()
    FROM inserted nuevo
    INNER JOIN deleted anterior ON anterior.IdUsuario = nuevo.IdUsuario
    WHERE CONVERT(VARBINARY(255), nuevo.Contrasena) <> CONVERT(VARBINARY(255), anterior.Contrasena);
END;
GO

CREATE VIEW vwReporteProyectos
AS
SELECT
    p.IdProyecto,
    p.Codigo,
    p.Nombre AS Proyecto,
    ISNULL(tp.Nombre, N'Sin tipo') AS Tipo,
    a.Nombre AS Area,
    u.NombreCompleto AS Responsable,
    ep.Nombre AS Estado,
    pr.Nombre AS Prioridad,
    CAST(ISNULL(AVG(t.AvanceActual), 0) AS DECIMAL(5,2)) AS Avance,
    p.FechaCreacion
FROM TbProyecto p
INNER JOIN TbArea a ON a.IdArea = p.IdArea
INNER JOIN TbUsuario u ON u.IdUsuario = p.IdResponsable
INNER JOIN TbEstadoProyecto ep ON ep.IdEstadoProyecto = p.IdEstadoProyecto
INNER JOIN TbPrioridad pr ON pr.IdPrioridad = p.IdPrioridad
LEFT JOIN TbTipoProyecto tp ON tp.IdTipoProyecto = p.IdTipoProyecto
LEFT JOIN TbTarea t ON t.IdProyecto = p.IdProyecto
GROUP BY
    p.IdProyecto, p.Codigo, p.Nombre, tp.Nombre, a.Nombre,
    u.NombreCompleto, ep.Nombre, pr.Nombre, p.FechaCreacion;
GO

CREATE VIEW vwTareasProductividad
AS
SELECT
    u.IdUsuario,
    u.NombreCompleto,
    t.IdTarea,
    et.Nombre AS EstadoTarea,
    t.FechaLimite,
    t.FechaCompletada
FROM TbUsuario u
INNER JOIN TbTipoUsuario tipo ON tipo.IdTipoUsuario = u.IdTipoUsuario
LEFT JOIN TbTarea t ON t.IdResponsable = u.IdUsuario
LEFT JOIN TbEstadoTarea et ON et.IdEstadoTarea = t.IdEstadoTarea
WHERE tipo.Nombre = N'Colaborador'
AND u.Activo = 1;
GO

CREATE VIEW vwReporteHitos
AS
SELECT
    h.IdHito,
    h.IdProyecto,
    p.IdResponsable AS IdGestor,
    p.Nombre AS Proyecto,
    h.Nombre AS Hito,
    h.Descripcion,
    h.FechaObjetivo,
    h.IdResponsable,
    ISNULL(u.NombreCompleto, N'Sin responsable') AS Responsable,
    h.IdEstadoHito,
    eh.Nombre AS Estado,
    h.FechaCumplimiento
FROM TbHito h
INNER JOIN TbProyecto p ON p.IdProyecto = h.IdProyecto
INNER JOIN TbEstadoHito eh ON eh.IdEstadoHito = h.IdEstadoHito
LEFT JOIN TbUsuario u ON u.IdUsuario = h.IdResponsable;
GO

CREATE PROCEDURE spReporteProductividad
    @Dias INT
AS
BEGIN
    SET NOCOUNT ON;

    IF @Dias < 1 OR @Dias > 365
    BEGIN
        RAISERROR(N'El periodo debe estar entre 1 y 365 días.', 16, 1);
        RETURN;
    END;

    DECLARE @FechaInicio DATE;
    DECLARE @FechaAnterior DATE;

    SET @FechaInicio = DATEADD(DAY, -@Dias, CONVERT(DATE, GETDATE()));
    SET @FechaAnterior = DATEADD(DAY, -(@Dias * 2), CONVERT(DATE, GETDATE()));

    WITH Conteos AS
    (
        SELECT
            IdUsuario,
            NombreCompleto,
            COUNT(IdTarea) AS Tareas,
            COUNT(CASE
                WHEN EstadoTarea = N'Completada'
                AND FechaCompletada >= @FechaInicio THEN 1 END) AS CompletadasActuales,
            COUNT(CASE
                WHEN EstadoTarea = N'Completada'
                AND FechaCompletada >= @FechaAnterior
                AND FechaCompletada < @FechaInicio THEN 1 END) AS CompletadasAnteriores,
            COUNT(CASE
                WHEN EstadoTarea = N'Completada'
                AND FechaCompletada >= @FechaInicio
                AND CONVERT(DATE, FechaCompletada) <= FechaLimite THEN 1 END) AS CompletadasATiempo
        FROM vwTareasProductividad
        GROUP BY IdUsuario, NombreCompleto
    )
    SELECT
        IdUsuario,
        NombreCompleto,
        Tareas,
        CASE WHEN CompletadasActuales = 0 THEN 0
             ELSE CompletadasATiempo * 100 / CompletadasActuales
        END AS PorcentajeATiempo,
        CASE WHEN CompletadasActuales = 0 THEN 0
             ELSE CompletadasATiempo * 100 / CompletadasActuales
        END AS Cumplimiento,
        CASE WHEN CompletadasActuales > CompletadasAnteriores THEN N'Alta'
             WHEN CompletadasActuales < CompletadasAnteriores THEN N'Baja'
             ELSE N'Estable'
        END AS Tendencia
    FROM Conteos
    ORDER BY NombreCompleto;
END;
GO

CREATE PROCEDURE spReporteHitosGestor
    @IdGestor INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        h.IdHito,
        h.IdProyecto,
        h.Proyecto,
        h.Hito,
        h.Descripcion,
        h.FechaObjetivo,
        h.IdResponsable,
        h.Responsable,
        h.IdEstadoHito,
        h.Estado,
        h.FechaCumplimiento,
        (
            SELECT COUNT(*)
            FROM TbTarea t
            INNER JOIN TbEstadoTarea estado ON estado.IdEstadoTarea = t.IdEstadoTarea
            WHERE t.IdHito = h.IdHito
            AND t.FechaLimite < CONVERT(DATE, GETDATE())
            AND estado.Nombre IN (N'Pendiente', N'En progreso', N'Devuelta', N'Vencida')
        ) AS TareasVencidas
    FROM vwReporteHitos h
    WHERE h.IdGestor = @IdGestor
    ORDER BY h.FechaObjetivo, h.Hito;
END;
GO
