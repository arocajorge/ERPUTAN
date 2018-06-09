using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Caja
{
    public class caj_Caja_Info
    {//dddd

        public	int	IdEmpresa { get; set; } 
        public	int	IdCaja { get; set; }
        public	string	ca_Codigo { get; set; }
        public	string	ca_Descripcion { get; set; }
        public string ca_Descripcion2 { get; set; }
        public	string	ca_Moneda { get; set; }
        public	string	IdCtaCble { get; set; }
        public	string	IdUsuario { get; set; }
        public	DateTime?	Fecha_Transac { get; set; }
        public	string	IdUsuarioUltMod	{ get; set; }
        public	DateTime?	Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public	string	nom_pc	{ get; set; }
        public  string ip { get; set; }
        public	string	Estado	{ get; set; }
        public  string IdUsuario_Responsable { get; set; }
        public string MotivoAnu { get; set; }
        public string N_usuarioResponsable { get; set; }
        public int? IdSucursal { get; set; }
        public string NSucursal { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdMoneda { get; set; }
     




        public caj_Caja_Info(){}
    }
}
