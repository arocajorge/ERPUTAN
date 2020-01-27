using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;
using DevExpress.XtraGrid.Columns;



namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento : Form
    {
        #region Variables
        int IdEmpresa_ant = 0;
        int IdTipoCbte_ant = 0;
        decimal IdCbteCble_ant = 0;
        string StringBusqueda = "";

        //BUS
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwcp_cbtes_cxp_para_conciliar_Bus CbtesConciliarBus = new vwcp_cbtes_cxp_para_conciliar_Bus();
        vwcp_orden_pago_con_cancelacion_para_conciliacion_Bus ordenPagoBus = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Bus();
        vwct_cbtecble_con_saldo_cxp_Bus CCScxpBus = new vwct_cbtecble_con_saldo_cxp_Bus();
        ct_Cbtecble_tipo_Bus CCtipoBus = new ct_Cbtecble_tipo_Bus();

        cp_orden_pago_cancelaciones_Bus OrdenPagoCancesBus = new cp_orden_pago_cancelaciones_Bus();
        cp_conciliacion_Bus ConciliacionBus = new cp_conciliacion_Bus();
        cp_conciliacion_det_Bus ConciliacionDetBus = new cp_conciliacion_det_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cp_orden_pago_Bus cp_Bus = new cp_orden_pago_Bus();
        cp_orden_pago_det_Bus cpd_Bus = new cp_orden_pago_det_Bus();
        cp_orden_pago_tipo_x_empresa_Bus cp_OP_TipoxEmpresaBus = new cp_orden_pago_tipo_x_empresa_Bus();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        vwcp_orden_pago_con_cancelacion_Bus bus_OPxCancelar;

        //Listas
        List<cp_orden_pago_cancelacion_Info> OrdenPagoCanceInfo = new List<cp_orden_pago_cancelacion_Info>();
        List<cp_orden_pago_cancelaciones_Info> OrdenPagoCancesInfo = new List<cp_orden_pago_cancelaciones_Info>();
        List<ct_Cbtecble_tipo_Info> CCtipoInfoL = new List<ct_Cbtecble_tipo_Info>();
        List<cp_conciliacion_det_Info> ConciliacionDetInfoL = new List<cp_conciliacion_det_Info>();
        List<cp_orden_pago_cancelacion_Info> CP_OrdenPagoCancelacionINFO = new List<cp_orden_pago_cancelacion_Info>();
        List<cp_orden_pago_Info> cp_infol = new List<cp_orden_pago_Info>();
        List<cp_orden_pago_det_Info> cpd_infol = new List<cp_orden_pago_det_Info>();
        List<cp_orden_pago_det_Info> cpd_infol2 = new List<cp_orden_pago_det_Info>();
        List<vwcp_orden_pago_con_cancelacion_Info> List_OPxCancelar;

        //Infos
        vwct_cbtecble_con_saldo_cxp_Info CCScxpInfo = new vwct_cbtecble_con_saldo_cxp_Info();
        cp_conciliacion_Info ConciliacionInfo = new cp_conciliacion_Info();
        vwcp_orden_pago_con_cancelacion_para_conciliacion_Info OPccInfo = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Info();
        vwcp_cbtes_cxp_para_conciliar_Info CbtesConciliarInfo = new vwcp_cbtes_cxp_para_conciliar_Info();
        vwct_cbtecble_con_saldo_cxp_Info cbtecbleInfo = new vwct_cbtecble_con_saldo_cxp_Info();
        cp_orden_pago_Info cp_info = new cp_orden_pago_Info();
        cp_orden_pago_det_Info cpd_info = new cp_orden_pago_det_Info();
        vwct_cbtecble_con_saldo_cxp_Info cuentacontableinfo = new vwct_cbtecble_con_saldo_cxp_Info();
        cp_orden_pago_tipo_x_empresa_Info cp_OP_TipoxEmpresaInfo = new cp_orden_pago_tipo_x_empresa_Info();
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();

        //BindingList 
        BindingList<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> BinList_OrdenPago = new BindingList<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info>();
        BindingList<vwcp_cbtes_cxp_para_conciliar_Info> BinList_CXP_Fact_ND = new BindingList<vwcp_cbtes_cxp_para_conciliar_Info>();
        BindingList<vwct_cbtecble_con_saldo_cxp_Info> BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
        BindingList<vwcp_orden_pago_con_cancelacion_Info> BinList_OPxCancelacion;

        //Variables
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        public cp_conciliacion_Info SETINFO_ { get; set; }
        double ValorTotal = 0;
        double valorGeneral = 0;
        double total = 0;
        int consultanueva = 0;
        Boolean check = false;
        int inicioGridCompDis = 0;
        string radio = "";
        int _IdTipoCbte = 0;
        double suma = 0;
        string MensajeError = "";
        double sumaDiario = 0;
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        vwcp_orden_pago_con_cancelacion_Info info_OPxCance;
        public delegate void delegate_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing();
        public event delegate_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing event_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing;


        #endregion

        public frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;

                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cargar_Grids()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;


                txtIdConciliacion.Text = "";
                dtpFecha.EditValue = DateTime.Now;

                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);
                txtObservacion.EditValue = null;

                rbAnticipo.Checked = true;

                IdEmpresa_ant = 0;
                IdTipoCbte_ant = 0;
                IdCbteCble_ant = 0;

                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;


                bus_OPxCancelar = new vwcp_orden_pago_con_cancelacion_Bus();
                List_OPxCancelar = new List<vwcp_orden_pago_con_cancelacion_Info>();

                List_OPxCancelar = bus_OPxCancelar.Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(param.IdEmpresa, "APRO");

                foreach (var item in List_OPxCancelar)
                {
                    item.Saldo_x_Pagar_OP = Math.Round(item.Saldo_x_Pagar_OP, 2);
                    item.Saldo_x_Pagar2 = Math.Round(item.Saldo_x_Pagar2, 2);
                    item.Valor_estimado_a_pagar_OP = Math.Round(item.Valor_estimado_a_pagar_OP, 2);
                }

                BinList_OPxCancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(List_OPxCancelar);
                gridControl_OPxCancelar.DataSource = BinList_OPxCancelacion;

                UC_Diario.LimpiarGrid();


                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                BtnBuscar.Enabled = true;
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
                Cargar_Grids();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_FormClosing();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCP_Conciliacion_cuenta_x_pagar_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                BinList_OPxCancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                gridControl_OPxCancelar.DataSource = BinList_OPxCancelacion;

                dtpDesde.DateTime = DateTime.Now.AddMonths(-1);
                dtpDesde.DateTime = DateTime.Now.AddMonths(1);


                load();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        bus_OPxCancelar = new vwcp_orden_pago_con_cancelacion_Bus();
                        List_OPxCancelar = new List<vwcp_orden_pago_con_cancelacion_Info>();

                        List_OPxCancelar = bus_OPxCancelar.Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(param.IdEmpresa, "APRO");
                        //Solo deben aparecer facturas que tengan op
                        List_OPxCancelar = List_OPxCancelar.Where(q => q.IdTipo_op == "FACT_PROVEE" && q.Estado == "A").ToList();
                        foreach (var item in List_OPxCancelar)
                        {
                            item.Saldo_x_Pagar_OP = Math.Round(item.Saldo_x_Pagar_OP, 2);
                            item.Saldo_x_Pagar2 = Math.Round(item.Saldo_x_Pagar2, 2);
                            item.Valor_estimado_a_pagar_OP = Math.Round(item.Valor_estimado_a_pagar_OP, 2);
                        }

                        BinList_OPxCancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(List_OPxCancelar);
                        gridControl_OPxCancelar.DataSource = BinList_OPxCancelacion;
                        ucGe_Menu.Visible_bntAnular = false;
                        colTotal_cancelado_OP_can.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        SETINFO();

                        gridViewCompDis.OptionsBehavior.Editable = false;
                        dtpFecha.Enabled = false;
                        BtnBuscar.Enabled = false;

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        rbAnticipo.Enabled = false;

                        rbDiarioContable.Enabled = false;


                        txtObservacion.Properties.ReadOnly = true;

                        colCheck_can.OptionsColumn.AllowEdit = false;
                        colCheck1.OptionsColumn.AllowEdit = false;
                        colTotal_cancelado_OP_can.OptionsColumn.AllowEdit = false;
                        colValor_aplicado_can.Visible = false;

                        ucGe_Menu.Visible_bntLimpiar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        SETINFO();

                        gridViewCompDis.OptionsBehavior.Editable = false;
                        dtpFecha.Enabled = false;
                        BtnBuscar.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = true;

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

        public void load()
        {
            try
            {

                rbAnticipo.Checked = true;

                dtpFecha.EditValue = DateTime.Now.Date;
                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.Date.AddMonths(+1);

                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtpFecha.EditValue), ref MensajeError);
                _IdTipoCbte = paramCP_I.pa_TipoCbte_para_conci_x_antcipo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Get()
        {
            try
            {
                ConciliacionInfo = new cp_conciliacion_Info();
                ConciliacionInfo.IdEmpresa = param.IdEmpresa;

                ConciliacionInfo.nom_pc = param.nom_pc;
                ConciliacionInfo.ip = param.ip;
                ConciliacionInfo.Fecha_Transac = param.Fecha_Transac.Date;
                //  ConciliacionInfo.Tipo_detalle = (tabControl.SelectedTab == tabPage1) ? "CxP" : "OPP"; //duda
                ConciliacionInfo.Tipo_detalle = "";

                ConciliacionInfo.Observacion = Convert.ToString(txtObservacion.EditValue);
                ConciliacionInfo.tipo = radio;


                OrdenPagoCancesInfo = new List<cp_orden_pago_cancelaciones_Info>();
                cuentacontableinfo = new vwct_cbtecble_con_saldo_cxp_Info();
                foreach (var itemcc in BinList_Anticipo_Diarios)
                {
                    if (itemcc.Check == true)
                    {
                        cuentacontableinfo = itemcc;
                        break;
                    }
                }



                if (tabControl.SelectedTab == tabPage5)
                {
                    foreach (var item in this.BinList_OPxCancelacion)
                    {
                        if (item.Check == true)
                        {
                            cp_orden_pago_cancelaciones_Info opcsinfo = new cp_orden_pago_cancelaciones_Info();

                            if (item.IdOrdenPago == null)
                            {
                                // Generar Orden Pago

                                cp_orden_pago_Info info_OP = new cp_orden_pago_Info();
                                info_OP.IdEmpresa = item.IdEmpresa;
                                info_OP.Observacion = "Orden de Pago generada por Conciliación";
                                info_OP.IdTipo_op = item.IdTipo_op;
                                info_OP.IdTipo_Persona = item.IdTipoPersona;
                                info_OP.IdPersona = item.IdPersona;

                                if (item.IdEntidad != null)
                                {
                                    info_OP.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                                }

                                info_OP.Fecha = DateTime.Now; // duda
                                info_OP.IdEstadoAprobacion = "APRO";
                                info_OP.IdFormaPago = "CHEQUE"; // duda
                                info_OP.Fecha_Pago = DateTime.Now;
                                info_OP.IdUsuario = param.IdUsuario;

                                // detalle
                                cp_orden_pago_det_Info info_DetOP = new cp_orden_pago_det_Info();

                                info_DetOP.IdEmpresa = item.IdEmpresa;
                                info_DetOP.IdEmpresa_cxp = Convert.ToInt32(item.IdEmpresa_cxp);
                                info_DetOP.IdCbteCble_cxp = item.IdCbteCble_cxp;
                                info_DetOP.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                                info_DetOP.Valor_a_pagar = item.Valor_aplicado;
                                info_DetOP.Referencia = item.Referencia;
                                info_DetOP.IdFormaPago = "CHEQUE";
                                info_DetOP.Fecha_Pago = DateTime.Now;
                                info_DetOP.IdEstadoAprobacion = "APRO";

                                info_OP.Detalle.Add(info_DetOP);

                                // grabar OP
                                decimal Id = 0;
                                string mensaje = "";
                                cp_orden_pago_Bus Bus_OrdenPago = new cp_orden_pago_Bus();
                                if (Bus_OrdenPago.GuardaDB(info_OP, ref Id, ref mensaje))
                                {
                                    item.IdEmpresa = info_OP.IdEmpresa;
                                    item.IdOrdenPago = Id;
                                    item.Secuencia_OP = Convert.ToInt32(info_OP.Detalle.FirstOrDefault().Secuencia);
                                }

                            }

                            opcsinfo.IdEmpresa = param.IdEmpresa;
                            opcsinfo.Idcancelacion = 0;
                            opcsinfo.Secuencia = 0;

                            opcsinfo.IdEmpresa_op = item.IdEmpresa;
                            opcsinfo.IdOrdenPago_op = (item.IdOrdenPago == null) ? 0 : Convert.ToDecimal(item.IdOrdenPago);
                            opcsinfo.Secuencia_op = (item.Secuencia_OP == null) ? 0 : Convert.ToInt32(item.Secuencia_OP);


                            opcsinfo.IdEmpresa_cxp = item.IdEmpresa_cxp;	//AbajoGrid
                            opcsinfo.IdTipoCbte_cxp = item.IdTipoCbte_cxp;	//AbajoGrid
                            opcsinfo.IdCbteCble_cxp = item.IdCbteCble_cxp;	//AbajoGrid

                            if (radio == "ANTPROV")
                            {
                                //consulto cabecera diario
                                ct_Cbtecble_Bus bus_cbtecble = new ct_Cbtecble_Bus();
                                ct_Cbtecble_Info info_cbtcble = new ct_Cbtecble_Info();
                                string msgError = "";
                                info_cbtcble = bus_cbtecble.Get_Info_CbteCble(Convert.ToInt32(cuentacontableinfo.IdEmpresa), Convert.ToInt32(cuentacontableinfo.IdTipocbte), Convert.ToDecimal(cuentacontableinfo.IdCbteCble), ref msgError);

                                if (info_cbtcble.IdEmpresa != 0)
                                {
                                    // consulto detalle diario
                                    ct_Cbtecble_det_Bus detbus_cbtecble = new ct_Cbtecble_det_Bus();
                                    List<ct_Cbtecble_det_Info> List_Detcbtecble = new List<ct_Cbtecble_det_Info>();
                                    List_Detcbtecble = detbus_cbtecble.Get_list_Cbtecble_det(Convert.ToInt32(cuentacontableinfo.IdEmpresa), Convert.ToInt32(cuentacontableinfo.IdTipocbte), Convert.ToDecimal(cuentacontableinfo.IdCbteCble), ref msgError);

                                    if (List_Detcbtecble.Count != 0)
                                    {
                                        info_cbtcble._cbteCble_det_lista_info = List_Detcbtecble;
                                    }
                                }

                                ct_Cbtecble_Info info = new ct_Cbtecble_Info();

                                // Creo nuevo diario
                                info.IdEmpresa = info_cbtcble.IdEmpresa;
                                info.IdTipoCbte = info_cbtcble.IdTipoCbte;
                                info.CodCbteCble = info_cbtcble.CodCbteCble;
                                info.IdPeriodo = info_cbtcble.IdPeriodo;
                                info.cb_Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                                info.cb_Valor = item.Valor_aplicado;  //duda
                                info.cb_Observacion = txtObservacion.Text;
                                info.Secuencia = info_cbtcble.Secuencia;
                                info.Estado = "A";
                                info.Anio = info_cbtcble.Anio;
                                info.Mes = info_cbtcble.Mes;
                                info.IdUsuario = param.IdUsuario;
                                info.cb_FechaTransac = param.Fecha_Transac;
                                info.Mayorizado = "N";

                                var lst_cbte = from q in info_cbtcble._cbteCble_det_lista_info
                                               group q by new { q.IdEmpresa, q.IdTipoCbte, q.IdCbteCble, q.IdCtaCble }
                                                   into grouping
                                                   select new
                                                   {
                                                       grouping.Key.IdEmpresa,
                                                       grouping.Key.IdTipoCbte,
                                                       grouping.Key.IdCtaCble,
                                                       dc_Valor = grouping.Sum(q => q.dc_Valor)
                                                   };

                                foreach (var item2 in lst_cbte)
                                {
                                    ct_Cbtecble_det_Info det_Info = new ct_Cbtecble_det_Info();
                                    if (item2.dc_Valor < 0)
                                    {
                                        // debe
                                        det_Info.IdEmpresa = item2.IdEmpresa;
                                        det_Info.IdTipoCbte = item2.IdTipoCbte;
                                        det_Info.IdCtaCble = item2.IdCtaCble;
                                        //det_Info.IdCentroCosto = item2.IdCentroCosto;
                                        //det_Info.IdCentroCosto_sub_centro_costo = item2.IdCentroCosto_sub_centro_costo;
                                        //det_Info.dc_Valor = Math.Abs(item2.dc_Valor);
                                        det_Info.dc_Valor = item.Valor_aplicado;   //duda
                                        det_Info.dc_Observacion = txtObservacion.Text;

                                        info._cbteCble_det_lista_info.Add(det_Info);

                                    }
                                    else
                                    {
                                        // haber
                                        det_Info.IdEmpresa = item2.IdEmpresa;
                                        det_Info.IdTipoCbte = item2.IdTipoCbte;
                                        det_Info.IdCtaCble = item2.IdCtaCble;
                                        //det_Info.IdCentroCosto = item2.IdCentroCosto;
                                        //det_Info.IdCentroCosto_sub_centro_costo = item2.IdCentroCosto_sub_centro_costo;
                                        //det_Info.dc_Valor = Math.Abs(item2.dc_Valor) * -1;
                                        det_Info.dc_Valor = item.Valor_aplicado * -1;  // duda
                                        det_Info.dc_Observacion = txtObservacion.Text;

                                        info._cbteCble_det_lista_info.Add(det_Info);

                                    }
                                }

                                // Grabar Nuevo Diario
                                decimal IdCbteCble = 0;
                                if (bus_cbtecble.GrabarDB(info, ref IdCbteCble, ref msgError))
                                {

                                    opcsinfo.IdEmpresa_op_padre = cuentacontableinfo.IdEmpresaOP;
                                    opcsinfo.IdOrdenPago_op_padre = cuentacontableinfo.IdOrdenPagoOP;
                                    opcsinfo.Secuencia_op_padre = cuentacontableinfo.SecuenciaOP;

                                    opcsinfo.IdEmpresa_pago = info.IdEmpresa;
                                    opcsinfo.IdTipoCbte_pago = info.IdTipoCbte;
                                    opcsinfo.IdCbteCble_pago = IdCbteCble;


                                    //Para la cabecera de la conciliación
                                    IdEmpresa_ant = info.IdEmpresa;
                                    IdTipoCbte_ant = info.IdTipoCbte;
                                    IdCbteCble_ant = info.IdCbteCble;

                                }
                            }
                            else
                            {
                                opcsinfo.IdEmpresa_op_padre = null;
                                opcsinfo.IdOrdenPago_op_padre = null;
                                opcsinfo.Secuencia_op_padre = null;


                                opcsinfo.IdEmpresa_pago = Convert.ToInt32(cuentacontableinfo.IdEmpresa);//ArribaGrid
                                opcsinfo.IdTipoCbte_pago = cuentacontableinfo.IdTipocbte;	//ArribaGrid
                                opcsinfo.IdCbteCble_pago = cuentacontableinfo.IdCbteCble;	//ArribaGrid

                            }



                            opcsinfo.MontoAplicado = item.Valor_aplicado;
                            opcsinfo.SaldoAnterior = item.Valor_estimado_a_pagar_OP;
                            opcsinfo.SaldoActual = item.Saldo_x_Pagar_OP;

                            opcsinfo.Observacion = Convert.ToString(txtObservacion.EditValue);
                            opcsinfo.fechaTransaccion = Convert.ToDateTime(dtpFecha.EditValue).Date;

                            OrdenPagoCancesInfo.Add(opcsinfo);
                        }
                    }
                }

                ConciliacionInfo.lista_Orden_Pago_Cancel = OrdenPagoCancesInfo;

                foreach (var item in OrdenPagoCancesInfo)
                {
                    ConciliacionInfo.IdConciliacion = 0;
                    ConciliacionInfo.Observacion = item.Observacion;
                    ConciliacionInfo.Fecha = item.fechaTransaccion;
                    ConciliacionInfo.IdCancelacion = item.Idcancelacion;
                    break;
                }

                GETINFODETALLECONCILIACION();

                ConciliacionInfo.lista_Det_Concilia = ConciliacionDetInfoL;

                if (radio == "ANTPROV")
                {
                    GeneraDiario();

                    // if (!UC_Diario.valida_ct_Cbtecble_det())
                    // {
                    //     return false;
                    // }

                    //  get_Cbtecble();

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

        public Boolean GETINFODETALLECONCILIACION()
        {
            try
            {
                foreach (var item in OrdenPagoCancesInfo)
                {
                    cp_conciliacion_det_Info ConcDetinfo = new cp_conciliacion_det_Info();
                    ConcDetinfo.IdEmpresa = item.IdEmpresa;
                    ConcDetinfo.IdConciliacion = ConciliacionInfo.IdConciliacion;
                    ConcDetinfo.Secuencia = item.Secuencia;
                    ConcDetinfo.IdEmpresa_op = item.IdEmpresa_op;
                    ConcDetinfo.IdOrdenPago_op = item.IdOrdenPago_op;
                    ConcDetinfo.Secuencia_op = item.Secuencia_op;
                    ConcDetinfo.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    ConcDetinfo.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    ConcDetinfo.IdCbteCble_cxp = item.IdCbteCble_cxp;

                    ConcDetinfo.IdEmpresa_pago = Convert.ToInt32(item.IdEmpresa_pago);
                    ConcDetinfo.IdTipoCbte_pago = item.IdTipoCbte_pago;
                    ConcDetinfo.IdCbteCble_pago = item.IdCbteCble_pago;

                    ConcDetinfo.MontoAplicado = item.MontoAplicado;
                    ConcDetinfo.SaldoAnterior = item.SaldoAnterior;
                    ConcDetinfo.SaldoActual = item.SaldoActual;
                    ConcDetinfo.Observacion = item.Observacion;
                    ConcDetinfo.fechaTransaccion = item.fechaTransaccion;

                    ConciliacionDetInfoL.Add(ConcDetinfo);
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

        public Boolean SETINFO()
        {
            try
            {
                double suma = 0;
                string mensaje = "";
                txtIdConciliacion.EditValue = SETINFO_.IdConciliacion;
                dtpFecha.EditValue = SETINFO_.Fecha;
                txtObservacion.EditValue = SETINFO_.Observacion;

                Set_Consulta_Cancelaciones();

                //Comprobantes Disponibles                
                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                ConciliacionDetInfoL = new List<cp_conciliacion_det_Info>();
                ConciliacionDetInfoL = ConciliacionDetBus.Get_List_Conciliacion_x_cbte_cble(param.IdEmpresa, SETINFO_.IdConciliacion);
                string TIPO = "";
                foreach (var item in ConciliacionDetInfoL)
                {
                    vwct_cbtecble_con_saldo_cxp_Info inf = new vwct_cbtecble_con_saldo_cxp_Info();
                    inf.IdEmpresa = item.IdEmpresa;
                    inf.IdCbteCble = item.IdCbteCble;
                    inf.tipo = item.Tipo;
                    TIPO = item.Tipo;
                    inf.IdTipocbte = item.IdTipocbte;
                    inf.cb_Fecha = item.cb_Fecha;
                    inf.cb_Observacion = item.cb_Observacion;
                    inf.referencia = item.referencia;
                    inf.tc_TipoCbte = item.tc_TipoCbte;
                    inf.Valor_cbte = item.Valor_cbte;

                    inf.Valor_cancelado_cbte = item.Valor_cancelado_cbte;
                    inf.valor_Saldo_cbte = item.valor_Saldo_cbte;
                    inf.Beneficiario = item.Beneficiario;

                    BinList_Anticipo_Diarios.Add(inf);
                }

                foreach (var item in BinList_Anticipo_Diarios)
                {
                    item.Check = true;
                }

                if (TIPO.Trim() == "ANTPROV")
                {
                    consultanueva = 1;
                    rbAnticipo.Checked = true;
                }
                if (TIPO.Trim() == "NCPROV")
                {
                    consultanueva = 1;
                    // rbNotaCredito.Checked = true;
                }
                if (TIPO.Trim() == "DIARIO" || TIPO.Trim() == "DIARIO_BAN")
                {
                    consultanueva = 1;
                    rbDiarioContable.Checked = true;
                }
                //CCScxpInfoL = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>(CCScxpInfoL.ToList().FindAll(q => q.tipo == set.Trim()));

                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;

                //llena grid contable

                ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                UC_Diario.LimpiarGrid();
                string mensajeRROR = "";
                lm = _CbteCbleBus.Get_list_Cbtecble_det(SETINFO_.IdEmpresa_cbtecble, SETINFO_.IdTipoCbte_cbtecble, SETINFO_.IdCbteCble_cbtecble, ref mensajeRROR);
                // _ListaCbteCbleDetAnt = lm;
                UC_Diario.setDetalle(lm);
                UC_Diario.HabilitarGrid(false);

                if (SETINFO_.Estado == "I")
                { lblAnular.Visible = true; }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Set_Consulta_Cancelaciones()
        {
            try
            {

                string mensaj = "";
                cp_orden_pago_cancelaciones_Bus bus_Cancela = new cp_orden_pago_cancelaciones_Bus();
                List<cp_orden_pago_cancelaciones_Info> lista_Cance = new List<cp_orden_pago_cancelaciones_Info>();

                lista_Cance = bus_Cancela.ConsultaGeneralOPCxIdCancelaciones(param.IdEmpresa, SETINFO_.IdCancelacion, ref mensaj);

                List<vwcp_orden_pago_con_cancelacion_Info> lista_vwCance_AUX = new List<vwcp_orden_pago_con_cancelacion_Info>();

                if (lista_Cance.Count != 0)
                {
                    foreach (var item in lista_Cance)
                    {

                        bus_OPxCancelar = new vwcp_orden_pago_con_cancelacion_Bus();
                        List<vwcp_orden_pago_con_cancelacion_Info> List_OPxCancelar = new List<vwcp_orden_pago_con_cancelacion_Info>();

                        //List_OPxCancelar = bus_OPxCancelar.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(Convert.ToInt32(item.IdEmpresa_op), Convert.ToDecimal(item.IdOrdenPago_op), Convert.ToInt32(item.Secuencia_op));

                        //List_OPxCancelar = bus_OPxCancelar.Get_List_orden_pago_con_cancelacion_todos_Mayor_a_cero(Convert.ToInt32(item.IdEmpresa_op), Convert.ToDecimal(item.IdOrdenPago_op), Convert.ToInt32(item.Secuencia_op));

                        if (List_OPxCancelar.Count != 0)
                        {
                            foreach (var item2 in List_OPxCancelar)
                            {
                                item2.Saldo_x_Pagar_OP = Math.Round(item2.Saldo_x_Pagar_OP, 2);
                                item2.Total_cancelado_OP = Math.Round(item2.Total_cancelado_OP, 2);
                                item2.Valor_estimado_a_pagar_OP = Math.Round(item2.Valor_estimado_a_pagar_OP, 2);
                            }

                            lista_vwCance_AUX.AddRange(List_OPxCancelar);
                        }
                    }

                }

                if (lista_vwCance_AUX.Count != 0)
                {

                    BinList_OPxCancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(lista_vwCance_AUX);
                    gridControl_OPxCancelar.DataSource = BinList_OPxCancelacion;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarGridCompDis()
        {
            try
            {
                check = false;
                string mensaje = "";


                if (radio == "ANTPROV")
                {

                    vwcp_Anticipos_para_Conciliar_Bus bus_antxCon = new vwcp_Anticipos_para_Conciliar_Bus();
                    List<vwcp_Anticipos_para_Conciliar_Info> lista_AntxConciliar = new List<vwcp_Anticipos_para_Conciliar_Info>();

                    lista_AntxConciliar = bus_antxCon.Get_list_Anticipos_para_Conciliar(param.IdEmpresa, "", Convert.ToDateTime(dtpDesde.EditValue).Date, Convert.ToDateTime(dtpHasta.EditValue).Date, ref mensaje);

                    List<vwct_cbtecble_con_saldo_cxp_Info> lista_saldoCbte = new List<vwct_cbtecble_con_saldo_cxp_Info>();

                    if (lista_AntxConciliar.Count != 0)
                    {

                        foreach (var item in lista_AntxConciliar)
                        {
                            vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();

                            info.IdEmpresa = item.IdEmpresa_cxp;
                            info.IdCbteCble = item.IdCbteCble_cxp;
                            info.IdTipocbte = item.IdTipocbte_cxp;
                            info.cb_Fecha = item.Fecha;
                            info.cb_Observacion = item.Observacion;
                            info.referencia = item.referencia;
                            info.tc_TipoCbte = item.tc_TipoCbte;
                            info.Valor_cbte = item.Valor_cbte;
                            info.Valor_cancelado_cbte = item.Valor_cancelado;
                            info.valor_Saldo_cbte = item.valor_Saldo_cbte;


                            info.tipo = item.tipo;

                            info.IdEmpresaOP = item.IdEmpresaOP;
                            info.IdOrdenPagoOP = item.IdOrdenPagoOP;
                            info.SecuenciaOP = item.SecuenciaOP;

                            info.IdCtaCble = item.IdCtaCble;
                            info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;
                            info.Beneficiario = item.Beneficiario;

                            info.IdBeneficiario = item.IdProveedor;
                            info.IdPersona = item.IdPersona;
                            lista_saldoCbte.Add(info);


                        }

                        BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>(lista_saldoCbte);
                        gridControlCompDis.DataSource = BinList_Anticipo_Diarios;

                    }
                    else
                    {

                        BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                        gridControlCompDis.DataSource = BinList_Anticipo_Diarios;
                    }
                }
                else
                {

                    BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>(CCScxpBus.Get_list_cbtecble_con_saldo_cxp(param.IdEmpresa, radio, Convert.ToDateTime(dtpDesde.EditValue).Date, Convert.ToDateTime(dtpHasta.EditValue).Date, ref mensaje));
                }


                if (BinList_Anticipo_Diarios.Count == 0)
                {
                    MessageBox.Show("No existe Información de Consulta", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in BinList_Anticipo_Diarios)
                {
                    item.Check = false;
                    item.Valor_cancelado_cbte = Convert.ToDouble(item.valor_Saldo_cbte);

                }
                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;

                foreach (var item in BinList_Anticipo_Diarios)
                {
                    if (item.Check == true)
                    {
                        check = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void ValidarGridCompDis()
        {
            try
            {
                if (dtpDesde.EditValue == null || dtpDesde.EditValue == "")
                {
                    MessageBox.Show("Falta campo fecha Desde", "Operación Erronea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtpHasta.EditValue == null || dtpHasta.EditValue == "")
                {
                    MessageBox.Show("Falta campo fecha Hasta", "Operación Erronea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Convert.ToDateTime(dtpDesde.EditValue).Date > Convert.ToDateTime(dtpHasta.EditValue).Date)
                {
                    MessageBox.Show("La fecha desde es MAYOR a la fecha hasta,\nporfavor el campo de la fecha desde \nno puede ser mayor.", "Operación Erronea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public Boolean Validar()
        {
            try
            {
                Boolean verd = false;

                if (CCScxpInfo == null)
                {
                    MessageBox.Show("Debe seleccionar un comprobante contable si desea continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                foreach (var item in BinList_Anticipo_Diarios)
                {
                    if (item.Check == true)
                    {
                        verd = true;
                        break;
                    }
                }

                if (verd == false)
                {
                    MessageBox.Show("Debe seleccionar un comprobante contable si desea continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                verd = false;


                if (tabControl.SelectedTab == tabPage5)
                {
                    foreach (var item in BinList_OPxCancelacion)
                    {
                        if (item.Check == true)
                        {
                            verd = true;
                            break;
                        }
                    }
                }

                if (verd == false)
                {
                    MessageBox.Show("Debe seleccionar una orden de pago por Cancelar si desea continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (rbAnticipo.Checked == true)
                {

                    GeneraDiario();

                    if (!UC_Diario.valida_ct_Cbtecble_det())
                        if (!UC_Diario.ValidarAsientosContables())
                        {
                            return false;
                        }

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

        public void BlanquearGridCompDis()
        {
            try
            {
                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public Boolean Grabar()
        {
            try
            {
                Boolean regresa = false;
                string mensaje = "";


                if (Get())
                {
                    if (IdEmpresa_ant != 0)
                    {
                        ConciliacionInfo.IdEmpresa_cbtecble = IdEmpresa_ant;
                        ConciliacionInfo.IdTipoCbte_cbtecble = IdTipoCbte_ant;
                        ConciliacionInfo.IdCbteCble_cbtecble = IdCbteCble_ant;
                    }

                    if (ConciliacionBus.GrabarDB(ref ConciliacionInfo, CbteCble_I, ref mensaje))//GRABAR EN CABECERA CONCILIACION
                    {
                        regresa = true;
                    }
                }
                if (regresa == true)
                {
                    txtIdConciliacion.EditValue = ConciliacionInfo.IdConciliacion;
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Conciliación", txtIdConciliacion.EditValue);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    Cargar_Grids();

                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, mensaje);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                ValidarGridCompDis();
                CargarGridCompDis();

                inicioGridCompDis++;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoComprobante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                BlanquearGridCompDis();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDesde_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                BlanquearGridCompDis();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpHasta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                BlanquearGridCompDis();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        decimal? IdBeneficiario = 0;

        private void gridViewCompDis_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                StringBusqueda = "";


                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }


                if (e.Column.Name == "colCheck1")
                {
                    CCScxpInfo = new vwct_cbtecble_con_saldo_cxp_Info();
                    CCScxpInfo = (vwct_cbtecble_con_saldo_cxp_Info)gridViewCompDis.GetFocusedRow();
                    IdBeneficiario = CCScxpInfo.IdPersona;
                    StringBusqueda = CCScxpInfo.Beneficiario;
                    valorGeneral = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte);
                    RefrescarCompDis(CCScxpInfo, 1);

                    this.gridView_OPxCancelar.ActiveFilterString = "[Nom_Beneficiario] like '%" + StringBusqueda.Trim() + "%'";

                    if (CCScxpInfo.Check == false)
                    {
                        /*
                          foreach (var item in BinList_OPxCancelacion)
                          {                         
                              item.Check = false;
                              item.Check_aux = false;
                              item.Valor_aplicado = 0;
                              item.Valor_estimado_a_pagar_OP=item.Saldo_x_Pagar2;
                          }
                          */
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

        public void RefrescarCompDis(vwct_cbtecble_con_saldo_cxp_Info CCScxpInfo, int Qgrides)
        {


            decimal valors = 0;
            try
            {
                foreach (var item in BinList_Anticipo_Diarios)
                {
                    if (item.IdCbteCble == CCScxpInfo.IdCbteCble && item.tc_TipoCbte == CCScxpInfo.tc_TipoCbte && inicioGridCompDis > 0)
                    {
                        valors = Math.Abs(Convert.ToDecimal(item.Valor_cbte - ValorTotal));

                        if ((valors > 0 || total > 0) || (Qgrides > 0))
                        {
                            if (item.Check == true)
                            {
                                if (Qgrides == 1)
                                {
                                    item.Check = false;

                                }
                                if (Convert.ToDouble(item.valor_Saldo_cbte) > ValorTotal)
                                    item.Valor_cancelado_cbte = Convert.ToDouble(item.valor_Saldo_cbte) - ValorTotal;
                                else
                                {
                                    double val = 0;
                                    val = ValorTotal - Convert.ToDouble(item.valor_Saldo_cbte);
                                    CbtesConciliarInfo.co_valorpagar = CbtesConciliarInfo.co_valorpagar - val;
                                    CbtesConciliarInfo.Saldo = CbtesConciliarInfo.Saldo_x_Pagar2 - CbtesConciliarInfo.co_valorpagar;

                                    foreach (var item2 in BinList_CXP_Fact_ND)
                                    {
                                        if (item2.IdCbte_cxp == CbtesConciliarInfo.IdCbte_cxp && item2.IdProveedor == CbtesConciliarInfo.IdProveedor && item2.IdEmpresa == CbtesConciliarInfo.IdEmpresa && item2.Su_Descripcion == CbtesConciliarInfo.Su_Descripcion)
                                        {
                                            item2.check = CbtesConciliarInfo.check;
                                            item2.Saldo = CbtesConciliarInfo.Saldo;
                                            item2.co_valorpagar = CbtesConciliarInfo.co_valorpagar;
                                        }
                                    }
                                    item.Valor_cancelado_cbte = 0;
                                }
                            }
                            else
                            {
                                if (Qgrides == 1)
                                {
                                    item.Check = true;

                                }
                                item.Valor_cancelado_cbte = Convert.ToDouble(item.valor_Saldo_cbte);
                                ValorTotal = 0;
                            }
                        }
                        else
                        {
                            if (CbtesConciliarInfo.check == false)
                            {
                                item.Valor_cancelado_cbte = Convert.ToDouble(item.valor_Saldo_cbte) - ValorTotal;
                            }
                            else
                            {
                                double numerostotales = 0;
                                foreach (var item3 in BinList_CXP_Fact_ND)
                                {
                                    if (item3.check == true)
                                    {
                                        numerostotales = numerostotales + item3.co_valorpagar;
                                    }
                                }
                                if (numerostotales >= ValorTotal && CbtesConciliarInfo.check == true && CbtesConciliarInfo.co_valorpagar > 0)
                                {

                                }
                                else
                                {
                                    MessageBox.Show("El monto de saldo pendiente ha llegado a su límite", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CbtesConciliarInfo.check = false;
                                    CbtesConciliarInfo.Saldo = CbtesConciliarInfo.Saldo_x_Pagar2;
                                    CbtesConciliarInfo.co_valorpagar = 0;

                                    item.Valor_cancelado_cbte = 0;
                                }
                            }
                        }
                        total = item.Valor_cancelado_cbte;
                    }
                    else
                    {
                        item.Check = false;
                    }
                }
                gridControlCompDis.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Anular()
        {
            try
            {
                string mensaje = "";
                if (paramCP_I.pa_TipoCbte_para_conci_anulacion_x_antcipo == null)
                {
                    MessageBox.Show("Parametrice el tipo de comprobante para la anulación de conciliación de cxp", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                OrdenPagoCancesInfo = new List<cp_orden_pago_cancelaciones_Info>();

                OrdenPagoCancesInfo = OrdenPagoCancesBus.ConsultaGeneralOPCxIdCancelaciones(param.IdEmpresa, SETINFO_.IdCancelacion, ref mensaje);

                foreach (var item in OrdenPagoCancesInfo)
                {
                    int IdTipoCbte_rev = Convert.ToInt32(paramCP_I.pa_TipoCbte_para_conci_anulacion_x_antcipo);
                    decimal IdCbteCble_rev = 0;

                    ct_Cbtecble_Bus bus_CbteCble = new ct_Cbtecble_Bus();
                    if (bus_CbteCble.ReversoCbteCble(Convert.ToInt32(item.IdEmpresa_pago), Convert.ToDecimal(item.IdCbteCble_pago), Convert.ToInt32(item.IdTipoCbte_pago), IdTipoCbte_rev, ref IdCbteCble_rev, ref mensaje, param.IdUsuario, ""))
                    {
                        if (OrdenPagoCancesBus.Eliminar_OrdenPagoCancelaciones(item, ref mensaje))
                        {

                            string motiAnulacion = "";
                            FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                            fr.ShowDialog();
                            motiAnulacion = fr.motivoAnulacion;
                            SETINFO_.MotivoAnu = motiAnulacion;
                            SETINFO_.Fecha_Transac = param.Fecha_Transac.Date;
                            SETINFO_.Fecha_UltAnu = DateTime.Now.Date;
                            SETINFO_.Fecha_UltMod = DateTime.Now.Date;
                            SETINFO_.nom_pc = param.nom_pc;
                            SETINFO_.ip = param.ip;
                            SETINFO_.IdUsuarioUltAnu = param.IdUsuario;
                            /*
                            SETINFO_.IdEmpresa_cbtecble = item.IdEmpresa;
                            SETINFO_.IdTipoCbte_cbtecble = IdTipoCbte_rev;
                            SETINFO_.IdCbteCble_cbtecble = IdCbteCble_rev;
                            */

                            if (ConciliacionBus.AnularDB(SETINFO_, ref mensaje))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Conciliación", SETINFO_.IdConciliacion);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                ucGe_Menu.Visible_bntAnular = false;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewCompDis_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCompDis.GetRow(e.RowHandle) as vwct_cbtecble_con_saldo_cxp_Info;
                if (data == null)
                    return;
                if (data.Check == true)
                    e.Appearance.BackColor = Color.LightSteelBlue;
                else
                    e.Appearance.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAnticipo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (consultanueva == 0)
                {
                    if (rbAnticipo.Checked == true)
                    {

                        if (BinList_Anticipo_Diarios.Count > 0 && BinList_Anticipo_Diarios != null)
                        {
                            if (MessageBox.Show("Está seguro de cambiar de tipo\nse borraran los datos seleccionados", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                            {
                                rbAnticipo.Checked = true;

                                rbDiarioContable.Checked = false;
                                rb_NotaCred.Checked = false;
                                radio = "ANTPROV";
                                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;
                                load();
                            }
                        }
                        else
                        {
                            rbAnticipo.Checked = true;

                            rbDiarioContable.Checked = false;
                            rb_NotaCred.Checked = false;

                            radio = "ANTPROV";
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

        private void rbDiarioContable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (consultanueva == 0)
                {
                    if (rbDiarioContable.Checked == true)
                    {
                        UC_Diario.LimpiarGrid();

                        if (BinList_Anticipo_Diarios.Count > 0 && BinList_Anticipo_Diarios != null)
                        {
                            if (MessageBox.Show("Está seguro de cambiar de tipo\nse borraran los datos seleccionados", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                            {
                                rbDiarioContable.Checked = true;

                                rbAnticipo.Checked = false;
                                rb_NotaCred.Checked = false;
                                radio = "DIARIO";
                                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;

                            }
                        }
                        else
                        {
                            rbDiarioContable.Checked = true;

                            rbAnticipo.Checked = false;
                            rb_NotaCred.Checked = false;
                            radio = "DIARIO";
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbtecbleInfo = new vwct_cbtecble_con_saldo_cxp_Info();
                cbtecbleInfo = (vwct_cbtecble_con_saldo_cxp_Info)gridViewCompDis.GetFocusedRow();

                foreach (var item2 in BinList_Anticipo_Diarios)
                {
                    if (item2.Check == true)
                    {
                        item2.Valor_cancelado_cbte = Convert.ToDouble(item2.valor_Saldo_cbte);
                        break;
                    }
                }
                gridControlCompDis.DataSource = null;
                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;
                gridControlCompDis.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GeneraDiario()
        {
            try
            {
                List<ct_Cbtecble_det_Info> ListDetalle = new List<ct_Cbtecble_det_Info>();

                // DEBE

                sumaDiario = 0;
                foreach (var item in this.BinList_OPxCancelacion)
                {
                    if (item.Check == true)
                    {
                        ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                        Debe.IdEmpresa = param.IdEmpresa;
                        Debe.IdCtaCble = item.IdCtaCble;
                        Debe.dc_Valor = item.Valor_aplicado;
                        Debe.dc_Observacion = "Conciliación cxp a: " + item.Nom_Beneficiario + " Ref:: " + item.Referencia + "";

                        sumaDiario = sumaDiario + item.Valor_aplicado;

                        ListDetalle.Add(Debe);
                    }
                }

                //HABER
                foreach (var item in BinList_Anticipo_Diarios)
                {
                    if (item.Check == true)
                    {
                        ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                        Haber.IdEmpresa = param.IdEmpresa;
                        Haber.IdCtaCble = item.IdCtaCble_Anticipo;
                        Haber.dc_Valor = sumaDiario > 0 ? sumaDiario * -1 : 0;
                        Haber.dc_Observacion = "Conciliación por " + item.tipo + " y Referencia: " + item.referencia + "";

                        ListDetalle.Add(Haber);
                    }
                }

                UC_Diario.setDetalle(ListDetalle);
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

                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.CodCbteCble = "";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;

                CbteCble_I.cb_Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                CbteCble_I.cb_Valor = UC_Diario.Get_ValorCbteCble();
                CbteCble_I.cb_Observacion = txtObservacion.Text.Trim();
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";

                CbteCble_I.Anio = Convert.ToDateTime(dtpFecha.EditValue).Year;

                CbteCble_I.Mes = Convert.ToDateTime(dtpFecha.EditValue).Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = (txtIdConciliacion.EditValue == "") ? 0 : Convert.ToDecimal(txtIdConciliacion.EditValue);

                get_CbteCble_det();

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
            try
            {
                var detalle = UC_Diario.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in detalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = (txtIdConciliacion.EditValue == "") ? 0 : Convert.ToDecimal(txtIdConciliacion.EditValue);
                    dte.IdTipoCbte = _IdTipoCbte;

                    dte.secuencia = i++;
                }
                CbteCble_I._cbteCble_det_lista_info = detalle;

                return detalle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            try
            {
                // GeneraDiario();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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


                if (CCScxpInfo.Check == false)
                {
                    MessageBox.Show("Escoja un comprobante", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (e.Column.Name == "colCheck_can")
                {
                    if ((bool)gridView_OPxCancelar.GetFocusedRowCellValue(colCheck_can))
                    {

                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_can, false);
                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, false);

                        foreach (var item2 in BinList_OPxCancelacion)
                        {
                            if (item2.Check_aux == false)
                            {
                                if (item2.Saldo_x_Pagar_OP == 0)
                                {
                                    item2.Saldo_x_Pagar_OP = item2.Valor_aplicado;
                                    item2.Valor_aplicado = 0;

                                }
                                else
                                {
                                    item2.Saldo_x_Pagar_OP = item2.Saldo_x_Pagar_OP + item2.Valor_aplicado;
                                    item2.Valor_aplicado = 0;

                                }

                            }
                        }

                        suma = 0;
                        foreach (var item2 in BinList_OPxCancelacion)
                        {
                            if (item2.Check == true)
                            {
                                suma = suma + item2.Valor_aplicado;
                            }
                        }

                        CCScxpInfo.Valor_cancelado_cbte = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte) - suma;

                        gridControlCompDis.RefreshDataSource();

                        gridControl_OPxCancelar.RefreshDataSource();

                    }
                    else
                    {
                        if (CCScxpInfo.Valor_cancelado_cbte == 0)
                        {
                            MessageBox.Show("No hay saldo para Asignar", "Sistemas");
                            return;
                        }

                        if (IdBeneficiario != null)
                        {
                            if (IdBeneficiario != 0)
                            {

                                decimal s = Convert.ToDecimal(gridView_OPxCancelar.GetFocusedRowCellValue(colIdEntidad_can));
                                if (IdBeneficiario != info_OPxCance.IdPersona)
                                {
                                    MessageBox.Show("Debe Seleccionar el mismo Proveedor", "Sistemas");
                                    return;
                                }
                            }


                        }


                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_can, true);
                        gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, true);


                        if (info_OPxCance.Saldo_x_Pagar_OP <= CCScxpInfo.Valor_cancelado_cbte)
                        {
                            info_OPxCance.Valor_aplicado = info_OPxCance.Saldo_x_Pagar_OP;
                            info_OPxCance.Saldo_x_Pagar_OP = 0;
                        }
                        else
                        {
                            info_OPxCance.Valor_aplicado = CCScxpInfo.Valor_cancelado_cbte;
                            info_OPxCance.Saldo_x_Pagar_OP = info_OPxCance.Saldo_x_Pagar_OP - CCScxpInfo.Valor_cancelado_cbte;
                        }

                        suma = 0;

                        foreach (var item in BinList_OPxCancelacion)
                        {
                            if (item.Check == true)
                            {
                                suma = suma + item.Valor_aplicado;
                            }
                        }

                        if (suma <= CCScxpInfo.Valor_cancelado_cbte)
                        {
                            CCScxpInfo.Valor_cancelado_cbte = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte);
                            CCScxpInfo.Valor_cancelado_cbte = CCScxpInfo.Valor_cancelado_cbte - suma;
                        }


                        suma = 0;

                        foreach (var item in BinList_OPxCancelacion)
                        {
                            if (item.Check == true)
                            {

                                suma = suma + item.Valor_aplicado;
                            }
                        }

                        CCScxpInfo.Valor_cancelado_cbte = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte) - suma;

                        gridControlCompDis.RefreshDataSource();


                        gridControl_OPxCancelar.RefreshDataSource();
                    }
                }

                //  GeneraDiario();
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

                if (CCScxpInfo.Check == false)
                {
                    MessageBox.Show("Escoja un comprobante", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    info_OPxCance.Valor_aplicado = 0;
                    return;
                }

                if (e.Column.Name == "colValor_aplicado_can")
                {

                    if (IdBeneficiario != null)
                    {
                        if (IdBeneficiario != 0)
                        {
                            if (IdBeneficiario != Convert.ToDecimal(gridView_OPxCancelar.GetFocusedRowCellValue(colIdEntidad_can)))
                            {
                                MessageBox.Show("Debe Seleccionar el mismo Proveedor", "Sistemas");

                                info_OPxCance.Valor_aplicado = 0;
                                return;
                            }

                        }

                    }


                    if (Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_aplicado_can)) > Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_estimado_a_pagar_OP_can)))
                    {
                        gridView_OPxCancelar.SetFocusedRowCellValue(colValor_aplicado_can, 0);
                        return;
                    }
                    else
                    {
                        if (Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_aplicado_can)) == 0)
                        {
                            gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_can, false);
                            gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, false);
                            gridView_OPxCancelar.SetFocusedRowCellValue(colSaldo_x_Pagar_OP_can, info_OPxCance.Saldo_x_Pagar2);

                        }


                        if (Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_aplicado_can)) != 0)
                        {
                            gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, true);
                        }

                        if (Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_aplicado_can)) > CCScxpInfo.Valor_cancelado_cbte)
                        {
                            gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_can, false);
                            gridView_OPxCancelar.SetFocusedRowCellValue(colCheck_aux, false);
                            gridView_OPxCancelar.SetFocusedRowCellValue(colValor_aplicado_can, 0);
                        }


                        double val = 0;
                        double sal = 0;
                        double tot = 0;

                        val = Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_aplicado_can));
                        sal = Convert.ToDouble(gridView_OPxCancelar.GetFocusedRowCellValue(colValor_estimado_a_pagar_OP_can));
                        tot = sal - val;

                        gridView_OPxCancelar.SetFocusedRowCellValue(colSaldo_x_Pagar_OP_can, tot);


                        suma = 0;

                        foreach (var item in BinList_OPxCancelacion)
                        {
                            if (item.Check_aux == true)
                            {
                                item.Check = true;

                                suma = suma + item.Valor_aplicado;

                            }
                        }

                        if (suma <= CCScxpInfo.Valor_cancelado_cbte)
                        {
                            CCScxpInfo.Valor_cancelado_cbte = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte);

                            CCScxpInfo.Valor_cancelado_cbte = CCScxpInfo.Valor_cancelado_cbte - suma;
                        }


                        suma = 0;

                        foreach (var item in BinList_OPxCancelacion)
                        {
                            if (item.Check == true)
                            {

                                suma = suma + item.Valor_aplicado;
                            }
                        }

                        CCScxpInfo.Valor_cancelado_cbte = Convert.ToDouble(CCScxpInfo.valor_Saldo_cbte) - suma;

                        gridControlCompDis.RefreshDataSource();

                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_NotaCred_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (consultanueva == 0)
                {

                    if (rb_NotaCred.Checked == true)
                    {

                        if (BinList_Anticipo_Diarios.Count > 0 && BinList_Anticipo_Diarios != null)
                        {
                            if (MessageBox.Show("Está seguro de cambiar de tipo\nse borraran los datos seleccionados", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                            {
                                rb_NotaCred.Checked = true;


                                rbAnticipo.Checked = false;
                                rbDiarioContable.Checked = false;
                                radio = "NOTA-CRED";
                                BinList_Anticipo_Diarios = new BindingList<vwct_cbtecble_con_saldo_cxp_Info>();
                                gridControlCompDis.DataSource = BinList_Anticipo_Diarios;
                                //load();
                            }
                        }
                        else
                        {
                            rb_NotaCred.Checked = true;

                            rbAnticipo.Checked = false;
                            rbDiarioContable.Checked = false;
                            radio = "NOTA-CRED";
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
                ucGe_Menu.Visible_bntAnular = false;
                lblAnular.Visible = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Grabar();
                }
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
                if (Validar())
                {
                    if (Grabar())
                        Close();
                }
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

        private void gridControlCompDis_Click(object sender, EventArgs e)
        {

        }

        private void lnkAprobar_fac_nd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmCP_Aprobacion_Facturas_x_Pagar frmApro = new frmCP_Aprobacion_Facturas_x_Pagar();
                frmApro.StringBusqueda = StringBusqueda;
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
                Cargar_Grids();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirAnticipos_Click(object sender, EventArgs e)
        {
            try
            {
                gridControlCompDis.ShowPrintPreview();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
