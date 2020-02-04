using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Buscar_Imagen_Iconos : Form
    {
        public FrmGe_Buscar_Imagen_Iconos()
        {
            InitializeComponent();
        }


        Image image;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        FileInfo FileInfo_Ico_Peq;
        FileInfo FileInfo_Ico_Gra;

        tb_sis_iconos_Bus IcoBus = new tb_sis_iconos_Bus();
        List<tb_sis_iconos_Info> listIco = new List<tb_sis_iconos_Info>();
        tb_sis_iconos_Info IconoInfo = new tb_sis_iconos_Info();

        public tb_sis_iconos_Info InfoImagen { get; set; }





        private void btn_import_local_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_buscar_imag = new OpenFileDialog();

                if (openFileDialog_buscar_imag.ShowDialog() != DialogResult.Cancel)
                {

                    image = Image.FromFile(openFileDialog_buscar_imag.FileName);
                    FileInfo_Ico_Gra = new FileInfo(openFileDialog_buscar_imag.FileName);
                    pictureEdit_Imagen.Image = image;
                    System.IO.FileInfo FileInfoItem = new FileInfo(openFileDialog_buscar_imag.FileName);

                    IconoInfo = new tb_sis_iconos_Info();
                    IconoInfo.IdIcono = FileInfoItem.Name;
                    IconoInfo.descripcion = "";
                    IconoInfo.DirectoryName = FileInfoItem.DirectoryName;
                    IconoInfo.Extencion = FileInfoItem.Extension;
                    IconoInfo.FullName = FileInfoItem.FullName;
                    IconoInfo.Icono = ImageToByte(image);
                    IconoInfo.Icono_image = image;
                    IconoInfo.Length = FileInfoItem.Length;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_Buscar_Imagen_Iconos_Load(object sender, EventArgs e)
        {
            try
            {

                cargarImg_List();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cargarImg_List()
        {
            try
            {
                listIco = IcoBus.Get_List_iconos();
                gridControl_Imagen.DataSource = listIco;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }




        private void Cargar_Imagen(string IdImagen)
        {

            try
            {
                tb_sis_iconos_Info Info =listIco.Find(v => v.IdIcono == IdImagen);
                pictureEdit_Imagen.Image = Info.Icono_image;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }


        private void gridView_Iconos_vzen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                IconoInfo = new tb_sis_iconos_Info();
                IconoInfo = gridView_Iconos_vzen.GetFocusedRow() as tb_sis_iconos_Info;
                Cargar_Imagen(IconoInfo.IdIcono);
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensErro="";


                if (opt_Img_local.Checked == true)
                {
                    IcoBus.GrabarDB(InfoImagen, ref mensErro);

                }

                InfoImagen = IconoInfo;
                Close();


                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



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

        private void btn_borrar_local_Click(object sender, EventArgs e)
        {
            try
            {

                IconoInfo = new tb_sis_iconos_Info();
                pictureEdit_Imagen.Image = null;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        
        
    }
}
