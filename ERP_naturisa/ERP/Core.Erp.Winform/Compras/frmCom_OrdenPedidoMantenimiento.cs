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

    public partial class frmCom_OrdenPedidoMantenimiento : Form
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
        in_producto_Bus bus_producto;
        in_UnidadMedida_Bus bus_uni_medida;
        List<in_Producto_Info> Lista_producto;
        com_OrdenPedidoPlantilla_Bus bus_plantilla;
        com_OrdenPedidoPlantillaDet_Bus bus_plantilla_det;
        #endregion

        #region Delegados
        public delegate void delegate_frmCom_OrdenPedidoMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCom_OrdenPedidoMantenimiento_FormClosing event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing;
        #endregion

        public frmCom_OrdenPedidoMantenimiento()
        {
            InitializeComponent();
            bus_orden = new com_OrdenPedido_Bus();
            bus_departamento = new com_departamento_Bus();
            bus_solicitante = new com_solicitante_Bus();
            bus_detalle = new com_OrdenPedidoDet_Bus();
            blst_det = new BindingList<com_OrdenPedidoDet_Info>();
            bus_sucursal = new tb_Sucursal_Bus();
            bus_punto_cargo = new ct_punto_cargo_Bus();
            bus_producto = new in_producto_Bus();
            bus_uni_medida = new in_UnidadMedida_Bus();
            Lista_producto = new List<in_Producto_Info>();
            bus_plantilla = new com_OrdenPedidoPlantilla_Bus();
            bus_plantilla_det = new com_OrdenPedidoPlantillaDet_Bus();
            event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing += frmCom_OrdenPedidoMantenimiento_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing;
        }

        void frmCom_OrdenPedidoMantenimiento_event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void CargarCombos()
        {
            try
            {
                cmb_Departamento.Properties.DataSource = bus_departamento.Get_List_Departamento(param.IdEmpresa);
                var lstSucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_SucursalDestino.DataSource = lstSucursal;
                cmb_SucursalOrdigen.DataSource = lstSucursal;
                var lstPuntoCargo =bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_PuntoCargo.DataSource = lstPuntoCargo;
                Lista_producto = bus_producto.GetListProductoCombo(param.IdEmpresa, Cl_Enumeradores.eModulos.COMP);
                cmb_producto.DataSource = Lista_producto;
                cmb_UnidadMedida.DataSource = bus_uni_medida.Get_list_UnidadMedida();
                cmb_PuntoCargoCab.Properties.DataSource = lstPuntoCargo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetInfo(com_OrdenPedido_Info _info, Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                info_pedido = _info;
                Accion = _Accion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetAccionInControls()
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.duplicar)
                {
                    CargarCombos();

                    var solicitante = bus_solicitante.GetInfo(param.IdEmpresa, param.IdUsuario);
                    if (solicitante == null)
                        MessageBox.Show("No tiene un usuario solicitante configurado para el módulo de compras, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        if (solicitante.IdDepartamento != null)
                        {
                            cmb_Departamento.Visible = false;
                            lblDepartamento.Visible = false;
                        }
                        else
                        {
                            cmb_Departamento.Visible = true;
                            lblDepartamento.Visible = true;
                        }
                        cmb_Departamento.EditValue = solicitante.IdDepartamento;
                        param.IdSolicitante = solicitante.IdSolicitante;
                    }
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        lbl_IdOrdenPedido.Visible = false;
                        txt_IdOrdenPedido.Visible = false;
                        uc_menu.btnGuardar.Visible = true;
                        uc_menu.btnGuardar_y_Salir.Visible = true;
                        uc_menu.Visible_bntAnular = false;
                        col_Estado.Visible = false;
                        col_Comprador.Visible = false;
                        btnBuscarPlantilla.Text = "Buscar plantilla";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = true;
                        uc_menu.btnGuardar_y_Salir.Visible = true;
                        uc_menu.Visible_bntAnular = false;
                        SetInfoInControls();
                        col_Estado.Visible = true;
                        col_Comprador.Visible = true;
                        btnBuscarPlantilla.Text = "Compradores por familia";
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = true;
                        uc_menu.btnGuardar_y_Salir.Visible = true;
                        uc_menu.Visible_bntAnular = false;
                        SetInfoInControls();
                        col_Estado.Visible = true;
                        col_Comprador.Visible = true;
                        btnBuscarPlantilla.Text = "Compradores por familia";
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        SetAccionInControls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = false;
                        uc_menu.btnGuardar_y_Salir.Visible = false;
                        uc_menu.Visible_bntAnular = true;
                        SetInfoInControls();
                        col_Estado.Visible = true;
                        col_Comprador.Visible = true;
                        btnBuscarPlantilla.Text = "Compradores por familia";
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        lbl_IdOrdenPedido.Visible = true;
                        txt_IdOrdenPedido.Visible = true;
                        uc_menu.btnGuardar.Visible = false;
                        uc_menu.btnGuardar_y_Salir.Visible = false;
                        uc_menu.Visible_bntAnular = false;
                        SetInfoInControls();
                        col_Estado.Visible = true;
                        col_Comprador.Visible = true;
                        btnBuscarPlantilla.Text = "Compradores por familia";
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void SetInfoInControls()
        {
            try
            {
                info_pedido = bus_orden.GetInfo(info_pedido.IdEmpresa, info_pedido.IdOrdenPedido);
                if (info_pedido != null)
                {
                    if (Accion != Cl_Enumeradores.eTipo_action.duplicar)
                    {
                        txt_IdOrdenPedido.Text = info_pedido.IdOrdenPedido.ToString();
                        txt_ObservacionGA.Text = info_pedido.ObservacionGA;
                    }

                    txt_Observacion.Text = info_pedido.op_Observacion;
                    cmb_Departamento.EditValue = info_pedido.IdDepartamento;
                    de_Fecha.DateTime = Accion != Cl_Enumeradores.eTipo_action.duplicar ? info_pedido.op_Fecha.Date : DateTime.Now.Date;
                    txt_codigo.Text = info_pedido.op_Codigo;
                    chk_EsCompraUrgente.Checked = info_pedido.EsCompraUrgente;
                    cmb_PuntoCargoCab.EditValue = info_pedido.IdPunto_cargo;
                    
                    blst_det = new BindingList<com_OrdenPedidoDet_Info>(bus_detalle.GetList(info_pedido.IdEmpresa,info_pedido.IdOrdenPedido));
                    if (Accion == Cl_Enumeradores.eTipo_action.duplicar)
                    {
                        foreach (var item in blst_det)
                        {
                            item.opd_EstadoProceso = "P";
                            item.opd_CantidadApro = 0;
                            item.Adjunto = false;
                            item.NombreArchivo = null;
                        }    
                    }
                    
                    gc_detalle.DataSource = blst_det;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool validar()
        {
            try
            {
                if (param.IdSolicitante == 0)
                {
                    var solicitante = bus_solicitante.GetInfo(param.IdEmpresa, param.IdUsuario);
                    if (solicitante == null)
                    {
                        MessageBox.Show("No tiene un usuario solicitante configurado para el módulo de compras, comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                        param.IdSolicitante = solicitante.IdSolicitante;
                }

                if (de_Fecha.EditValue == null)
                {
                    MessageBox.Show("El campo fecha es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_Departamento.EditValue == null)
                {
                    MessageBox.Show("El campo departamento es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_det.Where(q=> q.opd_Cantidad == 0).Count() > 0)
                {
                    MessageBox.Show("No se puede guardar solicitudes con cantidad 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (blst_det.Where(q => q.IdSucursalDestino == 0).Count() > 0)
                {
                    MessageBox.Show("No se puede guardar solicitudes sin sucursal destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (blst_det.Where(q => q.IdSucursalOrigen == 0).Count() > 0)
                {
                    MessageBox.Show("No se puede guardar solicitudes sin sucursal destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void limpiar()
        {
            try
            {
                info_pedido = new com_OrdenPedido_Info();
                txt_IdOrdenPedido.Text = string.Empty;
                txt_Observacion.Text = string.Empty;
                cmb_Departamento.EditValue = null;
                de_Fecha.DateTime = DateTime.Now.Date;
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_codigo.Text = string.Empty;
                blst_det = new BindingList<com_OrdenPedidoDet_Info>();
                gc_detalle.DataSource = blst_det;
                chk_EsCompraUrgente.Checked = false;
                cmb_PuntoCargoCab.EditValue = null;
                SetAccionInControls();
            }
            catch (Exception)
            {

            }
        }

        private void frmCom_OrdenPedidoMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                de_Fecha.DateTime = DateTime.Now.Date;
                gc_detalle.DataSource = blst_det;
                SetAccionInControls();
                
            }
            catch (Exception)
            {

            }
        }

        public void GetInfo()
        {
            try
            {
                txt_codigo.Focus();
                info_pedido = new com_OrdenPedido_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdOrdenPedido = Accion == Cl_Enumeradores.eTipo_action.grabar ? 0 : Convert.ToDecimal(txt_IdOrdenPedido.Text),
                    IdDepartamento = Convert.ToInt32(cmb_Departamento.EditValue),
                    IdSolicitante = param.IdSolicitante,
                    IdUsuarioCreacion = param.IdUsuario,
                    op_Codigo = txt_codigo.Text,
                    op_Fecha = de_Fecha.DateTime.Date,
                    op_Observacion = txt_Observacion.Text,
                    EsCompraUrgente = chk_EsCompraUrgente.Checked,
                    IdPunto_cargo = cmb_PuntoCargoCab.EditValue == null ? null : (int?)cmb_PuntoCargoCab.EditValue,
                    ListaDetalle = new List<com_OrdenPedidoDet_Info>(blst_det)
                };
            }
            catch (Exception)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void uc_menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                this.Close();
        }

        private void uc_menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                limpiar();
        }

        private void uc_menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (AccionGrabar())
                this.Close();
        }

        private bool AccionGrabar()
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.Anular && !validar())
                {
                    return false;
                }
                GetInfo();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        return Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        return Anular();
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Guardar()
        {
            try
            {
                if (bus_orden.GuardarDB(info_pedido))
                {
                    MessageBox.Show("Orden de pedido # "+info_pedido.IdOrdenPedido.ToString()+" creado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Modificar()
        {
            try
            {
                if (bus_orden.ModificarDB(info_pedido))
                {
                    MessageBox.Show("Orden de pedido # " + info_pedido.IdOrdenPedido.ToString() + " modificado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Anular()
        {
            try
            {
                if (bus_orden.AnularDB(info_pedido))
                {
                    MessageBox.Show("Registro anulado exitósamente");
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void gv_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (col_IdProducto == e.Column)
                {
                    if (row.IdProducto != null)
                    {
                        var producto = Lista_producto.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdProducto == Convert.ToDecimal(row.IdProducto)).FirstOrDefault();
                        if (producto != null)
                        {
                            row.pr_descripcion = producto.pr_descripcion;
                            row.IdUnidadMedida = producto.IdUnidadMedida;
                            row.IdUnidadMedida_Consumo = producto.IdUnidadMedida_Consumo;
                            row.Stock = bus_producto.GetStockProductoPorEmpresa(param.IdEmpresa, Convert.ToDecimal(row.IdProducto));
                        }
                    }
                    else
                    {
                        row.IdUnidadMedida = "UND";
                        row.IdUnidadMedida_Consumo = "UND";
                        row.pr_descripcion = string.Empty;
                        row.Stock = 0;
                    }    
                }

                if (cmb_PuntoCargoCab.EditValue != null)
                    row.IdPunto_cargo = Convert.ToInt32(cmb_PuntoCargoCab.EditValue);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gv_detalle_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            SetEstadoCelda(gv_detalle.FocusedRowHandle);
        }

        private void gv_detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEstadoCelda(e.FocusedRowHandle);
        }

        private void SetEstadoCelda(int RowHandle)
        {
            com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetRow(RowHandle);
            if (row == null)
            {
                col_IdUnidadMedida.OptionsColumn.AllowEdit = true;
                col_pr_descripcion.OptionsColumn.AllowEdit = true;
            }
            else
                if (row.IdProducto == null)
            {
                col_IdUnidadMedida.OptionsColumn.AllowEdit = false;
                col_pr_descripcion.OptionsColumn.AllowEdit = true;
            }else
            if (row.IdProducto != null)
            {
                col_IdUnidadMedida.OptionsColumn.AllowEdit = true;
                col_pr_descripcion.OptionsColumn.AllowEdit = false;
            }
        }

        private void txtStock_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetFocusedRow();
                if(row == null)
                    return;

                if(row.IdProducto == null)
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

        private void gv_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    gv_detalle.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void frmCom_OrdenPedidoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_frmCom_OrdenPedidoMantenimiento_FormClosing(sender, e);
        }

        private void cmb_subir_Click(object sender, EventArgs e)
        {
            try
            {
                com_OrdenPedidoDet_Info row = (com_OrdenPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;
                string filePath = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                    row.NombreArchivo = openFileDialog1.FileName;
                    row.NuevoAdjunto = true;
                    row.Adjunto = true;
                    gc_detalle.RefreshDataSource();
                }
                else
                {
                    return;
                }
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
                if(row.IdProducto == null)
                    e.Appearance.ForeColor = Color.DarkOrange;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnBuscarPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmCom_OrdenPedidoPlantillaAsignar frm = new frmCom_OrdenPedidoPlantillaAsignar();
                    frm.ShowDialog();
                    if (frm.info_plantilla != null && frm.info_plantilla.IdPlantilla > 0)
                    {
                        limpiar();
                        frm.info_plantilla = bus_plantilla.GetInfo(frm.info_plantilla.IdEmpresa, frm.info_plantilla.IdPlantilla);
                        if (frm.info_plantilla != null)
                        {
                            txt_Observacion.Text = frm.info_plantilla.op_Observacion;
                            txt_codigo.Text = frm.info_plantilla.op_Codigo;
                            chk_EsCompraUrgente.Checked = frm.info_plantilla.EsCompraUrgente;
                            cmb_PuntoCargoCab.EditValue = frm.info_plantilla.IdPunto_cargo;
                            blst_det = new BindingList<com_OrdenPedidoDet_Info>(bus_detalle.GetListPlantilla(frm.info_plantilla.IdEmpresa, frm.info_plantilla.IdPlantilla));
                            gc_detalle.DataSource = blst_det;
                        }
                    }
                }
                else
                {
                    FrmCom_OrdenPedidoCompradorFamilia frm = new FrmCom_OrdenPedidoCompradorFamilia();
                    frm.IdOrdenPedido = Convert.ToDecimal(txt_IdOrdenPedido.Text);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
