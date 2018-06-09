using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using  Core.Erp.Info.General;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_EficienciaPiezas_Rpt_Info
    {
        public List<prd_OrdenTaller_Info> LmOrdenTaller { get; set; }
        public ct_Centro_costo_Info InfoCentroCosto { get; set; }
        public tb_Empresa_Info Empresa { get; set; }
        public prd_EficienciaPiezas_Rpt_Info(){}
    }
}
