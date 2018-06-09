using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Caja;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_conciliacion_caja_Info
    {

        public int	IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdCaja { get; set; }
        public DateTime? Fecha { get; set; }
        public Nullable<DateTime> Fecha_ini { get; set; }
        public Nullable<DateTime> Fecha_fin { get; set; }
     
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }
        public int? IdEmpresa_op { get; set; }
        public decimal? IdOrdenPago_op { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string IdCtaCble { get; set; }

        public double?  Valor_pagado { get; set; }
        public string nom_Caja { get; set; }
        public string nom_Estado { get; set; }

        public Boolean Icono_Buscar { get; set; }

        public double Saldo_cont_al_periodo { get; set; }
        public double Ingresos { get; set; }
        public double Total_Ing { get; set; }
        public double Total_fact_vale { get; set; }
        public double Total_fondo { get; set; }
        public double Dif_x_pagar_o_cobrar { get; set; }
        public int IdPeriodo { get; set; }

        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }

        //Para diarios internos al momento de conciliar
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }

        public Nullable<int> IdEmpresa_mov_caj { get; set; }
        public Nullable<int> IdTipoCbte_mov_caj { get; set; }
        public Nullable<decimal> IdCbteCble_mov_caj { get; set; }

       public List<cp_conciliacion_Caja_det_Info> Detalle_x_FP { get; set; }
       public List<cp_conciliacion_Caja_det_Info> Detalle_x_ValeCaja { get; set; }
       public List<cp_conciliacion_Caja_det_Ing_Caja_Info> Detalle_x_Ingresos { get; set; }
       public cp_orden_pago_Info Info_Orden_Pago_x_Repocision_Caja { get; set; }


        public cp_conciliacion_caja_Info()
        {
            Detalle_x_FP = new List<cp_conciliacion_Caja_det_Info>();
            Detalle_x_ValeCaja = new List<cp_conciliacion_Caja_det_Info>();
            Detalle_x_Ingresos = new List<cp_conciliacion_Caja_det_Ing_Caja_Info>();
        }
    }
}

