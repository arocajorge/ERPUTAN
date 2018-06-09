using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxCobrar
{
    public class cxc_cobro_tipo_Info
    {
        public string IdCobro_tipo { get; set; }
        public string tc_descripcion { get; set; }
        public string tc_EsCheque { get; set; }
        public string tc_Afecha { get; set; }
        public string tc_interno { get; set; }
        public string Estado { get; set; }
        public string tc_generaNCAuto { get; set; }
        public string tc_abreviatura { get; set; }
        public string tc_docXCobrar { get; set; }
        public int tc_Orden { get; set; }
        public string tc_seMuestraManCheque { get; set; }
        public string tc_Que_Tipo_Registro_Genera { get; set; }
        public string tc_seCobra { get; set; }
        public string IdEstadoCobro_Inicial { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        public double PorcentajeRet { get; set; }
        public string ESRetenIVA { get; set; }
        public string ESRetenFTE { get; set; }
        public string tc_SePuede_Depositar { get; set; }

        public string tc_Tomar_Cta_Cble_De { get; set; }

        public string IdMotivo_tipo_cobro { get; set; }



        public Boolean Impresion_Vario { get; set; }

        public cxc_cobro_tipo_Info(){}


    }
}
