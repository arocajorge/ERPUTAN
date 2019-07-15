using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_comprador_familia_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdComprador { get; set; }
        public int Secuencia { get; set; }
        public int IdFamilia { get; set; }

        #region Campos que no existen en la tabla
        public decimal IdOrdenPedido { get; set; }
        public string Familia { get; set; }
        public string Comprador { get; set; }
        #endregion
    }
}
