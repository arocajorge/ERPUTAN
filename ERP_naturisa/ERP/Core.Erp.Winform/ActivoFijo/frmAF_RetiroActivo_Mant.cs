using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class                                                            frmAF_RetiroActivo_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delefate_FormClosed(object sender, FormClosingEventArgs e);
        public event delefate_FormClosed event_FormClosed;
        public Af_Retiro_Activo_Info _InfoRt { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Retiro_Activo_Info InfoRetiro = new Af_Retiro_Activo_Info();
        Af_Retiro_Activo_Bus busRetiro = new Af_Retiro_Activo_Bus();
        Af_Activo_fijo_Bus actiFijoBus = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lstInfoAf = new List<Af_Activo_fijo_Info>();
        ct_Cbtecble_Info CbteCbleInfo = new ct_Cbtecble_Info();
        ct_Cbtecble_Bus busCbteCble = new ct_Cbtecble_Bus();
        Af_Parametros_Bus busParam = new Af_Parametros_Bus();
        Af_Parametros_Info infoParam = new Af_Parametros_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        Af_TipoTransac_x_Cta_CbteCble_Bus busDepreCtaCble = new Af_TipoTransac_x_Cta_CbteCble_Bus();
        Af_TipoTransac_x_Cta_CbteCble_Info infoDepreCble = new Af_TipoTransac_x_Cta_CbteCble_Info();
        int IdTipoCbte = 0;
        decimal IdCbteCle = 0;


        public frmAF_RetiroActivo_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            event_FormClosed += new delefate_FormClosed(frmAF_RetiroActivo_Mant_event_FormClosed);
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ImprimirDiario()
        {
            try
            {
                XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                reporte.set_parametros(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();
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

        void frmAF_RetiroActivo_Mant_event_FormClosed(object sender, FormClosingEventArgs e)
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
                if (GuardarDatos())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
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
                if (lblAnulado.Visible)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Enabled_bntAnular = false;
                }
                else
                    AnularDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void setInfo()
        {
            try
            {
                txtIdRetiro.EditValue = _InfoRt.IdRetiroActivo;
                txtCodRetiro.EditValue = _InfoRt.Cod_Ret_Activo;
                txtConcepto.EditValue = _InfoRt.Concepto_Retiro;
                txtComproVta.EditValue = _InfoRt.NumComprobante;
                txtValorActivo.EditValue = _InfoRt.ValorActivo;
                txtValorBaja.EditValue = _InfoRt.Valor_Tot_Bajas;
                txtValorMejora.EditValue = _InfoRt.Valor_Tot_Mejora;
                txtValorDepre.EditValue = _InfoRt.Valor_Depre_Acu;
                txtValorNeto.EditValue = _InfoRt.Valor_Neto;
                cmbActivoFijo.EditValue = _InfoRt.IdActivoFijo;
                dtpFecha.Value = _InfoRt.Fecha_Retiro;
                if (_InfoRt.Estado == "I")
                    lblAnulado.Visible = true;
                cargarGridContable();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getInfo()
        {
            try
            {
                InfoRetiro.IdEmpresa = param.IdEmpresa;
                InfoRetiro.IdRetiroActivo = (txtIdRetiro.EditValue == "" || txtIdRetiro.EditValue == null) ? 0 : Convert.ToInt32(txtIdRetiro.EditValue);
                InfoRetiro.Cod_Ret_Activo = (txtCodRetiro.EditValue == "" || txtCodRetiro.EditValue == null) ? "" : Convert.ToString(txtCodRetiro.EditValue);
                InfoRetiro.Concepto_Retiro = Convert.ToString(txtConcepto.EditValue);
                InfoRetiro.NumComprobante = Convert.ToString(txtComproVta.EditValue);                
                InfoRetiro.ValorActivo = Convert.ToDouble(txtValorActivo.EditValue);
                InfoRetiro.Valor_Tot_Bajas = Convert.ToDouble(txtValorBaja.EditValue);
                InfoRetiro.Valor_Tot_Mejora = Convert.ToDouble(txtValorMejora.EditValue);
                InfoRetiro.Valor_Depre_Acu = Convert.ToDouble(txtValorDepre.EditValue);
                InfoRetiro.Valor_Neto = Convert.ToDouble(txtValorNeto.EditValue);                
                InfoRetiro.IdActivoFijo = Convert.ToInt32(cmbActivoFijo.EditValue);
                InfoRetiro.Fecha_Retiro = dtpFecha.Value;
                InfoRetiro.IdUsuario = param.IdUsuario;
                InfoRetiro.Fecha_Transac = dtpFecha.Value;
                InfoRetiro.nom_pc = param.nom_pc;
                InfoRetiro.ip = param.ip;
                InfoRetiro.Estado = "A";      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdRetiroActivo = 0;
                decimal IdCbteCble = 0;
                string msjError = "";
                if (ValidarDatos())
                {
                    getCbtecble();
                    if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                    {
                    getInfo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busRetiro.GuardarDB(InfoRetiro, CbteCbleInfo, ref IdRetiroActivo, ref IdCbteCble, ref msjError))
                            {
                                txtIdRetiro.EditValue = IdRetiroActivo;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente el Retiro del Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cargarGridContable();
                                if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_event_btnImprimir_Click(null, null);
                                }
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            InfoRetiro.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            InfoRetiro.IdUsuarioUltMod = param.IdUsuario;

                            if (busRetiro.ModificarDB(InfoRetiro, CbteCbleInfo, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente el Retiro del Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                cargarGridContable();
                                if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_event_btnImprimir_Click(null, null);
                                }
                                LimpiarDatos();
                            }
                            else
                                MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                    }
                    }
                    else
                    {
                        MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                InfoRetiro = new Af_Retiro_Activo_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                CbteCbleInfo = new ct_Cbtecble_Info();
                
                txtIdRetiro.EditValue = "";
                txtCodRetiro.EditValue = "";
                txtConcepto.EditValue = "";
                txtComproVta.EditValue = "";
                txtValorActivo.EditValue = "";
                txtValorBaja.EditValue ="";
                txtValorMejora.EditValue = "";
                txtValorDepre.EditValue = "";
                txtValorNeto.EditValue = "";
                cmbActivoFijo.EditValue ="";

              
                ucCon_GridDiarioContable.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean AnularDatos()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdCbteCble_Rev = 0;
                string msjError = "";
                getInfo();
                getCbtecble();
                if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    InfoRetiro.MotivoAnula = frm.motivoAnulacion;
                    InfoRetiro.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    InfoRetiro.IdUsuarioUltAnu = param.IdUsuario;
                    InfoRetiro.IdTipoCbte_Rev = infoParam.IdTipoCbteRetiro_Anulacion;
                    if (busRetiro.AnularDB(InfoRetiro, CbteCbleInfo, ref IdCbteCble_Rev, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente el Retiro del Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                        //    ucGe_Menu_event_btnImprimir_Click(null, null);
                        //}
                    }
                    else
                        MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        void getCbtecble()
        {
            try
            {
                CbteCbleInfo.IdEmpresa = param.IdEmpresa;
                CbteCbleInfo.IdTipoCbte = (infoDepreCble.ct_IdTipoCbte == null || infoDepreCble.ct_IdTipoCbte == 0) ? IdTipoCbte : infoDepreCble.ct_IdTipoCbte;
                CbteCbleInfo.CodCbteCble = "";
                CbteCbleInfo.IdPeriodo = Per_I.IdPeriodo;

                CbteCbleInfo.cb_Fecha = Convert.ToDateTime(dtpFecha.Value);
                CbteCbleInfo.cb_Valor = ucCon_GridDiarioContable.Get_ValorCbteCble();
                CbteCbleInfo.cb_Observacion = txtConcepto.Text.Trim();
                CbteCbleInfo.Secuencia = 0;
                CbteCbleInfo.Estado = "A";

                CbteCbleInfo.Anio = Convert.ToDateTime(dtpFecha.Value).Year;

                CbteCbleInfo.Mes = Convert.ToDateTime(dtpFecha.Value).Month;
                CbteCbleInfo.IdUsuario = param.IdUsuario;
                CbteCbleInfo.IdUsuarioUltModi = param.IdUsuario;
                CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                CbteCbleInfo.cb_FechaUltModi = param.Fecha_Transac;
                CbteCbleInfo.Mayorizado = "N";
                CbteCbleInfo.IdCbteCble = IdCbteCle;

                getCbteCble_Det();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<ct_Cbtecble_det_Info> getCbteCble_Det()
        {
            try
            {
                var lstDetalle = ucCon_GridDiarioContable.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in lstDetalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = IdCbteCle;
                    dte.IdTipoCbte = (infoDepreCble.ct_IdTipoCbte == null || infoDepreCble.ct_IdTipoCbte == 0) ? IdTipoCbte : infoDepreCble.ct_IdTipoCbte;

                    dte.secuencia = i++;
                }
                CbteCbleInfo._cbteCble_det_lista_info = lstDetalle;

                return lstDetalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }


        public void cargarGridContable()
        {
            try
            {
                infoDepreCble = new Af_TipoTransac_x_Cta_CbteCble_Info();
                infoDepreCble = busDepreCtaCble.Get_Info_Transac_x_CtaCble(param.IdEmpresa, Convert.ToDecimal(txtIdRetiro.EditValue), Cl_Enumeradores.eTipoActivoFijo.Retiro_Acti.ToString());
                IdCbteCle = infoDepreCble.ct_IdCbteCble;
                ucCon_GridDiarioContable.setInfo(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean ValidarDatos()
        {
            try
            {
                if (cmbActivoFijo.EditValue == "" || cmbActivoFijo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbActivoFijo.Focus();
                    return false;
                }

                if (txtConcepto.EditValue == "" || txtConcepto.EditValue == null)
                {
                    MessageBox.Show("Ingrese el concepto de la venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConcepto.Focus();
                    return false;
                }

                if (dtpFecha.Value.ToString() == "" || dtpFecha.Value.ToString() == null)
                {
                    MessageBox.Show("Seleccione la fecha de venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpFecha.Focus();
                    return false;
                }               
                /*
                if (txtComproVta.EditValue == "" || txtComproVta.EditValue == null)
                {
                    MessageBox.Show("Ingrese el numero e comprobante de la venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComproVta.Focus();
                    return false;
                }
                 * */

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmAF_RetiroActivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_RetiroActivo_Mant_event_FormClosed(sender, e);
                event_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_RetiroActivo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";
                infoParam = busParam.Get_Info_Parametros(param.IdEmpresa);
                IdTipoCbte = infoParam.IdTipoCbteRetiro;
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtpFecha.Value), ref MensajeError);                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        CargarCombo(Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString());
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        CargarCombo("");
                        setInfo();
                        ucGe_Menu.Enabled_bntAnular = false;
                        cmbActivoFijo.Properties.ReadOnly = true;
                        txtCodRetiro.Properties.ReadOnly = true;
                        cmbActivoFijo_EditValueChanged(null, null);
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        CargarCombo("");
                        setInfo();
                        ucCon_GridDiarioContable.Enabled = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        cmbActivoFijo.Properties.ReadOnly = true;
                        cmbActivoFijo.Properties.ReadOnly = true;
                        cmbActivoFijo_EditValueChanged(null, null);
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        CargarCombo("");
                        setInfo();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        cmbActivoFijo_EditValueChanged(null, null);

                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CargarCombo(string EstadoProceso)
        {
            try
            {
                lstInfoAf = actiFijoBus.Get_List_ActivoFijo(param.IdEmpresa, EstadoProceso);
                cmbActivoFijo.Properties.DataSource = lstInfoAf;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbActivoFijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularValores();   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CalcularValores()
        {
            try
            {
                Af_Activo_fijo_Info InfoActiFijo = new Af_Activo_fijo_Info();
                List<Af_Mej_Baj_Activo_Info> lstInfoMej = new List<Af_Mej_Baj_Activo_Info>();
                Af_Mej_Baj_Activo_Bus busMejBaj = new Af_Mej_Baj_Activo_Bus();
                Af_Depreciacion_Det_Bus busDepre = new Af_Depreciacion_Det_Bus();
                double ValorDepreTot = 0;
                if (cmbActivoFijo.EditValue != null && cmbActivoFijo.EditValue != "")
                {
                    InfoActiFijo = lstInfoAf.Where(q => q.IdActivoFijo == Convert.ToInt32(cmbActivoFijo.EditValue)).First();
                    txtValorActivo.EditValue = InfoActiFijo.Af_costo_compra;

                    lstInfoMej = busMejBaj.Get_List_Sum_Valor_Mej_Baj_Activo(param.IdEmpresa, Convert.ToDecimal(cmbActivoFijo.EditValue));

                    if (lstInfoMej.Where(q => q.Id_Tipo == Cl_Enumeradores.eTipoActivoFijo.Baja_Acti.ToString()).ToList().Count > 0)
                        txtValorBaja.EditValue = lstInfoMej.Where(q => q.Id_Tipo == Cl_Enumeradores.eTipoActivoFijo.Baja_Acti.ToString()).First().Valor_Mej_Baj_Activo;
                    else
                        txtValorBaja.EditValue = 0;

                    if (lstInfoMej.Where(q => q.Id_Tipo == Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString()).ToList().Count > 0)
                        txtValorMejora.EditValue = lstInfoMej.Where(q => q.Id_Tipo == Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString()).First().Valor_Mej_Baj_Activo;
                    else
                        txtValorMejora.EditValue = 0;


                    ValorDepreTot = busDepre.Get_DepreAcum_x_Activo(param.IdEmpresa, Convert.ToInt32(cmbActivoFijo.EditValue));
                    txtValorDepre.EditValue = Math.Round( Convert.ToDouble((InfoActiFijo.Af_Depreciacion_acum == null ? 0 : InfoActiFijo.Af_Depreciacion_acum) + ValorDepreTot),2,MidpointRounding.AwayFromZero);

                    txtValorNeto.EditValue = Math.Round( (Convert.ToDecimal(txtValorActivo.EditValue) - Convert.ToDecimal(txtValorBaja.EditValue)
                        + Convert.ToDecimal(txtValorMejora.EditValue) - Convert.ToDecimal(txtValorDepre.EditValue)),2,MidpointRounding.AwayFromZero);
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
