USE DbSyncore;
GO

IF OBJECT_ID('dbo.TbConfiguracionEmpresa', 'U') IS NULL
BEGIN
    CREATE TABLE TbConfiguracionEmpresa
    (
        IdConfiguracion INT IDENTITY(1,1) PRIMARY KEY,
        NombreEmpresa NVARCHAR(150) NOT NULL,
        RutaLogo NVARCHAR(500) NOT NULL,
        LogoImagen VARBINARY(MAX) NULL,
        InformacionGeneral NVARCHAR(500) NOT NULL,
        FechaConfiguracion DATETIME NOT NULL DEFAULT GETDATE()
    );
END
GO

IF COL_LENGTH('dbo.TbConfiguracionEmpresa', 'LogoImagen') IS NULL
BEGIN
    ALTER TABLE dbo.TbConfiguracionEmpresa ADD LogoImagen VARBINARY(MAX) NULL;
END
GO
