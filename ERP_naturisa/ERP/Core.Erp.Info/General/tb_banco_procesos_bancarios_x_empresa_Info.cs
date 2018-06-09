using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_banco_procesos_bancarios_x_empresa_Info
    {
        public int IdEmpresa { get; set; }
        public string IdProceso_bancario_tipo { get; set; }        
        public int IdBanco { get; set; }
        public string cod_banco { get; set; }
        public string Codigo_Empresa { get; set; }
        public Nullable<decimal> Secuencial_detalle_inicial { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public Nullable<bool> Se_contabiliza { get; set; }

        public string Tipo_Proc { get; set; }


        //Campos vista
        public ebanco_procesos_bancarios_tipo cod_Proceso { get; set; }
        public string Iniciales_Archivo { get; set; }
        public string nom_proceso_bancario { get; set; }
    }
}
