using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.MobileSCI
{
    public class tbl_producto_Info
    {
        public int IdEmpresaSCI { get; set; }
        public decimal IdSCI { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        //Campos que no existen en la tabla
        public bool seleccionado { get; set; }
        public string nom_producto { get; set; }
        public string nom_categoria { get; set; }
        public string nom_linea { get; set; }
        public string mobile_cod_produccion { get; set; }
    }
}
