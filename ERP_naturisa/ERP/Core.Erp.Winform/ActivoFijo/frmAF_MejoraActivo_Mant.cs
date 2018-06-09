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
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.ActivoFijo;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_MejoraActivo_Mant : DevExpress.XtraEditors.XtraForm
    {
        private Cl_Enumeradores.eTipo_action _Accion;
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void Delegate_frmClosed(object sender, FormClosingEventArgs e);
        public event Delegate_frmClosed event_frmClosed;
        cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
        List<cp_proveedor_Info> lstProveedor = new List<cp_proveedor_Info>();
        Af_Mej_Baj_Activo_Bus mejActiBus = new Af_Mej_Baj_Activo_Bus();
        Af_Mej_Baj_Activo_Info _InfoMejActi = new Af_Mej_Baj_Activo_Info();
        Af_Activo_fijo_Bus actiFijoBus = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lstActiFijo = new List<Af_Activo_fijo_Info>();
        public Af_Mej_Baj_Activo_Info _Info = new Af_Mej_Baj_Activo_Info();
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
        Af_Catalogo_Bus busCata = new Af_Catalogo_Bus();
        List<Af_Catalogo_Info> lstInfoCata = new List<Af_Catalogo_Info>();

        public frmAF_MejoraActivo_Mant()
        {
            InitializeComponent();
            event_frmClosed += new Delegate_frmClosed(frmAF_MejoraActivo_Mant_event_frmClosed);
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
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

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XACTF_Rpt001_rpt Reporte = new XACTF_Rpt001_rpt(param.IdUsuario,Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString()) ;
                XACTF_Rpt001_Bus busRpt = new XACTF_Rpt001_Bus();
                List<XACTF_Rpt001_Info> lstRpt = new List<XACTF_Rpt001_Info>();

                Reporte.RequestParameters = false;
                lstRpt = busRpt.get_BajaMejora_ActivoFijo(param.IdEmpresa, Convert.ToDecimal(txtIdmejora.EditValue), Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString());
                Reporte.lstRpt = lstRpt;

                Reporte.CreateDocument();
                Reporte.ShowPreviewDialog();

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
                if (GuardarMejora())
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
                GuardarMejora();
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
                    AnularMejora();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmAF_MejoraActivo_Mant_event_frmClosed(object sender, FormClosingEventArgs e)
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
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void frmAF_MejoraActivo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";

                infoParam = busParam.Get_Info_Parametros(param.IdEmpresa);
                IdTipoCbte = infoParam.IdTipoCbteMejora;
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtpFecha.Value), ref MensajeError);                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        cargarCombos(Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString());
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cargarCombos("");
                        set_MejoraActivo();
                        ucGe_Menu.Enabled_bntAnular = false;
                        cmbActivoFijo.Properties.ReadOnly = true;
                        txtCodMejora.Properties.ReadOnly = true;
                        cmbActivoFijo_EditValueChanged(null, null);
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        cargarCombos("");
                        set_MejoraActivo();
                        ucCon_GridDiarioContable.Enabled = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        cmbActivoFijo.Properties.ReadOnly = true;
                        cmbProveedor.Enabled = false;
                        txtDescripcionTecnica.Properties.ReadOnly = true;
                        txtMotivoMejora.Properties.ReadOnly = true;
                        txtCodMejora.Properties.ReadOnly = true;
                        txtValorMejora.Properties.ReadOnly = true;
                        txtComrobante.Properties.ReadOnly = true;
                        cmbActivoFijo_EditValueChanged(null, null);
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        cargarCombos("");
                        set_MejoraActivo();
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

        private void frmAF_MejoraActivo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_MejoraActivo_Mant_event_frmClosed(sender, e);
                event_frmClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        void cargarCombos(string EstadoProceso)
        {
            try
            {
                lstActiFijo = actiFijoBus.Get_List_ActivoFijo(param.IdEmpresa, EstadoProceso);
                cmbActivoFijo.Properties.DataSource = lstActiFijo;


                cmbUbicacion.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                cmbMarca.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_MARCA.ToString());
                cmbModelo.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_DISEÑO.ToString());
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        Boolean GuardarMejora()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdMejoraBaja = 0;
                decimal IdCbteCble = 0;
                string msjError = "";
                if (ValidarDatos())
                {
                     getCbtecble();
                    if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                    {
                    get_MejoraActivo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (mejActiBus.GuardarDB(_InfoMejActi, CbteCbleInfo, ref IdMejoraBaja, ref IdCbteCble, ref msjError))
                            {
                                txtIdmejora.EditValue = IdMejoraBaja;
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Guardo Exitosamente la Mejora  de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            _InfoMejActi.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            _InfoMejActi.IdUsuarioUltMod = param.IdUsuario;

                            if (mejActiBus.ModificarDB(_InfoMejActi, CbteCbleInfo, ref msjError))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                ucGe_Menu.Enabled_bntImprimir = true;
                                bolResult = true;
                                MessageBox.Show("Se Modifico Exitosamente la Mejora  de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _InfoMejActi = new Af_Mej_Baj_Activo_Info();
                CbteCbleInfo = new ct_Cbtecble_Info();
                ucCon_GridDiarioContable.LimpiarGrid();
                
                txtIdmejora.EditValue = "";                
                cmbActivoFijo.EditValue = null;
                cmbProveedor.Inicializar_cmbProveedor();
                txtCodMejora.EditValue = "";
                txtCostoActivo.EditValue = "";
                txtValorMejora.EditValue = "";
                txtComrobante.EditValue = "";
                txtDescripcionTecnica.EditValue = "";
                txtMotivoMejora.EditValue = "";
                
                txtVidaUtil.EditValue = "";
                cmbUbicacion.Inicializar_Catalogos();
                txtCostoActivo.EditValue = "";
                cmbMarca.Inicializar_Catalogos();
                cmbModelo.Inicializar_Catalogos();
                txtSerie.EditValue = "";
                txtDepreciacion.EditValue = "";

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
                CbteCbleInfo.cb_Observacion = txtMotivoMejora.Text.Trim();
                CbteCbleInfo.Secuencia = 0;
                CbteCbleInfo.Estado = "A";

                CbteCbleInfo.Anio = Convert.ToDateTime(dtpFecha.Value).Year;

                CbteCbleInfo.Mes = Convert.ToDateTime(dtpFecha.Value).Month;
                CbteCbleInfo.IdUsuario = param.IdUsuario;
                CbteCbleInfo.IdUsuarioUltModi = param.IdUsuario;
                CbteCbleInfo.cb_FechaTransac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                CbteCbleInfo.cb_FechaUltModi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
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
                infoDepreCble = busDepreCtaCble.Get_Info_Transac_x_CtaCble(param.IdEmpresa, Convert.ToDecimal(txtIdmejora.Text), Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString());
                IdCbteCle = infoDepreCble.ct_IdCbteCble;                
                ucCon_GridDiarioContable.setInfo(infoDepreCble.ct_IdEmpresa, infoDepreCble.ct_IdTipoCbte, infoDepreCble.ct_IdCbteCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_MejoraActivo()
        {
            try
            {
                txtIdmejora.EditValue = _Info.Id_Mejora_Baja_Activo;                
                cmbActivoFijo.EditValue =  _Info.IdActivoFijo;
                cmbProveedor.set_ProveedorInfo(_Info.IdProveedor);
                txtCodMejora.EditValue = _Info.Cod_Mej_Baj_Activo;
                txtValorMejora.EditValue = _Info.Valor_Mej_Baj_Activo;
                txtComrobante.EditValue = _Info.Compr_Mej_Baj ;
                txtDescripcionTecnica.EditValue = _Info.DescripcionTecnica;
                txtMotivoMejora.EditValue = _Info.Motivo;
                dtpFecha.Value  = _Info.Fecha_Transac ;                
                if (_Info.Estado == "I")                
                    lblAnulado.Visible = true;
                cargarGridContable();
            }
            catch (Exception ex )
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void get_MejoraActivo()
        {
            try
            {
                _InfoMejActi = new Af_Mej_Baj_Activo_Info();
                _InfoMejActi.IdEmpresa = param.IdEmpresa;
                _InfoMejActi.Id_Mejora_Baja_Activo = (txtIdmejora.EditValue == "" || txtIdmejora.EditValue == null) ? 0 : Convert.ToDecimal(txtIdmejora.EditValue);
                _InfoMejActi.Id_Tipo = Cl_Enumeradores.eTipoActivoFijo.Mejo_Acti.ToString();
                _InfoMejActi.IdActivoFijo = Convert.ToInt32(cmbActivoFijo.EditValue);
                _InfoMejActi.IdProveedor = cmbProveedor.get_ProveedorInfo().IdProveedor;
                _InfoMejActi.Cod_Mej_Baj_Activo = (txtCodMejora.EditValue == "" || txtCodMejora.EditValue == null) ? "" : txtCodMejora.EditValue.ToString();
                _InfoMejActi.ValorActivo = Convert.ToDouble(txtCostoActivo.EditValue);
                _InfoMejActi.Valor_Mej_Baj_Activo = Convert.ToDouble(txtValorMejora.EditValue);
                _InfoMejActi.Compr_Mej_Baj = (txtComrobante.EditValue == "" || txtComrobante.EditValue == null) ? "" : txtComrobante.EditValue.ToString();
                _InfoMejActi.DescripcionTecnica = txtDescripcionTecnica.EditValue.ToString();
                _InfoMejActi.Motivo = txtMotivoMejora.EditValue.ToString();
                _InfoMejActi.IdUsuario = param.IdUsuario;
                _InfoMejActi.Fecha_Transac = dtpFecha.Value;
                _InfoMejActi.nom_pc = param.nom_pc;
                _InfoMejActi.ip = param.ip;
                _InfoMejActi.Estado = "A";                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean AnularMejora()
        {
            try
            {
                Boolean bolResult = false;
                decimal IdCbteCble_Rev = 0;
                string msjError = "";
                get_MejoraActivo();
                getCbtecble();
                if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    _InfoMejActi.MotivoAnula = frm.motivoAnulacion;
                    _InfoMejActi.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    _InfoMejActi.IdUsuarioUltAnu = param.IdUsuario;
                    _InfoMejActi.IdTipoCbte_Rev = infoParam.IdTipoCbteMejora_Anulacion;

                    if (mejActiBus.AnularDB(_InfoMejActi, CbteCbleInfo, ref IdCbteCble_Rev, ref msjError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        bolResult = true;
                        lblAnulado.Visible = true;
                        MessageBox.Show("Se Anulo Exitosamente la Mejora  de Activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("¿Desea Imprimir el Soporte ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ucGe_Menu_event_btnImprimir_Click(null, null);
                        }  
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

        Boolean ValidarDatos()
        {
            try
            {
                if (cmbActivoFijo.EditValue == "" || cmbActivoFijo.EditValue == null)
                {
                    MessageBox.Show("Por favor seleccione el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbActivoFijo.Focus();
                    return false;
                }

                if (cmbProveedor.get_ProveedorInfo() == null)
                {//Por_favor_seleccione_proveedor
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_proveedor), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbProveedor.Focus();
                    return false;
                }

                if ( txtDescripcionTecnica.EditValue == null)
                {
                    MessageBox.Show("Por favor Ingrese la Descripcion Tecnica", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcionTecnica.Focus();
                    return false;
                }

                if (txtMotivoMejora.EditValue == "" || txtMotivoMejora.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese el Motivo de la Mejora", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMotivoMejora.Focus();
                    return false;
                }

                if (Convert.ToInt32(txtValorMejora.EditValue) <= 0)
                {
                    MessageBox.Show("El valor de la Mejora debe ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorMejora.Focus();
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

        private void cmbActivoFijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Af_Activo_fijo_Info InfoActiFijo = new Af_Activo_fijo_Info();
                if (cmbActivoFijo.EditValue != null && cmbActivoFijo.EditValue != "")
                {
                    InfoActiFijo = lstActiFijo.Where(q => q.IdActivoFijo == Convert.ToInt32(cmbActivoFijo.EditValue)).First();
                    txtVidaUtil.EditValue = InfoActiFijo.Af_Vida_Util;
                    cmbUbicacion.set_CatalogosInfo(InfoActiFijo.IdTipoCatalogo_Ubicacion);
                    txtCostoActivo.EditValue = InfoActiFijo.Af_costo_compra;
                    cmbMarca.set_CatalogosInfo(InfoActiFijo.IdCatalogo_Marca);
                    cmbModelo.set_CatalogosInfo(InfoActiFijo.IdCatalogo_Modelo);
                    txtSerie.EditValue = InfoActiFijo.Af_NumSerie;
                    txtDepreciacion.EditValue = InfoActiFijo.Af_porcentaje_deprec;
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
