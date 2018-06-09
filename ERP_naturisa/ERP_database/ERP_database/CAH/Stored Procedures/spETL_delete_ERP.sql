CREATE proc [CAH].[spETL_delete_ERP]
(
@i_Operacion varchar(20)
)
as
begin
declare @i_respuesta bit
set @i_respuesta = 0
end

            if (@i_Operacion='DELETE')
	       begin

					if(@i_respuesta = 0)
					begin
					delete from CAH.Aca_matricula_x_mg_matricula
					set @i_respuesta = 1
					end

					if(@i_respuesta = 1)
		            begin
					set @i_respuesta = 0
					delete from Aca_matricula
					set @i_respuesta = 1
					end

					if(@i_respuesta = 1)
					begin
					set @i_respuesta = 0
					delete from [dbo].Aca_Paralelo
					set @i_respuesta = 1
					end

					if(@i_respuesta = 1)
					begin
					set @i_respuesta = 0
					delete from [dbo].Aca_curso
					set @i_respuesta = 1
					end
if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].Aca_Seccion
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].Aca_Jornada
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].Aca_Sede
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from CAH.Aca_Anio_Lectivo_x_mg_anio_lectivo
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_periodo
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].Aca_Anio_Lectivo
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Aspirante
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Pre_Facturacion_det
set @i_respuesta = 1
end


if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].[Aca_Rubro_x_Aca_Periodo_Lectivo]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Rubro
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Beca
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Academico.fa_notaCredDeb_aca
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Academico.fa_factura_aca
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from[dbo].[Aca_Familiar_x_Estudiante]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [Aca_ficha_medica]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [Aca_estudiante_x_Alergia]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_estudiante
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Documento_Bancario_x_Rep_Economico
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Familiar
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].[Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from Aca_Institucion
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].Aca_Tipo_Mecanismo_Pago
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from  CAH.Aca_Familiar_x_Estudiante_x_fa_cliente_Auditoria
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from [dbo].[Aca_Familiar_x_Estudiante_x_fa_cliente]
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from dbo.tb_persona 
where IdPersona in
 (select per.IdPersona from tb_persona per
left join cp_proveedor prov on prov.IdPersona = per.IdPersona
left join fa_cliente clien on clien.IdPersona = per.IdPersona
where prov.IdPersona is null and clien.IdPersona is null)
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from CAH.mg_alumno_x_Aca_aspirante
delete from CAH.mg_alumno_x_Aca_estudiante
delete from CAH.tb_ciudad_x_mg_ciudad
delete from CAH.tb_pais_x_mg_pais
delete from CAH.tb_persona_x_mg_persona
delete from CAH.tb_provincia_x_mg_provincia
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_factura_det
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_factura_x_formaPago
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_factura_x_in_Ing_Egr_Inven
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_factura_x_in_movi_inve
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_factura
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_notaCreDeb_det
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_notaCreDeb_x_ct_cbtecble
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_notaCreDeb
set @i_respuesta = 1
end

if(@i_respuesta = 1)
begin
set @i_respuesta = 0
delete from fa_cliente
where IdUsuario = 'sys_mig_aca'  and IdUsuario= 'sys_mig_aca'
set @i_respuesta = 1
end

end