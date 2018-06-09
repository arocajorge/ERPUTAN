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
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_ActivoFijoTipo_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        Af_Activo_fijo_tipo_Info info;
        List<ct_Plancta_Info> listaPLan = new List<ct_Plancta_Info>();
        public delegate void delegate_frmAF_ActivoFijoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_ActivoFijoTipo_Mant_FormClosing event_frmAF_ActivoFijoTipo_Mant_FormClosing;
        string MensajeError = "";

        #endregion
        
        public frmAF_ActivoFijoTipo_Mant()
        {
            try
            {
            InitializeComponent();
            //load_tipo_plan_cta();
            event_frmAF_ActivoFijoTipo_Mant_FormClosing += new delegate_frmAF_ActivoFijoTipo_Mant_FormClosing(frmAF_ActivoFijoTipo_Mant_event_frmAF_ActivoFijoTipo_Mant_FormClosing);
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {              
                    if(guardarDatos())
                        this.Close();
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validar()
        {
            Boolean res = true;
            try
            {
               
                if (this.txt_descripcion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la descripción del Tipo Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_descripcion.Focus();
                    return false;
                }

                if (this.txt_porc_deprec.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el porcentaje de depreciación del Tipo Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_porc_deprec.Focus();
                    return false;
                }

                if (this.txt_anio_deprec.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el año de depreciación del Tipo Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_porc_deprec.Focus();
                    return false;
                }

                if (cmbPlanctaActivo.get_PlanCtaInfo().IdCtaCble == null)
                {
                    MessageBox.Show("Por Favor Seleccione Cuenta Contable Predeterminada para los Activos");
                    cmbPlanctaActivo.Focus();
                    return false;
                }
                if (cmbCtaDepreAcu.get_PlanCtaInfo().IdCtaCble == null)
                {
                    MessageBox.Show("Por Favor Seleccione Cuenta Contable Predeterminada para Depreciación Acumulada");
                    cmbCtaDepreAcu.Focus();
                    return false;
                }
                if (cmbCtaGasto.get_PlanCtaInfo().IdCtaCble == null)
                {
                    MessageBox.Show("Por Favor Seleccione Cuenta Contable Predeterminada para Gastos Depreciación");
                    cmbCtaGasto.Focus();
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean guardarDatos()
        {
            try
            {
                Af_Activo_fijo_tipo_Bus bus_act_fijo_tip = new Af_Activo_fijo_tipo_Bus();                 
                Boolean bolResult = false;
                int id = 0;
                string msg = "";
                if (Validar())
                {
                    get_ActivoFijoTipo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (bus_act_fijo_tip.GrabarDB(info, ref id, ref msg))
                            {
                                bolResult = true;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                LimpiarDatos();
                            }

                            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                            
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if(bus_act_fijo_tip.ModificarDB(info, ref msg))
                            {
                                bolResult = true;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                LimpiarDatos();
                            }
                            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                            break;
                    }
                }

                return bolResult;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        void LimpiarDatos()
        {
            try
            {
                info = new Af_Activo_fijo_tipo_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_Accion(_Accion);
                this.lbl_id_tipo.Text = "";
                this.txt_codigo.Text = "";
                this.txt_descripcion.Text = "";
                this.txt_porc_deprec.Text = "";
                this.txt_anio_deprec.Text = "";
                cmbPlanctaActivo.Inicializar_cmbPlanCta();
                cmbCtaDepreAcu.Inicializar_cmbPlanCta();
                cmbCtaGasto.Inicializar_cmbPlanCta();

                ucCon_CentroCosto_Activo.Inicializar_cmbCentroCosto();
                ucCon_CentroCosto_Depre.Inicializar_cmbCentroCosto();
                ucCon_CentroCosto_Gasto.Inicializar_cmbCentroCosto();

                this.chk_estado.Checked = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (info.IdActivoFijoTipo != 0)
                {
                    if (lblEstado.Visible == true)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema);
                    }
                    else
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el)+"#:" + info.IdActivoFijoTipo + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            info.IdUsuarioUltAnu = param.IdUsuario;
                            info.Fecha_UltAnu = DateTime.Now;
                            info.MotiAnula = ofrm.motivoAnulacion;

                            if (info.Estado == "A")
                            {
                                string msg = "";
                                Af_Activo_fijo_tipo_Bus bus_act_fij_tip = new Af_Activo_fijo_tipo_Bus();
                                if (bus_act_fij_tip.EliminarDB(info, ref msg))
                                    ucGe_Menu.Enabled_bntAnular = false;
                                MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblEstado.Visible = true;
                            }
                            else
                            {//msj0027_no_se_puede_anular_activo_fijo
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " Activo fijo #" + info.IdActivoFijoTipo + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmAF_ActivoFijoTipo_Mant_event_frmAF_ActivoFijoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_tipo_plan_cta()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_ActivoFijoTipo(Af_Activo_fijo_tipo_Info obj)
        {
            try
            {
                lbl_id_tipo.Text = obj.IdActivoFijoTipo.ToString();
                txt_codigo.Text = obj.CodActivoFijo;
                txt_descripcion.Text = obj.Af_Descripcion;
                txt_porc_deprec.Text = obj.Af_Porcentaje_depre.ToString();
                txt_anio_deprec.Text = obj.Af_anio_depreciacion.ToString();
                cmbPlanctaActivo.set_PlanCtarInfo(obj.IdCtaCble_Activo);
                cmbCtaDepreAcu.set_PlanCtarInfo(obj.IdCtaCble_Dep_Acum);
                cmbCtaGasto.set_PlanCtarInfo(obj.IdCtaCble_Gastos_Depre);

                ucCon_CentroCosto_Activo.set_item(obj.IdCentroCosto_Activo);
                ucCon_CentroCosto_Depre.set_item(obj.IdCentroCosto_Dep_Acum);
                ucCon_CentroCosto_Gasto.set_item(obj.IdCentroCosto_Gasto_Depre);

                chk_estado.Checked = (obj.Estado == "A") ? true : false; 
                lblEstado.Visible = (obj.Estado == "I") ? true : false;
                check_deprecia.Checked = Convert.ToBoolean(obj.Se_Deprecia);
                info = obj;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Af_Activo_fijo_tipo_Info get_ActivoFijoTipo()
        {
            try
            {
                info = new Af_Activo_fijo_tipo_Info();
                info.IdActivoFijoTipo = (this.lbl_id_tipo.Text != "") ? Convert.ToInt32(this.lbl_id_tipo.Text) : 0;
                info.CodActivoFijo = (this.txt_codigo.Text != "") ? this.txt_codigo.Text : " ";
                info.Af_Descripcion = (this.txt_descripcion.Text != "") ? this.txt_descripcion.Text : " ";
                info.Af_Porcentaje_depre = (this.txt_porc_deprec.Text != "") ? Convert.ToDouble(this.txt_porc_deprec.Text) : 0;
                info.Af_anio_depreciacion = (this.txt_anio_deprec.Text != "") ? Convert.ToInt32(this.txt_anio_deprec.Text) : 0;
                info.IdCtaCble_Activo = (cmbPlanctaActivo.get_PlanCtaInfo().IdCtaCble == "") ? null : Convert.ToString(cmbPlanctaActivo.get_PlanCtaInfo().IdCtaCble);
                info.IdCtaCble_Dep_Acum = (cmbCtaDepreAcu.get_PlanCtaInfo().IdCtaCble == "") ? null : Convert.ToString(cmbCtaDepreAcu.get_PlanCtaInfo().IdCtaCble);
                info.IdCtaCble_Gastos_Depre = (cmbCtaGasto.get_PlanCtaInfo().IdCtaCble == "") ? null : Convert.ToString(cmbCtaGasto.get_PlanCtaInfo().IdCtaCble);

                info.IdCentroCosto_Activo = (ucCon_CentroCosto_Activo.get_item() == "") ? null : Convert.ToString(ucCon_CentroCosto_Activo.get_item());
                info.IdCentroCosto_Dep_Acum = (ucCon_CentroCosto_Depre.get_item() == "") ? null : Convert.ToString(ucCon_CentroCosto_Depre.get_item());
                info.IdCentroCosto_Gasto_Depre = (ucCon_CentroCosto_Gasto.get_item() == "") ? null : Convert.ToString(ucCon_CentroCosto_Gasto.get_item());
                info.Se_Deprecia = check_deprecia.Checked;
                info.Estado = (this.chk_estado.Checked)? "A" : "I" ;
                info.IdEmpresa = param.IdEmpresa;
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Af_Activo_fijo_tipo_Info();
            }
            
        }

        private void frmAF_ActivoFijoTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        AsignarParametros();
                        ucGe_Menu.Enabled_bntAnular = false;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        lbl_title_id_tipo.Visible = true;
                        lbl_id_tipo.Visible = true;
                        //txt_codigo.ReadOnly = true;
                        txt_descripcion.Enabled = true;
                        txt_porc_deprec.Enabled = true;
                        txt_anio_deprec.Enabled = true;
                        chk_estado.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;                        
                        lbl_title_id_tipo.Visible = true;
                        lbl_id_tipo.Visible = true;
                        //txt_codigo.Enabled = false;
                        txt_descripcion.Enabled = false;
                        cmbPlanctaActivo.Enabled = false;
                        txt_porc_deprec.Enabled = false;
                        txt_anio_deprec.Enabled = false;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        lbl_title_id_tipo.Visible = true;
                        lbl_id_tipo.Visible = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        void AsignarParametros()
        {
            try
            {
                Af_Parametros_Bus busParam = new Af_Parametros_Bus();
                Af_Parametros_Info infoParam = new Af_Parametros_Info();
                infoParam = busParam.Get_Info_Parametros(param.IdEmpresa);
                cmbPlanctaActivo.set_PlanCtarInfo(infoParam.IdCtaCble_Activo);
                cmbCtaDepreAcu.set_PlanCtarInfo(infoParam.IdCtaCble_Dep_Acum);
                cmbCtaGasto.set_PlanCtarInfo(infoParam.IdCtaCble_Gastos_Depre);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_anio_deprec_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_porc_deprec_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_porc_deprec.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_porc_deprec_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(this.txt_porc_deprec.Text) > 100)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Porcentaje_de_depreciacion_mayor_a_100), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_porc_deprec.Text = "";
                    this.txt_porc_deprec.Focus();
                }
                else
                {
                    Funciones f = new Funciones();
                    txt_porc_deprec.Text = f.Format_text_2_decimales(txt_porc_deprec.Text);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmAF_ActivoFijoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_ActivoFijoTipo_Mant_event_frmAF_ActivoFijoTipo_Mant_FormClosing(sender,e);
                event_frmAF_ActivoFijoTipo_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPlancta_Validated(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
