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

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_ImportWizard : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #region DATA
        cp_proveedor_Bus _ProveedorBus = new cp_proveedor_Bus();
        cp_proveedor_Info _ProveedorInfo = new cp_proveedor_Info();
        cp_proveedor_Info _ProveedorInfoBase = new cp_proveedor_Info();
        List<cp_proveedor_Info> _ListClienteInfo = new List<cp_proveedor_Info>();
        tb_persona_bus _PersonaBus = new tb_persona_bus();
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        List<tb_persona_Info> _ListPersonaInfo = new List<tb_persona_Info>();
        #endregion
        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();

        string IdCtaCble_CXP = "";
        string IdCtaCble_Anticipo = "";
        string IdCtaCble_Gasto = "";
        #endregion
        #region Delegados

        public delegate void delegate_frmCP_Proveedor_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Proveedor_ImportacionWizard_FormClosing event_frmCP_Proveedor_ImportacionWizard_FormClosing;

        #endregion
        public frmCP_Proveedor_ImportWizard()
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Proceso_Grabacion()
        {
            int c = 1;
            int Total_Reg = 0;
            decimal SIdProveedor = 0;
          string SNom_Prov = "";
            

            BindingList<cl_estado_grabacion> ListEstadoGrabacion = new BindingList<cl_estado_grabacion>();

            try
            {
                string MensajeLog = "Ingreso Exitoso.";
                string MensajeWarning = "";
                string listaLog = "";
                this.rtbLog.Text = "";
                bool flagSinError = true;
                bool flagNuevoEmpleado = true;
                bool flagNuevaPersona = true;
                decimal IdProveedor = 0;
                decimal idPersona = 0;
                string cedula = "";
                int IdEmpresa = param.IdEmpresa;
                lblMensaje.Text = "";
                lblMensaje.Visible = false;

                gridControl_estado_grab_x_proveedor.DataSource = ListEstadoGrabacion;


                if (this.gridControlProveedor.DataSource != null)
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
                            if (!_ProveedorBus.EliminarDB_Todos(IdEmpresa, ref MensajeError))
                            {
                                MensajeLog = "Error al eliminar registros en bases de datos \n" + MensajeError;
                                flagSinError = false;
                            }
                        }

                        if (flagSinError == true)//si es falso es porque entro al Eliminar y tuvo error, realmente no deberia hacer nada.
                        {
                            
                            //splashScreenManager.ShowWaitForm();

                            Total_Reg = _ListClienteInfo.Count();
                            progressBar.Maximum = Total_Reg;
                            progressBar.Minimum = 1;
                            progressBar.Step = 1;
                            lblNumRegistros.Text = "0 registros de " + Total_Reg;
                            c = 1;

                            foreach (cp_proveedor_Info item in _ListClienteInfo)
                            {
                                flagSinError = true;
                                cedula = item.Persona_Info.pe_cedulaRuc.Trim();
                                _PersonaInfo = _PersonaBus.Get_Info_Persona(cedula);
                                if (_PersonaInfo.IdPersona != 0)
                                {
                                    idPersona = _PersonaInfo.IdPersona;
                                    item.IdPersona = idPersona;
                                    item.Persona_Info.IdPersona = idPersona;
                                    _PersonaInfo.pe_telfono_Contacto = item.Persona_Info.pe_telfono_Contacto;
                                    //_PersonaInfo.pe_correo = (item.Persona_Info.pe_correo == null) ? "" : "";
                                    
                                    _PersonaInfo.pe_direccion = item.Persona_Info.pe_direccion.Trim();
                                    

                                    flagNuevaPersona = false;//ya esta la persona en la base de datos
                                    if (!_PersonaBus.ModificarDB(_PersonaInfo, ref MensajeError))//para grabar nuevos datos
                                    {
                                        listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.pr_nombre + " ;" + "\n";
                                        flagSinError = false;
                                    }
                                }
                                else
                                {
                                    _PersonaInfo = item.Persona_Info;
                                    //_PersonaInfo.IdTipoPersona = "PROVEE";
                                    flagNuevaPersona = true;//es nueva persona
                                    if (!_PersonaBus.GrabarDB(_PersonaInfo, ref idPersona, ref MensajeError))
                                    {
                                        listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.pr_nombre + " -" + "\n";
                                        flagSinError = false;
                                    }
                                }
                                if (flagSinError == true)//si es false, porque  dio error en persona, para que intentar el cliente
                                {
                                    item.IdPersona = idPersona;
                                    item.Persona_Info.IdPersona = idPersona;
                                    if ((rgImportar.SelectedIndex == 0) || (flagNuevaPersona == true))
                                        flagNuevoEmpleado = true;

                                    else//si no elimino previamente todos los empleados, y la persona no es nueva busco el cliente
                                    {
                                        _ProveedorInfoBase = _ProveedorBus.Get_Info_Proveedor_x_Persona(IdEmpresa, idPersona, ref MensajeError);//busco el cliente por la persona
                                        if (_ProveedorInfoBase.IdProveedor == 0)
                                            flagNuevoEmpleado = true;//si no encontro empleado, entonces es nuevo
                                        else
                                        {
                                            item.IdProveedor = _ProveedorInfoBase.IdProveedor;
                                            flagNuevoEmpleado = false;
                                        }
                                    }

                                    if (flagNuevoEmpleado == true)//si el empleado es nuevo, o actualizo
                                    {
                                        if (item.pr_codigo.Trim() == "98") { MessageBox.Show(""); }

                                        if (!_ProveedorBus.GrabarDB(item, ref IdProveedor, ref MensajeError))
                                        {
                                            listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.pr_nombre + " _" + "\n";
                                        }
                                        else
                                        {
                                            SIdProveedor = item.IdProveedor;
                                            SNom_Prov = item.pr_nombre;
                                            ListEstadoGrabacion.Add(new cl_estado_grabacion(c, item.IdProveedor, item.pr_nombre, item.pr_codigo, item.pr_contribuyenteEspecial, "OK", "Migrado Ok"));
                                            gridControl_estado_grab_x_proveedor.Refresh();
                                            progressBar.Value = c;
                                            lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                            progressBar.Refresh();
                                            Application.DoEvents();
                                            c++;
                                        }
                                    }
                                    else
                                    {
                                        if (!_ProveedorBus.ModificarDB(item))
                                            listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.pr_nombre + " ." + "\n";
                                    }
                                }//fin sin error /en la Persona

                            }//fin for each
                        }//fin sin error /al Eliminar
                        if (listaLog != "")
                            MensajeLog += " pero con errores:" + "\n" + listaLog + MensajeError;
                        else
                        {
                            if(IdCtaCble_CXP!=null && IdCtaCble_Anticipo!=null && IdCtaCble_Gasto!=null)
                                _ProveedorBus.ModificarDB_Cuentas_cbles(param.IdEmpresa, IdCtaCble_CXP, IdCtaCble_Anticipo, IdCtaCble_Gasto, ref MensajeError);
                        }
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
                //splashScreenManager.CloseWaitForm();
                ListEstadoGrabacion.Add(new cl_estado_grabacion(9000, SIdProveedor, SNom_Prov, "", "", "ERROR", ex.Message));
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
                this.gridControlProveedor.DataSource = null;
                _ListPersonaInfo.Clear();
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                        this.gridControlProveedor.DataSource = _ListClienteInfo;

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
                    _ListClienteInfo = _ProveedorBus.ProcesarDataTablePc_Proveedor_Info(ds, param.IdEmpresa, param.IdSucursal, ref MensajeError);
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
               // String strconn = "";
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
                    cb.Provider = "Microsoft.Jet.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 XML;HDR=YES;IMEX=0;");
                   
                }

              //  strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
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
                    cb.Add("Extended Properties", "Excel 12.0 XML;HDR=YES;IMEX=0;");
                }

                  
               // String strconn2 = "";
              //  strconn2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;";
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
                File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Ejemplo_Proveedores);
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

        private void frmCP_Proveedor_ImportWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCP_Proveedor_ImportacionWizard_FormClosing(sender,e);
        }

        private void frmCP_Proveedor_ImportWizard_Load(object sender, EventArgs e)
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
                IdCtaCble_CXP = ucCon_PlanCtaCmb_CxP_Proveedores.get_PlanCtaInfo().IdCtaCble;
                IdCtaCble_Anticipo = ucCon_PlanCtaCmb_CxC_Anticipos.get_PlanCtaInfo().IdCtaCble;
                IdCtaCble_Gasto = ucCon_PlanCtaCmb_CxC_Gastos.get_PlanCtaInfo().IdCtaCble;
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
        public decimal IdProveedor { get; set; }
        public Decimal IdPersona { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string pr_contribuyenteEspecial { get; set; }
        public int Secuencia { get; set; }
        public string Estado_grabado { get; set; }

        public cl_estado_grabacion()
        {

        }



        public cl_estado_grabacion(int _Secuencia, decimal _IdProveedor, string _pr_nombre, string _pr_codigo, string _pr_contribuyenteEspecial, string _Estado_grabado, string _Observacion)
        {
            IdProveedor = _IdProveedor;
            pr_nombre = _pr_nombre;
            pr_codigo = _pr_codigo;
            Estado_grabado = _Estado_grabado;
            pr_contribuyenteEspecial = _pr_contribuyenteEspecial;
            Secuencia = _Secuencia;

        }

    }
}
