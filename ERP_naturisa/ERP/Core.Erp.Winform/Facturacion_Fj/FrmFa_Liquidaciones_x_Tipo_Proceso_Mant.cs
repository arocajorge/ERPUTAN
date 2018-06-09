using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_Liquidaciones_x_Tipo_Proceso_Mant : Form
    {
        #region "Variables Y Propiedades "
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string MensajeError = string.Empty;
        fa_liquidaciones_tipo_proceso_Info Info_TipoPro = new fa_liquidaciones_tipo_proceso_Info();
        fa_liquidaciones_tipo_proceso_Bus Bus_TipoPro = new fa_liquidaciones_tipo_proceso_Bus();
        List<fa_liquidacion_gastos_producto_Info> Lista = new List<fa_liquidacion_gastos_producto_Info>();
        fa_liquidacion_gastos_producto_Bus Bus_GasProd = new fa_liquidacion_gastos_producto_Bus();
        public delegate void Delegate_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing;
        #endregion

        #region " Constructor"
        public FrmFa_Liquidaciones_x_Tipo_Proceso_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing += FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing;
        }

        void FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region " Eventos "
        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GrabarDatos();
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrabarDatos())
                    this.Close();
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

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrabarDatos())
                    this.Close();
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        private void FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    carga_Combos_Productos();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;  
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            Set();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            txtNombreTipoProceso.Properties.ReadOnly = true;
                            Set();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            txtIdTipoProceso.Properties.ReadOnly = true;
                            sealupProductoLiqui.Properties.ReadOnly = true;
                            Set();
                            txtNombreTipoProceso.Properties.ReadOnly = true;
                            break;
                        default:
                            break;
                    }

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
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Get "
        private void Get()
        {
            try
            {
                Info_TipoPro = new fa_liquidaciones_tipo_proceso_Info();
                Info_TipoPro.IdTipo_Proceso = txtIdTipoProceso.Text;
                Info_TipoPro.nom_IdTipo_Proceso_x_Liqui = txtNombreTipoProceso.Text;
                Info_TipoPro.IdProducto_Liqui_x_defecto = Convert.ToInt32(sealupProductoLiqui.EditValue);
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
        #endregion

        #region " Set "
        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
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

        public void SetInfo(fa_liquidaciones_tipo_proceso_Info _Info)
        {
            try
            {
                Info_TipoPro = _Info;
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

        private void Set()
        {
            try
            {
                txtIdTipoProceso.Text = Info_TipoPro.IdTipo_Proceso;
                txtNombreTipoProceso.Text = Info_TipoPro.nom_IdTipo_Proceso_x_Liqui;
                sealupProductoLiqui.EditValue = Info_TipoPro.IdProducto_Liqui_x_defecto;
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
        #endregion

        #region "GrabarDatos"
        private Boolean GrabarDatos()
        {
            try
            {
                Boolean respuesta = false;
                Get();
                if (Validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = Modificar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            respuesta = Anular();
                            break;
                    }
                }
                return respuesta;
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
        #endregion

        #region " Guardar, Modificar, Anular "
        private Boolean Guardar()
        {
            try
            {
                Boolean res = false;
                if (!TipoProcesoExiste(Info_TipoPro.IdTipo_Proceso))
                {
                    if (Bus_TipoPro.GuardarDB(Info_TipoPro, ref MensajeError))
                    {
                        res = true;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " El Tipo de Proceso : " + Info_TipoPro.IdTipo_Proceso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdTipoProceso.Text = string.Empty;
                        txtNombreTipoProceso.Text = string.Empty;
                        sealupProductoLiqui.Properties.DataSource = "[Vacio]";
                    }
                }
                else
                {
                    MessageBox.Show(" El Tipo de Proceso ya esta creado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return res;
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

        private Boolean Modificar()
        {
            try
            {
                Boolean res = false;
                if (Bus_TipoPro.ModificiarDB(Info_TipoPro, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Tipo de Proceso : " + Info_TipoPro.IdTipo_Proceso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return res;
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

        private Boolean Anular()
        {
            try
            {
                Boolean res = false;
                if (Info_TipoPro.IdTipo_Proceso == null)
                { return false; }
                return res;
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
        #endregion

        #region " Cargar Combos"

        void carga_Combos_Productos()
        {
            try
            {
                
                Lista = Bus_GasProd.Get_List_Liqui_Gas_Producto(1, ref MensajeError);
                sealupProductoLiqui.Properties.DataSource = Lista;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region " Validacion "
        private Boolean Validaciones()
        {
            Boolean res = true;
            if (string.IsNullOrEmpty(txtIdTipoProceso.Text))
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Id del Tipo de Proceso ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdTipoProceso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombreTipoProceso.Text))
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Nombre del Tipo de Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreTipoProceso.Focus();
                return false;
            }

            if (sealupProductoLiqui.EditValue == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Producto Liquidación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sealupProductoLiqui.Focus();
                return false;
            }
            return res;
        }

        bool TipoProcesoExiste(string IdTipoProceso)
        {
            try
            {
                bool resultado = false;
                resultado = Bus_TipoPro.TipoProcesoExiste(Info_TipoPro.IdTipo_Proceso, ref MensajeError);

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region " Evento FormClosing "
        private void FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmFa_Liquidaciones_x_Tipo_Proceso_Mant_FormClosing(sender, e);
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
        #endregion

    }
}
