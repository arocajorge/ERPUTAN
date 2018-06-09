using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Parametros : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Parametros_Bus busPara = new Af_Parametros_Bus();
        Af_Parametros_Info Info = new Af_Parametros_Info();
        string MensajeError = "";
        #endregion

        public frmAF_Parametros()
        {
            InitializeComponent();
        }

        public Boolean Validar()
        {
            try
            {
                cmbtipocbtecble.Focus();

                if (cmbtipocbtecble.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para Depreciación");
                    cmbtipocbtecble.Focus();
                    return false;
                }

                if (cmbtipocbtecbleBaja.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Baja de Activo Fijo");
                    cmbtipocbtecbleBaja.Focus();
                    return false;
                }

                if (cmbtipocbtecbleMejora.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Mejora de Activo Fijo");
                    cmbtipocbtecbleMejora.Focus();
                    return false;
                }

                if (cmbtipocbtecbleVenta.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Venta de Activo Fijo");
                    cmbtipocbtecbleVenta.Focus();
                    return false;
                }

                if (cmbtipocbtecbleRetiro.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Retiro de Activo Fijo");
                    cmbtipocbtecbleRetiro.Focus();
                    return false;
                }


                if (cmbtipoAnulaBaja.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Anulación de la Baja de Activo Fijo");
                    cmbtipoAnulaBaja.Focus();
                    return false;
                }

                if (cmbtipoAnulaMejora.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Anulación de la Mejora de Activo Fijo");
                    cmbtipoAnulaMejora.Focus();
                    return false;
                }

                if (cmbtipoAnulaDepreciacion.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Anulación de la Depreciación");
                    cmbtipoAnulaDepreciacion.Focus();
                    return false;
                }

                if (cmbtipoAnulaRetiro.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Anulación del Retiro de Activo Fijo");
                    cmbtipoAnulaRetiro.Focus();
                    return false;
                }
                
                if (cmbtipoAnulaVenta.get_TipoCbteCble().IdTipoCbte == null)
                {
                    MessageBox.Show("Por Favor Seleccione Tipo de Comprobante para la Anulación de la Venta de Activo Fijo");
                    cmbtipoAnulaVenta.Focus();
                    return false;
                }



                

                if (cmbFormaContabiliza.EditValue == null || cmbFormaContabiliza.EditValue == "")
                {
                    MessageBox.Show("Por Favor Seleccione la Forma de Contabilzar la Depreciación");
                    cmbFormaContabiliza.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El parametro ", "Activo Fijo");
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdCtaCble_Activo = (cmPlanCtaactivos.get_PlanCtaInfo().IdCtaCble == "") ? null : cmPlanCtaactivos.get_PlanCtaInfo().IdCtaCble;
                Info.IdCtaCble_Dep_Acum = (cmPlanCtadepre.get_PlanCtaInfo().IdCtaCble == "") ? null : cmPlanCtadepre.get_PlanCtaInfo().IdCtaCble;
                Info.IdCtaCble_Gastos_Depre = (cmPlanCtagasto.get_PlanCtaInfo().IdCtaCble == "") ? null : cmPlanCtagasto.get_PlanCtaInfo().IdCtaCble;
                Info.IdTipoCbte = cmbtipocbtecble.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteBaja = cmbtipocbtecbleBaja.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteMejora = cmbtipocbtecbleMejora.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteRetiro = cmbtipocbtecbleRetiro.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteVenta = cmbtipocbtecbleVenta.get_TipoCbteCble().IdTipoCbte;
                Info.FormaContabiliza = Convert.ToString(cmbFormaContabiliza.EditValue);
                Info.IdTipoCbteBaja_Anulacion = cmbtipoAnulaBaja.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteMejora_Anulacion = cmbtipoAnulaMejora.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteRetiro_Anulacion = cmbtipoAnulaRetiro.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteVenta_Anulacion = cmbtipoAnulaVenta.get_TipoCbteCble().IdTipoCbte;
                Info.IdTipoCbteDep_Acum_Anulacion = cmbtipoAnulaDepreciacion.get_TipoCbteCble().IdTipoCbte;
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmAF_Parametros_Load(object sender, EventArgs e)
        {
            try
            {
                Info = busPara.Get_Info_Parametros(param.IdEmpresa);
                cmbtipocbtecble.set_TipoCbteCble(Info.IdTipoCbte);
                cmbtipocbtecbleBaja.set_TipoCbteCble(Info.IdTipoCbteBaja);
                cmbtipocbtecbleMejora.set_TipoCbteCble(Info.IdTipoCbteMejora);
                cmbtipocbtecbleRetiro.set_TipoCbteCble(Info.IdTipoCbteRetiro);
                cmbtipocbtecbleVenta.set_TipoCbteCble(Info.IdTipoCbteVenta);
                cmPlanCtaactivos.set_PlanCtarInfo(Info.IdCtaCble_Activo);
                cmPlanCtadepre.set_PlanCtarInfo(Info.IdCtaCble_Dep_Acum);
                cmPlanCtagasto.set_PlanCtarInfo(Info.IdCtaCble_Gastos_Depre);  
                cmbFormaContabiliza.EditValue = Info.FormaContabiliza;

                cmbtipoAnulaBaja.set_TipoCbteCble(Info.IdTipoCbteBaja_Anulacion);
                cmbtipoAnulaMejora.set_TipoCbteCble(Info.IdTipoCbteMejora_Anulacion);
                cmbtipoAnulaRetiro.set_TipoCbteCble(Info.IdTipoCbteRetiro_Anulacion);
                cmbtipoAnulaVenta.set_TipoCbteCble(Info.IdTipoCbteVenta_Anulacion);
                cmbtipoAnulaDepreciacion.set_TipoCbteCble(Info.IdTipoCbteDep_Acum_Anulacion);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}