using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Business.Compras;
using Cus.Erp.Reports.Naturisa.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_TransferenciaConGuiaMantenimiento : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        tb_sis_Log_Error_Vzen_Bus busLogError;
        in_transferencia_bus busTransferencia;
        in_producto_Bus busProducto;
        tb_Sucursal_Bus busSucursal;
        tb_Bodega_Bus busBodega;
        in_UnidadMedida_Bus busUnidadMedida;
        List<tb_Bodega_Info> lstBodega;
        List<tb_Sucursal_Info> lstSucursal;
        BindingList<in_transferencia_det_Info> blstDetalle;
        Cl_Enumeradores.eTipo_action Accion;
        in_transferencia_Info infoTransferencia;
        in_Guia_x_traspaso_bodega_Bus busGuia;
        in_Transferencia_det_Bus busDet;
        in_Parametro_Bus busParam;
        in_Parametro_Info infoParam;
        List<in_Producto_Info> lstProducto;
        in_Ing_Egr_Inven_Bus busIngEgr;
        com_OrdenPedido_Bus busPedido;
        List<in_transferencia_det_Info> lstOCDet;
        tb_transportista_Bus busTransportista;
        List<tb_transportista_Info> lstTransportista;
        in_Catalogo_Bus busCatalogo;
        #endregion

        #region Delegados
        public delegate void delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed;
        void FrmIn_TransferenciaConGuiaMantenimiento_event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FrmIn_TransferenciaConGuiaMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed(sender, e);
        }
        #endregion

        public FrmIn_TransferenciaConGuiaMantenimiento()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            busLogError = new tb_sis_Log_Error_Vzen_Bus();
            busTransferencia = new in_transferencia_bus();
            busProducto = new in_producto_Bus();
            busSucursal = new tb_Sucursal_Bus();
            busBodega = new tb_Bodega_Bus();
            busUnidadMedida = new in_UnidadMedida_Bus();
            lstBodega = new List<tb_Bodega_Info>();
            lstSucursal = new List<tb_Sucursal_Info>();
            blstDetalle = new BindingList<in_transferencia_det_Info>();
            infoTransferencia = new in_transferencia_Info();
            busDet = new in_Transferencia_det_Bus();
            event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed += FrmIn_TransferenciaConGuiaMantenimiento_event_delegate_FrmIn_TransferenciaConGuiaMantenimiento_FormClosed;
            busParam = new in_Parametro_Bus();
            infoParam = new in_Parametro_Info();
            lstProducto = new List<in_Producto_Info>();
            busIngEgr = new in_Ing_Egr_Inven_Bus();
            busPedido = new com_OrdenPedido_Bus();
            lstOCDet = new List<in_transferencia_det_Info>();
            busTransportista = new tb_transportista_Bus();
            lstTransportista = new List<tb_transportista_Info>();
            busCatalogo = new in_Catalogo_Bus();
            busGuia = new in_Guia_x_traspaso_bodega_Bus();
        }

        private void CargarCombos()
        {
            try
            {
                btnConsultarIngreso.Visible = true;
                btnConsultarEgreso.Visible = true;
                deFecha.EditValue = DateTime.Now.Date;
                lstSucursal = busSucursal.Get_List_Sucursal(param.IdEmpresa);
                lstBodega = busBodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal);
                if (Accion == Cl_Enumeradores.eTipo_action.grabar || Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    cmbProducto.DataSource = lstProducto = busProducto.GetListProductoCombo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV);    
                }
                
                cmbUnidadMedida.DataSource = busUnidadMedida.Get_list_UnidadMedida();

                cmbSucursalOrigen.Properties.DataSource = lstSucursal;
                cmbSucursalDestino.Properties.DataSource = lstSucursal;
                cmbSucursalOC.Properties.DataSource = lstSucursal;

                cmbSucursalOrigen.EditValue = param.IdSucursal;
                cmbSucursalOC.EditValue = param.IdSucursal;
                infoParam = busParam.Get_Info_Parametro(param.IdEmpresa);
                lstTransportista = busTransportista.Get_List_transportista(param.IdEmpresa);
                cmbTransportista.Properties.DataSource = lstTransportista;

                cmbMotivo.Properties.DataSource = busCatalogo.Get_List_Catalogo(3);
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion, in_transferencia_Info _info)
        {
            Accion = _Accion;
            infoTransferencia = Accion == Cl_Enumeradores.eTipo_action.grabar ? new in_transferencia_Info() : _info;
        }

        private void SetAccionInControls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucgeMenu.btnGuardar.Visible = true;
                        ucgeMenu.btnGuardar_y_Salir.Visible = true;
                        ucgeMenu.btnAnular.Visible = false;
                        ucgeMenu.btnImprimir.Visible = false;
                        btnConsultarIngreso.Visible = false;
                        btnConsultarEgreso.Visible = false;
                        colCantidadPreDespacho.VisibleIndex = -1;
                        colCantidadAprobada.VisibleIndex = -2;
                        colDiferencia.VisibleIndex = -3;
                        colMotivoParcial.VisibleIndex = -4;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucgeMenu.btnGuardar.Visible = true;
                        ucgeMenu.btnGuardar_y_Salir.Visible = true;
                        ucgeMenu.btnAnular.Visible = false;
                        ucgeMenu.btnImprimir.Visible = true;
                        SetInfoInControls();
                        colCantidadPreDespacho.VisibleIndex = -1;
                        colCantidadAprobada.VisibleIndex = -2;
                        colDiferencia.VisibleIndex = -3;
                        colMotivoParcial.VisibleIndex = -4;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucgeMenu.btnGuardar.Visible = false;
                        ucgeMenu.btnGuardar_y_Salir.Visible = false;
                        ucgeMenu.btnAnular.Visible = true;
                        ucgeMenu.btnImprimir.Visible = true;
                        SetInfoInControls();
                        colCantidadPreDespacho.VisibleIndex = -1;
                        colCantidadAprobada.VisibleIndex = -2;
                        colDiferencia.VisibleIndex = -3;
                        colMotivoParcial.VisibleIndex = -4;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucgeMenu.btnGuardar.Visible = false;
                        ucgeMenu.btnGuardar_y_Salir.Visible = false;
                        ucgeMenu.btnAnular.Visible = false;
                        ucgeMenu.btnImprimir.Visible = true;
                        SetInfoInControls();
                        colCantidadPreDespacho.VisibleIndex = 4;
                        colCantidadAprobada.VisibleIndex = 5;
                        colDiferencia.VisibleIndex = 6;
                        colMotivoParcial.VisibleIndex = 7;
                        break;
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInfoInControls()
        {
            try
            {
                infoTransferencia = busTransferencia.Get_Info_transferencia(param.IdEmpresa, infoTransferencia.IdSucursalOrigen, infoTransferencia.IdBodegaOrigen, infoTransferencia.IdTransferencia);
                if (infoTransferencia == null)
                    return;
                blstDetalle = new BindingList<in_transferencia_det_Info>(busDet.GetList(infoTransferencia.IdEmpresa, infoTransferencia.IdSucursalOrigen, infoTransferencia.IdBodegaOrigen, infoTransferencia.IdTransferencia));
                gcDetalle.DataSource = blstDetalle;
                txtIdTransferencia.Text = infoTransferencia.IdTransferencia.ToString();
                txtObservacion.Text = infoTransferencia.tr_Observacion;
                cmbSucursalOrigen.Properties.ReadOnly = true;
                cmbBodegaOrigen.Properties.ReadOnly = true;                
                cmbSucursalOrigen.EditValue = infoTransferencia.IdSucursal_Ing_Egr_Inven_Origen;
                cmbSucursalDestino.EditValue = infoTransferencia.IdSucursal_Ing_Egr_Inven_Destino;
                deFecha.DateTime = infoTransferencia.tr_fecha;
                if (infoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino != null)
                {
                    cmbSucursalDestino.Properties.ReadOnly = true;
                    cmbBodegaDestino.Properties.ReadOnly = true;
                }
                cmbBodegaOrigen.EditValue = infoTransferencia.IdBodegaOrigen;
                cmbBodegaDestino.EditValue = infoTransferencia.IdBodegaDest;

                if (infoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino == null)
                    btnConsultarIngreso.Visible = false;
                    
                if (infoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen == null)
                    btnConsultarEgreso.Visible = false;

                txtIdNumMoviDestino.Text = Convert.ToString(infoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino ?? 0);
                txtIdNumMoviOrigen.Text = Convert.ToString(infoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen ?? 0);

                lstOCDet = blstDetalle.Where(q => q.IdOrdenCompra != null).ToList();

                if (infoTransferencia.IdGuia != null)
                {
                    chkGenerarGuia.Checked = true;
                    chkGenerarGuia.Properties.ReadOnly = true;
                    var guia = busGuia.Get_Info_x_in_Guia(param.IdEmpresa, infoTransferencia.IdGuia ?? 0);
                    if (guia != null)
                    {
                        txtDireccionOrigen.Text = guia.Direc_sucu_Partida;
                        txtDireccionDestino.Text = guia.Direc_sucu_Llegada;
                        txtIdentificacion.Text = guia.IdentificacionDestinatario;
                        txtDestinatario.Text = guia.NombreDestinatario;
                        cmbTransportista.EditValue = guia.IdTransportista;
                        txtPlaca.Text = guia.Placa;
                        cmbMotivo.EditValue = guia.IdMotivo_Traslado;
                        txtNumGuia.Text = guia.NumDocumento_Guia;
                        txtIdGuia.Text = guia.IdGuia.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            Accion = Cl_Enumeradores.eTipo_action.grabar;
            blstDetalle = new BindingList<in_transferencia_det_Info>();
            gcDetalle.DataSource = blstDetalle;
            txtIdTransferencia.Text = string.Empty;
            txtObservacion.Text = string.Empty;
            cmbSucursalOrigen.EditValue = null;
            cmbSucursalDestino.EditValue = null;
            cmbBodegaOrigen.EditValue = null;
            cmbBodegaDestino.EditValue = null;
            SetAccionInControls();

            cmbSucursalDestino.Properties.ReadOnly = false;
            cmbSucursalOrigen.Properties.ReadOnly = false;
            cmbBodegaDestino.Properties.ReadOnly = false;
            cmbBodegaOrigen.Properties.ReadOnly = false;

            txtIdNumMoviDestino.Text = string.Empty;
            txtIdNumMoviOrigen.Text = string.Empty;

            chkGenerarGuia.Checked = false;
            chkGenerarGuia.Properties.ReadOnly = false;
            chkEnviarGuiaTrue.Checked = true;
            txtDireccionOrigen.Text = string.Empty;
            txtDireccionDestino.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDestinatario.Text = string.Empty;
            cmbTransportista.EditValue = null;
            txtPlaca.Text = string.Empty;
            cmbMotivo.EditValue = null;
            txtNumGuia.Text = string.Empty;
            txtIdGuia.Text = string.Empty;
        }

        private void GetInfo()
        {
            try
            {
                infoTransferencia = new in_transferencia_Info
                {
                    IdEmpresa = param.IdEmpresa,
                    IdSucursalOrigen = Convert.ToInt32(cmbSucursalOrigen.EditValue),
                    IdBodegaOrigen = Convert.ToInt32(cmbBodegaOrigen.EditValue),
                    IdTransferencia = Convert.ToDecimal(string.IsNullOrEmpty(txtIdTransferencia.Text) ? "0" : txtIdTransferencia.Text),
                    
                    IdEmpresa_Ing_Egr_Inven_Origen = param.IdEmpresa,
                    IdSucursal_Ing_Egr_Inven_Origen = Convert.ToInt32(cmbSucursalOrigen.EditValue),
                    IdMovi_inven_tipo_SucuOrig = infoParam.IdMovi_inven_tipo_egresoBodegaOrigen ?? 0,
                    IdNumMovi_Ing_Egr_Inven_Origen = infoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen,

                    IdEmpresa_Ing_Egr_Inven_Destino = param.IdEmpresa,
                    IdSucursal_Ing_Egr_Inven_Destino = Convert.ToInt32(cmbSucursalDestino.EditValue),
                    IdMovi_inven_tipo_SucuDest = infoParam.IdMovi_inven_tipo_ingresoBodegaDestino ?? 0,
                    IdNumMovi_Ing_Egr_Inven_Destino = infoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino,

                    IdSucursalDest = Convert.ToInt32(cmbSucursalDestino.EditValue),
                    IdBodegaDest = Convert.ToInt32(cmbBodegaDestino.EditValue),
                    IdUsuario = param.IdUsuario,
                    tr_Observacion = txtObservacion.Text,
                    tr_fecha = deFecha.DateTime.Date,
                    lista_detalle_transferencia = new List<in_transferencia_det_Info>(blstDetalle)
                };

                if (chkGenerarGuia.Checked)
                {
                    infoTransferencia.InfoGuia = new in_Guia_x_traspaso_bodega_Info
                    {
                        IdEmpresa = param.IdEmpresa,
                        IdGuia = string.IsNullOrEmpty(txtIdGuia.Text) ? 0 : Convert.ToDecimal(txtIdGuia.EditValue),
                        IdSucursal_Partida = infoTransferencia.IdSucursalOrigen,
                        IdSucursal_Llegada = infoTransferencia.IdSucursalDest,
                        Direc_sucu_Partida = txtDireccionOrigen.Text,
                        Direc_sucu_Llegada = txtDireccionDestino.Text,
                        IdTransportista = Convert.ToInt32(cmbTransportista.EditValue),
                        Fecha = infoTransferencia.tr_fecha,
                        Fecha_Traslado = infoTransferencia.tr_fecha,
                        Fecha_llegada = infoTransferencia.tr_fecha,
                        IdMotivo_Traslado = cmbMotivo.EditValue.ToString(),
                        IdUsuario = param.IdUsuario,

                        CodDocumentoTipo = "GUIA",
                        IdEstablecimiento = string.IsNullOrEmpty(txtSerie1.Text) ? "001" : txtSerie1.Text,
                        IdPuntoEmision = string.IsNullOrEmpty(txtSerie2.Text) ? "001" : txtSerie2.Text,
                        NumDocumento_Guia = txtNumGuia.Text,
                        NombreDestinatario = txtDestinatario.Text,
                        IdentificacionDestinatario = txtIdentificacion.Text,
                        Placa = txtPlaca.Text
                    };
                }                
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            try
            {
                txtIdNumMoviDestino.Focus();
                gvDetalle.MoveNext();
                if (cmbSucursalOrigen.EditValue == null)
                {
                    MessageBox.Show("El campo sucursal origen es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;    
                }

                if (cmbBodegaOrigen.EditValue == null)
                {
                    MessageBox.Show("El campo bodega origen es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbSucursalDestino.EditValue == null)
                {
                    MessageBox.Show("El campo sucursal destino es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbBodegaDestino.EditValue == null)
                {
                    MessageBox.Show("El campo bodega destino es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blstDetalle.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un producto a ser transferido", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                foreach (var item in blstDetalle)
                {
                    if (item.dt_cantidad == 0)
                    {
                        MessageBox.Show("No se ha ingresado la cantidad a transferir para el producto: " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (string.IsNullOrEmpty(item.IdUnidadMedida))
                    {
                        MessageBox.Show("No se ha ingresado la unidad de medida para el producto: " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (string.IsNullOrEmpty(item.pr_descripcion))
                    {
                        MessageBox.Show("Existen productos sin descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (chkGenerarGuia.Checked)
                {
                    if (blstDetalle.Where(q=> q.EnviarEnGuia == true).Count() == 0)
                    {
                        MessageBox.Show("No ha seleccionado productos para enviar en la guia", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txtDireccionOrigen.Text))
                    {
                        MessageBox.Show("El campo punto de partida es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txtDireccionDestino.Text))
                    {
                        MessageBox.Show("El campo punto de llegada es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txtIdentificacion.Text))
                    {
                        MessageBox.Show("El campo identifiación es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txtDestinatario.Text))
                    {
                        MessageBox.Show("El campo destinatario es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (cmbTransportista.EditValue == null)
                    {
                        MessageBox.Show("El campo transportista es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (string.IsNullOrEmpty(txtPlaca.Text))
                    {
                        MessageBox.Show("El campo placa es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (cmbMotivo.EditValue == null)
                    {
                        MessageBox.Show("El campo motivo es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if (infoParam.Maneja_Stock_Negativo == "N")
                {
                    #region ValidarStock
                    /*
                    var lst = blstDetalle.Where(Q => Q.IdProducto != null).GroupBy(q => new { q.IdProducto, q.pr_descripcion }).Select(Q => new
                    {
                        IdProducto = Q.Key.IdProducto,
                        pr_descripcion = Q.Key.pr_descripcion,
                        Cantidad = Q.Sum(q => q.dt_cantidad),
                        CantidadAnterior = Q.Sum(q => q.CantidadAnterior)
                    });
                    */
                    var lst = blstDetalle.Where(Q => Q.IdProducto != null).GroupBy(q => new {q.IdProducto, q.pr_descripcion, q.IdUnidadMedida }).Select(Q => new
                    {
                        IdProducto = Q.Key.IdProducto,
                        pr_descripcion = Q.Key.pr_descripcion,
                        Cantidad = busUnidadMedida.GetCantidadConvertida(param.IdEmpresa, Q.Key.IdProducto ?? 0, Q.Key.IdUnidadMedida, Q.Sum(q => q.dt_cantidad)),
                        CantidadAnterior = busUnidadMedida.GetCantidadConvertida(param.IdEmpresa, Q.Key.IdProducto ?? 0, Q.Key.IdUnidadMedida, Q.Sum(q => q.CantidadAnterior))
                    });

                    lst = lst.Where(Q => Q.IdProducto != null).GroupBy(q => new { q.IdProducto, q.pr_descripcion }).Select(Q => new
                    {
                        IdProducto = Q.Key.IdProducto,
                        pr_descripcion = Q.Key.pr_descripcion,
                        Cantidad = Q.Sum(q => q.Cantidad),
                        CantidadAnterior = Q.Sum(q => q.CantidadAnterior)
                    });

                    foreach (var item in lst)
                    {
                        if (!busProducto.ValidarStock(param.IdEmpresa, Convert.ToInt32(cmbSucursalOrigen.EditValue), Convert.ToInt32(cmbBodegaOrigen.EditValue), item.IdProducto ?? 0, item.Cantidad, item.CantidadAnterior))
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + " no tiene stock suficiente para la transferencia.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    #endregion
                }
                

                return true;
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool AccionGrabar()
        {
            try
            {
                bool Res = false;
                string mensaje = "Registro {0} exitósamente";
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (!Validar())
                            return false;
                        GetInfo();
                        Res = busTransferencia.Guardar(infoTransferencia);
                        mensaje = mensaje.Replace("{0}","guardado");
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (!Validar())
                            return false;
                        GetInfo();
                        Res = busTransferencia.Modificar(infoTransferencia);
                        mensaje = mensaje.Replace("{0}", "actualizado");
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        infoTransferencia.IdUsuario = param.IdUsuario;
                        Res = busTransferencia.AnularDB(infoTransferencia);
                        mensaje = mensaje.Replace("{0}", "anulado");
                        break;
                }
                if (Res)
                {
                    var lstoc = infoTransferencia.lista_detalle_transferencia.Where(q => q.IdOrdenCompra != null).ToList();
                    foreach (var item in lstOCDet)
                    {
                        if (lstoc.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal_oc == item.IdSucursal_oc && q.IdOrdenCompra == item.IdOrdenCompra && q.Secuencia_oc == item.Secuencia_oc).Count() == 0)
                            lstoc.Add(item);
                    }
                    foreach (var OCD in lstoc)
                    {
                        busPedido.ValidarProceso(OCD.IdEmpresa, OCD.IdSucursal_oc ?? 0, OCD.IdOrdenCompra ?? 0, OCD.Secuencia_oc ?? 0);
                    }

                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    if (Accion != Cl_Enumeradores.eTipo_action.Anular && MessageBox.Show("Desea imprimir la transferencia?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }
                }else
                    MessageBox.Show("No se ha podido completar la transacción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return Res;
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmIn_TransferenciaConGuiaMantenimiento_Load(object sender, EventArgs e)
        {
            CargarCombos();
            gcDetalle.DataSource = blstDetalle;
            SetAccionInControls();
        }

        private void cmbSucursalOrigen_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var lstBodegaTmp = new List<tb_Bodega_Info>();
                if (cmbSucursalOrigen.EditValue != null)
                {
                    lstBodegaTmp = lstBodega.Where(q => q.IdSucursal == Convert.ToInt32(cmbSucursalOrigen.EditValue)).ToList();
                    var sucursal = lstSucursal.Where(q => q.IdSucursal == Convert.ToInt32(cmbSucursalOrigen.EditValue)).FirstOrDefault();
                    if (sucursal != null)
                        txtDireccionOrigen.Text = sucursal.Su_Direccion;

                }else
                    txtDireccionOrigen.Text = string.Empty;
                cmbBodegaOrigen.Properties.DataSource = lstBodegaTmp;
                cmbBodegaOrigen.EditValue = null;
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSucursalDestino_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var lstBodegaTmp = new List<tb_Bodega_Info>();
                if (cmbSucursalDestino.EditValue != null)
                {
                    lstBodegaTmp = lstBodega.Where(q => q.IdSucursal == Convert.ToInt32(cmbSucursalDestino.EditValue)).ToList();
                    var sucursal = lstSucursal.Where(q => q.IdSucursal == Convert.ToInt32(cmbSucursalDestino.EditValue)).FirstOrDefault();
                    if (sucursal != null)
                    {
                        txtDireccionDestino.Text = sucursal.Su_Direccion;
                        txtIdentificacion.Text = param.InfoEmpresa.em_ruc;
                        txtDestinatario.Text = sucursal.Su_Descripcion;
                    }
                }
                else
                {
                    txtDireccionDestino.Text = string.Empty;
                    txtIdentificacion.Text = string.Empty;
                    txtDestinatario.Text = string.Empty;
                }
                cmbBodegaDestino.Properties.DataSource = lstBodegaTmp;
                cmbBodegaDestino.EditValue = null;
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucgeMenu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ucgeMenu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucgeMenu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionGrabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucgeMenu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionGrabar())
                {
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucgeMenu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccionGrabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucgeMenu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void ImprimirRide()
        {
            try
            {
                XINV_Rpt030_rpt rpt = new XINV_Rpt030_rpt();
                rpt.pIdSucursal.Value = infoTransferencia.IdSucursalOrigen;
                rpt.pIdBodega.Value = infoTransferencia.IdBodegaOrigen;
                rpt.pIdTransferencia.Value = infoTransferencia.IdTransferencia;
                rpt.ShowPreviewDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Imprimir()
        {
            try
            {
                XINV_Rpt017_Rpt Reporte = new XINV_Rpt017_Rpt();
                Reporte.P_IdSucursal_origen.Value = infoTransferencia.IdSucursalOrigen;
                Reporte.P_IdBodega_origen.Value = infoTransferencia.IdBodegaOrigen;
                Reporte.P_IdTransferencia.Value = infoTransferencia.IdTransferencia;

                Reporte.RequestParameters = false;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreviewDialog();

                if (infoTransferencia.IdGuia != null && infoTransferencia.IdGuia != 0 && MessageBox.Show("Desea imprimir la guia?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XINV_NAT_Rpt001_Rpt Rpt = new XINV_NAT_Rpt001_Rpt();
                    Rpt.PIdEmpresa.Value = param.IdEmpresa;
                    Rpt.PIdGuia.Value = infoTransferencia.IdGuia ?? 0;

                    Rpt.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool ptg = new DevExpress.XtraReports.UI.ReportPrintTool(Rpt);
                    ptg.AutoShowParametersPanel = false;

                    Rpt.ShowPreviewDialog();

                    ImprimirRide();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdNumMoviOrigen.Text == "0" || txtIdNumMoviOrigen.Text == "")
                {
                    MessageBox.Show("Esta transferencia no tiene un egreso relacionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int IdSucursal = Convert.ToInt32(cmbSucursalOrigen.EditValue);
                int IdBodega = Convert.ToInt32(cmbBodegaOrigen.EditValue);
                int IdMovi_inven_tipo = infoParam.IdMovi_inven_tipo_egresoBodegaOrigen ?? 0;
                decimal IdNumMovi = Convert.ToDecimal(txtIdNumMoviOrigen.Text);
                var info_egr = busIngEgr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                if (info_egr.IdEmpresa != 0)
                {
                    FrmIn_Egresos_Varios_Mant frm = new FrmIn_Egresos_Varios_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.setInfo_(info_egr);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdNumMoviDestino.Text == "0" || txtIdNumMoviDestino.Text == "")
                {
                    MessageBox.Show("Esta transferencia no tiene un ingreso relacionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int IdSucursal = Convert.ToInt32(cmbSucursalDestino.EditValue);
                int IdBodega = Convert.ToInt32(cmbBodegaDestino.EditValue);
                int IdMovi_inven_tipo = infoParam.IdMovi_inven_tipo_ingresoBodegaDestino ?? 0;
                decimal IdNumMovi = Convert.ToDecimal(txtIdNumMoviDestino.Text);

                var info_ing = busIngEgr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                if (info_ing.IdEmpresa != 0)
                {
                    FrmIn_Ingreso_varios_Mant frm = new FrmIn_Ingreso_varios_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.setInfo(info_ing);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_transferencia_det_Info row = (in_transferencia_det_Info)gvDetalle.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == colIdProducto)
                {
                    if (row.IdProducto != null)
                    {
                        var producto = lstProducto.Where(q => q.IdProducto == row.IdProducto).FirstOrDefault();
                        if (producto != null)
                        {
                            row.IdUnidadMedida = producto.IdUnidadMedida_Consumo;
                            row.pr_descripcion = producto.pr_descripcion;
                        }
                    }
                    else
                    {
                        row.IdUnidadMedida = "UND";                        
                        row.pr_descripcion = string.Empty;                        
                    }
                }

                if (e.Column == colNomProducto)
                {
                    row.IdUnidadMedida = "UND";
                }

                if (e.Column != colChecked && chkEnviarGuiaTrue.Checked)
                    row.EnviarEnGuia = true;
                
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvDetalle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetEstadoCelda(e.FocusedRowHandle);
        }

        private void SetEstadoCelda(int RowHandle)
        {
            in_transferencia_det_Info row = (in_transferencia_det_Info)gvDetalle.GetRow(RowHandle);
            if (row == null)
            {
                colUnidadMedida.OptionsColumn.AllowEdit = true;
                colNomProducto.OptionsColumn.AllowEdit = true;
            }
            else
                if (row.IdProducto == null)
                {
                    colUnidadMedida.OptionsColumn.AllowEdit = true;
                    colNomProducto.OptionsColumn.AllowEdit = true;
                }
                else
                    if (row.IdProducto != null)
                    {
                        colUnidadMedida.OptionsColumn.AllowEdit = false;
                        colNomProducto.OptionsColumn.AllowEdit = false;
                    }
        }

        private void gvDetalle_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            SetEstadoCelda(gvDetalle.FocusedRowHandle);
        }

        private void gvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    gvDetalle.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportarOC_Click(object sender, EventArgs e)
        {
            if (cmbSucursalOC.EditValue == null)
            {
                MessageBox.Show("El campo sucursal orden de compra es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtOC.Text))
            {
                MessageBox.Show("El campo orden de compra es obligatorio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal IdOrdenCompra = 0;
            try
            {
                IdOrdenCompra = Convert.ToDecimal(string.IsNullOrEmpty(txtOC.Text) ? "0" : txtOC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un # de orden de compra correcto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var lst = busDet.GetList(param.IdEmpresa,Convert.ToInt32(cmbSucursalOC.EditValue),IdOrdenCompra);

            foreach (var item in lst)
            {
                if (blstDetalle.Where(q => q.IdSucursal_oc == item.IdSucursal_oc && q.IdOrdenCompra == item.IdOrdenCompra && q.Secuencia_oc == item.Secuencia_oc).Count() == 0)
                {
                    item.EnviarEnGuia = chkEnviarGuiaTrue.Checked;
                    blstDetalle.Add(item);
                }
            }
        }

        private void cmbTransportista_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTransportista.EditValue != null)
                {
                    var transportista = lstTransportista.Where(q => q.IdTransportista == Convert.ToInt32(cmbTransportista.EditValue)).FirstOrDefault();
                    if (transportista != null)
                        txtPlaca.Text = transportista.Placa;
                }else
                    txtPlaca.Text = null;
            }
            catch (Exception ex)
            {
                busLogError.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkGenerarGuia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGenerarGuia.Checked)
                pnlGuia.Visible = true;
            else
                pnlGuia.Visible = true;
        }
    }
}
