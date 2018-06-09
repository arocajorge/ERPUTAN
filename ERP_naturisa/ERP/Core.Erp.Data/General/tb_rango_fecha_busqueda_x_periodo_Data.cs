using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
   public  class tb_rango_fecha_busqueda_x_periodo_Data
    {
       string mensaje = "";
       
       public List<tb_rango_fecha_busqueda_x_periodo_Info> Obtener_Listado_Rango_fechas()
       {
           try
           {

               List<tb_rango_fecha_busqueda_x_periodo_Info> listado = new List<tb_rango_fecha_busqueda_x_periodo_Info>();
               EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

               var selectEmpresa = from C in OEselecEmpresa.tb_rango_fecha_busqueda_x_periodo
                                   select C;

               foreach (var item in selectEmpresa)
               {

                   tb_rango_fecha_busqueda_x_periodo_Info Cbt = new tb_rango_fecha_busqueda_x_periodo_Info();

                   Cbt.Id = item.Id;
                   Cbt.Descripcion = item.Descripcion;
                   Cbt.valor_ini = item.valor_ini;
                   Cbt.valor_fin = item.valor_fin;
                   Cbt.uni_medida = item.uni_medida;
                   listado.Add(Cbt);
               }
               return listado;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString() + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }
    }
}
