using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//MODIFICADO POR: DEREK MEJÍA SORIA
//21/01/2014Mod22/01/2014
namespace Core.Erp.Info.General
{
    public class tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCategoria { get; set; }
        public string IdProcesoConta { get; set; }
        public string IdParametro { get; set; }
        public string IdCtaCble { get; set; }
        public string Dbcr { get; set; }
        public string IdCentroCosto { get; set; }
        public string Modificado { get; set; }
        public string Viene_Base { get; set; }

        //Derek 21/01/2014
        public string Su_Descripcion { get; set; }
        public string ca_Categoria { get; set; }


        public tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info()
        {

        }

    }
}
