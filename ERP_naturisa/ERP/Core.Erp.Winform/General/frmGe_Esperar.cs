using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using Core.Erp.Business.General;

namespace Core.Erp.Winform
{
    public partial class frmGe_Esperar : WaitForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public frmGe_Esperar()
        {
            try
            {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            try
            {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        public override void SetDescription(string description)
        {
            try
            {

            base.SetDescription(description);
            this.progressPanel1.Description = description;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            try
            {
                base.ProcessCommand(cmd, arg);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        #endregion

        public enum WaitFormCommand
        {

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {
            try
            {
                  //
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}