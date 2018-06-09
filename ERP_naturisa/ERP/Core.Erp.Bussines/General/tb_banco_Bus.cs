using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_banco_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        tb_Banco_Data oData = new tb_Banco_Data();
        tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_bancarios_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Bus();

        public List<tb_banco_Info> Get_List_Banco()
        {
            try
            {
                   return oData.Get_List_Banco();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
     
        }

        public Boolean GrabarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool res = false;
                res = oData.GrabarDB(Info, ref msg);

                foreach (var item in Info.lst_procesos_bancarios_x_empresa)
                {
                    item.IdBanco = Info.IdBanco;
                }

                res = bus_procesos_bancarios_x_empresa.GuardarDB(Info.lst_procesos_bancarios_x_empresa);
                
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
     
        }

        public Boolean ActualizarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool res = false;

                res = oData.ActualizarDB(Info, ref msg);

                foreach (var item in Info.lst_procesos_bancarios_x_empresa)
                {
                    item.IdBanco = Info.IdBanco;
                }
                if (bus_procesos_bancarios_x_empresa.EliminarDB(param.IdEmpresa,Info.IdBanco))
                {
                    res = bus_procesos_bancarios_x_empresa.GuardarDB(Info.lst_procesos_bancarios_x_empresa);    
                }
                
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public Boolean AnulaDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                return oData.AnulaDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }
    }
}
