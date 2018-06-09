using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
    public class in_movi_inven_tipo_Bus
    {
        string mensaje = "";
        in_movi_inven_tipo_Data md = new in_movi_inven_tipo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<in_movi_inven_tipo_Info> Get_List_movi_inven_tipo(int IdEmpresa)
        {
            try
            {
                return md.Get_List_movi_inven_tipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaMovimientoInventarioTipoXEmpresa", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
            
           
        }

        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo(int IdEmpresa, string tipoMovi, string Interno, string todos)
        {
            try
            {       

                return md.Get_list_movi_inven_tipo(IdEmpresa, tipoMovi, Interno, todos);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_movi_inven_tipo", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }

        }

        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo(int IdEmpresa, string tipoMovi)
        {
            try
            {

                return md.Get_list_movi_inven_tipo(IdEmpresa, tipoMovi);


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_movi_inven_tipoParametros", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };


            }

        }

        public List<in_movi_inven_tipo_Info> Get_list_movi_inven_tipo_x_bodega(int IdEmpresa, int IdSucursal, int idBodega, string tipoMovi, string Interno)
        {
            try
            {

                return md.Get_list_movi_inven_tipo_x_bodega(IdEmpresa, IdSucursal, idBodega, tipoMovi, Interno);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_list_movi_inven_tipo_x_bodega", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }
       
        public Boolean ModificarDB(in_movi_inven_tipo_Info moviI, ref string mensaje)
        {
            try
            {
                in_movi_inven_tipo_Data moviD = new in_movi_inven_tipo_Data();
                moviI.IdUsuarioUltMod = param.IdUsuario;
                moviI.Fecha_UltMod = param.Fecha_Transac;
                moviI.ip = param.ip;
                moviI.nom_pc = param.nom_pc;
                return moviD.ModificarDB(moviI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public Boolean AnularDB(in_movi_inven_tipo_Info moviI)
        {
            try
            {
                in_movi_inven_tipo_Data moviD = new in_movi_inven_tipo_Data();
                moviI.IdUsuarioUltAnu = param.IdUsuario;
                moviI.Fecha_UltAnu = param.Fecha_Transac;
                moviI.ip = param.ip;
                moviI.nom_pc = param.nom_pc;
                return moviD.AnularDB(moviI);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anuliar_Reg_DB", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public Boolean GrabarDB(in_movi_inven_tipo_Info MoviI, ref string Mensaje)
        {
            try
            {
                in_movi_inven_tipo_Data MoviD = new in_movi_inven_tipo_Data();
                MoviI.IdUsuario = param.IdUsuario;
                MoviI.Fecha_Transac = param.Fecha_Transac;
                MoviI.ip = param.ip;
                MoviI.nom_pc = param.nom_pc;
                return MoviD.GrabarDB(MoviI, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_Reg_DB", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public int GetIdMoviInvent(int id)
        {
            try
            {
                in_movi_inven_tipo_Data MoviD = new in_movi_inven_tipo_Data();
                return MoviD.GetIdMoviInvent(id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerId", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public Boolean Get_Codigo(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {

            try
            {
                in_movi_inven_tipo_Data MoviD = new in_movi_inven_tipo_Data();
                return MoviD.Get_Codigo(MoviI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarCodigo", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }
        
        public Boolean Cons_MovimientoInventario(in_movi_inven_tipo_Info MoviI, ref string mensaje)
        {

            try
            {
                in_movi_inven_tipo_Data MoviD = new in_movi_inven_tipo_Data();
                return MoviD.Cons_MovimientoInventario(MoviI, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Cons_MovimientoInventario", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public in_movi_inven_tipo_Info Get_Info_movi_inven_tipo(int IdEmpresa, string Idtipo, int s = 0)
        {
            try
            {
                in_movi_inven_tipo_Data md = new in_movi_inven_tipo_Data();
                return md.Get_Info_movi_inven_tipo(IdEmpresa, Idtipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Un_movi_inven_tipo", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public in_movi_inven_tipo_Info Get_Info_movi_inven_tipo(int IdEmpresa, string Codigo)
        {
            try
            {
                in_movi_inven_tipo_Data md = new in_movi_inven_tipo_Data();
                return md.Get_Info_movi_inven_tipo(IdEmpresa, Codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Un_movi_inven_tipo", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        public in_movi_inven_tipo_Info Get_Info_movi_inven_tipo(int IdEmpresa, int Idtipo)
        {
            try
            {
                in_movi_inven_tipo_Data md = new in_movi_inven_tipo_Data();
                return md.Get_Info_movi_inven_tipo(IdEmpresa, Idtipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Un_movi_inven_tipo", ex.Message), ex) { EntityType = typeof(in_movi_inven_tipo_Bus) };

            }
        }

        
    }
}
