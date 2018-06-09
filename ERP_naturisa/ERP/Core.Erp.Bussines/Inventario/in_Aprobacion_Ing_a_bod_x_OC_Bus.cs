using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;


namespace Core.Erp.Business.Inventario
{
   public class in_Aprobacion_Ing_a_bod_x_OC_Bus
    {
       string mensaje = "";
       in_Aprobacion_Ing_a_bod_x_OC_Data Odata ;
       
       public in_Aprobacion_Ing_a_bod_x_OC_Bus()
       {
           try
           {
              Odata = new in_Aprobacion_Ing_a_bod_x_OC_Data();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "in_Aprobacion_Ing_a_bod_x_OC_Bus", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

               
           }
       }

       public List<in_Aprobacion_Ing_a_bod_x_OC_Info> Get_List_Aprobacion_Ing_a_bod_x_OC(int IdEmpresa, DateTime desde, DateTime Hasta)
        {
            try
            {

                return Odata.Get_List_Aprobacion_Ing_a_bod_x_OC(IdEmpresa, desde, Hasta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consulta", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

            }
        }


       public in_Aprobacion_Ing_a_bod_x_OC_Info Get_Info_Aprobacion_Ing_a_bod_x_OC(int IdEmpresa, decimal IdAprobacion)
        {
            try
            {

                return Odata.Get_Info_Aprobacion_Ing_a_bod_x_OC(IdEmpresa, IdAprobacion);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consulta_Info", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

            }
        }

        public Boolean GrabarDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info,ref decimal IdAprobacion,ref string msg)
        {
            try
            {
                return  Odata.GrabarDB(Info,ref IdAprobacion,ref msg);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

            }
        }



        public Boolean ModificarDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info, ref string msg)
        {
            try
            {
                return Odata.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

            }
        }



        public Boolean AnularDB(in_Aprobacion_Ing_a_bod_x_OC_Info Info, ref string msg)
        {
            try
            {
                return Odata.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(in_Aprobacion_Ing_a_bod_x_OC_Bus) };

            }
        }

    }
}
