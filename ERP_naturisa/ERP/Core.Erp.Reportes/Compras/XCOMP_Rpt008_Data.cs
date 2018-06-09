using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt008_Data
    {
        public List<XCOMP_Rpt008_Info> get_list(int IdEmpresa, int IdSucursal, decimal IdProducto, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<XCOMP_Rpt008_Info> Lista = new List<XCOMP_Rpt008_Info>();

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesCompra_reporte_Ge Context = new EntitiesCompra_reporte_Ge())
                {
                    var lst = from q in Context.vwCOMP_Rpt008
                              where q.IdEmpresa == IdEmpresa
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && Fecha_ini <= q.oc_fecha && q.oc_fecha <= Fecha_fin
                              select q;

                    foreach (var item in lst)
                    {
                        XCOMP_Rpt008_Info info = new XCOMP_Rpt008_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_descripcion = item.pr_descripcion;
                        info.IdPunto_cargo = item.IdPunto_cargo;
                        info.nom_punto_cargo = item.nom_punto_cargo;
                        info.oc_fecha = item.oc_fecha;
                        info.do_Cantidad = item.do_Cantidad;
                        info.do_precioCompra = item.do_precioCompra;
                        info.ult_costo = item.ult_costo;
                        info.diferencia = item.diferencia;
                        Lista.Add(info);
                    }
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(XCOMP_Rpt008_Data) };
            }
        }
    }
}
