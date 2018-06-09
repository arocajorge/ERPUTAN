using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Contrato_Mant : Form
    {

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        ro_contrato_bus BusContrato = new ro_contrato_bus();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        ro_Catalogo_Bus BusCatalogo = new ro_Catalogo_Bus();
        public ro_contrato_Info InfoContrato = new ro_contrato_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        private int Bandera=0;
        public delegate void delegate_frmRo_Contrato_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Contrato_Mant_FormClosing Event_frmRo_Contrato_Mant_FormClosing;

        #endregion

        public frmRo_Contrato_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                
                cargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            ControlDatos();
            if (Bandera == 1)
            {
                return;
            }
            get_Info();
            string msg = "";
            ro_contrato_bus contratoBus = new ro_contrato_bus();

            _Accion = Accion;

            if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                if (contratoBus.GrabarDB(InfoContrato, ref msg))
                {
                    //MessageBox.Show(msg, "Operación Exitosa");
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BloquearControles();
                }
                else
                {
                    MessageBox.Show(msg, "Operación Fallida");
                }
            }

            if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                if (contratoBus.ModificarDB(InfoContrato, ref msg))
                {
                //MessageBox.Show(msg, " Operación Exitosa");
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BloquearControles();
                }
                else
                {
                    MessageBox.Show(msg, "Operación Fallida");
                }
            }

            if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                if (contratoBus.Anular(InfoContrato))
                {
                    MessageBox.Show("Anulado ok", "Operación Exitosa");
                    this.Parent.Parent.Dispose();

                    BloquearControles();

                }
                else
                {
                    MessageBox.Show("No se Anulado", "Operación Fallida");
                }
            }
            this.Close();

        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                 ControlDatos();
            if (Bandera == 1)
            {
                return;
            }
            get_Info();
            string msg = "";
            ro_contrato_bus contratoBus = new ro_contrato_bus();

            _Accion = Accion;

            if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                if (contratoBus.GrabarDB(InfoContrato, ref msg))
                {
                    //MessageBox.Show(msg, "Operación Exitosa");
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(msg, "Operación Fallida");
                }
            }

            if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                if (contratoBus.ModificarDB(InfoContrato, ref msg))
                {
 //                   MessageBox.Show(msg, " Operación Exitosa");
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                }
                else
                {
                    MessageBox.Show(msg, "Operación Fallida");
                }
            }

            if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                if (contratoBus.Anular(InfoContrato))
                {
                    MessageBox.Show("Anulado ok", "Operación Exitosa");
                    this.Parent.Parent.Dispose();

                    BloquearControles();

                }
                else
                {
                    MessageBox.Show("No se Anulado", "Operación Fallida");
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cargarCombos()
        {
            try
            {
                //Carga combo Empleado
                List<ro_Empleado_Info> InfoSup = new List<ro_Empleado_Info>();
                InfoSup = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleado.Properties.DataSource = InfoSup;

                //Cargar combo Tipo Contrato
                List<ro_Catalogo_Info> InfoTipoContrato = new List<ro_Catalogo_Info>();
                InfoTipoContrato = BusCatalogo.Get_List_Catalogo_x_Tipo(2);
                cmbTipoContrato.Properties.ValueMember = "CodCatalogo";
                cmbTipoContrato.Properties.DisplayMember = "ca_descripcion";
                this.cmbTipoContrato.Properties.DataSource = InfoTipoContrato;


                //Cargar combo Tipo ESTADO DE CONTRATO
                List<ro_Catalogo_Info> oListRo_EstadoContrato_Info = new List<ro_Catalogo_Info>();
                oListRo_EstadoContrato_Info = BusCatalogo.Get_List_Catalogo_x_Tipo(33);
                cmbEstado.Properties.ValueMember = "CodCatalogo";
                cmbEstado.Properties.DisplayMember = "ca_descripcion";

                this.cmbEstado.Properties.DataSource = oListRo_EstadoContrato_Info;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void Grabar()
        {
            try
            {
                 // Controlar los datos
                    ControlDatos();
                    if (Bandera == 1)
                    {
                        return;
                    }
                    // Extraer Información 
                    get_Info();

                    // variable de mensaje
                    string msg = "";

                    ro_contrato_bus contratoBus = new ro_contrato_bus();

                    // Accion para grabar el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (contratoBus.GrabarDB(InfoContrato, ref msg))
                        {
                            MessageBox.Show(msg, "Operación Exitosa");
                            
                            BloquearControles();
                        }
                        else
                        {
                            MessageBox.Show(msg, "Operación Fallida");
                        }
                    }

                    // Accion para actualizar el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (contratoBus.ModificarDB(InfoContrato, ref msg))
                        {
                            MessageBox.Show(msg, " Operación Exitosa");
                           
                            BloquearControles();
                        }
                        else
                        {
                            MessageBox.Show(msg, "Operación Fallida");
                        }
                    }

                    // Accion para anular el registro
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (contratoBus.Anular(InfoContrato))
                        {
                            MessageBox.Show("Anulado ok", "Operación Exitosa");
                            this.Parent.Parent.Dispose();
                           
                            BloquearControles();

                        }
                        else
                        {
                            MessageBox.Show("No se Anulado", "Operación Fallida");
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void ControlDatos()
        {
            try
            {
                    if (cmbEmpleado.EditValue == null)
                        {
                            MessageBox.Show("No se ha asignado el empleado para el Contrato..", "Ingrese el empleado ");
                            Bandera = 1;
                        }
                        else
                        {
                            if (cmbTipoContrato.EditValue == null)
                            {
                                MessageBox.Show("Tipo de contrato sin datos..", " Ingrese datos");
                                Bandera = 1;
                            }
                            else
                            {
                                if (dtpFechaInicio.Value >= dtpFechaFin.Value)
                                {
                                    MessageBox.Show("La fecha de culminación del contrato : " + dtpFechaFin.Value + " no puede ser menor o igual a la fecha de ingreso " + dtpFechaInicio.Value + "..", "Verifique los datos");
                                    Bandera = 1;
                                }
                                else
                                {
                                    Bandera = 0;
                                }
                            }
                        }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }   
        }

        public ro_contrato_Info get_Info()
        
        {

            try
            {
                InfoContrato.IdEmpresa = param.IdEmpresa;
                if (txtIdContrato.Text != "")
                {
                    InfoContrato.IdContrato = Convert.ToDecimal(txtIdContrato.Text);
                }
                InfoContrato.NumDocumento = txtNoContrato.Text;
                InfoContrato.IdEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                InfoContrato.IdContrato_Tipo = Convert.ToString(cmbTipoContrato.EditValue);
                InfoContrato.FechaInicio = dtpFechaInicio.Value;
                InfoContrato.FechaFin = dtpFechaFin.Value;
                InfoContrato.Observacion = txtObservacion.Text;
                InfoContrato.Estado = (CheckEstado.Checked == true) ? "A" : "I";

                InfoContrato.EstadoContrato = cmbEstado.EditValue.ToString();

                return InfoContrato;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return new ro_contrato_Info();
            }

        }

        public void set_Info(ro_contrato_Info info)
        {
            try
            {
                txtIdContrato.Text = info.IdContrato.ToString();
                txtNoContrato.Text = info.NumDocumento;
                cmbEmpleado.EditValue = info.IdEmpleado;
                cmbTipoContrato.EditValue = info.IdContrato_Tipo;
                dtpFechaInicio.Value = info.FechaInicio;
                dtpFechaFin.Value = info.FechaFin;
                CheckEstado.Checked = (info.Estado == "A") ? true : false;
                cmbEstado.EditValue = info.EstadoContrato;

                //lbl_Estado.Visible = (info.Estado == "I") ? true : false;
                txtObservacion.Text = info.Observacion;

                InfoContrato = info;

                if (info.Estado == "I")
                {
                    lbl_Estado.Visible = true;
                }
                else
                {
                    lbl_Estado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Contrato_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                 Event_frmRo_Contrato_Mant_FormClosing += new delegate_frmRo_Contrato_Mant_FormClosing(frmRo_Contrato_Mant_Event_frmRo_Contrato_Mant_FormClosing);
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            
                            CheckEstado.Enabled = true;
                            lbl_Estado.Visible = false;

                            cmbEstado.EditValue = "ECT_ACT";
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            
                            cmbEmpleado.Enabled = false;
                            this.cmbEmpleado.BackColor = System.Drawing.Color.White;
                            this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;
                            break;

                        case Cl_Enumeradores.eTipo_action.Anular:
                            
                            break;

                        case Cl_Enumeradores.eTipo_action.consultar:
                            
                            if (InfoContrato.Estado == "I")
                            {
                                lbl_Estado.Visible = true;
                            }
                            //BloquearControles();

                            this.cmbEmpleado.Enabled = false;
                            this.cmbEmpleado.BackColor = System.Drawing.Color.White;
                            this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;

                            cmbTipoContrato.Enabled = false;
                            this.cmbTipoContrato.BackColor = System.Drawing.Color.White;
                            this.cmbTipoContrato.ForeColor = System.Drawing.Color.Black;

                            txtObservacion.ReadOnly = true;
                            this.txtObservacion.BackColor = System.Drawing.Color.White;

                            txtNoContrato.ReadOnly = true;
                            this.txtNoContrato.BackColor = System.Drawing.Color.White;

                             CheckEstado.Enabled = false;
                             dtpFechaFin.Enabled = false;
                             dtpFechaInicio.Enabled = false;


                            break;

                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void frmRo_Contrato_Mant_Event_frmRo_Contrato_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void BloquearControles()
        {
            try
            {
                txtIdContrato.ReadOnly = true;
                txtNoContrato.ReadOnly = true;
                CheckEstado.Enabled = false;
                dtpFechaFin.Enabled = false;
                dtpFechaInicio.Enabled = false;
                cmbEmpleado.Enabled = false;
                cmbTipoContrato.Enabled = false;
                txtObservacion.ReadOnly = true;
                cmbEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void frmRo_Contrato_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_frmRo_Contrato_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        lbl_Estado.Visible = false;
                        cmbEstado.EditValue = "ECT_ACT";
                        CheckEstado.Enabled = false;
                        CheckEstado.Checked = true;
                        cmbEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        cmbEmpleado.Enabled = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        CheckEstado.Enabled = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        CheckEstado.Enabled = false;
                        BloquearControles();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        CheckEstado.Enabled = false;

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void Limpiar()
        {
            try
            {
                cmbEmpleado.EditValue = null;
                cmbTipoContrato.EditValue = null;
               // cmbEstado.EditValue = null;
                txtIdContrato.Text = "";
                txtNoContrato.Text = "";
                txtObservacion.Text="";
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFin.Value = DateTime.Now.AddMonths(3);
                cmbEmpleado.Enabled = true;
                cmbTipoContrato.Enabled = true;
                cargarCombos();
                CheckEstado.Checked = true;
                InfoContrato = new ro_contrato_Info();
            }
            catch (Exception ex)
            {
            }
        }

        private void frmRo_Contrato_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == Accion)
                {
                    if (BusContrato.Get_SiExisteContratoActivo(param.IdEmpresa, Convert.ToInt32(cmbEmpleado.EditValue)))
                    {
                        MessageBox.Show("El Empleado Tiene contrato Activo  " + "SIN LIQUIDAR", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbTipoContrato.Enabled = false;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

    }
}
