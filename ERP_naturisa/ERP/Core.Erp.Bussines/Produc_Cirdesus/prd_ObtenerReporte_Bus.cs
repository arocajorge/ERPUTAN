using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ObtenerReporte_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";        
        prd_ObtenerReporte_Data Data = new prd_ObtenerReporte_Data();
        
        //public List<tbPRD_Rpt_RPRD001_Info> OptenerData_spPRD_Rpt_RPRD001(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi, string IdUsuario, string nom_pc)
        //{

        //    try
        //    {
                
        //        return Data .OptenerData_spPRD_Rpt_RPRD001(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, IdUsuario, nom_pc);

        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD001", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
        //    }


        //}

   //     // public List<tbPRD_Rpt_RPRD001_Info> ObtenerData_ReimpresionCodigo(List<tbPRD_Rpt_RPRD001_Info> listado, string idusuario, string nom_pc)
   //     //{
   //     //    try
   //     //    {
   //     //        return Data.ObtenerData_ReimpresionCodigo(listado, idusuario , nom_pc);

   //     //    }
   //     //    catch (Exception)
   //     //    {
   //     //        return null;

   //     //    }


   //     //}

   //     public List<tbPRO_CUS_CID_Rpt003_Info> OptenerData_spPRD_Rpt_RPRD003(int IdEmpresa,int IdSucursal, decimal IdListadoMateriales)
   //     {
   //         try
   //         {
   //               return Data.OptenerData_spPRD_Rpt_RPRD003(IdEmpresa,IdSucursal, IdListadoMateriales);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD003", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }


   //     }
   //     public List<tbPRO_CUS_CID_Rpt005_Info> OptenerData_spPRD_Rpt_RPRD005(int IdEmpresa, int IdSucursal, decimal IdDespacho)
   //     {
   //         try
   //         {
   //            return Data.OptenerData_spPRD_Rpt_RPRD005(IdEmpresa, IdSucursal, IdDespacho);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD005", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }

   //     public List<tbPRO_CUS_CID_Rpt004_Info> OptenerData_spPRD_Rpt_RPRD004(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //           return Data.OptenerData_spPRD_Rpt_RPRD004(IdEmpresa, IdSucursal, IdOrdenCompra, IdUsuario, nom_pc); 
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD004", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }

   //     public List<tbPRO_CUS_CID_Rpt006_Info> OptenerData_spPRD_Rpt_RPRD006(int IdEmpresa, int IdSucursal, int IdBodega,
   //       int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //           return Data.OptenerData_spPRD_Rpt_RPRD006(IdEmpresa, IdSucursal, IdBodega, IdTipoMov, IdNumMovi, IdUsuario, nom_pc);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD006", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }

   //     public List<tbPRO_CUS_CID_Rpt007_Info> OptenerData_spPRD_Rpt_RPRD007(int IdEmpresa, int IdSucursal, int IdBodega,
   //        int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //          return Data.ImprimirReporte(IdEmpresa, IdSucursal, IdBodega, IdTipoMov, IdNumMovi, IdUsuario, nom_pc);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD007", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }

   //     public List<tbPRO_CUS_CID_Rpt008_Info> OptenerData_spPRD_Rpt_RPRD008(int IdEmpresa, int IdSucursal, int IdBodega,
   //       int IdTipoMov, decimal IdNumMovi, string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //          return Data.OptenerData_spPRD_Rpt_RPRD008(IdEmpresa, IdSucursal, IdBodega, IdTipoMov, IdNumMovi, IdUsuario, nom_pc);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD008", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }

   //     public List<tbPRO_CUS_CID_Rpt009_Info> OptenerData_spPRD_Rpt_RPRD009(int IdEmpresa, int IdSucursal, decimal IdGrupoTrabajo,
   //string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //             return Data.OptenerData_spPRD_Rpt_RPRD009(IdEmpresa, IdSucursal, IdGrupoTrabajo, IdUsuario, nom_pc);

   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD009", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }
   //     }

   //     public List<tbPRO_CUS_CID_Rpt010_Info> OptenerData_spPRD_Rpt_RPRD010(int IdEmpresa, int IdProcesoProductivo, 
   //string IdUsuario, string nom_pc)
   //     {
   //         try
   //         {
   //            return Data.OptenerData_spPRD_Rpt_RPRD010(IdEmpresa, IdProcesoProductivo, IdUsuario, nom_pc);
   //         }
   //         catch (Exception ex)
   //         {
   //             Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
   //             throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD010", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };
               
   //         }

   //     }



        //public List<XPRO_CUS_CID_Rpt002_Info> OptenerData_spPRD_Rpt_RPRD002(int IdEmpresa, int idOrdenCompra)
        //{
        //    try
        //    {
        //        return Data.OptenerData_spPRD_Rpt_RPRD002(IdEmpresa, idOrdenCompra);
        //    }
        //    catch (Exception ex)
        //    {
        //        Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "OptenerData_spPRD_Rpt_RPRD002", ex.Message), ex) { EntityType = typeof(prd_ObtenerReporte_Bus) };

        //    }
        //}
    
    
    
    
    }
}

