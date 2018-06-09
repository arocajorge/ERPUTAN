using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt007_Data
    {
        string mensaje = "";

        public List<XCOMP_Rpt007_Info> Get_Lista(int _IdEmpresa, int _IdSucursal, int _IdSucursalFin, DateTime FechaCorte, int _Alerta, int _AlertaFin)
        {
            try
            {
                List<XCOMP_Rpt007_Info> Lista = new List<XCOMP_Rpt007_Info>();
                using (EntitiesCompra_reporte_Ge DbContext = new EntitiesCompra_reporte_Ge())
                {
                    Lista = (from q in DbContext.spCOMP_Rpt007(_IdEmpresa, _IdSucursal, _IdSucursalFin, FechaCorte)
                             where _Alerta <=  q.Alerta && q.Alerta <= _AlertaFin
                             select new XCOMP_Rpt007_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 Nom_Empresa = q.Nom_Empresa,
                                 IdSucursal = q.IdSucursal,
                                 Nom_Sucursal = q.Nom_Sucursal,
                                 Fecha_Corte = q.Fecha_Corte,
                                 IdMes1_anio = q.IdMes1_anio,
                                 IdMes2_anio = q.IdMes2_anio,
                                 IdMes3_anio = q.IdMes3_anio,
                                 IdMes4_anio = q.IdMes4_anio,
                                 Nom_Mes1_anio = q.Nom_Mes1_anio,
                                 Nom_Mes2_anio = q.Nom_Mes2_anio,
                                 Nom_Mes3_anio = q.Nom_Mes3_anio,
                                 Nom_Mes4_anio = q.Nom_Mes4_anio,
                                 Cant_Mes1_anio = q.Cant_Mes1_anio,
                                 Cant_Mes2_anio = q.Cant_Mes2_anio,
                                 Cant_Mes3_anio = q.Cant_Mes3_anio,
                                 Cant_Mes4_anio = q.Cant_Mes4_anio,
                                 Prom_cant_x_comp = q.Prom_cant_x_comp,
                                 IdProducto = q.IdProducto,
                                 Cod_Producto = q.Cod_Producto,
                                 nom_producto = q.nom_producto,
                                 stock_min = q.stock_min,
                                 stock_a_la_fecha = q.stock_a_la_fecha,
                                 Alerta = q.Alerta,
                                 varianza = q.varianza
                             }).ToList();
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt007_Data) };
            }
        }
    }
}
