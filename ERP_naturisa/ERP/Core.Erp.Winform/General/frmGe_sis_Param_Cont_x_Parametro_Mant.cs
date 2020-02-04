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
    public partial class FrmGe_sis_Param_Cont_x_Parametro_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing Event_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing;

        
        int txtCodigoMaxLengh;
        #endregion
       
        public FrmGe_sis_Param_Cont_x_Parametro_Mant()
        {
            try
            {
                InitializeComponent();
                            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_sis_Param_Cont_x_Parametro_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        Boolean validar()
        {
            try
            {
                if (cmbProceso.EditValue == null || cmbProceso.Text == "")
                {
                    MessageBox.Show("No ha seleccionado ningun proceso contable", "Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }
                if (txtCodigo.Text == "" || txtCodigo.Text.Length == txtCodigoMaxLengh)
                {
                    MessageBox.Show("No ha escrito el codigo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;

                }
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("No ha escrito la descripcion", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Get()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        
        private void cmbProceso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;
                }
                else
                {
                  if (e.KeyChar == 8)
                    {
                        if (txtCodigoMaxLengh == (txtCodigo.Text).Length)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmGe_sis_Param_Cont_x_Parametro_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    Get();
                    

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_event_btnGuardar_Click(sender, e);
                Close();
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
