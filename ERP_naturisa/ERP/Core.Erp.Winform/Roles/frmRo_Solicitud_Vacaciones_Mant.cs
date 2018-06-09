

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
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Solicitud_Vacaciones_Mant : Form
    {

        int AniosServicios = 0;
        DateTime ro_corte_actual =DateTime.Now ;
        DateTime ro_periodo = DateTime.Now;
        int IdNomina_Tipo = 0;
        DateTime Fecha_Anio_Inicio ;
        DateTime Fecha_Anio_Fin;

        #region Declaración de variables
        //
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }


        int para = 0;

        int SumarDiasTomados = 0;

        UCRo_Historico_Vacaciones ctrl = new UCRo_Historico_Vacaciones();
 
        public delegate void delegate_frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Solicitud_Vacaciones_Mant_FormClosing event_frmRo_Solicitud_Vacaciones_Mant_FormClosing;
        

        List<ro_Empleado_Info> Lista_empleado = new List<ro_Empleado_Info>();
   
        BindingList<ro_historico_vacaciones_x_empleado_Info> RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
        ro_historico_vacaciones_x_empleado_Info infoHistoricoVac = new ro_historico_vacaciones_x_empleado_Info();
        BindingList<ro_Catalogo_Info> catInfo = new BindingList<ro_Catalogo_Info>();
        ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();
        ro_Departamento_Info depInfo = new ro_Departamento_Info();
        
        ro_SolicitudVacaciones_Info info = new ro_SolicitudVacaciones_Info();
        tb_Calendario_Info InfoCalendario = new tb_Calendario_Info();
        tb_Calendario_Bus Bus_Calendario = new tb_Calendario_Bus();

        //BUS
        ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();
        ro_Empleado_Bus EmpleadoBus = new ro_Empleado_Bus();
        ct_AnioFiscal_Bus AnioFiscalBus = new ct_AnioFiscal_Bus();
        ro_Departamento_Bus depBus = new ro_Departamento_Bus();
        ro_Empleado_Bus empBus = new ro_Empleado_Bus();
        ro_Catalogo_Bus catBus = new ro_Catalogo_Bus();
        ro_historico_vacaciones_x_empleado_Bus RoHistoricoVacaBus = new ro_historico_vacaciones_x_empleado_Bus();
        ro_SolicitudVacaciones_Bus oRo_SolicitudVacaciones_Bus = new ro_SolicitudVacaciones_Bus();


       XROL_Rpt013_Info InfoReporte = new XROL_Rpt013_Info();
       List< XROL_Rpt013_Info> List_Reporte = new List<XROL_Rpt013_Info>();
       XROL_Rpt013_Bus BusReporte = new XROL_Rpt013_Bus();


        #endregion
       
        public frmRo_Solicitud_Vacaciones_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Solicitud_Vacaciones_Mant_FormClosing += frmRo_Solicitud_Vacaciones_Mant_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing;
                pu_CargaInicial();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Validar())
                {
                    pu_Grabar();
                    Close();
                }

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pu_Validar())
                {
                    pu_Grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

    
         
        private void frmRo_Solicitud_Vacaciones_Mant_event_frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }     

        public Boolean getInfo()
        {
            try
            {

                info = new ro_SolicitudVacaciones_Info();

                info.IdEmpresa = param.IdEmpresa;
                info.IdNomina_Tipo = IdNomina_Tipo;
                info.AnioServicio = txtAnioServicio.EditValue.ToString();
                info.IdSolicitudVaca = Convert.ToInt32(txtIdSolicitud.Text==""?0:Convert.ToInt32(txtIdSolicitud.Text));
                info.Fecha = Convert.ToDateTime(dtpFechaRegistro.EditValue);
                info.IdEmpleado =Convert.ToInt32(cmbIdEmpleado.EditValue);
                info.Dias_a_disfrutar = Convert.ToInt32(txtDiaDisfrutar.EditValue);
                info.Dias_pendiente = Convert.ToInt32(txtDiasPendientes.EditValue);            
                info.Fecha_Desde = Convert.ToDateTime(dtpFechaInicio.EditValue);
                info.Fecha_Hasta = Convert.ToDateTime(dtpFechaFinal.EditValue);
                info.Anio_Desde = Fecha_Anio_Inicio;
                info.Anio_Hasta = Fecha_Anio_Fin;
                info.Fecha_Retorno = Convert.ToDateTime(dtpFechaRetorno.EditValue);
                info.IdEstadoAprobacion = (cmbEstado.EditValue == null) ? "Pendiente" : Convert.ToString(cmbEstado.EditValue);
                info.Observacion = Convert.ToString(txtObservacion.EditValue).Trim();
                info.IdUsuario = param.IdUsuario;
                info.FechaAnulacion =null;
                info.Fecha_Transac = Convert.ToDateTime(dtpFechaRegistro.EditValue);
                info.Estado ="A";
                info.Dias_q_Corresponde = txtDiasCorresponde.EditValue.ToString();
                if (info.IdEstadoAprobacion=="Negado" | _Accion== Cl_Enumeradores.eTipo_action.Anular)
                {
                    int diasDisfrutar = Convert.ToInt32(txtDiaDisfrutar.Text);

                    RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.pu_RevertirVacaciones(oRo_Empleado_Info.IdEmpresa, oRo_Empleado_Info.IdEmpleado, diasDisfrutar));
                    gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                    info.Estado = "I";
                    cmbEstado.Enabled = false;
                    _Accion = Cl_Enumeradores.eTipo_action.consultar;
                }
                if(cmb_remplazo.EditValue!=null&& cmb_remplazo.EditValue!="")
                info.IdEmpleado_remp = Convert.ToDecimal(cmb_remplazo.EditValue);
                info.IdEmpleado_aprue = Convert.ToDecimal(cmb_empleado_autoriza.EditValue);

                if (rbt_gozadas.Checked)
                    info.Gozadas_Pgadas = true;
                else
                    info.Gozadas_Pgadas = false;
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public Boolean setInfo(ro_SolicitudVacaciones_Info oInfo)
        {
            try
            {
                info = oInfo;
                txtIdSolicitud.EditValue = info.IdSolicitudVaca;
                dtpFechaRegistro.EditValue = info.Fecha;      
                cmbIdEmpleado.EditValue = info.IdEmpleado;
                txtAnioServicio.EditValue = info.AnioServicio;
                txtDiaDisfrutar.EditValue = info.Dias_a_disfrutar;
                txtDiasPendientes.Text =Convert.ToString( info.Dias_pendiente);
                cmbEstado.EditValue = info.IdEstadoAprobacion;
                dtpFechaInicio.EditValue = info.Fecha_Desde;
                dtpFechaFinal.EditValue = info.Fecha_Hasta;
                dtpFechaRetorno.EditValue = info.Fecha_Retorno;
                txtObservacion.EditValue = info.Observacion;

                if (info.Estado == "I")
                {
                    lblEstado.Visible = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                }
                else {
                    lblEstado.Visible = false;              
                }

                cmb_empleado_autoriza.EditValue = info.IdEmpleado_aprue;
                cmb_remplazo.EditValue = info.IdEmpleado_remp;
                pu_ConsultarHistorico(info.IdEmpleado, info.IdEmpresa);

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        int ConsultarVaca()
        {
            try
            {
                return oRo_SolicitudVacaciones_Bus.MaxPermisoVacaciones(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }



        private void pu_CalcularVacaciones() {
            try {

                int diasPendientes = 0;
                    int diasDisfrutar = Convert.ToInt32(txtDiaDisfrutar.Text);
                    if (txtDiasPendientes.Text != "")
                    {
                        diasPendientes = Convert.ToInt32(txtDiasPendientes.Text);
                    }
                    if (dtpFechaInicio.EditValue != null && dtpFechaFinal.EditValue != null)
                    {
                        if (diasPendientes > 0 && diasDisfrutar <= diasPendientes)
                        {
                            RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.pu_CalcularVacaciones(oRo_Empleado_Info, diasDisfrutar));
                            gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                        }
                        else
                        {
                            MessageBox.Show("El Empleado no tiene días pendientes de vacaciones", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (diasPendientes > 0 && diasDisfrutar <= diasPendientes)
                        {
                            RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.pu_CalcularVacaciones(oRo_Empleado_Info, diasDisfrutar));
                            gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                        }
                        else
                        {
                            MessageBox.Show("El Empleado no tiene días pendientes de vacaciones", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

              //  }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_ActualizarTotales(){
        try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtDiasPendientes.Text = colDiasPendientes.SummaryText;
                }
                txtAnioServicio.Text = colIdHis_Vacaciones.SummaryText;
                txtDiasCorresponde.Text = colDiasGanados.SummaryText;


                if (dtpFechaInicio.EditValue != null && dtpFechaFinal.EditValue != "")
                {
                    double diasDisfrutar = oRo_historico_vacaciones_x_empleado_Bus.CalcularDiasDeDiferencia(Convert.ToDateTime(dtpFechaInicio.EditValue), Convert.ToDateTime(dtpFechaFinal.EditValue));
                    txtDiaDisfrutar.Text = (diasDisfrutar + 1).ToString();
                }
                else
                {

                    DateTime fi;
                    DateTime ff;
                    fi = DateTime.Now;
                    ff = DateTime.Now.AddDays(Convert.ToInt32( txtDiaDisfrutar.EditValue));

                    double diasDisfrutar = oRo_historico_vacaciones_x_empleado_Bus.CalcularDiasDeDiferencia(fi, ff);
                  
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_ConsultarHistorico(decimal idEmpleado, int idEmpresa)
        {
            try 
            {
                RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.ConsultarHistoricoVaca(idEmpleado, idEmpresa));
                gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                pu_ActualizarTotales();

                }catch(Exception ex){
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString());
                }
        }



        private Boolean pu_GrabarHistorico() {
            try {

                int id=0;

                foreach (ro_historico_vacaciones_x_empleado_Info item in RoHistoricoVacaInfoLst)
                {
                    if (!oRo_historico_vacaciones_x_empleado_Bus.GrabarBD(item, ref id, ref mensaje)) {return false; }
                }

               return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public void pu_Grabar() {
            try {

                int id = 0;


                    if (getInfo())
                    {
                        if (oRo_SolicitudVacaciones_Bus.GrabarBD(info, ref id, ref mensaje))
                        {
                            info.IdSolicitudVaca = id;
                            txtIdSolicitud.Text = id.ToString();
                            dtpFechaRegistro.EditValue = info.Fecha;
                            dtpFechaInicio.Enabled = false;
                            dtpFechaFinal.Enabled = false;

                            if (pu_GrabarHistorico()) {
                             
                                 _Accion = Cl_Enumeradores.eTipo_action.grabar;


                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                               // Limpiar();
                            }
                            else {
                                MessageBox.Show("El registro no se pudo guardar errores en el Histórico, revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El registro no se pudo guardar, revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else {
                        MessageBox.Show("El registro no se pudo guardar, existen datos incorrectos revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }




        private Boolean pu_Validar()
        {
            try
            {


                if (cmbIdEmpleado.EditValue == null || cmbIdEmpleado.EditValue=="")
                {
                    MessageBox.Show("El nombre del Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbIdEmpleado.Focus();
                    return false;
                }

                info.IdEmpresa = param.IdEmpresa;
                info.IdEmpleado = Convert.ToDecimal(cmbIdEmpleado.EditValue);

                double dias=oRo_historico_vacaciones_x_empleado_Bus.CalcularDiasDeDiferencia(Convert.ToDateTime(oRo_Empleado_Info.em_fecha_ingreso),Convert.ToDateTime(param.Fecha_Transac));


                if(dias<360)
                {
                    MessageBox.Show("El Empleado tiene menos de 1 año de servicio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbIdEmpleado.Focus();
                    return false;
                }


                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (rbt_gozadas.Checked)
                    {
                        if (dtpFechaInicio.EditValue == null)
                        {
                            MessageBox.Show("La Fecha Inicial es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dtpFechaInicio.Focus();
                            return false;
                        }
                    }

                    info.Fecha_Desde = Convert.ToDateTime(dtpFechaInicio.EditValue);
                    /*
                    if (oRo_SolicitudVacaciones_Bus.getExisteFecha(info.IdEmpresa, info.IdEmpleado, info.Fecha_Desde))
                    {
                        MessageBox.Show("La Fecha Inicial de las vacaciones del Empleado ya existe en otra solicitud, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dtpFechaInicio.Focus();
                        return false;
                    }
                    */
                    if (rbt_gozadas.Checked)
                    {
                        if (dtpFechaFinal.EditValue == null)
                        {
                            MessageBox.Show("La Fecha Final es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dtpFechaFinal.Focus();
                            return false;
                        }
                    }
                    info.Fecha_Hasta = Convert.ToDateTime(dtpFechaFinal.EditValue);
                    /*
                    if (oRo_SolicitudVacaciones_Bus.getExisteFecha(info.IdEmpresa, info.IdEmpleado, info.Fecha_Hasta))
                    {
                        MessageBox.Show("La Fecha Final de las vacaciones del Empleado ya existe en otra solicitud, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dtpFechaFinal.Focus();
                        return false;
                    }
                     * */
                    if (rbt_gozadas.Checked)
                    {
                        if (info.Fecha_Hasta < info.Fecha_Desde)
                        {
                            MessageBox.Show("La Fecha Final no puede ser menor que la Fecha Inicial de las vacaciones del Empleado, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dtpFechaFinal.Focus();
                            return false;

                        }
                    }
                    if (rbt_gozadas.Checked)
                    {
                        if (dtpFechaRetorno.EditValue == null)
                        {
                            MessageBox.Show("La Fecha de Retorno es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            dtpFechaRetorno.Focus();
                            return false;
                        }
                    }

                    if (cmb_empleado_autoriza.EditValue == null ||cmb_empleado_autoriza.EditValue =="" )
                    {
                        MessageBox.Show("Seleccione el empleado que autoriza, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmb_empleado_autoriza.Focus();
                        return false;
                    }
                }



                if (Convert.ToInt32(txtAnioServicio.EditValue) == 0)
                {
                    MessageBox.Show("Debe seleccionar un Empleado con años de servicio", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (txtDiasCorresponde.EditValue != null)
                {
                    if (txtDiaDisfrutar.EditValue == null)
                    {
                        MessageBox.Show("Debe seleccionar el número de días que va a disfrutar el Empleado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }

                if (Convert.ToInt32(txtDiasPendientes.EditValue) < 0)
                {
                    MessageBox.Show("El Empleado seleccionado ha ocupado todos los días pendientes, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
      
                if (Convert.ToInt32(txtDiasCorresponde.EditValue) == 0)
                {
                    MessageBox.Show("Se han agotado los días que le corresponde a este Empleado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (Convert.ToInt32(txtDiasCorresponde.EditValue) < 0)
                    {
                        MessageBox.Show("Los días que le corresponde a este Empleado son negativos,\n no se puede guardar la información.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
          
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }


        }

     

        private void frmRo_Solicitud_Vacaciones_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Solicitud_Vacaciones_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void pu_CargaInicial() {
            try
            {
                 Lista_empleado.Add(new ro_Empleado_Info());

                Lista_empleado.AddRange(EmpleadoBus.Get_List_Empleado_(param.IdEmpresa));

                cmbIdEmpleado.Properties.DataSource = Lista_empleado;
                cmb_empleado_autoriza.Properties.DataSource = Lista_empleado;
                cmb_remplazo.Properties.DataSource = Lista_empleado;

   
                catInfo = new BindingList<ro_Catalogo_Info>(catBus.Get_List_Catalogo_x_Tipo(19));

                cmbEstado.Properties.DataSource = catInfo;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    foreach (var item in catInfo)
                    {
                        if (item.ca_descripcion == "Pendiente")
                            cmbEstado.EditValue = item.CodCatalogo;//*donde parametrizar??? 113                
                    }
                }
                txtAnioServicio.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void pu_MostrarDetalle(decimal IdEmpleado)
        {
            try
            {
                //persona info
                oRo_Empleado_Info = empBus.Get_Info_Empleado_x_IdEmpleado(param.IdEmpresa, IdEmpleado);

                if (oRo_Empleado_Info!=null)
                {
                    depInfo = depBus.Get_Info_Departamento(param.IdEmpresa, Convert.ToInt32(oRo_Empleado_Info.IdDepartamento));
                    
                    txtCedula.Text = oRo_Empleado_Info.InfoPersona.pe_cedulaRuc;
                    txtFechaIngreso.Text = oRo_Empleado_Info.em_fecha_ingreso.Value.ToShortDateString();

                    if(_Accion== Cl_Enumeradores.eTipo_action.grabar){
                        oRo_historico_vacaciones_x_empleado_Bus.GenerarVacacionesPorEmpleado(oRo_Empleado_Info, ref mensaje);
                        pu_ConsultarHistorico(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa);
                    }


               
                }
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }        
        
        private void frmRo_Solicitud_Vacaciones_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdSolicitud.Enabled = false;
                rbt_gozadas.Checked = true;
                txtDiasPendientes.Enabled = false;
              //  txtDiaDisfrutar.Enabled = false;
                ctrl.Dock = DockStyle.Fill;
                cmbIdEmpleado.Enabled = false;
                txtObservacion.Enabled = false;
                cmbEstado.Enabled = false;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;                
                        cmbIdEmpleado.Enabled = true;
                        dtpFechaInicio.Enabled = true;
                        dtpFechaFinal.Enabled = true;
                        txtObservacion.Enabled = true;
                        cmbEstado.Enabled = true;
                        lblEstado.Visible = false;
                        dtpFechaRegistro.EditValue = DateTime.Now;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        txtObservacion.Enabled = true;
                        if (info.IdEstadoAprobacion == "Negado" | info.Estado == "I") 
                        { cmbEstado.Enabled = false; } else { cmbEstado.Enabled = true; }
                        cmb_remplazo.Enabled = false;
                        cmb_empleado_autoriza.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false; 


                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false; 

                        break;
                    default:
                        break;
                } 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }  
        }

        private void txtDiasCorresponde_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRo_Solicitud_Vacaciones_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtpFechaInicio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbt_gozadas.Checked)
                {
                    pu_ActualizarTotales();
                    pu_CalcularVacaciones();
                    ObtenerFecha();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 
        }

        private void dtpFechaFinal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFechaRetorno.EditValue = Convert.ToDateTime(dtpFechaFinal.EditValue).AddDays(1);

                if (rbt_gozadas.Checked)
                {
                    pu_ActualizarTotales();
                    pu_CalcularVacaciones();
                    ObtenerFecha();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbEstado_EditValueChanged(object sender, EventArgs e)
        {
           
        }


        private void pu_RevertirVacaciones()
        {
            try
            {

               // if (pu_Validar())
              //  {
                    int diasDisfrutar = Convert.ToInt32(txtDiaDisfrutar.Text);
                    int diasPendientes = Convert.ToInt32(txtDiasPendientes.Text);

                    if (dtpFechaInicio.EditValue != null && dtpFechaFinal.EditValue != null)
                    {
                        if (diasPendientes > 0 && diasDisfrutar <= diasPendientes)
                        {
                            RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.pu_RevertirVacaciones(oRo_Empleado_Info.IdEmpresa, oRo_Empleado_Info.IdEmpleado, diasDisfrutar));
                            gridVacaciones.DataSource = RoHistoricoVacaInfoLst;

                        }
                        else
                        {
                            MessageBox.Show("El Empleado no tiene días pendientes de vacaciones", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

              //  }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void cmdRevertir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_RevertirVacaciones();
                pu_ActualizarTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                SumarDiasTomados = 0;
                if (cmbIdEmpleado.EditValue != "" && cmbIdEmpleado.EditValue != null)
                {
                    oRo_Empleado_Info = (ro_Empleado_Info)cmbIdEmpleado.Properties.View.GetFocusedRow();
                    if (oRo_Empleado_Info == null)
                        oRo_Empleado_Info = Lista_empleado.Where(v => v.IdEmpleado ==Convert.ToInt32( cmbIdEmpleado.EditValue) ).FirstOrDefault();
                    IdNomina_Tipo = oRo_Empleado_Info.IdNomina_Tipo;
                    pu_MostrarDetalle(Convert.ToInt32(cmbIdEmpleado.EditValue));
                }


                cmb_empleado_autoriza.Properties.DataSource = Lista_empleado.Where(v => v.IdEmpleado != Convert.ToDecimal(cmbIdEmpleado.EditValue)).ToList();
                cmb_empleado_autoriza.Refresh();

                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                InfoCalendario = Bus_Calendario.Get_Info_Calendario(Convert.ToDateTime(txtFechaIngreso.EditValue));

                int DiadAdicionales = 0;
                int AnioIngreso =(int) InfoCalendario.AnioFiscal;
                int MesIngreso=(int)InfoCalendario.Mes_x_anio;
                int DiaIngreso = (int)InfoCalendario.dia_x_mes;

                DateTime FechaInicioVaca = Convert.ToDateTime(Convert.ToString(DiaIngreso) + "/" + Convert.ToString(MesIngreso) + "/" + Convert.ToString(AnioIngreso + Convert.ToInt32(txtAnioServicio.EditValue)-1));

                DateTime FechaFinVacaciones = Convert.ToDateTime(Convert.ToString(DiaIngreso-1) + "/" + Convert.ToString(MesIngreso) + "/" + Convert.ToString(AnioIngreso + Convert.ToInt32(txtAnioServicio.EditValue)));

                
                ro_corte_actual = Convert.ToDateTime(txtFechaIngreso.EditValue);
                List_Reporte = BusReporte.Get_List_Vacaciones(param.IdEmpresa, info.IdEmpleado, FechaInicioVaca, Convert.ToDateTime(FechaFinVacaciones));
                XROL_Rpt013_rpt Rept = new XROL_Rpt013_rpt();

                Rept.Parameters["ro_fechaIngreso"].Value = txtFechaIngreso.EditValue.ToString();
                Rept.Parameters["ro_corte_actual"].Value = Convert.ToString(FechaFinVacaciones).Substring(0,10);
                if (Convert.ToInt32(txtAnioServicio.Text) > 5)
                {
                    DiadAdicionales = Convert.ToInt32(txtAnioServicio.Text) - 5;

                }
                Rept.Parameters["ro_dias_adicionales"].Value = DiadAdicionales;
                Rept.Parameters["ro_periodo"].Value = FechaInicioVaca.ToString().Substring(0, 10) + " al " + FechaFinVacaciones.ToString().Substring(0, 10);

                if (List_Reporte.Count() == 0)
                {
                    MessageBox.Show("No existen ingreso para el empleado en el periodo seleccionado");
                }
                else
                {
                    Rept.Set(List_Reporte);
                    Rept.ShowPreviewDialog();
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
                cmbIdEmpleado.Enabled = true;
                dtpFechaFinal.EditValue = null;
                dtpFechaInicio.EditValue = null;
                txtAnioServicio.Text = "";
                txtCedula.Text = "";
                txtDiaDisfrutar.Text = "";
                txtDiasCorresponde.Text = "";
                txtDiasPendientes.Text = "";
                txtIdSolicitud.Text = "";
                txtFechaIngreso.Text = "";
                txtObservacion.Text = "";
                dtpFechaRetorno.Text = "";
                dtpFechaRegistro.Text = "";
                dtpFechaRegistro.EditValue = DateTime.Now;
                dtpFechaRegistro.Enabled = true;
                dtpFechaInicio.Enabled = true;
                dtpFechaFinal.Enabled = true;
                cmbIdEmpleado.EditValue = null;
             


                RoHistoricoVacaInfoLst = new BindingList<ro_historico_vacaciones_x_empleado_Info>();
                gridVacaciones.DataSource = RoHistoricoVacaInfoLst;
                
            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_empleado_autoriza_EditValueChanged(object sender, EventArgs e)
        {
             try
            {
                if (cmb_empleado_autoriza.EditValue != null && cmb_empleado_autoriza.EditValue != "")
                    cmb_remplazo.Properties.DataSource = Lista_empleado.Where(v => v.IdEmpleado != Convert.ToDecimal(cmbIdEmpleado.EditValue) && v.IdEmpleado != Convert.ToDecimal(cmb_empleado_autoriza.EditValue)).ToList();    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        public void ObtenerFecha()
        {
            try
            {

                foreach (var item in RoHistoricoVacaInfoLst.Where(v=>v.check==true).ToList())
                {
                    Fecha_Anio_Inicio=item.FechaInicio;
                    Fecha_Anio_Fin=item.FechaFin;
                }
                 
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbt_pagadas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbt_pagadas.Checked)
                {
                    dtpFechaInicio.Properties.ReadOnly = true;
                    dtpFechaFinal.Properties.ReadOnly = true;
                    dtpFechaFinal.EditValue = null;
                    dtpFechaInicio.EditValue = null;
                }

                else
                {
                    dtpFechaInicio.Properties.ReadOnly = false;
                    dtpFechaFinal.Properties.ReadOnly = false;
                    
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtDiaDisfrutar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (!rbt_gozadas.Checked)
                {
                    pu_ActualizarTotales();
                    pu_CalcularVacaciones();
                    ObtenerFecha();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
               
        }

        private void cmb_remplazo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
