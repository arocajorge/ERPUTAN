create view vwro_ro_Asignacion_Implemento_x_Empleado_xi_existen_pemdientes_devolver as
SELECT                   C.IdEmpresa,C.IdNomina_Tipo, C.IdEmpleado, 
                         C.Tipo_Movimiento, D.IdAsignacion_Impl,D.Estado_implemnto
FROM                     dbo.ro_Asignacion_Implemento_x_Empleado as C INNER JOIN
                         dbo.ro_Asignacion_Implemento_x_Empleado_det as D ON 
                        C.IdEmpresa = D.IdEmpresa AND 
                        C.IdAsignacion_Impl = D.IdAsignacion_Impl
						 where C.Tipo_Movimiento='-'
						 and D.Estado_implemnto!='DEV_IMPLE'
GROUP BY                 C.IdEmpresa,C.IdNomina_Tipo, C.IdEmpleado, 
                         C.Tipo_Movimiento, D.IdAsignacion_Impl,D.Estado_implemnto