using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class vwtb_sis_Documento_Tipo_x_Disenio_Report_Data
    {
        string mensaje = "";

        public List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info> Get_List_sis_Documento_Tipo_x_Disenio_Report(int IdEmpresa, string ApareceCombo_FileReporte)
        {
            try
            {
                List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info> lstDoc = new List<vwtb_sis_Documento_Tipo_x_Disenio_Report_Info>();

                using (EntitiesGeneral listado = new EntitiesGeneral())
                {
                    var select = from q in listado.vwtb_sis_Documento_Tipo_x_Disenio_Report
                                 where q.IdEmpresa == IdEmpresa
                                 && q.ApareceCombo_FileReporte == ApareceCombo_FileReporte
                                 select q;

                    foreach (var item in select)
                    {
                        vwtb_sis_Documento_Tipo_x_Disenio_Report_Info Info = new vwtb_sis_Documento_Tipo_x_Disenio_Report_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.codDocumentoTipo = item.codDocumentoTipo;
                        Info.descripcion = item.descripcion;
                        Info.File_Disenio_Reporte = item.File_Disenio_Reporte;
                        Info.ApareceCombo_FileReporte = item.ApareceCombo_FileReporte;                                

                        lstDoc.Add(Info);
                    }
                }

                return lstDoc;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
