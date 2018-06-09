using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info;
using Core.Erp.Business;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Inventario_Edehsa
{
    public partial class FrmIn_Producto_Wizard_Import_Edehsa : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        in_producto_x_tb_bodega_Info info_producto_x_bodega = new in_producto_x_tb_bodega_Info();
        in_producto_x_tb_bodega_Bus bus_producto_x_bodega = new in_producto_x_tb_bodega_Bus();

        List<tb_Sucursal_Info> lst_Sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_Sucursal = new tb_Sucursal_Bus();

        List<tb_Bodega_Info> lst_Bodega = new List<tb_Bodega_Info>();
        tb_Bodega_Bus bus_Bodega = new tb_Bodega_Bus();
        
        #region Delegados
        public delegate void delegate_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_ImportacionWizard_FormClosing event_frmRo_Empleado_ImportacionWizard_FormClosing;
        #endregion

        #region DATA
        //Categoria
        List<in_categorias_Info> list_Categoria = new List<in_categorias_Info>();
        in_categorias_bus Categoria_Bus = new in_categorias_bus();

        //Línea
        List<in_linea_info> list_Linea = new List<in_linea_info>();
        in_linea_Bus Linea_bus = new in_linea_Bus();

        //Grupo
        List<in_grupo_info> list_Grupo = new List<in_grupo_info>();
        in_grupo_Bus Grupo_bus = new in_grupo_Bus();

        //SubGrupo
        List<in_subgrupo_info> list_SubGrupo = new List<in_subgrupo_info>();
        in_subgrupo_Bus SubGrupo_bus = new in_subgrupo_Bus();

        //Marca
        List<in_Marca_Info> list_Marca = new List<in_Marca_Info>();
        in_marca_bus Marca_bus = new in_marca_bus();

        //Presentación
        List<in_presentacion_Info> list_Presentacion = new List<in_presentacion_Info>();
        in_presentacion_Bus Presentacion_bus = new in_presentacion_Bus();

        //Motivo venta
        fa_motivo_venta_Info _Motivo_venta_Info = new fa_motivo_venta_Info();
        fa_motivo_venta_Bus Motivo_venta_bus = new fa_motivo_venta_Bus();

        //Producto
        in_producto_Bus _ProductoBus = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus _Bus_producto_x_bodega = new in_producto_x_tb_bodega_Bus();

        in_Producto_Info _ProductoInfo = new in_Producto_Info();
        in_Producto_Info _ProductoInfoBase = new in_Producto_Info();
        List<in_Producto_Info> _ListProductoInfo = new List<in_Producto_Info>();


        #endregion

        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable DataTable_Excel_producto;
        DataTable DataTable_DATA_Categoria;
        DataTable DataTable_DATA_Linea;
        DataTable DataTable_DATA_Grupo;
        DataTable DataTable_DATA_SubGrupo;
        DataTable DataTable_DATA_Marca;
        DataTable DataTable_DATA_Presentacion;
        DataTable dt;

        #endregion

        public FrmIn_Producto_Wizard_Import_Edehsa()
        {
            InitializeComponent();
        }

        void PU_OBTENER_RUTA()
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "All files (*.*)|*.*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    fileName = System.IO.Path.GetFileName(dialogo.FileName);
                    path = Path.GetDirectoryName(dialogo.FileName);
                    tipofile = System.IO.Path.GetExtension(dialogo.FileName);
                    ruta = path + "\\" + fileName;
                    txtSeleccion.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public bool PU_CARGAR_EXCEL_GRILLA()
        {
            try
            {
                ruta = txtSeleccion.Text;
                plantilla = cmbHoja.Text;
                this.gridControlProductos.DataSource = null;
                _ListProductoInfo.Clear();
                if (ruta != "")
                {
                    if (Cargar_Excel_y_convertir_DT_a_Info())
                    {
                        this.gridControlProductos.DataSource = _ListProductoInfo;
                        return true;
                    }
                    else
                    { MessageBox.Show("Archivo no cumple formato de plantilla. " + MensajeError, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                }
                else
                { MessageBox.Show("Por favor seleccione archivo de plantilla válida.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public bool Cargar_Excel_y_convertir_DT_a_Info()
        {
            try
            {
                //categoria
                DataTable_DATA_Categoria = Cargar_ArchivoExcel_x_Categoria_A_DataTable();
                list_Categoria = Categoria_Bus.ProcesarDataTablein_categorias_Info(DataTable_DATA_Categoria, param.IdEmpresa, ref MensajeError);

                //Línea
                DataTable_DATA_Linea = Cargar_ArchivoExcel_x_Linea_A_DataTable();
                list_Linea = Linea_bus.ProcesarDataTablein_linea_info(DataTable_DATA_Linea, param.IdEmpresa, ref MensajeError);

                //grupo
                DataTable_DATA_Grupo = Cargar_ArchivoExcel_x_Grupo_A_DataTable();
                list_Grupo = Grupo_bus.ProcesarDataTablein_grupo_info(DataTable_DATA_Grupo, param.IdEmpresa, ref MensajeError);

                //SubGrupo
                DataTable_DATA_SubGrupo = Cargar_ArchivoExcel_x_SubGrupo_A_DataTable();
                list_SubGrupo = SubGrupo_bus.ProcesarDataTablein_subgrupo_info(DataTable_DATA_SubGrupo, param.IdEmpresa, ref MensajeError);

                //Marca
                DataTable_DATA_Marca = Cargar_ArchivoExcel_x_Marca_A_DataTable();
                list_Marca = Marca_bus.ProcesarDataTablein_Marca_Info(DataTable_DATA_Marca, param.IdEmpresa, ref MensajeError);

                //listado de presentación
                DataTable_DATA_Presentacion = Cargar_ArchivoExcel_x_Presentacion_A_DataTable();
                list_Presentacion = Presentacion_bus.ProcesarDataTablein_Presentacion_Info(DataTable_DATA_Presentacion, param.IdEmpresa, ref MensajeError);

                if (Cargar_ArchivoExcel_x_Producto_A_DataTable())
                {
                    MensajeError = "";
                    _ListProductoInfo = _ProductoBus.ProcesarDataTablein_Producto_Info(DataTable_Excel_producto, param.IdEmpresa, ref MensajeError);
                    if (MensajeError == "")
                        return true;
                    else
                        return false;
                }
                else
                {
                    MensajeError = "Archivo Incorrecto o Inexistente.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        DataTable Cargar_ArchivoExcel_x_Categoria_A_DataTable()
        {
            DataTable_DATA_Categoria = new DataTable();
            try
            {
                DataTable_DATA_Categoria.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [Categoria$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_Categoria);

                mconn.Close();
                return DataTable_DATA_Categoria;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_Categoria = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_Categoria;
            }
        }

        DataTable Cargar_ArchivoExcel_x_Linea_A_DataTable()
        {
            DataTable_DATA_Linea = new DataTable();
            try
            {
                DataTable_DATA_Linea.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [Linea$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_Linea);

                mconn.Close();
                return DataTable_DATA_Linea;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_Linea = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_Linea;
            }
        }

        DataTable Cargar_ArchivoExcel_x_Grupo_A_DataTable()
        {
            DataTable_DATA_Grupo = new DataTable();
            try
            {
                DataTable_DATA_Grupo.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [Grupo$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_Grupo);

                mconn.Close();
                return DataTable_DATA_Grupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_Grupo = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_Grupo;
            }
        }

        DataTable Cargar_ArchivoExcel_x_SubGrupo_A_DataTable()
        {
            DataTable_DATA_SubGrupo = new DataTable();
            try
            {
                DataTable_DATA_SubGrupo.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [SubGrupo$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_SubGrupo);

                mconn.Close();
                return DataTable_DATA_SubGrupo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_SubGrupo = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_SubGrupo;
            }
        }

        DataTable Cargar_ArchivoExcel_x_Marca_A_DataTable()
        {
            DataTable_DATA_Marca = new DataTable();
            try
            {
                DataTable_DATA_Marca.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [Marca$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_Marca);

                mconn.Close();
                return DataTable_DATA_Marca;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_Marca = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_Marca;
            }
        }

        DataTable Cargar_ArchivoExcel_x_Presentacion_A_DataTable()
        {
            DataTable_DATA_Presentacion = new DataTable();
            try
            {
                DataTable_DATA_Presentacion.Clear();

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [Presentacion$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_DATA_Presentacion);

                mconn.Close();
                return DataTable_DATA_Presentacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_DATA_Presentacion = new DataTable();
                MessageBox.Show(ex.Message);
                return DataTable_DATA_Presentacion;
            }
        }

        bool Cargar_ArchivoExcel_x_Producto_A_DataTable()
        {
            try
            {
                DataTable_Excel_producto = new DataTable();
                DataTable_Excel_producto.Clear();
                bool flag = false;

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                // strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [" + plantilla + "$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(DataTable_Excel_producto);
                if (DataTable_Excel_producto != null)
                    flag = true;
                else
                    flag = false;
                //cierra una conexion de tipo oledb
                mconn.Close();
                return flag;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                DataTable_Excel_producto = new DataTable();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool CargarHojas_en_Combo()
        {
            try
            {
                dt = new DataTable();
                dt.Clear();
                bool flag = false;

                OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder();
                cb.DataSource = ruta;

                if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLS")
                {
                    cb.Provider = "Microsoft.Jet.OLEDB.4.0";
                    cb.Add("Extended Properties", "Excel 8.0;HDR=YES;IMEX=0;");
                }
                else if (Path.GetExtension(cb.DataSource).ToUpper() == ".XLSX")
                {
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
                }

                //  String strconn2 = "";
                // strconn2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn2 = new OleDbConnection(cb.ConnectionString);
                //abre una conexion de tipo oledb
                mconn2.Open();
                dt = mconn2.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //Lo agrega a mi datatable
                if (dt != null)
                {
                    String[] excelSheets = new String[dt.Rows.Count];
                    int i = 0;

                    // Add the sheet name to the string array.
                    cmbHoja.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        excelSheets[i] = row["TABLE_NAME"].ToString();
                        cmbHoja.Items.Add(excelSheets[i].Substring(0, excelSheets[i].Length - 1)); //$
                        i++;
                    }
                    cmbHoja.SelectedIndex = 0;
                    //cierra una conexion de tipo oledb                
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                mconn2.Close();
                return flag;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                dt = new DataTable();
                return false;
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                lblMsg1.Visible = true;
                PU_OBTENER_RUTA();
                if (!CargarHojas_en_Combo())
                    MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblMsg1.Visible = false;
            }
            catch (Exception ex)
            {


            }

        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            string filePath = null;
            if (saveFileDialogProducto.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialogProducto.FileName;
                File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Ejemplo_Productos);
                MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void wizardControlImportProducto_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardControlImportProducto_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
                
        private void wizardControlImportProducto_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {

                e.Page.AllowNext = true;

                if (e.Page.Name == wizardPageSeleccionExcel.Name)
                {
                    PU_CARGAR_EXCEL_GRILLA();
                }

                if (e.Page.Name == wizardPageTipoDeIngresoDatos.Name)
                {
                    wizardPageEstadoGrabacion.AllowNext = false;
                }


            }
            catch (Exception ex)
            {
            }

        }

        private Boolean Proceso_Grabacion()
        {
            Boolean respuesta = false;
            int c = 1;
            int Total_Reg = 0;
            string SIdProducto = "";
            string nom_producto = "";

            BindingList<cl_estado_grabacion> ListEstadoGrabacion = new BindingList<cl_estado_grabacion>();

            try
            {
                string MensajeLog = "Ingreso Exitoso.";
                string MensajeWarning = "";
                string listaLog = "";
                this.rtbLog.Text = "";
                bool B_Proceso_anulacion = true;
                lblMensaje.Text = "";
                lblMensaje.Visible = false;
                decimal IdProducto = 0;
                int IdLinea = 0;
                int IdGrupo = 0;
                int IdSubGrupo = 0;
                int idMotivo = 0;

                gridControlProceGrabado.DataSource = ListEstadoGrabacion;

                if (gridControlProductos.DataSource != null)
                {
                    if (rgImportar.SelectedIndex == 0)
                        MensajeWarning = "Atención esta a punto de eliminar toda la información actual, y reemplazarla con la nueva. Está seguro de continuar?";
                    else
                        MensajeWarning = "Atención esta a punto de proceder. Está seguro de continuar?";
                    lblmsg3.Visible = true;

                    if (MessageBox.Show(MensajeWarning, "SISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        
                        if (rgImportar.SelectedIndex == 0)
                        {
                            //splashScreenManager.ShowWaitForm();
                            B_Proceso_anulacion = _Bus_producto_x_bodega.Delete_Todos_Producto_x_bodega (param.IdEmpresa, ref MensajeError);

                            B_Proceso_anulacion = _ProductoBus.Delete_Todos_Producto(param.IdEmpresa, ref MensajeError);

                            if (B_Proceso_anulacion)
                            {
                                ListEstadoGrabacion.Add(new cl_estado_grabacion(0, "", "Eliminado productos", "", "OK", "Eliminado Ok"));
                                gridControlProceGrabado.Refresh();
                            }
                            //splashScreenManager.CloseWaitForm();
                        }

                        if (B_Proceso_anulacion == true)
                        {
                            //splashScreenManager.ShowWaitForm();

                            Total_Reg = _ListProductoInfo.Count();
                            progressBar.Maximum = Total_Reg;
                            progressBar.Minimum = 1;
                            progressBar.Step = 1;
                            lblNumRegistros.Text = "0 registros de " + Total_Reg;
                            c = 1;

                            #region Listas
                            foreach (var item in list_Categoria)
                            {
                                respuesta = Categoria_Bus.GrabarDB(param.IdEmpresa, item, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Categoria no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (var item in list_Linea)
                            {
                                respuesta = Linea_bus.GrabarDB(item, ref IdLinea, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Línea no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (var item in list_Grupo)
                            {
                                respuesta = Grupo_bus.GrabarDB(item, ref IdGrupo, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Grupo no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (var item in list_SubGrupo)
                            {
                                respuesta = SubGrupo_bus.GrabarDB(item, ref IdSubGrupo, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de SubGrupo no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (var item in list_Marca)
                            {
                                respuesta = Marca_bus.GrabarDB(item, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Marca no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            _Motivo_venta_Info = new fa_motivo_venta_Info();
                            _Motivo_venta_Info.IdEmpresa = param.IdEmpresa;
                            _Motivo_venta_Info.IdMotivo_Vta = 1;
                            _Motivo_venta_Info.codMotivo_Vta = "1";
                            _Motivo_venta_Info.descripcion_motivo_vta = "no definido";
                            _Motivo_venta_Info.Estado = "A";
                            _Motivo_venta_Info.FechaCreacion = param.Fecha_Transac;
                            _Motivo_venta_Info.UsuarioCreacion = param.IdUsuario;

                            respuesta = Motivo_venta_bus.Grabar(_Motivo_venta_Info, ref idMotivo, ref MensajeError);
                           
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Motivo de venta no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }    

                            foreach (var item in list_Presentacion)
                            {
                                respuesta = Presentacion_bus.GuardarDB(item, ref MensajeError);
                            }
                            if (!respuesta)
                            {
                                MessageBox.Show("La Hoja de Presentación no cumple con el formato de la plantilla", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }

                            foreach (in_Producto_Info item in _ListProductoInfo)
                            {
                                SIdProducto = item.IdProducto.ToString();
                                nom_producto = item.pr_descripcion;
                                item.IdProducto = 0;//en caso de que sea conservar
                                item.IdCategoria = "1";
                                item.IdLinea = 1;
                                item.IdGrupo = 1;
                                item.IdSubGrupo = 1;
                                item.IdMarca = 1;
                                item.IdProductoTipo = 2;
                                item.IdPresentacion = "1";
                                item.IdUnidadMedida = "UNID";
                                item.IdUnidadMedida_Consumo = "UNID";
                                item.IdCod_Impuesto_Iva = "IVA12"; ;
                                item.IdMotivo_Vta = 1;
                                item.Estado = "A";
                                item.ManejaKardex = "N";
                                
                                respuesta = _ProductoBus.GrabarDB(item, ref IdProducto, ref MensajeError);
                                if (respuesta)
                                {
                                    #region Producto por bodega
                                    foreach (var Sucursal in lst_Sucursal)
                                    {
                                        foreach (var Bodega in lst_Bodega)
                                        {
                                            if (Bodega.IdSucursal == Sucursal.IdSucursal)
                                            {
                                                info_producto_x_bodega = new in_producto_x_tb_bodega_Info();
                                                info_producto_x_bodega.IdEmpresa = item.IdEmpresa;
                                                info_producto_x_bodega.IdSucursal = Sucursal.IdSucursal;
                                                info_producto_x_bodega.IdBodega = Bodega.IdBodega;
                                                info_producto_x_bodega.IdProducto = item.IdProducto;
                                                info_producto_x_bodega.pr_precio_publico = item.pr_precio_publico;
                                                info_producto_x_bodega.pr_precio_mayor = item.pr_precio_mayor;
                                                info_producto_x_bodega.pr_precio_puerta = item.pr_precio_puerta;
                                                info_producto_x_bodega.pr_precio_minimo = item.pr_precio_minimo;
                                                info_producto_x_bodega.pr_Por_descuento = item.pr_Por_descuento;
                                                //info_producto_x_bodega.pr_stock = item.pr_stock;
                                                info_producto_x_bodega.pr_stock_maximo = item.pr_stock_maximo;
                                                info_producto_x_bodega.pr_stock_minimo = item.pr_stock_minimo;
                                                info_producto_x_bodega.pr_costo_fob = item.pr_costo_fob;
                                                info_producto_x_bodega.pr_costo_CIF = item.pr_costo_CIF;
                                                info_producto_x_bodega.pr_costo_promedio = item.pr_costo_promedio;
                                                //Cuentas contables
                                                info_producto_x_bodega.IdCtaCble_Inven = cmb_IdCtaCble_Inven.get_PlanCtaInfo().IdCtaCble;//1
                                                info_producto_x_bodega.IdCtaCble_VenIva = cmb_IdCtaCble_VenIva.get_PlanCtaInfo().IdCtaCble;//2
                                                info_producto_x_bodega.IdCtaCble_Ven0 = cmb_IdCtaCble_Ven0.get_PlanCtaInfo().IdCtaCble;//3
                                                info_producto_x_bodega.IdCtaCble_DevIva = cmb_IdCtaCble_DesIva.get_PlanCtaInfo().IdCtaCble;//4
                                                info_producto_x_bodega.IdCtaCble_Des0 = cmb_IdCtaCble_Des0.get_PlanCtaInfo().IdCtaCble;//5
                                                info_producto_x_bodega.IdCtaCble_DevIva = cmb_IdCtaCble_DevIva.get_PlanCtaInfo().IdCtaCble;//6
                                                info_producto_x_bodega.IdCtaCble_Dev0 = cmb_IdCtaCble_Dev0.get_PlanCtaInfo().IdCtaCble;//7
                                                info_producto_x_bodega.IdCtaCble_Costo = cmb_IdCtaCble_Costo.get_PlanCtaInfo().IdCtaCble;//8
                                                info_producto_x_bodega.IdCtaCble_Gasto_x_cxp = cmb_IdCtaCble_Gasto_x_cxp.get_PlanCtaInfo().IdCtaCble;//9
                                                info_producto_x_bodega.IdCtaCble_Vta = cmb_IdCtaCble_Vta.get_PlanCtaInfo().IdCtaCble;//10
                                                //Fin cuentas contables
                                                info_producto_x_bodega.Estado = "A";
                                                respuesta = bus_producto_x_bodega.GrabaDB(info_producto_x_bodega, param.IdEmpresa, ref MensajeError);
                                            } 
                                        }
                                    }
                                    #endregion

                                    ListEstadoGrabacion.Add(new cl_estado_grabacion(c, item.IdProducto.ToString(), item.pr_codigo, item.pr_descripcion, "OK", "Migrado Ok"));
                                    progressBar.Value = c;
                                    lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                    progressBar.Refresh();
                                    Application.DoEvents();
                                }
                                c++;
                            }
                            #endregion

                            if (listaLog != "")
                                MensajeLog += " pero con errores:" + "\n" + listaLog + MensajeError;
                        }
                    }
                    else
                    {
                        MensajeLog = "No se efectuó la operación. Operación cancelada por el usuario.";
                    }
                    lblmsg3.Visible = false;
                }
                else
                {
                    MensajeLog = "No existen Datos para importación.";
                }
                this.rtbLog.Text = MensajeLog;
                //splashScreenManager.CloseWaitForm();
                return respuesta;
            }
            catch (Exception ex)
            {
                //splashScreenManager.CloseWaitForm();
                ListEstadoGrabacion.Add(new cl_estado_grabacion(c++, SIdProducto, SIdProducto, nom_producto, "ERROR", "No Migrado:" + ex.ToString()));
                gridControlProceGrabado.Refresh();
                lblMensaje.Text = "Error al cargar " + ex.ToString();
                lblMensaje.Visible = true;
                return respuesta;
            }
        }

        private class cl_estado_grabacion
        {
            public int Secuencia { get; set; }
            public string IdProducto { get; set; }
            public string cod_producto { get; set; }
            public string nom_producto { get; set; }
            public string Estado_grabado { get; set; }
            public string Observacion { get; set; }

            public cl_estado_grabacion()
            {
            }

            public cl_estado_grabacion(int Secuencia, string _IdProducto, string _cod_producto, string _nom_producto, string _Estado_grabado, string _Observacion)
            {
                IdProducto = _IdProducto;
                cod_producto = _cod_producto;
                nom_producto = _nom_producto;
                Estado_grabado = _Estado_grabado;
                Observacion = _Observacion;
            }
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Cargar_sucursales_bodegas();
            Proceso_Grabacion();
            wizardPageEstadoGrabacion.AllowNext = true;
        }

        private void FrmIn_Producto_Winzard_Import_Load(object sender, EventArgs e)
        {
           
        }

        private void Cargar_sucursales_bodegas()
        {
            try
            {
                lst_Sucursal = bus_Sucursal.Get_List_Sucursal(param.IdEmpresa);
                lst_Bodega = bus_Bodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
