using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_OrdenTaller_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_OrdenTaller_Data data = new prd_OrdenTaller_Data();

        public List<prd_OrdenTaller_Info> ObtenerListaOT(int idempresa)
        {
            try
            {
                return data.ObtenerListaOT(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaOT", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }
        public List<prd_OrdenTaller_Info> ObtenerListaOT_x_Obra(int idempresa, string CodObra)
        {
            try
            {
                return data.ObtenerListaOT_x_Obra(idempresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaOT", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };

            }
        }
        public List<prd_OrdenTaller_Info> ObtenerListaOT_x_CentroCosto(int idempresa, string IdCentroCosto)
        {
            try
            {
                return data.ObtenerListaOT_x_CentroCosto(idempresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaOT_x_CentroCosto", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }

        public prd_OrdenTaller_Info ObtenerUnaOT(int IdEmpresa, int IdSucursal, decimal IdOrdenTaller, string IdCentroCosto)
        {
            try
            {
                return data.ObtenerUnaOT(IdEmpresa, IdSucursal, IdOrdenTaller, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerUnaOT", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }

        public List<prd_OrdenTaller_Info> ObtenerOrdenesTaller_x_GrupoTrabajoCab_x_CentroCosto(int idempresa, string IdCentroCosto, decimal IdGrupoTrabajo)
        {
            try
            {
                return data.ObtenerOrdenesTaller_x_GrupoTrabajoCab_x_CentroCosto(idempresa, IdCentroCosto, IdGrupoTrabajo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerOrdenesTaller_x_GrupoTrabajoCab_x_CentroCosto", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }

        public Boolean GrabarDB(int idempresa, prd_OrdenTaller_Info info, ref string msg, ref decimal idgenerada, ref string numDoc)
        {
            try
            {
                return data.GrabarDB(idempresa, info, ref msg, ref idgenerada, ref numDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }


        public Boolean VerificarCodigo(string NumDoc)
        {
            try
            {
                return data.VerificarCodigo(NumDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }
        public Boolean ModificarDB(int idempresa, prd_OrdenTaller_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }

        public Boolean Anular(int idempresa, prd_OrdenTaller_Info info, ref string msg)
        {
            try
            {
                return data.Anular(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }

        public prd_OrdenTaller_Bus() { }

        public Int32 ObtenerIDOrdenTaller(int idempresa, int IdSucursal, string CodObra, ref string msg)
        {
            try
            {
              return  data.ObtenerIDOrdenTaller(idempresa,IdSucursal,CodObra,ref msg);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerIDOrdenTaller", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }

           
        }
        public decimal getNumDoc(int idempresa, int IdSucursal)
        {
            try
            {
                return data.getNumDoc(idempresa,IdSucursal);

            }
            catch (Exception)
            {

                return 0;
            }
        }


        public List<prd_OrdenTaller_Info> GetLisOrdenTaller(int idempresa, int IdSucursal, string CodObra)
        {
            try
            {
                return data.GetLisOrdenTaller(idempresa, IdSucursal, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetLisOrdenTaller", ex.Message), ex) { EntityType = typeof(prd_OrdenTaller_Bus) };
               
            }
        }
    }
}
