using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_VendedorxSucursal_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<fa_VendedorxSucursal_Info> Get_List_VendedoresxSucursal(int idempresa, int id)
        {
            try
            {
                List<fa_VendedorxSucursal_Info> lM = new List<fa_VendedorxSucursal_Info>();
                fa_VendedorxSucursal_Data data = new fa_VendedorxSucursal_Data();
                lM = data.Get_List_VendedoresxSucursal(idempresa,id);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_VendedoresxSucursal", ex.Message), ex) { EntityType = typeof(fa_VendedorxSucursal_Bus) };
           
            }
        }

        public Boolean ModificarDB(List<fa_VendedorxSucursal_Info> lista_nueva, int IdEmpresa, int IdVendedor,  ref string msg)
        {
            try
            {
                fa_VendedorxSucursal_Data data = new fa_VendedorxSucursal_Data();
                List<fa_VendedorxSucursal_Info> lista_antigua = new List<fa_VendedorxSucursal_Info>();
                lista_antigua = Get_List_VendedoresxSucursal(IdEmpresa, IdVendedor);
                return data.ModificarDB(lista_antigua, lista_nueva, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_VendedorxSucursal_Bus) };
           
            }
        }


        public Boolean GrabarDB(List<fa_VendedorxSucursal_Info> lm, ref string msg)
        {
            try
            {
                fa_VendedorxSucursal_Data data = new fa_VendedorxSucursal_Data();
                foreach (var item in lm)
                {
                    data.GrabarDB(item, ref msg);
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Grabar_Lista", ex.Message), ex) { EntityType = typeof(fa_VendedorxSucursal_Bus) };
           
            }
        }

        public Boolean GrabarDB(fa_VendedorxSucursal_Info info, ref string msg)
        {
            try
            {
                fa_VendedorxSucursal_Data data = new fa_VendedorxSucursal_Data();
                return data.GrabarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_VendedorxSucursal_Bus) };
           
            }
        }

        public Boolean EliminarDB(fa_VendedorxSucursal_Info info, ref  string msg)
        {
            try
            {
                fa_VendedorxSucursal_Data data = new fa_VendedorxSucursal_Data();
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_VendedorxSucursal_Bus) };
           
            }
        }


        public fa_VendedorxSucursal_Bus() { }
    }
}
