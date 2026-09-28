USE DbSyncore;
GO

SELECT DB_NAME() AS BaseEnUso;
GO

SELECT name FROM sys.views WHERE name IN ('vwReporteProyectos', 'vwTareasProductividad', 'vwReporteHitos');
SELECT name FROM sys.procedures WHERE name IN ('spReporteProductividad', 'spReporteHitosGestor');
SELECT name, is_disabled FROM sys.triggers WHERE name IN ('trgTareaAuditarCambios', 'trgRevisionAuditarResultado', 'trgUsuarioAuditarCambios');
GO

SELECT TOP (20) * FROM vwReporteProyectos;
SELECT TOP (20) * FROM vwTareasProductividad;
SELECT TOP (20) * FROM vwReporteHitos;
GO

EXEC spReporteProductividad @Dias = 30;
EXEC spReporteProductividad @Dias = 60;
EXEC spReporteHitosGestor @IdGestor = 1;
GO

SELECT * FROM TbProyecto WHERE IdProyecto = 1;
SELECT * FROM TbEquipoProyecto WHERE IdProyecto = 1;
SELECT * FROM TbHito WHERE IdProyecto = 1;
SELECT * FROM TbTarea WHERE IdProyecto = 1;
SELECT * FROM TbAvance WHERE IdTarea = 1;
SELECT * FROM TbRevisionTarea WHERE IdTarea = 1;
SELECT * FROM TbNotificacion WHERE IdProyecto = 1;
GO

BEGIN TRANSACTION;
UPDATE TbTarea SET IdEstadoTarea = 2 WHERE IdTarea = 1;
SELECT * FROM TbAuditoriaSistema WHERE Tabla = N'TbTarea' AND IdRegistro = 1 ORDER BY IdAuditoria DESC;
ROLLBACK TRANSACTION;
GO

BEGIN TRANSACTION;
UPDATE TbRevisionTarea SET IdResultadoRevision = 2 WHERE IdRevision = 1;
SELECT * FROM TbAuditoriaSistema WHERE Tabla = N'TbRevisionTarea' AND IdRegistro = 1 ORDER BY IdAuditoria DESC;
ROLLBACK TRANSACTION;
GO

BEGIN TRANSACTION;
UPDATE TbUsuario SET Activo = 0 WHERE IdUsuario = 6;
SELECT * FROM TbAuditoriaSistema WHERE Tabla = N'TbUsuario' AND IdRegistro = 6 ORDER BY IdAuditoria DESC;
ROLLBACK TRANSACTION;
GO

BEGIN TRANSACTION;
UPDATE TbRevisionTarea SET IdResultadoRevision = 2 WHERE IdRevision = 1;
UPDATE TbTarea SET IdEstadoTarea = 6, FechaCompletada = GETDATE() WHERE IdTarea = 1;
SELECT * FROM TbAvance WHERE IdTarea = 1;
SELECT * FROM TbRevisionTarea WHERE IdRevision = 1;
SELECT * FROM vwReporteProyectos WHERE IdProyecto = 1;
EXEC spReporteProductividad @Dias = 30;
SELECT * FROM TbAuditoriaSistema WHERE IdRegistro = 1 ORDER BY IdAuditoria DESC;
ROLLBACK TRANSACTION;
GO

SELECT * FROM TbConfiguracionEmpresa;
GO

DELETE FROM TbConfiguracionEmpresa WHERE IdConfiguracion = -1;
GO
