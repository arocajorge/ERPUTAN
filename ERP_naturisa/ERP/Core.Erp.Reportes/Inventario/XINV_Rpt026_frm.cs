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

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt026_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public XINV_Rpt026_frm()
        {
            InitializeComponent();
        }

        private void ucInv_MenuReportes_21_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int IdSucursal = Menu_rpt.cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(Menu_rpt.cmbSucursal.EditValue);
                int IdBodega = Menu_rpt.cmbBodega.EditValue == null ? 0 : Convert.ToInt32(Menu_rpt.cmbBodega.EditValue);
                DateTime fecha_ini = Menu_rpt.dtpDesde.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(Menu_rpt.dtpDesde.EditValue).Date;
                DateTime fecha_fin = Menu_rpt.dtpHasta.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(Menu_rpt.dtpHasta.EditValue).Date;
                
                string nom_Sucursal = IdSucursal == 0 ? "Todas" : Menu_rpt.cmbSucursal.Edit.GetDisplayText(Menu_rpt.cmbSucursal.EditValue);
                string nom_Bodega = IdBodega == 0 ? "Todas" : Menu_rpt.cmbBodega.Edit.GetDisplayText(Menu_rpt.cmbBodega.EditValue);
                XINV_Rpt026_Rpt rpt = new XINV_Rpt026_Rpt();

                rpt.P_IdSucursal.Value = IdSucursal;
                rpt.P_IdSucursal.Visible = false;
                rpt.PS_nom_Sucursal.Value = nom_Sucursal;
                rpt.PS_nom_Sucursal.Visible = false;
                rpt.PS_nom_Bodega.Value = nom_Bodega;
                rpt.PS_nom_Bodega.Visible = false;
                rpt.P_IdBodega.Value = IdBodega;
                rpt.P_IdBodega.Visible = false;
                rpt.P_Fecha_ini.Value = fecha_ini;
                rpt.P_Fecha_ini.Visible = false;
                rpt.P_Fecha_fin.Value = fecha_fin;
                rpt.P_Fecha_fin.Visible = false;
                rpt.P_IdCategoria.Value = Menu_rpt.Get_info_categoria() == null ? "" : Menu_rpt.Get_info_categoria().IdCategoria;
                rpt.P_IdCategoria.Visible = false;
                rpt.P_IdLinea.Value = Menu_rpt.Get_info_linea() == null ? 0 : Menu_rpt.Get_info_linea().IdLinea;
                rpt.P_IdLinea.Visible = false;
                rpt.PS_Categoria.Value = Menu_rpt.Get_info_categoria() == null ? "Todas" : Menu_rpt.Get_info_categoria().ca_Categoria2;
                rpt.PS_Categoria.Visible = false;
                rpt.PS_Linea.Value = Menu_rpt.Get_info_linea() == null ? "Todas" : Menu_rpt.Get_info_linea().nom_linea2;
                rpt.PS_Linea.Visible = false;

                rpt.RequestParameters = false;
                
                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucInv_MenuReportes_21_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
