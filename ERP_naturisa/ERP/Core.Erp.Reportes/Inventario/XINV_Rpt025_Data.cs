using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Reportes.Inventario
{
    class XINV_Rpt025_Data
    {
        string MensajeError = "";
        public List<XINV_Rpt025_Info> Get_list_reporte(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdProducto, DateTime fecha_ini, DateTime fecha_fin, string signo)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999: IdSucursal;

                int IdBodega_ini = IdBodega;
                int IdBodega_fin = IdBodega == 0 ? 9999 : IdBodega; ;

                int IdMovi_inven_tipo_ini = IdMovi_inven_tipo;
                int IdMovi_inven_tipo_fin = IdMovi_inven_tipo == 0 ? 9999 : IdMovi_inven_tipo; ;

                decimal IdProducto_ini = IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 9999 : IdProducto;

                List<XINV_Rpt025_Info> Lista = new List<XINV_Rpt025_Info>();

                using (Entities_Inventario_General Context = new Entities_Inventario_General())
                {
                    var lst = from q in Context.vwINV_Rpt025
                              where IdEmpresa == q.IdEmpresa
                              && IdSucursal_ini <= q.IdSucursal && q.IdSucursal <= IdSucursal_fin
                              && IdBodega_ini <= q.IdBodega && q.IdBodega <= IdBodega_fin
                              && IdMovi_inven_tipo_ini <= q.IdMovi_inven_tipo && q.IdMovi_inven_tipo <= IdMovi_inven_tipo_fin
                              && IdProducto_ini <= q.IdProducto && q.IdProducto <= IdProducto_fin
                              && fecha_ini <= q.cm_fecha && q.cm_fecha <= fecha_fin
                              select q;

                    if (signo != "") lst = lst.Where(q => q.signo == signo);

                    foreach (var item in lst)
                    {
                        XINV_Rpt025_Info info = new XINV_Rpt025_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.dm_cantidad = item.dm_cantidad;
                        info.dm_observacion = item.dm_observacion;
                        info.cm_observacion = item.cm_observacion;
                        info.mv_costo = item.mv_costo;
                        info.cm_fecha = item.cm_fecha;
                        info.Estado = item.Estado;
                        info.IdEstadoAproba = item.IdEstadoAproba;
                        info.pr_codigo = item.pr_codigo;
                        info.pr_descripcion = item.pr_descripcion;
                        info.bo_Descripcion = item.bo_Descripcion;
                        info.Su_Descripcion = item.Su_Descripcion;
                        info.tm_descripcion = item.tm_descripcion;
                        info.total = item.total;
                        info.CodMoviInven = item.CodMoviInven;
                        info.signo = item.signo;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
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
