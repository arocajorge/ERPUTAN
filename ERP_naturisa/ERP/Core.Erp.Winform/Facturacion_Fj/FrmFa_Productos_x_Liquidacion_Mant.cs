using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
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

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class FrmFa_Productos_x_Liquidacion_Mant : Form
    {
        #region "Variables Y Propiedades"
        fa_liquidacion_gastos_producto_Info GasProd_Info = new fa_liquidacion_gastos_producto_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string MensajeError;

        fa_liquidacion_gastos_producto_Bus Bus_GasProd = new fa_liquidacion_gastos_producto_Bus();

        public delegate void Delegate_FrmFa_Productos_x_Liquidacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmFa_Productos_x_Liquidacion_Mant_FormClosing Event_FrmFa_Productos_x_Liquidacion_Mant_FormClosing;
        #endregion

        #region "Constructor"
        public FrmFa_Productos_x_Liquidacion_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            Event_FrmFa_Productos_x_Liquidacion_Mant_FormClosing += FrmFa_Productos_x_Liquidacion_Mant_Event_FrmFa_Productos_x_Liquidacion_Mant_FormClosing;
        }

        void FrmFa_Productos_x_Liquidacion_Mant_Event_FrmFa_Productos_x_Liquidacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region "Eventos"
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

        private void FrmFa_Productos_x_Liquidacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        txtId.EditValue = Bus_GasProd.getId(param.IdEmpresa);
                        chkActivo.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        //chkActivo.Properties.ReadOnly = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        txtDescripcion.Properties.ReadOnly = true;
                        ucIn_ProductoCmb1.Enabled  = false;
                        chkActivo.Properties.ReadOnly = true;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        Set();
                        txtDescripcion.Properties.ReadOnly = true;
                        ucIn_ProductoCmb1.Enabled  = false;
                        chkActivo.Properties.ReadOnly = true;
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
        #endregion

        #region "Set"
        public void SetInfo(fa_liquidacion_gastos_producto_Info _Info)
        {
            try
            {
                GasProd_Info = _Info;
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

        private void Set()
        {
            try
            {
                txtId.EditValue = GasProd_Info.IdProducto_Liqui;
                txtDescripcion.Text = GasProd_Info.nom_producto_Liqui;
                ucIn_ProductoCmb1.set_ProductoInfo(GasProd_Info.IdProducto);
                if (GasProd_Info.estado == "A")
                    chkActivo.Checked = true;
                else
                {
                    chkActivo.Checked = false;
                    lblAnulado.Visible = true;
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

        #region "Get"
        private void Get()
        {
            try
            {
                GasProd_Info = new fa_liquidacion_gastos_producto_Info();
                GasProd_Info.IdEmpresa = param.IdEmpresa;
                GasProd_Info.IdProducto_Liqui = Convert.ToInt32((txtId.EditValue == "") ? 0 : txtId.EditValue);
                GasProd_Info.nom_producto_Liqui = txtDescripcion.Text;
                GasProd_Info.IdProducto = Convert.ToDecimal((ucIn_ProductoCmb1.get_ProductoInfo() == null) ? 0 : ucIn_ProductoCmb1.get_ProductoInfo().IdProducto);
                GasProd_Info.estado = (chkActivo.Checked == true) ? "A" : "I"; 
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

        #region "Guardar, Modificar, Anular"
        private Boolean Guardar()
        {
            try
            {
                Boolean res = false;
                if (Bus_GasProd.GuardarDB(GasProd_Info, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " El Producto # : " + GasProd_Info.IdProducto_Liqui, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bool resultado = false;
                if (Bus_GasProd.ModificiarDB(GasProd_Info, ref MensajeError))
                {
                    resultado = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el Producto " + GasProd_Info.IdProducto_Liqui, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
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
                bool resultado = false;
                if (GasProd_Info.IdProducto_Liqui == 0)
                { return false; }
                if (lblAnulado.Visible)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " el Producto " + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " el Producto ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (Bus_GasProd.AnularDB(GasProd_Info, ref MensajeError))
                    {
                        resultado = true;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " el Producto " + GasProd_Info.IdProducto_Liqui, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblAnulado.Visible = true;
                    }
                }
                return resultado;
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

        #region " Validacion "
        private Boolean Validaciones()
        {
            Boolean res = true;
            if(string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }

            if (ucIn_ProductoCmb1.get_ProductoInfo() == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return res;
        }
        #endregion

        #region "Evento FormClosing"
        private void FrmFa_Productos_x_Liquidacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmFa_Productos_x_Liquidacion_Mant_FormClosing(sender, e);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

    }
}
