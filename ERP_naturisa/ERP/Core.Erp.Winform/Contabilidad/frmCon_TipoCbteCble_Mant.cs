using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_TipoCbteCble_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_TipoCbteCble_Mant_FormClosing event_frmCon_TipoCbteCble_Mant_FormClosing;
        ct_Cbtecble_tipo_Info InfoTipoCble = new ct_Cbtecble_tipo_Info();
        ct_Cbtecble_tipo_Bus BusTipoCble = new ct_Cbtecble_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        string motiAnulacion = "";
        string MensajeError = "";

        
        #endregion

        public frmCon_TipoCbteCble_Mant()
        {
            InitializeComponent();
           
        }

        void frmCon_TipoCbteCble_Mant_event_frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
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
                Grabar();
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
                Grabar();
                this.Close();
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

        private void frmCon_TipoCbteCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_TipoCbteCble_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_TipoCbteCble_Mant_Load(object sender, EventArgs e)
        {

        }

        private ct_Cbtecble_tipo_Info get_TipoCbtecble()
        {
            try
            {
                InfoTipoCble.IdEmpresa = param.IdEmpresa;
                InfoTipoCble.CodTipoCbte = txtcodigo.Text;
                InfoTipoCble.IdTipoCbte = Convert.ToInt32((txtidtipocbte.EditValue == null) ? 0 : txtidtipocbte.EditValue); 
                InfoTipoCble.tc_TipoCbte = txttipocbte.Text;
                InfoTipoCble.tc_Estado = (this.chk_estado.Checked == true) ? "A" : "I";
                InfoTipoCble.tc_Interno = (this.chk_interno.Checked == true) ? "S" : "N";
                InfoTipoCble.tc_Nemonico = txtnemonico.Text;

                return InfoTipoCble;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_tipo_Info();
            }
        }

        public void set_TipoCbtecble(ct_Cbtecble_tipo_Info info)
        {
            try
            {
                txtcodigo.Text = info.CodTipoCbte;
                txtnemonico.Text = info.tc_Nemonico;
                txtidtipocbte.Text = info.IdTipoCbte.ToString();
                txttipocbte.Text = info.tc_TipoCbte;
                this.chk_estado.Checked = (info.tc_Estado == "I") ? false : true;
                this.chk_interno.Checked = (info.tc_Interno == "N") ? false : true;
                lb_Anulado.Visible = (info.tc_Estado == "I") ? true : false;

                InfoTipoCble = info;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean validar()
        {
            try
            {
                Boolean estado = true;

                if (txtcodigo.EditValue == null)
                {
                    MessageBox.Show("Ingrese el Código del Tipo de Comprobante Contable", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Focus();
                    estado = false;
                    return estado;
                }

                if (this.txttipocbte.EditValue == null)
                {
                    MessageBox.Show("Ingrese el Tipo de Comprobante Contable", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttipocbte.Focus();
                    estado = false;
                    return estado;
                }

                //if (this.txtnemonico.EditValue == null)
                //{
                //    MessageBox.Show("Ingrese el Nemónico del Tipo de Comprobante Contable", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtnemonico.Focus();
                //    estado = false;
                //    return estado;
                //}


                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Grabar()
        {
            try
            {
                if (validar())
                {
                    get_TipoCbtecble();

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (BusTipoCble.GrabarDB(InfoTipoCble, ref MensajeError))
                        {
                            txtcodigo.Text = (txtcodigo.Text == "") ? txtidtipocbte.Text : txtcodigo.Text;
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Tipo de Comprobante Contable ", InfoTipoCble.IdTipoCbte);
                            MessageBox.Show(smensaje, param.Nombre_sistema);

                            
                            LimpiarDatos();
                            return;
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (BusTipoCble.ModificarDB(InfoTipoCble, ref  MensajeError))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Tipo de Comprobante Contable ", txtidtipocbte.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, MensajeError);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (InfoTipoCble.tc_Estado != "I")
                        {
                            if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Comprobante Contable #: " + txtidtipocbte.Text + " ?", "Anulación de Tipo de Comprobante Contable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                motiAnulacion = fr.motivoAnulacion;
                                InfoTipoCble.MotiAnula = motiAnulacion;
                                InfoTipoCble.IdUsuarioUltAnu = param.IdUsuario;
                                InfoTipoCble.Fecha_UltAnu = param.Fecha_Transac;
                                chk_estado.Checked = false;

                                if (BusTipoCble.EliminarDB(InfoTipoCble, ref  MensajeError))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Tipo de Comprobante Contable ", txtidtipocbte.Text);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    lb_Anulado.Visible = true;
                                    ucGe_Menu.Visible_bntAnular = false;
                                    chk_estado.Checked = false;
                                }
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, MensajeError);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                            MessageBox.Show("Este Tipo de Comprobante Contable ya esta Anulado...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("No se puede Grabar...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                InfoTipoCble = new ct_Cbtecble_tipo_Info();
                txtcodigo.Text = "";
                txtidtipocbte.EditValue = "";
                txttipocbte.Text = "";
                this.chk_estado.Checked = true;
                
                txtnemonico.Text = "";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}