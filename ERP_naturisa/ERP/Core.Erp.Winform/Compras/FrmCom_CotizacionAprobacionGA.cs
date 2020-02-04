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

    public partial class FrmCom_CotizacionAprobacionGA : Form
    {
        #region Variables
        com_CotizacionPedido_Bus bus_cotizacion;
        com_CotizacionPedidoDet_Bus bus_det;
        BindingList<com_CotizacionPedidoDet_Info> blst;
        cl_parametrosGenerales_Bus param;
        com_CotizacionPedido_Info info;
        com_OrdenPedido_Bus bus_pedido;
        #endregion

        public FrmCom_CotizacionAprobacionGA()
        {
            blst = new BindingList<com_CotizacionPedidoDet_Info>();
            bus_cotizacion = new com_CotizacionPedido_Bus();
            bus_det = new com_CotizacionPedidoDet_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            info = new com_CotizacionPedido_Info();
            bus_pedido = new com_OrdenPedido_Bus();
            InitializeComponent();
        }

        private void FrmCom_CotizacionAprobacionGA_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                
            }   
        }

        private void Buscar()
        {
            try
            {
                gc_Consulta.DataSource = bus_pedido.GetList(param.IdEmpresa, param.IdUsuario);
            }
            catch (Exception)
            {
                
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                com_OrdenPedido_Info row = (com_OrdenPedido_Info)gv_Consulta.GetFocusedRow();
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                FrmCom_CotizacionAprobacionGAMant frm = new FrmCom_CotizacionAprobacionGAMant();
                frm.IdOrdenPedido = row.IdOrdenPedido;
                frm.MdiParent = this.MdiParent;
                frm.event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing += frm_event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing;
                frm.Show();
            }
            catch (Exception)
            {
                
            }
        }

        void frm_event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Buscar();
        }

    }
}
