using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_XML_DocumentosNoContabilizados : Form
    {
        #region Variables
        cp_XML_Documento_Bus busXML;
        public cp_XML_Documento_Info infoXML { get; set; }
        public string pe_cedulaRuc { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public frmCP_XML_DocumentosNoContabilizados()
        {
            InitializeComponent();
            busXML = new cp_XML_Documento_Bus();
        }

        private void gvDetalle_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                cp_XML_Documento_Info row = (cp_XML_Documento_Info)gvDetalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (!string.IsNullOrEmpty(row.ret_NumeroDocumento))
                    e.Appearance.ForeColor = Color.Blue;

                if (!row.Estado)
                    e.Appearance.ForeColor = Color.Red;

                if (!string.IsNullOrEmpty(row.ret_NumeroAutorizacion))
                    e.Appearance.ForeColor = Color.Green;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                infoXML = (cp_XML_Documento_Info)gvDetalle.GetFocusedRow();
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void frmCP_XML_DocumentosNoContabilizados_Load(object sender, EventArgs e)
        {
            gcDetalle.DataSource = null;
            gcDetalle.DataSource = busXML.GetList(param.IdEmpresa, pe_cedulaRuc);
            infoXML = null;
        }

        private void frmCP_XML_DocumentosNoContabilizados_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
