using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
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
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Reportes.Roles;
using Core.Erp.Business.Roles_Fj;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;
namespace Core.Erp.Winform.Roles
{
    public partial class FrmRo_Asignacion_Implemento_x_Empleado_Mant : Form
    {
        #region Atributos y variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action _Accion = Cl_Enumeradores.eTipo_action.grabar;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Asignacion_Implemento_x_Empleado_Bus Asig_Imp_Bus = new ro_Asignacion_Implemento_x_Empleado_Bus();
        ro_Asignacion_Implemento_x_Empleado_Info Asig_Imp_Info = new ro_Asignacion_Implemento_x_Empleado_Info();
        ro_Asignacion_Implemento_x_Empleado_det_Info item = new ro_Asignacion_Implemento_x_Empleado_det_Info();
        List<in_Producto_Info> lista_productos = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();
        BindingList<ro_Asignacion_Implemento_x_Empleado_det_Info> lista_detalle = new BindingList<ro_Asignacion_Implemento_x_Empleado_det_Info>();

        ro_Asignacion_Implemento_x_Empleado_det_Bus Asig_Imp_det_Bus = new ro_Asignacion_Implemento_x_Empleado_det_Bus();
        ro_Empleado_Info Empleado_Info = new ro_Empleado_Info();

        in_Ing_Egr_Inven_Info Info_moviemiento_inventario = new in_Ing_Egr_Inven_Info();
        in_Ing_Egr_Inven_Bus bus_Inventario = new in_Ing_Egr_Inven_Bus();
        List<in_Ing_Egr_Inven_det_Info> lista_detalle_movimiento = new List<in_Ing_Egr_Inven_det_Info>();
      //  ro_parametro_Egreso_Ingreso_x_implementos_Bus bus_rol_parametro = new ro_parametro_Egreso_Ingreso_x_implementos_Bus();
       // ro_parametro_Egreso_Ingreso_x_implementos_Info paramatreo_info = new ro_parametro_Egreso_Ingreso_x_implementos_Info();
        ro_Catalogo_Bus bus_catalogo = new ro_Catalogo_Bus();
        List<ro_Catalogo_Info> lista_catalogo = new List<ro_Catalogo_Info>();
        ro_Empleado_Info info_empleado = new ro_Empleado_Info();

        ro_empleado_x_Activo_Fijo_Info info_activo_fijo = new ro_empleado_x_Activo_Fijo_Info();
        ro_empleado_x_Activo_Fijo_Bus bus_Activo_fijo = new ro_empleado_x_Activo_Fijo_Bus();

        Boolean res = false;
        string msg = "";
        
        #endregion

        #region Delegados
        public delegate void delegate_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing;
        #endregion

        public FrmRo_Asignacion_Implemento_x_Empleado_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucRo_Empleado1.event_cmbEmpleado_EditValueChanged += ucRo_Empleado1_event_cmbEmpleado_EditValueChanged;
        }

        void ucRo_Empleado1_event_cmbEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              info_empleado=  ucRo_Empleado1.get_EmpleadoInfo();
              txt_cargo.EditValue = info_empleado.cargo_Descripcion;
              info_activo_fijo = bus_Activo_fijo.Get_Info(param.IdEmpresa,Convert.ToInt32( info_empleado.IdEmpleado));
              txt_equipo.Text = info_activo_fijo.Af_Nombre;
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
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cargo.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar())
                            this.Close();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Actualizar())
                            this.Close();
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
                txt_cargo.Focus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar())
                            Limpiar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Actualizar())
                            Limpiar();
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

        private void FrmRo_Asignacion_Implemento_x_Empleado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListas();
                gridControlAsignacion.DataSource = lista_detalle
;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRo_Asignacion_Implemento_x_Empleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmRo_Asignacion_Implemento_x_Empleado_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetAccion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                this._Accion = _accion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        deFecha.EditValue = DateTime.Now;
                        this.Text = "Orden de servicio por activo fijo ***NUEVO REGISTRO***";
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.Text = "Orden de servicio por activo fijo ***MODIFICAR REGISTRO***";
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.Text = "Orden de servicio por activo fijo ***ANULAR REGISTRO***";
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.Text = "Orden de servicio por activo fijo ***CONSULTAR REGISTRO***";
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
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

        private void CargarListas()
        {
            try
            {
                lista_productos =  bus_producto.Get_list_Producto(param.IdEmpresa, param.IdSucursal);
                cmb_Producto.DataSource = lista_productos;
                cmb_Producto.DisplayMember="pr_descripcion";
                cmb_Producto.ValueMember = "IdProducto";


                lista_catalogo = bus_catalogo.Get_List_Catalogo_x_Tipo(38);
                cmb_catalogo.DataSource = lista_catalogo;
                cmb_catalogo.DisplayMember = "ca_descripcion";
                cmb_catalogo.ValueMember = "CodCatalogo";
              //  paramatreo_info = bus_rol_parametro.Get_Info_Parametr(param.IdEmpresa);

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Get_Info()
        {
            try
            {
                int sec = 0;
                res = true;
               

                Asig_Imp_Info.IdAsignacion_Impl = txtIdAsignación.Text == "" ? 0 : Convert.ToDecimal(txtIdAsignación.Text);
                Asig_Imp_Info.IdEmpresa = param.IdEmpresa;
                Asig_Imp_Info.Fecha_Entrega = deFecha.EditValue == null ? DateTime.Now : (DateTime)deFecha.EditValue;
                Asig_Imp_Info.Estado = "A";
                Asig_Imp_Info.Observacion = txtObservacion.Text;
                Asig_Imp_Info.Lst_ro_Asignacion_Implemento_x_Empleado_det = new List<ro_Asignacion_Implemento_x_Empleado_det_Info>(lista_detalle);
                Asig_Imp_Info.IdEmpleado = ucRo_Empleado1.get_IdEmpleado();
                Asig_Imp_Info.IdNomina_Tipo = ucRo_Empleado1.get_EmpleadoInfo().IdNomina_Tipo;
                if (rbt_Egreso.Checked == true)
                {
                    Asig_Imp_Info.Tipo_Movimiento = "-";
                }
                else
                {
                    Asig_Imp_Info.Tipo_Movimiento = "+";
                }
                // movimiento de inventario

                Info_moviemiento_inventario.IdEmpresa = param.IdEmpresa;
               // Info_moviemiento_inventario.IdSucursal = paramatreo_info.IdSucursal;
                //Info_moviemiento_inventario.IdBodega = paramatreo_info.IdBodega;

                if (rbt_Egreso.Checked == true)
                {
                   // Info_moviemiento_inventario.IdMovi_inven_tipo = paramatreo_info.IdTipo_mov_Egreso;
                    Info_moviemiento_inventario.signo = "-";
                }
                else
                {
                  //  Info_moviemiento_inventario.IdMovi_inven_tipo = paramatreo_info.IdTipo_mov_Egreso;
                    Info_moviemiento_inventario.signo = "+";
                }

                Info_moviemiento_inventario.cm_observacion = txtObservacion.Text;
                Info_moviemiento_inventario.cm_fecha =Convert.ToDateTime( deFecha.EditValue);
                Info_moviemiento_inventario.IdUsuario = param.IdUsuario;
                Info_moviemiento_inventario.Fecha_Transac = DateTime.Now;

                // movimiento de inventario Detalle 

                foreach (var item in lista_detalle)
                {
                    sec = sec + 1;
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                   // info.IdSucursal = paramatreo_info.IdSucursal;
                    if (rbt_Egreso.Checked == true)
                    {
                      //  info.IdMovi_inven_tipo = paramatreo_info.IdTipo_mov_Egreso;
                        Info_moviemiento_inventario.signo = "-";
                    }
                    else
                    {
                       // info.IdMovi_inven_tipo = paramatreo_info.IdTipo_mov_Egreso;
                        Info_moviemiento_inventario.signo = "+";
                    }
                    info.Secuencia = sec;
                   // info.IdBodega = paramatreo_info.IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = item.Cantidad;
                    info.dm_stock_actu = 0;
                    info.dm_stock_ante = 0;
                    info.dm_observacion = item.Detalle;
                    info.dm_precio = item.Vida_Util;
                    info.mv_costo = item.Vida_Util;
                    info.IdUnidadMedida = "UNID";
                    info.IdUnidadMedida_sinConversion = "UNID";
                    info.dm_cantidad_sinConversion = item.Cantidad;

                    lista_detalle_movimiento.Add(info);
                    
                }
                Info_moviemiento_inventario.listIng_Egr = lista_detalle_movimiento;
                Asig_Imp_Info.Movimiento_Inventario = Info_moviemiento_inventario;
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewAsignacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                ro_Asignacion_Implemento_x_Empleado_det_Info row = new ro_Asignacion_Implemento_x_Empleado_det_Info();
                row = (ro_Asignacion_Implemento_x_Empleado_det_Info)gridViewAsignacion.GetFocusedRow();

                int cont = 0;
                if (row != null)
                {
                    if (row.IdProducto != 0)
                    {
                        cont = lista_detalle.Where(q => q.IdProducto == row.IdProducto).Count();
                    }
                }


                if (cont > 1)
                {
                    item = lista_detalle.FirstOrDefault(q => q.IdProducto == row.IdProducto);
                    MessageBox.Show("El implemento : " + item.IdProducto + " ya se encuentra en el Detalle. Se procederá a Eliminar", "Sistemas");
                    gridViewAsignacion.DeleteSelectedRows();
                }
               
                if (e.Column.Name == "colVida_Util" )
                {
                    int Dias = row.Vida_Util;
                    DateTime fecha_ = Convert.ToDateTime(deFecha.EditValue);
                    fecha_ = fecha_.AddDays(Dias);
                    gridViewAsignacion.SetFocusedRowCellValue(Col_fecha_fin_vida_util, fecha_);
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Guardar()
        {
            try
            {
                decimal Idmovimiento=0;
                string mesnsaje="";
                decimal IdAsignacion = 0;
                res = true;
                if (!Validar())
                    return false;
                if (Get_Info())
                {
                    if (Asig_Imp_Bus.GuardarDB(Asig_Imp_Info, ref msg, ref IdAsignacion))
                    {
                        Asig_Imp_Info.IdAsignacion_Impl = IdAsignacion;
                        bus_Inventario.GuardarDB(Asig_Imp_Info.Movimiento_Inventario, ref Idmovimiento, ref mesnsaje);
                        
                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La asignación de implemento ", Asig_Imp_Info.IdAsignacion_Impl);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        txtIdAsignación.Text = Asig_Imp_Info.IdAsignacion_Impl.ToString();
                        deFecha.EditValue = Asig_Imp_Info.Fecha_Entrega;
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
                else
                    res = false;
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Actualizar()
        {
            try
            {
                txt_cargo.Focus();
                res = true;

                if (Get_Info())
                {
                    if (Asig_Imp_Bus.ActualizarDB(Asig_Imp_Info, ref msg))
                    {
                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La asignación de implemento ", Asig_Imp_Info.IdAsignacion_Impl);
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
                else
                    res = false;
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Anular()
        {
            try
            {
                res = false;
                if (MessageBox.Show("¿Está seguro que desea anular la asignación de implementos #: " + Asig_Imp_Info.IdAsignacion_Impl + " ?", "Anulación de asignación de implementos ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Asig_Imp_Info.IdUsuarioUltAnu = param.IdUsuario;
                    Asig_Imp_Info.Fecha_UltAnu = DateTime.Now;
                    Asig_Imp_Info.MotivoAnulacion = ofrm.motivoAnulacion;

                    if (Asig_Imp_Bus.AnularDB(Asig_Imp_Info, ref msg))
                    {

                        res = true;
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La asignación de implementos ", Asig_Imp_Info.IdAsignacion_Impl);
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




                if (Asig_Imp_Bus.AnularDB(Asig_Imp_Info, ref msg))
                {
                   
                }
                else
                {
                    MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    res = false;
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
        
        private void Imprimir()
        {
            try
            {

                XROL_Rpt015_Rpt rpt = new XROL_Rpt015_Rpt();
                ReportPrintTool pt = new ReportPrintTool(rpt);
                rpt.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                rpt.Parameters["IdNomina_tipo"].Value = Asig_Imp_Info.IdNomina_Tipo;
                rpt.Parameters["Id_Asignacion_impl"].Value = Asig_Imp_Info.IdAsignacion_Impl;
                rpt.Parameters["IdEmpleado"].Value = Asig_Imp_Info.IdEmpleado;
                rpt.CreateDocument();
                rpt.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info(ro_Asignacion_Implemento_x_Empleado_Info Info)
        {
            try
            {
                Asig_Imp_Info = Info;
                if (Info!=null)
                {
                    txtObservacion.Text = Info.Observacion;
                    txtIdAsignación.Text = Info.IdAsignacion_Impl.ToString();
                    deFecha.EditValue = Info.Fecha_Entrega;
                    ucRo_Empleado1.setEmpleado(Info.IdEmpleado);

                    
                        lista_detalle = new BindingList<ro_Asignacion_Implemento_x_Empleado_det_Info>(Asig_Imp_det_Bus.Get_Lista_Implemento_x_empleador_det(param.IdEmpresa,Info.IdAsignacion_Impl));
                        gridControlAsignacion.DataSource = lista_detalle;
                    
                    if (Info.Estado=="I")
                    {
                        lblAnulado.Visible = true;
                    }
                    if (Info.Tipo_Movimiento == "-")
                    {
                        rbt_Egreso.Checked = true;
                    }
                    else
                    {
                        rbt_ingreso.Checked = true;
                    }
                }

                
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            try
            {
                Asig_Imp_Info = new ro_Asignacion_Implemento_x_Empleado_Info();
                this.Text = "Orden de servicio por activo fijo ***NUEVO REGISTRO***";
                txtIdAsignación.Text = string.Empty;
                txtObservacion.Text = string.Empty;
                ucRo_Empleado1.InicializarEmpleado();
                deFecha.EditValue = DateTime.Now;

                lista_detalle = new BindingList<ro_Asignacion_Implemento_x_Empleado_det_Info>();
                gridControlAsignacion.DataSource = lista_detalle;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAsignacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (MessageBox.Show("Está seguro que desea eliminar el registro", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridViewAsignacion.DeleteSelectedRows();
                    
                }
            }
        }

        public bool Validar()
        {
            bool Bandera = true;
            try
            {
                if (lista_detalle.Count == 0)
                {
                    MessageBox.Show("Ingrese un implemento.", param.Nombre_sistema, MessageBoxButtons.OK);
                    Bandera= false;
                }
                foreach (var item in lista_detalle)
                {
                    if (item.Cantidad == 0)
                    {
                        MessageBox.Show("Ingrese la cantidad del implemento.", param.Nombre_sistema, MessageBoxButtons.OK);
                        Bandera = false;
                    }
                    if (item.Detalle == "" || item.Detalle == null)
                    {
                        MessageBox.Show("Ingrese un detalle del implemento.", param.Nombre_sistema, MessageBoxButtons.OK);
                        Bandera = false;
                    }
                    if (item.IdProducto == null || item.IdProducto == 0)
                    {
                        MessageBox.Show("Ingrese un implemento.", param.Nombre_sistema, MessageBoxButtons.OK);
                        Bandera = false;
                    }
                }

                return Bandera;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
