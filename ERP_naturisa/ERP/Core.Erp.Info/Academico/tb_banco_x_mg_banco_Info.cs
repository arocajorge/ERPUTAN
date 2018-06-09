using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
    public class tb_banco_x_mg_banco_Info
    {
        public int Id_tb_banco_x_mgbanco { get; set; }
        public Nullable<int> IdBanco_Erp { get; set; }
        public Nullable<int> IdBanco_Academico { get; set; }
        public string nombre { get; set; }
        public string nota1 { get; set; }
        public string nota2 { get; set; }
        public Nullable<System.DateTime> fecha_insert { get; set; }
        public Nullable<System.DateTime> fecha_update { get; set; }
    }
}
