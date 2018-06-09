using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt009_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance; 

        public XCXC_Rpt009_frm()
        {
            InitializeComponent();
            uccxC_MenuReportes.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;
            uccxC_MenuReportes.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
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
                XCXC_Rpt009_rpt Reporte = new XCXC_Rpt009_rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.IdEmpresa.Value = param.IdEmpresa;
                Reporte.IdUsuario.Value = param.IdUsuario;
                Reporte.PIdCliente.Value = Convert.ToInt32(uccxC_MenuReportes.beiCliente.EditValue);
                Reporte.IdSucursalIni.Value = (uccxC_MenuReportes.beiSucursal.EditValue == null) ? 0 : uccxC_MenuReportes.beiSucursal.EditValue;
                Reporte.IdSucursalFin.Value = (uccxC_MenuReportes.beiSucursal.EditValue == null || Convert.ToInt32(uccxC_MenuReportes.beiSucursal.EditValue) == 0) ? 999999 : uccxC_MenuReportes.beiSucursal.EditValue;
                Reporte.FechaCorte.Value = uccxC_MenuReportes.dtpHasta.EditValue;
                Reporte.nomSucursal.Value = uccxC_MenuReportes.beiSucursal.Edit.GetDisplayText(uccxC_MenuReportes.beiSucursal.EditValue);

                Reporte.PIdTipo_Cliente.Value = cmb_tipo_Cliente.EditValue; 

                

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXC_Rpt009_frm_Load(object sender, EventArgs e)
        {
            try
            {
                

                fa_cliente_tipo_Bus BusCliente = new fa_cliente_tipo_Bus();
                List<fa_cliente_tipo_Info> ListInfoCliente = new List<fa_cliente_tipo_Info>();


                ListInfoCliente  = BusCliente.Get_List_fa_cliente_tipo(param.IdEmpresa);
                ListInfoCliente.Add(new fa_cliente_tipo_Info(param.IdEmpresa, 0, "0", "TODOS", "A"));

                cmb_tipo_Cliente.Properties.DataSource = ListInfoCliente;
                cmb_tipo_Cliente.EditValue = 1 ;

                

                uccxC_MenuReportes.dtpDesde.EditValue = DateTime.Now;
                uccxC_MenuReportes.dtpDesde.Caption = "Fecha Corte:";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
