using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// haac
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Marcaciones_Mant : Form
    {
        #region
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Empleado_Bus Bus_Empleado = new ro_Empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_marcaciones_tipo_Bus Bus_TipoMarcacion = new ro_marcaciones_tipo_Bus();
        ro_marcaciones_x_empleado_Bus Bus_EmpMarcacion = new ro_marcaciones_x_empleado_Bus();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        ro_marcaciones_x_empleado_Info InfoMarcacion = new ro_marcaciones_x_empleado_Info();
        public delegate void delegate_frmRo_Marcaciones_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Marcaciones_Mant_FormClosing event_frmRo_Marcaciones_Mant_FormClosing;
        #endregion 

        public frmRo_Marcaciones_Mant()
        {
            try
            {
                  InitializeComponent();
                  ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                  ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                  ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                  ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                event_frmRo_Marcaciones_Mant_FormClosing += frmRo_Marcaciones_Mant_event_frmRo_Marcaciones_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                LbObsrvacion.Focus();
                GetMarcacion();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            insertar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (Validar())
                        {
                            Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.Eliminar();
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
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
                this.LbObsrvacion.Focus();
                GetMarcacion();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            insertar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (Validar())
                        {
                            Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.Eliminar();
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

        void frmRo_Marcaciones_Mant_event_frmRo_Marcaciones_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        private void frmRo_Marcaciones_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                  this.LoadDatos();

                   this.txtSecuencia.Focus();
            

                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                          //  this.txtSecuencia.Enabled = false;

                             this.txtSecuencia.Enabled = false;
                            this.txtSecuencia.BackColor = System.Drawing.Color.White;
                            this.txtSecuencia.ForeColor = System.Drawing.Color.Black;
                    
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntAnular = false;

                           // this.txtSecuencia.Enabled = false;

                            this.txtSecuencia.Enabled = false;
                            this.txtSecuencia.BackColor = System.Drawing.Color.White;
                            this.txtSecuencia.ForeColor = System.Drawing.Color.Black;


                             this.cmbEmpleado.Enabled = false;
                             this.cmbEmpleado.BackColor = System.Drawing.Color.White;
                             this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;

                             this.cmbTipoMarcacion.Enabled = false;
                             this.cmbTipoMarcacion.BackColor = System.Drawing.Color.White;
                             this.cmbTipoMarcacion.ForeColor = System.Drawing.Color.Black;

                    

                            SetMarcacion();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntAnular = true;

                           // this.txtSecuencia.Enabled = false;

                              this.txtSecuencia.Enabled = false;
                            this.txtSecuencia.BackColor = System.Drawing.Color.White;
                            this.txtSecuencia.ForeColor = System.Drawing.Color.Black;

                             this.cmbEmpleado.Enabled = false;
                             this.cmbEmpleado.BackColor = System.Drawing.Color.White;
                             this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;

                             this.cmbTipoMarcacion.Enabled = false;
                             this.cmbTipoMarcacion.BackColor = System.Drawing.Color.White;
                             this.cmbTipoMarcacion.ForeColor = System.Drawing.Color.Black;

                             this.txtHora.Enabled = false;
                             this.txtHora.BackColor = System.Drawing.Color.White;
                             this.txtHora.ForeColor = System.Drawing.Color.Black;

                             this.dteFecha.Enabled = false;

                            //btnGrabarySalir.Visible = false;

                            SetMarcacion();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:

                           // this.txtSecuencia.Enabled = false;

                             this.txtSecuencia.Enabled = false;
                            this.txtSecuencia.BackColor = System.Drawing.Color.White;
                            this.txtSecuencia.ForeColor = System.Drawing.Color.Black;

                             this.cmbEmpleado.Enabled = false;
                             this.cmbEmpleado.BackColor = System.Drawing.Color.White;
                             this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;

                             this.cmbTipoMarcacion.Enabled = false;
                             this.cmbTipoMarcacion.BackColor = System.Drawing.Color.White;
                             this.cmbTipoMarcacion.ForeColor = System.Drawing.Color.Black;

                             this.txtHora.Enabled = false;
                             this.txtHora.BackColor = System.Drawing.Color.White;
                             this.txtHora.ForeColor = System.Drawing.Color.Black;

                             this.dteFecha.Enabled = false;


                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntAnular = false;

                            SetMarcacion();
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
         
        public frmRo_Marcaciones_Mant(Cl_Enumeradores.eTipo_action Numerador) : this()
          {
              try
              {
                    Accion = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
              }

        }

        public void LoadDatos()
          {
              try
              {
                List<ro_Empleado_Info> InfoEmp = new List<ro_Empleado_Info>();
                InfoEmp = Bus_Empleado.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleado.Properties.DataSource = InfoEmp;
                List<ro_marcaciones_tipo_Info> InfoMarTipo = new List<ro_marcaciones_tipo_Info>();
                InfoMarTipo = Bus_TipoMarcacion.Get_List_marcaciones_tipo();
                this.cmbTipoMarcacion.Properties.DataSource = InfoMarTipo;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
              }                             
        }
                
        public void GetMarcacion()
        {
            try
            {
                    DateTime dt = new DateTime(0001, 1, 1);
                 
                        InfoMarcacion.IdEmpresa = param.IdEmpresa;
                        InfoMarcacion.IdEmpleado = Convert.ToDecimal(this.cmbEmpleado.EditValue);
                        InfoMarcacion.IdTipoMarcaciones = Convert.ToString(this.cmbTipoMarcacion.EditValue);
                        string[] HoraIni = this.txtHora.Text.Split(':');
                        TimeSpan Hora = new TimeSpan(Convert.ToInt32(HoraIni[0]), Convert.ToInt32(HoraIni[1]), 0);
                        InfoMarcacion.es_Hora = new TimeSpan(Convert.ToInt32(HoraIni[0]), Convert.ToInt32(HoraIni[1]), 0);
                        InfoMarcacion.es_fechaRegistro = Convert.ToDateTime(this.dteFecha.EditValue);
                        InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(this.dteFecha.EditValue));
                        if (InfoMarcacion.es_fechaRegistro != dt)
                        {
                            InfoMarcacion.es_anio = Convert.ToInt32(InfoCalendario.AnioFiscal);
                            InfoMarcacion.es_mes = Convert.ToInt32(InfoCalendario.Mes_x_anio);
                            InfoMarcacion.es_semana = Convert.ToInt32(InfoCalendario.Semana_x_anio);
                            InfoMarcacion.es_dia = Convert.ToInt32(InfoCalendario.dia_x_semana);
                            InfoMarcacion.es_sdia = InfoCalendario.NombreDia;
                            InfoMarcacion.es_idDia = Convert.ToInt32(InfoCalendario.dia_x_mes);
                            TimeSpan ts = Hora; 
                           string dia = Convert.ToString(dteFecha.DateTime.Day);
                           string mes = Convert.ToString(dteFecha.DateTime.Month);
                           string anio = Convert.ToString(dteFecha.DateTime.Year);

                           int Horas = ts.Hours;
                           string hora = Convert.ToString(Horas);

                           int Minutos = ts.Minutes;
                           string minuto = Convert.ToString(Minutos);

                           int Segundos = ts.Seconds;
                           string segundo = Convert.ToString(Segundos);
                 

                            if (dia.Length == 1)
                               dia = "0" + dia;

                            if (mes.Length == 1)
                                mes = "0" + mes;                               

                          if (hora.Length == 1)
                              hora = "0" + hora;

                          if (minuto.Length == 1)
                              minuto = "0" + minuto;

                          if (segundo.Length == 1)
                              segundo = "0" + segundo;


                          InfoMarcacion.IdRegistro = Convert.ToString(InfoMarcacion.IdEmpleado) + anio + mes + dia + InfoMarcacion.IdTipoMarcaciones + hora + minuto + segundo;
                          InfoMarcacion.Observacion = txtObservacion.Text.ToString();
                          InfoMarcacion.Estado = "A";
                          InfoMarcacion.IdUsuario = param.IdUsuario;
                          InfoMarcacion.Fecha_Transac = DateTime.Now;


                          if (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                          {
                              InfoMarcacion.IdRegistro = txtSecuencia.Text;

                          }

                    
                        }
                        else

                        { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

           
        }

        public ro_marcaciones_x_empleado_Info _SetInfo { get; set; }

        public void SetMarcacion()
        {
            try
            {
                this.txtSecuencia.EditValue = _SetInfo.IdRegistro;
                this.cmbEmpleado.EditValue = _SetInfo.IdEmpleado;
                this.dteFecha.EditValue = _SetInfo.es_fechaRegistro;
                this.txtHora.EditValue = _SetInfo.es_Hora;
                this.cmbTipoMarcacion.EditValue = _SetInfo.IdTipoMarcaciones;
                txtObservacion.Text = _SetInfo.Observacion;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void insertar()
        {
            try
            {
                this.cmbEmpleado.Focus();
           
               // decimal Id = 0;
                string IdRegistro = "";
                string mensaje = "";

                if (Bus_EmpMarcacion.GrabarDB(InfoMarcacion, ref IdRegistro, ref mensaje))
                {
                    MessageBox.Show("El registro ha sido guardado con éxito  Marcación ", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
               
                }
                else
                    MessageBox.Show("Error al ingresar la marcación", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void Actualizar()
        {
            try
            {
                InfoMarcacion.IdUsuarioUltModi = param.IdUsuario;
                InfoMarcacion.Fecha_UltMod = DateTime.Now;
                if (Bus_EmpMarcacion.ModificarDB(InfoMarcacion, ""))
                {
                    this.txtSecuencia.EditValue = _SetInfo.IdRegistro.ToString();
                    MessageBox.Show("El registro ha sido guardado con éxito  Marcación " , "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void Eliminar()
        {
            try
            {
                if (MessageBox.Show("Está seguro que desea eliminar la marcación", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string IdRegistro=Convert.ToString(this.txtSecuencia.EditValue);

                    if (Bus_EmpMarcacion.EliminarDB(IdRegistro, param.IdEmpresa))
                    {
                        MessageBox.Show("El registro ha sido eliminado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtHora_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               txtHora.Text = txtHora.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
      
        public Boolean Validar()
        {
            try
            {
                if (this.cmbEmpleado.EditValue == null )
                {
                    MessageBox.Show("Ingrese el Nombre del Empleado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (this.dteFecha.EditValue == null )
                {
                    MessageBox.Show("Ingrese la Fecha", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (this.txtHora.EditValue == null || this.txtHora.EditValue == "00:00")
                {
                    MessageBox.Show("Ingrese la Hora", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
               
                         
                if (this.cmbTipoMarcacion.EditValue == null )
                {
                    MessageBox.Show("Ingrese el Tipo de Marcación", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtObservacion.Text=="")
                {
                    MessageBox.Show("Ingrese la Observacion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtObservacion.Focus();
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
     
        private void frmRo_Marcaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Marcaciones_Mant_FormClosing(sender, e);
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

        private void frmRo_Marcaciones_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        public void Limpiar()
        {
            try
            {
                cmbEmpleado.EditValue = null;
                cmbTipoMarcacion.EditValue = null;
                txtObservacion.Text = "";
                txtSecuencia.Text = "";
                txtHora.Text = "00:00";
                dteFecha.EditValue = DateTime.Now;



                cmbEmpleado.Enabled = true;
                cmbTipoMarcacion.Enabled = true;
                txtObservacion.Enabled = true;
                txtSecuencia.Enabled = true;
                txtHora.Enabled = true;
                dteFecha.Enabled = true;

                LoadDatos();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}
