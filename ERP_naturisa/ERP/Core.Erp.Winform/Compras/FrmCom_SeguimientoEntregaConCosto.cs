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
    public partial class FrmCom_SeguimientoEntregaConCosto : Form
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

        public FrmCom_SeguimientoEntregaConCosto()
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
                gcDetalle.DataSource = bus_seguimientoEntrega.GetListConCosto(param.IdEmpresa,deDesde.DateTime.Date,deHasta.DateTime.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_SeguimientoEntregaConCosto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
