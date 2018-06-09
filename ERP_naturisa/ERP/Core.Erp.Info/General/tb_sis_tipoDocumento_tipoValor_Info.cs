using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_tipoDocumento_tipoValor_Info
    {
        public string IdTipoValor { get; set; }
        public string Descripcion { get; set; }
        public int Posicion { get; set; }
        public Boolean Estado { get; set; }
        public string IdTipoDocumento { get; set; }
        public double Valor { get; set; }


        public tb_sis_tipoDocumento_tipoValor_Info() { }
    }
}
