using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_ClienteTipo_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        fa_cliente_tipo_Info InfoCliTip = new fa_cliente_tipo_Info();
        fa_cliente_tipo_Bus busCliTip = new fa_cliente_tipo_Bus();
        public delegate void delegate_frmFa_ClienteTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFa_ClienteTipo_Mant_FormClosing event_frmFa_ClienteTipo_Mant_FormClosing;

        public frmFa_ClienteTipo_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmFa_ClienteTipo_Mant_FormClosing += frmFa_ClienteTipo_Mant_event_frmFa_ClienteTipo_Mant_FormClosing;

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarTipo())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else
                {
                    AnularTipo();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmFa_ClienteTipo_Mant_event_frmFa_ClienteTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmFa_ClienteTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        ucGe_Menu.Enabled_bntAnular = false;
                        chkestado.Checked = true;                        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        chkestado.Checked = true;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_ClienteTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmFa_ClienteTipo_Mant_event_frmFa_ClienteTipo_Mant_FormClosing(sender, e);
                event_frmFa_ClienteTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarTipo()
        {
            try
            {
                Boolean bolResult = false;
                int IdTipoCli = 0;
                string msjError = "";
                if (ValidarDatos())
                {
                    getInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busCliTip.Guardar_DB(InfoCliTip, ref IdTipoCli, ref msjError))
                            {
                                txtIdTipoCli.EditValue = IdTipoCli;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;                                
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente el Tipo de Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            InfoCliTip.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoCliTip.IdUsuarioUltMod = param.IdUsuario;

                            if (busCliTip.ModificarDB(InfoCliTip, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente el Tipo de Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;                     
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        Boolean AnularTipo()
        {
            try
            {
                Boolean bolResult = false;
                string msjError = "";
                if (ValidarDatos())
                {
                    getInfo();

                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoCliTip.MotivoAnula = frm.motivoAnulacion;
                    InfoCliTip.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoCliTip.IdUsuarioUltAnu = param.IdUsuario;

                    if (busCliTip.AnularDB(InfoCliTip, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente el Tipo de Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(msjError, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        Boolean ValidarDatos()
        {
            try
            {
                if (txtDescripcion.EditValue == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la Descripción del Tipo de Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Focus();
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

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void setInfo(fa_cliente_tipo_Info Info)
        {
            try
            {
                txtIdTipoCli.EditValue = Info.Idtipo_cliente;
                txtcodigo.EditValue = Info.Cod_cliente_tipo;
                txtDescripcion.EditValue = Info.Descripcion_tip_cliente;
                cmbCtaCbleLocal.set_PlanCtarInfo(Info.IdCtaCble_CXC_Con);
                cmbCtaCbleCredito.set_PlanCtarInfo(Info.IdCtaCble_CXC_Cred);
                cmbCtaCbleAnticipo.set_PlanCtarInfo(Info.IdCtaCble_CXC_Anticipo);
                if (Info.estado == "I")
                    chkestado.Checked = false;
                else
                    chkestado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getInfo()
        { 
            try
            {
                InfoCliTip.IdEmpresa = param.IdEmpresa;

                InfoCliTip.Cod_cliente_tipo = Convert.ToString(txtcodigo.EditValue);

                if (txtIdTipoCli.Text != "")
                {
                    InfoCliTip.Idtipo_cliente =  Convert.ToInt32(txtIdTipoCli.EditValue);
                }
                InfoCliTip.Descripcion_tip_cliente = Convert.ToString(txtDescripcion.EditValue);
                InfoCliTip.IdCtaCble_CXC_Con = (cmbCtaCbleLocal.get_PlanCtaInfo() == null)? null :cmbCtaCbleLocal.get_PlanCtaInfo().IdCtaCble;
                InfoCliTip.IdCtaCble_CXC_Cred = (cmbCtaCbleCredito.get_PlanCtaInfo() == null)? null :cmbCtaCbleCredito.get_PlanCtaInfo().IdCtaCble;
                InfoCliTip.IdCtaCble_CXC_Anticipo = (cmbCtaCbleAnticipo.get_PlanCtaInfo() == null) ? null : cmbCtaCbleAnticipo.get_PlanCtaInfo().IdCtaCble;

                InfoCliTip.IdUsuario = param.IdUsuario;
                InfoCliTip.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                InfoCliTip.nom_pc = param.nom_pc;
                InfoCliTip.ip = param.ip;
                if (chkestado.Checked == true)
                    InfoCliTip.estado = "A";
                else
                    InfoCliTip.estado = "I";
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
                InfoCliTip = new fa_cliente_tipo_Info();
                txtIdTipoCli.EditValue ="";
                txtDescripcion.EditValue = "";
                chkestado.Checked = false;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                chkestado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
