using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt014_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cp_proveedor_Info> proveedorInfo = new List<cp_proveedor_Info>();
        cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
        public XCXP_Rpt014_rpt()
        {
            InitializeComponent();
           
        }

    }
}
