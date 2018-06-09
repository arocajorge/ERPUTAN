using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt002_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Decimal IdSolicitudCompra { get; set; }
        public Decimal IdPersona_Solicita { get; set; }
        public string nom_personaSol { get; set; }
        public Decimal IdPersona_comprador { get; set; }
        public string nom_personaComp { get; set; }
        public int IdDepartamento { get; set; }
        public string nom_departamento { get; set; }
        public string nom_empresa { get; set; }
        public string nom_sucursal { get; set; }
        public DateTime fecha { get; set; }
        public string observacion { get; set; }
        public Decimal IdProducto { get; set; }
        public string nom_producto { get; set; }
        public Double do_Cantidad { get; set; }
        public String em_ruc { get; set; }
        public String em_direccion { get; set; }
        public Image  em_logo { get; set; }
        public string em_telefonos { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string  IdCentroCosto { get; set; }
        public string nom_Centro_Costo { get; set; }
        public string IdSubCentroCosto { get; set; }
        public string nom_SubCentroCosto { get; set; }
        public string nom_unidad { get; set; }
        public string pr_codigo { get; set; }

        public XCOMP_Rpt002_Info()
       {

       }
    }
}
