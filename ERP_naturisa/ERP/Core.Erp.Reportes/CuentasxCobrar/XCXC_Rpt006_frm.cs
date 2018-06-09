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
using Core.Erp.Info.CuentasxCobrar;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt006_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        List<string> List_TipoCobro = new List<string>();
        
        public XCXC_Rpt006_frm()
        {
            InitializeComponent();
            uccxC_Menu.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;            
            uccxC_Menu.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
            uccxC_Menu.chkTipoCobro.EditValueChanged += chkTipoCobro_EditValueChanged;
        }

        void chkTipoCobro_EditValueChanged(object sender, EventArgs e)
        {
            //Lista_Tipo_Cobro= new List<cxc_cobro_tipo_Info>(uccxC_Menu.chkTipoCobro.GetCheckedItems(
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
                XCXC_Rpt006_rpt reporte = new XCXC_Rpt006_rpt();

                reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(reporte);


                pt.AutoShowParametersPanel = false;

                List_TipoCobro = uccxC_Menu.Get_list_cobros_chequeados();

                reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                reporte.Parameters["IdSucursalIni"].Value = (uccxC_Menu.beiSucursal.EditValue == null) ? 0 : uccxC_Menu.beiSucursal.EditValue;
                reporte.Parameters["IdSucursalFin"].Value = (uccxC_Menu.beiSucursal.EditValue == null || Convert.ToInt32(uccxC_Menu.beiSucursal.EditValue) == 0) ? 999999 : uccxC_Menu.beiSucursal.EditValue;
                reporte.Parameters["IdClienteIni"].Value = (uccxC_Menu.beiCliente.EditValue == null) ? 0 : uccxC_Menu.beiCliente.EditValue;
                reporte.Parameters["IdClienteFin"].Value = (uccxC_Menu.beiCliente.EditValue == null || Convert.ToInt32(uccxC_Menu.beiCliente.EditValue) == 0) ? 999999 : uccxC_Menu.beiCliente.EditValue;
                reporte.Parameters["FechaIni"].Value = uccxC_Menu.dtpDesde.EditValue;
                reporte.Parameters["FechaFin"].Value = uccxC_Menu.dtpHasta.EditValue;
                reporte.Parameters["TipoFecha"].Value = uccxC_Menu.beiOpciones.EditValue;
                reporte.Parameters["IdUsuario"].Value = param.IdUsuario;
                reporte.Parameters["nomCliente"].Value = uccxC_Menu.beiCliente.Edit.GetDisplayText(uccxC_Menu.beiCliente.EditValue);
                reporte.Parameters["nomSucursal"].Value = uccxC_Menu.beiSucursal.Edit.GetDisplayText(uccxC_Menu.beiSucursal.EditValue);
                reporte.set_lista_cobros(List_TipoCobro);
                printControlReporte.PrintingSystem = reporte.PrintingSystem;
                reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
