using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Parametro : Form 
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Cbtecble_tipo_Bus TIPO = new ct_Cbtecble_tipo_Bus();
        ct_Parametro_Bus busPara = new ct_Parametro_Bus();
        ct_Parametro_Info Info = new ct_Parametro_Info();
        string MensajeError = "";
        #endregion
        
        public frmCon_Parametro()
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (Validar())
                {
                    if (busPara.ModificarDB(Info))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El parametro ", "Contable");
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                Info = busPara.Get_Info_Parametro(param.IdEmpresa);
                cmbCierreAnual.set_TipoCbteCble(Info.IdTipoCbte_AsientoCierre_Anual);
                cmbSaldoInicial.set_TipoCbteCble(Info.IdTipoCbte_SaldoInicial);
                chk_Se_Muestra_Todas_las_ctas_en_combos.Checked = (Info.P_Se_Muestra_Todas_las_ctas_en_combos == null) ? false : Convert.ToBoolean(Info.P_Se_Muestra_Todas_las_ctas_en_combos);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                cmbSaldoInicial.Focus();

                if (cmbSaldoInicial.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Comprobante Contable para saldo Inicial");
                    cmbSaldoInicial.Focus();
                    return false;
                }
                if (cmbCierreAnual.get_TipoCbteCble() == null)
                {
                    MessageBox.Show("Por Favor Seleccione Comprobante Contable para Cierre Anual");
                    cmbCierreAnual.Focus();
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
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdTipoCbte_SaldoInicial = cmbSaldoInicial.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbte_AsientoCierre_Anual = cmbCierreAnual.get_TipoCbteCble().IdTipoCbte;
                Info.P_Se_Muestra_Todas_las_ctas_en_combos = chk_Se_Muestra_Todas_las_ctas_en_combos.Checked;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
      
    }
}
