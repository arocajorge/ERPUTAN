using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Business.Produccion_Talme;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_GestionProductivaTechos : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_producto_Bus _Prod_B = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        List<in_Producto_Info> ListaProductos;
        prod_Turno_Bus _Turno_B = new prod_Turno_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        prod_ModeloProduccion_CusTalme_Bus _ModelProduccion_B = new prod_ModeloProduccion_CusTalme_Bus();
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
        public frmProd_GestionProductivaTechos()
        {
            try
            {
                InitializeComponent();
              
                dtpFecha.EditValue = DateTime.Now;
                cmbMateriaPrima.Properties.DataSource = _Prod_B.Get_list_MateriaPrima(param.IdEmpresa);
                CmbTurno.Properties.DataSource = _Turno_B.ConsultaGeneral(param.IdEmpresa);
                CmbTipoModelo.Properties.DataSource = _ModelProduccion_B.ConsultaGeneral().FindAll(var => var.Tipo == "FE_TC");

                var Primero = ((List<prod_ModeloProduccion_CusTalme_Info>)CmbTipoModelo.Properties.DataSource).First();

                CmbTipoModelo.EditValue = Primero.IdModeloProd;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridControl_Click(object sender, EventArgs e){}

        private void repositoryItemSearchLookUpEdit1View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var ass = (in_Producto_Info)repositoryItemSearchLookUpEdit1View.GetFocusedRow();
                var asd = GridView.GetFocusedRowCellValue(colProd_IdProducto);
            GridView.SetFocusedRowCellValue(colProd_Largo, repositoryItemSearchLookUpEdit1View.GetFocusedRowCellValue(colpr_largo));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void GridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                var Producto =ListaProductos.First(var => var.IdProducto == Convert.ToDecimal(GridView.GetFocusedRowCellValue(colProd_IdProducto)));
                
                GridView.SetFocusedRowCellValue(colProd_Largo, Producto.pr_largo);
                GridView.SetFocusedRowCellValue(colProd_PsoUnd, Producto.pr_peso);
                GridView.SetFocusedRowCellValue(colProd_Ancho, Producto.pr_alto);

                if (Convert.ToInt32(GridView.GetFocusedRowCellValue(colSegunda_IdProducto)) == 0) 
                {
                    GridView.SetFocusedRowCellValue(colSegunda_Kg,0);
                    GridView.SetFocusedRowCellValue(colSegunda_Unidades, 0);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());            
            }
        }

        in_producto_x_tb_bodega_Bus _ProdXBode_B = new in_producto_x_tb_bodega_Bus();
        prod_GestionProductivaTechos_CusTalme_Cab_Bus Bus = new prod_GestionProductivaTechos_CusTalme_Cab_Bus();
        in_movi_inve_Bus _movi_B = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus _movidet_b = new in_movi_inve_detalle_Bus();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdGestion.Focus();
                Get();

                string mensaje_cbte_cble = "";


                if (validar())
                {
                    decimal Id = 0;
                    prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus BusprodXMovi = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus();
                    if (Bus.GuardarDB(Info, ref Id))
                    {
                        var Parametros_Techo = ((List<prod_ModeloProduccion_CusTalme_Info>)CmbTipoModelo.Properties.DataSource).First(var => var.IdModeloProd == Convert.ToInt32(CmbTipoModelo.EditValue));
                        #region MovimientoInventarioMateriaPrima


                        var ProdMateriaPrima = _ProdXBode_B.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(Parametros_Techo.IdSucursal_EgrxMateriaPrima), Convert.ToInt32(Parametros_Techo.IdBodega_EgrxMateriaPrima), Convert.ToDecimal(cmbMateriaPrima.EditValue));
                        in_movi_inve_Info InfoMovi = new in_movi_inve_Info();
                        InfoMovi.IdEmpresa = param.IdEmpresa;
                        InfoMovi.cm_observacion = "Egr. Materia P. X Gestion Productiva " + CmbTipoModelo.Text + "# " + Id;
                        InfoMovi.cm_tipo = "-";
                        InfoMovi.cm_fecha = DateTime.Now;
                        InfoMovi.Fecha_Transac = param.Fecha_Transac;
                        InfoMovi.IdUsuario = param.IdUsuario;
                        InfoMovi.IdUsuarioUltModi = param.IdUsuario;
                        InfoMovi.Fecha_UltMod = param.Fecha_Transac;
                        InfoMovi.IdBodega = Convert.ToInt32(Parametros_Techo.IdBodega_EgrxMateriaPrima);
                        InfoMovi.IdSucursal = Convert.ToInt32(Parametros_Techo.IdSucursal_EgrxMateriaPrima);
                        InfoMovi.IdMovi_inven_tipo = Convert.ToInt32(Parametros_Techo.IdMovi_inven_tipo_x_EgrxProduc_MatPri);
                        InfoMovi.nom_pc = param.nom_pc;
                        Info.ip = param.ip;
                        string men = "";
                        decimal Idmovi = 0;
                        if (_movi_B.GrabarDB(InfoMovi, ref Idmovi, ref mensaje_cbte_cble,ref men) == false)
                        {
                            MessageBox.Show(men);
                        }
                        prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info InfoMovxPro = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info();
                        InfoMovxPro.IdEmpresa = InfoMovxPro.prod_IdEmpresa = param.IdEmpresa;
                        InfoMovxPro.IdBodega = InfoMovi.IdBodega;
                        InfoMovxPro.IdGestionProductiva = Id;
                        InfoMovxPro.IdMovi_inven_tipo = InfoMovi.IdMovi_inven_tipo;
                        InfoMovxPro.IdNumMovi = Idmovi;
                        InfoMovxPro.IdSucursal = InfoMovi.IdSucursal;
                        if (BusprodXMovi.Guardar(InfoMovxPro, ref men) == false)
                        {
                            MessageBox.Show(men);
                        }


                        #region DetalleMovimiento
                        List<in_movi_inve_detalle_Info> ListDetalle = new List<in_movi_inve_detalle_Info>();
                        in_movi_inve_detalle_Info _DetMovi_I = new in_movi_inve_detalle_Info();
                        _DetMovi_I.IdBodega = Convert.ToInt32(Parametros_Techo.IdBodega_EgrxMateriaPrima);
                        _DetMovi_I.IdEmpresa = param.IdEmpresa;
                        _DetMovi_I.IdMovi_inven_tipo = Convert.ToInt32(Parametros_Techo.IdMovi_inven_tipo_x_EgrxProduc_MatPri);
                        _DetMovi_I.IdNumMovi = Idmovi;
                        _DetMovi_I.IdProducto = Info.IdProducto_MateriaPrima;
                        _DetMovi_I.IdSucursal = Convert.ToInt32(Parametros_Techo.IdSucursal_EgrxMateriaPrima);
                        _DetMovi_I.dm_cantidad = Convert.ToDouble(txtConsumo.EditValue);
                        _DetMovi_I.dm_observacion = InfoMovi.cm_observacion;
                        _DetMovi_I.dm_precio = ProdMateriaPrima.pr_precio_publico;
                        _DetMovi_I.mv_costo = ProdMateriaPrima.pr_costo_promedio;
                        _DetMovi_I.mv_tipo_movi = "-";
                        _DetMovi_I.dm_stock_ante = ProdMateriaPrima.pr_stock;
                        _DetMovi_I.dm_stock_actu = ProdMateriaPrima.pr_stock - _DetMovi_I.dm_cantidad;
                        ListDetalle.Add(_DetMovi_I);

                        #endregion
                        if (_movidet_b.GrabarDB(ListDetalle, ref men) == false)
                        {
                            MessageBox.Show(men);
                        }
                        ListDetalle.ForEach(var => var.dm_cantidad = var.dm_cantidad * -1);
                        _ProdXBode_B.ActualizarStock_x_Bodega_con_moviInven(ListDetalle, ref men);
                        #endregion
                        #region MovimientoInvenarioProducto
                        InfoMovi = new in_movi_inve_Info();
                        ListDetalle = new List<in_movi_inve_detalle_Info>();
                        InfoMovi.IdEmpresa = param.IdEmpresa;
                        InfoMovi.cm_observacion = "Ing. Produ Ter. X Gestion Productiva " + CmbTipoModelo.Text + "# " + Id;
                        InfoMovi.cm_tipo = "+";
                        InfoMovi.cm_fecha = DateTime.Now;
                        InfoMovi.Fecha_Transac = param.Fecha_Transac;
                        InfoMovi.IdUsuario = param.IdUsuario;
                        InfoMovi.IdUsuarioUltModi = param.IdUsuario;
                        InfoMovi.Fecha_UltMod = param.Fecha_Transac;
                        InfoMovi.IdBodega = Convert.ToInt32(Parametros_Techo.IdBodega_IngxProduc);
                        InfoMovi.IdSucursal = Convert.ToInt32(Parametros_Techo.IdSucursal_IngxProduc);
                        InfoMovi.IdMovi_inven_tipo = Convert.ToInt32(Parametros_Techo.IdMovi_inven_tipo_x_IngxProduc_ProdTermi);
                        InfoMovi.nom_pc = param.nom_pc;
                        Info.ip = param.ip;
                        if (_movi_B.GrabarDB(InfoMovi, ref Idmovi,ref mensaje_cbte_cble, ref men) == false)
                        {
                            MessageBox.Show(men);
                        }
                        InfoMovxPro = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Info();
                        InfoMovxPro.IdEmpresa = InfoMovxPro.prod_IdEmpresa = param.IdEmpresa;
                        InfoMovxPro.IdBodega = InfoMovi.IdBodega;
                        InfoMovxPro.IdGestionProductiva = Id;
                        InfoMovxPro.IdMovi_inven_tipo = InfoMovi.IdMovi_inven_tipo;
                        InfoMovxPro.IdNumMovi = Idmovi;
                        InfoMovxPro.IdSucursal = InfoMovi.IdSucursal;
                        if (BusprodXMovi.Guardar(InfoMovxPro, ref men) == false)
                        {
                            MessageBox.Show(men);
                        }
                        Boolean segunda = false;
                        foreach (var item in Info.ListaDetalle)
                        {
                            var Producto = _ProdXBode_B.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(Parametros_Techo.IdSucursal_EgrxMateriaPrima), Convert.ToInt32(Parametros_Techo.IdBodega_EgrxMateriaPrima), Convert.ToDecimal(cmbMateriaPrima.EditValue));
                            _DetMovi_I = new in_movi_inve_detalle_Info();
                            _DetMovi_I.IdBodega = Convert.ToInt32(Parametros_Techo.IdBodega_IngxProduc);
                            _DetMovi_I.IdEmpresa = param.IdEmpresa;
                            _DetMovi_I.IdMovi_inven_tipo = Convert.ToInt32(Parametros_Techo.IdMovi_inven_tipo_x_IngxProduc_ProdTermi);
                            _DetMovi_I.IdNumMovi = Idmovi;
                            _DetMovi_I.IdProducto = item.Prod_IdProducto;
                            _DetMovi_I.IdSucursal = Convert.ToInt32(Parametros_Techo.IdSucursal_IngxProduc);
                            _DetMovi_I.dm_cantidad = item.Prducc_Unidades;
                            _DetMovi_I.dm_observacion = InfoMovi.cm_observacion;
                            _DetMovi_I.dm_precio = Producto.pr_precio_publico;
                            _DetMovi_I.mv_costo = Producto.pr_costo_promedio;
                            _DetMovi_I.mv_tipo_movi = "+";
                            _DetMovi_I.dm_stock_ante = Producto.pr_stock;
                            _DetMovi_I.dm_stock_actu = Producto.pr_stock - _DetMovi_I.dm_cantidad;
                            ListDetalle.Add(_DetMovi_I);

                            if (segunda)
                            {
                                _DetMovi_I = new in_movi_inve_detalle_Info();
                                var Producto2 = _ProdXBode_B.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(Parametros_Techo.IdSucursal_EgrxMateriaPrima), Convert.ToInt32(Parametros_Techo.IdBodega_EgrxMateriaPrima), Convert.ToDecimal(item.Segunda_IdProducto));
                                _DetMovi_I = new in_movi_inve_detalle_Info();
                                _DetMovi_I.IdBodega = Convert.ToInt32(Parametros_Techo.IdBodega_IngxProduc);
                                _DetMovi_I.IdEmpresa = param.IdEmpresa;
                                _DetMovi_I.IdMovi_inven_tipo = Convert.ToInt32(Parametros_Techo.IdMovi_inven_tipo_x_IngxProduc_ProdTermi);
                                _DetMovi_I.IdNumMovi = Idmovi;
                                _DetMovi_I.IdProducto = item.Segunda_IdProducto;
                                _DetMovi_I.IdSucursal = Convert.ToInt32(Parametros_Techo.IdSucursal_IngxProduc);
                                _DetMovi_I.dm_cantidad = item.Segunda_Unidades;
                                _DetMovi_I.dm_observacion = InfoMovi.cm_observacion;
                                _DetMovi_I.dm_precio = Producto2.pr_precio_publico;
                                _DetMovi_I.mv_costo = Producto2.pr_costo_promedio;
                                _DetMovi_I.mv_tipo_movi = "+";
                                _DetMovi_I.dm_stock_ante = Producto2.pr_stock;
                                _DetMovi_I.dm_stock_actu = Producto2.pr_stock - _DetMovi_I.dm_cantidad;
                                ListDetalle.Add(_DetMovi_I);
                            }
                            _ProdXBode_B.ActualizarStock_x_Bodega_con_moviInven(ListDetalle, ref men);


                        }
                        if (_movidet_b.GrabarDB(ListDetalle, ref men) == false)
                        {
                            MessageBox.Show(men);

                        };

                        #endregion
                        txtIdGestion.EditValue = Id;

                        MessageBox.Show("Se ha Ingresado con exito el Registro #: " + Id);
                        btnGuardar.Enabled = false;
                        btnGuardarYSalir.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        prod_GestionProductivaTechos_CusTalme_Cab_Info Info = new prod_GestionProductivaTechos_CusTalme_Cab_Info();
        
        void Get() 
        {
            try
            {
                Info = new prod_GestionProductivaTechos_CusTalme_Cab_Info();
                Info.Chatarra = Convert.ToDouble(txtChatarra.EditValue);

                Info.Consumo = Convert.ToDouble(txtConsumo.EditValue);

                if (txtDespacho.Text != "")
                {
                    string[] I = txtDespacho.Text.Split(':');
                    TimeSpan hrI = new TimeSpan(Convert.ToInt16(I[0]), Convert.ToInt16(I[1]), 0);
                    Info.Despacho = hrI;
                }

                Info.IdModeloProd = Convert.ToInt32(CmbTipoModelo.EditValue);
                Info.Factor = Convert.ToDouble(txtFactor.EditValue);
                Info.Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                if (txtHrsTurno.Text != "")
                {
                    string[] I = txtHrsTurno.Text.Split(':');
                    TimeSpan hrI = new TimeSpan(Convert.ToInt16(I[0]), Convert.ToInt16(I[1]), 0);
                    Info.HrsTurno = hrI;
                }
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdProducto_MateriaPrima = Convert.ToDecimal(cmbMateriaPrima.EditValue);
                Info.IdTurno = Convert.ToInt32(CmbTurno.EditValue);
                Info.Num_Personas = Convert.ToInt32(txtNumPersona.EditValue);

                //Info.Tprep=txtTPrep.Text;
                if (txtTPrep.Text != "")
                {
                    string[] I = txtTPrep.Text.Split(':');
                    TimeSpan hrI = new TimeSpan(Convert.ToInt16(I[0]), Convert.ToInt16(I[1]), 0);
                    Info.Tprep = hrI;
                }


                for (int i = 0; i < GridView.RowCount; i++)
                {
                    prod_GestionProductivaTechos_CusTalme_Detalle_Info Item = (prod_GestionProductivaTechos_CusTalme_Detalle_Info)GridView.GetRow(i);
                    if (Item != null)
                    {
                        Info.ListaDetalle.Add(Item);
                    }
                }
                Info.IdGestionProductiva = Convert.ToDecimal((txtIdGestion.EditValue == "") ? 0 : txtIdGestion.EditValue);    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtHrsTurno_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtHrsTurno.Text = txtHrsTurno.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (Bus.AnularDB(Info))
                {
                    string mensaje = "";
                    prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus BusAnulacion = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus();
                    var Movimientos = BusAnulacion.ObjtenerListaPorGestion(param.IdEmpresa, Info.IdGestionProductiva);
                    foreach (var item in Movimientos)
                    {
                        in_movi_inve_Info MInfo = new in_movi_inve_Info();
                        MInfo.IdNumMovi = item.IdNumMovi;
                        MInfo.IdEmpresa = item.IdEmpresa;
                        MInfo.IdSucursal = item.IdSucursal;
                        MInfo.IdBodega = item.IdBodega;
                        MInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                       _movi_B.AnularDB(MInfo, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);
                    }

                    MessageBox.Show("Anulado Con exito La Gestion #: " + Info.IdGestionProductiva);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }


        public prod_GestionProductivaTechos_CusTalme_Cab_Info _SetInfo { get; set; }


        void Set() 
        {

            try
            {
                txtIdGestion.Text = _SetInfo.IdGestionProductiva.ToString();
                txtChatarra.EditValue = _SetInfo.Chatarra;
                txtConsumo.EditValue = _SetInfo.Consumo;
                txtDespacho.EditValue = _SetInfo.Despacho;
                txtFactor.EditValue = _SetInfo.Factor;
                txtHrsTurno.EditValue = _SetInfo.HrsTurno;
                txtNumPersona.EditValue = _SetInfo.Num_Personas;
                txtTPrep.EditValue = _SetInfo.Tprep;
                dtpFecha.EditValue = _SetInfo.Fecha;
                CmbTipoModelo.EditValue = _SetInfo.IdModeloProd;
                cmbMateriaPrima.EditValue = _SetInfo.IdProducto_MateriaPrima;
                CmbTurno.EditValue = _SetInfo.IdTurno;
                if (_SetInfo.Estado == "I")
                {
                    btnGuardar.Enabled = false;
                    btnGuardarYSalir.Enabled = false;
                    btnAnular.Enabled = false;
                    lblEstado.Visible = true;
                }

                prod_GestionProductivaTechos_CusTalme_Detalle_Bus _BusDet = new prod_GestionProductivaTechos_CusTalme_Detalle_Bus();

                gridControl.DataSource = _BusDet.ConsultaGeneral(param.IdEmpresa, _SetInfo.IdGestionProductiva);
                prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus BusMoviCon = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus();
                var Movimientos = BusMoviCon.ObjtenerListaPorGestion(param.IdEmpresa, _SetInfo.IdGestionProductiva);
                List<in_movi_inve_Info> lstMovi = new List<in_movi_inve_Info>();
                foreach (var item in Movimientos)
                {
                    var Movi = _movi_B.Get_Info_Movi_inven_Report(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo, item.IdNumMovi);
                    Movi.IconImprimir = global::Core.Erp.Winform.Properties.Resources.imprimir;

                    lstMovi.Add(Movi);
                }

                gridControlMovi.DataSource = lstMovi;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        private void frmProd_GestionProductivaTechos_Load(object sender, EventArgs e)
        {
            try
            {

                Event_frmProd_GestionProductivaTechos_FormClosing += new delegate_frmProd_GestionProductivaTechos_FormClosing(frmProd_GestionProductivaTechos_Event_frmProd_GestionProductivaTechos_FormClosing);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        btnGuardar.Enabled = false;
                        btnGuardarYSalir.Enabled = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btnGuardar.Enabled = false;
                        btnGuardarYSalir.Enabled = false;
                        btnAnular.Enabled = false;
                        Set();
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

        void frmProd_GestionProductivaTechos_Event_frmProd_GestionProductivaTechos_FormClosing(object sender, FormClosingEventArgs e){}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
               Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public delegate void delegate_frmProd_GestionProductivaTechos_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmProd_GestionProductivaTechos_FormClosing Event_frmProd_GestionProductivaTechos_FormClosing;

        private void frmProd_GestionProductivaTechos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               Event_frmProd_GestionProductivaTechos_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtTPrep_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtTPrep.Text = txtTPrep.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtDespacho_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              txtDespacho.Text = txtDespacho.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e){}

        private void TextEditTiempoPreparacion_EditValueChanged(object sender, EventArgs e){}

        private void CmbTipoModelo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(CmbTipoModelo.EditValue);

                cmbMateriaPrima.Properties.DataSource = _Prod_B.Get_list_MateriaPrima_X_ModeloDeProduccion(param.IdEmpresa, a);

                ListaProductos = _Prod_B.Get_ProductoTerminado_X_ModeloDeProduccion(param.IdEmpresa,a);
                cmbProducto.DataSource = ListaProductos;
                cmbProductoSegunda.DataSource = ListaProductos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        Boolean validar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtHrsTurno.Text)) 
                {
                    MessageBox.Show("Por Favor ingreseHorasTurno");
                    return false;
                }
                if (string.IsNullOrEmpty(txtNumPersona.Text))
                {
                    MessageBox.Show("Por favor Ingrese Numero De personas");
                    return false;
                }
                if (string.IsNullOrEmpty(txtTPrep.Text))
                {
                    MessageBox.Show("Por Favor Ingrese tiempo de Preparacion");
                    return false;
                }
                if (string.IsNullOrEmpty(txtConsumo.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Consumo");
                    return false;
                }
                if (string.IsNullOrEmpty(txtDespacho.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Despacho");
                    return false;
                }
                if (string.IsNullOrEmpty(txtChatarra.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Chatarra");
                    return false;
                }
                if (string.IsNullOrEmpty(txtFactor.Text))
                {
                    MessageBox.Show("Por Favor Ingrese Factor");
                    return false;
                }

                if (string.IsNullOrEmpty(cmbMateriaPrima.Text))
                {
                    MessageBox.Show("Por Favor Seleccione Materia Prima");
                    return false;
                }
                if (string.IsNullOrEmpty(CmbTipoModelo.Text))
                {
                    MessageBox.Show("Por favor Infrese Tipo de Gestion");
                    return false;
                }
                if (string.IsNullOrEmpty(CmbTurno.Text))
                {
                    MessageBox.Show("Por Favor seleccione Turno");
                    return false;
                }
                
                if (Info.ListaDetalle.Count==0) 
                {
                    MessageBox.Show("Por Favor Ingresar al menos un Producto");
                    return false;

                }
                foreach (var item in Info.ListaDetalle)
                {
                    if (item.Prod_IdProducto == 0 || item.Prod_IdProducto== null) 
                     {
                    MessageBox.Show("Por Favor seleccionar Producto en el detalle");
                    return false;

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void gridViewMovi_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Caption == "*")
                {
                    Get();
                    in_movi_inve_Bus MoviB = new in_movi_inve_Bus();
                    in_movi_inve_Info DataMoviInven = new in_movi_inve_Info();
                    List<in_movi_inve_Info> listMoviIn = new List<in_movi_inve_Info>();
                    prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus Busrpt = new prod_GestionProductivaTechos_CusTalme_X_in_movi_inve_Bus();
                    in_producto_Bus BusPr = new in_producto_Bus();
                    var Movimientos = Busrpt.ObjtenerListaPorGestion(param.IdEmpresa, Info.IdGestionProductiva);
                    foreach (var item in Movimientos)
                    {
                        DataMoviInven = MoviB.Get_Info_Movi_inven_Report(param.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdMovi_inven_tipo, item.IdNumMovi);

                        listMoviIn.Add(DataMoviInven);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }
    }
}

