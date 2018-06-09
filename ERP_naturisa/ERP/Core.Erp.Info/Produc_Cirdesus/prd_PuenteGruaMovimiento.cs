using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_PuenteGruaMovimiento
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPteGrua { get; set; }
        public int Idproducto { get; set; }
        public int IdOrdenTaller { get; set; }
        public DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Codigo_Barra_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public int Toneladas_Mover { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string pr_motivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public prd_PuenteGruaMovimiento() 
        { }
    }
}
