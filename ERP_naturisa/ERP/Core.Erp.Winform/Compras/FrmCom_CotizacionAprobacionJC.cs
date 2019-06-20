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

    public partial class FrmCom_CotizacionAprobacionJC : Form
    {
        #region Variables
        com_CotizacionPedido_Bus bus_cotizacion;
        com_CotizacionPedidoDet_Bus bus_det;
        BindingList<com_CotizacionPedidoDet_Info> blst;
        cl_parametrosGenerales_Bus param;
        com_CotizacionPedido_Info info;
        #endregion

        public FrmCom_CotizacionAprobacionJC()
        {
            blst = new BindingList<com_CotizacionPedidoDet_Info>();
            bus_cotizacion = new com_CotizacionPedido_Bus();
            bus_det = new com_CotizacionPedidoDet_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            info = new com_CotizacionPedido_Info();
            InitializeComponent();
        }

        private void FrmCom_CotizacionAprobacionJC_Load(object sender, EventArgs e)
        {
            CargarCotizacion();
        }

        private void SetCotizacion()
        {
            try
            {
                if (info != null)
                {
                    txtIdCotizacion.Text = info.IdCotizacion.ToString();
                    txtProveedor.Text = info.pe_nombreCompleto;
                    txtComprador.Text = info.Comprador;
                    txtObservacion.Text = info.cp_Observacion;
                    txtPlazo.Text = info.cp_PlazoEntrega.ToString();
                    txtSolicitante.Text = info.nom_solicitante;
                    txtSucursal.Text = info.Su_Descripcion;
                    txtTerminoPago.Text = info.TerminoPago;
                    deFecha.DateTime = info.cp_Fecha;

                    info.ListaDetalle = bus_det.GetList(info.IdEmpresa, info.IdCotizacion,"JC");
                    blst = new BindingList<com_CotizacionPedidoDet_Info>(info.ListaDetalle);
                    gc_detalle.DataSource = blst;

                    btnAnular.Visible = true;
                    btnAprobar.Visible = true;
                    btnPasar.Visible = true;
                }
                else
                    Limpiar();
            }
            catch (Exception)
            {
                
            }
        }

        private void CargarCotizacion()
        {
            try
            {
                info = bus_cotizacion.GetInfoAprobar(param.IdEmpresa, param.IdUsuario, "JC");
                SetCotizacion();
            }
            catch (Exception)
            {
                
            }
        }

        private void Limpiar()
        {
            try
            {
                info = new com_CotizacionPedido_Info();

                txtIdCotizacion.Text = string.Empty;
                txtProveedor.Text = string.Empty;
                txtComprador.Text = string.Empty;
                txtObservacion.Text = string.Empty;
                txtPlazo.Text = string.Empty;
                txtSolicitante.Text = string.Empty;
                txtSucursal.Text = string.Empty;
                txtTerminoPago.Text = string.Empty;
                deFecha.DateTime = DateTime.Now.Date;

                blst = new BindingList<com_CotizacionPedidoDet_Info>();
                gc_detalle.DataSource = blst;

                btnAnular.Visible = false;
                btnAprobar.Visible = false;
                btnPasar.Visible = false;

                MessageBox.Show("No existen cotizaciones pendientes de aprobar",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCotizacion.Focus();
                info.ListaDetalle = new List<com_CotizacionPedidoDet_Info>(blst);
                info.EstadoJC = info.ListaDetalle.Where(q=>q.A == true).Count() > 0 ? "A" : "R";
                if (bus_cotizacion.AprobarDB(info,"JC"))
                {
                    CargarCotizacion();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCotizacion.Focus();
                info.ListaDetalle.ForEach(q => q.A = false);
                info.EstadoJC = "R";
                if (bus_cotizacion.AprobarDB(info, "JC"))
                {
                    CargarCotizacion();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCotizacion.Focus();
                if (bus_cotizacion.PasarDB(info.IdEmpresa,info.IdCotizacion, param.IdUsuario))
                {
                    CargarCotizacion();
                }
            }
            catch (Exception)
            {

            }
        }

        private void gv_detalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (e.Column == colA)
                    row.R = !Convert.ToBoolean(e.Value ?? false);
                else
                    if (e.Column == colR)
                        row.A = !Convert.ToBoolean(e.Value ?? false);
            }
            catch (Exception)
            {

            }
        }

        private void txtProducto_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdProducto != null)
                {
                    FrmCom_ProductoComprasAnteriores frm = new FrmCom_ProductoComprasAnteriores();
                    frm.IdProducto = row.IdProducto ?? 0;
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void gv_detalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_Color)
                    e.Appearance.BackColor = row.Color;
                
            }
            catch (Exception)
            {
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCom_CotizacionConsulta frm = new FrmCom_CotizacionConsulta();
                frm.Cargo = "JC";
                frm.ShowDialog();
                info = frm.info;
                SetCotizacion();
            }
            catch (Exception)
            {
                
            }
        }

    }
}
