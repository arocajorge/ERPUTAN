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
    public partial class XINV_Rpt025_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        public XINV_Rpt025_frm()
        {
            InitializeComponent();
        }

        private void ucInv_MenuReportes1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucInv_MenuReportes1_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int IdSucursal = ucInv_MenuReportes1.cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbSucursal.EditValue);
                int IdBodega = ucInv_MenuReportes1.cmbBodega.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbBodega.EditValue);
                int IdMovi_inven_tipo = ucInv_MenuReportes1.cmbTipoMovInve.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                decimal IdProducto = ucInv_MenuReportes1.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_MenuReportes1.cmbProducto.EditValue);
                DateTime fecha_ini = ucInv_MenuReportes1.dtpDesde.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucInv_MenuReportes1.dtpDesde.EditValue).Date;
                DateTime fecha_fin = ucInv_MenuReportes1.dtpHasta.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucInv_MenuReportes1.dtpHasta.EditValue).Date;

                string nom_Sucursal = IdSucursal == 0 ? "Todas" : ucInv_MenuReportes1.cmbSucursal_Grid.GetDisplayText(ucInv_MenuReportes1.cmbSucursal.EditValue);
                string nom_Bodega = IdBodega == 0 ? "Todas" : ucInv_MenuReportes1.cmbBodega_Grid.GetDisplayText(ucInv_MenuReportes1.cmbBodega.EditValue);
                string nom_Movi_inven_tipo = IdMovi_inven_tipo == 0 ? "Todos" : ucInv_MenuReportes1.CmbTipoMov_Grid.GetDisplayText(ucInv_MenuReportes1.cmbTipoMovInve.EditValue);
                string nom_Producto = IdProducto == 0 ? "Todos" : ucInv_MenuReportes1.cmbProducto_Grid.GetDisplayText(ucInv_MenuReportes1.cmbProducto.EditValue);
                string signo = ucInv_MenuReportes1.optOpciones.EditValue == null ? "" : ucInv_MenuReportes1.optOpciones.EditValue.ToString();
                XINV_Rpt025_Rpt rpt = new XINV_Rpt025_Rpt();
                rpt.Set_parameters(IdSucursal, nom_Sucursal, IdBodega, nom_Bodega, IdMovi_inven_tipo, nom_Movi_inven_tipo, IdProducto, nom_Producto, fecha_ini, fecha_fin,signo);
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
    }
}
