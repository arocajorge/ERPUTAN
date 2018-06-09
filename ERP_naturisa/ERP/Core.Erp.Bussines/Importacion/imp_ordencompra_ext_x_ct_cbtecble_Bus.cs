using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_ordencompra_ext_x_ct_cbtecble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        imp_ordencompra_ext_x_ct_cbtecble_Data odata = new imp_ordencompra_ext_x_ct_cbtecble_Data();

        public Boolean GuardarDB(imp_ordencompra_ext_x_ct_cbtecble_Info Info, ref string mensaje)
        {
            try
            {
                return odata.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }


        public Boolean GuardarDB(List<imp_ordencompra_ext_x_ct_cbtecble_Info> lst, ref string mensaje)
        {
            try
            {
                 return odata.GuardarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDBLst", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }

        public imp_ordencompra_ext_x_ct_cbtecble_Info Get_Info_ordencompra_ext_x_ct_cbtecble(int ct_IdEmpresa, int ct_IdTipoCbte, decimal ct_IdCbteCble, ref string mensaje)
        {
            try
            {
                return odata.Get_Info_ordencompra_ext_x_ct_cbtecble(ct_IdEmpresa, ct_IdTipoCbte, ct_IdCbteCble,ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }

        public imp_ordencompra_ext_x_ct_cbtecble_Info Get_Info_ordencompra_ext_x_ct_cbtecble(int IdEmpres, int IdSucursal, decimal IdOrdeCompr, string TipoReg = "")
        {
            try
            {
                 return odata.Get_Info_ordencompra_ext_x_ct_cbtecble(IdEmpres, IdSucursal, IdOrdeCompr, TipoReg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }

        public List<imp_ordencompra_ext_x_ct_cbtecble_Info> Get_List_ordencompra_ext_x_ct_cbtecble(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExt)
        {
            try
            {
                return odata.Get_List_ordencompra_ext_x_ct_cbtecble(IdEmpresa, IdSucursal,IdOrdenCompraExt);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }
        public List<imp_ordencompra_ext_x_ct_cbtecble_Info> Get_List_ordencompra_ext_x_ct_cbtecble(int ct_IdEmpresa, int ct_IdTipoCbte, decimal ct_IdCbteCble, ref string mensaje)
        {
            try
            {
                return odata.Get_List_ordencompra_ext_x_ct_cbtecble( ct_IdEmpresa,  ct_IdTipoCbte,  ct_IdCbteCble, ref  mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
            }

        }
        
         public Boolean EliminarDB(int ct_IdEmpresa,decimal ct_IdCbteCble, int ct_IdTipoCbte)
         {
             try
             {
                 return odata.EliminarDB(ct_IdEmpresa, ct_IdCbteCble, ct_IdTipoCbte);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
             }

         }

         public Boolean ModificarDB(imp_ordencompra_ext_x_ct_cbtecble_Info info)
         {
             try
             {
                   return odata.ModificarDB(info);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(imp_ordencompra_ext_x_ct_cbtecble_Bus) };
            
             }

         }
    }
}
