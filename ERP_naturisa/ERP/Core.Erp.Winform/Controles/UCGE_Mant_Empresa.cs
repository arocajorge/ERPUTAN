using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.IO;



namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Mant_Empresa : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        private Cl_Enumeradores.eTipo_action _Accion;
        //tb_Empresa_Data EmpreD = new tb_Empresa_Data();
        tb_Empresa_Bus EmpreB = new tb_Empresa_Bus();
        
        public void set_enable_btn_Grabar(Boolean value)
        {
            try
            {
              btn_grabar.Enabled = value;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public UCGe_Mant_Empresa()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                    _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        public tb_Empresa_Info _empresa_info { get; set; }
        
        public void set_empresa(tb_Empresa_Info iEmpre)
        {
            try
            {
                this.txt_Contador.Text = iEmpre.em_contador;
                this.txt_RucContador.Text  = iEmpre.em_rucContador;
                this.txt_fax.Text = iEmpre.em_fax;
                this.txt_Gerente.Text = iEmpre.em_gerente;
                this.txt_NomEmpresa.Text = iEmpre.em_nombre;
                this.txt_RucEmpresa.Text =iEmpre.em_ruc;
                this.txt_telefono.Text = iEmpre.em_telefonos;
                this.txt_telInternacional.Text = iEmpre.em_tel_int;
                this.dtpFechaInicioConta.Value = iEmpre.em_fechaInicioContable;
                this.lblIdEmpresa.Text = iEmpre.IdEmpresa.ToString();
                this.dtpFechaInicioConta.Value = iEmpre.em_fechaInicioContable;
                this.pbox_logo.Image = byteArrayToImage(iEmpre.em_logo);
                this.pbox_fondo.Image = byteArrayToImage(iEmpre.em_fondo);
                this.txt_direccion.Text = iEmpre.em_direccion;
                this.chkActivo.Checked = (iEmpre.Estado == "S") ? true : false;
                this.txtcodigo.Text = iEmpre.codigo;



                _empresa_info = iEmpre;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public tb_Empresa_Info get_empresa ()
        {
            try
            {
                _empresa_info.em_contador = this.txt_Contador.Text.Trim();
                _empresa_info.em_rucContador = this.txt_RucContador.Text.Trim();
                _empresa_info.em_fax = this.txt_fax.Text.Trim();
                _empresa_info.em_gerente = this.txt_Gerente.Text.Trim(); 
                _empresa_info.em_nombre = this.txt_NomEmpresa.Text.Trim() ;
                _empresa_info.em_ruc = this.txt_RucEmpresa.Text.Trim();
                _empresa_info.em_telefonos = this.txt_telefono.Text.Trim();
                _empresa_info.em_tel_int = this.txt_telInternacional.Text.Trim();
                _empresa_info.em_fechaInicioContable = this.dtpFechaInicioConta.Value;
                _empresa_info.IdEmpresa = Convert.ToInt32(this.lblIdEmpresa.Text.Trim());
                _empresa_info.em_fechaInicioContable = this.dtpFechaInicioConta.Value;
                _empresa_info.em_logo = ImageToByte(pbox_logo.Image);
                _empresa_info.em_fondo = ImageToByte(pbox_fondo.Image);
                _empresa_info.em_direccion = txt_direccion.Text.Trim();
                _empresa_info.Estado = (chkActivo.Checked == true) ? "A" : "I";
                _empresa_info.codigo = txtcodigo.Text.Trim();




                return _empresa_info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new tb_Empresa_Info();
            }
            

        }

        public byte[] ImageToByte(Image my_image)
        {
            try
            {
                if (my_image != null)
                {
                    MemoryStream Mstream = new MemoryStream();
                    my_image.Save(Mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return Mstream.ToArray();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }       

            
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn != null)
                    {
                        MemoryStream ms = new MemoryStream(byteArrayIn);
                        Image returnImage = Image.FromStream(ms);
                        return returnImage;
                    }
                    else
                    {
                        return null;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
            
        }

        private void UCGE_Mant_Empresa_Load(object sender, EventArgs e)
        {
            try
            {
                if (_empresa_info == null)
                { _empresa_info = new tb_Empresa_Info(); }


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btn_grabar.Text = "Grabar";

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.btn_grabar.Text = "Actualizar";


                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.btn_grabar.Text = "Eliminar";


                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:


                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private Boolean Grabar()
        {

            get_empresa();
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (EmpreB.GrabarDB(_empresa_info))
                    {
                        MessageBox.Show("Grabado ok", "Sistemas..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Registro repetido", "Sistemas..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {

                    if (EmpreB.ModificarDB(_empresa_info))
                    {

                        MessageBox.Show("Actualizado ok", "Sistemas..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       
                    }
                }
                this.Parent.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
            
           
        }

        private void btn_buscarFondo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialog.ShowDialog() != DialogResult.Cancel)
                {

                    Image image = Image.FromFile(openDialog.FileName);
                    pbox_fondo.Image = image;
                    pbox_fondo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                 Grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
    
        }

        private void btn_busLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialog.ShowDialog() != DialogResult.Cancel)
                {

                    Image image = Image.FromFile(openDialog.FileName);
                    pbox_logo.Image = image;
                    pbox_logo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

       
       
    }
}
