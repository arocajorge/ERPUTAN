using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Business.Facturacion_Grafinpren
{
    public class fa_factura_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Facturacion.fa_factura_det_Bus Bus_Fact_det = new Facturacion.fa_factura_det_Bus();

        public Boolean GuardarDB(List<fa_factura_det_info> Lista, ref decimal Id, ref string msg)
        {
            try
            {
                return Bus_Fact_det.GuardarDB(Lista, ref Id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
            }
        }

        public List<fa_factura_det_info> Get_List_factura_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
        {
            try
            {
                return Bus_Fact_det.Get_List_factura_det(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
            }
        }

        public Boolean ModificarDB(List<fa_factura_det_info> Lista, fa_factura_Info info)
        {
            try
            {
                return Bus_Fact_det.ModificarDB(Lista, info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
            }

        }
    }
}
