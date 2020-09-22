using Core.Erp.Business.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
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
    public partial class FrmCom_OrdenPedidoRegularizacionCons : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedido_Bus bus_Orden;
        #endregion

        public FrmCom_OrdenPedidoRegularizacionCons()
        {
            InitializeComponent();
            bus_Orden = new com_OrdenPedido_Bus();
        }

        private void FrmCom_OrdenPedidoRegularizacionCons_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        #region Metodos
        private void Buscar()
        {
            try
            {
                var lst = bus_Orden.GetListRegularizacion(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gc_Consulta.DataSource = lst;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        #region Acciones
        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        #endregion

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                com_OrdenPedido_Info row = (com_OrdenPedido_Info)gv_Consulta.GetFocusedRow();
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                frmCom_OrdenPedidoRegularizacionMant frm = new frmCom_OrdenPedidoRegularizacionMant();
                frm.SetInfo(row ?? new com_OrdenPedido_Info(),Info.General.Cl_Enumeradores.eTipo_action.consultar);
                frm.event_delegate_frmCom_OrdenPedidoRegularizacionMant_FormClosing += frm_event_delegate_frmCom_OrdenPedidoRegularizacionMant_FormClosing;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void frm_event_delegate_frmCom_OrdenPedidoRegularizacionMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Buscar();
        }
        
    }
}
