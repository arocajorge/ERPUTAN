using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Cbtecble_det_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public decimal ?dc_Numconciliacion { get; set; }
        public string dc_EstaConciliado { get; set; }

        public int ? IdPunto_cargo { get; set; }


        public bool dc_para_conciliar { get; set; }



        public string NomCtaCble { get; set; }
        public string NomCentroCosto { get; set; }

        public ct_Plancta_Info _Plancta_Info { get; set; }

        public string tipo { get; set; }
        public double dc_Valor_D { get; set; }
        public double dc_Valor_H { get; set; }

        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string NomSubCentroCosto { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }

        public in_movi_inve_detalle_Info Info_movi_inven_det { get; set; }

        //Campos para vista de conciliacion de caja
        public decimal IdConciliacion_Caja { get; set; }
        public int IdEmpresa_conci { get; set; }
        public string nom_punto_cargo_grupo { get; set; }
        public string nom_punto_cargo { get; set; }

        public string IdRegistro { get; set; }

        public cxc_cobro_Det_Info Info_cobro_det { get; set; }


        public eFormas_de_Contabilizar Forma_de_Contabili_x_Inven { get; set; }


        public ct_Cbtecble_det_Info() 
        {
            Info_movi_inven_det = new in_movi_inve_detalle_Info();
            Info_cobro_det = new cxc_cobro_Det_Info();
        }

    }
}
