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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Clientes_ImportacionWizard : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #region DATA
        fa_Cliente_Bus _ClienteBus = new fa_Cliente_Bus();
        fa_Cliente_Info _ClienteInfo = new fa_Cliente_Info();
        fa_Cliente_Info _ClienteInfoBase = new fa_Cliente_Info();
        List<fa_Cliente_Info> _ListClienteInfo = new List<fa_Cliente_Info>();
        tb_persona_bus _PersonaBus = new tb_persona_bus();
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        List<tb_persona_Info> _ListPersonaInfo = new List<tb_persona_Info>();

        string cxc_Contado = "";
        string cxc_Credito = "";
        string cxc_Anticipo = "";

        #endregion
       #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();
        #endregion
        #region Delegados

        public delegate void delegate_frmFa_Clientes_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFa_Clientes_ImportacionWizard_FormClosing event_frmFa_Clientes_ImportacionWizard_FormClosing;

        #endregion
        public frmFa_Clientes_ImportacionWizard()
        {
            InitializeComponent();
            event_frmFa_Clientes_ImportacionWizard_FormClosing += frmFa_Clientes_ImportacionWizard_event_frmFa_Clientes_ImportacionWizard_FormClosing;
        }
        void frmFa_Clientes_ImportacionWizard_event_frmFa_Clientes_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {

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
            }
        }

        void Proceso_Grabacion()
        {
            Boolean respuesta = false;
            int c = 1;
            int Total_Reg = 0;
            decimal idcliente = 0;
            string nombre = "";

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
                decimal idCliente = 0;
                decimal idPersona = 0;
                string cedula = "";
                int IdEmpresa = param.IdEmpresa;
                richTextBoxError.Text = "";
            

                gridControlClientes.DataSource = ListEstadoGrabacion;

                if (this.gridControl_Clientes.DataSource != null)
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
                            if (!_ClienteBus.Eliminar_Clientes(IdEmpresa, ref MensajeError))
                            {
                                MensajeLog = "Error al eliminar registros en bases de datos \n" + MensajeError;
                                flagSinError = false;
                            }
                        }

                        if (flagSinError == true)//si es falso es porque entro al Eliminar y tuvo error, realmente no deberia hacer nada.
                        {
                            Total_Reg = _ListClienteInfo.Count();
                            progressBar.Maximum = Total_Reg;
                            progressBar.Minimum = 1;
                            progressBar.Step = 1;
                            lblNumRegistros.Text = "0 registros de " + Total_Reg;
                            c = 1;

                            foreach (fa_Cliente_Info item in _ListClienteInfo)
                            {
                                flagSinError = true;
                                cedula = item.Persona_Info.pe_cedulaRuc;
                                _PersonaInfo = _PersonaBus.Get_Info_Persona(cedula);
                                if (_PersonaInfo.IdPersona != 0)
                                {
                                    idPersona = _PersonaInfo.IdPersona;
                                    item.Persona_Info = _PersonaInfo;
                                    flagNuevaPersona = false;//ya esta la persona en la base de datos
                                }
                                else
                                {
                                    _PersonaInfo = item.Persona_Info;
                                    flagNuevaPersona = true;//es nueva persona

                                    if (!_PersonaBus.GrabarDB(_PersonaInfo, ref idPersona, ref MensajeError))
                                    {
                                        listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.Persona_Info.pe_razonSocial + " -" + "\n";
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
                                        _ClienteInfoBase = _ClienteBus.Get_info_Cliente_x_IdPersona(IdEmpresa, idPersona);//busco el cliente por la persona
                                        if (_ClienteInfoBase.IdCliente == 0)
                                            flagNuevoEmpleado = true;//si no encontro empleado, entonces es nuevo
                                        else
                                        {
                                            item.IdCliente = _ClienteInfoBase.IdCliente;
                                            flagNuevoEmpleado = false;
                                        }
                                    }

                                    if (flagNuevoEmpleado == true)//si el empleado es nuevo, o actualizo
                                    {
                                                                       
                                        if (!_ClienteBus.GrabarDB(item, ref idPersona, ref idCliente, ref MensajeError))
                                        {
                                            listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.Persona_Info.pe_razonSocial + " _" + "\n";
                                        }
                                        else
                                        {
                                            idcliente = item.IdCliente;
                                            nombre = item.Persona_Info.pe_razonSocial;
                                            ListEstadoGrabacion.Add(new cl_estado_grabacion(c, item.IdCliente, item.Persona_Info.pe_razonSocial, item.Codigo, "OK", "Migrado Ok"));
                                            gridControlClientes.Refresh();
                                            progressBar.Value = c;
                                            lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                            progressBar.Refresh();
                                            Application.DoEvents();
                                            c++;
                                        }
                                    }
                                    else
                                    {
                                       // if (!_ClienteBus.ModificarDB(item,ref MensajeError))
                                            listaLog += "Ced: " + item.Persona_Info.pe_cedulaRuc + "\t" + item.Persona_Info.pe_razonSocial + " ." + "\n";

                                            idcliente = item.IdCliente;
                                            nombre = item.Persona_Info.pe_razonSocial;
                                            ListEstadoGrabacion.Add(new cl_estado_grabacion(c, item.IdCliente, item.Persona_Info.pe_razonSocial, item.Codigo, "YA EXISTE EN BASE", "actualizado Ok"));
                                            gridControlClientes.Refresh();
                                            progressBar.Value = c;
                                            lblNumRegistros.Text = c + " registros de " + Total_Reg;
                                            progressBar.Refresh();
                                            Application.DoEvents();
                                            c++;
                                    }
                                }//fin sin error /en la Persona

                            }//fin for each
                        }//fin sin error /al Eliminar
                        if (listaLog != "")
                            MensajeLog += " pero con errores:" + "\n" + listaLog + MensajeError;
                        else
                        {
                            if(cxc_Contado!=null && cxc_Anticipo!=null && cxc_Credito!=null)
                                _ClienteBus.ModificarDB_Cuentas_cbles(param.IdEmpresa, cxc_Contado, cxc_Anticipo, cxc_Credito, ref MensajeError);
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
                ListEstadoGrabacion.Add(new cl_estado_grabacion(c, idcliente, nombre, "", "ERROR", ex.Message));
                richTextBoxError.Text = "Error al cargar " + ex.ToString();
            
            }
        }

        public bool PU_CARGAR_EXCEL_GRILLA()
        {
            try
            {
                ruta = txtSeleccion.Text;
                plantilla = cmbHoja.Text;
                this.gridControl_Clientes.DataSource = null;
                _ListPersonaInfo.Clear();
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                        this.gridControl_Clientes.DataSource = _ListClienteInfo;

                        return true;
                    }
                    else
                    { MessageBox.Show("Archivo no cumple formato de plantilla. "+MensajeError, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
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

        public bool PU_CARGA_EXCEL()
        {
            try
            {
                if (CargarArchivoExcelADataTable())
                {
                    MensajeError = "";
                    _ListClienteInfo = _ClienteBus.ProcesarDataTableFa_Cliente_Info(ds, param.IdEmpresa, param.IdSucursal, ref MensajeError);

                    
                    if (MensajeError=="")
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
                return false;
            }
        }

        bool CargarArchivoExcelADataTable()
        {
            try
            {
                ds.Clear();
                //String strconn = "";
                bool flag=false;

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
                ds = new DataTable();
                return false;
            }
        }

        bool CargarHojasCombo()
        {
            try
            {
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
                
                
                
                dt.Clear();
                bool flag = false;
               // String strconn2 = "";
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
                        cmbHoja.Items.Add(excelSheets[i].Substring(0,excelSheets[i].Length-1)); //$
                        i++;
                    }
                    cmbHoja.SelectedIndex=0;
                    //cierra una conexion de tipo oledb                
                    flag= true;
                }
                else
                {
                    flag= false;
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

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
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

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
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

        private void frmFa_Clientes_ImportacionWizard_Load(object sender, EventArgs e)
        {
            cmbHoja.SelectedIndex = 0;
        }

        private void frmFa_Clientes_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmFa_Clientes_ImportacionWizard_FormClosing(sender, e);
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            string filePath = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Ejemplo_Clientes);
                MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
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
                  cxc_Contado = ucCon_PlanCtaCmb_CxC.get_PlanCtaInfo().IdCtaCble;
                  cxc_Credito = ucCon_PlanCtaCmb_CxC_Credito.get_PlanCtaInfo().IdCtaCble;
                  cxc_Anticipo = ucCon_PlanCtaCmb_CxC_Anticipo.get_PlanCtaInfo().IdCtaCble;
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

                throw;
            }
        }
    }

    class cl_estado_grabacion
    {
        public decimal IdCliente { get; set; }
        public string Codigo { get; set; }
        public string Nombre_Cliente { get; set; }

        public int Secuencia { get; set; }
        public string Estado_grabado { get; set; }

        public cl_estado_grabacion()
        {
        }

        public cl_estado_grabacion(int _Secuencia, decimal _IdCliente, string _Nombre_Cliente, string _Codigo, string _Estado_grabado, string _Observacion)
        {
            IdCliente = _IdCliente;
            Nombre_Cliente = _Nombre_Cliente;
            Codigo = _Codigo;
            Estado_grabado = _Estado_grabado;
            Secuencia = _Secuencia;
        }
    }
}

