using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_Documento_Tipo_Reporte_x_Empresa_Data
    {
        string mensaje = "";

        public Boolean GuardarDatos(tb_sis_Documento_Tipo_Reporte_x_Empresa_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var Address = new tb_sis_Documento_Tipo_Reporte_x_Empresa();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.codDocumentoTipo = Info.codDocumentoTipo;
                    Address.File_Disenio_Reporte = Info.File_Disenio_Reporte;

                    context.tb_sis_Documento_Tipo_Reporte_x_Empresa.Add(Address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDatos(tb_sis_Documento_Tipo_Reporte_x_Empresa_Info Info, ref string msjError)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_sis_Documento_Tipo_Reporte_x_Empresa.FirstOrDefault(af => af.IdEmpresa == Info.IdEmpresa && af.codDocumentoTipo == Info.codDocumentoTipo);
                    if (contact != null)
                    {
                        contact.File_Disenio_Reporte = Info.File_Disenio_Reporte;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public Boolean ValidarExistencia(int IdEmpresa, string codDocumentoTipo)
        {
            try
            {
                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.tb_sis_Documento_Tipo_Reporte_x_Empresa
                                 where q.IdEmpresa == IdEmpresa
                                 && q.codDocumentoTipo == codDocumentoTipo
                                 select q;

                    if (select.Count() > 0)                    
                        return false;                    
                    else
                        return true;
                }
                
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Info get_DisenioRpt(int IdEmpresa, string codDocumentoTipo)
        {
            try
            {
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoRpt = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();
                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.tb_sis_Documento_Tipo_Reporte_x_Empresa
                                 where q.IdEmpresa == IdEmpresa
                                 && q.codDocumentoTipo == codDocumentoTipo
                                 select q;

                    foreach (var item in select)
                    {
                        InfoRpt.IdEmpresa = item.IdEmpresa;
                        InfoRpt.codDocumentoTipo = item.codDocumentoTipo;
                        InfoRpt.File_Disenio_Reporte = item.File_Disenio_Reporte;
                    }
                }
                return InfoRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
