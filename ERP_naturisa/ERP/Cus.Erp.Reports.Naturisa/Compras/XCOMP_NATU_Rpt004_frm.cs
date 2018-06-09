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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt004_frm : Form
    {
        #region Variables
        //Bus
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        //Listas
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
       
        #endregion
              
        public XCOMP_NATU_Rpt004_frm()
        {
            InitializeComponent();
        }

        void cargar_combos()
        {
            try
            {
                listSucursal = buSucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursal.Properties.DataSource = listSucursal;
                cmbSucursal.Properties.DisplayMember = "Su_Descripcion";
                cmbSucursal.Properties.ValueMember = "IdSucursal";

                listProveedor = busProveedor.Get_List_proveedor(param.IdEmpresa);

                cp_proveedor_Info InfoTodos = new cp_proveedor_Info();
                InfoTodos.IdEmpresa = param.IdEmpresa;
                InfoTodos.IdProveedor = 0;
                InfoTodos.pr_nombre2 = "Todos";
                InfoTodos.pr_nombre = "Todos";
                listProveedor.Add(InfoTodos);

                cmbProveedor.Properties.DataSource = listProveedor;
                cmbProveedor.Properties.DisplayMember = "pr_nombre";
                cmbProveedor.Properties.ValueMember = "IdProveedor";

                listProducto = busProducto.Get_list_Producto(param.IdEmpresa);
                cmbProducto.Properties.DataSource = listProducto;
                cmbProducto.Properties.DisplayMember = "pr_descripcion";
                cmbProducto.Properties.ValueMember = "IdProducto";
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCOMP_NATU_Rpt004_frm_Load(object sender, EventArgs e)
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
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;

                if (cmbProveedor.EditValue == null)
                {
                    IdProveedorIni = 1;
                    IdProveedorFin = 999999;
                }
                else
                {
                    IdProveedorIni = Convert.ToDecimal(cmbProveedor.EditValue);
                    IdProveedorFin = Convert.ToDecimal(cmbProveedor.EditValue);
                }

                if (cmbProducto.EditValue == null || Convert.ToDecimal(cmbProducto.EditValue) == 0)
                {
                    IdProductoIni = 1;
                    IdProductoFin = 999999;
                }
                else
                {
                    IdProductoIni = Convert.ToDecimal(cmbProducto.EditValue);
                    IdProductoFin = Convert.ToDecimal(cmbProducto.EditValue);
                }

                XCOMP_NATU_Rpt004_Rpt Reporte = new XCOMP_NATU_Rpt004_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["IdSucursal"].Value = cmbSucursal.EditValue;
                Reporte.Parameters["FechaIni"].Value = dtpFechaIni.Value;
                Reporte.Parameters["FechaFin"].Value = dtpFechaFin.Value;
                Reporte.Parameters["IdProveedorIni"].Value = IdProveedorIni;
                Reporte.Parameters["IdProveedorFin"].Value = IdProveedorFin;
                Reporte.Parameters["IdProductoIni"].Value = IdProductoIni;
                Reporte.Parameters["IdProductoFin"].Value = IdProductoFin;


                Reporte.Parameters["S_empresa"].Value = param.InfoEmpresa.em_nombre;
                Reporte.Parameters["S_sucursal"].Value = cmbSucursal.Text;
                Reporte.Parameters["S_proveedor"].Value = cmbProveedor.Text;
                Reporte.Parameters["S_fechaini"].Value = dtpFechaIni.Text;
                Reporte.Parameters["S_fechafin"].Value = dtpFechaFin.Text;
                Reporte.Parameters["S_producto"].Value = cmbProducto.Text;

                printControl_report.PrintingSystem = Reporte.PrintingSystem;
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
