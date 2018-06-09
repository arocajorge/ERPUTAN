using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public partial class XACTF_Rpt010_frm : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;  

        public XACTF_Rpt010_frm()
        {
            InitializeComponent();
            ucactF_Menu.event_btnGenerar_ItemClick += ucactF_Menu_event_btnGenerar_ItemClick;
            ucactF_Menu.event_btnSalir_ItemClick += ucactF_Menu_event_btnSalir_ItemClick;
        }

        void ucactF_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucactF_Menu_event_btnGenerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ConsultarDatos()
        {
            try
            {
                XACTF_Rpt010_rpt Reporte = new XACTF_Rpt010_rpt();
                Reporte.RequestParameters = false;

                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdActivoFijo"].Value = (ucactF_Menu.barEditActivo.EditValue == null) ? 0 : ucactF_Menu.barEditActivo.EditValue;
                Reporte.Parameters["IdActivoFijoTipo"].Value = (ucactF_Menu.barEditItemTipo.EditValue == null) ? 0 : ucactF_Menu.barEditActivo.EditValue; ;
                Reporte.Parameters["FechaIni"].Value = ucactF_Menu.dtpFechaIni.EditValue;
                Reporte.Parameters["FechaFin"].Value = ucactF_Menu.dtpFechaFin.EditValue;

                Reporte.IdUsuario = param.IdUsuario;
                Reporte.nomActivoFijo = ucactF_Menu.barEditActivo.Edit.GetDisplayText(ucactF_Menu.barEditActivo.EditValue);
                Reporte.Tipo_Af = ucactF_Menu.cmbMejoBaj_AF.Edit.GetDisplayText(ucactF_Menu.barEditItemTipo.EditValue);

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}