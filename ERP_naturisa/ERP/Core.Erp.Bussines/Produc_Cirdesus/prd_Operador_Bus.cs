using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produc_Cirdesus
{
  public   class prd_Operador_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Operador_Data data = new prd_Operador_Data();



        public Boolean GuardarDB(prd_Operador_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Operador_Bus) };
               
            }
        }



        public List<prd_Operador_Info> ListadoOperadores()
        {
            try
            {
                return data.ListadoOperadores();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListadoOperadores", ex.Message), ex) { EntityType = typeof(prd_Operador_Bus) };
               
            }

        }


        public Boolean ModificarDB(prd_Operador_Info info, ref string msg)
        {
            try
            {

                return data.ModificarDB(info, ref msg);


            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_Operador_Bus) };
               
            }
        }


        public Boolean AnularDB(prd_Operador_Info info, ref string msg)
        {
            try
            {

                return data.AnularDB(info, ref msg);


            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(prd_Operador_Bus) };
               
            }
        }
        // public Boolean AnularDB(prd_Operador_Info info, ref string msg)

        public int GedId(ref string mensaje)
        {
            try
            {

                return data.GedId(ref mensaje);


            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GedId", ex.Message), ex) { EntityType = typeof(prd_Operador_Bus) };
               
            }
        }

    }
}
