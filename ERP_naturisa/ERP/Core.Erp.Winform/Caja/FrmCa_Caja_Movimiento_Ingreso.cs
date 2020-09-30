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
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Reportes.Contabilidad;
//DEREK MEJIA 06022014
namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_Caja_Movimiento_Ingreso : Form
    {
        #region Declaración de Variables
        public delegate void delegate_FrmCa_Caja_Movimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCa_Caja_Movimiento_FormClosing event_FrmCa_Caja_Movimiento_FormClosing;
        string idcta = "";
        BindingList<ct_Cbtecble_det_Info> listaCtaCble = new BindingList<ct_Cbtecble_det_Info>();
        BindingList<ct_Cbtecble_det_Info> BindinglistaCtaCble = new BindingList<ct_Cbtecble_det_Info>();
        ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
        ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
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
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Bus caja_B = new caj_Caja_Bus();
        caj_Caja_Info caja_I = new caj_Caja_Info();
        caj_Caja_Movimiento_Tipo_Bus caj_Caja_Movimiento_Tipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        caj_Caja_Movimiento_Tipo_Info Motivo_I = new caj_Caja_Movimiento_Tipo_Info();
        List<caj_Caja_Movimiento_Tipo_Info> caj_Caja_Movimiento_Tipo_LisI = new List<caj_Caja_Movimiento_Tipo_Info>();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        DataTable dt = new DataTable("diarioCtbl");
        caj_Caja_Movimiento_Info CajaMovi_I = new caj_Caja_Movimiento_Info();
        caj_Caja_Movimiento_Bus CajaMovi_B = new caj_Caja_Movimiento_Bus();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        //Derek 06022014
        BindingList<caj_Caja_Movimiento_det_Info> BcajaMovDetInfo = new BindingList<caj_Caja_Movimiento_det_Info>();
        List<caj_Caja_Movimiento_det_Info> LcajaMovDetInfo = new List<caj_Caja_Movimiento_det_Info>();
        fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
        List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
        caj_Caja_Movimiento_det_Info infoDet = new caj_Caja_Movimiento_det_Info();
        // Yaan Yanten 07/03/2014
        caj_parametro_Info listParanCaja = new caj_parametro_Info();
        caj_parametro_Bus cajPara = new caj_parametro_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<caj_Caja_Movimiento_det_Info> Listdet;
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;
        int _IdTipoCbte_IN = 0;
        int IdTipoCbteRev_IN = 0;
        decimal IdCbteCbleRev;
        string MensajeError = "";
        string dc = "";
        string motiAnulacion = "";

        int contadorHaber = 0;
        double[] valorHaber;

        

        public caj_Caja_Movimiento_Info Info_CajMovi { get; set; }

        List<caj_Caja_Info> List_Caja = new List<caj_Caja_Info>();
        Caj_Talonario_Recibo_Bus talonarioBus = new Caj_Talonario_Recibo_Bus();//opin 2017/03/24
        #endregion

        public FrmCa_Caja_Movimiento_Ingreso()
        {
            InitializeComponent();
          
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
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
                Grabar();
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
                        int IdTipoCbteRev = IdTipoCbteRev_IN;

                        if (CbteCble_B.ReversoCbteCble(param.IdEmpresa, Convert.ToDecimal(txt_Ncomprobante.Text), _IdTipoCbte, IdTipoCbteRev, ref IdCbteCbleRev, ref MensajeError, param.IdUsuario))
                        {
                            CajaMovi_I.MotivoAnulacion = motiAnulacion;
                            CajaMovi_I.IdUsuario_Anu = param.IdUsuario;
                            CajaMovi_I.FechaAnulacion = param.Fecha_Transac;
                            CajaMovi_I.IdTipocbte_Anu = IdTipoCbteRev;
                            CajaMovi_I.IdCbteCble_Anu = IdCbteCbleRev;

                            if (CajaMovi_B.AnularDB(CajaMovi_I, ref  MensajeError))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Movimiento de Caja ", CajaMovi_I.IdCbteCble_Anu);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                //MessageBox.Show("Movimiento de Caja Anulado Correctamente con el Comprobante de anulacion  # " + CajaMovi_I.IdCbteCble_Anu, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + CajaMovi_I.IdCbteCble_Anu.ToString() + " Tipo Cbt.Cble de Anu.: " + CajaMovi_I.IdTipocbte_Anu.ToString();
                                lb_Anulado.Visible = true;
                                lblCbt_TipoAnulacion.Visible = true;
                                ucGe_Menu.Visible_bntAnular = false;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //MessageBox.Show("No se pudo Anular el Movimiento de Caja", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                List_Caja = caja_B.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.ultraCmbE_caja.Properties.DataSource = List_Caja;

                caj_Caja_Movimiento_Tipo_LisI = caj_Caja_Movimiento_Tipo_B.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr.INGRESOS, ref  MensajeError);
                


                griddetalle.DataSource = BcajaMovDetInfo;


                tb_banco_Bus BusBanco = new tb_banco_Bus();
                cxc_cobro_tipo_Bus BustipoCxC = new cxc_cobro_tipo_Bus();
                cmbBanco.DataSource = BusBanco.Get_List_Banco();

                cmbTipo_cobro.DataSource = BustipoCxC.Get_List_Cobro_Tipo();
                //Lista_Clientes = new List<fa_Cliente_Info>(bus_cliente.Get_List_Clientes(param.IdEmpresa));
                //cmb_cliente.Properties.DataSource = Lista_Clientes;
                ucGe_Beneficiario1.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.CLIENTE, 0);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       this.event_FrmCa_Caja_Movimiento_FormClosing += new delegate_FrmCa_Caja_Movimiento_FormClosing(FrmCa_Caja_Movimiento_event_FrmCa_Caja_Movimiento_FormClosing);

                   // MotivoMovi("+");
                    dc = "Ingreso Caja ";
                    //HMRR
                  
                    //Derek06022014
                   
                    //
                    // Yaan Yanten 07/03/2014
                    caj_Caja_Movimiento_Tipo_LisI = caj_Caja_Movimiento_Tipo_B.Get_list_Caja_Movimiento_Tipo(param.IdEmpresa,Cl_Enumeradores.eTipo_Ing_Egr.INGRESOS,  ref  MensajeError);
                    _IdTipoCbte = _IdTipoCbte_IN;
                    IdTipoCbteRev = IdTipoCbteRev_IN;
                    listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                    _IdTipoCbte_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing;
                    IdTipoCbteRev_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing_Anu;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                       

                    listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                    _IdTipoCbte_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing;
                    IdTipoCbteRev_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing_Anu;
                    _IdTipoCbte = _IdTipoCbte_IN;
                    IdTipoCbteRev = IdTipoCbteRev_IN;
                    dc = "Egreso Caja ";
                    txt_Observacion.Visible = true;
                    ultraCmbE_caja.Enabled = false;
                  //  ultraCmbE_motivo.Enabled = false;

                    ucCaj_MovIngresoCaj_cmb.Perfil_Lectura();

                    set_CajaMovi();

                    //opin 2017/03/24
                    txtRecibo.Visible = true;
                    txtRecibo.Properties.ReadOnly = true;
                    lblNumeroRecibo.Visible = true;
                    talonarioBus = new Caj_Talonario_Recibo_Bus();
                        if(Info_CajMovi.IdRecibo != null)
                    txtRecibo.Text = talonarioBus.Get_Num_Recibo_optenido((int)Info_CajMovi.IdRecibo, ref MensajeError);

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        listParanCaja = cajPara.Get_Info_Parametro(param.IdEmpresa);

                    _IdTipoCbte_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing;
                    IdTipoCbteRev_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing_Anu;
                    _IdTipoCbte = _IdTipoCbte_IN;
                    IdTipoCbteRev = IdTipoCbteRev_IN;
                    dc = "Ingreso de caja ";
                    txt_Observacion.Visible = true;
                    ultraCmbE_caja.Enabled = false;
                  //  ultraCmbE_motivo.Enabled = false;
                    ucCaj_MovIngresoCaj_cmb.Perfil_Lectura();

                    set_CajaMovi();
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

                    _IdTipoCbte_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing;
                    IdTipoCbteRev_IN = listParanCaja.IdTipoCbteCble_MoviCaja_Ing_Anu;
                    _IdTipoCbte = _IdTipoCbte_IN;
                    IdTipoCbteRev = IdTipoCbteRev_IN;
                    dc = "Ingreso de caja ";
                    txt_Observacion.Visible = true;
                    ultraCmbE_caja.Enabled = false;
                  //  ultraCmbE_motivo.Enabled = false;

                    ucCaj_MovIngresoCaj_cmb.Perfil_Lectura();

                    set_CajaMovi();
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

        public List<caj_Caja_Movimiento_det_Info> getdetalle(decimal IdCbteCble, int IdTipocbte, ref string MensajeError)
        {
            try
            {
                List<caj_Caja_Movimiento_det_Info> cajDetInfo = new List<caj_Caja_Movimiento_det_Info>();
                
                int i = 0;
                foreach (var item in BcajaMovDetInfo)
                {
                                       
                    caj_Caja_Movimiento_det_Info cajDetInfo_ = new caj_Caja_Movimiento_det_Info();
                    cajDetInfo_.IdCobro_tipo = item.IdCobro_tipo;
                    cajDetInfo_.cr_Banco = item.cr_Banco;

                    cajDetInfo_.cr_fechaDocu = item.cr_fechaDocu;
                    cajDetInfo_.cr_fecha = item.cr_fecha;
                    cajDetInfo_.cr_cuenta = item.cr_cuenta;
                    cajDetInfo_.cr_NumDocumento = item.cr_NumDocumento;
                    cajDetInfo_.cr_Valor = item.cr_Valor;
                    cajDetInfo_.IdEmpresa = param.IdEmpresa;
                    cajDetInfo_.Secuencia = i + 1;
                    cajDetInfo_.IdCbteCble = IdCbteCble;
                    cajDetInfo_.IdTipocbte = IdTipocbte;                   
                    cajDetInfo.Add(cajDetInfo_);
                   
                }
                return cajDetInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<caj_Caja_Movimiento_det_Info>();
            }
        }
        
        public void CalcularTotal()
        {
            try
            {
                List<caj_Caja_Movimiento_det_Info> lista=new List<caj_Caja_Movimiento_det_Info>();
                lista = getdetalle(0, 0, ref  MensajeError);

                
                var s = (from q in lista select q.cr_Valor).Sum();
                txe_monto.EditValue = Convert.ToDouble(s);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_monto_ValueChanged(object sender, EventArgs e)
        {
           
        }
        
        public caj_Caja_Movimiento_Info  get_cajaMovi()
        {
            try
            {
               
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() !=null)
                {
                    CajaMovi_I.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }
                                          
                CajaMovi_I.cm_beneficiario = ucGe_Beneficiario1.Get_Persona_beneficiario_Info().NombreCompleto;
                CajaMovi_I.IdPersona = ucGe_Beneficiario1.Get_Persona_beneficiario_Info().IdPersona;
                CajaMovi_I.IdEntidad = ucGe_Beneficiario1.Get_Persona_beneficiario_Info().IdEntidad;
                CajaMovi_I.IdTipo_Persona = ucGe_Beneficiario1.Get_Persona_beneficiario_Info().IdTipo_Persona;
                CajaMovi_I.cm_fecha = dt_fechaCbte.Value;
                CajaMovi_I.cm_observacion = txt_Observacion.Text;
                CajaMovi_I.cm_Signo = "+";
                CajaMovi_I.cm_valor = Convert.ToDouble(txe_monto.EditValue);
                CajaMovi_I.Estado = (lb_Anulado.Visible == false) ? "A" : "I";
                CajaMovi_I.Fecha_Transac = param.Fecha_Transac;
                CajaMovi_I.Fecha_UltMod = param.Fecha_Transac;
                CajaMovi_I.FechaAnulacion = param.Fecha_Transac;
                CajaMovi_I.IdCaja = caja_I.IdCaja;
                CajaMovi_I.IdSucursal = ucFa_Sucursal_PtoVta_cmb1.get_Info_Sucursal().IdSucursal;//opin 2017/03/23
                CajaMovi_I.IdPuntoVta = ucFa_Sucursal_PtoVta_cmb1.get_Info_PuntoVta().IdPuntoVta;//opin 2017/03/23
                CajaMovi_I.IdCbteCble = (txt_Ncomprobante.Text=="")?0: Convert.ToDecimal(txt_Ncomprobante.Text);
                CajaMovi_I.CodMoviCaja = cod_CbteCble;
                CajaMovi_I.IdEmpresa = param.IdEmpresa;
                CajaMovi_I.IdPeriodo = Per_I.IdPeriodo;
                CajaMovi_I.IdTipocbte = _IdTipoCbte;
               // CajaMovi_I.IdTipoMovi = Convert.ToInt32(ultraCmbE_motivo.EditValue);


                CajaMovi_I.IdTipoMovi = ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo().IdTipoMovi;


                CajaMovi_I.IdUsuario = param.IdUsuario;
                CajaMovi_I.IdUsuario_Anu = param.IdUsuario;
                CajaMovi_I.IdUsuario_Aprueba =param.IdUsuario;
                CajaMovi_I.IdUsuarioUltMod = param.IdUsuario;
                
               
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
                CbteCble_I.cb_Fecha = dt_fechaCbte.Value;
                if(txe_monto.EditValue  != "")
                CbteCble_I.cb_Valor = Convert.ToDouble(txe_monto.EditValue);
                CbteCble_I.cb_Observacion   = "Ingreso de Caja " + txt_Observacion.Text;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dt_fechaCbte.Value.Year;
                CbteCble_I.Mes = dt_fechaCbte.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble =(txt_Ncomprobante.Text=="")?0: Convert.ToDecimal(txt_Ncomprobante.Text);

                
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    CbteCble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>(listaCtaCble);
                }
                else
                {
                    List<caj_Caja_Movimiento_det_Info> lista = new List<caj_Caja_Movimiento_det_Info>();
                    lista = getdetalle(0, 0, ref  MensajeError);

                    _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                    Debe.dc_Observacion = CbteCble_I.cb_Observacion;
                    _ListaCbteCbleDet.Add(Debe);

                    valorHaber = new double[50];
                    contadorHaber = 0;
                    foreach (var item in lista)
                    {
                        Haber = new ct_Cbtecble_det_Info();
                        valorHaber[contadorHaber] = item.cr_Valor;
                        Haber.dc_Valor_H = item.cr_Valor;
                        Haber.dc_Observacion = item.IdCobro_tipo + " " + CbteCble_I.cb_Observacion;
                        //Haber.IdCtaCble = 
                        contadorHaber++;
                        _ListaCbteCbleDet.Add(Haber);
                        
                    }
                    //_ListaCbteCbleDet.Add(Haber);

                    CbteCble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>(BindinglistaCtaCble);               
                }


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
        
        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {
           
            try
            {
                double valor;

                return _ListaCbteCbleDet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = false;

                decimal debe = 0, haber = 0;

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (this.ucFa_Sucursal_PtoVta_cmb1.get_IdSucursal() == 0)
                {
                    MessageBox.Show("Por favor, seleccione la sucursal ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucFa_Sucursal_PtoVta_cmb1.cmb_sucursal.Focus();
                    return false;
                }

                if (this.ultraCmbE_caja.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo() == null || ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo().IdTipoMovi==0)
                {
                    MessageBox.Show("Antes de continuar seleccione el Motivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucGe_Beneficiario1.Get_Persona_beneficiario_Info().IdEntidad == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione un beneficiario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (Convert.ToDouble(txe_monto.EditValue) <= 0)
                {
                    MessageBox.Show("Por favor Ingrese el Monto...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                int focus = gridView.FocusedRowHandle;
                gridView.FocusedRowHandle = focus + 1;

                foreach (var item in BcajaMovDetInfo)
                { 
                   if(item.cr_Valor==0)
                   {
                       MessageBox.Show("Ingrese el valor para el Tipo de Cobro: " + item.IdCobro_tipo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       return false;
                   }
                }

                int validaCta_convalor = 0;
               

                if (validaCta_convalor > 0)
                {
                    MessageBox.Show("No se puede grabar Comprobante,  verifique los saldos del debe y haber, que se están enviando con la cuenta contable en blanco ...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.CAJ, Convert.ToDateTime(dt_fechaCbte.Value)))
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

        private Boolean Grabar()
        {
            try
            {
                Boolean bolResult = false;
                txt_Observacion.Focus();
                CalcularTotal();
                if (validaColumna())
                {
                    string msg = "";
                    _IdTipoCbte = _IdTipoCbte_IN;
                    IdTipoCbteRev = IdTipoCbteRev_IN;
                    dc = "Ingreso Caja ";
                    get_Cbtecble();

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                      
                    
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
                                    LimpiarDatos();
                                
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                               
                            }

                     
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (CbteCble_B.ModificarDB(CbteCble_I, ref  MensajeError))
                        {
                            get_cajaMovi();
                            if (CajaMovi_B.ModificarDB(CajaMovi_I, ref  MensajeError))
                            {
                                if (CajaMoviDet_Bus.ModificarDBDetalle(getdetalle(CajaMovi_I.IdCbteCble, CajaMovi_I.IdTipocbte, ref  MensajeError), ref  MensajeError))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, dc, txt_Ncomprobante.Text);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                    //ucGe_Menu.Visible_btnGuardar = false;
                                    bolResult = true;
                                    LimpiarDatos();
                                }
                            }
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    //string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    //MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion(_Accion);
                UC_DiarioContPago.LimpiarGrid();
                CbteCble_I = new ct_Cbtecble_Info();
                listaCtaCble = new BindingList<ct_Cbtecble_det_Info>();
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                BcajaMovDetInfo = new BindingList<caj_Caja_Movimiento_det_Info>();
                CajaMovi_I = new caj_Caja_Movimiento_Info();
                Info_CajMovi = new caj_Caja_Movimiento_Info();
                griddetalle.DataSource = BcajaMovDetInfo;

                 ucBa_TipoFlujo.Inicializar_TipoFlujo();          
                //cmb_cliente.EditValue = null;                
                 ucGe_Beneficiario1.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.CLIENTE, 0);
                txt_Observacion.Text = "";                
                txe_monto.EditValue = "";
                txt_Ncomprobante.Text = "";
                //opin 2017/03/27
                ucCaj_MovIngresoCaj_cmb.Inicializar_cmb_comprador();
                
                txtRecibo.Visible = false;
                lblNumeroRecibo.Visible = false;
                ucFa_Sucursal_PtoVta_cmb1.InicializarPtoVta();
                ucFa_Sucursal_PtoVta_cmb1.InicializarSucursal();
                ultraCmbE_caja.EditValue = null;
                txt_responsable.Text = string.Empty;
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
                int contador = 1;
                foreach (var item in BcajaMovDetInfo)
                {
                    caj_Caja_Movimiento_det_Info info_det = new caj_Caja_Movimiento_det_Info();
                

               
                    info_det.IdEmpresa = param.IdEmpresa;
                    info_det.IdOrdenPago = null;
                    info_det.cr_Valor = item.cr_Valor;
                    info_det.Secuencia = contador;
                    info_det.IdTipocbte = _IdTipoCbte;
                    info_det.IdCobro_tipo = item.IdCobro_tipo;
                    info_det.cr_fecha = dt_fechaCbte.Value;
                    info_det.cr_Banco = item.cr_Banco;
                    info_det.cr_cuenta = item.cr_cuenta;
                    info_det.cr_fechaDocu = item.cr_fecha;
                    info_det.cr_NumDocumento = item.cr_NumDocumento;
                    info_det.IdCbteCble = CajaMovi_I.IdCbteCble;
                    info_det.IdTipocbte = CajaMovi_I.IdTipocbte;
                    info_det.IdEmpresa_OP = item.IdEmpresa;

                    Listdet.Add(info_det);
                    contador = contador + 1;
                }

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

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        txt_usuario.Text = param.IdUsuario;
                    

                        ucGe_Menu.Visible_bntAnular = false;
                        colcr_Banco.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo.OptionsColumn.AllowEdit = true;
                        colcr_fecha.OptionsColumn.AllowEdit = true;
                        colcr_cuenta.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                        colcr_Valor.OptionsColumn.AllowEdit = true;
                        ucGe_Beneficiario1.Enabled = true;
                       

                        txe_monto.Properties.ReadOnly = true;
                        ultraCmbE_caja.Enabled = true;
                       // ultraCmbE_motivo.Enabled = true;

                      //  ucCaj_MovIngresoCaj_cmb.Perfil_Lectura();

                        ucGe_Menu.Visible_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        colcr_Banco.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo.OptionsColumn.AllowEdit = false;
                        colcr_fecha.OptionsColumn.AllowEdit = false;
                        colcr_cuenta.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                        //colcr_Valor.OptionsColumn.AllowEdit = false;
                        dt_fechaCbte.Enabled = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Beneficiario1.Enabled = false;
                        //txe_monto.Properties.ReadOnly = true;

                        

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ultraCmbE_caja.Enabled = false;
                      //  ultraCmbE_motivo.Enabled = false;

                        ucCaj_MovIngresoCaj_cmb.Perfil_Lectura();

                        ucGe_Beneficiario1.Enabled = false;
                        txe_monto.Properties.ReadOnly = true;
                        dt_fechaCbte.Enabled = false;
                        colcr_Banco.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo.OptionsColumn.AllowEdit = false;
                        colcr_fecha.OptionsColumn.AllowEdit = false;
                        colcr_cuenta.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                        colcr_Valor.OptionsColumn.AllowEdit = false;
                        ucGe_Beneficiario1.Enabled = false;
                    
                        ucGe_Menu.Visible_bntImprimir = false;

                        ucBa_TipoFlujo.ReadOnly(true);
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        txe_monto.Properties.ReadOnly = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        colcr_Banco.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo.OptionsColumn.AllowEdit = false;
                        colcr_fecha.OptionsColumn.AllowEdit = false;
                        colcr_cuenta.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                        colcr_Valor.OptionsColumn.AllowEdit = false;
                        ucGe_Beneficiario1.Enabled = false;
                        ucBa_TipoFlujo.ReadOnly(true);
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

        caj_Caja_Movimiento_det_Bus CajaMoviDet_Bus = new caj_Caja_Movimiento_det_Bus();
        public void set_CajaMovi()
        {
            try
            {
                BcajaMovDetInfo = new BindingList<caj_Caja_Movimiento_det_Info>(CajaMoviDet_Bus.Get_listDetalle(param.IdEmpresa, Info_CajMovi.IdCbteCble, Info_CajMovi.IdTipocbte, ref  MensajeError));

                griddetalle.DataSource = BcajaMovDetInfo;
                calculo();

                txt_usuario.Text = Info_CajMovi.IdUsuario;
                dt_fechaCbte.Value = Info_CajMovi.cm_fecha;

                if (Info_CajMovi.IdTipo_Persona != null)
                {
                    Cl_Enumeradores.eTipoPersona ETipo_Persona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), Info_CajMovi.IdTipo_Persona);

                    ucGe_Beneficiario1.set_Persona_beneficiario_Info(ETipo_Persona, Convert.ToDecimal(Info_CajMovi.IdEntidad));
                }


                txt_Observacion.Text = Info_CajMovi.cm_observacion;
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
                ultraCmbE_caja.EditValue = Info_CajMovi.IdCaja;
              //  ultraCmbE_motivo.EditValue = Info_CajMovi.IdTipoMovi;

                ucCaj_MovIngresoCaj_cmb .set_MovimientoInfo(Info_CajMovi.IdTipoMovi);

                txt_Ncomprobante.Text = Info_CajMovi.IdCbteCble.ToString();
                _IdTipoCbte = Info_CajMovi.IdTipocbte;
               // MotivoMovi("+");
                CajaMovi_I = Info_CajMovi;
                UC_DiarioContPago.setInfo(Info_CajMovi.IdEmpresa, Info_CajMovi.IdTipocbte, Info_CajMovi.IdCbteCble);
                UC_DiarioContPago.HabilitarGrid(true);
                listaCtaCble = UC_DiarioContPago.Get_BindingList_Cbtecble_det();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ultraGrid_diario_Validating(object sender, CancelEventArgs e)
        {
          
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
        
        private void FrmCa_Caja_Movimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_FrmCa_Caja_Movimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                caj_Caja_Movimiento_det_Info row = (caj_Caja_Movimiento_det_Info)gridView.GetRow(e.RowHandle);
                txe_monto.Text = BcajaMovDetInfo.Sum(v => v.cr_Valor).ToString();

                if (row.cr_Valor < 0)
                {
                    MessageBox.Show("No se permiten valores negativos", param.Nombre_sistema);
                    gridView.SetFocusedRowCellValue(colcr_Valor, 0);
                    generaDiario();
                    return;
                }
                else
                {
                    generaDiario();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //DEREK MEJIA 06022014
        public void calculo()
        {
            try
            {
                txtEfectivo.EditValue = 0;
                txtCheque.EditValue = 0;
                txtDeposito.EditValue = 0;
                txtOtros.EditValue = 0;
                txtCobrado.EditValue = 0;
                foreach (var item in BcajaMovDetInfo)
                {
                    if (item.IdCobro_tipo == "EFEC")
                    {
                        txtEfectivo.EditValue = Convert.ToDecimal(txtEfectivo.EditValue) + Convert.ToDecimal(item.cr_Valor);
                    }
                    else
                    {
                        if (item.IdCobro_tipo == "TARJ" || item.IdCobro_tipo == "CHQF" || item.IdCobro_tipo == "CHQV")
                        {
                            txtCheque.EditValue = Convert.ToDecimal(txtCheque.EditValue) + Convert.ToDecimal(item.cr_Valor);
                        }
                        else
                        {
                            if (item.IdCobro_tipo == "DEPO")
                            {
                                txtDeposito.EditValue = Convert.ToDecimal(txtDeposito.EditValue) + Convert.ToDecimal(item.cr_Valor);
                            }
                            else
                            {
                                if (item.IdCobro_tipo != "TARJ" && item.IdCobro_tipo != "CHQF" && item.IdCobro_tipo != "CHQV" && item.IdCobro_tipo != "EFEC" && item.IdCobro_tipo != "DEPO")
                                {
                                    txtOtros.EditValue = Convert.ToDecimal(txtOtros.EditValue) + Convert.ToDecimal(item.cr_Valor);
                                }
                            }
                        }
                    }
                }
                txtCobrado.EditValue = Convert.ToDecimal(txtEfectivo.EditValue) + Convert.ToDecimal(txtCheque.EditValue) + Convert.ToDecimal(txtDeposito.EditValue) + Convert.ToDecimal(txtOtros.EditValue);
                txtEfectivo.EditValue = "$" + " " + Convert.ToString(txtEfectivo.EditValue);
                txtCheque.EditValue = "$" + " " + Convert.ToString(txtCheque.EditValue);
                txtDeposito.EditValue = "$" + " " + Convert.ToString(txtDeposito.EditValue);
                txtOtros.EditValue = "$" + " " + Convert.ToString(txtOtros.EditValue);
                txtCobrado.EditValue = "$" + " " + Convert.ToString(txtCobrado.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (_Accion != Cl_Enumeradores.eTipo_action.consultar)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            infoDet = new caj_Caja_Movimiento_det_Info();
                            infoDet = gridView.GetFocusedRow() as caj_Caja_Movimiento_det_Info;
                            CajaMoviDet_Bus.EliminarRegistroDetalle(infoDet, ref  MensajeError);
                            gridView.DeleteSelectedRows();
                            LcajaMovDetInfo = new List<caj_Caja_Movimiento_det_Info>();
                            var r = (BindingList<caj_Caja_Movimiento_det_Info>)gridView.DataSource;
                            LcajaMovDetInfo = new List<caj_Caja_Movimiento_det_Info>(r);
                            int secuencia = 1;
                            foreach (var item in LcajaMovDetInfo)
                            {
                                item.Secuencia = secuencia;
                                secuencia++;
                            }
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

        void validarCampos()
        {
            try
            {
                if (infoDet != null)
                {
                    if (infoDet.IdCobro_tipo == "EFEC")
                    {
                        colcr_Banco.OptionsColumn.AllowEdit = false;
                        colcr_cuenta.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;                        
                    }
                    else
                    {
                        colcr_Banco.OptionsColumn.AllowEdit = true;
                        colcr_cuenta.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = true;                    
                    }
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
            try
            {
               calculo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ultraCmbE_caja_SelectionChanged(object sender, EventArgs e)
        {

        }
     
        private void generaDiario()
        {
            try
            {
                //_ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
               // caj_Caja_Movimiento_Tipo_Info Motivo_I = (caj_Caja_Movimiento_Tipo_Info)ultraCmbE_motivo.Properties.View.GetFocusedRow();
                get_Cbtecble();
                if (_ListaCbteCbleDet.Count > 0)
                {
                    _ListaCbteCbleDet[0].IdEmpresa = param.IdEmpresa;
                    _ListaCbteCbleDet[0].IdTipoCbte = _IdTipoCbte_IN;
                    _ListaCbteCbleDet[0].IdCtaCble = caja_I.IdCtaCble;
                    if (txe_monto.EditValue != "")
                    _ListaCbteCbleDet[0].dc_Valor = Convert.ToDouble(txe_monto.EditValue);

                    for (int i = 1; i < _ListaCbteCbleDet.Count; i++)
                    {
                        _ListaCbteCbleDet[i].IdEmpresa = param.IdEmpresa;
                        _ListaCbteCbleDet[i].IdTipoCbte = _IdTipoCbte_IN;
                        _ListaCbteCbleDet[i].IdCtaCble = ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo().IdCtaCble;
                        _ListaCbteCbleDet[i].dc_Valor = valorHaber[i - 1] * -1;
                    }
                    //Haber.IdEmpresa = param.IdEmpresa;
                    //Haber.IdTipoCbte = _IdTipoCbte_IN;

                    //Haber.IdCtaCble = ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo().IdCtaCble;
                    //Haber.dc_Valor = Convert.ToDouble(txe_monto.EditValue) * -1;

                    //Haber.IdCtaCble = Motivo_I.IdCtaCble;
                    //_ListaCbteCbleDet.Add(Debe);
                    //_ListaCbteCbleDet.Add(Haber);

                    UC_DiarioContPago.setDetalle(_ListaCbteCbleDet);
                    BindinglistaCtaCble = new BindingList<ct_Cbtecble_det_Info>(_ListaCbteCbleDet);
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmbE_caja_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (this.ultraCmbE_caja.EditValue != null)
                {

                    caja_I = List_Caja.FirstOrDefault(v => v.IdCaja == Convert.ToInt32(ultraCmbE_caja.EditValue));

                    if (caja_I != null)
                    {
                        txt_responsable.Text = caja_I.N_usuarioResponsable;
                        ucFa_Sucursal_PtoVta_cmb1.set_Idsucursal((int)caja_I.IdSucursal);
                        if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
                        {
                            generaDiario();    
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

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colcr_Valor")
                    CalcularTotal();

                calculo();
                infoDet = new caj_Caja_Movimiento_det_Info();
                infoDet = gridView.GetFocusedRow() as caj_Caja_Movimiento_det_Info;
                validarCampos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCaj_MovIngresoCaj_cmb_event_cmb_CajMovIngreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCaj_MovIngresoCaj_cmb.get_MovimientoInfo() != null)
                {
                    if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
                    {
                        generaDiario();    
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Observacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucGe_Beneficiario1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void ucBa_TipoFlujo_Load(object sender, EventArgs e)
        {

        }

        private void txe_monto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucCaj_MovIngresoCaj_cmb_Load(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_DatosCaja_Enter(object sender, EventArgs e)
        {

        }
    }
}
