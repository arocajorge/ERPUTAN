using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles.Archivos_para_Bancos
{
    public class ro_Solicitud_Tarjeta_Guayaquil_Info
    {
        //cabecera datos adicionales
        public string NumCtaEmpresa { get; set; }
        public string NumCreditos { get; set; }

        //detalle
        public string TipoRegistro { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string CobroServicio { get; set; }
        public string Filler { get; set; }
        public string CodigoProceso { get; set; }
        public string Monto { get; set; }
        public string Motivo3 { get; set; }
        public string Filler2 { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Fecha { get; set; }

    }
}
