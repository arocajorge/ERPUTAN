using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;



namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt002_frm : Form
        {
         //Bus       

        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Listas
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        
    
        public XCOMP_NATU_Rpt002_frm()
        {
            InitializeComponent();
                   
        }
        void cargar_combos()
        {
            try
            {
                listSucursal = buSucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_Sucursal.Properties.DataSource = listSucursal;
                cmb_Sucursal.Properties.DisplayMember = "Su_Descripcion";
                cmb_Sucursal.Properties.ValueMember = "IdSucursal";

                listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);


                cp_proveedor_Info InfoTodos = new cp_proveedor_Info();
                InfoTodos.IdEmpresa = param.IdEmpresa;
                InfoTodos.IdProveedor = 0;
                InfoTodos.pr_nombre2 = "Todos";
                InfoTodos.pr_nombre = "Todos";
                listProveedor.Add(InfoTodos);

                cmb_Proveedor.Properties.DataSource = listProveedor;
                cmb_Proveedor.Properties.DisplayMember = "pr_nombre";
                cmb_Proveedor.Properties.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCOMP_NATU_Rpt002_frm_Load(object sender, EventArgs e)
        {
            try
            {
                
                cargar_combos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
         private void btnCargarReporte_Click_1(object sender, EventArgs e)
         {
             try
             {
                 decimal IdProveedorIni = 0;
                 decimal IdProveedorFin = 0;

                 IdProveedorIni = Convert.ToDecimal(cmb_Proveedor.EditValue);
                 IdProveedorFin = Convert.ToDecimal(cmb_Proveedor.EditValue);

                 XCOMP_NATU_Rpt002_Rpt Reporte = new XCOMP_NATU_Rpt002_Rpt();

                 Reporte.RequestParameters = false;
                 ReportPrintTool pt = new ReportPrintTool(Reporte);

                 pt.AutoShowParametersPanel = false;


                 Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                 Reporte.Parameters["IdSucursal"].Value = cmb_Sucursal.EditValue;
                 Reporte.Parameters["IdProveedorIni"].Value = IdProveedorIni;
                 Reporte.Parameters["IdProveedorFin"].Value = IdProveedorFin;
                 Reporte.Parameters["Fecha_OC_Ini"].Value = dtpFecha_Desde.Value;
                 Reporte.Parameters["Fecha_OC_Fin"].Value = dtpFecha_Hasta.Value;


                 Reporte.Parameters["S_empresa"].Value = param.NombreEmpresa;
                 Reporte.Parameters["S_sucursal"].Value = cmb_Sucursal.Text;
                 Reporte.Parameters["S_proveedor"].Value = cmb_Proveedor.Text;
                 Reporte.Parameters["S_fechadesde"].Value = dtpFecha_Desde.Text;
                 Reporte.Parameters["S_fechahasta"].Value = dtpFecha_Hasta.Text;


                 printControl1.PrintingSystem = Reporte.PrintingSystem;
                 Reporte.CreateDocument();
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
