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
using Core.Erp.Info.Roles;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_ActivoFijo_ImportWizard : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #region DATA

        List<Af_Activo_fijo_Info> _ListActivoFijoInfo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Bus _ActivoFijoBus = new Af_Activo_fijo_Bus();
        Af_Activo_fijo_Info _ActivoFijoInfo = new Af_Activo_fijo_Info();
        Af_Activo_fijo_Categoria_Bus actfijo_cat_Bus = new Af_Activo_fijo_Categoria_Bus();
        Af_Activo_fijo_tipo_Bus actfijo_tipo_Bus = new Af_Activo_fijo_tipo_Bus();
        #endregion
        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();

        /*string IdCtaCble_CXP = "";
        string IdCtaCble_Anticipo = "";
        string IdCtaCble_Gasto = "";*/
        #endregion
        #region Delegados

        public delegate void delegate_frmAF_ActivoFijo_ImportWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_ActivoFijo_ImportWizard_FormClosing event_frmAF_ActivoFijo_ImportWizard_FormClosing;

        #endregion
        public frmAF_ActivoFijo_ImportWizard()
        {
            InitializeComponent();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            lblMsg1.Visible = true;
            PU_OBTENER_RUTA();
            if (!CargarHojasCombo())
                MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            lblMsg1.Visible = false;
        }

        private void PU_OBTENER_RUTA()
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Proceso_Grabacion()
        {
            int Total_Reg = 0;
            int c=1;

          
            
            BindingList<cl_estado_grabacion> ListEstadoGrabacion = new BindingList<cl_estado_grabacion>();

            try
            {
                string MensajeLog = "Ingreso Exitoso.";
                string MensajeWarning = "";
                string listaLog = "";
                this.rtbLog.Text = "";
                bool flagSinError = true;
                bool flagNuevoActivoFijo = true;
                int IdActivoFijo = 0;
                string CodActivoFijo = "";
                int IdEmpresa = param.IdEmpresa;
                lblMensaje.Text = "";
                lblMensaje.Visible = false;

                gridControl_estado_grab_x_activofijo.DataSource = ListEstadoGrabacion;


                if (this.gridControlActivoFijo.DataSource != null)
                {
                    if (rgImportar.SelectedIndex == 0)
                        MensajeWarning = "Atencion esta a punto de eliminar toda la informacion actual, y reemplazarla con la nueva. Esta seguro de continuar?";
                    else
                        MensajeWarning = "Atencion esta a punto de proceder. Esta seguro de continuar?";
                    lblmsg3.Visible = true;
                    if (MessageBox.Show(MensajeWarning, "SISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (rgImportar.SelectedIndex == 0)
                        {
                            if (!_ActivoFijoBus.EliminarDB_Todos(IdEmpresa, ref MensajeError))
                            {
                                MensajeLog = "Error al eliminar registros en bases de datos \n" + MensajeError;
                                flagSinError = false;
                            }
                        }

                        if (flagSinError == true)//si es falso es porque entro al Eliminar y tuvo error, realmente no deberia hacer nada.
                        {
                            //splashScreenManager.ShowWaitForm();

                            Total_Reg = _ListActivoFijoInfo.Count();
                            progressBar.Maximum = Total_Reg;
                            
                            progressBar.Minimum = 1;
                            progressBar.Step = 1;
                            lblNumRegistros.Text = "0 registros de " + Total_Reg;
                            c = 1;

                            foreach (Af_Activo_fijo_Info item in _ListActivoFijoInfo)
                            {
                                flagSinError = true;
                                CodActivoFijo = item.CodActivoFijo;       
                                /*
                                _ActivoFijoInfo = _ActivoFijoBus.Get_ActivoFijo_x_CODIGO(param.IdEmpresa, CodActivoFijo);
                                if (_ActivoFijoInfo.IdActivoFijo != 0)
                                {
                                    IdActivoFijo = _ActivoFijoInfo.IdActivoFijo;
                                    item.IdActivoFijo = IdActivoFijo;
                                    item.Af_Nombre = _ActivoFijoInfo.Af_Nombre;
                      
                                    flagNuevoActivoFijo = false;//el activo fijo ya esta en la base de datos
                                    if (!_ActivoFijoBus.ModificarDB(_ActivoFijoInfo, ref MensajeError))//para grabar nuevos datos
                                    {
                                        listaLog += "Cod: " + item.CodActivoFijo + "\t" + item.Af_Nombre + " ;" + "\n";
                                        flagSinError = false;
                                    }

                                }
                                else*/
                                {
                                    _ActivoFijoInfo = item;
                                    flagNuevoActivoFijo = true;//es nuevo activo fijo
                                    if (!_ActivoFijoBus.GrabarDB(_ActivoFijoInfo,ref IdActivoFijo ,ref CodActivoFijo,ref MensajeError))
                                    {
                                        listaLog += "Cod: " + item.CodActivoFijo + "\t" + item.Af_Nombre + " -" + "\n";
                                        flagSinError = false;
                                    }
                                }
                                if (flagSinError == true)
                                {
                                    ListEstadoGrabacion.Add(new cl_estado_grabacion(c, item.IdActivoFijo, item.Af_Nombre, item.CodActivoFijo, "OK", "Migrado Ok"));
                                    gridControl_estado_grab_x_activofijo.Refresh();
                                    progressBar.Value = c;
                                    lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                    progressBar.Refresh();
                                    Application.DoEvents();
                                    c++;
                                    
                                }
                            }//fin for each
                        }//fin sin error /al Eliminar

                        if (listaLog != "")
                            MensajeLog += " pero con errores:" + "\n" + listaLog + MensajeError;
                    }//Fin del warning del messageBox al aceptar viene el else
                    else
                    {
                        MensajeLog = "No se efectuo la operación. Operacion cancelada por el usuario.";
                    }
                    lblmsg3.Visible = false;
                }//fin del grid no nulo
                else
                {
                    MensajeLog = "No existen Datos para importación.";
                }
                this.rtbLog.Text = MensajeLog;
            }
            catch (Exception ex)
            {
              //  splashScreenManager.CloseWaitForm();
                //ListEstadoGrabacion.Add(new cl_estado_grabacion(_IdActF,CodActFi,act_nom,
                  // act_cat,Convert.ToDateTime(act_fec_comp),Convert.ToDateTime(act_fec_inidep),
                //  Convert.ToDateTime(act_fec_findep),act_coscomp,act_dep_acu,act_ult_dep,act_cos_net, ex.Message));
                lblMensaje.Text = "Error al cargar " + ex.ToString();
                lblMensaje.Visible = true;
            }
        }

        public bool PU_CARGAR_EXCEL_GRILLA()
        {
            try
            {
                ruta = txtSeleccion.Text;
                plantilla = cmbHoja.Text;
                this.gridControlActivoFijo.DataSource = null;
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                         this.gridControlActivoFijo.DataSource = _ListActivoFijoInfo;
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool PU_CARGA_EXCEL()
        {
            try
            {
                if (CargarArchivoExcelADataTable())
                {
                    MensajeError = "";
                    _ListActivoFijoInfo = _ActivoFijoBus.ProcesarDataTablePc_ActivoFijo_Info(ds, param.IdEmpresa, param.IdSucursal, ref MensajeError);
                    if (MensajeError == "")
                        return true;
                    else
                    {
                        return false;
                    }
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool CargarArchivoExcelADataTable()
        {
            try
            {
                ds.Clear();
                //String strconn = "";
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
                    cb.Add("Extended Properties", "Excel 12.0 XML;HDR=YES;IMEX=0;");
                }

                //strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
                OleDbConnection mconn = new OleDbConnection(cb.ConnectionString);
                //El nombre de la hoja del archivo de marcaciones tiene que llamarse Marcaciones
                OleDbDataAdapter ad = new OleDbDataAdapter("Select * from [" + plantilla + "$]", mconn);
                //abre una conexion de tipo oledb
                mconn.Open();
                //Lo agrega a mi datatable
                ad.Fill(ds);
                if (ds != null)
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = new DataTable();
                return false;
            }
        }

        bool CargarHojasCombo()
        {
            try
            {
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
                


                //String strconn2 = "";
                //strconn2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = new DataTable();
                return false;
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            string filePath = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Activo_Fijo_Ejemplo); 
                MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_ActivoFijo_ImportWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmAF_ActivoFijo_ImportWizard_FormClosing(sender, e);
        }

        private void frmAF_ActivoFijo_ImportWizard_Load(object sender, EventArgs e)
        {
            cmbHoja.SelectedIndex = 0;
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page.Name == "wizardPage1")
            {
                //if (!PU_CARGAR_EXCEL_GRILLA())
                PU_CARGAR_EXCEL_GRILLA();
            }

            if (e.Page.Name == "wizardPage4")
            {
                /*IdCtaCble_CXP = ucCon_PlanCtaCmb_CxP_Proveedores.get_PlanCtaInfo().IdCtaCble;
                IdCtaCble_Anticipo = ucCon_PlanCtaCmb_CxC_Anticipos.get_PlanCtaInfo().IdCtaCble;
                IdCtaCble_Gasto = ucCon_PlanCtaCmb_CxC_Gastos.get_PlanCtaInfo().IdCtaCble;*/
            }

            if (e.Page.Name == "wizardPage3")
            {
                
            }//fin del wizardpage 3            
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            try
            {
                Proceso_Grabacion();
                wizardPageEstadoGrabacion.AllowNext = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void lblNumRegistros_Click(object sender, EventArgs e)
        {

        }

       
    }

    class cl_estado_grabacion
    {
        public int IdActivoFijo { get; set; }
        public string Af_CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public DateTime Af_Fecha_compra { get; set; }
        public DateTime Af_fecha_ini_depre { get; set; }
        public DateTime Af_fecha_fin_depre { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_depreciacion_acumulada { get; set; }
        public double Af_ultima_depreciacion { get; set; }
        public double Af_costo_neto { get; set; }
        public int Secuencia { get; set; }
        public string Estado_grabado { get; set; }


        public cl_estado_grabacion(int _Secuencia, int _IdActivoFijo, string _af_nombre, string _Af_CodActivoFijo, string _Estado_grabado, string _Observacion)
        {
            IdActivoFijo = _IdActivoFijo;
            Af_Nombre = _af_nombre;
            Af_CodActivoFijo = _Af_CodActivoFijo;
            Estado_grabado = _Estado_grabado;
            Secuencia = _Secuencia;
        }

        public cl_estado_grabacion(int _IdActivoFijo, string _Af_CodActivoFijo, string _Af_Nombre, DateTime _Af_Fecha_compra, DateTime _Af_fecha_ini_depre, 
            DateTime _Af_fecha_fin_depre, double _Af_costo_compra, double _Af_depreciacion_acumulada,double _Af_ultima_depreciacion ,double _Af_costo_neto, string _Observacion)
        {
            IdActivoFijo = _IdActivoFijo;
            Af_CodActivoFijo = _Af_CodActivoFijo;
            Af_Nombre = _Af_Nombre;
            Af_Fecha_compra = _Af_Fecha_compra;
            Af_fecha_ini_depre = _Af_fecha_ini_depre;
            Af_fecha_fin_depre = _Af_fecha_fin_depre;
            Af_costo_compra = _Af_costo_compra;
            Af_depreciacion_acumulada = _Af_depreciacion_acumulada;
            Af_ultima_depreciacion = _Af_ultima_depreciacion;
            Af_costo_neto = _Af_costo_neto;
        }

    }
}
