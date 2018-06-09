using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


//haac 22102013
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using System.Diagnostics;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Generacion_Archivos_Transferencia_Cons : Form
    {
        #region DEclaración de variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Archivos_Bancos_Generacion_Bus Bus_Transfe = new ro_Archivos_Bancos_Generacion_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmRo_Generacion_Archivos_Transferencia frmMant = new frmRo_Generacion_Archivos_Transferencia();
        string borrar = "";
        #endregion

        public frmRo_Generacion_Archivos_Transferencia_Cons()
        {
            try
            {
                InitializeComponent();
                frmMant.event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                CargarGrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmRo_Generacion_Archivos_Transferencia(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                frmMant.pu_CargarDatos();
                frmMant.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ro_Archivos_Bancos_Generacion_Info)this.gridViewTransferencia.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //else if (Info.es == "I")
                //    MessageBox.Show("No se pueden modificar préstamos inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frmMant = new frmRo_Generacion_Archivos_Transferencia(Cl_Enumeradores.eTipo_action.actualizar);
                    frmMant.event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmMant.pu_CargarDatos();
                    frmMant.setInfo(Info);

                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewTransferencia.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ro_Archivos_Bancos_Generacion_Info)this.gridViewTransferencia.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmMant = new frmRo_Generacion_Archivos_Transferencia(Cl_Enumeradores.eTipo_action.consultar);
                    frmMant.event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant.pu_CargarDatos();
                    frmMant.setInfo(Info);
                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ro_Archivos_Bancos_Generacion_Info)this.gridViewTransferencia.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmMant = new frmRo_Generacion_Archivos_Transferencia(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmRo_Generacion_Archivos_Transferencia_FormClosing += frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.pu_CargarDatos();
                    frmMant.setInfo(Info);
                    frmMant.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmMant_event_frmRo_Generacion_Archivos_Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void CargarGrid()
        {
            try
            {
                //this.gridControlTransferencia.DataSource = Bus_Transfe.ConsultaArchivoBancoTransfe(param.IdEmpresa);

                List<ro_Archivos_Bancos_Generacion_Info> ListConsulta = new List<ro_Archivos_Bancos_Generacion_Info>();

                ListConsulta = Bus_Transfe.ConsultaArchivoBancoTransfe(param.IdEmpresa,ucGe_Menu_Mantenimiento_x_usuario.fecha_desde,ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);


                //cargar imagen en boton grilla
                foreach (var item in ListConsulta)
                {

                    item.Ico = (Bitmap)imageList1.Images[0];

                }

                this.gridControlTransferencia.DataSource = ListConsulta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
         
        }

        private void frmRo_Generacion_Archivos_Transferencia_Cons_Load(object sender, EventArgs e)
        {
            try
            {
               CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
          
        private void gridViewTransferencia_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                if (e.Column.Name == "gridColumnVerTxt" )
                {
                    CrearPdfTemp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }     

        void CrearPdfTemp()
        {
            try
            {
                var Info = (ro_Archivos_Bancos_Generacion_Info)this.gridViewTransferencia.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    string a = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string rutaTemp = a + "/" + Info.Nom_Archivo;//JUNTANDO Y HACIENDO UN SOLO PATH

                    if (File.Exists(rutaTemp))
                        File.Delete(rutaTemp);

                    File.WriteAllBytes(rutaTemp, Info.Archivo);
                    Process.Start(rutaTemp);
                    borrar = rutaTemp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}
