using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Dev_Compra_Mant : Form
    {
        #region Declaración de variables

        string mensaje = "";
        in_producto_Bus ProdBus = new in_producto_Bus();
        List<cp_proveedor_Info> ListProveedor = new List<cp_proveedor_Info>();

        public delegate void delegate_FrmCom_Dev_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_Dev_Compra_Mant_FormClosing event_FrmCom_Dev_Compra_Mant_FormClosing;
        
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        com_dev_compra_Info _Info_dev_compra = new com_dev_compra_Info();
        Cl_Enumeradores.eTipo_action _Accion { get; set; }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

      
        com_dev_compra_det_Bus devcom_det_bus = new com_dev_compra_det_Bus();       
        List<com_dev_compra_det_Info> listaDetalle = new List<com_dev_compra_det_Info>();
        com_dev_compra_Bus devcom_bus = new com_dev_compra_Bus();        
        BindingList<com_dev_compra_det_Info> DataSource = new BindingList<com_dev_compra_det_Info>();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        in_Producto_Info Item = new in_Producto_Info();
        UCCp_Proveedor proveedor = new UCCp_Proveedor();

        #endregion

        public void Set_Info(com_dev_compra_Info Info_dev_compra)
        {
            _Info_dev_compra = Info_dev_compra;
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            _Accion = Accion;
        }

        private Boolean validar()
        {
            try
            {           

                if (ucIn_Sucursal_Bodega.get_sucursal().IdSucursal==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) +  " la sucursal" ,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ucIn_Sucursal_Bodega.Focus();
                    return false;
                }

                if (ucIn_Sucursal_Bodega.get_bodega().IdBodega== 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucIn_Sucursal_Bodega.Focus();
                    return false;
                }

                if (txtObservacion.Text=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la)  +" la observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtObservacion.Focus();
                    return false;
                }

                if (DataSource.Count()==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer)+  " un item en el detalle", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                int contFor=0;
                int contCerosCant = 0;


                foreach (var item in DataSource)
                {
                    contFor = contFor + 1;

                    if (item.dv_Cantidad == 0)
                    {
                        contCerosCant = contCerosCant + 1;
                    }                    
                }

                if (contFor == contCerosCant)
                {
                    MessageBox.Show("Al menos un item debe tener en la cantidad mas de cero", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void set_info()
        {
            try
            {
                txt_num_dev_compra.Text = _Info_dev_compra.IdDevCompra.ToString();
                ucIn_Sucursal_Bodega.set_Idsucursal(_Info_dev_compra.IdSucursal);
                ucIn_Sucursal_Bodega.set_Idbodega(_Info_dev_compra.IdSucursal,_Info_dev_compra.IdBodega);
                dtpfecha.Value = _Info_dev_compra.dv_fecha;
                txtObservacion.Text = _Info_dev_compra.dv_observacion;
                ucCp_Proveedor1.set_ProveedorInfo( _Info_dev_compra.IdProveedor);
                
                if (_Info_dev_compra.Estado.Trim() == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }

               listaDetalle= devcom_det_bus.Get_List_dev_compra_det(param.IdEmpresa, _Info_dev_compra.IdSucursal, _Info_dev_compra.IdDevCompra);
               
               DataSource = new BindingList<com_dev_compra_det_Info>();

               foreach (com_dev_compra_det_Info item in listaDetalle)
               {
                   DataSource.Add(item);
               }

               gridControl_productos.DataSource = DataSource;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       

        public FrmCom_Dev_Compra_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior.event_btnSalir_Click += ucGe_Menu_Superior_event_btnSalir_Click;
            ucGe_Menu_Superior.event_btnlimpiar_Click += ucGe_Menu_Superior_event_btnlimpiar_Click;
            ucGe_Menu_Superior.event_btnGuardar_Click += ucGe_Menu_Superior_event_btnGuardar_Click;
            ucGe_Menu_Superior.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior.event_btnAnular_Click += ucGe_Menu_Superior_event_btnAnular_Click;

        }

        void ucGe_Menu_Superior_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void anular()
        {
            try
            {
                if (_Info_dev_compra != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (_Info_dev_compra.Estado == "A" )
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular la Devolucion de Compra N#: " + _Info_dev_compra.IdDevCompra + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            _Info_dev_compra.dv_observacion = "***ANULADO****" + _Info_dev_compra.dv_observacion;
                            _Info_dev_compra.MotivoAnulacion = oFrm.motivoAnulacion;

                            _Info_dev_compra.FechaHoraAnul = param.Fecha_Transac;
                            _Info_dev_compra.IdUsuarioUltAnu = param.IdUsuario;

                            _Info_dev_compra.dv_observacion = "***ANULADO****" + _Info_dev_compra.dv_observacion;

                            if (devcom_bus.AnularDB(_Info_dev_compra, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Devolución", _Info_dev_compra.IdDevCompra);
                                MessageBox.Show(smensaje, param.Nombre_sistema);                                
                                _Info_dev_compra.Estado = "I";
                                ucGe_Menu_Superior.Visible_bntAnular = false;
                                lblAnulado.Visible = true;

                                _Accion = Cl_Enumeradores.eTipo_action.consultar;
                                
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, mensaje);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (_Info_dev_compra.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la devolucion de Compra N#: " + _Info_dev_compra.IdDevCompra +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    grabar();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Superior_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_Superior_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void FrmCom_Dev_Compra_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
                set_accion();
                cargar_combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.txt_num_dev_compra.Enabled = false;
                        this.txt_num_dev_compra.BackColor = System.Drawing.Color.White;
                        this.txt_num_dev_compra.ForeColor = System.Drawing.Color.Black;
                        LimpiarDatos();
                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior.Visible_bntAnular = false;
                        ucGe_Menu_Superior.Visible_bntLimpiar = false;


                        this.txt_num_dev_compra.Enabled = false;
                        this.txt_num_dev_compra.BackColor = System.Drawing.Color.White;
                        this.txt_num_dev_compra.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        
                        gridView_productos.OptionsBehavior.Editable = false;
                        this.btnImportar.Enabled = false;


                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;

                        this.txt_num_dev_compra.Enabled = false;
                        this.txt_num_dev_compra.BackColor = System.Drawing.Color.White;
                        this.txt_num_dev_compra.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        gridView_productos.OptionsBehavior.Editable = false;
                        this.btnImportar.Enabled = false;

                        set_info();

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior.Visible_btnGuardar = false;
                        ucGe_Menu_Superior.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior.Visible_bntAnular = false;


                        this.txt_num_dev_compra.Enabled = false;
                        this.txt_num_dev_compra.BackColor = System.Drawing.Color.White;
                        this.txt_num_dev_compra.ForeColor = System.Drawing.Color.Black;

                        this.ucIn_Sucursal_Bodega.Enabled = false;
                        this.ucIn_Sucursal_Bodega.BackColor = System.Drawing.Color.White;
                        this.ucIn_Sucursal_Bodega.ForeColor = System.Drawing.Color.Black;

                        gridView_productos.OptionsBehavior.Editable = false;
                        this.btnImportar.Enabled = false;

                        set_info();
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargar_combo()
        {
            try
            {
                listProducto=ProdBus.Get_list_Producto(param.IdEmpresa);
                cmb_producto.DataSource = listProducto;
                cmb_producto_cod.DataSource = listProducto;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarDatos()
        {
            try
            {
                ucCp_Proveedor1.set_ProveedorInfo(0);
                txt_num_dev_compra.Text = "";
                txtObservacion.Text = "";
                dtpfecha.Value = DateTime.Now;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                DataSource = new BindingList<com_dev_compra_det_Info>();
                gridControl_productos.DataSource = DataSource;
                lblAnulado.Visible = false;
                chkdevolver_total_vta.Checked = false;

                _Info_dev_compra = new com_dev_compra_Info();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txt_num_dev_compra.Focus();
                GetInfo();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                   
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Guardar()
        {
            try
            {
                _Info_dev_compra.Fecha_Transac= param.Fecha_Transac;
                decimal IdDev_compra = 0;

                if (devcom_bus.GuardarDB(_Info_dev_compra ,ref IdDev_compra , ref  mensaje))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Devolución", _Info_dev_compra.IdDevCompra);
                    MessageBox.Show(smensaje, param.Nombre_sistema);                   
                    txt_num_dev_compra.Text = _Info_dev_compra.IdDevCompra.ToString();

                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, mensaje);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            try
            {
               _Info_dev_compra.Fecha_UltMod = param.Fecha_Transac;
               _Info_dev_compra.IdUsuarioUltMod = param.IdUsuario;


               if (devcom_bus.ModificarDB(_Info_dev_compra, ref  mensaje))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Devolución", _Info_dev_compra.IdDevCompra);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, mensaje);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetInfo()
        {
            try
            {
                _Info_dev_compra = new com_dev_compra_Info();


                _Info_dev_compra.IdEmpresa = param.IdEmpresa;
                _Info_dev_compra.IdSucursal = ucIn_Sucursal_Bodega.get_sucursal().IdSucursal;
                _Info_dev_compra.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                _Info_dev_compra.IdBodega = ucIn_Sucursal_Bodega.get_bodega().IdBodega;
                _Info_dev_compra.dv_fecha = Convert.ToDateTime(dtpfecha.Value.ToShortDateString());
                _Info_dev_compra.dv_observacion = txtObservacion.Text;                
                _Info_dev_compra.IdDevCompra =(txt_num_dev_compra.Text == "") ? 0 : Convert.ToDecimal( txt_num_dev_compra.Text);
                _Info_dev_compra.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                _Info_dev_compra.Fecha_UltMod = param.GetDateServer();
                _Info_dev_compra.IdUsuarioUltMod = param.IdUsuario;
                
                List<com_dev_compra_det_Info> listaProd = new List<com_dev_compra_det_Info>();

                for (int i = 0; i < gridView_productos.RowCount; i++)
                {
                    var item = gridView_productos.GetRow(i) as com_dev_compra_det_Info;
                    if (item != null)
                    {
                        listaProd.Add(item);
                    }
                }

                _Info_dev_compra.lista_detalle = listaProd;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_productos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               
                if (e.Column.Name == "colCant_a_devolver" || e.Column.Name == "colPrecio" )
                
                    {

                        if (Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colCant_a_devolver)) < 0)
                        {
                            gridView_productos.SetFocusedRowCellValue(colCant_a_devolver, Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colCant_a_devolver)) * -1);
                        }

                        if (Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPrecio)) < 0)
                        {
                            gridView_productos.SetFocusedRowCellValue(colPrecio, Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPrecio)) * -1);
                        }

                        if (Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPorc_Descuento)) < 0)
                        {
                            gridView_productos.SetFocusedRowCellValue(colPorc_Descuento, Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPorc_Descuento)) * -1);
                        }

                        double precio = Math.Round(Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPrecio)), 2);
                        int cantidad = Convert.ToInt32(gridView_productos.GetFocusedRowCellValue(colCant_a_devolver));
                        double Porc_Descuento = Math.Round(Convert.ToDouble(gridView_productos.GetFocusedRowCellValue(colPorc_Descuento)), 2);
                        double Descuento = Math.Round((Porc_Descuento * precio) / 100, 2);
                        double subtotal = Math.Round((precio * cantidad), 2);

                        gridView_productos.SetFocusedRowCellValue(colDescuento, Descuento);

                        gridView_productos.SetFocusedRowCellValue(colSubtotal, subtotal);

                        if (Convert.ToString(gridView_productos.GetFocusedRowCellValue(colPaga_Iva)) == "S")
                        {
                            gridView_productos.SetFocusedRowCellValue(colIva, (subtotal * param.iva.porcentaje) / 100);
                        }
                        else
                        {
                            gridView_productos.SetFocusedRowCellValue(colIva, 0);
                        }

                        gridView_productos.SetFocusedRowCellValue(colTotal, Math.Round(subtotal + ((subtotal * param.iva.porcentaje) / 100), 2));
                    }
                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_OC_x_Importacion( com_ordencompra_local_Info InfoOC)
        {
            try
            {
                if (InfoOC != null)
                {
                    txtObservacion.Text = txtObservacion.Text.Trim() + " x Dev/compra de la OC#" + InfoOC.IdOrdenCompra + " " + InfoOC.oc_observacion;
                    ucIn_Sucursal_Bodega.set_Idsucursal(InfoOC.IdSucursal);
                    ucIn_Sucursal_Bodega.set_Idbodega(InfoOC.IdSucursal, 1);
                    dtpfecha.Value = DateTime.Now;
                    txtOrdenCompra.Text = InfoOC.IdOrdenCompra.ToString();
                    ucCp_Proveedor1.set_ProveedorInfo(InfoOC.IdProveedor);

                    DataSource = new BindingList<com_dev_compra_det_Info>();

                    int c = 1;

                    foreach (var item in InfoOC.listDetalle)
                    {
                        com_dev_compra_det_Info ItemDv = new com_dev_compra_det_Info();

                        ItemDv.IdEmpresa = item.IdEmpresa;
                        ItemDv.IdSucursal = item.IdSucursal;
                        ItemDv.cod_producto = item.codproducto;
                        ItemDv.dv_Cantidad = 0;
                        ItemDv.cant_devuelta = item.cant_devuelta;
                        ItemDv.saldo_x_devolver = item.saldo_x_devolver;
                        ItemDv.cant_pedida_x_OC = item.do_Cantidad;
                        ItemDv.dv_Costeado = "N";
                        ItemDv.dv_descuento = item.do_descuento;
                        ItemDv.dv_iva = 0;
                        ItemDv.dv_ManejaIva = true;
                        ItemDv.dv_observacion = item.do_observacion;
                        ItemDv.dv_peso = item.do_peso;
                        ItemDv.dv_porc_des = item.do_porc_des;
                        ItemDv.dv_precioCompra = item.do_precioCompra;
                        ItemDv.dv_subtotal = 0;
                        ItemDv.dv_total = 0;
                        ItemDv.Esta_en_base = "N";
                        ItemDv.IdBodega = 1;
                        ItemDv.IdDevCompra = 0;
                        ItemDv.IdProducto = item.IdProducto;
                        ItemDv.Secuencia = c;
                        ItemDv.ocdet_IdEmpresa = item.IdEmpresa;
                        ItemDv.ocdet_IdSucursal = item.IdSucursal;
                        ItemDv.ocdet_IdOrdenCompra = item.IdOrdenCompra;
                        ItemDv.ocdet_Secuencia = item.Secuencia;
                        c++;
                        DataSource.Add(ItemDv);
                    }
                    gridControl_productos.DataSource = DataSource;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void chkdevolver_total_vta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (chkdevolver_total_vta.Checked == true)
                {

                    foreach (var item in DataSource)
                    {
                        item.dv_Cantidad = item.saldo_x_devolver;
                        item.dv_subtotal = (item.dv_Cantidad * item.dv_precioCompra) + (item.dv_Cantidad * item.dv_precioCompra)*item.dv_porc_des/100;
                        item.dv_iva = (item.dv_subtotal * param.iva.porcentaje/100);
                        item.dv_total = item.dv_subtotal + item.dv_iva;
                    }

                }
                else
                {

                    foreach (var item in DataSource)
                    {
                        item.dv_Cantidad = 0;
                        item.dv_subtotal = 0;
                        item.dv_iva = 0;
                        item.dv_total = 0;


                    }
                }

                gridControl_productos.DataSource = null;

                gridControl_productos.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_Dev_Compra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmCom_Dev_Compra_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btnImportar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmCom_Consulta_OrdenCompra frm = new FrmCom_Consulta_OrdenCompra();
                com_ordencompra_local_Info Info_OrdenCompra = new com_ordencompra_local_Info();
                List<com_ordencompra_local_Info> LstOC = new List<com_ordencompra_local_Info>();
                com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();

                //LimpiarDatos();
                if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                {
                    LstOC = BusOC.Get_List_ordencompra_local_x_Proveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                    if (LstOC != null)
                    {
                        if (LstOC.Count != 0)
                        {
                            frm.lista = LstOC;
                            frm.ShowDialog();
                            Info_OrdenCompra = frm.Info_orden_compra;
                            cargar_OC_x_Importacion(Info_OrdenCompra);
                        }
                        else
                        {
                            MessageBox.Show("El Proveedor no tiene Ordenes de Compra ");
                        }
                    }
                }
                else
                    MessageBox.Show("No ha seleccionado ningún proveedor.\nPor favor seleccione un proveedor.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
