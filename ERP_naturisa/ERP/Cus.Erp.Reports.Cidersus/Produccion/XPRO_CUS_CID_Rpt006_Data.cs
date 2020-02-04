using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class XPRO_CUS_CID_Rpt006_Data
    {
        string mensaje = "";
        public List< XPRO_CUS_CID_Rpt006_Info> Get_Codigo_Barra( int IdEmpresa,int IdSucursal, int IdBodega, int IdMovi_inven_tipo, int IdNumMovi)
        {
            try
            {
                List<XPRO_CUS_CID_Rpt006_Info> lista = new List<XPRO_CUS_CID_Rpt006_Info>();
                using (EntitiesProduccion_Edehsa_Rpt db= new EntitiesProduccion_Edehsa_Rpt())
                {
                   var select_ = from q in db.vwPRO_CUS_CID_Rpt001
                                 where q.IdEmpresa==IdEmpresa
                                 && q.IdSucursal == IdSucursal
                                 && q.IdBodega == IdBodega
                                 && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                                 && q.IdNumMovi == IdNumMovi
                              select q;


                   foreach (var item in select_)
                   {
                       XPRO_CUS_CID_Rpt006_Info info = new XPRO_CUS_CID_Rpt006_Info();
                        info.IdEmpresa = item.IdEmpresa;

                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        info.IdNumMovi = item.IdNumMovi;
                        info.mv_Secuencia = item.mv_Secuencia;
                        info.Secuencia = item.Secuencia;
                        info.IdProducto = item.IdProducto;
                        info.CodigoBarra = item.CodigoBarra;
                        info.mv_tipo_movi = item.mv_tipo_movi;
                        info.dm_cantidad = item.dm_cantidad;
                        info.dm_observacion = item.dm_observacion;
                        info.dm_precio = item.dm_precio;
                        info.mv_costo = item.mv_costo;
                        info.pr_descripcion = item.pr_descripcion;
                        info.pr_observacion = item.pr_observacion;
                        info.Fecha_Transac = item.Fecha_Transac;


                       lista.Add(info);
                       
                   }
                }


                return lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
