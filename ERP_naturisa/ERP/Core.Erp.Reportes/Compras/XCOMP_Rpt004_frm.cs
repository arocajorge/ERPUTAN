using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Compras
{
    public partial class XCOMP_Rpt004_frm : Form
    {

        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        public XCOMP_Rpt004_frm()
        {
            InitializeComponent();
        }
        
        private void XCOMP_Rpt004_frm_Load(object sender, EventArgs e)
        {
         
        }

        void cargar_datos_grid_pivot()
        {
            try
            {
                XCOMP_Rpt004_Bus obus = new XCOMP_Rpt004_Bus();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;

                fechaini = Convert.ToDateTime(ucGe_Menu.dtp_fechaIni.EditValue);
                fechafin = Convert.ToDateTime(ucGe_Menu.dtp_fechaFin.EditValue);

                this.PVGrid_orden_compra.DataSource = obus.Cargar_data(param.IdEmpresa, fechaini, fechafin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ucGe_Menu_Reportes_Compras1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.PVGrid_orden_compra.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Reportes_Compras1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargar_datos_grid_pivot();
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void bttnImprimir_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        private void ucGe_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }
    }
}
