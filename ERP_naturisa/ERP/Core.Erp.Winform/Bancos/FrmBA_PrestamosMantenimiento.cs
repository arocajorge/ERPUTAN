using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Winform.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using System.Threading;
using DevExpress.XtraSplashScreen;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_PrestamosMantenimiento : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public FrmBA_PrestamosMantenimiento()
        {
            try
            {
                InitializeComponent();
                gridControlDetalle.DataSource = lista_detalle_prestamo;

                this.dtpFechaPago.EditValue = DateTime.Now;
                this.dtpFechaReg.EditValue = DateTime.Now;
                event_frmRo_Prestamos_FormClosing += FrmBA_PrestamosMantenimiento_event_frmRo_Prestamos_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void FrmBA_PrestamosMantenimiento_event_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        #region Declaracion Variable
        BindingList<ba_prestamo_detalle_Info> lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>();

        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        ro_Nomina_Tipo_Bus Bus_TipoNo = new ro_Nomina_Tipo_Bus();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ba_prestamo_Bus prestamo_Infoecera_b = new ba_prestamo_Bus();
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        List<ba_Catalogo_Info> ListaTempo = new List<ba_Catalogo_Info>();
        public ba_prestamo_Info SETINFO_ { get; set; }
        ba_prestamo_Info prestamo_Info = new ba_prestamo_Info();
        List<ba_prestamo_detalle_Info> estados = new List<ba_prestamo_detalle_Info>();
        string mensaje = "";
        Boolean mostrarmensaje = false;
        BindingList<ba_prestamo_detalle_Info> estado = new BindingList<ba_prestamo_detalle_Info>();
        ba_prestamo_detalle_Bus bus_PrestamoDet = new ba_prestamo_detalle_Bus();
        ba_Catalogo_Bus BusPrestamo_Pago = new ba_Catalogo_Bus();

        ba_Banco_Cuenta_Bus busCtaBanc = new ba_Banco_Cuenta_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ba_prestamo_detalle_Bus prestamo_detalle_Bus = new ba_prestamo_detalle_Bus();

       ba_prestamo_detalle_Info prestamo_detalle_info = new ba_prestamo_detalle_Info();

       Af_Activo_fijo_Info activo_fijo_info = new Af_Activo_fijo_Info();
       ba_prestamo_Info Infoprestamo_InfoNove = new ba_prestamo_Info();

       List<Af_Activo_fijo_Info> lista_Activos_fijos = new List<Af_Activo_fijo_Info>();
       Af_Activo_fijo_Bus Activo_Fijo_Bus = new Af_Activo_fijo_Bus();
       BindingList<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> lista_activos_prendados = new BindingList<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info>();
       ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus Activos_Prendados_Bus = new ba_prestamo_detalle_x_af_activo_fijo_Prendados_Bus();


        #endregion

        #region
       int A = 0;
     
        double tasa = 0;
        DateTime fechaPago;
        DateTime fecha2;
        double monto = 0;
        int periodo = 0;
        double valor_cancelado_x_activo = 0;
        int id_activo = 0;
        double tota_valor_compra = 0;
        int tota_activos = 0;
        double tota_cancelado = 0;
        double total_pendiente = 0;
        #endregion

      


          public FrmBA_PrestamosMantenimiento(Cl_Enumeradores.eTipo_action Numerador)
              : this()
          {
              try
              {
                 enu = Numerador;
              }
              catch (Exception ex)
              {
                  string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              }
 


          }

          private void frmBA_Prestamos_Load(object sender, EventArgs e)
          {
              try
              {
                  gridControl_Activos_Prendados.DataSource = lista_activos_prendados;
                  cmb_cliente.Cargar_combos();

                 // Load_Datos();
                  switch (enu)
                  {
                      case Cl_Enumeradores.eTipo_action.grabar:

                          this.btnNuevo.Enabled = false;
                          this.btnGenerar.Enabled = true;
                          btnCuotas.Visible = false;
                          this.txtIdPrestamo.Enabled = false;
                          //  gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                          this.gridColumnCmbEstado.OptionsColumn.AllowEdit = false;
                          this.gridColumnSaldo.OptionsColumn.AllowEdit = false;

                          // this.panel1.Enabled = false;


                          break;
                      case Cl_Enumeradores.eTipo_action.actualizar:

                          A = 2;
                          btn_guardar.Text = "Actualizar";
                          btnGuardarSalir.Text = "Actualizar y Salir";
                          this.txtIdPrestamo.Enabled = false;

                          this.gridColumnCmbEstado.OptionsColumn.AllowEdit = true;
                          this.gridColumnSaldo.OptionsColumn.AllowEdit = false;

                          this.btnGenerar.Enabled = false;

                          this.btnNuevo.Enabled = false;
                          this.txtIdPrestamo.BackColor = System.Drawing.Color.White;
                          this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;

                          this.txeMontoSol.Properties.ReadOnly = true;
                          this.txeMontoSol.BackColor = System.Drawing.Color.White;

                          this.txtNumCuotas.Enabled = false;
                          this.txtNumCuotas.BackColor = System.Drawing.Color.White;
                          this.txtNumCuotas.ForeColor = System.Drawing.Color.Black;

                          txeInteres.Properties.ReadOnly = true;
                          txeInteres.BackColor = System.Drawing.Color.White;

                          this.cmbPeriodoPago.Enabled = false;
                          this.cmbPeriodoPago.BackColor = System.Drawing.Color.White;
                          this.cmbPeriodoPago.ForeColor = System.Drawing.Color.Black;


                          this.dtpFechaPago.Enabled = false;
                          this.dtpFechaReg.Enabled = false;



                          set();
                          break;
                      case Cl_Enumeradores.eTipo_action.Anular:

                          A = 3;
                          btn_guardar.Text = "Anular";
                          // this.txtIdPrestamo.Enabled = false;
                          this.btnGenerar.Enabled = false;
                          this.btnGuardarSalir.Visible = false;
                          this.btnNuevo.Enabled = false;
                          btnCuotas.Visible = false;
                          gridColumnFecha.OptionsColumn.AllowEdit = false;
                          gridColumnObservacion.OptionsColumn.AllowEdit = false;
                          // gridColumnEstadoPago.OptionsColumn.AllowEdit = false;

                          this.gridColumnCmbEstado.OptionsColumn.AllowEdit = false;

                          // this.panel1.Enabled = false;

                          this.txtIdPrestamo.Enabled = false;
                          this.txtIdPrestamo.BackColor = System.Drawing.Color.White;
                          this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;

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

                          txeInteres.Properties.ReadOnly = true;
                          txeInteres.BackColor = System.Drawing.Color.White;

                          this.txtObservacion.ReadOnly = true;
                          this.txtObservacion.BackColor = System.Drawing.Color.White;

                          this.gridViewDetalle.OptionsBehavior.Editable = false;

                          this.dtpFechaPago.Enabled = false;
                          this.dtpFechaReg.Enabled = false;

                          ucCon_PlanCtaCmb.Perfil_Lectura();


                          set();
                          break;
                      case Cl_Enumeradores.eTipo_action.consultar:

                          A = 1;
                          // this.lblAnulado.Visible = true;
                          //this.txtIdPrestamo.Enabled = false;
                          this.btn_guardar.Visible = false;
                          this.btnGuardarSalir.Visible = false;
                          this.btnGenerar.Enabled = false;
                          this.btnNuevo.Enabled = false;

                          txtCodPrestamo.Properties.ReadOnly = true;
                          cmbBanco.Properties.ReadOnly = true;
                          btnCuotas.Visible = false;
                          // this.panel1.Enabled = false;

                          this.txtIdPrestamo.Enabled = false;
                          this.txtIdPrestamo.BackColor = System.Drawing.Color.White;
                          this.txtIdPrestamo.ForeColor = System.Drawing.Color.Black;

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

                          txeInteres.Properties.ReadOnly = true;
                          txeInteres.BackColor = System.Drawing.Color.White;

                          this.txtObservacion.ReadOnly = true;
                          this.txtObservacion.BackColor = System.Drawing.Color.White;

                          this.dtpFechaPago.Enabled = false;
                          this.dtpFechaReg.Enabled = false;

                          this.gridViewDetalle.OptionsBehavior.Editable = false;

                          ucCon_PlanCtaCmb.Perfil_Lectura();

                          set();
                          break;
                      default:
                          break;
                  }
              }
              catch (Exception ex)
              {
                  string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              } 
          }

        public void bloquear_Datos()
        {
            try
            {
                
            this.cmbMotivoPrest.Enabled = false;
            this.txtObservacion.Enabled = false;
            txeMontoSol.Enabled = false;
            this.txtNumCuotas.Enabled = false;
            txeInteres.Enabled = false;
            this.cmbPeriodoPago.Enabled = false;
            this.dtpFechaPago.Enabled = false;
            this.dtpFechaReg.Enabled = false;
            this.btnGenerar.Enabled = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void bloquear_Datos_Actualizar()
        {
            try
            {
                cmbBanco.Enabled = false;
                txeMontoSol.Enabled = false;
                this.txtNumCuotas.Enabled = false;
                txeInteres.Enabled = false;
                this.cmbPeriodoPago.Enabled = false;
                this.dtpFechaPago.Enabled = false;
                this.dtpFechaReg.Enabled = false;
                this.btnGenerar.Enabled = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


       public void Load_Datos()
        {

            try
            {
                
                // Cargando combo de Motivo Prestamo
                ListaTempo = BusPrestamo_Pago.Get_List_MotivoPrestamo();
                this.cmbMotivoPrest.Properties.DataSource = ListaTempo;
                cmbMotivoPrest.EditValue = "OTR";


                // Cargando combo Periodo de pago
                 ListaTempo = BusPrestamo_Pago.Get_List_PeriocidadPago();
                this.cmbPeriodoPago.Properties.DataSource = ListaTempo;
                this.cmbPeriodoPago.EditValue = "MEN";

                // Cargando estado de pago prestamos
                 ListaTempo = BusPrestamo_Pago.Get_List_EstadoPago();
                this.cmbestadoPago.DataSource = ListaTempo;
                

                 ListaTempo = BusPrestamo_Pago.Get_List_MetodoCalculo();
                this.cmbMetodoCalc.Properties.DataSource = ListaTempo;
                cmbMetodoCalc.EditValue = "FRAN";

                ListaTempo = BusPrestamo_Pago.Get_List_EstadoPago();
                this.cmbestadoPago.DataSource = ListaTempo;
                this.cmbEstadoPag.DataSource = ListaTempo;
                

                var lstBanco = busCtaBanc.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.cmbBanco.Properties.DataSource = lstBanco;

                lista_Activos_fijos = Activo_Fijo_Bus.Get_List_ActivoFijo(param.IdEmpresa);
                cmb_acticos_fijo.DataSource = lista_Activos_fijos;
                cmb_acticos_fijo.ValueMember = "IdActivoFijo";
                cmb_acticos_fijo.DisplayMember = "Af_Nombre";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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

                meses = Convert.ToInt32(this.txtNumCuotas.Text);
                monto = Convert.ToDouble(txeMontoSol.EditValue);
                interes = Convert.ToDouble(txeInteres.EditValue);

                List<ba_prestamo_detalle_Info> listaDetalle = new List<ba_prestamo_detalle_Info>();

                for (int i = 1; i <= meses; i++)
                {
                    ba_prestamo_detalle_Info item = new ba_prestamo_detalle_Info();

                    item.NumCuota = i;

                    // item.MontoCuota= Math.Round((monto / meses),3);
                    item.Interes = interes;
                    // item.ValorInteres = Math.Round(((item.MontoCuota * interes) / 100),3);
                    // item.TotalCuota = Math.Round((item.MontoCuota + item.ValorInteres),3);
                    item.EstadoPago = "PEN";
                    item.FechaPago = fecha;


                    item.Observacion_det = "";
                    item.Estado = "A";
                    listaDetalle.Add(item);


                    // fecha = fecha.AddDays(meses);

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

                lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>(listaDetalle);
                this.gridControlDetalle.DataSource = lista_detalle_prestamo;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }                 
        }
        public void insertar()
        {
            try
            {
               

                decimal Id = 0;
                string mensaje = "";
                prestamo_Info.IdUsuario = param.IdUsuario;
                prestamo_Info.lista_detalle = lista_detalle_prestamo.ToList();
                prestamo_Info.lista_activos_prendados = lista_activos_prendados.ToList();
                if (prestamo_Infoecera_b.GuardarDB(prestamo_Info, ref Id, ref mensaje))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el prestamo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + " del prestamo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }
      
        void Actualizar()
        {
            try
            {
                prestamo_Info.IdUsuarioUltMod = param.IdUsuario;
                prestamo_Info.Fecha_UltMod = DateTime.Now;
                prestamo_Info.lista_detalle = lista_detalle_prestamo.ToList();
                prestamo_Info.lista_activos_prendados = lista_activos_prendados.ToList();
                if (prestamo_Infoecera_b.ModificarDB(prestamo_Info))
                {

                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el prestamo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_modificaron_los_datos) + " del prestamo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void Anular()
        {
            try
            {
                List<ba_prestamo_detalle_Info> Registro = new List<ba_prestamo_detalle_Info>();
                 get();                                          
                if (prestamo_Info != null)
                {
                    if (prestamo_Info.Estado == "A")
                    {
                         List<ba_prestamo_detalle_Info> listadodetalle = prestamo_detalle_Bus.Get_List_prestamo_detalle(param.IdEmpresa, prestamo_Info.IdPrestamo);
                         try
                         {

                         //var Registro = listadodetalle.FindAll( var=> var.EstadoPago!="CAN");
                             Registro = estados.FindAll(var => var.EstadoPago != "CAN" && (var.Saldo_Canc == null|| var.Saldo_Canc==0 ));
                         if (Registro.Count ==0)
                           {
                             MessageBox.Show("No se puede anular el préstamo: " + prestamo_Info.CodPrestamo+". \r Todas las cuotas ya están canceladas");
                             return;

                           }
                         }
                         catch (Exception)
                         {

                         }
                         FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                   
                         if (MessageBox.Show("¿Está seguro que desea anular el préstamo: " + prestamo_Info.CodPrestamo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                         {
                             if (Registro.Count > 0 && Registro.Count < listadodetalle.Count)

                                 if (MessageBox.Show("¿El prestamo tiene cuotas ya canceladas.\r ¿Está realmente seguro que desea anular el préstamo: " + prestamo_Info.CodPrestamo + " ?...", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                     return;

                             string msg = "";
                             oFrm.ShowDialog();

                             prestamo_Info.MotiAnula = oFrm.motivoAnulacion;
                             prestamo_Info.IdUsuarioUltAnu = param.IdUsuario;
                             prestamo_Info.Fecha_UltAnu = param.Fecha_Transac;

                             if (prestamo_Infoecera_b.AnularDB(prestamo_Info))
                             {
                                 //
                                 // checkBoxEstado.Checked = false;

                                 Registro.ForEach(var => var.EstadoPago = "ANU");
                                 if (prestamo_detalle_Bus.AnularDetallePrestamo(Registro, ref msg) == false)
                                 {
                                     MessageBox.Show(msg);


                                 }                                                         
                                 else 
                                 {
                                     string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El préstamo", prestamo_Info.CodPrestamo);
                                     MessageBox.Show(smensaje, param.Nombre_sistema);
                                     //MessageBox.Show("Anulado con éxito el el préstamo: " + Info.CodPrestamo); 
                                 }

                                 this.btn_guardar.Enabled = false;
                             }
                             else MessageBox.Show("No se pudo anular el préstamo: " + prestamo_Info.CodPrestamo + " debido a: "
                                 + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el préstamo: " + prestamo_Info.CodPrestamo, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void AnullarLineaDetalle()
        {
            //GetDetalle();
            try
            {
                if (this.txtIdPrestamo.Enabled == false)
                { 

                    var Info = (ba_prestamo_detalle_Info)this.gridViewDetalle.GetFocusedRow();

                    if (Info == null)
                        MessageBox.Show("Seleccione una fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                    if (prestamo_detalle_Bus.AnularDetallePrestamo(Info))
                                    {
                                        MessageBox.Show("Anulado con éxito la cuota #: " + Info.NumCuota);
                                        // checkBoxEstado.Checked = false;
                                        ////lblAnulado.Visible = true;
                                        ////this.btn_guardar.Enabled = false;

                                        set();
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
            catch (Exception ex) 
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        
        }    
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtObservacion.Focus();
                get();
                //enu = Cl_Enumeradores.eTipo_action.grabar;
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //guardar();
                        if (Validar())
                        {
                            if (this.ValidaGeneraPrestamo())
                            {
                                if (this.VerificaGridFechas())
                                {
                                    insertar();
                                   // SETINFO();
                                }
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            if (this.ValidaGeneraPrestamo())
                            {
                                if (this.VerificaGridFechas())
                                {
                                    Actualizar();
                                  //  SETINFO();
                                }
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        // Borrar();
                        Anular();
                      //  SETINFO();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
         
        }
        Boolean ValidaGeneraPrestamo()

        {
            try
            {

                if (this.gridViewDetalle.RowCount == 0)
                {
                    MessageBox.Show("Genere el detalle del préstamo", param.Nombre_sistema);

                    return false;
                     }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }                
        }

        void generarMetodoFrances(int dias, int tipoperiodo)
        {
            try
            {
                double meses = Convert.ToDouble(txtNumCuotas.EditValue);
                double interes = (Convert.ToDouble(txeInteres.EditValue))/12 ;
                double monto = Convert.ToDouble(txeMontoSol.EditValue);
                double Cuota_Pago = 0;
                double amortizacion=0   ;
                Cuota_Pago = Math.Round(monto * (((interes) * Convert.ToDouble((Math.Pow((1 + Convert.ToDouble(interes)), meses))) / Convert.ToDouble((Math.Pow((1 + Convert.ToDouble(interes)), meses)) - 1))), 2);
                lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>();
                DateTime Fecha_Pago_cuota_anterior=new DateTime();
                DateTime Fecha_Pago_Siguiente = new DateTime();
                int DiasPlazo = 0;
                int dia_Pago = 0;

                for (int i = 1; i <= meses; i++)
                {
                    if (i == 1)
                    {
                       DiasPlazo = ((TimeSpan)(Convert.ToDateTime(dtpFechaPago.EditValue) - Convert.ToDateTime(dtpFechaReg.EditValue))).Days;
                       Fecha_Pago_Siguiente =Convert.ToDateTime( dtpFechaPago.EditValue);
                    }
                    else
                    {
                        Fecha_Pago_Siguiente =Convert.ToDateTime( Fecha_Pago_Siguiente).AddMonths(1);
                        DiasPlazo = ((TimeSpan)(Convert.ToDateTime(Fecha_Pago_Siguiente) - Convert.ToDateTime(Fecha_Pago_cuota_anterior))).Days;
                    }
                     
                    dia_Pago = Convert.ToInt32(Fecha_Pago_Siguiente.DayOfWeek);
                    if (dia_Pago == 6)
                    {
                        DiasPlazo = DiasPlazo + 2;
                    }

                    if (dia_Pago == 7)
                    {
                        DiasPlazo = DiasPlazo + 1;
                    }

                    ba_prestamo_detalle_Info Detalle_cuoate_info = new ba_prestamo_detalle_Info();
                    Detalle_cuoate_info.Interes = Math.Round(monto * (Convert.ToDouble( txeInteres.EditValue) / 360) * DiasPlazo, 2);
                    Detalle_cuoate_info.TotalCuota = Cuota_Pago;
                    Detalle_cuoate_info.Estado = "A";
                    Detalle_cuoate_info.EstadoPago = "PEN";
                    Detalle_cuoate_info.FechaPago = Fecha_Pago_Siguiente;
                    amortizacion = Cuota_Pago - Detalle_cuoate_info.Interes;
                    monto =Math.Round( monto - amortizacion,2);
                    Fecha_Pago_cuota_anterior = Detalle_cuoate_info.FechaPago;
                    Detalle_cuoate_info.Saldo = monto;
                    Detalle_cuoate_info.SaldoInicial = amortizacion;
                    Detalle_cuoate_info.Secuencia = i;
                    Detalle_cuoate_info.NumCuota = i;
                    Detalle_cuoate_info.DiasPlazo = DiasPlazo;

                    Detalle_cuoate_info.IdUsuario = param.IdUsuario;
                    Detalle_cuoate_info.Fecha_Transac = param.Fecha_Transac;
                    Detalle_cuoate_info.nom_pc = param.nom_pc;
                    Detalle_cuoate_info.ip = param.ip;
                    Detalle_cuoate_info.Observacion_det =txtObservacion.Text;
                    Detalle_cuoate_info.IdEmpresa = param.IdEmpresa;
                    this.lista_detalle_prestamo.Add(Detalle_cuoate_info);
                }












                gridControlDetalle.DataSource = lista_detalle_prestamo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void generarMetodoAleman(int dias, int tipoperiodo)
        {
            try
            {
                double meses = Convert.ToDouble(txtNumCuotas.EditValue);
                double interes = (Convert.ToDouble(txeInteres.EditValue) / tipoperiodo) / 100;
                double monto = Convert.ToDouble(txeMontoSol.EditValue);
                double montoOculto = 0;
                double InteresTextbox = Convert.ToDouble(txeInteres.EditValue) / 100;
                //montoOculto = Math.Round(monto * ((interes * (Math.Pow((1 + interes), meses)) / ((Math.Pow((1 + interes), meses)) - 1))), 3);

                montoOculto = Math.Round(monto * (((interes) * Convert.ToDouble((Math.Pow((1 + Convert.ToDouble(interes)), meses))) /
                    Convert.ToDouble((Math.Pow((1 + Convert.ToDouble(interes)), meses)) - 1))), 3);

                lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>();
                lista_detalle_prestamo.Add(new ba_prestamo_detalle_Info()
                {
                    SaldoInicial = Convert.ToDouble(monto),
                    Saldo = Convert.ToDouble(monto),
                    FechaPago = Convert.ToDateTime((Convert.ToDateTime(dtpFechaReg.EditValue).ToShortDateString()))
                });

                for (int i = 0; i < meses; i++)
                {
                    ba_prestamo_detalle_Info RegistroAnterior = lista_detalle_prestamo[i];


                    DateTime fechapago_sig = new DateTime();
                    fechapago_sig = RegistroAnterior.FechaPago.AddDays(dias);
                    
                    double InterObj = 0;
                    double AbonoCap = 0;

                    ba_prestamo_detalle_Info reg = new ba_prestamo_detalle_Info();
                    reg.NumCuota = i + 1;
                    reg.SaldoInicial = RegistroAnterior.Saldo;
                    reg.FechaPago = fechapago_sig;
                    reg.Interes = InterObj = 
                        Convert.ToDouble((Convert.ToDouble(RegistroAnterior.Saldo )* (InteresTextbox) / 360) * fechapago_sig.Subtract(RegistroAnterior.FechaPago).Days);
                    //reg.AbonoCapital = AbonoCap = i + 1 < meses ? montoOculto - InterObj : i + 1 == meses ? (montoOculto - InterObj) : 0;
                    reg.AbonoCapital =AbonoCap= Convert.ToDouble(monto )/ meses;
                    reg.TotalCuota = reg.Interes + reg.AbonoCapital;
                    reg.Saldo = i + 1 < meses ? RegistroAnterior.Saldo - AbonoCap : 0;
                    reg.IdEmpresa = param.IdEmpresa;
                    reg.Estado = "A";
                    reg.EstadoPago = "PEN";
                  
                    lista_detalle_prestamo.Add(reg);

                }
             
                foreach (var item in lista_detalle_prestamo)
                {
                    item.SaldoInicial = Math.Round(item.SaldoInicial, 2);
                    item.Interes = Math.Round(item.Interes, 2);
                    item.AbonoCapital = Math.Round(item.AbonoCapital, 2);
                    item.TotalCuota = Math.Round(item.TotalCuota, 2);
                    item.Saldo = Math.Round(item.Saldo, 2);
                }
                gridControlDetalle.DataSource = lista_detalle_prestamo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                fechaPago = Convert.ToDateTime(dtpFechaPago.Text);
                fecha2 = Convert.ToDateTime(dtpFechaReg.Text);
                monto = Convert.ToDouble(txeMontoSol.EditValue);
                periodo = Convert.ToInt32(txtNumCuotas.EditValue);

                double tasaIntres = Convert.ToDouble(txeInteres.EditValue);

                tasa = Convert.ToDouble(txeInteres.EditValue);

                DateTime dt1 = fechaPago;
                DateTime dt2 = fecha2;

                TimeSpan difer = dt1 - dt2;

                int dias = Convert.ToInt16(difer.Days);

                if (Validar())
                {
                    if (this.ValidarDetPrestamo())
                    {
                        if (dias < 0)
                        {
                            MessageBox.Show("La fecha de pago  " + fechaPago + " no puede ser menor a la fecha de registro  " + fecha2, param.Nombre_sistema);
                            return;
                        }
                        else
                        {
                            if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "MEN")
                            {
                                if (Convert.ToString(cmbMetodoCalc.EditValue) == "ALE")
                                {
                                    generarMetodoAleman(30, 12); desabilitar();
                                }
                                else if (Convert.ToString(cmbMetodoCalc.EditValue) == "FRAN")
                                {
                                    generarMetodoFrances(30, 12); desabilitar();
                                }

                            } if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "QUI")
                            {

                                if (Convert.ToString(cmbMetodoCalc.EditValue) == "ALE")
                                {
                                    generarMetodoAleman(15, 24); desabilitar();
                                }
                                else if (Convert.ToString(cmbMetodoCalc.EditValue) == "FRAN")
                                {
                                    generarMetodoFrances(15, 24); desabilitar();
                                }

                            }
                            if (Convert.ToString(this.cmbPeriodoPago.EditValue) == "SEM")
                            {

                                if (Convert.ToString(cmbMetodoCalc.EditValue) == "ALE")
                                {
                                    generarMetodoAleman(7, 52);
                                    desabilitar();
                                }
                                else if (Convert.ToString(cmbMetodoCalc.EditValue) == "FRAN")
                                {
                                    generarMetodoFrances(7, 52);
                                    desabilitar();
                                }

                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void desabilitar()
        {
            try
            {
                txeMontoSol.Enabled = false;
                this.txtNumCuotas.Enabled = false;
                txeInteres.Enabled = false;
                this.cmbMetodoCalc.Enabled = false;
                this.cmbPeriodoPago.Enabled = false;
                this.dtpFechaPago.Enabled = false;
            //    this.dtpFechaReg.Enabled = false;

                this.btnGenerar.Enabled = false;
                this.btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        Boolean Validar()
        {
            try
            {
                 if(Convert.ToDouble(txeInteres.EditValue) <=0)
                {
                    MessageBox.Show("Ingrese el Interes del Préstamo.", param.Nombre_sistema);
                    txeInteres.Focus();
                    return false;
                }
                if (this.cmbMetodoCalc.EditValue == null )//|| Convert.ToInt32(cmbMetodoCalc.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el Método de Cálculo.", param.Nombre_sistema);
                    cmbMetodoCalc.Focus();
                    return false;
                }
                if (this.cmbBanco.EditValue == null)
                {
                    MessageBox.Show("Ingrese el Banco.", param.Nombre_sistema);
                    cmbBanco.Focus();
                    return false;
                }
                if (this.cmbMotivoPrest.EditValue == null)
                {
                    MessageBox.Show("Ingrese el motivo del préstamo.", param.Nombre_sistema);
                    cmbMotivoPrest.Focus();
                    return false;
                }
                if (this.txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese la observación.", param.Nombre_sistema);
                    txtObservacion.Focus();
                    return false;
                }
                if (Convert.ToDecimal(txeMontoSol.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el monto del préstamo", param.Nombre_sistema);
                    return false;
                }
                if (this.cmbPeriodoPago.EditValue == null)
                {
                    MessageBox.Show("Ingrese el periodo de pago", param.Nombre_sistema);
                    return false;
                }
                if (this.txtNumCuotas.Text == "0")
                {
                    MessageBox.Show("Ingrese el número de cuotas", param.Nombre_sistema);
                    return false;
                }

                if (Convert.ToDouble(txeInteres.EditValue) == 0 || txeInteres.EditValue == "" || txeInteres.EditValue == null)
                {
                    MessageBox.Show("Ingrese la tasa de interés", param.Nombre_sistema);
                    return false;
                }

                if (fechaPago.Day>28)
                {
                    MessageBox.Show("Escoja un dia menor o igual a 28", param.Nombre_sistema);
                    return false;
                }


                if (ucBa_TipoFlujo.get_TipoFlujoInfo() == null || ucBa_TipoFlujo.get_TipoFlujoInfo().IdEmpresa==0)
                {
                    MessageBox.Show("Escoja tipo flujo", param.Nombre_sistema);
                    return false;
                }


                if (ucCon_PlanCtaCmb.get_PlanCtaInfo() == null || ucCon_PlanCtaCmb.get_PlanCtaInfo().IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione una cuenta contable", param.Nombre_sistema);
                    return false;
                }

                if (lista_detalle_prestamo.Where(v=>v.EstadoPago=="CAN").Count()>0)
                {
                    MessageBox.Show("No se puede modificar el prestamo existen cuotas canceladas", param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dtpFechaReg.EditValue)))
                    return false; 
                return true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        Boolean ValidarDetPrestamo()
        {
            try
            {
                if (Convert.ToDouble(txeMontoSol.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el monto del préstamo", param.Nombre_sistema);
                    return false;
                }
                if (this.cmbPeriodoPago.EditValue == null)
                {
                    MessageBox.Show("Ingrese el periodo de pago", param.Nombre_sistema);
                    return false;
                }

                if (this.txtNumCuotas.Text == "0")
                {
                    MessageBox.Show("Ingrese el número de cuotas", param.Nombre_sistema);
                    return false;
                }

                if (Convert.ToDouble(txeInteres.EditValue) == 0 || txeInteres.EditValue == "" || txeInteres.EditValue == null)
                {
                    MessageBox.Show("Ingrese la tasa de interés", param.Nombre_sistema);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtObservacion.Focus();
                get();

                Anular();
                set();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        public delegate void delegate_frmRo_Prestamos_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Prestamos_FormClosing event_frmRo_Prestamos_FormClosing;
       
        void get()
        {
            try
            {
                prestamo_Info.IdPrestamo = Convert.ToDecimal(this.txtIdPrestamo.EditValue);
                prestamo_Info.IdEmpresa = param.IdEmpresa;
                prestamo_Info.CodPrestamo = txtCodPrestamo.Text;                
                prestamo_Info.IdMotivo_Prestamo = Convert.ToString(this.cmbMotivoPrest.EditValue);
                prestamo_Info.IdMetCalc = Convert.ToString ( cmbMetodoCalc.EditValue);
                prestamo_Info.IdPeriPago = Convert.ToString(cmbPeriodoPago.EditValue);
                prestamo_Info.NomBanco = cmbBanco.Text;
                prestamo_Info.NomMotivo_Prestamo = cmbMotivoPrest.Text;
                prestamo_Info.MetodoCalculo = cmbMetodoCalc.Text;
                prestamo_Info.IdBanco = Convert.ToInt32(cmbBanco.EditValue);
                prestamo_Info.NumCuotas = Convert.ToInt32(this.txtNumCuotas.EditValue);
                prestamo_Info.TasaInteres = Convert.ToDouble(txeInteres.EditValue);
                prestamo_Info.IdTipo_Pago = Convert.ToString(this.cmbPeriodoPago.EditValue);
                prestamo_Info.Observacion = this.txtObservacion.Text;
                prestamo_Info.MontoSol = Convert.ToDouble(txeMontoSol.EditValue);
                prestamo_Info.Pago_contado =Convert.ToDouble( txtpagoContado.EditValue);
                prestamo_Info.Fecha_PriPago = Convert.ToDateTime(this.dtpFechaPago.EditValue);
                prestamo_Info.IdCtaCble = ucCon_PlanCtaCmb.get_PlanCtaInfo().IdCtaCble;
                prestamo_Info.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                prestamo_Info.Fecha = Convert.ToDateTime(this.dtpFechaReg.EditValue);
                prestamo_Info.Fecha_Transac = param.Fecha_Transac;
                prestamo_Info.IdCliente = cmb_cliente.Get_Info_Cliente_x_Centro_costo().IdCliente_cli;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        string IdCtaCble_Banco = "";

        void set()
        {
            try
            {
                IdCtaCble_Banco = SETINFO_.IdCtaCble_Banco;
                
                
                if (SETINFO_.IdTipoFlujo !=null)
               {
                   ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(SETINFO_.IdTipoFlujo));
               
               }
                if (!String.IsNullOrEmpty(SETINFO_.IdCtaCble))
               {
                   ucCon_PlanCtaCmb.set_PlanCtarInfo(SETINFO_.IdCtaCble);
               
               }
                             
                txtIdPrestamo.EditValue = SETINFO_.IdPrestamo;
                cmbBanco.EditValue = SETINFO_.IdBanco;
                cmbMetodoCalc.EditValue = SETINFO_.IdMetCalc;
                txtCodPrestamo.Text = SETINFO_.CodPrestamo;
                cmbMotivoPrest.EditValue = SETINFO_.IdMotivo_Prestamo;
                txtNumCuotas.EditValue = SETINFO_.NumCuotas;
                txeInteres.EditValue = Convert.ToDouble(SETINFO_.TasaInteres);
                cmbPeriodoPago.EditValue = SETINFO_.IdTipo_Pago;
                txtObservacion.Text = SETINFO_.Observacion;
                txeMontoSol.EditValue = Convert.ToDouble(SETINFO_.MontoSol);
                dtpFechaPago.EditValue = SETINFO_.Fecha_PriPago;
                dtpFechaReg.EditValue = SETINFO_.Fecha;
                txtpagoContado.EditValue = SETINFO_.Pago_contado;
                cmb_cliente.Set_Info_Cliente_x_Centro_costo(SETINFO_.IdCliente);
                if (SETINFO_.Estado == "I")
                {

                    gridViewDetalle.OptionsBehavior.ReadOnly = true;
                    btnCuotas.Enabled = false;

                }
                else
                {
                    gridViewDetalle.OptionsBehavior.ReadOnly = false;
                    btnCuotas.Enabled = true;
                }


                prestamo_Infoecera_b.Get_List_PrestamoxIdPrestamo(param.IdEmpresa, SETINFO_.IdPrestamo);

                lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>( prestamo_detalle_Bus.Get_List_prestamo_detalle(param.IdEmpresa, SETINFO_.IdPrestamo));
                gridControlDetalle.DataSource = lista_detalle_prestamo;
                estados = new List<ba_prestamo_detalle_Info>();
                estados = bus_PrestamoDet.Get_List_EstadoCuenta(SETINFO_, ref mensaje);
                foreach (var item in estados)
                {
                   if(item.Secuencia !=null)
                   {item.numcuota_numpago  = item.Secuencia+"/"+ item.NumCuota;}
                    if (item.Secuencia != null && item.Secuencia != 0)
                    {
                        item.btnEditar = (Bitmap)imageBotones.Images[0];
                        item.btnAnular = (Bitmap)imageBotones.Images[1];
                    }
                    else {
                        item.btnEditar = (Bitmap)imageBotones.Images[2]; 
                        item.btnAnular = (Bitmap)imageBotones.Images[2];
                    }
                }
                estado = new BindingList<ba_prestamo_detalle_Info>(estados);
                gridControlEstado.DataSource = estado;
                if (enu != Cl_Enumeradores.eTipo_action.grabar)
                { tabPage2.Focus(); }


                // acticvos prendados por prestamos
                 tota_cancelado = 0;
                 total_pendiente = 0;
                var canceladas = lista_detalle_prestamo.Where(v => v.EstadoPago == "CAN");
                tota_cancelado = canceladas.Sum(v => v.TotalCuota);
                total_pendiente = SETINFO_.MontoSol - tota_cancelado;
                lista_activos_prendados = new BindingList<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info>(Activos_Prendados_Bus.Get_list_activos_prendados(SETINFO_.IdEmpresa, Convert.ToInt32(SETINFO_.IdPrestamo)));
                Get_valor_prendado_x_activo();
                gridControl_Activos_Prendados.DataSource = lista_activos_prendados;
                
                mostrarmensaje = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        
        public void setprestamo_InfoPrestamo(ba_prestamo_Info prestamo_Info)
        {
            try
            {
              //  Load_Datos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        Boolean VerificaGridFechas()
        {
            try
            {
                for (int i = 0; i < gridViewDetalle.RowCount - 1; i++)
                {

                    ba_prestamo_detalle_Info info1 = (ba_prestamo_detalle_Info)gridViewDetalle.GetRow(i);

                    ba_prestamo_detalle_Info info2 = (ba_prestamo_detalle_Info)gridViewDetalle.GetRow(i + 1);

                    if (info2.FechaPago < info1.FechaPago)
                    {
                       MessageBox.Show("La fecha : " + info2.FechaPago + "  de la cuota # " + info2.NumCuota + " , no puede ser menor a la fecha de pago de la cuota  #  " + info1.NumCuota + " . Por favor ingrese una fecha válida..... ", param.Nombre_sistema);
                        return false;
                    }

                }

                return true;
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
            
          }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                txeMontoSol.Enabled = true;
                txtNumCuotas.Enabled = true;
                txeInteres.Enabled = true;

                cmbPeriodoPago.Enabled = true;
                dtpFechaPago.Enabled = true;
                dtpFechaReg.Enabled = true;
                cmbMetodoCalc.Enabled = true;
                btnGenerar.Enabled = true;
                btnNuevo.Enabled = false;

                txeMontoSol.EditValue = 0;
                txtNumCuotas.EditValue = 0;
                txeInteres.EditValue = null;

                //limpia gridview
                lista_detalle_prestamo = new BindingList<ba_prestamo_detalle_Info>();
                gridControlDetalle.DataSource = lista_detalle_prestamo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

  
        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                btn_guardar_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fehca = Convert.ToDateTime(dtpFechaReg.EditValue).ToShortDateString();
                gridViewDetalle.ViewCaption = " Fecha:"+fehca+" Banco:" + cmbBanco.Text + "\r Cód. Préstamo:" + txtCodPrestamo.Text +
                    " Id# " + txtIdPrestamo.Text;
                gridViewDetalle.OptionsView.ShowViewCaption = true;
                
                this.gridControlDetalle.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDetalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (mostrarmensaje == true)
                {
                    ba_prestamo_detalle_Info Item = gridViewDetalle.GetFocusedRow() as ba_prestamo_detalle_Info;

                    if (Item.EstadoPago == "ANU" || Item.EstadoPago == "CAN")
                    {
                        gridViewDetalle.OptionsBehavior.Editable = false;
                        MessageBox.Show("No puede modificar un registro cancelado.");
                    }
                    else
                    {
                        gridViewDetalle.OptionsBehavior.Editable = true;
                      //  Item.TotalCuota = Item.TotalCuota + Item.Interes;

                        gridControlDetalle.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void FrmBA_PrestamosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Prestamos_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void bandedGridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                ba_prestamo_detalle_Info row = (ba_prestamo_detalle_Info)bandedGridView1.GetFocusedRow();
                if (row != null && row.Secuencia != null && row.Secuencia !=0)
                {
                    ba_prestamo_detalle_Info temp = new ba_prestamo_detalle_Info();
                    temp = row;
                    get();
                    temp.IdEmpresa = param.IdEmpresa;
                    temp.IdPrestamo = prestamo_Info.IdPrestamo;
                    temp.Monto_x_Canc  = row.Monto_Canc;
                    temp.Check = true;
                    if (Cl_Enumeradores.eTipo_action.consultar != enu && Cl_Enumeradores.eTipo_action.Anular != enu)
                    {
                        if (e.Column.FieldName == "btnAnular")
                        {
                            FrmBA_prestamo_detalle_cancelacion frm = new FrmBA_prestamo_detalle_cancelacion();
                            frm.SetInfo(prestamo_Info);
                            frm.tipollamada = "Anular";
                            frm.GET_Editar_o_Anular(temp);
                            frm.ShowDialog();
                            SETINFO_ = prestamo_Info;
                            mostrarmensaje = false;
                            set();
                            tabPage2.Focus();

                        }
                        else
                            if (e.Column.FieldName == "btnEditar")
                            {

                                FrmBA_prestamo_detalle_cancelacion frm = new FrmBA_prestamo_detalle_cancelacion();
                                frm.SetInfo(prestamo_Info);
                                frm.Text = "Edición de cuota";
                                frm.tipollamada = "Editar";
                                frm.GET_Editar_o_Anular(temp);
                                frm.ShowDialog();
                                SETINFO_ = prestamo_Info;
                                mostrarmensaje = false;
                                set(); tabPage2.Focus();
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {

            try
            {
                get();
                FrmBA_prestamo_detalle_cancelacion frm = new FrmBA_prestamo_detalle_cancelacion();
                frm.SetInfo(prestamo_Info);
                frm.ShowDialog();

                SETINFO_ = prestamo_Info;
                mostrarmensaje = false;
                set();
                tabPage2.Focus();


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void bandedGridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                ba_prestamo_detalle_Info data = bandedGridView1.GetRow(e.RowHandle) as ba_prestamo_detalle_Info;
                if (data == null)
                    return;
                if (data.Monto_Canc == 0)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnImprimirEC_Click(object sender, EventArgs e)
        {

            try
            {
                string fehca = Convert.ToDateTime(dtpFechaReg.EditValue).ToShortDateString();
                bandedGridView1.ViewCaption = "Estado de Cuenta\r Fecha:" + fehca + " Banco:" + cmbBanco.Text + "\r Cód. Préstamo:" + txtCodPrestamo.Text +
                    " Id# " + txtIdPrestamo.Text;
                bandedGridView1.OptionsView.ShowViewCaption = true;

                this.gridControlDetalle.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                string fehca = Convert.ToDateTime(dtpFechaReg.EditValue).ToShortDateString();
                gridViewDetalle.ViewCaption = " Tabla Amortización \r Fecha:" + fehca + " Banco:" + cmbBanco.Text + "\r Cód. Préstamo:" + txtCodPrestamo.Text +
                    " Id# " + txtIdPrestamo.Text;
                gridViewDetalle.OptionsView.ShowViewCaption = true;

                this.gridControlDetalle.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewDetalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                ba_prestamo_detalle_Info data = gridViewDetalle.GetRow(e.RowHandle) as ba_prestamo_detalle_Info;
                if (data == null)
                    return;
                if (data.EstadoPago == "ANU")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlEstado_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }



        public void Get_valor_prendado_x_activo()
        {
            try
            {
                tota_valor_compra = 0;
                valor_cancelado_x_activo = 0;
                if(lista_activos_prendados.Count>0 )
                {
                   tota_valor_compra = lista_activos_prendados.Sum(v => v.Af_costo_compra);
                   tota_activos = lista_activos_prendados.Count();
                  
                  foreach (var item in lista_activos_prendados)
                  {
                      item.porcentaje_prestamo_x_activo = item.Af_costo_compra / tota_valor_compra;
                      item.valor_cancelado = tota_cancelado * item.porcentaje_prestamo_x_activo;
                      item.valor_pendiente =Convert.ToDouble( item.Garantia_Bancaria)-item.valor_cancelado;

                  }


                 
                }

            }
            catch (Exception ex)
            {
                
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          
            }
        }

        private void gridView_Activos_Prendados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {


                if (e.Column.Name == "ColIdActivoFijo")
                {
                    if (id_activo != 0)
                    {

                        activo_fijo_info = lista_Activos_fijos.Where(q => q.IdActivoFijo == id_activo).FirstOrDefault();
                        if (lista_activos_prendados.Where(q => q.IdActivoFijo == id_activo).Count() > 1)
                        {
                            MessageBox.Show("Ya existe un registro con este activo fijo, se procederá a eliminar la fila", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info info_eliminar = new ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info();
                            info_eliminar = lista_activos_prendados.Where(q => q.IdActivoFijo == id_activo).FirstOrDefault();
                            lista_activos_prendados.Remove(info_eliminar);
                        }
                        else
                        {
                            gridView_Activos_Prendados.SetFocusedRowCellValue(Col_Af_costo_compra, activo_fijo_info.Af_costo_compra);
                        }
                    }
                    else
                        gridViewDetalle.DeleteRow(gridViewDetalle.FocusedRowHandle);
                }


                
                Get_valor_prendado_x_activo();
              

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
          
            }
        }

        private void gridView_Activos_Prendados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar el registro?.", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Activos_Prendados.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void cmb_acticos_fijo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                id_activo = Convert.ToInt32(e.NewValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridView_Activos_Prendados_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });

                ba_prestamo_detalle_Info newRow = new ba_prestamo_detalle_Info();
                if (rowData.Count() >= 3) //return false;          
                {


                    int Cuota = Convert.ToInt32(rowData[0]);
                    double SaldoInicial = Convert.ToDouble(rowData[1]);
                    double Interes = Convert.ToDouble(rowData[2]);
                    double AbonoCapital = Convert.ToDouble(rowData[3]);
                    double TotalCuota = Convert.ToDouble(rowData[4]);
                    double Saldo = Convert.ToDouble(rowData[5]);
                    DateTime FechaPago = Convert.ToDateTime(rowData[6]);


                    ba_prestamo_detalle_Info emp = new ba_prestamo_detalle_Info();
                    if (!string.IsNullOrWhiteSpace(SaldoInicial.ToString()))
                    {
                        if (fx_Verificar_Reg_Repetidos(emp, false, 0))
                        {

                            newRow.IdEmpresa = param.IdEmpresa;
                            newRow.NumCuota = Cuota;
                            newRow.SaldoInicial = SaldoInicial;
                            newRow.Interes = Interes;
                            newRow.AbonoCapital = AbonoCapital;
                            newRow.TotalCuota = TotalCuota;
                            newRow.Saldo = Saldo;
                            newRow.FechaPago = FechaPago;
                            newRow.EstadoPago="PEN";
                            newRow.Observacion_det = "Vence al " + FechaPago;
                          
                        }
                        else
                        {
                          //  MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                            return false;
                        }



                        lista_detalle_prestamo.Add( newRow);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                        return false;

                    }
                    
                }
                gridControlDetalle.DataSource = lista_detalle_prestamo;
                gridControlDetalle.RefreshDataSource();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        Boolean banderaCargaBatch = false;

        private Boolean fx_Verificar_Reg_Repetidos(ba_prestamo_detalle_Info Info_det, Boolean eliminar, int tipo)
        {
            try
            {/*
                int cont = 0;



                if (banderaCargaBatch)
                {
                    cont = (from C in BindList_Ing_egr_inve_det
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }
                else
                {
                    cont = (from C in lista_IngEgrInv
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }


                if (cont == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                        MessageBox.Show("El producto con la misma cantidad y costo  ya se encuentra ingresado, se procederá con su eliminación.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra ingresado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;

                }
              * */

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }
        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private void gridViewDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
