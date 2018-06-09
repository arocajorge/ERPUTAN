using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_gastosxImport_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_gastosxImport_Data oData = new imp_gastosxImport_Data();

        public List<imp_gastosxImport_Info> Get_List_gastosxImport()
        {
            try
            {
                return oData.Get_List_gastosxImport();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }
        }

        public List<vwImp_GastosImportacion_X_Proveedor_Info> Get_List_GastosImportacion_X_Proveedor(int IdEmpresa, int IdSucursal, decimal IdOrdenCompraExt)
        {
            try
            {
                return oData.Get_List_GastosImportacion_X_Proveedor(IdEmpresa, IdSucursal, IdOrdenCompraExt);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaGastosImportacion_X_Proveedor", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }
        }

        public List<vwImp_GastosImportacion_X_Proveedor_Info> Get_List_GastosImportacion_X_ProveedorYCbte(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return oData.Get_List_GastosImportacion_X_ProveedorYCbte(IdEmpresa,IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaGastosImportacion_X_ProveedorYCbte", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }
        }

        public Boolean GuardarDB(ref imp_gastosxImport_Info Info)
        {
            try
            {
               return oData.GuardarDB(ref Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean ValidarCodigo(String Codigo)
        {
            try
            {
              return oData.ValidarCodigo(Codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigo", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean ModificarDB(imp_gastosxImport_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean AnularDB(imp_gastosxImport_Info Info)
        {
            try
            {
                 return oData.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }

        }

        public Boolean Validar(imp_gastosxImport_Info Info)
        {
            try
            {
                 return oData.Validar(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar", ex.Message), ex) { EntityType = typeof(imp_gastosxImport_Bus) };
            
            }

        }
    }
}
