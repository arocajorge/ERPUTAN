using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_transportista_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransportista { get; set; }
        public decimal IdPersona { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Placa { get; set; }
        public string pe_nombreCompleto { get; set; }

        public string IdUsuario { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        public tb_transportista_Info() { }
    }
}
