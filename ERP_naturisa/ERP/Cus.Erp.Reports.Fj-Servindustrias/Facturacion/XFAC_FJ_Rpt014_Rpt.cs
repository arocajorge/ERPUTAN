using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt014_Rpt()
        {
            InitializeComponent();
        }
        List<XFAC_FJ_Rpt014_Info> lista = new List<XFAC_FJ_Rpt014_Info>();
        XFAC_FJ_Rpt014_Bus bus = new XFAC_FJ_Rpt014_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private void XFAC_FJ_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdSucursal = Convert.ToInt32(P_IdSucursal.Value);
                int IdBodega = Convert.ToInt32(P_IdBodega.Value);
                decimal IdCbteVta = Convert.ToDecimal(P_IdCbteVta.Value);
                int Numero_lineas = Convert.ToInt32(P_Numero_lineas.Value);

                double por_iva = param.iva.porcentaje;

                lista = bus.Get_list(param.IdEmpresa, IdSucursal, IdBodega, IdCbteVta, Numero_lineas);
               // lista.ForEach(q => q.vt_por_iva = q.vt_por_iva == "" ? por_iva : q.vt_por_iva);
                this.DataSource = lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
