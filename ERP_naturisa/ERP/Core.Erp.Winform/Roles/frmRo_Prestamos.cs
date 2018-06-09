using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Reportes.Roles;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Prestamos : Form
    {
        #region Declaracion Variable

       //Bus
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_Catalogo_Bus BusPrestamo_Pago = new ro_Catalogo_Bus();
        ro_rubro_tipo_Bus busRubro = new ro_rubro_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_prestamo_detalle_Bus cab_detalle = new ro_prestamo_detalle_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_prestamo_Bus cabecera_b = new ro_prestamo_Bus();
        ro_prestamo_detalle_Bus detalleBus = new ro_prestamo_detalle_Bus();
        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        //Info
         ro_prestamo_detalle_Info info_detalle = new ro_prestamo_detalle_Info();        
         ro_prestamo_Info info_prestamo = new ro_prestamo_Info();

        //List
         List<ro_prestamo_detalle_Info> detalle = new List<ro_prestamo_detalle_Info>();
         List<ro_prestamo_detalle_Info> detalleHold = new List<ro_prestamo_detalle_Info>();
         List<ro_prestamo_detalle_Info> Listdet;

         // BindingList<ro_Empleado_Novedad_Det_Info> Obj_DNovedad = new BindingList<ro_Empleado_Novedad_Det_Info>();
         BindingList<ro_prestamo_detalle_Info> DataSource = new BindingList<ro_prestamo_detalle_Info>();
         int A = 0;
         public Cl_Enumeradores.eTipo_action  Accion { get; set; }
         List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
         ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();

         ct_Cbtecble_Info Info_comprobante_Contable = new ct_Cbtecble_Info();
         List<ct_Cbtecble_det_Info> Lista_Comprobante_Contable = new List<ct_Cbtecble_det_Info>();
         ct_Cbtecble_Bus Bus_comprobante_contable = new ct_Cbtecble_Bus();


         cp_orden_pago_Bus Bus_Orden_pago = new Business.CuentasxPagar.cp_orden_pago_Bus();
         List<cp_orden_pago_det_Info> Detalle_op = new List<Info.CuentasxPagar.cp_orden_pago_det_Info>();
         cp_orden_pago_Info Info_Orden_Pago = new cp_orden_pago_Info();

         ro_Parametros_Bus bus_parametro = new ro_Parametros_Bus();
         ro_Parametros_Info info_parametro = new ro_Parametros_Info();

         cp_orden_pago_tipo_x_empresa_Bus bus_tipoOP = new cp_orden_pago_tipo_x_empresa_Bus();
         cp_orden_pago_tipo_x_empresa_Info info_tipoOP = new cp_orden_pago_tipo_x_empresa_Info();

         public delegate void delegate_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e);
         public event delegate_frmRo_Prestamos_FormClosing event_frmRo_Prestamos_FormClosing;

        #endregion

        #region variables para Préstamos
         decimal Id = 0;
         string mensaje = "";
        double saldoInicial = 0;
        double interes = 0;
        double abonoCapital = 0;
        double totalPago = 0;
        double saldo = 0;
        double cuota2 = 0;
        double tasa = 0;


        int anio = 0;
        int mes = 0;
        int dayMes = 0;
        int resul_dia = 0;
        int diaR = 0;


        DateTime fechaPago;
        DateTime fecha2;
        double monto = 0;
        int periodo = 0;

        #endregion

        public frmRo_Prestamos()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Prestamos_FormClosing += frmRo_Prestamos_event_frmRo_Prestamos_FormClosing;
                gridControlDetalle.DataSource = DataSource;

                this.dtpFechaPago.EditValue = DateTime.Now;
                this.dtpFechaReg.EditValue = DateTime.Now;
                Load_Datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

          
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void pu_Imprimir()
        {
            try
            {
                if (txtIdPrestamo.Text != "")
                {

                    XROL_Rpt005_frm oXROL_Rpt005_frm = new XROL_Rpt005_frm(param.IdEmpresa, Convert.ToInt32(txtIdPrestamo.Text));
                    oXROL_Rpt005_frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Consule el Prestamo por Favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            pu_Imprimir();
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            //Close();
            try
            {
                //if (Validar())
                //{
                //    btn_guardar_Click(sender, e);
                //    Close();                    
                //}
                if (Validar())
                {
                    if (this.ValidaGeneraPrestamo())
                    {
                        if (this.VerificaGridFechas())
                        {
                            this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                            Close();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            this.txtObservacion.Focus();
            get_Detalle();
            GetCabecera();

            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //guardar();
                        if (Validar())
                        {
                            if (this.ValidaGeneraPrestamo())
                            {
                                if (this.VerificaGridFechas())
                                {
                                    Grabar();
                                }
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (this.VerificaGridFechas())
                        {
                            Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        // Borrar();
                        Anular();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }         
        }

        void frmRo_Prestamos_event_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e){}
         
        public frmRo_Prestamos( Cl_Enumeradores.eTipo_action Numerador):this()
          {
              try
              {
                   Accion = Numerador;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
                  Log_Error_bus.Log_Error(ex.ToString());
              }
          }

        private void frmRo_Prestamos_Load(object sender, EventArgs e)
        {
            try
            {
               
                rbtNumeroCuotas.Checked = true;
                rbtValorCuota.Checked = false;
                txeTasaInteres.Text = "0";
                info_parametro = bus_parametro.Get_Parametros(param.IdEmpresa);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.btnNuevo.Enabled = false;
                        this.btnGenerar.Enabled = true;
                        this.CheckEstado.Checked = true;

                        this.txtIdPrestamo.Enabled = false;
                        //  gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                        this.gridColumnCmbEstado.OptionsColumn.AllowEdit = false;
                        this.gridColumnSaldo.OptionsColumn.AllowEdit = false;

                        // this.panel1.Enabled = false;

                        this.txtTotalPrestamo.Enabled = false;
                        this.txtTotalPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtTotalPrestamo.ForeColor = System.Drawing.Color.Black;

                        this.txtTotalCobrado.Enabled = false;
                        this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
                        this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;

                        this.txtSaldoPrestamo.Enabled = false;
                        this.txtSaldoPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtSaldoPrestamo.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        A = 2;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = true;
                        this.txtIdPrestamo.Enabled = false;

                        // bloquear_Datos_Actualizar();
                        //  gridColumnEstadoPago.OptionsColumn.AllowEdit = true;

                        this.gridColumnCmbEstado.OptionsColumn.AllowEdit = true;
                        this.gridColumnSaldo.OptionsColumn.AllowEdit = false;

                        //this.panel1.Enabled = false;

                        this.btnGenerar.Enabled = true;
                        this.btnNuevo.Enabled = true;
                        this.cmbTipoNomi.Enabled = false;
                        this.cmbEmpleados.Enabled = false;
                        this.cmbRubro.Enabled = true;
                        this.cmbAproEmpleado.Enabled = false;
                        this.txtNumCuotas.Enabled = false;
                        this.txeTasaInteres.Properties.ReadOnly = true;
                        this.cmbPeriodoPago.Enabled = true;
                        this.dtpFechaPago.Enabled = true;
                        this.dtpFechaReg.Enabled = false;
                        this.txtTotalPrestamo.Enabled = true;
                        this.txtTotalCobrado.Enabled = true;
                        this.txtSaldoPrestamo.Enabled = true;
                        txeMontoSol.Enabled = true;
                        cmbPeriodoPago.Enabled = false;
                        SETINFO();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        A = 3;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        // this.txtIdPrestamo.Enabled = false;
                        this.btnGenerar.Enabled = false;
                        this.btnNuevo.Enabled = false;

                        gridColumnFecha.OptionsColumn.AllowEdit = false;
                        gridColumnObservacion.OptionsColumn.AllowEdit = false;
                        // gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                        this.gridColumnCmbEstado.OptionsColumn.AllowEdit = false;

                        // this.panel1.Enabled = false;

                        this.txtIdPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;

                        this.cmbTipoNomi.Enabled = false;
                        this.cmbTipoNomi.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomi.ForeColor = System.Drawing.Color.Black;

                        this.cmbEmpleados.Enabled = false;
                        this.cmbEmpleados.BackColor = System.Drawing.Color.White;
                        this.cmbEmpleados.ForeColor = System.Drawing.Color.Black;

                        this.cmbRubro.Enabled = false;
                        this.cmbRubro.BackColor = System.Drawing.Color.White;
                        this.cmbRubro.ForeColor = System.Drawing.Color.Black;

                        this.cmbAproEmpleado.Enabled = false;
                        this.cmbAproEmpleado.BackColor = System.Drawing.Color.White;
                        this.cmbAproEmpleado.ForeColor = System.Drawing.Color.Black;

                        this.cmbMotivoPrest.Enabled = false;
                        this.cmbMotivoPrest.BackColor = System.Drawing.Color.White;
                        this.cmbMotivoPrest.ForeColor = System.Drawing.Color.Black;


                        this.cmbPeriodoPago.Enabled = false;
                        this.cmbPeriodoPago.BackColor = System.Drawing.Color.White;
                        this.cmbPeriodoPago.ForeColor = System.Drawing.Color.Black;

                        this.txeMontoSol.Properties.ReadOnly = true;
                        this.txeMontoSol.BackColor = System.Drawing.Color.White;

                        this.txtNumCuotas.Enabled = false;
                        this.txtNumCuotas.BackColor = System.Drawing.Color.White;
                        this.txtNumCuotas.ForeColor = System.Drawing.Color.Black;

                        this.txeTasaInteres.Properties.ReadOnly = true;
                        this.txeTasaInteres.BackColor = System.Drawing.Color.White;

                        this.txtObservacion.ReadOnly = true;
                        this.txtObservacion.BackColor = System.Drawing.Color.White;

                        this.gridViewDetalle.OptionsBehavior.Editable = false;

                        this.dtpFechaPago.Enabled = false;
                        this.dtpFechaReg.Enabled = false;

                        this.txtTotalPrestamo.Enabled = false;
                        this.txtTotalPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtTotalPrestamo.ForeColor = System.Drawing.Color.Black;

                        this.txtTotalCobrado.Enabled = false;
                        this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
                        this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;

                        this.txtSaldoPrestamo.Enabled = false;
                        this.txtSaldoPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtSaldoPrestamo.ForeColor = System.Drawing.Color.Black;

                        SETINFO();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        A = 1;
                        CheckEstado.Enabled = true;
                         rbtNumeroCuotas.Enabled=false;
                         rbtValorCuota.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        this.btnGenerar.Enabled = false;
                        this.btnNuevo.Enabled = false;

                        // this.panel1.Enabled = false;

                        this.txtIdPrestamo.Enabled = false;
                        this.txtIdPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;

                        this.cmbTipoNomi.Enabled = false;
                        this.cmbTipoNomi.BackColor = System.Drawing.Color.White;
                        this.cmbTipoNomi.ForeColor = System.Drawing.Color.Black;

                        this.cmbEmpleados.Enabled = false;
                        this.cmbEmpleados.BackColor = System.Drawing.Color.White;
                        this.cmbEmpleados.ForeColor = System.Drawing.Color.Black;

                        this.cmbRubro.Enabled = false;
                        this.cmbRubro.BackColor = System.Drawing.Color.White;
                        this.cmbRubro.ForeColor = System.Drawing.Color.Black;

                        this.cmbAproEmpleado.Enabled = false;
                        this.cmbAproEmpleado.BackColor = System.Drawing.Color.White;
                        this.cmbAproEmpleado.ForeColor = System.Drawing.Color.Black;

                        this.cmbMotivoPrest.Enabled = false;
                        this.cmbMotivoPrest.BackColor = System.Drawing.Color.White;
                        this.cmbMotivoPrest.ForeColor = System.Drawing.Color.Black;


                        this.cmbPeriodoPago.Enabled = false;
                        this.cmbPeriodoPago.BackColor = System.Drawing.Color.White;
                        this.cmbPeriodoPago.ForeColor = System.Drawing.Color.Black;

                        this.txeMontoSol.Properties.ReadOnly = true;
                        this.txeMontoSol.BackColor = System.Drawing.Color.White;

                        this.txtNumCuotas.Enabled = false;
                        this.txtNumCuotas.BackColor = System.Drawing.Color.White;
                        this.txtNumCuotas.ForeColor = System.Drawing.Color.Black;

                        this.txeTasaInteres.Properties.ReadOnly = true;
                        this.txeTasaInteres.BackColor = System.Drawing.Color.White;

                        this.txtObservacion.ReadOnly = true;
                        this.txtObservacion.BackColor = System.Drawing.Color.White;

                        this.dtpFechaPago.Enabled = false;
                        this.dtpFechaReg.Enabled = false;

                        this.gridViewDetalle.OptionsBehavior.Editable = false;

                        this.txtTotalPrestamo.Enabled = false;
                        this.txtTotalPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtTotalPrestamo.ForeColor = System.Drawing.Color.Black;

                        this.txtTotalCobrado.Enabled = false;
                        this.txtTotalCobrado.BackColor = System.Drawing.Color.White;
                        this.txtTotalCobrado.ForeColor = System.Drawing.Color.Black;

                        this.txtSaldoPrestamo.Enabled = false;
                        this.txtSaldoPrestamo.BackColor = System.Drawing.Color.White;
                        this.txtSaldoPrestamo.ForeColor = System.Drawing.Color.Black;

                        //this.gridViewDetalle.ActiveFilterEnabled = true;
                        //gridColumnFecha.OptionsColumn.AllowEdit = false;
                        //gridColumnObservacion.OptionsColumn.AllowEdit = false;
                        //gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                        //bloquear_Datos();
                        SETINFO();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                             
        }

    
        public void bloquear_Datos_Actualizar()
        {
            try
            {
                this.cmbTipoNomi.Enabled = false;
                this.cmbEmpleados.Enabled = false;    
                this.cmbRubro.Enabled = false;
                this.cmbAproEmpleado.Enabled = false;
              //  this.txeMontoSol.Enabled = false;
                this.txtNumCuotas.Enabled = false;
                this.txeTasaInteres.Enabled = false;
                this.cmbPeriodoPago.Enabled = false;
                this.dtpFechaPago.Enabled = false;
                this.dtpFechaReg.Enabled = false;
                this.btnGenerar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void Load_Datos()
        {
            try
            {
                // Cargando Combo de Tipo de Nomina
                List<ro_Nomina_Tipo_Info> InfoTipoNomina = new List<ro_Nomina_Tipo_Info>();
                InfoTipoNomina = Bus_TipoNo.Get_List_Nomina_Tipo(param.IdEmpresa);
                this.cmbTipoNomi.Properties.DataSource = InfoTipoNomina;

                // Cargando combo de Empleado
                List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
                InfoSup = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleados.Properties.DataSource = InfoSup;


                // Cargando combo de Empleado Aprobado
                //List<ro_Empleado_Info> EmpApro = new List<ro_Empleado_Info>();
                //EmpApro = BusEmpleado.Obtener_Empleados(param.IdEmpresa);
                this.cmbAproEmpleado.Properties.DataSource = InfoSup;

                //// Cargando combo de Rubros Prestamos
                //var lstRubro = busRubro.ConsultaGeneral();
                //this.cmbRubro.Properties.DataSource = lstRubro;

                // Cargando combo de Rubros Prestamos
                var lstRubro = busRubro.ConsultaRubrosPrestamo(param.IdEmpresa);
                this.cmbRubro.Properties.DataSource = lstRubro;

                // Cargando combo de Motivo Prestamo
                var lstPrestamo = BusPrestamo_Pago.Get_List_CatalogoMotivoPrestamo();
                this.cmbMotivoPrest.Properties.DataSource = lstPrestamo;

                // Cargando combo Periodo de pago
               lista_catalogo = BusPrestamo_Pago.Get_List_CatalogoTipoPago();
               this.cmbPeriodoPago.Properties.DataSource = lista_catalogo;

                // Cargando estado de pago prestamos
                var lstEstado = BusPrestamo_Pago.Get_List_CatalogoEstadoPrestamo();
                //  this.cmbEstado.DataSource = lstEstado;
                this.cmbestadoPago.DataSource = lstEstado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                         
        }
        
        public void GetCabecera()
        {
            try
            {
                info_prestamo.IdEmpresa = param.IdEmpresa;
                info_prestamo.IdNomina_Tipo = Convert.ToInt32(this.cmbTipoNomi.EditValue);
                info_prestamo.IdEmpleado = Convert.ToInt32(this.cmbEmpleados.EditValue);
                info_prestamo.IdRubro = Convert.ToString(this.cmbRubro.EditValue);
                info_prestamo.IdEmpleado_Aprueba = Convert.ToInt32(this.cmbAproEmpleado.EditValue);
                info_prestamo.IdMotivo_Prestamo = Convert.ToString(this.cmbMotivoPrest.EditValue);
                info_prestamo.Estado = CheckEstado.Checked == true ? "A" : "I";
                info_prestamo.Fecha = Convert.ToDateTime(dtpFechaReg.EditValue);
                info_prestamo.MontoSol = Convert.ToDouble(txeMontoSol.EditValue);
                info_prestamo.TasaInteres = Convert.ToDouble(txeTasaInteres.EditValue);
                info_prestamo.TotalPrestamo = Convert.ToDouble(txeMontoSol.EditValue);
                if (rbtNumeroCuotas.Checked == true)
                {
                    info_prestamo.NumCuotas = Convert.ToInt32(this.txtNumCuotas.Text);
                }
                else
                {
                    double nu_C = Convert.ToDouble(txeMontoSol.Text);
                    info_prestamo.NumCuotas = Convert.ToInt32(nu_C) / Convert.ToInt32(txtValocuota.Text);

                }
                info_prestamo.IdTipo_Pago = Convert.ToString(this.cmbPeriodoPago.EditValue);
                info_prestamo.Fecha_PriPago = Convert.ToDateTime(this.dtpFechaPago.Text);
                info_prestamo.Observacion = this.txtObservacion.Text;
                if (rbtValorCuota.Checked == true)
                {
                    info_prestamo.Tipo_Calculo = "V";
                }
                else
                {
                    info_prestamo.Tipo_Calculo = "C";


                }
                info_prestamo.IdUsuario = param.IdUsuario;
                info_prestamo.Fecha_Transac = param.Fecha_Transac;
                info_prestamo.IdUsuarioUltMod = param.IdUsuario;
                info_prestamo.Fecha_UltMod = info_prestamo.Fecha_Transac;

                info_prestamo.nom_pc = param.nom_pc;
                info_prestamo.ip = param.ip;
                info_prestamo.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);
                GetDetalle();
                info_prestamo.Detalle = DataSource.ToList(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                                  
    }
        
        public void GetDetalle()
        {
            try
            {
                Listdet = new List<ro_prestamo_detalle_Info>();

                foreach (var det in DataSource)
                {


                    det.IdPrestamo = Convert.ToDecimal(this.txtIdPrestamo.Text == "" ? "0" : this.txtIdPrestamo.Text);
                    det.IdEmpresa = param.IdEmpresa;
                    det.Estado = "A";

                    det.IdUsuario = param.IdUsuario;
                    det.Fecha_Transac = DateTime.Now;
                    det.IdUsuarioUltMod = param.IdUsuario;
                    det.Fecha_UltMod = DateTime.Now;

                    det.nom_pc = param.nom_pc;
                    det.ip = param.ip;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());                         
            }                      
        }
           
        public void calcular(int numero)
        {
            try
            {
                int meses;
                double interes;
                double monto;

                DateTime fecha;
                //fecha = System.DateTime.Today
                fecha = Convert.ToDateTime(this.dtpFechaPago.Text);
                if (rbtValorCuota.Checked == true)
                {
                    monto = Convert.ToInt32(txeMontoSol.Text) / Convert.ToInt32(txtValocuota.Text);
                }

                meses = Convert.ToInt32(this.txtNumCuotas.Text);
                monto = Convert.ToDouble(txeMontoSol.EditValue);
                interes = Convert.ToDouble(txeTasaInteres.EditValue);

                List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();

                for (int i = 1; i <= meses; i++)
                {
                    ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();

                    item.NumCuota = i;
                    item.Interes = interes;
                    item.EstadoPago = "PEN";
                    item.FechaPago = fecha;
                    item.Observacion_det = "";
                    item.Estado = "A";
                    listaDetalle.Add(item);
                    fecha = fecha.AddMonths(1);

                    //calculo dia fin mes
                    int anio = (fecha.Year);
                    int dia = (fecha.Day);
                    int mes = (fecha.Month);

                    int dayMes = System.DateTime.DaysInMonth(anio, mes);
                    //resto los dias
                    int resul_dia = dayMes - dia;
                    fecha = fecha.AddDays(resul_dia);
                    //calculo dia fin mes
                }

                DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
                this.gridControlDetalle.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }                               
        }

        public  void CalculoPrestamoConInteresMensualTalme()
        {
            try
            {
                double tasa = Convert.ToDouble(txeTasaInteres.EditValue);

                 int mesAnio = 12; // 12 meses que tiene el año
                // double tasa1 = (Convert.ToDouble(this.txtTasaInteres.Value) / periodo) / 100;
                 double tasa1 = ((Convert.ToDouble(txeTasaInteres.EditValue) / (100 * mesAnio)));

                List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();

                for (int i = 1; i <= periodo; i++)
                {                  
                 
                    double cuota = (monto * (tasa1 * (Math.Pow((1 + tasa1), periodo)) / ((Math.Pow((1 + tasa1), periodo)) - 1)));

                    

                    ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();

                    if (i == 1)
                    {                   
                        int diaPago = (fechaPago.Day);
                        int dia2 = (fecha2.Day);

                        if (dia2 >= 27)
                        {

                            anio = (fecha2.Year);
                            mes = (fecha2.Month);

                            dayMes = System.DateTime.DaysInMonth(anio, mes);
                            int resul_dia = (dayMes - dia2) + diaPago;
            
                            saldoInicial = monto;
                            interes = Math.Round((((saldoInicial * (tasa / 100)) / 360) * resul_dia), 2);
                            abonoCapital = Math.Round((cuota - interes), 2);
                            totalPago = Math.Round((interes + abonoCapital), 2);
                            saldo = Math.Round((saldoInicial - abonoCapital), 2);

                        }

                        else
                        {                          
                            int resul_dia = diaPago - dia2;

                            saldoInicial = monto;
                            interes = Math.Round((((saldoInicial * (tasa / 100)) / 360) * resul_dia), 2);
                            abonoCapital = Math.Round((cuota - interes), 2);
                            totalPago = Math.Round((interes + abonoCapital), 2);
                            saldo = Math.Round((saldoInicial - abonoCapital), 2);
                        }                                    
                    }
                    else
                    {                                              
                        if (i > 1 && i <= periodo - 1)
                        {
                                                    
                            int dia = (fechaPago.Day);
                            saldoInicial = saldo;
                            interes = Math.Round((((saldoInicial * (tasa / 100)) / 360) * dia), 2);
                            abonoCapital = Math.Round((cuota - interes), 2);
                            totalPago = Math.Round((interes + abonoCapital), 2);
                            saldo = Math.Round((saldoInicial - abonoCapital), 2);                          
                        }

                        else
                        {
                            if (i == periodo)
                            {                            
                                int dia = (fechaPago.Day);                          
                                saldoInicial = saldo;
                                interes = Math.Round((((saldoInicial * (tasa / 100)) / 360) * dia), 2);
                                abonoCapital = saldoInicial;
                                totalPago = Math.Round((interes + abonoCapital), 2);
                                saldo = Math.Round((saldoInicial - abonoCapital), 2);                             
                            }
                        }
                    }

                    item.NumCuota = i;
                    item.SaldoInicial = saldoInicial;
                    item.Interes = interes;
                    item.AbonoCapital = abonoCapital;
                    item.TotalCuota = totalPago;
                    item.Saldo = saldo;
                    item.EstadoPago = "PEN";
                    item.FechaPago = fechaPago;
                    item.Observacion_det = "";
                    item.Estado = "A";
                    item.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);

                    listaDetalle.Add(item);

                    fechaPago = fechaPago.AddMonths(1);
                    //calculo dia fin mes            
                    anio = (fechaPago.Year);
                    diaR = (fechaPago.Day);
                    mes = (fechaPago.Month);
                    dayMes = System.DateTime.DaysInMonth(anio, mes);
                    //resto los dias
                    int resul_diaR = dayMes - diaR;
                    fechaPago = fechaPago.AddDays(resul_diaR);
                    //calculo dia fin mes
                }
                DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
                this.gridControlDetalle.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }         
        }

        public  void CalculoPrestamoSinInteresMensualTalme()
      {
          try
          {
              List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();        
              for (int i = 1; i <= periodo; i++)
              {
                  ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();


                  if (rbtValorCuota.Checked == true)
                  {
                      cuota2 = Convert.ToDouble(txtValocuota.Text);
                  }
                  else
                  {
                       cuota2 = monto / periodo;
                  }
                  if (i == 1)
                  {
                      saldoInicial = monto;
                      interes = 0;
                      abonoCapital = 0;
                      totalPago = Math.Round(cuota2, 2);
                      saldo = Math.Round((saldoInicial - totalPago), 2);                    
                  }
                  else
                  {
                      if (i > 1 && i <= periodo - 1)
                      {
                          saldoInicial = Math.Round(saldo, 2);
                          interes = 0;
                          abonoCapital = 0;
                          totalPago = Math.Round(cuota2, 2);
                          saldo = Math.Round((saldoInicial - totalPago), 2);                       
                      }
                      else
                      {
                          if (i == periodo)
                          {
                              saldoInicial = Math.Round(saldo, 2);
                              interes = 0;
                              abonoCapital = 0;
                              totalPago = Math.Round(cuota2, 2);
                              saldo = Math.Round((saldoInicial - totalPago), 2);                            
                          }
                      }
                  }
                 
                  item.NumCuota = i;
                  item.SaldoInicial = saldoInicial;
                  item.Interes = interes;
                  item.AbonoCapital = abonoCapital;
                  item.TotalCuota = totalPago;
                  item.Saldo = saldo;
                  item.EstadoPago = "PEN";
                  item.FechaPago = fechaPago;
                  item.Observacion_det = "";
                  item.Estado = "A";
                  item.IdNominaTipoLiqui =Convert.ToInt32(cmbnominaTipo.EditValue);

                  fechaPago = fechaPago.AddMonths(1);
                  //calculo dia fin mes            
                  anio = (fechaPago.Year);
                  diaR = (fechaPago.Day);
                  mes = (fechaPago.Month);
                  dayMes = System.DateTime.DaysInMonth(anio, mes);
                  //resto los dias
                  int resul_diaR = dayMes - diaR;
                  fechaPago = fechaPago.AddDays(resul_diaR);
                  //calculo dia fin mes

                  if (i == periodo)
                  {
                      if (rbtValorCuota.Checked == true)
                      {
                          if (Convert.ToInt32(txeMontoSol.Text) != cuota2 * (Convert.ToInt32(txeMontoSol.Text) / Convert.ToInt32(txtValocuota.Text)))
                          {
                              item.TotalCuota = item.TotalCuota + (Convert.ToInt32(txeMontoSol.Text) - (periodo * Convert.ToInt32(txtValocuota.Text)));

                              if (saldo > 0)
                              {
                                  item.Saldo = saldoInicial - item.TotalCuota;

                              }
                          }
                      }
                  }
                  listaDetalle.Add(item);
 
              }

              DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
              this.gridControlDetalle.DataSource = DataSource;
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.ToString());
              Log_Error_bus.Log_Error(ex.ToString());
          }              
      }

        public void CalculoPrestamoSinInteres(int numero)
     {
         try
         {
             List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();
             for (int i = 1; i <= periodo; i++)
             {
                 ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();
                 //para interes = 0
                 if (rbtNumeroCuotas.Checked == true)
                 {
                     cuota2 = monto / periodo;
                 }
                 else
                 {
                     cuota2 =Convert.ToDouble( txtValocuota.Text);
                 }
                 if (i == 1)
                 {
                     saldoInicial = monto;
                     interes = 0;
                     abonoCapital = 0;
                     totalPago = Math.Round(cuota2, 2);
                     saldo = Math.Round((saldoInicial - totalPago), 2);
                 }
                 else
                 {
                     if (i > 1 && i <= periodo - 1)
                     {
                         saldoInicial = Math.Round(saldo, 2);
                         interes = 0;
                         abonoCapital = 0;
                         totalPago = Math.Round(cuota2, 2);
                         saldo = Math.Round((saldoInicial - totalPago), 2);
                     }

                     else
                     {
                         if (i == periodo)
                         {
                             saldoInicial = Math.Round(saldo, 2);
                             interes = 0;
                             abonoCapital = 0;
                             totalPago = Math.Round(cuota2, 2);
                             saldo = Math.Round((saldoInicial - totalPago), 2);

                             if (saldo <= 1)
                             {
                                 totalPago = totalPago + saldo;
                                 saldo = 0;
                             }
                             else
                             {// si el saldo es mayor ha uno

                                 i = i - 1;


                             }
                             
                         }
                     }
                 }

                 item.NumCuota = i;
                 item.SaldoInicial = saldoInicial;
                 item.Interes = interes;
                 item.AbonoCapital = abonoCapital;
                 if (saldo < 1 && saldo >0)
                 {
                     totalPago = totalPago + saldo;
                 }


                 item.TotalCuota = totalPago;
                 item.Saldo = saldo;
                 item.EstadoPago = "PEN";
                 item.FechaPago = fechaPago;
                 item.Observacion_det = "";
                 item.Estado = "A";
                 item.IdNominaTipoLiqui =Convert.ToInt32( cmbnominaTipo.EditValue);

                 listaDetalle.Add(item);
                 fechaPago = fechaPago.AddDays(numero);
              
                 if (i == periodo)
                 {
                     if (saldo < 1)
                     {
                         item.Saldo = 0;
                     }
                     else
                     {
                         periodo = periodo + 1;
                     }
                 }
             }
             DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
             this.gridControlDetalle.DataSource = DataSource;
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }
     }

        public void CalculoPrestamoConInteres(int SemQuin, int dia)
     {
         try
         {
         
             double tasa1 = (tasa / SemQuin) / 100;
             List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();

             for (int i = 1; i <= periodo; i++)
             {
                 double cuota = monto * ((tasa1 * (Math.Pow((1 + tasa1), periodo)) / ((Math.Pow((1 + tasa1), periodo)) - 1)));
                 ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();
               
                 if (i == 1)
                 {                                      
                         saldoInicial = monto;                                          
                         abonoCapital = Math.Round((cuota - interes), 2);                                                             
                 }
                 else
                 {
                     if (i > 1 && i <= periodo - 1)
                     {                        
                         saldoInicial = saldo;                        
                         abonoCapital = Math.Round((cuota - interes), 2);                                             
                     }
                     else
                     {
                         if (i == periodo)
                         {
                            saldoInicial = saldo;
                            abonoCapital = saldoInicial;                                            
                         }
                     }
                 }

                 interes = Math.Round((((saldoInicial * (tasa / 100)) / 360) * dia), 2);
                 totalPago = Math.Round((interes + abonoCapital), 2);
                 saldo = Math.Round((saldoInicial - abonoCapital), 2);  

                 item.NumCuota = i;
                 item.SaldoInicial = saldoInicial;
                 item.Interes = interes;
                 item.AbonoCapital = abonoCapital;
                 item.TotalCuota = totalPago;
                 item.Saldo = saldo;
                 item.EstadoPago = "PEN";
                 item.FechaPago = fechaPago;
                 item.Observacion_det = "";
                 item.Estado = "A";
                 item.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);

                 listaDetalle.Add(item);
                 fechaPago = fechaPago.AddDays(dia);
             }
             DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
             this.gridControlDetalle.DataSource = DataSource;
         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString());
             Log_Error_bus.Log_Error(ex.ToString());
         }
     }
        public void CalculoPrestamoSin_Beneficioss_Sociales()
        {
            try
            {
                List<ro_prestamo_detalle_Info> listaDetalle = new List<ro_prestamo_detalle_Info>();
                for (int i = 1; i <= periodo; i++)
                {
                    ro_prestamo_detalle_Info item = new ro_prestamo_detalle_Info();

                    //Carlos C.




                    if (rbtValorCuota.Checked == true)
                    {
                        cuota2 = Convert.ToDouble(txtValocuota.Text);
                    }
                    else
                    {
                        cuota2 = monto / periodo;
                    }
                    if (i == 1)
                    {
                        saldoInicial = monto;
                        interes = 0;
                        abonoCapital = 0;
                        totalPago = Math.Round(cuota2, 2);
                        saldo = Math.Round((saldoInicial - totalPago), 2);
                    }
                    else
                    {
                        if (i > 1 && i <= periodo - 1)
                        {
                            saldoInicial = Math.Round(saldo, 2);
                            interes = 0;
                            abonoCapital = 0;
                            totalPago = Math.Round(cuota2, 2);
                            saldo = Math.Round((saldoInicial - totalPago), 2);
                        }
                        else
                        {
                            if (i == periodo)
                            {
                                saldoInicial = Math.Round(saldo, 2);
                                interes = 0;
                                abonoCapital = 0;
                                totalPago = Math.Round(cuota2, 2);
                                saldo = Math.Round((saldoInicial - totalPago), 2);
                            }
                        }
                    }

                    item.NumCuota = i;
                    item.SaldoInicial = saldoInicial;
                    item.Interes = interes;
                    item.AbonoCapital = abonoCapital;
                    item.TotalCuota = totalPago;
                    item.Saldo = saldo;
                    item.EstadoPago = "PEN";
                    item.FechaPago = fechaPago;
                    item.Observacion_det = "";
                    item.Estado = "A";
                    item.IdNominaTipoLiqui = Convert.ToInt32(cmbnominaTipo.EditValue);


                    fechaPago = fechaPago.AddMonths(1);
                    anio = (fechaPago.Year);
                    diaR = (fechaPago.Day);
                    mes = (fechaPago.Month);
                    dayMes = System.DateTime.DaysInMonth(anio, mes);
                    int resul_diaR = dayMes - diaR;
                    fechaPago = fechaPago.AddDays(resul_diaR);

                    if (i == periodo)
                    {
                        if (rbtValorCuota.Checked == true)
                        {
                            if (Convert.ToInt32(txeMontoSol.Text) != cuota2 * (Convert.ToInt32(txeMontoSol.Text) / Convert.ToInt32(txtValocuota.Text)))
                            {
                                item.TotalCuota = item.TotalCuota + (Convert.ToInt32(txeMontoSol.Text) - (periodo * Convert.ToInt32(txtValocuota.Text)));

                                if (saldo > 0)
                                {
                                    item.Saldo = saldoInicial - item.TotalCuota;

                                }
                            }
                        }
                    }
                    listaDetalle.Add(item);

                }

                DataSource = new BindingList<ro_prestamo_detalle_Info>(listaDetalle);
                this.gridControlDetalle.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Grabar()
        {
            GetCabecera();
            if (info_parametro.GeneraOP_PagoPrestamos == true)
            {
                Get_OrdenPago();
                Get_Comprobante_contable();
            }
                decimal id_OP = 0;
                decimal id_detalle_OP = 0;
                string mensajeError = "";
                decimal IdCbteCble = 0;
            try
            {


                // modifico la cabecera
                if (cabecera_b.Guardar_DB(info_prestamo, ref Id, ref mensaje))
                {
                    if (detalleBus.GuardarPrestamoDetalle(info_prestamo.Detalle, ref Id, ref mensaje))
                    {
                        if (info_parametro.GeneraOP_PagoPrestamos == true)
                        {

                            if (Bus_Orden_pago.GuardaDB(Info_Orden_Pago, ref id_OP, ref mensajeError))
                            {
                                int sec = 0;
                                if (Bus_comprobante_contable.GrabarDB(Info_comprobante_Contable, ref IdCbteCble, ref mensajeError))
                                {
                                    cp_orden_pago_det_Bus detalle = new cp_orden_pago_det_Bus();

                                    foreach (var item in Info_Orden_Pago.Detalle)
                                    {
                                        item.IdOrdenPago = id_OP;
                                        item.IdEmpresa = Info_comprobante_Contable.IdEmpresa;
                                        item.IdEmpresa_cxp = param.IdEmpresa;
                                        item.IdCbteCble_cxp = IdCbteCble;
                                        item.IdTipoCbte_cxp = Info_comprobante_Contable.IdTipoCbte;

                                        if (detalle.ModificarDB(item, ref id_detalle_OP, ref mensajeError))
                                        {


                                        }

                                    }

                                }
                            }
                        }
                    }
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Desea Imprimir la Tabla de Amortizacion?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtIdPrestamo.Text =Convert.ToString( Id);
                        ucGe_Menu.Visible_bntImprimir = true;
                        pu_Imprimir();
                        Limpiar();
                    }
                    
                }
                else
                //MessageBox.Show("Error al ingresar el préstamo");
                MessageBox.Show("El registro no se pudo guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());                
           
            }

          
        }
      
        void Actualizar()
        {
            try
            {
                var listadodetalle = cab_detalle.ConsultaxIdPrestamo(param.IdEmpresa, SETINFO_.IdPrestamo);               
                    var Registro = listadodetalle.FindAll(var => var.EstadoPago == "CAN");
                    if (Registro.Count == 0)
                    {

                        get_Detalle();
                        GetCabecera();
                        info_prestamo.IdPrestamo = SETINFO_.IdPrestamo;
                        if (cabecera_b.ModificarCabeceraPrestamo(info_prestamo))
                        {

                            if (detalleBus.EliminarDetallePrestamo(detalleHold))
                            {

                                Id = info_prestamo.IdPrestamo;
                                if (detalleBus.GuardarPrestamoDetalle(info_prestamo.Detalle, ref Id, ref mensaje))
                                {
                                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                                    if (MessageBox.Show("¿Desea Imprimir la Tabla de Amortizacion?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        pu_Imprimir();
                                        Limpiar();
                                    }
                                    else
                                    {
                                        Limpiar();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un Error Al Actualizar el prestamo" + mensaje);
                                }
                            }
                        }

                    }
                    else // si existen cuotas ya canceladas
                    {

                        if (MessageBox.Show(" Existen cuotas ya canceladas, se restrucuturara la tabla de amortizacion ¿Desea Continuar?", "MODIFICACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            foreach (var item in info_prestamo.Detalle)
                            {
                                item.IdUsuarioUltMod = param.IdUsuario;
                                item.Fecha_UltMod = DateTime.Now;
                            }
                            if (detalleBus.Modificar_Cuotas_Forma_Pago(info_prestamo.Detalle))
                            {

                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Accion = Cl_Enumeradores.eTipo_action.grabar;
                                if (MessageBox.Show("¿Desea Imprimir la Tabla de Amortizacion?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    pu_Imprimir();
                                    Limpiar();
                                }
                                else
                                {
                                    Limpiar();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un Error Al Actualizar el prestamo" + mensaje);
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
                                   
        }

        void Anular()
        {
            try
            {
                get_Detalle();
                GetCabecera();                       
                if (Info != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (SETINFO_.Estado == "A")
                    {
                        var listadodetalle = cab_detalle.ConsultaxIdPrestamo(param.IdEmpresa, SETINFO_.IdPrestamo);
                         try
                         {

                         var Registro = listadodetalle.FindAll( var=> var.EstadoPago=="CAN");
                         if (Registro.Count > 0)
                           {
                             MessageBox.Show("No se puede anular el préstamo # : " + Info.IdPrestamo+". \r Existen cuotas ya canceladas");
                             return;
                           }
                         }
                         catch (Exception ex)
                         {
                             Log_Error_bus.Log_Error(ex.ToString());

                         }

                        if (MessageBox.Show("¿Está seguro que desea anular el préstamo #: " + Info.IdPrestamo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            SETINFO_.MotiAnula = oFrm.motivoAnulacion;
                            SETINFO_.IdUsuarioUltAnu = param.IdUsuario;
                            SETINFO_.Fecha_UltAnu = param.Fecha_Transac;

                            if (cabecera_b.AnularPrestamo(SETINFO_))
                            {
                                MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // checkBoxEstado.Checked = false;

                               
                                if (cab_detalle.AnularDetallePrestamo(listadodetalle, ref msg) == false)
                                {
                                    MessageBox.Show(msg);
                                    SETINFO();
                                    
                                }

                                this.Close();
                            }
                            else MessageBox.Show("No se pudo anular el préstamo #: " + Info.IdPrestamo + " debido a: "
                                + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el préstamo #: " + Info.IdNomina_Tipo, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void AnullarLineaDetalle()
        {
            
            try
            {
                if (this.txtIdPrestamo.Enabled == false && this.cmbTipoNomi.Enabled== false)
                { 

                    var Info = (ro_prestamo_detalle_Info)this.gridViewDetalle.GetFocusedRow();

                    if (Info == null)
                        MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (Info.Estado == "I")
                        MessageBox.Show("La cuota # : " + Info.NumCuota + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (Info != null)
                        {
                            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            if (Info.Estado == "A")
                            {

                                if (Info.EstadoPago == "CAN")
                                {
                                    MessageBox.Show("No se puede anular la cuota # : " + Info.NumCuota + ". \r La cuota ya fue cancelada");
                                    return;

                                }

                                if (MessageBox.Show("¿Está seguro que desea anular la cuota #: " + Info.NumCuota + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string msg = "";
                                    oFrm.ShowDialog();

                                    Info.MotiAnula = oFrm.motivoAnulacion;
                                    Info.IdUsuarioUltAnu = param.IdUsuario;
                                    Info.Fecha_UltAnu = param.Fecha_Transac;
                                    if (cab_detalle.AnularDetallePrestamo(info_prestamo.Detalle, ref mensaje))
                                    {
                                        MessageBox.Show("Anulado con éxito la cuota #: " + Info.NumCuota);


                                        SETINFO();
                                    }
                                    else MessageBox.Show("No se pudo anular la cuota #: " + Info.NumCuota + " debido a: "
                                        + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular la cuota #: " + Info.NumCuota, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }



            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        
        }        

        public ro_prestamo_detalle_Info get_Detalle()
        {
            try
            {             
                string msg = "";

                foreach (var item in DataSource)
                {
                   // InfoDetNove.Secuencia = c;
                   // c++;
                    info_detalle.IdEmpresa = param.IdEmpresa;
                   // InfoDetNove.IdNovedad = InfoCabNove.IdNovedad;
                    info_detalle.IdPrestamo = item.IdPrestamo;
                    info_detalle.NumCuota = item.NumCuota;
                    info_detalle.SaldoInicial= item.SaldoInicial;

                    info_detalle.Interes = item.Interes;
                    info_detalle.AbonoCapital = item.AbonoCapital;
                    info_detalle.TotalCuota = item.TotalCuota;

                    info_detalle.Saldo = item.Saldo;
                   // InfoDetNove.Estado = item.Estado;             
                    info_detalle.FechaPago = item.FechaPago;

                    info_detalle.EstadoPago = item.EstadoPago;
                   // InfoDetNove.Estado =item.Estado;
                    info_detalle.Observacion_det = item.Observacion_det;
                   // InfoDetNove.IdRol = (Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(cmbTipoNomina.EditValue));

                    
                }

                   return info_detalle;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return new ro_prestamo_detalle_Info();
            }
        }
           
        
        Boolean ValidaGeneraPrestamo()

        {
            try
            {

                if (this.gridViewDetalle.RowCount == 0)
                {
                    MessageBox.Show("Falta el detalle del préstamo, por favor presione el botón <GENERAR PRESTAMO>", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return false;
                     }
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }                
        }
            
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            try
            {
                fechaPago = Convert.ToDateTime(this.dtpFechaPago.Text);
                fecha2 = Convert.ToDateTime(this.dtpFechaReg.Text);
                monto = Convert.ToDouble(txeMontoSol.EditValue);
                // Carlos.C
                if (rbtValorCuota.Checked == true)
                {
                    double monto_ = Convert.ToDouble(txeMontoSol.Text);
                    periodo = Convert.ToInt32(monto_) / Convert.ToInt32(txtValocuota.Text);
                }
                else
                {
                    periodo = Convert.ToInt32(this.txtNumCuotas.EditValue);
                }
                double tasaIntres = Convert.ToDouble(txeTasaInteres.EditValue);

                tasa = Convert.ToDouble(txeTasaInteres.EditValue);

                DateTime dt1 = fechaPago;
                DateTime dt2 = fecha2;

                TimeSpan difer = dt1 - dt2;

                int dias = Convert.ToInt16(difer.Days);
                dias = 1;
                if (Validar())
                {
                    info_tipoOP = bus_tipoOP.Get_Info_orden_pago_tipo_x_empresa(param.IdEmpresa, info_parametro.IdTipoOP_LiquidacionVacaciones);


                    if (this.ValidarDetPrestamo())
                    {
                        if (dias < 0)
                        {
                            MessageBox.Show("La fecha de pago  " + fechaPago + " no puede ser menor a la fecha de registro  " + fecha2, "Sistemas");
                            return;
                        }
                        else
                        {

                            if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "BEN_SOCIAL")
                            {
                                if (tasaIntres > 0)
                                {
                                   // this.CalculoPrestamoConInteresMensualTalme();
                                }
                                else
                                {
                                    CalculoPrestamoSin_Beneficioss_Sociales();
                                }
                            }



                            if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "MEN")
                            {
                                if (tasaIntres > 0)
                                {
                                    this.CalculoPrestamoConInteresMensualTalme();
                                }
                                else
                                {
                                    this.CalculoPrestamoSinInteresMensualTalme();
                                }
                             }


                           
                                if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "QUINCE")
                                {
                                    if (tasaIntres > 0)
                                    {
                                        int SemQuin = 24;
                                        int dia = 15;
                                        this.CalculoPrestamoConInteres(SemQuin, dia);
                                    }
                                    else
                                    {

                                        switch (param.IdCliente_Ven_x_Default)
                                        {
                                            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.FJ:
                                               this.CalculoPrestamoSinInteres(30);
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.TALME:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.CAH:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA:
                                                break;
                                            case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                                break;
                                            default:
                                                this.CalculoPrestamoSinInteres(15);
                                                break;
                                        }
                                        

                                        







                                    }
                                }
                               
                                    if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "SEM")
                                    {
                                        if (tasaIntres > 0)
                                        {
                                            int SemQuin = 52;
                                            int dia = 7;
                                            this.CalculoPrestamoConInteres(SemQuin, dia);
                                        }
                                        else
                                        {
                                            int numero = 7;
                                            this.CalculoPrestamoSinInteres(numero);
                                        }
                                    }
                                
                            
                        }

                        GetDetalle();

                        this.txtNumCuotas.Enabled = false;
                        this.txeTasaInteres.Enabled = false;

                        this.cmbPeriodoPago.Enabled = false;
                        this.dtpFechaPago.Enabled = false;
                        this.dtpFechaReg.Enabled = false;

                        this.btnGenerar.Enabled = false;
                        this.btnNuevo.Enabled = true;
                        rbtNumeroCuotas.Enabled = false;
                        rbtValorCuota.Enabled = false;
                        txtNumCuotas.Enabled = false;
                        txtValocuota.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
           
        }
   

        Boolean Validar()
        {
            try
            {
                bool bandera_validar = false;

                if (info_parametro.GeneraOP_PagoPrestamos == true)
                {
                    if (info_parametro.IdFormaOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show("Faltan parametros ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                        return bandera_validar;
                    }
                    if (info_parametro.IdBancoOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                        return bandera_validar;
                    }

                    if (info_parametro.IdTipoCbte_AsientoSueldoXPagar == null)
                    {
                        MessageBox.Show("Seleccione el tipo de comprobante contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                        return bandera_validar;
                    }




                    if (info_tipoOP.IdCtaCble == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cta Credito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                        return bandera_validar;
                    }


                    if (info_parametro.IdFormaOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bandera_validar = false;
                        return bandera_validar;
                    }





                }









                if (rbtNumeroCuotas.Checked == false && rbtValorCuota.Checked == false)
                {
                    MessageBox.Show("El Tipo de Calculo de Cuotas es Obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;

                }

                if (this.cmbTipoNomi.EditValue == null)
                            
                {
                    MessageBox.Show("El Tipo de Nómina es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                
                    if (this.cmbRubro.EditValue == null)
                    {
                        MessageBox.Show("El Rubro es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    
                        if (this.cmbEmpleados.EditValue == null)
                        {
                            MessageBox.Show("El Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                        
                            if (this.cmbMotivoPrest.EditValue == null)
                            {
                                MessageBox.Show("El Motivo del Préstamo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return false;
                            }
                             if (this.txtObservacion.Text == "")
                                  {
                                      MessageBox.Show("La Observación es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                      return false;
                                  }
                                  
                                       if (Convert.ToDouble(txeMontoSol.EditValue) == 0 || txeMontoSol.EditValue == null)
                                       {
                                           MessageBox.Show("El Monto del Préstamo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                           return false;
                                       }
                                      
                                           if (this.cmbPeriodoPago.EditValue == null)
                                           {
                                               MessageBox.Show("El Período de Pago es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                               return false;
                                           }
                                            if (rbtNumeroCuotas.Checked == true)
                                               {
                                                   if (this.txtNumCuotas.Text == "0")
                                                   {
                                                       MessageBox.Show("El Número de Cuotas es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                       return false;
                                                   }
                                               }
                                                                                                if (Convert.ToDouble(txeTasaInteres.EditValue) == 0 || txeTasaInteres.EditValue == null)
                                                   if (txeTasaInteres.EditValue == null)
                                                   {
                                                       MessageBox.Show("La Tasa de Interés es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                       return false;
                                                   }
                                                  
                                                       if (this.cmbAproEmpleado.EditValue == null)
                                                       {
                                                           MessageBox.Show("El nombre de la persona para la Aprobación del Préstamo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                           return false;
                                                       }

                                                       
         
                
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }

        Boolean ValidarDetPrestamo()
        {
            try
            {
                if (Convert.ToDouble(txeMontoSol.EditValue) == 0 || txeMontoSol.EditValue == null)
                      {
                         MessageBox.Show("El Monto del Préstamo es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         return false;
                      }
                      else
                        {
                           if (this.cmbPeriodoPago.EditValue == null)
                         {
                            MessageBox.Show("El Período de Pago es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                         }
                           else 

                           {
                          
                           if (this.txtNumCuotas.Text == "0")
                           {
                               if (rbtNumeroCuotas.Checked == true)
                               {
                                   MessageBox.Show("El Número de Cuotas es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                   return false;
                               }
                            }
                           else
                           {
//                               if (Convert.ToDouble(txeTasaInteres.EditValue) == 0 || txeTasaInteres.EditValue==null)
                                   if (txeTasaInteres.EditValue == null)
                                   {
                                      MessageBox.Show("La Tasa de Interés es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                      return false;
                                   }                              
                           }
                           
                           }
                        }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }


        public ro_prestamo_Info SETINFO_ { get; set; }

        ro_prestamo_Info Info = new ro_prestamo_Info();
     
            
        void SETINFO() 
        {
            try
           {
            //this..EditValue = SETINFO_.IdProducto;
            this.txtIdPrestamo.EditValue = SETINFO_.IdPrestamo;
            this.cmbTipoNomi.EditValue = SETINFO_.IdNomina_Tipo;
            this.cmbRubro.EditValue = SETINFO_.IdRubro.TrimEnd();
            this.cmbEmpleados.EditValue = SETINFO_.IdEmpleado;
            this.cmbAproEmpleado.EditValue = SETINFO_.IdEmpleado_Aprueba;
            this.cmbMotivoPrest.EditValue = SETINFO_.Codigo;
            //this.txtNumCuotas.EditValue = SETINFO_.NumCuotas;
            txeTasaInteres.EditValue = Convert.ToDouble(SETINFO_.TasaInteres);
            this.cmbPeriodoPago.EditValue = SETINFO_.cod_pago;
            this.txtObservacion.Text = SETINFO_.Observacion;
            txeMontoSol.EditValue = Convert.ToDouble(SETINFO_.MontoSol);
            this.dtpFechaPago.EditValue = SETINFO_.Fecha_PriPago;
            this.dtpFechaReg.EditValue = SETINFO_.Fecha;
            this.CheckEstado.Checked = (SETINFO_.Estado == "A") ? true : false;

            this.txtTotalPrestamo.EditValue = SETINFO_.TotalPrestamo;
            this.txtTotalCobrado.EditValue = SETINFO_.TotalCobrado;
            this.txtSaldoPrestamo.EditValue = SETINFO_.SaldoPrestamo;
            cmbnominaTipo.EditValue = SETINFO_.IdNominaTipoLiqui;
            if (SETINFO_.Estado == "I")
            {

                this.lblAnulado.Visible = true;
               
            }
            else
            {
                this.lblAnulado.Visible = false;
            }

            if (SETINFO_.Tipo_Calculo == "C")
            {
                rbtNumeroCuotas.Checked = true;
               

            }
            else
            {
                rbtValorCuota.Checked = true;



            }
           cabecera_b.ConsultarCabeceraPrestamoxIdPrestamo(param.IdEmpresa, SETINFO_.IdPrestamo);

            detalle=cab_detalle.ConsultaxIdPrestamo(param.IdEmpresa,SETINFO_.IdPrestamo);
            detalleHold = detalle;
            double vaotC = detalle.FirstOrDefault().TotalCuota;
            if (SETINFO_.Tipo_Calculo == "V")
            {
                txtValocuota.Text =Convert.ToString( vaotC);
            }
            else
            {
                txtNumCuotas.Text = Convert.ToString(SETINFO_.NumCuotas);

            }
            DataSource = new BindingList<ro_prestamo_detalle_Info>(detalle);
                          
            this.gridControlDetalle.DataSource = DataSource;

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        Boolean flag = true; // en el caso de llamarlo de la pantalla de liquidacion de rol no limpia los combos

        public void setCabPrestamo(ro_prestamo_Info cab)
        {
            try
            {
                flag = false;
               
                cmbTipoNomi.EditValue = cab.IdNomina_Tipo;              
                cmbEmpleados.EditValue = cab.IdEmpleado;
                cmbnominaTipo.EditValue = cab.IdNominaTipoLiqui;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
      
        private void gridViewDetalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //for (int i = 0; i < gridViewDetalle.RowCount; i++)
                //{
                //    if (gridViewDetalle.GetRowCellValue(i, gridColumnFecha) == gridViewDetalle.GetRowCellValue(i-1, gridColumnFecha))
                //    {
                //        MessageBox.Show("Error de fechas", "Sistemas");
                //        return;
                //    }
                //}
                //gridViewDetalle.FocusedRowHandle = gridViewDetalle.FocusedRowHandle+1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Prestamos_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                  event_frmRo_Prestamos_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
   
        }

        private void gridViewDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {/*
                ro_prestamo_detalle_Info ROW_modificada = gridViewDetalle.GetFocusedRow() as ro_prestamo_detalle_Info;
                ro_prestamo_detalle_Info ROW2 = gridViewDetalle.GetRow(e.RowHandle - 2) as ro_prestamo_detalle_Info;
                int intervalo = 0;// ROW_modificada.FechaPago - ROW2.FechaPago;
                 int sec = 0;

                 string periodo_pago = cmbPeriodoPago.EditValue.ToString();
                 if (periodo_pago == "MEN")
                     intervalo = 30;
                 if (periodo_pago == "QUINCE")
                     intervalo = 15;
                 if (periodo_pago == "SEM")
                     intervalo = 7;

                foreach (var item in DataSource.Where(v=>v.EstadoPago=="PEN"))
                {
                    DateTime Fecha = item.FechaPago;
                    if (sec > 0)
                    {
                        item.FechaPago = Fecha.AddDays(intervalo);
                    }
                    sec++;
                }

               */

                
            }
            catch (Exception ex)
            {
              Log_Error_bus.Log_Error(ex.ToString());
            }

         
        }

        Boolean VerificaGridFechas()
        {
            try
            {
                for (int i = 0; i < gridViewDetalle.RowCount - 1; i++)
                {

                    ro_prestamo_detalle_Info info1 = (ro_prestamo_detalle_Info)gridViewDetalle.GetRow(i);

                    ro_prestamo_detalle_Info info2 = (ro_prestamo_detalle_Info)gridViewDetalle.GetRow(i + 1);

                    if (info2.FechaPago < info1.FechaPago)
                    {
                       MessageBox.Show("La fecha : " + info2.FechaPago + "  de la cuota # " + info2.NumCuota + " , no puede ser menor a la fecha de pago de la cuota  #  " + info1.NumCuota + " . Por favor ingrese una fecha válida..... ", " Sistemas");
                        return false;
                    }

                }

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
            
          }
      
        private void gridViewDetalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridViewDetalle.GetRow(e.RowHandle) as ro_prestamo_detalle_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;

                if (A == 1 || A == 3 )
                {
                    if (data.EstadoPago == "CAN")
                        e.Appearance.ForeColor = Color.Blue;
                }
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewDetalle_KeyDown(object sender, KeyEventArgs e)
        {


            try
            {
                if (A == 1)
                {

                }
                else
                {
                    if (A == 2)
                    {

                    }

                    else
                    {
                        if (e.KeyCode.ToString() == "Delete")
                        {
                            this.AnullarLineaDetalle();
                        }
                    }
                }         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());           
            }
           
        }
         
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                btnAbono.Enabled = false;
                this.txeMontoSol.Enabled = true;
                this.txtNumCuotas.Enabled = true;
                this.txeTasaInteres.Enabled = true;

                this.cmbPeriodoPago.Enabled = true;
                this.dtpFechaPago.Enabled = true;
                this.dtpFechaReg.Enabled = true;

                this.btnGenerar.Enabled = true;
                this.btnNuevo.Enabled = false;
                txtValocuota.Enabled = true;

                rbtValorCuota.Enabled = true;
                rbtNumeroCuotas.Enabled = true;
                rbtNumeroCuotas.Checked = true;
                rbtValorCuota.Checked = false;

                this.txtNumCuotas.EditValue = 0;
                this.txeTasaInteres.EditValue = 0;
                txtValocuota.EditValue = 0;
               // cambio permite modificar las cuotas de un prestamo
                this.gridControlDetalle.DataSource = null;
                if (detalle.Where(v => v.EstadoPago == "CAN" || v.EstadoPago == "ABO").Count() > 0)
                {
                    double tota_pendiente = detalle.Where(v => v.EstadoPago == "PEN").Sum(v=>v.TotalCuota);
                    txeMontoSol.Text = Convert.ToString(tota_pendiente);
                    txeMontoSol.Enabled = false;
                    DateTime Fecha_Pago = (from prod in detalle.Where(v => v.EstadoPago == "PEN") select prod.FechaPago).Min();
                    dtpFechaPago.EditValue = Fecha_Pago;
                    dtpFechaPago.Enabled = false;
                    if (SETINFO_.Tipo_Calculo=="V")
                    {
                        rbtValorCuota.Checked = true;
                    }
                    else
                    {
                        rbtNumeroCuotas.Checked = true;


                    }

                    rbtValorCuota.Enabled = false;
                    rbtNumeroCuotas.Enabled = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }

        private void gridViewDetalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (this.txtIdPrestamo.Enabled == false && this.cmbTipoNomi.Enabled == false)
                {

                    var item = (ro_prestamo_detalle_Info)gridViewDetalle.GetRow(e.FocusedRowHandle);
                 

                    if (item.EstadoPago == "CAN")
                    {

                        gridColumnFecha.OptionsColumn.AllowEdit = false;
                        gridColumnObservacion.OptionsColumn.AllowEdit = false;
                         gridColumnEstadoPago.OptionsColumn.AllowEdit = false;
                    }
                    else 
                    {

                         if (item.Estado == "I")
                        {

                        gridColumnFecha.OptionsColumn.AllowEdit = false;
                        gridColumnObservacion.OptionsColumn.AllowEdit = false;
                        gridColumnEstadoPago.OptionsColumn.AllowEdit = false;
                        }

                         else
                         {
                           gridColumnFecha.OptionsColumn.AllowEdit = true;
                           gridColumnObservacion.OptionsColumn.AllowEdit = true;
                           gridColumnEstadoPago.OptionsColumn.AllowEdit = true;
                         }                    
                    }
                }
           }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }         
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRo_Prestamos_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ucGe_Menu_event_btnSalir_Click_1(object sender, EventArgs e)
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

        private void RdbCalculosCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtNumeroCuotas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtNumeroCuotas.Checked == true )
                {
                    txtValocuota.Enabled = false;
                }
                else
                {
                    txtValocuota.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rbtValorCuota_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtValorCuota.Checked == true)
                {
                    txtNumCuotas.Enabled = false; 
                }
                else
                {
                    txtNumCuotas.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        public void Limpiar()
        {
            try
            {
                this.txtNumCuotas.Text = ""; 
                this.txeTasaInteres.Text = "";
                this.cmbPeriodoPago.EditValue=null;
                this.dtpFechaPago.EditValue=DateTime.Now;
                this.dtpFechaReg.EditValue = DateTime.Now;
                this.txtTotalPrestamo.Text = "";
                this.txtTotalCobrado.Text = "";
                this.txtSaldoPrestamo.Text = "";
                txeMontoSol.Text = "";
                txtValocuota.Text = "";
                txtObservacion.Text = "";
                dtpFechaPago.Text = "";
                txeTasaInteres.EditValue = 0;
                cmbTipoNomi.EditValue=null;
                cmbEmpleados.EditValue=null;
                cmbMotivoPrest.EditValue=null;
                cmbRubro.EditValue=null;
                cmbTipoNomi.Enabled = true;
                cmbEmpleados.Enabled = true;
                cmbMotivoPrest.Enabled = true;
                cmbRubro.Enabled = true;
                cmbAproEmpleado.Enabled = true;
                cmbAproEmpleado.EditValue=null;
                dtpFechaPago.Enabled = true;
                btnGenerar.Enabled = true;
                txtNumCuotas.Enabled = true;
                txtValocuota.Enabled = true;
                cmbPeriodoPago.Enabled = true;
                txeMontoSol.Enabled = true;
                txeTasaInteres.Enabled = true;
                rbtNumeroCuotas.Enabled = true;
                rbtValorCuota.Enabled = true;
                gridControlDetalle.DataSource = new BindingList<ro_prestamo_detalle_Info>();                 

            

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        public void Set_IdEmpleado(int IdEmpleao, int IdNomina_Tipo)
        {
            try
            {
                cmbTipoNomi.EditValue = IdNomina_Tipo;
                cmbEmpleados.EditValue = IdEmpleao;



                cmbEmpleados.Enabled = false;
                cmbTipoNomi.Enabled = false;



            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cmbEmpleados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              //  ObtenerCuotasPendientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        public void ObtenerCuotasPendientes()
        {
            try
            {
                double SaldoPrestamoAnterio = 0;
                SaldoPrestamoAnterio=  cab_detalle.SaldoPendiente(param.IdEmpresa, Convert.ToInt32(cmbEmpleados.EditValue));

                if (SaldoPrestamoAnterio > 0)
                {
                   MessageBox.Show("El empleado Tiene un valor de prestamos $"+SaldoPrestamoAnterio , "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbMotivoPrest_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Ro_Abono_Prestamos frm = new frm_Ro_Abono_Prestamos();
                frm.Show();
                frm.Cargar_Datos();
                frm.Set(SETINFO_);

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoNomi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbTipoNomi.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

                cmb_nomina_tipo_detalle.DataSource = ListadoTipoLiquidacion;
                cmb_nomina_tipo_detalle.ValueMember = "IdNomina_TipoLiqui";
                cmb_nomina_tipo_detalle.DisplayMember = "DescripcionProcesoNomina";
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPeriodoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ro_Catalogo_Info info_catalogo = new ro_Catalogo_Info();
                info_catalogo = (ro_Catalogo_Info)cmbPeriodoPago.Properties.View.GetFocusedRow();
                if (info_catalogo == null)
                    info_catalogo = lista_catalogo.Where(v => v.CodCatalogo == SETINFO_.cod_pago).FirstOrDefault();
                if (info_catalogo.CodCatalogo == "BEN_SOCIAL")
                {
                    rbtNumeroCuotas.Checked = true;
                    txtNumCuotas.EditValue = 1;
                    txtNumCuotas.Enabled = false;
                }
                else
                {
                    rbtNumeroCuotas.Checked = true;
                    txtNumCuotas.EditValue = 0;
                    txtNumCuotas.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        public void Get_OrdenPago()
        {
            try
            {
                Detalle_op = new List<cp_orden_pago_det_Info>();
                Info_Orden_Pago = new Info.CuentasxPagar.cp_orden_pago_Info();
                Info_Orden_Pago.IdEmpresa = param.IdEmpresa;
                Info_Orden_Pago.IdOrdenPago = 0;
                Info_Orden_Pago.Observacion = info_prestamo.Observacion;
                Info_Orden_Pago.IdTipo_op = info_parametro.IdTipoOP_LiquidacionVacaciones;
                Info_Orden_Pago.IdTipo_Persona = "EMPLEADO";
                Info_Orden_Pago.IdPersona = info_prestamo.IdEmpleado;
                Info_Orden_Pago.IdEntidad = info_prestamo.IdEmpleado;
                Info_Orden_Pago.Fecha =Convert.ToDateTime( dtpFechaPago.EditValue);
                Info_Orden_Pago.IdEstadoAprobacion = "PENDI";
                Info_Orden_Pago.IdFormaPago = info_parametro.IdFormaOP_LiquidacionVacaciones;
                Info_Orden_Pago.IdBanco = info_parametro.IdBancoOP_LiquidacionVacaciones;
                Info_Orden_Pago.Fecha_Pago =Convert.ToDateTime( dtpFechaPago.EditValue);
                Info_Orden_Pago.Estado = "A";
                Info_Orden_Pago.Fecha =Convert.ToDateTime( dtpFechaPago.EditValue);
                Info_Orden_Pago.IdUsuario = param.IdUsuario;
                Info_Orden_Pago.IdTipoFlujo = info_parametro.IdTipoFlujoOP_LiquidacionVacaciones;
                // detalle

                cp_orden_pago_det_Info info_detalle = new Info.CuentasxPagar.cp_orden_pago_det_Info();
                info_detalle.IdEmpresa = param.IdEmpresa;
                info_detalle.IdOrdenPago = 0;
                info_detalle.Secuencia = 1;
                info_detalle.Valor_a_pagar = Convert.ToDouble(txeMontoSol.EditValue);
                info_detalle.Referencia = "Cancelacion Vacaciones";
                info_detalle.IdFormaPago = info_parametro.IdFormaOP_LiquidacionVacaciones;
                info_detalle.Fecha_Pago =Convert.ToDateTime( dtpFechaPago.EditValue);
                info_detalle.IdEstadoAprobacion = "PENDI";
                info_detalle.Idbanco = info_parametro.IdBancoOP_LiquidacionVacaciones;
                Detalle_op.Add(info_detalle);

                Info_Orden_Pago.Detalle = Detalle_op;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void Get_Comprobante_contable()
        {
            try
            {
                Info_comprobante_Contable = new ct_Cbtecble_Info();
                Info_comprobante_Contable._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                Lista_Comprobante_Contable = new List<ct_Cbtecble_det_Info>();
                Info_comprobante_Contable.IdEmpresa = param.IdEmpresa;
                Info_comprobante_Contable.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                Info_comprobante_Contable.IdPeriodo = Convert.ToInt32(Convert.ToDateTime(dtpFechaPago.EditValue).Year.ToString() + Convert.ToDateTime(dtpFechaPago.EditValue).Month.ToString().PadLeft(2, '0'));
                Info_comprobante_Contable.cb_Fecha =Convert.ToDateTime( dtpFechaPago.EditValue);
                Info_comprobante_Contable.cb_Observacion = info_prestamo.Observacion;
                Info_comprobante_Contable.Secuencia = 0;
                Info_comprobante_Contable.cb_Valor = Convert.ToDouble(txeMontoSol.EditValue);
                Info_comprobante_Contable.Estado = "A";
                Info_comprobante_Contable.Anio = Convert.ToDateTime(dtpFechaPago.EditValue).Year;
                Info_comprobante_Contable.Mes = Convert.ToDateTime(dtpFechaPago.EditValue).Month;
                Info_comprobante_Contable.IdUsuario = param.IdUsuario;
                Info_comprobante_Contable.cb_FechaTransac = DateTime.Now;
                Info_comprobante_Contable.Mayorizado = "N";
                // detalle
                ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                haber.IdEmpresa = param.IdEmpresa;
                haber.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                haber.secuencia = 1;
                haber.IdCtaCble = info_tipoOP.IdCtaCble;
                haber.dc_Valor =Convert.ToDouble( txeMontoSol.EditValue);
                haber.dc_Observacion = info_prestamo.Observacion;
                Lista_Comprobante_Contable.Add(haber);

                
                ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                debe.IdEmpresa = param.IdEmpresa;
                debe.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                debe.secuencia = 2;
                debe.IdCtaCble = info_tipoOP.IdCtaCble_Credito;

                debe.dc_Valor = Convert.ToDouble(txeMontoSol.EditValue);

                 debe.dc_Observacion = info_prestamo.Observacion;
                Lista_Comprobante_Contable.Add(debe);

                Info_comprobante_Contable._cbteCble_det_lista_info = Lista_Comprobante_Contable;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     


    }
}
