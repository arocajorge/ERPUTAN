using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Core.Erp.Info.General
{
    public class tb_sis_reporte_Info
    {

        public string CodReporte { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string Modulo { get; set; }
        public string VistaRpt { get; set; }
        public string Formulario { get; set; }
        public int Orden { get; set; }

        
        
        public string Observacion { get; set; }
        public string nom_Asembly { get; set; }
        public Image imagen { get; set; }
        public Bitmap icon { get; set; }
        public byte[] imgByt { get; set; }
        
        public int VersionActual { get; set; }
        public string Tipo_Balance { get; set; }
        public string SQuery { get; set; }

        public string Class_NomReporte { get; set; }
        public string Class_Info { get; set; }
        public string Class_Bus { get; set; }
        public string Class_Data { get; set; }

        public Boolean se_Muestra_Admin_Reporte { get; set; }
        public string Estado { get; set; }
        public string Store_proce_rpt { get; set; }
        public byte[] Disenio_reporte { get; set; }

        public Boolean Se_Muestra_Icono { get; set; }
        public bool esta_en_base { get; set; }






        public tb_sis_reporte_Info(){}



    }
}
