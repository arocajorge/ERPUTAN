
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Parametros_Contables : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Config_Param_contable_Bus Bus_ParamContable = new ro_Config_Param_contable_Bus();
        ct_Plancta_Bus _PlanCtaBus = new ct_Plancta_Bus();
        ct_Centro_costo_Bus _CentroCostoBus = new ct_Centro_costo_Bus();
        BindingList<ro_Config_Param_contable_Info> lista_conf_sueldo_x_pagar = new BindingList<ro_Config_Param_contable_Info>();
        BindingList<ro_Config_Param_contable_Info> lista_conf_Provisiones = new BindingList<ro_Config_Param_contable_Info>();




        List<cp_orden_pago_tipo_Info> list_OrdenTipPago = new List<cp_orden_pago_tipo_Info>();
        List<ba_Banco_Cuenta_Info> lista_Banco = new List<ba_Banco_Cuenta_Info>();
        List<cp_orden_pago_formapago_Info> lista_FormaPago = new List<cp_orden_pago_formapago_Info>();
        List<ro_Config_Param_contable_Info> Lista_grabar = new List<ro_Config_Param_contable_Info>();
        cp_orden_pago_tipo_Bus Bus_OrdenTipPago = new cp_orden_pago_tipo_Bus();

        ba_Banco_Cuenta_Bus Bus_Banco = new ba_Banco_Cuenta_Bus();
        cp_orden_pago_formapago_Bus Bus_FormaPago = new cp_orden_pago_formapago_Bus();


        public delegate void delegate_frmRo_Parametros_Contables_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Parametros_Contables_FormClosing event_frmRo_Parametros_Contables_FormClosing;
        string MensajeError = "";
        List<ro_Nomina_Tipo_Info> lista_nomina_tipo = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus nomina_bus = new ro_Nomina_Tipo_Bus();
      
        ro_Parametros_Info info_parametro = new ro_Parametros_Info();
        ro_Parametros_Bus oRo_Parametros_Bus = new ro_Parametros_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        List<ro_Nomina_Tipoliqui_Info> lista_nomina_tipo_liq = new List<ro_Nomina_Tipoliqui_Info>();


        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

   


        BindingList<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> lista_sueldo = new BindingList<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info>();
        ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus bus_sueldo = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus();
        #endregion

        public frmRo_Parametros_Contables()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Parametros_Contables_FormClosing += frmRo_Parametros_Contables_event_frmRo_Parametros_Contables_FormClosing;

                gridControlParamContable.DataSource = lista_conf_sueldo_x_pagar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmRo_Parametros_Contables_event_frmRo_Parametros_Contables_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txt_diasConsideradoPago.Focus();
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_diasConsideradoPago.Focus();
                textBox1.Focus();
                this.gridControlParamContable.Focus();

              
                    GrabarDB();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void setInfo() 
        {
            try 
            {

                info_parametro = oRo_Parametros_Bus.Get_List_Parametros(param.IdEmpresa).FirstOrDefault();
                if (info_parametro == null)
                    return;

                if(info_parametro!=null)
                    cmbTipoDiario.set_TipoCbteCble(info_parametro.IdTipoCbte_AsientoSueldoXPagar == null ? 0 : Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar));

                txt_diasConsideradoPago.EditValue = info_parametro.Dias_considerado_ultimo_pago_quincela_Liq;
                if(info_parametro.IdTipo_mov_Ingreso!=null)
                cmb_tipoIngreso.Set_tipoMovi(Convert.ToInt32( info_parametro.IdTipo_mov_Ingreso));
                if (info_parametro.IdTipo_mov_Egreso != null)
                cmbTipoEgreso.Set_tipoMovi(Convert.ToInt32( info_parametro.IdTipo_mov_Egreso));

                if (info_parametro.IdNomina_Tipo_Para_Desc_Automat != null)
                {
                    cmbnomina.EditValue = info_parametro.IdNomina_Tipo_Para_Desc_Automat;
                }
                if (info_parametro.IdNomina_Tipo_Para_Desc_Automat != null)
                {
                    cmbnominaTipo.EditValue = info_parametro.IdNominatipoLiq_Para_Desc_Automat;
                    
                }

                //pagos a terceros

                if (info_parametro.IdBancoOP_PagoTerceros != null)
                    cmbBanco.EditValue = info_parametro.IdBancoOP_PagoTerceros;
                if (info_parametro.IdFormaOP_PagoTerceros != null)
                    cmbFormaPago.EditValue = info_parametro.IdFormaOP_PagoTerceros;
                if (info_parametro.IdTipoOP_PagoTerceros != null)
                    cmbOrdTipPag.EditValue = info_parametro.IdTipoOP_PagoTerceros;
                if (info_parametro.IdTipoFlujoOP_PagoTerceros != null)
                    ucBa_TipoFlujo.set_TipoFlujoInfo(info_parametro.IdTipoFlujoOP_PagoTerceros);

                // liquidacion de vacaciones

                if (info_parametro.IdBancoOP_LiquidacionVacaciones != null)
                    cmbBanco_Vacaciones.EditValue = info_parametro.IdBancoOP_LiquidacionVacaciones;
                if (info_parametro.IdFormaOP_LiquidacionVacaciones != null)
                    cmb_formapago_Vacaciones.EditValue = info_parametro.IdFormaOP_LiquidacionVacaciones;
                if (info_parametro.IdTipoOP_LiquidacionVacaciones != null)
                    cmb_TipoOP_Vacaciones.EditValue = info_parametro.IdTipoOP_LiquidacionVacaciones;
                if (info_parametro.IdTipoFlujoOP_LiquidacionVacaciones != null)
                    cmb_TipoFlujo_Vacaciones.set_TipoFlujoInfo(info_parametro.IdTipoFlujoOP_LiquidacionVacaciones);
                if (info_parametro.DescuentaIESS_LiquidacionVacaciones != null)
                    checkIESS.Checked =Convert.ToBoolean( info_parametro.DescuentaIESS_LiquidacionVacaciones);

                if (info_parametro.cta_contable_IESS_Vacaciones != null)
                    cmb_cuentaIESS.set_PlanCtarInfo(info_parametro.cta_contable_IESS_Vacaciones);





                //pagos a prestamos

                if (info_parametro.IdBancoOP_PagoPrestamos != null)
                    cmb_banco_prestamos.EditValue = info_parametro.IdBancoOP_PagoPrestamos;

                if (info_parametro.IdFormaOP_PagoPrestamos != null)
                    cmb_forma_pago_prestamo.EditValue = info_parametro.IdFormaOP_PagoPrestamos;

                if (info_parametro.IdTipoOP_PagoPrestamos != null)
                    cmb_tipo_pago_prestamos.EditValue = info_parametro.IdTipoOP_PagoPrestamos;

                if (info_parametro.IdTipoFlujoOP_PagoTerceros != null)
                    cmb_tipo_flujo_prestamos.set_TipoFlujoInfo(info_parametro.IdTipoFlujoOP_PagoPrestamos);




                //pagos a acta finiquito

                if (info_parametro.IdBancoOP_ActaFiniquito != null)
                    cmb_banco_ActaFiniquito.EditValue = info_parametro.IdBancoOP_ActaFiniquito;

                if (info_parametro.IdFormaPagoOP_ActaFiniquito != null)
                    cmb_forma_pago_ActaFiniquito.EditValue = info_parametro.IdFormaPagoOP_ActaFiniquito;

                if (info_parametro.IdTipoOP_ActaFiniquito != null)
                    cmb_tipoPagoActaFiniquito.EditValue = info_parametro.IdTipoOP_ActaFiniquito;

                if (info_parametro.IdTipoFlujoOP_ActaFiniquito != null)
                    cmb_tipoFlijo_ActaFiniquito.set_TipoFlujoInfo(info_parametro.IdTipoFlujoOP_ActaFiniquito);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void getInfo()
        {
            try
            { 
                if(!Validar())
                return;
                info_parametro = new ro_Parametros_Info();
                info_parametro.IdEmpresa = param.IdEmpresa;

                info_parametro.IdTipo_mov_Egreso = cmbTipoEgreso.get_TipoMovi();
                info_parametro.IdTipo_mov_Ingreso = cmb_tipoIngreso.get_TipoMovi();
                if(txt_diasConsideradoPago.EditValue!=null)
                info_parametro.Dias_considerado_ultimo_pago_quincela_Liq =Convert.ToInt32( txt_diasConsideradoPago.EditValue);
                info_parametro.IdTipoCbte_AsientoSueldoXPagar = cmbTipoDiario.get_TipoCbteCble().IdTipoCbte;
                if (cmbnomina.EditValue != null)
                    info_parametro.IdNomina_Tipo_Para_Desc_Automat =Convert.ToInt32( cmbnomina.EditValue);

                if (cmbnominaTipo.EditValue != null)
                    info_parametro.IdNominatipoLiq_Para_Desc_Automat = Convert.ToInt32(cmbnominaTipo.EditValue);

                // Pago a terceros

                if (cmbBanco.EditValue != null)
                {
                    info_parametro.GeneraraOP_PagoTerceros = true;
                    info_parametro.IdBancoOP_PagoTerceros = Convert.ToInt32(cmbBanco.EditValue);
                }
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                    info_parametro.IdTipoFlujoOP_PagoTerceros = Convert.ToInt32(ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo);
                if (cmbFormaPago.EditValue != null)
                    info_parametro.IdFormaOP_PagoTerceros = Convert.ToString(cmbFormaPago.EditValue);
                if (cmbOrdTipPag.EditValue != null)
                    info_parametro.IdTipoOP_PagoTerceros = cmbOrdTipPag.EditValue.ToString();

                // liquidacion de vacaciones

                if (cmbBanco_Vacaciones.EditValue != null)
                {
                    info_parametro.GeneraOP_LiquidacionVacaciones = true;
                    info_parametro.IdBancoOP_LiquidacionVacaciones = Convert.ToInt32(cmbBanco_Vacaciones.EditValue);
                }
                if (cmb_TipoFlujo_Vacaciones.get_TipoFlujoInfo() != null)
                    info_parametro.IdTipoFlujoOP_LiquidacionVacaciones = Convert.ToInt32(cmb_TipoFlujo_Vacaciones.get_TipoFlujoInfo().IdTipoFlujo);
                if (cmb_formapago_Vacaciones.EditValue != null)
                    info_parametro.IdFormaOP_LiquidacionVacaciones = Convert.ToString(cmb_formapago_Vacaciones.EditValue);
                if (cmb_TipoOP_Vacaciones.EditValue != null)
                    info_parametro.IdTipoOP_LiquidacionVacaciones = cmb_TipoOP_Vacaciones.EditValue.ToString();
                info_parametro.DescuentaIESS_LiquidacionVacaciones = checkIESS.Checked;

                if (cmb_cuentaIESS.get_PlanCtaInfo() != null)
                    info_parametro.cta_contable_IESS_Vacaciones = cmb_cuentaIESS.get_PlanCtaInfo().IdCtaCble;





                // Pago a prestamos

                if (cmb_banco_prestamos.EditValue != null)
                {
                    info_parametro.GeneraOP_PagoPrestamos = true;
                    info_parametro.IdBancoOP_PagoPrestamos = Convert.ToInt32(cmb_banco_prestamos.EditValue);
                }
                if (cmb_tipo_flujo_prestamos.get_TipoFlujoInfo() != null)
                    info_parametro.IdTipoFlujoOP_PagoPrestamos = Convert.ToInt32(cmb_tipo_flujo_prestamos.get_TipoFlujoInfo().IdTipoFlujo);

                if (cmb_tipo_pago_prestamos.EditValue != null)
                    info_parametro.IdTipoOP_PagoPrestamos = Convert.ToString(cmb_tipo_pago_prestamos.EditValue);

                if (cmb_forma_pago_prestamo.EditValue != null)
                    info_parametro.IdFormaOP_PagoPrestamos = cmb_forma_pago_prestamo.EditValue.ToString();





                // Pago acta finiquito

                if (cmb_banco_ActaFiniquito.EditValue != null)
                {
                    info_parametro.GeneraOP_ActaFiniquito = true;
                    info_parametro.IdBancoOP_ActaFiniquito = Convert.ToInt32(cmb_banco_ActaFiniquito.EditValue);
                }
                if (cmb_tipoFlijo_ActaFiniquito.get_TipoFlujoInfo() != null)
                    info_parametro.IdTipoFlujoOP_ActaFiniquito = Convert.ToInt32(cmb_tipoFlijo_ActaFiniquito.get_TipoFlujoInfo().IdTipoFlujo);
                if (cmb_forma_pago_ActaFiniquito.EditValue != null)
                    info_parametro.IdFormaPagoOP_ActaFiniquito = Convert.ToString(cmb_forma_pago_ActaFiniquito.EditValue);
                if (cmb_tipoPagoActaFiniquito.EditValue != null)
                    info_parametro.IdTipoOP_ActaFiniquito = cmb_tipoPagoActaFiniquito.EditValue.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void frmRo_Parametros_Contables_Load(object sender, EventArgs e)
        {
            try
            {

                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;


                lista_sueldo = new BindingList<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info>();
                gridControl_Sueldo_x_Pagar.DataSource = lista_sueldo;

                CargarGrid();


                lista_nomina_tipo = nomina_bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmb_nomina.DataSource = lista_nomina_tipo;




                cmb_nomina_tipo.DisplayMember = "DescripcionProcesoNomina";
                cmb_nomina_tipo.ValueMember = "IdNomina_TipoLiqui";



                cmbTipoEgreso.CargarCombo();
                cmb_tipoIngreso.CargarCombo();





                list_OrdenTipPago = Bus_OrdenTipPago.Get_List_orden_pago_tipo_x_Empresa(param.IdEmpresa);
                cmbOrdTipPag.Properties.DataSource = list_OrdenTipPago;
                cmb_TipoOP_Vacaciones.Properties.DataSource = list_OrdenTipPago;
                cmb_TipoOP_Vacaciones.Properties.DataSource = list_OrdenTipPago;
                cmb_tipo_pago_prestamos.Properties.DataSource = list_OrdenTipPago;
                cmb_tipoPagoActaFiniquito.Properties.DataSource = list_OrdenTipPago;
                

                lista_Banco = Bus_Banco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.Properties.DataSource = lista_Banco;
                cmbBanco_Vacaciones.Properties.DataSource = lista_Banco;
                cmb_banco_prestamos.Properties.DataSource = lista_Banco;
                cmb_banco_ActaFiniquito.Properties.DataSource = lista_Banco;




                lista_FormaPago = Bus_FormaPago.Get_List_orden_pago_formapago();
                cmbFormaPago.Properties.DataSource = lista_FormaPago;
                cmb_formapago_Vacaciones.Properties.DataSource = lista_FormaPago;
                cmb_forma_pago_prestamo.Properties.DataSource = lista_FormaPago;
                cmb_forma_pago_ActaFiniquito.Properties.DataSource = lista_FormaPago;














                
                //

                foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabControlParametros.TabPages)
                {
            
                    xtraTabControlParametros.SelectedTabPage = item;

                   
                }
                
                this.cmb_plancte_Sueldo_x_Pagar.DataSource = _PlanCtaBus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                this.cmbCentroCosto.DataSource = _CentroCostoBus.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

                //LLENA EL COMBO - 
                List<ro_Catalogo_Info> oRo_NaturalezaContable_Info = new List<ro_Catalogo_Info>();
                ro_Catalogo_Bus oRo_Catalogo_Bus = new ro_Catalogo_Bus();

                oRo_NaturalezaContable_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(34));
                cmbDebitoCreditoD.ValueMember = "CodCatalogo";
                cmbDebitoCreditoD.DisplayMember = "ca_descripcion";
                cmbDebitoCreditoD.DataSource = oRo_NaturalezaContable_Info;

                setInfo();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
                    
        void CargarGrid()
        {
            try
            {
               
                string msg = "";
                ct_Plancta_Bus bus_plaCuenta = new ct_Plancta_Bus();
                List<ct_Plancta_Info> lista_pc = new List<ct_Plancta_Info>();
                lista_pc = bus_plaCuenta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref msg);
                cmb_Cuenta_Sueldo_x_Pagar.DataSource = lista_pc;
                cmb_cte_haber_Prov.DataSource = lista_pc;

                cmb_cte_Debe_Prov.DataSource = lista_pc;

                cmb_plancte_Sueldo_x_Pagar.DataSource = lista_pc;

                lista_conf_sueldo_x_pagar =new BindingList<ro_Config_Param_contable_Info>( Bus_ParamContable.Get_List_Config_Param_contable_Sueldo_x_pagar(param.IdEmpresa));
                this.gridControlParamContable.DataSource = lista_conf_sueldo_x_pagar;
                lista_conf_Provisiones=new BindingList<ro_Config_Param_contable_Info>( Bus_ParamContable.Get_List_Config_Param_contable_Provisiones(param.IdEmpresa));
                gridControlProvisiones.DataSource = lista_conf_Provisiones;


                lista_sueldo=new BindingList<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info>( bus_sueldo.Get_List(param.IdEmpresa));

                gridControl_Sueldo_x_Pagar.DataSource = lista_sueldo;

                pu_ValidarNaturalezaCuentaContable();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_ValidarNaturalezaCuentaContable() {
            try
            {
                foreach (ro_Config_Param_contable_Info item in lista_conf_sueldo_x_pagar)
                { 
                    //VALIDA LA NATURALEZA DE LAS CUENTAS
                    if(item.DebCre==null )
                    {
                       
                        //CREDITO
                        if(item.ru_tipo=="I")
                        { 
                            item.DebCre ="C" ;

                        }
                        else if(item.ru_tipo=="E")
                        {//DEBITO
                            item.DebCre = "D";                                             
                        }
                    }  
              
                    if(item.IdCtaCble==null)
                    {
                        item.IdCtaCble = item.rub_ctacon;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private bool Validar()
        {
            try
            {bool bandera=true;


                if(cmbTipoDiario.get_TipoCbteCble()==null)
                {
                  MessageBox.Show("Seleccione Tipo Comprobante",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bandera=false;
                }

                return bandera;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                  
                Log_Error_bus.Log_Error(ex.ToString());

                return false;
            }
            }
       







     


      


       public void GrabarDB()
        {
            try
            {
                string msg = "";

                getInfo();

                Lista_grabar = new List<ro_Config_Param_contable_Info>();

                foreach (var item in lista_conf_sueldo_x_pagar)// detalle sueldo x pagar
                {
                    Lista_grabar.Add(item);

                }

                foreach (var item in lista_conf_Provisiones)// detalle de procisines
                {
                    Lista_grabar.Add(item);
                }

                foreach (var item in lista_sueldo)
                {
                    item.IdEmpresa = param.IdEmpresa;
                    if (item.Observacion == null)
                        item.Observacion = " ";
                    
                }

                if (Bus_ParamContable.GrabarParametrosContables(Lista_grabar, ref msg))
                {
                   
                    if (oRo_Parametros_Bus.GrabarBD(info_parametro, ref MensajeError))
                    {
                        if(lista_sueldo.Count()>0)
                        bus_sueldo.Grabar(lista_sueldo.ToList());
                    }
                }


                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void frmRo_Parametros_Contables_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Parametros_Contables_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

      
        private void gridView_Sueldo_x_Pagar_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

            try
            {
                ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info inf = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info();
                inf = (ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info)gridView_Sueldo_x_Pagar.GetFocusedRow();

                if (inf != null)
                {
                    lista_nomina_tipo_liq = nominatipo_Bus.Get_List_Nomina_Tipoliqui(param.IdEmpresa, inf.IdNomina); 
                    cmb_nomina_tipo.DataSource = lista_nomina_tipo_liq;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView_Sueldo_x_Pagar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    gridView_Sueldo_x_Pagar.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucBa_TipoFlujo1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
