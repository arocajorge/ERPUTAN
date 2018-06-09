using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
   public class tb_Catalogo_Bus
    {
       string mensaje = ""; 

       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       tb_Catalogo_Data CtD = new tb_Catalogo_Data();
      
       public List<Cl_EstadoCivil_Info> Get_List_EstadoCivil()
        {
            try
            {
                return CtD.Get_List_EstadoCivil();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }

            
        }

       public List<Cl_TipoDoc_Personales_Info> Get_List_TipoDoc_Personales()
        {

            
            try
            {
                return CtD.Get_List_TipoDoc_Personales();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_TipoDoc_Personales", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }



        }

       public List<Cl_Sexo_Info> Get_List_Sexo()
        {

            try
            {
                return CtD.Get_List_Sexo();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Sexo", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }

       public List<Cl_Estado_Info> Get_List_Estado()
        {


            try
            {
                return CtD.Get_List_Estado();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Estado", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }
        
       public List<Cl_NaturalezaPerso> Get_List_NaturalezaPer()
        {



            try
            {
                return CtD.Get_List_NaturalezaPer();


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_NaturalezaPer", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }

       
       public List<tb_Catalogo_Info> Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo IdTipoCatalogo)
        {
            try
            {
                return CtD.Get_List_Catalogo(IdTipoCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Catalogo", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }

       public List<tb_Catalogo_Info> Get_List_MotivoAnulacion()
       {
           try
           {
               tb_Catalogo_Data CtD = new tb_Catalogo_Data();
               return CtD.Get_List_MotivoAnulacion();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_MotivoAnulacion", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };

           }
       }

       public List<tb_Catalogo_Info> Get_CatalogoPorTipo(int IdTipoCatalgo)
       {
           try
           {
               tb_Catalogo_Data CtD = new tb_Catalogo_Data();
               return CtD.Get_CatalogoPorTipo(IdTipoCatalgo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObteneCatalogoPorTipo", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };

           }
       }

       public Boolean Anular(tb_Catalogo_Info info, ref string msg)
        {
            try 
	        {	        
		        return CtD.AnularDB(info,ref msg);
	        }
	        catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
	        }
        }

       public Boolean GrabarDB(tb_Catalogo_Info info, ref string msg, ref int id)
        {
            try
            {
                return CtD.GrabarDB(info, ref msg,ref id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }

       public Boolean ModificarDB(tb_Catalogo_Info info, ref string msg)
        {
            try
            {
                return CtD.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };
         
            }
        }

       public string Get_DescripcionDocumentoIdentidad(string codigo, ref string descripcion)
       {
           try
           {

               return CtD.Get_DescripcionDocumentoIdentidad(codigo, ref descripcion);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_DescripcionDocumentoIdentidad", ex.Message), ex) { EntityType = typeof(tb_Catalogo_Bus) };

           }
       }

   }
}
