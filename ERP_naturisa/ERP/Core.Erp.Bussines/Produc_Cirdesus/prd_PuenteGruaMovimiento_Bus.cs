using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_PuenteGruaMovimiento_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_PuenteGruaMovimiento_Data data = new prd_PuenteGruaMovimiento_Data();

       public List<prd_MovPteGrua_Info> ListadoMovimientos(int IdPuenteGrua, int IdOperadorIni, int IdOperadorFin, DateTime Fdesde, DateTime Fhasta, ref string msg)
        {
            try
            {
                return data.ListadoMovimientos(IdPuenteGrua, IdOperadorIni,IdOperadorFin,Fdesde,Fhasta,ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListadoMovimientos", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovimiento_Bus) };
              
            }

       }

       public Boolean GrabarDB(prd_MovPteGrua_Info Info, ref string msg)
       {
           try
           {
               return data.GrabarDB(Info, ref  msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovimiento_Bus) };
              
           }
       }



       public int getIdMovimiento(ref string mensaje)
       {
           try
           {
               return data.getIdMovimiento(ref  mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getIdMovimiento", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovimiento_Bus) };
              
           }

       }

       public Boolean ModificarDB(prd_MovPteGrua_Info Info, ref string msg)
       {
           try
           {
               return data.ModificarDB(Info,ref  mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovimiento_Bus) };
              
           }
       }

       public List<prd_MovPteGrua_Info> GetLisListadoPiezasPendMover(int Idempresa, DateTime Fdesde, DateTime Fhasta, ref string msg)
       {
           try
           {
               return data.GetLisListadoPiezasPendMover(Idempresa, Fdesde, Fhasta, ref  msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetLisListadoPiezasPendMover", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovimiento_Bus) };
              
           }

       }

    }
}
