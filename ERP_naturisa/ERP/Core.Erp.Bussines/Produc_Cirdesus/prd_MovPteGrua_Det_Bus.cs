using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_MovPteGrua_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_MovPteGrua_Det_Data data = new prd_MovPteGrua_Det_Data();
        public Boolean GuardarDB(List<prd_MovPteGrua_Det_Info> LstInfo, ref string msg)
        {

            try
            {
                return data.GuardarDB(LstInfo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Det_Bus) };
               
            }
        }


        public List<prd_MovPteGrua_Det_Info> MovPteGruaDetalle(int IdEmpresa, int IdSucursal, decimal IdMovPteGrua, ref string msg)
        {

            try
            {
                return data.MovPteGruaDetalle(IdEmpresa, IdSucursal, IdMovPteGrua, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MovPteGruaDetalle", ex.Message), ex) { EntityType = typeof(prd_MovPteGrua_Det_Bus) };
               
            }
        
        }
    }
}
