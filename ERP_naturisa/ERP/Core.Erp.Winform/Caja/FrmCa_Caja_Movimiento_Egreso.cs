using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_Caja_Movimiento_Egreso : Form
    {
        #region Declaración de variables

        double Total = 0;

        caj_Caja_Movimiento_det_Bus CajaMoviDet_Bus = new caj_Caja_Movimiento_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Bus caja_B = new caj_Caja_Bus();
        caj_parametro_Bus cajPara = new caj_parametro_Bus();
        caj_parametro_Info listParanCaja = new caj_parametro_Info();
        Boolean Guardado = false;
        caj_Caja_Info caja_I = new caj_Caja_Info();
        caj_Caja_Movimiento_Tipo_Bus caj_Caja_Movimiento_Tipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        caj_Caja_Movimiento_Tipo_Info Motivo_I = new caj_Caja_Movimiento_Tipo_Info();
        List<caj_Caja_Movimiento_Tipo_Info> caj_Caja_Movimiento_Tipo_LisI = new List<caj_Caja_Movimiento_Tipo_Info>();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        Cl_Enumeradores.eTipo_action _Accion;
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        caj_Caja_Movimiento_Info CajaMovi_I = new caj_Caja_Movimiento_Info();
        caj_Caja_Movimiento_Bus CajaMovi_B = new caj_Caja_Movimiento_Bus();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();

        
        
        vwcp_orden_pago_con_cancelacion_Bus orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

        vwtb_persona_beneficiario_Info G_persona_beneficiario_Info_obj = new vwtb_persona_beneficiario_Info();

        BindingList<vwcp_orden_pago_con_cancelacion_Info> BindingList__DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<caj_Caja_Movimiento_det_Info> Listdet;
        int IdTipoCbte_OP = 0;
        List<cp_orden_pago_cancelaciones_Info> ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
        cp_orden_pago_cancelaciones_Bus BusOrdenPagoCancelacion = new cp_orden_pago_cancelaciones_Bus();

        
        BindingList<caj_Caja_Movimiento_det_Info> BcajaMovDetInfo = new BindingList<caj_Caja_Movimiento_det_Info>();
        List<caj_Caja_Movimiento_det_Info> LcajaMovDetInfo = new List<caj_Caja_Movimiento_det_Info>();
        
        caj_Caja_Movimiento_det_Info infoDet = new caj_Caja_Movimiento_det_Info();
        BindingList<vwcaj_Caja_Movimiento_det_cancelado_Info> BindingDetalleCaja = new BindingList<vwcaj_Caja_Movimiento_det_cancelado_Info>();
        
                    List<caj_Caja_Info> lis_Cajas = new List<caj_Caja_Info>();


        decimal idCbteCble = 0;
        string cod_CbteCble = "";

        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;

        int _IdTipoCbte_EG = 0;
        int IdTipoCbteRev_EG = 0;

        decimal IdCbteCbleRev;
        string MensajeError = "";
        string dc = "";
        string motiAnulacion = "";
        string IdFormaPago = "EFEC";
        caj_Caja_Movimiento_Info Info_CajMovi = new caj_Caja_Movimiento_Info();
        Caj_Talonario_Recibo_Bus talonarioBus = new Caj_Talonario_Recibo_Bus();//opin 2017/03/24

        public delegate void delegate_FrmCa_Caja_Movimiento_Egreso_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCa_Caja_Movimiento_Egreso_FormClosing event_FrmCa_Caja_Movimiento_Egreso_FormClosing;
     
        #region Enventos delegados locales

        void FrmCa_Caja_Movimiento_event_FrmCa_Caja_Movimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion

        #endregion

        public FrmCa_Caja_Movimiento_Egreso()
        {
            InitializeComponent();
            #region Obtener lista
            try
            {
                lis_Cajas = caja_B.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.ultraCmbE_caja.Properties.DataSource = lis_Cajas;
                caj_Caja_Movimiento_Tipo_LisI = caj_Caja_Movimiento_Tipo_B.Get_list_Caja_Movimiento_Tipo( ref  MensajeError);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            #endregion
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_FrmCa_Caja_Movimiento_Egreso_FormClosing += FrmCa_Caja_Movimiento_Egreso_event_FrmCa_Caja_Movimiento_Egreso_FormClosing;
        }

        void FrmCa_Caja_Movimiento_Egreso_event_FrmCa_Caja_Movimiento_Egreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
                //imprimir();
                ImprimirDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ImprimirDiario()
        {
            try
            {
                XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                reporte.set_parametros(Info_CajMovi.IdEmpresa, Info_CajMovi.IdTipocbte, Info_CajMovi.IdCbteCble);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();
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
                if (validaColumna())
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
                if (validaColumna())
                {
                    if (Grabar())
                        LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (CajaMovi_I.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Movimiento de Caja # " + CajaMovi_I.IdCbteCble + " ?", "Anulación de Movimiento de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motiAnulacion = fr.motivoAnulacion;

                        int IdTipoCbteRev = IdTipoCbteRev_EG;

                        if (CbteCble_B.ReversoCbteCble(param.IdEmpresa, Convert.ToDecimal(txt_Ncomprobante.Text), _IdTipoCbte, IdTipoCbteRev, ref IdCbteCbleRev, ref MensajeError, param.IdUsuario))
                        {
                            CajaMovi_I.MotivoAnulacion = motiAnulacion;
                            CajaMovi_I.IdUsuario_Anu = param.IdUsuario;
                            CajaMovi_I.FechaAnulacion = param.Fecha_Transac;
                            CajaMovi_I.IdTipocbte_Anu = IdTipoCbteRev;
                            CajaMovi_I.IdCbteCble_Anu = IdCbteCbleRev;

                            if (CajaMovi_B.AnularDB(CajaMovi_I, ref  MensajeError))
                            {
                               

                                cp_orden_pago_cancelaciones_Bus bus_Cancela = new cp_orden_pago_cancelaciones_Bus();
                                string mensaje="";
                                if (bus_Cancela.Eliminar_OrdenPagoCancelaciones(CajaMovi_I.IdEmpresa, CajaMovi_I.IdTipocbte, CajaMovi_I.IdCbteCble, ref mensaje))
                                { }
                                
                                
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Movimiento de Caja ", CajaMovi_I.IdCbteCble_Anu);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + CajaMovi_I.IdCbteCble_Anu.ToString() + " Tipo Cbt.Cble de Anu.: " + CajaMovi_I.IdTipocbte_Anu.ToString();
                                lb_Anulado.Visible = true;
                                lblCbt_TipoAnulacion.Visible = true;
                                ucGe_Menu.Visible_bntAnular = false;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                                
                        }
                        else
                            MessageBox.Show("No se pudo Reversar el Comprobante", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                    MessageBox.Show("Esta Movimiento de Caja ya esta Anulada...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
      

        private void FrmCa_Caja_Movimiento_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                set_accion_in_controls();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularTotal()
        {
            try
            {
                foreach (var item in BindingList__DetalleAprob)
                {
                    if (item.Check == true)
                    {
                        Total = Total + item.Valor_aplicado;
                    }
                    
                }
                if (BindingList__DetalleAprob.Count > 0)
                {
                    txe_monto.EditValue = Convert.ToDouble(Total);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generaDiario()
        {
            try
            {
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                ct_Cbtecble_det_Info Debe_x_Movi_Tipo = new ct_Cbtecble_det_Info();
                ct_Cbtecble_det_Info Debe_x_OP = new ct_Cbtecble_det_Info();
                ct_Cbtecble_det_Info Haber_caja = new ct_Cbtecble_det_Info();



                caj_Caja_Movimiento_Tipo_Info motivo = cmb_motivo.get_MovimientoInfo();



                // egreso de caja la caja va al haber 
                
                Haber_caja.IdEmpresa = param.IdEmpresa;
                Haber_caja.IdTipoCbte = _IdTipoCbte_EG;
                if (caja_I !=null)
                    Haber_caja.IdCtaCble = caja_I.IdCtaCble; // cuenta de caja al haber
                Haber_caja.dc_Valor = Convert.ToDouble(txe_monto.EditValue) * -1;



                //debe la cuentas de OP o la del motivo sino hay OPS

                if (BindingList__DetalleAprob.Count > 0) // hay ops se contabiliza por ops
                {

                    foreach (var item in BindingList__DetalleAprob)
                    {
                        Debe_x_OP = new ct_Cbtecble_det_Info();
                        Debe_x_OP.IdEmpresa = param.IdEmpresa;
                        Debe_x_OP.IdTipoCbte = _IdTipoCbte_EG;
                        Debe_x_OP.IdCtaCble = item.IdCtaCble;//motivo al debe
                        Debe_x_OP.dc_Valor = item.Valor_aplicado;
                        _ListaCbteCbleDet.Add(Debe_x_OP);
                    }
                
                }
                else
                {
                    Debe_x_Movi_Tipo = new ct_Cbtecble_det_Info();
                    
                    Debe_x_Movi_Tipo.IdEmpresa = param.IdEmpresa;
                    Debe_x_Movi_Tipo.IdTipoCbte = _IdTipoCbte_EG;

                    if (motivo != null)
                    {
                        Debe_x_Movi_Tipo.IdCtaCble = motivo.IdCtaCble;//motivo al debe

                    }

                    Debe_x_Movi_Tipo.dc_Valor = Convert.ToDouble(txe_monto.EditValue);
                    _ListaCbteCbleDet.Add(Debe_x_Movi_Tipo);
                }



                
                
                _ListaCbteCbleDet.Add(Haber_caja);

                UC_DiarioContPago.setDetalle(_ListaCbteCbleDet);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ct_Cbtecble_det_Info> Get_CbteCble_det()
        {
            try
            {
                List<ct_Cbtecble_det_Info> lst = new List<ct_Cbtecble_det_Info>();
                if(Guardado)
                    lst = UC_DiarioContPago.Get_List_Cbtecble_det();
                return lst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        int IdSucursal = 0;
        
        private void ultraCmbE_caja_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = 0;
                if (this.ultraCmbE_caja.EditValue != null)
                {
                    //Infragistics.Win.ValueListItem item = new Infragistics.Win.ValueListItem();
                    caja_I = (caj_Caja_Info)ultraCmbE_caja.Properties.View.GetFocusedRow();
                    if (caja_I == null)
                    {
                        caja_I = lis_Cajas.Where(v=>v.IdCaja==Convert.ToInt32( ultraCmbE_caja.EditValue)).FirstOrDefault();
                    }
                    if (caja_I != null)
                    {
                        txt_responsable.Text = caja_I.N_usuarioResponsable;
                        ucFa_Sucursal_PtoVta_cmb1.set_Idsucursal((int)caja_I.IdSucursal);//opin 2017/03/24
                        //txt_sucursal.Text = caja_I.NSucursal.Trim();
                        IdSucursal = Convert.ToInt32(caja_I.IdSucursal);
                    }

                }
                generaDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmbE_motivo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                 generaDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_monto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        public caj_Caja_Movimiento_Info get_cajaMovi()
        {
            try
            {
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    CajaMovi_I.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }
                else CajaMovi_I.IdTipoFlujo = null;

                
                CajaMovi_I.cm_fecha = dt_fechaCbte.Value;
                CajaMovi_I.cm_observacion = txt_observacion.Text;
                CajaMovi_I.cm_Signo = "-";
                CajaMovi_I.cm_valor = Convert.ToDouble(txe_monto.EditValue);
                CajaMovi_I.Estado = (lb_Anulado.Visible == false) ? "A" : "I";
                CajaMovi_I.Fecha_Transac = param.Fecha_Transac;
                CajaMovi_I.IdCaja = caja_I.IdCaja;
                CajaMovi_I.IdSucursal = ucFa_Sucursal_PtoVta_cmb1.get_Info_Sucursal().IdSucursal;//opin 2017/03/24
                CajaMovi_I.IdPuntoVta = ucFa_Sucursal_PtoVta_cmb1.get_Info_PuntoVta().IdPuntoVta;//opin 2017/03/24
                CajaMovi_I.IdCbteCble =(txt_Ncomprobante.Text=="")?0:Convert.ToDecimal(txt_Ncomprobante.Text);
                CajaMovi_I.CodMoviCaja = cod_CbteCble;
                CajaMovi_I.IdEmpresa = param.IdEmpresa;
                CajaMovi_I.IdPeriodo = Per_I.IdPeriodo;
                CajaMovi_I.IdTipocbte = _IdTipoCbte;

                if (cmb_motivo.get_MovimientoInfo() != null)
                {
                    CajaMovi_I.IdTipoMovi = cmb_motivo.get_MovimientoInfo().IdTipoMovi;
                }
                else CajaMovi_I.IdTipoMovi = null;
                //CajaMovi_I.IdTipoMovi = cmb_motivo.get_MovimientoInfo() == null ? 0 : cmb_motivo.get_MovimientoInfo().IdTipoMovi;
                CajaMovi_I.IdUsuario = param.IdUsuario;
                CajaMovi_I.IdUsuario_Aprueba = param.IdUsuario;
               CajaMovi_I.ResponsableCaja = txt_responsable.Text;
                CajaMovi_I.IdSucursal = IdSucursal;
                CajaMovi_I.IdPersona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdPersona;
                CajaMovi_I.cm_beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info().NombreCompleto;
                CajaMovi_I.IdTipo_Persona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdTipo_Persona;
                CajaMovi_I.IdPersona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdPersona;
                CajaMovi_I.IdEntidad = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdEntidad;

                return CajaMovi_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new caj_Caja_Movimiento_Info();
            }
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {

                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha  = dt_fechaCbte.Value;
                CbteCble_I.cb_Valor = Convert.ToDouble(txe_monto.EditValue);
                CbteCble_I.cb_Observacion = "Egreso de Caja "+ txt_observacion.Text;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dt_fechaCbte.Value.Year;
                CbteCble_I.Mes = dt_fechaCbte.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = (txt_Ncomprobante.Text == "") ? 0 : Convert.ToDecimal(txt_Ncomprobante.Text); 
                CbteCble_I._cbteCble_det_lista_info = _ListaCbteCbleDet;
                                
                CajaMovi_I.Info_CbteCble_x_Caja_Movi = CbteCble_I;

                return CbteCble_I;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Cbtecble_Info();
            }
        }

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;

                

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }
                if (this.ucFa_Sucursal_PtoVta_cmb1.get_IdSucursal() == 0) //opin2017/03/27
                {
                    MessageBox.Show("Por favor, seleccione la sucursal ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucFa_Sucursal_PtoVta_cmb1.cmb_sucursal.Focus();
                    return false;
                }

                if (this.ultraCmbE_caja.EditValue  == null)
                {
                    MessageBox.Show("Antes de continuar seleccione Caja", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (cmb_motivo.get_MovimientoInfo()==null)
                {
                    MessageBox.Show("Antes de continuar seleccione el Motivo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (cmb_motivo.get_MovimientoInfo().IdTipoMovi == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione el Motivo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (Convert.ToDouble(txe_monto.EditValue) <= 0)
                {
                    MessageBox.Show("Por favor Ingrese el Monto...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CAJ, Convert.ToDateTime(dt_fechaCbte.Value)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dt_fechaCbte.Value)))
                    return false; 


                //return estado;//PENDIENTE
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        public Boolean getAsientoContable()
        {
            Boolean res = false;
            try
            {
                CbteCble_I = UC_DiarioContPago.Get_Info_CbteCble();
                foreach (var item in CbteCble_I._cbteCble_det_lista_info)
                {
                    item.dc_Observacion = "" + item.dc_Observacion;
                }
                CbteCble_I.IdEmpresa = param.IdEmpresa;

                
                CbteCble_I.IdTipoCbte = IdTipoCbte_OP;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.cb_Fecha = Convert.ToDateTime(dt_fechaCbte.Value.ToShortDateString());
                CbteCble_I.Anio = CbteCble_I.cb_Fecha.Year;
                CbteCble_I.Mes = CbteCble_I.cb_Fecha.Month;
                CbteCble_I.cb_Observacion = "";

                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_Valor = CbteCble_I._cbteCble_det_lista_info.FindAll(var => var.dc_Valor > 0).
                    Sum(var => var.dc_Valor);
                CbteCble_I.Mayorizado = "N";

                string mes = Convert.ToString(CbteCble_I.Mes);
                if (mes.Length == 1)
                    mes = "0" + mes;

                string AnioMes = Convert.ToString(CbteCble_I.Anio) + mes;
                int IdPeriodo = Convert.ToInt32(AnioMes);

                CbteCble_I.IdPeriodo = IdPeriodo;
                CbteCble_I.Estado = "A";
                CbteCble_I.cb_Fecha = CbteCble_I.cb_Fecha;
                CbteCble_I.cb_Valor = CbteCble_I.cb_Valor;

                res = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;

        }

        private Boolean Grabar()
        {
            try
            {
                Boolean bolResult = false;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    txe_monto.Focus();
                    CalcularTotal();
                    if (!getAsientoContable())
                    { MessageBox.Show("Verifique el Asiento Contable a generar."); }
                    else
                    {
                        if (validaColumna())
                        {
                            string msg = "";

                            _IdTipoCbte = _IdTipoCbte_EG;
                            IdTipoCbteRev = IdTipoCbteRev_EG;
                            dc = "Egreso Caja ";

                            if (BindingList__DetalleAprob.Count > 0)
                            {
                                txe_monto.EditValue = Convert.ToDouble(colValor_aplicado.SummaryText);
                            }

                            get_Cbtecble();
                            GetDetalle_Grid();
                            get_cajaMovi();
                                                            
                             if (CajaMovi_B.GrabarDB(ref CajaMovi_I, ref  MensajeError))
                                {
                                   txt_Ncomprobante.Text = CajaMovi_I.IdCbteCble.ToString();
                                                                       
                                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, dc, txt_Ncomprobante.Text);
                                        MessageBox.Show(smensaje, param.Nombre_sistema);
                                       
                                        if (MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msg_Pregunta_Imprimir, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            Info_CajMovi = CajaMovi_I;
                                            ucGe_Menu_event_btnImprimir_Click(null, null);                                            
                                        }
                                        bolResult = true;                                 
                                }
                                else
                                {
                                    MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }                                                          
                        }
                    }
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    get_cajaMovi();
                    if (CajaMovi_B.ModificarDB(CajaMovi_I, ref  MensajeError))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, dc, txt_Ncomprobante.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Visible_btnGuardar = false;
                        bolResult = true;
                     
                    }
                    else
                    {
                     
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                    }
                }
                Guardado = bolResult;
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void LimpiarDatos()
        {
            try
            {
                CajaMovi_I = new caj_Caja_Movimiento_Info();
                Info_CajMovi = new caj_Caja_Movimiento_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion(_Accion);
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                CbteCble_I = new ct_Cbtecble_Info();
                BindingList__DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                Listdet = new List<caj_Caja_Movimiento_det_Info>();
                BindingDetalleCaja = new BindingList<vwcaj_Caja_Movimiento_det_cancelado_Info>();
                this.gridEgresoCaja.DataSource = BindingDetalleCaja;
                ucBa_TipoFlujo.Inicializar_TipoFlujo();
                
                txt_observacion.Text = "";                
                txe_monto.EditValue = "0";
                txt_Ncomprobante.Text = "0";
                
                txt_responsable.Text = "";

                //opin 2017/03/27
                cmb_motivo.Inicializar_cmb_comprador();
                cmb_motivo.Enabled = true;
                ucGe_Beneficiario.Inicializar_Beneficiario();
                txtRecibo.Visible = false;
                lblNumeroRecibo.Visible = false;
                ucFa_Sucursal_PtoVta_cmb1.InicializarPtoVta();
                ucFa_Sucursal_PtoVta_cmb1.InicializarSucursal();
                ultraCmbE_caja.EditValue = null;
                txt_responsable.Text = string.Empty;
                ultraCmbE_caja.Enabled = true;
           
            }
            catch (Exception ex)
            {
             Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<caj_Caja_Movimiento_det_Info> GetDetalle_Grid()
        {
            try
            {                
                Listdet = new List<caj_Caja_Movimiento_det_Info>();
                ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
                int contador = 1;
                foreach (var item in BindingList__DetalleAprob)
                {
                    if (item.Check == true)
                    {
                        caj_Caja_Movimiento_det_Info info_det = new caj_Caja_Movimiento_det_Info();
                        cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                        // Orden de cancelación
                        info_ordenCan.IdEmpresa = param.IdEmpresa;
                        info_ordenCan.Idcancelacion = 0;
                        info_ordenCan.Secuencia = contador;

                        info_ordenCan.IdEmpresa_op= item.IdEmpresa;
                        info_ordenCan.IdOrdenPago_op=item.IdOrdenPago;

                        info_ordenCan.Secuencia_op= item.Secuencia_OP;
                        info_ordenCan.IdEmpresa_op_padre = null;
                        info_ordenCan.IdOrdenPago_op_padre = null;
                        info_ordenCan.Secuencia_op_padre = null;

                        info_ordenCan.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info_ordenCan.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info_ordenCan.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info_ordenCan.IdEmpresa_pago = param.IdEmpresa;
                        info_ordenCan.IdTipoCbte_pago = CajaMovi_I.IdTipocbte;
                        info_ordenCan.IdCbteCble_pago =(txt_Ncomprobante.Text=="")?0:Convert.ToDecimal(txt_Ncomprobante.Text);
                        info_ordenCan.MontoAplicado = item.Valor_aplicado;
                        info_ordenCan.SaldoAnterior=0;
                        info_ordenCan.SaldoActual=0;
                        info_ordenCan.Observacion=txt_observacion.Text;
                        info_ordenCan.IdTipo_Persona = item.IdTipoPersona;
                        info_ordenCan.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                        info_ordenCan.IdPersona = item.IdPersona;
                        info_ordenCan.IdTipo_op = item.IdTipo_op;
                        ListOrdenPagoCancelacion.Add(info_ordenCan);
                       

                        // detalle
                        info_det.IdEmpresa = param.IdEmpresa;
                        info_det.IdOrdenPago = item.IdOrdenPago;
                        info_det.cr_Valor = item.Valor_aplicado;
                        info_det.Secuencia = contador;
                        info_det.IdTipocbte = _IdTipoCbte;
                        info_det.IdCobro_tipo = null;
                        info_det.cr_fecha = dt_fechaCbte.Value;
                        info_det.cr_Banco = null;
                        info_det.cr_cuenta = null;
                        info_det.cr_fechaDocu = null;
                        info_det.cr_NumDocumento = null;
                        info_det.IdCbteCble = CajaMovi_I.IdCbteCble;
                        info_det.IdTipocbte = CajaMovi_I.IdTipocbte;
                        info_det.IdEmpresa_OP = item.IdEmpresa;

                        Listdet.Add(info_det);
                     
                        contador = contador + 1;
                    }

                   
                }
                CajaMovi_I.List_OrdenCan = ListOrdenPagoCancelacion;
                CajaMovi_I.list_Caja_Movi_det = Listdet;

                

                return Listdet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Listdet;
            }
        }

        void Inhabilitar_Grid()
        {

            colCheck.Visible = false;
            colValor_aplicado.Visible = false;
            colFecha_Pago.Visible = false;
            colTotal_cancelado_OP.Visible = true;

            colIdOrdenPago.OptionsColumn.AllowEdit = false;
            colFecha_OP.OptionsColumn.AllowEdit = false;
            colIdTipoPersona.OptionsColumn.AllowEdit = false;
            colIdPersona1.OptionsColumn.AllowEdit = false;
            colIdEntidad1.OptionsColumn.AllowEdit = false;
            colNom_Beneficiario_2.OptionsColumn.AllowEdit = false;
            colReferencia.OptionsColumn.AllowEdit = false;
            colSaldo_x_Pagar_OP.OptionsColumn.AllowEdit = false;
            colValor_estimado_a_pagar_OP.OptionsColumn.AllowEdit = false;
            colTotal_cancelado_OP.OptionsColumn.AllowEdit = false;
        
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

                        this.event_FrmCa_Caja_Movimiento_Egreso_FormClosing += new delegate_FrmCa_Caja_Movimiento_Egreso_FormClosing(FrmCa_Caja_Movimiento_event_FrmCa_Caja_Movimiento_FormClosing);

                        //HMRR
                        tb_banco_Bus BusBanco = new tb_banco_Bus();
                        cxc_cobro_tipo_Bus BustipoCxC = new cxc_cobro_tipo_Bus();


                        orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();


                        //llenado grid
                        // Carga de Grid

                        BindingList__DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago(param.IdEmpresa,
                            G_persona_beneficiario_Info_obj.IdTipo_Persona, G_persona_beneficiario_Info_obj.IdPersona
                            , G_persona_beneficiario_Info_obj.IdEntidad, "APRO"));

                        this.gridEgresoCaja.DataSource = BindingList__DetalleAprob;
                        //


                        caj_Caja_Movimiento_Tipo_LisI = caj_Caja_Movimiento_Tipo_B.Get_list_Caja_Movimiento_Tipo( ref  MensajeError);

                        _IdTipoCbte = _IdTipoCbte_EG;
                        IdTipoCbteRev = IdTipoCbteRev_EG;
                        dc = "Egreso Caja ";
                        txt_observacion.Visible = true;



                        listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                        _IdTipoCbte_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr;
                        IdTipoCbteRev_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr_Anu;
                        colCheck.OptionsColumn.AllowEdit = true;

                        ultraCmbE_caja.Enabled = true;
                        cmb_motivo.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:




                        listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                        _IdTipoCbte_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr;
                        IdTipoCbteRev_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr_Anu;
                        _IdTipoCbte = _IdTipoCbte_EG;
                        IdTipoCbteRev = IdTipoCbteRev_EG;
                        dc = "Egreso Caja ";
                        txt_observacion.Visible = true;
                        colCheck.OptionsColumn.AllowEdit = false;
                        ultraCmbE_caja.Enabled = false;
                        //cmb_motivo.Enabled = false;

                        set_Info_CajaMovi_in_controls();
                        //opin 2017/03/24
                        txtRecibo.Visible = true;
                        txtRecibo.Properties.ReadOnly = true;
                        lblNumeroRecibo.Visible = true;
                        talonarioBus = new Caj_Talonario_Recibo_Bus();
                        if (Info_CajMovi.IdRecibo != null)
                        txtRecibo.Text = talonarioBus.Get_Num_Recibo_optenido((int)Info_CajMovi.IdRecibo, ref MensajeError);
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                        _IdTipoCbte_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr;
                        IdTipoCbteRev_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr_Anu;
                        _IdTipoCbte = _IdTipoCbte_EG;
                        IdTipoCbteRev = IdTipoCbteRev_EG;
                        dc = "Egreso Caja ";
                        txt_observacion.Visible = true;

                        colCheck.OptionsColumn.AllowEdit = false;
                        ultraCmbE_caja.Enabled = false;
                        //cmb_motivo.Enabled = false;

                        set_Info_CajaMovi_in_controls();
                        //opin 2017/03/24
                        txtRecibo.Visible = true;
                        txtRecibo.Properties.ReadOnly = true;
                        lblNumeroRecibo.Visible = true;
                        talonarioBus = new Caj_Talonario_Recibo_Bus();
                        if (Info_CajMovi.IdRecibo != null)
                        txtRecibo.Text = talonarioBus.Get_Num_Recibo_optenido((int)Info_CajMovi.IdRecibo, ref MensajeError);

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                        _IdTipoCbte_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr;
                        IdTipoCbteRev_EG = listParanCaja.IdTipoCbteCble_MoviCaja_Egr_Anu;
                        _IdTipoCbte = _IdTipoCbte_EG;
                        IdTipoCbteRev = IdTipoCbteRev_EG;
                        dc = "Egreso Caja ";
                        txt_observacion.Visible = true;
                        colCheck.OptionsColumn.AllowEdit = false;
                        ultraCmbE_caja.Enabled = false;
                        //cmb_motivo.Enabled = false;

                        set_Info_CajaMovi_in_controls();
                        //opin 2017/03/24
                        txtRecibo.Visible = true;
                        txtRecibo.Properties.ReadOnly = true;
                        lblNumeroRecibo.Visible = true;
                        talonarioBus = new Caj_Talonario_Recibo_Bus();
                        if (Info_CajMovi.IdRecibo != null)
                        txtRecibo.Text = talonarioBus.Get_Num_Recibo_optenido((int)Info_CajMovi.IdRecibo, ref MensajeError);
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




        public void set_Info_CajaMovi(caj_Caja_Movimiento_Info _Info_CajMovi)
        {
            try
            {

                Info_CajMovi = _Info_CajMovi;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void set_Info_CajaMovi_in_controls()
        {
            try
            {
                BindingDetalleCaja = new BindingList<vwcaj_Caja_Movimiento_det_cancelado_Info>(CajaMoviDet_Bus.Get_list_Caja_Movimiento_det_cancelado(param.IdEmpresa, Info_CajMovi.IdCbteCble, Info_CajMovi.IdTipocbte, ref  MensajeError));                                         
                this.gridEgresoCaja.DataSource = BindingDetalleCaja;
                txt_usuario.Text = Info_CajMovi.IdUsuario;

                Cl_Enumeradores.eTipoPersona TipoPersona;
                if (Info_CajMovi.IdTipo_Persona == null)
                {
                    TipoPersona = Cl_Enumeradores.eTipoPersona.PROVEE;
                }
                else
                {
                    TipoPersona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), Info_CajMovi.IdTipo_Persona);
                }


                ucGe_Beneficiario.set_Persona_beneficiario_Info(TipoPersona, Convert.ToDecimal(Info_CajMovi.IdEntidad));
                txt_responsable.Text = Info_CajMovi.ResponsableCaja;
                Info_CajMovi.IdPuntoVta = Info_CajMovi.IdPuntoVta == null ? 0 : Info_CajMovi.IdPuntoVta;
                ucFa_Sucursal_PtoVta_cmb1.set_IdPuntoVta_((int)Info_CajMovi.IdSucursal, (int)Info_CajMovi.IdPuntoVta);//opin 2017/03/24 
                dt_fechaCbte.Value = Info_CajMovi.cm_fecha;
                txt_observacion.Text = Info_CajMovi.cm_observacion;
                txe_monto.EditValue = (double)Info_CajMovi.cm_valor;


                ucBa_TipoFlujo.set_TipoFlujoInfo(Info_CajMovi.IdTipoFlujo);

                if (Info_CajMovi.Estado == "I")
                {
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    lb_Anulado.Visible = true;
                    lblCbt_TipoAnulacion.Visible = true;
                    lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + Info_CajMovi.IdCbteCble_Anu.ToString() + " Tipo Cbt.Cble de Anu.: " + Info_CajMovi.IdTipocbte_Anu.ToString();
                }                
                this.ultraCmbE_caja.EditValue = Info_CajMovi.IdCaja;
                txt_Ncomprobante.Text = Info_CajMovi.IdCbteCble.ToString();
                _IdTipoCbte = Info_CajMovi.IdTipocbte;


                this.cmb_motivo.set_MovimientoInfo(Convert.ToInt32(Info_CajMovi.IdTipoMovi));

                CajaMovi_I = Info_CajMovi;
                UC_DiarioContPago.setInfo(Info_CajMovi.IdEmpresa, Info_CajMovi.IdTipocbte, Info_CajMovi.IdCbteCble);
                UC_DiarioContPago.HabilitarGrid(true);
                



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void imprimir()
        {
            try
            {
                //XRptCaj_CajaMovimiento reprt = new XRptCaj_CajaMovimiento();
                caj_rpt_Caja_Movimiento_Info moviCaja_rpt_I = new caj_rpt_Caja_Movimiento_Info();
                moviCaja_rpt_I = CajaMovi_B.Get_Info_MovimientoCaja_Rpt(param.IdEmpresa, CajaMovi_I.IdCbteCble, CajaMovi_I.IdTipocbte, ref  MensajeError);
                moviCaja_rpt_I.Empresa = param.InfoEmpresa;


                List<caj_rpt_Caja_Movimiento_Info> lOg = new List<caj_rpt_Caja_Movimiento_Info>();
                lOg.Add(moviCaja_rpt_I);
                //reprt.loadData(lOg.ToArray(), param.IdUsuario, CajaMovi_I.Estado);
                //reprt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void validarCampos()
        {
            try
            {
                if (infoDet != null)
                {
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //   calculo();
        }

        private void FrmCa_Caja_Movimiento_Egreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_FrmCa_Caja_Movimiento_Egreso_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               

        private void toolStripButton_Imprimir_Click_1(object sender, EventArgs e)
        {

        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               
                
                vwcp_orden_pago_con_cancelacion_Info a = (vwcp_orden_pago_con_cancelacion_Info)gridView2.GetFocusedRow();
                if (a != null)
                {
                    if (e.Column == colCheck)
                    {
                        if (a.Check == true)
                        {
                            gridView2.SetFocusedRowCellValue(colCheck, false);
                            gridView2.SetFocusedRowCellValue(colValor_aplicado, 0);
                           // return;
                        }
                        else
                        {
                            gridView2.SetFocusedRowCellValue(colValor_aplicado, a.Saldo_x_Pagar_OP);
                            gridView2.SetFocusedRowCellValue(colCheck, true);
                        }

                                                 
                        txt_Ncomprobante.Focus();
                        var sacarvalor = BindingList__DetalleAprob.ToList();
                        double valort = 0;


                        valort = sacarvalor.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);
                        txe_monto.EditValue = Convert.ToDouble(valort);
                        txt_observacion.Text = a.Observacion;

                        
                    }


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
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

        void calcula_Monto()
        {
            try
            {
                  txt_Ncomprobante.Focus();
                  var sacarvalor = BindingList__DetalleAprob.ToList();
                        double valort = 0;


                        valort = sacarvalor.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);
                        txe_monto.EditValue = Convert.ToDouble(valort);
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                vwcp_orden_pago_con_cancelacion_Info a = (vwcp_orden_pago_con_cancelacion_Info)gridView2.GetFocusedRow();

                if (e.Column.Name == "colValor_aplicado")
                {

                    if (Convert.ToDouble(gridView2.GetFocusedRowCellValue(colValor_aplicado)) == 0)
                    {
                        gridView2.SetFocusedRowCellValue(colSaldo_x_Pagar_OP, a.Saldo_x_Pagar2);
                        gridView2.SetFocusedRowCellValue(colCheck, false);

  

                        calcula_Monto();

                        return;
                    }
                    else
                    {
                        if (Convert.ToDouble(gridView2.GetFocusedRowCellValue(colValor_aplicado)) > Convert.ToDouble(gridView2.GetFocusedRowCellValue(colSaldo_x_Pagar2)))
                        {
                            gridView2.SetFocusedRowCellValue(colValor_aplicado, 0);
                            gridView2.SetFocusedRowCellValue(colCheck, false);

        

                            calcula_Monto();
                            return;
                        }
                        else
                        {
                            double diferencia = 0;
                            double valor_aplica = 0;
                            double saldo = 0;

                            valor_aplica = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colValor_aplicado));
                            saldo = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colSaldo_x_Pagar2));
                            diferencia = saldo - valor_aplica;

                            gridView2.SetFocusedRowCellValue(colSaldo_x_Pagar_OP, diferencia);
                            gridView2.SetFocusedRowCellValue(colCheck, true);

                            calcula_Monto();
                        
                                               
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

        private void ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    vwcp_orden_pago_con_cancelacion_Info Info_Pago = new vwcp_orden_pago_con_cancelacion_Info();
                    orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();

                    G_persona_beneficiario_Info_obj = ucGe_Beneficiario.Get_Persona_beneficiario_Info();


                    list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion_Mayor_a_cero(param.IdEmpresa
                        , G_persona_beneficiario_Info_obj.IdTipo_Persona, G_persona_beneficiario_Info_obj.IdPersona
                        , G_persona_beneficiario_Info_obj.IdEntidad, "APRO");

                    BindingList__DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);
                    this.gridEgresoCaja.DataSource = BindingList__DetalleAprob;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      

        }

      

        private void txe_monto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }

        private void txe_monto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
    }
}
