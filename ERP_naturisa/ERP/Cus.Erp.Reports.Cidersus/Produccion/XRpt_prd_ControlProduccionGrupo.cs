using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Produc_Cirdesus;

namespace Cus.Erp.Reports.Cidersus
{
    public partial class XRpt_prd_ControlProduccionGrupo : DevExpress.XtraReports.UI.XtraReport
    {
        public XRpt_prd_ControlProduccionGrupo()
        {
            InitializeComponent();
        }



        public void loadData(prd_rpt_ControlProducionGrupo_Info [] Data, String Estado)
        {
            try
            {

                //if (Estado == "A")
                //    this.Watermark.Image = null;



                this.DataSource = Data;





            }
            catch (Exception ex)
            {
            }
        }
        /*
                public void cargaData(in_OrdenCompraLocalReporte_Info[] Data,string user)
                {
                    try
                    {
                        this.DataSource = Data;

                        Object a = "";
                        a = this.GetCurrentColumnValue("OC_CabeceraInfo");
                        in_OrdenCompraLocal_Info info = new in_OrdenCompraLocal_Info();
                        info = (in_OrdenCompraLocal_Info)a;
                
                        xrLabelUsuario.Text = user;
                        if (info.Estado == "A")
                            this.Watermark.Image = null;

                        Funciones fxG = new Funciones();
                        this.fx_LetrasValores.Expression = "'" + fxG.NumeroALetras(info.oc_total.ToString()) + "'";

                        if (info.IdTerminoPago == 6)
                        {
                            chk_PagoContado.Checked = true;
                        }
                        else
                        {
                            chk_PagoCredito.Checked = true;

                        }
                    }
            */
    }
}
