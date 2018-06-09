using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Importacion
{
    public class imp_Tipo_docu_pago_Info
    {
        public string CodDocu_Pago { get; set; }
        public string Descripcion { get; set; }
        public string PideBanco { get; set; }
        public string PideProveedor { get; set; }
        
        public imp_Tipo_docu_pago_Info()
        {
        }
    }
}
