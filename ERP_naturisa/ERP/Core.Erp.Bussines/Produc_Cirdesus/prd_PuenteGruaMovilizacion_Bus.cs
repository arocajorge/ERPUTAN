using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_PuenteGruaMovilizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_MovPteGrua_Data data = new prd_MovPteGrua_Data();
        public List<prd_MovPteGrua_Info> ObtenerListaPteGrua(int idempresa,int idsucursal)
        {
            try
            {
                return new List<prd_MovPteGrua_Info>();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GedId", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovilizacion_Bus) };
            }                
        }

        public Boolean GrabarDB(prd_MovPteGrua_Info Info,  ref string msg)
        {
            try
            {
                return data.GrabarDB( Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GedId", ex.Message), ex) { EntityType = typeof(prd_PuenteGruaMovilizacion_Bus) };
              
            }
        }

       

        public Boolean Anular(int idempresa, prd_MovPteGrua_Info info, ref string msg)
        {
            return false;
        }
    }
}
