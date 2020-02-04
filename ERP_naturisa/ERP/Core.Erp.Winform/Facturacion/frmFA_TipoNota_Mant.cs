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
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_TipoNota_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        fa_TipoNota_Info info = new fa_TipoNota_Info();
        fa_TipoNota_Bus bus = new fa_TipoNota_Bus();
        string MensajeError = "";
        #endregion

        public frmFa_TipoNota_Mant()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
              ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
              ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new fa_TipoNota_Info();
                this.lbl_id_tipo_nota.Text = "";
                this.txt_codigo.Text = "";
                this.txt_descripcion.Text = "";
                this.txt_nemonico.Text = "";
                this.chk_interno.Checked = true;
                this.chk_declara.Checked = true;
                this.chk_estado.Checked = true;
                
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
                if (guardarDatos())
                {
                    this.Close();
                }     

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
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Anular();
                    this.Close();
                    this.Dispose();
                }
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
                Close();
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
                guardarDatos();
                  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean guardarDatos()
        {
            try
            {
                Boolean bolReult = false;
                fa_TipoNota_Bus bus_tiponota = new fa_TipoNota_Bus();
                int id = 0;
                string msg = "";
                if (validarDatos())
                {
                    get_TipoNota();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (bus_tiponota.GrabarDB(info, ref id, ref msg))
                            {
                                bolReult = true;
                               // MessageBox.Show("Registro guardado exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lbl_id_tipo_nota.Text = Convert.ToString(id);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El tipo de Nota", id);
                                MessageBox.Show(smensaje, param.Nombre_sistema);      
                                //ucGe_Menu.Visible_btnGuardar = false;
                                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show("Error " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (bus_tiponota.ModificarDB(info, ref msg))
                            {
                                bolReult = true;
                               // MessageBox.Show("Registro modificado exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El tipo de Nota", info.IdTipoNota);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                //ucGe_Menu.Visible_btnGuardar = false;
                                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show("Error " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            break;               

                    }
                }
                return bolReult;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
        }


        private Boolean validarDatos()
        {
            try
            {
                if (txt_descripcion.Text == "" || txt_descripcion.Text == null)
                {
                    MessageBox.Show("Por favor ingrese la Descripcion del Tipo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string mensaje = "";
                if (lblEstado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular Tipo de Nota ?", "Anulación de Tipo de Nota  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        info.IdUsuarioUltAnu = param.IdUsuario;
                        info.MotiAnula = ofrm.motivoAnulacion;

                        if (bus.EliminarDB(info, ref mensaje))
                        {
                          //  MessageBox.Show("Tipo de Nota # " + info.IdTipoNota + " ANULADA SATISFACTORIAMENTE", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El tipo de Nota", info.IdTipoNota);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            lblEstado.Visible = true;
                            resultB = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al ANULAR TIPO DE NOTA verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            resultB = false;
                        }
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        private void load_tipo_plan_cta()
        {
            try
            {
                ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
                listaPlan = _PlanCta_bus1.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_tipo_nota_combo()
        {
            try
            {
                List<fa_TipoNota_Combo_Info> lista_combo = new List<fa_TipoNota_Combo_Info>();
                fa_TipoNota_Combo_Info info_tp = new fa_TipoNota_Combo_Info();
                info_tp.IdTipoNota = "C";
                info_tp.TipoNota = "Crédito";
                lista_combo.Add(info_tp);
                info_tp = new fa_TipoNota_Combo_Info();
                info_tp.IdTipoNota = "D";
                info_tp.TipoNota = "Débito";
                lista_combo.Add(info_tp);

                this.cmb_tipo.DataSource = lista_combo;
                this.cmb_tipo.DisplayMember = "TipoNota";
                this.cmb_tipo.ValueMember = "IdTipoNota";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_TipoNota(fa_TipoNota_Info info_tp)
        {
            try
            {
                this.lbl_id_tipo_nota.Text = info_tp.IdTipoNota.ToString();
                this.txt_codigo.Text = info_tp.CodTipoNota;
                this.txt_descripcion.Text = info_tp.no_Descripcion;
                this.cmb_tipo.SelectedValue = info.Tipo;
                //this.cmb_plancta.Value = info.IdCtaCble;
                this.txt_nemonico.Text = info_tp.Nemonico;
                this.chk_interno.Checked = (info_tp.InternoSis=="S")?true:false;
                this.chk_declara.Checked = (info_tp.SeDeclaraSRI=="S")?true:false;
                this.chk_estado.Checked = (info_tp.Estado == "A") ? true : false;
                lblEstado.Visible = (info_tp.Estado == "I") ? true : false;
                info = info_tp;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public fa_TipoNota_Info get_TipoNota()
        {
            try
            {
                info.IdEmpresa = param.IdEmpresa;
                info.IdTipoNota = (this.lbl_id_tipo_nota.Text != "") ? Convert.ToInt32(this.lbl_id_tipo_nota.Text) : 0;
                info.CodTipoNota = this.txt_codigo.Text;
                info.no_Descripcion = this.txt_descripcion.Text;
                info.Tipo = this.cmb_tipo.SelectedValue.ToString();
                //info.IdCtaCble = (cmb_plancta.SelectedIndex != -1) ? this.cmb_plancta.Value.ToString() : "1";
                info.Nemonico = this.txt_nemonico.Text;
                info.InternoSis = (this.chk_interno.Checked==true)?"S":"N";
                info.SeDeclaraSRI = (this.chk_declara.Checked==true)?"S":"N";
                info.Estado = (this.chk_estado.Checked==true)?"S":"N";
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
              
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new fa_TipoNota_Info();
            }
        }

        private void cmb_plancta_Validated(object sender, EventArgs e)
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

        private void frmFA_TipoNota_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                load_tipo_plan_cta();
                load_tipo_nota_combo();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmb_tipo.Enabled = false;
                        txt_codigo.Enabled = false;
                        set_TipoNota(info);
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        cmb_tipo.Enabled = false;
                        txt_codigo.Enabled = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        set_TipoNota(info);
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        cmb_tipo.Enabled = false;
                        txt_codigo.Enabled = false;
                        set_TipoNota(info);
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
