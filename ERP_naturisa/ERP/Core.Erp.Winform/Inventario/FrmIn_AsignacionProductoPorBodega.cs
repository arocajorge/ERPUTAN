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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_AsignacionProductoPorBodega : Form
    {
        #region Variables
        in_ProductoPor_tb_bodega_Bus busProductoPorBodega = new in_ProductoPor_tb_bodega_Bus();
        BindingList<in_ProductoPor_tb_bodega_Info> blstProductoPorBodega = new BindingList<in_ProductoPor_tb_bodega_Info>();
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Bodega_Info> ListBodegas = new List<tb_Bodega_Info>();
        tb_Bodega_Info infoBodega = new tb_Bodega_Info();
        string mensaje = string.Empty;
        #endregion

        #region Constructor
        public FrmIn_AsignacionProductoPorBodega()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        private void CargarCombos()
        {
            cmbSucursal.Properties.DataSource = busSucursal.Get_List_Sucursal(param.IdEmpresa);
        }
        private void CargarDetalle()
        {
            blstProductoPorBodega = new BindingList<in_ProductoPor_tb_bodega_Info>();
            infoBodega = null;
            if (cmbBodega.EditValue != null)
            {
                int IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                int IdBodega = Convert.ToInt32(cmbBodega.EditValue);
                infoBodega = ListBodegas.Where(q => q.IdBodega == IdBodega).FirstOrDefault();
                blstProductoPorBodega = new BindingList<in_ProductoPor_tb_bodega_Info>(busProductoPorBodega.GetList(param.IdEmpresa, IdSucursal, IdBodega, true));    
            }
            gcNoAsignado.DataSource = blstProductoPorBodega;
        }
        private bool Guardar()
        {
            gvNoAsignado.MoveNext();
            cmbSucursal.Focus();

            if (cmbSucursal.EditValue == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cmbBodega.EditValue == null)
            {
                MessageBox.Show("Debe seleccionar una bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            int IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
            int IdBodega = Convert.ToInt32(cmbBodega.EditValue);
            if (busProductoPorBodega.GuardarDB(param.IdEmpresa, IdSucursal, IdBodega, blstProductoPorBodega.Where(q=> q.Seleccionado == true).ToList()))
            {
                MessageBox.Show("Registros guardados exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eventos
        private void FrmIn_AsignacionProductoPorBodega_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            blstProductoPorBodega = new BindingList<in_ProductoPor_tb_bodega_Info>();
            if (cmbSucursal.EditValue == null)
            {
                gcNoAsignado.DataSource = blstProductoPorBodega;
                return;
            }
            int IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
            cmbBodega.EditValue = null;
            ListBodegas = busBodega.Get_List_Bodega(param.IdEmpresa, IdSucursal);
            cmbBodega.Properties.DataSource = ListBodegas;
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                cmbBodega.EditValue = null;
                cmbSucursal.EditValue = null;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.Close();
            }
        }

        private void chkSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < gvNoAsignado.RowCount; i++)
            {
                if (chkSeleccionarTodo.Checked)
                {
                    var row = (in_ProductoPor_tb_bodega_Info)gvNoAsignado.GetRow(i);
                    mensaje = busProductoPorBodega.ValidarExisteEnMultiplesBodegas(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue), Convert.ToInt32(cmbBodega.EditValue), infoBodega.EsBodegaSecundaria, row.IdProducto);
                    if (string.IsNullOrEmpty(mensaje))
                    {
                        gvNoAsignado.SetRowCellValue(i, colSeleccionadoNA, chkSeleccionarTodo.Checked);
                    }else
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else
                    gvNoAsignado.SetRowCellValue(i, colSeleccionadoNA, chkSeleccionarTodo.Checked);
            }
        }
        #endregion                

        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            CargarDetalle();
        }

        private void chkSeleccion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                var row = (in_ProductoPor_tb_bodega_Info)gvNoAsignado.GetFocusedRow();
                if (row != null)
                {
                    mensaje = busProductoPorBodega.ValidarExisteEnMultiplesBodegas(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue), Convert.ToInt32(cmbBodega.EditValue), infoBodega.EsBodegaSecundaria, row.IdProducto);
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
