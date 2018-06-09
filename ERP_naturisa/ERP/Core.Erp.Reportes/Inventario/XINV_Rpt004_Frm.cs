using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt004_frm : Form
    {
        //Bus
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //Listas
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        List<in_Producto_Info> ListProducto = new List<in_Producto_Info>();



        public XINV_Rpt004_frm()
        {
          InitializeComponent();
          
        }

        void ucInv_Menu_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucInv_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void cargarGrid()
        {
            try
            {       
                XINV_Rpt004_Rpt Reporte = new XINV_Rpt004_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;                

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursal_inv_Ini"].Value = (ucInv_Menu.cmbSucursal.EditValue == null) ? 0 : ucInv_Menu.cmbSucursal.EditValue;
                Reporte.Parameters["IdSucursal_inv_Fin"].Value = (ucInv_Menu.cmbSucursal.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["Fecha_oc_Ini"].Value = ucInv_Menu.dtpDesde.EditValue;
                Reporte.Parameters["Fecha_oc_Fin"].Value = ucInv_Menu.dtpHasta.EditValue;
                Reporte.Parameters["IdProveedorIni"].Value = (ucInv_Menu.cmbProveedor.EditValue == null) ? 0 : ucInv_Menu.cmbProveedor.EditValue;
                Reporte.Parameters["IdProveedorFin"].Value = (ucInv_Menu.cmbProveedor.EditValue == null || Convert.ToDecimal(ucInv_Menu.cmbProveedor.EditValue) == 0) ? 99999 : Convert.ToDecimal(ucInv_Menu.cmbProveedor.EditValue);
                Reporte.Parameters["IdProductoIni"].Value = (ucInv_Menu.cmbProducto.EditValue == null) ? 0 : ucInv_Menu.cmbProducto.EditValue;
                Reporte.Parameters["IdProductoFin"].Value = (ucInv_Menu.cmbProducto.EditValue == null || Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue) == 0) ? 99999 : Convert.ToInt32(ucInv_Menu.cmbProducto.EditValue);

                Reporte.Parameters["S_sucursal"].Value = ucInv_Menu.cmbSucursal.Edit.GetDisplayText(ucInv_Menu.cmbSucursal.EditValue);
                Reporte.Parameters["S_proveedor"].Value = ucInv_Menu.cmbProveedor.Edit.GetDisplayText(ucInv_Menu.cmbProveedor.EditValue);
                Reporte.Parameters["S_producto"].Value = ucInv_Menu.cmbProducto.Edit.GetDisplayText(ucInv_Menu.cmbProducto.EditValue);

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
