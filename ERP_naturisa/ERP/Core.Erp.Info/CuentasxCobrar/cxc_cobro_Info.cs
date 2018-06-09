using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_Info : cxc_cobro_Det_Info 
    {
        
        public	int	IdEmpresa { get; set; } 
        public	int	IdSucursal { get; set; }
        public	decimal	IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public string cr_propietarioCta { get; set; }
        public	decimal	IdCliente { get; set; }
        public double cr_TotalCobro { get; set; }
        public	DateTime cr_fecha { get; set; }
        public	DateTime cr_fechaCobro { get; set; }
        public DateTime cr_fechaDocu { get; set; }

        //public DateTime Fecha_Cobro { get; set; }


        public	String cr_observacion { get; set; }
        public	String cr_Banco { get; set; }
        public	String cr_cuenta { get; set; }
        public	string cr_Tarjeta { get; set; }
        public String cr_NumDocumento { get; set; }
        public String cr_es_anticipo { get; set; }
        public	String cr_estado { get; set; }
        public	decimal? cr_recibo { get; set; }
        public String cr_estadoCobro { get; set; }
        public string cr_Codigo { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public int ? IdTipoNotaCredito { get; set; }
        public string IdEstadoCobro { get; set; }
        
        

        public int IdVendedorCliente { get; set; }
        public string nSucursal { get; set; }
        public string nCliente { get; set; }
        public Boolean chek { get; set; }
        public string Caja { get; set; }
        public string Tipo { get; set; }
        public decimal IdCbteCble_MoviCaja { get; set; }
        public int IdTipocbte_MoviCaja { get; set; }
        public int Secuencia_MoviCaja { get; set; }
        

        
        public string MotiAnula { get; set; }
        public Nullable<int> IdBanco { get; set; }


        public decimal? IdCobro_a_aplicar { get; set; } 


        public ba_Banco_Cuenta_Info BancoCuenta { get; set; }
        
        //TARJETA
        public string RF { get; set; }
        public string RI { get; set; }
        public double valorRF { get; set; }
        public double valorRI { get; set; }
        public double valorComision { get; set; }
        public double ValorCheque { get; set; }

        public string TipoPagoTarjeta { get; set; }
        public string BancoTarjeta { get; set; }
        public string cuentaTarjeta { get; set; }
        public string chequeTarjeta { get; set; }

        public string dc_TipoDocumento { get; set; }
        public decimal IdCbte_vta_nota { get; set; }
        public int IdBodega_Cbte { get; set; }
        public int IdCaja { get; set; }
        public int IdFila { get; set; }
        public string IdCtaCble { get; set; } 
        public cxc_cobro_x_Anticipo_det_Info Infocxc_cobro_x_Anticipo_det { get; set; }
        
        public List<cxc_cobro_Det_Info> ListaCobro { get; set; }
                
        public cxc_cobro_Info()
        {
            ListaCobro = new List<cxc_cobro_Det_Info>();
            Infocxc_cobro_x_Anticipo_det = new cxc_cobro_x_Anticipo_det_Info();
        }
    }
}
