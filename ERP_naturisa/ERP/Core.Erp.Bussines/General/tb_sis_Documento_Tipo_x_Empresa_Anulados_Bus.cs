using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;


namespace Core.Erp.Business.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Documento_Tipo_x_Empresa_Anulados_Data data = new tb_sis_Documento_Tipo_x_Empresa_Anulados_Data();
        
        public Boolean GuardarDB(tb_sis_Documento_Tipo_x_Empresa_Anulados_Info Info,ref string msj)
        {
            try
            {
                //if(Info.Documento == Info.DocumentoFin)
                //{
                    if(!data.ValidaSiEstaAnulado(Info.IdEmpresa, Info.codDocumentoTipo, Info.Serie1, Info.Serie2, Info.Documento))
                        return data.GuardarDB(Info);
                    else
                    {
                        msj = "El documento: "+Info.Serie1+"-" + Info.Serie2+"-" + Info.Documento + "ya fue Anulado";
                        return false;
                    }
                //}
                //else
                //{
                //    string doc = "";
                //    string d = "";
                //    decimal ini=Convert.ToDecimal(Info.Documento);
                //    decimal fin = Convert.ToDecimal(Info.DocumentoFin);
                //    for(decimal i=ini  ; i <= fin; i++)
                //    {
                //        if (!data.ValidaSiEstaAnulado(Info.IdEmpresa, Info.codDocumentoTipo, Info.Serie1, Info.Serie2, Info.Documento))
                //        {
                //            Info.Documento = i.ToString(); Info.DocumentoFin = i.ToString();
                //            data.GuardarDB(Info);
                //        }
                //        else
                //        {
                //            doc = doc + d + i;
                //            d = " - ";
                //        }
                //    }
                //    if(doc.Length > 0)
                //    {
                //        msj = "Estos documentos (" + doc + ") ya fueron anulados con anterioridad ";
                //        return false;
                //    }
                //    else
                //        return true;
                //}
            }
            catch(Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus) };
           
            }
        }

        public List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                 return data.ConsultaGeneral(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus) };
            }

        }

        public bool ValidaSiEstaAnulado(int IdEmpresa, string TipoDoc, string serie1, string serie2, string Doc)
        {
            try
            {
                    return data.ValidaSiEstaAnulado(IdEmpresa, TipoDoc, serie1, serie2, Doc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus) };
            }
        }

        public List<tb_sis_Documento_Tipo_x_Empresa_Anulados_Info> ConsultaPorMesAnio(int IdEmpresa, int anio, int mes)
        {
            try
            {
                 return data.ConsultaPorMesAnio(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus) };
           
            }

        }

        public tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus()
        {
            try
            {

            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarEstadoDocumento", ex.Message), ex) { EntityType = typeof(tb_sis_Documento_Tipo_x_Empresa_Anulados_Bus) };
           
            }
        }
    }
}
