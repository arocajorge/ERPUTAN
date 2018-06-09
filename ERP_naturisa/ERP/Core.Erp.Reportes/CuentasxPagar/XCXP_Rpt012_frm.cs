using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt012_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XCXP_Rpt012_frm()
        {
            InitializeComponent();
        }

        private void ucCp_Menu_Reportes1_event_btnimprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pgcCXP.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCp_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            { 
                cargar_datos_grid_pivot();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        void cargar_datos_grid_pivot()
        {
            try
            {
                XCXP_Rpt012_Bus obus = new XCXP_Rpt012_Bus();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;
                string msj = "";
                fechaini = Convert.ToDateTime(ucCp_Menu_Reportes1.get_FchIni());
                fechafin = Convert.ToDateTime(ucCp_Menu_Reportes1.get_FchFin());
                int prv = ucCp_Menu_Reportes1.get_cmbProveedor();
                int prvfin = 99999;
                if (prv > 0) prvfin = prv;
                this.pgcCXP.DataSource = obus.consultar_data(param.IdEmpresa, prv, prvfin, fechaini, fechafin, ref msj);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            try
            { 
                this.chartControlCXP.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
