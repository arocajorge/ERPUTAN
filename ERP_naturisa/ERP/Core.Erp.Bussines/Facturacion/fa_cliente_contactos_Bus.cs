using Core.Erp.Data.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    
    public class fa_cliente_contactos_Bus
    {
        fa_cliente_contactos_Data Data = new fa_cliente_contactos_Data();

        public Boolean GuardarDB(fa_cliente_contactos_Info Info, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_cliente_contactos_Info> Lista, ref string mensaje)
        {
            try
            {
                return Data.GuardarDB(Lista, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdCliente, ref string msg)
        {
            try
            {
                return Data.EliminarDB(IdEmpresa,IdCliente, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public bool ExisteCliente(int idEmpresa, decimal idCliente, decimal idContacto, ref string mensaje)
        {
            try
            {
                return Data.ExisteCliente(idEmpresa, idCliente, idContacto, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCliente", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

        public List<tb_contacto_Info> Get_List_Contactos_x_Clientes(int IdEmpresa, decimal Idcliente)
        {
            try
            {
                return Data.Get_List_Contactos_x_Clientes(IdEmpresa,Idcliente);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCliente", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
            }
        }

    }

}
