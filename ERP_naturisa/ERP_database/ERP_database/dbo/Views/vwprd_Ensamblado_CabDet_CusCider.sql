

CREATE view [dbo].[vwprd_Ensamblado_CabDet_CusCider] as
select 
      cab.[IdBodega]
      ,cab.[IdGrupoTrabajo]
      ,cab.[IdProducto] as cab_IdProducto
      ,cab.[CodigoBarra] as CBMaestro
      ,cab.[CodObra]
      ,cab.[IdOrdenTaller]
      ,cab.[IdUsuario]
      ,cab.[IdUsuarioAnu]
      ,cab.[MotivoAnu]
      ,cab.[IdUsuarioUltModi]
      ,cab.[FechaAnu]
      ,cab.[FechaTransac]
      ,cab.[FechaUltModi]
      ,cab.[Estado] as cab_Estado
      ,cab.[Observacion] as cab_observacion,
      det.[IdEmpresa]
      ,det.[IdSucursal]
      ,det.[IdEnsamblado]
      ,det.[Secuencia]
      ,det.[IdProducto] as det_IdProducto
      ,det.[CodigoBarra]
      ,det.[Observacion] as det_observacion
      ,det.[en_cantidad]
       from dbo.prd_Ensamblado_CusCider cab inner join dbo.prd_Ensamblado_Det_CusCider  det 
on cab.IdEmpresa = det.IdEmpresa and cab.IdSucursal = det.IdSucursal 
and cab.IdEnsamblado = det.IdEnsamblado