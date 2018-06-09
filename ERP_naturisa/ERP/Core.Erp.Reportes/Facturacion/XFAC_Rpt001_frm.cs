using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt001_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;        

        public XFAC_Rpt001_frm()
        {
            InitializeComponent();
        }
        
        void cargarDatosGrid()
        {
            try
            {
                XFAC_Rpt001_Bus rptBus = new XFAC_Rpt001_Bus();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                fechaini = Convert.ToDateTime(ucFa_Menu.dtpDesde.EditValue);
                fechafin = Convert.ToDateTime(ucFa_Menu.dtpHasta.EditValue);
                IdSucursalIni = (ucFa_Menu.cmbSucursal.EditValue == null) ? 0 : Convert.ToInt32(ucFa_Menu.cmbSucursal.EditValue);
                IdSucursalFin = (ucFa_Menu.cmbSucursal.EditValue == null || Convert.ToDecimal(ucFa_Menu.cmbSucursal.EditValue) == 0) ? 999999 : Convert.ToInt32(ucFa_Menu.cmbSucursal.EditValue);

                this.pivotGridControlDocumento.DataSource = rptBus.getDatosDocumentos(param.IdEmpresa, IdSucursalIni, IdSucursalFin, Convert.ToString(ucFa_Menu.cmbTipoDocumento.EditValue), fechaini, fechafin);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarDatosGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pivotGridControlDocumento.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void ucFa_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
