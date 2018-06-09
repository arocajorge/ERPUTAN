using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_PteGrua_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       
        prd_PteGrua_Data Data = new prd_PteGrua_Data();

        public Boolean GuardarDB(prd_PuenteGruaMovimiento Info, ref int idptegrua, ref string msg)
        {
            try
            {
                return Data.GuardarDB(Info, ref idptegrua, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_PteGrua_Bus) };
              
            }
        }

        public List<prd_PuenteGruaMovimiento> ConsultaGeneral(int idempresa, int idsucursal, ref string msg)
        {
            try
            {
                return Data.ConsultaGeneral(idempresa, idsucursal , ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_PteGrua_Bus) };
              
            }
        }


        public prd_PuenteGruaMovimiento ObtenerObjeto(int IdEmpresa,int IdSucursal,int IdPteGrua, ref string msg)
        {
            try
            {
                return Data.ObtenerObjeto(IdEmpresa, IdSucursal,IdPteGrua, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_PteGrua_Bus) };
              
            }
        }
    }
}
