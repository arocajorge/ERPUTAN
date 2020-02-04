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
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_GrupoEmpresarial_plancta : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_GrupoEmpresarial_plancta_Bus PlanCta_B = new ct_GrupoEmpresarial_plancta_Bus();
        List<ct_GrupoEmpresarial_plancta_Info> listaPlan = new List<ct_GrupoEmpresarial_plancta_Info>();
        ct_GrupoEmpresarial_plancta_Bus _PlanCta_bus = new ct_GrupoEmpresarial_plancta_Bus();
        int PrimerNivel;
        ct_GrupoEmpresarial_plancta_Info _PlanCta_info = new ct_GrupoEmpresarial_plancta_Info();
        ct_GrupoEmpresarial_plancta_nivel_Bus NivelCta_bus = new ct_GrupoEmpresarial_plancta_nivel_Bus();
        List<ct_GrupoEmpresarial_plancta_nivel_Info> LstNivelCta = new List<ct_GrupoEmpresarial_plancta_nivel_Info>();
        ct_GrupoEmpresarial_grupocble_Info GrupoCtble_I = new ct_GrupoEmpresarial_grupocble_Info();
        int Maxlen = 0;
        int ultimoNivel = 0;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion
       
        public frmCon_GrupoEmpresarial_plancta()
        {
            InitializeComponent();
            try
            {
                ct_GrupoEmpresarial_grupocble_Bus _GrupoCbleB = new ct_GrupoEmpresarial_grupocble_Bus();
                
                cmb_grupocbtle.DataSource = _GrupoCbleB.Get_list_GrupoEmpresarial_grupocble();
                cmb_grupocbtle.DisplayMember = "gc_GrupoCble_gr";
                cmb_grupocbtle.ValueMember = "IdGrupoCble_gr";


                LstNivelCta = NivelCta_bus.Get_list_GrupoEmpresarial_plancta_nivel();

                if (LstNivelCta == null || LstNivelCta.Count() == 0)
                {
                    MessageBox.Show("No puede continuar, antes debe ingresar los Nivele del plan de Cuenta , Falta ingresar los Niveles del Plan de Cuenta.. \nIngréselos desde la pantalla de parámetros de Contabilidad,o comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Parent.Dispose();
                }

                if (LstNivelCta.Count() > 0)
                {
                    PrimerNivel = LstNivelCta.Select(y => y.IdNivelCta_gr).Min(); // LstNivelCta.Where(c => c.Estado == "A").Select(y => y.IdNivelCta).Min();
                    ultimoNivel = LstNivelCta.Select(y => y.IdNivelCta_gr).Max();

                    lblnivelcuenta.Text = Convert.ToString(PrimerNivel);
                    var xd = LstNivelCta.Where(c => c.IdNivelCta_gr == PrimerNivel).Select(y => y.nv_NumDigitos_gr).First();
                    txt_id.MaxLength = (xd == null) ? 1 : Convert.ToInt32(xd);
                    cmb_naturaleza.SelectedIndex = 0;

                    listaPlan = PlanCta_B.Get_list_GrupoEmpresarial_plancta();

                    //menos los que son ultimo nivel     listaPlan
                    cmbPlancta.Properties.DataSource = listaPlan.FindAll(v => v.IdNivelCta_gr != ultimoNivel);
                    cmbPlancta.Properties.DisplayMember = "pc_Cuenta_gr";
                    cmbPlancta.Properties.ValueMember = "IdCuenta_gr";
                }
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

                        chk_activo.Checked = true;
                        chk_activo.Enabled = false;
                        cmb_naturaleza.SelectedItem = 1;
                        ucGe_Menu.Visible_bntAnular = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmbPlancta.Properties.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        txt_id.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

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

        public void set_PlanCta(ct_GrupoEmpresarial_plancta_Info _PlanCtaInfo)
        {
            try
            {
                this.txt_id.Text = _PlanCtaInfo.IdCuenta_gr.ToString();
                cmbPlancta.EditValue = _PlanCtaInfo.IdCuentaPadre_gr.ToString();
                txt_cuenta.Text = _PlanCtaInfo.pc_Cuenta_gr.ToString();
                lblctapadre.Text = _PlanCtaInfo.IdCuentaPadre_gr.ToString();
                cmb_naturaleza.SelectedIndex = (_PlanCtaInfo.pc_Naturaleza == "D") ? 0 : 1;
                lblnivelcuenta.Text = _PlanCtaInfo.IdNivelCta_gr.ToString();
                cmb_grupocbtle.SelectedValue = _PlanCtaInfo.IdGrupoCble_gr.ToString();
                chk_activo.Checked = (_PlanCtaInfo.pc_Estado.ToString() == "A") ? true : false;
                chk_movimiento.Checked = (_PlanCtaInfo.pc_EsMovimiento.ToString() == "S") ? true : false;
               lbl_id_new.Text = txt_id.Text;
               this.txt_id.Text = this.txt_id.Text.Substring(lblctapadre.Text.Trim().Length, txt_id.Text.Trim().Length - lblctapadre.Text.Trim().Length);
                _PlanCta_info = _PlanCtaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_GrupoEmpresarial_plancta_Info get_PlanCta()
        {
            try
            {
                _PlanCta_info.pc_Cuenta_gr = txt_cuenta.Text;
                _PlanCta_info.IdCuenta_gr = lblctapadre.Text.Trim() + txt_id.Text.ToString().Trim();
                _PlanCta_info.IdCuentaPadre_gr = lblctapadre.Text;
                _PlanCta_info.IdNivelCta_gr = Convert.ToInt32(lblnivelcuenta.Text);
                GrupoCtble_I = (ct_GrupoEmpresarial_grupocble_Info)cmb_grupocbtle.SelectedItem;//ct_GrupoEmpresarial_grupocble_Info//ct_Grupocble_Info
                _PlanCta_info.IdGrupoCble_gr = GrupoCtble_I.IdGrupoCble_gr;
                _PlanCta_info.pc_Naturaleza = (cmb_naturaleza.SelectedItem.ToString().Trim() == "DEUDOR") ? "D" : "C";
                _PlanCta_info.pc_Estado = (chk_activo.Checked) ? "A" : "I";
                _PlanCta_info.pc_EsMovimiento = (chk_movimiento.Checked) ? "S" : "N";
             
                return _PlanCta_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_GrupoEmpresarial_plancta_Info();
            }
        }

        private bool validacion()
        {
            try
            {
                bool estado = true;


                if (txt_id.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Por favor Ingrese el Codigo de la Cuenta...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_cuenta.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Por favor Ingrese el Nombre de la Cuenta...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (GrupoCtble_I == null)
                {
                    MessageBox.Show("Por favor Seleccione el Grupo Contable...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

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
                get_PlanCta();
                if (validacion())
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (_PlanCta_bus.GrabarDB(_PlanCta_info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Plan de cuenta ", txt_cuenta.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se Guardo el Plan de cuenta " + this.txt_cuenta.Text + " correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();

                        }
                        else
                        {
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        _PlanCta_bus.ModificarDB(_PlanCta_info);
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Plan de cuenta ", this.txt_cuenta.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Se Actualizo el Plan de cuenta " + this.txt_cuenta.Text + " correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                        LimpiarDatos();
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (_PlanCta_bus.EliminarDB(_PlanCta_info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Plan de cuenta", this.txt_cuenta.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se Anulo el Plan de cuenta");
                            chk_activo.Checked = false;
                        }
                        else { MessageBox.Show("No se puede Anular la Cuenta porque contiene Cuentas hijas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void set_CuandoesNuevo(ct_GrupoEmpresarial_plancta_Info info)
        {
            try
            {
                if (info != null)
                {
                    cmbPlancta.EditValue = info.IdCuenta_gr;

                    ct_GrupoEmpresarial_plancta_Info _PlanCta_info = new ct_GrupoEmpresarial_plancta_Info();
                    _PlanCta_info = info;

                    var tb = from C in listaPlan
                             where C.IdCuenta_gr == Convert.ToString(cmbPlancta.EditValue)
                             select C;

                    foreach (var item in tb)
                    {
                        _PlanCta_info = item;
                    }

                    this.txt_id.Text = _PlanCta_info.IdCuenta_gr.ToString();
                    this.txt_cuenta.Text = _PlanCta_info.pc_Cuenta_gr.ToString();
                    lblnivelcuenta.Text = (_PlanCta_info.IdNivelCta_gr + 1).ToString();
                    cmb_naturaleza.SelectedIndex = (_PlanCta_info.pc_Naturaleza == "D") ? 0 : 1;
                    cmb_grupocbtle.SelectedValue = _PlanCta_info.IdGrupoCble_gr;


                    lblctapadre.Text = _PlanCta_info.IdCuenta_gr.ToString();

                    this.txt_id.Text = _PlanCta_bus.Get_IdCta(lblctapadre.Text, _PlanCta_info.IdNivelCta_gr, ref Maxlen);
                    this.lbl_id_new.Text = this.txt_id.Text;
                  

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_GrupoEmpresarial_plancta_Load(object sender, EventArgs e)
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

        private void cmbPlancta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    ct_GrupoEmpresarial_plancta_Info _PlanCta_info = new ct_GrupoEmpresarial_plancta_Info();

                    var tb = from C in listaPlan
                             where C.IdCuenta_gr == Convert.ToString(cmbPlancta.EditValue)
                             select C;

                    foreach (var item in tb)
                    {
                        _PlanCta_info = item;
                    }
                    
                    txt_cuenta.Text = _PlanCta_info.pc_Cuenta_gr.ToString();
                    lblnivelcuenta.Text = (_PlanCta_info.IdNivelCta_gr + 1).ToString();
                    chk_movimiento.Checked = ((_PlanCta_info.IdNivelCta_gr + 1) == ultimoNivel) ? true : false;
                    chk_movimiento.Visible = ((_PlanCta_info.IdNivelCta_gr + 1) == ultimoNivel) ? true : false;

                    cmb_naturaleza.SelectedValue = _PlanCta_info.pc_Naturaleza;
                    cmb_grupocbtle.SelectedValue = _PlanCta_info.IdGrupoCble_gr;

                    lblctapadre.Text = _PlanCta_info.IdCuenta_gr.ToString();

                    this.txt_id.Text = _PlanCta_bus.Get_IdCta(lblctapadre.Text, _PlanCta_info.IdNivelCta_gr, ref Maxlen);
                    txt_id.MaxLength = Maxlen;
                    this.lbl_id_new.Text = this.txt_id.Text;
                }
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (validacion())
                {
                    Grabar();
                    Close();
                }
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
                _PlanCta_info = new ct_GrupoEmpresarial_plancta_Info();
                txt_cuenta.Text = "";
                lblctapadre.Text = "";
                txt_id.Text = "";                
                lblnivelcuenta.Text = "";
                chk_activo.Checked = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
