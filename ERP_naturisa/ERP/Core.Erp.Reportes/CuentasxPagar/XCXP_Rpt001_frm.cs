using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Core.Erp.Reportes.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt001_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<cp_proveedor_Info> ListproveedorInfo = new List<cp_proveedor_Info>();

        public XCXP_Rpt001_frm()
        {
            InitializeComponent();

            cmb_estado_Pago.SelectedIndex = 0;
        }

        private void XCXP_Rpt001_frm_Load(object sender, EventArgs e)
        {
            cargarCombo();
            dtp_desde.Value = new DateTime(2015, 01, 01);
            rdb_con_Pagos.Checked = true;
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

                cmbProveedor.Properties.DataSource = ListproveedorInfo;  
   
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {

                XCXP_Rpt001_Rpt Reporte = new XCXP_Rpt001_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;


                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;                
                Reporte.Parameters["IdProveedor"].Value = (cmbProveedor.EditValue == null) ? 0 : cmbProveedor.EditValue;
               // Reporte.Parameters["IdProveedorFin"].Value = (cmbProveedor.EditValue == null || Convert.ToDecimal(cmbProveedor.EditValue) == 0) ? 999999 : cmbProveedor.EditValue;
                Reporte.Parameters["co_fechaOg_Ini"].Value = dtp_desde.Value;
                Reporte.Parameters["co_fechaOg_Fin"].Value = dtp_hasta.Value;

            
                if (rdb_con_Pagos.Checked == true)
                {
                    Reporte.Parameters["P_Muestra_Pagos"].Value = "SI";
                }
                else
                {
                    Reporte.Parameters["P_Muestra_Pagos"].Value = "NO";
                }

               // if (cmb_estado_Pago.SelectedItem==null)
               //{
               //    cmb_estado_Pago.SelectedIndex= 0;
               //}
                
                Reporte.Parameters["P_Estado_Pago"].Value =cmb_estado_Pago.SelectedItem;
                
                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rdb_con_Pagos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdb_con_Pagos.Checked == true)
                {
                    rdb_sin_Pagos.Checked = false;

                }
                else
                {
                    rdb_sin_Pagos.Checked = true;
                
                }

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
