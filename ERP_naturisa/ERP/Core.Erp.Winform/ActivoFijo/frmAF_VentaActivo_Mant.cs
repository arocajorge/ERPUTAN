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
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_VentaActivo_Mant : Form
    {
        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accon = new Cl_Enumeradores.eTipo_action();
        public delegate void delegate_FormClosed(object sender, FormClosingEventArgs e);
        public event delegate_FormClosed event_FormClosed;
        public Af_Venta_Activo_Info _Info { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Activo_fijo_Bus actiFijoBus = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lstActiFijo = new List<Af_Activo_fijo_Info>();
        Af_Mej_Baj_Activo_Bus busMejBaj = new Af_Mej_Baj_Activo_Bus();
        List<Af_Mej_Baj_Activo_Info> lstInfoMej = new List<Af_Mej_Baj_Activo_Info>();
        Af_Venta_Activo_Bus busVta = new Af_Venta_Activo_Bus();
        Af_Venta_Activo_Info _InfoVtaAf = new Af_Venta_Activo_Info();

        Af_Activo_fijo_CtasCbles_Info Info_CtaCble_x_ActivoFijo = new Af_Activo_fijo_CtasCbles_Info();
        Af_Activo_fijo_CtasCbles_Bus Bus_CtaCble_x_ActivoFijo = new Af_Activo_fijo_CtasCbles_Bus();

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

        #endregion

        public frmAF_VentaActivo_Mant()
        {
            InitializeComponent();
            event_FormClosed += new delegate_FormClosed(frmAF_VentaActivo_Mant_event_FormClosed);
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
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

        void frmAF_VentaActivo_Mant_event_FormClosed(object sender, FormClosingEventArgs e)
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

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accon = Accion;
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
                txtIdVta.EditValue = _Info.IdVtaActivo;
                txtCodVta.EditValue = _Info.Cod_VtaActivo;
                txtConcepto.EditValue = _Info.Concepto_Vta;
                txtComproVta.EditValue = _Info.NumComprobante;
                txtValorVta.EditValue = _Info.Valor_Venta;
                txtValorActivo.EditValue = _Info.ValorActivo;
                txtValorBaja.EditValue = _Info.Valor_Tot_Bajas;
                txtValorMejora.EditValue = _Info.Valor_Tot_Mejora;
                txtValorDepre.EditValue = _Info.Valor_Depre_Acu;
                txtValorNeto.EditValue = _Info.Valor_Neto;
                txtValorPerdida.EditValue = _Info.Valor_Perdi_Gana;   
                cmbActivoFijo.EditValue = _Info.IdActivoFijo;
                dtpFecha.Value = _Info.Fecha_Venta;
                if (_Info.Estado == "I")
                    lblAnulado.Visible = true;
                cargarGridContable();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getInfo()
        {
            try
            {
                _InfoVtaAf.IdEmpresa = param.IdEmpresa;
                _InfoVtaAf.IdVtaActivo = (txtIdVta.EditValue == "" || txtIdVta.EditValue == null) ? 0 : Convert.ToInt32(txtIdVta.EditValue);
                _InfoVtaAf.Cod_VtaActivo = (txtCodVta.EditValue == "" || txtCodVta.EditValue == null) ? "" : Convert.ToString(txtCodVta.EditValue);
                _InfoVtaAf.Concepto_Vta =  Convert.ToString(txtConcepto.EditValue);
                _InfoVtaAf.NumComprobante = Convert.ToString(txtComproVta.EditValue);
                _InfoVtaAf.Valor_Venta = Convert.ToDouble(txtValorVta.EditValue);
                _InfoVtaAf.ValorActivo = Convert.ToDouble(txtValorActivo.EditValue);
                _InfoVtaAf.Valor_Tot_Bajas = Convert.ToDouble(txtValorBaja.EditValue);
                _InfoVtaAf.Valor_Tot_Mejora = Convert.ToDouble(txtValorMejora.EditValue);
                _InfoVtaAf.Valor_Depre_Acu = Convert.ToDouble(txtValorDepre.EditValue);
                _InfoVtaAf.Valor_Neto = Convert.ToDouble(txtValorNeto.EditValue);
                _InfoVtaAf.Valor_Perdi_Gana = Convert.ToDouble(txtValorPerdida.EditValue);
                _InfoVtaAf.IdActivoFijo = Convert.ToInt32(cmbActivoFijo.EditValue);
                _InfoVtaAf.Fecha_Venta = dtpFecha.Value;
                _InfoVtaAf.IdUsuario = param.IdUsuario;
                _InfoVtaAf.Fecha_Transac = dtpFecha.Value;
                _InfoVtaAf.nom_pc = param.nom_pc;
                _InfoVtaAf.ip = param.ip;
                _InfoVtaAf.Estado = "A";      
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_VentaActivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_VentaActivo_Mant_event_FormClosed(sender, e);
                event_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_VentaActivo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";
                infoParam = busParam.Get_Info_Parametros(param.IdEmpresa);
                IdTipoCbte = infoParam.IdTipoCbteVenta;
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtpFecha.Value), ref MensajeError);                
                switch (_Accon)
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
                        txtCodVta.Properties.ReadOnly = true;
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
                lstActiFijo = actiFijoBus.Get_List_ActivoFijo(param.IdEmpresa, EstadoProceso);
                cmbActivoFijo.Properties.DataSource = lstActiFijo;
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
                Af_Depreciacion_Det_Bus busDepre = new Af_Depreciacion_Det_Bus();
                double ValorDepreTot = 0;
                if (cmbActivoFijo.EditValue != null && cmbActivoFijo.EditValue != "")
                {
                    InfoActiFijo = lstActiFijo.Where(q => q.IdActivoFijo == Convert.ToInt32(cmbActivoFijo.EditValue)).First();
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
                    txtValorDepre.EditValue = Math.Round(Convert.ToDouble((InfoActiFijo.Af_Depreciacion_acum == null ? 0 : InfoActiFijo.Af_Depreciacion_acum) + ValorDepreTot), 2, MidpointRounding.AwayFromZero);

                    txtValorNeto.EditValue = Math.Round((Convert.ToDecimal(txtValorActivo.EditValue) - Convert.ToDecimal(txtValorBaja.EditValue)
                        + Convert.ToDecimal(txtValorMejora.EditValue) - Convert.ToDecimal(txtValorDepre.EditValue)), 2, MidpointRounding.AwayFromZero);
                                        
                    txtValorPerdida.EditValue = (Convert.ToDecimal(txtValorVta.EditValue) - Convert.ToDecimal(txtValorNeto.EditValue));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorVta_EditValueChanged(object sender, EventArgs e)
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

                if (txtValorVta.EditValue == "" || txtValorVta.EditValue == null)
                {
                    MessageBox.Show("Ingrese el valor de la venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorVta.Focus();
                    return false;
                }

                if (txtComproVta.EditValue == "" || txtComproVta.EditValue == null)
                {
                    MessageBox.Show("Ingrese el numero e comprobante de la venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComproVta.Focus();
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

        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdVtaActivo = 0;
                decimal IdCbteCble = 0;
                string msjError = "";
                if (ValidarDatos())
                {
                     getCbtecble();
                    if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                    {
                    getInfo();
                    switch (_Accon)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (busVta.GuardarDB(_InfoVtaAf, CbteCbleInfo, ref IdVtaActivo, ref IdCbteCble, ref msjError))
                            {
                                txtIdVta.EditValue = IdVtaActivo;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Venta de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            _InfoVtaAf.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            _InfoVtaAf.IdUsuarioUltMod = param.IdUsuario;

                            if (busVta.ModificarDB(_InfoVtaAf, CbteCbleInfo, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Venta de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                _Accon = Cl_Enumeradores.eTipo_action.grabar;
                _InfoVtaAf = new Af_Venta_Activo_Info();
                
                txtIdVta.EditValue = "";
                txtCodVta.EditValue = "";
                txtConcepto.EditValue = "";
                txtComproVta.EditValue = "";                
                txtValorActivo.EditValue = "";
                txtValorBaja.EditValue = "";
                txtValorMejora.EditValue = "";
                txtValorDepre.EditValue = "";
                txtValorNeto.EditValue = "";
                txtValorPerdida.EditValue = "";
                cmbActivoFijo.EditValue = null;
                txtValorVta.EditValue = "";
                CbteCbleInfo = new ct_Cbtecble_Info();
                ucCon_GridDiarioContable.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                infoDepreCble = busDepreCtaCble.Get_Info_Transac_x_CtaCble(param.IdEmpresa, Convert.ToDecimal(txtIdVta.EditValue), Cl_Enumeradores.eTipoActivoFijo.Venta_Acti.ToString());
                IdCbteCle = infoDepreCble.ct_IdCbteCble;
                ucCon_GridDiarioContable.setInfo(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
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
                    _InfoVtaAf.MotivoAnula = frm.motivoAnulacion;
                    _InfoVtaAf.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    _InfoVtaAf.IdUsuarioUltAnu = param.IdUsuario;
                    _InfoVtaAf.IdTipoCbte_Rev = infoParam.IdTipoCbteVenta_Anulacion;

                    if (busVta.AnularDB(_InfoVtaAf, CbteCbleInfo, ref IdCbteCble_Rev, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente la Venta de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
