using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
   public class cp_archivos_para_banco_x_cxp_det_Info
   {
       public int IdEmpresa { get; set; }
       public decimal IdArchivo { get; set; }
       public int Secuencia { get; set; }
       public Nullable<int> IdEmpresa_op { get; set; }
       public Nullable<decimal> IdOrdenPago_op { get; set; }
       public Nullable<double> Saldo_x_pagar { get; set; }
       public Nullable<double> Valor_pagado { get; set; }
       public string IdUsuario { get; set; }
       public Nullable<System.DateTime> Fecha_Transac { get; set; }
       public string IdUsuarioUltMod { get; set; }
       public Nullable<System.DateTime> Fecha_UltMod { get; set; }
       public string IdUsuarioUltAnu { get; set; }
       public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
       public string nom_pc { get; set; }
       public string ip { get; set; }
       public int Secuencia_op { get; set; }
       public string proveedor { get; set; }
       public DateTime fecha_op { get; set; }
       public string  estado_op { get; set; }
       public bool check { get; set; }
       public string observacion_op { get; set; }

       public int IdPersona { get; set; }
    }
}
