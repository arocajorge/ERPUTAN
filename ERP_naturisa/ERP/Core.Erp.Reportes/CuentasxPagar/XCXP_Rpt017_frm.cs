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

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt017_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt017_frm()
        {
            InitializeComponent();
            ucCp_Menu_Reportes.event_btnRefrescar_ItemClick += ucCp_Menu_Reportes_event_btnRefrescar_ItemClick;
        }

        void ucCp_Menu_Reportes_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;
                string nom_Proveedor = "";
                if (this.ucCp_Menu_Reportes.get_cmbProveedor() == 0)
                {
                    IdProveedorIni = 1;
                    IdProveedorFin = 99999999;
                    nom_Proveedor = "TODOS";
                }
                else
                {
                    IdProveedorIni = Convert.ToInt32(ucCp_Menu_Reportes.get_cmbProveedor());
                    IdProveedorFin = IdProveedorIni;
                    nom_Proveedor = ucCp_Menu_Reportes.get_cmbNomProveedor();
                }

                XCXP_Rpt017_rpt Reporte = new XCXP_Rpt017_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdProveedorIni"].Value = IdProveedorIni;
                Reporte.Parameters["IdProveedorFin"].Value = IdProveedorFin;
                Reporte.Parameters["FechaCorte"].Value = ucCp_Menu_Reportes.get_FchFin();
           
                Reporte.Parameters["S_Proveedor"].Value = nom_Proveedor;
                Reporte.Parameters["S_FechaCorte"].Value = ucCp_Menu_Reportes.get_FchFin(); 

             
                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
