using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_ActivoFijo_x_OC_x_Factura : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus busAf_OC = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus();
        List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info> lstInfo = new List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info>();
        vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info Info = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmAF_ActivoFijo_x_OC_x_Factura()
        {
            InitializeComponent();
        }


        public void set_OC_Factura_Activo(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                lstInfo = busAf_OC.Get_List_OC_Factura_ActivoFijo(IdEmpresa, IdProveedor, lstNaturaleza());
                gridActivo_OC_Factura.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<fa_catalogo_Info> lstNaturaleza()
        {
            try
            {
                List<fa_catalogo_Info> lstInfo = new List<fa_catalogo_Info>();
                fa_catalogo_Info Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_TODO.ToString();
                lstInfo.Add(Info);

                Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_ACFIJ.ToString();
                lstInfo.Add(Info);

                return lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<fa_catalogo_Info>();
            }
        }

        private void gridViewActivo_OC_Factura_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Info = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
                Info = (vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info)gridViewActivo_OC_Factura.GetFocusedRow();
                getObtenerDatos();
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info getObtenerDatos()
        {
            try
            {
                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
            }
        }

        private void frmAF_ActivoFijo_x_OC_x_Factura_Load(object sender, EventArgs e)
        {

        }

    }
}