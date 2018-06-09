using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.CuentasxPagar
{

    public class cp_TipoServicioxProvee_Info
    {

        
        public string codigo { get; set; }
        public string descripcion { get; set; }

  

        public cp_TipoServicioxProvee_Info() { }

        public cp_TipoServicioxProvee_Info(string _codigo, string _descripcion)
        {
            codigo = _codigo;
            descripcion = _descripcion;
        }
    }

}
