using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.CuentasxPagar;
    using Core.Erp.Business.CuentasxPagar;
    using Core.Erp.Business.Contabilidad;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Winform.Inventario;

    public partial class FrmCom_OrdenPedidoCotizacionConfirma : Form
    {
        #region Variables
        public List<com_TerminoPago_Info> lst_termino { get; set; }
        public List<cp_proveedor_combo_Info> lst_proveedor { get; set; }
        public List<tb_Sucursal_Info> lst_sucursal { get; set; }
        public BindingList<com_CotizacionPedido_Info> blst { get; set; }
        com_CotizacionPedido_Bus bus_cotizaciones;
        cl_parametrosGenerales_Bus param;
        #endregion

        public FrmCom_OrdenPedidoCotizacionConfirma()
        {
            InitializeComponent();
            bus_cotizaciones = new com_CotizacionPedido_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
        }

        private void gv_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            com_CotizacionPedido_Info row = (com_CotizacionPedido_Info)gv_detalle.GetRow(e.RowHandle);
            if (row == null)
                return;

            if (e.Column == col_TerminoPago)
            {
                var termino = lst_termino.Where(q => q.IdTerminoPago == row.IdTerminoPago).FirstOrDefault();
                if (termino == null)
                    return;
                row.cp_Plazo = termino.Dias;
            }
        }

        private void FrmCom_OrdenPedidoCotizacionConfirma_Load(object sender, EventArgs e)
        {
            cmb_Proveedor.DataSource = lst_proveedor;
            cmb_Sucursal.DataSource = lst_sucursal;
            cmb_TerminoPago.DataSource = lst_termino;
            gc_detalle.DataSource = blst;
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            txtFocus.Focus();

            if (blst.Where(q=> string.IsNullOrEmpty(q.IdTerminoPago)).Count() > 0)
            {
                MessageBox.Show("Seleccione el término de pago del proveedor",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (blst.Where(q => string.IsNullOrEmpty(q.cp_Observacion)).Count() > 0)
            {
                MessageBox.Show("Ingrese la observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool cerrar = true;
            foreach (var item in blst)
            {
                item.IdUsuario = param.IdUsuario;
                if (!bus_cotizaciones.GuardarDB(item))
                {
                    cerrar = false;
                }
            }
            if (cerrar)
            {
                MessageBox.Show("Cotizaciones creadas exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}
