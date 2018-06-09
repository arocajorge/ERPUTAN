using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Contabilidad
{
    public class frmCon_CentroCosto_SubCentroCosto_Mant_Handler
    {

        #region Declaracion de controles
        public System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        public Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        public System.Windows.Forms.GroupBox groupbox_datos;
        public System.Windows.Forms.CheckBox ckbActivo;
        public System.Windows.Forms.Label lblAnulado;
        public DevExpress.XtraEditors.TextEdit txtCentroCosto;
        public DevExpress.XtraEditors.TextEdit txtIdSubCentro;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_ctacble;
        public Controles.UCCon_CentroCosto_ctas_Movi cmbCentroCosto;
        public Controles.UCAF_Activo_Fijo ucaF_Activo_Fijo1;
        #endregion

        #region Variables y atributos
        
        int C = 0;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        ct_Plancta_Bus Bus_Plancta = new ct_Plancta_Bus();
        ct_centro_costo_sub_centro_costo_Info Info_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Info();
        List<ct_Plancta_Info> lst_PlanCta = new List<ct_Plancta_Info>();
        List<ct_Centro_costo_Info> lst_CentroCosto = new List<ct_Centro_costo_Info>();
        public delegate void delegate_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
        public Cl_Enumeradores.eTipo_action enu { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        public ct_centro_costo_sub_centro_costo_Info SetInfo { get; set; }
        Cl_Enumeradores.eCliente_Vzen eCliente;
        

        #endregion

        Form frmChildren;
        Form frmParent;
        Boolean Asociar_Activo_fijo = false;

        #region Set
        public void Set_frmChildren(Form _frmChildren)
        {
            try
            {
                frmChildren = _frmChildren;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_frmParent(Form _frmParent)
        {
            try
            {
                frmParent = _frmParent;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        public void Set_Cliente_VZEN(Cl_Enumeradores.eCliente_Vzen _eCliente)
        {
            try
            {
                eCliente = _eCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion  

        public frmCon_CentroCosto_SubCentroCosto_Mant_Handler()
        {
            if (eCliente==0)
            {
                eCliente = Cl_Enumeradores.eCliente_Vzen.GENERAL;
            }
        }

        public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                frmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    frmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                {
                    limpiar();  
                } 
                Info_SubCentroCosto.cod_subcentroCosto = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void limpiar()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Info();

                //cmbCentroCosto.EditValue = null;                
                //cmb_ctacble.EditValue = null;
                txtIdSubCentro.Text = "";
                txtCentroCosto.Text = "";
                cmbCentroCosto.Inicializar_cmbCentroCosto();
                cmb_ctacble.set_IdCtaCble(null);
                ckbActivo.Checked = true;
                if (eCliente==Cl_Enumeradores.eCliente_Vzen.FJ)
                {
                    //info_scc_x_af = new ct_centro_costo_sub_centro_costo_x_Af_Activo_fijo_Info();
                    ucaF_Activo_Fijo1.InicializarActivoFijo();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {

                }
                if (C == 4)
                {

                    cmbCentroCosto.Enabled = false;
                    cmbCentroCosto.BackColor = System.Drawing.Color.White;
                    cmbCentroCosto.ForeColor = System.Drawing.Color.Black;

                    txtIdSubCentro.Enabled = false;
                    txtIdSubCentro.BackColor = System.Drawing.Color.White;
                    txtIdSubCentro.ForeColor = System.Drawing.Color.Black;


                    txtCentroCosto.Enabled = false;
                    txtCentroCosto.BackColor = System.Drawing.Color.White;
                    txtCentroCosto.ForeColor = System.Drawing.Color.Black;

                    cmb_ctacble.Enabled = false;
                    cmb_ctacble.BackColor = System.Drawing.Color.White;
                    cmb_ctacble.ForeColor = System.Drawing.Color.Black;

                    ckbActivo.Enabled = false;
                    ckbActivo.BackColor = System.Drawing.Color.White;
                    ckbActivo.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {


                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void GetSubCentroCosto()
        {
            try
            {
                Info_SubCentroCosto.IdEmpresa = param.IdEmpresa;
                Info_SubCentroCosto.IdCentroCosto = cmbCentroCosto.Get_IdCentroCosto();
                Info_SubCentroCosto.IdCentroCosto_sub_centro_costo = Convert.ToString(this.txtIdSubCentro.EditValue);
                Info_SubCentroCosto.Centro_costo = Convert.ToString(this.txtCentroCosto.EditValue);
                Info_SubCentroCosto.pc_Estado = (ckbActivo.Checked == true) ? "A" : "I";
                if (cmb_ctacble.get_CuentaInfo() != null)
                    Info_SubCentroCosto.IdCtaCble = cmb_ctacble.get_CuentaInfo().IdCtaCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmCon_CentroCosto_SubCentroCosto_Mant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void SetSubCentroCosto()
        {
            try
            {
                this.cmbCentroCosto.set_IdCentroCosto(SetInfo.IdCentroCosto);
                this.txtIdSubCentro.EditValue = SetInfo.IdCentroCosto_sub_centro_costo;
                this.txtCentroCosto.EditValue = SetInfo.Centro_costo;
                this.cmb_ctacble.set_IdCtaCble(SetInfo.IdCtaCble);

                if (eCliente==Cl_Enumeradores.eCliente_Vzen.FJ)
                {
                    //info_scc_x_af = bus_scc_x_af.Get_Info_x_scc(param.IdEmpresa, SetInfo.IdCentroCosto, SetInfo.IdCentroCosto_sub_centro_costo);
                    //ucaF_Activo_Fijo1.setId_Activo_fijo(info_scc_x_af.IdActivoFijo_af);
                }

                if (SetInfo.pc_Estado == "I")
                {
                    this.ckbActivo.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    this.ckbActivo.Checked = true;
                    lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public Boolean grabar()
        {
            try
            {
                Boolean bolResult = true;
                txtIdSubCentro.Focus();
                GetSubCentroCosto();
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        string ver = "";
                        string variable = (this.txtIdSubCentro.Text).TrimEnd();
                        bolResult = Guardar();
                        if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                        {
                            if (bolResult)
                            {
                                if (Asociar_Activo_fijo)
                                {
                                    //Get_scc_x_af();
                                    //bus_scc_x_af.GuardarDB(info_scc_x_af);    
                                }
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        bolResult = Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        Anular();
                        break;
                    default:
                        break;
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean Guardar()
        {
            try
            {
                Boolean var = Validar();
                if (var == true)
                {

                    if (Bus_SubCentroCosto.GrabarDB(Info_SubCentroCosto))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El sub centro de costo ", Info_SubCentroCosto.IdCentroCosto_sub_centro_costo);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Se ha guardado con éxito el sub centro de costo : " + Info_SubCentroCosto.IdCentroCosto_sub_centro_costo, param.Nombre_sistema);
                        txtIdSubCentro.Text = Info_SubCentroCosto.IdCentroCosto_sub_centro_costo;
                        var = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar el sub centro de costo", param.Nombre_sistema);
                        var = false;
                    }
                }

                return var;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        public Boolean Actualizar()
        {
            try
            {
                if (Bus_SubCentroCosto.ModificarDB(Info_SubCentroCosto))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El sub centro de costo ", Info_SubCentroCosto.IdCentroCosto_sub_centro_costo);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Se ha actualizado con éxito el sub centro de costo : " + Info_SubCentroCosto.IdCentroCosto_sub_centro_costo ,param.Nombre_sistema);
                    limpiar();
                }
                else { MessageBox.Show("Problemas al actualizar el sub centro de costo", param.Nombre_sistema); return false; }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void Anular()
        {
            try
            {
                if (Bus_SubCentroCosto.AnularDB(Info_SubCentroCosto))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, "El registro ", Info_SubCentroCosto.IdCentroCosto_sub_centro_costo);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Registro anulado con éxito", param.Nombre_sistema);
                    lblAnulado.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error al Anular", param.Nombre_sistema);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (this.cmbCentroCosto.Get_IdCentroCosto() == "")
                {
                    MessageBox.Show("Ingrese el centro de costo", param.Nombre_sistema);
                    return false;
                }
                else
                {

                    if (this.txtCentroCosto.EditValue == null)
                    {
                        MessageBox.Show("Ingrese la descripción", param.Nombre_sistema);
                        return false;
                    }
                    else
                    {
                        if (this.cmb_ctacble.get_CuentaInfo() == null)
                        {
                            MessageBox.Show("Ingrese la Cuenta Contable", param.Nombre_sistema);
                            return false;
                        }
                    }
                }
                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                {
                    //if (ucaF_Activo_Fijo1.Get_Activo_fijo().IdActivoFijo != 0)
                    //{
                    //    //Get_scc_x_af();
                    //    //if (res == false)
                    //    //{
                    //    //    MessageBox.Show("El activo fijo ya se encuentra relacionado al centro de costo seleccionado", param.Nombre_sistema);
                    //    //    return false;
                    //    //}
                    //    //else
                    //        Asociar_Activo_fijo = true;
                    //}
                    //else
                    //    Asociar_Activo_fijo = false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void frmCon_CentroCosto_SubCentroCosto_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (eCliente==Cl_Enumeradores.eCliente_Vzen.FJ)
                {
                    ucaF_Activo_Fijo1.Cargar_Combo();
                }

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);
                        txtIdSubCentro.Focus();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        C = 3;
                        Inhabilita_Campos(C);
                        SetSubCentroCosto();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        C = 4;
                        Inhabilita_Campos(C);
                        SetSubCentroCosto();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        C = 4;
                        Inhabilita_Campos(C);
                        SetSubCentroCosto();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cmbCentroCosto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (enu == Info.General.Cl_Enumeradores.eTipo_action.grabar && Info_SubCentroCosto != null)
                {
                    txtIdSubCentro.Text = Info_SubCentroCosto.IdCentroCosto + Bus_SubCentroCosto.GetIdSubCentroCosto(param.IdEmpresa);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
