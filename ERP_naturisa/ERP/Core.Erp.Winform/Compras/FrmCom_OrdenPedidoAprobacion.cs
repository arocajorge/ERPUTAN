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
    using Core.Erp.Business.General;
    using Core.Erp.Info.General;
    using Core.Erp.Business.Compras;
    using Core.Erp.Info.Compras;
    using Core.Erp.Business.Contabilidad;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Info.Inventario;
    using DevExpress.XtraGrid.Views.Grid;
    using Core.Erp.Winform.Inventario;

    public partial class FrmCom_OrdenPedidoAprobacion : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_OrdenPedido_Bus bus_orden;
        com_departamento_Bus bus_departamento;
        com_OrdenPedido_Info info_pedido;
        Cl_Enumeradores.eTipo_action Accion;
        com_solicitante_Bus bus_solicitante;
        com_OrdenPedidoDet_Bus bus_detalle;
        BindingList<com_OrdenPedidoDet_Info> blst_det;
        tb_Sucursal_Bus bus_sucursal;
        ct_punto_cargo_Bus bus_punto_cargo;
        in_UnidadMedida_Bus bus_uni_medida;
        #endregion

        public FrmCom_OrdenPedidoAprobacion()
        {
            InitializeComponent();
            bus_orden = new com_OrdenPedido_Bus();
            bus_departamento = new com_departamento_Bus();
            bus_solicitante = new com_solicitante_Bus();
            bus_detalle = new com_OrdenPedidoDet_Bus();
            blst_det = new BindingList<com_OrdenPedidoDet_Info>();
            bus_sucursal = new tb_Sucursal_Bus();
            bus_punto_cargo = new ct_punto_cargo_Bus();
            bus_uni_medida = new in_UnidadMedida_Bus();
        }


        private void CargarCombos()
        {
            try
            {
                var lstSucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_SucursalDestino.DataSource = lstSucursal;
                cmb_SucursalOrdigen.DataSource = lstSucursal;
                cmb_PuntoCargo.DataSource = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_UnidadMedida.DataSource = bus_uni_medida.Get_list_UnidadMedida();
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
                blst_det = new BindingList<com_OrdenPedidoDet_Info>(bus_detalle.GetListPorAprobar(param.IdEmpresa, param.IdUsuario,"P"));
                gc_detalle.DataSource = blst_det;
            }
            catch (Exception)
            {
                
            }
        }

        private void FrmCom_OrdenPedidoAprobacion_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void gv_detalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {
                
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool Actualizar()
        {
            try
            {
                btn_Buscar.Focus();
                if (blst_det.Where(q=> q.A == true && q.opd_CantidadApro == 0).Count() > 0)
                {
                    MessageBox.Show("Existen registros aprobados con cantidad 0, verifique",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
                var lst = new List<com_OrdenPedidoDet_Info>(blst_det.Where(q => q.A == true || q.R == true).ToList());
                lst.ForEach(q => q.IdUsuario = param.IdUsuario);
                if (bus_detalle.ActualizarEstadoAprobacion(lst))
                {
                    var lstGrupo = blst_det.Where(q => q.A && q.opd_CantidadApro > 0).GroupBy(q => q.IdOrdenPedido).Select(q => new
                    {
                        IdOrdenPedido = q.Key
                    });
                    foreach (var item in lstGrupo)
                    {
                        bus_orden.SaltarPaso4(param.IdEmpresa, item.IdOrdenPedido, param.IdUsuario);
                    }

                    MessageBox.Show("Registros actualizados exitósamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actualizar())
                {
                    Buscar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Actualizar())
                {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtStock_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdProducto == null)
                    return;

                FrmIn_ProductoPorBodegaStock frm = new FrmIn_ProductoPorBodegaStock();
                frm._IdProducto = row.IdProducto ?? 0;
                frm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gv_detalle_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (row.IdProducto == null)
                    e.Appearance.ForeColor = Color.DarkOrange;
            }
            catch (Exception)
            {

            }
        }

        private void chk_Reprobar_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_detalle.RowCount; i++)
            {
                gv_detalle.SetRowCellValue(i, col_R, chk_Reprobar.Checked);
            }
        }

        private void chk_Aprobar_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_detalle.RowCount; i++)
            {
                gv_detalle.SetRowCellValue(i, col_A, chk_Aprobar.Checked);
            }
        }

        private void gv_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_A)
                {
                    if (row.A == true)
                    {
                        row.opd_CantidadApro = row.opd_Cantidad;
                    }
                    else
                    {
                        row.opd_CantidadApro = 0;
                    }
                    row.R = false;
                }
                if (e.Column == col_R)
                {
                    row.opd_CantidadApro = 0;
                    row.A = false;
                }
                if (e.Column == col_CantidadAprobada)
                {
                    if (Convert.ToDouble(e.Value ?? 0) == 0)
                    {
                        row.A = false;
                        row.R = false;
                    }
                    else
                    {
                        row.A = true;
                        row.R = false;
                    }
                }
                gv_detalle.RefreshData();
            }
            catch (Exception)
            {
                
            }
        }

        private void cmb_search_Click(object sender, EventArgs e)
        {
            try
            {
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetFocusedRow();
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
    }
}
