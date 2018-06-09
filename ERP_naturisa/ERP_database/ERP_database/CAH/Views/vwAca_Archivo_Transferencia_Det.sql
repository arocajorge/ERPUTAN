CREATE VIEW [CAH].[vwAca_Archivo_Transferencia_Det]
	AS 

	SELECT        dbo.ba_Archivo_Transferencia.IdEmpresa, dbo.ba_Archivo_Transferencia.IdArchivo, dbo.ba_Archivo_Transferencia.IdBanco, dbo.ba_Archivo_Transferencia.IdProceso_bancario, 
                         dbo.ba_Archivo_Transferencia.Origen_Archivo, dbo.ba_Archivo_Transferencia.Cod_Empresa, dbo.ba_Archivo_Transferencia.Nom_Archivo, dbo.ba_Archivo_Transferencia.Fecha, 
                         dbo.ba_Archivo_Transferencia.Estado, dbo.ba_Archivo_Transferencia.IdEstadoArchivo_cat, dbo.ba_Archivo_Transferencia.Observacion, dbo.ba_Archivo_Transferencia_Det.Valor, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, dbo.ba_Catalogo.ca_descripcion AS nom_EstadoRegistro, dbo.ba_Archivo_Transferencia_Det.Id_Item, 
                         dbo.ba_Archivo_Transferencia_Det.Secuencia, dbo.ba_Archivo_Transferencia_Det.Valor AS Valor_Enviado, dbo.ba_Archivo_Transferencia_Det.Valor_cobrado, 
                         dbo.ba_Archivo_Transferencia_Det.Valor - dbo.ba_Archivo_Transferencia_Det.Valor_cobrado AS Saldo_x_Cobrar, dbo.ba_Archivo_Transferencia.IdOrden_Bancaria, 
                         dbo.ba_Archivo_Transferencia.IdMotivoArchivo_cat, ba_Catalogo_1.ca_descripcion AS nom_MotivoArchivo, dbo.ba_Archivo_Transferencia.Fecha_Proceso, NULL AS cb_Fecha_cheq, NULL AS num_cheq, NULL 
                         AS Observacion_cheq, NULL AS giradoA_cheq, NULL AS IdEstado_Preaviso_ch_cat, dbo.ba_Archivo_Transferencia_Det.Secuencial_reg_x_proceso, dbo.tb_persona.IdTipoDocumento, NULL AS Expr2, 
                         dbo.tb_persona.pe_Naturaleza, dbo.tb_persona.IdPersona, dbo.tb_persona.IdPersona AS Identidad, dbo.Aca_Seccion.Descripcion_secc, dbo.Aca_Paralelo.Descripcion_paralelo, dbo.Aca_curso.Descripcion_cur, 
                         dbo.Aca_Jornada.Descripcion_Jor, dbo.Aca_Rubro.Descripcion_rubro, dbo.Aca_Familiar_x_Estudiante.activo, dbo.Aca_Documento_Bancario_x_Rep_Economico.Numero_Documento, 
                         dbo.ba_Archivo_Transferencia_Det.IdInstitucion_Col,
                          dbo.ba_Archivo_Transferencia_Det.Contabilizado
FROM            dbo.ba_Catalogo INNER JOIN
                         dbo.ba_Archivo_Transferencia INNER JOIN
                         dbo.ba_Archivo_Transferencia_Det ON dbo.ba_Archivo_Transferencia.IdEmpresa = dbo.ba_Archivo_Transferencia_Det.IdEmpresa AND 
                         dbo.ba_Archivo_Transferencia.IdArchivo = dbo.ba_Archivo_Transferencia_Det.IdArchivo ON dbo.ba_Catalogo.IdCatalogo = dbo.ba_Archivo_Transferencia_Det.IdEstadoRegistro_cat INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.Aca_estudiante ON dbo.tb_persona.IdPersona = dbo.Aca_estudiante.IdPersona ON dbo.ba_Archivo_Transferencia_Det.IdInstitucion_Col = dbo.Aca_estudiante.IdInstitucion  
                         INNER JOIN
                         dbo.Aca_matricula ON dbo.Aca_estudiante.IdInstitucion = dbo.Aca_matricula.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = dbo.Aca_matricula.IdEstudiante INNER JOIN
                         dbo.Aca_Contrato_x_Estudiante ON dbo.Aca_matricula.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND dbo.Aca_matricula.IdEstudiante = dbo.Aca_Contrato_x_Estudiante.IdEstudiante AND 
                         dbo.Aca_matricula.IdMatricula = dbo.Aca_Contrato_x_Estudiante.IdMatricula AND dbo.Aca_matricula.IdAnioLectivo = dbo.Aca_Contrato_x_Estudiante.IdAnioLectivo INNER JOIN
                         dbo.Aca_Paralelo ON dbo.Aca_matricula.IdParalelo = dbo.Aca_Paralelo.IdParalelo INNER JOIN
                         dbo.Aca_curso ON dbo.Aca_Paralelo.IdCurso = dbo.Aca_curso.IdCurso INNER JOIN
                         dbo.Aca_Seccion ON dbo.Aca_curso.IdSeccion = dbo.Aca_Seccion.IdSeccion INNER JOIN
                         dbo.Aca_Jornada ON dbo.Aca_Seccion.IdJornada = dbo.Aca_Jornada.IdJornada INNER JOIN
                         dbo.Aca_Rubro ON dbo.ba_Archivo_Transferencia_Det.IdInstitucion_Col = dbo.Aca_Rubro.IdInstitucion INNER JOIN
                         dbo.Aca_Familiar_x_Estudiante ON dbo.Aca_estudiante.IdInstitucion = dbo.Aca_Familiar_x_Estudiante.IdInstitucion AND 
                         dbo.Aca_estudiante.IdEstudiante = dbo.Aca_Familiar_x_Estudiante.IdEstudiante INNER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico ON dbo.Aca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion AND 
                         dbo.Aca_Familiar_x_Estudiante.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar AND 
                         dbo.Aca_Familiar_x_Estudiante.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat INNER JOIN
                         dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula ON 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdInstitucion = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdInstitucion AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdFamiliar = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdFamiliar AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdParentesco_cat = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdParentesco_cat AND 
                         dbo.Aca_Documento_Bancario_x_Rep_Economico.IdDocumento_Bancario = dbo.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.IdDocumento_Bancario INNER JOIN
                         dbo.Aca_Catalogo ON dbo.Aca_Documento_Bancario_x_Rep_Economico.Tipo_documento_cat = dbo.Aca_Catalogo.IdCatalogo LEFT OUTER JOIN
                         dbo.ba_Catalogo AS ba_Catalogo_1 ON dbo.ba_Archivo_Transferencia.IdMotivoArchivo_cat = ba_Catalogo_1.IdCatalogo
WHERE        (dbo.Aca_Familiar_x_Estudiante.activo = 1)