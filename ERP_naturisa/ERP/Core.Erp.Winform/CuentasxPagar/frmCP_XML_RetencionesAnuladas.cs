using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_XML_RetencionesAnuladas : Form
    {
        #region Variables
        cp_XML_DocumentoRetAnulado_Bus busDocumento;
        public int IdEmpresa { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        #endregion


        public frmCP_XML_RetencionesAnuladas()
        {
            InitializeComponent();
            busDocumento = new cp_XML_DocumentoRetAnulado_Bus();

        }

        private void frmCP_XML_RetencionesAnuladas_Load(object sender, EventArgs e)
        {
            gcDetalle.DataSource = busDocumento.GetList(IdEmpresa, FechaIni, FechaFin);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }
    }
}
