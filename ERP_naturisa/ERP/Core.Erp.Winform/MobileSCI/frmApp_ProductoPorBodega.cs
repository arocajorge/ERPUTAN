using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.MobileSCI;
using Core.Erp.Info.MobileSCI;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.MobileSCI
{
    public partial class frmApp_ProductoPorBodega : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        tbl_producto_x_tbl_bodega_Bus busProductoPorBodega;
        tb_Sucursal_Bus busSucursal;
        tb_Bodega_Bus busBodega;
        List<tb_Bodega_Info> lstBodega;
        BindingList<tbl_producto_x_tbl_bodega_Info> blstNoAsignado;
        BindingList<tbl_producto_x_tbl_bodega_Info> blstAsignado;
        #endregion

        #region Constructor
        public frmApp_ProductoPorBodega()
        {
            InitializeComponent();
            busProductoPorBodega = new tbl_producto_x_tbl_bodega_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            busSucursal = new tb_Sucursal_Bus();
            busBodega = new tb_Bodega_Bus();
            lstBodega = new List<tb_Bodega_Info>();
            blstAsignado = new BindingList<tbl_producto_x_tbl_bodega_Info>();
            blstNoAsignado = new BindingList<tbl_producto_x_tbl_bodega_Info>();
        }
        #endregion

        #region Eventos
        private void frmApp_ProductoPorBodega_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbBodega.Properties.DataSource = null;
                if (cmbSucursal.EditValue != null)
                    cmbBodega.Properties.DataSource = lstBodega.Where(q => q.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue)).ToList();

                cmbBodega.EditValue = null;
            }
            catch (Exception)
            {

            }
        }
        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarListas();
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Métodos
        private void CargarCombos()
        {
            try
            {
                var lstSucursal = busSucursal.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursal.Properties.DataSource = lstSucursal;

                lstBodega = busBodega.Get_List_Bodega(param.IdEmpresa);
                cmbBodega.Properties.DataSource = lstBodega;
            }
            catch (Exception)
            {
                
            }
        }

        public void CargarListas()
        {
            try
            {
                if (cmbSucursal.EditValue == null || cmbBodega.EditValue == null)
                    return;

                int IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                int IdBodega = Convert.ToInt32(cmbBodega.EditValue);
                var lst = busProductoPorBodega.GetList(param.IdEmpresa, IdSucursal, IdBodega);

                blstNoAsignado = new BindingList<tbl_producto_x_tbl_bodega_Info>(lst.Where(q => q.EnBase == false).ToList());
                gcNoAsignado.DataSource = blstNoAsignado;

                blstAsignado = new BindingList<tbl_producto_x_tbl_bodega_Info>(lst.Where(q => q.EnBase == true).ToList());
                gcAsignado.DataSource = blstAsignado;                
            }
            catch (Exception)
            {
                
            }   
        }
        #endregion

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                gvNoAsignado.MoveNext();
                var lst = new List<tbl_producto_x_tbl_bodega_Info>(blstNoAsignado.Where(q => q.Seleccionado == true).ToList());
                foreach (var item in lst)
                {
                    busProductoPorBodega.Guardar(param.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto);
                }
                CargarListas();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnNoAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                gvAsignado.MoveNext();
                var lst = new List<tbl_producto_x_tbl_bodega_Info>(blstAsignado.Where(q => q.Seleccionado == true).ToList());
                foreach (var item in lst)
                {
                    busProductoPorBodega.Anular(param.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto);
                }
                CargarListas();
            }
            catch (Exception)
            {
                
            }
        }

        private void chkSeleccionNA_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvNoAsignado.RowCount; i++)
            {
                gvNoAsignado.SetRowCellValue(i, colSeleccionadoNA, chkSeleccionNA.Checked);
            }
        }

        private void chkSeleccionA_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvAsignado.RowCount; i++)
            {
                gvAsignado.SetRowCellValue(i, colSeleccionadoA, chkSeleccionA.Checked);
            }
        }


    }
}
