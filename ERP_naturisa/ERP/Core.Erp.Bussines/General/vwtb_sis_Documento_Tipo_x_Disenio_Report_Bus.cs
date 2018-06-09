using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
    public class vwtb_sis_Documento_Tipo_x_Disenio_Report_Bus
    {
        vwtb_sis_Documento_Tipo_x_Disenio_Report_Data dataRpt = new vwtb_sis_Documento_Tipo_x_Disenio_Report_Data();

        public List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info> Get_List_sis_Documento_Tipo_x_Disenio_Report(int IdEmpresa, string ApareceCombo_FileReporte)
        {
            try
            {
                return dataRpt.Get_List_sis_Documento_Tipo_x_Disenio_Report(IdEmpresa, ApareceCombo_FileReporte);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPersonaBeneficiario", ex.Message), ex) { EntityType = typeof(vwtb_sis_Documento_Tipo_x_Disenio_Report_Bus) };
           
            }
        }

        public vwtb_sis_Documento_Tipo_x_Disenio_Report_Bus()
        {

        }
    }
}
