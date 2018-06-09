using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;


namespace Core.Erp.Info.Factuarcion_CAH
{
    public class fa_notaCredDeb_aca_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNotaCredDeb { get; set; }
        public Nullable<int> IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public int IdTipoNota { get; set; }
        public string Observaciones { get; set; }
        public Nullable<bool> estado { get; set; }

        public Aca_Estudiante_Info Info_Estudiante { get; set; }



        public fa_notaCredDeb_aca_Info()
        {
            Info_Estudiante = new Aca_Estudiante_Info();

        }
    }
}
