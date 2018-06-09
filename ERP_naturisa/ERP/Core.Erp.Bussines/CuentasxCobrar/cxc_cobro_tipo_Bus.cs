using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_cobro_tipo_Bus
    {
        cxc_cobro_tipo_Data data = new cxc_cobro_tipo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo()
        {
            try
            {
                return data.Get_List_Cobro_Tipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
              
            }
        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo(string docxcobrar)
        {
            try
            {
                  return data.Get_List_Cobro_Tipo(docxcobrar);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Anticipo(int IdEmpresa)
        {
            try
            {
                return data.Get_List_Cobro_Tipo_Anticipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
        public Boolean GuardarDB(cxc_cobro_tipo_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
        public Boolean ModificarDB(cxc_cobro_tipo_Info info, ref string msg)
        {
            try
            {
              return data.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_ParaMantCheque()
        {
            try
            {
              return data.Get_List_Cobro_Tipo_ParaMantCheque();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_ParaMantCheque", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_RetIva()
        {
            try
            {
                 return data.Get_List_Cobro_Tipo_RetIva();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_RetIva", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_x_RetFte()
        {
            try
            {
                return data.Get_List_Cobro_Tipo_x_RetFte();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_x_RetFte", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_x_Anticipo(int IdEmpresa)
        {
            try
            {
             return data.Get_List_Cobro_Tipo_x_Anticipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_x_Anticipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Documento()
        {
            try
            {
                 return data.Get_List_Cobro_Tipo_Documento();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_Documento", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo_Todos()
        {
            try
            {
                return data.Get_List_Cobro_Tipo_Todos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_Todos", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };

            }
        }


        public List<cxc_cobro_tipo_Info> Get_List_Cobro_Tipo(List<string> lTipoCobros)
        {
            try
            {
                return data.Get_List_Cobro_Tipo(lTipoCobros);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };

            }
        }
    }
}
