using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_devol_venta_mant : Form
    {
        #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();

        DataTable TablaProducto = new DataTable("Productos");
        fa_devol_venta_det_Info infoDetDev = new fa_devol_venta_det_Info();
        List<fa_devol_venta_det_Info> ListDev = new List<fa_devol_venta_det_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        DataTable dtGrilla = new DataTable();
        in_producto_Bus BusProducto = new in_producto_Bus();
        fa_factura_Info InfoFac = new fa_factura_Info();
        UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
        UCFa_Cliente_Facturacion UCCliente = new UCFa_Cliente_Facturacion();
        UCGe_NumeroDocTrans UCNumDoc = new UCGe_NumeroDocTrans();

        List<fa_factura_det_info> listDetTabla = new List<fa_factura_det_info>();

        List<fa_factura_det_info> factDet = new List<fa_factura_det_info>();
        fa_devol_venta_Info infoDev = new fa_devol_venta_Info();
        fa_devol_venta_Bus busDev = new fa_devol_venta_Bus();

        fa_devol_venta_det_Bus busDevDet = new fa_devol_venta_det_Bus();

        public fa_devol_venta_Info Info_DevolucionVenta { get; set; }

        fa_factura_Bus busFac = new fa_factura_Bus();
        List<vwFa_FacturasConDevolucionxItemSaldos_Info> listvw = new List<vwFa_FacturasConDevolucionxItemSaldos_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;

        public delegate void Delegate_ultraGrid_KeyPress(object sender, KeyPressEventArgs e);
        public event Delegate_ultraGrid_KeyPress Evente_ultraGrid_KeyPress;
        int IdCaja = 0;
        string msg = "";
        fa_notaCreDeb_Info NDCInfo = new fa_notaCreDeb_Info();
        List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>();
        fa_notaCredDeb_Bus BusBNotaDB = new fa_notaCredDeb_Bus();
        public delegate void Delegate_FrmClose(object sender, FormClosingEventArgs e);
        public event Delegate_FrmClose event_FrmClose;
        public delegate void Delegate_ultraGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e);
        public event Delegate_ultraGrid_PreviewKeyDown Evente_ultraGrid_PreviewKeyDown;
        public decimal IdProducto = 0;
        public Boolean VisibleDescuento { get; set; }
        public Boolean VisiblePorcDescuento { get; set; }
        public Boolean VisiblePeso { get; set; }
        public Boolean ValidaStock { get; set; }
        public Boolean VisibleCosto { get; set; }
        public int idSucursal { get; set; }
        public int idBodega { get; set; }
        public decimal idDev { get; set; }
        public decimal idCliente { get; set; }
        public int idVendedor { get; set; }
        public decimal IdCbteVta { get; set; }

        #endregion

        public frmFa_devol_venta_mant()
        {
            try
            {
                InitializeComponent();
                
                UCSucursal.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(UCSucursal_Event_cmb_bodega_SelectionChangeCommitted);
                UCSucursal.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted);
                                
                event_FrmClose += new Delegate_FrmClose(frmFA_devol_venta_event_FrmClose);
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        void UCSucursal_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_Rpt011_rpt rptSoporte = new XFAC_Rpt011_rpt(param.IdUsuario);
                XFAC_Rpt011_Bus busRpt = new XFAC_Rpt011_Bus();
                List<XFAC_Rpt011_Info> lstRpt = new List<XFAC_Rpt011_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_ImpresionDevolucion(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), Convert.ToDecimal(txtidDev.Text));
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                {
                    this.Close();
                }      

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos();                       
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                if (validarDatos())
                {
                    listDetTabla = new List<fa_factura_det_info>();
                    listDetTabla = get_Tabla_detalle();
                    getCabDev();

                    infoDev.CodDevolucion = txtCodDev.Text;
                    infoDev.totalDev = Convert.ToDouble(this.txtTotal.EditValue);

                    if (busDev.GuardarDB(infoDev, ref msg))
                    {
                        bolResult = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Devolución", infoDev.IdDevolucion);
                        MessageBox.Show(smensaje, param.Nombre_sistema);  

                        if (MessageBox.Show("¿Desea Imprimir?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.ucGe_Menu_event_btnImprimir_Click(null, null);
                        }
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = true;
                    }
                    else
                    {
                        MessageBox.Show("Error " + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                return bolResult;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean validarDatos()
        {
            try
            {
                if (Convert.ToDouble(txtTotalDev.EditValue) <= 0 || txtTotalDev.EditValue == null)
                {
                    MessageBox.Show("El valor de la devolución no puede ser menor igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtObservacion.Text == "" || txtObservacion.Text == null)
                {
                    MessageBox.Show("Ingrese la Observacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue) == 0 || UCSucursal.cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Seleccione la Sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (Convert.ToInt32(UCSucursal.cmb_bodega.EditValue) == 0 || UCSucursal.cmb_bodega.EditValue == null)
                {
                    MessageBox.Show("Seleccione la Bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                if (UCNumDoc.txe_Serie.EditValue == "" || UCNumDoc.txe_Serie.EditValue == null || UCNumDoc.txtNumDoc.Text == "" || UCNumDoc.txtNumDoc.Text == null)
                {
                    MessageBox.Show("Seleccione la Fcatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.FAC, Convert.ToDateTime(dateFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
    
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible) { MessageBox.Show("Devolución # " + txtidDev.Text + " de la Factura # " + UCNumDoc.txtNumDoc.Text + " esta Anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (MessageBox.Show("La Devolución " + txtidDev.Text + "\n" + "¿Desea Continuar?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    frm.ShowDialog();
                    msg = frm.motivoAnulacion;


                    fa_devol_venta_Info infoDev_Vta = new fa_devol_venta_Info();
                    infoDev_Vta = busDev.Get_Info_devol_vent(param.IdEmpresa, idSucursal, idBodega, idDev, ref msg);

                    fa_devol_venta_Bus DevoBus = new fa_devol_venta_Bus();
                    if (DevoBus.AnularDevolucion(infoDev_Vta.IdEmpresa, infoDev_Vta.IdSucursal, infoDev_Vta.IdBodega, infoDev_Vta.IdDevolucion,
                        param.Fecha_Transac, frm.motivoAnulacion, ref msg))
                    {
                        //MessageBox.Show("La Devolución " + txtidDev.Text + " de la Factura " + UCNumDoc.txtNumDoc.Text + " fue Anulada con Exito", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Devolución", txtidDev.Text);
                        MessageBox.Show(smensaje, param.Nombre_sistema);  
                        ucGe_Menu.Visible_bntAnular = false;
                    }
                    else
                        MessageBox.Show("Error al Anular", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmFA_devol_venta_event_FrmClose(object sender, FormClosingEventArgs e){}

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
             _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmFA_devol_venta_Load(object sender, EventArgs e)
        {
            try
            {
                UCCliente.txt_Direccion.Visible = false;
                UCCliente.txt_Ruc.Visible = false;
                UCCliente.txt_Telefonos.Visible = false;
                UCCliente.lbltelefono.Visible = false;
                UCCliente.llblRuc.Visible = false;
                UCCliente.lblDireccion.Visible = false;
                UCCliente.CargarCombos();
                pnlCliente.Controls.Add(UCCliente);

                UCSucursal.Dock = UCCliente.Dock = DockStyle.Fill;

                UCSucursal.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                pnlSucursal.Controls.Add(UCSucursal);
                
                UCNumDoc.btnBuscar.Enabled = false;
                UCNumDoc.txtNumDoc.Properties.ReadOnly = true;
                UCNumDoc.txe_Serie.Properties.ReadOnly = true;
                pnlNumDoc.Controls.Add(UCNumDoc);

                load_Producto();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCCliente.cmb_cliente.Enabled = false;
                        UCCliente.cmb_vendedor.Enabled = false;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        UCNumDoc.txtNumDoc.Enabled = false;
                        this.pnlSucursal.Enabled = false;
                        pnlCliente.Enabled = false;
                        setCabecera(Info_DevolucionVenta);
                        btnConsultar.Enabled = false;
                        txtNumDoc.Enabled = false;
                        btnImportar.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;
                        btnConsultar.Enabled = false;
                        txtNumDoc.Enabled = false;
                        btnImportar.Enabled = false;
                        setCabecera(Info_DevolucionVenta);
                                             

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        #region GRIDPRO



        public List<fa_factura_det_info> get_Tabla_detalle()
        {
            try
            {
                List<fa_factura_det_info> lm = new List<fa_factura_det_info>();

                var s = from q in (List<fa_factura_det_info>)gridDevolucion.DataSource select q;
                foreach (var item in s)
                {
                    fa_factura_det_info info = new fa_factura_det_info();

                    //info.Codigo_Producto = item.Codigo_Producto;
                    //info.Producto = item.Producto;
                    //info.Cantidad = item.Cantidad;
                    //info.Precio = item.Precio;
                    //info.Porc_Descuento = item.Porc_Descuento;
                    //info.Descuento = item.Descuento;
                    //info.PrecioFinal = item.PrecioFinal;
                    //info.Subtotal = item.Subtotal;
                    //info.Iva = item.Iva;
                    //info.Paga_Iva = item.Paga_Iva;
                    //info.Total = item.Total;
                    //info.Costo = item.Costo;
                    //info.IdProducto = item.IdProducto;
                    //info.Cant_Venta = item.Cant_Venta;
                    //info.Cant_Dev = item.Cant_Dev;

                    lm.Add(info);
                }
              
                return lm;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<fa_factura_det_info>();
            }
        }

          
            


       
        #endregion
        
        #region inventario
        in_movi_inve_Bus inBus = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus inBusDet = new in_movi_inve_detalle_Bus();
        in_movi_inve_Info invCabInfo = new in_movi_inve_Info();
        List<in_movi_inve_detalle_Info> invList = new List<in_movi_inve_detalle_Info>();
        fa_parametro_Bus FaPaBus = new fa_parametro_Bus();
        fa_parametro_info inf = new fa_parametro_info();

        public void MoviInventario(fa_devol_venta_Info infoDev)
        {
            try
            {
                invCabInfo = new in_movi_inve_Info();
                invList = new List<in_movi_inve_detalle_Info>();
                invCabInfo.cm_anio = DateTime.Now.Year;
                invCabInfo.IdEmpresa = infoDev.IdEmpresa;
                invCabInfo.IdBodega = infoDev.IdBodega;
                invCabInfo.IdSucursal = infoDev.IdSucursal;
                invCabInfo.IdNumMovi = infoDev.IdDevolucion;
                //invCabInfo.IdCbteCble = infoDev.IdCbteVta;
                
                inf = FaPaBus.Get_Info_parametro(param.IdEmpresa);
                invCabInfo.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta;
                invCabInfo.cm_tipo = "+";
                invCabInfo.CodMoviInven = "DEV" + infoDev.IdDevolucion;
                invCabInfo.cm_observacion = "DEV VTA " + infoDev.IdDevolucion + " A LA FAC # " + UCNumDoc.txtNumDoc.Text + "/" + infoDev.IdCbteVta + " Al Cliente: " + UCCliente.cmb_cliente.Text + " por el monto de: " + txtTotal.EditValue;
                invCabInfo.cm_fecha = infoDev.dv_fecha;
                invCabInfo.cm_anio = infoDev.dv_fecha.Year;
                invCabInfo.cm_mes = infoDev.dv_fecha.Month;
                invCabInfo.Estado = infoDev.Estado;
                invCabInfo.ip = param.ip;
                invCabInfo.IdUsuario = infoDev.IdUsuario;
                invCabInfo.nom_pc = param.nom_pc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void moviDetalle(decimal d, List<fa_devol_venta_det_Info> DevDet)
        {
            try
            {
                int secuencia = 0;
                foreach (var item in DevDet)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.IdNumMovi = d;
                    info.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta;
                    //info.IdNumMovi = item.IdCbteVta;
                    secuencia += 1;
                    info.Secuencia += secuencia;
                    info.mv_tipo_movi = "+";
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = +item.dv_cantidad;
                    info.dm_stock_ante = 0;
                    //info.dm_stock_actu = item.IdSucursal;
                    info.dm_observacion = "DEV VTA " + infoDev.IdDevolucion + " A LA FAC # " + UCNumDoc.txtNumDoc.Text + "/" + infoDev.IdCbteVta + " Al Cliente: " + UCCliente.cmb_cliente.Text + " por el monto de: " + txtTotal.EditValue;
                    info.dm_precio = item.dv_valor;
                    info.mv_costo = item.dv_costo;
                    invList.Add(info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion
        
        public void CalcularTotales()
        {
            try
            {
                listDetTabla = new List<fa_factura_det_info>();
                listDetTabla = get_Tabla_detalle();
                double base0 = 0;
                foreach (var item in listDetTabla)
                {
                   
                    base0 += item.vt_total;                   
                }
                decimal otros;
                otros = Convert.ToDecimal(txtTransporteDev.EditValue) + Convert.ToDecimal(txtInteresDev.EditValue) + Convert.ToDecimal(txtOtroValor1Dev.EditValue) + Convert.ToDecimal(txtOtroValor2Dev.EditValue) + Convert.ToDecimal(txtSeguroDev.EditValue);
                txtTotalDev.EditValue = (decimal)base0 + otros;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        public void convertir_info(List<fa_factura_det_info> listDetTabla)
        {
            try
            {
                ListDev = new List<fa_devol_venta_det_Info>();
                int secuencia = 1;
                foreach (var item in listDetTabla)
                {
                    fa_devol_venta_det_Info info = new fa_devol_venta_det_Info();
                    info.IdProducto = item.IdProducto;
                    info.dv_cantidad = item.Cant_Dev;
                    info.dv_valor = item.vt_Precio;
                    info.dv_PorDescUni = item.vt_PorDescUnitario;
                    info.dv_descUni = item.vt_DescUnitario;
                    info.dv_PrecioFinal = item.vt_PrecioFinal;
                    info.dv_subtotal = item.vt_Subtotal;
                    info.dv_iva = item.vt_iva;
                    //info.dv_costo = item.COS;
                    info.dv_total = item.vt_total;
                    info.Secuencia = secuencia;
                    info.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                    info.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);

                    //if (item.vt_tieneIVA == true)
                    //{
                    //    info.sc_pagaIva = "S";
                    //}
                    //else
                    //{
                    //    info.sc_pagaIva = "N";                   
                    //}            
                   
                    secuencia += 1;
                    info.IdEmpresa = param.IdEmpresa;
                    if (info.dv_cantidad != 0)
                    {
                        ListDev.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                rbIdventa.Checked = true;
                frmFa_Documentos_Consulta frm = new frmFa_Documentos_Consulta();
                frm.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                frm.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                frm.TipoDoc = "FACT";
                frm.Text = frm.Text + " - " + frm.TipoDoc;
                frm.ShowDialog();
                txtNumDoc.Text = frm.Id;
                txtTotal.EditValue = frm.TOTAL;

                UCCliente.cmb_cliente.EditValue = frm.idcliente;
                UCCliente.cmb_vendedor.EditValue = frm.idvendedor;
                btnImportar_Click(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void load_Producto()
        {
            try
            {
                Lista_producto = BusProducto.Get_list_Producto(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue));
                foreach (var item in Lista_producto)
                {
                    item.Disponible = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock) - item.pr_pedidos == null ? 0 : Convert.ToDouble(item.pr_pedidos);
                }
                cmbProducto.DataSource = Lista_producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void convertir_infoDEV(List<fa_devol_venta_det_Info> ListaDev)
        {
            try
            {
                listDetTabla = new List<fa_factura_det_info>();
                foreach (var item in ListaDev)
                {
                    fa_factura_det_info info = new fa_factura_det_info();
                    info.IdProducto = item.IdProducto;
                    //info.Codigo_Producto = BusProducto.Get_Codigo_Producto(param.IdEmpresa, item.IdProducto);
                    //info.Producto = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);
                    //info.IdCotizacion = IdCotizacion;
                    info.vt_cantidad = item.dv_cantidad;
                    //info.Peso = item.dv_Peso;
                    //info.Precio = item.vt_Precio;
                    info.vt_PorDescUnitario = item.dv_PorDescUni;
                    info.vt_DescUnitario = item.dv_descUni;
                    info.vt_PrecioFinal = item.dv_PrecioFinal;
                    info.vt_Subtotal = item.dv_subtotal;
                    info.vt_iva = item.dv_iva;
                    info.vt_total = item.dv_total;
                   // info.vt_tieneIVA = (item.dv_iva >0) ? true : false;
                    
                    listDetTabla.Add(info); //}
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void convertir_infotabla(List<fa_factura_det_info> ListaDetFact)
        {
            try
            {
                listDetTabla = new List<fa_factura_det_info>();
                in_producto_x_tb_bodega_Costo_Historico_Bus BusCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                foreach (var item in ListaDetFact)
                {
                    fa_factura_det_info info = new fa_factura_det_info();
                    in_producto_x_tb_bodega_Costo_Historico_Info InfoCostoHis = new in_producto_x_tb_bodega_Costo_Historico_Info();
                    InfoCostoHis = BusCostoHis.get_UltimoCosto_x_Producto_Bodega(param.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdProducto,infoDev.dv_fecha);
                    info.IdProducto = item.IdProducto;
                    //info.Codigo_Producto = BusProducto.Get_Codigo_Producto(param.IdEmpresa, item.IdProducto);
                    //info.Producto = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);
                    info.vt_cantidad = item.vt_cantidad;
                    //info.Peso = item.vt_Peso;
                    info.vt_Precio = item.vt_Precio;
                    info.vt_PorDescUnitario = item.vt_PorDescUnitario;
                    info.vt_DescUnitario = item.vt_DescUnitario;
                    info.vt_PrecioFinal = item.vt_PrecioFinal;
                    info.vt_Subtotal = item.vt_Subtotal;
                    info.vt_iva = item.vt_iva;
                    //info.Costo = Convert.ToDouble(InfoCostoHis.costo);  
                    info.vt_total = item.vt_total;
                  //  info.vt_tieneIVA = item.vt_tieneIVA;
                    info.vt_detallexItems = item.vt_detallexItems;
                    if (item.vt_cantidad != 0) { listDetTabla.Add(info); }


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setCabecera(fa_devol_venta_Info infoDev2) {
            try
            {
                fa_factura_Bus FacBus = new fa_factura_Bus();
                infoDev = infoDev2;
                txtObservacion.Text = infoDev.dv_Observacion;
                dateFecha.Value = infoDev.dv_fecha;
                UCCliente.cmb_cliente.EditValue = Convert.ToInt32(infoDev.IdCliente);
                UCCliente.cmb_vendedor.EditValue = Convert.ToInt32(infoDev.IdVendedor);
                txtOtroValor1Dev.EditValue = Convert.ToDecimal(infoDev.dv_OtroValor1);
                txtOtroValor2Dev.EditValue = Convert.ToDecimal(infoDev.dv_OtroValor2);
                txtTransporteDev.EditValue = Convert.ToDecimal(infoDev.dv_flete);
                txtInteresDev.EditValue = Convert.ToDecimal(infoDev.dv_interes);
                txtSeguroDev.EditValue = Convert.ToDecimal(infoDev.dv_seguro);
                UCSucursal.cmb_sucursal.EditValue = infoDev.IdSucursal;
                UCSucursal.cmb_bodega.EditValue = infoDev.IdBodega;


                idBodega = infoDev.IdBodega;
                idSucursal = infoDev.IdSucursal;
                idDev = infoDev.IdDevolucion;
                txtidDev.Text = infoDev.IdDevolucion.ToString();
                IdCbteVta = infoDev.IdCbteVta;
                txtCodDev.Text = infoDev.CodDevolucion;
                txtNumDoc.Text = infoDev.IdCbteVta.ToString();
                UCNumDoc.txtNumDoc.Text = infoDev.vt_NumFactura;
                UCNumDoc.txe_Serie.Text = infoDev.vt_serie1 + "-" + infoDev.vt_serie2;
                if (infoDev.Estado == "I") {
                    lblAnulado.Visible = true;
                }
                               
                listvw = busDev.Get_List_Fa_FacturasConDevolucionxItemSaldos(param.IdEmpresa, infoDev.IdSucursal, infoDev.IdBodega, infoDev.IdCbteVta, infoDev.IdDevolucion);
                listDetTabla = new List<fa_factura_det_info>();
                listDetTabla = setVista_TablaPedido(listvw);
                gridDevolucion.DataSource = listDetTabla;
                CalcularTotales();   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                importarDatos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void importarDatos()
        {
            try
            {
                listvw = new List<vwFa_FacturasConDevolucionxItemSaldos_Info>();
                fa_factura_Bus FacBus = new fa_factura_Bus();
                InfoFac = new fa_factura_Info();
                List<fa_factura_det_info> listFac = new List<fa_factura_det_info>();
                InfoFac.IdEmpresa = param.IdEmpresa;
                if (txtNumDoc.Text == "") {
                    MessageBox.Show("Ingrese Numero del Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return;
                }
                InfoFac.IdCbteVta = Convert.ToDecimal(txtNumDoc.Text);
                InfoFac.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                InfoFac.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);

                if(rbNumDoc.Checked==true)
                    InfoFac = FacBus.Get_Info_factura_x_Numero_Factura(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), txtNumDoc.Text);
                else
                    InfoFac = FacBus.Get_Info_factura(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), Convert.ToDecimal(txtNumDoc.Text));
                    txtObservacion.Text = InfoFac.vt_Observacion;
                    UCNumDoc.txe_Serie.EditValue = InfoFac.vt_serie1 + "-" + InfoFac.vt_serie2;
                    UCNumDoc.txtNumDoc.Text = InfoFac.vt_NumFactura;
                    UCCliente.cmb_cliente.EditValue = InfoFac.IdCliente;
                    UCCliente.cmb_vendedor.EditValue = InfoFac.IdVendedor;

                    txtInteres.EditValue = Convert.ToDecimal(InfoFac.vt_interes);
                    txtTransporte.EditValue = Convert.ToDecimal(InfoFac.vt_flete);
                    txtOtro1.EditValue = Convert.ToDecimal(InfoFac.vt_OtroValor1);
                    txtOtro2.EditValue = Convert.ToDecimal(InfoFac.vt_OtroValor2);
                    txtSeguro.EditValue = Convert.ToDecimal(InfoFac.vt_seguro);
                    txtTotal.EditValue = Convert.ToDecimal(InfoFac.Total + InfoFac.vt_interes + InfoFac.vt_flete + InfoFac.vt_OtroValor1 + InfoFac.vt_OtroValor2 + InfoFac.vt_seguro);

                    listvw = busDev.Get_List_Fa_FacturasConDevolucionxItemSaldos(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), InfoFac.IdCbteVta);
                    listDetTabla = new List<fa_factura_det_info>();
                    listDetTabla = setVista_TablaPedido(listvw);
                    gridDevolucion.DataSource = listDetTabla;

                    if (listDetTabla.Count() == 0)
                    {
                        MessageBox.Show("Factura No tiene Items o ya se Realizo la Devolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiar();
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = this.ucGe_Menu.Visible_btnGuardar = pnlSucursal.Enabled = false;
                    }
                    else
                    {
                        gridDevolucion.DataSource = listDetTabla;
                        txtNumDoc.Enabled = false;
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = this.ucGe_Menu.Visible_btnGuardar = true;
                        pnlSucursal.Enabled = false;
                    }

                    IdCaja = Convert.ToInt32(InfoFac.IdCaja);
               // }
                //else {
                //    limpiar();
               //     MessageBox.Show("Ya se Realizo una Devolucion a esta Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // }
            }
            catch (Exception ex )
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private List<fa_factura_det_info> setVista_TablaPedido(List<vwFa_FacturasConDevolucionxItemSaldos_Info> listvw)
        {
            try
            {
                List<fa_factura_det_info> lstTablaInfo = new List<fa_factura_det_info>();
                foreach (var item in listvw)
                {
                    fa_factura_det_info info = new fa_factura_det_info();

                    //info.Codigo_Producto = item.IdProducto.ToString();
                    info.IdProducto =  item.IdProducto;
                    info.vt_cantidad = item.vt_cantidad;
                    info.vt_Precio = item.vt_Precio;
                    info.vt_PorDescUnitario = item.vt_PorDesc;
                    info.vt_DescUnitario = item.vt_DescUni;
                    info.vt_PrecioFinal = item.vt_PrecioFinal;

                   // info.vt_tieneIVA = (item.vt_tieneIVA == "S") ? true : false;
                    
                    info.IdProducto = item.IdProducto;
                    info.Cant_Venta = item.dv_saldo;

                    if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                    {
                        info.Cant_Dev = 0;
                        info.vt_Subtotal = 0;
                        info.vt_iva = 0;
                        info.vt_total = 0;
                    }
                    else {
                        info.Cant_Dev = item.dv_cantidad;
                        info.vt_Subtotal = (item.dv_cantidad == 0) ? 0 : item.dv_cantidad * item.vt_Precio;
                        info.vt_iva = (item.dv_cantidad == 0) ? 0 : info.vt_Subtotal * (param.iva.porcentaje / 100);
                        info.vt_total = (item.dv_cantidad == 0) ? 0 : info.vt_Subtotal + info.vt_iva;
                    }

                    lstTablaInfo.Add(info);
                }
                CalcularTotales();
                return lstTablaInfo;
            }
            catch (Exception ex)
            {
                return new List<fa_factura_det_info>();
            }
        }

        private void chbTodaVenta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbTodaVenta.Checked)
                {
                    foreach (var item in listDetTabla)
                    {
                        item.Cant_Dev = item.Cant_Venta;
                        item.vt_Subtotal = (item.Cant_Venta * item.vt_Precio);
                        //if (item.vt_tieneIVA==true)
                        //    item.vt_iva = item.vt_Subtotal * (param.iva / 100);
                        //else
                        //    item.vt_iva = 0;
                        item.vt_total = item.vt_Subtotal + item.vt_iva;
                    }                    
                    colCant_Dev.OptionsColumn.ReadOnly = true;
                    
                    txtOtroValor1Dev.EditValue = txtOtro1.EditValue;
                    txtOtroValor2Dev.EditValue = txtOtro2.EditValue;
                    txtTransporteDev.EditValue = txtTransporte.EditValue;
                    txtInteresDev.EditValue = txtInteres.EditValue;
                    txtSeguroDev.EditValue = txtSeguro.EditValue;
                }
                else {                    
                    foreach (var item in listDetTabla)
                    {
                        item.Cant_Dev = 0;
                        item.vt_Subtotal = 0;         
                        item.vt_total = 0;
                    }
                    colCant_Dev.OptionsColumn.ReadOnly = false;

                    txtOtroValor1Dev.EditValue = 0;
                    txtOtroValor2Dev.EditValue = 0;
                    txtTransporteDev.EditValue = 0;
                    txtInteresDev.EditValue = 0;
                    txtSeguroDev.EditValue = 0;
                }

                gridDevolucion.DataSource = listDetTabla;
                gridDevolucion.RefreshDataSource();
                CalcularTotales();

             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void getCabDev()
        {
            try
            {
                getNotaDC();
                
                infoDev = new fa_devol_venta_Info();
                infoDev.IdEmpresa = param.IdEmpresa;
                infoDev.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                infoDev.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                infoDev.IdCliente = Convert.ToInt32(UCCliente.cmb_cliente.EditValue);
                infoDev.IdVendedor = Convert.ToInt32(UCCliente.cmb_vendedor.EditValue);
                infoDev.IdCbteVta = Convert.ToDecimal(txtNumDoc.Text);
                infoDev.dv_fecha = dateFecha.Value;
                infoDev.Estado = "A";
                infoDev.dv_OtroValor1 = Convert.ToDouble(txtOtro1.EditValue);
                infoDev.dv_OtroValor2 = Convert.ToDouble(txtOtro2.EditValue);
                infoDev.dv_interes = Convert.ToDouble(txtInteres.EditValue);
                infoDev.dv_flete = Convert.ToDouble(txtTransporte.EditValue);
                infoDev.dv_seguro = Convert.ToDouble(txtSeguro.EditValue);
                infoDev.dv_Observacion = txtObservacion.Text;
                infoDev.IdUsuario =param.IdUsuario;


               //campos NotaCreDeb
                infoDev.InfoNotaCreDeb.IdEmpresa = infoDev.IdEmpresa;
                infoDev.InfoNotaCreDeb.IdSucursal = infoDev.IdSucursal;
                infoDev.InfoNotaCreDeb.IdBodega = infoDev.IdBodega;
                infoDev.InfoNotaCreDeb.IdCliente = infoDev.IdCliente;
                infoDev.InfoNotaCreDeb.IdVendedor = infoDev.IdVendedor;
                infoDev.InfoNotaCreDeb.CodNota = NDCInfo.CodNota;
                infoDev.InfoNotaCreDeb.CreDeb = NDCInfo.CreDeb;
                infoDev.InfoNotaCreDeb.no_fecha = NDCInfo.no_fecha;
                infoDev.InfoNotaCreDeb.no_fecha_venc = NDCInfo.no_fecha_venc;
                infoDev.InfoNotaCreDeb.nom_pc = NDCInfo.nom_pc;
                infoDev.InfoNotaCreDeb.ip = NDCInfo.ip;           
                infoDev.InfoNotaCreDeb.sc_observacion = NDCInfo.sc_observacion;
                infoDev.InfoNotaCreDeb.NumNota_Impresa = NDCInfo.NumNota_Impresa;
                infoDev.InfoNotaCreDeb.NaturalezaNota = NDCInfo.NaturalezaNota;
                infoDev.InfoNotaCreDeb.no_dev_venta = NDCInfo.no_dev_venta;
                infoDev.InfoNotaCreDeb.IdTipoNota = NDCInfo.IdTipoNota;
                infoDev.InfoNotaCreDeb.sc_observacion = NDCInfo.sc_observacion;
                infoDev.InfoNotaCreDeb.sc_usuario = NDCInfo.sc_usuario;
                infoDev.InfoNotaCreDeb.IdUsuarioUltAnu = NDCInfo.IdUsuarioUltAnu;
                infoDev.InfoNotaCreDeb.Estado = NDCInfo.Estado;
                infoDev.InfoNotaCreDeb.IdDevolucion = NDCInfo.IdDevolucion;
                infoDev.InfoNotaCreDeb.interes = NDCInfo.interes;
                infoDev.InfoNotaCreDeb.valor1 = NDCInfo.valor1;
                infoDev.InfoNotaCreDeb.valor2 = NDCInfo.valor2;
                infoDev.InfoNotaCreDeb.flete = NDCInfo.flete;
                infoDev.InfoNotaCreDeb.dv_fecha = NDCInfo.dv_fecha;
                infoDev.InfoNotaCreDeb.IdUsuario = NDCInfo.IdUsuario;
                infoDev.InfoNotaCreDeb.IdCaja = NDCInfo.IdCaja;
                infoDev.InfoNotaCreDeb.CodDevolucion = NDCInfo.CodDevolucion;

                infoDev.InfoNotaCreDeb.ListaDetalles.Clear();
                infoDev.InfoNotaCreDeb.ListaDetalles = NDCInfo.ListaDetalles;
                //campos NotaCreDeb
              
                convertir_info(listDetTabla);

                infoDev.DetalleDeVta = ListDev;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        private void getNotaDC() {
            try
            {
                inf = FaPaBus.Get_Info_parametro(param.IdEmpresa);
                NDCInfo = new fa_notaCreDeb_Info();
                NDCInfo.CodNota = "";

                NDCInfo.IdEmpresa = param.IdEmpresa;
                NDCInfo.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                NDCInfo.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                NDCInfo.IdCliente = Convert.ToInt32(UCCliente.cmb_cliente.EditValue);
                NDCInfo.IdVendedor = Convert.ToInt32(UCCliente.cmb_vendedor.EditValue);
                NDCInfo.sc_observacion = txtObservacion.Text;

                NDCInfo.ip = param.ip;
                NDCInfo.nom_pc = param.nom_pc;
            
                NDCInfo.NumNota_Impresa = "";
              
                NDCInfo.NaturalezaNota = "INT";
                NDCInfo.no_dev_venta = "";
                NDCInfo.CreDeb = "C";
                NDCInfo.no_fecha =Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_fecha_venc = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_dev_venta = "";
                
                NDCInfo.IdTipoNota = inf.Tipo_NC_x_DevVta;
                NDCInfo.sc_observacion = "NCRE # " + invCabInfo.cm_observacion;
                NDCInfo.sc_usuario = param.IdUsuario;

                NDCInfo.IdUsuarioUltAnu = "";                  
                NDCInfo.Estado = "A";                                        
                NDCInfo.IdDevolucion = null;             
                NDCInfo.nom_pc = param.nom_pc;
                NDCInfo.ip = param.ip;

                NDCInfo.interes = Convert.ToDouble(txtInteresDev.EditValue);
                NDCInfo.valor1 = Convert.ToDouble(txtOtroValor1Dev.EditValue);
                NDCInfo.valor2 = Convert.ToDouble(txtOtroValor2Dev.EditValue);
                NDCInfo.flete = Convert.ToDouble(txtTransporte.EditValue);

                NDCInfo.dv_fecha = dateFecha.Value;
                NDCInfo.IdUsuario = param.IdUsuario;

                NDCInfo.IdCaja = IdCaja;
                NDCInfo.CodDevolucion = txtCodDev.Text;

                getNotaDCDetalle();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
        
        private void getNotaDCDetalle()
        {
            try
            {
                listDetTabla = get_Tabla_detalle();
                ListaNDC = new List<fa_notaCreDeb_det_Info>();
                int secuencia=1;
                foreach (var item in listDetTabla)
                {
                    fa_notaCreDeb_det_Info ListaNDCInfo = new fa_notaCreDeb_det_Info();
                    if (item.Cant_Dev > 0)
                    {
                        ListaNDCInfo.IdEmpresa = param.IdEmpresa;
                        ListaNDCInfo.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                        ListaNDCInfo.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                        ListaNDCInfo.IdProducto = item.IdProducto;
                        ListaNDCInfo.pr_descripcion = "";
                        ListaNDCInfo.sc_cantidad = item.Cant_Dev;
                        //ListaNDCInfo.sc_costo = item.cos;
                        ListaNDCInfo.sc_estado = "A";
                        ListaNDCInfo.sc_observacion = "";
                        ListaNDCInfo.sc_iva = item.vt_iva;
                     //   ListaNDCInfo.sc_pagaIva = (item.vt_tieneIVA) == true ? "S" : "N";
                        ListaNDCInfo.sc_descUni = item.vt_DescUnitario;
                        ListaNDCInfo.sc_PordescUni = item.vt_PorDescUnitario;
                        ListaNDCInfo.sc_Precio = item.vt_Precio;
                        ListaNDCInfo.sc_precioFinal = item.vt_PrecioFinal;
                        ListaNDCInfo.sc_subtotal = item.vt_Subtotal;
                        ListaNDCInfo.sc_total = item.vt_total;
                        ListaNDCInfo.Secuencia = secuencia;
                        secuencia += 1;
                        ListaNDC.Add(ListaNDCInfo);
                    }
                }
                NDCInfo.ListaDetalles.Clear();
                NDCInfo.ListaDetalles = ListaNDC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }    

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)102)
                {
                    btnConsultar_Click(new object(), new EventArgs());
                }
                if (e.KeyChar == (Char)13)
                { btnImportar_Click(new object(),new EventArgs());}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void limpiar()
        {
            try
            {
                txtOtro1.EditValue = txtOtro2.EditValue = txtSeguro.EditValue = txtInteres.EditValue = txtTransporte.EditValue = txtOtroValor1Dev.EditValue = txtOtroValor2Dev.EditValue = txtSeguroDev.EditValue = txtInteresDev.EditValue = txtTransporteDev.EditValue = txtTotal.EditValue = txtTotalDev.EditValue = 0;
                pnlSucursal.Enabled = true;
                txtNumDoc.Enabled = true;
                chbTodaVenta.Checked = false;
                txtObservacion.Text = "";

                UCNumDoc.txe_Serie.EditValue = "";
                UCNumDoc.txtNumDoc.Text = "";
                UCCliente.cmb_cliente.EditValue = 0;
                UCCliente.cmb_vendedor.EditValue = 0;
                txtInteres.EditValue = 0;
                txtTotal.EditValue = 0;

                gridDevolucion.DataSource = null;
                gridDevolucion.RefreshDataSource();
                txtidDev.Text = "";
                this.ucGe_Menu.Visible_bntGuardar_y_Salir = this.ucGe_Menu.Visible_btnGuardar = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private void frmFA_devol_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 frmFA_devol_venta_event_FrmClose(sender, e);
                event_FrmClose(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
   
        }

        #region devolucion anular

        public void MoviInventarioAnul(fa_devol_venta_Info infoDev)
        {
            try
            {
                invCabInfo = new in_movi_inve_Info();
                invList = new List<in_movi_inve_detalle_Info>();
                invCabInfo.cm_anio = DateTime.Now.Year;
                invCabInfo.IdEmpresa = infoDev.IdEmpresa;
                invCabInfo.IdBodega = infoDev.IdBodega;
                invCabInfo.IdSucursal = infoDev.IdSucursal;
                invCabInfo.IdNumMovi = infoDev.IdDevolucion;
                //invCabInfo.IdCbteCble = IdCbteVta;

                inf = FaPaBus.Get_Info_parametro(param.IdEmpresa);
                invCabInfo.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                invCabInfo.cm_tipo = "-";
                invCabInfo.CodMoviInven = "DEVANUL" + IdCbteVta;
                invCabInfo.cm_observacion = "DEV ANUL VTA " + idDev + " A LA FAC #" + UCNumDoc.txtNumDoc.Text + "/" + infoDev.IdCbteVta + "Al Cliente: " + UCCliente.cmb_cliente.Text + " por el monto de: " + txtTotal.EditValue;

                invCabInfo.cm_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                invCabInfo.cm_anio = DateTime.Now.Year;
                invCabInfo.cm_mes = DateTime.Now.Month;
                invCabInfo.Estado = "A";
                invCabInfo.ip = param.ip;
                invCabInfo.IdUsuario = param.IdUsuario;
                invCabInfo.nom_pc = param.nom_pc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void moviDetalleAnul(decimal d, List<fa_devol_venta_det_Info> DevDet)
        {
            try
            {
                int secuencia = 0;
                foreach (var item in DevDet)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.IdNumMovi = d;
                    info.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                    //info.IdNumMovi = item.IdCbteVta;
                    secuencia += 1;
                    info.Secuencia += secuencia;
                    info.mv_tipo_movi = "-";
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = -item.dv_cantidad;
                    info.dm_stock_ante = 0;
                    //info.dm_stock_actu = item.IdSucursal;
                    info.dm_observacion = "Anulacion" + infoDev.IdDevolucion.ToString();
                    info.dm_precio = item.dv_valor;
                    info.mv_costo = item.dv_costo;
                    invList.Add(info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion

        private void btnAnular_Click(object sender, EventArgs e) { }

        private void btnImprimir_Click(object sender, EventArgs e) { }

        private void rbNumDoc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumDoc.Enabled == true)
                {
                    txtNumDoc.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void rbNumDoc_Validating(object sender, CancelEventArgs e){}

        private void gridViewDevolucionFact_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double Subtotal = 0;
                double valorIva = 0;
                if (e.Column.Name == "colCant_Dev" && Convert.ToDecimal(gridViewDevolucionFact.GetFocusedRowCellValue(colCant_Dev)) > Convert.ToDecimal(gridViewDevolucionFact.GetFocusedRowCellValue(colCant_Venta)))
                {
                    MessageBox.Show("La cantidad a devolver es mayor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewDevolucionFact.SetFocusedRowCellValue(colCant_Dev, 0);
                }
                else {

                    if (e.Column.Name == "colCant_Dev")
                    {
                        Subtotal = Convert.ToDouble(gridViewDevolucionFact.GetFocusedRowCellValue(colPrecio)) * Convert.ToDouble(gridViewDevolucionFact.GetFocusedRowCellValue(colCant_Dev));
                        gridViewDevolucionFact.SetFocusedRowCellValue(colSubtotal, Subtotal);

                        if (Convert.ToBoolean(gridViewDevolucionFact.GetFocusedRowCellValue(colPaga_Iva)))
                        {
                            valorIva = Subtotal * (param.iva.porcentaje / 100);
                            gridViewDevolucionFact.SetFocusedRowCellValue(colIva, valorIva);
                        }

                        gridViewDevolucionFact.SetFocusedRowCellValue(colTotal, valorIva + Subtotal);
                    }
                }       
              
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}
