using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.General;
using Cus.Erp.Reports.FJ.Facturacion;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmfa_liquidacion_gastos_Mant : Form
    {
        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        //clases bus
        fa_liquidacion_gastos_Bus Bus_Liquidacion = new fa_liquidacion_gastos_Bus();
        fa_liquidacion_gastos_det_Bus Bus_Det_Liquidacion = new fa_liquidacion_gastos_det_Bus();
        fa_liquidacion_gastos_det_Historico_Bus Bus_Det_Liquidacion_Historico = new fa_liquidacion_gastos_det_Historico_Bus();
        fa_liquidacion_gastos_producto_Bus Bus_Liqui_Producto = new fa_liquidacion_gastos_producto_Bus();
        ct_Periodo_Bus Bus_Periodo = new ct_Periodo_Bus();
        
        //clases info
        fa_liquidacion_gastos_Info Info_Liquidacion = new fa_liquidacion_gastos_Info();
        fa_liquidacion_gastos_det_Info Info_Liqui_Det = new fa_liquidacion_gastos_det_Info();
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
        
        //listas y bindingList
        List<fa_liquidacion_gastos_producto_Info> List_Liqui_Producto = new List<fa_liquidacion_gastos_producto_Info>();
        List<fa_liquidacion_gastos_det_Info> Lista_Det_Historico = new List<fa_liquidacion_gastos_det_Info>();
        BindingList<fa_liquidacion_gastos_det_Info> BindList_Liquidacion = new BindingList<fa_liquidacion_gastos_det_Info>();

        //Delegados y Eventos
        public delegate void delegate_frmfa_liquidacion_gastos_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmfa_liquidacion_gastos_Mant_FormClosing event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing;

        string mensaje = "";
        decimal IdLiquidacion = 0;
        double precio = 0;
        double cantidad = 0;
        double subtotal = 0;
        double iva = 0;

        #endregion

        public frmfa_liquidacion_gastos_Mant()
        {
            InitializeComponent();
            event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing += frmfa_liquidacion_gastos_Mant_event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing;
        }

        void frmfa_liquidacion_gastos_Mant_event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmfa_liquidacion_gastos_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_delegate_frmfa_liquidacion_gastos_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #region Funciones Set y Get

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(fa_liquidacion_gastos_Info _Info_Liquidacion)
        {
            try
            {
                Info_Liquidacion = _Info_Liquidacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        txt_Codigo.Properties.ReadOnly = false;
                        ucFa_ClienteCmb.cmb_cliente.Properties.ReadOnly = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = true;
                        txt_Codigo.Properties.ReadOnly = true;
                        ucFa_ClienteCmb.cmb_cliente.Properties.ReadOnly = true;
                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        txt_Codigo.Properties.ReadOnly = true;
                        ucFa_ClienteCmb.cmb_cliente.Properties.ReadOnly = true;
                        Set_Info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = true;
                        ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
                        txt_Codigo.Properties.ReadOnly = false;
                        ucFa_ClienteCmb.cmb_cliente.Properties.ReadOnly = true;
                        Set_Info_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Info_in_controls()
        {
            try
            {
                txt_Id.Text = Info_Liquidacion.IdLiquidacion.ToString();
                txt_Codigo.Text = Info_Liquidacion.cod_liquidacion;
                dt_fecha_liqui.Value = Info_Liquidacion.fecha_liqui;
                ucFa_ClienteCmb.set_ClienteInfo(Info_Liquidacion.IdCliente);
                txt_Observacion.Text = Info_Liquidacion.Observacion;

                //Cargo la grilla
                Info_Liquidacion.Lis_Detalle = Bus_Det_Liquidacion.Get_List_Liquidacion_Gastos_Det(Info_Liquidacion.IdEmpresa, Info_Liquidacion.IdLiquidacion, ref mensaje);
                BindList_Liquidacion = new BindingList<fa_liquidacion_gastos_det_Info>(Info_Liquidacion.Lis_Detalle);
                gc_Liquidacion_detalle.DataSource = BindList_Liquidacion;
                Cargar_Grid_Historico();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public fa_liquidacion_gastos_Info Get_Info_Liquidacion()
        {
            try
            {
                Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dt_fecha_liqui.Value, ref mensaje);

                Info_Liquidacion.IdEmpresa = param.IdEmpresa;
                Info_Liquidacion.IdPeriodo = Info_Periodo.IdPeriodo;
                Info_Liquidacion.cod_liquidacion = txt_Codigo.Text;
                Info_Liquidacion.IdCliente = ucFa_ClienteCmb.get_ClienteInfo().IdCliente;
                Info_Liquidacion.fecha_liqui = dt_fecha_liqui.Value;
                ucFa_ClienteCmb.set_ClienteInfo(Info_Liquidacion.IdCliente);
                Info_Liquidacion.Observacion = txt_Observacion.Text;
                Info_Liquidacion.IdUsuario = param.IdUsuario;
                Info_Liquidacion.Fecha_Transaccion = DateTime.Now;
                Info_Liquidacion.IdLiquidacion = Convert.ToInt32(txt_Codigo.Text);
                Info_Liquidacion.Lis_Detalle = new List<fa_liquidacion_gastos_det_Info>(BindList_Liquidacion);

                return Info_Liquidacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_liquidacion_gastos_Info();
            }
        }

        #endregion

        #region Funciones Guardar, Modificar, Alunar, Validar, limpiar

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = GuardarDB();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = ModificarDB();
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean GuardarDB()
        {
            try
            {
                Boolean respuesta = false;
                Get_Info_Liquidacion();
                if (validar())
                {
                    respuesta = Bus_Liquidacion.GuardarDB(Info_Liquidacion, ref IdLiquidacion, ref mensaje);
                    if (respuesta)
                    {
                        Info_Liquidacion.IdLiquidacion = IdLiquidacion;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Liquidación # " + Info_Liquidacion.IdLiquidacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean ModificarDB()
        {
            try
            {
                bool respuesta = false;
                Get_Info_Liquidacion();
                if (validar())
                {
                    respuesta = Bus_Liquidacion.ModificarDB(Info_Liquidacion, ref mensaje);
                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Liquidación # " + Info_Liquidacion.IdLiquidacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                        return respuesta;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean AnularDB()
        {
            try
            {
                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " la Liquidación #: " + Info_Liquidacion.IdLiquidacion + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oFrm.ShowDialog();
                    Info_Liquidacion.MotivoAnulacion = oFrm.motivoAnulacion;
                    if (Bus_Liquidacion.AnularDB(Info_Liquidacion, ref mensaje))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la Liquidación # " + Info_Liquidacion.IdLiquidacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Info_Liquidacion.estado = "I";
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
                        Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void limpiar()
        {
            try
            {
                gc_Liquidacion_detalle.DataSource = null;
                txt_Observacion.Text = "";
                txt_Id.Text = "";
                txt_Codigo.Text = "";
                ucFa_ClienteCmb.set_ClienteInfo(0);
                dt_fecha_liqui.Value = DateTime.Now;
                
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                BindList_Liquidacion = new BindingList<fa_liquidacion_gastos_det_Info>();
                //Info_Liquidacion.DetFactura_List = new List<fa_factura_det_info>();

                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean validar()
        {
            try
            {
                if (ucFa_ClienteCmb.get_ClienteInfo() == null)
                {
                    MessageBox.Show("No ha Ingresado Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txt_Observacion.Text == null || txt_Observacion.Text == "")
                {
                    MessageBox.Show("Ingrese una Observación ", param.Nombre_sistema);
                    return false;
                }

                if (BindList_Liquidacion.Count == 0)
                {
                    MessageBox.Show("No ha agregado Ningún Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                int cont = 0;
                foreach (var item in BindList_Liquidacion)
                {
                    if (item.cantidad == 0 && item.IdProducto_Liqui != 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont > 0)
                {
                    MessageBox.Show("El detalle registra valores de cantidad en 0. Por favor ingrese la cantidad ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Imprimir()
        {
            try
            {
                // imprimir resume por subcentro 
                XFAC_FJ_Rpt002_Rpt rpt = new XFAC_FJ_Rpt002_Rpt();
                rpt.P_IdEmpresa.Value = param.IdEmpresa;
                rpt.P_Liquidacion.Value = Info_Liquidacion.IdLiquidacion;
                rpt.RequestParameters = false;
                rpt.ShowPreviewDialog();




            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        void Cargar_Combos()
        {
            try
            {
                List_Liqui_Producto = Bus_Liqui_Producto.Get_List_Liqui_Gas_Producto(param.IdEmpresa, ref mensaje);
                cmb_Liquidacion_Producto.DataSource = List_Liqui_Producto;

                gc_det_historico.DataSource = BindList_Liquidacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Cargar_Grid_Historico()
        {
            try
            {
                Lista_Det_Historico = Bus_Det_Liquidacion_Historico.Get_List_Liquidacion_Gastos_Det_Historico(Info_Liquidacion.IdEmpresa, Info_Liquidacion.IdLiquidacion, ref mensaje);
                cmb_productos_.DataSource = List_Liqui_Producto;

                gc_det_historico.DataSource = BindList_Liquidacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmfa_liquidacion_gastos_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                Set_Accion_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Codigo.Focus();
                if (Guardar_Datos())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Codigo.Focus();
                if (Guardar_Datos())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Imprimir();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularDB();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gw_Liquidacion_detalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info_Liqui_Det = new fa_liquidacion_gastos_det_Info();
                Info_Liqui_Det = (fa_liquidacion_gastos_det_Info)this.gw_Liquidacion_detalle.GetFocusedRow();

                precio = Math.Round(Convert.ToDouble(gw_Liquidacion_detalle.GetFocusedRowCellValue(col_precio)), 2);
                cantidad = Math.Round(Convert.ToDouble(gw_Liquidacion_detalle.GetFocusedRowCellValue(col_cantidad)),2);
                
                subtotal = Math.Round((precio * cantidad), 2);

                if (e.Column == col_cantidad || e.Column == col_precio)
                {
                    gw_Liquidacion_detalle.SetFocusedRowCellValue(col_subtotal, subtotal);
                    if (Convert.ToBoolean(gw_Liquidacion_detalle.GetFocusedRowCellValue(col_aplica_iva)) == true)
                    {
                        gw_Liquidacion_detalle.SetFocusedRowCellValue(col_valor_iva, (subtotal * param.iva.porcentaje) / 100);
                        iva = (subtotal * param.iva.porcentaje) / 100;

                    }
                    else
                    {
                        gw_Liquidacion_detalle.SetFocusedRowCellValue(col_valor_iva, 0);
                        iva = 0;
                    }
                    gw_Liquidacion_detalle.SetFocusedRowCellValue(col_por_iva, param.iva);
                    gw_Liquidacion_detalle.SetFocusedRowCellValue(col_Total_liq, subtotal + iva);
                }

                if (e.Column == col_aplica_iva)
                {
                    if (Convert.ToBoolean(gw_Liquidacion_detalle.GetFocusedRowCellValue(col_aplica_iva)) == true)
                    {
                        gw_Liquidacion_detalle.SetFocusedRowCellValue(col_valor_iva, (subtotal * param.iva.porcentaje) / 100);
                        iva = (subtotal * param.iva.porcentaje) / 100;
                    }
                    else
                    {
                        iva = 0;
                        gw_Liquidacion_detalle.SetFocusedRowCellValue(col_valor_iva, 0);
                    }

                    gw_Liquidacion_detalle.SetFocusedRowCellValue(col_por_iva, param.iva);
                    gw_Liquidacion_detalle.SetFocusedRowCellValue(col_Total_liq, subtotal + iva);
                }

               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Liquidacion_Producto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                fa_liquidacion_gastos_producto_Info Info_Producto = List_Liqui_Producto.First(v => v.IdProducto_Liqui == Convert.ToInt32(e.NewValue));

                gw_Liquidacion_detalle.SetFocusedRowCellValue(col_IdProducto_Liqui, Info_Producto.IdProducto_Liqui);
                gw_Liquidacion_detalle.SetFocusedRowCellValue(col_cantidad, 0);
                gw_Liquidacion_detalle.SetFocusedRowCellValue(col_precio, 0);
                gw_Liquidacion_detalle.SetFocusedRowCellValue(col_aplica_iva, true);
                gw_Liquidacion_detalle.SetFocusedRowCellValue(col_por_iva, param.iva);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gw_Liquidacion_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gw_Liquidacion_detalle.DeleteRow(gw_Liquidacion_detalle.FocusedRowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
