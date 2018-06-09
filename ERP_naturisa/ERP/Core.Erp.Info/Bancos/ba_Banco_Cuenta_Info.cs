using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Info.Bancos
{
    public class ba_Banco_Cuenta_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
        public string ba_descripcion2 { get; set; }
        public string ba_Tipo { get; set; }
        public string ba_Num_Cuenta { get; set; }
        public string ba_Moneda { get; set; }
        public string ba_Ultimo_Cheque { get; set; }
        public int ba_num_digito_cheq { get; set; }
        public string IdCtaCble { get; set; }
        public string CodigoLegal { get; set; }

        public int ? IdBanco_Financiero { get; set; }


        public string IdUsuario { get; set; }
        public DateTime ? Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime ? Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public byte[] Reporte { get; set; }
        public byte[] ReporteSolo_Cheque { get; set; }
        public bool? MostrarVistaPreviaCheque { get; set; }
        public bool? Imprimir_Solo_el_cheque { get; set; }
        public ba_Banco_Cuenta_Info() {}
        public ba_Banco_Cuenta_Info(int _IdEmpresa, int _IdBanco, string _ba_descripcion, string _ba_descripcion2)
            {
                IdEmpresa=_IdEmpresa;
                IdBanco=_IdBanco;
                ba_descripcion=_ba_descripcion;
                ba_descripcion2 = _ba_descripcion2;


                    
            }
    }
}
