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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Facturacion_CAH
{
    public partial class frmFa_Saldo_inicial_ImportWizard : Form
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #region DATA
        List<fa_notaCreDeb_Info> lst_ND = new List<fa_notaCreDeb_Info>();
        fa_notaCredDeb_Bus bus_ND = new fa_notaCredDeb_Bus();
        DateTime Fecha_contabilizacion = DateTime.Now;
        ct_Periodo_Info info_periodo = new ct_Periodo_Info();
        ct_Periodo_Bus bus_periodo = new ct_Periodo_Bus();
        fa_parametro_Bus bus_parametro = new fa_parametro_Bus();
        fa_parametro_info info_parametro = new fa_parametro_info();
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

        #region

        public delegate void delegate_frm_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frm_FormClosing event_delegate_frm_FormClosing;

        #endregion

        public frmFa_Saldo_inicial_ImportWizard()
        {
            InitializeComponent();
            event_delegate_frm_FormClosing += frmFa_Saldo_inicial_ImportWizard_event_delegate_frm_FormClosing;
        }

        void frmFa_Saldo_inicial_ImportWizard_event_delegate_frm_FormClosing(object sender, FormClosingEventArgs e)
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Proceso_Grabacion()
        {


            try
            {

                BindingList<cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante> ListEstadoGrabacion = new BindingList<cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante>();



                int c = 1;
                int Total_Reg = 0;

                info_parametro = bus_parametro.Get_Info_parametro(param.IdEmpresa);
                string MensajeLog = "Ingreso Exitoso.";
                this.rtbLog.Text = "";
                lblMensaje.Text = "";
                lblMensaje.Visible = false;
                gridControl_estado_grab_x_proveedor.DataSource = ListEstadoGrabacion;
                Total_Reg = lst_ND.Count();
                progressBar.Maximum = Total_Reg;
                progressBar.Minimum = 1;
                progressBar.Step = 1;
                lblNumRegistros.Text = "0 registros de " + Total_Reg;

                if (this.gridControlND_Saldo_inicial.DataSource != null)
                {
                    int secuencia = 1;
                    foreach (var item in lst_ND)
                    {
                        item.fecha_Ctble = Fecha_contabilizacion;
                        item.info_CbteCble = Armar_diario(item);

                        if (bus_ND.GuardarDB_ND_x_Saldo_inicial(item, ref MensajeError))
                        {

                            // falta
                            ListEstadoGrabacion.Add(new cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante
                                ( secuencia,"","","",0,"","",item.CodNota, Convert.ToDateTime(item.no_fecha), Convert.ToDateTime(item.no_fecha_venc),
                                Convert.ToDateTime(item.fecha_Ctble), Convert.ToDouble(item.Total)));



                            gridControl_estado_grab_x_proveedor.Refresh();
                            progressBar.Value = secuencia;
                            lblNumRegistros.Text = secuencia + " registros de " + Total_Reg;
                            progressBar.Refresh();
                            Application.DoEvents();
                            secuencia++;

                        }
                    }
                    lblmsg3.Visible = false;
                }
                else
                {
                    MensajeLog = "No existen Datos para importación.";
                }
                this.rtbLog.Text = MensajeLog;
            }
            catch (Exception ex)
            {
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
                this.gridControlND_Saldo_inicial.DataSource = null;
                if (ruta != "")
                {
                    if (PU_CARGA_EXCEL())
                    {
                        MensajeError = "";
                        lst_ND = bus_ND.ProcesarDataTable_ND_x_Saldo_inicial_x_Alumno_CAH(ds, ref MensajeError);
                        if (MensajeError!="")
                        {
                            MessageBox.Show(MensajeError, "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop); return false;
                        }
                        this.gridControlND_Saldo_inicial.DataSource = lst_ND;

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
                    lst_ND = bus_ND.ProcesarDataTable_ND_x_Saldo_inicial(ds, ref MensajeError);
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
                    cb.Provider = "Microsoft.ACE.OLEDB.12.0";
                    cb.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");
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
                File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_Ejemplo_CXC_ND_Saldo_inicial_x_Estudiante_CAH);
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

        private ct_Cbtecble_Info Armar_diario(fa_notaCreDeb_Info info_ND)
        {
            try
            {
                ct_Cbtecble_Info info_diario = new ct_Cbtecble_Info();
                #region Cabecera
                info_diario.IdEmpresa = param.IdEmpresa;
                info_diario.cb_Fecha = Fecha_contabilizacion;
                info_diario.cb_Observacion = info_ND.sc_observacion;
                info_diario.cb_Valor = Math.Round(Convert.ToDouble(info_ND.Total), 2, MidpointRounding.AwayFromZero);
                info_diario.IdTipoCbte = info_parametro.IdTipoCbteCble_ND;
                info_diario.IdUsuario = "SysAdmin";
                info_diario.cb_FechaTransac = param.Fecha_Transac;
                info_diario.Estado = "A";
                info_diario.IdPeriodo = info_periodo.IdPeriodo;
                info_diario.Mayorizado = "N";

                #endregion

                #region Detalle
                ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                debe.IdEmpresa = param.IdEmpresa;
                debe.IdTipoCbte = info_diario.IdTipoCbte;
                debe.IdCtaCble = info_ND.info_cliente.IdCtaCble_cxc;
                debe.dc_Valor = Math.Round(Convert.ToDouble(info_ND.Total), 2, MidpointRounding.AwayFromZero);
                debe.dc_Observacion = info_ND.sc_observacion;
                info_diario._cbteCble_det_lista_info.Add(debe);

                ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                haber.IdEmpresa = param.IdEmpresa;
                haber.IdTipoCbte = info_diario.IdTipoCbte;
                haber.IdCtaCble = info_ND.info_cliente.IdCtaCble_cxc;
                haber.dc_Valor = Math.Round(Convert.ToDouble(info_ND.Total), 2, MidpointRounding.AwayFromZero)*-1;
                haber.dc_Observacion = info_ND.sc_observacion;
                info_diario._cbteCble_det_lista_info.Add(haber);

                #endregion
                return info_diario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void frmcxc_Saldo_inicial_ImportWizard_Load(object sender, EventArgs e)
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
                Fecha_contabilizacion = Convert.ToDateTime(de_fecha_contabilizacion.EditValue).Date;
                info_periodo = bus_periodo.Get_Info_Periodo(param.IdEmpresa, Fecha_contabilizacion, ref MensajeError);
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

        private void frmFa_Saldo_inicial_ImportWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_frm_FormClosing(sender, e);
        }

        private void gridControlND_Saldo_inicial_Click(object sender, EventArgs e)
        {

        }
    }

    class cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante
    {

        public string Cod_Estudiante { get; set; }
        public string ced_estudiante { get; set; }
        public string ced_repres_eco { get; set; }
        public string nom_estudiante { get; set; }
        public string nom_rep_econo { get; set; }
        public string num_Fact { get; set; }

        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        
        public DateTime Fecha { get; set; }
        public DateTime Fecha_vcto { get; set; }
        public DateTime Fecha_contabilizacion { get; set; }
        public double Saldo { get; set; }
        public decimal Secuencia { get; set; }


        public cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante(decimal Secuencia_, string Cod_Estudiante_, string ced_estudiante_, string ced_repres_eco_, 
          int IdTipoCbte_,  string nom_estudiante_,string nom_rep_econo_, string num_Fact_, DateTime Fecha_, DateTime Fecha_vcto_, DateTime Fecha_contabilizacion_, double Saldo_)
        {
            Secuencia = Secuencia_;
            Cod_Estudiante = Cod_Estudiante;
            ced_estudiante = ced_estudiante_;
            ced_repres_eco = ced_repres_eco_;
            nom_estudiante = nom_estudiante_;
            nom_rep_econo = nom_rep_econo_;
            num_Fact = num_Fact_;
            Fecha = Fecha_;
            Fecha_vcto = Fecha_vcto_;
            Fecha_contabilizacion = Fecha_contabilizacion_;
            Saldo = Saldo_;
            IdTipoCbte=IdTipoCbte_;

        }

        public cl_estado_grabacion_Saldo_inicial_ND_x_Estudiante()
        {

        }



    }
}
