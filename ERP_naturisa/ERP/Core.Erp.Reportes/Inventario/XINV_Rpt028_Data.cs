using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    class XINV_Rpt028_Data
    {
        public List<XINV_Rpt028_Info> Get_list(int IdEmpresa, decimal IdProducto, decimal IdProveedor, int IdSucursal , decimal IdOrdenCompra, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 9999999 : IdProducto;

                decimal IdProveedor_ini = IdProveedor;
                decimal IdProveedor_fin = IdProveedor == 0 ? 9999999 : IdProveedor;

                decimal IdOrdenCompra_ini = IdOrdenCompra;
                decimal IdOrdenCompra_fin = IdOrdenCompra == 0 ? 9999999 : IdOrdenCompra;

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 99999 : IdSucursal;

                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                
                List<XINV_Rpt028_Info> Lista = new List<XINV_Rpt028_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = from q in Context.vwINV_Rpt028
                              where q.IdEmpresa == IdEmpresa
                              && IdProducto_ini<= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && IdProveedor_ini <= q.IdProveedor && q.IdProveedor <= IdProveedor_fin
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdOrdenCompra_ini <= q.IdOrdenCompra && q.IdOrdenCompra <= IdOrdenCompra_fin
                              && Fecha_ini <= q.oc_fecha && q.oc_fecha <= Fecha_fin
                              select q;

                    foreach (var item in lst)
                    {
                        XINV_Rpt028_Info info = new XINV_Rpt028_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdOrdenCompra = item.IdOrdenCompra;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.cod_prod = item.cod_prod;
                        info.pr_descripcion = item.pr_descripcion;
                        info.oc_fecha = item.oc_fecha;
                        info.IdProveedor = item.IdProveedor;
                        info.cod_provee = item.cod_provee;
                        info.nom_provee = item.nom_provee;
                        info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                        info.do_Cantidad = item.do_Cantidad;
                        info.dm_cantidad = item.dm_cantidad;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
