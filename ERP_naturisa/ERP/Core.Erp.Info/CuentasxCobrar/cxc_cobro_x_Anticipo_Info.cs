using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

//Cobro_x_Anticipo
//Derek Mejía Soria
//Ult.Mod 03/02/2014
namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_x_Anticipo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdAnticipo { get; set; }
        public int IdSecuencia { get; set; }
        public int IdSucursal { get; set; }
        public decimal? IdCliente { get; set; }
        public string Observacion { get; set; }
        public DateTime? Fecha { get; set; }
        //public decimal? IdCbteCble_Caja { get; set; }
        //public int? IdTipocbte_Caja { get; set; }
        //public int? IdEmpresa_Caja { get; set; }
        //03022014 Derek Mejía Soria
        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }

        //28012014 Derek Mejía
        public string nombreCliente { get; set; }  
      
        //31012014 Derek Mejía Vista
        public int IdEmpresa2 { get; set; }
        public decimal IdAnticipo2 { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public int IdEmpresa_Cobro { get; set; }
        public int IdSucursal_cobro { get; set; }
        public decimal IdCobro_cobro { get; set; }
        public decimal IdCliente2 { get; set; }
        public DateTime cr_fecha { get; set; }
        public DateTime cr_fechaDocu { get; set; }
        public DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string cr_Tarjeta { get; set; }
        public string cr_propietarioCta { get; set; }
        public int mcj_IdEmpresa { get; set; }
        public decimal mcj_IdCbteCble { get; set; }
        public int mcj_IdTipocbte { get; set; }
        public double Valor { get; set; }
        public int? IdBanco  { get; set; }

        public int contador { get; set; }
        public Boolean chek { get; set; } 
      
        //DEREK 08022014
        public Bitmap Ico { get; set; }

        //DEREK 13032014
        public int IdCaja{ get; set; }


        // prop     
        public List<cxc_cobro_x_Anticipo_det_Info> listDetalle_Anticipo { get; set; }
        public List<cxc_cobro_Info> listCobros { get; set; }



        public cxc_cobro_x_Anticipo_Info() {
            cr_fecha = DateTime.Now.Date;
            cr_fechaDocu = DateTime.Now.Date;
            cr_fechaCobro = DateTime.Now.Date;
            Ico = null;
            listDetalle_Anticipo = new List<cxc_cobro_x_Anticipo_det_Info>();
            listCobros = new List<cxc_cobro_Info>();

        }

    }
}
