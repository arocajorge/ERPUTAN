using Core.Erp.Business.Compras;
using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenPedidoConsulta : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedido_Bus bus_Orden;
        #endregion

        public frmCom_OrdenPedidoConsulta()
        {
            InitializeComponent();
            bus_Orden = new com_OrdenPedido_Bus();
        }

        private void frmCom_OrdenPedidoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Buscar()
        {
            try
            {
                var lst = bus_Orden.GetList(param.IdEmpresa, param.IdUsuario, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
                gc_Consulta.DataSource = lst;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_Consulta.ShowPrintPreview();
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                com_OrdenPedido_Info row = (com_OrdenPedido_Info)gv_Consulta.GetFocusedRow();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (Accion != Cl_Enumeradores.eTipo_action.grabar && Accion != Cl_Enumeradores.eTipo_action.consultar && row != null)
                {
                    var orden = bus_Orden.GetInfo(row.IdEmpresa, row.IdOrdenPedido);
                    if (orden.IdCatalogoEstado != Cl_Enumeradores.eCatalogoEstadoSolicitudPedido.EST_OP_ABI.ToString())
                    {
                        MessageBox.Show("La solicitud de pedido #"+row.IdOrdenPedido.ToString()+" no puede ser " +
                            (Accion == Cl_Enumeradores.eTipo_action.actualizar ?  "modificada" : "anulada")
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                frmCom_OrdenPedidoMantenimiento frm = new frmCom_OrdenPedidoMantenimiento();
                frm.SetInfo(row ?? new com_OrdenPedido_Info(), Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing += frm_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing;
                frm.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void frm_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void gv_Consulta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                com_OrdenPedido_Info row = (com_OrdenPedido_Info)gv_Consulta.GetRow(e.RowHandle);
                if (row != null)
                {
                    if (row.IdCatalogoEstado == "EST_OP_CER")
                        e.Appearance.ForeColor = Color.Green;
                    else
                        if (row.IdCatalogoEstado == "EST_OP_PRO")
                            e.Appearance.ForeColor = Color.Navy;
                    if (!row.Estado)
                        e.Appearance.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
