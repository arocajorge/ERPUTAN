using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_Obra_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Obra_Data data = new prd_Obra_Data();

        public List<prd_Obra_Info> ObtenerListaObra(int IdEmpresa)
        {
            try
            {
                return data.ObtenerListaObra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaObra", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
            }
        
        }

        public prd_Obra_Info ObtenerUnaObra(int IdEmpresa, string CodObra)
        {
            try
            {
                return data.ObtenerUnaObra(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerUnaObra", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
            }
        }

        public List<prd_Obra_Info> ObtenerListaObraxPP(int IdEmpresa, ref string msg)
        {
            try
            {
                return data.ObtenerListaObra(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaObraxPP", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
            }
        }

         public Boolean GuardarDB(prd_Obra_Info info, ref string msg)
         {
             try
             {
                 return data.GuardarDB(info, ref  msg);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }
         public Boolean ModificarDB(prd_Obra_Info info, ref string msg)
         {
             try
             {
               
                 return data.ModificarDB(info, ref  msg);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }
        public Boolean AnularDB(prd_Obra_Info info, ref string msg)
         {
             try
             {
                 return data.AnularDB(info, ref  msg);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }
         public Boolean VerificarExisteCodigo(string CodObra)
         {
             try
             {
                 return data.VerificarExisteCodigo(CodObra);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }


         public List<prd_Obra_Info> ObtenerCliente(int IdEmpresa, string cl_RazonSocial)
         {
             try
             {
                 return data.ObtenerClientes(IdEmpresa, cl_RazonSocial);
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCliente", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }

         public Int32 ObtenerIdObra(ref string msg)
         {
             try
             {
                 return data.ObtenerIdObra(ref msg);
             }
             catch (Exception ex)
             {

                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerIdObra", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };
               
             }
         }

         public Boolean CompararPesoObra_vs_OTs(decimal PesoOT_a_Comparar, string CodObra)
         {
             try
             {
                 decimal PesoTotal_OTs_Registradas = 0;



                 decimal PesoTotal_OTs = PesoOT_a_Comparar + PesoTotal_OTs_Registradas;



                 return data.CompararPesoObra(PesoTotal_OTs, CodObra);
             
             }
             catch (Exception ex)
             {
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Obra_Bus) };

             }
         }


         
    }
}
