using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus
    {
        tb_sis_Documento_Tipo_Reporte_x_Empresa_Data dataDoc = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Data();

        public Boolean GuardarDatos(tb_sis_Documento_Tipo_Reporte_x_Empresa_Info Info, ref string msjError)
        {
            try
            {
                if (dataDoc.ValidarExistencia(Info.IdEmpresa, Info.codDocumentoTipo))
                    return dataDoc.GuardarDatos(Info, ref msjError);
                else
                    return dataDoc.ModificarDatos(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDatos", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus) };
           
            }
        }


        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Info get_DisenioRpt(int IdEmpresa, string codDocumentoTipo)
        {
            try
            {
                return dataDoc.get_DisenioRpt(IdEmpresa, codDocumentoTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_DisenioRpt", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus) };
           
            }
        }


        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus()
        {

        }
    }
}
