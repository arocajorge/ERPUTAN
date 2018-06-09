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
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_ImportacionWizard : Form
    {
        #region Variables Para Carga de Excel
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds;
        DataTable dt;
        #endregion

        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //BUS
        ro_HistoricoSueldo_Bus oRo_HistoricoSueldo_Bus = new ro_HistoricoSueldo_Bus();

        #region Delegados
        public delegate void delegate_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_ImportacionWizard_FormClosing event_frmRo_Empleado_ImportacionWizard_FormClosing;
        #endregion

        #region DATA
        ro_Empleado_Bus _EmpleadoBus = new ro_Empleado_Bus();
        ro_Empleado_Info _EmpleadoInfo = new ro_Empleado_Info();
        ro_Empleado_Info _EmpleadoInfoBase = new ro_Empleado_Info();
        List<ro_Empleado_Info> _ListEmpleadoInfo = new List<ro_Empleado_Info>();
        tb_persona_bus _PersonaBus = new tb_persona_bus();
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        List<tb_persona_Info> _ListPersonaInfo = new List<tb_persona_Info>();
        #endregion

        public frmRo_Empleado_ImportacionWizard()
        {
            InitializeComponent();
        }

        void frmRo_Empleado_ImportacionWizard_event_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        public bool PU_CARGAR_EXCEL_GRILLA()
        {
            try
            {
                ruta = txtSeleccion.Text;
                plantilla = cmbHoja.Text;
                this.gridControlconsultaEmp.DataSource = null;
                 _ListEmpleadoInfo.Clear();
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                        this.gridControlconsultaEmp.DataSource = _ListEmpleadoInfo;
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        public bool PU_CARGA_EXCEL()
        {
            try
            {
                if (CargarArchivoExcelADataTable())
                {
                    MensajeError = "";
                    _ListEmpleadoInfo = _EmpleadoBus.ProcesarDataTableRo_Empleado_Info(ds, param.IdEmpresa,param.IdSucursal, ref MensajeError);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        bool CargarArchivoExcelADataTable()
        {
            try
            {
                ds = new DataTable();
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); ds = new DataTable();
                return false;
            }
        }

        bool CargarHojasCombo()
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); 
                dt = new DataTable();
                return false;
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            { lblMsg1.Visible = true;
            PU_OBTENER_RUTA();
            if (!CargarHojasCombo())
                MessageBox.Show("Archivo de excel no valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            lblMsg1.Visible = false;

            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmRo_Empleado_ImportacionWizard_FormClosing(sender, e);
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Empleados);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); 
                
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Empleado_ImportacionWizard_Load(object sender, EventArgs e)
        {
            cmbHoja.SelectedIndex = 0;
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                 if (e.Page.Name == "wizardPage1")
            {
                //if (!PU_CARGAR_EXCEL_GRILLA())
                PU_CARGAR_EXCEL_GRILLA();
            }

            if (e.Page.Name == "wizardPage3")
            {
                string MensajeLog = "Ingreso Exitoso.";
                string MensajeWarning="";
                string listaLog="";
                this.rtbLog.Text = "";
                bool flagSinError = true;
                bool flagNuevoEmpleado = true;
                bool flagNuevaPersona = true;
                decimal idEmpleado = 0;
                decimal idPersona=0;
                string cedula = "";
                int IdEmpresa = param.IdEmpresa;

                if (this.gridControlconsultaEmp.DataSource != null)
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
                            if (!_EmpleadoBus.Eliminar_Empleados(IdEmpresa, ref MensajeError))
                            {
                                MensajeLog = "Error al eliminar registros en bases de datos \n" + MensajeError;
                                flagSinError = false;
                            }
                        }

                        if (flagSinError == true)//si es falso es porque entro al Eliminar y tuvo error, realmente no deberia hacer nada.
                        {
                            foreach (ro_Empleado_Info item in _ListEmpleadoInfo)
                            {
                                flagSinError = true;
                                cedula = item.pe_cedulaRuc;
                                _PersonaInfo = _PersonaBus.Get_Info_Persona(cedula);
                                if (_PersonaInfo.IdPersona != 0)
                                {
                                    idPersona = _PersonaInfo.IdPersona;
                                   // item.InfoPersona = _PersonaInfo;
                                    item.InfoPersona.IdPersona = idPersona;

                                    flagNuevaPersona = false;//ya esta la persona en la base de datos
                                }
                                else
                                {
                                    _PersonaInfo = item.InfoPersona;
                                    flagNuevaPersona = true;//es nueva persona
                                    if (!_PersonaBus.GrabarDB(_PersonaInfo, ref idPersona, ref MensajeError))
                                    {
                                        listaLog += "Ced: " + item.pe_cedulaRuc + "\t" + item.pe_NomCompleto + " -" + "\n";
                                        flagSinError = false;
                                    }
                                }
                                if (flagSinError == true)//si es false, porque  dio error en persona, para que intentar el empleado
                                {
                                    item.IdPersona = idPersona;
                                    item.InfoPersona.IdPersona = idPersona;
                                    if ((rgImportar.SelectedIndex == 0) || (flagNuevaPersona == true))
                                        flagNuevoEmpleado = true;
                                    else//si no elimino previamente todos los empleados, y la persona no es nueva busco el empledo
                                    {
                                        _EmpleadoInfoBase = _EmpleadoBus.Get_Info_Empleado_vs_Persona(IdEmpresa, idPersona);//busco el empleado por la persona
                                        if (_EmpleadoInfoBase.IdEmpleado == 0)
                                            flagNuevoEmpleado = true;//si no encontro empleado, entonces es nuevo
                                        else
                                        {
                                            item.IdEmpleado = _EmpleadoInfoBase.IdEmpleado;
                                            flagNuevoEmpleado = false;
                                        }
                                    }

                                    
                                    
                                    //AGREGAR RUBROS ACUMULADOS
                                    item.oListRo_empleado_x_rubro_acumulado_Info = new List<ro_empleado_x_rubro_acumulado_Info>();
                                    if(item.acumulaDecimoTercer=="S")
                                    {
                                        ro_empleado_x_rubro_acumulado_Info oRo_empleado_x_rubro_acumulado_Info = new ro_empleado_x_rubro_acumulado_Info();
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpleado= item.IdEmpleado;
                                        oRo_empleado_x_rubro_acumulado_Info.IdRubro = "290";
                                        item.oListRo_empleado_x_rubro_acumulado_Info.Add(oRo_empleado_x_rubro_acumulado_Info);                                       
                                    }

                                    if (item.acumulaDecimoCuarto == "S")
                                    {
                                        ro_empleado_x_rubro_acumulado_Info oRo_empleado_x_rubro_acumulado_Info = new ro_empleado_x_rubro_acumulado_Info();
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpleado = item.IdEmpleado;
                                        oRo_empleado_x_rubro_acumulado_Info.IdRubro = "289";
                                        item.oListRo_empleado_x_rubro_acumulado_Info.Add(oRo_empleado_x_rubro_acumulado_Info);
                                    }

                                    if (item.acumulaFondoReserva == "S")
                                    {
                                        ro_empleado_x_rubro_acumulado_Info oRo_empleado_x_rubro_acumulado_Info = new ro_empleado_x_rubro_acumulado_Info();
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_empleado_x_rubro_acumulado_Info.IdEmpleado = item.IdEmpleado;
                                        oRo_empleado_x_rubro_acumulado_Info.IdRubro = "296";
                                        item.oListRo_empleado_x_rubro_acumulado_Info.Add(oRo_empleado_x_rubro_acumulado_Info);
                                    }


                                    //AGREGAR NOMINA
                                    if (item.IdNomina_Tipo > 0)
                                    {
                                        ro_Empleado_TipoNomina_Info oRo_Empleado_TipoNomina_Info = new ro_Empleado_TipoNomina_Info();
                                        item.oListRo_Empleado_TipoNomina_Info = new List<ro_Empleado_TipoNomina_Info>();
                                        oRo_Empleado_TipoNomina_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_Empleado_TipoNomina_Info.IdEmpleado = item.IdEmpleado;
                                        oRo_Empleado_TipoNomina_Info.IdNomina_Tipo = item.IdNomina_Tipo;
                                        item.oListRo_Empleado_TipoNomina_Info.Add(oRo_Empleado_TipoNomina_Info);
                                    }

                                    //AGREGAR CENTRO DE COSTO  
                                    if (item.IdCentroCosto != "")
                                    {
                                        item.oListro_empleado_x_centro_costo_Info = new List<ro_empleado_x_centro_costo_Info>();
                                        ro_empleado_x_centro_costo_Info oRo_empleado_x_centro_costo_Info = new ro_empleado_x_centro_costo_Info();
                                        oRo_empleado_x_centro_costo_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_empleado_x_centro_costo_Info.IdEmpleado = item.IdEmpleado;
                                        oRo_empleado_x_centro_costo_Info.IdCentroCosto = item.IdCentroCosto;

                                        item.oListro_empleado_x_centro_costo_Info.Add(oRo_empleado_x_centro_costo_Info);
                                    }


                                    decimal idP=0;



                                    // sueldo actual

                                    //GRABAR NUEVO SUELDO
                                    ro_HistoricoSueldo_Info oRo_HistoricoSueldo_Info = new ro_HistoricoSueldo_Info();

                                    oRo_HistoricoSueldo_Info.IdEmpresa = item.IdEmpresa;
                                    oRo_HistoricoSueldo_Info.IdEmpleado = idEmpleado;
                                    oRo_HistoricoSueldo_Info.Secuencia = 1;
                                    oRo_HistoricoSueldo_Info.SueldoActual = item.em_Sueldo;
                                    oRo_HistoricoSueldo_Info.SueldoAnterior = 0;
                                    oRo_HistoricoSueldo_Info.PorIncrementoSueldo = 0;
                                    oRo_HistoricoSueldo_Info.ValorIncrementoSueldo = 0;
                                    oRo_HistoricoSueldo_Info.ca_descripcion = "-";
                                    oRo_HistoricoSueldo_Info.de_descripcion = "-";
                                    oRo_HistoricoSueldo_Info.Motivo = "Importación de Empleados mediante Plantilla";
                                    oRo_HistoricoSueldo_Info.Fecha = item.fechaInicioContrato;
                                    oRo_HistoricoSueldo_Info.idUsuario = param.IdUsuario;
                                    oRo_HistoricoSueldo_Info.Fecha_Transac = DateTime.Now;
                                    //BORRRA VALORES PREVIOS DEL HISTORIAL DE SUELDOS
                                   // oRo_HistoricoSueldo_Bus.EliminarBD(item.IdEmpresa, item.IdEmpleado, ref MensajeError);

                                    item.InfoSueldo = oRo_HistoricoSueldo_Info;


                                    if (!_EmpleadoBus.GrabarDB(item, ref idEmpleado, ref idP, ref MensajeError))
                                    {
                                        listaLog += "Ced: " + item.pe_cedulaRuc + "\t" + item.pe_NomCompleto + " _" + "\n";                                      
                                    }
                                    else
                                    {


                                        //GRABAR NUEVO CONTRATO
                                        ro_contrato_bus oRo_contrato_bus = new ro_contrato_bus();
                                        ro_contrato_Info oRo_contrato_Info = new ro_contrato_Info();

                                        oRo_contrato_Info.IdEmpresa = item.IdEmpresa;
                                        oRo_contrato_Info.IdEmpleado = idEmpleado;
                                        oRo_contrato_Info.IdContrato_Tipo = item.idTipoContrato;
                                        oRo_contrato_Info.NumDocumento = item.NoDocumentoContrato;
                                        oRo_contrato_Info.FechaInicio = item.fechaInicioContrato;
                                        oRo_contrato_Info.FechaFin = item.fechaFinContrato;
                                        oRo_contrato_Info.Observacion = "Importación de Empleados mediante Plantilla";
                                        oRo_contrato_Info.Estado = "A";
                                        oRo_contrato_Info.EstadoContrato = "ECT_ACT";

                                        oRo_contrato_bus.GrabarDB(oRo_contrato_Info, ref MensajeError);


                                   
 

 
                                       

                                    }


                                  }//fin sin error /en la Persona
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
            }//fin del wizardpage 3            
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void wizardPage3_Click(object sender, EventArgs e)
        {

        }//fin del void
    }
}

