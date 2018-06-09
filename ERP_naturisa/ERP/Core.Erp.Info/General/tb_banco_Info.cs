
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_banco_Info
    {
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
        public string Estado { get; set; }
        public string CodigoLegal { get; set; }
        public Boolean? TieneFormatoTransferencia { get; set; }
        public List<tb_banco_procesos_bancarios_x_empresa_Info> lst_procesos_bancarios_x_empresa { get; set; }

        public tb_banco_Info()
        {
            lst_procesos_bancarios_x_empresa = new List<tb_banco_procesos_bancarios_x_empresa_Info>();
        }
    }
}
