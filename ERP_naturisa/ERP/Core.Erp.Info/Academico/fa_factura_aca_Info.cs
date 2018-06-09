using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
   public class fa_factura_aca_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public decimal IdFamiliar { get; set; }
        public string IdParentesco_cat { get; set; }

        //public string IdAnioLectivo { get; set; }
        public int IdAnioLectivo { get; set; }

        public int IdPeriodo { get; set; }
        public Nullable<int> IdRubro { get; set; }
       // vista

        public string CodCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public string vt_Observacion { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public System.DateTime vt_fech_venc { get; set; }
        public Nullable<double> vt_cantidad { get; set; }
        public Nullable<double> vt_Precio { get; set; }
        public Nullable<double> vt_PorDescUnitario { get; set; }
        public Nullable<double> vt_DescUnitario { get; set; }
        public Nullable<double> vt_PrecioFinal { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public string Apell_Estu { get; set; }
        public string Nom_Estud { get; set; }
        public string Apellido_Fam { get; set; }
        public string Nombre_Fam { get; set; }
        public string Descripcion_secc { get; set; }
        public string Descripcion_paralelo { get; set; }
        public string Descripcion_cur { get; set; }
        public decimal IdContrato { get; set; }
        public string Comprobante { get; set; }
    }
}
