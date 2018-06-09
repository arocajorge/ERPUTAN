using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico.Archivo_respuesta
{
    public class Aca_respuesta_archivo_bancario_Info
    {
        public string cod_estudiante { get; set; }
        public string nom_estudiante { get; set; }
        public string num_cuenta_tarjeta { get; set; }
        public string fecha_proceso { get; set; }
        public string valor_cobrado { get; set; }
        public string valor_comision { get; set; }
    }
}
