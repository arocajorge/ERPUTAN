using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class vwtb_sis_Documento_Tipo_x_Disenio_Report_Info
    {
        public int IdEmpresa { get; set; }
        public string codDocumentoTipo { get; set; }
        public string descripcion { get; set; }
        public byte[] File_Disenio_Reporte { get; set; }
        public string ApareceCombo_FileReporte { get; set; }


        public vwtb_sis_Documento_Tipo_x_Disenio_Report_Info()
        {

        }
    }
}
