use Prueba1;

/*Empresas*/
INSERT INTO Empresas (NombreFiscal, RFC, RegistroIMSS, RegistroInfonavit, RegimenFiscal, ClaveCFDI, EmitirRecibo)
VALUES ('EMPRESA DEMO SA DE CV', 'AAA010101AAA', '123456', '654321', '601 - General de Ley', 'G01', 1);

SELECT * FROM Empresas;
SELECT * FROM Empresas WHERE IdEmpresa = @IdEmpresa;

UPDATE Empresas SET
    NombreFiscal = @NombreFiscal,
    RFC = @RFC,
    RegistroIMSS = @RegistroIMSS,
    RegistroInfonavit = @RegistroInfonavit,
    RegimenFiscal = @RegimenFiscal,
    ClaveCFDI = @ClaveCFDI,
    EmitirRecibo = @EmitirRecibo
WHERE IdEmpresa = @IdEmpresa;

/*Departamentos*/
INSERT INTO Departamentos (IdEmpresa, Nombre, Responsable)
VALUES (@IdEmpresa, @Nombre, @Responsable);

SELECT * FROM Departamentos WHERE IdEmpresa = @IdEmpresa;

/*Puestos*/
INSERT INTO Puestos (IdEmpresa, Nombre, Nivel, SueldoBase)
VALUES (@IdEmpresa, @Nombre, @Nivel, @SueldoBase);

SELECT * FROM Puestos WHERE IdEmpresa = @IdEmpresa;

/*Bancos*/
INSERT INTO Bancos (Nombre, Clave)
VALUES (@Nombre, @Clave);

SELECT * FROM Bancos WHERE Activo = 1;

/*Empleados*/
INSERT INTO Empleados (
    IdEmpresa, CodigoEmpleado, Nombre, ApellidoPaterno, ApellidoMaterno,
    RFC, CURP, NSS, FechaNacimiento, FechaIngreso, SueldoDiario,
    SueldoIntegrado, IdDepartamento, IdPuesto, IdBanco, Clabe, TipoContrato,
    AltaIMSS, BajaIMSS, CambioCotizacionIMSS, Activo
)
VALUES (
    @IdEmpresa, @CodigoEmpleado, @Nombre, @ApellidoPaterno, @ApellidoMaterno,
    @RFC, @CURP, @NSS, @FechaNacimiento, @FechaIngreso, @SueldoDiario,
    @SueldoIntegrado, @IdDepartamento, @IdPuesto, @IdBanco, @Clabe, @TipoContrato,
    @AltaIMSS, @BajaIMSS, @CambioCotizacionIMSS, @Activo
);

/*Consulta con Join*/
SELECT e.IdEmpleado, e.CodigoEmpleado, e.Nombre, e.ApellidoPaterno, e.ApellidoMaterno,
       e.RFC, e.NSS, e.SueldoDiario, d.Nombre AS Departamento, p.Nombre AS Puesto
FROM Empleados e
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
WHERE e.IdEmpresa = @IdEmpresa AND e.Activo = 1;

UPDATE Empleados SET
    CodigoEmpleado = @CodigoEmpleado,
    Nombre = @Nombre,
    ApellidoPaterno = @ApellidoPaterno,
    ApellidoMaterno = @ApellidoMaterno,
    RFC = @RFC,
    CURP = @CURP,
    NSS = @NSS,
    FechaNacimiento = @FechaNacimiento,
    FechaIngreso = @FechaIngreso,
    SueldoDiario = @SueldoDiario,
    SueldoIntegrado = @SueldoIntegrado,
    IdDepartamento = @IdDepartamento,
    IdPuesto = @IdPuesto,
    IdBanco = @IdBanco,
    Clabe = @Clabe,
    TipoContrato = @TipoContrato
WHERE IdEmpleado = @IdEmpleado;

/*Periodos*/
INSERT INTO Periodos (IdEmpresa, Anio, Mes, NumeroPeriodo, FechaInicio, FechaFin, DiasPago, FechaPago)
VALUES (@IdEmpresa, @Anio, @Mes, @NumeroPeriodo, @FechaInicio, @FechaFin, @DiasPago, @FechaPago);

SELECT * FROM Periodos
WHERE IdEmpresa = @IdEmpresa AND Anio = @Anio AND Mes = @Mes;

/*Conceptos de Nómina*/
INSERT INTO ConceptosNomina (IdEmpresa, Numero, Tipo, Descripcion, Formula, TipoClaveSAT, CuentaContable)
VALUES (@IdEmpresa, @Numero, @Tipo, @Descripcion, @Formula, @TipoClaveSAT, @CuentaContable);

SELECT * FROM ConceptosNomina WHERE IdEmpresa = @IdEmpresa ORDER BY Tipo, Numero;

/*Movimientos de Nómina*/
INSERT INTO MovimientosNomina (
    IdPeriodo, IdEmpleado, IdConcepto, Importe, Valor, TipoMovimiento, Observaciones
)
VALUES (
    @IdPeriodo, @IdEmpleado, @IdConcepto, @Importe, @Valor, @TipoMovimiento, @Observaciones
);

SELECT m.*, c.Descripcion, c.Tipo
FROM MovimientosNomina m
JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE IdEmpleado = @IdEmpleado AND IdPeriodo = @IdPeriodo;

/*Recibos Timbrados*/
INSERT INTO RecibosTimbrados (IdPeriodo, IdEmpleado, TotalPercepciones, TotalDeducciones, NetoPagar)
VALUES (@IdPeriodo, @IdEmpleado, @TotPer, @TotDed, @Neto);

SELECT * FROM RecibosTimbrados
WHERE IdEmpleado = @IdEmpleado AND IdPeriodo = @IdPeriodo;

/*IMSS // INFONAVIT // Contabilidad*/

/*Consulta General*/
SELECT 
    e.IdEmpleado, 
    e.CodigoEmpleado, 
    e.Nombre, 
    e.ApellidoPaterno, 
    e.ApellidoMaterno,
    e.RFC, 
    e.NSS, 
    e.SueldoDiario,
    d.Nombre AS Departamento,
    p.Nombre AS Puesto
FROM Empleados e
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
WHERE e.IdEmpresa = @IdEmpresa AND e.Activo = 1
ORDER BY e.Nombre, e.ApellidoPaterno;

/*Consulta con Búsqueda*/

SELECT 
    e.IdEmpleado, 
    e.CodigoEmpleado, 
    e.Nombre, 
    e.ApellidoPaterno, 
    e.ApellidoMaterno,
    e.RFC, 
    e.NSS, 
    e.SueldoDiario,
    d.Nombre AS Departamento,
    p.Nombre AS Puesto
FROM Empleados e
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
WHERE 
    e.IdEmpresa = @IdEmpresa 
    AND e.Activo = 1
    AND (
        e.Nombre LIKE '%' + @Texto + '%'
        OR e.ApellidoPaterno LIKE '%' + @Texto + '%'
        OR e.ApellidoMaterno LIKE '%' + @Texto + '%'
        OR e.CodigoEmpleado LIKE '%' + @Texto + '%'
        OR e.RFC LIKE '%' + @Texto + '%'
        OR e.CURP LIKE '%' + @Texto + '%'
        OR e.NSS LIKE '%' + @Texto + '%'
    )
ORDER BY e.Nombre, e.ApellidoPaterno;

/*Consulta por Departamento*/
SELECT 
    e.IdEmpleado, e.CodigoEmpleado, e.Nombre, e.ApellidoPaterno, e.ApellidoMaterno,
    d.Nombre AS Departamento, p.Nombre AS Puesto
FROM Empleados e
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
WHERE e.IdEmpresa = @IdEmpresa AND e.IdDepartamento = @IdDepartamento AND e.Activo = 1;

/*Consulta por Puesto*/
SELECT 
    e.IdEmpleado, e.CodigoEmpleado, e.Nombre, e.ApellidoPaterno, e.ApellidoMaterno,
    d.Nombre AS Departamento, p.Nombre AS Puesto
FROM Empleados e
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
WHERE e.IdEmpresa = @IdEmpresa AND e.IdPuesto = @IdPuesto AND e.Activo = 1;

/*Consulta para ComboBox*/
SELECT IdEmpleado, Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS NombreCompleto
FROM Empleados
WHERE Activo = 1 AND IdEmpresa = @IdEmpresa
ORDER BY NombreCompleto;

/*Consulta por ID de empleado [detalle]*/
SELECT *
FROM Empleados
WHERE IdEmpleado = @IdEmpleado;

/*Consulta completa*/
SELECT 
    e.*,
    d.Nombre AS NombreDepartamento,
    p.Nombre AS NombrePuesto,
    b.Nombre AS Banco,
    emp.NombreFiscal AS Empresa
FROM Empleados e
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
LEFT JOIN Bancos b ON e.IdBanco = b.IdBanco
LEFT JOIN Empresas emp ON e.IdEmpresa = emp.IdEmpresa
WHERE e.IdEmpleado = @IdEmpleado;

/*Reporte por periodo estilo nomina*/
SELECT 
    e.IdEmpleado,
    e.CodigoEmpleado,
    e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno AS NombreCompleto,
    
    SUM(CASE WHEN c.Tipo = 'P' THEN m.Importe ELSE 0 END) AS TotalPercepciones,
    SUM(CASE WHEN c.Tipo = 'D' THEN m.Importe ELSE 0 END) AS TotalDeducciones,
    SUM(CASE WHEN c.Tipo = 'P' THEN m.Importe ELSE 0 END) -
    SUM(CASE WHEN c.Tipo = 'D' THEN m.Importe ELSE 0 END) AS NetoPagar

FROM MovimientosNomina m
INNER JOIN Empleados e ON m.IdEmpleado = e.IdEmpleado
INNER JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE m.IdPeriodo = @IdPeriodo
GROUP BY e.IdEmpleado, e.CodigoEmpleado, e.Nombre, e.ApellidoPaterno, e.ApellidoMaterno
ORDER BY NombreCompleto;


/*Totales Globales del periodo*/
SELECT
    SUM(CASE WHEN c.Tipo = 'P' THEN m.Importe ELSE 0 END) AS TotalPercepcionesGlobal,
    SUM(CASE WHEN c.Tipo = 'D' THEN m.Importe ELSE 0 END) AS TotalDeduccionesGlobal,
    SUM(CASE WHEN c.Tipo = 'P' THEN m.Importe ELSE 0 END) -
    SUM(CASE WHEN c.Tipo = 'D' THEN m.Importe ELSE 0 END) AS NetoTotalGlobal
FROM MovimientosNomina m
INNER JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE m.IdPeriodo = @IdPeriodo;

/*Percepciones vs Deducciones [detalle por concepto]*/
SELECT
    c.Numero,
    c.Descripcion,
    c.Tipo,
    SUM(m.Importe) AS Total
FROM MovimientosNomina m
INNER JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE m.IdPeriodo = @IdPeriodo
GROUP BY c.Numero, c.Descripcion, c.Tipo
ORDER BY c.Tipo, c.Numero;


/*Calculo Base Imss*/
SELECT
    e.IdEmpleado,
    e.Nombre + ' ' + e.ApellidoPaterno AS Nombre,
    e.SueldoDiario,
    e.SueldoIntegrado AS SDI,
    e.NSS
FROM Empleados e
WHERE e.IdEmpresa = @IdEmpresa AND e.Activo = 1;

SELECT 
    SUM(m.Importe) AS TotalDescuentoIMSS
FROM MovimientosNomina m
INNER JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE m.IdPeriodo = @IdPeriodo
AND c.TipoClaveSAT LIKE 'IMSS%';

/*Historial de sueldos del empleado*/
SELECT
    e.IdEmpleado,
    e.SueldoDiario,
    e.SueldoIntegrado,
    e.FechaCreacion
FROM Empleados e
WHERE e.IdEmpleado = @IdEmpleado
ORDER BY FechaCreacion ASC;

/*Reporte Completo Estilo Contpaqi*/
SELECT
    e.IdEmpleado,
    e.CodigoEmpleado,
    e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno AS NombreEmpleado,
    d.Nombre AS Departamento,
    p.Nombre AS Puesto,
    r.Folio,
    r.UUID,
    r.TotalPercepciones,
    r.TotalDeducciones,
    r.NetoPagar,
    r.FechaEmision
FROM RecibosTimbrados r
INNER JOIN Empleados e ON r.IdEmpleado = e.IdEmpleado
LEFT JOIN Departamentos d ON e.IdDepartamento = d.IdDepartamento
LEFT JOIN Puestos p ON e.IdPuesto = p.IdPuesto
WHERE r.IdPeriodo = @IdPeriodo
ORDER BY NombreEmpleado;

/*Reporte detallado de movimientos del empleado*/
SELECT
    c.Numero AS Clave,
    c.Descripcion AS Concepto,
    c.Tipo,
    m.Importe,
    m.Valor,
    m.TipoMovimiento
FROM MovimientosNomina m
INNER JOIN ConceptosNomina c ON m.IdConcepto = c.IdConcepto
WHERE m.IdPeriodo = @IdPeriodo AND m.IdEmpleado = @IdEmpleado
ORDER BY c.Tipo, c.Numero;


/*Usuarios*/
select Usuario, PasswordHash from Usuarios
where Usuario = 'Usuario1' AND PasswordHash = '123456';

INSERT INTO Usuarios(Usuario, NombreCompleto, PasswordHash, Rol, Activo)
VALUES ('Usuario1', 'Tedss Kuma', '123456', 'Gerente', 1);