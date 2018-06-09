using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{

    public class prd_Ensamblado_CusCider_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Ensamblado_CusCider_Data Data = new prd_Ensamblado_CusCider_Data();

        public Boolean GuardarDB(prd_Ensamblado_CusCider_Info Info,List <prd_Ensamblado_Det_CusCider_Info> Det, ref decimal idEnsamblado, ref string msg)
        {
            try
            {
                return Data.GuardarDB(Info,Det, ref idEnsamblado, ref msg );

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }


        }

        public List<prd_Ensamblado_CusCider_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {
                return Data.ConsultaGeneral(idempresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }
        
        }

        public prd_Ensamblado_CusCider_Info ObtenerObjeto(int IdEmpresa, int IdSucursal, decimal IdEnsamblado, ref string msg)
        {
            try
            {
                return Data.ObtenerObjeto(IdEmpresa, IdSucursal,  IdEnsamblado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }

        }

        public vwprd_CantidadEnsamblada_x_OT_CusCider_Info TraerCantEnsamb(prd_OrdenTaller_Info OT, ref string msg)
        {
            try
            {
               return  Data.TraerCantEnsamb(OT, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerCantEnsamb", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }    
            
        }

        public Boolean AnularEnsamb_Mov(prd_Ensamblado_CusCider_Info ensamblado, ref string msg)
        {
            try
            {
                return Data.AnularEnsamb_Mov(ensamblado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularEnsamb_Mov", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }

        }
        
        public List<vwprd_Ensamblado_CabDet_CusCider_Info> BuscarCodBarraMaestro(int Idempresa, string codbar, ref string msg)
        {
            try
            {
                return Data.BuscarCodBarraMaestro(Idempresa,codbar, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "BuscarCodBarraMaestro", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }

        }
         public vwprd_Ensamblado_CabDet_CusCider_Info buscacodbarramaestro(int idempresa, string codbar, ref string msg)
        {
            try
            {
                return Data.buscacodbarramaestro(idempresa, codbar, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "buscacodbarramaestro", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_CusCider_Bus) };
                
            }

        }
    }
}
