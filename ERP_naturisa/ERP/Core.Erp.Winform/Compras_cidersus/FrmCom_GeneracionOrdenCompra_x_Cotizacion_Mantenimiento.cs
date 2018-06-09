using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Business.General;
using Core.Erp.Business.Compras;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Compras_Edehsa;
using Core.Erp.Info.Contabilidad;
using Cus.Erp.Reports.Naturisa.Compras;
using System.Diagnostics;
using Cus.Erp.Reports.Cidersus;
using Cus.Erp.Reports.Cidersus.Produccion;

namespace Core.Erp.Winform.Compras_cidersus
{
    public partial class FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento : Form
    {
        #region variables
        int i;//bandera para controlar check
        int j;//bandera para validar si se esta selccionando un check
        int contador;
        in_Producto_Info Item;
        public com_ordencompra_local_Info InfoCab { get; set; }
        string MensajeError = "";
        decimal Cod_Producto = 0;
        // Bus        

        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
        com_TerminoPago_Bus BusTermPago = new com_TerminoPago_Bus();
        com_Catalogo_Bus Catalogo_bus = new com_Catalogo_Bus();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        com_parametro_Bus Bus_ParamCompra = new com_parametro_Bus();
        com_ordencompra_local_det_Bus BusDetOC = new com_ordencompra_local_det_Bus();
        ro_Departamento_Bus DepBus = new ro_Departamento_Bus();
        in_producto_Bus BusProducto = new in_producto_Bus();
        tb_persona_bus PersoBus = new tb_persona_bus();
        com_comprador_Bus bus_Comprador = new com_comprador_Bus();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        //com_Catalogo_Bus BusCatalogo = new com_Catalogo_Bus();
        com_Motivo_Orden_Compra_Bus bus_Motivo = new com_Motivo_Orden_Compra_Bus();
        ct_Centro_costo_Bus BusCentroCosto;
        List<tb_sis_impuesto_Info> listTipoImpu_x_Iva = new List<tb_sis_impuesto_Info>();

        com_estado_cierre_Bus Bus_estado_cierre = new com_estado_cierre_Bus();
        List<com_estado_cierre_Info> list_estadoCierre = new List<com_estado_cierre_Info>();



        // Infos
        com_ordencompra_local_Info OCInfo = new com_ordencompra_local_Info();
        com_ordencompra_local_Info InfoOC = new com_ordencompra_local_Info();

        // Listas                
        List<tb_Sucursal_Info> LstInfoSucursal = new List<tb_Sucursal_Info>();
        List<cp_proveedor_Info> LstInfoProv = new List<cp_proveedor_Info>();
        List<com_TerminoPago_Info> LstTermPago = new List<com_TerminoPago_Info>();

        List<com_ordencompra_local_det_Info> LstDetOC = new List<com_ordencompra_local_det_Info>();

        List<ro_Departamento_Info> ListDepar = new List<ro_Departamento_Info>();
        List<tb_persona_Info> PersonaList = new List<tb_persona_Info>();
        List<com_comprador_Info> CompradorList = new List<com_comprador_Info>();
        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();
        

        List<com_Motivo_Orden_Compra_Info> listMotivo = new List<com_Motivo_Orden_Compra_Info>();

        ////COTIZACION
        com_cotizacion_compra_det_Bus BusCotizacion = new com_cotizacion_compra_det_Bus();
        List<com_cotizacion_compra_det_Info> ListaCotizacion = new List<com_cotizacion_compra_det_Info>();
        //BindingList<com_cotizacion_compra_det_Info> listaCotizacion = new BindingList<com_cotizacion_compra_det_Info>();
        
        // REGISTRO OC X COTIZACION 
        List<com_Registro_OrdenCompra_x_Cotizacion_Info> listaRegOC_x_Cot = new List<com_Registro_OrdenCompra_x_Cotizacion_Info>();
        com_Registro_OrdenCompra_x_Cotizacion_Info InfoRegistro_OC_x_Cotizacion = new com_Registro_OrdenCompra_x_Cotizacion_Info();
        com_Registro_OrdenCompra_x_Cotizacion_Bus BusRegistro_OC_x_Cotizacion = new com_Registro_OrdenCompra_x_Cotizacion_Bus();

        //Variables 

        private Cl_Enumeradores.eTipo_action Accion;

        //BindingList<Tabla_pedido_det_Info> ListaBind;
        //Tabla_pedido_det_Info Info = new Tabla_pedido_det_Info();
        BindingList<com_ordencompra_local_det_Info> lista_detalle = new BindingList<com_ordencompra_local_det_Info>();
        BindingList<com_ordencompra_local_det_Info> lista_detalle_x_cotizacion = new BindingList<com_ordencompra_local_det_Info>();


        private BindingList<com_ordencompra_local_det_Info> LstOrdC = new BindingList<com_ordencompra_local_det_Info>();
        private BindingList<com_ordencompra_local_det_Info> listDetTabla;

        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro;

        


        double base0 = 0;
        double base12 = 0;
        double descuento = 0;
        double iva = 0;
        double dSubtotal = 0;

        int idsucursal = 0;
        int idsolicitud = 0;
        List<com_solicitud_compra_det_Info> ListaGrid;
        List<com_solicitud_compra_det_Info> ListDetSolCom = new List<com_solicitud_compra_det_Info>();
       
        string desc_producto = "";
        int scd_IdEmpresa = 0;
        int scd_IdSucursal = 0;
        decimal scd_IdSolicitudCompra = 0;

        

        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listCompxSolici = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        List<com_solicitud_compra_det_Info> listDetSoli = new List<com_solicitud_compra_det_Info>();
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_DetxSol = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();
        in_producto_Bus _ProductoBus = new in_producto_Bus();


        public delegate void delegate_frmCom_OrdenCompra_x_Cotizacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCom_OrdenCompra_x_Cotizacion_Mant_FormClosing event_frmCom_OrdenCompra_x_Cotizacion_Mant_FormClosing;
        #endregion
        

        public delegate void Delegate_FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento(object sender, FormClosingEventArgs e);
        public event Delegate_FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento Event_FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento;

        public FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento()
        {
            InitializeComponent();
            _Parametros_Info = param_Produccion.ObtenerObjeto(param.IdEmpresa);
           
        }
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;

                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       
                        

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                       
                       
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                       
     
                        break;

                    default:

                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        private void FrmCom_GeneracionOrdenCompra_x_Cotizacion_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {

                gridControlOrdenCompra.DataSource = lista_detalle;
                cargacombos();

                if (Accion == null || Accion == 0)
                {
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                }
                LoadProductos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo();
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        cmbEstadoAprob.Enabled = true;
                        CalcularTotales();

                        if (listCompxSolici.Count() != 0)
                        {
                            this.colCodigo_Producto.OptionsColumn.AllowEdit = false;
                            this.colCantidad.OptionsColumn.AllowEdit = false;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        setInfo();

                     //   this.btnImportar.Enabled = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        CalcularTotales();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                         ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        setInfo();

                        CalcularTotales();
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

        public void CargarCombos()
        {
            try
            {
                 LstTermPago = BusTermPago.Get_List_TerminoPago();
                //cmbTermPago.Properties.DataSource = LstTermPago;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //SET USER_CONTROLS - TERMINO PAGO
        ////private void setInfo_In_Controls()
        ////{
        ////    try
        ////    {

        ////        ucCom_TerminoPagoCmb1.set_TermPagoInfo(InfoOC.IdTerminoPago);

        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Log_Error_bus.Log_Error(ex.ToString());
        ////        MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        ////    }
        ////}



        void getGra()
        {
            try
            {
                OCInfo.Fecha_Transac = param.Fecha_Transac;
                OCInfo.IdUsuario_Aprueba = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean getdet()
        {
            try
            {

                if (lista_detalle.Count == 0)
                {
                    MessageBox.Show("Debe agregar un producto a la Orden de Compra ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {

                    int focus = gridViewOrdenCompra.FocusedRowHandle;
                    gridViewOrdenCompra.FocusedRowHandle = focus + 1;

                    foreach (var item in LstDetOC)
                    {
                        //if (item.dm_cantidad == 0)
                        //{
                        if (item.do_Cantidad == 0)
                        {
                            MessageBox.Show("Ingrese una cantidad para el Item : " + desc_producto + "  ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //LstOrdC = new BindingList<Tabla_pedido_det_Info>();
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        void getMod()
        {
            try
            {
                OCInfo.Fecha_UltMod = param.Fecha_Transac;
                OCInfo.IdUsuarioUltMod = param.IdUsuario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void grabar()
        {
            try
            {
                decimal id = 0;
                string msg = "";
                string msgReg_x_Cot = "";
                List<com_ordencompra_local_det_Info> templst = new List<com_ordencompra_local_det_Info>();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        getGra();

                        OCInfo.listDetalle = LstDetOC;
                       // OCInfo.listDetSoliciComp = ListDetSolCom;

                        if (BusOC.GuardarDB(OCInfo, ref id, ref msg))
                        {
                            //MessageBox.Show("Se ha procedido a grabar el registro de la Orden/Compra #: " + id.ToString() + " exitosamente.", "Operación Exitosa");

                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Orden de Compra", OCInfo.IdOrdenCompra);
                            MessageBox.Show(smensaje, param.Nombre_sistema);

                            if (BusRegistro_OC_x_Cotizacion.GrabarDB(listaRegOC_x_Cot, ref msgReg_x_Cot))
                            {
                                //string smensaje2 = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Se registro el Detalle de la Orden de Compra por Cotizacion", InfoRegistro_OC_x_Cotizacion.IdOrdenCompra);
                                //MessageBox.Show(smensaje2, param.Nombre_sistema);
                            }
                            else
                            {
                                string smensaje2 = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                                MessageBox.Show(smensaje2, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //MessageBox.Show("error al grabar OC. " + msg, param.Nombre_sistema);
                            }

                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                            OCInfo.IdOrdenCompra = id;
                            setInfo();

                            if (MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msg_Pregunta_Imprimir, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                              imprimir();
                            }
                            set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //MessageBox.Show("error al grabar OC. " + msg, param.Nombre_sistema);
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        getMod();

                        OCInfo.listDetalle = LstDetOC;
                        OCInfo.listDetSoliciComp = ListDetSolCom;
                        if (BusOC.ModificarDB(OCInfo, ref  msg))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Orden de Compra", OCInfo.IdOrdenCompra);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //MessageBox.Show("Se ha procedido a actualizar el registro de la Orden/Compra #: " + OCInfo.IdOrdenCompra.ToString() + " exitosamente.", "Operación Exitosa");
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // MessageBox.Show("No se ha actualizado el registro de la Orden/Compra #: " + OCInfo.IdOrdenCompra + " por " + msg + "", "Operación Fallida");
                        }

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private Boolean validaciones()
        {
            try
            {

                 if (ucCom_Comprador1.get_CompradorInfo() == null)
                {
                     MessageBox.Show("Debe seleccionar el comprador para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCom_Comprador1.Focus(); return false;
                }

                
               
                //else if (cmbTermPago.EditValue == null)
                //{
                //    MessageBox.Show("Debe seleccionar el Termino de Pago para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //    cmbTermPago.Focus(); return false;
                //}

                 else if (ucCom_TerminoPagoCmb1.get_TermPagoInfo() == null)
                 {
                     MessageBox.Show("Debe seleccionar el Termino de Pago para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     ucCom_TerminoPagoCmb1.Focus(); return false;
                 }


                else if (ucGe_Sucursal_combo1.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Debe seleccionar una Sucursal para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ucGe_Sucursal_combo1.Focus(); return false;
                }
                else if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Debe seleccionar un Proveedor para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCp_Proveedor1.Focus(); return false;
                }


                

               

                else if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese Observación para la Orden/Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservacion.Focus(); return false;
                }
                 else

                     if (LstDetOC.Count != 0)
                     {
                         int focus = gridViewOrdenCompra.FocusedRowHandle;
                         gridViewOrdenCompra.FocusedRowHandle = focus + 1;

                         foreach (var item in LstDetOC)
                         {
                             if (item.do_Cantidad == 0)
                             {
                                 MessageBox.Show("Ingrese una cantidad para el Item : " + desc_producto + "  ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                 return false;
                             }
                             if (item.do_precioCompra == 0)
                             {
                                 MessageBox.Show("Ingrese el Precio para el Item : " + desc_producto + "  ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                 return false;
                             }



                         }
                     }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void CalcularTotales()
        {
            try
            {
                convertir_info(lista_detalle);

                calculos(LstDetOC);

                txeDesc.EditValue = (double)descuento;
                txeSTotaliva.EditValue = (double)iva;
                txeSsubtotal.EditValue = (double)base0 + (double)base12;
                txeSsubtotal0.EditValue = (double)base0;
                txeIva.EditValue = (double)base12;

               txeSTotal.EditValue = Convert.ToDouble(txeSsubtotal.EditValue) + Convert.ToDouble(txeSTotaliva.EditValue) ;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void calculos(List<com_ordencompra_local_det_Info> LstOCDEtalle)
        {
            try
            {
                base0 = 0;
                base12 = 0;
                descuento = 0;
                iva = 0;

                //foreach (var item in lista_detalle)
                //{
                foreach (var item in LstOCDEtalle)
                {
                    //if (item.idco == true)
                    //{
                    //    base12 += item.do_subtotal;
                    //    iva += item.do_iva;
                    //}
                    //else
                    //{
                    //    base0 += item.do_total;
                    //}


                    descuento += item.do_descuento;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void calculos2(List<com_ordencompra_local_det_Info> LstOCDEtalle)
        {
            try
            {
                base0 = 0;
                base12 = 0;
                descuento = 0;
                iva = 0;
                dSubtotal = 0;

                //foreach (var item in lista_detalle)
                //{
                foreach (var item in LstOCDEtalle)
                {
                    //if (item.Por_Iva == true)
                    //{
                    //    base12 += item.do_subtotal;
                    //    iva += item.do_iva;
                    //}
                    //else
                    //{
                    //    base0 += item.do_total;
                    //}
                    
                    
                    descuento += item.do_descuento;
                    iva += item.do_iva;
                    dSubtotal += item.do_subtotal;

                }

                txeDesc.EditValue = (double)descuento;
                txeSTotaliva.EditValue = (double)iva;
                txeSsubtotal.EditValue = (double)dSubtotal;
                txeSTotal.EditValue = Convert.ToDouble(txeSsubtotal.EditValue) + Convert.ToDouble(txeSTotaliva.EditValue) ;

                //txeSsubtotal.EditValue = (double)base0 + (double)base12;
                //txeSsubtotal0.EditValue = (double)base0;
                //txeIva.EditValue = (double)base12;
                //txeIva.EditValue = (double)dSubtotal;

                //txeSTotal.EditValue = Convert.ToDouble(txeSsubtotal.EditValue) + Convert.ToDouble(txeSTotaliva.EditValue) + Convert.ToDouble(txeFlete.EditValue);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void convertir_info(BindingList<com_ordencompra_local_det_Info> listDetTabla)
        {
            try
            {
                LstDetOC = new List<com_ordencompra_local_det_Info>();

                if (listDetTabla == null)
                { return; }


                foreach (var item in listDetTabla)
                {
                    com_ordencompra_local_det_Info info = new com_ordencompra_local_det_Info();
                    info.IdProducto = item.IdProducto;
                    info.codproducto = BusProducto.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa).pr_descripcion;
                    desc_producto = info.codproducto;

                    info.do_peso = item.do_peso;

                    //info.dm_cantidad = item.do_Cantidad;
                    info.do_Cantidad = item.do_Cantidad;

                    info.do_Costeado = "N";
                    info.do_precioCompra = item.do_precioCompra;
                    info.do_porc_des = item.do_porc_des;
                    info.do_descuento = item.do_descuento;
                    info.do_subtotal = item.do_subtotal;
                    info.do_iva = item.do_iva;
                    info.Secuencia = item.Secuencia;
                    info.do_total = item.do_total;

                    //info.do_ManejaIva = (item.Paga_Iva == true) ? "S" : "N";

                    //info.do_observacion = (item.DetallexItems == null) ? "" : item.DetallexItems;

                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.IdUnidadMedida = item.IdUnidadMedida;

                    if (OCInfo.IdOrdenCompra == 0)
                    {
                        decimal temp = (BusOC.GetId(param.IdEmpresa, OCInfo.IdSucursal));
                        temp = (temp <= 0) ? 1 : temp;

                        info.IdOrdenCompra = temp;
                    }
                    else
                        info.IdOrdenCompra = OCInfo.IdOrdenCompra;
                    info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                    info.IdEmpresa = param.IdEmpresa;

                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    LstDetOC.Add(info);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private Boolean modificarcantregistros()
        {
            try
            {

                string msg = "";
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus busti = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus();

                    com_ordencompra_local_det_Info info = new com_ordencompra_local_det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = OCInfo.IdSucursal;
                    info.IdOrdenCompra = OCInfo.IdOrdenCompra;
                    info.Secuencia = 1;

                    var ti = busti.Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider(info, ref msg);
                    if (ti.goc_IdDetTrans > 0)
                        return false;
                    else
                        return true;
                }
                else if (Accion == Cl_Enumeradores.eTipo_action.grabar) return true; else return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        private void setInfo()
        {
            try
            {
                if (InfoCab != null)
                {
                    OCInfo = InfoCab;
                }
                else
                {
                    InfoCab = OCInfo;
                }

                txtIdOC.Text = Convert.ToString(InfoCab.IdOrdenCompra);
                txtNumOC.Text = InfoCab.oc_NumDocumento;
                txtPlazo.Text = Convert.ToString(InfoCab.oc_plazo);
                txtObservacion.Text = InfoCab.oc_observacion;
                ucGe_Sucursal_combo1.set_SucursalInfo(OCInfo.IdSucursal);
                ucCp_Proveedor1.set_ProveedorInfo(OCInfo.IdProveedor);

                //cmbTermPago.EditValue = OCInfo.IdTerminoPago;
                //TERMINO PAGO UC
                ucCom_TerminoPagoCmb1.set_TermPagoInfo(OCInfo.IdTerminoPago);

                 ucCom_Comprador1.set_CompradorInfo(OCInfo.IdComprador);
                
                dtpFechaEntrega.Value = InfoCab.oc_fechaVencimiento;
                if (InfoCab.Estado == "I")
                {
                    set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                }
                LstDetOC = BusDetOC.Get_List_ordencompra_local_det(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, Convert.ToInt32(InfoCab.IdOrdenCompra));
                
                convertir_infotabla(LstDetOC);
                gridControlOrdenCompra.DataSource = lista_detalle;

                //convertir_infotabla(LstDetOC);
                //gridControlOrdenCompra.DataSource = ListaBind;


                com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_OCxSC = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
                List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> list_OCxSC = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
                list_OCxSC = bus_OCxSC.Get_List_ordencompra_local_det_x_com_solicitud_compra_det_x_Solicitud(InfoCab.IdEmpresa, InfoCab.IdSucursal, InfoCab.IdOrdenCompra);

                if (list_OCxSC.Count == 0)
                {
                }
                else
                {
                    var item2 = list_OCxSC.FirstOrDefault(q => q.ocd_IdEmpresa == InfoCab.IdEmpresa && q.ocd_IdSucursal == InfoCab.IdSucursal && q.ocd_IdOrdenCompra == InfoCab.IdOrdenCompra);

                    com_solicitud_compra_det_aprobacion_Bus bus_SCDetAprob = new com_solicitud_compra_det_aprobacion_Bus();
                    List<com_solicitud_compra_det_aprobacion_Info> list_SCDetAprob = new List<com_solicitud_compra_det_aprobacion_Info>();
                    list_SCDetAprob = bus_SCDetAprob.Get_List_solicitud_compra_det_aprobacion(item2.scd_IdEmpresa, item2.scd_IdSucursal, item2.scd_IdSolicitudCompra);

                    List<com_solicitud_compra_det_Info> list_DetSC = new List<com_solicitud_compra_det_Info>();

                    foreach (var item in list_SCDetAprob)
                    {
                        foreach (var item3 in list_OCxSC)
                        {
                            if (item3.scd_IdEmpresa == item.IdEmpresa && item3.scd_IdSucursal == item.IdSucursal_SC && item3.scd_IdSolicitudCompra == item.IdSolicitudCompra && item3.scd_Secuencia == item.Secuencia_SC)
                            {
                                com_solicitud_compra_det_Info info = new com_solicitud_compra_det_Info();
                                info.NomProducto = item.NomProducto_SC;
                                info.IdProducto = item.IdProducto_SC;
                                info.do_Cantidad = item.Cantidad_aprobada;
                                info.IdSolicitudCompra = item.IdSolicitudCompra;

                                list_DetSC.Add(info);

                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadProductos()
        {
            try
            {
                //SE CAMBIA EL OBTNER LA LISTA DE PRODUCTOS DEBIDO A QUE NO SE NECESITA 
                //EL HISTORICO DE PRECIOS QUE TRAE LA FUNCION COMENTADA
                ////Lista_producto = _ProductoBus.Get_list_Producto(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);

                //NO SE ELIJE Get_list_ProductosMateriaPrima porque un elemento tambien es materia prima.
                //por lo cual se debe pasar como parametro el idTipoPRoducto en la funcion Get_list_ProductosMateriaPrimaDimension_x_TipoProducto
                //Lista_producto = _ProductoBus.Get_list_ProductosMateriaPrima(param.IdEmpresa);
                Lista_producto = _ProductoBus.Get_list_ProductosMateriaPrimaDimension_x_TipoProducto(param.IdEmpresa, Convert.ToInt16(_Parametros_Info.IdProductoTipo_MateriaPrima));
                
                cmbProductoCodigo.DataSource = Lista_producto;
                cmbProductoCodigo.ValueMember = "IdProducto";
                cmbProductoCodigo.DisplayMember = "pr_descripcion";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }  
        void Inhabilita_Controles()
        {
            try
            {
                this.txtIdOC.Enabled = false;
                this.txtIdOC.BackColor = System.Drawing.Color.White;
                this.txtIdOC.ForeColor = System.Drawing.Color.Black;

                this.txtNumOC.Enabled = false;
                this.txtNumOC.BackColor = System.Drawing.Color.White;
                this.txtNumOC.ForeColor = System.Drawing.Color.Black;



                this.dTPFecha.Enabled = false;

                //  this.cmb_sucursal.Enabled = false;

                //this.cmbTermPago.Enabled = false;
                //this.cmbTermPago.BackColor = System.Drawing.Color.White;
                //this.cmbTermPago.ForeColor = System.Drawing.Color.Black;

                this.ucCom_TerminoPagoCmb1.Enabled = false;
                this.ucCom_TerminoPagoCmb1.BackColor = System.Drawing.Color.White;
                this.ucCom_TerminoPagoCmb1.ForeColor = System.Drawing.Color.Black;


                this.ucCp_Proveedor1.Enabled = false;
                this.ucCp_Proveedor1.BackColor = System.Drawing.Color.White;
                this.ucCp_Proveedor1.ForeColor = System.Drawing.Color.Black;

                this.cmbEstadoAprob.Enabled = false;
       

                


               

             

                this.txtPlazo.Enabled = false;
                this.txtPlazo.BackColor = System.Drawing.Color.White;
                this.txtPlazo.ForeColor = System.Drawing.Color.Black;



                this.txtObservacion.Enabled = false;
                this.txtObservacion.BackColor = System.Drawing.Color.White;
                this.txtObservacion.ForeColor = System.Drawing.Color.Black;

                gridViewOrdenCompra.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void cargacombos()
        {
            try
            {
                string estadoAprob = "";

                List<com_Catalogo_Info> listEstaAprob = new List<com_Catalogo_Info>();
                listEstaAprob = Catalogo_bus.Get_ListEstadoAprobacion();
                com_parametro_Info InfoComDev = new com_parametro_Info();
                InfoComDev = Bus_ParamCompra.Get_Info_parametro(param.IdEmpresa);
                estadoAprob = InfoComDev.IdEstadoAprobacion_OC;
                if (OCInfo.IdSucursal == null || OCInfo.IdSucursal == 0)

                    ucGe_Sucursal_combo1.Incializar_cmbsucursal();
                    ucCom_TerminoPagoCmb1.Inicializar_cmbTermPago();

                LstInfoProv = BusProv.Get_List_proveedor(param.IdEmpresa);
                LstTermPago = BusTermPago.Get_List_TerminoPago();

                //cmbTermPago.Properties.DataSource = LstTermPago;
                
                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
               // cmbPuntoCargo.DataSource = listPuntoCargo;
                BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                BusCentroCosto = new ct_Centro_costo_Bus();
                list_centroCosto = BusCentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                //cmbCentroCosto.DataSource = list_centroCosto;
                listMotivo = bus_Motivo.Get_List_Motivo_Orden_Compra(param.IdEmpresa);
                in_UnidadMedida_Bus bus_UniMedida = new in_UnidadMedida_Bus();
                List<in_UnidadMedida_Info> listUniMedidad = new List<in_UnidadMedida_Info>();
                listUniMedidad = bus_UniMedida.Get_list_UnidadMedida();

                //cmbUniMedida_grid.DataSource = listUniMedidad;
                //cmbUniMedida_grid.DisplayMember = "Descripcion";
                //cmbUniMedida_grid.ValueMember = "IdUnidadMedida";



                tb_sis_impuesto_Bus Bus_sis_impuesto = new tb_sis_impuesto_Bus();
                listTipoImpu_x_Iva = Bus_sis_impuesto.Get_List_impuesto_para_Compras("IVA");
                cmbTipoImpuesto1.DataSource = listTipoImpu_x_Iva;
                cmbTipoImpuesto1.ValueMember="IdCod_Impuesto";
                cmbTipoImpuesto1.DisplayMember = "nom_impuesto";

                string sEstadoCierre = "";

                sEstadoCierre = InfoComDev.IdEstado_cierre;


                list_estadoCierre = Bus_estado_cierre.Get_List_estado_cierre();
               





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
                txtIdOC.Text = "";
                txtNumOC.Text = "";

                txtObservacion.Text = "";
                //cmbTermPago.EditValue = null;
                //ucCom_Comprador1.EditValue = null;
                dTPFecha.Value = DateTime.Now;
                txtPlazo.Text = "0";
                txeSsubtotal0.EditValue = 0;
                txeIva.EditValue = 0;
                txeDesc.EditValue = 0;
                txeSsubtotal.EditValue = 0;
                txeSTotaliva.EditValue = 0;
                txeSTotal.EditValue = 0;
                colCodigo_Producto.OptionsColumn.AllowEdit = true;
                //ListaBind = new BindingList<Tabla_pedido_det_Info>();
                //gridControlOrdenCompra.DataSource = ListaBind;
                ListDetSolCom = new List<com_solicitud_compra_det_Info>();
                //gridControlSolicitud.DataSource = ListDetSolCom;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private Boolean getcab()
        {
            try
            {
                if (validaciones())
                {
                    OCInfo.IdEmpresa = param.IdEmpresa;
                    OCInfo.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal; //Convert.ToInt32(cmb_sucursal.EditValue);
                    OCInfo.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;

                    //OCInfo.IdTerminoPago = Convert.ToString(cmbTermPago.EditValue);

                    OCInfo.IdTerminoPago = ucCom_TerminoPagoCmb1.get_TermPagoInfo().IdTerminoPago;
                    
                    OCInfo.oc_NumDocumento = txtNumOC.Text;
                    OCInfo.oc_observacion = txtObservacion.Text;
                    txtObservacion.Focus();
                    OCInfo.oc_plazo = Convert.ToInt32((txtPlazo.Text == "") ? 0 : Convert.ToInt32(txtPlazo.Text));
                    OCInfo.IdComprador = ucCom_Comprador1.get_CompradorInfo().IdComprador;
                    OCInfo.oc_fecha = Convert.ToDateTime(dTPFecha.Value.ToShortDateString());

                    OCInfo.oc_fechaVencimiento = Convert.ToDateTime(dtpFechaEntrega.Value.ToShortDateString());

                    OCInfo.IdUsuario = param.IdUsuario;
                    OCInfo.IdMotivo = 1;
                    OCInfo.IdEstadoAprobacion_cat = "xAPRO";
                    OCInfo.IdEstado_cierre = "";
                    if (getdet()) return true; 
                    else return false;
                }
                else return false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public void anular()
        {
            try
            {
                if (OCInfo != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (OCInfo.Estado == "A" && OCInfo.IdEstadoRecepcion_cat != "REC")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular/reprobar y reversar la Orden de Compra N#: " + OCInfo.oc_NumDocumento + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            OCInfo.oc_observacion = "***ANULADO****" + OCInfo.oc_observacion;
                            OCInfo.MotivoAnulacion = oFrm.motivoAnulacion;
                         //   getparamanular();
                            OCInfo.oc_observacion = "***ANULADO****" + OCInfo.oc_observacion;
                            if (BusOC.ReversarOC(OCInfo, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Orden de Compra", OCInfo.IdOrdenCompra);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                // MessageBox.Show("Anulado con éxito la Orden de Compra # " + OCInfo.IdOrdenCompra + "\n ID: " + OCInfo.IdOrdenCompra);
                                OCInfo.Estado = "I";

                              
                                set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                            }
                        }
                    }
                    else if (OCInfo.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la Orden de Compra N#: " + OCInfo.oc_NumDocumento +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (OCInfo.IdEstadoRecepcion_cat == "REC")
                    {
                        MessageBox.Show("No se puede anular la Orden de Compra N#: " + OCInfo.oc_NumDocumento +
                            ", ya ha sido recibida.", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

    

        public void convertir_infotabla(List<com_ordencompra_local_det_Info> ListaDetOC)
        {
            try
            {
                lista_detalle = new BindingList<com_ordencompra_local_det_Info>();

                foreach (var item in ListaDetOC)
                {
                    com_ordencompra_local_det_Info info = new com_ordencompra_local_det_Info();
                    info.IdProducto = item.IdProducto;
                    info.codproducto = BusProducto.Get_Codigo_Producto(param.IdEmpresa, item.IdProducto);
                    info.producto = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);

                    //info.dm_cantidad = item.do_Cantidad;
                    info.do_Cantidad = item.do_Cantidad;

                    info.do_peso = item.do_peso;
                    info.do_precioCompra = item.do_precioCompra;
                    info.do_porc_des = item.do_porc_des;
                    info.do_descuento = item.do_descuento;
                    info.Secuencia = item.Secuencia;
                    info.do_subtotal = item.do_subtotal;
                    info.do_iva = item.do_iva;
                    info.do_total = item.do_total;
                    //info.Paga_Iva = (item.do_ManejaIva == "S") ? true : false;
                    info.Por_Iva = item.Por_Iva;
                    //info.DetallexItems = item.do_observacion;
                    info.do_observacion = item.do_observacion;
                    info.Esta_en_base = "S";
                    info.Tiene_despacho = "N";
                    info.Tiene_Movi_Inven = "N"; // pendiente de encontrar

                    info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.IdUnidadMedida = item.IdUnidadMedida;

                    info.Nomsub_centro_costo = item.Nomsub_centro_costo;

                    if (item.do_Cantidad != 0)
                    {
                        lista_detalle.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public void convertir_infotablaSolicitud(List<com_solicitud_compra_det_Info> ListaDetSC)
        {
            try
            {
                lista_detalle = new BindingList<com_ordencompra_local_det_Info>();
                foreach (var item in ListaDetSC)
                {
                    com_ordencompra_local_det_Info info = new com_ordencompra_local_det_Info();
                    info.IdProducto = Convert.ToDecimal(item.IdProducto);

                    //info.dm_cantidad = item.do_Cantidad;
                    info.do_Cantidad = item.do_Cantidad;

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    
                    //info.IdSolicitudCompra = item.IdSolicitudCompra;
                    info.IdOrdenCompra = item.IdSolicitudCompra;

                    info.Secuencia = item.Secuencia;
                    info.do_peso = item.Peso;
                    info.do_precioCompra = item.Precio;
                    info.do_porc_des = item.Porc_Descuento;
                    info.do_descuento = item.Descuento;
                    info.do_precioFinal = item.PrecioFinal;
                    info.do_subtotal = item.Subtotal;
                    info.do_iva = item.Iva;
                    info.do_total = item.Total;

                    //info.Paga_Iva = item.Paga_Iva;
                    //info.Por_Iva = item.ivaPor_Iva;

                    //info.DetallexItems = item.DetallexItems;
                    info.do_observacion = item.do_observacion;

                    info.IdUnidadMedida = item.IdUnidadMedida;

                    if (info.IdProducto == 0)
                    {
                        //info.Ico1 = (Bitmap)imageList1.Images[0];
                    }

                    if (item.do_Cantidad != 0)
                    {
                        lista_detalle.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewOrdenCompra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {


                com_ordencompra_local_det_Info fila_OC_det = new com_ordencompra_local_det_Info();
                fila_OC_det = (com_ordencompra_local_det_Info)gridViewOrdenCompra.GetFocusedRow();

                double Iva = 0;
                double Por_Iva = 0;
                double Total = 0;



                if (e.Column.Name == "colCodigo_Producto")
                {
                    
                    Item = Lista_producto.First(v => v.IdProducto == Convert.ToDecimal(Cod_Producto));
                    gridViewOrdenCompra.SetFocusedRowCellValue(colPeso, Item.pr_peso);
                    gridViewOrdenCompra.SetFocusedRowCellValue(colPrecio, Item.pr_precio_publico);
                    gridViewOrdenCompra.SetFocusedRowCellValue(colCantidad, 0);

                    //gridViewOrdenCompra.SetFocusedRowCellValue(colIdCod_Impuesto, (Item.pr_ManejaIva == "S") ? true : false);

                    tb_sis_impuesto_Info Info_Imp_Iva = new tb_sis_impuesto_Info();
                    Info_Imp_Iva = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Item.IdCod_Impuesto_Iva);

                    if (Info_Imp_Iva != null)
                    {
                        gridViewOrdenCompra.SetFocusedRowCellValue(colIdCod_Impuesto, Info_Imp_Iva.IdCod_Impuesto);
                    }



                }
                else
                {

                    if (e.Column.Name == "colCantidad" || e.Column.Name == "colPrecio" || e.Column.Name == "colPorc_Descuento")
                    {
                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colCantidad, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad)) * -1);
                        }

                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colPrecio, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio)) * -1);
                        }

                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colPorc_Descuento, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)) * -1);
                        }

                        double precio = Math.Round(Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio)), 2);
                        int cantidad = Convert.ToInt32(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad));



                        double Porc_Descuento = Math.Round(Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)), 2);

                        double Descuento = Math.Round((Porc_Descuento * precio) / 100, 2);

                        double PrecioFinal = Math.Round((precio - Descuento), 2);

                        double subtotal = Math.Round((PrecioFinal * cantidad), 2);

                        Iva = 0;
                        Por_Iva = 0;
                        Total = 0;

                        gridViewOrdenCompra.SetFocusedRowCellValue(colDescuento, Descuento);

                        gridViewOrdenCompra.SetFocusedRowCellValue(colPrecioFinal, PrecioFinal);

                        gridViewOrdenCompra.SetFocusedRowCellValue(colSubtotal, subtotal);

                        tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                        InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == fila_OC_det.IdCod_Impuesto);

                        if (InfoTipoImpuesto != null)
                        {
                            Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                            Por_Iva = InfoTipoImpuesto.porcentaje;
                        }


                        gridViewOrdenCompra.SetFocusedRowCellValue(colIva, Iva);
                        gridViewOrdenCompra.SetFocusedRowCellValue(colPor_Iva, Por_Iva);


                        Total = subtotal + Iva;
                        gridViewOrdenCompra.SetFocusedRowCellValue(colTotal, Total);

                        //////if (Convert.ToBoolean(gridViewOrdenCompra.GetFocusedRowCellValue(colIdCod_Impuesto)) == true)
                        //////{
                        //////    gridViewOrdenCompra.SetFocusedRowCellValue(colIva, Math.Round(((subtotal * param.iva.porcentaje) / 100), 2));
                        //////}
                        //////else
                        //////{
                        //////    gridViewOrdenCompra.SetFocusedRowCellValue(colIva, 0);
                        //////}

                        gridViewOrdenCompra.SetFocusedRowCellValue(colTotal, Math.Round(subtotal + Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colIva)), 2));
                    }
                }


                ct_centro_costo_sub_centro_costo_Bus busSubCen = new ct_centro_costo_sub_centro_costo_Bus();




                convertir_info(lista_detalle);

                calculos2(LstDetOC);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyValue.ToString() == "46")
               {                                            
                if (listDetSoli.Count() != 0)
                {   
                    return;                                     
                }
                              
                if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    gridViewOrdenCompra.DeleteSelectedRows();


                    convertir_info(lista_detalle);

                    calculos2(LstDetOC);
                }              
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();

                if (getcab())
                {
                    grabar();
                  
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();

                if (getcab())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        public void imprimir()
        {
            try
            {
                //-- CARLOS ACTALIZACION

                XPRO_CUS_CID_Rpt002 Xrpt_ListMat = new XPRO_CUS_CID_Rpt002();
                com_rpt_ListadoMateriales_Info InfoRptListMat = new com_rpt_ListadoMateriales_Info();
                XPRO_CUS_CID_Rpt002_Bus ObtDatos = new XPRO_CUS_CID_Rpt002_Bus();
                List<com_rpt_ListadoMateriales_Info> LstInfoRep = new List<com_rpt_ListadoMateriales_Info>();


                var cab = ObtDatos.OptenerData_spPRD_Rpt_RPRD002(param.IdEmpresa, Convert.ToInt32(InfoCab.IdOrdenCompra));
                if (cab != null)
                {

                    Xrpt_ListMat.loadData(cab.ToList());
                    Xrpt_ListMat.ShowPreviewDialog();

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al cargar los datos. "
                        + "Por favor comuniquese con sistemas...");
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewOrdenCompra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_ordencompra_local_det_Info row = new com_ordencompra_local_det_Info();
                row = (com_ordencompra_local_det_Info)gridViewOrdenCompra.GetFocusedRow();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        
            
        }

       

        private void cmbProductoCodigo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                Cod_Producto = Convert.ToDecimal(e.NewValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControlOrdenCompra_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //gridControlOrdenCompra.DataSource = BusCotizacion.Get_list_Cotizacion_detalle(param.IdEmpresa, Convert.ToInt32(txtCotizacion.Text), ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);
                if(!String.IsNullOrEmpty(txtCotizacion.Text))
                {
                    ListaCotizacion = BusCotizacion.Get_list_Cotizacion_detalle(param.IdEmpresa, Convert.ToInt32(txtCotizacion.Text), ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);
                    convertir_infotablaCotizacion_a_OC(ListaCotizacion);
                    gridControlOrdenCompra.DataSource = lista_detalle;
                }
                else
                {
                    MessageBox.Show("Ingrese una Cotizacion");
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        public void convertir_infotablaCotizacion_a_OC(List<com_cotizacion_compra_det_Info> ListaDetCot)
        {
            try

            {
                lista_detalle_x_cotizacion = new BindingList<com_ordencompra_local_det_Info>();
                //lista_detalle_x_cotizacion = Lista_producto;
                lista_detalle = new BindingList<com_ordencompra_local_det_Info>();
                listaRegOC_x_Cot = new List<com_Registro_OrdenCompra_x_Cotizacion_Info>();
                tb_sis_impuesto_Info Info_Imp_Iva = new tb_sis_impuesto_Info();
               
                    foreach (var item in ListaDetCot)
                    {
                        com_ordencompra_local_det_Info info = new com_ordencompra_local_det_Info();
                        com_Registro_OrdenCompra_x_Cotizacion_Info infoRegOC_x_Cot = new com_Registro_OrdenCompra_x_Cotizacion_Info();

                        info.IdProducto = Convert.ToDecimal(item.IdProducto);
                        foreach (var itemPro in Lista_producto)
                        {
                            if (itemPro.IdProducto == item.IdProducto) 
                            {
                                //info.dm_cantidad = item.do_Cantidad;
                                info.do_Cantidad = item.Cant_a_cotizar;

                                info.IdEmpresa = item.IdEmpresa;
                                info.IdSucursal = item.IdSucursal;

                                //info.IdSolicitudCompra = item.IdSolicitudCompra;
                                //info.IdOrdenCompra = item.IdSolicitudCompra;

                                ///////info.Secuencia = itemPro.se;
                                info.do_peso = Convert.ToDouble(itemPro.pr_peso);

                                info.IdCod_Impuesto = itemPro.IdCod_Impuesto_Iva;
                            
                                //info.IdCotizacion = item.IdCotizacion;
                                //info.SecDetalleCotizacion = item.Secuencia;
                                //info.IdDetalle_lq = item.IdDetalle_lq;

                                InfoRegistro_OC_x_Cotizacion.IdEmpresa = item.IdEmpresa;
                                InfoRegistro_OC_x_Cotizacion.IdSucursal = item.IdSucursal;
                                if (InfoRegistro_OC_x_Cotizacion.IdOrdenCompra == 0)
                                {
                                    //decimal temp = (BusOC.GetId(param.IdEmpresa, OCInfo.IdSucursal));
                                    decimal temp = (BusOC.GetId(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal)); 
                                    temp = (temp <= 0) ? 1 : temp;
                                    InfoRegistro_OC_x_Cotizacion.IdOrdenCompra = temp;
                                }
                                InfoRegistro_OC_x_Cotizacion.IdCotizacion = item.IdCotizacion;
                                InfoRegistro_OC_x_Cotizacion.SecuenciaDetalleCotizacion = item.Secuencia;
                                InfoRegistro_OC_x_Cotizacion.IdListadoMateriales = item.IdListadoMateriales_lq;

                                //info.do_precioCompra = itemPro.pr_precio_publico;
    
                            }
                        }

                    

                        if (info.IdProducto == 0)
                        {
                            //info.Ico1 = (Bitmap)imageList1.Images[0];
                        }

                        if (item.Cant_a_cotizar != 0)
                        {
                            lista_detalle.Add(info);
                            listaRegOC_x_Cot.Add(InfoRegistro_OC_x_Cotizacion);
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
