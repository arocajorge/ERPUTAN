using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Activo_fijo_CtasCbles_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_Activo_fijo_CtasCbles_Data data = new Af_Activo_fijo_CtasCbles_Data();
        string mensaje = "";


        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles(int IdEmpresa,int IdActivo_Fijo)
        {
            try
            {
                return data.Get_List_Activo_fijo_CtasCbles(IdEmpresa, IdActivo_Fijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Activo_fijo_CtasCbles", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }
        }

        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Activo_fijo_CtasCbles(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Activo_fijo_CtasCbles", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }
        }

        public List<Af_Activo_fijo_CtasCbles_Info> Get_List_Activo_fijo_CtasCbles()
        {
            try
            {
                return data.Get_List_Activo_fijo_CtasCbles();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Activo_fijo_CtasCbles", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }
        }

        public Boolean GuardarDB(List<Af_Activo_fijo_CtasCbles_Info> lstInfoCbte, ref string msjError)
        {
            try
            {
                return data.GuardarDB(lstInfoCbte, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }
        }

        public Boolean ModificarDB(List<Af_Activo_fijo_CtasCbles_Info> lstInfoCbte, ref string msjError)
        {
            try
            {
                return data.ModificarDB(lstInfoCbte, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }
        }


        public Boolean EliminarDB(int IdEmpresa, decimal IdActivoFijo)
        {
            try
            {
                return data.EliminarDB(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Bus) };
            }

        }
    }
}
