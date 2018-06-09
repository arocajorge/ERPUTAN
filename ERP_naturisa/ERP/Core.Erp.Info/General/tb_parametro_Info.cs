using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
   public class tb_parametro_Info
    {
        public string IdParametro { get; set; }
        public string IdTipoParam { get; set; }
        public string Valor { get; set; }
        public string descripcion { get; set; }

        public string IdCliente_Vzen { get; set; }


        public Boolean Se_Actualizo_Valor { get; set; }


        public tb_parametro_Info()
        {

        }

        public tb_parametro_Info(string _IdParametro, string _IdTipoParam, string _Valor)
        {
            IdParametro = _IdParametro;
            IdTipoParam = _IdTipoParam;
            Valor = _Valor;


        }

    }
}
