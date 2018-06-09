using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Info.Importacion
{
	public class imp_gastosximport_x_empresa_Info
	{

        public int IdEmpresa { get; set; }
        public int IdGastoImp { get; set; }
        public string IdCtaCble { get; set; }
        public string debcre_DebBanco { get; set; }
        public string debCre_Provicion { get; set; }
        public string ga_decripcion { get; set; }
        public string CodGastoImp { get; set; }
        public string EstaEnBase { get; set; }
        public string AfectaLiquidacion { get; set; }
        public imp_gastosximport_x_empresa_Info()
        {

        }

	}
}
