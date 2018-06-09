using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_Catalogo_Info
    {
        public int IdCatalogo { get; set; }
        public string CodCatalogo { get; set; }
        public string ca_descripcion { get; set; }
        public string ca_estado { get; set; }
        public int IdTipoCatalogo { get; set; }
        public int ca_orden { get; set; }

        public tb_Catalogo_Info() { }

        public tb_Catalogo_Info(int _IdCatalogo, string _CodCatalogo, string _ca_descripcion, string _ca_estado, int _IdTipoCatalogo, int _ca_orden)
        {

            IdCatalogo =_IdCatalogo ;
            CodCatalogo =_CodCatalogo ;
            ca_descripcion =_ca_descripcion ;
            ca_estado =_ca_estado ;
            IdTipoCatalogo =_IdTipoCatalogo ;
            ca_orden = _ca_orden;

        }


    }
}
