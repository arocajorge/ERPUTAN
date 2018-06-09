using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_banco_procesos_bancarios_Info
    {
        public int IdBanco { get; set; }
        public string IdProceso_bancario { get; set; }
        public string Nombre_Archivo { get; set; }
        public string cod_banco { get; set; }
        public string nom_proceso_bancario { get; set; }
        public string estado { get; set; }
        public Boolean Estado { get; set; }
        public bool EstaEnBase { get; set; }
        public string Codigo_Empresa { get; set; }


        public tb_banco_procesos_bancarios_Info()
        {

        }
    }
}
