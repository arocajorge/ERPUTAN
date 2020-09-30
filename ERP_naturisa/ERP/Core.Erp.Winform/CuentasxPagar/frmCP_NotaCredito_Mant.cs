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
using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Info.class_sri.NotaCredito;
using Core.Erp.Winform.General;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Cus.Erp.Reports.Naturisa.CuentasxPagar;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_NotaCredito_Mant : Form
    {

        public delegate void delegate_frmCP_NotaCredito_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_NotaCredito_Mant_FormClosing event_frmCP_NotaCredito_Mant_FormClosing;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        bool Cargar_cancelacion = true;

        #region Variables


        cp_parametros_Bus BusParam;
        cp_parametros_Info InfoParam = new cp_parametros_Info();

        cp_catalogo_Bus BusCatalogo ;
        cp_proveedor_Bus BusProveedor ;
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        
        ba_TipoFlujo_Bus BusTipoFlujo ;

        ct_Plancta_Bus BusPlanCta ;
        ct_Centro_costo_Bus BusCentroCosto;
        cp_codigo_SRI_Bus dat_ti ;
        cp_reembolso_Bus Reem_B;
        
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cp_nota_DebCre_Bus notaCr_B = new cp_nota_DebCre_Bus();
        
        
        ct_Periodo_Bus Per_B ;
        ct_Periodo_Info Per_I = new ct_Periodo_Info();

        vwba_Cbte_Ban_detallePagos_Bus _CbteBan_B ;
        vwba_ordenGiroPendientes_Bus OGP_B ;
        cp_orden_pago_cancelaciones_Bus bus_PagoCance;

        List<ct_Cbtecble_det_Info> _ListaCbteCbleDet ;
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();


        List<vwba_ordenGiroPendientes_Info> Lst_OGP_I = new List<vwba_ordenGiroPendientes_Info>();
        List<vwba_Cbte_Ban_detallePagos_Info> lm = new List<vwba_Cbte_Ban_detallePagos_Info>();
        List<vwcp_orden_pago_con_cancelacion_Info> lista_Cancelacion;
        
        
        cp_nota_DebCre_Info notaCr_I= new cp_nota_DebCre_Info() ;
        
        
        BindingList<vwcp_orden_pago_con_cancelacion_Info> BindList_Cancelacion;


        int _IdTipoCbte;
        int IdTipoCbteRev;
        decimal IdCbteCbleRev;
        decimal idCbteCble ;
        string cod_CbteCble = "";

        private Cl_Enumeradores.eTipo_action _Accion;

        string motiAnulacion, msg2 = "";
        string MensajeError = "";

        vwcp_orden_pago_con_cancelacion_Info info_OPxCance;

        double Valor = 0;
        double total = 0, valorApagar = 0, Vsaldo = 0;
        double saldo = 0;
        double sumaT = 0;

        #endregion

        public frmCP_NotaCredito_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged;
            event_frmCP_NotaCredito_Mant_FormClosing += frmCP_NotaCredito_Mant_event_frmCP_NotaCredito_Mant_FormClosing;

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
                buscar_ops();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscar_ops()
        {
            try
            {
                if (Cargar_cancelacion)
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        UC_Diario.LimpiarGrid();    
                    }
                    
                    if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                    {
                        //consulta cancelaciones x pagar
                        vwcp_orden_pago_con_cancelacion_Bus bus_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();
                        lista_Cancelacion = new List<vwcp_orden_pago_con_cancelacion_Info>();

                        lista_Cancelacion = bus_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(param.IdEmpresa, "FACT_PROVEE", ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, "APRO");

                        if (lista_Cancelacion.Count != 0)
                        {
                            BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(lista_Cancelacion);
                            gridControl_OPxCancelar.DataSource = BindList_Cancelacion;
                        }
                        else
                        {
                            BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                            gridControl_OPxCancelar.DataSource = BindList_Cancelacion;

                        }
                    }
                } 
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

                if (Anular())
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
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
                if(validaColumna())
                {
                    if (Accion_Grabar())
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
                 if(validaColumna())
                 {
                     if (Accion_Grabar())
                     {
                         _Accion = Cl_Enumeradores.eTipo_action.grabar;
                         Limpiar();
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
              
               
                                                                                            
                //carga Tipo Nota
                BusCatalogo = new cp_catalogo_Bus();
                var TipoNota = BusCatalogo.Get_List_catalogo("T_TIP_NOTA");
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
                cmbCodigoIce.Properties.ValueMember= "IdCodigo_SRI";

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
                CbteCble_I = new ct_Cbtecble_Info();      
                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = (CbteCble_I.IdTipoCbte == 0) ? _IdTipoCbte : CbteCble_I.IdTipoCbte;
                CbteCble_I.IdCbteCble = Convert.ToDecimal(txE_NotaCre.Text == "" ? "0" : txE_NotaCre.Text);
                CbteCble_I.CodCbteCble = "";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(dtE_FecCtble.EditValue);
                CbteCble_I.cb_Valor = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info.FindAll(q => q.dc_Valor > 0).Sum(q => q.dc_Valor);
                CbteCble_I.cb_Observacion = Convert.ToString(mmE_Observacion.EditValue).Trim();
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = Convert.ToDateTime(dtE_Fecha.EditValue).Year;
                CbteCble_I.Mes = Convert.ToDateTime(dtE_Fecha.EditValue).Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                _ListaCbteCbleDet = get_CbteCble_det();
                CbteCble_I._cbteCble_det_lista_info = _ListaCbteCbleDet;

                return CbteCble_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }
       
        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {
            double valor;
            try
            {

                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                _ListaCbteCbleDet = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info;
            
                foreach (var dte in _ListaCbteCbleDet)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = notaCr_I.IdCbteCble_Nota;
                    dte.IdTipoCbte = _IdTipoCbte;
                }
                return _ListaCbteCbleDet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
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

                notaCr_I.IdEmpresa = Convert.ToInt32(param.IdEmpresa);            
                notaCr_I.IdCbteCble_Nota = (txE_NotaCre.EditValue == null) ? 0 : Convert.ToDecimal(txE_NotaCre.EditValue);
                notaCr_I.IdTipoCbte_Nota = (notaCr_I.IdTipoCbte_Nota == 0) ? _IdTipoCbte : notaCr_I.IdTipoCbte_Nota;


                notaCr_I.cn_baseImponible = Convert.ToDouble(txE_BaseImponible.EditValue);
                notaCr_I.cn_BaseSeguro = Convert.ToDecimal(txE_BaSeguros.EditValue);
                notaCr_I.cn_fecha = Convert.ToDateTime(dtE_Fecha.EditValue);
                notaCr_I.cn_Fecha_vcto = Convert.ToDateTime(dtE_FecVenci.EditValue);
                notaCr_I.Fecha_contable = Convert.ToDateTime(dtE_FecCtble.EditValue);
            
                if (dteFecAutoriza.EditValue == null)
                {
                    notaCr_I.fecha_autorizacion = null;
                }
                else
                {
                    notaCr_I.fecha_autorizacion = FechaAu;                
                }
                            
                notaCr_I.cn_Ice_base = Convert.ToDouble(txE_BaseIce.EditValue);
                notaCr_I.cn_Ice_por = Convert.ToDouble(txE_PICE.EditValue);
                notaCr_I.cn_Ice_valor = Convert.ToDouble(txE_montoIce.EditValue);
                notaCr_I.cn_observacion = Convert.ToString(mmE_Observacion.EditValue).Trim();
                notaCr_I.cn_Por_iva = Convert.ToDouble(txE_IVA.EditValue);
                notaCr_I.cn_serie1 = String.IsNullOrEmpty(Convert.ToString(txE_serie1.EditValue)) ? null : Convert.ToString(txE_serie1.EditValue).Trim();
                notaCr_I.cn_serie2 = String.IsNullOrEmpty(Convert.ToString(txE_serie2.EditValue)) ? null : Convert.ToString(txE_serie2.EditValue).Trim();
                notaCr_I.cn_Serv_por = (txE_Servicio.EditValue== null) ? 0 : Convert.ToDouble(txE_Servicio.EditValue);
                notaCr_I.cn_Serv_valor = (txE_valorServicio.EditValue == null) ? 0 : Convert.ToDouble(txE_valorServicio.EditValue);
                notaCr_I.cn_subtotal_iva = (txE_SubtotalIva.EditValue == null) ? 0 : Convert.ToDouble(txE_SubtotalIva.EditValue);
                notaCr_I.cn_subtotal_siniva = (txE_Subtotal0.EditValue == null) ? 0 : Convert.ToDouble(txE_Subtotal0.EditValue);
                notaCr_I.cn_total = (txE_Total.EditValue == null) ? 0 : Convert.ToDecimal(txE_Total.EditValue);
                if (cmbTipoNota.EditValue == "T_TIP_NOTA_INT")
                    notaCr_I.cn_vaCoa = "N";
                else
                    if (cmbTipoNota.EditValue == "T_TIP_NOTA_SRI")
                        notaCr_I.cn_vaCoa = "S";

                notaCr_I.cn_valoriva = (txE_ValorIva.EditValue == null) ? 0 : Convert.ToDouble(txE_ValorIva.EditValue);
                notaCr_I.Estado = (notaCr_I.Estado == "I") ? notaCr_I.Estado : "A";
                notaCr_I.Fecha_Transac = param.Fecha_Transac;
                notaCr_I.Fecha_UltMod = param.Fecha_Transac;      
                notaCr_I.cn_Autorizacion = Convert.ToString(txeIdNumAutoriza.EditValue);
                notaCr_I.IdCod_ICE = Convert.ToInt32(cmbCodigoIce.EditValue);
                
                notaCr_I.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                
                notaCr_I.IdTipoServicio = Convert.ToString(cmbTipoServicio.EditValue);
                notaCr_I.IdUsuario = param.IdUsuario;
                notaCr_I.IdUsuarioUltAnu = param.IdUsuario;
                notaCr_I.IdUsuarioUltMod = param.IdUsuario;
                notaCr_I.ip = param.ip;
                notaCr_I.MotivoAnu = "";
                notaCr_I.nom_pc = param.nom_pc;
                notaCr_I.IdCtaCble_IVA = InfoParam.pa_ctacble_iva;
                notaCr_I.Fecha_UltAnu = param.Fecha_Transac;
                notaCr_I.cn_tipoLocacion = Convert.ToString(cmbTipoLocalidad.EditValue);           
                notaCr_I.cn_Nota = Convert.ToString(txeNumDocum.EditValue);           
                notaCr_I.DebCre = "C";
                notaCr_I.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;

                if (cmbTipoFlujo.get_TipoFlujoInfo() == null)
                    notaCr_I.IdTipoFlujo = null;
                else
                    notaCr_I.IdTipoFlujo = cmbTipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;


                if (cmbSustenTribut.EditValue == null || cmbSustenTribut.EditValue == "")
                    notaCr_I.IdIden_credito = null;
                else
                    notaCr_I.IdIden_credito = Convert.ToInt32(cmbSustenTribut.EditValue);
                notaCr_I.cod_nota = txtCodigo.Text;
                notaCr_I.PagoLocExt = (cmbLocalExt.EditValue == "Local") ? "LOC" : "EXT";
                notaCr_I.PaisPago = Convert.ToString(cmbPais.EditValue);
                notaCr_I.ConvenioTributacion = (rb_aplicConvDobTribSI.Checked == true) ? "SI" : (rb_aplicConvDobTribNO.Checked == true) ? "NO" : "NA";
                notaCr_I.PagoSujetoRetencion = (rb_pagExtSujRetNorLegSI.Checked == true) ? "SI" : (rb_pagExtSujRetNorLegNO.Checked == true) ? "NO" : "NA";
                notaCr_I.IdTipoNota = Convert.ToString(cmbTipoNota.EditValue);
                notaCr_I.cn_Autorizacion_Imprenta = "";
                notaCr_I.cn_num_doc_modificado = Convert.ToString(txE_DocuModifica.EditValue);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<cp_orden_pago_cancelaciones_Info> List_Orden_Pago_Cancelaciones_Info = new List<cp_orden_pago_cancelaciones_Info>();

        public void Get_Cancelacion()
        {
            try
            {
                int i = 0;

                foreach (var item in this.BindList_Cancelacion)
                {
                    if (item.Check == true)
                    {
                        cp_orden_pago_cancelaciones_Info opcsinfo = new cp_orden_pago_cancelaciones_Info();
                        opcsinfo.IdEmpresa = param.IdEmpresa;
                        opcsinfo.Idcancelacion = 0;
                        opcsinfo.Secuencia = i++;

                        opcsinfo.IdEmpresa_op = item.IdEmpresa;
                        opcsinfo.IdOrdenPago_op = item.IdOrdenPago;
                        opcsinfo.Secuencia_op = item.Secuencia_OP;
                        opcsinfo.IdTipo_op = item.IdTipo_op;

                        opcsinfo.IdEmpresa_op_padre = null;
                        opcsinfo.IdOrdenPago_op_padre = null;
                        opcsinfo.Secuencia_op_padre = null;

                        opcsinfo.IdEmpresa_cxp = item.IdEmpresa_cxp;	//AbajoGrid
                        opcsinfo.IdTipoCbte_cxp = item.IdTipoCbte_cxp;	//AbajoGrid
                        opcsinfo.IdCbteCble_cxp = item.IdCbteCble_cxp;	//AbajoGrid

                        opcsinfo.IdEmpresa_pago = Convert.ToInt32(param.IdEmpresa);             //Nota de Credito
                        opcsinfo.IdTipoCbte_pago = _IdTipoCbte;	                                //Nota de Credito
                        opcsinfo.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;	            //Nota de Credito

                        opcsinfo.MontoAplicado = item.Valor_aplicado;
                        opcsinfo.SaldoAnterior = item.Valor_estimado_a_pagar_OP;
                        opcsinfo.SaldoActual = item.Saldo_x_Pagar_OP;

                        opcsinfo.Observacion = Convert.ToString(mmE_Observacion.EditValue);
                        opcsinfo.fechaTransaccion = Convert.ToDateTime(dtE_Fecha.EditValue).Date;

                        List_Orden_Pago_Cancelaciones_Info.Add(opcsinfo);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(cp_nota_DebCre_Info info)
        {
            try
            {
                notaCr_I = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_notaCr()
        {
            try
            {
                txE_BaseImponible.EditValue = Convert.ToDouble(notaCr_I.cn_baseImponible);
                txE_BaSeguros.EditValue = notaCr_I.cn_BaseSeguro;
                dtE_Fecha.EditValue = notaCr_I.cn_fecha;
                if (notaCr_I.fecha_autorizacion != null && notaCr_I.fecha_autorizacion != DateTime.MinValue)
                {
                    dteFecAutoriza.EditValue = Convert.ToDateTime(notaCr_I.fecha_autorizacion.Value.Date.ToShortDateString());
                    tm_hora_aut.EditValue = notaCr_I.fecha_autorizacion.Value.TimeOfDay;
                }
                txE_BaseIce.EditValue = Convert.ToDouble(notaCr_I.cn_Ice_base);
                txE_PICE.EditValue = notaCr_I.cn_Ice_por;
                txE_montoIce.EditValue = Convert.ToDouble(notaCr_I.cn_Ice_valor);
                txE_IVA.EditValue = notaCr_I.cn_Por_iva;
                txE_serie1.EditValue = notaCr_I.cn_serie1;
                txE_serie2.EditValue = notaCr_I.cn_serie2;
                txE_Servicio.EditValue = notaCr_I.cn_Serv_por;
                if (notaCr_I.IdProveedor != null)
                {
                    Cargar_cancelacion = false;
                    ucCp_Proveedor1.set_ProveedorInfo(notaCr_I.IdProveedor);
                }
                txE_valorServicio.EditValue = Convert.ToDouble(notaCr_I.cn_Serv_valor);
                txE_SubtotalIva.EditValue = Convert.ToDouble(notaCr_I.cn_subtotal_iva);
                txE_Subtotal0.EditValue = Convert.ToDouble(notaCr_I.cn_subtotal_siniva);
                txE_Total.EditValue = notaCr_I.cn_total;
                txE_Saldo.EditValue = notaCr_I.Saldo;
                txE_ValorIva.EditValue = Convert.ToDecimal(notaCr_I.cn_valoriva);
                lblAnulado.Visible = (notaCr_I.Estado == "I") ? true : false;
                lblAnulado.Text = "Anulado con el #Cbt.Cble.: " + notaCr_I.IdCbteCble_Anulacion + " Tipo Cbt.Cble.: " + notaCr_I.IdTipoCbte_Anulacion;
                txeIdNumAutoriza.EditValue = notaCr_I.cn_Autorizacion;
                txE_NotaCre.EditValue = notaCr_I.IdCbteCble_Nota.ToString();
                cmbCodigoIce.EditValue = notaCr_I.IdCod_ICE;
                cmbTipoNota.EditValue = notaCr_I.IdTipoNota;
                ucGe_Sucursal_combo1.set_SucursalInfo(Convert.ToInt32(notaCr_I.IdSucursal));
                cmbTipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(notaCr_I.IdTipoFlujo));
                cmbSustenTribut.EditValue = notaCr_I.IdIden_credito;
                _IdTipoCbte = notaCr_I.IdTipoCbte_Nota;
                cmbTipoServicio.EditValue = notaCr_I.IdTipoServicio;
                notaCr_I.MotivoAnu = "";
                cmbTipoLocalidad.EditValue = notaCr_I.cn_tipoLocacion;
                txeNumDocum.EditValue = notaCr_I.cn_Nota;
                txE_DocuModifica.EditValue = notaCr_I.cn_num_doc_modificado;
                cmbLocalExt.EditValue = (notaCr_I.PagoLocExt == "LOC") ? "Local" : "Exterior";
                cmbPais.EditValue = notaCr_I.PaisPago;
                if (notaCr_I.ConvenioTributacion == "SI")
                    rb_aplicConvDobTribSI.Checked = true;
                else if (notaCr_I.ConvenioTributacion == "NO")
                    rb_aplicConvDobTribNO.Checked = true;
                if (notaCr_I.PagoSujetoRetencion == "SI")
                    rb_pagExtSujRetNorLegSI.Checked = true;
                else if (notaCr_I.PagoSujetoRetencion == "NO")
                    rb_pagExtSujRetNorLegNO.Checked = true;
                dtE_FecCtble.EditValue = notaCr_I.Fecha_contable == null ? DateTime.Now : (DateTime)notaCr_I.Fecha_contable;
                txtCodigo.Text = notaCr_I.cod_nota;

                set_PagadosOG();
                set_CbteCbleInfo();

                
             
                string mensaje = "";
                bus_PagoCance = new cp_orden_pago_cancelaciones_Bus();
                List<cp_orden_pago_cancelaciones_Info> lista_PagoCance = new List<cp_orden_pago_cancelaciones_Info>();

                lista_Cancelacion = new List<vwcp_orden_pago_con_cancelacion_Info>();

                lista_PagoCance = bus_PagoCance.ConsultaGeneral_Cancelacion_x_Pagos(notaCr_I.IdEmpresa, notaCr_I.IdTipoCbte_Nota, notaCr_I.IdCbteCble_Nota, ref mensaje);
                double saldo = 0;
                if (lista_PagoCance.Count != 0)
                {

                    foreach (var item in lista_PagoCance)
                    {
                        vwcp_orden_pago_con_cancelacion_Info info_cance = new vwcp_orden_pago_con_cancelacion_Info();

                        info_cance.IdOrdenPago = Convert.ToDecimal(item.IdOrdenPago_op);
                        info_cance.Nom_Beneficiario_2 = item.pr_nombre;
                        info_cance.Referencia = item.Referencia;
                        info_cance.Fecha_OP = item.Fecha;
                        info_cance.IdTipo_op = item.IdTipo_op;
                        info_cance.Valor_estimado_a_pagar_OP = item.SaldoAnterior;
                        info_cance.Saldo_x_Pagar_OP = item.SaldoActual;
                        info_cance.Valor_aplicado = item.MontoAplicado;

                        saldo = saldo + item.MontoAplicado;
                        lista_Cancelacion.Add(info_cance);

                    }

                    txe_Saldo_NC.EditValue = Convert.ToDouble(txE_Saldo.EditValue) - saldo;
                }
                else
                { 
                  if(_Accion==Cl_Enumeradores.eTipo_action.actualizar)
                  {
                      //consulta cancelaciones x pagar
                      vwcp_orden_pago_con_cancelacion_Bus bus_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();
                      lista_Cancelacion = new List<vwcp_orden_pago_con_cancelacion_Info>();

                      lista_Cancelacion = bus_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(param.IdEmpresa, "", ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, "APRO");

                      if (lista_Cancelacion.Count != 0)
                      {
                          BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(lista_Cancelacion);
                          gridControl_OPxCancelar.DataSource = BindList_Cancelacion;

                          txe_Saldo_NC.EditValue = Convert.ToDouble(txE_Saldo.EditValue);

                          colCheck.Visible = true;
                          colTotal_cancelado_OP.Visible = true;
                          colIdCtaCble_can.Visible = true;
                          colValor_aplicado.OptionsColumn.AllowEdit = true;
                          colValor_aplicado.Caption = "valor a Cancelar";

                      }

                      txe_Saldo_NC.EditValue = Convert.ToDouble(txE_Saldo.EditValue);                 
                  }
                               
                }
                Cargar_cancelacion = true;
                mmE_Observacion.EditValue = notaCr_I.cn_observacion;
                BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(lista_Cancelacion);
                gridControl_OPxCancelar.DataSource = BindList_Cancelacion;
                                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_PagadosOG()
        {
            try
            {
                Lst_OGP_I.Clear();
                _CbteBan_B = new vwba_Cbte_Ban_detallePagos_Bus();
                lm = _CbteBan_B.Get_List_Cbte_Ban_detallePagos(notaCr_I.IdEmpresa, notaCr_I.IdTipoCbte_Nota, notaCr_I.IdCbteCble_Nota);
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

        public void set_CbteCbleInfo()
        {
            try
            {
                if (notaCr_I.IdCbteCble_Nota != 0)
                {
                    UC_Diario.setAccion(_Accion);
                    UC_Diario.setInfo(notaCr_I.IdEmpresa, notaCr_I.IdTipoCbte_Nota, notaCr_I.IdCbteCble_Nota);
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
            try
            {
                _Accion = Accion;

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_en_controles()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        txE_NotaCre.Properties.ReadOnly = true;
                        txE_NotaCre.BackColor = System.Drawing.Color.White;

                        lblAnulado.Visible = false;

                        
                        
                        cmbLocalExt.EditValue = "Local";

                        btn_Eliminar_ApRe_NC.Enabled = false;

                        dtE_Fecha.EditValue = DateTime.Now;
                        dtE_FecVenci.EditValue = DateTime.Now;
                        dteFecAutoriza.EditValue = DateTime.Now;
                        dtE_FecCtble.EditValue = DateTime.Now;

                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_notaCr();

                        //ucCp_Proveedor1.Perfil_Lectura();

                        cmbTipoNota.Properties.ReadOnly = true;
                        cmbTipoNota.BackColor = System.Drawing.Color.White;

                        colCheck.Visible = false;
                        colTotal_cancelado_OP.Visible = false;
                        colIdCtaCble_can.Visible = false;
                        colValor_aplicado.OptionsColumn.AllowEdit = false;
                        colValor_aplicado.Caption = "valor Cancelado";

                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntAnular = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_notaCr();
                        bloquear_Controles();
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        



                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);

                        colCheck.Visible = false;
                        colTotal_cancelado_OP.Visible = false;
                        colIdCtaCble_can.Visible = false;
                        colValor_aplicado.OptionsColumn.AllowEdit = false;
                        colValor_aplicado.Caption = "valor Cancelado";

                        btn_Eliminar_ApRe_NC.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_notaCr();
                        
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        bloquear_Controles();
                        UC_Diario.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        colCheck.Visible = false;
                        colTotal_cancelado_OP.Visible = false;
                        colIdCtaCble_can.Visible = false;
                        colValor_aplicado.OptionsColumn.AllowEdit = false;
                        colValor_aplicado.Caption = "valor Cancelado";
                        btn_Eliminar_ApRe_NC.Enabled = false;
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

        private void bloquear_Controles()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Enabled_bntLimpiar = false;
             
                dtE_Fecha.Properties.ReadOnly = true;
                dtE_Fecha.BackColor = System.Drawing.Color.White;

                dteFecAutoriza.Properties.ReadOnly = true;
                dteFecAutoriza.BackColor = System.Drawing.Color.White;
             
                mmE_Observacion.Properties.ReadOnly = true;
                mmE_Observacion.BackColor = System.Drawing.Color.White;

                txE_SubtotalIva.Properties.ReadOnly = true;
                txE_SubtotalIva.BackColor = System.Drawing.Color.White;

                txE_Subtotal0.Properties.ReadOnly = true;
                txE_Subtotal0.BackColor = System.Drawing.Color.White;

                txE_Servicio.Properties.ReadOnly = true;
                txE_Servicio.BackColor = System.Drawing.Color.White;

                txE_valorServicio.Properties.ReadOnly = true;
                txE_valorServicio.BackColor = System.Drawing.Color.White;

                txE_BaseIce.Properties.ReadOnly = true;
                txE_BaseIce.BackColor = System.Drawing.Color.White;

                txE_BaSeguros.Properties.ReadOnly = true;
                txE_BaSeguros.BackColor = System.Drawing.Color.White;
           
                txeIdNumAutoriza.Properties.ReadOnly = true;
                txeIdNumAutoriza.BackColor = System.Drawing.Color.White;

                txE_serie1.Properties.ReadOnly = true;
                txE_serie1.BackColor = System.Drawing.Color.White;
       
                txE_serie2.Properties.ReadOnly = true;
                txE_serie2.BackColor = System.Drawing.Color.White;
             
                txeNumDocum.Properties.ReadOnly = true;
                txeNumDocum.BackColor = System.Drawing.Color.White;
             
                txE_NotaCre.Properties.ReadOnly = true;
                txE_NotaCre.BackColor = System.Drawing.Color.White;

                txE_IVA.Properties.ReadOnly = true;
                txE_IVA.BackColor = System.Drawing.Color.White;

                txE_ValorIva.Properties.ReadOnly = true;
                txE_ValorIva.BackColor = System.Drawing.Color.White;

                txE_BaseImponible.Properties.ReadOnly = true;
                txE_BaseImponible.BackColor = System.Drawing.Color.White;

                txE_Total.Properties.ReadOnly = true;
                txE_Total.BackColor = System.Drawing.Color.White;

                txE_Saldo.Properties.ReadOnly = true;
                txE_Saldo.BackColor = System.Drawing.Color.White;

                txE_SumatoriaOG.Properties.ReadOnly = true;
                txE_SumatoriaOG.BackColor = System.Drawing.Color.White;
            
                txE_DocuModifica.Properties.ReadOnly = true;
                txE_DocuModifica.BackColor = System.Drawing.Color.White;

                txE_PICE.Properties.ReadOnly = true;
                txE_PICE.BackColor = System.Drawing.Color.White;

                txE_montoIce.Properties.ReadOnly = true;
                txE_montoIce.BackColor = System.Drawing.Color.White;

                cmbPais.Properties.ReadOnly = true;
                cmbPais.BackColor = System.Drawing.Color.White;

                cmbCodigoIce.Properties.ReadOnly = true;
                cmbCodigoIce.BackColor = System.Drawing.Color.White;
         
                //ucCon_PlanCtaCmb1.cmbPlanCta_Enable(true);

                cmbTipoServicio.Properties.ReadOnly = true;
                cmbTipoServicio.BackColor = System.Drawing.Color.White;

                cmbTipoLocalidad.Properties.ReadOnly = true;
                cmbTipoLocalidad.BackColor = System.Drawing.Color.White;

                cmbLocalExt.Properties.ReadOnly = true;
                cmbLocalExt.BackColor = System.Drawing.Color.White;

                cmbSustenTribut.Properties.ReadOnly = true;
                cmbSustenTribut.BackColor = System.Drawing.Color.White;
             
                ucCp_Proveedor1.Perfil_Lectura();

                cmbTipoNota.Properties.ReadOnly = true;
                cmbTipoNota.BackColor = System.Drawing.Color.White;

                //cmbTipoFlujo.Properties.ReadOnly = true;
                //cmbTipoFlujo.BackColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            try
            {
                _Accion= Cl_Enumeradores.eTipo_action.grabar;
                
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
                txE_ValorIva.EditValue = null;
                txE_BaseImponible.EditValue = null;
                txE_Total.EditValue = null;
                txE_Saldo.EditValue = null;
                txE_SumatoriaOG.EditValue = null;           
                txE_DocuModifica.EditValue = null;
                txE_PICE.EditValue = null;
                txE_montoIce.EditValue = null;
                cmbPais.EditValue = null;
                cmbCodigoIce.EditValue = null;
                //ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();            
                cmbTipoServicio.EditValue = null;
                cmbTipoLocalidad.EditValue = null;
                cmbLocalExt.EditValue = null;
                cmbSustenTribut.EditValue = null;          

                //ucCon_CentroCosto_ctas_Movi1.Inicializar_cmbCentroCosto();
             
                ucCp_Proveedor1.Inicializar_cmbProveedor();
                ucGe_Sucursal_combo1.get_SucursalInfo();
                
                cmbTipoFlujo.Inicializar_TipoFlujo();
            
                dtE_Fecha.EditValue = DateTime.Now;
                dteFecAutoriza.EditValue = DateTime.Now;
           
                BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                gridControl_OPxCancelar.DataSource = BindList_Cancelacion;
                UC_Diario.LimpiarGrid();

                CbteCble_I = new ct_Cbtecble_Info();
                notaCr_I = new cp_nota_DebCre_Info();
                List_Orden_Pago_Cancelaciones_Info = new List<cp_orden_pago_cancelaciones_Info>();
                mmE_Observacion.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Grabar()
        {
            Boolean res = true;
            try
            {
                

                this.mmE_Observacion.Focus();
                get_Cbtecble();
                string msg = "";
                string msg2 = "";
                get_notaCr();
                
                     
                        if (Convert.ToString(cmbTipoNota.EditValue) == "T_TIP_NOTA_SRI")
                       {
                           notaCr_B = new cp_nota_DebCre_Bus();
                            
                            if (notaCr_B.Existe_NumNotaCredito_Proveedor(param.IdEmpresa, Convert.ToDecimal(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor), Convert.ToString(txE_serie1.EditValue), Convert.ToString(txE_serie2.EditValue), Convert.ToString(txeNumDocum.EditValue), "C", Convert.ToString(cmbTipoNota.EditValue)))
                           {
                               MessageBox.Show("La Nota de Crédito#: " + notaCr_I.cn_serie1 + "-" + notaCr_I.cn_serie2 + "-" +notaCr_I.cn_Nota +  ". Ya se encuentra ingresada");
                               res = false;
                               return false;
                           }
                       
                       }
                       
                       
                            txE_NotaCre.EditValue= idCbteCble.ToString();
                              notaCr_I.IdCbteCble_Nota = idCbteCble;
                              notaCr_I.Info_CbteCble_X_Nota = CbteCble_I;

                           notaCr_B = new cp_nota_DebCre_Bus();
                           string mesError = "";
                           Get_Cancelacion();

                           if (notaCr_B.GrabarDB(notaCr_I, ref mesError))
                           {
                                
                               string mensaje = "";
                               cp_orden_pago_cancelaciones_Bus bus_pagoCance = new cp_orden_pago_cancelaciones_Bus();

                               foreach (var item in List_Orden_Pago_Cancelaciones_Info)
                               {
                                   if (item.IdOrdenPago_op>0)
                                   {
                                       item.IdEmpresa_pago=notaCr_I.IdEmpresa;
                                       item.IdCbteCble_pago=notaCr_I.IdCbteCble_Nota;
                                       item.IdTipoCbte_pago=notaCr_I.IdTipoCbte_Nota;
                                       bus_pagoCance.GuardarDB(item, param.IdEmpresa, ref mensaje);
                                   }
                                   else
                                   {
                                       //// no hay OP hay q generarla
                                       cp_orden_pago_Bus BusOP = new cp_orden_pago_Bus();
                                       cp_orden_pago_Info InfoOP = new cp_orden_pago_Info();
                                       cp_orden_pago_det_Info Info_det_OP = new cp_orden_pago_det_Info();
                                       List<cp_orden_pago_det_Info> List_Info_det_OP = new List<cp_orden_pago_det_Info>();
                                       decimal IdOP = 0;

                                       InfoOP.IdEmpresa = param.IdEmpresa;
                                       InfoOP.IdEntidad = notaCr_I.IdProveedor;
                                       InfoOP.IdEstadoAprobacion = "APRO";
                                       InfoOP.IdFormaPago = "EFEC";
                                       InfoOP.IdTipo_Persona = "PROVEE";
                                       InfoOP.IdOrdenPago = 0;
                                       InfoOP.IdPersona = ucCp_Proveedor1.get_ProveedorInfo().IdPersona;
                                       InfoOP.IdProveedor = notaCr_I.IdProveedor;
                                       InfoOP.IdTipo_op = item.IdTipo_op;
                                       InfoOP.Observacion = "O/P x NC Generada y Conciliada..";
                                       InfoOP.Saldo = 0;
                                       InfoOP.Total_cancelado = Convert.ToDecimal(item.MontoAplicado);
                                       InfoOP.Total_OP = Convert.ToDecimal(item.MontoAplicado);

                                       /////////////

                                       Info_det_OP.IdEmpresa = InfoOP.IdEmpresa;
                                       Info_det_OP.IdOrdenPago = 0;
                                       Info_det_OP.Secuencia = 1;

                                       Info_det_OP.IdEmpresa_cxp = item.IdEmpresa_cxp;
                                       Info_det_OP.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                                       Info_det_OP.IdCbteCble_cxp = item.IdCbteCble_cxp;

                                       Info_det_OP.Valor_a_pagar = item.MontoAplicado;
                                       Info_det_OP.Referencia = "";

                                       Info_det_OP.IdFormaPago = "EFEC";
                                       Info_det_OP.Fecha_Pago = DateTime.Now;
                                       Info_det_OP.IdEstadoAprobacion = "APRO";

                                       Info_det_OP.Idbanco = 1;

                                       Info_det_OP.IdUsuario_Aproba = param.IdUsuario;
                                       Info_det_OP.fecha_hora_Aproba = DateTime.Now;
                                       Info_det_OP.Motivo_aproba = "x conciliacion con NC cxp";
                                       
                                       List_Info_det_OP.Add(Info_det_OP);
                                       InfoOP.Detalle = List_Info_det_OP;
 
                                       BusOP.GuardaDB(InfoOP, ref IdOP, ref mensaje);



                                       item.IdEmpresa_pago = notaCr_I.IdEmpresa;
                                       item.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;
                                       item.IdTipoCbte_pago = notaCr_I.IdTipoCbte_Nota;
                                       item.IdEmpresa_op = InfoOP.IdEmpresa;
                                       item.IdOrdenPago_op = IdOP;
                                       item.Secuencia = 1;
                                       item.Secuencia_op = Info_det_OP.Secuencia;
                                       item.Observacion = "Conciliacion desde pantalla NC ";
                                       bus_pagoCance.GuardarDB(item, param.IdEmpresa, ref mensaje);

                                   }
                               }






                               string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Nota de Crédito ", notaCr_I.IdCbteCble_Nota);
                               MessageBox.Show(smensaje, param.Nombre_sistema);                
                               if (MessageBox.Show("Desea Imprimir el documento", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                               {                                 
                                   ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(new object(), new EventArgs());
                               }
                               Limpiar();
                            
                         }
                        else
                        {
                            string smensaje = param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas);
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

        private Boolean Actualizar()
        {

            try
            {
                Boolean Respuesta = false;
                string msg = "";

              

                this.mmE_Observacion.Focus();

                get_Cbtecble();
                get_notaCr();


                   notaCr_I.Info_CbteCble_X_Nota = CbteCble_I;
                    Respuesta=notaCr_B.ModificarDB(notaCr_I);
                    if (Respuesta)
                    {

                               Get_Cancelacion();

                                
                                cp_orden_pago_cancelaciones_Bus bus_pagoCance = new cp_orden_pago_cancelaciones_Bus();

                                int IdCancelacion = 0;

                                foreach (var item in List_Orden_Pago_Cancelaciones_Info)
                                {
                                    if (item.IdOrdenPago_op > 0)
                                    {
                                        item.IdEmpresa_pago = notaCr_I.IdEmpresa;
                                        item.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;
                                        item.IdTipoCbte_pago = notaCr_I.IdTipoCbte_Nota;
                                        bus_pagoCance.GuardarDB(item, param.IdEmpresa, ref msg);
                                    }
                                    else
                                    {
                                        //// no hay OP hay q generarla
                                        cp_orden_pago_Bus BusOP = new cp_orden_pago_Bus();
                                        cp_orden_pago_Info InfoOP = new cp_orden_pago_Info();
                                        cp_orden_pago_det_Info Info_det_OP = new cp_orden_pago_det_Info();
                                        List<cp_orden_pago_det_Info> List_Info_det_OP = new List<cp_orden_pago_det_Info>();
                                        decimal IdOP = 0;

                                        InfoOP.IdEmpresa = param.IdEmpresa;
                                        InfoOP.IdEntidad = notaCr_I.IdProveedor;
                                        InfoOP.IdEstadoAprobacion = "APRO";
                                        InfoOP.IdFormaPago = "EFEC";
                                        InfoOP.IdTipo_Persona = "PROVEE";
                                        InfoOP.IdOrdenPago = 0;
                                        InfoOP.IdPersona = ucCp_Proveedor1.get_ProveedorInfo().IdPersona;
                                        InfoOP.IdProveedor = notaCr_I.IdProveedor;
                                        InfoOP.IdTipo_op = item.IdTipo_op;
                                        InfoOP.Observacion = "O/P x NC Generada y Conciliada..";
                                        InfoOP.Saldo = 0;
                                        InfoOP.Total_cancelado = Convert.ToDecimal(item.MontoAplicado);
                                        InfoOP.Total_OP = Convert.ToDecimal(item.MontoAplicado);

                                        /////////////

                                        Info_det_OP.IdEmpresa = InfoOP.IdEmpresa;
                                        Info_det_OP.IdOrdenPago = 0;
                                        Info_det_OP.Secuencia = 1;

                                        Info_det_OP.IdEmpresa_cxp = item.IdEmpresa_cxp;
                                        Info_det_OP.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                                        Info_det_OP.IdCbteCble_cxp = item.IdCbteCble_cxp;

                                        Info_det_OP.Valor_a_pagar = item.MontoAplicado;
                                        Info_det_OP.Referencia = "";

                                        Info_det_OP.IdFormaPago = "EFEC";
                                        Info_det_OP.Fecha_Pago = DateTime.Now;
                                        Info_det_OP.IdEstadoAprobacion = "APRO";

                                        Info_det_OP.Idbanco = 1;

                                        Info_det_OP.IdUsuario_Aproba = param.IdUsuario;
                                        Info_det_OP.fecha_hora_Aproba = DateTime.Now;
                                        Info_det_OP.Motivo_aproba = "x conciliacion con NC cxp";

                                        List_Info_det_OP.Add(Info_det_OP);
                                        InfoOP.Detalle = List_Info_det_OP;

                                        BusOP.GuardaDB(InfoOP, ref IdOP, ref msg);



                                        item.IdEmpresa_pago = notaCr_I.IdEmpresa;
                                        item.IdCbteCble_pago = notaCr_I.IdCbteCble_Nota;
                                        item.IdTipoCbte_pago = notaCr_I.IdTipoCbte_Nota;
                                        item.IdEmpresa_op = InfoOP.IdEmpresa;
                                        item.IdOrdenPago_op = IdOP;
                                        item.Secuencia = 1;
                                        item.Secuencia_op = Info_det_OP.Secuencia;
                                        item.Observacion = "Conciliacion desde pantalla NC ";
                                        bus_pagoCance.GuardarDB(item, param.IdEmpresa, ref msg);

                                    }
                                }

                        

                                if (Respuesta)
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Nota de Crédito ", txE_NotaCre.EditValue);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    Limpiar();
                                }
                    }
                    else
                    {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
               

                return Respuesta;                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        
        }

        private Boolean Anular()
        {
            try
            {

                Boolean Respuesta = false;
                string msg = "";

                _IdTipoCbte = Convert.ToInt32(InfoParam.pa_TipoCbte_NC);
                IdTipoCbteRev = Convert.ToInt32(InfoParam.pa_TipoCbte_NC_anulacion);

                this.mmE_Observacion.Focus();

                //get_Cbtecble();
                //get_CbteCble_det();
                
                //get_notaCr();


                
                        if (notaCr_I.Estado != "I")
                        {
                            if (MessageBox.Show("¿Está seguro que desea anular la Nota de Crédito # " + notaCr_I.IdCbteCble_Nota + " ?", "Anulación de Nota de Crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                motiAnulacion = fr.motivoAnulacion;
                                CbteCble_B = new ct_Cbtecble_Bus();
                                Respuesta=CbteCble_B.ReversoCbteCble(param.IdEmpresa, notaCr_I.IdCbteCble_Nota, notaCr_I.IdTipoCbte_Nota, IdTipoCbteRev, ref IdCbteCbleRev, ref msg2, param.IdUsuario);

                                if (Respuesta)
                                {
                                    notaCr_I.MotivoAnu = motiAnulacion;
                                    notaCr_I.IdUsuarioUltAnu = param.IdUsuario;
                                    notaCr_I.Fecha_UltAnu = param.Fecha_Transac;
                                    notaCr_I.IdTipoCbte_Anulacion = IdTipoCbteRev;
                                    notaCr_I.IdCbteCble_Anulacion = IdCbteCbleRev;

                                    notaCr_B = new cp_nota_DebCre_Bus();
                                    Respuesta = notaCr_B.AnularDB(notaCr_I);
                                    if (Respuesta)
                                    {
                                        MessageBox.Show("Nota de Crédito Anulado Exitosamente...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                        MessageBox.Show("No se pudo Anular la Nota de Crédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                else
                                    MessageBox.Show("No se pudo Reversar el Comprobante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                

                            }
                        }
                        else
                        {
                            MessageBox.Show("Esta Nota de Crédito ya está Anulada...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Respuesta = false;
                        }


                        return Respuesta;
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    respuesta = Grabar();
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    respuesta = Actualizar();
                }
                return respuesta;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }
        
        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;
                Per_B = new ct_Periodo_Bus();
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtE_Fecha.EditValue),ref MensajeError);

                if (Per_I.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoNota.EditValue == null )
                {
                    MessageBox.Show("Antes de continuar debe seleccionar el Tipo de Nota", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoNota.Focus();
                    return false;
                }
               
                if (ucCp_Proveedor1.get_ProveedorInfo() == null )
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCp_Proveedor1.Focus();
                    return false;
                }

                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null )
                {
                    MessageBox.Show("Antes de continuar debe seleccionar la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_combo1.Focus();
                    return false;
                }

                if (Convert.ToDouble(txE_BaseImponible.EditValue) <= 0)
                {
                    MessageBox.Show("Base imponible no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txE_BaseImponible.Focus();
                    return false;
                }
           
                if (Convert.ToString(cmbTipoNota.EditValue) == "T_TIP_NOTA_SRI")
                {
                    if (cmbTipoServicio.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar el tipo de Servico", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbTipoServicio.Focus();
                        return false;
                    }

                    if (txeIdNumAutoriza.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Autorización y # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txeIdNumAutoriza.Focus();
                        return false;
                    }
                    
                    if (Convert.ToDouble(txE_serie1.EditValue) == 0 || txE_serie1.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de serie 1", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txE_serie1.Focus();
                        return false;
                    }

                    if (Convert.ToDouble(txE_serie2.EditValue) == 0 || txE_serie2.EditValue == null)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de serie 2", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txE_serie2.Focus();
                        return false;
                    }

                    if ( Convert.ToDouble(txeNumDocum.EditValue) == 0)
                    {
                        MessageBox.Show("Antes de continuar debe ingresar el Número de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txeNumDocum.Focus();
                        return false;
                    }

                    if ( cmbTipoLocalidad.EditValue == null)
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

                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtE_Fecha.EditValue)))
                        return false;

                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtE_FecCtble.EditValue)))
                        return false;
                }
                else
                {
                    dteFecAutoriza.EditValue = null;
                
                }

                if (!UC_Diario.ValidarAsientosContables())
                    return false;
                if (UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info.Count < 1)
                {
                    MessageBox.Show("Antes de continuar debe dar clic en el botón Contabilizar para general el Diario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (mmE_Observacion.Text.Trim()=="")
                {
                    MessageBox.Show("Antes de continuar debe ingresar la observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mmE_Observacion.Focus();
                    return false;
                }
                /* NO SE NECESITA PARA EL REPORTE DE TIPO FLUJO
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        if (cmbTipoFlujo.get_TipoFlujoInfo() == null)
                        {
                            MessageBox.Show("Antes de continuar debe seleccionar Tipo De Flujo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cmbTipoFlujo.Focus();
                            return false;
                        }
                        break;                   
                }*/
            
                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void fxSuma()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    total = Math.Round(Convert.ToDouble(Convert.ToDouble(txE_BaseImponible.EditValue) +Convert.ToDouble( txE_ValorIva.EditValue) + Convert.ToDouble(txE_valorServicio.EditValue) + Convert.ToDouble(txE_montoIce.EditValue)),2);
                    txE_Total.EditValue = total;
                    Vsaldo = Math.Round(total - Convert.ToDouble(txE_SumatoriaOG.EditValue),2);
                    txE_Saldo.EditValue = Vsaldo.ToString();

                    txe_Saldo_NC.EditValue = Vsaldo.ToString();
                    saldo = Vsaldo;

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
              

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar el Proveedor.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucCp_Proveedor1.Focus();
                    return;

                }

              //  txE_SubtotalIva
                
                if (Convert.ToDouble(txE_BaseImponible.EditValue) <= 0)
                {
                    MessageBox.Show("Para generar el diario la Base Imponible debe ser mayor a 0, Por favor ingrese los valores de la Nota de Crédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //debito o credito

                UC_Diario.LimpiarGrid();

                // CTA GASTO
                List<ct_Cbtecble_det_Info> ListCbteDet = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_det_Info DetGto = new ct_Cbtecble_det_Info();

                DetGto.IdCtaCble = null;
                DetGto.IdCentroCosto = null;


                DetGto.dc_Observacion = Convert.ToString(mmE_Observacion.EditValue).Trim();
                DetGto.dc_Valor = (Convert.ToDouble(txE_BaseImponible.EditValue) > 0) ? (Convert.ToDouble(txE_BaseImponible.EditValue) +
                        ((txE_montoIce.EditValue == null) ? 0 : Convert.ToDouble(txE_montoIce.EditValue))) * -1 : 0;

                DetGto.dc_Valor_H = (Convert.ToDouble(txE_BaseImponible.EditValue) > 0) ? (Convert.ToDouble(txE_BaseImponible.EditValue) +
                        ((txE_montoIce.EditValue == null) ? 0 : Convert.ToDouble(txE_montoIce.EditValue))) : 0;
               
                ListCbteDet.Add(DetGto);

                // IVA POR PAGAR

                if (Convert.ToDouble(txE_ValorIva.EditValue) > 0)
                {
                    ct_Cbtecble_det_Info DetIVA = new ct_Cbtecble_det_Info();

                    DetIVA.IdCtaCble = InfoParam.pa_ctacble_iva;


                    DetIVA.IdCentroCosto = null;

                    DetIVA.dc_Observacion = Convert.ToString(mmE_Observacion.EditValue).Trim();
                    DetIVA.dc_Valor = (Convert.ToDouble(txE_ValorIva.EditValue) > 0) ? Convert.ToDouble(txE_ValorIva.EditValue) * -1 : 0;
                    DetIVA.dc_Valor_H = (Convert.ToDouble(txE_ValorIva.EditValue) > 0) ? Convert.ToDouble(txE_ValorIva.EditValue) : 0;

                    ListCbteDet.Add(DetIVA);
                }

                //PROVEEDOR
                ct_Cbtecble_det_Info DetProv = new ct_Cbtecble_det_Info();

                DetProv.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;

                DetProv.IdCentroCosto = null;

                DetProv.dc_Valor = (Convert.ToDouble(txE_Total.EditValue) > 0) ? Convert.ToDouble(txE_Total.EditValue) : 0;              
                DetProv.dc_Observacion = Convert.ToString(mmE_Observacion.EditValue).Trim();
                ListCbteDet.Add(DetProv);
                UC_Diario.setDetalle(ListCbteDet);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            try
            {
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XCXP_NATU_Rpt011_rpt reporte_natu = new XCXP_NATU_Rpt011_rpt();
                        
                        IdEmpresa = param.IdEmpresa;
                        IdTipoCbte = Convert.ToInt32(notaCr_I.IdTipoCbte_Nota);
                        IdCbteCble = Convert.ToDecimal(notaCr_I.IdCbteCble_Nota);
                        
                        reporte_natu.set_parametros(IdEmpresa, IdTipoCbte, IdCbteCble);
                        reporte_natu.RequestParameters = true;
                        reporte_natu.ShowPreviewDialog();

                        break;
                    default:
                        XCXP_Rpt006_Rpt reporte = new XCXP_Rpt006_Rpt();
                          
                        decimal IdCtaCble_Nota= 0;

                        IdEmpresa = param.IdEmpresa;
                        IdCtaCble_Nota = Convert.ToDecimal(txE_NotaCre.EditValue);

                        reporte.set_parametros(IdEmpresa, notaCr_I.IdCbteCble_Nota);
                        reporte.RequestParameters = true;

                        ReportPrintTool pt = new ReportPrintTool(reporte);
                        pt.ShowPreviewDialog();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void frmCP_NotaCredito_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                BusParam = new cp_parametros_Bus();
                InfoParam = BusParam.Get_Info_parametros(param.IdEmpresa);
                if (InfoParam.pa_TipoCbte_NC == null || InfoParam.pa_TipoCbte_NC == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera la Nota de Crédito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                else if (InfoParam.pa_ctacble_iva == null || InfoParam.pa_ctacble_iva == "")
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar la Cuenta IVA para Generar la Nota de Crédito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                else if (InfoParam.pa_TipoCbte_NC_anulacion == null || InfoParam.pa_TipoCbte_NC_anulacion == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Anula la Nota de Crédito.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                _IdTipoCbte = Convert.ToInt32(InfoParam.pa_TipoCbte_NC);
                IdTipoCbteRev = Convert.ToInt32(InfoParam.pa_TipoCbte_NC_anulacion);

                BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                gridControl_OPxCancelar.DataSource = BindList_Cancelacion;

                txE_IVA.EditValue = param.iva.porcentaje.ToString();
                cargar_Combos();

                _Accion = (_Accion == 0) ? Cl_Enumeradores.eTipo_action.grabar : _Accion;

                set_accion_en_controles();

            }
            catch (Exception ex) 
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_NotaCredito_Mant_event_frmCP_NotaCredito_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
                double BaseImpo = 0;
                BaseImpo= Math.Round(Convert.ToDouble(txE_SubtotalIva.EditValue) + Convert.ToDouble(txE_Subtotal0.EditValue),2);

                txE_BaseImponible.EditValue = BaseImpo;
                if (cmbCodigoIce.EditValue != null)
                {
                    txE_BaseIce.EditValue= txE_BaseImponible.EditValue;
                    txE_montoIce.EditValue = Math.Round((Convert.ToDouble( txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue)) / 100,2);
                }

                UC_Diario.LimpiarGrid();
                fxSuma();
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

        private void txE_SubtotalIva_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                txE_BaseImponible.EditValue = Math.Round(Convert.ToDouble(txE_SubtotalIva.EditValue) + Convert.ToDouble(txE_Subtotal0.EditValue),2);
                txE_ValorIva.EditValue =Math.Round( ( Convert.ToDouble(txE_IVA.EditValue) * Convert.ToDouble(txE_SubtotalIva.EditValue)) / 100,2);

                if (cmbCodigoIce.EditValue != null)
                {
                   txE_BaseIce.EditValue = txE_BaseImponible.EditValue;
                   txE_montoIce.EditValue =  Math.Round( (Convert.ToDouble( txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue)) / 100,2);
                }
                fxSuma();
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

                    if (cmbCodigoIce.Properties.View.GetFocusedRow() != null)
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
                    this.txE_BaseIce.EditValue= 0;

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
                fxSuma();
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
                    item.dc_Observacion = Convert.ToString(mmE_Observacion.EditValue);
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
                if (cmbLocalExt.EditValue=="Local")
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
                 if (cmbTipoNota.EditValue.ToString() == "T_TIP_NOTA_INT")
                {
                    gbDatosP_DatosIce.Visible = false;
                    gbDatosP_Otros.Visible = false;
                    txE_Servicio.EditValue = 0;
                    txE_valorServicio.EditValue= 0;
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
                    txeNumDocum.Visible = false;
                    dteFecAutoriza.Visible = false;
                    lbl_AutSri.Visible = false;
                    lbl_Documento.Visible = false;
                    lbl_FechAut.Visible = false;
                    lbl_Serie1.Visible = false;
                    lbl_Serie2.Visible = false;
                    lbl_numDocu.Visible = false;
                    tm_hora_aut.Visible = false;
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
                    lbl_AutSri.Visible = true;
                    lbl_Documento.Visible = true;
                    lbl_FechAut.Visible = true;
                    lbl_Serie1.Visible = true;
                    lbl_Serie2.Visible = true;
                    lbl_numDocu.Visible = true;
                    tm_hora_aut.Visible = false;
                }
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmCP_NotaCredito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmCP_NotaCredito_Mant_FormClosing(sender, e);
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
                notaCr_B = new cp_nota_DebCre_Bus();
                string numDocum = "";
                decimal numNotaCre = 0;
                numDocum = Convert.ToString(txeNumDocum.EditValue);
                numNotaCre = (txE_NotaCre.EditValue == "" || txE_NotaCre.EditValue == null) ? 0 : Convert.ToDecimal(txE_NotaCre.EditValue);

                if (numDocum!="")
                {
                    if (notaCr_B.VericarNumDocumento(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, txE_serie1.Text, txE_serie2.Text, numDocum, numNotaCre, _IdTipoCbte, ref msg) == true)
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
        
        decimal? IdBeneficiario = 0;
        
        private void btn_Eliminar_ApRe_NC_Click(object sender, EventArgs e)
        {
               try
               {
                   if (MessageBox.Show("¿Está seguro que Desea borrar Todas estas Aplicaciones Realizadas para esta Nota de Crédito?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       string mensaje = "";
                       bus_PagoCance = new cp_orden_pago_cancelaciones_Bus();
                       
                       if (bus_PagoCance.Eliminar_OrdenPagoCancelaciones(param.IdEmpresa, _IdTipoCbte, Convert.ToDecimal(txE_NotaCre.EditValue), ref mensaje))
                       {

                           //consulta cancelaciones x pagar
                           vwcp_orden_pago_con_cancelacion_Bus bus_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();
                           lista_Cancelacion = new List<vwcp_orden_pago_con_cancelacion_Info>();

                           lista_Cancelacion = bus_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(param.IdEmpresa, "", ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, "APRO");

                           if (lista_Cancelacion.Count != 0)
                           {
                               BindList_Cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(lista_Cancelacion);
                               gridControl_OPxCancelar.DataSource = BindList_Cancelacion;
                               txe_Saldo_NC.EditValue = Convert.ToDouble(txE_Saldo.EditValue);
                               colCheck.Visible = true;
                               colTotal_cancelado_OP.Visible = true;
                               colIdCtaCble_can.Visible = true;
                               colValor_aplicado.OptionsColumn.AllowEdit = true;
                               colValor_aplicado.Caption = "valor a Cancelar";
                           }
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
                txE_Servicio.EditValue = (Convert.ToDouble(txE_BaSeguros.EditValue) * (Convert.ToDouble(txE_valorServicio.EditValue)/100));
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

        private void btn_ImportarXML_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string path = "";
                        path = openFileDialog1.FileName;

                        notaCredito InfoNotaCredito_SRI = new notaCredito();

                        string numAutoriza = "";
                        DateTime fechAutoriza = new DateTime();

                        tb_Proceso_SRI_Bus bus_proSri = new tb_Proceso_SRI_Bus();
                        InfoNotaCredito_SRI = bus_proSri.Deserializar_NotaCredito_SRI(path, ref numAutoriza, ref fechAutoriza);

                        //llenado de campos

                        txE_serie1.EditValue = InfoNotaCredito_SRI.infoTributaria.estab;
                        txE_serie2.EditValue = InfoNotaCredito_SRI.infoTributaria.ptoEmi;
                        txeNumDocum.EditValue = InfoNotaCredito_SRI.infoTributaria.secuencial;
                        dtE_Fecha.EditValue = Convert.ToDateTime(InfoNotaCredito_SRI.infoNotaCredito.fechaEmision);
                        mmE_Observacion.EditValue = InfoNotaCredito_SRI.infoNotaCredito.motivo;

                        txE_DocuModifica.EditValue = InfoNotaCredito_SRI.infoNotaCredito.numDocModificado;

                        // no viene   txeIdNumAutoriza.EditValue = numAutoriza;
                        //no viene   dteFecAutoriza.EditValue = fechAutoriza;
                       // cmbTipoDocu.EditValue = InfoNotaCredito_SRI.infoFactura.tipoIdentificacionComprador;

                        txE_BaseImponible.EditValue = InfoNotaCredito_SRI.infoNotaCredito.totalSinImpuestos;

                        decimal sum_base_12 = 0;
                        decimal sum_base_0 = 0;
                        decimal sum_base_2 = 0;
                        decimal sum_base = 0;
                        decimal sum_base_12_tot = 0;
                        decimal sum_base_0_tot = 0;
                        decimal sum_valor_iva_12 = 0;

                        foreach (var item in InfoNotaCredito_SRI.detalles)
                        {
                            decimal base_12 = 0;
                            decimal base_0 = 0;
                            decimal valor_ice = 0;

                            int conta12 = 0;
                            int conta0 = 0;

                            foreach (var item2 in item.impuestos)
                            {

                                if (item2.codigo == "2")
                                {
                                    //  base_12 = 0;
                                    if (item2.codigoPorcentaje == "2")  //iva 12%
                                    {
                                        sum_valor_iva_12 = sum_valor_iva_12 + item2.valor;
                                    }
                                }

                                int cod_3 = item.impuestos.Count(q => q.codigo == "3");

                                if (cod_3 >= 1)
                                {
                                    //impuesto iva 2
                                    if (item2.codigo == "2")
                                    {
                                        //  base_12 = 0;
                                        if (item2.codigoPorcentaje == "2")  //iva 12%
                                        {
                                            base_12 = item2.baseImponible;
                                            conta12 = 1;
                                        }
                                        //  base_0 = 0;
                                        if (item2.codigoPorcentaje == "0") // iva 0%
                                        {
                                            base_0 = item2.baseImponible;
                                            conta0 = 1;

                                            //  valor_ice_0 = item2.valor;
                                        }
                                    }
                                    //impuesto ice 3
                                    //  valor_ice = 0;
                                    if (item2.codigo == "3")
                                    {
                                        valor_ice = item2.valor;

                                        if (conta12 == 1)
                                        {
                                            sum_base_12 = sum_base_12 + (base_12 - valor_ice);
                                        }

                                        if (conta0 == 1)
                                        {
                                            sum_base_0 = sum_base_0 + (base_0 - valor_ice);
                                        }
                                    }
                                }
                                else
                                {
                                    //impuesto iva 2
                                    if (item2.codigo == "2")
                                    {
                                        //  base_12 = 0;
                                        if (item2.codigoPorcentaje == "2")  //iva 12%
                                        {
                                            base_12 = item2.baseImponible;
                                            sum_base_2 = sum_base_2 + base_12;
                                        }
                                        //  base_0 = 0;
                                        if (item2.codigoPorcentaje == "0") // iva 0%
                                        {
                                            base_0 = item2.baseImponible;
                                            sum_base = sum_base + base_0;
                                        }
                                    }
                                }
                            }       // for impuesto
                            sum_base_12_tot = sum_base_12 + sum_base_2;
                            sum_base_0_tot = sum_base_0 + sum_base;
                        }     // for detalle

                        txE_ValorIva.EditValue = sum_valor_iva_12;
                        txE_SubtotalIva.EditValue = sum_base_12_tot;
                        txE_Subtotal0.EditValue = sum_base_0_tot;

                        txE_Total.EditValue = InfoNotaCredito_SRI.infoNotaCredito.valorModificacion;
                    }                               
                }
            }
            catch (Exception ex )
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

                txE_BaseImponible.EditValue = Math.Round(BaseImpo,2);

                txE_ValorIva.EditValue = Math.Round((Convert.ToDouble(txE_IVA.EditValue) * Convert.ToDouble(txE_SubtotalIva.EditValue) / 100),2);

                if (!String.IsNullOrEmpty(Convert.ToString(cmbCodigoIce.EditValue)))
                {
                    txE_BaseIce.EditValue = txE_BaseImponible.EditValue;
                    txE_montoIce.EditValue = Convert.ToDouble(txE_BaseIce.EditValue) * Convert.ToDouble(txE_PICE.EditValue) / 100;
                }
                fxSuma();
                UC_Diario.LimpiarGrid();

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

        double TotalSuma_Aplicada= 0;        

        private void gridView_OPxCancelar_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                

                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }

                info_OPxCance = new vwcp_orden_pago_con_cancelacion_Info();
                info_OPxCance = (vwcp_orden_pago_con_cancelacion_Info)gridView_OPxCancelar.GetFocusedRow();


                

                if (e.Column.Name == "colCheck")
                {
                   

                    //cuando quita el check
                    if ((bool)gridView_OPxCancelar.GetFocusedRowCellValue(colCheck))
                    {

                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck, false);
                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, false);


                        foreach (var item2 in BindList_Cancelacion)
                        {
                            if (item2.Check_aux == false)
                            {
                                if (item2.Saldo_x_Pagar_OP == 0)
                                {
                                    item2.Saldo_x_Pagar_OP = Math.Round(item2.Valor_aplicado,2);
                                    item2.Valor_aplicado = 0;

                                }
                                else
                                {
                                    item2.Saldo_x_Pagar_OP = Math.Round(item2.Saldo_x_Pagar_OP + item2.Valor_aplicado,2);
                                    item2.Valor_aplicado = 0;

                                }

                            }
                        }

                        TotalSuma_Aplicada = 0;
                        foreach (var item2 in BindList_Cancelacion)
                        {
                            if (item2.Check == true)
                            {
                                TotalSuma_Aplicada = Math.Round(TotalSuma_Aplicada + item2.Valor_aplicado,2);
                            }
                        }


                        txtTotalValorAplicado.Text = TotalSuma_Aplicada.ToString();

                        txe_Saldo_NC.Text = Convert.ToString(Math.Round(Convert.ToDouble(txE_Saldo.Text) - TotalSuma_Aplicada,2));


                        gridControl_OPxCancelar.RefreshDataSource();

                    }
                    else
                    {
                        //cuando chequea

                        if (Convert.ToDouble(txe_Saldo_NC.Text) == 0)
                        {
                            MessageBox.Show("No Tiene saldo q aplicar verifique..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck, true);
                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, true);

                        TotalSuma_Aplicada = 0;

                        if (info_OPxCance.Saldo_x_Pagar_OP <= Convert.ToDouble( txe_Saldo_NC.Text))
                        {
                            info_OPxCance.Valor_aplicado = info_OPxCance.Saldo_x_Pagar_OP;
                            info_OPxCance.Saldo_x_Pagar_OP = 0;                            
                        }
                        else
                        {
                            info_OPxCance.Valor_aplicado =Math.Round( Convert.ToDouble(txe_Saldo_NC.Text),2);
                            info_OPxCance.Saldo_x_Pagar_OP = Math.Round(info_OPxCance.Saldo_x_Pagar_OP - Convert.ToDouble(txe_Saldo_NC.Text),2);
                        }


                        foreach (var item in BindList_Cancelacion)
                        {
                            if (item.Check == true)
                            {
                                TotalSuma_Aplicada =Math.Round(TotalSuma_Aplicada + item.Valor_aplicado,2);
                            }
                        }

                        txe_Saldo_NC.Text = Convert.ToString(Math.Round(Convert.ToDouble(txE_Saldo.Text) - TotalSuma_Aplicada,2));


                        txtTotalValorAplicado.Text = TotalSuma_Aplicada.ToString();
                        gridControl_OPxCancelar.RefreshDataSource();
                    }
                }

                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_OPxCancelar_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                info_OPxCance = new vwcp_orden_pago_con_cancelacion_Info();
                info_OPxCance = (vwcp_orden_pago_con_cancelacion_Info)gridView_OPxCancelar.GetFocusedRow();

                if (info_OPxCance == null) return;

                if (e.Column.Name == colValor_aplicado.Name)
                {
                    
                    if (info_OPxCance.Valor_aplicado <= info_OPxCance.Valor_a_pagar)
                    {
                        if (info_OPxCance.Valor_estimado_a_pagar_OP <= info_OPxCance.Valor_aplicado)
                        {
                            info_OPxCance.Valor_aplicado = info_OPxCance.Saldo_x_Pagar_OP;
                            info_OPxCance.Saldo_x_Pagar_OP = 0;
                        }
                        else
                        {
                            //info_OPxCance.Valor_aplicado = Math.Round(Convert.ToDouble(txe_Saldo_NC.Text), 2);
                            info_OPxCance.Saldo_x_Pagar_OP = Math.Round(info_OPxCance.Valor_estimado_a_pagar_OP - info_OPxCance.Valor_aplicado - info_OPxCance.Total_cancelado_OP, 2);
                        }
                        info_OPxCance.Check = info_OPxCance.Valor_aplicado == 0 ? false : true;

                        TotalSuma_Aplicada = 0;
                        foreach (var item in BindList_Cancelacion)
                        {
                            if (item.Check == true)
                            {
                                TotalSuma_Aplicada = Math.Round(TotalSuma_Aplicada + item.Valor_aplicado, 2);
                            }
                        }

                        txe_Saldo_NC.Text = Convert.ToString(Math.Round(Convert.ToDouble(txE_Saldo.Text) - TotalSuma_Aplicada, 2));
                        
                        txtTotalValorAplicado.Text = TotalSuma_Aplicada.ToString();
                        gridControl_OPxCancelar.RefreshDataSource();
                        
                    }                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_OPxCancelar_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                info_OPxCance = new vwcp_orden_pago_con_cancelacion_Info();
                info_OPxCance = (vwcp_orden_pago_con_cancelacion_Info)gridView_OPxCancelar.GetFocusedRow();

                if (info_OPxCance == null) return;

                if (Convert.ToDouble(txe_Saldo_NC.Text) == 0 || info_OPxCance.Valor_a_pagar < Convert.ToDouble(e.Value == "" ? 0 : e.Value))
                {
                    MessageBox.Show("No Tiene saldo q aplicar verifique..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridView_OPxCancelar.SetFocusedRowCellValue(colValor_aplicado, 0);
                    return;
                }

                if (e.Column.Name == colValor_aplicado.Name)
                {
                    gridView_OPxCancelar.SetFocusedRowCellValue(colValor_aplicado, Convert.ToDouble(e.Value == "" ? 0 : e.Value));
                }
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
                dtE_FecCtble.EditValue = dtE_Fecha.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_aprobar_doc_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    return;
                }

                frmCP_Aprobacion_Facturas_x_Pagar frmApro = new frmCP_Aprobacion_Facturas_x_Pagar();
                frmApro.StringBusqueda = ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                frmApro.event_frmCP_Aprobacion_Facturas_x_Pagar += frmApro_event_frmCP_Aprobacion_Facturas_x_Pagar;
                frmApro.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmApro_event_frmCP_Aprobacion_Facturas_x_Pagar(object sender, FormClosingEventArgs e)
        {
            try
            {
                buscar_ops();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
