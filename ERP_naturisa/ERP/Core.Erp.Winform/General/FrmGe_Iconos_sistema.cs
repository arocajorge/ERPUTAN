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
using System.IO;



namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Iconos_sistema : Form
    {

        Image image;
        string fullPatchImagen;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();



        public FrmGe_Iconos_sistema()
        {
            InitializeComponent();
        }


        BindingList<tb_sis_iconos_Info> listIconos = new BindingList<tb_sis_iconos_Info>();

        tb_sis_iconos_Bus IconoBus = new tb_sis_iconos_Bus();


        private byte[] ImageToByte(Image my_image)
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

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }


        private Image byteArrayToImage(byte[] byteArrayIn)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void FrmGe_Iconos_sistema_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        private void cargar_grid()
        {
            try 
            {	        
		        listIconos = new BindingList<tb_sis_iconos_Info>(IconoBus.Get_List_iconos());
                    this.gridControl_iconos.DataSource = listIconos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

      
      
        private void limpiar()
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

        

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string [] images;

                string msgError = "";


                openFileDialog_buscar_imag.Multiselect = true;

                if (openFileDialog_buscar_imag.ShowDialog() != DialogResult.Cancel)
                {
                    images = openFileDialog_buscar_imag.FileNames;
                    
                    foreach (var itemImagen in images)
                    {
                        System.IO.FileInfo FileInfoItem = new FileInfo(itemImagen);
                        Image image = Image.FromFile(itemImagen);
                        tb_sis_iconos_Info Info = new tb_sis_iconos_Info();
                        Info.descripcion = "";
                        Info.IdIcono = FileInfoItem.Name;
                        Info.Icono = ImageToByte(image);
                        Info.Icono_image = image;
                        Info.Length = FileInfoItem.Length;
                        Info.descripcion="";
                        Info.DirectoryName = FileInfoItem.DirectoryName;
                        Info.Extencion = FileInfoItem.Extension;
                        Info.FullName = FileInfoItem.FullName;
                     

                        if (IconoBus.GrabarDB(Info, ref msgError) == false)
                        {
                            
                        }
                        else
                        {
                           // MessageBox.Show("Carga de Imagenes al sistema OK...", param.Nombre_sistema);
                        }
                    }
                    MessageBox.Show("Grabado Ok...", param.Nombre_sistema);

                    cargar_grid();
                    limpiar();

                }

                openFileDialog_buscar_imag.Multiselect = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

        private void btnsalir_Click(object sender, EventArgs e)
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



    }
}
