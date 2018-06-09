using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
    public  class tb_sis_Documento_Tipo_Talonario_Bus
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        tb_sis_Documento_Tipo_Talonario_Data data = new tb_sis_Documento_Tipo_Talonario_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_DocTipoxSecTalonario(int idEmpresa)
        {
            try
            {
                return data.Get_List_DocTipoxSecTalonario(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaDocTipoxSecTalonario", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }

        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Docu_Tipo_Talonario_x_TipoDocu
            (int IdEmpresa, string TipoDocu,bool Es_Documento_Electronico)
        {
            try
            {
                return data.Get_List_Docu_Tipo_Talonario_x_TipoDocu(IdEmpresa, TipoDocu, Es_Documento_Electronico);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista_Docu_Tipo_Talonario_x_TipoDocu", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        
        }

       
        
        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento(int idEmpresa, string puntoemision, string establecimiento, string tipodoc)
        {
            try
            {
                return data.Get_Info_Ult_Documento(idEmpresa, puntoemision, establecimiento, tipodoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Ult_Documento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }


        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento_no_usado
            (int idEmpresa, string puntoemision, string establecimiento, string tipodoc,bool Es_Documento_Electronico)
        {
            try
            {
                return data.Get_Info_Ult_Documento_no_usado(idEmpresa, puntoemision, establecimiento, tipodoc, Es_Documento_Electronico);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Ult_Documento_no_usado", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Documento_Tipo_Talonario
           (int IdEmpresa, string tipodoc, string establecimiento, string puntoemision, string NumDocumento)
        {
            try
            {
                return data.Get_Info_Documento_Tipo_Talonario(IdEmpresa, tipodoc, establecimiento ,puntoemision, NumDocumento);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Primer_Documento_no_usado", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };

            }

        }

        public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Primer_Documento_no_usado(int idEmpresa,string establecimiento, string puntoemision, string tipodoc,bool Es_Documento_Electronico)
        {
            try
            {
                bool Considerar_punto_emision = true;
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        Considerar_punto_emision = false;
                        break;
                    default:
                        Considerar_punto_emision = true;
                        break;
                }
                return data.Get_Info_Primer_Documento_no_usado(idEmpresa, establecimiento, puntoemision, tipodoc, Es_Documento_Electronico, Considerar_punto_emision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Primer_Documento_no_usado", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }

        public Boolean grabar(tb_sis_Documento_Tipo_Talonario_Info info, int cantiGenerar, ref string msjRetorno)
        {
            try
            {
                Boolean boolResult = true;
                int numDocActual = 0;

                if (info.NumDocumento == "")
                {
                    tb_sis_Documento_Tipo_Talonario_Info InfoNumUltiDoc = Get_Info_Ult_Documento(info.IdEmpresa, info.PuntoEmision, info.Establecimiento, info.CodDocumentoTipo);
                    if (InfoNumUltiDoc != null)
                        numDocActual = Convert.ToInt32(InfoNumUltiDoc.NumDocumento);
                }
                else
                    numDocActual = Convert.ToInt32(info.NumDocumento);
                if (numDocActual == 0)
                    msjRetorno = "Se procedio a Guardar los Documentos del " + (numDocActual + 1);
                else
                    msjRetorno = "Se procedio a Guardar los Documentos del " + numDocActual;

                for (int i = 0; i < cantiGenerar; i++)
                {                    
                    string numDocumento = Convert.ToString(numDocActual);
                    info.NumDocumento = numDocumento.PadLeft(9, '0');
                    boolResult = data.Guardar(info);
                    numDocActual = numDocActual + 1;
                }

                if (boolResult)
                    msjRetorno = msjRetorno + " al " + numDocActual;
                else
                    msjRetorno = "";
                
                return boolResult;
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }
        }
        
        public Boolean Modificar(tb_sis_Documento_Tipo_Talonario_Info info)
        {
            try
            {
                return data.Modificar(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener_Primer_Documento_no_usado", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }

        public Boolean Verificar_NumTalonario(int IdEmpresa, string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, ref string mensaje)
        {
            try
            {
                 return data.Verificar_NumTalonario(IdEmpresa, codDocuTipo,  establecimiento,  puntoEmision, numDocumento, ref  mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Verificar_NumTalonario", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        
        }

        public Boolean Modificar_Estado_Usado(Info.General.tb_sis_Documento_Tipo_Talonario_Info Info, ref string  mensajeError)
        {
            try
            {
                return data.Modificar_Estado_Usado(Info, ref mensajeError);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar_Estado_Usado", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        }


        public Boolean Documento_talonario_esta_Usado(tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensajeError, ref string mensajeDocumentoDupli)
        {
            try
            {
                return data.Documento_talonario_esta_Usado(Info, ref mensajeError, ref mensajeDocumentoDupli);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };
           
            }
        
        }

        public  tb_sis_Documento_Tipo_Talonario_Info Verificar_DocumentoElectronico(int IdEmpresa,string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensaje)
        {
            try
            {
                return data.Verificar_DocumentoElectronico(IdEmpresa, codDocuTipo, establecimiento, puntoEmision, numDocumento, Info, ref mensaje);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Verificar_EsDocumentoElectronico", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };

            }
        }
        public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Doc_disponible(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico)
        {
            try
            {
                return data.Get_List_Doc_disponible(IdEmpresa, puntoemision, establecimiento, tipodoc,Es_Documento_Electronico);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Verificar_EsDocumentoElectronico", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };

            }
        }
        public Boolean Modificar_Estado_Usado(int IdEmpresa, string CodDocumentoTipo, string Establecimiento, string PuntoEmision, string NumDocumento, ref string mensajeError)
        {
            try
            {
                return data.Modificar_Estado_Usado(IdEmpresa, CodDocumentoTipo, Establecimiento, PuntoEmision, NumDocumento, ref mensajeError);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Verificar_EsDocumentoElectronico", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_Talonario_Bus) };

            }
        }
    }
}
