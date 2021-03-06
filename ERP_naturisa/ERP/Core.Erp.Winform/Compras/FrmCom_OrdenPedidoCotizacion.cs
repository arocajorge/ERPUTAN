﻿using System;
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
    using Core.Erp.Winform.Contabilidad;
    using System.IO;
    using System.Diagnostics;
    
    public partial class FrmCom_OrdenPedidoCotizacion : Form
    {
        #region Variables
        BindingList<com_CotizacionPedidoDet_Info> blst;
        ct_punto_cargo_Bus bus_punto_cargo;
        com_CotizacionPedido_Bus bus_cotizacion;
        com_CotizacionPedidoDet_Bus bus_det;
        cp_proveedor_Bus bus_proveedor;
        tb_Sucursal_Bus bus_sucursal;
        cl_parametrosGenerales_Bus param;
        in_UnidadMedida_Bus bus_unidad;
        tb_sis_impuesto_Bus bus_impuesto;
        List<tb_sis_impuesto_Info> lst_impuesto;
        com_TerminoPago_Bus bus_termino;
        List<com_CotizacionPedido_Info> lst_info;
        List<tb_Sucursal_Info> lst_sucursal;
        List<cp_proveedor_combo_Info> lst_proveedor;
        List<com_TerminoPago_Info> lst_termino;
        com_OrdenPedidoDet_Bus bus_pedido_det;
        Funciones Fx;
        com_parametro_Info com_param;
        com_parametro_Bus bus_param;
        #endregion

        #region Constructor
        public FrmCom_OrdenPedidoCotizacion()
        {
            blst = new BindingList<com_CotizacionPedidoDet_Info>();
            bus_punto_cargo = new ct_punto_cargo_Bus();
            bus_cotizacion = new com_CotizacionPedido_Bus();
            bus_det = new com_CotizacionPedidoDet_Bus();
            bus_proveedor = new cp_proveedor_Bus();
            bus_sucursal = new tb_Sucursal_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_unidad = new in_UnidadMedida_Bus();
            bus_impuesto = new tb_sis_impuesto_Bus();
            lst_impuesto = new List<tb_sis_impuesto_Info>();
            bus_termino = new com_TerminoPago_Bus();
            lst_info = new List<com_CotizacionPedido_Info>();
            lst_sucursal = new List<tb_Sucursal_Info>();
            lst_proveedor = new List<cp_proveedor_combo_Info>();
            lst_termino = new List<com_TerminoPago_Info>();
            bus_pedido_det = new com_OrdenPedidoDet_Bus();
            Fx = new Funciones();
            com_param = new com_parametro_Info();
            bus_param = new com_parametro_Bus();
            InitializeComponent();
        }
        #endregion

        private void CargarCombos()
        {
            try
            {
                cmb_PuntoCargo.DataSource = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_SucursalDestino.DataSource = lst_sucursal;
                cmb_SucursalOrdigen.DataSource = lst_sucursal;
                cmb_UnidadMedida.DataSource = bus_unidad.Get_list_UnidadMedida();
                
                lst_proveedor = bus_proveedor.GetListCombo(param.IdEmpresa);
                cmb_proveedor.DataSource = lst_proveedor;

                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto.DataSource = lst_impuesto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar()
        {
            try
            {
                blst = new BindingList<com_CotizacionPedidoDet_Info>(bus_det.GetListCotizacion(param.IdEmpresa, param.IdUsuario,de_Desde.DateTime,de_Hasta.DateTime,chk_MostrarAR.Checked));
                gc_detalle.DataSource = blst;
            }
            catch (Exception)
            {
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmCom_OrdenPedidoCotizacion_Load(object sender, EventArgs e)
        {
            de_Desde.DateTime = DateTime.Now.Date.AddMonths(-1);
            de_Hasta.DateTime = DateTime.Now.Date;
            ucGe_Menu_Superior_Mant1.btnAnular.Text = "Rechazar";
            ucGe_Menu_Superior_Mant1.btnAprobar.Text = "Cotizar";
            ucGe_Menu_Superior_Mant1.btnAprobarGuardarSalir.Text = "Cotizar y salir";
            com_param = bus_param.Get_Info_parametro(param.IdEmpresa);
            CargarCombos();
        }

        private void gv_detalle_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_A)
                {
                    row.R = false;
                }
                if (e.Column == col_R)
                {
                    row.A = false;
                }
                if (e.Column == col_cd_Cantidad || e.Column == col_cd_porc_des || e.Column == col_cd_precioCompr || e.Column == col_IdProveedor)
                {
                    if (Convert.ToDouble(e.Value ?? 0) > 0)
                    {
                        row.A = true;
                    }
                }
                
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
                
                if (e.Column == col_cd_Cantidad || e.Column == col_cd_porc_des || e.Column == col_cd_precioCompr || e.Column == col_IVA)
                {
                    row.cd_descuento = row.cd_precioCompra * (row.cd_porc_des / 100);
                    row.cd_precioFinal = row.cd_precioCompra - row.cd_descuento;
                    row.cd_subtotal = row.cd_Cantidad * row.cd_precioFinal;
                    
                    var impuesto = lst_impuesto.Where(q => q.IdCod_Impuesto == row.IdCod_Impuesto).FirstOrDefault();
                    if (impuesto != null)
                        row.Por_Iva = impuesto.porcentaje;
                    else
                        row.Por_Iva = 0;

                    row.cd_iva = row.cd_subtotal * (row.Por_Iva / 100);
                    row.cd_total = row.cd_subtotal + row.cd_iva;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void txtStock_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdProducto == null)
                    return;

                FrmIn_ProductoPorBodegaStock frm = new FrmIn_ProductoPorBodegaStock();
                frm._IdProducto = row.IdProducto ?? 0;
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool GetInfo()
        {
            btn_Buscar.Focus();
            lst_info = new List<com_CotizacionPedido_Info>();
            var lst = blst.Where(q => q.A == true && q.opd_EstadoProceso == "A").ToList();

            if (lst.Count == 0)
            {
                MessageBox.Show("Seleccione registros para cotizar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (lst.Where(q=> q.IdProducto == null || q.IdProveedor == null || q.cd_precioCompra == 0 || string.IsNullOrEmpty(q.IdUnidadMedida) || string.IsNullOrEmpty(q.IdCod_Impuesto)).Count() > 0)
            {
                MessageBox.Show("La información de la cotización se encuentra incompleta, por favor revise los registros seleccionados",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            var lstProvDep = lst.GroupBy(q => new { q.IdProveedor, q.IdDepartamento, q.IdSolicitante, q.IdSucursalOrigen, q.IdComprador, q.opd_IdOrdenPedido, q.IdSucursalDestino }).Select(q => new
            {
                q.Key.IdSolicitante,
                q.Key.IdDepartamento,
                q.Key.IdProveedor,
                q.Key.IdSucursalOrigen,
                q.Key.IdComprador,
                q.Key.opd_IdOrdenPedido,
                q.Key.IdSucursalDestino
            }).ToList();
            lst_termino = bus_termino.Get_List_TerminoPago().Where(q=> q.Estado == "A").ToList();
            
            foreach (var item in lstProvDep)
            {
                var proveedor = bus_proveedor.Get_Info_Proveedor(param.IdEmpresa, item.IdProveedor ?? 0);
                if (proveedor == null)
                    return false;
                var Pedido = blst.Where(q => q.opd_IdOrdenPedido == item.opd_IdOrdenPedido).FirstOrDefault();
                string Observacion = (Pedido != null ? Pedido.op_Observacion : string.Empty);
                com_CotizacionPedido_Info cab = new com_CotizacionPedido_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdSucursal = item.IdSucursalOrigen,
                    IdProveedor = item.IdProveedor ?? 0,                    
                    cp_Fecha = DateTime.Now.Date,
                    cp_Observacion = Observacion,
                    IdDepartamento = item.IdDepartamento,
                    IdSolicitante = item.IdSolicitante,
                    IdComprador = item.IdComprador,
                    IdTerminoPago = (proveedor.pr_plazo ?? 0) == 0 ? "1" : lst_termino.Where(q => q.Dias == (proveedor.pr_plazo ?? 0)).FirstOrDefault() == null ? "1" : lst_termino.Where(q => q.Dias == (proveedor.pr_plazo ?? 0)).FirstOrDefault().IdTerminoPago,
                    cp_Plazo = proveedor.pr_plazo ?? 0,
                    pe_correo = proveedor.Persona_Info.pe_correo_secundario1,
                    IdPersona = proveedor.IdPersona,
                    
                    IdOrdenPedido = item.opd_IdOrdenPedido,
                    ListaDetalle = new List<com_CotizacionPedidoDet_Info>()
                };

                cab.ListaDetalle = lst.Where(q => q.IdProveedor == item.IdProveedor && q.IdDepartamento == item.IdDepartamento && q.IdSolicitante == item.IdSolicitante && q.IdSucursalOrigen == item.IdSucursalOrigen && q.opd_IdOrdenPedido == item.opd_IdOrdenPedido && q.IdSucursalDestino == item.IdSucursalDestino).Select(q=> new com_CotizacionPedidoDet_Info{
                    IdEmpresa = param.IdEmpresa,
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
                    cd_DetallePorItem = q.cd_DetallePorItem,
                    IdSucursalDestino = q.IdSucursalDestino,
                    IdSucursalOrigen = q.IdSucursalOrigen,
                    NombreArchivoC = q.NombreArchivoC,
                    AdjuntoC = q.AdjuntoC
                }).ToList();
                cab.Subtotal = cab.ListaDetalle.Sum(q => q.cd_subtotal);
                cab.IVA = cab.ListaDetalle.Sum(q => q.cd_iva);
                cab.Total = cab.ListaDetalle.Sum(q => q.cd_total);
                lst_info.Add(cab);
            }
            return true;
        }

        private void Anular()
        {
            try
            {
                btn_Buscar.Focus();
                var lst = blst.Where(q => q.R == true && q.opd_EstadoProceso == "A").Select(q => new com_OrdenPedidoDet_Info
                {
                    IdEmpresa = q.IdEmpresa,
                    IdOrdenPedido = q.opd_IdOrdenPedido,
                    Secuencia = q.opd_Secuencia,
                    opd_Detalle = q.cd_DetallePorItem
                }).ToList();

                bus_pedido_det.RechazarComprador(lst);
            }
            catch (Exception)
            {

            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                if (lst_info.Count > 0)
                {
                    FrmCom_OrdenPedidoCotizacionConfirma frm = new FrmCom_OrdenPedidoCotizacionConfirma();
                    frm.lst_proveedor = lst_proveedor;
                    frm.lst_sucursal = lst_sucursal;
                    frm.lst_termino = lst_termino;
                    frm.blst = new BindingList<com_CotizacionPedido_Info>(lst_info);
                    frm.ShowDialog();    
                }
                Buscar();
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            if (GetInfo())
            {
                if (lst_info.Count > 0)
                {
                    FrmCom_OrdenPedidoCotizacionConfirma frm = new FrmCom_OrdenPedidoCotizacionConfirma();
                    frm.lst_proveedor = lst_proveedor;
                    frm.lst_sucursal = lst_sucursal;
                    frm.lst_termino = lst_termino;
                    frm.blst = new BindingList<com_CotizacionPedido_Info>(lst_info);
                    frm.ShowDialog();
                }
                Buscar();
            }
        }

        private void txtProducto_DoubleClick(object sender, EventArgs e)
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

                    var det = frm.info;
                    if (det != null && det.IdProveedor != 0)
                    {
                        row.A = true;
                        row.IdProveedor = det.IdProveedor;
                        row.cd_precioCompra = det.do_precioCompra;
                        row.cd_porc_des = det.do_porc_des;
                        row.cd_descuento = det.do_descuento;
                        row.cd_precioFinal = det.do_precioFinal;

                        row.cd_subtotal = row.cd_Cantidad * row.cd_precioFinal;

                        var impuesto = lst_impuesto.Where(q => q.IdCod_Impuesto == row.IdCod_Impuesto).FirstOrDefault();
                        if (impuesto != null)
                            row.Por_Iva = impuesto.porcentaje;
                        else
                            row.Por_Iva = 0;

                        row.cd_iva = row.cd_subtotal * (row.Por_Iva / 100);
                        row.cd_total = row.cd_subtotal + row.cd_iva;
                    }
                    gc_detalle.RefreshDataSource();
                    btn_Buscar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error comuníquese con sistemas, Error:"+ex.Message);
            }
        }

        private void gv_detalle_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (row.IdProducto == null)
                    e.Appearance.ForeColor = Color.DarkOrange;
                if(row.Grupo == "5. RECHAZADO")
                    e.Appearance.ForeColor = Color.DarkRed;
                if (row.Grupo == "4. APROBADOS")
                    e.Appearance.ForeColor = Color.DarkGreen;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void cmb_selec_Click(object sender, EventArgs e)
        {
            com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
            if (row == null)
                return;

            if (row.Add == false)
                return;

            FrmIn_ProductoSeleccionar frmProduC = new FrmIn_ProductoSeleccionar();
            frmProduC.ShowDialog();
            var infoP = frmProduC.info;
            if (infoP != null)
            {
                if (infoP.IdProducto != 0)
                {
                    row.IdProducto = infoP.IdProducto;
                    row.pr_descripcion = infoP.pr_descripcion;
                    row.IdUnidadMedida = infoP.IdUnidadMedida;
                    row.IdUnidadMedida_Consumo = infoP.IdUnidadMedida_Consumo;
                    row.IdCod_Impuesto = infoP.IdCod_Impuesto_Iva;
                    row.Add = false;
                    row.Selec = false;

                    bus_pedido_det.ActualizarProducto(row.opd_IdEmpresa, row.opd_IdOrdenPedido, row.opd_Secuencia, row.IdProducto ?? 0, row.IdUnidadMedida, row.pr_descripcion);

                    gc_detalle.RefreshDataSource();
                    btn_Buscar.Focus();
                }
            }
        }

        private void cmb_add_Click(object sender, EventArgs e)
        {
            com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
            if (row == null)
                return;

            if (row.Add == false)
                return;

            FrmIn_Producto_Mant frmManProd = new FrmIn_Producto_Mant();
            frmManProd.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
            frmManProd.ShowDialog();
            var infoP = frmManProd.Get_producto();
            if (infoP != null)
            {
                if (infoP.IdProducto != 0)
                {
                    row.IdProducto = infoP.IdProducto;
                    row.pr_descripcion = infoP.pr_descripcion;
                    row.IdUnidadMedida = infoP.IdUnidadMedida;
                    row.IdUnidadMedida_Consumo = infoP.IdUnidadMedida_Consumo;
                    row.IdCod_Impuesto = infoP.IdCod_Impuesto_Iva;
                    row.Add = false;
                    row.Selec = false;

                    bus_pedido_det.ActualizarProducto(row.opd_IdEmpresa, row.opd_IdOrdenPedido, row.opd_Secuencia, row.IdProducto ?? 0, row.IdUnidadMedida, row.pr_descripcion);

                    gc_detalle.RefreshDataSource();
                    btn_Buscar.Focus();
                }
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
            Buscar();
        }

        private void cmb_addPC_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;
                
                frmCon_Punto_Cargo_Mant frm = new frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frm.event_frmCon_Punto_Cargo_Mant_FormClosing += frm_event_frmCon_Punto_Cargo_Mant_FormClosing;
                frm.ShowDialog();
                if(frm.IdPuntoCargo > 0)
                    row.IdPunto_cargo = frm.IdPuntoCargo;

                gc_detalle.RefreshDataSource();

            }
            catch (Exception)
            {
                
            }
        }

        void frm_event_frmCon_Punto_Cargo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cmb_PuntoCargo.DataSource = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
            }
            catch (Exception)
            {
                
            }
        }

        private void gv_detalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;
                if (row.opd_EstadoProceso != "A")
                {
                    col_A.OptionsColumn.AllowEdit = false;
                    col_R.OptionsColumn.AllowEdit = false;
                    col_pr_descripcion.OptionsColumn.AllowFocus = false;
                }
                else
                {
                    col_A.OptionsColumn.AllowEdit = true;
                    col_R.OptionsColumn.AllowEdit = true;
                    col_pr_descripcion.OptionsColumn.AllowFocus = true;
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gv_detalle.ShowPrintPreview();
            }
            catch (Exception)
            {
                
            }
        }

        private void cmb_adjunto_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;
                
                if (!row.Adjunto)
                    return;

                string Comando = "/c Net Use " + com_param.FileDominio + " /USER:" + com_param.FileUsuario + " " + com_param.FileContrasenia;
                Fx.ExecuteCommand(@"" + Comando);

                var ruta = com_param.UbicacionArchivosPedido + @"\" + row.opd_IdOrdenPedido.ToString()+@"\"+row.NombreArchivo;
                Process.Start(@"" + ruta);
                
                Comando = "/c Net Use /DELETE " + com_param.FileDominio + " /USER:" + com_param.FileUsuario + " " + com_param.FileContrasenia;
                Fx.ExecuteCommand(@"" + Comando);
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no se encuentra en el servidor",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void txtIdOrdenPedido_Click(object sender, EventArgs e)
        {
           
        }

        private void txtIdOrdenPedido_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                FrmCom_OrdenPedidoCompradorFamilia frm = new FrmCom_OrdenPedidoCompradorFamilia();
                frm.IdOrdenPedido = row.opd_IdOrdenPedido;
                frm.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void cmbRegularizacion_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                if (row.IdOrdenPedidoReg == null)
                    return;

                var det = bus_det.GetInfoDetRegularizacion(row.IdEmpresa, row.IdOrdenPedidoReg ?? 0, row.SecuenciaReg ?? 0);
                if (det != null)
                {
                    row.A = true;
                    row.IdProveedor = det.IdProveedor;
                    row.cd_precioCompra = det.cd_precioCompra;
                    row.cd_porc_des = det.cd_porc_des;
                    row.cd_descuento = det.cd_descuento;
                    row.cd_precioFinal = det.cd_precioFinal;
                    row.IdCod_Impuesto = det.IdCod_Impuesto;

                    row.cd_subtotal = row.cd_Cantidad * row.cd_precioFinal;

                    var impuesto = lst_impuesto.Where(q => q.IdCod_Impuesto == det.IdCod_Impuesto).FirstOrDefault();
                    if (impuesto != null)
                        row.Por_Iva = impuesto.porcentaje;
                    else
                        row.Por_Iva = 0;

                    row.cd_iva = row.cd_subtotal * (row.Por_Iva / 100);
                    row.cd_total = row.cd_subtotal + row.cd_iva;

                    gc_detalle.RefreshDataSource();
                    btn_Buscar.Focus();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmb_adjuntar_Click(object sender, EventArgs e)
        {
            try
            {
                com_CotizacionPedidoDet_Info row = (com_CotizacionPedidoDet_Info)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;
                string filePath = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                    row.NombreArchivoC = openFileDialog1.FileName;
                    row.AdjuntoC = true;
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
    }
}
