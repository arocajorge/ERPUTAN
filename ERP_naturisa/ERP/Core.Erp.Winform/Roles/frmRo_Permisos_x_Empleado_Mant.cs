
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Permisos_x_Empleado_Mant : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //private Cl_Enumeradores.eTipo_action _Accion;
        private ro_permiso_x_empleado_Info _Info = new ro_permiso_x_empleado_Info();
        //public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        ro_permiso_x_empleado_Bus oRo_permiso_x_empleado_Bus = new ro_permiso_x_empleado_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Empleado_Info> EmpInfo1 = new List<ro_Empleado_Info>();
        List<ro_Empleado_Info> EmpInfo2 = new List<ro_Empleado_Info>();
        List<ro_Empleado_Info> EmpInfo3 = new List<ro_Empleado_Info>();

        BindingList<ro_Catalogo_Info> oListEstadoAprobacion = new BindingList<ro_Catalogo_Info>();
        List<ro_Catalogo_Info> oRo_TipoLicencia_Info = new List<ro_Catalogo_Info>();

        ro_Empleado_Info empinfo = new ro_Empleado_Info();
        ro_Departamento_Info depInfo = new ro_Departamento_Info();
        ro_Cargo_Info carInfo = new ro_Cargo_Info();
        ro_Catalogo_Bus catBus = new ro_Catalogo_Bus();
        ro_Cargo_Bus carBus = new ro_Cargo_Bus();
        ro_Empleado_Bus empBus = new ro_Empleado_Bus();
        ro_Departamento_Bus depBus = new ro_Departamento_Bus();
        frmRo_Periodo_Cons frmCons = new frmRo_Periodo_Cons();
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action();
        List<ro_Catalogo_Info> ListCatalogo = new List<ro_Catalogo_Info>();

        ro_Catalogo_Bus BusCatalogo = new ro_Catalogo_Bus();

        public delegate void delegate_frmRo_Permisos_x_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Permisos_x_Empleado_Mant_FormClosing event_frmRo_Permisos_x_Empleado_Mant_FormClosing;
        
        string mensaje = "";
     
        #endregion
     
        public frmRo_Permisos_x_Empleado_Mant()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                 ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                 ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                
                 event_frmRo_Permisos_x_Empleado_Mant_FormClosing += frmRo_Permisos_x_Empleado_Mant_event_frmRo_Permisos_x_Empleado_Mant_FormClosing;            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            PU_ANULAR();
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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
            {  pu_Guardar();
            this.Close();

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            //PU_GUARDAR_MODIFICAR();

            pu_Guardar();

        }

        void frmRo_Permisos_x_Empleado_Mant_event_frmRo_Permisos_x_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    //throw new NotImplementedException();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void frmRo_Permisos_x_Empleado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  event_frmRo_Permisos_x_Empleado_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }   

        }
                        
        public Boolean getInfo() {
            try
            {
                
                if (txtIdPermiso.Text != null && txtIdPermiso.Text != "")
                {
                    _Info.IdPermiso = decimal.Parse(txtIdPermiso.Text); 
                }
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                _Info.IdEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                _Info.MotivoAusencia = Convert.ToString(txtMotivoAusencia.EditValue);
               _Info.FormaRecuperacion = Convert.ToString(txtRecuperacion.EditValue);
                _Info.IdEmpleado_Soli = Convert.ToInt32(cmbSolicitado_por.EditValue);
            
                _Info.IdEmpleado_Apro = Convert.ToInt32(cmbAprobado_por.EditValue);
                _Info.MotivoAproba = Convert.ToString(txtMotivo.EditValue);
                _Info.Observacion = Convert.ToString(txtObservación.EditValue);

                _Info.IdTipoLicencia = cmbTipoLicencia.EditValue == null ? "" : cmbTipoLicencia.EditValue.ToString();
                _Info.EsPermiso = rbPermiso.Checked;
                _Info.EsLicencia = rbLicencia.Checked;

                //_Info.TomarEnCuentaParaVacaciones = (chkEncuenta.Checked == true) ? "S" : "N";

                _Info.IdUsuario = param.IdUsuario;
                _Info.Fecha_Transac = param.Fecha_Transac;

                _Info.FechaSalida = Convert.ToDateTime(dtFechaSalida.EditValue);
                _Info.FechaEntrada = Convert.ToDateTime(dtFechaEntrada.EditValue);
                if (check_atraso_SI_NO.Checked == true)
                {
                    _Info.LLegoAtrasado = true;
                }
                else
                {
                    _Info.LLegoAtrasado = false;
                }
                if (rbPermiso.Checked == true)
                {
                    string[] HoraS = this.TxtHoraS.Text.Split(':');
                    _Info.HoraSalida = new TimeSpan(Convert.ToInt32(HoraS[0]), Convert.ToInt32(HoraS[1]), 0);


                    string[] HoraI = this.TxtHoraI.Text.Split(':');
                    _Info.HoraRegreso = new TimeSpan(Convert.ToInt32(HoraI[0]), Convert.ToInt32(HoraI[1]), 0);


                    string[] HoraPedidas = this.txtTiempo.Text.Split(':');
                    _Info.TiempoAusencia = new TimeSpan(Convert.ToInt32(HoraPedidas[0]), Convert.ToInt32(HoraPedidas[1]), 0);
                }
                else
                {
                    _Info.TiempoAusencia = new TimeSpan(1, 1, 0);
                }
                if (Cl_Enumeradores.eTipo_action.actualizar == iAccion)
                {
                    if (check_atraso_SI_NO.Checked == true)
                    {
                        string[] HoraAtraso = this.txtTiempoAtraso.Text.Split(':');
                        _Info.HorasAtraso = new TimeSpan(Convert.ToInt32(HoraAtraso[0]), Convert.ToInt32(HoraAtraso[1]), 0);

                    }
                }

                if (iAccion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    foreach (var item in oListEstadoAprobacion)
                    {
                        if (item.ca_descripcion.Trim() == "Negado")
                        {
                            cmbEstado_aprovacion.EditValue = item.IdCatalogo;
                            break;
                        }
                    }

                    _Info.Estado = "I";
                }

                _Info.IdEstadoAprob = Convert.ToString(cmbEstado_aprovacion.EditValue);
                if(rbPermiso.Checked==true)
                _Info.Id_Forma_descuento_permiso_Cat = cmb_forma_descuento.EditValue.ToString();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }
      
        public Boolean setInfo(ro_permiso_x_empleado_Info info) 
        {
            try
            {
                _Info= info;

                txtIdPermiso.EditValue = _Info.IdPermiso;
                dtpFecha.EditValue = _Info.Fecha;
                cmbEmpleado.EditValue = _Info.IdEmpleado;
                txtMotivoAusencia.EditValue = _Info.MotivoAusencia;
                txtTiempo.Text =Convert.ToString( _Info.TiempoAusencia);
                txtRecuperacion.EditValue = _Info.FormaRecuperacion;
                cmbSolicitado_por.EditValue = _Info.IdEmpleado_Soli;
                cmbEstado_aprovacion.EditValue = _Info.IdEstadoAprob;
                cmbAprobado_por.EditValue = _Info.IdEmpleado_Apro;               
                txtMotivo.EditValue = _Info.MotivoAproba;
                txtObservación.EditValue = _Info.Observacion;
                rbPermiso.Checked = Convert.ToBoolean(info.EsPermiso);
                rbLicencia.Checked = Convert.ToBoolean(info.EsLicencia);             
                cmbTipoLicencia.EditValue = info.IdTipoLicencia;
                dtFechaSalida.EditValue = info.FechaSalida;
                dtFechaEntrada.EditValue = info.FechaEntrada;
                if (_Info.Estado == "I"){
                    lblEstado.Visible = true;
                }else {
                    lblEstado.Visible = false;               
                }
                if (iAccion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (_Info.EsLicencia == true)
                    {
                        dtFechaEntrada.Enabled = true;
                        dtFechaSalida.Enabled = true;
                    }
                    else
                    {
                        dtFechaEntrada.Enabled = false;
                        dtFechaSalida.Enabled = false;

                    }
                }
               TxtHoraI.Text =Convert.ToString( info.HoraRegreso);
               TxtHoraS.Text = Convert.ToString(info.HoraSalida);
               txtTiempoAtraso.Text  = Convert.ToString(info.HorasAtraso);
               check_atraso_SI_NO.Checked =Convert.ToBoolean( info.LLegoAtrasado);
               txtCedula.EditValue = info.pe_cedulaRuc;
               txtDepartamento.EditValue = (info.de_descripcion).Trim();
               txtCargo.EditValue = info.ca_descripcion;
               if (info.LLegoAtrasado == true)
               {
                   txtTiempoAtraso.Text =Convert.ToString( info.HorasAtraso);
               }

               cmb_forma_descuento.EditValue = _Info.Id_Forma_descuento_permiso_Cat;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        
        }

 
        void PU_MOSTRAR_DETALLE(decimal IdEmpleado) {
            try
            {

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public Boolean PU_VALIDAR() {
            try
            {

                if (cmbEmpleado.EditValue == null)
                {
                    MessageBox.Show("El Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbEmpleado.Focus();
                    return false;
                }

                if (cmbSolicitado_por.EditValue == null)
                {
                    MessageBox.Show("El Nombre de Solicitado por es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tabControl1.SelectTab(1);
                    cmbSolicitado_por.Focus();
                    return false;
                }
                else
                {

                }

                if (cmbEstado_aprovacion.EditValue == null || cmbEstado_aprovacion.EditValue.ToString().Length == 0)
                {
                    MessageBox.Show("El Estado de Aprobación es  obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbEstado_aprovacion.Focus();
                    return false;
                }
                else
                {
                    if (cmbEstado_aprovacion.Text == "Aprobado"){
                        if (cmbAprobado_por.EditValue == null){

                            MessageBox.Show("Debe seleccionar el nombre de quien aprueba el permiso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            cmbAprobado_por.Focus();
                            return false;
                        }
                    }

                }

                
               
                

                if (rbPermiso.Checked == true)
                {

                    if (txtMotivoAusencia.EditValue == null || txtMotivoAusencia.EditValue.ToString().Length == 0)
                    {
                        MessageBox.Show("El Motivo de la Ausencia es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //                    MessageBox.Show("Escriba un motivo de ausencia.", "Operación Fallida");
                        tabControl1.SelectTab(0);
                        txtMotivoAusencia.Focus();
                        return false;
                    }

                    if (txtRecuperacion.EditValue == null || txtRecuperacion.EditValue.ToString().Length == 0)
                    {
                        MessageBox.Show("La Forma de Recuperación es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //                    MessageBox.Show("Escriba un motivo de ausencia.", "Operación Fallida");
                        txtRecuperacion.Focus();
                        return false;
                    }



                    if (TxtHoraS.Text == "  :")
                    {
                        MessageBox.Show("La hora de salida es obligatoria", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return false;
                    }
                    if (TxtHoraI.Text == "  :")
                    {
                        MessageBox.Show("La hora de retorno es obligatoria", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;

                    }


                    if (txtTiempo.Text == "  :")
                    {
                        MessageBox.Show("Ingrese el tiempo de ausencia es obligatorio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;

                    }



                    if (txtTiempo.Text == "  :")
                    {
                        MessageBox.Show("El Tiempo Estimado de Ausencia es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //                    MessageBox.Show("Escriba el tiempo estimado para solicitar el permiso.", "Operación Fallida");
                        tabControl1.SelectTab(0);
                        txtTiempo.Focus();
                        return false;
                    }





                    if (cmbSolicitado_por.Text == "" || cmbSolicitado_por.EditValue==null)
                    {
                        MessageBox.Show("Seleccione quien solicita, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                        return false;
                    }


                    if (cmbEstado_aprovacion.Text == "" || cmbEstado_aprovacion.EditValue == null)
                    {
                        MessageBox.Show("Seleccione un Estado para la solicitud, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return false;
                    }

                    if (cmbAprobado_por.Text == "" || cmbAprobado_por.EditValue == null)
                    {
                        MessageBox.Show("Seleccione quien aprueba, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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




        public void PU_ANULAR()
        {
        try{
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
            Boolean valorRetornar = false;
            decimal idPermiso=0;
          //  if (MessageBox.Show("Está seguro que desea ANULAR el registro, recuerde que se procederá a eliminar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
            DialogResult result = MessageBox.Show("Está seguro que desea ANULAR el registro, recuerde que se procederá a eliminar?", "ATENCION", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string msg = "";

                oFrm.ShowDialog();

                getInfo();

                _Info.IdUsuario_Anu = param.IdUsuario;
                _Info.FechaAnulacion = param.Fecha_Transac;
                _Info.MotivoAnulacion = oFrm.motivoAnulacion;
                _Info.Estado = "I";


               if (oRo_permiso_x_empleado_Bus.GuardarDB(_Info, ref idPermiso, ref mensaje))
               {
                    setInfo(_Info);

                    lblEstado.Visible = true;
                    ucGe_Menu.Enabled_bntAnular = false;
                    valorRetornar = true;
                    MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
     
                }
               else
               {
                    MessageBox.Show("Imposible anular el Registro No. " + txtIdPermiso.Text + " , débido a: "
                    + mensaje, "ANULACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valorRetornar = false;
                }
            }
            
            
        }
        
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            Log_Error_bus.Log_Error(ex.ToString());
        }
        
        
        }


        public void pu_Guardar()
        {
            try {
                decimal idPermiso=0;

                if (PU_VALIDAR())
                {

                    if (getInfo())
                    {
                        if (oRo_permiso_x_empleado_Bus.GuardarDB(_Info, ref idPermiso, ref mensaje))
                        {
                            txtIdPermiso.Text = idPermiso.ToString();
                          if(  rbLicencia.Checked==true)
                          {                            
                                empBus.Modificar_Estado(param.IdEmpresa, Convert.ToInt32(_Info.IdEmpleado), "EST_SUB");
                            }
                            else
                            {
                                empBus.Modificar_Estado(param.IdEmpresa, Convert.ToInt32(_Info.IdEmpleado), "EST_ACT");
                            }
                            MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            iAccion = Cl_Enumeradores.eTipo_action.grabar;
                            PU_BLOQUEAR_CONTROLES(false);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



      

        public void PU_CARGAR_COMBOS()
        {
            try
            {
                ro_Empleado_Info inf = new ro_Empleado_Info();
    
                EmpInfo1.Add(new ro_Empleado_Info());

                oListEstadoAprobacion.Add(new ro_Catalogo_Info());


                oRo_TipoLicencia_Info.Add(new ro_Catalogo_Info());


                EmpInfo1.AddRange(empBus.Get_List_Empleado_(param.IdEmpresa));


                cmbEmpleado.Properties.DataSource = EmpInfo1;
                cmbSolicitado_por.Properties.DataSource = EmpInfo1;
                cmbAprobado_por.Properties.DataSource = EmpInfo1;

                //LLENA EL COMBO ESTAADO DE APROBACION
                oListEstadoAprobacion = new BindingList<ro_Catalogo_Info>(catBus.Get_List_Catalogo_x_Tipo(19));
                cmbEstado_aprovacion.Properties.ValueMember = "IdCatalogo";
                cmbEstado_aprovacion.Properties.DisplayMember = "ca_descripcion";
                cmbEstado_aprovacion.Properties.DataSource = oListEstadoAprobacion;

                //LLENA EL COMBO TIPO DE LICENCIA
                oRo_TipoLicencia_Info.AddRange(catBus.Get_List_Catalogo_x_Tipo(23));
                cmbTipoLicencia.Properties.ValueMember = "IdCatalogo";
                cmbTipoLicencia.Properties.DisplayMember = "ca_descripcion";
                cmbTipoLicencia.Properties.DataSource = oRo_TipoLicencia_Info;
              // tipos de descuentos
                ListCatalogo = BusCatalogo.Get_List_Catalogo_x_DiasFalta(1);
                cmb_forma_descuento.Properties.DataSource = ListCatalogo;
              
                if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    foreach (var item in oListEstadoAprobacion)
                    {
                        if (item.ca_descripcion == "Pendiente")
                        {
                            cmbEstado_aprovacion.EditValue = item.IdCatalogo;
                            break;
                        }           
                    }
                }

                pu_ValidarCheck();


               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void PU_BLOQUEAR_CONTROLES(Boolean estado){
            dtpFecha.Properties.ReadOnly = estado;
            txtMotivoAusencia.Properties.ReadOnly = estado;
            txtRecuperacion.Properties.ReadOnly = estado;
            txtObservación.Properties.ReadOnly = estado;
            txtTiempo.ReadOnly = estado;
            txtMotivo.Properties.ReadOnly = estado;
            cmbAprobado_por.Properties.ReadOnly = estado;
            cmbEstado_aprovacion.Properties.ReadOnly = estado;
            cmbSolicitado_por.Properties.ReadOnly = estado;
            cmbEmpleado.Properties.ReadOnly = estado;
            TxtHoraS.ReadOnly = estado;
            TxtHoraI.ReadOnly = estado;
            dtFechaEntrada.Enabled = false;
            dtFechaSalida.Enabled = false;
           
        }


         public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                iAccion = Accion;

                cmbEmpleado.Enabled = false;
                cmbTipoLicencia.Properties.ReadOnly = true;
                rbPermiso.Enabled = false;
                rbLicencia.Enabled = false;

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntSalir = true;
                        dtpFecha.DateTime = System.DateTime.Now;                         
                        
                        PU_BLOQUEAR_CONTROLES(false);
                        cmbEmpleado.Enabled = true;
                        cmbTipoLicencia.Properties.ReadOnly = false;
                        rbPermiso.Enabled = true;
                        rbLicencia.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:                    
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                    
                        dtpFecha.Enabled = false;
                        PU_BLOQUEAR_CONTROLES(false);
                        cmbTipoLicencia.Properties.ReadOnly = false;
                        rbPermiso.Enabled = false;
                        rbLicencia.Enabled = false;

                        check_atraso_SI_NO.Visible = true;
                        LbHoraAtraso.Visible = true;
                        txtTiempoAtraso.Visible = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        PU_BLOQUEAR_CONTROLES(true);
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:                
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false; 
                        
                        //dtpFecha.Enabled = false;
                        PU_BLOQUEAR_CONTROLES(true);

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


        private void frmRo_Permisos_x_Empleado_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    check_atraso_SI_NO.Checked = false;
                    check_atraso_SI_NO.Visible = false;
                    txtTiempoAtraso.Visible = false;
                    LbHoraAtraso.Visible = false;



                }

                TxtHoraI.Visible = false;
                TxtHoraS.Visible = false;
                txtTiempo.Visible = false;
                LbHoraSalida.Visible = false;
                LbHoraIngreso.Visible = false;
                LbTiermpoAusencia.Visible = false;
                LbTiermpoAusencia.Visible = false;
               

                txtIdPermiso.Enabled = false;
                txtCedula.Enabled = false;
                txtDepartamento.Enabled = false;
                txtCargo.Enabled = false;
                lblEstado.Visible = false;
                dtpFecha.EditValue = DateTime.Now;

                if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    dtFechaEntrada.Enabled = true;
                    dtFechaSalida.Enabled = true;
                    dtFechaEntrada.EditValue = DateTime.Now;
                    dtFechaSalida.EditValue = DateTime.Now;
                }

                PU_CARGAR_COMBOS ();
            
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }


   private void cmbAprobado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleado.EditValue == null)
                {
                    MessageBox.Show("Seleccione un Empleado", "Mensaje");
                }
                else
                {
                    if (cmbEmpleado.EditValue.ToString() == cmbAprobado_por.EditValue.ToString())
                    {
                        MessageBox.Show("No puede seleccionar el mismo empleado", "Mensaje");
                        cmbAprobado_por.EditValue = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

     
        private void frmRo_Permisos_x_Empleado_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void pu_ValidarCheck() {
            try {

                if(rbLicencia.Checked)
                {
                    cmbTipoLicencia.Enabled = true;
                    txtRecuperacion.Enabled = false;

                    txtTiempoAtraso.Visible = false;
                    TxtHoraI.Visible = false;
                    TxtHoraS.Visible = false;
                    txtTiempo.Visible = false;
                    LbHoraSalida.Visible = false;
                    LbHoraIngreso.Visible = false;
                    LbTiermpoAusencia.Visible = false;
                    check_atraso_SI_NO.Visible = false;
                    LbTiermpoAusencia.Visible = false;
                    LbHoraAtraso.Visible = false;
                    lb_forma_descuenta.Visible = false;
                    cmb_forma_descuento.Visible = false;
                }
                else
                {
                    if(rbPermiso.Checked){
                        cmbTipoLicencia.Enabled = false;
                        txtRecuperacion.Enabled = true;

                        TxtHoraI.Visible = true;
                        TxtHoraS.Visible = true;
                        txtTiempo.Visible = true;
                        //txtTiempoAtraso.Visible = true;

                        LbHoraSalida.Visible = true;
                        LbHoraIngreso.Visible = true;
                        LbTiermpoAusencia.Visible = true;
                        LbTiermpoAusencia.Visible = true;
                      //  LbHoraAtraso.Visible = true;

                        lb_forma_descuenta.Visible = true;
                        cmb_forma_descuento.Visible = true;
                        if (Cl_Enumeradores.eTipo_action.grabar == iAccion)
                        {
                            LbHoraAtraso.Visible = false;
                            check_atraso_SI_NO.Visible = false;
                            txtTiempoAtraso.Visible = false;
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



        private void rbPermiso_CheckedChanged(object sender, EventArgs e)
        {
            pu_ValidarCheck();
        }

        private void rbLicencia_CheckedChanged(object sender, EventArgs e)
        {
            pu_ValidarCheck();
        }

        private void cmbIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (iAccion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    empinfo = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                    if (empinfo != null)
                    {
                        txtCedula.EditValue = empinfo.InfoPersona.pe_cedulaRuc;
                        txtDepartamento.EditValue = (empinfo.de_descripcion).Trim();
                        txtCargo.EditValue = empinfo.cargo;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void checkCumplioTiempo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (check_atraso_SI_NO.Checked == true)
                {

                    txtTiempoAtraso.Visible = true;
                    LbHoraAtraso.Visible = true;
                }
                else
                {
                    txtTiempoAtraso.Visible = false;
                    LbHoraAtraso.Visible = false;

                }
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
                cmbAprobado_por.EditValue = null;
                cmbSolicitado_por.EditValue = null;
                cmbEmpleado.EditValue = null;
                cmbEstado_aprovacion.EditValue = null;


                txtCargo.Text = "";
                txtCedula.Text = "";
                txtDepartamento.Text = "";
                txtMotivoAusencia.Text = "";
                txtRecuperacion.Text = "";
                txtTiempo.Text = "";
                txtTiempoAtraso.Text = "";
                TxtHoraI.Text = "";
                TxtHoraS.Text = "";
                cmbEmpleado.Enabled = true;
                TxtHoraI.Enabled = true;
                TxtHoraS.Enabled = true;

                txtObservación.Text = "";
                txtRecuperacion.Text="";
                rbPermiso.Enabled = true;
                rbLicencia.Enabled = true;
                dtFechaEntrada.Enabled = true;
                dtFechaSalida.Enabled = true;

                txtIdPermiso.Text = "";
                PU_CARGAR_COMBOS();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      

        public void set_IdEmpleado(int IdEmpleado)
        {
            try
            {
                cmbEmpleado.EditValue = IdEmpleado;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }




    
    }
}
