using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using DevExpress.XtraReports.UI;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public partial class XPRO_CUS_CID_Rpt012_frm : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_Obra_Info InfoOBra = new prd_Obra_Info();
        string CodObra = "";



        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public XPRO_CUS_CID_Rpt012_frm()
        {
            InitializeComponent();
        }


        void CargarGrid()
        {
            try
            {
                XPRO_CUS_CID_Rpt012_Rpt Reporte = new XPRO_CUS_CID_Rpt012_Rpt();
                Reporte.RequestParameters = false;
                //Reporte.Parameters["pIdSede"].Value = cmb_Sede.EditValue;
                Reporte.Parameters["pCodigoObra"].Value = InfoOBra.CodObra;
                Reporte.Parameters["pObra"].Value = InfoOBra.Descripcion + " (" + InfoOBra.CodObra + ")";

                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                //Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                //Reporte.Parameters["IdUsuario"].Value = 1;

                printControl1.PrintingSystem = Reporte.PrintingSystem;

                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR en REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void XPRO_CUS_CID_Rpt012_frm_Load(object sender, EventArgs e)
        {
            cargaCmb_Obra();
        }
        public void cargaCmb_Obra()
        {
            try
            {
                cmbObra.Properties.DataSource = BusOBra.ObtenerListaObra(param.IdEmpresa);

                cmbObra.Properties.DisplayMember = "DetalleObra";
                cmbObra.Properties.ValueMember = "CodObra";


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }


        public prd_Obra_Info get_obra_info()
        {
            try
            {
                if (cmbObra.EditValue != null)
                {
                    InfoOBra = (prd_Obra_Info)cmbObra.Properties.View.GetFocusedRow();
                }
                else
                {
                    return new prd_Obra_Info();
                }

                return InfoOBra;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new prd_Obra_Info();
            }
        }

        private void cmbObra_EditValueChanged(object sender, EventArgs e)
        {
            get_obra_info();
        }
    }
}
