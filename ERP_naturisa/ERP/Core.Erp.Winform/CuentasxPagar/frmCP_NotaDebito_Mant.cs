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
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;

using Core.Erp.Reportes.CuentasxPagar;
using Cus.Erp.Reports.Naturisa.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_NotaDebito_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_catalogo_Bus busCpCatalogo;
        cp_proveedor_Bus proveedorB;
        ba_TipoFlujo_Bus busTipoFlujo;
        ct_Plancta_Bus _PlanCta_bus;
        ct_Centro_costo_Bus _CentroCostoBus;
        cp_codigo_SRI_Bus dat_ti;
        cp_reembolso_Bus Reem_B;
        
        cp_nota_DebCre_Bus Bus_notaCrDeb = new cp_nota_DebCre_Bus();
        cp_parametros_Bus paramCP_B;
        ct_Periodo_Bus Per_B;
        vwba_Cbte_Ban_detallePagos_Bus _CbteBan_B;
        vwba_ordenGiroPendientes_Bus OGP_B;
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        List<vwba_ordenGiroPendientes_Info> Lst_OGP_I = new List<vwba_ordenGiroPendientes_Info>();
        List<vwba_Cbte_Ban_detallePagos_Info> lm = new List<vwba_Cbte_Ban_detallePagos_Info>();
        cp_parametros_Info InfoParam_cxp = new cp_parametros_Info();
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
        cp_nota_DebCre_Info Info_notaCredDeb = new cp_nota_DebCre_Info();
        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        //int _IdTipoCbte;
        //int IdTipoCbteRev;
        //decimal IdCbteCbleRev;
        //decimal idCbteCble = 0;
        //string cod_CbteCble = "";
        private Cl_Enumeradores.eTipo_action _Accion;
        string motiAnulacion, msg2 = "";
        string MensajeError = "";
        double Valor = 0;
        double total = 0, valorApagar = 0, Vsaldo = 0;

        public delegate void delegate_frmCP_NotaDebito_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_NotaDebito_Mant_FormClosing event_frmCP_NotaDebito_Mant_FormClosing;

        #endregion

        public frmCP_NotaDebito_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;

            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;

            ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged;

            event_frmCP_NotaDebito_Mant_FormClosing+= frmCP_NotaDebito_Mant_event_frmCP_NotaDebito_Mant_FormClosing;

            event_frmCP_NotaDebito_Mant_FormClosing += frmCP_NotaDebito_Mant_event_frmCP_NotaDebito_Mant_FormClosing;
            

        }

        void ucCon_PlanCtaCmb_Iva_event_cmbPlanCta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UC_Diario.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCon_PlanCtaCmb1_event_cmbPlanCta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UC_Diario.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 UC_Diario.LimpiarGrid();                               
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                    _Accion = Cl_Enumeradores.eTipo_action.Anular;
                    if (Anular() == true)
                    { 
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean res = false;

                if (Validaciones())
                {
                    res = Accion_Grabar();
                    if (res == true)
                    {
                        this.Close();
                    }
                }               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean res = false;

                if(Validaciones())
                {
                    res  =Accion_Grabar();
                    if (res == true)
                    {
                        Limpiar();
                        _Accion = Cl_Enumeradores.eTipo_action.grabar;
                        set_accion_in_controls();
                    }

                }               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        void cargar_Combos()
        {
            try
            {
               
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    //ucCon_PlanCtaCmb1.set_PlanCtarInfo(paramCP_I.pa_ctacble_deudora);
                    //ucCon_PlanCtaCmb_Iva.set_PlanCtarInfo(paramCP_I.pa_ctacble_iva);
                }

                //carga Tipo Nota
                busCpCatalogo = new cp_catalogo_Bus();
                var TipoNota = busCpCatalogo.Get_List_catalogo("T_TIP_NOTA");
                cmbTipoNota.Properties.DataSource = TipoNota;
                cmbTipoNota.Properties.DisplayMember = "Nombre";
                cmbTipoNota.Properties.ValueMember = "IdCatalogo";
                if (TipoNota.Count > 0)
                    cmbTipoNota.EditValue = TipoNota.First().IdCatalogo;
                           
                //carga Codigo ICE
                dat_ti = new cp_codigo_SRI_Bus();
                string[] CodRetencion2 = new string[] { "COD_ICE" };
                List<cp_codigo_SRI_Info> ListaCodigoSri = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion2, param.IdEmpresa);
                ListaCodigoSri.ForEach(item =>
                {
                    item.descriConcate = "[" + item.codigoSRI + "] - " + item.co_descripcion + " " + item.co_porRetencion + "%";
                    item.co_descripcion = "[" + item.codigoSRI + "] - " + item.co_descripcion;
                });

                cmbCodigoIce.Properties.DataSource = ListaCodigoSri;
                cmbCodigoIce.Properties.DisplayMember = "descriConcate";
                cmbCodigoIce.Properties.ValueMember = "IdCodigo_SRI";

                //carga Codigo SRI             
                List<cp_codigo_SRI_Info> ListCodigoSri = dat_ti.Get_List_codigo_SRI_x_codigo (new string[] { "COD_IDCREDITO" }, param.IdEmpresa).FindAll(c => c.co_estado == "A" && c.codigoSRI != "10");
                cmbSustenTribut.Properties.DataSource = ListCodigoSri;
                cmbSustenTribut.Properties.DisplayMember = "descriConcate";
                cmbSustenTribut.Properties.ValueMember = "IdCodigo_SRI";

                //carga Tipo Servicio
                DataTable dtb_Servicio = new DataTable();
                dtb_Servicio.Columns.Add(new DataColumn("Tipo Servicio", typeof(string)));
                dtb_Servicio.Rows.Add(new object[] { "BIEN" });
                dtb_Servicio.Rows.Add(new object[] { "SERVI" });
                dtb_Servicio.Rows.Add(new object[] { "AMBAS" });

                cmbTipoServicio.Properties.DisplayMember = "Tipo Servicio";
                cmbTipoServicio.Properties.ValueMember = "Tipo Servicio";
                cmbTipoServicio.Properties.DataSource = dtb_Servicio;

                //carga Localizacion
                DataTable dtb_Local = new DataTable();
                dtb_Local.Columns.Add(new DataColumn("Localizacion", typeof(string)));
                dtb_Local.Rows.Add(new object[] { "NAC" });
                dtb_Local.Rows.Add(new object[] { "EXT" });

                cmbTipoLocalidad.Properties.DisplayMember = "Localizacion";
                cmbTipoLocalidad.Properties.ValueMember = "Localizacion";
                cmbTipoLocalidad.Properties.DataSource = dtb_Local;

                //carga Pago
                DataTable dtb_Pago = new DataTable();
                dtb_Pago.Columns.Add(new DataColumn("Pago", typeof(string)));
                dtb_Pago.Rows.Add(new object[] { "Local" });
                dtb_Pago.Rows.Add(new object[] { "Exterior" });

                cmbLocalExt.Properties.DisplayMember = "Pago";
                cmbLocalExt.Properties.ValueMember = "Pago";
                cmbLocalExt.Properties.DataSource = dtb_Pago;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                Info_CbteCble = new ct_Cbtecble_Info();

                Info_CbteCble.IdEmpresa = param.IdEmpresa;
                Info_CbteCble.IdTipoCbte = Convert.ToInt32(InfoParam_cxp.pa_TipoCbte_ND);
                Info_CbteCble.CodCbteCble = "";

                Info_CbteCble.IdPeriodo = Info_Periodo.IdPeriodo;


                Info_CbteCble.cb_Fecha = Convert.ToDateTime(dtE_Fecha_Contabilizacion.EditValue);
                Info_CbteCble.cb_Valor = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info.FindAll(q => q.dc_Valor > 0).Sum(q => q.dc_Valor);
                Info_CbteCble.cb_Observacion = Convert.ToString(txt_observacion.EditValue).Trim();
                Info_CbteCble.Secuencia = 0;
                Info_CbteCble.Estado = "A";
                Info_CbteCble.Anio = Convert.ToDateTime(dtE_Fecha.EditValue).Year;
                Info_CbteCble.Mes = Convert.ToDateTime(dtE_Fecha.EditValue).Month;
                Info_CbteCble.IdUsuario = param.IdUsuario;
                Info_CbteCble.IdUsuarioUltModi = param.IdUsuario;
                Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                Info_CbteCble.cb_FechaUltModi = param.Fecha_Transac;
                Info_CbteCble.Mayorizado = "N";
                Info_CbteCble.IdCbteCble = Info_notaCredDeb.IdCbteCble_Nota;
                Info_CbteCble._cbteCble_det_lista_info = _ListaCbteCbleDet;
                Info_CbteCble.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;

                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                _ListaCbteCbleDet = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info;

                foreach (var dte in _ListaCbteCbleDet)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = Info_notaCredDeb.IdCbteCble_Nota;
                    dte.IdTipoCbte = Info_notaCredDeb.IdTipoCbte_Nota;
                }

                Info_CbteCble._cbteCble_det_lista_info = _ListaCbteCbleDet;

                return Info_CbteCble;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }

        public void get_notaCr()
        {
            try
            {
                DateTime FechaAu;

                


                FechaAu = dteFecAutoriza.DateTime.Date;
                FechaAu = FechaAu.AddHours(tm_hora_aut.Time.Hour);
                FechaAu = FechaAu.AddMinutes(tm_hora_aut.Time.Minute);
                FechaAu = FechaAu.AddSeconds(tm_hora_aut.Time.Second);

                


                Info_notaCredDeb.cn_baseImponible = Convert.ToDouble(txE_BaseImponible.EditValue);
                Info_notaCredDeb.cn_BaseSeguro = Convert.ToDecimal(txE_BaSeguros.EditValue);
                Info_notaCredDeb.cn_fecha = Convert.ToDateTime(dtE_Fecha.EditValue);

                if (dteFecAutoriza.EditValue == null)
                {
                    Info_notaCredDeb.fecha_autorizacion = null;
                }
                else
                {
                    Info_notaCredDeb.fecha_autorizacion = FechaAu;
                }
            
                Info_notaCredDeb.cn_Ice_base = Convert.ToDouble(txE_BaseIce.EditValue);
                Info_notaCredDeb.cn_Ice_por = Convert.ToDouble(txE_PICE.EditValue);
                Info_notaCredDeb.cn_Ice_valor = Convert.ToDouble(txE_montoIce.EditValue);
                Info_notaCredDeb.cn_observacion = Convert.ToString(txt_observacion.EditValue).Trim();
                Info_notaCredDeb.cn_Por_iva = Convert.ToDouble(txE_IVA.EditValue);
                Info_notaCredDeb.cn_serie1 = String.IsNullOrEmpty(Convert.ToString(txE_serie1.EditValue)) ? null : Convert.ToString(txE_serie1.EditValue).Trim();
                Info_notaCredDeb.cn_serie2 = String.IsNullOrEmpty(Convert.ToString(txE_serie2.EditValue)) ? null : Convert.ToString(txE_serie2.EditValue).Trim();
                Info_notaCredDeb.cn_Serv_por = (txE_Servicio.EditValue == null) ? 0 : Convert.ToDouble(txE_Servicio.EditValue);
                Info_notaCredDeb.cn_Serv_valor = (txE_valorServicio.EditValue == null) ? 0 : Convert.ToDouble(txE_valorServicio.EditValue);
                Info_notaCredDeb.cn_subtotal_iva = (txE_SubtotalIva.EditValue == null) ? 0 : Convert.ToDouble(txE_SubtotalIva.EditValue);
                Info_notaCredDeb.cn_subtotal_siniva = (txE_Subtotal0.EditValue == null) ? 0 : Convert.ToDouble(txE_Subtotal0.EditValue);
                Info_notaCredDeb.cn_total = (txE_Total.EditValue == null) ? 0 : Convert.ToDecimal(txE_Total.EditValue);
                Info_notaCredDeb.cn_vaCoa = (chk_coa.Checked == true) ? "S" : "N";
                Info_notaCredDeb.cn_valoriva = (txE_ValorIva.EditValue == null) ? 0 : Convert.ToDouble(txE_ValorIva.EditValue);
                Info_notaCredDeb.Estado = (Info_notaCredDeb.Estado == "I") ? Info_notaCredDeb.Estado : "A";
                Info_notaCredDeb.Fecha_Transac = param.Fecha_Transac;
                Info_notaCredDeb.Fecha_UltMod = param.Fecha_Transac;
                Info_notaCredDeb.cn_Autorizacion = Convert.ToString(this.txeIdNumAutoriza.EditValue);
                Info_notaCredDeb.IdCbteCble_Nota = (txE_NotaCre.EditValue == null) ? 0 : Convert.ToDecimal(txE_NotaCre.EditValue);
                Info_notaCredDeb.IdCod_ICE = Convert.ToInt32(cmbCodigoIce.EditValue);

                Info_notaCredDeb.IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                Info_notaCredDeb.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                Info_notaCredDeb.IdTipoCbte_Nota = Convert.ToInt32(InfoParam_cxp.pa_TipoCbte_ND);
                Info_notaCredDeb.IdTipoServicio = Convert.ToString(cmbTipoServicio.EditValue);
                Info_notaCredDeb.IdUsuario = param.IdUsuario;
                Info_notaCredDeb.IdUsuarioUltAnu = param.IdUsuario;
                Info_notaCredDeb.IdUsuarioUltMod = param.IdUsuario;
                Info_notaCredDeb.ip = param.ip;
                Info_notaCredDeb.MotivoAnu = "";
                Info_notaCredDeb.nom_pc = param.nom_pc;
                Info_notaCredDeb.cod_nota = txtCodigo.Text;
               

                Info_notaCredDeb.Fecha_UltAnu = param.Fecha_Transac;
                Info_notaCredDeb.cn_tipoLocacion = Convert.ToString(cmbTipoLocalidad.EditValue);
                Info_notaCredDeb.cn_Nota = Convert.ToString(txeNumDocum.EditValue);
                Info_notaCredDeb.DebCre = "D";
                Info_notaCredDeb.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;

                if (ucBa_TipoFlujo1.get_TipoFlujoInfo() == null)
                    Info_notaCredDeb.IdTipoFlujo = null;
                else Info_notaCredDeb.IdTipoFlujo = ucBa_TipoFlujo1.get_TipoFlujoInfo().IdTipoFlujo;

                if (cmbSustenTribut.EditValue == null)

                    Info_notaCredDeb.IdIden_credito = null;
                else
                    Info_notaCredDeb.IdIden_credito = Convert.ToInt32(cmbSustenTribut.EditValue);

                Info_notaCredDeb.PagoLocExt = (cmbLocalExt.EditValue == "Local") ? "LOC" : "EXT";
                Info_notaCredDeb.PaisPago = Convert.ToString(cmbPais.EditValue);
                Info_notaCredDeb.ConvenioTributacion = (rb_aplicConvDobTribSI.Checked == true) ? "SI" : (rb_aplicConvDobTribNO.Checked == true) ? "NO" : "NA";
                Info_notaCredDeb.PagoSujetoRetencion = (rb_pagExtSujRetNorLegSI.Checked == true) ? "SI" : (rb_pagExtSujRetNorLegNO.Checked == true) ? "NO" : "NA";
                Info_notaCredDeb.IdTipoNota = Convert.ToString(cmbTipoNota.EditValue);
                Info_notaCredDeb.Fecha_contable =Convert.ToDateTime( dtE_Fecha_Contabilizacion.EditValue);
                Info_notaCredDeb.cn_Fecha_vcto =Convert.ToDateTime(dtE_Fecha_vencimiento.EditValue);
                Info_notaCredDeb.cn_fecha =Convert.ToDateTime( dtE_Fecha.EditValue);
                Info_notaCredDeb.cn_Autorizacion_Imprenta = "";
                Info_notaCredDeb.cn_num_doc_modificado = Convert.ToString(txE_DocuModifica.EditValue);


                Info_notaCredDeb.Info_CbteCble_X_Nota = get_Cbtecble();

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Info_notaCr(cp_nota_DebCre_Info info)
        {
            try
            {
                Info_notaCredDeb=info;
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void set_Info_notaCr_in_controls()
        {
            try
            {
                txE_BaseImponible.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_baseImponible);
                txE_BaSeguros.EditValue = Info_notaCredDeb.cn_BaseSeguro;
                dtE_Fecha.EditValue = Info_notaCredDeb.cn_fecha;
                if (Info_notaCredDeb.fecha_autorizacion != null && Info_notaCredDeb.fecha_autorizacion != DateTime.MinValue)
                {
                    dteFecAutoriza.EditValue = Info_notaCredDeb.fecha_autorizacion.Value.Date.ToShortDateString();
                    tm_hora_aut.EditValue = Info_notaCredDeb.fecha_autorizacion.Value.TimeOfDay;
                }
                txE_BaseIce.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_Ice_base);
                txE_PICE.EditValue = Info_notaCredDeb.cn_Ice_por;
                txE_montoIce.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_Ice_valor);
                txt_observacion.EditValue = Info_notaCredDeb.cn_observacion;
                txE_IVA.EditValue = Info_notaCredDeb.cn_Por_iva;
                txE_serie1.EditValue = Info_notaCredDeb.cn_serie1;
                txE_serie2.EditValue = Info_notaCredDeb.cn_serie2;
                txE_Servicio.EditValue = Info_notaCredDeb.cn_Serv_por;
                dtE_Fecha.EditValue = Info_notaCredDeb.cn_fecha;
                dtE_Fecha_Contabilizacion.EditValue = Info_notaCredDeb.Fecha_contable;
                dtE_Fecha_vencimiento.EditValue = Info_notaCredDeb.cn_Fecha_vcto;
                txtCodigo.Text = Info_notaCredDeb.cod_nota;
                if (Info_notaCredDeb.IdProveedor != null)
                {
                    ucCp_Proveedor1.set_ProveedorInfo(Info_notaCredDeb.IdProveedor);

                }
                txE_valorServicio.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_Serv_valor);
                txE_SubtotalIva.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_subtotal_iva);
                txE_Subtotal0.EditValue = Convert.ToDouble(Info_notaCredDeb.cn_subtotal_siniva);
                txE_Total.EditValue = Info_notaCredDeb.cn_total;
                txE_Saldo.EditValue = Info_notaCredDeb.Saldo; //Agregado 14/03/2014
                chk_coa.Checked = (Info_notaCredDeb.cn_vaCoa == "S") ? true : false;
                txE_ValorIva.EditValue = Convert.ToDecimal(Info_notaCredDeb.cn_valoriva);
                lblAnulado.Visible = (Info_notaCredDeb.Estado == "I") ? true : false;
                lblAnulado.Text = "Anulado con el #Cbt.Cble.: " + Info_notaCredDeb.IdCbteCble_Anulacion + " Tipo Cbt.Cble.: " + Info_notaCredDeb.IdTipoCbte_Anulacion;
                txeIdNumAutoriza.EditValue = Info_notaCredDeb.cn_Autorizacion;
                txE_NotaCre.EditValue = Info_notaCredDeb.IdCbteCble_Nota.ToString();
                cmbCodigoIce.EditValue = Info_notaCredDeb.IdCod_ICE;
                

               
                cmbTipoNota.EditValue = Info_notaCredDeb.IdTipoNota;
                ucGe_Sucursal_combo1.set_SucursalInfo(Convert.ToInt32(Info_notaCredDeb.IdSucursal));



                ucBa_TipoFlujo1.set_TipoFlujoInfo(Info_notaCredDeb.IdTipoFlujo);
                cmbSustenTribut.EditValue = Info_notaCredDeb.IdIden_credito;
                
                //_IdTipoCbte = Info_notaCredDeb.IdTipoCbte_Nota;

                cmbTipoServicio.EditValue = Info_notaCredDeb.IdTipoServicio;
                Info_notaCredDeb.MotivoAnu = "";

              
                cmbTipoLocalidad.EditValue = Info_notaCredDeb.cn_tipoLocacion;
                txeNumDocum.EditValue = Info_notaCredDeb.cn_Nota;
                txE_DocuModifica.EditValue = Info_notaCredDeb.cn_num_doc_modificado;
                cmbLocalExt.EditValue = (Info_notaCredDeb.PagoLocExt == "EXT") ? "Exterior" : "Local";

                

                cmbPais.EditValue = Info_notaCredDeb.PaisPago;
                if (Info_notaCredDeb.ConvenioTributacion == "SI")
                    rb_aplicConvDobTribSI.Checked = true;
                else if (Info_notaCredDeb.ConvenioTributacion == "NO")
                    rb_aplicConvDobTribNO.Checked = true;

                if (Info_notaCredDeb.PagoSujetoRetencion == "SI")
                    rb_pagExtSujRetNorLegSI.Checked = true;
                else if (Info_notaCredDeb.PagoSujetoRetencion == "NO")
                    rb_pagExtSujRetNorLegNO.Checked = true;

                Info_notaCredDeb = Info_notaCredDeb;

                set_PagadosOG();
                set_CbteCbleInfo();
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_PagadosOG()
        {
            try
            {
                Lst_OGP_I.Clear();
                _CbteBan_B = new vwba_Cbte_Ban_detallePagos_Bus();
                lm = _CbteBan_B.Get_List_Cbte_Ban_detallePagos(Info_notaCredDeb.IdEmpresa, Info_notaCredDeb.IdTipoCbte_Nota, Info_notaCredDeb.IdCbteCble_Nota);
                foreach (var item in lm)
                {
                    vwba_ordenGiroPendientes_Info info = new vwba_ordenGiroPendientes_Info();
                    info.chek = true;
                    info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    info.co_fechaOg = item.co_fechaOg;
                    info.co_observacion = item.co_observacion;
                    info.valorAPagar = Convert.ToDouble(item.co_valorpagar);
                    info.saldo2 = item.pg_saldoAnterior;
                    info.valorAplicado = Convert.ToDecimal(item.pg_MontoAplicado);
                    info.saldo = item.pg_saldoAnterior - item.pg_MontoAplicado;
                    info.TotalPagado = Convert.ToDouble(item.pg_MontoAplicado);
                    info.IdProveedor = item.IdProveedor;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTipoCbte_Ogiro = item.IdTipocbte_cbte;
                    info.NFactura = item.NFactura;

                    Lst_OGP_I.Add(info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_CbteCbleInfo()
        {
            try
            {
                if (Info_notaCredDeb.IdCbteCble_Nota != 0)
                {
                    UC_Diario.setAccion(_Accion);
                    UC_Diario.setInfo(Info_notaCredDeb.IdEmpresa, Info_notaCredDeb.IdTipoCbte_Nota, Info_notaCredDeb.IdCbteCble_Nota);
                    _ListaCbteCbleDetAnt = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info;

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
            _Accion = Accion;
        }

        private void set_accion_in_controls()
        {
            try
            {             

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txE_NotaCre.Properties.ReadOnly = true;
                        txE_NotaCre.BackColor = System.Drawing.Color.White;
                        
                        lblAnulado.Visible = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntAnular = false;

                        chk_coa.Checked = true;
                    
                        cmbLocalExt.EditValue = "Local";

                        dtE_Fecha.EditValue = DateTime.Now;
                        dteFecAutoriza.EditValue = DateTime.Now;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucCp_Proveedor1.Perfil_Lectura();
                        cmbTipoNota.Properties.ReadOnly = true;
                        cmbTipoNota.BackColor = System.Drawing.Color.White;
                        set_Info_notaCr_in_controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        bloquear_Controles();
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        set_Info_notaCr_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        bloquear_Controles();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        set_Info_notaCr_in_controls();
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

        void bloquear_Controles()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Enabled_bntLimpiar = false;
               
                dtE_Fecha.Properties.ReadOnly = true;

                dteFecAutoriza.Properties.ReadOnly = true;

                txt_observacion.Properties.ReadOnly = true;

                txE_SubtotalIva.Properties.ReadOnly = true;

                txE_Subtotal0.Properties.ReadOnly = true;

                txE_Servicio.Properties.ReadOnly = true;
                                            
                txE_valorServicio.Properties.ReadOnly = true;

                txE_BaseIce.Properties.ReadOnly = true;

                txE_BaSeguros.Properties.ReadOnly = true;
               
                txeIdNumAutoriza.Properties.ReadOnly = true;

                txE_serie1.Properties.ReadOnly = true;

                txE_serie2.Properties.ReadOnly = true;

                txeNumDocum.Properties.ReadOnly = true;

                txE_NotaCre.Properties.ReadOnly = true;

                txE_IVA.Properties.ReadOnly = true;

                txE_ValorIva.Properties.ReadOnly = true;

                txE_BaseImponible.Properties.ReadOnly = true;

                txE_Total.Properties.ReadOnly = true;

                txE_Saldo.Properties.ReadOnly = true;

                txE_SumatoriaOG.Properties.ReadOnly = true;

                txE_DocuModifica.Properties.ReadOnly = true;

                txE_PICE.Properties.ReadOnly = true;

                txE_montoIce.Properties.ReadOnly = true;

                chk_coa.Enabled = false;

                cmbPais.Properties.ReadOnly = true;
                        
                cmbCodigoIce.Properties.ReadOnly = true;

                cmbTipoServicio.Properties.ReadOnly = true;

                cmbTipoLocalidad.Properties.ReadOnly = true;

                cmbLocalExt.Properties.ReadOnly = true;

                cmbSustenTribut.Properties.ReadOnly = true;
           
                ucCp_Proveedor1.Perfil_Lectura();

                cmbTipoNota.Properties.ReadOnly = true;

                ucBa_TipoFlujo1.ReadOnly(true);
            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }
       
        void Limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                
                txE_SubtotalIva.EditValue = null;
                txE_Subtotal0.EditValue = null;
                txE_Servicio.EditValue = null;
                txE_valorServicio.EditValue = null;
                txE_BaseIce.EditValue = null;
                txE_BaSeguros.EditValue = null;
                txeIdNumAutoriza.EditValue = null;
                txE_serie1.EditValue = null;
                txE_serie2.EditValue = null;
                txeNumDocum.EditValue = null;
                txE_NotaCre.EditValue = null;
                //txE_IVA.EditValue = null;
                txE_ValorIva.EditValue = null;
                txE_BaseImponible.EditValue = null;
                txE_Total.EditValue = null;
                txE_Saldo.EditValue = null;
                txE_SumatoriaOG.EditValue = null;
                txt_observacion.Text = "";

                txE_DocuModifica.EditValue = null;
                txE_PICE.EditValue = null;
                txE_montoIce.EditValue = null;

                cmbPais.EditValue = null;
                cmbCodigoIce.EditValue = null;
  
                cmbTipoServicio.EditValue = null;
                cmbTipoLocalidad.EditValue = null;
                cmbLocalExt.EditValue = null;
                cmbSustenTribut.EditValue = null;

                ucCp_Proveedor1.Inicializar_cmbProveedor();
                ucGe_Sucursal_combo1.get_SucursalInfo();
                cmbTipoNota.EditValue = null;
                ucBa_TipoFlujo1.Inicializar_TipoFlujo();

      
                dtE_Fecha.EditValue =DateTime.Now;
                dteFecAutoriza.EditValue = DateTime.Now;

                UC_Diario.LimpiarGrid();
                Info_CbteCble = new ct_Cbtecble_Info();
                Info_notaCredDeb = new cp_nota_DebCre_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                    
        }


        Boolean Accion_Grabar()
        {
            try
            {
                Boolean res = false;

                txt_observacion.Focus();
                

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res =Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res =Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        res =Anular();
                        break;
                    default:
                        break;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Grabar()
        {
            Boolean res = true;
            try
            {
                

                    this.txt_observacion.Focus();

                    
                        get_notaCr();

                
                        if (Convert.ToString(cmbTipoNota.EditValue) == "T_TIP_NOTA_SRI")
                        {
                        

                            if (Bus_notaCrDeb.Existe_NumNotaCredito_Proveedor(param.IdEmpresa, Convert.ToDecimal(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor), Convert.ToString(txE_serie1.EditValue), Convert.ToString(txE_serie2.EditValue), Convert.ToString(txeNumDocum.EditValue), "D", Convert.ToString(cmbTipoNota.EditValue)))
                            {
                                MessageBox.Show("La Nota de Débito#: " + Info_notaCredDeb.cn_serie1 + "-" + Info_notaCredDeb.cn_serie2 + "-" + Info_notaCredDeb.cn_Nota + ". Ya se encuentra ingresada");
                                res = false;
                                return false;
                            }
                        }

                        string mensaje_Error = "";


                        res = Bus_notaCrDeb.GrabarDB(Info_notaCredDeb, ref mensaje_Error);

                            if (res)
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Nota de Débito ", Info_notaCredDeb.IdCbteCble_Nota);
                                MessageBox.Show(smensaje, param.Nombre_sistema);

                                if (MessageBox.Show("Desea Imprimir el documento", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(new object(), new EventArgs());
                                }
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("No se grabo la Nota debito :" +  mensaje_Error , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        


                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return  false;          
            }
        }

        private Boolean Modificar()
        {
            Boolean res = true;
            try
            {
                

                this.txt_observacion.Focus();

                
                            get_notaCr();

                            res =Bus_notaCrDeb.ModificarDB(Info_notaCredDeb);

                            if (res)
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Nota de Débito ", txE_NotaCre.EditValue);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                Limpiar();
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                res = false;
                            }


                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Anular()
        { Boolean res = true;
            try 
            {


                int IdTipoCbteRev = 0;

                IdTipoCbteRev = Convert.ToInt32(InfoParam_cxp.pa_TipoCbte_ND_anulacion);

                this.txt_observacion.Focus();
                string mensaje = "";

                get_notaCr();

                if (Info_notaCredDeb != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (Info_notaCredDeb.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la ND#: " + Info_notaCredDeb.IdCbteCble_Nota + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            Info_notaCredDeb.MotivoAnu = motiAnulacion;
                            Info_notaCredDeb.IdUsuarioUltAnu = param.IdUsuario;
                            Info_notaCredDeb.Fecha_UltAnu = param.Fecha_Transac;
                            Info_notaCredDeb.IdTipoCbte_Anulacion = IdTipoCbteRev;


                                    Bus_notaCrDeb = new cp_nota_DebCre_Bus();

                                    if (Bus_notaCrDeb.AnularDB(Info_notaCredDeb))
                                    {
                                        MessageBox.Show("Nota debito anulada Correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                        MessageBox.Show("No se pudo Anular la Nota de Débito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    

                            
                                _Accion = Cl_Enumeradores.eTipo_action.consultar;

                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, mensaje);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    

                    }
                    else if (Info_notaCredDeb.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la ND#: " + Info_notaCredDeb.IdCbteCble_Nota +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                return res;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public Boolean Validaciones()
        {
            try
            {
                Boolean estado = true;
                string MensajeErro="";

                Per_B = new ct_Periodo_Bus();
                Info_Periodo = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtE_Fecha_Contabilizacion.EditValue), ref MensajeErro);

                if (Info_Periodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoNota.EditValue == null || cmbTipoNota.EditValue =="")
                {
                    MessageBox.Show("Antes de continuar debe seleccionar el Tipo de Nota", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;                
                }
                
              

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                
                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDouble(txE_BaseImponible.EditValue) <= 0)
                {
                    MessageBox.Show("Base imponible no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }                

                if ( Convert.ToString(cmbTipoNota.EditValue) == "T_TIP_NOTA_SRI")
                {
                    if (cmbTipoServicio.EditValue == null || cmbTipoServicio.EditValue == "")
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar el tipo de Servico", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbTipoServicio.Focus();
                        return false;
                    }

                  

                    if (txeIdNumAutoriza.EditValue == null || txeIdNumAutoriza.EditValue == "")
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Autorización y # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txeIdNumAutoriza.Focus();
                        return false;
                    }

                    if (txE_serie1.EditValue == "" || Convert.ToDouble(txE_serie1.EditValue) == 0 || txE_serie1.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de serie 1", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txE_serie1.Focus();
                        return false;
                    }

                    if (txE_serie2.EditValue == "" || Convert.ToDouble(txE_serie2.EditValue) == 0 || txE_serie2.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de serie 2", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txE_serie2.Focus();
                        return false;
                    }

                    if (txeNumDocum.EditValue == "" || Convert.ToDouble(txeNumDocum.EditValue) == 0)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txeNumDocum.Focus();
                        return false;
                    }

                  

                   
                    if (cmbTipoLocalidad.EditValue == "" || cmbTipoLocalidad.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar el tipo de Localidad", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbTipoLocalidad.Focus();
                        return false;
                    }

                    if (cmbSustenTribut.EditValue == null || Convert.ToInt32(cmbSustenTribut.EditValue) == 0)
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar la Identificación de sustento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                
                }
                else
                {
                    dteFecAutoriza.EditValue = null;

                }

                if (Convert.ToString(cmbTipoNota.EditValue) == "T_TIP_NOTA_INT")
                {
                    if (cmbLocalExt.EditValue == "Exterior" && (cmbPais.EditValue == null || cmbPais.EditValue == ""))
                    {
                        MessageBox.Show("En información de Pago debe seleccionar El País al que se efectua el pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (!UC_Diario.ValidarAsientosContables())
                    return false;
                if (UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info.Count < 1)
                {
                    MessageBox.Show("Antes de continuar debe dar clic en el botón Contabilizar para general el Diario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;

                }

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        if (ucBa_TipoFlujo1.get_TipoFlujoInfo() == null)
                        {
                            MessageBox.Show("Antes de continuar debe seleccionar Tipo De Flujo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        break;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtE_Fecha.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtE_Fecha_Contabilizacion.EditValue)))
                    return false;

                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void suma()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    total = Convert.ToDouble(Convert.ToDouble(txE_BaseImponible.EditValue) + Convert.ToDouble(txE_ValorIva.EditValue) + Convert.ToDouble(txE_valorServicio.EditValue) + Convert.ToDouble(txE_montoIce.EditValue));
                    txE_Total.EditValue = total;
                    Vsaldo = total - Convert.ToDouble(txE_SumatoriaOG.EditValue);
                    txE_Saldo.EditValue = Vsaldo.ToString();

                    //UC_Diario.LimpiarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneraDiario()
        {
            try
            {
                //if (ucCon_PlanCtaCmb1.get_PlanCtaInfo() == null)
                //{
                //    MessageBox.Show("Antes de continuar debe seleccionar la Cuenta Acreedora", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    ucCon_PlanCtaCmb1.Focus();
                //    return;
                //}
                
                //if (ucCon_PlanCtaCmb_Iva.get_PlanCtaInfo() == null)
                //{
                //    MessageBox.Show("Antes de continuar debe seleccionar la Cuenta. IVA por Cobrar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


                if (ucCp_Proveedor1.get_ProveedorInfo()== null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar el Proveedor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (Convert.ToDouble(txE_BaseImponible.EditValue) <= 0)
                {
                    MessageBox.Show("Para generar el diario la Base Imponible debe ser mayor a 0, Por favor ingrese los valores de la Nota de Dédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //debito o credito

                UC_Diario.LimpiarGrid();

                // CTA GASTO
                List<ct_Cbtecble_det_Info> ListCbteDet = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_det_Info DetGto = new ct_Cbtecble_det_Info();

                //DetGto.IdCtaCble = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble;

     

                //DetGto.IdCentroCosto = !String.IsNullOrEmpty(ucCon_CentroCosto_ctas_Movi1.get_item()) ? ucCon_CentroCosto_ctas_Movi1.get_item() : "";


                DetGto.dc_Observacion = Convert.ToString(txt_observacion.EditValue).Trim();
                DetGto.dc_Valor = DetGto.dc_Valor_D = (Convert.ToDouble(txE_BaseImponible.EditValue) > 0) ? (Convert.ToDouble(txE_BaseImponible.EditValue) +
                ((txE_montoIce.EditValue == null) ? 0 : Convert.ToDouble(txE_montoIce.EditValue))) : 0;
                
                ListCbteDet.Add(DetGto);

                // IVA POR PAGAR

                if (Convert.ToDouble(txE_ValorIva.EditValue) > 0)
                {
                    ct_Cbtecble_det_Info DetIVA = new ct_Cbtecble_det_Info();

                    DetIVA.IdCtaCble = InfoParam_cxp.pa_ctacble_iva;
              
                    //DetIVA.IdCentroCosto = !String.IsNullOrEmpty(ucCon_CentroCosto_ctas_Movi1.get_item()) ? ucCon_CentroCosto_ctas_Movi1.get_item() : "";

                    DetIVA.dc_Observacion = Convert.ToString(txt_observacion.EditValue).Trim();
                    DetIVA.dc_Valor = DetIVA.dc_Valor_D = (Convert.ToDouble(txE_ValorIva.EditValue) > 0) ? Convert.ToDouble(txE_ValorIva.EditValue) : 0;
                   
                    ListCbteDet.Add(DetIVA);
                }

                //PROVEEDOR
                ct_Cbtecble_det_Info DetProv = new ct_Cbtecble_det_Info();

                DetProv.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
   

                //DetProv.IdCentroCosto = !String.IsNullOrEmpty(ucCon_CentroCosto_ctas_Movi1.get_item()) ? ucCon_CentroCosto_ctas_Movi1.get_item() : "";


                 DetProv.dc_Valor = (Convert.ToDouble(txE_Total.EditValue) > 0) ? Convert.ToDouble(txE_Total.EditValue) * -1 : 0;
                 DetProv.dc_Valor_H = (Convert.ToDouble(txE_Total.EditValue) > 0) ? Convert.ToDouble(txE_Total.EditValue) : 0;
             
                DetProv.dc_Observacion = Convert.ToString(txt_observacion.EditValue).Trim();
                ListCbteDet.Add(DetProv);
                UC_Diario.setDetalle(ListCbteDet);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void Imprimir()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default )
                {
                   
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XCXP_NATU_Rpt011_rpt reporte_natu = new XCXP_NATU_Rpt011_rpt();

                        reporte_natu.set_parametros(param.IdEmpresa, Info_notaCredDeb.IdTipoCbte_Nota, Info_notaCredDeb.IdCbteCble_Nota);
                        reporte_natu.RequestParameters = true;

                        reporte_natu.ShowPreviewDialog();

                        break;
                   
                    default:
                        XCXP_Rpt007_Rpt reporte = new XCXP_Rpt007_Rpt();
                        reporte.set_parametros(Info_notaCredDeb.IdEmpresa, Info_notaCredDeb.IdTipoCbte_Nota, Info_notaCredDeb.IdCbteCble_Nota);
                        reporte.RequestParameters = true;
                        reporte.ShowPreviewDialog();
                        break;
                }

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_NotaDebito_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                paramCP_B = new cp_parametros_Bus();
                InfoParam_cxp = paramCP_B.Get_Info_parametros(param.IdEmpresa);

                dtE_Fecha.EditValue = DateTime.Now;
                dtE_FecEmision.EditValue = DateTime.Now;
                dtE_Fecha_Contabilizacion.EditValue = DateTime.Now;
                dtE_Fecha_vencimiento.EditValue = DateTime.Now;


                if (InfoParam_cxp.pa_TipoCbte_NC == null || InfoParam_cxp.pa_TipoCbte_NC == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera la Nota de Débito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }


                else if (InfoParam_cxp.pa_ctacble_iva == null || InfoParam_cxp.pa_ctacble_iva == "")
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar la Cuenta IVA para Generar la Nota de Débito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (InfoParam_cxp.pa_TipoCbte_NC_anulacion == null || InfoParam_cxp.pa_TipoCbte_NC_anulacion == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Anula la Nota de Débito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                txE_IVA.EditValue = param.iva.porcentaje.ToString();
                cargar_Combos();

                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                set_accion_in_controls();
            
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_NotaDebito_Mant_event_frmCP_NotaDebito_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                GeneraDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_Subtotal0_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double BaseImponible = 0;

                BaseImponible = Convert.ToDouble(txE_SubtotalIva.EditValue) + Convert.ToDouble(txE_Subtotal0.EditValue);

                txE_BaseImponible.EditValue = BaseImponible;
                if (cmbCodigoIce.EditValue != null )
                {
                    if(Convert.ToDouble(cmbCodigoIce.EditValue) != 0)                  
                    txE_BaseIce.EditValue = txE_BaseImponible.EditValue;
                    txE_montoIce.EditValue = (Convert.ToDouble(txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue)) / 100;
                }
                suma();

                if (InfoProveedor != null)
                {
                    if (BaseImponible > 0)
                    {
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                            GeneraDiario();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_SubtotalIva_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                txE_BaseImponible.EditValue = Convert.ToDouble(txE_SubtotalIva.EditValue) + Convert.ToDouble(txE_Subtotal0.EditValue);
                txE_ValorIva.EditValue = (Convert.ToDouble(txE_IVA.EditValue) * Convert.ToDouble(txE_SubtotalIva.EditValue)) / 100;

                if (cmbCodigoIce.EditValue != null)
                {
                    if (Convert.ToDouble(cmbCodigoIce.EditValue) != 0)
                    txE_BaseIce.EditValue = txE_BaseImponible.EditValue;
                    txE_montoIce.EditValue = (Convert.ToDouble(txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue)) / 100;
                }
                suma();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCodigoIce_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCodigoIce.EditValue != null)
                {
                    if (Convert.ToDouble(cmbCodigoIce.EditValue) != 0)
                   {
                       cp_codigo_SRI_Info ice = (cp_codigo_SRI_Info)cmbCodigoIce.Properties.View.GetFocusedRow();
                       txE_PICE.EditValue = ice.co_porRetencion;
                       txE_BaseIce.EditValue = txE_BaseImponible.EditValue;

                       UC_Diario.LimpiarGrid();                   
                   }
                }
                else
                {

                    this.txE_PICE.EditValue = 0;
                    this.txE_BaseIce.EditValue = 0;

                    UC_Diario.LimpiarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_BaseIce_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txE_montoIce.EditValue = (Convert.ToDouble(txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue)) / 100;
                suma();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mmE_Observacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var detalle = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info;
                foreach (var item in detalle)
                {
                    item.dc_Observacion = Convert.ToString(txt_observacion.EditValue);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_numNota_Validating(object sender, CancelEventArgs e)
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

        private void cmbLocalExt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbLocalExt.EditValue == "Local")
                {
                    label35.Visible = false;
                    cmbPais.Visible = false;
                    grupo_convenioDobleTributacion.Visible = false;
                    grupo_PagoSujetoRetencion.Visible = false;
                }
                else
                {
                    label35.Visible = true;
                    cmbPais.Visible = true;
                    grupo_convenioDobleTributacion.Visible = true;
                    grupo_PagoSujetoRetencion.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_serie2_Validating(object sender, CancelEventArgs e)
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

        private void txE_serie1_Validating(object sender, CancelEventArgs e)
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

        private void txE_Saldo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Valor = Convert.ToDouble(txE_Saldo.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoNota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoNota.EditValue != null)
                {

                    if (cmbTipoNota.EditValue.ToString() == "T_TIP_NOTA_INT")
                    {
                        gbDatosP_DatosIce.Visible = false;
                        gbDatosP_Otros.Visible = false;

                        txE_Servicio.EditValue = 0;
                        txE_valorServicio.EditValue = 0;
                        txE_BaSeguros.EditValue = 0;
                        cmbCodigoIce.EditValue = null;
                        txE_PICE.EditValue = 0;
                        txE_montoIce.EditValue = 0;
                        txE_BaseIce.EditValue = 0;
                        cmbSustenTribut.EditValue = null;
                        cmbTipoServicio.EditValue = null;
                        cmbTipoLocalidad.EditValue = null;
                        txE_DocuModifica.EditValue = null;
                        txeIdNumAutoriza.EditValue = null;
                        txE_serie1.EditValue = null;
                        txE_serie2.EditValue = null;
                        txeNumDocum.EditValue = null;
                        txE_serie1.Visible = false;
                        txE_serie2.Visible = false;
                        txeIdNumAutoriza.Visible = false;
                        tm_hora_aut.Visible=false;
                        group_aut.Visible = false;
                        txeNumDocum.Visible = false;
                        dteFecAutoriza.Visible = false;
                        lbl_AutSri.Visible = false;
                        lbl_Documento.Visible = false;
                        lbl_FechAut.Visible = false;
                        lbl_Serie1.Visible = false;
                        lbl_Serie2.Visible = false;
                        lbl_numDocu.Visible = false;
                    }
                    else if (cmbTipoNota.EditValue.ToString() == "T_TIP_NOTA_SRI")
                    {
                        gbDatosP_DatosIce.Visible = true;
                        gbDatosP_Otros.Visible = true;

                        txE_serie1.Visible = true;
                        txE_serie2.Visible = true;
                        txeIdNumAutoriza.Visible = true;
                        txeNumDocum.Visible = true;
                        dteFecAutoriza.Visible = true;
                        tm_hora_aut.Visible = true;
                        group_aut.Visible = true;
                        lbl_AutSri.Visible = true;
                        lbl_Documento.Visible = true;
                        lbl_FechAut.Visible = true;
                        lbl_Serie1.Visible = true;
                        lbl_Serie2.Visible = true;
                        lbl_numDocu.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmCP_NotaDebito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCP_NotaDebito_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeNumDocum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                 string msg = "";

                 
                 if (txE_NotaCre.EditValue != null)
                 {
                     if (Bus_notaCrDeb.VericarNumDocumento(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, txE_serie1.Text, txE_serie1.Text, Convert.ToString(txeNumDocum.EditValue), (txE_NotaCre.EditValue == "") ? 0 : Convert.ToDecimal(txE_NotaCre.EditValue), Convert.ToInt32(InfoParam_cxp.pa_TipoCbte_ND), ref msg) == true)
                     {
                         MessageBox.Show("En la Nota de Crédito #: " + msg + " ya está ingresado este número de Documento: " + txeNumDocum.EditValue + " .. Cámbielo para poder continuar ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                         this.txeNumDocum.Focus();
                     }
                 }
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_BaSeguros_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txE_Servicio.EditValue = (Convert.ToDouble(txE_BaSeguros.EditValue) * (Convert.ToDouble(txE_valorServicio.EditValue) / 100));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txE_valorServicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txE_Servicio.EditValue = (Convert.ToDouble(txE_BaSeguros.EditValue) * (Convert.ToDouble(txE_valorServicio.EditValue) / 100));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeNumDocum_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //validar secuencial 
                string secuencia_aux = "";
                string secuencia = "";

                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    if (Convert.ToString(txeNumDocum.EditValue).Length < 9)
                    {
                        int conta = Convert.ToString(txeNumDocum.EditValue).Length;
                        int diferencia = 9 - conta;

                        secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                        secuencia = secuencia_aux + txeNumDocum.EditValue;

                        txeNumDocum.EditValue = secuencia;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_SubtotalIva_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double BaseImpo = 0;

                BaseImpo = Convert.ToDouble(txE_SubtotalIva.EditValue) + Convert.ToDouble(txE_Subtotal0.EditValue);

                txE_BaseImponible.EditValue = BaseImpo;

                txE_ValorIva.EditValue = (Convert.ToDouble(txE_IVA.EditValue) * Convert.ToDouble(txE_SubtotalIva.EditValue) / 100);

                if (!String.IsNullOrEmpty(Convert.ToString(cmbCodigoIce.EditValue)))
                {
                    txE_BaseIce.EditValue = txE_BaseImponible.EditValue;
                    txE_montoIce.EditValue = Convert.ToDouble(txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue) / 100;
                }
                suma();
                if (InfoProveedor != null)
                {
                   if (BaseImpo > 0)
                   {
                       if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                           GeneraDiario();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtE_Fecha_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                dtE_Fecha_Contabilizacion.EditValue = e.NewValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtE_Fecha_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtE_Fecha_Contabilizacion.EditValue = dtE_Fecha.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
