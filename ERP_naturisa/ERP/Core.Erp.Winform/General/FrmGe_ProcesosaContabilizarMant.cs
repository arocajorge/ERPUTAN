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


namespace Core.Erp.Winform.General
{
    public partial class FrmGe_ProcesosaContabilizarMant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;

        List<tb_sis_Documento_Tipo_Info> lstinfoDocuTipo = new List<tb_sis_Documento_Tipo_Info>();
        List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info> lstinfoParamContTipoConta = new List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info>();
        tb_sis_Documento_Tipo_Bus DocuTipoBus = new tb_sis_Documento_Tipo_Bus();
        tb_sis_Param_Cont_Tipo_Contabilizacion_Bus ParamContTipoContaBus = new tb_sis_Param_Cont_Tipo_Contabilizacion_Bus();

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }

        


        public FrmGe_ProcesosaContabilizarMant()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmGe_ProcesosaContabilizarMant_Load(object sender, EventArgs e)
        {
            load();
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        btn_guardar.Text = "Grabar";
                        btn_guardarysalir.Text = "Grabar y Salir";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        SETINFO();
                        btn_guardar.Text = "Modificar";
                        btn_guardarysalir.Text = "Modificar y Salir";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        SETINFO();
                        btn_guardar.Enabled = false;
                        btn_guardarysalir.Enabled = false;
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

        public Boolean GETINFO() {
            try
            {
                //ParamContProcInfo = new tb_sis_Param_Cont_x_Proceso_Info();
                //ParamContProcInfo.IdProcesoConta = Convert.ToString(cmbTipoDocu.EditValue);
                //ParamContProcInfo.Descripcion = Convert.ToString(txtDescripcion.EditValue);
                //ParamContProcInfo.IdTipo_Conta = Convert.ToString(cmbTipoContable.EditValue);
                //ParamContProcInfo.TomarParametrosContablesDE = Convert.ToString(txtParamConta.EditValue);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean SETINFO() {
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
        }

        public void load() {
            try
            {
                lstinfoDocuTipo = new List<tb_sis_Documento_Tipo_Info>(DocuTipoBus.Get_List_Documento_Tipo());
                lstinfoParamContTipoConta = new List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info>(ParamContTipoContaBus.ConsultarParamConta());

                cmbTipoDocu.Properties.DataSource = lstinfoDocuTipo;
                cmbTipoContable.Properties.DataSource = lstinfoParamContTipoConta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        

        private void cmbTipoContable_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoContable.EditValue != null || cmbTipoContable.EditValue != "")
                {
                    txtParamConta.EditValue = ParamContTipoContaBus.ConsEspeParamConta(Convert.ToString(cmbTipoContable.EditValue));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public Boolean Grabar() {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (GETINFO() == false)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos.", "Operación Fallida");
                        return false;
                    }


                    //if (ParamContProcBus.GuardarParamProceso(ParamContProcInfo) == false)
                    //{
                    //    MessageBox.Show("Problemas al Grabar el Proceso a Contabilizar.", "Operación Fallida");
                    //    return false;
                    //}


                    MessageBox.Show("Se ha procedido ha Guardar con exito la información", "Operación Exitosa");
                    btn_guardar.Enabled = false;
                    btn_guardarysalir.Enabled = false;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (GETINFO() == false)
                    {
                        MessageBox.Show("Problemas en la Actualización de los Datos.", "Operación Fallida");
                        return false;
                    }

                    //if (ParamContProcBus.ModificarParamProceso(ParamContProcInfo) == false)
                    //{
                    //    MessageBox.Show("Problemas al Actualizar el Proceso a Contabilizar.", "Operación Fallida");
                    //    return false;
                    //}


                    MessageBox.Show("Se ha procedido ha Actualizar con exito la información", "Operación Exitosa");
                    btn_guardar.Enabled = false;
                    btn_guardarysalir.Enabled = false;
                }
                return true;
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                 Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       

        }

        private void FrmGe_ProcesosaContabilizarMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    event_FrmGe_ProcesosaContabilizarMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Delegados
        public delegate void delegate_FrmGe_ProcesosaContabilizarMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_ProcesosaContabilizarMant_FormClosing event_FrmGe_ProcesosaContabilizarMant_FormClosing;

        private void cmbTipoDocu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoDocu.EditValue != null || cmbTipoDocu.EditValue != "")
                {
                    txtDescripcion.EditValue = DocuTipoBus.Get_Documento_Tipo(Convert.ToString(cmbTipoDocu.EditValue));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
