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
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_GeneracionFile_Banco_x_cxp_Cons : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmCP_GeneracionFile_Banco_x_cxp_Mant frmMant = new frmCP_GeneracionFile_Banco_x_cxp_Mant();
        List<ba_Archivo_Transferencia_Info> ListaArchivos = new List<ba_Archivo_Transferencia_Info>();
        //ba_Archivo_Transferencia_Info Archivo_info = new ba_Archivo_Transferencia_Info();
        ba_Archivo_Transferencia_Bus Archivo_bus = new ba_Archivo_Transferencia_Bus();
        ba_Archivo_Transferencia_Info Info_Archivo = new ba_Archivo_Transferencia_Info();
        Funciones Funciones = new Info.General.Funciones();


       string mensaje = "";
        public frmCP_GeneracionFile_Banco_x_cxp_Cons()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Info.General.Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  

        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_Archivo.IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un registro", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    if (!Info_Archivo.Estado)
                    {
                        MessageBox.Show("No se puede modificar un registro anulado", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Preparar_Formulario(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
              
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_Archivo.IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un registro", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    if (!Info_Archivo.Estado )
                    {
                        MessageBox.Show("el registro ya esta anulado", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Preparar_Formulario(Info.General.Cl_Enumeradores.eTipo_action.Anular);
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  

        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info_Archivo.IdEmpresa == 0)
                {
                    MessageBox.Show("Seleccione un registro", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return;

                }
                Preparar_Formulario(Info.General.Cl_Enumeradores.eTipo_action.consultar);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void frmCP_GeneracionFile_Banco_x_cxp_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu.fecha_desde.AddDays(-30);
                Cargar_Datos();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_Datos()
        {
            try
            {
                ListaArchivos = Archivo_bus.Get_List_Archivo_transferencia(param.IdEmpresa,"CXP",ucGe_Menu.fecha_desde,ucGe_Menu.fecha_hasta);
                gridControlArchivos.DataSource = ListaArchivos;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridViewArchivos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Info_Archivo = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewArchivos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info_Archivo = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewArchivos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewArchivos.GetRow(e.RowHandle) as ba_Archivo_Transferencia_Info;
                if (data == null)
                    return;
                if (!data.Estado)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                if (data.Contabilizado == true)
                {
                    e.Appearance.ForeColor = Color.Blue;
                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarFile_Click(object sender, EventArgs e)
        {
            try
            {

                ba_Archivo_Transferencia_Info info_A = new ba_Archivo_Transferencia_Info();
                byte[] archivo;
                info_A = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                archivo = Archivo_bus.Get_Archivo(info_A.IdEmpresa, info_A.IdArchivo, info_A.IdProceso_bancario, info_A.IdBanco);
                if (archivo.Length == 0)
                {
                    MessageBox.Show("El registro no contiene archivo para descargar", "VZEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Funciones.Crear_y_abrir_Archivo_txt(archivo, info_A.Nom_Archivo);
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                string mensajeFrm = "";
                Info_Archivo = new ba_Archivo_Transferencia_Info();

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        mensajeFrm = "REGISTRO NUEVO";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        mensajeFrm = "MODIFICAR REGISTRO";
                        Info_Archivo = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        mensajeFrm = "ANULAR REGISTRO";
                        Info_Archivo = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        mensajeFrm = "CONSULTAR REGISTRO";
                        Info_Archivo = (ba_Archivo_Transferencia_Info)gridViewArchivos.GetFocusedRow();
                        break;
                    default:
                        break;
                }

                if (Info_Archivo != null)
                {
                    frmMant = new frmCP_GeneracionFile_Banco_x_cxp_Mant();
                    frmMant.Text = frmMant.Text + "***" + mensajeFrm + "***";
                    frmMant.Set_Accion(iAccion);

                    if (iAccion != Info.General.Cl_Enumeradores.eTipo_action.grabar)
                    {
                        frmMant.Set_Info(Info_Archivo);
                    }
                    
                    frmMant.Show();
                    frmMant.MdiParent = this.MdiParent;
                    frmMant.event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing += frmMant_event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmMant_event_frmCP_GeneracionFile_Banco_x_cxp_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cargar_Datos();
        }
    }
}
