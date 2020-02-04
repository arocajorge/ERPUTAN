using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.CuentasxPagar

{
    public partial class frmCP_MantCodigoSRI : Form
    {
        #region Variables
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        UCCp_Tipo_codigo_SRI UCTC = new UCCp_Tipo_codigo_SRI();
        cp_codigo_SRI_Info codSRI_inf = new cp_codigo_SRI_Info();
        cp_codigo_SRI_tipo_Info tipoCodSRI = new cp_codigo_SRI_tipo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_codigo_SRI_Bus codSRI_Bus = new cp_codigo_SRI_Bus();
        cp_codigo_SRI_x_CtaCble_Bus codcta = new cp_codigo_SRI_x_CtaCble_Bus();
        cp_codigo_SRI_x_CtaCble_Bus cp_codigo_SRI_x_CtaCble = new cp_codigo_SRI_x_CtaCble_Bus();
        List<cp_codigo_SRI_x_CtaCble_Info> listInfo = new List<cp_codigo_SRI_x_CtaCble_Info>();               
        int id = 0;
        string MensajeError = "";
        #endregion

        public frmCP_MantCodigoSRI()
        {
            try
            {
                InitializeComponent();
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
                _Accion =Cl_Enumeradores.eTipo_action.grabar;

                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;

                txt_id.Text="";
                cmb_tipCodSRI.EditValue=null;
                txt_cod_SRI.Text="";
                txt_cod_base.Text="";
                txt_descripcion.Text="";
                dtp_valiDesde.Value=DateTime.Now;
                dtp_valiHasta.Value=DateTime.Now;

                ucCtaCble.Inicializar_cmbPlanCta();

            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_MantCodigo_SRI_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void cargar_Combo()
        {
            try
            {

                cp_codigo_SRI_tipo_Bus CatBus = new cp_codigo_SRI_tipo_Bus();
                List<cp_codigo_SRI_tipo_Info> tipo_Codigo_SRI = new List<cp_codigo_SRI_tipo_Info>();


                tipo_Codigo_SRI = CatBus.Get_List_codigo_SRI_tipo();
                
                this.cmb_tipCodSRI.Properties.DataSource = tipo_Codigo_SRI;
                this.cmb_tipCodSRI.Properties.DisplayMember = "descripcion";
                this.cmb_tipCodSRI.Properties.ValueMember = "IdTipoSRI";
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
                        chk_estado.Enabled = false;
                        chk_estado.Checked = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        cmb_tipCodSRI.Enabled = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txt_cod_base.Enabled = false;
                        txt_cod_SRI.Enabled = false;
                        txt_descripcion.Enabled = false;
                        txt_retencion.Enabled = false;
                        chk_estado.Enabled = false;
                        dtp_valiDesde.Enabled = false;
                        dtp_valiHasta.Enabled = false;
                        cmb_tipCodSRI.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txt_cod_base.Enabled = false;
                        txt_cod_SRI.Enabled = false;
                        txt_descripcion.Enabled = false;
                        txt_retencion.Enabled = false;
                        chk_estado.Enabled = false;
                        dtp_valiDesde.Enabled = false;
                        dtp_valiHasta.Enabled = false;
                        cmb_tipCodSRI.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
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

        public void set_Info(cp_codigo_SRI_Info info)
        {
            try
            {
                txt_id.Text = info.IdCodigo_SRI.ToString();
                cmb_tipCodSRI.EditValue = info.IdTipoSRI;
                txt_cod_base.Text = info.co_codigoBase.Trim();
                txt_cod_SRI.Text = info.codigoSRI.Trim();
                txt_descripcion.Text = info.co_descripcion.Trim();
                txt_retencion.Text = info.co_porRetencion.ToString();
                dtp_valiDesde.Value = Convert.ToDateTime(info.co_f_vigente_desde.ToShortDateString());
                dtp_valiHasta.Value = Convert.ToDateTime(info.co_f_vigente_hasta.ToShortDateString());              
                listInfo=cp_codigo_SRI_x_CtaCble.Get_codigo_SRI_x_CtaCble(param.IdEmpresa, info.IdCodigo_SRI);
                if (info.co_estado == "I") { lblAnulado.Visible = true; }
                else { lblAnulado.Visible = false; }
                chk_estado.Checked = (info.co_estado == "A") ? true : false;
                if (listInfo != null)
                {
                    if (listInfo.Count() > 0)
                    {
                        ucCtaCble.set_PlanCtarInfo(listInfo.FirstOrDefault().IdCtaCble);
                    }
                }
                codSRI_inf = info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public cp_codigo_SRI_Info get_Info()
        {
            try
            {
                tipoCodSRI = UCTC.get_Dato();
                codSRI_inf.co_codigoBase = txt_cod_base.Text.Trim();
                codSRI_inf.co_descripcion = txt_descripcion.Text.Trim();
                codSRI_inf.co_estado = (chk_estado.Checked == true) ? "A" : "I";
                codSRI_inf.co_f_vigente_desde = dtp_valiDesde.Value;
                codSRI_inf.co_f_vigente_hasta = dtp_valiHasta.Value;
                codSRI_inf.co_porRetencion = Convert.ToDouble(txt_retencion.Text);
                codSRI_inf.codigoSRI = txt_cod_SRI.Text;
                codSRI_inf.IdCodigo_SRI = Convert.ToInt16(txt_id.Text);
                codSRI_inf.IdTipoSRI = Convert.ToString(cmb_tipCodSRI.EditValue);
                codSRI_inf.IdCtaCble = ucCtaCble.get_PlanCtaInfo().IdCtaCble;
                return codSRI_inf;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cp_codigo_SRI_Info();
            }

        }

        private Boolean validar()
        {
            try
            {

                if (dtp_valiDesde.Value > dtp_valiHasta.Value)
                {
                    MessageBox.Show("La fecha Válido Desde no debe ser mayor a la fecha Válido Hasta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    return false;
                }

                if (txt_descripcion.Text == "")
                {
                    MessageBox.Show("Ingrese la Descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_descripcion.Focus();
                    return false;
                }

                if (txt_cod_SRI.Text == "")
                {
                    MessageBox.Show("Ingrese Código SRI", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cod_SRI.Focus();
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

        public Boolean Procesar()
        {
            try
            {
                Boolean bolResult = false;
                int codigoSRI = Convert.ToInt32(txt_id.Text);
                txt_descripcion.Focus();

                if (validar())
                {
                    tipoCodSRI = UCTC.get_Dato();
                    get_Info();

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        codSRI_inf.IdUsuario = param.IdUsuario;
                        codSRI_inf.Fecha_Transac = param.Fecha_Transac;
                        codSRI_inf.nom_pc = param.nom_pc;
                        codSRI_inf.ip = param.ip;

                        if (codSRI_Bus.GrabarDB(codSRI_inf, ref id))
                        {
                            txt_id.Text = id.ToString();
                            codigoSRI = id;

                            cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();

                            info.IdEmpresa = param.IdEmpresa;
                            info.idUsuario = codSRI_inf.IdUsuario;
                            info.fecha_UltMod = codSRI_inf.Fecha_Transac;
                            info.nom_pc = codSRI_inf.nom_pc;
                            info.ip = codSRI_inf.ip;
                            info.idCodigo_SRI = id;
                            info.IdCtaCble = ucCtaCble.get_PlanCtaInfo().IdCtaCble;
                            if (info.IdCtaCble != null)
                            {
                                codcta.GuardarDB(info);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Código SRI", id);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                            }
                            bolResult = true;
                            LimpiarDatos();
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        codSRI_inf.IdUsuarioUltMod = param.IdUsuario;
                        codSRI_inf.Fecha_UltMod = param.Fecha_Transac;
                        if (codSRI_Bus.ModificarDB(codSRI_inf))
                        {
                            cp_codigo_SRI_x_CtaCble_Info info = new cp_codigo_SRI_x_CtaCble_Info();

                            info.IdEmpresa = param.IdEmpresa;
                            info.idUsuario = codSRI_inf.IdUsuarioUltMod;
                            info.fecha_UltMod = codSRI_inf.Fecha_UltMod;
                            info.nom_pc = param.nom_pc;
                            info.ip = param.ip;
                            info.idCodigo_SRI = codSRI_inf.IdCodigo_SRI;
                            info.IdCtaCble = ucCtaCble.get_PlanCtaInfo().IdCtaCble;
                            if (info.IdCtaCble != null)
                            {
                                codcta.ModificarDB(info);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Código SRI", codSRI_inf.IdCodigo_SRI);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                            }
                            bolResult = true;

                            LimpiarDatos();
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        codSRI_inf.IdUsuarioUltAnu = param.IdUsuario;
                        codSRI_inf.Fecha_UltAnu = param.Fecha_Transac;

                        if (MessageBox.Show("¿Está seguro que desea anular dicho Código SRI?", "Anulación de Código SRI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            codSRI_inf.MotivoAnulacion = ofrm.motivoAnulacion;
                            if (codSRI_Bus.AnularDB(codSRI_inf))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Código SRI", codSRI_inf.IdCodigo_SRI);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                ucGe_Menu.Visible_bntAnular = false;
                                bolResult = true;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                       
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
                if (validar())
                {
                    if (Procesar())
                        Close();
                }
                
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
                if (Procesar())
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

        private void ucGe_Menu_event_btnlimpiar_Click_1(object sender, EventArgs e)
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
                codSRI_inf = new cp_codigo_SRI_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                
                txt_cod_base.Text = "";
                txt_descripcion.Text = "";
                chk_estado.Checked = true;
                txt_retencion.Text = "";
                txt_cod_SRI.Text = "";
                txt_id.Text = "";
                cmb_tipCodSRI.EditValue = null;
                ucCtaCble.Inicializar_cmbPlanCta();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
