using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt011_frm : Form
    {
        List<cp_proveedor_Info> ListproveedorInfo = new List<cp_proveedor_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt011_frm()
        {
            InitializeComponent();
        }

        public void cargarCombo()
        {
            try
            {
                cp_proveedor_Bus proveedorBus = new cp_proveedor_Bus();
                ListproveedorInfo = proveedorBus.Get_List_proveedor(param.IdEmpresa);

                cp_proveedor_Info InfoTodos = new cp_proveedor_Info();
                InfoTodos.IdEmpresa = param.IdEmpresa;
                InfoTodos.IdProveedor = 0;
                InfoTodos.pr_nombre2 = "Todos";
                InfoTodos.pr_nombre = "Todos";
                ListproveedorInfo.Add(InfoTodos);

                
                cmb_Proveedor.Properties.DataSource = ListproveedorInfo;
                cmb_Proveedor.Properties.DisplayMember = "pr_nombre";
                cmb_Proveedor.Properties.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXP_Rpt011_frm_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {

                XCXP_Rpt011_rpt Reporte = new XCXP_Rpt011_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdProveedorIni"].Value = (cmb_Proveedor.EditValue == null) ? 1 : cmb_Proveedor.EditValue;
                Reporte.Parameters["IdProveedorFin"].Value = (cmb_Proveedor.EditValue == null || Convert.ToDecimal(cmb_Proveedor.EditValue) == 0) ? 999999 : cmb_Proveedor.EditValue;
                Reporte.Parameters["FechaIni"].Value = dtp_FechaIni.Value;
                Reporte.Parameters["FechaFin"].Value = dtp_FechaFin.Value;

                Reporte.Parameters["S_Empresa"].Value = param.InfoEmpresa.em_nombre;
                Reporte.Parameters["S_Proveedor"].Value = cmb_Proveedor.EditValue == null ? "TODOS" : cmb_Proveedor.Text;

               // Reporte.Parameters["S_Proveedor"].Value = cmb_Proveedor.Text;
                Reporte.Parameters["S_FechaIni"].Value = dtp_FechaIni.Text;
                Reporte.Parameters["S_FechaFin"].Value = dtp_FechaFin.Text;


                Reporte.Parameters["S_ced_proveedor"].Value = cmb_Proveedor.EditValue == null ? "" : ced_proveedor;
                Reporte.Parameters["S_dir_proveedor"].Value = cmb_Proveedor.EditValue == null ? "" : dir_proveedor;
               

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        string ced_proveedor = "";
        string dir_proveedor = "";
        private void cmb_Proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cp_proveedor_Info infoProve = (cp_proveedor_Info)cmb_Proveedor.Properties.View.GetFocusedRow();

                ced_proveedor = infoProve.Persona_Info.pe_cedulaRuc;
                dir_proveedor = infoProve.Persona_Info.pe_direccion;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
