using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Data.General
{
   public  class tb_sis_Grupo_empresarial_Cliente_Data
    {

       
       public List<tb_sis_Grupo_empresarial_Cliente_Info> Get_List_Grupo_empresarial_Cliente(ref string mensaje)
       {
           try
           {
               List<tb_sis_Grupo_empresarial_Cliente_Info> lista = new List<tb_sis_Grupo_empresarial_Cliente_Info>();

               EntitiesGeneral oEnti = new EntitiesGeneral();


               var select = from q in oEnti.tb_sis_Grupo_empresarial_Cliente
                            select q;

               foreach (var item in select)
               {
                   tb_sis_Grupo_empresarial_Cliente_Info info = new tb_sis_Grupo_empresarial_Cliente_Info();

                   info.IdGrupo_Empresarial_cliente = item.IdGrupo_Empresarial_cliente;
                   info.descripcion = item.descripcion;

                   lista.Add(info);
               }

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public tb_sis_Grupo_empresarial_Cliente_Data()
       {

       }
    }
}
