using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
//

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ComprasChatarra : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Bus Proveedores_B = new cp_proveedor_Bus();
        prod_ChatarraTipo_CusTalme_Bus ChatarraTipo_B = new prod_ChatarraTipo_CusTalme_Bus();
        cl_parametrosGenerales_Bus param =  cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
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

        
        public frmProd_ComprasChatarra()
        {
            try
            {
               InitializeComponent();
                    List<cp_proveedor_Info> datasource = new List<cp_proveedor_Info>();
                    List<cp_proveedor_Info> Consulta = Proveedores_B.Get_List_ProveedoresXPresupuestoCusTalme(param.IdEmpresa);
                    var agrupacion = Consulta.GroupBy(V => V.IdProveedor);
                    foreach (var item in agrupacion)
                    {
                
                        datasource.Add((cp_proveedor_Info)item.First());
                    }

                    cmbPresupuesto.Properties.DataSource = datasource;
                    cmbProveedor.Properties.DataSource = Proveedores_B.Get_List_proveedor(param.IdEmpresa);
                    cmbChatarraTipo.Properties.DataSource = ChatarraTipo_B.ConsultaGeneral(param.IdEmpresa);
                    dtpFecha.EditValue = DateTime.Now;
                    //prod_BeneficiarioYProsupuestados_Bus Bus_Beb = new prod_BeneficiarioYProsupuestados_Bus();
                    //cmbBeneficiario.Properties.DataSource = Bus_Beb.Consulta(param.IdEmpresa);
                    DataSource = new BindingList<prod_LiquidacionChatarraDetalle_Info>();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }
        BindingList<prod_LiquidacionChatarraDetalle_Info> DataSource;
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e){}

        prod_CompraChatarra_CusTalme_Info _Info = new prod_CompraChatarra_CusTalme_Info();

        void Get()
        {
            try
            {
                _Info = new prod_CompraChatarra_CusTalme_Info();
                _Info.Beneficiario = cmbBeneficiario.Text.Trim();
                _Info.Descuento = Convert.ToDouble(txtDesct.EditValue);
                _Info.Fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue).ToShortDateString());
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdLiquidacion = Convert.ToDecimal(txtIdLiquidacion.EditValue);
                _Info.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                _Info.IdProveedor_Presu = Convert.ToDecimal(cmbPresupuesto.EditValue);
                _Info.IdTipoChatarra = Convert.ToInt32(cmbChatarraTipo.EditValue);
                _Info.Placa = txtPlaca.Text;
                _Info.PrecioChatarra = Convert.ToDouble(txtPrecio.EditValue);
                _Info.Subtotal = Convert.ToDouble(txtSubtotsl.EditValue);
                _Info.TLlenoKg = Convert.ToDouble(txtLleno.EditValue);
                _Info.TMermaKg = Convert.ToDouble(txtMerma.EditValue);
                _Info.Total = Convert.ToDouble(txtTotal.EditValue);
                _Info.TVacionKg = Convert.ToDouble(txtVacio.EditValue);
                _Info.TNetokg = Convert.ToDouble(txtNeto.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }
        prod_CompraChatarra_CusTalme_Bus Bus = new prod_CompraChatarra_CusTalme_Bus();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
             if (Validar()) 
                    {
                         Get();
                        string mensaje = "";
                        decimal IdLiquidacion = 0;

                        if (Bus.GuardarDB(_Info, ref IdLiquidacion, ref mensaje))
                        {
                            txtIdLiquidacion.EditValue = IdLiquidacion;
                            GenerarMOvimientoInventario(IdLiquidacion);
                            MessageBox.Show(mensaje);
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                        }
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        void GenerarMOvimientoInventario(decimal IdLiquidacion)
        {
            try
            {

                string mensaje_cbte_cble = "";

                   prod_Parametros_x_MoviInven_x_ModeloProduccion_Bus parametrosBus = new prod_Parametros_x_MoviInven_x_ModeloProduccion_Bus();
                    in_producto_x_tb_bodega_Bus _Prod_B = new in_producto_x_tb_bodega_Bus();
                    in_movi_inve_Bus _MoviInven_B = new in_movi_inve_Bus();
                    prod_Parametros_x_MoviInven_x_ModeloProduccion_Info _parametrosProduccion_I = parametrosBus.ObtenerObjeto(param.IdEmpresa, 4);
                    var _Produ_I = _Prod_B.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(_parametrosProduccion_I.IdSucursal_IngxProducTermi), Convert.ToInt32(_parametrosProduccion_I.IdBodega_IngxProducTermi), Convert.ToDecimal(_parametrosProduccion_I.IdProducto_ParaIngreso));
                    in_movi_inve_Info _InMovi_I = new in_movi_inve_Info();
                    _InMovi_I.IdBodega = Convert.ToInt32(_parametrosProduccion_I.IdBodega_IngxProducTermi);
                    _InMovi_I.IdEmpresa = param.IdEmpresa;
                    _InMovi_I.IdSucursal = Convert.ToInt32(_parametrosProduccion_I.IdSucursal_IngxProducTermi);
                    _InMovi_I.IdMovi_inven_tipo = Convert.ToInt32(_parametrosProduccion_I.IdMovi_inven_tipo_x_IngxProduc_ProdTermi);
                    _InMovi_I.cm_observacion = "Movimiento inventario por Compra de chatarra # " + IdLiquidacion;
                    _InMovi_I.cm_tipo = "+";
                    _InMovi_I.cm_fecha = Convert.ToDateTime(((DateTime)(dtpFecha.EditValue)).ToShortDateString());
                    in_movi_inve_detalle_Info _MoviDetalle_i = new in_movi_inve_detalle_Info();
                    _MoviDetalle_i.IdEmpresa = param.IdEmpresa;
                    _MoviDetalle_i.IdBodega = _InMovi_I.IdBodega;
                    _MoviDetalle_i.IdSucursal = _InMovi_I.IdSucursal;
                    _MoviDetalle_i.dm_observacion = _InMovi_I.cm_observacion;
                    _MoviDetalle_i.mv_tipo_movi = _InMovi_I.cm_tipo;
                    _MoviDetalle_i.IdMovi_inven_tipo = _InMovi_I.IdMovi_inven_tipo;
                    _MoviDetalle_i.IdProducto = Convert.ToDecimal(_parametrosProduccion_I.IdProducto_ParaIngreso);
                    _MoviDetalle_i.dm_cantidad = Convert.ToDouble(txtNeto.EditValue);
                    _MoviDetalle_i.dm_stock_actu = _Produ_I.pr_stock + _MoviDetalle_i.dm_cantidad;
                    _MoviDetalle_i.dm_stock_ante = _Produ_I.pr_stock;
                    _MoviDetalle_i.dm_precio = _Produ_I.pr_precio_publico;
                    _MoviDetalle_i.mv_costo = _Produ_I.pr_costo_promedio;
                    _InMovi_I.listmovi_inve_detalle_Info.Add(_MoviDetalle_i);

                    decimal IdMovimiento =0;
                    string Mensaje ="";
                    if (_MoviInven_B.GrabarDB(_InMovi_I, ref IdMovimiento,ref mensaje_cbte_cble, ref Mensaje) == false) 
                    {
                        MessageBox.Show(Mensaje,"Error Al Guardar Movimiento Inventario");
                    }

                    prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus Comp_X_Movi_B = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus();
                    prod_CompraChatarra_CusTalme_x__in_movi_inven_Info Comp_X_Movi_I = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Info();
                    Comp_X_Movi_I.IdEmpresa = param.IdEmpresa;
                    Comp_X_Movi_I.IdLiquidacion = IdLiquidacion;
                    Comp_X_Movi_I.mv_IdBodega = _InMovi_I.IdBodega;
                    Comp_X_Movi_I.mv_IdEmpresa = _InMovi_I.IdEmpresa;
                    Comp_X_Movi_I.mv_IdMovi_inven_tipo = _InMovi_I.IdMovi_inven_tipo;
                    Comp_X_Movi_I.mv_IdNumMovi = IdMovimiento;
                    Comp_X_Movi_I.mv_IdSucursal = _InMovi_I.IdSucursal;

                    if(Comp_X_Movi_B.GuardarDB(Comp_X_Movi_I)==false)
                        MessageBox.Show("Error al Guardar Movimiento Inventario X Compra ", "Tabla Intermedia0");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        
        }

        private void frmProd_GestionProductivaChatarra_Load(object sender, EventArgs e)
        {
            try
            {
                Evente_frmProd_ComprasChatarra_FormClosing += new delegate_frmProd_ComprasChatarra_FormClosing(frmProd_ComprasChatarra_Evente_frmProd_ComprasChatarra_FormClosing);
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            BtnGuardar.Enabled = false;
                            btnGuardarySalir.Enabled = false;
                            Set();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            BtnGuardar.Enabled = false;
                            btnGuardarySalir.Enabled = false;
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

        void frmProd_ComprasChatarra_Evente_frmProd_ComprasChatarra_FormClosing(object sender, FormClosingEventArgs e){}

        private void cmbChatarraTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var ObjtoChatarra = ((List<prod_ChatarraTipo_CusTalme_Info>)(cmbChatarraTipo.Properties.DataSource)).First(v=>v.IdTipoChatarra == Convert.ToInt32(cmbChatarraTipo.EditValue));
                txtPrecio.EditValue = ObjtoChatarra.Precio;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                txtPrecio.EditValue = 0;
            }
        }

        private void cmbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var ObjetoProveedor= ((List<cp_proveedor_Info>)(cmbProveedor.Properties.DataSource)).First(v=>v.IdProveedor == Convert.ToDecimal(cmbProveedor.EditValue));
                txtRazonSocial.EditValue = ObjetoProveedor.pr_nombre;
                txtRuc.EditValue = ObjetoProveedor.Persona_Info.pe_cedulaRuc;
                txtDireccion.EditValue = ObjetoProveedor.Persona_Info.pe_direccion;
                cmbBeneficiario.EditValue = ObjetoProveedor.pr_girar_cheque_a;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                txtRazonSocial.EditValue =null;
                txtRuc.EditValue = null;
                txtDireccion.EditValue = null;
                cmbBeneficiario.EditValue = null;
            }
        }

        void CalcularNeto()
        {
            try
            {
         double lleno = Convert.ToDouble(txtLleno.EditValue);
                double Vacio = Convert.ToDouble(txtVacio.EditValue);
                double merma = Convert.ToDouble(txtMerma.EditValue);

                double Neto = (lleno - Vacio) - merma;

                txtNeto.EditValue = Neto;
                double Precio = Convert.ToDouble(txtPrecio.EditValue);
                double subtotal = Neto * Precio;
                txtSubtotsl.EditValue =subtotal;

                double Descuento = Convert.ToDouble(txtDesct.EditValue);

                txtTotal.EditValue = subtotal - Descuento;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
         
                               
        }

        private void txtPrecio_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularNeto();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public delegate void delegate_frmProd_ComprasChatarra_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmProd_ComprasChatarra_FormClosing Evente_frmProd_ComprasChatarra_FormClosing;
        private void frmProd_ComprasChatarra_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Evente_frmProd_ComprasChatarra_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        public prod_CompraChatarra_CusTalme_Info _SetInfo { get; set; }
        void Set()
        {
            try
            {
                  cmbBeneficiario.Text = _SetInfo.Beneficiario;
                    txtDesct.EditValue = _SetInfo.Descuento;
                    dtpFecha.EditValue=_SetInfo.Fecha;
                    txtIdLiquidacion.EditValue = _SetInfo.IdLiquidacion;
                    cmbProveedor.EditValue = _SetInfo.IdProveedor;
                    cmbPresupuesto.EditValue = _SetInfo.IdProveedor_Presu;
                    cmbChatarraTipo.EditValue = _SetInfo.IdTipoChatarra;
                    txtPlaca.Text = _SetInfo.Placa;
                    txtPrecio.EditValue = _SetInfo.PrecioChatarra;
                    txtSubtotsl.EditValue = _SetInfo.Subtotal;
                    txtLleno.EditValue = _SetInfo.TLlenoKg;
                    txtMerma.EditValue = _SetInfo.TMermaKg;
                    txtTotal.EditValue = _SetInfo.Total;
                    txtVacio.EditValue = _SetInfo.TVacionKg;
                    txtNeto.EditValue = _SetInfo.TNetokg;
                    if (_SetInfo.Estado == "I") 
                    {
                        btnAnular.Enabled = false;
                        BtnGuardar.Enabled = false;
                        btnGuardarySalir.Enabled = false;
                        lblEstado.Visible = true;
                    }
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        Boolean Validar() 
        {
            try
            {
                if (cmbPresupuesto.EditValue == null || cmbPresupuesto.Text == "" || cmbPresupuesto.Text == "[Vacio]") 
                {
                    MessageBox.Show("Favor seleccione Presupuesto");
                    return false;
                }
                if (cmbProveedor.EditValue == null || cmbProveedor.Text == "" || cmbProveedor.Text == "[Vacio]")
                {
                    MessageBox.Show("Favor seleccione Proveedor");
                    return false;
                }
                if (cmbChatarraTipo.EditValue == null || cmbChatarraTipo.Text == "" || cmbChatarraTipo.Text == "[Vacio]")
                {
                    MessageBox.Show("Favor seleccione Tipo Chatarra");
                    return false;
                }
                if (txtLleno.EditValue == null || txtLleno.Text == "0")
                {
                    MessageBox.Show("Favor ingrese lleno");
                    return false;
                }
                if (txtVacio.EditValue == null || txtVacio.Text == "0")
                {
                    MessageBox.Show("Favor ingrese vacio");
                    return false;
                }
                if (txtMerma.EditValue == null || txtMerma.Text == "0")
                {
                    MessageBox.Show("Favor ingrese Merma");
                    return false;
                }
                if (Convert.ToDouble(txtDesct.Text) <= 0)
                {
                    MessageBox.Show("El descuento no puede ser menor o igual a cero");
                    return false;
                }
                if (Convert.ToDouble(txtTotal.Text) <= 0)
                {
                    MessageBox.Show("El Valor Total no puede ser menor o igual a cero");
                    return false;
                } 

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea Anular a transaccion ?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus Chat_X_moVI_B = new prod_CompraChatarra_CusTalme_x__in_movi_inven_Bus();
                    in_movi_inve_Bus _MoviInven_B = new in_movi_inve_Bus();
                    Get();
                    string Mensaje = "";
                    if (Bus.Anular(_Info, ref Mensaje))
                    {
                        var movimientoInv = Chat_X_moVI_B.ObtenerObjeto(param.IdEmpresa, _Info.IdLiquidacion);
                        in_movi_inve_Info Movi_I = new in_movi_inve_Info();
                        Movi_I.IdMovi_inven_tipo = movimientoInv.mv_IdMovi_inven_tipo;
                        Movi_I.IdNumMovi = movimientoInv.mv_IdNumMovi;
                        Movi_I.IdEmpresa = param.IdEmpresa;
                        Movi_I.IdBodega = movimientoInv.mv_IdBodega;
                        Movi_I.IdSucursal = movimientoInv.mv_IdSucursal;

                    if (_MoviInven_B.AnularDB(Movi_I, Convert.ToDateTime(DateTime.Now.ToShortDateString()) , ref Mensaje) == false)
                    { MessageBox.Show(Mensaje); }
                    btnAnular.Enabled = false;

                        MessageBox.Show(Mensaje);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

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

        private void btnGuardarySalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar()) 
                {
                    BtnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void labelControl8_Click(object sender, EventArgs e){}

        private void txtPlaca_EditValueChanged(object sender, EventArgs e){}

        private void txtClave_Leave(object sender, EventArgs e)
        {
            try
            {
             prod_Clave_Autorizacion_Bus validar_b = new prod_Clave_Autorizacion_Bus();

                    if (validar_b.ValidarClave(param.IdEmpresa,txtClave.Text,4))
                    {
                        MessageBox.Show("Apertura Ok");
                        colLLeno.OptionsColumn.AllowEdit = true;
                        colVacio.OptionsColumn.AllowEdit = true;
                    }
                    else
                    {
                        MessageBox.Show("La clave ingresada es invalida");
                        colLLeno.OptionsColumn.AllowEdit = false   ;
                        colVacio.OptionsColumn.AllowEdit = false;
                    }
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

    }
}
