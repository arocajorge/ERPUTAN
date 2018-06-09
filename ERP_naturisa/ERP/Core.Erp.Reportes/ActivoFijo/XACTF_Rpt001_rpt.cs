using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt001_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<XACTF_Rpt001_Info> lstRpt { get; set; }

        public XACTF_Rpt001_rpt()
        {
            InitializeComponent();
        }

        public XACTF_Rpt001_rpt(string IdUsuario, string IdTipo)
        {
            InitializeComponent();
            lblIdUsuario.Text = IdUsuario;
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

            if (IdTipo == Cl_Enumeradores.eTipoActivoFijo.Baja_Acti.ToString())
                lblTituloPrincipal.Text = "SOPORTE DE BAJA DE ACTIVO FIJO";
            else
                lblTituloPrincipal.Text = "SOPORTE DE MEJORA DE ACTIVO FIJO";
            
        }

        private void XACTF_Rpt001_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XACTF_Rpt001_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XACTF_Rpt001_rpt) };
            }
        }

    }
}
