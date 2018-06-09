using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_sis_Documento_Tipo_Reporte_x_Empresa_Info
    {
        public int IdEmpresa { get; set; }
        public string codDocumentoTipo { get; set; }
        public byte[] File_Disenio_Reporte { get; set; }


        public tb_sis_Documento_Tipo_Reporte_x_Empresa_Info()
        {

        }
    }
}
