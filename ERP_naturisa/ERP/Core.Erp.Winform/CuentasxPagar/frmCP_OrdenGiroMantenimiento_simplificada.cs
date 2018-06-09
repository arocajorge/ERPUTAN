using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_OrdenGiroMantenimiento_simplificada : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        bool bandera_armar_diario = false;
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
        List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
        List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
        cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
        cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();
        cp_orden_giro_Bus bus_OrdenGiro = new cp_orden_giro_Bus();
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        int _IdTipoCbte = 0;
        double subtotal_iva = 0;
        double subtotal_0 = 0;
        double base_imponible = 0;
        double valor_iva = 0;
        double valor_restar = 0;
        double total = 0;
        double porcentaje_iva = 0;
        string msg = "";

        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();

        public frmCP_OrdenGiroMantenimiento_simplificada()
        {
            InitializeComponent();
            
        }

        private void Cargar_combos()
        {
            try
            {
                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);
                _IdTipoCbte = paramCP_I.pa_TipoCbte_OG;

                txE_IVA.Text = Convert.ToString(param.iva.porcentaje);
                _IdTipoCbte = paramCP_I.pa_TipoCbte_OG;
                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa);

                cmb_idtCredito.Properties.DataSource = ListCodigoSRI.FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO").OrderBy(C => C.codigoSRI).ToList();
                cmb_idtCredito.Properties.DisplayMember = "descriConcate";
                cmb_idtCredito.Properties.ValueMember = "IdCodigo_SRI";

                LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04");//&& c.CodSRI != "05");
                LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);

                cmbTipoDocu.Properties.DataSource = LstTipDoc;
                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_OrdenGiroMantenimiento_simplificada_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_fechaOG.EditValue = DateTime.Now;
                if (_Accion == 0)
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }
                bandera_armar_diario = true;
                Cargar_combos();
                Set_accion_in_controls();
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
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, Convert.ToDateTime(dtp_fechaOG.EditValue).Date, ref msg);
                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.CodCbteCble = "";
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(dtp_fechaOG.EditValue).Date;
                CbteCble_I.cb_Valor = UC_Diario_x_cxp.Get_ValorCbteCble();
                CbteCble_I.cb_Observacion = txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = Convert.ToDateTime(dtp_fechaOG.EditValue).Date.Year;
                CbteCble_I.Mes = Convert.ToDateTime(dtp_fechaOG.EditValue).Date.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);

                return CbteCble_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }

        public void get_ordenGiro()
        {
            try
            {
                DateTime FechaAu;

                FechaAu = dtp_fechaOG.DateTime.Date;
                
                Info_OrdenGiro.IdTipoCbte_Ogiro = _IdTipoCbte;
                Info_OrdenGiro.co_baseImponible = Convert.ToDouble(txE_BaseImponible.EditValue);
                Info_OrdenGiro.co_BaseSeguro = 0;
                Info_OrdenGiro.co_factura = Convert.ToString(txeNumDocum.EditValue);
                Info_OrdenGiro.co_FechaFactura = Convert.ToDateTime(dtp_fechaOG.EditValue).Date;
                Info_OrdenGiro.co_FechaFactura_vct = Convert.ToDateTime(dtp_fechaOG.EditValue).Date;
                Info_OrdenGiro.co_FechaContabilizacion = Convert.ToDateTime(dtp_fechaOG.EditValue).Date;
                Info_OrdenGiro.co_fechaOg = Convert.ToDateTime(dtp_fechaOG.EditValue).Date;
                Info_OrdenGiro.co_Ice_base = 0;
                Info_OrdenGiro.co_Ice_por = 0; ;
                Info_OrdenGiro.co_Ice_valor = 0; ;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_OrdenGiro.co_observacion = txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                }
                else
                {
                    Info_OrdenGiro.co_observacion = txt_observacion.Text.Trim();
                }

                Info_OrdenGiro.co_OtroValor_a_descontar = Convert.ToDouble(txe_valor_restar.EditValue);//Convert.ToDouble(txE_vRestar.EditValue);
                Info_OrdenGiro.co_OtroValor_a_Sumar = 0;// Convert.ToDouble(txE_vSumar.EditValue);
                Info_OrdenGiro.co_plazo = 0;
                Info_OrdenGiro.co_Por_iva = Convert.ToDouble(txE_IVA.EditValue);
                Info_OrdenGiro.co_serie = Convert.ToString(txeSerie.EditValue).Trim();
                Info_OrdenGiro.co_Serv_por = 0;// Convert.ToDouble(txE_servicio.EditValue);
                Info_OrdenGiro.co_Serv_valor = 0;// Convert.ToDouble(txE_valorServicio.EditValue);
                Info_OrdenGiro.co_subtotal_iva = Convert.ToDouble(txE_subTotalIVA_12.EditValue);
                Info_OrdenGiro.co_subtotal_siniva = Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_SubTotal0.EditValue), 2));
                Info_OrdenGiro.co_total = Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_total.EditValue), 2));
                Info_OrdenGiro.co_vaCoa = "S";
                Info_OrdenGiro.co_valoriva = Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_valorIVA.EditValue), 2, MidpointRounding.AwayFromZero));
                Info_OrdenGiro.co_valorpagar = Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_total.EditValue), 2,MidpointRounding.AwayFromZero));
                Info_OrdenGiro.Saldo_OG = Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_total.EditValue), 2, MidpointRounding.AwayFromZero));
                Info_OrdenGiro.Estado = (Info_OrdenGiro.Estado == "I") ? Info_OrdenGiro.Estado : "A";
                Info_OrdenGiro.Fecha_Transac = param.Fecha_Transac;
                Info_OrdenGiro.Fecha_UltMod = param.Fecha_Transac;
                Info_OrdenGiro.Num_Autorizacion = Convert.ToString(txeIdNumAutoriza.EditValue);
                Info_OrdenGiro.fecha_autorizacion = FechaAu;
                Info_OrdenGiro.Num_Autorizacion_Imprenta = "";
                Info_OrdenGiro.IdCbteCble_Ogiro = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);
                Info_OrdenGiro.IdCod_101 = 0;// Convert.ToInt32(cmb_101.EditValue);
                Info_OrdenGiro.IdCod_ICE = 0;// Convert.ToInt32(cmb_ICE.EditValue);

                Info_OrdenGiro.IdCtaCble_Gasto = ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo()!=null ? ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo().IdCtaCble : paramCP_I.pa_ctacble_deudora;

                Info_OrdenGiro.IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                Info_OrdenGiro.IdIden_credito = Convert.ToInt32(cmb_idtCredito.EditValue);

                Info_OrdenGiro.IdOrden_giro_Tipo = Convert.ToString(cmbTipoDocu.EditValue);

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_OrdenGiro.IdProveedor = InfoProveedor.IdProveedor;
                }

                Info_OrdenGiro.IdTipoCbte_Ogiro = _IdTipoCbte;
                Info_OrdenGiro.IdTipoServicio = cmb_tipoOG.Text;
                Info_OrdenGiro.IdUsuario = param.IdUsuario;
                Info_OrdenGiro.IdUsuarioUltAnu = param.IdUsuario;
                Info_OrdenGiro.IdUsuarioUltMod = param.IdUsuario;
                Info_OrdenGiro.ip = param.ip;
                Info_OrdenGiro.MotivoAnu = "";
                Info_OrdenGiro.nom_pc = param.nom_pc;

                //    ordenGiro_I.IdCtaCble_IVA = Convert.ToString(cmbCtaIva.EditValue).Trim();

                var detalle = UC_Diario_x_cxp.Get_Info_CbteCble()._cbteCble_det_lista_info;
                foreach (var item in detalle)
                {
                    if (item.tipo == "IVA")
                    {
                        if (!String.IsNullOrEmpty(item.IdCtaCble.Trim()))
                        {
                            Info_OrdenGiro.IdCtaCble_IVA = item.IdCtaCble;
                        }
                        else
                        { Info_OrdenGiro.IdCtaCble_IVA = null; }
                    }

                }
                
                    Info_OrdenGiro.IdTipoFlujo = null;
                

                Info_OrdenGiro.co_retencionManual = "N";

                Info_OrdenGiro.Fecha_UltAnu = param.Fecha_Transac;

                Info_OrdenGiro.IdSucursal = param.IdSucursal;
                Info_OrdenGiro.BseImpNoObjDeIva = Math.Round( Convert.ToDouble(txE_SubTotal0.EditValue),2,MidpointRounding.AwayFromZero);
                Info_OrdenGiro.PagoLocExt = "LOC";
                Info_OrdenGiro.PaisPago = null;
                Info_OrdenGiro.ConvenioTributacion = "NA";
                Info_OrdenGiro.PagoSujetoRetencion = "NA";

                Info_OrdenGiro.co_propina = 0;
                Info_OrdenGiro.co_IRBPNR = 0;
                Info_OrdenGiro.cp_es_comprobante_electronico = chk_Cbte_Electronico.Checked;
                //Campo del tipo de movimiento
                Info_OrdenGiro.IdTipoMovi = ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo().IdTipoMovi;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {
            try
            {
                var detalle = UC_Diario_x_cxp.Get_Info_CbteCble()._cbteCble_det_lista_info;
                int i = 1;
                foreach (var dte in detalle)
                {
                    dte.IdEmpresa = param.IdEmpresa;
                    dte.IdCbteCble = (txt_NOrdeG.Text == "") ? 0 : Convert.ToDecimal(txt_NOrdeG.Text);
                    dte.IdTipoCbte = _IdTipoCbte;

                    if (String.IsNullOrEmpty(dte.dc_Observacion))
                    {
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            dte.dc_Observacion = String.IsNullOrEmpty(txt_observacion.Text) ? "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre : txt_observacion.Text.Trim() + "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                        }
                        else
                        {
                            dte.dc_Observacion = String.IsNullOrEmpty(txt_observacion.Text) ? "FP:#" + txeSerie.Text + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre : txt_observacion.Text.Trim(); ;
                        }
                    }

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

        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                txt_observacion.Focus();
                
                if (_Accion == Cl_Enumeradores.eTipo_action.duplicar)
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    respuesta = Grabar();
                }                

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    respuesta = Modificar();
                }
               
                return respuesta;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public Boolean Validar(ref string msg)
        {
            try
            {

                Boolean estado = true;

                if (ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo() == null)
                {
                     MessageBox.Show("Seleccione el tipo de gasto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txeIdNumAutoriza.EditValue)))
                {
                    MessageBox.Show("Ingrese el Número de Autorización del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeIdNumAutoriza.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txeSerie.EditValue)))
                {
                    MessageBox.Show("Ingrese la serie del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeSerie.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    MessageBox.Show("Ingrese el Número del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeNumDocum.Focus();
                    return false;
                }


                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                if (InfoProveedor == null && _Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (cmbTipoDocu.EditValue == null || cmbTipoDocu.EditValue == "")
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoDocu.Focus();
                    return false;
                }


                if (txeNumDocum.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar ingrese #Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

              
                if (String.IsNullOrEmpty(Convert.ToString(cmb_idtCredito.EditValue)))
                {
                    MessageBox.Show("Antes de continuar debe seleccionar la Identificación de sustento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDouble(txE_BaseImponible.EditValue) == 0)
                {
                    MessageBox.Show("Base imponible no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (UC_Diario_x_cxp.ValidarAsientosContables() == false)
                {
                    return false;
                }

                if (txeIdNumAutoriza.Text.Length < 10)
                {
                     MessageBox.Show("El número de autorización debe ser mayor a 10 caracteres ", param.Nombre_sistema);
                        return false;
                }
                
                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar && bus_OrdenGiro.ExisteFacturaPorProveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, txeSerie.Text, Convert.ToString(txeNumDocum.EditValue)))
                    {
                        MessageBox.Show("El número de documento ya fue ingresado verifique ", param.Nombre_sistema);
                        return false;
                    }

                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtp_fechaOG.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtp_fechaOG.EditValue)))
                    return false;

                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                msg = "Error ocurrido al grabar..  " + ex.Message + ex.InnerException;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Grabar()
        {
            Boolean res = false;
            try
            {
                res = Validar(ref msg);
                decimal idCbteCble = 0;
                if (res)
                {
                    res = false;
                    get_Cbtecble();
                    get_CbteCble_det();
                    get_ordenGiro();


                    Info_OrdenGiro.Info_CbteCble_x_OG = CbteCble_I;

                    //se graba la cabecera y la retencion
                    if (bus_OrdenGiro.GrabarDB(Info_OrdenGiro, ref idCbteCble, ref msg))
                    {
                        txt_NOrdeG.Text = idCbteCble.ToString();
                        // grabar tabla intermedia cp_orden_giro_x_com_ordencompra_local_det                         

                        // CbteCble_I.IdCbteCble +
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Factura Proveedor: ", Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + "/" + CbteCble_I.IdCbteCble);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        res = true;
                    }
                    else
                    {
                        MessageBox.Show(msg, param.Nombre_sistema);

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private Boolean Modificar()
        {
            Boolean res = true;
            try
            {
                res = Validar(ref msg);

                if (res)
                {
                    get_Cbtecble();
                    get_CbteCble_det();
                    get_ordenGiro();
                    Info_OrdenGiro.Info_CbteCble_x_OG = CbteCble_I;
                    
                    if (res = bus_OrdenGiro.ModificarDB(Info_OrdenGiro, ref msg))
                    {                        
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar la Factura Proveedor ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        res = false;

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        public void Set_accion(Cl_Enumeradores.eTipo_action Accion)
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

        private void Set_accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        uCMenu.Visible_bntAnular = false;
                        uCMenu.Visible_bntImprimir = false;
                        uCMenu.Visible_bntGuardar_y_Salir = true;
                        cmb_tipoOG.SelectedIndex = 0;
                        uCMenu.Visible_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        uCMenu.Visible_bntAnular = false;
                        uCMenu.Visible_bntImprimir = true;
                        uCMenu.Visible_bntGuardar_y_Salir = true;
                        
                        uCMenu.Visible_bntLimpiar = true;
                        set_Info_OrdenGiro_Controles();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        uCMenu.Visible_bntAnular = true;
                        uCMenu.Visible_bntImprimir = true;
                        uCMenu.Visible_bntGuardar_y_Salir = false;
                        
                        uCMenu.Visible_bntLimpiar = false;
                        set_Info_OrdenGiro_Controles();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        uCMenu.Visible_bntAnular = false;
                        uCMenu.Visible_bntImprimir = true;
                        uCMenu.Visible_bntGuardar_y_Salir = false;
                        
                        uCMenu.Visible_bntLimpiar = false;
                        set_Info_OrdenGiro_Controles();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        uCMenu.Visible_bntAnular = false;
                        uCMenu.Visible_bntImprimir = false;
                        uCMenu.Visible_bntGuardar_y_Salir = true;
                        uCMenu.Visible_btnGuardar = true;
                        uCMenu.Visible_bntLimpiar = true;
                        set_Info_OrdenGiro_Controles();
                        Info_OrdenGiro.IdCbteCble_Ogiro = 0;
                        txt_NOrdeG.Text = "0";                       
                        break;                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_idtCredito_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    return;
                }
                cmbTipoDocu.EditValue = null;
                InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                if (InfoProveedor != null)
                {
                    if (InfoProveedor.Persona_Info.IdTipoDocumento != null)
                    {
                        if (!String.IsNullOrEmpty(Convert.ToString(cmb_idtCredito.EditValue)))
                        {
                            cp_codigo_SRI_Info info = ListCodigoSRI.FirstOrDefault(v => v.IdCodigo_SRI == Convert.ToInt32(cmb_idtCredito.EditValue));

                            List<cp_TipoDocumento_Info> lst = new List<cp_TipoDocumento_Info>();

                            if (info != null)
                                if (info.codigoSRI != null)
                                    foreach (var item in LstTipDoc)
                                    {
                                        if (item.CodSRI == "03")
                                        {
                                            item.CodSRI = item.CodSRI;
                                        }

                                        if (item.Sustento_Tributario != null)
                                        {
                                            string[] arreglo = item.Sustento_Tributario.Split(',');

                                            for (int i = 0; i < arreglo.Length; i++)
                                            {
                                                arreglo[i] = arreglo[i].Trim();

                                                if (arreglo[i] == info.codigoSRI)
                                                {


                                                    string secuencial = "";
                                                    if (InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "RUC")
                                                        secuencial = "01";
                                                    else if (InfoProveedor.Persona_Info.IdTipoDocumento.Trim() == "CED")
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
                    }
                    else

                        MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_subTotalIVA_12_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_SubTotal0_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void txE_IVA_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void calcular()
        {
            try
            {
                subtotal_0 = Math.Round(Convert.ToDouble(txE_SubTotal0.EditValue), 2, MidpointRounding.AwayFromZero);
                subtotal_iva = Math.Round(Convert.ToDouble(txE_subTotalIVA_12.EditValue), 2, MidpointRounding.AwayFromZero);
                
                base_imponible = Math.Round(subtotal_0 + subtotal_iva, 2, MidpointRounding.AwayFromZero);
                txE_BaseImponible.EditValue = Math.Round(base_imponible, 2, MidpointRounding.AwayFromZero);

                porcentaje_iva = Math.Round(Convert.ToDouble(txE_IVA.EditValue), 2, MidpointRounding.AwayFromZero);
                valor_iva = (subtotal_iva * porcentaje_iva) / 100;
                txE_valorIVA.EditValue = Math.Round(valor_iva, 2, MidpointRounding.AwayFromZero);

                valor_restar = Math.Round(txe_valor_restar.EditValue== null ? 0 : Convert.ToDouble(txe_valor_restar.EditValue),2,MidpointRounding.AwayFromZero);

                total = subtotal_0 + subtotal_iva + valor_iva - valor_restar;
                txE_total.EditValue = Math.Round(total, 2, MidpointRounding.AwayFromZero);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Armar_diario()
        {
            try
            {
                if (!bandera_armar_diario)
                    return;

                InfoProveedor = new cp_proveedor_Info();

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    InfoProveedor.IdProveedor = Info_OrdenGiro.IdProveedor;
                }
                else
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        InfoProveedor.IdProveedor = Info_OrdenGiro.IdProveedor;
                    }
                    else
                    {
                        InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                    }
                }

                if (InfoProveedor == null)
                {
                    //MessageBox.Show("Antes de continuar debe seleccionar el Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Convert.ToDouble(txE_BaseImponible.EditValue) <= 0)
                {
                    //MessageBox.Show("Para generar el diario, la base imponible debe ser mayor a 0, Por favor ingrese los valores de la factura", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txE_subTotalIVA_12.Focus();
                    return;
                }
                if (ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo() == null)
                {
                    return;
                }

                List<ct_Cbtecble_det_Info> ListDetalle = new List<ct_Cbtecble_det_Info>();

                int ro = 0;
                #region Cuenta de proveedor
                //PROVEEDOR LOCAL
                ct_Cbtecble_det_Info prov = new ct_Cbtecble_det_Info();
                prov.IdEmpresa = param.IdEmpresa;

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    ucCp_Proveedor1.set_ProveedorInfo(InfoProveedor.IdProveedor);
                    prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                }
                else
                {
                    if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                    {
                        ucCp_Proveedor1.set_ProveedorInfo(InfoProveedor.IdProveedor);
                        prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                    }
                    else
                    {
                        prov.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                    }
                }
                prov.IdCentroCosto = ucCp_Proveedor1.get_ProveedorInfo().IdCentroCosoto;
                prov.IdCentroCosto_sub_centro_costo = ucCp_Proveedor1.get_ProveedorInfo().IdSubCentroCosoto;
                prov.IdPunto_cargo = ucCp_Proveedor1.get_ProveedorInfo().IdPunto_cargo;
                prov.IdPunto_cargo_grupo = ucCp_Proveedor1.get_ProveedorInfo().IdPunto_cargo_grupo;
                prov.dc_Valor = (((Convert.ToDecimal(txE_total.EditValue) > 0) ? (Convert.ToDouble(txE_total.EditValue)) : 0) + (txe_valor_restar.Text =="" ? 0 : Convert.ToDouble(txe_valor_restar.EditValue)))*-1;
                ListDetalle.Add(prov);
                #endregion

                #region Cuenta de iva
                ct_Cbtecble_det_Info iva = new ct_Cbtecble_det_Info();

                if (!String.IsNullOrEmpty(Convert.ToString(txE_subTotalIVA_12.EditValue)))
                {

                    if (Convert.ToDouble(txE_subTotalIVA_12.EditValue) > 0)
                    {
                        iva.IdEmpresa = param.IdEmpresa;

                        if (!String.IsNullOrEmpty(paramCP_I.pa_ctacble_iva.Trim()))
                        {
                            iva.IdCtaCble = paramCP_I.pa_ctacble_iva.Trim();
                        }
                        else
                        { iva.IdCtaCble = null; }

                        iva.tipo = "IVA";

                        iva.dc_Valor = (Convert.ToDouble(txE_valorIVA.EditValue) > 0) ? Convert.ToDouble(Math.Round(Convert.ToDecimal(txE_valorIVA.EditValue), 2, MidpointRounding.AwayFromZero)) : 0;                        

                        ListDetalle.Add(iva);

                        ro += 1;
                    }
                }
                #endregion

                #region Cuenta de gasto
                ct_Cbtecble_det_Info gto = new ct_Cbtecble_det_Info();
                gto.IdEmpresa = param.IdEmpresa;
                gto.IdCtaCble = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_Gasto;

               
                    gto.IdCtaCble = ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo().IdCtaCble;
                    //gto.IdCtaCble = paramCP_I.pa_ctacble_deudora; 
                gto.dc_Valor = (Convert.ToDouble(txE_BaseImponible.EditValue) > 0) ? Convert.ToDouble(txE_BaseImponible.EditValue) : 0;
                
                gto.IdCentroCosto = uCct_CentroCosto1.Get_IdCentroCosto();
                gto.IdCentroCosto_sub_centro_costo = uCct_CentroCosto1.Get_IdSubCentro_Costo();
                gto.IdRegistro = gto.IdCentroCosto + "-" + gto.IdCentroCosto_sub_centro_costo;
                
                if (uCct_Pto_Cargo1.Get_Pto_Cargo() != null)
                {
                    gto.IdPunto_cargo_grupo = uCct_Pto_Cargo1.Get_Pto_Cargo().IdPunto_cargo_grupo;
                    gto.IdPunto_cargo = uCct_Pto_Cargo1.Get_Pto_Cargo().IdPunto_cargo;
                }
                else
                {
                    gto.IdPunto_cargo_grupo = null;
                    gto.IdPunto_cargo = null;
                }
                
                ListDetalle.Add(gto);
                UC_Diario_x_cxp.setDetalle(ListDetalle);
                #endregion
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txE_total_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UC_Diario_x_cxp.LimpiarGrid();
                Armar_diario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCMenu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCMenu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public cp_orden_giro_Info Get_Orden_giro()
        {
            try
            {
                return Info_OrdenGiro;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void uCct_Pto_Cargo1_event_delegate_cmb_Pto_Cargo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (uCct_Pto_Cargo1.Get_Id_Pto_Cargo() != 0)
                {
                    info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, uCct_Pto_Cargo1.Get_Id_Pto_Cargo());
                    uCct_CentroCosto1.Set_centro_costo(info_punto_cargo.IdCentroCosto_Scc);
                    uCct_CentroCosto1.Set_sub_centro_costo(info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc);
                }
                else
                {
                    uCct_CentroCosto1.Set_centro_costo("");
                    uCct_CentroCosto1.Set_sub_centro_costo("");
                }
                Armar_diario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uCMenu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void set_Info_OrdenGiro_Controles()
        {
            try
            {
                bandera_armar_diario = false;

                dtp_fechaOG.EditValue = Info_OrdenGiro.co_fechaOg;
                txt_observacion.Text = Info_OrdenGiro.co_observacion;
                txt_NOrdeG.Text = Info_OrdenGiro.IdCbteCble_Ogiro.ToString();
                txE_BaseImponible.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_baseImponible);
                txeNumDocum.EditValue = Info_OrdenGiro.co_factura;
                txE_IVA.EditValue = (Convert.ToDouble(Info_OrdenGiro.co_Por_iva) == 0) ? param.iva.porcentaje : Convert.ToDouble(Info_OrdenGiro.co_Por_iva);
                txeSerie.EditValue = Info_OrdenGiro.co_serie;
                txE_subTotalIVA_12.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_subtotal_iva);
                txE_SubTotal0.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_subtotal_siniva);
                txE_valorIVA.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_valoriva);
                txe_valor_restar.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_OtroValor_a_descontar);
                ucCp_Proveedor1.set_ProveedorInfo(Info_OrdenGiro.IdProveedor);
                _IdTipoCbte = Info_OrdenGiro.IdTipoCbte_Ogiro;
                cmb_tipoOG.Text = Info_OrdenGiro.IdTipoServicio;
                cmb_idtCredito.EditValue = Convert.ToInt32(Info_OrdenGiro.IdIden_credito);
                cmbTipoDocu.EditValue = Info_OrdenGiro.IdOrden_giro_Tipo;
                txeIdNumAutoriza.EditValue = Info_OrdenGiro.Num_Autorizacion;
                txE_total.EditValue = Convert.ToDecimal(Info_OrdenGiro.co_total);
                chk_Cbte_Electronico.Checked = Info_OrdenGiro.cp_es_comprobante_electronico == null ? false : Convert.ToBoolean(Info_OrdenGiro.cp_es_comprobante_electronico);
                
                set_CbteCbleInfo();
                bandera_armar_diario = true;
                if (_Accion == Cl_Enumeradores.eTipo_action.duplicar)
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_ordenGiro(cp_orden_giro_Info info)
        {
            try
            {
                Info_OrdenGiro = info;
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
                if (Info_OrdenGiro.IdCbteCble_Ogiro != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";
                    UC_Diario_x_cxp.LimpiarGrid();
                    lm = _CbteCbleBus.Get_list_Cbtecble_det(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref MensajeError);
                    UC_Diario_x_cxp.setDetalle(lm);

                    Set_Punto_cargo_de_diario();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Punto_cargo_de_diario()
        {
            try
            {
                List<caj_Caja_Movimiento_Tipo_Info> lst_tipo_movi_caj = new List<caj_Caja_Movimiento_Tipo_Info>();
                caj_Caja_Movimiento_Tipo_Bus bus_movi_caj = new caj_Caja_Movimiento_Tipo_Bus();

                lst_tipo_movi_caj = bus_movi_caj.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa, Cl_Enumeradores.eTipo_Ing_Egr.EGRESOS, ref msg);

                foreach (var item in UC_Diario_x_cxp.Get_List_Cbtecble_det())
                {
                    if (item.IdPunto_cargo != null)
                    {
                        uCct_Pto_Cargo1.Set_info_punto_Cargo(Convert.ToInt32(item.IdPunto_cargo));
                    }
                    if (item.dc_Valor > 0)
                    {
                        if (lst_tipo_movi_caj.FirstOrDefault(q=>q.IdCtaCble == item.IdCtaCble)!= null)
                        {
                            ucCaj_MovEgresoCaj_cmb1.set_MovimientoInfo(lst_tipo_movi_caj.FirstOrDefault(q => q.IdCtaCble == item.IdCtaCble).IdTipoMovi);
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

        private void ucCaj_MovEgresoCaj_cmb1_event_cmbTipoMoviCaja_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_Tipo_Info info_movi = new caj_Caja_Movimiento_Tipo_Info();
                info_movi = ucCaj_MovEgresoCaj_cmb1.get_MovimientoInfo();
                if (info_movi != null)
                {
                    if (info_movi.IdCtaCble != null)
                    {
                        Armar_diario();
                    }
                    else
                    {
                        MessageBox.Show("El tipo de movimiento seleccionado no posee cuenta contable, por favor corrija",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        ucCaj_MovEgresoCaj_cmb1.set_MovimientoInfo(0);
                    }
                }                
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
                //validar secuencial factura
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

        private void txe_valor_restar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
