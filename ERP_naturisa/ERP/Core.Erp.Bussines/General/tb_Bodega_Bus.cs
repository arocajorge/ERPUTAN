using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
    public class tb_Bodega_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_Bodega_Data data = new tb_Bodega_Data();
        string mensaje = "";

        public List<tb_Bodega_Info> Get_List_Bodega(int IdEmpresa, int IdSucursal)
        {
            try
            {

                return data.Get_List_Bodega(IdEmpresa, IdSucursal);
                 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public List<tb_Bodega_Info> Get_List_Bodega(int IdEmpresa, Cl_Enumeradores.eTipoFiltro TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.Get_List_Bodega(IdEmpresa,TipoCarga);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_BodegasTodas", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public string Get_cod_pto_emision_x_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.Get_cod_pto_emision_x_Bodega(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Objeto", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };

            }
        }

        public tb_Bodega_Info Get_Info_Bodega(int IdEmpresa, int IdSucursal, int IdBodega)
        {

            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.Get_Info_Bodega(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Objeto", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public Boolean ModificarDB(tb_Bodega_Info info, ref string msg)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public int getId(int IdEmpresa,int IdSucursal)
        {
            try
            {
            tb_Bodega_Data data = new tb_Bodega_Data();
            return data.getId(IdEmpresa,IdSucursal );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }

        }

        public Boolean GrabarDB(tb_Bodega_Info info, ref int id, ref string msg)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.GrabarDB(info,ref id, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public Boolean EliminarDB(tb_Bodega_Info info, ref  string msg)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.EliminarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public List<tb_Bodega_Info> Get_List_Bodegas_x_CentroCosto(int IdEmpresa, string IdCentroCosto)
        {
            try
            {
                tb_Bodega_Data data = new tb_Bodega_Data();
                return data.Get_List_Bodegas_x_CentroCosto(IdEmpresa,IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Bodegas_x_CentroCosto", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
            }
        }

        public tb_Bodega_Bus() 
        {
        
        }
    }
}
