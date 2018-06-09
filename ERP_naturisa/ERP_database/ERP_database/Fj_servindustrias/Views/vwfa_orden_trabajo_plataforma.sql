create view Fj_servindustrias.[vwfa_orden_trabajo_plataforma]
as
SELECT        Fj_servindustrias.fa_orden_trabajo_plataforma.IdEmpresa, Fj_servindustrias.fa_orden_trabajo_plataforma.IdOrdenTrabajo_Pla, Fj_servindustrias.fa_orden_trabajo_plataforma.codOrdenTrabajo_Pla, 
                         Fj_servindustrias.fa_orden_trabajo_plataforma.IdCliente, Fj_servindustrias.fa_orden_trabajo_plataforma.Descripcion, Fj_servindustrias.fa_orden_trabajo_plataforma.Equipo, 
                         Fj_servindustrias.fa_orden_trabajo_plataforma.serie, Fj_servindustrias.fa_orden_trabajo_plataforma.km_salida, Fj_servindustrias.fa_orden_trabajo_plataforma.km_llegada, 
                         Fj_servindustrias.fa_orden_trabajo_plataforma.con_atencion_a, Fj_servindustrias.fa_orden_trabajo_plataforma.IdUsuarioUltMod, Fj_servindustrias.fa_orden_trabajo_plataforma.Fecha_UltMod, 
                         Fj_servindustrias.fa_orden_trabajo_plataforma.IdUsuarioUltAnu, Fj_servindustrias.fa_orden_trabajo_plataforma.Fecha_UltAnu, Fj_servindustrias.fa_orden_trabajo_plataforma.MotiAnula, 
                         Fj_servindustrias.fa_orden_trabajo_plataforma.nom_pc, Fj_servindustrias.fa_orden_trabajo_plataforma.ip, Fj_servindustrias.fa_orden_trabajo_plataforma.Estado, 
                         dbo.tb_persona.pe_nombreCompleto AS nom_Cliente, Fj_servindustrias.fa_orden_trabajo_plataforma.Fecha, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_direccion
FROM            dbo.fa_cliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona RIGHT OUTER JOIN
                         Fj_servindustrias.fa_orden_trabajo_plataforma ON dbo.fa_cliente.IdEmpresa = Fj_servindustrias.fa_orden_trabajo_plataforma.IdEmpresa AND 
                         dbo.fa_cliente.IdCliente = Fj_servindustrias.fa_orden_trabajo_plataforma.IdCliente