using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt020_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        XINV_Rpt020_Bus busRpt = new XINV_Rpt020_Bus();
        public XINV_Rpt020_frm()
        {
            InitializeComponent();
        }

        private void XINV_Rpt020_frm_Load(object sender, EventArgs e)
        {
            ucInv_MenuReportes_21.dtpDesde.EditValue = DateTime.Now.Date.AddDays(-7);
            ucInv_MenuReportes_21.dtpHasta.EditValue = DateTime.Now.Date;
        }

        private void ucInv_MenuReportes_21_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucInv_MenuReportes_21_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int IdSucursal = ucInv_MenuReportes_21.cmbSucursal.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes_21.cmbSucursal.EditValue);
                int IdBodega = ucInv_MenuReportes_21.cmbBodega.EditValue == null ? 0 : Convert.ToInt32(ucInv_MenuReportes_21.cmbBodega.EditValue);
                decimal IdProducto = ucInv_MenuReportes_21.cmbProducto.EditValue == null ? 0 : Convert.ToDecimal(ucInv_MenuReportes_21.cmbProducto.EditValue);
                string IdCentroCosto = ucInv_MenuReportes_21.barEditItemCentroCosto.EditValue == null ? "" : ucInv_MenuReportes_21.barEditItemCentroCosto.EditValue.ToString();
                DateTime FechaIni = ucInv_MenuReportes_21.dtpDesde.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucInv_MenuReportes_21.dtpDesde.EditValue).Date;
                DateTime FechaFin = ucInv_MenuReportes_21.dtpHasta.EditValue == null ? DateTime.Now.Date : Convert.ToDateTime(ucInv_MenuReportes_21.dtpHasta.EditValue).Date;

                if (IdSucursal == 0)
                {
                    MessageBox.Show("Debe seleccionar una sucursal",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                PVGrid_orden_compra.DataSource = busRpt.GetList(param.IdEmpresa, IdProducto, FechaIni, FechaFin, IdCentroCosto, IdSucursal, IdBodega);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void PVGrid_orden_compra_Click(object sender, EventArgs e)
        {

        }

        private void ucInv_MenuReportes_21_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.PVGrid_orden_compra.ShowRibbonPrintPreview();
        }
    }
}
