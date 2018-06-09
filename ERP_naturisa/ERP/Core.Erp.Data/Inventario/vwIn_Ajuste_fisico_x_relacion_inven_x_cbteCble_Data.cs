using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
   public  class vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Data
    {
       List<vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info> listaData = new List<vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info>();
       public List<vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info> Get_List_In_Ajuste_fisico_x_relacion_inven_x_cbteCble(int idEmpresa, decimal IdAjusteFisico, ref string mensaje)
       {
           EntitiesInventario oEnti = new EntitiesInventario();
           try
           {
               var select = from q in oEnti.vwin_Ajuste_fisico_x_relacion_inven_x_cbteCble
                            where q.IdEmpresa == idEmpresa && q.IdAjusteFisico == IdAjusteFisico
                            select q;
               foreach (var item in select)
               {
                   vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info info = new vwIn_Ajuste_fisico_x_relacion_inven_x_cbteCble_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdBodega = item.IdBodega;
                   info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                   info.IdNumMovi = item.IdNumMovi;
                   info.cm_observacion = item.cm_observacion;
                   info.cm_fecha = item.cm_fecha;
                   info.IdTipoCbte = item.IdTipoCbte;
                   info.IdCbteCble = item.IdCbteCble;
                   info.CodCbteCble = item.CodCbteCble;
                   info.cb_Fecha = item.cb_Fecha;
                   info.cb_Valor = item.cb_Valor;
                   info.cb_Observacion = item.cb_Observacion;
                   info.IdAjusteFisico = item.IdAjusteFisico;
                   info.Su_Descripcion = item.Su_Descripcion;
                   info.tm_descripcion = item.tm_descripcion;
                   info.tc_TipoCbte = item.tc_TipoCbte;
                   listaData.Add(info);
               }
               return listaData;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }

       }




   
   
   }
}
