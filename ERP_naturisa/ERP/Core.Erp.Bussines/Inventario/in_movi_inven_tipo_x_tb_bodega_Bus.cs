using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Inventario
{
  public   class in_movi_inven_tipo_x_tb_bodega_Bus
    {

        string mensaje = "";

        in_movi_inven_tipo_x_tb_bodega_Data moviD = new in_movi_inven_tipo_x_tb_bodega_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public in_movi_inven_tipo_x_tb_bodega_Info Get_Info_movi_inven_tipo_x_tb_bodega(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
        {

            try
            {
                return moviD.Get_Info_movi_inven_tipo_x_tb_bodega(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_inventario_tipobodega", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }


        }


        public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_list_movi_inven_tipo_x_tb_bodega(int IdEmpresa)
        {
            try
            {
                return moviD.Get_list_movi_inven_tipo_x_tb_bodega(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_inventario_tipobodega", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }
        }

        public Boolean GrabarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, int IdEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
        {
            try
            {
                
                return moviD.GrabarDB(lst, IdEmpresa, moviI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarLista", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }
        }

        public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_List_movi_inven_tipo_x_tb_bodega(int IdEmpresa, in_movi_inven_tipo_Info moviI, int IdSucursal)
        {
            try
            {

                return moviD.Get_List_movi_inven_tipo_x_tb_bodega(IdEmpresa, moviI, IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consulta_movimiento_tipo_x_bodega", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }
        }


        public Boolean ModificarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, int idEmpresa, in_movi_inven_tipo_Info moviI, ref string mensaje)
        {
            try
            {

                return moviD.ModificarDB(lst, idEmpresa, moviI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarLIsta", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }
        }

       

        public List<in_movi_inven_tipo_x_tb_bodega_Info> Get_List_movi_inven_tipo_x_tb_bodega(int IdEmpresa, int IdMoviInvenTipo)
        {
            try
            {
                return moviD.Get_List_movi_inven_tipo_x_tb_bodega(IdEmpresa, IdMoviInvenTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar_BodegayCuentaContable_X_TipodeMovimiento", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }

        }

        public Boolean GrabarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, ref string mensaje)
        {
            try
            {
                return moviD.GrabarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarSucursalBodegaxCtaContable", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }

        }

        public Boolean ModificarDB(List<in_movi_inven_tipo_x_tb_bodega_Info> lst, ref string mensaje)
        {
            try
            {
                return moviD.ModificarDB(lst, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarSucursalBodegaXCtaContable", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_x_tb_bodega_Bus) };

            }

        }
  
  }
}
