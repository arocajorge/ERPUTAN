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
    using Core.Erp.Business.Contabilidad;

    public partial class FrmCom_CotizacionAprobacionGAMant : Form
    {
        #region Variables
        com_OrdenPedido_Bus bus_pedido;
        com_CotizacionPedido_Bus bus_cotizacion;
        com_CotizacionPedidoDet_Bus bus_cotizaciondet;
        BindingList<com_CotizacionPedidoDet_Info> blst;
        cl_parametrosGenerales_Bus param;
        com_departamento_Bus bus_departamento;
        ct_punto_cargo_Bus bus_punto_cargo;
        tb_Sucursal_Bus bus_sucursal;
        public decimal IdOrdenPedido { get; set; }
        #endregion

        #region Delegados
        public delegate void delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing;
        void FrmCom_CotizacionAprobacionGAMant_event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void FrmCom_CotizacionAprobacionGAMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing(sender, e);
            }
            catch (Exception)
            {

            }
        }
        #endregion

        public FrmCom_CotizacionAprobacionGAMant()
        {
            bus_pedido = new com_OrdenPedido_Bus();
            bus_cotizacion = new com_CotizacionPedido_Bus();
            bus_cotizaciondet = new com_CotizacionPedidoDet_Bus();
            blst = new BindingList<com_CotizacionPedidoDet_Info>();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_punto_cargo = new ct_punto_cargo_Bus();
            bus_departamento = new com_departamento_Bus();
            bus_sucursal = new tb_Sucursal_Bus();
            InitializeComponent();
            event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing += FrmCom_CotizacionAprobacionGAMant_event_delegate_FrmCom_CotizacionAprobacionGAMant_FormClosing;
        }

        private void FrmCom_CotizacionAprobacionGAMant_Load(object sender, EventArgs e)
        {
            try
            {
                uc_menu.btnAnular.Text = "Anular todo";
                SetInfoInControls();
            }
            catch (Exception)
            {
                
            }
        }

        private void SetInfoInControls()
        {
            try
            {
                CargarCombos();

                var pedido = bus_pedido.GetInfo(param.IdEmpresa, IdOrdenPedido);
                if (pedido == null)
                    return;

                txt_codigo.Text = pedido.op_Codigo;
                txt_IdOrdenPedido.Text = pedido.IdOrdenPedido.ToString();
                txt_Observacion.Text = pedido.op_Observacion;
                cmb_Departamento.EditValue = pedido.IdDepartamento;
                cmb_PuntoCargoCab.EditValue = pedido.IdPunto_cargo;
                chk_EsCompraUrgente.Checked = pedido.EsCompraUrgente;
                de_Fecha.DateTime = pedido.op_Fecha;

                blst = new BindingList<com_CotizacionPedidoDet_Info>(bus_cotizaciondet.GetListPedido(param.IdEmpresa, IdOrdenPedido, param.IdUsuario));
                lblTotal.Text = "$ " + blst.Sum(q => q.cd_total).ToString("n2");
                gc_detalle.DataSource = blst;
            }
            catch (Exception)
            {
                
            }
        }

        private void CargarCombos()
        {
            try
            {
                cmb_Departamento.Properties.DataSource = bus_departamento.Get_List_Departamento(param.IdEmpresa);
                var lstSucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_SucursalDestino.DataSource = lstSucursal;
                cmb_SucursalOrdigen.DataSource = lstSucursal;
                var lstPuntoCargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_PuntoCargoCab.Properties.DataSource = lstPuntoCargo;
            }
            catch (Exception)
            {
                
            }
        }

        private void uc_menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_menu_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Focus();
                if (blst.Where(q => q.opd_EstadoProceso != "AJC").Count() > 0)
                {
                    MessageBox.Show("Para aprobar el pedido todos los items deben ser aprobados por el jefe de compras",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                var lst = blst.GroupBy(q=>q.IdCotizacion).ToList();
                foreach (var item in lst)
                {
                    var cotizacion = bus_cotizacion.GetInfoAprobar(param.IdEmpresa, item.Key);
                    if (cotizacion != null)
                    {
                        cotizacion.ObservacionAprobador = txt_ObservacionApro.Text;
                        cotizacion.EstadoGA = blst.Where(q => q.IdCotizacion == item.Key && q.A == true).Count() > 0 ? "A" : "R";
                        cotizacion.IdUsuario = param.IdUsuario;
                        cotizacion.ListaDetalle = new List<com_CotizacionPedidoDet_Info>(blst.Where(q => q.IdCotizacion == item.Key).Select(q => new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = param.IdEmpresa,
                            IdCotizacion = q.IdCotizacion,
                            Secuencia = q.Secuencia,
                            opd_IdEmpresa = q.opd_IdEmpresa,
                            opd_IdOrdenPedido = q.opd_IdOrdenPedido,
                            opd_Secuencia = q.opd_Secuencia,
                            IdProducto = q.IdProducto ?? 0,
                            cd_Cantidad = q.cd_Cantidad,
                            cd_precioCompra = q.cd_precioCompra,
                            cd_porc_des = q.cd_porc_des,
                            cd_descuento = q.cd_descuento,
                            cd_precioFinal = q.cd_precioFinal,
                            cd_subtotal = q.cd_subtotal,
                            IdCod_Impuesto = q.IdCod_Impuesto,
                            Por_Iva = q.Por_Iva,
                            cd_iva = q.cd_iva,
                            cd_total = q.cd_total,
                            IdUnidadMedida = q.IdUnidadMedida,
                            IdPunto_cargo = q.IdPunto_cargo,
                            EstadoGA = q.A,
                            A = q.A,
                            cd_DetallePorItem = q.cd_DetallePorItem,
                            IdSucursalDestino = q.IdSucursalDestino
                        }).ToList());

                        if (!bus_cotizacion.AprobarDB(cotizacion, "GA"))
                            return;

                    }
                }
                bus_pedido.ValidarProceso(param.IdEmpresa, IdOrdenPedido);
                MessageBox.Show("Pedido # " + txt_IdOrdenPedido.Text + " actualizado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void chk_Aprobar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gv_detalle.RowCount; i++)
            {
                gv_detalle.SetRowCellValue(i, Col_A, chk_Aprobar.Checked);
            }
            }
            catch (Exception)
            {
                
            }
        }

        private void cmb_search_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdPunto_cargo == null)
                    return;

                FrmCom_ComprasPorPuntoCargo frm = new FrmCom_ComprasPorPuntoCargo();
                frm.IdPunto_cargo = Convert.ToInt32(row.IdPunto_cargo);
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void uc_menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Focus();
                if (MessageBox.Show("A continuación se anulará el pedido #"+txt_IdOrdenPedido.Text+" completamente",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                if (blst.Where(q => q.opd_EstadoProceso != "AJC").Count() > 0)
                {
                    MessageBox.Show("Para anular el pedido todos los items deben ser aprobados por el jefe de compras", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var lst = blst.GroupBy(q => q.IdCotizacion).ToList();
                foreach (var item in lst)
                {
                    var cotizacion = bus_cotizacion.GetInfoAprobar(param.IdEmpresa, item.Key);
                    if (cotizacion != null)
                    {
                        cotizacion.ObservacionAprobador = txt_ObservacionApro.Text;
                        cotizacion.EstadoGA = "R";
                        cotizacion.IdUsuario = param.IdUsuario;
                        cotizacion.ListaDetalle = new List<com_CotizacionPedidoDet_Info>(blst.Where(q => q.IdCotizacion == item.Key).Select(q => new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = param.IdEmpresa,
                            IdCotizacion = q.IdCotizacion,
                            Secuencia = q.Secuencia,
                            opd_IdEmpresa = q.opd_IdEmpresa,
                            opd_IdOrdenPedido = q.opd_IdOrdenPedido,
                            opd_Secuencia = q.opd_Secuencia,
                            IdProducto = q.IdProducto ?? 0,
                            cd_Cantidad = q.cd_Cantidad,
                            cd_precioCompra = q.cd_precioCompra,
                            cd_porc_des = q.cd_porc_des,
                            cd_descuento = q.cd_descuento,
                            cd_precioFinal = q.cd_precioFinal,
                            cd_subtotal = q.cd_subtotal,
                            IdCod_Impuesto = q.IdCod_Impuesto,
                            Por_Iva = q.Por_Iva,
                            cd_iva = q.cd_iva,
                            cd_total = q.cd_total,
                            IdUnidadMedida = q.IdUnidadMedida,
                            IdPunto_cargo = q.IdPunto_cargo,
                            EstadoGA = false,
                            A = false,
                            cd_DetallePorItem = q.cd_DetallePorItem
                        }).ToList());

                        if (!bus_cotizacion.AprobarDB(cotizacion, "GA"))
                            return;

                    }
                }
                bus_pedido.ValidarProceso(param.IdEmpresa, IdOrdenPedido);
                MessageBox.Show("Pedido # " + txt_IdOrdenPedido.Text + " actualizado exitósamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void gv_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (Col_Cantidad == e.Column)
                {
                    row.cd_subtotal = row.cd_precioFinal * row.cd_Cantidad;
                    row.cd_iva = row.cd_subtotal * (row.Por_Iva / 100);
                    row.cd_total = row.cd_subtotal + row.cd_iva;
                    gc_detalle.RefreshDataSource();
                    SetTotal();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void SetTotal()
        {
            try
            {
                lblTotal.Text = "$ " + blst.Sum(q => q.cd_subtotal).ToString("n2");
            }
            catch (Exception)
            {
                
            }
        }
    }
}
