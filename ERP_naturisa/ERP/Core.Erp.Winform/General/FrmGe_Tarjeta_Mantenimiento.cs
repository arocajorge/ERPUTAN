using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Tarjeta_Mantenimiento : Form
    {
        #region Declaración de Variables
        public delegate void delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Tarjeta_Mantenimiento_FormClosing Event_FrmGe_Tarjeta_Mantenimiento_FormClosing;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        tb_tarjeta_Info Info = new tb_tarjeta_Info();
        tb_tarjeta_parametro_Info InfoParametro = new tb_tarjeta_parametro_Info();
        tb_tarjeta_parametro_Bus tarParBus = new tb_tarjeta_parametro_Bus();
        ct_Plancta_Bus planBus = new ct_Plancta_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_tarjeta_Bus tarBus = new tb_tarjeta_Bus();
        tb_banco_Bus banBus = new tb_banco_Bus();
        cxc_cobro_tipo_Bus cxcTipoBus;
        string MensajeError = "";
        string motivoAnulacion = "";
        #endregion
    
        public void _Info(vwGe_tb_Tarjeta_tb_Parametro_Info _Info)
        {
            try
            {
                InfoParametro.IdEmpresa = _Info.IdEmpresa;
                Info.IdTarjeta = InfoParametro.IdTarjeta = _Info.IdTarjeta;
                Info.tr_Descripcion = _Info.tr_Descripcion;
                Info.Estado = _Info.Estado;
                Info.IdBanco = _Info.IdBanco;
                InfoParametro.IdCtaCble_Tarj = _Info.IdCtaCble_Tarj;
                InfoParametro.IdCobro_tipo_x_Tarj = _Info.IdCobro_tipo_x_Tarj;
                InfoParametro.IdCobro_tipo_x_RetFu = _Info.IdCobro_tipo_x_RetFu;
                InfoParametro.IdCobro_tipo_x_RetIva = _Info.IdCobro_tipo_x_RetIva;
                InfoParametro.IdCtaCble_Comision = _Info.IdCtaCble_Comision;
                InfoParametro.Porcetaje_Comision = Convert.ToDouble(_Info.Porcetaje_Comision);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        public FrmGe_Tarjeta_Mantenimiento()
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

        private void FrmGe_Tarjeta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmGe_Tarjeta_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       
        void Combos()
        {
            try
            {
                cxcTipoBus = new cxc_cobro_tipo_Bus();
                cmbRetFuente.Properties.DataSource = cxcTipoBus.Get_List_Cobro_Tipo();                
                cmbBanco.Properties.DataSource = banBus.Get_List_Banco();
                cmbRetFuente.Properties.DataSource = cxcTipoBus.Get_List_Cobro_Tipo_x_RetFte();
                cmbRetIva.Properties.DataSource = cxcTipoBus.Get_List_Cobro_Tipo_RetIva();                
                cmbCobroTipo.Properties.DataSource = cxcTipoBus.Get_List_Cobro_Tipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Tarjeta_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                txtId.Enabled = false;
                txtId.ForeColor = Color.Black;
                txtId.BackColor = Color.White;
                Combos();
                ckEstado.Enabled = false;


                switch (_Accion)
                { 
                    case  Cl_Enumeradores.eTipo_action.grabar:
                        ckEstado.Checked = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        txtId.Text = tarBus.GetId().ToString();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        bloque_Datos();
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        txtId.Enabled = false;
                        txtId.ForeColor = Color.Black;
                        txtId.BackColor = Color.White;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ckEstado.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        bloque_Datos();
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool validar()
        {
            try
            {
                
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Ingrese la descripción por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    return false;
                }
                if (txtComision.Text == "" || txtComision.EditValue == null)
                {
                    MessageBox.Show("Ingrese la comisión por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtComision.Focus();
                    return false;
                }
                if (cmbBanco.Text == "" || cmbBanco.EditValue == null)
                {
                    MessageBox.Show("Ingrese el banco", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (ucCon_PlanCtaCmb1.get_PlanCtaInfo() == null)
                {
                    MessageBox.Show("Ingrese la cuenta contable por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucCon_PlanCtaCmb1.Focus();
                    return false;
                }
                if (ucCon_PlanCtaCmb2.get_PlanCtaInfo() == null)
                {
                    MessageBox.Show("Ingrese la cuenta contable de la comision por favor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucCon_PlanCtaCmb2.Focus();
                    return false;
                }
                if (cmbRetFuente.Text == "" || cmbRetFuente.EditValue == null)
                {
                    MessageBox.Show("Ingrese el porcentaje de retención a la fuente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbRetFuente.Focus();
                    return false;
                }
                if (cmbRetIva.Text == "" || cmbRetIva.EditValue == null)
                {
                    MessageBox.Show("Ingrese el porcentaje de retención al IVA", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbRetIva.Focus();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        void Guardar()
        {
            try
            {
                if (validar())
                {
                    Get();
                                   
                    if (tarBus.GuardarDB(Info))
                    {
                        InfoParametro.IdTarjeta = Info.IdTarjeta;
                        InfoParametro.IdEmpresa = param.IdEmpresa;
                        if (tarParBus.GuardarDB(InfoParametro))
                        {
                            //bloque_Datos();
                            MessageBox.Show("El registro #" + Info.IdTarjeta + " se guardo correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al tratar de guardar el cobro de la tarjeta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al tratar de guardar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void Actualizar()
        {
            try
            {
                if (validar())
                {
                    Get();
                    if (tarBus.ModificarDB(Info))
                    {
                        InfoParametro.IdTarjeta = Info.IdTarjeta;
                        if (tarParBus.ModificarDB(InfoParametro))
                        {
                            MessageBox.Show("El registro #" + Info.IdTarjeta + " se actualizo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("El registro #" + Info.IdTarjeta + " no se pudo actualizar el cobro de la tarjeta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El registro #" + Info.IdTarjeta + " no se pudo actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void bloque_Datos()
        {
            try
            {
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;
                txtDescripcion.Enabled = false;
                txtDescripcion.ForeColor = Color.Black;
                txtDescripcion.BackColor = Color.White;
                txtComision.Enabled = false;
                txtComision.ForeColor = Color.Black;
                txtComision.BackColor = Color.White;
                cmbBanco.Enabled = false;
                cmbBanco.ForeColor = Color.Black;
                cmbBanco.BackColor = Color.White;
                ucCon_PlanCtaCmb1.Enabled = false;
                ucCon_PlanCtaCmb1.ForeColor = Color.Black;
                ucCon_PlanCtaCmb1.BackColor = Color.White;
                ucCon_PlanCtaCmb2.Enabled = false;
                ucCon_PlanCtaCmb2.ForeColor = Color.Black;
                ucCon_PlanCtaCmb2.BackColor = Color.White;
                cmbRetFuente.Enabled = false;
                cmbRetFuente.ForeColor = Color.Black;
                cmbRetFuente.BackColor = Color.White;
                cmbRetIva.Enabled = false;
                cmbRetIva.ForeColor = Color.Black;
                cmbRetIva.BackColor = Color.White;
                cmbCobroTipo.Enabled = false;
                cmbCobroTipo.ForeColor = Color.Black;
                cmbCobroTipo.BackColor = Color.White;


                ckEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        void Set()
        {
            try
            {
                txtId.Text = Info.IdTarjeta.ToString();
                txtDescripcion.Text = Info.tr_Descripcion;
                cmbBanco.EditValue = Info.IdBanco;
                ucCon_PlanCtaCmb1.set_PlanCtarInfo(InfoParametro.IdCtaCble_Tarj);
                cmbCobroTipo.EditValue = InfoParametro.IdCobro_tipo_x_Tarj;
                cmbRetFuente.EditValue = InfoParametro.IdCobro_tipo_x_RetFu;
                cmbRetIva.EditValue = InfoParametro.IdCobro_tipo_x_RetIva;
                txtComision.Text = InfoParametro.Porcetaje_Comision.ToString();
                ucCon_PlanCtaCmb2.set_PlanCtarInfo(InfoParametro.IdCtaCble_Comision);

                if (Info.Estado == "A")
                {
                    ckEstado.Checked = true;
                }
                else
                {
                    ckEstado.Checked = false;
                }

                lbl_anulado.Visible = (Info.Estado == "I") ? true : false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                Info.IdTarjeta = Convert.ToInt32(txtId.Text);     
                Info.tr_Descripcion = txtDescripcion.Text;
                Info.IdBanco = Convert.ToInt32(cmbBanco.EditValue);
                InfoParametro.IdEmpresa = param.IdEmpresa;
                InfoParametro.IdCtaCble_Tarj = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble;
                InfoParametro.IdCobro_tipo_x_Tarj = cmbCobroTipo.EditValue.ToString();
                InfoParametro.IdCobro_tipo_x_RetFu = cmbRetFuente.EditValue.ToString();
                InfoParametro.IdCobro_tipo_x_RetIva = cmbRetIva.EditValue.ToString();
                InfoParametro.IdCtaCble_Comision = ucCon_PlanCtaCmb2.get_PlanCtaInfo().IdCtaCble;
                InfoParametro.Porcetaje_Comision = Convert.ToDouble(txtComision.Text);

                if (ckEstado.Checked == true)
                {
                    Info.Estado = "A";
                }
                else
                {
                    Info.Estado = "I";
                }

                lbl_anulado.Visible = (this.ckEstado.Checked == true) ? false : true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info.Estado == "A")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el registro #: " + Info.IdTarjeta + " ?", "ANULACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motivoAnulacion = fr.motivoAnulacion;

                        Info.MotivoAnulacion = motivoAnulacion;
                        Info.IdUsuarioUltAnu = param.IdUsuario;
                        Info.Fecha_UltAnu = DateTime.Now;


                        if (tarBus.AnularDB(Info))
                        {
                            ucGe_Menu.Visible_bntAnular = false;
                            ckEstado.Checked = false;
                            MessageBox.Show("El registro #" + Info.IdTarjeta + " se Anulo Exitosamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbl_anulado.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("El registro #" + Info.IdTarjeta + " no se pudo anular ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }
                else
                    MessageBox.Show("El Registro ya esta Anulado...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_event_btnGuardar_Click(sender,e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                txtDescripcion.Enabled = true;
                cmbBanco.Enabled = true;
                ckEstado.Enabled = false;
                cmbCobroTipo.Enabled = true;
                ucCon_PlanCtaCmb2.Enabled = true;
                ucCon_PlanCtaCmb1.Enabled = true;
                cmbRetFuente.Enabled = true;
                cmbRetIva.Enabled = true;
                txtComision.Enabled = true;
                ckEstado.Checked = true;
                txtId.Text = "";
                txtDescripcion.Text = "";
                cmbCobroTipo.EditValue = "";
                ucCon_PlanCtaCmb2.Inicializar_cmbPlanCta();
                ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();
                cmbRetFuente.EditValue = "";
                cmbRetIva.EditValue = "";
                txtComision.EditValue = "";
                Info = new tb_tarjeta_Info();
                InfoParametro = new tb_tarjeta_parametro_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
