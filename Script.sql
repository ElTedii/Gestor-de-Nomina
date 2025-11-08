-- 1. Tabla Empresas
IF OBJECT_ID('dbo.Empresas') IS NOT NULL DROP TABLE dbo.Empresas;
CREATE TABLE dbo.Empresas (
    IdEmpresa INT IDENTITY(1,1) PRIMARY KEY,
    NombreFiscal NVARCHAR(200) NOT NULL,
    RFC NVARCHAR(13) NULL,
    RegistroIMSS NVARCHAR(30) NULL,
    RegistroInfonavit NVARCHAR(30) NULL,
    RegimenFiscal NVARCHAR(80) NULL,
    ClaveCFDI NVARCHAR(200) NULL,
    EmitirRecibo BIT NOT NULL DEFAULT(0),
    GUIDEmpresa UNIQUEIDENTIFIER NOT NULL DEFAULT(NEWID()),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE())
);
--CREATE INDEX IX_Empresas_RFC ON dbo.Empresas(RFC);

-- 2. Departamentos
IF OBJECT_ID('dbo.Departamentos') IS NOT NULL DROP TABLE dbo.Departamentos;
CREATE TABLE dbo.Departamentos (
    IdDepartamento INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpresa INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Responsable NVARCHAR(120) NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Departamentos_Empresas FOREIGN KEY (IdEmpresa) REFERENCES dbo.Empresas(IdEmpresa)
);
--CREATE INDEX IX_Departamentos_Empresa ON dbo.Departamentos(IdEmpresa);

-- 3. Puestos
IF OBJECT_ID('dbo.Puestos') IS NOT NULL DROP TABLE dbo.Puestos;
CREATE TABLE dbo.Puestos (
    IdPuesto INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpresa INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Nivel NVARCHAR(50) NULL,
    SueldoBase DECIMAL(14,2) NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Puestos_Empresas FOREIGN KEY (IdEmpresa) REFERENCES dbo.Empresas(IdEmpresa)
);
--CREATE INDEX IX_Puestos_Empresa ON dbo.Puestos(IdEmpresa);

-- 4. Bancos
IF OBJECT_ID('dbo.Bancos') IS NOT NULL DROP TABLE dbo.Bancos;
CREATE TABLE dbo.Bancos (
    IdBanco INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(120) NOT NULL,
    Clave NVARCHAR(20) NULL,
    Activo BIT NOT NULL DEFAULT(1)
);
--CREATE INDEX IX_Bancos_Nombre ON dbo.Bancos(Nombre);

-- 5. Empleados
IF OBJECT_ID('dbo.Empleados') IS NOT NULL DROP TABLE dbo.Empleados;
CREATE TABLE dbo.Empleados (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpresa INT NOT NULL,
    CodigoEmpleado NVARCHAR(30) NULL,
    Nombre NVARCHAR(200) NOT NULL,
    ApellidoPaterno NVARCHAR(80) NULL,
    ApellidoMaterno NVARCHAR(80) NULL,
    RFC NVARCHAR(13) NULL,
    CURP NVARCHAR(18) NULL,
    NSS NVARCHAR(11) NULL,
    FechaNacimiento DATE NULL,
    FechaIngreso DATE NULL,
    FechaBaja DATE NULL,
    SueldoDiario DECIMAL(14,2) NULL,
    SueldoIntegrado DECIMAL(14,2) NULL,
    IdDepartamento INT NULL,
    IdPuesto INT NULL,
    IdBanco INT NULL,
    Clabe NVARCHAR(18) NULL,
    TipoContrato NVARCHAR(50) NULL,
    AltaIMSS BIT NOT NULL DEFAULT(0),
    BajaIMSS BIT NOT NULL DEFAULT(0),
    CambioCotizacionIMSS BIT NOT NULL DEFAULT(0),
    Activo BIT NOT NULL DEFAULT(1),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Empleados_Empresas FOREIGN KEY (IdEmpresa) REFERENCES dbo.Empresas(IdEmpresa),
    CONSTRAINT FK_Empleados_Departamentos FOREIGN KEY (IdDepartamento) REFERENCES dbo.Departamentos(IdDepartamento),
    CONSTRAINT FK_Empleados_Puestos FOREIGN KEY (IdPuesto) REFERENCES dbo.Puestos(IdPuesto),
    CONSTRAINT FK_Empleados_Bancos FOREIGN KEY (IdBanco) REFERENCES dbo.Bancos(IdBanco)
);
--CREATE INDEX IX_Empleados_Empresa ON dbo.Empleados(IdEmpresa);
--CREATE INDEX IX_Empleados_NSS ON dbo.Empleados(NSS);
--CREATE INDEX IX_Empleados_RFC ON dbo.Empleados(RFC);
--CREATE INDEX IX_Empleados_Codigo ON dbo.Empleados(CodigoEmpleado);

-- 6. Periodos
IF OBJECT_ID('dbo.Periodos') IS NOT NULL DROP TABLE dbo.Periodos;
CREATE TABLE dbo.Periodos (
    IdPeriodo INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpresa INT NOT NULL,
    Anio INT NOT NULL,
    Mes INT NOT NULL,
    NumeroPeriodo INT NOT NULL DEFAULT(1),
    FechaInicio DATE NULL,
    FechaFin DATE NULL,
    DiasPago INT NULL,
    FechaPago DATE NULL,
    Calculado BIT NOT NULL DEFAULT(0),
    Afectado BIT NOT NULL DEFAULT(0),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Periodos_Empresas FOREIGN KEY (IdEmpresa) REFERENCES dbo.Empresas(IdEmpresa)
);
--CREATE INDEX IX_Periodos_Empresa_AnioMes ON dbo.Periodos(IdEmpresa, Anio, Mes);

-- 7. ConceptosNomina (Percepciones / Deducciones / Obligaciones)
IF OBJECT_ID('dbo.ConceptosNomina') IS NOT NULL DROP TABLE dbo.ConceptosNomina;
CREATE TABLE dbo.ConceptosNomina (
    IdConcepto INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpresa INT NOT NULL,
    Numero NVARCHAR(20) NULL,
    Tipo CHAR(1) NOT NULL, -- P = Percepción, D = Deducción, O = Obligación
    Descripcion NVARCHAR(200) NOT NULL,
    Formula NVARCHAR(400) NULL, -- expresión o nota de cálculo
    TipoClaveSAT NVARCHAR(50) NULL,
    CuentaContable NVARCHAR(50) NULL,
    Activo BIT NOT NULL DEFAULT(1),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Conceptos_Empresas FOREIGN KEY (IdEmpresa) REFERENCES dbo.Empresas(IdEmpresa)
);
--CREATE INDEX IX_Conceptos_Empresa_Tipo ON dbo.ConceptosNomina(IdEmpresa, Tipo);

-- 8. MovimientosNomina (detalle del recibo / línea de concepto)
IF OBJECT_ID('dbo.MovimientosNomina') IS NOT NULL DROP TABLE dbo.MovimientosNomina;
CREATE TABLE dbo.MovimientosNomina (
    IdMovimiento INT IDENTITY(1,1) PRIMARY KEY,
    IdPeriodo INT NOT NULL,
    IdEmpleado INT NOT NULL,
    IdConcepto INT NOT NULL,
    Importe DECIMAL(14,2) NOT NULL DEFAULT(0),
    Valor DECIMAL(14,2) NULL,
    FechaRegistro DATETIME2 NOT NULL DEFAULT(GETDATE()),
    TipoMovimiento NVARCHAR(30) NULL, -- Permanente / Eventual
    Observaciones NVARCHAR(400) NULL,
    CONSTRAINT FK_Movimientos_Periodo FOREIGN KEY (IdPeriodo) REFERENCES dbo.Periodos(IdPeriodo),
    CONSTRAINT FK_Movimientos_Empleado FOREIGN KEY (IdEmpleado) REFERENCES dbo.Empleados(IdEmpleado),
    CONSTRAINT FK_Movimientos_Concepto FOREIGN KEY (IdConcepto) REFERENCES dbo.ConceptosNomina(IdConcepto)
);
--CREATE INDEX IX_Movimientos_Periodo ON dbo.MovimientosNomina(IdPeriodo);
--CREATE INDEX IX_Movimientos_Empleado ON dbo.MovimientosNomina(IdEmpleado);

-- 9. RecibosTimbrados (simulación de CFDI)
IF OBJECT_ID('dbo.RecibosTimbrados') IS NOT NULL DROP TABLE dbo.RecibosTimbrados;
CREATE TABLE dbo.RecibosTimbrados (
    IdRecibo INT IDENTITY(1,1) PRIMARY KEY,
    IdPeriodo INT NULL,
    IdEmpleado INT NOT NULL,
    Folio NVARCHAR(50) NULL,
    UUID NVARCHAR(50) NULL,
    FechaEmision DATETIME2 NULL,
    TotalPercepciones DECIMAL(14,2) NULL,
    TotalDeducciones DECIMAL(14,2) NULL,
    NetoPagar DECIMAL(14,2) NULL,
    Emitido BIT NOT NULL DEFAULT(0),
    Cancelado BIT NOT NULL DEFAULT(0),
    Metadatos XML NULL,
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Recibos_Empleado FOREIGN KEY (IdEmpleado) REFERENCES dbo.Empleados(IdEmpleado),
    CONSTRAINT FK_Recibos_Periodo FOREIGN KEY (IdPeriodo) REFERENCES dbo.Periodos(IdPeriodo)
);
--CREATE INDEX IX_Recibos_Empleado ON dbo.RecibosTimbrados(IdEmpleado);

-- 10. MovimientosIMSS
IF OBJECT_ID('dbo.MovimientosIMSS') IS NOT NULL DROP TABLE dbo.MovimientosIMSS;
CREATE TABLE dbo.MovimientosIMSS (
    IdMovimientoIMSS INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL,
    TipoMovimiento NVARCHAR(50) NOT NULL, -- Alta / Baja / CambioSalario / CambioContrato
    FechaMovimiento DATE NOT NULL,
    SalarioBaseCotizacion DECIMAL(14,2) NULL,
    ArchivoGenerado NVARCHAR(200) NULL,
    Procesado BIT NOT NULL DEFAULT(0),
    Observaciones NVARCHAR(400) NULL,
    FechaRegistro DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_IMSS_Empleado FOREIGN KEY (IdEmpleado) REFERENCES dbo.Empleados(IdEmpleado)
);
--CREATE INDEX IX_IMSS_Empleado ON dbo.MovimientosIMSS(IdEmpleado);

-- 11. AvisosINFONAVIT
IF OBJECT_ID('dbo.AvisosINFONAVIT') IS NOT NULL DROP TABLE dbo.AvisosINFONAVIT;
CREATE TABLE dbo.AvisosINFONAVIT (
    IdAviso INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado INT NOT NULL,
    NumeroCredito NVARCHAR(50) NULL,
    TipoAviso NVARCHAR(50) NULL, -- Alta / Modificación / Suspensión
    FechaInicioDescuento DATE NULL,
    PorcentajeDescuento DECIMAL(5,2) NULL,
    MontoDescuento DECIMAL(14,2) NULL,
    Procesado BIT NOT NULL DEFAULT(0),
    FechaRegistro DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Infonavit_Empleado FOREIGN KEY (IdEmpleado) REFERENCES dbo.Empleados(IdEmpleado)
);
--CREATE INDEX IX_Infonavit_Empleado ON dbo.AvisosINFONAVIT(IdEmpleado);

-- 12. PolizasContables
IF OBJECT_ID('dbo.PolizasContables') IS NOT NULL DROP TABLE dbo.PolizasContables;
CREATE TABLE dbo.PolizasContables (
    IdPoliza INT IDENTITY(1,1) PRIMARY KEY,
    IdPeriodo INT NULL,
    Tipo NVARCHAR(50) NULL, -- Diario / Nómina / etc.
    Fecha DATE NULL,
    TotalCargos DECIMAL(18,2) NULL,
    TotalAbonos DECIMAL(18,2) NULL,
    Descripcion NVARCHAR(400) NULL,
    Exportada BIT NOT NULL DEFAULT(0),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Polizas_Periodo FOREIGN KEY (IdPeriodo) REFERENCES dbo.Periodos(IdPeriodo)
);
--CREATE INDEX IX_Polizas_Periodo ON dbo.PolizasContables(IdPeriodo);

-- 13. MovimientosPoliza
IF OBJECT_ID('dbo.MovimientosPoliza') IS NOT NULL DROP TABLE dbo.MovimientosPoliza;
CREATE TABLE dbo.MovimientosPoliza (
    IdMovPoliza INT IDENTITY(1,1) PRIMARY KEY,
    IdPoliza INT NOT NULL,
    CuentaContable NVARCHAR(80) NOT NULL,
    Concepto NVARCHAR(200) NULL,
    Cargo DECIMAL(18,2) NULL,
    Abono DECIMAL(18,2) NULL,
    FechaRegistro DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_MovPoliza_Poliza FOREIGN KEY (IdPoliza) REFERENCES dbo.PolizasContables(IdPoliza)
);

-- 14. Usuarios
IF OBJECT_ID('dbo.Usuarios') IS NOT NULL DROP TABLE dbo.Usuarios;
CREATE TABLE dbo.Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario NVARCHAR(80) NOT NULL UNIQUE,
    NombreCompleto NVARCHAR(200) NULL,
    PasswordHash NVARCHAR(400) NOT NULL,
    Rol NVARCHAR(50) NOT NULL, -- Gerente, Capturista, Consulta, Empleado
    Activo BIT NOT NULL DEFAULT(1),
    FechaCreacion DATETIME2 NOT NULL DEFAULT(GETDATE())
);
--CREATE INDEX IX_Usuarios_Rol ON dbo.Usuarios(Rol);

-- 15. ParametrosSistema
IF OBJECT_ID('dbo.ParametrosSistema') IS NOT NULL DROP TABLE dbo.ParametrosSistema;
CREATE TABLE dbo.ParametrosSistema (
    Clave NVARCHAR(100) PRIMARY KEY,
    Valor NVARCHAR(400) NULL,
    Descripcion NVARCHAR(400) NULL,
    FechaModificacion DATETIME2 NULL
);

-- 16. Logs / Bitacora (auditoría)
--IF OBJECT_ID('dbo.Bitacora') IS NOT NULL DROP TABLE dbo.Bitacora;
CREATE TABLE dbo.Bitacora (
    IdLog INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NULL,
    Entidad NVARCHAR(100) NULL,
    IdEntidad NVARCHAR(100) NULL,
    Accion NVARCHAR(100) NULL,
    Detalle NVARCHAR(MAX) NULL,
    Fecha DATETIME2 NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Bitacora_Usuario FOREIGN KEY (IdUsuario) REFERENCES dbo.Usuarios(IdUsuario)
);
--CREATE INDEX IX_Bitacora_Fecha ON dbo.Bitacora(Fecha);