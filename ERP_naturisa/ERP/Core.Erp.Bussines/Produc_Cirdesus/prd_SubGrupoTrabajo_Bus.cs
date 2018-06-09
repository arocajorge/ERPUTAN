using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

///
namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_SubGrupoTrabajo_Data data = new prd_SubGrupoTrabajo_Data();


        // obtiene un grupo de trabajo para la cabecera
        public List<prd_SubGrupoTrabajo_Info> ObtenerGrupoTrabajoCab(int idempresa)
        {
            try
            {
                return data.ObtenerGrupoTrabajoCab(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGrupoTrabajoCab", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }


        // obtiene un grupo de trabajo x centro de costo para la cabecera
        public List<prd_SubGrupoTrabajo_Info> ObtenerGrupoTrabajoCab_x_OT(int idempresa, int idsucursal, decimal idordentaller)
        {
            try
            {
                return data.ObtenerGrupoTrabajoCab_x_OT(idempresa , idsucursal,idordentaller);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGrupoTrabajoCab_x_OT", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              

            }
        }

        public prd_SubGrupoTrabajo_Info OBtenerGTxEtapa(int idempresa, int idsucursal, int idGT )
        {
            try
            {
                return data.OBtenerGTxEtapa(idempresa, idsucursal, idGT );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OBtenerGTxEtapa", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }
        public prd_SubGrupoTrabajo_Info OBtenerGT(int idempresa, int idsucursal, decimal idGT )
        {
            try
            {
                return data.OBtenerGT(idempresa, idsucursal, idGT );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OBtenerGT", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }

        
       
        //graba cabecera en la Base de Datos 

        public Boolean GrabarCabeceraDB(int idempresa, prd_SubGrupoTrabajo_Info info, List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                return data.GrabarCabeceraDB(idempresa, info, lmDetalleInfo, ref msg, ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarCabeceraDB", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }

        public Boolean ModificarDB(int idempresa, prd_SubGrupoTrabajo_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }

        public Boolean AnularReactiva(int idempresa, prd_SubGrupoTrabajo_Info info, ref string msg)
        {
            try
            {
                return data.AnularReactiva(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularReactiva", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }





        public List<prd_SubGrupoTrabajo_Info> GetListSubGruposTrabajo(int idempresa, int idsucursal)
        {
            try
            {
                return data.GetListSubGruposTrabajo(idempresa, idsucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListSubGruposTrabajo", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }



        public List<prd_SubGrupoTrabajo_Info> GetListSubGruposTrabajo(int idempresa, int idsucursal, int IdGrupo)
        {
            try
            {
                return data.GetListSubGruposTrabajo(idempresa, idsucursal, IdGrupo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListSubGruposTrabajo", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajo_Bus) };
              
            }
        }

    }
}
