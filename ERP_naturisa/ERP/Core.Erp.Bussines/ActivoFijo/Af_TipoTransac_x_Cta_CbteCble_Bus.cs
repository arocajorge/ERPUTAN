using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_TipoTransac_x_Cta_CbteCble_Bus
    {
        Af_TipoTransac_x_Cta_CbteCble_Data dataTran = new Af_TipoTransac_x_Cta_CbteCble_Data();

        public Boolean GuardarTran_x_CbteCble(Af_TipoTransac_x_Cta_CbteCble_Info InfoTran_x_Cta, ref string msjError)
        {
            try
            {
                return dataTran.GuardarTran_x_CbteCble(InfoTran_x_Cta, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarTran_x_CbteCble", ex.Message), ex) { EntityType = typeof(Af_TipoTransac_x_Cta_CbteCble_Bus) };
            }
        }


        public Af_TipoTransac_x_Cta_CbteCble_Info Get_Info_Transac_x_CtaCble(int IdEmpresa, decimal IdTipoTran, string IdCatalogo)
        {
            try
            {
                return dataTran.Get_Info_Transac_x_CtaCble(IdEmpresa, IdTipoTran, IdCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Transac_x_CtaCble", ex.Message), ex) { EntityType = typeof(Af_TipoTransac_x_Cta_CbteCble_Bus) };
            }
        }


        public Af_TipoTransac_x_Cta_CbteCble_Bus()
        {

        }
    }
}
