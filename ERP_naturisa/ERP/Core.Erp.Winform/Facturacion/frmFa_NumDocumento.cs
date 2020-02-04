using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_NumDocumento : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmFa_NumDocumento()
        {
            try
            {
                   InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }
        public frmFa_NumDocumento( String TipoDoc,int IdEmpresa, int IdSucursal,int IdBodega) :this()
        {
            try
            {
                //ucfA_NumeroDocTrans.Obtener_Ult_Documento_no_usado(IdEmpresa, IdSucursal, IdBodega, TipoDoc);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NunAutorizacion { get; set; }
        public string NumDocument { get; set; }
        public Boolean Bole { get; set; }
        private void frmFa_NumDocumento_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bole = true;
                //modificar esto  
                //Serie1 = ucfA_NumeroDocTrans.txtSerie1.Text;
                //Serie2 = ucfA_NumeroDocTrans.txtSerie2.Text;
                //NunAutorizacion = ucfA_NumeroDocTrans.Autorizacion;
                NumDocument = ucfA_NumeroDocTrans.txtNumDoc.Text;                
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
              Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
