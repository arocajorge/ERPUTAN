using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_LogError_visor : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus LogBus = new tb_sis_Log_Error_Vzen_Bus();
        tb_sis_Log_Error_Vzen_Info InfoLog = new tb_sis_Log_Error_Vzen_Info();
        List<tb_sis_Log_Error_Vzen_Info> ListInfoLog = new List<tb_sis_Log_Error_Vzen_Info>();
        #endregion
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public FrmGe_LogError_visor()
        {
            InitializeComponent();
        }

        private void FrmGe_LogError_visor_Load(object sender, EventArgs e)
        {
            try
            {
                ListInfoLog=LogBus.ObtenerLista_logError();

                gridControl_data.DataSource = ListInfoLog;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void gridView_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void gridView_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoLog = new tb_sis_Log_Error_Vzen_Info();
                InfoLog = (tb_sis_Log_Error_Vzen_Info)this.gridView_data.GetFocusedRow();
                richTextBox_detalle.Text = InfoLog.Detalle;
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
