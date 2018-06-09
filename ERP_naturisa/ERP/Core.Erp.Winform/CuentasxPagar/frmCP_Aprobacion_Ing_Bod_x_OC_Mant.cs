using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Ing_Bod_x_OC_Mant : Form
    {
        #region Variables
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_Aprobacion_Ing_Bod_x_OC_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
        
        List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();

        BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
        //BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstBind_Agrupado = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();

        cp_Aprobacion_Ing_Bod_x_OC_Info Info;
        cp_Aprobacion_Ing_Bod_x_OC_det_Info InfoDet = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();

        Cl_Enumeradores.eTipo_action Accion;
        public cp_Aprobacion_Ing_Bod_x_OC_Info _SetInfo { get; set; }
        List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lista;
        List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();


        List<ct_centro_costo_sub_centro_costo_Info> listaSubcentero = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();

        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();


        int RowHandle = 0;
        FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant frm_param = new FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant();

        public delegate void delegate_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;
        double SumDescuento = 0;
        double SumValorIva = 0;
        double SumSubtotal = 0;
        double SumTotal = 0;
        double SumSubtotal0 = 0;
        double SumSubtotaliva = 0;

        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();
        cp_parametros_Bus bus_cpParam = new cp_parametros_Bus();
        cp_parametros_Info info_cpParam;

        string proveedor = "";

        #endregion

        public frmCP_Aprobacion_Ing_Bod_x_OC_Mant()
        {
            InitializeComponent();


            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;

            event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing += frmCP_Aprobacion_Ing_Bod_x_OC_Mant_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;

            ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged;
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar_Ingresos();
                if (String.IsNullOrEmpty(ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_Gasto))
                {
                    info_cpParam = new cp_parametros_Info();
                    info_cpParam = bus_cpParam.Get_Info_parametros(param.IdEmpresa);                   
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
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

                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar())
                    { Close(); }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (grabar()) { }
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void cargar_combos()
        {
            try
            {
                // carga proveedor    
                string MensajeError = "";
                cp_proveedor_Bus bus_Provee = new cp_proveedor_Bus();
                List<cp_proveedor_Info> list_Provee = new List<cp_proveedor_Info>();
                list_Provee = bus_Provee.Get_List_proveedor(param.IdEmpresa);
                foreach (var item in list_Provee)
                {
                    item.pr_nombre = "[" + item.IdProveedor + "]" + item.pr_nombre;
                }

                // carga combo Sustento Tributario
                cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
                List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa).FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO");

                cmbSustTrib.Properties.DataSource = ListCodigoSRI;
                cmbSustTrib.Properties.DisplayMember = "descriConcate";
                cmbSustTrib.Properties.ValueMember = "IdCodigo_SRI";

                // carga combo Tipo Documento
                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04" && c.CodSRI != "05");
                LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);
                cmbTipoDocu.Properties.DataSource = LstTipDoc;
                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

                listPlanCta = new List<ct_Plancta_Info>();
                listPlanCta = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmbCtaCtble_Gasto_x_cxp.DataSource = listPlanCta;



                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                CmbPuntoCargo.DataSource = listPuntoCargo;



                list_centroCosto = new List<ct_Centro_costo_Info>();
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centroCosoto.DataSource = list_centroCosto;


                listaSubcentero = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmbSubcentro.DataSource = listaSubcentero;


                

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_Load(object sender, EventArgs e)
        {
            try
            {


                txtSerie.Properties.MaxLength = 3;
                txtSerie2.Properties.MaxLength = 3;

                dtpFecFactura.EditValue = DateTime.Now;
                dtp_fecha_contabilizacion.EditValue = DateTime.Now;
                dtpFecAproba.EditValue = DateTime.Now;

                switch (param.IdCliente_Ven_x_Default)
                {                    
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        de_FechaVctoAuto.Visible = true;
                        lblFechaVctoAuto.Visible = true;
                        col_relacion_centro_cuenta.Visible = true;
                        break;  
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        Col_PuntoCargoFJ.Visible = true;
                        Col_CentroCosto.Visible = true;
                        ColIdSubcentroCosoto.Visible = true;
                        break;
                    default:
                        col_relacion_centro_cuenta.Visible = false;
                        Col_PuntoCargoFJ.Visible = false;
                        Col_CentroCosto.Visible = false;
                        ColIdSubcentroCosoto.Visible = false;
                        break;
                }

                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        info_cpParam = new cp_parametros_Info();
                        info_cpParam = bus_cpParam.Get_Info_parametros(param.IdEmpresa);

                        if (!String.IsNullOrEmpty(info_cpParam.pa_ctacble_deudora))
                        {
                            //cmb_ctaIva.set_PlanCtarInfo(info_cpParam.pa_ctacble_iva);
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        SetInfo();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        SetInfo();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void getInfo()
        {
            try
            {
                Info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdAprobacion = Convert.ToDecimal((txtIdAprobacion.EditValue == "") ? 0 : Convert.ToDecimal(txtIdAprobacion.EditValue));
                Info.Fecha_Factura = Convert.ToDateTime(dtpFecFactura.EditValue);
                Info.Fecha_aprobacion = Convert.ToDateTime(dtpFecAproba.EditValue);
                Info.co_FechaContabilizacion = Convert.ToDateTime(Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue).ToShortDateString());
                Info.Fecha_vcto = Convert.ToDateTime(dtpFecVtc.EditValue);
                Info.co_plazo = Convert.ToInt32(txt_plazo.Text);



                Info.IdOrden_giro_Tipo = Convert.ToString(cmbTipoDocu.EditValue).Trim();
                Info.IdIden_credito = Convert.ToInt32(cmbSustTrib.EditValue);
                Info.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                Info.Observacion = Convert.ToString(txtObservacion.EditValue).Trim() + "FP:#" + txtSerie.Text + "-" +txtSerie2.Text+ "-" + txtNumDocu.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre; 
                Info.Serie = Convert.ToString(txtSerie.EditValue).Trim();
                Info.Serie2 = Convert.ToString(txtSerie2.EditValue).Trim();
                Info.num_documento = Convert.ToString(txtNumDocu.EditValue).Trim();
                Info.num_auto_Proveedor = Convert.ToString(txtNumAutProve.EditValue).Trim();
                Info.num_auto_Imprenta = "";
                Info.co_subtotal_iva = Math.Round((txtSubtotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotalIva.EditValue)), 2);
                Info.co_subtotal_siniva = Math.Round((txtSubtotal0.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal0.EditValue)), 2);
                Info.Descuento = Math.Round((txtTotDescuento.EditValue == "" ? 0 : Convert.ToDouble(txtTotDescuento.EditValue)), 2);
                Info.co_baseImponible = Math.Round((txtSubtotal.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal.EditValue)), 2);
                double por_iva = param.iva.porcentaje;
                if(lstBind.Where(q => q.Checked == true).Count() != 0)
                    por_iva = lstBind.Where(q => q.Checked == true).ToList().Max(q => q.PorIva);
                Info.co_Por_iva = por_iva;

                

                Info.co_valoriva = Math.Round((txtTotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtTotalIva.EditValue)), 2);
                Info.co_total = Math.Round((txtTotal.EditValue == "" ? 0 : Convert.ToDouble(txtTotal.EditValue)), 2);
                Info.IdCtaCble_CXP = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                Info.pa_ctacble_iva = info_cpParam.pa_ctacble_iva;
                Info.IdCentroCosoto_CXP = ucCp_Proveedor1.get_ProveedorInfo().IdCentroCosoto;


              
                Info.listDetalle = lstBind.Where(v => v.Checked == true).ToList();

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        Info.co_FechaVctoAutorizacion = de_FechaVctoAuto.EditValue == null ? DateTime.Now : Convert.ToDateTime(de_FechaVctoAuto.EditValue);
                        break;
                    default:
                        Info.co_FechaVctoAutorizacion = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetInfo()
        {
            try
            {
                Info = _SetInfo;

                txtIdAprobacion.EditValue = Convert.ToString(_SetInfo.IdAprobacion);
                ucCp_Proveedor1.set_ProveedorInfo(_SetInfo.IdProveedor);
                cmbTipoDocu.EditValue = _SetInfo.IdOrden_giro_Tipo;
                cmbSustTrib.EditValue = _SetInfo.IdIden_credito;
                txtObservacion.EditValue = _SetInfo.Observacion;
                dtpFecAproba.EditValue = _SetInfo.Fecha_aprobacion;
                dtpFecFactura.EditValue = _SetInfo.Fecha_Factura;
                dtp_fecha_contabilizacion.EditValue = _SetInfo.co_FechaContabilizacion;
                txtSerie.EditValue = _SetInfo.Serie;
                txtSerie2.EditValue = _SetInfo.Serie2;
                txtNumDocu.EditValue = _SetInfo.num_documento;
                txtNumAutProve.EditValue = _SetInfo.num_auto_Proveedor;
                txtSubtotalIva.EditValue = Convert.ToString(_SetInfo.co_subtotal_iva);
                txtSubtotal0.EditValue = Convert.ToString(_SetInfo.co_subtotal_siniva);
                txtTotDescuento.EditValue = Convert.ToString(_SetInfo.Descuento);
                txtSubtotal.EditValue = Convert.ToString(_SetInfo.co_baseImponible);
                txtTotalIva.EditValue = Convert.ToString(_SetInfo.co_valoriva);
                txtTotal.EditValue = Convert.ToString(_SetInfo.co_total);

                de_FechaVctoAuto.EditValue = _SetInfo.co_FechaVctoAutorizacion;
                // consulta detalle
                cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lista = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                lista = Bus.Get_List_Aprobacion_Ing_Bod_x_OC_det(_SetInfo.IdEmpresa, _SetInfo.IdAprobacion);
              
                gridControlAproIngEgrxOC.DataSource = lista;
                
                colFecha_Ing_Bod.Visible = false;
                colnom_bodega.Visible = false;
                colChecked.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean Validar()
        {
            try
            {
                txtObservacion.Focus();
                Boolean res = true;

                string mensaje = "";

                if (ucCp_Proveedor1.get_ProveedorInfo()==null)
                {
                    MessageBox.Show("Seleccione un proveedor", param.Nombre_sistema);
                    return false;
                }

                if (!string.IsNullOrEmpty(Convert.ToString(txtSerie.EditValue)) && !String.IsNullOrEmpty(Convert.ToString(txtSerie2.EditValue)) && !String.IsNullOrEmpty(Convert.ToString(txtNumDocu.EditValue)))
                {
                    Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                    if (Bus_Aprob.VerificarNumDocumento(param.IdEmpresa, Convert.ToString(txtSerie.EditValue), Convert.ToString(txtSerie2.EditValue), Convert.ToString(txtNumDocu.EditValue),ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, ref mensaje))
                    {
                        MessageBox.Show("El número de Documento : " + mensaje + " ya se encuentra registrado"+ " Para este proveedor verifique..", param.Nombre_sistema);
                        return false;
                    }
                }

                bool Item_mes_anterior = false;
                foreach (var item in lstBind)
                {
                    if (item.Checked == true)
                    {
                        if (item.IdCtaCble_Gasto == null || item.IdCtaCble_Gasto == "")
                        {
                            MessageBox.Show("Ingrese la Cta Cble del Gasto para el Producto" + item.nom_producto, param.Nombre_sistema);
                            return false;
                        }
                        if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(item.Fecha_Ing_Bod)))
                            {
                                Item_mes_anterior = true;
                            }
                    }
                }
                if (Item_mes_anterior)
                {
                    if (MessageBox.Show("Ha escogido movimientos de un periodo cerrado, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;
                }

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        DateTime fecha_vcto_auto = Convert.ToDateTime(de_FechaVctoAuto.EditValue).Date;
                        DateTime fecha_factura = Convert.ToDateTime(dtpFecFactura.EditValue).Date;
                        if (fecha_vcto_auto < fecha_factura)
                        {
                            MessageBox.Show("El documento es de una fecha mayor a la fecha de autorización", param.Nombre_sistema);
                            return false;
                        }
                        break;                 
                }



                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtpFecAproba.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue)))
                    return false;

                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean grabar()
        {
            try
            {
                txtIdAprobacion.Focus();
                getInfo();
                string mensaje = "";
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        Boolean resultB;
                        resultB = true;

                        decimal IdIdAprobacion = 0;
                        Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();

                        if (Bus_Aprob.GuardarDB(Info, ref   IdIdAprobacion, ref mensaje))
                        {
                            txtIdAprobacion.Text = Convert.ToString(IdIdAprobacion);

                            if (Info.IdCbteCble_Ogiro != 0)
                            {
                                if (Info.IdCbteCble_Ogiro != null)
                                {
                                    MessageBox.Show("Se ha procedido a grabar el registro de Aprobación #: " + IdIdAprobacion.ToString() + ", con Factura Proveedor #: " + Info.IdCbteCble_Ogiro + " exitosamente.", "Operación Exitosa");
                                }
                                else
                                {
                                    MessageBox.Show(mensaje);
                                }
                            }
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el registro der Aprobación, " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    default:
                        break;
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

        private void Anular()
        {
            try
            {
                if (Info != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " /la Aprobación de ingreso a bodega N°: " + Info.IdAprobacion + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string msg = "";
                        string MotivoAnula = "";
                        oFrm.ShowDialog();
                        MotivoAnula = oFrm.motivoAnulacion;

                        if (Bus_Aprob.EliminarDB(Info.IdEmpresa, Info.IdAprobacion, param.IdUsuario, MotivoAnula, ref msg))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la aprobacion por ingreso a bodega " + Info.IdAprobacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        dtpFecAproba.EditValue = DateTime.Now;
                        dtpFecFactura.EditValue = DateTime.Now;

                        ucGe_Menu.Enabled_bntAnular = false;

                        txtIdAprobacion.Enabled = false;
                        txtIdAprobacion.BackColor = System.Drawing.Color.White;
                        txtIdAprobacion.ForeColor = System.Drawing.Color.Black;

                        txtTotDescuento.Enabled = false;
                        txtTotDescuento.BackColor = System.Drawing.Color.White;
                        txtTotDescuento.ForeColor = System.Drawing.Color.Black;

                        txtTotalIva.Enabled = false;
                        txtTotalIva.BackColor = System.Drawing.Color.White;
                        txtTotalIva.ForeColor = System.Drawing.Color.Black;

                        txtSubtotal.Enabled = false;
                        txtSubtotal.BackColor = System.Drawing.Color.White;
                        txtSubtotal.ForeColor = System.Drawing.Color.Black;

                        txtTotal.Enabled = false;
                        txtTotal.BackColor = System.Drawing.Color.White;
                        txtTotal.ForeColor = System.Drawing.Color.Black;

                        txtSubtotal0.Enabled = false;
                        txtSubtotal0.BackColor = System.Drawing.Color.White;
                        txtSubtotal0.ForeColor = System.Drawing.Color.Black;

                        txtSubtotalIva.Enabled = false;
                        txtSubtotalIva.BackColor = System.Drawing.Color.White;
                        txtSubtotalIva.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntAnular = false;

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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

        void Inhabilita_Controles()
        {
            try
            {
                ucGe_Menu.Enabled_bntAnular = false;

                txtIdAprobacion.Enabled = false;
                txtIdAprobacion.BackColor = System.Drawing.Color.White;
                txtIdAprobacion.ForeColor = System.Drawing.Color.Black;

                txtSerie.Enabled = false;
                txtSerie.BackColor = System.Drawing.Color.White;
                txtSerie.ForeColor = System.Drawing.Color.Black;

                txtSerie2.Enabled = false;
                txtSerie2.BackColor = System.Drawing.Color.White;
                txtSerie2.ForeColor = System.Drawing.Color.Black;

                ucCp_Proveedor1.Enabled = false;
                ucCp_Proveedor1.BackColor = System.Drawing.Color.White;
                ucCp_Proveedor1.ForeColor = System.Drawing.Color.Black;

                cmbTipoDocu.Enabled = false;
                cmbTipoDocu.BackColor = System.Drawing.Color.White;
                cmbTipoDocu.ForeColor = System.Drawing.Color.Black;

                cmbSustTrib.Enabled = false;
                cmbSustTrib.BackColor = System.Drawing.Color.White;
                cmbSustTrib.ForeColor = System.Drawing.Color.Black;

                txtObservacion.Enabled = false;
                txtObservacion.BackColor = System.Drawing.Color.White;
                txtObservacion.ForeColor = System.Drawing.Color.Black;

                txtNumDocu.Enabled = false;
                txtNumDocu.BackColor = System.Drawing.Color.White;
                txtNumDocu.ForeColor = System.Drawing.Color.Black;

                txtNumAutProve.Enabled = false;
                txtNumAutProve.BackColor = System.Drawing.Color.White;
                txtNumAutProve.ForeColor = System.Drawing.Color.Black;



                dtpFecAproba.Enabled = false;
                dtpFecAproba.BackColor = System.Drawing.Color.White;
                dtpFecAproba.ForeColor = System.Drawing.Color.Black;

                dtpFecFactura.Enabled = false;
                dtpFecFactura.BackColor = System.Drawing.Color.White;
                dtpFecFactura.ForeColor = System.Drawing.Color.Black;

                txtTotDescuento.Enabled = false;
                txtTotDescuento.BackColor = System.Drawing.Color.White;
                txtTotDescuento.ForeColor = System.Drawing.Color.Black;

                txtTotalIva.Enabled = false;
                txtTotalIva.BackColor = System.Drawing.Color.White;
                txtTotalIva.ForeColor = System.Drawing.Color.Black;

                txtSubtotal.Enabled = false;
                txtSubtotal.BackColor = System.Drawing.Color.White;
                txtSubtotal.ForeColor = System.Drawing.Color.Black;

                txtTotal.Enabled = false;
                txtTotal.BackColor = System.Drawing.Color.White;
                txtTotal.ForeColor = System.Drawing.Color.Black;

                txtSubtotal0.Enabled = false;
                txtSubtotal0.BackColor = System.Drawing.Color.White;
                txtSubtotal0.ForeColor = System.Drawing.Color.Black;

                txtSubtotalIva.Enabled = false;
                txtSubtotalIva.BackColor = System.Drawing.Color.White;
                txtSubtotalIva.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarDatos()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                ucGe_Menu.Visible_btnGuardar = true;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;


                txtIdAprobacion.EditValue = "";
                txtSerie.EditValue = "";
                txtSerie2.EditValue = "";
                txtObservacion.EditValue = "";
                txtNumAutProve.EditValue = "";
                txtNumDocu.EditValue = "";
                dtpFecFactura.EditValue = DateTime.Now;
                dtpFecAproba.EditValue = DateTime.Now;
                dtp_fecha_contabilizacion.EditValue = DateTime.Now;
                cmbTipoDocu.EditValue = null;
                cmbSustTrib.EditValue = null;
                txtSubtotal0.EditValue = "";
                txtSubtotalIva.EditValue = "";
                txtTotDescuento.EditValue = "";
                txtSubtotal.EditValue = "";
                txtTotalIva.EditValue = "";
                txtTotal.EditValue = "";

                lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                gridControlAproIngEgrxOC.DataSource = lstBind;
                Buscar_Ingresos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void buscar()
        {
            try
            {
                cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();

                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> list_Aprob = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                list_Aprob = Bus_Aprob.Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione el Proveedor");
                    return;
                }

                if (list_Aprob.Count == 0)
                {
                    MessageBox.Show("No existen Datos de Consulta para el Proveedor: " + ucCp_Proveedor1.get_ProveedorInfo().IdProveedor + "");
                    return;
                }

                foreach (var item in list_Aprob)
                {
                    //calculos

                    if (item.IdOrdenCompra == 98)
                    {
                    }
                    if (item.do_porc_des != 0)
                    {
                        item.do_porc_des = item.do_porc_des;
                        item.SubTotal = (item.Cantidad * item.Costo_uni);// -((item.do_porc_des * (item.Cantidad * item.Costo_uni)) / 100);// -item.Descuento;
                    }
                    else
                    {
                        item.SubTotal = (item.Cantidad * item.Costo_uni);

                    }

                    if (item.PorIva > 0)
                    {
                        item.PorIva = item.PorIva;
                        item.valor_Iva = item.SubTotal * (item.PorIva / 100);
                        item.subtotaliva = item.SubTotal;
                    }
                    else
                    {
                        item.PorIva = item.PorIva;
                        item.valor_Iva = 0;
                        item.subtotal0 = item.SubTotal;
                    }

                   
                    item.Total = item.SubTotal + item.valor_Iva;
                }

                lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(list_Aprob);
              
                gridControlAproIngEgrxOC.DataSource = lstBind;
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAproIngEgrxOC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }
                if (e.HitInfo.Column != null)
                {
                    e.HitInfo.Column.FieldName = gridViewAproIngEgrxOC.FocusedColumn.FieldName;

                    if (e.HitInfo.Column.FieldName == "Checked")
                    {
                        if ((Boolean)gridViewAproIngEgrxOC.GetFocusedRowCellValue(colChecked))
                        {

                            gridViewAproIngEgrxOC.SetFocusedRowCellValue(colChecked, false);
                        }
                        else
                        {
                            gridViewAproIngEgrxOC.SetFocusedRowCellValue(colChecked, true);
                        }
                    }

                    calculos(lstBind);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void calculos(BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> ListaBind)
        {
            try
            {
                SumDescuento = 0;
                SumValorIva = 0;
                SumTotal = 0;
                SumSubtotal = 0;
                SumSubtotal0 = 0;
                SumSubtotaliva = 0;

                int dias_plazo = 0;
                dias_plazo = ucCp_Proveedor1.get_ProveedorInfo() == null ? 0 : Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().pr_plazo);

                foreach (var item in ListaBind)
                {
                    if (item.Checked == true)
                    {
                        SumDescuento = SumDescuento + item.Descuento;
                        SumValorIva = SumValorIva + item.valor_Iva;
                        SumTotal = SumTotal + item.Total;
                        SumSubtotal = SumSubtotal + item.SubTotal;
                        SumSubtotal0 = SumSubtotal0 + item.subtotal0;
                        SumSubtotaliva = SumSubtotaliva + item.subtotaliva;

                        if (item.Dias > dias_plazo) dias_plazo = item.Dias;
                    }
                }

                txtTotDescuento.EditValue = Convert.ToString(SumDescuento);
                txtTotalIva.EditValue = Convert.ToString(SumValorIva);
                txtSubtotal.EditValue = Convert.ToString(SumSubtotal);
                txtTotal.EditValue = Convert.ToString(SumTotal);
                txtSubtotal0.EditValue = Convert.ToString(SumSubtotal0);
                txtSubtotalIva.EditValue = Convert.ToString(SumSubtotaliva);
                txt_plazo.Text = dias_plazo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSustTrib_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }

                if (cmbSustTrib.EditValue == null)
                {
                    return;
                }

                cp_proveedor_Info _p = ucCp_Proveedor1.get_ProveedorInfo();

                this.cmbTipoDocu.EditValue = null;
                if (_p != null)
                {
                    if (_p.Persona_Info.IdTipoDocumento != null)
                    {
                        cp_codigo_SRI_Info info_codSri = new cp_codigo_SRI_Info();
                        var a = (List<cp_codigo_SRI_Info>)cmbSustTrib.Properties.DataSource;
                        info_codSri = a.First(q => q.IdCodigo_SRI == Convert.ToDecimal(cmbSustTrib.EditValue));

                        List<cp_TipoDocumento_Info> lst = new List<cp_TipoDocumento_Info>();

                        if (info_codSri != null)
                            if (info_codSri.codigoSRI != null)
                                foreach (var item in LstTipDoc)
                                {
                                    if (item.Sustento_Tributario != null)
                                    {
                                        if (item.CodSRI == "06")
                                        {
                                        }
                                        //Separa sustento por documento
                                        string[] arreglo = item.Sustento_Tributario.Split(',');
                                        //Recorre los sustentos del documento
                                        for (int i = 0; i < arreglo.Length; i++)
                                        {
                                            arreglo[i] = arreglo[i].Trim();

                                            if (arreglo[i] == info_codSri.codigoSRI)
                                            { //Datos SRI cod_secuencia (01 compra ruc)(02 compra cedula)(03 compra pasaporte)

                                                string secuencial = "";
                                                if (_p.Persona_Info.IdTipoDocumento.Trim() == "RUC")
                                                    secuencial = "01";
                                                else if (_p.Persona_Info.IdTipoDocumento.Trim() == "CED")
                                                    secuencial = "02";
                                                else
                                                    secuencial = "03";

                                                string[] arregloSecuenci = item.Codigo_Secuenciales_Transaccion.Split(',');
                                                for (int ise = 0; ise < arregloSecuenci.Length; ise++)
                                                {
                                                    arregloSecuenci[ise] = arregloSecuenci[ise].Trim();
                                                    if (arregloSecuenci[ise] == secuencial)
                                                    {
                                                        lst.Add(item);
                                                        ise = arregloSecuenci.Length;
                                                        i = arreglo.Length;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                        cmbTipoDocu.Properties.DataSource = lst;
                    }
                    else
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSustTrib.EditValue = null;
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumDocu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";

                string valor_secu = "";
                valor_secu = Convert.ToString(txtNumDocu.EditValue);

                if (!String.IsNullOrEmpty(valor_secu))
                {
                    if (valor_secu.Length < 9)
                    {
                        int conta = valor_secu.Length;
                        int diferencia = 9 - conta;

                        secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                        secuencia = secuencia_aux + valor_secu;

                        txtNumDocu.EditValue = secuencia;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_plazo.Text != "")
                {
                    int plazo = 0;
                    DateTime fechaFact = Convert.ToDateTime(dtpFecFactura.EditValue);

                    plazo = Convert.ToInt32(txt_plazo.Text);
                    fechaFact = fechaFact.AddDays(plazo);

                    dtpFecVtc.EditValue = fechaFact;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridControlAproIngEgrxOC_Click(object sender, EventArgs e)
        {

        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewAproIngEgrxOC.RowCount; i++)
                {
                    gridViewAproIngEgrxOC.SetRowCellValue(i, colChecked, chk_seleccionar_visibles.Checked);
                }
                calculos(lstBind);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_Ingresos()
        {
            try
            {
                cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
                int plazo = 0;

                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                plazo = Convert.ToInt32(InfoProveedor.pr_plazo);

                txt_plazo.Text = plazo.ToString();
                dtpFecVtc.EditValue = dtpFecFactura.EditValue;
                dtpFecVtc.DateTime.AddDays(plazo);

                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarIngresos_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Ingresos();
            }
            catch (Exception ex)
            {

                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFecAproba_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_fecha_contabilizacion.EditValue = dtpFecAproba.EditValue;
                dtpFecFactura.EditValue = dtpFecAproba.EditValue;

                int dias_plazo = string.IsNullOrEmpty(txt_plazo.Text) ? 0 : Convert.ToInt32(txt_plazo.Text);
                dtpFecVtc.EditValue = Convert.ToDateTime(dtpFecAproba.EditValue).AddDays(dias_plazo);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_relacion_centro_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        cp_Aprobacion_Ing_Bod_x_OC_det_Info row = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
                        row = (cp_Aprobacion_Ing_Bod_x_OC_det_Info)gridViewAproIngEgrxOC.GetRow(RowHandle);
                        if (row != null)
                        {
                            if (row.es_Inven_o_Consumo == ein_Inventario_O_Consumo.TIC_CONSU)
                            {
                                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info_CConta = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                                info_CConta.IdEmpresa = param.IdEmpresa;
                                info_CConta.IdCategoria = row.IdCategoria;
                                info_CConta.IdLinea = row.IdLinea;
                                info_CConta.IdGrupo = row.IdGrupo;
                                info_CConta.IdSubgrupo = row.IdSubGrupo;
                                info_CConta.IdCentroCosto = row.IdCentro_Costo;
                                info_CConta.IdSub_centro_costo = row.IdCentroCosto_sub_centro_costo;
                                info_CConta.IdCtaCble = row.IdCtaCble_Gasto;

                                frm_param = new FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant();
                                frm_param.Set_info(info_CConta);
                                frm_param.ShowDialog();
                                info_CConta = frm_param.Get_info_param();
                                if (info_CConta != null)
                                {
                                    gridViewAproIngEgrxOC.SetRowCellValue(RowHandle, colIdCtaCtble_Gasto_x_cxp, info_CConta.IdCtaCble == "" ? null : info_CConta.IdCtaCble);
                                }
                                frm_param.Dispose();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void gridViewAproIngEgrxOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;




            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_relacion_centro_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        cp_Aprobacion_Ing_Bod_x_OC_det_Info row = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
                        row = (cp_Aprobacion_Ing_Bod_x_OC_det_Info)gridViewAproIngEgrxOC.GetRow(RowHandle);
                        if (row != null)
                        {
                            in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info_CConta = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                            info_CConta.IdEmpresa = param.IdEmpresa;
                            info_CConta.IdCategoria = row.IdCategoria;
                            info_CConta.IdLinea = row.IdLinea;
                            info_CConta.IdGrupo = row.IdGrupo;
                            info_CConta.IdSubgrupo = row.IdSubGrupo;
                            info_CConta.IdCentroCosto = row.IdCentro_Costo;
                            info_CConta.IdSub_centro_costo = row.IdCentroCosto_sub_centro_costo;
                            info_CConta.IdCtaCble = row.IdCtaCble_Gasto;

                            frm_param = new FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant();
                            frm_param.Set_info(info_CConta);
                            frm_param.ShowDialog();
                            info_CConta = frm_param.Get_info_param();
                            if (info_CConta != null)
                            {
                                gridViewAproIngEgrxOC.SetRowCellValue(RowHandle, colIdCtaCtble_Gasto_x_cxp, info_CConta.IdCtaCble == "" ? null : info_CConta.IdCtaCble);
                            }

                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAproIngEgrxOC_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            { if (e.Column == Col_PuntoCargoFJ)
                {
                    cp_Aprobacion_Ing_Bod_x_OC_det_Info fila_OC_det = (cp_Aprobacion_Ing_Bod_x_OC_det_Info)gridViewAproIngEgrxOC.GetFocusedRow();

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                            if (fila_OC_det.IdPunto_cargo != 0 && fila_OC_det.IdPunto_cargo != null)
                            {
                                ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
                                ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
                                info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, Convert.ToInt32(fila_OC_det.IdPunto_cargo));
                                fila_OC_det.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                                fila_OC_det.IdCentro_Costo = info_punto_cargo.IdCentroCosto_Scc;
                                fila_OC_det.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                            }
                            else
                            {
                                fila_OC_det.IdPunto_cargo_grupo = null;
                                fila_OC_det.IdCentro_Costo = null;
                                fila_OC_det.IdCentroCosto_sub_centro_costo = null;
                            }
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                
               Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
