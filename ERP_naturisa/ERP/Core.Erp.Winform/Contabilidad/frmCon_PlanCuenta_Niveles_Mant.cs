using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_PlanCuenta_Niveles_Mant : Form
    {
        #region Declaración de variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        public ct_Plancta_nivel_Info _PlanCtaNivel_info = new ct_Plancta_nivel_Info();
        public ct_Plancta_nivel_Bus _PlanCtaNivel_bus = new ct_Plancta_nivel_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<ct_Plancta_nivel_Info> listaPlanCtaNivel = new List<ct_Plancta_nivel_Info>();
        public delegate void delegate_frmCon_PlanCuenta_Niveles_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_PlanCuenta_Niveles_Mant_FormClosing event_frmCon_PlanCuenta_Niveles_Mant_FormClosing;

        #endregion

        public frmCon_PlanCuenta_Niveles_Mant()
        {
            InitializeComponent();
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
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
                Eliminar();
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
                Procesar();
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
                Procesar();
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

        public void set_PlanCtaNivel(ct_Plancta_nivel_Info _PlanCtaNivelInfo)
        {
            try
            {
                this.txt_id.Text = _PlanCtaNivelInfo.IdNivelCta.ToString();
                this.num_dig.EditValue = _PlanCtaNivelInfo.nv_NumDigitos;
                this.txt_descripcion.Text = _PlanCtaNivelInfo.nv_Descripcion;
                this.chk_estado.Checked = (_PlanCtaNivelInfo.Estado == "I") ? false : true;
                lblAnulado.Visible = (_PlanCtaNivelInfo.Estado == "I") ? true : false;

                _PlanCtaNivel_info = _PlanCtaNivelInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        public ct_Plancta_nivel_Info get_PlanCtaNivel()
        {
            try
            {
                _PlanCtaNivel_info.IdEmpresa = param.IdEmpresa;
                _PlanCtaNivel_info.IdNivelCta = Convert.ToInt32(txt_id.Text);
                _PlanCtaNivel_info.nv_NumDigitos = Convert.ToInt32(num_dig.EditValue);
                _PlanCtaNivel_info.nv_Descripcion = txt_descripcion.Text;
                _PlanCtaNivel_info.Estado = (chk_estado.Checked == false) ? "I" : "A";
                return _PlanCtaNivel_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return new ct_Plancta_nivel_Info();
            }

        }

        private void Grabar()
        {
            try
            {
                get_PlanCtaNivel();

                if (_PlanCtaNivel_bus.GrabarDB(_PlanCtaNivel_info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Nivel ", _PlanCtaNivel_info.IdNivelCta);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }

        private void Modificar()
        {
            try
            {
                get_PlanCtaNivel();

                if (_PlanCtaNivel_bus.ModificarDB(_PlanCtaNivel_info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Nivel ", _PlanCtaNivel_info.IdNivelCta);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void Eliminar()
        {
            try
            {
                get_PlanCtaNivel();

                if (_PlanCtaNivel_info.IdNivelCta != 0)
                {
                    if (lblAnulado.Visible == true)
                    {
                        MessageBox.Show("El registro ya se encuentra Anulado");
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Nivel #: " + _PlanCtaNivel_info.IdNivelCta + " ?", "ANULACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            _PlanCtaNivel_info.IdUsuarioUltAnu = param.IdUsuario;
                            _PlanCtaNivel_info.Fecha_UltAnu = DateTime.Now;
                            _PlanCtaNivel_info.MotivoAnulacion = ofrm.motivoAnulacion;


                            if (_PlanCtaNivel_bus.AnularDB(_PlanCtaNivel_info))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Nivel ", _PlanCtaNivel_info.IdNivelCta);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                chk_estado.Checked = false;
                                ucGe_Menu.Visible_bntAnular = false;
                                lblAnulado.Visible = true;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                        }
                    }
                    
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);

              

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }


        }

        void Procesar()
        {
            try
            {
                get_PlanCtaNivel();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Eliminar();
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

        private void frmCon_PlanCuenta_Niveles_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                listaPlanCtaNivel = _PlanCtaNivel_bus.Get_list_Plancta_nivel(param.IdEmpresa);

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.txt_id.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.txt_id.Enabled = false;
                        this.num_dig.Enabled = false;
                        this.txt_descripcion.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.txt_id.Enabled = false;
                        this.num_dig.Enabled = false;
                        this.txt_descripcion.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
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

        private void txt_id_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validate_id();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private Boolean validate_num_digitos()
        {
            try
            {
                Boolean bstatus;
                if (Convert.ToInt32(num_dig.EditValue) == 0)
                {
                    error.SetError(num_dig, "Numero de digitos de niveles en cero");
                    bstatus = false;
                }
                else
                {
                    bstatus = true;
                }
                return bstatus;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }

        }

        private Boolean validate_id()
        {
            try
            {
                Boolean bstatus;
                if (txt_id.Text == "")
                {
                    error.SetError(txt_id, "Por favor ingrese el Id de Plan de Cuenta de Niveles");
                    bstatus = false;
                }
                else
                {
                    int item = listaPlanCtaNivel.Max(q => q.IdNivelCta);

                    int idenBase = item + 1;
                    int idTexBox = Convert.ToInt32(txt_id.Text);

                    if (idenBase == idTexBox)
                    {
                        bstatus = true;
                    }
                    else
                    {

                        MessageBox.Show("El nivel máximo grabado en la Base es : [" + item + "], debe seguir la secuencia", "SISTEMAS");
                        bstatus = false;
                    }
                }
                return bstatus;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }

        }

        private void frmCon_PlanCuenta_Niveles_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_PlanCuenta_Niveles_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void num_dig_Validating_1(object sender, CancelEventArgs e)
        {
            try
            {
                validate_num_digitos();
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
                _PlanCtaNivel_info = new ct_Plancta_nivel_Info();
                
                txt_id.Text = "";
                num_dig.EditValue ="";
                txt_descripcion.Text = "";
                chk_estado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
