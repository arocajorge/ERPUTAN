using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Inventario
{
   public class in_Aprobacion_Ing_a_bod_x_OC_Data
    {
       string mensaje = "";

       public List<in_Aprobacion_Ing_a_bod_x_OC_Info> Get_List_Aprobacion_Ing_a_bod_x_OC(int IdEmpresa, DateTime desde, DateTime Hasta)
       {

           List<in_Aprobacion_Ing_a_bod_x_OC_Info> lista = new List<in_Aprobacion_Ing_a_bod_x_OC_Info>();

           EntitiesInventario oEnti = new EntitiesInventario();

           try
           {
               var select = from q in oEnti.in_Aprobacion_Ing_a_bod_x_OC
                            where q.IdEmpresa == IdEmpresa
                            && q.Fecha >= desde && q.Fecha <= Hasta
                            select q;

               foreach (var item in select)
               {
                   in_Aprobacion_Ing_a_bod_x_OC_Info info = new in_Aprobacion_Ing_a_bod_x_OC_Info();

                  //info.bo_descripcion = item.bo_Descripcion;
                  
                   lista.Add(info);

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

       public in_Aprobacion_Ing_a_bod_x_OC_Info Get_Info_Aprobacion_Ing_a_bod_x_OC(int IdEmpresa, decimal IdAprobacion)
       {
           try
           {

               return new in_Aprobacion_Ing_a_bod_x_OC_Info();
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

       public Boolean GrabarDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info, ref decimal IdAprobacion, ref string msg)
       {
           try
           {
               return true;
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

       public Boolean ModificarDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info, ref string msg)
       {
           try
           {
               return true;
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

       public Boolean AnularDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info, ref string msg)
       {
           try
           {
               return true;
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
 