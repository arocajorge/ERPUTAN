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

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt011_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public XCXC_Rpt011_frm()
        {
            InitializeComponent();
            uccxC_Menu.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;
            uccxC_Menu.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
        }

        void uccxC_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void uccxC_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos()
        {
            try
            {
                XCXC_Rpt011_rpt Reporte = new XCXC_Rpt011_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                int IdSucursal = 0;
                decimal IdCliente = 0;
                string nom_Cliente = "";
                string nom_Sucursal = "";
                string nom_Tipo_cliente = "";
                DateTime fecha_corte = DateTime.Now;
                int IdtipoCliente = 0;
                
                IdSucursal = uccxC_Menu.beiSucursal.EditValue==null ? 0 : Convert.ToInt32(uccxC_Menu.beiSucursal.EditValue);
                IdCliente = (uccxC_Menu.beiCliente.EditValue == null) ? 0 : Convert.ToDecimal(uccxC_Menu.beiCliente.EditValue);
                nom_Sucursal = uccxC_Menu.beiSucursal.EditValue==null ? "Todas" : uccxC_Menu.beiSucursal.Edit.GetDisplayText(uccxC_Menu.beiSucursal.EditValue);
                nom_Tipo_cliente = uccxC_Menu.beiTipoCliente.EditValue == null ? "Todos" : uccxC_Menu.beiTipoCliente.Edit.GetDisplayText(uccxC_Menu.beiTipoCliente.EditValue);
                nom_Cliente = uccxC_Menu.beiCliente.EditValue==null ? "Todos" : uccxC_Menu.beiCliente.Edit.GetDisplayText(uccxC_Menu.beiCliente.EditValue);
                fecha_corte = uccxC_Menu.dtpHasta.EditValue==null ? DateTime.Now : Convert.ToDateTime(uccxC_Menu.dtpHasta.EditValue); 
                IdtipoCliente = uccxC_Menu.beiTipoCliente.EditValue==null ? 0 : Convert.ToInt32(uccxC_Menu.beiTipoCliente.EditValue);

                Reporte.Set_parameters(IdSucursal, nom_Sucursal, IdCliente, nom_Cliente, IdtipoCliente, nom_Tipo_cliente, fecha_corte);

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt011_frm_Load(object sender, EventArgs e)
        {
            try
            {
                uccxC_Menu.dtpHasta.EditValue = DateTime.Now;
                uccxC_Menu.dtpHasta.Caption = "Fecha Corte:";

                uccxC_Menu.beiCliente.EditValue = null;
                uccxC_Menu.beiSucursal.EditValue = null;
                uccxC_Menu.beiTipoCliente.EditValue = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
