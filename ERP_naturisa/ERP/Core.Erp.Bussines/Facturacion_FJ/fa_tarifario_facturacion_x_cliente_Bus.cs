using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_tarifario_facturacion_x_cliente_Bus
    {
        string MensajeError = "";
        fa_tarifario_facturacion_x_cliente_Data data = new fa_tarifario_facturacion_x_cliente_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Activo_fijo_Data data_af = new Af_Activo_fijo_Data();

        public bool Guardar(fa_tarifario_facturacion_x_cliente_Info info, ref int idtarifario)
        {
            try
            {
                return data.Guardar(info, ref idtarifario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_Bus) };
            }
        }

        public bool Modificar(fa_tarifario_facturacion_x_cliente_Info info)
        {
            try
            {
                info.IdUsuarioUltMod = param.IdUsuario;
                info.FechaUltMod = param.Fecha_Transac;
                return data.Modificar(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_Bus) };

            }
        }

        public bool Anular(fa_tarifario_facturacion_x_cliente_Info info)
        {
            try
            {
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = param.Fecha_Transac;
                return data.Anular(info);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_Bus) };

            }
        }

        public fa_tarifario_facturacion_x_cliente_Info Get_Info(int idEmpresa, decimal idTarifario)
        {
            try
            {
                return data.Get_Info(idEmpresa, idTarifario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_Bus) };
            }
        }

        public List<fa_tarifario_facturacion_x_cliente_Info> Get_List_Tarifarios(int idempresa, DateTime fecha_inicio, DateTime fecha_fin)
        {
            try
            {
                return data.Get_List_Tarifarios(idempresa, fecha_inicio, fecha_fin);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Tarifarios", ex.Message), ex) { EntityType = typeof(fa_tarifario_facturacion_x_cliente_Bus) };

            }
        }

    }
}
