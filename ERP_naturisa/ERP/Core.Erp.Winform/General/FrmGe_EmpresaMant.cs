using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_EmpresaMant : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmGe_EmpresaMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_EmpresaMant_FormClosing event_FrmGe_EmpresaMant_FormClosing;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Empresa_Info _empresa_info = new tb_Empresa_Info();
        tb_Empresa_Bus _empresa_Bus = new tb_Empresa_Bus();
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();

        tb_persona_bus BusPersona = new tb_persona_bus();
        int C = 0;
        #endregion
      
        public FrmGe_EmpresaMant()
        {
            InitializeComponent();
            event_FrmGe_EmpresaMant_FormClosing += FrmGe_EmpresaMant_event_FrmGe_EmpresaMant_FormClosing;
        }

        public FrmGe_EmpresaMant(Cl_Enumeradores.eTipo_action Numerador): this()
        {
            try
            {
                enu = Numerador;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmGe_EmpresaMant_event_FrmGe_EmpresaMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
       
        private void ucGe_Menu_event_btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    Grabar();
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
                if (Validar())
                {
                    if (Grabar())
                        Close();
                }
                
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
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_EmpresaMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_EmpresaMant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_empresa(tb_Empresa_Info iEmpre)
        {
            try
            {
                this.txt_Contador.Text = iEmpre.em_contador;
                this.txt_RucContador.Text = iEmpre.em_rucContador;
                this.txt_fax.Text = iEmpre.em_fax;
                this.txt_Gerente.Text = iEmpre.em_gerente;
                this.txt_NomEmpresa.Text = iEmpre.em_nombre;
                this.txt_RucEmpresa.EditValue = iEmpre.em_ruc;
                this.txt_telefono.Text = iEmpre.em_telefonos;
                this.txt_telInternacional.Text = iEmpre.em_tel_int;
                this.dtpFechaInicioConta.Value = iEmpre.em_fechaInicioContable;
                this.lblIdEmpresa.Text = iEmpre.IdEmpresa.ToString();
                this.dtpFechaInicioConta.Value = iEmpre.em_fechaInicioContable;
                this.txt_Direccion.Text = iEmpre.em_direccion;
                this.chkActivo.Checked = (iEmpre.Estado == "A") ? true : false;
                this.txtcodigo.Text = iEmpre.codigo;
                this.txt_cod_dinardap.Text = iEmpre.cod_entidad_dinardap;
                txtEmail.EditValue = iEmpre.em_Email;


                if (iEmpre.em_logo!=null)
                {
                    MemoryStream ms = new MemoryStream(iEmpre.em_logo);
                    pic_logo.Image = System.Drawing.Bitmap.FromStream(ms);
                
                }

                tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
                
              byte []  fondo_=  BusEmpresa.Get_Fondo_Pantalla_x_Empresa(iEmpre.IdEmpresa);

              iEmpre.em_fondo = fondo_;


                if (iEmpre.em_fondo != null)
                {
                    MemoryStream ps = new MemoryStream(iEmpre.em_fondo);
                    pic_fondo.Image = System.Drawing.Bitmap.FromStream(ps);
                }

               chkllevaCont.Checked = (iEmpre.ObligadoAllevarConta == "SI") ? true : false;
               txtRazon.EditValue=iEmpre.RazonSocial;
               txtNomComercial.EditValue=iEmpre.NombreComercial;
               txtResContEsp.EditValue = iEmpre.ContribuyenteEspecial;


                _empresa_info = iEmpre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public tb_Empresa_Info get_empresa()
        {
            try
            {
                _empresa_info.em_contador = this.txt_Contador.Text.Trim();
                _empresa_info.em_rucContador = this.txt_RucContador.Text.Trim();
                _empresa_info.em_fax = this.txt_fax.Text.Trim();
                _empresa_info.em_gerente = this.txt_Gerente.Text.Trim();
                _empresa_info.em_nombre = this.txt_NomEmpresa.Text.Trim();
                _empresa_info.em_ruc =Convert.ToString(txt_RucEmpresa.EditValue).Trim();
                _empresa_info.em_telefonos = this.txt_telefono.Text.Trim();
                _empresa_info.em_tel_int = this.txt_telInternacional.Text.Trim();
                _empresa_info.em_fechaInicioContable = this.dtpFechaInicioConta.Value;
                _empresa_info.IdEmpresa = Convert.ToInt32(this.lblIdEmpresa.Text.Trim());
                _empresa_info.em_fechaInicioContable = this.dtpFechaInicioConta.Value;
                _empresa_info.em_direccion = txt_Direccion.Text.Trim();
                _empresa_info.Estado = (chkActivo.Checked == true) ? "A" : "I";
                _empresa_info.codigo = txtcodigo.Text.Trim();
                _empresa_info.cod_entidad_dinardap = txt_cod_dinardap.Text.Trim();
                _empresa_info.RazonSocial = Convert.ToString(txtRazon.EditValue).Trim();
                _empresa_info.NombreComercial = Convert.ToString(txtNomComercial.EditValue).Trim();
                _empresa_info.ContribuyenteEspecial = Convert.ToString(txtResContEsp.EditValue).Trim();
                _empresa_info.ObligadoAllevarConta = chkllevaCont.Checked == true ? "SI" : "NO";
                _empresa_info.em_Email = txtEmail.EditValue == null ? "" :txtEmail.EditValue.ToString();


                if (pic_logo.Image != null)
                {
                    MemoryStream memimagen = new MemoryStream();
                    pic_logo.Image.Save(memimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byfoto = new byte[memimagen.Length];
                    memimagen.Position = 0;
                    memimagen.Read(byfoto, 0, Convert.ToInt32(memimagen.Length));
                    _empresa_info.em_logo = byfoto;
                }

                if (pic_fondo.Image != null)
                {
                    MemoryStream memimagen = new MemoryStream();
                    pic_fondo.Image.Save(memimagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] byfoto = new byte[memimagen.Length];
                    memimagen.Position = 0;
                    memimagen.Read(byfoto, 0, Convert.ToInt32(memimagen.Length));
                    _empresa_info.em_fondo = byfoto;
                }

                return _empresa_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new tb_Empresa_Info();
            }


        }

        private Boolean Grabar()
        {

            get_empresa();
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (_empresa_Bus.GrabarDB(_empresa_info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Empresa  ", _empresa_info.em_nombre);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (_empresa_Bus.ModificarDB(_empresa_info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Empresa  ", _empresa_info.em_nombre);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

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
       
        public Boolean Validar()
        {
            try
            {
                txtcodigo.Focus();


                if (String.IsNullOrEmpty(Convert.ToString(txtRazon.EditValue)))
                {
                    MessageBox.Show("Por favor ingrese la Razón Social", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRazon.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txtNomComercial.EditValue)))
                {
                    MessageBox.Show("Por favor ingrese el Nombre Comercial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomComercial.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txtResContEsp.EditValue)))
                {
                    MessageBox.Show("Por favor ingrese el número de Contribuyente Especial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtResContEsp.Focus();
                    return false;
                }
              
                if (this.txt_NomEmpresa.Text == "")
                {
                    MessageBox.Show("Por favor ingrese el nombre de la Empresa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_NomEmpresa.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(Convert.ToString(txt_RucEmpresa.EditValue)))
                {
                    MessageBox.Show("Por favor ingrese el RUC de la Empresa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_RucEmpresa.Focus();
                    return false;
                }
                else
                {
                    string men = "";

                    if (!BusPersona.Verifica_Ruc(Convert.ToString(txt_RucEmpresa.EditValue).Trim(), ref men))
                    {
                        MessageBox.Show(men,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return false;
                    }
                
                }
                if (this.dtpFechaInicioConta.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la fecha de Inicio Contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dtpFechaInicioConta.Focus();
                    return false;
                }

                if (this.txt_Gerente.Text == "")
                {
                    MessageBox.Show("Por favor ingrese nombre del Gerente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_Gerente.Focus();
                    return false;
                }

                if (this.txt_telefono.Text == "")
                {
                    MessageBox.Show("Por favor ingrese N° de Telefono de la Empresa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_telefono.Focus();
                    return false;
                }

                if (this.txt_Direccion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la Dirección de la Empresa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txt_Direccion.Focus();
                    return false;
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

        private void FrmGe_EmpresaMant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        chkActivo.Checked = true;
                        chkActivo.Enabled = false;
                        txtcodigo.Focus();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        C = 3;
                        set_empresa(_empresa_info);
                        break;
                  
                    case Cl_Enumeradores.eTipo_action.consultar:
                        
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        C = 4;

                        set_empresa(_empresa_info);
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

        private void btn_logo_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagen = new OpenFileDialog();
                imagen.Filter = "Archivos de Imagen|*.JPG;*.PNG;*.JEPG";
                imagen.FileName = "SELECCIONE UNA IMAGEN";
                imagen.InitialDirectory = "C:\\";


                switch (imagen.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                          string direc = imagen.FileName;
                            pic_logo.ImageLocation = direc;
                        break;

                    case System.Windows.Forms.DialogResult.Cancel:
                         pic_logo.ImageLocation = "";
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_fondo_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog imagen = new OpenFileDialog();
                imagen.Filter = "Archivos de Imagen|*.JPG;*.PNG;*.JEPG";
                imagen.FileName = "SELECCIONE UNA IMAGEN";
                imagen.InitialDirectory = "C:\\";


                switch (imagen.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                                string direc = imagen.FileName;
                                pic_fondo.ImageLocation = direc;
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        pic_fondo.ImageLocation = "";
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_RucEmpresa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(Convert.ToString(txt_RucEmpresa.EditValue)))
                { return; }

                string men = "";
               
                //if (!BusPersona.Verifica_Ruc(Convert.ToString(txt_RucEmpresa.EditValue).Trim(), ref men))
                //{
                //    MessageBox.Show(men);
                //}


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

        void LimpiarDatos()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                _empresa_info = new tb_Empresa_Info();
                txt_Contador.Text = "";
                txt_RucContador.Text = "";
                txt_fax.Text = "";
                txt_Gerente.Text = "";
                txt_NomEmpresa.Text = "";
                txt_RucEmpresa.EditValue = "";
                txt_telefono.Text = "";
                txt_telInternacional.Text = "";
                
                lblIdEmpresa.Text = "";
                
                txt_Direccion.Text = "";
                chkActivo.Checked = true;
                txtcodigo.Text = "";

                txtRazon.EditValue = "";
                txtNomComercial.EditValue = "";
                txtResContEsp.EditValue = "";
                pic_logo.Image = null;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
