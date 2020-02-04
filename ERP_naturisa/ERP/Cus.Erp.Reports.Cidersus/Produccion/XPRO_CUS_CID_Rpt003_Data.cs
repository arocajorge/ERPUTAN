using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt003_Data
   {
       string mensaje = "";
       public List<XPRO_CUS_CID_Rpt003_Info> Get_cotizacion(int IdEmpresa, int IdCotizacion, int IdSucursal)
       {
           try
           {
               tb_Empresa_Info Cbt = new tb_Empresa_Info();
               tb_Empresa_Data empresaData = new tb_Empresa_Data();
               List<XPRO_CUS_CID_Rpt003_Info> lista = new List<XPRO_CUS_CID_Rpt003_Info>();
               using (EntitiesProduccion_Edehsa_Rpt db = new EntitiesProduccion_Edehsa_Rpt())
               {
                   var select_ = from q in db.vwPRO_CUS_CID_Rpt003
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal == IdSucursal
                                 && q.IdCotizacion == IdCotizacion
                                 select q;

                   Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                   foreach (var item in select_)
                   {
                       XPRO_CUS_CID_Rpt003_Info info = new XPRO_CUS_CID_Rpt003_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdSucursal = item.IdSucursal;
                       info.IdCotizacion = item.IdCotizacion;
                       info.Secuencia = item.Secuencia;
                       info.Idproducto = item.Idproducto;
                       info.Cant_a_cotizar = item.Cant_a_cotizar;
                       info.Cant_soli = item.Cant_soli;
                       info.IdListadoMateriales_lq = item.IdListadoMateriales_lq;
                       info.nom_sucursal = item.nom_sucursal;
                       info.FechaReg = item.FechaReg;
                       info.IdDetalle_lq = item.IdDetalle_lq;
                       info.pr_descripcion   = item.pr_descripcion;
                       info.Observacion = item.Observacion;
                       info.pr_nombre = item.pr_nombre;
                       info.em_logo = Cbt.em_logo;
                       info.em_nombre = Cbt.em_nombre;

                       


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
