using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_Catalogo_Bus
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_Catalogo_Data Data = new com_Catalogo_Data();
        #endregion

        public List<com_Catalogo_Info> Get_List_MotivoRequerimiento()
        {
            try
            {
                List<com_Catalogo_Info> listCatalogo = new List<com_Catalogo_Info>();
                listCatalogo =Data.Get_List_MotivoRequerimiento();
                return listCatalogo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_MotivoRequerimiento", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public List<com_Catalogo_Info> Get_ListMotivo()
        {

            try
            {
                return new List<com_Catalogo_Info>();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ListMotivo", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }
       
       
        public List<com_Catalogo_Info> Get_ListEstadoRecepcion()
        {
            try
            {
                List<com_Catalogo_Info> listCatalogo = new List<com_Catalogo_Info>();
                listCatalogo=Data.Get_ListEstadoRecepcion();
                return listCatalogo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ListEstadoRecepcion", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }
        
        public List<com_Catalogo_Info> Get_ListEstadoAprobacion()
        {
            try
            {
                List<com_Catalogo_Info> listCatalogo = new List<com_Catalogo_Info>();
                listCatalogo = Data.Get_ListEstadoAprobacion();
                return listCatalogo;
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ListEstadoAprobacion", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }
        
        public List<com_Catalogo_Info> Get_ListEstadoAnulacion()
        {
            try
            {
                List<com_Catalogo_Info> listCatalogo = new List<com_Catalogo_Info>();
                listCatalogo = Data.Get_ListEstadoAnulacion();
                return listCatalogo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ListEstadoAnulacion", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }
                
        public com_Catalogo_Info Get_EstadoAprobacion(string IdEAprob)
        {
            try
            {
                com_Catalogo_Info listCatalogo = new com_Catalogo_Info();
                listCatalogo =Data.Get_Info_EstadoAprobacion(IdEAprob);
                return listCatalogo;

            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_EstadoAprobacion", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public List<com_Catalogo_Info> Get_ListEstadoAprobacion_solicitud_compra()
        {
            try
            {

                List<com_Catalogo_Info> listCatalogo = new List<com_Catalogo_Info>();
                listCatalogo = Data.Get_ListEstadoAprobacion_solicitud_compra();
                return listCatalogo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_ListEstadoAprobacion_solicitud_compra", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public string GetId()
        {
            try { return Data.GetId(); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public com_Catalogo_Bus()
        {

        }

        public List<com_Catalogo_Info> Get_List_Catalogo()
        {
            try { return Data.Get_List_Catalogo(); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Catalogo", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public List<com_Catalogo_Info> Get_IdTipoLista(string cod)
        {
            try { return Data.Get_list_IdTipoLista(cod); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_IdTipoLista", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean GuardarDB(com_Catalogo_Info Info)
        {
            try { return Data.GuardarDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean ValidarCodigoExiste(string cod)
        {
            try { return Data.ValidarCodigoExiste(cod); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean ModificarDB(com_Catalogo_Info Info)
        {
            try { return Data.ModificarDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean AnularDB(com_Catalogo_Info Info)
        {
            try { return Data.AnularDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }

        public Boolean ValidarIdTipoCatalogoCompra_Descripcion(string idTipoCatalogoCompra, string ca_descripcion)
        {
            try { return Data.ValidarIdTipoCatalogo_Descripcion(idTipoCatalogoCompra, ca_descripcion); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarIdTipoCatalogo_Descripcion", ex.Message), ex) { EntityType = typeof(com_Catalogo_Bus) };
            }
        }


    }
}
