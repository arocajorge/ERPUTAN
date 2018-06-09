using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt002_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XFAC_Rpt002_rpt()
        {
            InitializeComponent();
            //xlbl_idReporte.Text = "XFAC_Rpt002_rpt";
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_Rpt002_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XFAC_Rpt002_Bus rptBus = new XFAC_Rpt002_Bus();
                List<XFAC_Rpt002_Info> lstInfo = new List<XFAC_Rpt002_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;
                DateTime FechaIni = DateTime.Now;
                DateTime FechaFin = DateTime.Now;
                string TipoPago = "";
                bool EfectoTribu = false;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdClienteIni = Convert.ToDecimal(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToDecimal(Parameters["IdClienteFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                TipoPago = Convert.ToString(Parameters["TipoPago"].Value);
                EfectoTribu = Convert.ToBoolean(this.PEfectoTributario.Value);

                if (EfectoTribu)
                {
                    lblTitulo.Text = "Efectos Tributarios";
                    cel_det_pagado.Visible = false;
                    cel_det_saldo.Visible = false;
                    cel_cab_pagado.Visible = false;
                    cel_cab_saldo.Visible = false;
                    cel_rep_pagado.Visible = false;
                    cel_rep_saldo.Visible = false;
                    cel_gru_pagado.Visible = false;
                    cel_gru_saldo.Visible = false;
                }
                else
                {
                    lblTitulo.Text = "Reporte de Ventas";
                    cel_det_pagado.Visible = true;
                    cel_det_saldo.Visible = true;
                    cel_cab_pagado.Visible = true;
                    cel_cab_saldo.Visible = true;
                    cel_rep_pagado.Visible = true;
                    cel_rep_saldo.Visible = true;
                    cel_gru_pagado.Visible = true;
                    cel_gru_saldo.Visible = true;
                }

                lstInfo = rptBus.getDatosReporteVentas(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaFin, TipoPago);
                this.DataSource = lstInfo.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt002_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt002_rpt) };
            }
        }



    }
}
