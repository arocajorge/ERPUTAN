using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt018_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt018_frm()
        {
            InitializeComponent();
        }

        private void Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCONTA_Rpt018_rpt rpt = new XCONTA_Rpt018_rpt();
                rpt.P_Fecha_ini.Value = Menu.bei_Desde.EditValue == null ? DateTime.Now : Menu.bei_Desde.EditValue;
                rpt.P_Fecha_ini.Visible = false;
                rpt.P_Fecha_fin.Value = Menu.bei_Hasta.EditValue == null ? DateTime.Now : Menu.bei_Hasta.EditValue;
                rpt.P_Fecha_fin.Visible = false;
                rpt.P_Mostrar_detalle.Value = Menu.bei_Check.EditValue;
                rpt.P_Mostrar_detalle.Visible = false;

                rpt.P_IdPunto_cargo_grupo.Value = Menu.Get_info_punto_cargo_grupo() == null ? 0 : Menu.Get_info_punto_cargo_grupo().IdPunto_cargo_grupo;
                rpt.P_IdPunto_cargo_grupo.Visible = false;

                rpt.PS_Punto_cargo_grupo.Value = Menu.Get_info_punto_cargo_grupo() == null ? "TODOS" : Menu.Get_info_punto_cargo_grupo().nom_punto_cargo_grupo2;
                rpt.PS_Punto_cargo_grupo.Visible = false;

                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.RequestParameters = false;

                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void XCONTA_Rpt018_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Menu.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
