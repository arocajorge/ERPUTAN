using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_Fj;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_Fj;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cus.Erp.Reports.FJ;
using Cus.Erp.Reports.FJ.Inventario;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario_Fj
{
    public partial class FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento : Form
    {
        #region Variables y atributos
        List<in_Producto_Info> Lst_Producto_info = new List<in_Producto_Info>();
        List<in_Producto_Info> Lst_cmb_Producto = new List<in_Producto_Info>();
        in_Producto_Info item = new in_Producto_Info();
        BindingList<in_Orden_servicio_x_Activo_fijo_det_Info> BLst_det_info = new BindingList<in_Orden_servicio_x_Activo_fijo_det_Info>();
        in_Orden_servicio_x_Activo_fijo_det_Bus det_Bus = new in_Orden_servicio_x_Activo_fijo_det_Bus();
        public in_Orden_servicio_x_Activo_fijo_Info OS_Info = new in_Orden_servicio_x_Activo_fijo_Info();
        in_producto_Bus Producto_bus = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Bodega_Info Bodega_info = new tb_Bodega_Info();
        tb_Sucursal_Info Sucursal_info = new tb_Sucursal_Info();
        cp_proveedor_Info Proveedor_info = new cp_proveedor_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion = Cl_Enumeradores.eTipo_action.grabar;
        XINV_FJ_Rpt001_Bus Rpt_Bus = new XINV_FJ_Rpt001_Bus();
        List<XINV_FJ_Rpt001_Info> Rpt_Info_lst = new List<XINV_FJ_Rpt001_Info>();
        string msg = "";
        bool res = false;

        public delegate void delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;

        //--Variables para calculos
        int Cantidad = 0;
        double Costo = 0;
        double Iva = 0;
        double subTotal = 0;
        double Total = 0;
        bool Maneja_Iva = true;

        double sIva = 0;
        double sSubtotal = 0;
        double sTotal = 0;
        #endregion

        public FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento()
        {
            InitializeComponent();
            
        }
        public FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento(Cl_Enumeradores.eTipo_action ACCION)
        {
            InitializeComponent();
            this._Accion = ACCION;
            ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;
            ucIn_Sucursal_Bodega1.Event_cmb_sucursal1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;

            event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing += FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing;
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar())
                            this.Close();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Modificar())
                            this.Close();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        if (Anular())
                            this.Close();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar())
                            LimpiarCampos();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Modificar())
                            LimpiarCampos();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        if (Anular())
                            LimpiarCampos();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.duplicar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ucIn_Sucursal_Bodega1.InicializarBodega(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridControlActivoFijo.DataSource = null;
                BLst_det_info = new BindingList<in_Orden_servicio_x_Activo_fijo_det_Info>();
                Bodega_info = ucIn_Sucursal_Bodega1.get_bodega();
                Sucursal_info = ucIn_Sucursal_Bodega1.get_sucursal();
                if (Bodega_info != null && Sucursal_info != null)
                {
                    Lst_cmb_Producto = Lst_Producto_info.Where(q => q.IdSucursal == Sucursal_info.IdSucursal && q.IdBodega == Bodega_info.IdBodega).ToList();
                    cmb_Producto.DataSource = Lst_cmb_Producto;
                    gridControlActivoFijo.DataSource = BLst_det_info;
                }
                else
                    cmb_Producto.DataSource = Lst_Producto_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CargarListas()
        {
            try
            {
                
                gridControlActivoFijo.DataSource = BLst_det_info;
                ucaF_Activo_Fijo1.Cargar_Combo();
                Lst_Producto_info = Producto_bus.Get_list_Productos_x_Empresa(param.IdEmpresa);
                cmb_Producto.DataSource = Lst_Producto_info;
                cmb_Producto.DisplayMember = "pr_descripcion";
                cmb_Producto.ValueMember = "IdProducto";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                
                OS_Info = new in_Orden_servicio_x_Activo_fijo_Info();
                this.Text = "Orden de servicio por activo fijo ***NUEVO REGISTRO***";
                BLst_det_info = new BindingList<in_Orden_servicio_x_Activo_fijo_det_Info>();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_Accion(_Accion);
                lblAnulado.Visible = false;

                gridControlActivoFijo.DataSource = null;
                gridControlActivoFijo.DataSource = BLst_det_info;
                txtId_OrdenSer.Text = string.Empty;
                ucCp_Proveedor1.Inicializar_cmbProveedor();
                ucCon_CentroCosto_ctas_Movi1.Inicializar_cmbCentroCosto();
                ucIn_Sucursal_Bodega1.InicializarSucursal();
                ucIn_Sucursal_Bodega1.InicializarBodega();
                deFecha.EditValue = DateTime.Now;
                txtNoDoc.Text = string.Empty;
                txtNoFact.Text = string.Empty;
                ucaF_Activo_Fijo1.InicializarActivoFijo();
                txtObservacion.Text = string.Empty;
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewActivoFijo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                in_Orden_servicio_x_Activo_fijo_det_Info row = new in_Orden_servicio_x_Activo_fijo_det_Info();
                row = (in_Orden_servicio_x_Activo_fijo_det_Info)gridViewActivoFijo.GetFocusedRow();

                int cont = 0;
                if (row != null)
                {
                    if (row.IdProducto != 0)
                    {
                        cont = BLst_det_info.Where(q => q.IdProducto == row.IdProducto).Count();
                    }
                }

                
                if (cont > 1)
                {
                    MessageBox.Show("El Producto : " + item.pr_descripcion + " ya se encuentra en el Detalle. Se procederá a Eliminar", "Sistemas");
                    gridViewActivoFijo.DeleteSelectedRows();
                }

                if (e.Column.Name == colProducto.Name)
                {
                    item = Lst_Producto_info.FirstOrDefault(q => q.IdProducto == Convert.ToDecimal(e.Value));
                    if (item != null)
                    {
                        gridViewActivoFijo.SetFocusedRowCellValue(colIdProducto, item.IdProducto);
                        gridViewActivoFijo.SetFocusedRowCellValue(colManeja_Iva, (item.pr_ManejaIva.Equals("S         ") ? true : false));
                    }
                    else
                        MessageBox.Show("Debe seleccionar una bodega primero", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                if (e.Column.Name == colCantidad.Name || e.Column.Name == colCosto.Name || e.Column.Name == colManeja_Iva.Name)
                {
                    if (Convert.ToInt32(gridViewActivoFijo.GetFocusedRowCellValue(colCantidad))<0)
                    {
                        gridViewActivoFijo.SetFocusedRowCellValue(colCantidad, Convert.ToInt32(gridViewActivoFijo.GetFocusedRowCellValue(colCantidad)) * -1);
                    }
                    if (Convert.ToInt32(gridViewActivoFijo.GetFocusedRowCellValue(colCosto)) < 0)
                    {
                        gridViewActivoFijo.SetFocusedRowCellValue(colCantidad, Convert.ToInt32(gridViewActivoFijo.GetFocusedRowCellValue(colCosto)) * -1);
                    }

                    Cantidad = Convert.ToInt32(gridViewActivoFijo.GetFocusedRowCellValue(colCantidad));
                    Costo = Convert.ToDouble(gridViewActivoFijo.GetFocusedRowCellValue(colCosto));
                    subTotal = Math.Round(Cantidad * Costo, 2);
                    Maneja_Iva = Convert.ToBoolean(gridViewActivoFijo.GetFocusedRowCellValue(colManeja_Iva));
                    if (Maneja_Iva)
                        Iva = Math.Round((subTotal * param.iva.porcentaje) / 100, 2);
                    else
                        Iva = 0;
                    
                    
                    Total = Math.Round(subTotal + Iva, 2);

                    gridViewActivoFijo.SetFocusedRowCellValue(colSubTotal, subTotal);
                    gridViewActivoFijo.SetFocusedRowCellValue(colIva, Iva);
                    gridViewActivoFijo.SetFocusedRowCellValue(colTotal, Total);

                    CalcularTotales();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewActivoFijo_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotales()
        {
            try
            {
                sSubtotal = 0;
                sIva = 0;
                sTotal = 0;

                foreach (var item in BLst_det_info)
                {
                    sSubtotal += item.SubTotal;
                    sIva += item.Iva;
                    sTotal += item.Total;
                }
                txeSsubtotal.Text = sSubtotal.ToString();
                txeSTotaliva.Text = sIva.ToString();
                txeSTotal.Text = sTotal.ToString();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewActivoFijo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)Keys.Delete)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewActivoFijo.DeleteSelectedRows();
                        CalcularTotales();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Guardar()
        {
            try
            {
                res = false;
                string msg = "";
                in_Orden_servicio_x_Activo_fijo_Bus Bus = new in_Orden_servicio_x_Activo_fijo_Bus();

                if (get_Det())
                {
                    if (Bus.GuardarDB(OS_Info, ref msg))
                    {
                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Orden de servicio ", OS_Info.IdOrdenSer_x_Af);
                        MessageBox.Show(smensaje, param.Nombre_sistema);

                        txtId_OrdenSer.Text = OS_Info.IdOrdenSer_x_Af.ToString();


                        if (MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msg_Pregunta_Imprimir, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        res = false;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Modificar()
        {
            try
            {
                res = false;
                in_Orden_servicio_x_Activo_fijo_Bus Bus = new in_Orden_servicio_x_Activo_fijo_Bus();

                if (get_Det())
                {
                    if (Bus.ActualizarDB(OS_Info, ref msg))
                    {
                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Orden de servicio ", OS_Info.IdOrdenSer_x_Af);
                        MessageBox.Show(smensaje, param.Nombre_sistema);

                        if (MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msg_Pregunta_Imprimir, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();

                        }
                    }
                    else
                    {
                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       res = false;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Anular()
        {
            try
            {
                res = false;
                if (MessageBox.Show("¿Está seguro que desea anular la Orden de servicio #: " + OS_Info.IdOrdenSer_x_Af + " ?", "Anulación de Orden de servicio ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    OS_Info.IdUsuarioUltAnu = param.IdUsuario;
                    OS_Info.FechaHoraAnul = DateTime.Now;
                    OS_Info.motivoAnulacion = ofrm.motivoAnulacion;



                    in_Orden_servicio_x_Activo_fijo_Bus Bus = new in_Orden_servicio_x_Activo_fijo_Bus();
                    if (Bus.AnularDB(OS_Info))
                    {

                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Orden de servicio ", OS_Info.IdOrdenSer_x_Af);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        lblAnulado.Visible = true;
                        
                    }
                    else
                    {
                        
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        res = false;
                    }
                }
                return res;
   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool get_Det()
        {
            try
            {
                if (BLst_det_info.Count() == 0)
                {
                    MessageBox.Show("Debe agregar un Servicio a la Orden ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                foreach (var Serv in BLst_det_info)
                {
                    if (Serv.Cantidad == 0)
                    {
                        this.item = Lst_Producto_info.FirstOrDefault(q => q.IdProducto == Serv.IdProducto);
                        MessageBox.Show("Debe ingresar la cantidad al servicio " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (Serv.Costo == 0)
                    {
                        this.item = Lst_Producto_info.FirstOrDefault(q => q.IdProducto == Serv.IdProducto);
                        MessageBox.Show("Debe ingresar el costo al servicio " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                Sucursal_info = ucIn_Sucursal_Bodega1.get_sucursal();
                Bodega_info = ucIn_Sucursal_Bodega1.get_bodega();
                Proveedor_info = ucCp_Proveedor1.get_ProveedorInfo();
                

                OS_Info.IdActivoFijo = ucaF_Activo_Fijo1.GetId_Activo_fijo();
                OS_Info.IdBodega = Bodega_info == null ? 0 :Bodega_info.IdBodega;
                OS_Info.IdSucursal = Sucursal_info == null ? 0 : Sucursal_info.IdSucursal;
                OS_Info.IdProveedor = Proveedor_info == null ? 0 : Proveedor_info.IdProveedor;
                OS_Info.IdEmpresa = param.IdEmpresa;
                OS_Info.Num_Documento = txtNoDoc.Text.Trim();
                OS_Info.Num_Fact = txtNoFact.Text.Trim();
                OS_Info.IdCentroCosto = ucCon_CentroCosto_ctas_Movi1.Get_IdCentroCosto();
                OS_Info.Fecha = deFecha.EditValue == null ? DateTime.Now : (DateTime)deFecha.EditValue;
                OS_Info.Observacion = txtObservacion.Text.Trim();
                OS_Info.List_in_Orden_servicio_x_Activo_fijo_det = new List<in_Orden_servicio_x_Activo_fijo_det_Info>(BLst_det_info);
                OS_Info.Estado = "A";
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                BloquearCampos();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        deFecha.EditValue = DateTime.Now;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Info();
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set_Info();
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;


                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Info();
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;

                        //  btnImportar.Enabled = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;


                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_delegate_FrmIn_Orden_servicio_x_Activo_fijo_Mantenimiento_FormClosing(sender, e);
        }

        private void Set_Info()
        {
            try
            {
                deFecha.EditValue = OS_Info.Fecha;
                string msg="";
                txtId_OrdenSer.Text = OS_Info.IdOrdenSer_x_Af.ToString();
                txtNoDoc.Text = OS_Info.Num_Documento;
                txtNoFact.Text = OS_Info.Num_Fact;
                txtObservacion.Text = OS_Info.Observacion;
                ucCon_CentroCosto_ctas_Movi1.set_IdCentroCosto(OS_Info.IdCentroCosto);
                ucCp_Proveedor1.set_ProveedorInfo(OS_Info.IdProveedor);
                ucaF_Activo_Fijo1.setId_Activo_fijo(OS_Info.IdActivoFijo);
                ucIn_Sucursal_Bodega1.set_Idbodega(OS_Info.IdSucursal ,OS_Info.IdBodega);
                OS_Info.List_in_Orden_servicio_x_Activo_fijo_det = det_Bus.Get_Lista_det_x_Orden_servicio(OS_Info.IdEmpresa, OS_Info.IdSucursal, OS_Info.IdOrdenSer_x_Af,ref msg);
                if (OS_Info.List_in_Orden_servicio_x_Activo_fijo_det.Count()>0)
                {
                    BLst_det_info = new BindingList<in_Orden_servicio_x_Activo_fijo_det_Info>(OS_Info.List_in_Orden_servicio_x_Activo_fijo_det);
                    gridControlActivoFijo.DataSource = BLst_det_info;
                    CalcularTotales();
                }
                if (OS_Info.Estado=="I")
                {
                    lblAnulado.Visible = true;
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearCampos()
        {
            try
            {
                ucaF_Activo_Fijo1.Campos_consulta(_Accion);
                ucIn_Sucursal_Bodega1.Campos_consulta(_Accion);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imprimir()
        {
            try
            {
                if (OS_Info!=null && OS_Info.IdOrdenSer_x_Af!=0)
                {
                    if (OS_Info.Estado != "I")
                    {
                        XINV_FJ_Rpt001_Rpt Rpt = new XINV_FJ_Rpt001_Rpt();
                        Rpt_Bus = new XINV_FJ_Rpt001_Bus();
                        Rpt_Info_lst = Rpt_Bus.Get_OrdenSer_Info(OS_Info.IdEmpresa, OS_Info.IdSucursal, OS_Info.IdBodega, OS_Info.IdOrdenSer_x_Af);
                        Rpt.CargarReporte(Rpt_Info_lst);
                        Rpt.ShowPreviewDialog();
                    }
                    else
                    {
                        MessageBox.Show("La orden de servicio se encuentra anulada.",param.Nombre_sistema,MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
