using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiro_para_Conciliacion_Caja : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<cp_orden_giro_Info> list_OG = new List<cp_orden_giro_Info>();
        cp_orden_giro_Info info_OG = new cp_orden_giro_Info();
        cp_orden_giro_Bus bus_OG = new cp_orden_giro_Bus();

        string MensajeError = string.Empty;
        int RowHandle = 0;
        #endregion

        public frmCP_OrdenGiro_para_Conciliacion_Caja()
        {
            InitializeComponent();            
        }

        public cp_orden_giro_Info Get_Orden_giro()
        {
            try
            {
                return info_OG;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void gridViewOrdenGiro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info_OG = (cp_orden_giro_Info)gridViewOrdenGiro.GetRow(e.FocusedRowHandle);
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenGiro_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                info_OG = (cp_orden_giro_Info)gridViewOrdenGiro.GetRow(RowHandle);
                this.Close();    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Grid()
        {
            try
            {
                list_OG = bus_OG.Get_List_orden_giro_x_Pagar(param.IdEmpresa, true, ref MensajeError);
                gridControlOrdenGiro.DataSource = list_OG;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_OrdenGiro_para_Conciliacion_Caja_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Vaciar_Click(object sender, EventArgs e)
        {
            try
            {
                info_OG = null;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
