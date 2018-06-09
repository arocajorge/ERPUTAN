using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Caja
{
    public class Caj_Talonario_Recibo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRecibo { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public string Num_Recibo { get; set; }
        public bool Usado { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuario_Responsable { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnu { get; set; }

        public string Su_Descripcion { get; set; }
        public string nom_PuntoVta { get; set; }
        public string Su_CodigoEstablecimiento { get; set; }
        public string cod_PuntoVta { get; set; }

        public string IdTipo_Docu_cat { get; set; }//opin 2017/03/23
    }
}
