using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_microempresa_Info
    {
        public string Ruc { get; set; }
        public string Nombre { get; set; }

        #region Campos que no existen en la base
        public bool EsMicroEmpresa { get; set; }
        #endregion
    }
}
