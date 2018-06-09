/*CLASE: frmRo_RDEP_Mant
 *CREADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_RDEP_Mant : Form
    {
        //VARIABLES
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        string mensaje = "";

        //INFO
        ro_Rdep_Info _Info = new ro_Rdep_Info();
        List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();

        //BUS
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        ro_Rdep_Bus oRo_Rdep_Bus = new ro_Rdep_Bus();

        //DELEGADOS
        public delegate void delegate_frmRo_RDEP_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_RDEP_Mant_FormClosing Event_frmRo_RDEP_Mant_FormClosing;



        public frmRo_RDEP_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;

            Event_frmRo_RDEP_Mant_FormClosing += frmRo_RDEP_Mant_Event_frmRo_RDEP_Mant_FormClosing;
        
            pu_CargaInicial();
        }

        void frmRo_RDEP_Mant_Event_frmRo_RDEP_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
                this.Close();
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
                pu_Guardar();
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_CargaInicial() {
            try { 
                // Cargando combo de Empleado
                oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(param.IdEmpresa);
                this.cmbEmpleados.Properties.DataSource = oListRo_Empleado_Info;

                //COMBO PERIODOFISCAL
                int anioActual = 0;
                anioActual = param.Fecha_Transac.Year;

                for (int i = 10; i > 0; i--)
                {
                    cmbAnioFiscal.Items.Add(anioActual);
                    anioActual -= 1;
                }

                if (cmbAnioFiscal.Items.Count > 0)
                {
                    cmbAnioFiscal.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }  
        }


        public void setAccion(Cl_Enumeradores.eTipo_action accion)
        {
            try {
                
                _Accion = accion;

                lbl_Estado.Visible = false;
                cmbEmpleados.Properties.ReadOnly = true;
                cmbAnioFiscal.Enabled = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        CheckEstado.Enabled = false;
                        CheckEstado.Checked = true;
                        cmbEmpleados.Properties.ReadOnly = false;
                        cmbAnioFiscal.Enabled = true;

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        pu_SetearCero();

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
        

        private void frmRo_RDEP_Mant_Load(object sender, EventArgs e)
        {
           

        }



        //private Boolean pu_Validar() {
        //    try {

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //        return false;
        //    }
        //}


        private Boolean getInfo()
        {
            try
            {
                if (cmbEmpleados.EditValue.ToString() != "")
                {
                    _Info.IdEmpresa = param.IdEmpresa;
                    _Info.IdEmpleado = Convert.ToInt32(cmbEmpleados.EditValue);
                    _Info.AnioFiscal = Convert.ToInt32(cmbAnioFiscal.Text);
                    _Info.Observacion = txtObservacion.Text.Trim();

                    _Info.apoPerIess = txtAporteIESSEmpleador.Text;
                    _Info.aporPerIessConOtrosEmpls = txtAporteIESSOtroEmpleador.Text;
                    _Info.basImp = txtBaseImponibleGravada.Text;
                    _Info.salarioDigno = txtCompensacionSueldoDigno.Text;
                    _Info.decimCuar = txtDecimoCuartoSueldo.Text;
                    _Info.decimTer = txtDecimoTercerSueldo.Text;
                    _Info.deducAliement = txtDeduccionAlimentacion.Text;
                    _Info.deducEduca = txtDeduccionEducacion.Text;
                    _Info.deducSalud = txtDeduccionSalud.Text;
                    _Info.deducVestim = txtDeduccionVestimenta.Text;
                    _Info.deducVivienda = txtDeduccionVivienda.Text;
                    _Info.exoDiscap = txtExoneracionDiscapacidad.Text;
                    _Info.exoTerEd = txtExoneracionTercerEdad.Text;
                    _Info.fondoReserva = txtFondoReserva.Text;
                    _Info.impRentEmpl = txtImpuestoAsumidoEmpleador.Text;
                    _Info.impRentCaus = txtImpuestoRentaCausado.Text;
                    _Info.ingGravConEsteEmpl = txtIngresosGravadosEmpleadorInformativo.Text;
                    _Info.intGrabGen = txtIngresosGravadoOtroEmpleador.Text;
                    _Info.otrosIngRenGrav = txtOtrosIngresosNoRentaGravada.Text;
                    _Info.sobSuelComRemu = txtSobresueldo.Text;
                    _Info.suelSal = txtSueldoSalario.Text;
                    _Info.partUtil = txtUtilidad.Text;
                    _Info.valImpAsuEsteEmpl = txtValorImpuestoAsumidoPorEmpleador.Text;
                    _Info.valRetAsuOtrosEmpls = txtValorImpuestoRetenidoAsumidoPorOtroEmpleador.Text;
                    _Info.valRet = txtValorImpuestoRetenidoPorEmpleador.Text;

                    _Info.Estado = CheckEstado.Checked == true ? "A" : "I";
                    return true;
                }
                else 
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void setInfo(ro_Rdep_Info info)
        {
            try
            {
                _Info = info;

                cmbEmpleados.EditValue = _Info.IdEmpleado;
                ro_Empleado_Info tmp=new ro_Empleado_Info();

                //tmp = oRo_Empleado_Bus.Obtener_1_Empleado(_Info.IdEmpresa, _Info.IdEmpleado);
                txtIdentificacion.Text = _Info.CedulaRuc;
                txtIdEmpleado.Text = _Info.IdEmpleado.ToString();
                txtObservacion.Text = _Info.Observacion;
                txtFechaRegistro.Text = _Info.FechaIngresa.ToShortDateString();
               
                txtAporteIESSEmpleador.Text = _Info.apoPerIess;
                txtAporteIESSOtroEmpleador.Text = _Info.aporPerIessConOtrosEmpls;
                txtBaseImponibleGravada.Text = _Info.basImp;
                txtCompensacionSueldoDigno.Text = _Info.salarioDigno;
                txtDecimoCuartoSueldo.Text = _Info.decimCuar;
                txtDecimoTercerSueldo.Text = _Info.decimTer;
                txtDeduccionAlimentacion.Text = _Info.deducAliement;
                txtDeduccionEducacion.Text = _Info.deducEduca;
                txtDeduccionSalud.Text = _Info.deducSalud;
                txtDeduccionVestimenta.Text = _Info.deducVestim;
                txtDeduccionVivienda.Text = _Info.deducVivienda;
                txtExoneracionDiscapacidad.Text = _Info.exoDiscap;
                txtExoneracionTercerEdad.Text = _Info.exoTerEd;
                txtFechaRegistro.Text = _Info.FechaIngresa.ToShortDateString();
                txtFondoReserva.Text = _Info.fondoReserva;
                txtImpuestoAsumidoEmpleador.Text = _Info.impRentEmpl;
                txtImpuestoRentaCausado.Text = _Info.impRentCaus;
                txtIngresosGravadosEmpleadorInformativo.Text = _Info.ingGravConEsteEmpl;
                txtIngresosGravadoOtroEmpleador.Text = _Info.intGrabGen;
                txtOtrosIngresosNoRentaGravada.Text = _Info.otrosIngRenGrav;
                txtSobresueldo.Text = _Info.sobSuelComRemu;
                txtSueldoSalario.Text = _Info.suelSal;
                txtUtilidad.Text = _Info.partUtil;
                txtValorImpuestoAsumidoPorEmpleador.Text = _Info.valImpAsuEsteEmpl;
                txtValorImpuestoRetenidoAsumidoPorOtroEmpleador.Text = _Info.valRetAsuOtrosEmpls;
                txtValorImpuestoRetenidoPorEmpleador.Text = _Info.valRet;

                if (_Info.Estado == "I")
                {
                    lbl_Estado.Visible = true;
                    CheckEstado.Checked = false;
                }
                else
                {
                    lbl_Estado.Visible = false;
                    CheckEstado.Checked = true;
                }

  
                return ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        
        private void pu_Guardar()
        {
            try
            {
                mensaje = "";
                    if(getInfo()){

                        //VALIDAR
                        if(oRo_Rdep_Bus.pu_ValidarRDEP(_Info,ref mensaje )){

                            //GRABAR
                            if (oRo_Rdep_Bus.GuardarBD(_Info, ref mensaje))
                            {
                                cmbEmpleados.Properties.ReadOnly = true;
                                cmbAnioFiscal.Enabled = false;
                                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                                MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("El registro no se pudo guardar, revise por favor: " + mensaje, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }else{
                                MessageBox.Show(mensaje, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                    
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Existen datos con errores, revise por favor","ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }               
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_SetearCero()
        {
            try
            {

                txtAporteIESSEmpleador.Text = "0.00";
                txtAporteIESSOtroEmpleador.Text = "0.00";
                txtBaseImponibleGravada.Text = "0.00";
                txtCompensacionSueldoDigno.Text = "0.00";
                txtDecimoCuartoSueldo.Text = "0.00";
                txtDecimoTercerSueldo.Text = "0.00";
                txtDeduccionAlimentacion.Text = "0.00";
                txtDeduccionEducacion.Text = "0.00";
                txtDeduccionSalud.Text = "0.00";
                txtDeduccionVestimenta.Text = "0.00";
                txtDeduccionVivienda.Text = "0.00";
                txtExoneracionDiscapacidad.Text = "0.00";
                txtExoneracionTercerEdad.Text = "0.00";
                txtFechaRegistro.Text = param.Fecha_Transac.ToShortDateString();
                txtFondoReserva.Text = "0.00";
                txtImpuestoAsumidoEmpleador.Text = "0.00";
                txtImpuestoRentaCausado.Text = "0.00";
                txtIngresosGravadosEmpleadorInformativo.Text = "0.00";
                txtIngresosGravadoOtroEmpleador.Text = "0.00";
                txtOtrosIngresosNoRentaGravada.Text = "0.00";
                txtSobresueldo.Text = "0.00";
                txtSueldoSalario.Text = "0.00";
                txtUtilidad.Text = "0.00";
                txtValorImpuestoAsumidoPorEmpleador.Text = "0.00";
                txtValorImpuestoRetenidoAsumidoPorOtroEmpleador.Text = "0.00";
                txtValorImpuestoRetenidoPorEmpleador.Text = "0.00";
                txtObservacion.Text = "";
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        private void pu_setHistorico() {
            try
            {
                if (cmbEmpleados.EditValue != null && cmbAnioFiscal.Text!="")
                {                  
                    _Info = oRo_Rdep_Bus.setInfoRdep(_Info.IdEmpresa, _Info.IdEmpleado, _Info.AnioFiscal, ref mensaje);
                    setInfo(_Info);

                }
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }        
        }


   
        private void frmRo_RDEP_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_RDEP_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbEmpleados_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleados.EditValue != null && cmbEmpleados.Properties.View.DataRowCount > 0)
                {
                    _Info = new ro_Rdep_Info();
                    _Info.IdEmpleado = Convert.ToInt32(cmbEmpleados.EditValue);
                    _Info.AnioFiscal = Convert.ToInt32(cmbAnioFiscal.Text);
                    _Info.IdEmpresa = param.IdEmpresa;

                    ro_Empleado_Info tmp = (ro_Empleado_Info)cmbEmpleados.Properties.View.GetFocusedRow();

                    txtIdentificacion.Text = tmp.InfoPersona.pe_cedulaRuc;
                    txtIdEmpleado.Text = tmp.IdEmpleado.ToString();

                    //VERIFICA QUE ESTE GRABANDO
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {

                        //VERIFICA SI YA TIENE REGISTRO PREVIO 
                        getInfo();

                        if (oRo_Rdep_Bus.GetExiste(_Info, ref mensaje))
                        {
                            _Info = oRo_Rdep_Bus.GetInfoPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado,_Info.AnioFiscal, ref mensaje);
                            setInfo(_Info);
                            MessageBox.Show("El Empleado seleccionado ya tiene creado un registro, por favor intente seleccionando otro empleado","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        }
                        else
                        {
                            pu_setHistorico();
                        }
                    
                    }

                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 


        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    pu_setHistorico();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
  
        }



        private void pu_Calcular() {
            try {

                if (getInfo()) 
                {

                    if (oRo_Rdep_Bus.pu_ValidarRDEP(_Info, ref mensaje))
                    {
                        _Info = oRo_Rdep_Bus.pu_CalcularRDEP(_Info);

                        setInfo(_Info);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            } 
        
        
        }



        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Calcular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbAnioFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //VERIFICA QUE ESTE GRABANDO
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    //VERIFICA SI YA TIENE REGISTRO PREVIO 
                    _Info.IdEmpleado = Convert.ToInt32(cmbEmpleados.EditValue);
                    _Info.AnioFiscal = Convert.ToInt32(cmbAnioFiscal.Text);
                    _Info.IdEmpresa = param.IdEmpresa;

                    if (oRo_Rdep_Bus.GetExiste(_Info, ref mensaje))
                    {
                        _Info = oRo_Rdep_Bus.GetInfoPorEmpleado(_Info.IdEmpresa, _Info.IdEmpleado, _Info.AnioFiscal, ref mensaje);
                        setInfo(_Info);
                        MessageBox.Show("El Empleado seleccionado ya tiene creado un registro, por favor intente seleccionando otro empleado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        pu_setHistorico();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_RDEP_Mant_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
