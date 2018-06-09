using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    
    
    public class fa_Vendedor_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        string mensaje = "";

        public List<fa_Vendedor_Info> Get_List_Vendedores(int idempresa)
        {
            try
            {
                List<fa_Vendedor_Info> lM = new List<fa_Vendedor_Info>();
                fa_Vendedor_Data data = new fa_Vendedor_Data();
                lM = data.Get_List_Vendedores(idempresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Vendedores", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
            }
        }

        public Boolean ModificarDB(fa_Vendedor_Info info, List<fa_VendedorxSucursal_Info> lstVendeSucu, ref string msg)
        {
            try
            {
                fa_Vendedor_Data data = new fa_Vendedor_Data();
                fa_VendedorxSucursal_Bus vendedorxsucursal_bus = new fa_VendedorxSucursal_Bus();
                if (data.ModificarDB(info, ref msg))
                {
                    foreach (var item in lstVendeSucu)
                    {
                        item.IdVendedor = info.IdVendedor;
                    }
                    return vendedorxsucursal_bus.ModificarDB(lstVendeSucu, info.IdEmpresa, info.IdVendedor, ref msg);
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
            }
        }

      

        public Boolean VerificaSiExisteVendedor(fa_Vendedor_Info info, ref string msg)
        {
            try
            {
                fa_Vendedor_Data data = new fa_Vendedor_Data();
                return data.VerificaSiExisteVendedor(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificaSiExisteVendedor", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
        
            }
        }

        public Boolean GrabarDB(fa_Vendedor_Info info, List<fa_VendedorxSucursal_Info> lstVendeSucu, ref int id, ref string msg)
        {
            try
            {
                fa_Vendedor_Data data = new fa_Vendedor_Data();
                fa_VendedorxSucursal_Bus vendedorxsucursal_bus = new fa_VendedorxSucursal_Bus();

                if (data.GrabarDB(info, ref id, ref msg))
                {
                    foreach (var item in lstVendeSucu)
                    {
                        item.IdVendedor = id;
                    }
                    return vendedorxsucursal_bus.GrabarDB(lstVendeSucu, ref msg);
                }
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
        
            }
        }

        public Boolean AnularDB(fa_Vendedor_Info info, ref  string msg)
        {
            try
            { 
                fa_Vendedor_Data data = new fa_Vendedor_Data();
                return data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
        
            }
        }

        public fa_Vendedor_Info ConsultarVendedorPorCedula(int Idempresa, String Cedula)
        {
            try
            {
                 fa_Vendedor_Data data = new fa_Vendedor_Data();
                 return data.ConsultarVendedorPorCedula(Idempresa, Cedula);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarVendedorPorCedula", ex.Message), ex) { EntityType = typeof(fa_TipoNota_Bus) };
        
            }
        }

        public fa_Vendedor_Bus() { }
    }
}
