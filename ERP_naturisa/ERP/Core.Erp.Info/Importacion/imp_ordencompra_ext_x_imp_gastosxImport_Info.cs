using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Info : imp_ordencompra_ext_x_imp_gastosxImport_Det_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdRegistroGasto { get; set; }
        public int IdSucusal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public decimal? IdProveedor { get; set; } 
        public int IdBanco { get; set; }
        public string CodDocu_Pago  { get; set; }
        public string Sucursal { get; set; }
        public string Estado { get; set; }
        public decimal IdCbteCble { get; set; }
        public decimal IdCbteCble_Anulado { get; set; }
        public string CodOrdenCompraExt { get; set; }
        public string debcre_DebBanco { get; set; }
        public string debCre_Provicion { get; set; }
        public string IdUsuario	{ get; set; }
        public DateTime Fecha_Transac	{ get; set; }
        public string IdUsuarioUltMod	{ get; set; }
        public DateTime Fecha_UltMod	{ get; set; }
        public string IdUsuarioUltAnu	{ get; set; }
        public DateTime Fecha_UltAnu	{ get; set; }
        public string nom_pc	{ get; set; }
        public string ip	{ get; set; }

        public List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info> ListaGastos { get; set; }
        
        

        public imp_ordencompra_ext_x_imp_gastosxImport_Info()
        {
            ListaGastos = new List<imp_ordencompra_ext_x_imp_gastosxImport_Det_Info>();
        }


        public string Tipo_Importacion { get; set; }
    }
}
