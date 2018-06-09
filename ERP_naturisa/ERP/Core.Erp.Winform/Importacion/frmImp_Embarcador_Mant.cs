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
using Core.Erp.Info.Importacion;
using Core.Erp.Business.Importacion;
using System.Text.RegularExpressions;


namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_Embarcador_Mant : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        imp_Embarcador_Bus Bus = new imp_Embarcador_Bus();

        public delegate void Delegate_frmImp_Embarcador_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmImp_Embarcador_Mant_FormClosing Event_frmImp_Embarcador_Mant_FormClosing;
        private imp_Embarcador_Info _Info = new imp_Embarcador_Info();
        public imp_Embarcador_Info _InfoSet { get; set; }



        public frmImp_Embarcador_Mant()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void SetAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                 _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        

        public void get()
        {
            try
            {
                _Info.IdEmbarcador = Convert.ToInt16((txtIdEmbarcador.Text == "") ? "0" : txtIdEmbarcador.Text);
                _Info.em_contacto = txtContacto.Text;
                _Info.em_descripcion = txtDescripcion.Text;
                _Info.em_direccion = txtDireccion.Text;
                _Info.em_email = txtEmail.Text;
                _Info.em_telefono = txtTelefono.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        

        void Set() 
        {
            try
            {
                txtIdEmbarcador.Text = _InfoSet.IdEmbarcador.ToString();
                txtContacto.Text = _InfoSet.em_contacto;
                txtDescripcion.Text = _InfoSet.em_descripcion;
                txtDireccion.Text = _InfoSet.em_direccion;
                txtEmail.Text = _InfoSet.em_email;
                txtTelefono.Text = _InfoSet.em_telefono;

                if (_InfoSet.Estado=="I")
                {
                    lbl_Estado.Visible = true;
                    btnAnular.Enabled = false;
                }
                else
                { lbl_Estado.Visible = false; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmImp_Embarcador_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        btnOk.Text = "Guardar";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        btnOk.Text = "Actualizar";
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        btnOk.Text = "Guardar";
                        btnOk.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btnOk.Text = "Guardar";
                        btnOk.Enabled = false;
                        BtnGuardarYsalir.Enabled = false;
                        Set();
                        break;

                }
                Event_frmImp_Embarcador_Mant_FormClosing += new Delegate_frmImp_Embarcador_Mant_FormClosing(frmImp_Embarcador_Mant_Event_frmImp_Embarcador_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmImp_Embarcador_Mant_Event_frmImp_Embarcador_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (email_bien_escrito(txtEmail.Text))
                {
                    get();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            guardar();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Actualizar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            break;

                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        private Boolean email_bien_escrito(String email)
        {
            try
            {
                String expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

                if (email == "" || email == null)
                {
                    return true;                
                }
                
                if (Regex.IsMatch(email, expresion))
                {
                    if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Correo Invalido 'example@example.com'");
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

        void guardar()
        {

            try
            {
                if (Bus.GuardarDB(ref _Info))
                {
                    MessageBox.Show("Guardado Exitosamente el Embarcador # " + _Info.IdEmbarcador);

                    txtIdEmbarcador.Text = Convert.ToString(_Info.IdEmbarcador);
                    
                    btnOk.Enabled = false;
                    BtnGuardarYsalir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        void Actualizar() 
        {
            try
            {
                if (Bus.ModificarDB(_Info))
                {
                    MessageBox.Show("Actualizado Exitosamente el Embarcador # " + _Info.IdEmbarcador);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        
        }


        

        private void frmImp_Embarcador_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   Event_frmImp_Embarcador_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                get();
                if (Bus.AnularDB(_Info))
                {
                    MessageBox.Show("Anulado Exitosamente el Embarcador # " + _Info.IdEmbarcador);
                    btnAnular.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnGuardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnOk_Click(sender, e);
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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

    }
}
