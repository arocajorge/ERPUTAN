using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using System.IO;
using System.Drawing;



namespace Core.Erp.Data.General
{
   public  class tb_sis_iconos_Data
    {

       string mensaje = "";

       public List<tb_sis_iconos_Info> Get_List_iconos()
       {
           try
           {
               List<tb_sis_iconos_Info> lM = new List<tb_sis_iconos_Info>();
               EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

               var selectEmpresa = from C in OEselecEmpresa.tb_sis_iconos
                                   select C;

               foreach (var item in selectEmpresa)
               {
                   tb_sis_iconos_Info Cbt = new tb_sis_iconos_Info();
                   Cbt.IdIcono = item.IdIcono;
                   Cbt.Icono = item.Icono;
                   Cbt.Icono_image =Funciones.ArrayAImage(item.Icono);
                   Cbt.descripcion = item.descripcion;
                   Cbt.DirectoryName = item.DirectoryName;
                   Cbt.Extencion = item.Extencion;
                   Cbt.FullName = item.FullName;
                   Cbt.Length = item.Length;
                   lM.Add(Cbt);
               }

               return (lM);
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

       public Boolean GrabarDB(tb_sis_iconos_Info info, ref string msgError)
       {

           try
           {

               using (EntitiesGeneral context = new EntitiesGeneral())
               {
                   EntitiesGeneral EDB = new EntitiesGeneral();
                   var Q = from per in EDB.tb_sis_iconos
                           where per.IdIcono == info.IdIcono
                           select per;
                   if (Q.ToList().Count == 0)
                   {


                       tb_sis_iconos address = new tb_sis_iconos();

                       address.IdIcono = info.IdIcono;
                       address.Icono = info.Icono;
                       address.descripcion = info.descripcion;
                       address.Extencion = info.Extencion;
                       address.FullName = info.FullName;
                       address.Length = info.Length;
                       address.DirectoryName = info.DirectoryName;
                       context.tb_sis_iconos.Add(address);
                       context.SaveChanges();
                   }
                   else
                       return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               msgError = "Error al grabar .. " + ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       
      
       
    }
}
