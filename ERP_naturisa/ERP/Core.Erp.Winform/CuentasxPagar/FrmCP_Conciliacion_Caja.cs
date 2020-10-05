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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Bancos;

using Core.Erp.Winform.Controles;

using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Winform.Caja;
using Core.Erp.Reportes.Caja;
using Core.Erp.Winform.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_Caja : Form
    {
        #region Variables
        string cod_CbteCble = "";
        decimal IdProveedor;
        decimal IdCtaCble_Gasto;
        string Cta_Provedor;
        string CodTipoDoc = "";
        string MensajeError = "";
        decimal Nindice = 0;
        decimal NumConciliacion_Caja = 0;
        int IdTipoCbte_OP = 0;
        string NomProve = "";
        string TipoDocu = "";
        int secuencia_op = 0;
        int IdTipoCbte_EG = 0;
        decimal IdConciliacion_Caja = 0;
        string EstadoCierre = "";
        cp_orden_giro_Bus bus_og = new cp_orden_giro_Bus();
        public delegate void delegate_frmCP_Conciliacion_Caja_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Conciliacion_Caja_FormClosing event_frmCP_Conciliacion_Caja_FormClosing;
        List<ct_punto_cargo_Info> lista_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus punto_cargo_bus = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        FrmCa_Caja_Movimiento_Egreso frmCaja_Movi_Egreso = new FrmCa_Caja_Movimiento_Egreso();
        bool Modificar = true;
        cp_orden_giro_Info Info_OG = new cp_orden_giro_Info();
        ct_Cbtecble_Info info_CbteCble_x_OG = new ct_Cbtecble_Info();
        ct_Cbtecble_det_Bus bus_CbteCble_x_OG = new ct_Cbtecble_det_Bus();
        caj_Caja_Movimiento_Info fila_movi_caj = new caj_Caja_Movimiento_Info();
        Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCP_OrdenGiroMantenimiento_simplificada frm_og_simple;
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();

        List<ct_Periodo_Info> list_Periodo = new List<ct_Periodo_Info>();
        ct_Periodo_Bus Bus_Periodo = new ct_Periodo_Bus();
        ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();

        ct_Plancta_Bus Bus_PlanCta = new ct_Plancta_Bus();
        List<ct_Plancta_Info> List_PlanCta = new List<ct_Plancta_Info>();


        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info InfoCbte_CbteCble_I = new ct_Cbtecble_Info();
        ct_Cbtecble_Info InfoCbte_Cble_OP = new ct_Cbtecble_Info();

        ct_Cbtecble_det_Bus CbtDet_B = new ct_Cbtecble_det_Bus();
        List<ct_Cbtecble_det_Info> ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
        caj_parametro_Info Info_CajaParametro = new caj_parametro_Info();
        caj_parametro_Bus Bus_ParametrosCaja = new caj_parametro_Bus();

        caj_Caja_Info Info_caja = new caj_Caja_Info();
        caj_Caja_Bus Bus_Caja = new caj_Caja_Bus();
        List<caj_Caja_Info> lista_Caja = new List<caj_Caja_Info>();

        caj_Caja_Movimiento_Tipo_Info Info_CajaMoviTipo_I = new caj_Caja_Movimiento_Tipo_Info();
        caj_Caja_Movimiento_Tipo_Bus Bus_CajaMoviTipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        List<caj_Caja_Movimiento_Tipo_Info> List_Caja_Movimiento_Tipo = new List<caj_Caja_Movimiento_Tipo_Info>();

        caj_Caja_Movimiento_det_Info InfoMovCajaDet = new caj_Caja_Movimiento_det_Info();
        List<caj_Caja_Movimiento_det_Info> ListMovCajaDet = new List<caj_Caja_Movimiento_det_Info>();
        caj_Caja_Movimiento_Info Info_Caja_Movi_x_Egr_x_Vale = new caj_Caja_Movimiento_Info();
        List<caj_Caja_Movimiento_Info> Lista_Caja_Movi_x_Egr_Vale = new List<caj_Caja_Movimiento_Info>();

        cp_parametros_Info Info_Param_cxp = new cp_parametros_Info();
        cp_parametros_Bus Bus_Param_cxc = new cp_parametros_Bus();

        cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
        cp_proveedor_Autorizacion_Info Info_Autori_x_Prove = new cp_proveedor_Autorizacion_Info();
        cp_proveedor_Autorizacion_Bus Bus_Autori_x_Prove = new cp_proveedor_Autorizacion_Bus();
        List<cp_proveedor_Info> List_Prove_Info = new List<cp_proveedor_Info>();
        cp_proveedor_Info Info_Proveedor = new cp_proveedor_Info();

        cp_codigo_SRI_Bus Bus_Codigo_SRI_ = new cp_codigo_SRI_Bus();

        cp_conciliacion_caja_Bus Bus_ConciCaj_B = new cp_conciliacion_caja_Bus();
        cp_conciliacion_Caja_det_x_ValeCaja_Bus Bus_conciliacion_det_X_ValeCaj = new cp_conciliacion_Caja_det_x_ValeCaja_Bus();

        BindingList<cp_conciliacion_Caja_det_Info> BindingList_Conciliacion_det_x_FP = new BindingList<cp_conciliacion_Caja_det_Info>();
        BindingList<caj_Caja_Movimiento_Info> BindingList_conciliacion_det_x_ValeCaja = new BindingList<caj_Caja_Movimiento_Info>();
        BindingList<cp_conciliacion_Caja_det_Ing_Caja_Info> BindingList_conciliacion_det_x_Ing = new BindingList<cp_conciliacion_Caja_det_Ing_Caja_Info>();
        cp_conciliacion_Caja_det_Ing_Caja_Bus Ingreso_cajas_Bus = new cp_conciliacion_Caja_det_Ing_Caja_Bus();
        List<cp_catalogo_Info> lista_catalogo = new List<cp_catalogo_Info>();

        int rowHandle_val = 0;

        cp_TipoDocumento_Bus Bus_tipoDoc_B = new cp_TipoDocumento_Bus();
        cp_orden_pago_tipo_Info Info_Tipo_OP = new cp_orden_pago_tipo_Info();
        cp_orden_giro_Bus Bus_Orden_Giro_x_Pago = new cp_orden_giro_Bus();
        cp_retencion_Bus Bus_Retencion = new cp_retencion_Bus();
        cp_orden_giro_Info Info_Orden_G_Paga = new cp_orden_giro_Info();

        cp_retencion_Info Info_Retencion = new cp_retencion_Info();
        List<cp_retencion_det_Info> LstRetencion = new List<cp_retencion_det_Info>();
        cp_orden_pago_Info info_OP = new cp_orden_pago_Info();
        List<cp_orden_pago_tipo_Info> list_OrdenTipPago = new List<cp_orden_pago_tipo_Info>();

        cp_conciliacion_caja_Info Info_Conciliacion = new cp_conciliacion_caja_Info();
        cp_conciliacion_Caja_det_Info Fila_conciliacion_det_x_FP = new cp_conciliacion_Caja_det_Info();
        caj_Caja_Movimiento_Info Fila_x_ValeCaja = new caj_Caja_Movimiento_Info();
        cp_conciliacion_det_Bus Bus_ingresos_x_caja = new cp_conciliacion_det_Bus();

        ba_TipoFlujo_Bus b = new ba_TipoFlujo_Bus();

        List<caj_Caja_Movimiento_Tipo_Info> list_TipoMovimiento = new List<caj_Caja_Movimiento_Tipo_Info>();
        caj_Caja_Movimiento_Tipo_Bus Bus_TipoMovimiento = new caj_Caja_Movimiento_Tipo_Bus();
        List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info> list_TipoMovimiento_x_ctble = new List<caj_Caja_Movimiento_Tipo_x_CtaCble_Info>();
        caj_Caja_Movimiento_Tipo_x_CtaCble_Bus Bus_TipoMovimiento_x_ctble = new caj_Caja_Movimiento_Tipo_x_CtaCble_Bus();


        vwtb_persona_beneficiario_Bus Bus_Beneficiario_x_Vale_Caja = new vwtb_persona_beneficiario_Bus();
        List<vwtb_persona_beneficiario_Info> list_Beneficiario_ValeCaj = new List<vwtb_persona_beneficiario_Info>();
        vwtb_persona_beneficiario_Info Info_Persona_Beneficiario = new vwtb_persona_beneficiario_Info();

        List<ct_punto_cargo_grupo_Info> list_Grupo_PC = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_Grupo_PC = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_Grupo_PC = new ct_punto_cargo_grupo_Info();

        List<ct_Cbtecble_det_Info> list_CbteCble_x_Conci_caja = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_det_Bus bus_CbteCble_det = new ct_Cbtecble_det_Bus();
        #endregion

        public frmCP_Conciliacion_Caja()
        {
            try
            {
                InitializeComponent();

                this.event_frmCP_Conciliacion_Caja_FormClosing += new delegate_frmCP_Conciliacion_Caja_FormClosing(frmCP_Conciliacion_Caja_event_frmCP_Conciliacion_Caja_FormClosing);

                cmb_Proveedor.EditValueChanging += cmb_Proveedor_EditValueChanging;
                cmb_Proveedor.EditValueChanged += cmb_Proveedor_EditValueChanged;

                cmb_TipoDocu.EditValueChanging += cmb_TipoDocu_EditValueChanging;
                cmb_TipoDocu.EditValueChanged += cmb_TipoDocu_EditValueChanged;


                dTp_Fecha.Value = DateTime.Now;
                dtpFecha_OP.EditValue = DateTime.Now;




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Cbte_x_Conciliacion()
        {
            try
            {
                list_CbteCble_x_Conci_caja = bus_CbteCble_det.Get_list_CbteCble_x_cp_Conciliacion_caja(Info_Conciliacion.IdEmpresa, Info_Conciliacion.IdConciliacion_Caja);
                gridControlCbtes.DataSource = list_CbteCble_x_Conci_caja;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inicializar_Controles()
        {

            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;

                ultraCmbE_caja.EditValue = null;

                cmb_cta_cble_x_caja.Inicializar_cmbPlanCta();
                cmb_Estado.EditValue = lista_catalogo.FirstOrDefault().IdCatalogo;


                dTp_Fecha.Value = DateTime.Now;

                mEdit_Observacion.EditValue = "";

                BindingList_Conciliacion_det_x_FP = new BindingList<cp_conciliacion_Caja_det_Info>();
                gridControl_Facturas_x_Pagar.DataSource = BindingList_Conciliacion_det_x_FP;

                BindingList_conciliacion_det_x_ValeCaja = new BindingList<caj_Caja_Movimiento_Info>();
                gridControlValeCaja.DataSource = BindingList_conciliacion_det_x_ValeCaja;

                txtNumOrden.EditValue = null;
                cmbOrdTipPag.EditValue = null;
                dtpFecha_OP.EditValue = DateTime.Now;
                cmbBeneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PERSONA, 0);
                txtObservacion.Text = "";
                checkBox_OP.Checked = false;
                UC_DiarioContPago.LimpiarGrid();

                txt_NConciliacionCaja.Text = "";
                gridColumnModificar.Visible = false;
                gridColumnModificarValeCaja.Visible = false;

                Lista_Caja_Movi_x_Egr_Vale = new List<caj_Caja_Movimiento_Info>();


                cmb_Periodo.EditValue = null;

                txtSaldo.EditValue = 0;
                txtIngresos.EditValue = 0;
                txtFondo.EditValue = 0;
                txtTotalIngresos.EditValue = 0;
                txtEgresos.EditValue = 0;
                txtDiferencia.EditValue = 0;
                cmb_Periodo.Properties.ReadOnly = false;
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
                if (MessageBox.Show("Si elige limpiar se perderá todo lo que no haya sido guardado, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Inicializar_Controles();
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    if (Grabar())
                        this.Close();
                }
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
                if (Valida())
                {
                    if (Grabar())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos_tipo_movimiento()
        {
            try
            {
                List_Caja_Movimiento_Tipo = Bus_CajaMoviTipo_B.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa, Cl_Enumeradores.eTipo_Ing_Egr.EGRESOS, ref  MensajeError);
                cmb_Motivo.DataSource = List_Caja_Movimiento_Tipo;
                cmb_Motivo.DisplayMember = "tm_descripcion";
                cmb_Motivo.ValueMember = "IdTipoMovi";

                cmb_TipoMovi.DataSource = List_Caja_Movimiento_Tipo;
                cmb_TipoMovi.DisplayMember = "tm_descripcion";
                cmb_TipoMovi.ValueMember = "IdTipoMovi";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Combos()
        {

            try
            {
                string[] CodRetencion = new string[] { "COD_IDCREDITO" };

                cmb_sustento_tributario_SRI.DataSource = Bus_Codigo_SRI_.Get_List_codigo_SRI_x_codigo(CodRetencion, param.IdEmpresa);
                cmb_sustento_tributario_SRI.DisplayMember = "descriConcate";
                cmb_sustento_tributario_SRI.ValueMember = "IdCodigo_SRI";
                col_Sustento_Tributario_SRI.OptionsColumn.AllowEdit = true;

                list_Beneficiario_ValeCaj = Bus_Beneficiario_x_Vale_Caja.Get_List_PersonaBeneficiario(param.IdEmpresa, "PERSONA");
                cmb_Beneficiario.DataSource = list_Beneficiario_ValeCaj;
                cmb_Beneficiario.DisplayMember = "NombreCompleto";
                cmb_Beneficiario.ValueMember = "IdBeneficiario";

                //carga combo Motivo vale caja

                Cargar_combos_tipo_movimiento();

                //plan de cta
                List_PlanCta = Bus_PlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa);
                cmb_CtaCble_grid.DataSource = List_PlanCta;
                cmb_CtaCble_grid.DisplayMember = "pc_Cuenta2";
                cmb_CtaCble_grid.ValueMember = "IdCtaCble";


                cp_orden_pago_tipo_Bus Bus_OrdenTipPago = new cp_orden_pago_tipo_Bus();
                list_OrdenTipPago = Bus_OrdenTipPago.Get_List_orden_pago_tipo_x_Empresa(param.IdEmpresa).FindAll(q => q.IdTipo_op.Trim() != "FACT_PROVEE" && q.IdTipo_op != "ANTI_PROVEE");
                cmbOrdTipPag.Properties.DataSource = list_OrdenTipPago;


                cp_catalogo_Bus bus_catalogo = new cp_catalogo_Bus();
                lista_catalogo = bus_catalogo.Get_List_catalogo("EST_CIE");

                cmb_Estado.Properties.DataSource = lista_catalogo;
                cmb_Estado.Properties.DisplayMember = "Nombre";
                cmb_Estado.Properties.ValueMember = "IdCatalogo";
                cmb_Estado.EditValue = lista_catalogo.FirstOrDefault().IdCatalogo;


                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento();
                LstTipDoc = LstTipDoc.FindAll(c => c.Estado == "A");

                cmb_TipoDocu.DataSource = LstTipDoc;
                cmb_TipoDocu.DisplayMember = "Descripcion";
                cmb_TipoDocu.ValueMember = "CodTipoDocumento";

                List_Prove_Info = Bus_Proveedor.Get_List_proveedor(param.IdEmpresa);

                cmb_Proveedor.DataSource = List_Prove_Info;
                cmb_Proveedor.DisplayMember = "pr_nombre";
                cmb_Proveedor.ValueMember = "IdProveedor";

                cmb_ctaCble.DataSource = Bus_PlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa);
                cmb_ctaCble.DisplayMember = "pc_Cuenta2";
                cmb_ctaCble.ValueMember = "IdCtaCble";

                ct_Centro_costo_Bus _CentroCostoBus = new ct_Centro_costo_Bus();

                cmb_centroCosto.DataSource = _CentroCostoBus.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centroCosto.DisplayMember = "Centro_costo2";
                cmb_centroCosto.ValueMember = "IdCentroCosto";

                _CentroCostoBus = new ct_Centro_costo_Bus();
                cmb_Centrocosto2.DataSource = _CentroCostoBus.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_Centrocosto2.DisplayMember = "Centro_costo2";
                cmb_Centrocosto2.ValueMember = "IdCentroCosto";

                cmb_TipoFlujo.DataSource = b.Get_List_TipoFlujo(param.IdEmpresa);
                cmb_TipoFlujo.DisplayMember = "Descricion";
                cmb_TipoFlujo.ValueMember = "IdTipoFlujo";

                b = new ba_TipoFlujo_Bus();
                cmb_TipoFlujo2.DataSource = b.Get_List_TipoFlujo(param.IdEmpresa);
                cmb_TipoFlujo2.DisplayMember = "Descricion";
                cmb_TipoFlujo2.ValueMember = "IdTipoFlujo";


                list_TipoMovimiento_x_ctble = Bus_TipoMovimiento_x_ctble.Get_List(param.IdEmpresa);

                list_Periodo = Bus_Periodo.Get_List_Periodo(param.IdEmpresa, ref MensajeError);
                cmb_Periodo.Properties.DataSource = list_Periodo;
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";

                lista_Caja = new List<caj_Caja_Info>();

                lista_Caja = Bus_Caja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.ultraCmbE_caja.Properties.DataSource = lista_Caja;
                this.ultraCmbE_caja.Properties.DisplayMember = "ca_Descripcion";
                this.ultraCmbE_caja.Properties.ValueMember = "IdCaja";

                list_Grupo_PC = bus_Grupo_PC.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Grupo_PC_val.DataSource = list_Grupo_PC;
                cmb_Grupo_PC_val.ValueMember = "IdPunto_cargo_grupo";
                cmb_Grupo_PC_val.DisplayMember = "nom_punto_cargo_grupo";



                lista_punto_cargo = punto_cargo_bus.Get_List_PuntoCargo(param.IdEmpresa);
                cmbpunto_cargo.DataSource = lista_punto_cargo;
                cmbpunto_cargo.ValueMember = "IdPunto_cargo";
                cmbpunto_cargo.DisplayMember = "nom_punto_cargo";
                //Para fj
                cmb_punto_cargo_val_fj.DataSource = lista_punto_cargo;

                cmb_Punto_cargo_val.DataSource = lista_punto_cargo;
                cmb_Punto_cargo_val.ValueMember = "IdPunto_cargo";
                cmb_Punto_cargo_val.DisplayMember = "nom_punto_cargo";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Conciliacion_Caja_Load(object sender, EventArgs e)
        {
            try
            {

                BindingList_Conciliacion_det_x_FP = new BindingList<cp_conciliacion_Caja_det_Info>();
                gridControl_Facturas_x_Pagar.DataSource = BindingList_Conciliacion_det_x_FP;

                BindingList_conciliacion_det_x_ValeCaja = new BindingList<caj_Caja_Movimiento_Info>();
                gridControlValeCaja.DataSource = BindingList_conciliacion_det_x_ValeCaja;


                Info_CajaParametro = Bus_ParametrosCaja.Get_Info_Parametro(param.IdEmpresa);
                Info_Param_cxp = Bus_Param_cxc.Get_Info_parametros(param.IdEmpresa);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        colIdCentroCosto2.Visible = false;
                        colPunto_cargo_grupo_val.Visible = false;
                        colPunto_cargo_val.Visible = false;
                        btn_copiar_factura.Visible = false;
                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        btnNuevoMotivo.Visible = false;
                        colPunto_cargo_val.Visible = false;
                        colPunto_cargo_grupo_val.Visible = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        colPunto_cargo_grupo_val.Visible = true;
                        colPunto_cargo_val.Visible = true;
                        btn_copiar_factura.Visible = false;
                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                    default:
                        btn_copiar_factura.Visible = false;
                        col_IdPunto_cargo_val_FJ.Visible = false;
                        break;
                }



                if (Info_CajaParametro.IdEmpresa == 0)
                {
                    MessageBox.Show("No puede continuar porque No tienen ingresados los parámetros de Caja, Falta ingresar Los Parametros de Caja.. \nIngréselos desde la pantalla de parámetros Caja,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }


                if (Info_Param_cxp.IdEmpresa == 0)
                {
                    MessageBox.Show("No puede continuar porque No tienen ingresados los parámetros de Cuentas por Pagar, Falta ingresar Los Parametros de Cuentas por Pagar.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }
                if (Info_Param_cxp.pa_TipoCbte_OG == null || Info_Param_cxp.pa_TipoCbte_OG == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el tipo de Comprobante Con el que se Genera la Orde de Giro.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }
                else if (Info_Param_cxp.pa_ctacble_iva == null || Info_Param_cxp.pa_ctacble_iva == "")
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar la Cuenta IVA para Generár la Orde de Giro.. \nIngréselos desde la pantalla de parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }
                else if (Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion == null || Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion == 0)
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros de Cuentas por Pagar, Falta ingresar el Tipo de Movimiento Egreso de Caja.. \nIngréselos desde la pantalla de Parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }
                Info_CajaMoviTipo_I = Bus_CajaMoviTipo_B.Get_Info_Movimiento_Tipo((Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion == null) ? 0 : Convert.ToInt32(Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion), param.IdEmpresa, ref  MensajeError);

                if (Info_CajaMoviTipo_I == null)
                {
                    MessageBox.Show("No puede continuar porque el tipo de movimiento de Caja " + Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion + " está incorrecto, \nIngrese la cuenta desde la pantalla de Parámetros Cuentas por Pagar,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }

                if (Info_CajaMoviTipo_I.IdCtaCble == null || Info_CajaMoviTipo_I.IdCtaCble == "")
                {
                    MessageBox.Show("No puede continuar porque el tipo de movimiento de Caja " + Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion + " No tienen Cuenta Contable asignada, Falta ingresar la Cuenta Contable del Tipo de Movimiento Egreso de Caja (" + Info_Param_cxp.pa_TipoEgrMoviCaja_Conciliacion + ").. \nIngrese la cuenta desde la pantalla 'Tipo de Movimiento de Caja',o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); return;
                }


                IdTipoCbte_EG = Info_CajaParametro.IdTipoCbteCble_MoviCaja_Egr;
                Cargar_Combos();
                Limpiar_Controles_OP(false);
                set_accion_In_controls();

            }


            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmb_Proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {


                /*
                if (Info_Proveedor.IdCtaCble_CXP == null || Info_Proveedor.IdCtaCble_CXP == "")
                {
                    MessageBox.Show("EL Proveedor no tiene Ingresada la Cuenta Contable por Pagar, Antes de Continuar debe ingresarla.. \n, Falta ingresar la Cuenta Contable por Pagar del Proveedor para Generár la Orde de Giro.. \nIngréselos desde la pantalla de 'Consulta de Proveedor', o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Info_Proveedor.IdCtaCble_Gasto == null || Info_Proveedor.IdCtaCble_Gasto == "")
                {
                    MessageBox.Show("EL Proveedor no tiene Ingresada la Cuenta Contable de Gasto, Antes de Continuar debe ingresarla.. \n, Falta ingresar la Cuenta Contable por Pagar del Proveedor para Generár la Orde de Giro.. \nIngréselos desde la pantalla de 'Consulta de Proveedor', o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmb_Proveedor_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Convert.ToString(e.NewValue)))
                {
                    IdProveedor = Convert.ToDecimal(e.NewValue);

                    Info_Proveedor = ((List<cp_proveedor_Info>)(cmb_Proveedor.DataSource)).First(v => v.IdProveedor == IdProveedor);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmb_TipoDocu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var item = ((List<cp_TipoDocumento_Info>)(cmb_TipoDocu.DataSource)).First(v => v.CodTipoDocumento == CodTipoDoc);

                if (item != null)
                {
                    gridView_ConciCaja.SetFocusedRowCellValue(colNDocumento, "");

                    if (item.DeclaraSRI == "N")
                    {
                        cp_orden_giro_Bus ordenGiro_B = new cp_orden_giro_Bus();
                        gridView_ConciCaja.SetFocusedRowCellValue(colNDocumento, ordenGiro_B.GetNDocumentoXTipo(item.CodTipoDocumento, param.IdEmpresa).ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmb_TipoDocu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Convert.ToString(e.NewValue)))
                {
                    CodTipoDoc = e.NewValue.ToString();

                    var item = ((List<cp_TipoDocumento_Info>)(cmb_TipoDocu.DataSource)).First(v => v.CodTipoDocumento == CodTipoDoc);

                    TipoDocu = item.Descripcion;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_Conciliacion_Caja_event_frmCP_Conciliacion_Caja_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private Boolean validaAutorizacion(decimal IdProveedor, string NAutorizacion)
        {
            try
            {
                Boolean r = true;

                Info_Autori_x_Prove = Bus_Autori_x_Prove.ExisteNAutorizacion(param.IdEmpresa, IdProveedor, NAutorizacion);

                if (Info_Autori_x_Prove == null || Info_Autori_x_Prove.IdAutorizacion == 0)
                {
                    MessageBox.Show("La Autorización ingresada no esta Correcta.. \nPor favor cambie el Numero de la Autorización.. ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r = false;
                }
                else if (Info_Autori_x_Prove.Valido_Hasta < param.Fecha_Transac)
                {
                    MessageBox.Show("La Autorización ingresada esta vencida.. \nPor favor cambie el Numero de la Autorización.. ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    r = false;
                }


                return r;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridView_ConciCaja_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                cp_conciliacion_Caja_det_Info row_conciliacion_det_FP = new cp_conciliacion_Caja_det_Info();
                row_conciliacion_det_FP = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetRow(e.RowHandle);

                if (e.Column == colTotal)
                {
                    CalcularEgresos();
                }

                if (e.Column.Name == "colTotal12")
                {
                    double BaseImponible = row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_siniva + row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_iva;
                    double iva = Convert.ToDouble(e.Value) * param.iva.porcentaje / 100;

                    double retencion = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colRetencion)); ;

                    double total = (BaseImponible + iva) - retencion;


                    gridView_ConciCaja.SetFocusedRowCellValue(colBaseImponible, BaseImponible);

                    gridView_ConciCaja.SetFocusedRowCellValue(colIVA, iva);

                    gridView_ConciCaja.SetFocusedRowCellValue(colTotal, total);

                }

                if (e.Column.Name == "colTotal0")
                {
                    double BaseImponible = row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_siniva + row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_iva;
                    double iva = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colIVA));

                    double retencion = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colRetencion)); ;

                    double total = (BaseImponible + iva) - retencion;


                    gridView_ConciCaja.SetFocusedRowCellValue(colBaseImponible, BaseImponible);
                    gridView_ConciCaja.SetFocusedRowCellValue(colTotal, total);

                }

                if (e.Column.Name == "colRetencion")
                {
                    double BaseImponible = row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_siniva + row_conciliacion_det_FP.Info_Orden_Giro.co_subtotal_iva;
                    double iva = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colIVA));

                    double retencion = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colRetencion)); ;

                    double total = (BaseImponible + iva) - retencion;


                    gridView_ConciCaja.SetFocusedRowCellValue(colBaseImponible, BaseImponible);
                    gridView_ConciCaja.SetFocusedRowCellValue(colTotal, total);

                }




                if (e.Column.Name == "colTotal")
                {
                    if (checkBox_OP.Checked == true)
                    {
                        Genera_Diario_OP();

                    }

                }

                if (e.Column.Name == "colProveedor")
                {

                }

                if (e.Column.Name == "colNDocumento")
                {
                    //validar secuencial factura
                    string secuencia_aux = "";
                    string secuencia = "";

                    if (!String.IsNullOrEmpty(Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colNDocumento))))
                    {
                        if (Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colNDocumento)).Length < 9)
                        {
                            int conta = Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colNDocumento)).Length;
                            int diferencia = 9 - conta;

                            secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                            secuencia = secuencia_aux + gridView_ConciCaja.GetFocusedRowCellValue(colNDocumento);

                            gridView_ConciCaja.SetFocusedRowCellValue(colNDocumento, secuencia);
                        }

                    }

                }
                if (e.Column == colIdCentroCosto1)
                {
                    BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                    BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>
                        (Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(e.Value)));

                    cmbSubCentroCosto.Items.Clear();
                    foreach (ct_centro_costo_sub_centro_costo_Info item in BindListaSubCentro)
                    {
                        item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                        cmbSubCentroCosto.Items.Add(item.NomSubCentroCosto);
                    }

                }
                else

                    if (e.Column == colNomSubCentroCosto)
                    {
                        if (row_conciliacion_det_FP != null)
                        {

                        }

                    }

                if (e.Column == colTipoMovi)
                {
                    if (row_conciliacion_det_FP != null)
                    {

                    }
                }
                CalcularEgresos();
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
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

        public void llamaRetencion()
        {
            try
            {
                if (gridView_ConciCaja.GetFocusedRowCellValue(colTipo) == null)
                {
                    MessageBox.Show("Antes de Seleccionar las Retenciones debe seleccionar el Tipo de documento ..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }


                // else if (Convert.ToDecimal(gridView_ConciCaja.GetFocusedRowCellValue(colTotal0)) == 0 || gridView_ConciCaja.GetFocusedRowCellValue(colTotal0).ToString() == "" || gridView_ConciCaja.GetFocusedRowCellValue(colTotal0) == null)

                else if ((Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colTotal0)) == 0 || String.IsNullOrEmpty(Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colTotal0)).TrimEnd())) && (Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colTotal12)) == 0 || String.IsNullOrEmpty(Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colTotal12)).TrimEnd())))
                {
                    //double df = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colTotal0));

                    MessageBox.Show("Antes de Seleccionar las Retenciones debe Ingresar el Total Base 12 o Total Base 0..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                //else if (Convert.ToDecimal(gridView_ConciCaja.GetFocusedRowCellValue(colTotal12)) == 0 || gridView_ConciCaja.GetFocusedRowCellValue(colTotal12).ToString() == "" || gridView_ConciCaja.GetFocusedRowCellValue(colTotal12) == null)
                //{
                //    MessageBox.Show("Antes de Seleccionar las Retenciones debe Ingresar la Total Base 12 ..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                //}
                else
                {
                    double DvalorIVA = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colIVA));
                    double DBaseImponible = Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colTotal12)) + Convert.ToDouble(gridView_ConciCaja.GetFocusedRowCellValue(colTotal0));
                    decimal IdProveedor = Convert.ToDecimal(gridView_ConciCaja.GetFocusedRowCellValue(colProveedor));
                    string NDocumento = Convert.ToString(gridView_ConciCaja.GetFocusedRowCellValue(colNDocumento));

                    cp_retencion_Info CabRetencion_select = new cp_retencion_Info();




                    DateTime fechaRT;
                    if (CabRetencion_select == null)
                    {
                        fechaRT = Convert.ToDateTime(gridView_ConciCaja.GetFocusedRowCellValue(colFechaDocumento));
                    }
                    else
                    {
                        fechaRT = CabRetencion_select.fecha;
                    }

                    if (CabRetencion_select == null)
                    {
                        CabRetencion_select = new cp_retencion_Info();
                    }

                    CabRetencion_select.TipoDocumento = TipoDocu;
                    CabRetencion_select.NumRetencion = NDocumento;
                    CabRetencion_select.NomProveedor = NomProve;


                    frmCP_RetencionProveedor fr = new frmCP_RetencionProveedor(DvalorIVA, DBaseImponible, CabRetencion_select, IdProveedor, fechaRT, true);
                    fr.ShowDialog();



                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemButtonEdit_Reten_Click(object sender, EventArgs e)
        {
            try
            {
                llamaRetencion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean Valida()
        {
            try
            {
                txt_NConciliacionCaja.Focus();


                InfoPeriodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dTp_Fecha.Value, ref MensajeError);

                if (InfoPeriodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ultraCmbE_caja.EditValue == null || Convert.ToString(ultraCmbE_caja.EditValue).TrimEnd() == "")
                {
                    MessageBox.Show("Antes de continuar seleccione Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (BindingList_Conciliacion_det_x_FP.Count == 0 && BindingList_conciliacion_det_x_ValeCaja.Count == 0)
                {

                    MessageBox.Show("Ingrese Información a Conciliar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }

                if (checkBox_OP.Checked == true)
                {

                    if (String.IsNullOrEmpty(Convert.ToString(cmbOrdTipPag.EditValue)))
                    {
                        MessageBox.Show("Ingrese el tipo de pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }


                    if (this.cmbBeneficiario.Get_Persona_beneficiario_Info() == null)
                    {
                        MessageBox.Show("Ingrese el beneficiario ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (cmb_Periodo.EditValue == null || string.IsNullOrEmpty(cmb_Periodo.Text))
                {
                    MessageBox.Show("Antes de Continuar, Por favor ingrese periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (de_fecha_ini.EditValue == null)
                {
                    MessageBox.Show("Antes de Continuar, Por favor seleccione la fecha de inicio de la conciliación de caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (de_fecha_fin.EditValue == null)
                {
                    MessageBox.Show("Antes de Continuar, Por favor seleccione la fecha de fin de la conciliación de caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                #region Valida_FxP
                for (int i = 0; i < gridView_ConciCaja.RowCount; i++)
                {
                    cp_conciliacion_Caja_det_Info info = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetRow(i);

                    if (info != null)
                    {
                        if (String.IsNullOrEmpty(info.Info_Orden_Giro.EstaEnBase))
                        {

                            if (info.Info_Orden_Giro.IdTipoCbte_Ogiro == null)
                            {
                                MessageBox.Show("Antes de Continuar, Por favor ingrese el tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            if (info.Info_Orden_Giro.co_subtotal_siniva <= 0 && info.Info_Orden_Giro.co_subtotal_iva <= 0)
                            {
                                MessageBox.Show("Antes de continuar verifique los valores de las columnas Total 0 y Total Iva, ambos no pueden grabarse con 0\n Ingrese el valor o elimine el registro para poder continuar ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            if (info.Valor_a_aplicar == 0)
                            {
                                MessageBox.Show("Antes de continuar verifique los valores de la columna valor a aplicar,este no puede grabarse con 0\n Ingrese el valor o elimine el registro para poder continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            if (info.Valor_a_aplicar != Convert.ToDecimal(info.Info_Orden_Giro.Valor_a_Pagar))
                            {
                                if (MessageBox.Show("El valor aplicado a la factura " + info.Info_Orden_Giro.co_factura + " es diferente al valor a pagar, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                                    return true;
                            }
                        }
                    }
                }
                #endregion

                #region Valida vales
                foreach (var item in BindingList_conciliacion_det_x_ValeCaja)
                {
                    if (item.IdBeneficiario == null || item.IdBeneficiario == "")
                    {
                        MessageBox.Show("Existen vales de caja sin beneficiario, por favor ingrese el beneficiario o elimine el registro para continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (item.cm_valor == 0)
                    {
                        MessageBox.Show("Existen vales de caja sin valor, por favor ingrese el valor o elimine el registro para continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (item.IdTipoMovi == null)
                    {
                        MessageBox.Show("Existen vales de caja sin tipo de movimiento, por favor ingrese el motivo o elimine el registro para continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                #endregion

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CAJ, Convert.ToDateTime(dTp_Fecha.Value)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dTp_Fecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action Accion)
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

        private void set_accion_In_controls()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        gridColumnModificar.Visible = false;
                        gridColumnModificarValeCaja.Visible = false;
                        cmb_Periodo.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntImprimir = true;
                        gridColumnModificar.Visible = true;
                        cmb_Periodo.Properties.ReadOnly = true;
                        set_conciliacionCaja_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        gridColumnModificar.Visible = false;
                        set_conciliacionCaja_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_conciliacionCaja_In_Controls();
                        cmb_cta_cble_x_caja.Perfil_Lectura();
                        cmb_Estado.Properties.ReadOnly = true;
                        cmb_Periodo.Properties.ReadOnly = true;

                        txtNumOrden.Properties.ReadOnly = true;
                        cmbOrdTipPag.Properties.ReadOnly = true;
                        dtpFecha_OP.Properties.ReadOnly = true;

                        cmbBeneficiario.Enabled = false;
                        txtObservacion.ReadOnly = true;
                        UC_DiarioContPago.HabilitarGrid(false);
                        mEdit_Observacion.Properties.ReadOnly = true;

                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntImprimir = true;

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

        public void set_Info_ConciliacionCaja(cp_conciliacion_caja_Info _Info_Conciliacion)
        {
            try
            {
                Info_Conciliacion = _Info_Conciliacion;
            }
            catch (Exception ex)
            {


            }

        }

        private void set_conciliacionCaja_In_Controls()
        {
            try
            {
                IdConciliacion_Caja = Info_Conciliacion.IdConciliacion_Caja;
                EstadoCierre = Info_Conciliacion.IdEstadoCierre;
                txt_NConciliacionCaja.Text = Convert.ToString(Info_Conciliacion.IdConciliacion_Caja);
                ultraCmbE_caja.EditValue = Info_Conciliacion.IdCaja;
                cmb_Periodo.EditValue = Info_Conciliacion.IdPeriodo;
                de_fecha_ini.EditValue = Info_Conciliacion.Fecha_ini;
                de_fecha_fin.EditValue = Info_Conciliacion.Fecha_fin;
                mEdit_Observacion.Text = Info_Conciliacion.Observacion;
                txtSaldo.EditValue = Info_Conciliacion.Saldo_cont_al_periodo;
                txtIngresos.EditValue = Info_Conciliacion.Ingresos;
                txtTotalIngresos.EditValue = Info_Conciliacion.Total_Ing;
                txtEgresos.EditValue = Info_Conciliacion.Total_fact_vale;
                txtDiferencia.EditValue = Info_Conciliacion.Dif_x_pagar_o_cobrar;
                txtFondo.EditValue = Info_Conciliacion.Total_fondo;
                cmb_cta_cble_x_caja.set_PlanCtarInfo(Info_Conciliacion.IdCtaCble);
                cmb_Estado.EditValue = Info_Conciliacion.IdEstadoCierre;
                ucBa_TipoFlujo1.set_TipoFlujoInfo(Info_Conciliacion.IdTipoFlujo);
                dTp_Fecha.Value = Convert.ToDateTime(Info_Conciliacion.Fecha);
                //consulto detalle x FP
                cp_conciliacion_Caja_det_Bus bus_Conci_det = new cp_conciliacion_Caja_det_Bus();
                BindingList_Conciliacion_det_x_FP = new BindingList<cp_conciliacion_Caja_det_Info>(bus_Conci_det.Get_List_Conciliacion_Caja_Det(Info_Conciliacion.IdEmpresa, Info_Conciliacion.IdConciliacion_Caja));
                foreach (var item in BindingList_Conciliacion_det_x_FP)
                {
                    item.Esta_en_base = true;
                }
                gridControl_Facturas_x_Pagar.DataSource = BindingList_Conciliacion_det_x_FP;

                //consulto detalle vale de Caja
                BindingList_conciliacion_det_x_ValeCaja = new BindingList<caj_Caja_Movimiento_Info>(Bus_conciliacion_det_X_ValeCaj.Get_List_Conciliacion_Caja_Det_ValeCaja(Info_Conciliacion.IdEmpresa, Info_Conciliacion.IdConciliacion_Caja));
                foreach (var item in BindingList_conciliacion_det_x_ValeCaja)
                {
                    item.Esta_en_base = true;
                }
                gridControlValeCaja.DataSource = BindingList_conciliacion_det_x_ValeCaja;

                //datos de Orden de Pago
                cp_orden_pago_Bus bus_op = new cp_orden_pago_Bus();
                cp_orden_pago_Info info_op = new cp_orden_pago_Info();
                info_op = bus_op.Get_Info_orden_pago(Convert.ToInt32(Info_Conciliacion.IdEmpresa_op), Convert.ToDecimal(Info_Conciliacion.IdOrdenPago_op), ref MensajeError);
                if (info_op.IdEmpresa != 0)
                {
                    checkBox_OP.Checked = true;
                    checkBox_OP.Enabled = false;
                    Limpiar_Controles_OP(true);
                    Cl_Enumeradores.eTipoPersona Enum_TipoPersona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), info_op.IdTipo_Persona);
                    cmbBeneficiario.set_Persona_beneficiario_Info(Enum_TipoPersona, info_op.IdEntidad);
                    txtNumOrden.EditValue = info_op.IdOrdenPago;
                    cmbOrdTipPag.EditValue = info_op.IdTipo_op;
                    txtObservacion.Text = info_op.Observacion;
                    dtpFecha_OP.EditValue = (info_op.Fecha);
                    ucBa_TipoFlujo2.set_TipoFlujoInfo(info_op.IdTipoFlujo);
                    cp_orden_pago_det_Bus bus_detop = new cp_orden_pago_det_Bus();
                    cp_orden_pago_det_Info infoDetPago = new cp_orden_pago_det_Info();
                    infoDetPago = bus_detop.Get_Info_orden_pago(Convert.ToInt32(Info_Conciliacion.IdEmpresa_op), Convert.ToDecimal(Info_Conciliacion.IdOrdenPago_op));
                    UC_DiarioContPago.setInfo(Convert.ToInt32(infoDetPago.IdEmpresa_cxp), Convert.ToInt32(infoDetPago.IdTipoCbte_cxp), Convert.ToDecimal(infoDetPago.IdCbteCble_cxp));
                    UC_DiarioContPago.HabilitarGrid(false);
                }

                if (Info_Conciliacion.IdEstadoCierre == "EST_CIE_CER")
                {
                    colTotal_aplicado.Visible = false;
                    colTotalMovi.Visible = false;
                    colSaldo.Visible = false;
                }

                //Cargo cbtes involucrados en la conciliacion
                Cargar_Cbte_x_Conciliacion();

                ultraCmbE_caja.Properties.ReadOnly = true;

                Re_calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get_CbteCble_OP()
        {

            try
            {
                InfoCbte_Cble_OP = UC_DiarioContPago.Get_Info_CbteCble();

                foreach (var item in InfoCbte_Cble_OP._cbteCble_det_lista_info)
                {
                    item.dc_Observacion = "" + item.dc_Observacion;
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdTipoCbte = IdTipoCbte_OP;
                }

                InfoCbte_Cble_OP.IdEmpresa = param.IdEmpresa;
                if (IdTipoCbte_OP == 0)
                {
                    MessageBox.Show("Por favor verifique los parámetros del Tipo de comprobante para la Orden de Pago.");
                }
                InfoCbte_Cble_OP.IdTipoCbte = IdTipoCbte_OP;
                InfoCbte_Cble_OP.IdUsuario = param.IdUsuario;
                InfoCbte_Cble_OP.cb_Fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha_OP.EditValue).ToShortDateString());
                InfoCbte_Cble_OP.Anio = InfoCbte_Cble_OP.cb_Fecha.Year;
                InfoCbte_Cble_OP.Mes = InfoCbte_Cble_OP.cb_Fecha.Month;
                InfoCbte_Cble_OP.cb_Observacion = txtObservacion.Text;


                InfoCbte_Cble_OP.cb_FechaTransac = param.Fecha_Transac;
                InfoCbte_Cble_OP.cb_Valor = InfoCbte_Cble_OP._cbteCble_det_lista_info.FindAll(var => var.dc_Valor > 0).
                    Sum(var => var.dc_Valor);
                InfoCbte_Cble_OP.Mayorizado = "N";

                string mes = Convert.ToString(InfoCbte_Cble_OP.Mes);
                if (mes.Length == 1)
                    mes = "0" + mes;

                string AnioMes = Convert.ToString(InfoCbte_Cble_OP.Anio) + mes;
                int IdPeriodo = Convert.ToInt32(AnioMes);

                InfoCbte_Cble_OP.IdPeriodo = IdPeriodo;
                InfoCbte_Cble_OP.Estado = "A";
                InfoCbte_Cble_OP.cb_Fecha = InfoCbte_Cble_OP.cb_Fecha;
                InfoCbte_Cble_OP.cb_Valor = InfoCbte_Cble_OP.cb_Valor;
                InfoCbte_Cble_OP.IdSucursal = param.IdSucursal;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP = InfoCbte_Cble_OP;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_Conciliacion_det_x_ValeCaja()
        {
            try
            {
                int sec = 1;
                if (BindingList_conciliacion_det_x_ValeCaja.Count != 0)
                    sec = BindingList_conciliacion_det_x_ValeCaja.Max(q => q.secuencial) + 1;

                foreach (var item in this.BindingList_conciliacion_det_x_ValeCaja)
                {
                    if (item.secuencial == 0)
                    {
                        vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();
                        Info_Beneficiario = list_Beneficiario_ValeCaj.FirstOrDefault(q => q.IdBeneficiario == item.IdBeneficiario);

                        cp_conciliacion_Caja_det_Info info_det = new cp_conciliacion_Caja_det_Info();
                        info_det.IdEmpresa = param.IdEmpresa;
                        info_det.IdConciliacion_Caja = Convert.ToInt32(txt_NConciliacionCaja.Text);
                        info_det.Secuencia = sec;
                        sec++;
                        info_det.cm_beneficiario = Info_Beneficiario.NombreCompleto;
                        info_det.IdEntidad = Info_Beneficiario.IdEntidad;
                        info_det.IdTipo_Persona = Info_Beneficiario.IdTipo_Persona;
                        info_det.IdPersona = Info_Beneficiario.IdPersona;
                        info_det.IdBeneficiario = Info_Beneficiario.IdBeneficiario;

                        info_det.IdEmpresa_OGiro = param.IdEmpresa;
                        info_det.IdTipoCbte_Ogiro = item.IdTipocbte;
                        info_det.IdTipoMovi = (int)item.IdTipoMovi;
                        info_det.IdCentroCosto = item.IdCentroCosto;
                        info_det.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info_det.IdCtaCble_caja = Info_caja.IdCtaCble;
                        info_det.IdSucursal = param.IdSucursal;
                        info_det.cm_valor = item.cm_valor;
                        info_det.IdUsuario = param.IdUsuario;
                        info_det.Fecha_Transac = DateTime.Now;

                        info_det.cm_observacion = item.cm_observacion;
                        if (item.IdTipoFlujo != null) info_det.IdTipocbte = (int)item.IdTipoFlujo;
                        info_det.Fecha = item.cm_fecha;
                        info_det.IdPunto_cargo = item.IdPunto_cargo;
                        info_det.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info_det.Esta_en_base = item.Esta_en_base;
                        info_det.IdCentroCosto = item.IdCentroCosto;
                        info_det.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Info_Conciliacion.Detalle_x_ValeCaja.Add(info_det);

                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_Conciliacion_Cabecera()
        {
            try
            {
                Info_Conciliacion.IdEmpresa = param.IdEmpresa;
                Info_Conciliacion.IdCaja = Convert.ToInt32(ultraCmbE_caja.EditValue);
                Info_Conciliacion.IdEmpresa = param.IdEmpresa;
                Info_Conciliacion.IdConciliacion_Caja = Convert.ToDecimal(txt_NConciliacionCaja.Text);
                Info_Conciliacion.Fecha_ini = Convert.ToDateTime(de_fecha_ini.EditValue);
                Info_Conciliacion.Fecha_fin = Convert.ToDateTime(de_fecha_fin.EditValue);
                Info_Conciliacion.Saldo_cont_al_periodo = Convert.ToDouble(txtSaldo.EditValue);
                Info_Conciliacion.Ingresos = Convert.ToDouble(txtIngresos.EditValue);
                Info_Conciliacion.Total_Ing = Convert.ToDouble(txtTotalIngresos.EditValue);
                Info_Conciliacion.Total_fact_vale = Convert.ToDouble(txtEgresos.EditValue);
                Info_Conciliacion.Total_fondo = Convert.ToDouble(txtFondo.EditValue);
                Info_Conciliacion.Dif_x_pagar_o_cobrar = Convert.ToDouble(txtDiferencia.EditValue);
                Info_Conciliacion.IdPeriodo = Convert.ToInt32(cmb_Periodo.EditValue);
                Info_Conciliacion.Observacion = mEdit_Observacion.Text;
                Info_Conciliacion.Fecha = dTp_Fecha.Value;
                Info_Conciliacion.IdEstadoCierre = cmb_Estado.EditValue.ToString();
                Info_Conciliacion.IdCtaCble = cmb_cta_cble_x_caja.get_PlanCtaInfo().IdCtaCble;
                Info_Conciliacion.IdUsuario = param.IdUsuario;
                if (ucBa_TipoFlujo1.get_TipoFlujoInfo() != null && ucBa_TipoFlujo1.get_TipoFlujoInfo().IdTipoFlujo != 0) Info_Conciliacion.IdTipoFlujo = ucBa_TipoFlujo1.get_TipoFlujoInfo().IdTipoFlujo; else Info_Conciliacion.IdTipoFlujo = null;
                Info_Conciliacion.IdPunto_cargo = Info_caja.IdPunto_cargo;
                Info_Conciliacion.IdPunto_cargo_grupo = Info_caja.IdPunto_cargo_grupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_Conciliacion_det_Caja_x_FP()
        {
            try
            {
                Info_Conciliacion.Detalle_x_FP = new List<cp_conciliacion_Caja_det_Info>();
                int sec = 1;
                if (BindingList_Conciliacion_det_x_FP.Count != 0)
                    sec = BindingList_Conciliacion_det_x_FP.Max(q => q.Secuencia) + 1;
                foreach (var item in BindingList_Conciliacion_det_x_FP)
                {
                    if (item.Secuencia == 0)
                    {
                        item.IdEmpresa = param.IdEmpresa;
                        item.IdUsuario = param.IdUsuario;
                        item.Fecha_Transac = DateTime.Now;
                        item.Secuencia = sec;
                        sec++;
                    }
                    Info_Conciliacion.Detalle_x_FP.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void get_OrdenPago()
        {
            try
            {
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja = new cp_orden_pago_Info();

                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdEmpresa = param.IdEmpresa;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdOrdenPago = Convert.ToDecimal((this.txtNumOrden.EditValue == null) ? 0 : txtNumOrden.EditValue);
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipo_op = "OTROS_CONC";//Convert.ToString(this.cmbOrdTipPag.EditValue);
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdEstadoAprobacion = list_OrdenTipPago.FirstOrDefault(q => q.IdTipo_op == Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipo_op).IdEstadoAprobacion;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdPersona = cmbBeneficiario.Get_Persona_beneficiario_Info().IdPersona;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdEntidad = cmbBeneficiario.Get_Persona_beneficiario_Info().IdEntidad;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipo_Persona = cmbBeneficiario.Get_Persona_beneficiario_Info().IdTipo_Persona;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Observacion = this.txtObservacion.Text;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Fecha = Convert.ToDateTime(this.dtpFecha_OP.EditValue);
                if (ucBa_TipoFlujo2.get_TipoFlujoInfo() != null) Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipoFlujo = ucBa_TipoFlujo2.get_TipoFlujoInfo().IdTipoFlujo; else Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipoFlujo = null;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Detalle = new List<cp_orden_pago_det_Info>();
                cp_orden_pago_det_Info detalle = new cp_orden_pago_det_Info();
                detalle.IdEmpresa = param.IdEmpresa;
                detalle.Secuencia = 1;
                detalle.Valor_a_pagar = Math.Round(UC_DiarioContPago.Get_ValorCbteCble(), 2, MidpointRounding.AwayFromZero);
                detalle.Fecha_Pago = Convert.ToDateTime(dtpFecha_OP.EditValue).Date;
                detalle.IdEstadoAprobacion = list_OrdenTipPago.FirstOrDefault(q => q.IdTipo_op == Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.IdTipo_op).IdEstadoAprobacion;
                detalle.IdFormaPago = "CHEQUE";
                detalle.Idbanco = Info_Param_cxp.pa_IdBancoCuenta_default_para_OP == null ? 1 : Info_Param_cxp.pa_IdBancoCuenta_default_para_OP;
                Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Detalle.Add(detalle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void get_Conciliacion_det_Ingr_x_conciliar()
        {
            try
            {
                Asignar_ingresos();
                Info_Conciliacion.Detalle_x_Ingresos = new List<cp_conciliacion_Caja_det_Ing_Caja_Info>(BindingList_conciliacion_det_x_Ing.Where(q => q.Marcado == true).ToList());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Grabar()
        {
            try
            {
                string MensajeError = "";

                ultraCmbE_caja.Focus();
                Boolean estado = true;

                get_Conciliacion_Cabecera();
                get_Conciliacion_det_Caja_x_FP();
                get_Conciliacion_det_x_ValeCaja();

                if (checkBox_OP.Checked == true)
                {
                    get_OrdenPago();
                    Get_CbteCble_OP();
                    if (!UC_DiarioContPago.ValidarAsientosContables())
                    {
                        estado = false;
                        return estado;
                    }
                }

                string EstadoCierre = Convert.ToString(cmb_Estado.EditValue);
                string observacion = mEdit_Observacion.Text;

                if (Info_Conciliacion.IdEstadoCierre == "EST_CIE_CER")
                {
                    if (MessageBox.Show("Si genera la Orden de pago, la caja se cerrará y no podrá modificarla ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;

                    ct_Cbtecble_det_Info cbte_det = Info_Conciliacion.Info_Orden_Pago_x_Repocision_Caja.Info_CbteCble_x_OP._cbteCble_det_lista_info.FirstOrDefault(q => q.dc_Valor > 0);

                    if (cbte_det != null)
                    {
                        if (cbte_det.IdPunto_cargo == null && param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {
                            if (MessageBox.Show("La cuenta [" + cbte_det.IdCtaCble + "] no tiene punto de cargo ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return false;
                        }
                    }
                    get_Conciliacion_det_Ingr_x_conciliar();
                }

                if (Bus_ConciCaj_B.GrabarDB(Info_Conciliacion, ref MensajeError))
                {
                    txt_NConciliacionCaja.Text = Info_Conciliacion.IdConciliacion_Caja.ToString();
                    MessageBox.Show("Conciliación de Caja # " + txt_NConciliacionCaja.Text + " ingresada correctamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("No se procedió a Grabar porque: \n " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                }
                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridView_ConciCaja_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cp_conciliacion_Caja_det_Info info = new cp_conciliacion_Caja_det_Info();
                        info = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetFocusedRow();

                        if (info == null)
                            return;

                        if (info.IdCbteCble_Ogiro == 0)
                            return;

                        bool eliminar_desvincular = false;
                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.FJ:
                                eliminar_desvincular = true;
                                break;                            
                            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                eliminar_desvincular = false;
                                break;
                            default:
                                if (MessageBox.Show("Para eliminar la factura presione [SI], para desvincularla de la conciliación presione [NO]", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    eliminar_desvincular = true;
                                else
                                    eliminar_desvincular = false;
                                break;
                        }
                        

                        MessageBox.Show(Bus_ConciCaj_B.Eliminar_facturas_o_vales(info.IdEmpresa_OGiro, info.IdTipoCbte_Ogiro, info.IdCbteCble_Ogiro, "FACTURA", eliminar_desvincular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gridView_ConciCaja.DeleteSelectedRows();
                    }
                }
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
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        XCAJ_Rpt003_Rpt reporte = new XCAJ_Rpt003_Rpt();

                        int IdEmpresa = 0;
                        decimal IdConciliacion_Caja = 0;

                        IdEmpresa = param.IdEmpresa;
                        IdConciliacion_Caja = Convert.ToDecimal(txt_NConciliacionCaja.Text);

                        reporte.Parameters["PIdConciliacion_Caja"].Value = IdConciliacion_Caja;
                        reporte.Parameters["PIdEmpresa"].Value = IdEmpresa;

                        reporte.RequestParameters = true;
                        reporte.ShowPreviewDialog();
                        break;
                    default:
                        XCAJ_Rpt004_Rpt rpt_gnral = new XCAJ_Rpt004_Rpt();
                        rpt_gnral.P_IdConcilacionCaja.Value = Convert.ToDecimal(txt_NConciliacionCaja.Text);
                        rpt_gnral.RequestParameters = true;
                        rpt_gnral.ShowPreviewDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Conciliacion_Caja_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmCP_Conciliacion_Caja_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ultraCmbE_caja_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Convert.ToString(ultraCmbE_caja.EditValue)))
                {
                    Info_caja = lista_Caja.FirstOrDefault(q => q.IdCaja == Convert.ToInt32(ultraCmbE_caja.EditValue));
                    cmb_cta_cble_x_caja.set_PlanCtarInfo(Info_caja.IdCtaCble);
                    Buscar_ingresos();
                }
                else
                    cmb_cta_cble_x_caja.set_PlanCtarInfo(null);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void gridView_ConciCaja_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Fila_conciliacion_det_x_FP = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetRow(e.FocusedRowHandle);
                var Item = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetRow(e.FocusedRowHandle);

               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox_OP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.consultar)
                {
                    if (checkBox_OP.Checked == true)
                    {
                        if (MessageBox.Show("Si elige generar la orden de pago por reposición de caja; esta se cerrará y no podrá modificarla luego... ¿Está seguro que desea cerrar la caja?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Limpiar_Controles_OP(true);
                            cmbOrdTipPag.EditValue = null;
                            cmbBeneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PROVEE, 0);
                            UC_DiarioContPago.LimpiarGrid();
                            Genera_Diario_OP();
                            cmb_Estado.EditValue = "EST_CIE_CER";
                        }
                        else
                        {
                            checkBox_OP.Checked = false;
                            cmb_Estado.EditValue = "EST_CIE_ABI";
                        }
                    }
                    else
                    {
                        Limpiar_Controles_OP(false);


                        cmbOrdTipPag.EditValue = null;
                        cmbBeneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PROVEE, 0);
                        UC_DiarioContPago.LimpiarGrid();
                        cmb_Estado.EditValue = "EST_CIE_ABI";
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Limpiar_Controles_OP(bool valor)
        {

            try
            {
                label8.Visible = valor;
                txtNumOrden.Visible = valor;
                label12.Visible = valor;
                cmbOrdTipPag.Visible = valor;
                label7.Visible = valor;
                dtpFecha_OP.Visible = valor;
                label11.Visible = valor;
                txtObservacion.Visible = valor;
                pnl_op_ocultar.Visible = valor;
                UC_DiarioContPago.Visible = valor;
                cmbBeneficiario.Visible = valor;
                label6.Visible = valor;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        void Genera_Diario_OP()
        {
            try
            {

                Info_Tipo_OP = null;

                if (cmbOrdTipPag.EditValue != null)
                {
                    Info_Tipo_OP = list_OrdenTipPago.FirstOrDefault(q => q.IdTipo_op == cmbOrdTipPag.EditValue.ToString());
                }

                Info_Persona_Beneficiario = new vwtb_persona_beneficiario_Info();
                Info_Persona_Beneficiario = cmbBeneficiario.Get_Persona_beneficiario_Info();



                ListDetCbteCble = new List<ct_Cbtecble_det_Info>();

                double tot_fact = 0;
                double tot_vale = 0;
                double Total_OP = 0;


                if (BindingList_Conciliacion_det_x_FP.Count > 0)
                    tot_fact = (double)BindingList_Conciliacion_det_x_FP.Sum(q => q.Valor_a_aplicar);

                if (this.BindingList_conciliacion_det_x_ValeCaja.Count > 0)
                    tot_vale = BindingList_conciliacion_det_x_ValeCaja.Sum(q => q.cm_valor);

                Total_OP = tot_fact + tot_vale;



                ///seteamos el Debe
                ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                info.IdEmpresa = param.IdEmpresa;

                if (Info_Tipo_OP != null)
                {
                    info.IdTipoCbte = Convert.ToInt32(Info_Tipo_OP.IdTipoCbte_OP ?? 17);
                    IdTipoCbte_OP = Convert.ToInt32(Info_Tipo_OP.IdTipoCbte_OP ?? 17);

                }

                //al debe la cta de caja
                info.IdCtaCble = cmb_cta_cble_x_caja.get_PlanCtaInfo().IdCtaCble;

                info.dc_Valor = Total_OP;
                ListDetCbteCble.Add(info);

                ///seteamos el Haber
                info = new ct_Cbtecble_det_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdTipoCbte = IdTipoCbte_OP;
                info.IdCtaCble = (Info_Persona_Beneficiario != null) ? Info_Persona_Beneficiario.IdCtaCble : info.IdCtaCble;
                info.dc_Valor = Total_OP * -1;
                ListDetCbteCble.Add(info);
                UC_DiarioContPago.setDetalle(ListDetCbteCble);

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbOrdTipPag_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Genera_Diario_OP();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                var c = gridView_ConciCaja.GetFocusedRowCellValue(colProveedor);

                if (e.Column.Name == "colIco")
                {
                    if (Convert.ToDecimal(gridView_ConciCaja.GetFocusedRowCellValue(colProveedor)) == 0 || gridView_ConciCaja.GetFocusedRowCellValue(colProveedor).ToString() == "" || gridView_ConciCaja.GetFocusedRowCellValue(colProveedor) == null)
                    {
                        MessageBox.Show("Antes de Seleccionar la Autorización debe seleccionar el Proveedor..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        frmCP_AutorizacionProveedor fr = new frmCP_AutorizacionProveedor((decimal)c);

                        fr.ShowDialog();
                        Info_Autori_x_Prove = fr.OtroFrm_Aut_I;


                        if (Info_Autori_x_Prove != null)
                        {
                            gridView_ConciCaja.SetFocusedRowCellValue(colAutorizacion, Info_Autori_x_Prove.nAutorizacion);
                            gridView_ConciCaja.SetFocusedRowCellValue(colco_serie, Info_Autori_x_Prove.Serie1 + "-" + Info_Autori_x_Prove.Serie2);
                        }
                        else
                        {
                            gridView_ConciCaja.SetFocusedRowCellValue(colAutorizacion, null);
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

        private void gridViewValeCaja_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_Info row = (caj_Caja_Movimiento_Info)gridViewValeCaja.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column.Name == "colcm_beneficiario")
                {
                    gridViewValeCaja.SetFocusedRowCellValue(colcm_fecha, DateTime.Now);
                }

                if (e.Column == colcm_valor)
                {
                    CalcularEgresos();
                }

                if (e.Column.Name == "colIdTipoMovi")
                {
                    if (Convert.ToInt32(e.Value == null ? 0 : e.Value) != 0 && e.Value != null)
                    {
                        Info_CajaMoviTipo_I = List_Caja_Movimiento_Tipo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdTipoMovi == Convert.ToInt32(e.Value));
                        if (Info_CajaMoviTipo_I != null)
                        {
                            if (Info_CajaMoviTipo_I.IdCtaCble == null)
                            {
                                MessageBox.Show("El motivo seleccionado, no tiene una cuenta contable asignada, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                row.IdTipoMovi = null;
                                return;
                            }
                        }
                    }
                }
                if (e.Column == colIdCentroCosto2)
                {
                    BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                    BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>
                        (Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(e.Value)));

                    cmbSubCentroCosto2.Items.Clear();
                    foreach (ct_centro_costo_sub_centro_costo_Info item in BindListaSubCentro)
                    {
                        item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                        cmbSubCentroCosto2.Items.Add(item.NomSubCentroCosto);
                    }
                }
                if (e.Column == col_IdPunto_cargo_val_FJ)
                {
                    switch (param.IdCliente_Ven_x_Default)
                    {
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewValeCaja_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rowHandle_val = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewValeCaja_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        caj_Caja_Movimiento_Info info = new caj_Caja_Movimiento_Info();
                        info = (caj_Caja_Movimiento_Info)gridViewValeCaja.GetRow(rowHandle_val);

                        if (info == null)
                            return;

                        if (info.IdCbteCble_movcaja != 0)
                        {
                            bool eliminar_desvincular = false;
                            switch (param.IdCliente_Ven_x_Default)
                            {
                                case Cl_Enumeradores.eCliente_Vzen.FJ:
                                    eliminar_desvincular = true;
                                    break;
                                case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                    eliminar_desvincular = false;
                                    break;
                                default:
                                    if (MessageBox.Show("Para eliminar vale presione [SI], para desvincularlo de la conciliación presione [NO]", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        eliminar_desvincular = true;
                                    else
                                        eliminar_desvincular = false;
                                    break;
                            }                           

                            MessageBox.Show(Bus_ConciCaj_B.Eliminar_facturas_o_vales(info.IdEmpresa_movcaja, info.IdTipocbte_movcaja, info.IdCbteCble_movcaja, "VALE", eliminar_desvincular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            gridViewValeCaja.DeleteSelectedRows();
                        }
                        else
                            gridViewValeCaja.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarConciliacion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {


                if (Fila_conciliacion_det_x_FP != null)
                {
                    cp_orden_giro_Info info = new cp_orden_giro_Info();
                    cp_orden_giro_Bus Bus = new cp_orden_giro_Bus();

                    info = Bus.Get_Info_orden_giro(Fila_conciliacion_det_x_FP.IdEmpresa_OGiro, Fila_conciliacion_det_x_FP.IdTipoCbte_Ogiro, Fila_conciliacion_det_x_FP.IdCbteCble_Ogiro);

                    if (info != null)
                    {
                        frmCP_OrdenGiroMantenimiento frm = new frmCP_OrdenGiroMantenimiento();
                        frm.set_accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.MdiParent = this.MdiParent;
                        frm.set_ordenGiro(info);
                        frm.Show();
                        frm.event_frmCP_MantOrdenGiro_FormClosing += frm_event_frmCP_MantOrdenGiro_FormClosing;
                    }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_event_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e, cp_orden_giro_Info _Info_Orgen_Giro)
        {
            try
            {
                get_Conciliacion_Cabecera();
                set_Info_ConciliacionCaja(Info_Conciliacion);
                Re_calcular();
                get_Conciliacion_Cabecera();
                cp_conciliacion_caja_Bus bus = new cp_conciliacion_caja_Bus();
                if (!bus.ModificarDB_valores(Info_Conciliacion, ref MensajeError))
                {
                    MessageBox.Show("Hubo un error actualizando los valores: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarValeCaja_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_Info row = (caj_Caja_Movimiento_Info)gridViewValeCaja.GetFocusedRow();
                fila_movi_caj = row;
                if (row != null)
                {
                    caj_Caja_Movimiento_Bus Bus = new caj_Caja_Movimiento_Bus();
                    caj_Caja_Movimiento_Info Info = new caj_Caja_Movimiento_Info();

                    Info = Bus.Get_Info_MovimientoCaja(row.IdEmpresa_movcaja, row.IdCbteCble_movcaja, row.IdTipocbte_movcaja, ref MensajeError);

                    if (Info.IdEmpresa != 0)
                    {
                        frmCaja_Movi_Egreso = new FrmCa_Caja_Movimiento_Egreso();
                        frmCaja_Movi_Egreso.set_accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frmCaja_Movi_Egreso.MdiParent = this.MdiParent;

                        frmCaja_Movi_Egreso.set_Info_CajaMovi(Info);
                        frmCaja_Movi_Egreso.Show();
                        frmCaja_Movi_Egreso.event_FrmCa_Caja_Movimiento_Egreso_FormClosing += formaCajaMan_event_FrmCa_Caja_Movimiento_Egreso_FormClosing;
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void formaCajaMan_event_FrmCa_Caja_Movimiento_Egreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                List<ct_Cbtecble_det_Info> List = new List<ct_Cbtecble_det_Info>(frmCaja_Movi_Egreso.Get_CbteCble_det());
                if (List.Count != 0)
                {
                    fila_movi_caj.IdPunto_cargo_grupo = List.FirstOrDefault(q => q.dc_Valor < 0).IdPunto_cargo_grupo;
                    fila_movi_caj.IdPunto_cargo = List.FirstOrDefault(q => q.dc_Valor < 0).IdPunto_cargo;

                    cp_conciliacion_Caja_det_x_ValeCaja_Info info = new cp_conciliacion_Caja_det_x_ValeCaja_Info();
                    info.IdEmpresa = fila_movi_caj.IdEmpresa;
                    info.IdConciliacion_Caja = fila_movi_caj.IdConciliacionCaja;
                    info.IdEmpresa_movcaja = fila_movi_caj.IdEmpresa_movcaja;
                    info.IdTipocbte_movcaja = fila_movi_caj.IdTipocbte_movcaja;
                    info.IdCbteCble_movcaja = fila_movi_caj.IdCbteCble_movcaja;
                    info.Secuencia = fila_movi_caj.secuencial;
                    info.IdPunto_cargo = fila_movi_caj.IdPunto_cargo;
                    info.IdPunto_cargo_grupo = fila_movi_caj.IdPunto_cargo_grupo;
                    Bus_conciliacion_det_X_ValeCaj.ModificarDB(info);
                }
                get_Conciliacion_Cabecera();
                set_Info_ConciliacionCaja(Info_Conciliacion);
                Re_calcular();
                get_Conciliacion_Cabecera();
                cp_conciliacion_caja_Bus bus = new cp_conciliacion_caja_Bus();
                if (!bus.ModificarDB_valores(Info_Conciliacion, ref MensajeError))
                {
                    MessageBox.Show("Hubo un error actualizando los valores: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_ingresos()
        {
            try
            {
                DateTime Fecha_ini = Convert.ToDateTime(de_fecha_ini.EditValue);
                DateTime Fecha_fin = Convert.ToDateTime(de_fecha_fin.EditValue);

                if (ultraCmbE_caja.EditValue != null)
                {
                    Info_caja = lista_Caja.FirstOrDefault(q => q.IdCaja == Convert.ToInt32(ultraCmbE_caja.EditValue));
                    if (Info_Conciliacion.IdEstadoCierre != "EST_CIE_CER")
                    {
                        BindingList_conciliacion_det_x_Ing = new BindingList<cp_conciliacion_Caja_det_Ing_Caja_Info>(Ingreso_cajas_Bus.Get_List_Ingresos_x_conciliar(param.IdEmpresa, Fecha_ini, Fecha_fin, Info_caja.IdCaja));
                        Re_calcular();
                    }
                    else
                    {
                        BindingList_conciliacion_det_x_Ing = new BindingList<cp_conciliacion_Caja_det_Ing_Caja_Info>(Ingreso_cajas_Bus.Get_List_Ingresos_x_conciliacion(param.IdEmpresa, Info_Conciliacion.IdConciliacion_Caja));
                    }
                    gridControlIngresos.DataSource = BindingList_conciliacion_det_x_Ing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoPeriodo = list_Periodo.FirstOrDefault(q => q.IdPeriodo == Convert.ToInt32(cmb_Periodo.EditValue));
                if (InfoPeriodo!=null)
                {
                    de_fecha_ini.EditValue = InfoPeriodo.pe_FechaIni.Date;
                    de_fecha_fin.EditValue = InfoPeriodo.pe_FechaFin.Date;
                }
                Buscar_ingresos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewIngresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_conciliacion_Caja_det_Ing_Caja_Info row = new cp_conciliacion_Caja_det_Ing_Caja_Info();
                row = (cp_conciliacion_Caja_det_Ing_Caja_Info)gridViewIngresos.GetFocusedRow();
                if (row != null)
                {
                    CalcularIngresos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos_txt_Calculos
        private void txtIngresos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular_Total_Ingresos();
                txtFondo.EditValue = txtIngresos.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSaldo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Calcular_Total_Ingresos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalIngresos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFondo.EditValue = txtIngresos.EditValue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEgresos_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFondo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Calculos_cabecera

        private void Re_calcular()
        {
            try
            {
                if (Info_Conciliacion.IdEstadoCierre != "EST_CIE_CER")
                {
                    CalcularSaldo();
                    CalcularEgresos();
                    Asignar_ingresos();
                    CalcularIngresos();
                    Calcular_Total_Ingresos();
                    CalcularDiferencia();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Asignar_ingresos()
        {
            try
            {
                foreach (var item in BindingList_conciliacion_det_x_Ing)
                {
                    item.Marcado = false;
                    item.valor_aplicado = 0;
                }

                double total_egresos = txtEgresos.Text == "" ? 0 : Convert.ToDouble(txtEgresos.EditValue);
                total_egresos = total_egresos * -1;
                foreach (var item in BindingList_conciliacion_det_x_Ing.OrderBy(q => q.cm_fecha).ToList())
                {
                    if (total_egresos == 0)
                        break;
                    if (total_egresos > 0)
                    {
                        if (item.Saldo >= total_egresos)
                        {
                            item.valor_aplicado = Math.Round(total_egresos, 2);
                            total_egresos = 0;
                            item.Marcado = true;
                        }
                        else
                        {
                            item.valor_aplicado = Math.Round(item.Saldo, 2);
                            total_egresos = Math.Round(total_egresos, 2) - Math.Round(item.Saldo, 2);
                            item.Marcado = true;
                        }
                    }
                }
                gridControlIngresos.DataSource = null;
                gridControlIngresos.DataSource = BindingList_conciliacion_det_x_Ing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular_Total_Ingresos()
        {
            try
            {
                double Saldo = 0;
                double Ingresos = 0;
                double Total_Ingresos = 0;

                Saldo = Convert.ToDouble(txtSaldo.EditValue);
                Ingresos = Convert.ToDouble(txtIngresos.EditValue);
                Total_Ingresos = Saldo - Ingresos;
                txtTotalIngresos.EditValue = Total_Ingresos.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularEgresos()
        {
            try
            {
                double Egresos = 0;
                foreach (var item in BindingList_Conciliacion_det_x_FP)
                {
                    Egresos -= (double)Math.Round(item.Valor_a_aplicar, 2, MidpointRounding.AwayFromZero);
                }

                foreach (var item in BindingList_conciliacion_det_x_ValeCaja)
                {
                    Egresos -= Math.Round(item.cm_valor, 2, MidpointRounding.AwayFromZero);
                }

                txtEgresos.EditValue = Egresos.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularIngresos()
        {
            try
            {
                double total = 0;

                foreach (cp_conciliacion_Caja_det_Ing_Caja_Info item in BindingList_conciliacion_det_x_Ing)
                {
                    total += item.Saldo;
                }

                txtIngresos.EditValue = Convert.ToDouble(total);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularSaldo()
        {
            try
            {
                decimal Saldo = 0;

                CbtDet_B.Get_SaldoContableMesAnterior(Info_caja.IdEmpresa, Info_caja.IdCtaCble, Convert.ToDateTime(de_fecha_ini.EditValue), ref Saldo, ref MensajeError);

                txtSaldo.Text = Saldo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularDiferencia()
        {
            try
            {
                double Egresos = 0;
                double Fondo = 0;
                double Diferencia = 0;

                Egresos = Convert.ToDouble(txtEgresos.EditValue);
                Fondo = Convert.ToDouble(txtFondo.EditValue);
                Diferencia = Egresos + Fondo;

                txtDiferencia.EditValue = Diferencia.ToString();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void cmbBeneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Genera_Diario_OP();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Buscar_OG_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_OrdenGiro_para_Conciliacion_Caja frm = new frmCP_OrdenGiro_para_Conciliacion_Caja();
                frm.ShowDialog();
                Info_OG = frm.Get_Orden_giro();
                if (Info_OG != null)
                {
                    if (Info_OG.IdEmpresa != 0)
                    {
                        if (BindingList_Conciliacion_det_x_FP.Where(q => q.IdEmpresa_OGiro == Info_OG.IdEmpresa && q.IdTipoCbte_Ogiro == Info_OG.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == Info_OG.IdCbteCble_Ogiro).Count() == 0)
                        {
                            cp_conciliacion_Caja_det_Info info = new cp_conciliacion_Caja_det_Info();
                            info.IdEmpresa = Info_OG.IdEmpresa;
                            info.IdEmpresa_OGiro = Info_OG.IdEmpresa;
                            info.IdCbteCble_Ogiro = Info_OG.IdCbteCble_Ogiro;
                            info.IdTipoCbte_Ogiro = Info_OG.IdTipoCbte_Ogiro;
                            info.Info_Orden_Giro.co_subtotal_iva = Info_OG.co_subtotal_iva;
                            info.Info_Orden_Giro.co_subtotal_siniva = Info_OG.co_subtotal_siniva;
                            info.Info_Orden_Giro.co_total = Info_OG.co_total;
                            info.Info_Orden_Giro.co_valoriva = Info_OG.co_valoriva;
                            info.Info_Orden_Giro.IdProveedor = Info_OG.IdProveedor;
                            info.Info_Orden_Giro.Num_Autorizacion = Info_OG.Num_Autorizacion;
                            info.Info_Orden_Giro.co_factura = Info_OG.co_factura;
                            info.Info_Orden_Giro.co_FechaFactura = Info_OG.co_FechaFactura;
                            info.Info_Orden_Giro.co_FechaFactura_vct = Info_OG.co_FechaFactura_vct;
                            info.Info_Orden_Giro.co_observacion = Info_OG.co_observacion;
                            info.Info_Orden_Giro.IdTipoFlujo = Info_OG.IdTipoFlujo;
                            info.Info_Orden_Giro.IdOrden_giro_Tipo = Info_OG.IdOrden_giro_Tipo;
                            info.Info_Orden_Giro.co_baseImponible = Info_OG.co_baseImponible;
                            info.Info_Orden_Giro.co_serie = Info_OG.co_serie;
                            info.Info_Orden_Giro.Total_Retencion = Info_OG.Total_Retencion;
                            info.Info_Orden_Giro.Valor_a_Pagar = Info_OG.Saldo_OG;
                            info.Info_Orden_Giro.IdIden_credito = Info_OG.IdIden_credito;
                            info.IdTipoMovi = Info_OG.IdTipoMovi == null ? (List_Caja_Movimiento_Tipo.Count == 0 ? 0 : List_Caja_Movimiento_Tipo.FirstOrDefault().IdTipoMovi) : Convert.ToInt32(Info_OG.IdTipoMovi);
                            info.Valor_a_aplicar = (decimal)Info_OG.Saldo_OG;
                            info.Tipo_documento = Info_OG.cod_Documento;
                            BindingList_Conciliacion_det_x_FP.Add(info);
                        }
                    }
                }
                CalcularEgresos();
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ConciCaja_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                Re_calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewValeCaja_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                Re_calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Punto_cargo_val_Click(object sender, EventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_Info row = (caj_Caja_Movimiento_Info)gridViewValeCaja.GetFocusedRow();
                if (row != null)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridViewValeCaja.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(rowHandle_val, colPunto_cargo_val);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);
                        frm_cons.ShowDialog();

                        info_punto_cargo = frm_cons.Get_Info();
                        if (info_punto_cargo != null)
                        {
                            gridViewValeCaja.SetFocusedRowCellValue(colPunto_cargo_val, info_punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridViewValeCaja.SetFocusedRowCellValue(colPunto_cargo_val, null);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Recalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Re_calcular();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_ImprimirCbtes_Click(object sender, EventArgs e)
        {
            try
            {
                XCONTA_Rpt009 Rpt = new XCONTA_Rpt009();
                Rpt.Set_Parametros(Info_Conciliacion.IdEmpresa, Info_Conciliacion.IdConciliacion_Caja);
                Rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Refrescar_consulta_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Cbte_x_Conciliacion();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_nuevo_FP_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        frm_og_simple = new frmCP_OrdenGiroMantenimiento_simplificada();
                        frm_og_simple.Set_accion(Cl_Enumeradores.eTipo_action.grabar);
                        frm_og_simple.ShowDialog();
                        Info_OG = frm_og_simple.Get_Orden_giro();
                        Insertar_fp_en_grilla();
                        break;
                    default:
                        frmCP_OrdenGiroMantenimiento FrmFP = new frmCP_OrdenGiroMantenimiento();
                        FrmFP.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                        FrmFP.ShowDialog();
                        FrmFP.event_frmCP_MantOrdenGiro_FormClosing += FrmFP_event_frmCP_MantOrdenGiro_FormClosing;
                        break;
                }
                CalcularEgresos();
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmFP_event_frmCP_MantOrdenGiro_FormClosing(object sender, FormClosingEventArgs e, cp_orden_giro_Info _Info_Orgen_Giro)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }

        }

        private void btn_nueva_ND_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_NotaDebito_Mant frm_ND = new frmCP_NotaDebito_Mant();

                frm_ND.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                frm_ND.ShowDialog();
                frm_ND.event_frmCP_NotaDebito_Mant_FormClosing += frm_ND_event_frmCP_NotaDebito_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        void frm_ND_event_frmCP_NotaDebito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Info_OG = _Info_Orgen_Giro;

                if (Info_OG != null)
                {
                    if (Info_OG.IdEmpresa != 0)
                    {
                        cp_conciliacion_Caja_det_Info info = new cp_conciliacion_Caja_det_Info();
                        info.IdEmpresa = Info_OG.IdEmpresa;
                        info.IdEmpresa_OGiro = Info_OG.IdEmpresa;
                        info.IdCbteCble_Ogiro = Info_OG.IdCbteCble_Ogiro;
                        info.IdTipoCbte_Ogiro = Info_OG.IdTipoCbte_Ogiro;
                        info.Info_Orden_Giro.co_subtotal_iva = Info_OG.co_subtotal_iva;
                        info.Info_Orden_Giro.co_subtotal_siniva = Info_OG.co_subtotal_siniva;
                        info.Info_Orden_Giro.co_total = Info_OG.co_total;
                        info.Info_Orden_Giro.co_valoriva = Info_OG.co_valoriva;
                        info.Info_Orden_Giro.IdProveedor = Info_OG.IdProveedor;
                        info.Info_Orden_Giro.Num_Autorizacion = Info_OG.Num_Autorizacion;
                        info.Info_Orden_Giro.co_factura = Info_OG.co_factura;
                        info.Info_Orden_Giro.co_FechaFactura = Info_OG.co_FechaFactura;
                        info.Info_Orden_Giro.co_FechaFactura_vct = Info_OG.co_FechaFactura_vct;
                        info.Info_Orden_Giro.co_observacion = Info_OG.co_observacion;
                        info.Info_Orden_Giro.IdTipoFlujo = Info_OG.IdTipoFlujo;
                        info.Info_Orden_Giro.IdOrden_giro_Tipo = Info_OG.IdOrden_giro_Tipo;
                        info.Info_Orden_Giro.co_baseImponible = Info_OG.co_baseImponible;
                        info.Info_Orden_Giro.co_serie = Info_OG.co_serie;
                        info.Info_Orden_Giro.Total_Retencion = Info_OG.Total_Retencion;
                        info.Info_Orden_Giro.Valor_a_Pagar = Info_OG.Saldo_OG;
                        info.Info_Orden_Giro.IdIden_credito = Info_OG.IdIden_credito;
                        info.IdTipoMovi = List_Caja_Movimiento_Tipo.Count == 0 ? 0 : List_Caja_Movimiento_Tipo.FirstOrDefault().IdTipoMovi;
                        info.Valor_a_aplicar = (decimal)Info_OG.Saldo_OG;
                        info.Tipo_documento = Info_OG.cod_Documento;
                        BindingList_Conciliacion_det_x_FP.Add(info);
                    }
                }
                CalcularEgresos();
                CalcularDiferencia();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnNuevoMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCa_caj_Caja_Movimiento_Tipo frm = new FrmCa_caj_Caja_Movimiento_Tipo();
                frm.set_accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                Cargar_combos_tipo_movimiento();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnImprimir_vales_Click(object sender, EventArgs e)
        {
            gridControlValeCaja.ShowPrintPreview();
        }

        private void btn_copiar_factura_Click(object sender, EventArgs e)
        {
            try
            {
                cp_conciliacion_Caja_det_Info row_conciliacion_det_FP = new cp_conciliacion_Caja_det_Info();
                row_conciliacion_det_FP = (cp_conciliacion_Caja_det_Info)gridView_ConciCaja.GetFocusedRow();

                if (row_conciliacion_det_FP == null)
                    return;

                if (row_conciliacion_det_FP.IdEmpresa_OGiro == null)
                    return;

                if (row_conciliacion_det_FP.IdEmpresa_OGiro == 0)
                    return;

                cp_orden_giro_Info info_og = new cp_orden_giro_Info();
                cp_orden_giro_Bus bus_og = new cp_orden_giro_Bus();

                info_og = bus_og.Get_Info_orden_giro(row_conciliacion_det_FP.IdEmpresa_OGiro, row_conciliacion_det_FP.IdTipoCbte_Ogiro, row_conciliacion_det_FP.IdCbteCble_Ogiro);
                if (info_og.IdEmpresa == 0)
                    return;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        frm_og_simple = new frmCP_OrdenGiroMantenimiento_simplificada();
                        frm_og_simple.set_ordenGiro(info_og);
                        frm_og_simple.Set_accion(Cl_Enumeradores.eTipo_action.duplicar);
                        frm_og_simple.ShowDialog();
                        Info_OG = frm_og_simple.Get_Orden_giro();
                        Insertar_fp_en_grilla();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Insertar_fp_en_grilla()
        {
            try
            {
                if (Info_OG != null)
                {
                    if (Info_OG.IdCbteCble_Ogiro != 0)
                    {
                        if (BindingList_Conciliacion_det_x_FP.Where(q => q.IdEmpresa_OGiro == Info_OG.IdEmpresa && q.IdTipoCbte_Ogiro == Info_OG.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == Info_OG.IdCbteCble_Ogiro).Count() == 0)
                        {
                            cp_conciliacion_Caja_det_Info info = new cp_conciliacion_Caja_det_Info();
                            info.IdEmpresa = Info_OG.IdEmpresa;
                            info.IdEmpresa_OGiro = Info_OG.IdEmpresa;
                            info.IdCbteCble_Ogiro = Info_OG.IdCbteCble_Ogiro;
                            info.IdTipoCbte_Ogiro = Info_OG.IdTipoCbte_Ogiro;
                            info.Info_Orden_Giro.co_subtotal_iva = Info_OG.co_subtotal_iva;
                            info.Info_Orden_Giro.co_subtotal_siniva = Info_OG.co_subtotal_siniva;
                            info.Info_Orden_Giro.co_total = Info_OG.co_total;
                            info.Info_Orden_Giro.co_valoriva = Info_OG.co_valoriva;
                            info.Info_Orden_Giro.IdProveedor = Info_OG.IdProveedor;
                            info.Info_Orden_Giro.Num_Autorizacion = Info_OG.Num_Autorizacion;
                            info.Info_Orden_Giro.co_factura = Info_OG.co_factura;
                            info.Info_Orden_Giro.co_FechaFactura = Info_OG.co_FechaFactura;
                            info.Info_Orden_Giro.co_FechaFactura_vct = Info_OG.co_FechaFactura_vct;
                            info.Info_Orden_Giro.co_observacion = Info_OG.co_observacion;
                            info.Info_Orden_Giro.IdTipoFlujo = Info_OG.IdTipoFlujo;
                            info.Info_Orden_Giro.IdOrden_giro_Tipo = Info_OG.IdOrden_giro_Tipo;
                            info.Info_Orden_Giro.co_baseImponible = Info_OG.co_baseImponible;
                            info.Info_Orden_Giro.co_serie = Info_OG.co_serie;
                            info.Info_Orden_Giro.Total_Retencion = Info_OG.Total_Retencion;
                            info.Info_Orden_Giro.Valor_a_Pagar = Info_OG.Saldo_OG;
                            info.Info_Orden_Giro.IdIden_credito = Info_OG.IdIden_credito;

                            info.IdTipoMovi = Convert.ToInt32(Info_OG.IdTipoMovi != null ? Info_OG.IdTipoMovi : (List_Caja_Movimiento_Tipo.Count == 0 ? 0 : List_Caja_Movimiento_Tipo.FirstOrDefault().IdTipoMovi));

                            info.Valor_a_aplicar = (decimal)Info_OG.Saldo_OG;
                            info.Tipo_documento = Info_OG.cod_Documento;
                            BindingList_Conciliacion_det_x_FP.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void de_fecha_ini_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar_ingresos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void de_fecha_fin_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar_ingresos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}

