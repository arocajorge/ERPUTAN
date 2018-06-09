using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_tarjeta_Info
    {

        public int IdTarjeta { get; set; }
        public string tr_Descripcion { get; set; }
        public int IdBanco{ get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }


        public tb_tarjeta_Info()
        {

        }
    }
}
