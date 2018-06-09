
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Catalogo_Bus
    {
        string mensaje = "";
        int IdTipoCatalago;

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ro_Catalogo_Data odata = new ro_Catalogo_Data();

        public Boolean GuardarDB(ref ro_Catalogo_Info Info)
        {
            try
            {
                
                return odata.GuardarDB(ref Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }

        public List<ro_Catalogo_Info> Get_List_Catalogo(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Catalogo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }          
            
        }

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_AnioFiscal(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Catalogo_x_AnioFiscal(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralAnioFiscal", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
        }

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_DiasFalta(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_Catalogo_x_DiasFalta(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetCatalogosDiasFalta", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }


        }

        public List<ro_Catalogo_Info> Get_List_CatalogoMotivoPrestamo()
        {
            try
            {
                return odata.Get_List_CatalogoMotivoPrestamo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoMotivoPrestamo", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }

        public List<ro_Catalogo_Info> Get_List_CatalogoTipoPago()
        {
            try
            {
                return odata.Get_List_CatalogoTipoPago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoTipoPago", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }

        public List<ro_Catalogo_Info> Get_List_CatalogoEstadoPrestamo()
        {
            try
            {
                return odata.Get_List_CatalogoEstadoPrestamo();
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoEstadoPrestamo", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }

        public List<ro_Catalogo_Info> Get_List_CatalogoEstadoCobro()
        {
            try
            {
                return odata.Get_List_CatalogoEstadoCobro();
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoEstadoCobro", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
           
        }

        public List<ro_Catalogo_Info> Get_List_CatalogoBanco()
        {

            try
            {
                return odata.Get_List_CatalogoBanco();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoBanco", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
           
        }

        public List<ro_Catalogo_Info> Get_List_Catalogo_x_Tipo(int IdTipoCatalgo)
        {
            try
            {
                return odata.Get_List_Catalogo_x_Tipo(IdTipoCatalgo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCatalogoTipo", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
        }

        public Boolean ModificarDB(ro_Catalogo_Info Info, ref string msj)
        {
            try
            {
                return odata.ModificarDB(Info,ref  msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }

        public Boolean AnularDB(ro_Catalogo_Info Info)
        {
            try
            {
                return odata.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
            
        }
        
        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                return odata.ValidarCodigoExiste(Cod);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
           
        }

        public List<ro_Catalogo_Info> Get_List_CatalogoDecimo()
        {
            try
            {
                return odata.Get_List_CatalogoDecimos();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCatalogoDecimos", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
            
           
        }

        public ro_Catalogo_Info Get_info_Catalogo(int idCatalogo)
        {
            try
            {
                return odata.Get_info_Catalogo(idCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_Catalogo_Bus) };

            }
        
        }

    }
}
