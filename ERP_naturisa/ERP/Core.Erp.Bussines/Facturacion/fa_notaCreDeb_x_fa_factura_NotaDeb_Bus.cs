using Core.Erp.Business.General;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_notaCreDeb_x_fa_factura_NotaDeb_Bus
    {
        fa_notaCreDeb_x_fa_factura_NotaDeb_Data oData = new fa_notaCreDeb_x_fa_factura_NotaDeb_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_NC(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return oData.Get_list_docs_x_NC(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_docs_x_NC", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }

        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_NC_x_cobro(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return oData.Get_list_docs_x_NC_x_cobro(IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_docs_x_NC_x_cobro", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }

        public List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Get_list_docs_x_cruzar(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return oData.Get_list_docs_x_cruzar(IdEmpresa, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_docs_x_cruzar", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }

        public Boolean ModificarDB(List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lista)
        {
            try
            {
                if (Lista.Count == 0)
                    return false;
                int sec = Lista.Max(q => q.secuencia) + 1;
                foreach (var item in Lista)
                {
                    if (!item.esta_en_base)
                    {
                        item.secuencia = sec;
                        GuardarDB(item);
                        sec++;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }

        public Boolean GuardarDB(fa_notaCreDeb_x_fa_factura_NotaDeb_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_fa_factura_NotaDeb_Bus) };
            }
        }
    }
}
