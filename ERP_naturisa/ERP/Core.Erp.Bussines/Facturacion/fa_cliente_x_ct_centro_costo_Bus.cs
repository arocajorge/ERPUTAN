using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_cliente_x_ct_centro_costo_Bus
    {
        fa_cliente_x_ct_centro_costo_Data data = new fa_cliente_x_ct_centro_costo_Data();

        public Boolean GrabarBD(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                return data.Grabar(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(fa_cliente_x_ct_centro_costo_Bus) };

            }

        }

        public Boolean ModificarBD(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                return data.ModificarBD(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarBD", ex.Message), ex) { EntityType = typeof(fa_cliente_x_ct_centro_costo_Bus) };

            }

        }

        public Boolean AnularDB(fa_cliente_x_ct_centro_costo_Info info, ref string mensaje)
        {
            try
            {
                return data.AnularDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarBD", ex.Message), ex) { EntityType = typeof(fa_cliente_x_ct_centro_costo_Bus) };

            }

        }

        public List<fa_cliente_x_ct_centro_costo_Info> Get_Vista_Clientes_x_Centro_costo(int idEmpresa)
        {
            try
            {
                return data.Get_Vista_Clientes_x_Centro_costo(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Vista_Clientes_x_Centro_costo", ex.Message), ex) { EntityType = typeof(fa_cliente_x_ct_centro_costo_Bus) };

            }
        }
    }
}
