using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_ActaFiniquito : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string mensaje = "";
        decimal _idEmpleado = 0;
        double total_vacaciones = 0;
        //INFO
        ro_Empleado_Info oRo_Empleado_Info = new ro_Empleado_Info();
        ro_Acta_Finiquito_Info _Info = new ro_Acta_Finiquito_Info();
        List<ro_Catalogo_Info> oRo_CausaTerminacionLaboral_Info = new List<ro_Catalogo_Info>();
        List<ro_Catalogo_Info> oRo_TipoContrato= new List<ro_Catalogo_Info>();
        List<tb_Catalogo_Info> oTb_TipoIdentificacion = new List<tb_Catalogo_Info>();
        List<ro_contrato_Info> oLisrRo_Contrato_Info = new List<ro_contrato_Info>();
        List<ro_Cargo_Info> oListRo_Cargo_Info = new List<ro_Cargo_Info>();
        ro_contrato_Info InfoContrato = new ro_contrato_Info();
        List<ro_TablaSectorial_Info> oListRo_TablaSectorial_Info = new List<ro_TablaSectorial_Info>();
        BindingList<ro_Acta_Finiquito_Detalle_Info> oBListRo_Acta_Finiquito_Detalle_Ingresos_Info = new BindingList<ro_Acta_Finiquito_Detalle_Info>();
        BindingList<ro_Acta_Finiquito_Detalle_Info> oBListRo_Acta_Finiquito_Detalle_Egresos_Info = new BindingList<ro_Acta_Finiquito_Detalle_Info>();
        List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
        ro_historico_vacaciones_x_empleado_Bus oRo_historico_vacaciones_x_empleado_Bus = new ro_historico_vacaciones_x_empleado_Bus();
        BindingList<ro_historico_vacaciones_x_empleado_Info> detallevacaciones = new BindingList<ro_historico_vacaciones_x_empleado_Info>();


        //BUS
        ro_Acta_Finiquito_Bus oRo_Acta_Finiquito_Bus = new ro_Acta_Finiquito_Bus();
        ro_Acta_Finiquito_Detalle_Bus oRo_Acta_Finiquito_Detalle_Bus = new ro_Acta_Finiquito_Detalle_Bus();
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_contrato_bus oRo_Contrato_Bus = new ro_contrato_bus();
        ro_Catalogo_Bus oRo_Catalogo_Bus = new ro_Catalogo_Bus();
        tb_Catalogo_Bus oTb_Catalogo_Bus = new tb_Catalogo_Bus();
        ro_Cargo_Bus oRo_Cargo_Bus = new ro_Cargo_Bus();
        ro_TablaSectorial_Bus oRo_TablaSectorial_Bus = new ro_TablaSectorial_Bus();
        ro_Asignacion_Implemento_x_Empleado_Bus Bus_Implemento = new ro_Asignacion_Implemento_x_Empleado_Bus();
        //DELEGADOS
        public delegate void delegate_frmRo_ActaFiniquito_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_ActaFiniquito_FormClosing Event_frmRo_ActaFiniquito_FormClosing;

       

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

        #endregion
        public frmRo_ActaFiniquito()
        {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
        
            Event_frmRo_ActaFiniquito_FormClosing += frmRo_ActaFiniquito_Event_frmRo_ActaFiniquito_FormClosing;

            pu_CargarCombos();
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            pu_Imprimir();
        }

        private void pu_Imprimir() {
            try
            {
                XROL_Rpt007_frm oXROL_Rpt007_frm = new XROL_Rpt007_frm();
                oXROL_Rpt007_frm.setInfo(_Info.IdEmpresa, _Info.IdEmpleado, _Info.IdActaFiniquito);
                oXROL_Rpt007_frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }


        private void pu_Anular() {
            try {
                   decimal id=0;
                   string mensaje = "";

                   if (_Info != null)
                   {

                       if (MessageBox.Show("¿Está seguro que desea anular el Acta de Finiquito...?", "ANULACION" + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                           ofrm.ShowDialog();

                           _Info.IdUsuarioUltAnu = param.IdUsuario;
                           _Info.Fecha_UltMod = DateTime.Now;
                           _Info.MotiAnula = ofrm.motivoAnulacion;
                           _Info.Estado = "I";

                           if (oRo_Acta_Finiquito_Bus.GrabarBD(_Info, ref id, ref mensaje))
                           {
                               MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);

                               this.Close();
                           }
                           else
                           {
                               MessageBox.Show("Error al ANULAR el Acta de Finiquito, revise por favor: " + mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        
        
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            pu_Anular();
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            pu_Grabar();
            this.Close();
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            pu_Grabar();
        }

        void frmRo_ActaFiniquito_Event_frmRo_ActaFiniquito_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void pu_CargarCombos() {
            try {
                // Cargando Combo Empleados
                oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(param.IdEmpresa);
                cmbEmpleado.Properties.DataSource = oListRo_Empleado_Info.Where(V => V.em_status == "EST_PLQ").ToList();

                //LLENA EL COMBO - TIPO IDENTIFICACION
                oTb_TipoIdentificacion.AddRange(oTb_Catalogo_Bus.Get_CatalogoPorTipo(3));
                cmbTipoIdentificacion.Properties.ValueMember = "CodCatalogo";
                cmbTipoIdentificacion.Properties.DisplayMember = "ca_descripcion";
                cmbTipoIdentificacion.Properties.DataSource = oTb_TipoIdentificacion;

                //LLENA EL COMBO - TIPO CONTRATO
                oRo_TipoContrato.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(2));
                cmbTipoContrato.Properties.ValueMember = "CodCatalogo";//CodCatalogo = "CTR06"
                cmbTipoContrato.Properties.DisplayMember = "ca_descripcion";
                cmbTipoContrato.Properties.DataSource = oRo_TipoContrato;
                
                //LLENA EL COMBO - CAUSA TERMINACION LABORAL
                oRo_CausaTerminacionLaboral_Info.AddRange(oRo_Catalogo_Bus.Get_List_Catalogo_x_Tipo(24));
                cmbCausaTerminacion.Properties.ValueMember = "IdCatalogo";
                cmbCausaTerminacion.Properties.DisplayMember = "ca_descripcion";
                cmbCausaTerminacion.Properties.DataSource = oRo_CausaTerminacionLaboral_Info;

                //LLENAR EL COMBO - CARGO DEL EMPLEADO
                oListRo_Cargo_Info.AddRange(oRo_Cargo_Bus.ObtenerLstCargo(param.IdEmpresa));
                cmbCargo.Properties.ValueMember = "IdCargo";
                cmbCargo.Properties.DisplayMember = "ca_descripcion";
                cmbCargo.Properties.DataSource = oListRo_Cargo_Info;
                
                //LLENAR GRUPO OCUPACIONAL
                oListRo_TablaSectorial_Info.AddRange(oRo_TablaSectorial_Bus.ConsultaGeneral());
                cmbGrupoOcupacional.Properties.ValueMember = "IdCodSectorial";
                cmbGrupoOcupacional.Properties.DisplayMember = "Actividad";
                cmbGrupoOcupacional.Properties.DataSource = oListRo_TablaSectorial_Info;             


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }


        private void frmRo_ActaFiniquito_Load(object sender, EventArgs e)
        {
            try
            {
           
            cmbTipoContrato.Enabled = false;
            cmbContrato.Enabled = false;
            info_parametro = bus_parametro.Get_Parametros(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public void setInfo(ro_Acta_Finiquito_Info info)
        {
            try
            {
                _Info = info;
                cmbEmpleado.EditValue = _Info.IdEmpleado;
                pu_ObtenerContratosEmpleado();
                cmbContrato.EditValue = _Info.IdContrato;

                txtDepartamento.Text = _Info.Departamento;
                cmbTipoIdentificacion.EditValue= _Info.TipoIdentificacion;
                txtIdentificacion.Text = _Info.Identificacion;
                txtFechaNcto.Text = _Info.FechaNcto.Value.ToShortDateString();
                txtId.Text = _Info.IdActaFiniquito.ToString();
                cmbCausaTerminacion.EditValue=_Info.IdCausaTerminacion;
                cmbCargo.EditValue = _Info.IdCargo;
                cmbGrupoOcupacional.EditValue = _Info.IdCodSectorial;
                 cmbContrato.EditValue = _Info.IdContrato;
                 cmbTipoContrato.EditValue =_Info.IdContrato_Tipo;                
                cmbTipoContrato.EditValue = _Info.IdContrato_Tipo;
                dtpFechaInicioLabores.EditValue = _Info.FechaIngreso;
                dtpFechaSalidaLaboral.EditValue = _Info.FechaSalida;
                cmbCausaTerminacion.EditValue = _Info.IdCausaTerminacion;
                txtRemuneracion.Text = _Info.UltimaRemuneracion.ToString("N2");
                txtIngresos.Text = _Info.Ingresos.ToString("N2");
                txtEgresos.Text = _Info.Egresos.ToString("N2");
                txtTotalPagar.Text = (_Info.Ingresos - _Info.Egresos).ToString("N2");

                chkMujerEmbarazada.EditValue = _Info.EsMujerEmbarazada == null ? false : _Info.EsMujerEmbarazada;
                chkDirigenteSindical.EditValue = _Info.EsDirigenteSindical == null ? false : _Info.EsDirigenteSindical;
                chkPorDiscapacidad.EditValue = _Info.EsPorDiscapacidad == null ? false : _Info.EsPorDiscapacidad;
                chkEnfermedadNoProfesional.EditValue = _Info.EsPorEnfermedadNoProfesional == null ? false : _Info.EsPorEnfermedadNoProfesional;

                if (_Info.Estado == "I")
                {

                   

                    cmdCalcularLiquidacion.Enabled = false;
                    cmdProcesar.Enabled = false;
                }
                else
                {
                   
                }

                pu_CargarIngresos();
                pu_CargarEgresos();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        public Boolean getInfo() {
            try {

                    if (_Info == null) { _Info = new ro_Acta_Finiquito_Info(); }

                    _Info.IdEmpleado=Convert.ToDecimal(cmbEmpleado.EditValue);
                    _Info.IdActaFiniquito = txtId.Text == "" ? 0 : Convert.ToDecimal(txtId.Text);
                    _Info.IdEmpresa = param.IdEmpresa;
                    _Info.Identificacion=txtIdentificacion.Text;
                    _Info.IdContrato= Convert.ToDecimal(cmbContrato.EditValue) ;
                    if (dtpFechaInicioLabores.EditValue == null)
                    { MessageBox.Show(" Actualice la fecha de ingreso del empeado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                    }
                    _Info.FechaIngreso=Convert.ToDateTime(dtpFechaInicioLabores.EditValue);
                    _Info.FechaSalida=Convert.ToDateTime(dtpFechaSalidaLaboral.EditValue);
                    _Info.IdCausaTerminacion = cmbCausaTerminacion.EditValue.ToString(); ;
                    _Info.UltimaRemuneracion=Convert.ToDouble(txtRemuneracion.Text);
                    _Info.IdCargo = Convert.ToInt32(cmbCargo.EditValue);
                    _Info.IdCodSectorial = Convert.ToInt32(cmbGrupoOcupacional.EditValue) == null ? 0 : Convert.ToInt32(cmbGrupoOcupacional.EditValue);
                    
                    _Info.Ingresos= Convert.ToDouble(txtIngresos.Text);
                    _Info.Egresos = Convert.ToDouble(txtEgresos.Text);            
                    _Info.Observacion = "";

                    _Info.EsMujerEmbarazada = Convert.ToBoolean(chkMujerEmbarazada.EditValue);
                    _Info.EsDirigenteSindical = Convert.ToBoolean(chkDirigenteSindical.EditValue);
                    _Info.EsPorDiscapacidad = Convert.ToBoolean(chkPorDiscapacidad.EditValue);
                    _Info.EsPorEnfermedadNoProfesional = Convert.ToBoolean(chkEnfermedadNoProfesional.EditValue);
                    _Info.IdNomina_Tipo = oRo_Empleado_Info.IdNomina_Tipo;
                    getInfoDetalle();

                return true;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        }


        public void setAccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;
                cmbEmpleado.Enabled = false;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        //Limpiar();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        cmbEmpleado.Enabled = true;
                        txtIngresos.Text = "0";
                        txtEgresos.Text = "0";
                        txtTotalPagar.Text="0";

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
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


        private void frmRo_ActaFiniquito_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_ActaFiniquito_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private Boolean pu_Validar() 
        {
            try 
            {


                if( cmbEmpleado.EditValue==""){
                   MessageBox.Show("Debe seleccionar el Empleado es obligatorio, revise por favor","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                   cmbEmpleado.Focus();
                   return false;
                }

                if (cmbContrato.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar un contrato es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbContrato.Focus();
                    return false;
                }

                if (cmbCausaTerminacion.EditValue == null)
                {
                    MessageBox.Show("Debe seleccionar la Causa de Terminación del contrato es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbCausaTerminacion.Focus();
                    return false;
                }

                if (Convert.ToDateTime(dtpFechaInicioLabores.EditValue) > Convert.ToDateTime(dtpFechaSalidaLaboral.EditValue))
                {
                    MessageBox.Show("La Fecha de Salida del Empleado no puede ser menor a la Fecha de Ingreso, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRemuneracion.Focus();
                    return false;
                }

                
                if (txtRemuneracion.EditValue == null)
                {
                    MessageBox.Show("Debe ingresar el valor de la última Remuneración del Empleado es obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRemuneracion.Focus();
                    return false;
                }

                if (Convert.ToDouble(txtRemuneracion.Text)<=0)
                {
                    MessageBox.Show("El valor de la última Remuneración del Empleado debe ser mayor que cero, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtRemuneracion.Focus();
                    return false;
                }
                oRo_Empleado_Info = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (oRo_Empleado_Info == null)
                    oRo_Empleado_Info = oListRo_Empleado_Info.Where(v => v.IdEmpleado == Convert.ToDecimal(cmbEmpleado.EditValue)).FirstOrDefault();
                if (Bus_Implemento.Get_si_existe_Implemento_pendiente_devolver(param.IdEmpresa, oRo_Empleado_Info.IdNomina_Tipo, Convert.ToInt32(oRo_Empleado_Info.IdEmpleado)))
                {
                    MessageBox.Show("El empleado tiene implemento pendientes de devolver", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }







             







                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }
        
        }


        private void pu_Grabar() {
            try {
                decimal id=0;
                mensaje = "";

                if(pu_Validar()){
                    if (getInfo())
                    {
                        if (oRo_Acta_Finiquito_Bus.GrabarBD(_Info, ref id, ref mensaje))
                        {
                            txtId.Text = id.ToString();
                            Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            setAccion(Accion);
                            MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se pudo guardar, revise por favor: " + mensaje, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("El registro no se pudo guardar, existen errores en los datos, revise por favor: " + mensaje, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }  
                }
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(mensaje);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void pu_ObtenerContratosEmpleado() 
        {
            try 
            {

                if (cmbEmpleado.EditValue != null)
                {
                    _idEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                    oLisrRo_Contrato_Info = oRo_Contrato_Bus.GetListPorEmpleado(param.IdEmpresa, _idEmpleado);
                    cmbContrato.Properties.DataSource = oLisrRo_Contrato_Info;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }        
        }


        private void cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try 
            {
                oRo_Empleado_Info = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (oRo_Empleado_Info == null)
                    oRo_Empleado_Info = oListRo_Empleado_Info.Where(v => v.IdEmpleado == Convert.ToDecimal(cmbEmpleado.EditValue)).FirstOrDefault();
                if(cmbEmpleado.EditValue!=null && Accion==Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    _idEmpleado = Convert.ToDecimal(cmbEmpleado.EditValue);
                    
                    //OBTIENE LA LISTA DE CONTRATOS
                    pu_ObtenerContratosEmpleado();

                    //oRo_Empleado_Info = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetRow(cmbEmpleado.Properties.GetIndexByKeyValue(cmbEmpleado.EditValue));

                    ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();

                        oRo_Empleado_Info = oRo_Empleado_Bus.GetInfoConsultaPorIdEmpleado(param.IdEmpresa, _idEmpleado);                                          
                        oLisrRo_Contrato_Info=   oRo_Contrato_Bus.GetListPorEmpleado(param.IdEmpresa, Convert.ToInt32(cmbEmpleado.EditValue)).Where(v => v.EstadoContrato == "ECT_ACT").ToList();
                        cmbContrato.Properties.DataSource =oLisrRo_Contrato_Info;
                        InfoContrato = oLisrRo_Contrato_Info.FirstOrDefault();
                        cmbContrato.EditValue = InfoContrato.IdContrato;
                        cmbTipoContrato.EditValue = InfoContrato.IdContrato_Tipo;
                        dtpFechaInicioLabores.EditValue = InfoContrato.FechaInicio;
                        txtDepartamento.Text = oRo_Empleado_Info.de_descripcion.Trim();
                        cmbCargo.EditValue = oRo_Empleado_Info.IdCargo;
                        txtRemuneracion.Text = oRo_Empleado_Info.em_sueldoBasicoMen.ToString();

                    txtIdentificacion.Text = oRo_Empleado_Info.InfoPersona.pe_cedulaRuc.Trim();
                    txtFechaNcto.Text = oRo_Empleado_Info.InfoPersona.pe_fechaNacimiento.Value.ToShortDateString() ;
                    dtpFechaInicioLabores.EditValue = oRo_Empleado_Info.em_fecha_ingreso;
                    cmbTipoIdentificacion.EditValue = oRo_Empleado_Info.InfoPersona.IdTipoDocumento;
                    dtpFechaSalidaLaboral.EditValue = oRo_Empleado_Info.em_fechaSalida;
                    cmbGrupoOcupacional.EditValue = oRo_Empleado_Info.IdCodSectorial == null ? 0 : oRo_Empleado_Info.IdCodSectorial;

                    



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }




        public void pu_CargarIngresos()
        {
            try
            {

                oBListRo_Acta_Finiquito_Detalle_Ingresos_Info = new BindingList<ro_Acta_Finiquito_Detalle_Info>(oRo_Acta_Finiquito_Detalle_Bus.GetListConsultaPorId(_Info.IdEmpresa, _Info.IdEmpleado, _Info.IdActaFiniquito).Where(v => v.Signo == "+").ToList());
                gridIngresos.DataSource = oBListRo_Acta_Finiquito_Detalle_Ingresos_Info;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void pu_CargarEgresos()
        {
            try
            {
                oBListRo_Acta_Finiquito_Detalle_Egresos_Info = new BindingList<ro_Acta_Finiquito_Detalle_Info>(oRo_Acta_Finiquito_Detalle_Bus.GetListConsultaPorId(_Info.IdEmpresa, _Info.IdEmpleado, _Info.IdActaFiniquito).Where(v => v.Signo == "-").ToList());
                gridEgresos.DataSource = oBListRo_Acta_Finiquito_Detalle_Egresos_Info;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }


        private void getInfoDetalle()
        {
            try
            {
                int secuencia = 0;
                if(_Info!=null){

                    _Info.oListRo_Acta_Finiquito_Detalle_Info.Clear();
                    
                    //CARGAR INGRESOS
                    
                  //  oBListRo_Acta_Finiquito_Detalle_Ingresos_Info = (BindingList<ro_Acta_Finiquito_Detalle_Info>)gridIngresos.DataSource;
                    foreach (ro_Acta_Finiquito_Detalle_Info oRo_Acta_Finiquito_Detalle_Info in oBListRo_Acta_Finiquito_Detalle_Ingresos_Info)
                    {
                        oRo_Acta_Finiquito_Detalle_Info.IdEmpresa = _Info.IdEmpresa;
                        oRo_Acta_Finiquito_Detalle_Info.IdEmpleado = _Info.IdEmpleado;
                        oRo_Acta_Finiquito_Detalle_Info.IdActaFiniquito= _Info.IdActaFiniquito;
                        oRo_Acta_Finiquito_Detalle_Info.IdSecuencia = secuencia;
                        oRo_Acta_Finiquito_Detalle_Info.Signo = "+";

                        _Info.oListRo_Acta_Finiquito_Detalle_Info.Add(oRo_Acta_Finiquito_Detalle_Info);
                        secuencia++;
                    }

                   // oBListRo_Acta_Finiquito_Detalle_Egresos_Info = (BindingList<ro_Acta_Finiquito_Detalle_Info>)gridEgresos.DataSource;
                    foreach (ro_Acta_Finiquito_Detalle_Info oRo_Acta_Finiquito_Detalle_Info in oBListRo_Acta_Finiquito_Detalle_Egresos_Info)
                    {
                        oRo_Acta_Finiquito_Detalle_Info.IdEmpresa = _Info.IdEmpresa;
                        oRo_Acta_Finiquito_Detalle_Info.IdEmpleado = _Info.IdEmpleado;
                        oRo_Acta_Finiquito_Detalle_Info.IdActaFiniquito = _Info.IdActaFiniquito;
                        oRo_Acta_Finiquito_Detalle_Info.IdSecuencia = secuencia;
                        oRo_Acta_Finiquito_Detalle_Info.Signo = "-";
                        
                        _Info.oListRo_Acta_Finiquito_Detalle_Info.Add(oRo_Acta_Finiquito_Detalle_Info);
                        secuencia++;
                    }


                    foreach (var item in detallevacaciones)
                    {
                        ro_Acta_Finiquito_Detalle_Info info_ = new ro_Acta_Finiquito_Detalle_Info();
                        info_.IdEmpresa = _Info.IdEmpresa;
                        info_.IdEmpleado = _Info.IdEmpleado;
                        info_.IdActaFiniquito = _Info.IdActaFiniquito;
                        info_.IdSecuencia = secuencia;
                        info_.Signo = "+";
                        info_.Observacion= " vacaciones no gozadas de "+item.FechaInicio+" al "+item.FechaFin;
                        info_.Valor = item.Vacaciones;
                        info_.Otros_valor = item.otro_valor;
                        secuencia++;
                        _Info.oListRo_Acta_Finiquito_Detalle_Info.Add(info_);
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }


        private void pu_CalcularLiquidacion() {
            try
            {

                if (pu_Validar())
                {
                    if (getInfo())
                    {
                        if (_Info != null && _Info.IdActaFiniquito > 0)
                        {
                            oRo_Acta_Finiquito_Bus = new ro_Acta_Finiquito_Bus(_Info);
                            oRo_Acta_Finiquito_Bus.pu_CalcularValoresPendientes();
                            pu_CargarIngresos();
                            pu_CargarEgresos();
                            pu_ActualizarTotales();
                        }
                        else
                        {
                            MessageBox.Show("Es importante que primero guarde los cambios antes de continuar con el Cálculo de la Liquidación", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Existen errores en los datos, revise por favor: " + mensaje, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } 
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        private void pu_ActualizarTotales()
        {
            try
            {

                double totIngresos = 0;// Convert.ToDouble(colValor.SummaryText);
                double totEgresos = 0;// Convert.ToDouble(colValor1.SummaryText);

                foreach (var item1 in oBListRo_Acta_Finiquito_Detalle_Ingresos_Info)
                {
                    totIngresos += item1.Valor;
                }

                foreach (var item2 in oBListRo_Acta_Finiquito_Detalle_Egresos_Info)
                {
                    totEgresos += item2.Valor;
                }
                double tot = total_vacaciones + totIngresos;

                txtIngresos.Text = tot.ToString("N2");
                txtEgresos.Text = totEgresos.ToString("N2");
                txtTotalPagar.Text = (tot - totEgresos).ToString("N2");
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }



        private void cmdCalcularLiquidacion_Click(object sender, EventArgs e)
        {
            pu_CalcularLiquidacion();

           
        }

        private void viewIngresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            pu_ActualizarTotales();
        }

        private void viewEgresos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            pu_ActualizarTotales();
        }

        private void viewIngresos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //pu_ActualizarTotales();
        }




        private void pu_ProcesarLiquidacion() {
            try
            {
                decimal id = 0;

                if (info_parametro.GeneraOP_ActaFiniquito == true)
                {
                    if (!ValidarParametrosOP())
                        return;
                }



            if (info_parametro.GeneraOP_ActaFiniquito == true)
            {
                if (Convert.ToInt32(txtTotalPagar.EditValue) > 0)
                {
                    Get_OrdenPago();
                    Get_Comprobante_contable();
                }
            }
                decimal id_OP = 0;
                decimal id_detalle_OP = 0;
                string mensajeError = "";
                decimal IdCbteCble = 0;



                if (MessageBox.Show("Está seguro que desea Liquidar al Empleado, recuerde que una vez procesado el mismo quedará inhabilitado en el Sistema","CONFIRMACION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {







                    if (info_parametro.GeneraOP_ActaFiniquito == true)
                    {
                        if (Convert.ToInt32(txtTotalPagar.EditValue) > 0)
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








                    oRo_Empleado_Info = oRo_Empleado_Bus.GetInfoConsultaPorIdEmpleado(param.IdEmpresa, _idEmpleado);

                    if (oRo_Empleado_Info != null)
                    {
                        //MODIFICA EL ESTADO DEL EMPLEADO AL ESTADO LIQUIDADO Y LO INACTIVA
                        oRo_Empleado_Info.em_status = "EST_LIQ";
                        oRo_Empleado_Info.em_estado = "I";
                        oRo_Empleado_Info.em_fechaSalida = Convert.ToDateTime(dtpFechaSalidaLaboral.EditValue);
                        decimal IdP = 0;
                        if (oRo_Empleado_Bus.GrabarDB(oRo_Empleado_Info, ref id, ref IdP, ref mensaje))
                        {
                            InfoContrato.Estado = "I";
                            InfoContrato.EstadoContrato = "EST_LIQ";
                            
                            if (oRo_Contrato_Bus.CambiarEstadoContrado(param.IdEmpresa,Convert.ToInt32( oRo_Empleado_Info.IdEmpleado),Convert.ToInt32(cmbContrato.EditValue)))
                            {
                                MessageBox.Show("El Empleado ha sido Liquidado con éxito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

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



        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            pu_ProcesarLiquidacion();
        }

        private void frmRo_ActaFiniquito_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }



        private void BetPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                int IdNomina_Tipo_Liq = 0;

                oRo_Empleado_Info = (ro_Empleado_Info)cmbEmpleado.Properties.View.GetFocusedRow();
                if (oRo_Empleado_Info == null)
                {
                    oRo_Empleado_Info = oListRo_Empleado_Info.Where(v => v.IdEmpleado == Convert.ToInt32(cmbEmpleado.EditValue)).FirstOrDefault();
                }
                
                frmRo_Prestamos Frm = new frmRo_Prestamos();
                Frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                if (oRo_Empleado_Info.IdNomina_Tipo == 1)
                {
                    IdNomina_Tipo_Liq = 2;

                }
                else
                {
                    IdNomina_Tipo_Liq = 1;
                }

                Frm.Set_IdEmpleado(Convert.ToInt32(oRo_Empleado_Info.IdEmpleado), Convert.ToInt32(oRo_Empleado_Info.IdNomina_Tipo));
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void BtnNovedad_Click(object sender, EventArgs e)
        {
            try
            {
                int IdNomina_Tipo_Liq = 0;
                oRo_Empleado_Info =(ro_Empleado_Info) cmbEmpleado.Properties.View.GetFocusedRow();
                if (oRo_Empleado_Info == null)
                {
                    oRo_Empleado_Info = oListRo_Empleado_Info.Where(v => v.IdEmpleado == Convert.ToInt32(cmbEmpleado.EditValue)).FirstOrDefault();
                }


                frmRo_Empleado_Novedad_Mant Frm =new frmRo_Empleado_Novedad_Mant();
                Frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                if (oRo_Empleado_Info.IdNomina_Tipo == 1)
                {
                    IdNomina_Tipo_Liq = 2;

                }
                else
                {
                    IdNomina_Tipo_Liq = 1;
                }

                Frm.Set_IdEmpleado(Convert.ToInt32(oRo_Empleado_Info.IdEmpleado), Convert.ToInt32(oRo_Empleado_Info.IdNomina_Tipo), IdNomina_Tipo_Liq);
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void cmbCausaTerminacion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void viewVacaciones_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                if (e.Column.Name == "Col_Remuneracion" || e.Column.Name == "colDiasTomados" || e.Column.Name == "colDiasGanados" || e.Column.Name == "Col_otro_valor")
                {
                    int Dias_Pendientes = 0;
                    int Dias_Ganados = 0;
                    int dias_tomados = 0;
                    double TotalRemuneracion = 0;
                    double vacaciones = 0;
                    double otros_valor_restar = 0;
                    Dias_Ganados = (Convert.ToInt32(viewVacaciones.GetFocusedRowCellValue(colDiasGanados)));
                    dias_tomados = (Convert.ToInt32(viewVacaciones.GetFocusedRowCellValue(colDiasTomados)));
                    otros_valor_restar = (Convert.ToDouble(viewVacaciones.GetFocusedRowCellValue(Col_otro_valor)));

                    Dias_Pendientes = Dias_Ganados - dias_tomados;
                    viewVacaciones.SetFocusedRowCellValue(colDiasPendientes, (Dias_Pendientes));

                    TotalRemuneracion = (Convert.ToDouble(viewVacaciones.GetFocusedRowCellValue(Col_Remuneracion)));
                    vacaciones = ((TotalRemuneracion / 24) / 15) * Dias_Pendientes;
                    viewVacaciones.SetFocusedRowCellValue(Col_vacaciones, (vacaciones - otros_valor_restar));


                    if(detallevacaciones.Count()>0)
                    total_vacaciones = detallevacaciones.Sum(v => v.Vacaciones);


                    pu_ActualizarTotales();

                }
            }
            catch (Exception ex)
            {


            }
        
        }



        public void pu_MostrarDetalle(ro_Empleado_Info oRo_Empleado_Info)
        {
            try
            {
                oRo_historico_vacaciones_x_empleado_Bus.GenerarVacacionesPorEmpleado(oRo_Empleado_Info, ref mensaje);
                detallevacaciones = new BindingList<ro_historico_vacaciones_x_empleado_Info>(oRo_historico_vacaciones_x_empleado_Bus.ConsultarHistoricoVaca(oRo_Empleado_Info.IdEmpleado, oRo_Empleado_Info.IdEmpresa));
                gridVacaciones.DataSource = detallevacaciones;

                gridVacaciones.RefreshDataSource();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

       

        private void nuevoToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                pu_MostrarDetalle(oRo_Empleado_Info);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
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
                Info_Orden_Pago.Observacion = "Liquidacion por"+ cmbContrato.Text;
                Info_Orden_Pago.IdTipo_op = info_parametro.IdTipoOP_ActaFiniquito;
                Info_Orden_Pago.IdTipo_Persona = "EMPLEADO";
                Info_Orden_Pago.IdPersona =Convert.ToInt32( cmbEmpleado.EditValue);
                Info_Orden_Pago.IdEntidad  =Convert.ToInt32( cmbEmpleado.EditValue);
                Info_Orden_Pago.Fecha = Convert.ToDateTime(DateTime.Now);
                Info_Orden_Pago.IdEstadoAprobacion = "PENDI";
                Info_Orden_Pago.IdFormaPago = info_parametro.IdFormaPagoOP_ActaFiniquito;
                Info_Orden_Pago.Fecha_Pago = Convert.ToDateTime(DateTime.Now);
                Info_Orden_Pago.Estado = "A";
                Info_Orden_Pago.Fecha =  Convert.ToDateTime(DateTime.Now);
                Info_Orden_Pago.IdUsuario = param.IdUsuario;
                Info_Orden_Pago.IdTipoFlujo = info_parametro.IdTipoFlujoOP_LiquidacionVacaciones;
                // detalle

                cp_orden_pago_det_Info info_detalle = new Info.CuentasxPagar.cp_orden_pago_det_Info();
                info_detalle.IdEmpresa = param.IdEmpresa;
                info_detalle.IdOrdenPago = 0;
                info_detalle.Secuencia = 1;
                info_detalle.Valor_a_pagar = Convert.ToDouble(txtTotalPagar.EditValue);
                info_detalle.Referencia = "Liquidacio haberes";
                info_detalle.IdFormaPago = info_parametro.IdFormaPagoOP_ActaFiniquito;
                info_detalle.Fecha_Pago = Convert.ToDateTime(DateTime.Now);
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
                Info_comprobante_Contable.IdPeriodo = Convert.ToInt32(Convert.ToDateTime(DateTime.Now).Year.ToString() + Convert.ToDateTime(DateTime.Now).Month.ToString().PadLeft(2, '0'));
                Info_comprobante_Contable.cb_Fecha = Convert.ToDateTime(DateTime.Now);
                Info_comprobante_Contable.cb_Observacion = "Liquidacion " + cmbEmpleado.Text + " " + cmbContrato.Text;
                Info_comprobante_Contable.Secuencia = 0;
                Info_comprobante_Contable.cb_Valor = Convert.ToDouble(txtTotalPagar.EditValue);
                Info_comprobante_Contable.Estado = "A";
                Info_comprobante_Contable.Anio = Convert.ToDateTime(DateTime.Now).Year;
                Info_comprobante_Contable.Mes = Convert.ToDateTime(DateTime.Now).Month;
                Info_comprobante_Contable.IdUsuario = param.IdUsuario;
                Info_comprobante_Contable.cb_FechaTransac = DateTime.Now;
                Info_comprobante_Contable.Mayorizado = "N";
                // detalle
                ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                haber.IdEmpresa = param.IdEmpresa;
                haber.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                haber.secuencia = 1;
                haber.IdCtaCble = info_tipoOP.IdCtaCble;
                haber.dc_Valor = Convert.ToDouble(txtTotalPagar.EditValue);
                haber.dc_Observacion = "Liquidacion " +cmbEmpleado.Text+" "+cmbContrato.Text;
                Lista_Comprobante_Contable.Add(haber);


                ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                debe.IdEmpresa = param.IdEmpresa;
                debe.IdTipoCbte = Convert.ToInt32(info_parametro.IdTipoCbte_AsientoSueldoXPagar);
                debe.secuencia = 2;
                debe.IdCtaCble = info_tipoOP.IdCtaCble_Credito;
                debe.dc_Valor = Convert.ToDouble(txtTotalPagar.EditValue)*-1;
                debe.dc_Observacion = "Liquidacion " + cmbEmpleado.Text + " " + cmbContrato.Text;
                Lista_Comprobante_Contable.Add(debe);

                Info_comprobante_Contable._cbteCble_det_lista_info = Lista_Comprobante_Contable;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private bool ValidarParametrosOP()
        {
            try
            {
                info_tipoOP = bus_tipoOP.Get_Info_orden_pago_tipo_x_empresa(param.IdEmpresa, info_parametro.IdTipoOP_LiquidacionVacaciones);

                
                if (info_parametro.GeneraOP_PagoPrestamos == true)
                {
                    if (info_parametro.IdFormaOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show("Faltan parametros ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (info_parametro.IdBancoOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }

                    if (info_parametro.IdTipoCbte_AsientoSueldoXPagar == null)
                    {
                        MessageBox.Show("Seleccione el tipo de comprobante contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }




                    if (info_tipoOP.IdCtaCble == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Cta Credito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }


                    if (info_parametro.IdFormaOP_LiquidacionVacaciones == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;

                    }




                }
                return true;


            }
            catch (Exception)
            {

                return false;
            }
        }

        private void viewIngresos_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 pu_ActualizarTotales();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void viewEgresos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    viewEgresos.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }

        private void viewIngresos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    viewIngresos.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.InnerException.ToString());
            }
        }
     
    }
}
