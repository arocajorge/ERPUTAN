using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Compras
{
    public partial class XCOMP_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XCOMP_FJ_Rpt001_Bus Bus = new XCOMP_FJ_Rpt001_Bus();

        public XCOMP_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        public void LlenarReporte(int idEmpresa, int idSucursal, decimal idOrdenCompra)
        {
            try
            {
                double Total=0;
                string STotal="";

                List<XCOMP_FJ_Rpt001_Info> Lista = new List<XCOMP_FJ_Rpt001_Info>();
                Lista = Bus.Get_Orden_compra(idEmpresa, idSucursal, idOrdenCompra);
                if (Lista.Count!=0)
                {
                    foreach (var item in Lista)
                    {
                        Total = Total  + item.total;

                    }

                    Core.Erp.Info.General.Funciones fx = new Core.Erp.Info.General.Funciones();
                    STotal = fx.NumeroALetras(Total.ToString());
                    this.lblTotalletras.Text = STotal;
                    this.DataSource = Lista;  
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
