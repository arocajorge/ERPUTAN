using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_AnioFiscal_Mant : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_AnioFiscal_Info oanio = new ct_AnioFiscal_Info();
        ct_AnioFiscal_Bus oafb = new ct_AnioFiscal_Bus();
        ct_anio_fiscal_x_cuenta_utilidad_Bus anio_x_cta_bus = new ct_anio_fiscal_x_cuenta_utilidad_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmCon_AnioFiscal_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_AnioFiscal_Mant_FormClosing event_frmCon_AnioFiscal_Mant_FormClosing;
        string MensajeError = "";
        #endregion

        #region " Constructor"
        public frmCon_AnioFiscal_Mant()
        {
            InitializeComponent();
            event_frmCon_AnioFiscal_Mant_FormClosing += frmCon_AnioFiscal_Mant_event_frmCon_AnioFiscal_Mant_FormClosing;
        }

        void frmCon_AnioFiscal_Mant_event_frmCon_AnioFiscal_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region " SET"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(ct_AnioFiscal_Info _onio)
        {
            try
            {
                oanio = _onio;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void set_anio()
        {
            try
            {
                this.txt_id.EditValue = oanio.IdanioFiscal;
                this.dtFechaIni.EditValue = oanio.af_fechaIni;
                this.dtFechaFin.EditValue = oanio.af_fechaFin;
                lblAnulado.Visible = (oanio.af_estado == "I") ? true : false;
                if (oanio.af_estado == "A")
                    this.chk_estado.Checked = true;
                else
                {
                    this.chk_estado.Checked = false;                  
                     lblAnulado.Visible = true;                                                
                }
                oanio.anio_fiscal_x_cuenta_utilidad_Info = anio_x_cta_bus.Get_Info_anioF_x_Cta(param.IdEmpresa, oanio.IdanioFiscal, ref MensajeError);
                ucCon_PlanCtaCmb1.set_PlanCtarInfo(oanio.anio_fiscal_x_cuenta_utilidad_Info.IdCtaCble);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region " GET "
        private void get_anio()
        {
            try
            {
                oanio = new ct_AnioFiscal_Info();
                oanio.IdEmpresa = param.IdEmpresa;
                oanio.IdanioFiscal = Convert.ToInt32(this.txt_id.EditValue);
                oanio.af_fechaIni = Convert.ToDateTime(this.dtFechaIni.EditValue);
                oanio.af_fechaFin = Convert.ToDateTime(this.dtFechaFin.EditValue);
                lblAnulado.Visible = (this.chk_estado.Checked == true) ? false : true;
                if (chk_estado.Checked == true)
                {
                    oanio.af_estado = "A";
                }
                else
                { oanio.af_estado = "I"; }
                oanio.anio_fiscal_x_cuenta_utilidad_Info.IdEmpresa = oanio.IdEmpresa;
                oanio.anio_fiscal_x_cuenta_utilidad_Info.IdanioFiscal = oanio.IdanioFiscal;
                oanio.anio_fiscal_x_cuenta_utilidad_Info.IdCtaCble = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Validar"
        private Boolean validar()
        {
            try
            {
                if (txt_id.EditValue == "" || txt_id.EditValue == null || txt_id.EditValue.Equals(0))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " año fiscal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_id.Focus();
                    return false;
                }

                if (dtFechaIni.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " fecha inicial del  Año Fiscal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaIni.Focus();
                    return false;
                }

                if (dtFechaFin.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + "  fecha final del  Año Fiscal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaFin.Focus();
                    return false;
                }
                


                if (Convert.ToDateTime(dtFechaIni.EditValue) >= Convert.ToDateTime(dtFechaFin.EditValue))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Fecha_final_debe_ser_mayor_que_fecha_inicial) + " del  Año Fiscal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble == null || ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cuenta Contable ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCon_PlanCtaCmb1.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }
        #endregion

        #region " Guardar, Modificar, Anular "
        private Boolean GrabarDatos()
        {
            try
            {
                Boolean res = false;
                get_anio();
                ct_AnioFiscal_Bus anio_bus = new ct_AnioFiscal_Bus();
                string msg = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (oafb.GrabarDB(oanio, ref MensajeError))
                    {
                        ct_anio_fiscal_x_cuenta_utilidad_Bus Bus_anioF_ctaU = new ct_anio_fiscal_x_cuenta_utilidad_Bus();
                        if (Bus_anioF_ctaU.GuardarDB(oanio.anio_fiscal_x_cuenta_utilidad_Info, ref MensajeError))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el Año Fiscal " + oanio.IdanioFiscal, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            res = true;
                            LimpiarDatos();
                        }
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (oafb.ModificarDB(oanio, ref MensajeError))
                    {

                        ct_anio_fiscal_x_cuenta_utilidad_Bus Bus_anioF_ctaU = new ct_anio_fiscal_x_cuenta_utilidad_Bus();
                        Bus_anioF_ctaU.ModificarDB(oanio.anio_fiscal_x_cuenta_utilidad_Info, ref MensajeError);
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Año Fiscal " + oanio.IdanioFiscal, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        res = true;
                        LimpiarDatos();
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, MensajeError);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (anio_bus.Get_Tiene_PeriodosxAnio(param.IdEmpresa, oanio.IdanioFiscal, ref msg) == false)
                {

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (oanio.af_estado != "I")
                        {
                            if (oafb.AnularDB(oanio, ref MensajeError))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el Año Fiscal " + oanio.IdanioFiscal, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                res = true;
                                lblAnulado.Visible = true;
                                ucGe_Menu.Visible_bntAnular = false;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, MensajeError);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
                else
                    MessageBox.Show(msg);
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Eventos "
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                    GrabarDatos();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if(GrabarDatos())
                     Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    if (GrabarDatos())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Load "
        private void frmCon_AnioFiscal_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.chk_estado.Checked = true;
                        ucGe_Menu.Visible_bntAnular = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        this.txt_id.Properties.ReadOnly = true;
                        //dtFechaFin.Properties.ReadOnly = true;
                        //dtFechaIni.Properties.ReadOnly = true;
                        set_anio();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        this.txt_id.Properties.ReadOnly = true;
                        dtFechaFin.Properties.ReadOnly = true;
                        dtFechaIni.Properties.ReadOnly = true;
                        ucCon_PlanCtaCmb1.Enabled = false;
                        set_anio();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        this.txt_id.Properties.ReadOnly = true;
                        dtFechaFin.Properties.ReadOnly = true;
                        dtFechaIni.Properties.ReadOnly = true;
                        ucCon_PlanCtaCmb1.Enabled = false;
                        set_anio();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Evento FormClosing"
        private void frmCon_AnioFiscal_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_AnioFiscal_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Limpiar "
        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                oanio = new ct_AnioFiscal_Info();
                this.txt_id.EditValue = "";
                this.chk_estado.Checked = true;
                dtFechaFin.EditValue = null;
                    //= DateTime.Now;
                dtFechaIni.EditValue = null;
                this.ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion
    }
}