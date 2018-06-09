using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_cliente_pto_emision_cliente_Bus
    {
        fa_cliente_pto_emision_cliente_Data oData = new fa_cliente_pto_emision_cliente_Data();

        public List<fa_cliente_pto_emision_cliente_Info> Get_List(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(fa_cliente_pto_emision_cliente_Bus) };
            }  
        }

        public Boolean GuardarDB(fa_cliente_pto_emision_cliente_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_cliente_pto_emision_cliente_Bus) };
            }  
        }

        public Boolean ModificarDB(fa_cliente_pto_emision_cliente_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_cliente_pto_emision_cliente_Bus) };
            }  
        }

        public Boolean AnularDB(int idEmpresa, decimal idCliente)
        {
            try
            {
                return oData.AnularDB(idEmpresa,idCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(fa_cliente_pto_emision_cliente_Bus) };
            }  
        }

        public Boolean MergeDB(fa_Cliente_Info info_Cliente)
        {
            try
            {
                
                Boolean result = false;
                result = AnularDB(info_Cliente.IdEmpresa, info_Cliente.IdCliente);
                foreach (var item in info_Cliente.list_punto_emision_x_cliente)
                {
                    item.IdEmpresa = info_Cliente.IdEmpresa;
                    item.IdCliente = info_Cliente.IdCliente;

                    if (item.IdPuntoEmision == 0)
                        result = GuardarDB(item);
                    else
                        result = ModificarDB(item);
                }
                return result;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "MergeDB", ex.Message), ex) { EntityType = typeof(fa_cliente_pto_emision_cliente_Bus) };
            }
        }

    }
}
