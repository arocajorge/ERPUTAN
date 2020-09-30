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
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_TransferenciaConGuiaRevisionM : Form
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
        public delegate void delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed;
        void FrmIn_TransferenciaConGuiaRevisionM_event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FrmIn_TransferenciaConGuiaRevisionM_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed(sender, e);
        }
        #endregion

        public FrmIn_TransferenciaConGuiaRevisionM()
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
            event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed += FrmIn_TransferenciaConGuiaRevisionM_event_delegate_FrmIn_TransferenciaConGuiaRevisionM_FormClosed;
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

                cmbSucursalOrigen.Properties.DataSource = lstSucursal;
                cmbSucursalDestino.Properties.DataSource = lstSucursal;

                cmbSucursalOrigen.EditValue = param.IdSucursal;
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
                    case Cl_Enumeradores.eTipo_action.consultar:
                        SetInfoInControls();
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

        private void FrmIn_TransferenciaConGuiaRevisionM_Load(object sender, EventArgs e)
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

        private void ucgeMenu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucgeMenu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
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

        private void ucgeMenu_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdTransferencia.Focus();
                gvDetalle.MoveNext();
                GetInfo();
                if (infoTransferencia.lista_detalle_transferencia.Where(q=> q.dt_cantidadPreDespacho < q.dt_cantidad).Count() > 0)
                {
                    MessageBox.Show("Existen cantidades de despacho superiores a las transferidas", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                infoTransferencia.EstadoRevision = "A";
                if (busTransferencia.Revisar(infoTransferencia))
                {
                    MessageBox.Show("Transferencia aprobada exitósamente", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (!string.IsNullOrEmpty(txtIdGuia.Text) && txtIdGuia.Text != "0")
                        ImprimirRide();
                    
                    this.Close();
                }
                else
                    MessageBox.Show("No se pudo aprobar la transferencia", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ImprimirRide()
        {
            try
            {
                XINV_Rpt030_rpt rpt = new XINV_Rpt030_rpt();
                rpt.pIdSucursal.Value = infoTransferencia.IdSucursalOrigen;
                rpt.pIdBodega.Value = infoTransferencia.IdBodegaOrigen;
                rpt.pIdTransferencia.Value = infoTransferencia.IdTransferencia;
                ReportPrintTool pt = new ReportPrintTool(rpt);
                pt.ShowPreviewDialog();
            }
            catch (Exception)
            {
                
                throw;
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
