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
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Bancos
{



    public partial class FrmBA_ConciliacionBancaria_Auto_x_Excel : Form
    {

        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds;
        DataTable dt;


        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;



        public delegate void delegate_frmRo_Empleado_ImportacionWizard_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_ImportacionWizard_FormClosing event_frmRo_Empleado_ImportacionWizard_FormClosing;

        ba_Transacciones_x_excel_a_conciliar_Bus BusTrans = new ba_Transacciones_x_excel_a_conciliar_Bus();

        public FrmBA_ConciliacionBancaria_Auto_x_Excel()
        {
            InitializeComponent();
        }



        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {

                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.EstadoCta_Banco_Gye_Demo);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {


            }

        }

        private void txtruta_EditValueChanged(object sender, EventArgs e)
        {

        }

        void Optener_Ruta()
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
                    txtruta.Text = ruta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtruta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                lblMsg1.Visible = true;
                Optener_Ruta();
                if (!Cargar_Hojas_excel_en_Combo())
                    MessageBox.Show("Archivo de excel no valido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lblMsg1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        bool Cargar_Hojas_excel_en_Combo()
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
                Log_Error_bus.Log_Error(ex.ToString());
                dt = new DataTable();
                return false;
            }
        }

        private void wizardControlConciliacion_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {

            if (e.Page == WizardPage_Paso1_select_excel)
            {
                Cargar_excel_en_grilla();
            }

        }





        public bool Cargar_excel_en_grilla()
        {
            try
            {
                ruta = txtruta.Text;
                plantilla = cmbHoja.Text;
                this.gridControlExcel_a_comparar.DataSource = null;

                List<ba_Transacciones_x_excel_a_conciliar_Info> listaData_a_Conciliar = new List<ba_Transacciones_x_excel_a_conciliar_Info>();


                if (ruta != "")
                {
                    if (Leer_excel(ref listaData_a_Conciliar))
                    {
                        this.gridControlExcel_a_comparar.DataSource = listaData_a_Conciliar;
                        return true;
                    }
                    else
                    { MessageBox.Show("Archivo no cumple formato de plantilla. " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }
                }
                else
                { MessageBox.Show("Por favor seleccione archivo de plantilla válida.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Stop); return false; }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }




        public bool Leer_excel(ref List<ba_Transacciones_x_excel_a_conciliar_Info> lista)
        {
            try
            {
                if (CargarArchivoExcelADataTable())
                {
                    MensajeError = "";
                    lista = BusTrans.ProcesarDataTable_a_Info(ds, param.IdEmpresa, ref MensajeError);
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
                return false;
            }
        }

        bool CargarArchivoExcelADataTable()
        {
            try
            {
                ds = new DataTable();
                ds.Clear();
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
                Log_Error_bus.Log_Error(ex.ToString());
                ds = new DataTable();
                return false;
            }
        }

        private void FrmBA_ConciliacionBancaria_Auto_x_Excel_Load(object sender, EventArgs e)
        {

        }

        private void wizardPage2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
