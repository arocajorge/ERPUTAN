using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_Documento_Tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Documento_Tipo_Data data = new tb_sis_Documento_Tipo_Data();
        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo()
        {
            try
            {
                return data.Get_List_Documento_Tipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsutarSisTipoDocu", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
            }
        }

        public String Get_Documento_Tipo(string CodTipoDocu)
        {
            try
            {
                return data.Get_Documento_Tipo(CodTipoDocu);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsutarSisTipoDocu", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
            }
        }


        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Documento_Tipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsutarSisTipoDocu", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
            }

        }



        public List<tb_sis_Documento_Tipo_Info> Get_List_Documento_Tipo_ApareceTalonario(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Documento_Tipo_ApareceTalonario(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsutarSisTipoDocu", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
            }

        }
    
    
    }
}
