using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using GenericParsing;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_XML_ValidacionMasiva : Form
    {
        #region Variables
        string fileName = "";
        string path = "";
        string tipofile = "";
        string ruta = "";
        string plantilla = "Plantilla";
        DataTable ds = new DataTable();
        DataTable dt = new DataTable();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cp_XML_Documento_Info> ListaXml = new List<cp_XML_Documento_Info>();
        cp_XML_Documento_Bus busXml = new cp_XML_Documento_Bus();
        string MensajeError = string.Empty;
        #endregion

        public frmCP_XML_ValidacionMasiva()
        {
            InitializeComponent();
        }

        private void txtRutaXml_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                    txtRutaXml.Text = ruta;
                    Opcion2();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                MessageBox.Show("Ha ocurrido un error",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRutaXml.Text))
                {
                    Opcion2();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                MessageBox.Show("Ha ocurrido un error", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Opcion2()
        {
            try
            {
                ListaXml = new List<cp_XML_Documento_Info>();
                using (GenericParser parser = new GenericParser())
                {
                    parser.SetDataSource(txtRutaXml.Text);

                    parser.ColumnDelimiter = '\t';
                    parser.FirstRowHasHeader = false;
                    parser.SkipStartingDataRows = 2;
                    parser.MaxBufferSize = 4096;
                    parser.MaxRows = 500;
                    parser.TextQualifier = '\"';
                    int Fila = 0;
                    cp_XML_Documento_Info info = new cp_XML_Documento_Info();
                    while (parser.Read())
                    {
                        if ((Fila % 2) == 0)
                        {
                            info = new cp_XML_Documento_Info
                            {
                                Tipo = parser[0].ToString().ToUpper(),
                                CodDocumento = (parser[0].ToString().ToUpper() == "FACTURA" ? "01" : parser[0].ToString().ToUpper()),
                                Comprobante = (parser[0].ToString().ToUpper() == "FACTURA" ? "01-" : (parser[0].ToString().ToUpper()+"-")) + parser[1].ToString(),
                                emi_Ruc = parser[2].ToString(),
                                emi_RazonSocial = parser[3].ToString(),
                                FechaEmision = Convert.ToDateTime(parser[4].ToString()),
                                ClaveAcceso = parser[8].ToString()
                            };
                            var Doc = busXml.GetInfo(param.IdEmpresa,info.CodDocumento,info.Comprobante,info.emi_Ruc);
                            if (Doc != null)
	                        {
		                        info.ValidacionD = Doc.ValidacionD;
                                info.ValidacionR = Doc.ValidacionR;
                                info.IdDocumento = Doc.IdDocumento;
                                info.ValidacionC = Doc.ValidacionC;
	                        }
                            Fila++;
                        }
                        else
                        {
                            info.Total = parser[0] == null ? 0 : Convert.ToDouble(parser[0]);
                            ListaXml.Add(info);
                            Fila++;
                        }
                    }
                }
                gcDetalle.DataSource = ListaXml;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                MessageBox.Show("Ha ocurrido un error", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
