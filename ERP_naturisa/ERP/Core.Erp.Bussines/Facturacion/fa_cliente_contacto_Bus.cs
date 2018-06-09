using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    
    public class fa_cliente_contacto_Bus
    {
        fa_cliente_contacto_Data Data = new fa_cliente_contacto_Data();
        public Boolean Guardar_DB(fa_cliente_contacto_Info Info, ref string msjError)
        {
            try
            {
                return Data.Guardar(Info, ref msjError);
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
    }

}
