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
    public partial class frmGE_transportista : Form
    {
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus personaBus = new tb_persona_bus();
        tb_persona_Info infoPers;
        int x = 0;
        tb_transportista_Bus transBus = new tb_transportista_Bus();
        tb_transportista_Info infoTrans;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_frmGE_transportista_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGE_transportista_FormClosing event_frmGE_transportista_FormClosing;
        #endregion
        
        public frmGE_transportista()
        {
            try
            {
                 InitializeComponent();
                 event_frmGE_transportista_FormClosing += new delegate_frmGE_transportista_FormClosing(frmGE_transportista_event_frmGE_transportista_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmGE_transportista_event_frmGE_transportista_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmGE_transportista_Load(object sender, EventArgs e)
        {
            try
            {
                txtCedula.Focus();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCedula.Text == "") { txtCedula.Focus(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        public void txtCedula_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                infoPers = new tb_persona_Info();
                infoTrans = new tb_transportista_Info();
                List<tb_transportista_Info> lista = new List<tb_transportista_Info>();
                infoPers = personaBus.Get_Info_Persona(txtCedula.Text);
                txtApellido.Text = infoPers.pe_apellido;
                txtNombre.Text = infoPers.pe_nombre;
                txtId.Text = infoPers.IdPersona.ToString();

                lista=transBus.Get_List_transportista(param.IdEmpresa);
                var g = from C in lista where C.IdPersona == Convert.ToInt32(txtId.Text) select C;
                foreach (var item in g)
                {
                    txtIdTransportista.Text=item.IdTransportista.ToString();
                    chkEstado.Checked = (item.Estado=="A")?true:false;
                    infoTrans.IdEmpresa = item.IdEmpresa;
                    infoTrans.Estado = item.Estado;
                    infoTrans.IdPersona = item.IdPersona;
                    infoTrans.IdTransportista = item.IdTransportista;
                }
                if (infoTrans.IdPersona == 0)
                {
                    
                    btnGuardar.Text = "Guardar";
                    btnGuardarSalir.Text = "Guardar Y Salir";
                    txtIdTransportista.Text = "";
                }
                else
                {
                    if(x!=0){
                    MessageBox.Show("El transportista" + txtNombre.Text + " " + txtApellido.Text + " se encuentra Registrado");}
                    x = 1;
                    btnGuardar.Text = "Actualizar";
                    btnGuardarSalir.Text = "Actualizar Y Salir";
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void getInfo() {
            try
            {
                infoTrans.Estado=(chkEstado.Checked==true)?"A":"I";
                infoPers.pe_apellido = txtApellido.Text;
                infoPers.pe_nombre = txtNombre.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string MensajeError = "";
                decimal IdTran=0;
                txtIdTransportista.Focus();

                if (btnGuardar.Text == "Actualizar")
                {
                    getInfo();
                    string mensaje = "";
                    if (transBus.GuardarDB(infoTrans, ref IdTran))
                    {
                        MessageBox.Show("Transportista Actualizado");
                    LimpiarDatos();
                    }
                    infoPers.pe_nombreCompleto = txtApellido.Text + " " + txtNombre.Text;
                    return;
                } 
                
                else
                {
                    getInfo();
                    infoTrans.IdEmpresa = param.IdEmpresa;
                    infoTrans.IdPersona = Convert.ToInt32(txtId.Text);
                    decimal idPersonaOut = 0;
                    if (infoPers.CodPersona == null)
                    {
                        
                        infoPers.IdEmpresa = param.IdEmpresa;
                        infoPers.pe_cedulaRuc = txtCedula.Text;
                        infoPers.pe_nombreCompleto = txtApellido.Text +" "+ txtNombre.Text;
                        infoPers.pe_razonSocial = "";
                        infoPers.IdTipoPersona = 1;
                        infoPers.IdTipoDocumento = "";
                        infoPers.pe_direccion = "";
                        infoPers.pe_sexo = "M";
                        infoPers.IdEstadoCivil = "SOLT";
                        infoPers.pe_estado = "A";
                        infoPers.pe_Naturaleza = "";

                    }
                    if (infoPers.CodPersona == null)
                    {
                    if (MessageBox.Show("Desea Registrar a la persona con Cedula: " + txtCedula.Text, "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        personaBus.GrabarDB(infoPers, ref idPersonaOut, ref MensajeError);
                        infoTrans.IdPersona = idPersonaOut;
                        if (transBus.GuardarDB(infoTrans, ref IdTran))
                        {
                            MessageBox.Show("Transportista Guardado");
                        LimpiarDatos();
                        }
                        x = 0;
                        txtCedula_Validating(sender, new CancelEventArgs());
                    }
                    else
                    {
                        txtCedula.Focus();                        
                        return;
                    }
                    }else{
                        if (transBus.GuardarDB(infoTrans, ref IdTran)) { MessageBox.Show("Transportista Guardado"); }
                        x = 0;
                    txtCedula_Validating(sender, new CancelEventArgs());
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar_Click(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmGE_transportista_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmGE_transportista_event_frmGE_transportista_FormClosing(sender, e);
                event_frmGE_transportista_FormClosing(sender, e);
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
                btnGuardar.Text = "Grabar";
                infoTrans = new tb_transportista_Info();
                infoPers = new tb_persona_Info();
                txtIdTransportista.Text = "";                
                getInfo();
                    
                txtId.Text = "";
                txtCedula.Text = "";
                txtApellido.Text = "";
                txtNombre.Text = "";                        
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
