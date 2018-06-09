using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_ordencompra_ext_x_imp_gastosxImport_Det_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdRegistroGasto { get; set; }
        public int IdSucusal { get; set; }
        public int IdGastoImp { get; set; }
        public int Secuencia { get; set; }
        public double Valor { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCble_Banco { get; set; }
        public int IdTipoCbte { get; set; }
        public int IdTipoCbte_Anul { get; set; }
        public string Banco { get; set; }
        public String Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string IdCtaCble_Importacion { get; set; }
        public string Observacion { get; set; }
        public string CodDocu_Pago { get; set; }
        public imp_ordencompra_ext_x_imp_gastosxImport_Det_Info()
        {

        }



      
    }
}
