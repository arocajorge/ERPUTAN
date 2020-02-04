using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_SeguimientoEntregaSolicitante : Form
    {
        #region Variable
        cl_parametrosGenerales_Bus param;
        com_comprador_Bus bus_comprador;
        com_solicitante_Bus bus_solicitante;
        in_producto_Bus bus_producto;
        cp_proveedor_Bus bus_proveedor;
        com_SeguimientoEntrega_Bus bus_seguimientoEntrega;
        public decimal IdOrdenPedido { get; set; }
        #endregion

        public FrmCom_SeguimientoEntregaSolicitante()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_comprador = new com_comprador_Bus();
            bus_solicitante = new com_solicitante_Bus();
            bus_producto = new in_producto_Bus();
            bus_proveedor = new cp_proveedor_Bus();
            bus_seguimientoEntrega = new com_SeguimientoEntrega_Bus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombos()
        {
            try
            {
                deHasta.DateTime = DateTime.Now.Date;
                deDesde.DateTime = DateTime.Now.Date.AddDays(-7);
                cmbComprador.Properties.DataSource = bus_comprador.Get_List_comprador(param.IdEmpresa);
                cmbProveedor.Properties.DataSource = bus_proveedor.GetListCombo(param.IdEmpresa);
                cmbSolicitante.Properties.DataSource = bus_solicitante.Get_List_Solicitante(param.IdEmpresa);
                
                var solicitante = bus_solicitante.GetInfo(param.IdEmpresa, param.IdUsuario);
                if (solicitante != null)
                    cmbSolicitante.EditValue = solicitante.IdSolicitante;

                cmbProducto.Properties.DataSource = bus_producto.GetListCombo(param.IdEmpresa);
                txtIdOrdenPedido.EditValue = IdOrdenPedido;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSolicitante = Convert.ToInt32(cmbSolicitante.EditValue ?? 0);
                int IdComprador = Convert.ToInt32(cmbComprador.EditValue ?? 0);
                decimal IdProducto = Convert.ToInt32(cmbProducto.EditValue ?? 0);
                decimal IdProveedor = Convert.ToInt32(cmbProveedor.EditValue ?? 0);
                decimal IdOrdenPedido = Convert.ToDecimal(txtIdOrdenPedido.EditValue ?? 0);
                gcDetalle.DataSource = bus_seguimientoEntrega.GetList(param.IdEmpresa,param.IdUsuario,IdSolicitante,IdComprador,IdProducto,IdProveedor,deDesde.DateTime.Date,deHasta.DateTime.Date, IdOrdenPedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_SeguimientoEntregaSolicitante_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                if (!string.IsNullOrEmpty(txtIdOrdenPedido.Text) && Convert.ToDecimal(txtIdOrdenPedido.EditValue ?? 0) != 0 )
                    btnBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
