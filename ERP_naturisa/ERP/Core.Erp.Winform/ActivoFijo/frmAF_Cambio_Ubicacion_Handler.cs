using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.ActivoFijo
{
    public class frmAF_Cambio_Ubicacion_Handler
    {
        #region Declaracion de controles
        public DevExpress.XtraEditors.PanelControl panelControl1;
        public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        public Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public Controles.UCGe_Sucursal_combo cmbSucursal_Nueva;
        public Controles.UCGe_Sucursal_combo cmbSucursal_Actual;
        public DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbActivoFijo;
        public DevExpress.XtraGrid.Views.Grid.GridView gridActivoFijo;
        public DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        public DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraEditors.LabelControl labelControl9;
        public DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.TextEdit txtMotivoCambio;
        public System.Windows.Forms.DateTimePicker dtFechaCompra;
        public Controles.UCAF_Catalogos cmbUbicacion_Actual;
        public Controles.UCAF_Catalogos cmbUbicacion_Nueva;
        public DevExpress.XtraEditors.TextEdit txtIdCambio;
        public DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public Controles.UCCon_CentroCosto_ctas_Movi ucCon_CentroCosto_ctas_MoviActual;
        public System.Windows.Forms.CheckBox checkBoxdepartamentAct;
        public Controles.UCAf_DepartamentoCmb ucAf_DepartamentoCmb1;
        public System.Windows.Forms.CheckBox checkBoxdepartamentNewUbi;
        public Controles.UCCon_CentroCosto_ctas_Movi ucCon_CentroCosto_ctas_MoviNuevo;
        public DevExpress.XtraEditors.LabelControl labelControl11;
        public Controles.UCAf_DepartamentoCmb ucAf_DepartamentoCmb_nueva;
        public DevExpress.XtraEditors.TextEdit txtValor_Unidades_fac;
        public Controles.UCAF_Catalogos ucaF_Catalogos1;
        public Controles.UCAf_Encargado ucAf_Encargado_Actu;
        public Controles.UCAf_Encargado ucAf_EncargadoNue;

        public Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente_x_centro_costo_cmb_Nue;
        public Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente_x_centro_costo_cmb_Actu;
        #endregion

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        Af_Activo_fijo_Bus busActivo = new Af_Activo_fijo_Bus();
        List<Af_Activo_fijo_Info> lstActiFijo = new List<Af_Activo_fijo_Info>();
        Af_Activo_fijo_Info InfoActiFijo = new Af_Activo_fijo_Info();


        tb_Sucursal_Bus busSucur = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();

        Af_Catalogo_Bus busCata = new Af_Catalogo_Bus();
        List<Af_Catalogo_Info> lstCata = new List<Af_Catalogo_Info>();
        Af_CambioUbicacion_Activo_Bus BusCambioUbicacion = new Af_CambioUbicacion_Activo_Bus();
        Af_CambioUbicacion_Activo_Info _InfoCambioUbicacion = new Af_CambioUbicacion_Activo_Info();
        Af_CambioUbicacion_Activo_Info _InfoCambioUbicacion_Actual = new Af_CambioUbicacion_Activo_Info();

        ct_punto_cargo_Info info_Punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_Punto_cargo = new ct_punto_cargo_Bus();

        Af_Activo_fijo_x_ct_punto_cargo_Info info_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Info();
        Af_Activo_fijo_x_ct_punto_cargo_Bus bus_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Bus();

        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info info_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info();
        Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus bus_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus();


        #endregion

        Form FrmParent;
        Form FrmChildren;
        Cl_Enumeradores.eCliente_Vzen eCliente;

        public void Set_Af_CambioUbicacion_Activo_Info(Af_CambioUbicacion_Activo_Info __InfoCambioUbicacion)
        {
            try
            {
                this._InfoCambioUbicacion = __InfoCambioUbicacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_FrmChildren(Form _FrmChildren)
        {
            try
            {
                this.FrmChildren = _FrmChildren;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_FrmParent(Form _FrmParent)
        {
            try
            {
                this.FrmParent = _FrmParent;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_eCliente(Cl_Enumeradores.eCliente_Vzen _eCliente)
        {
            try
            {
                this.eCliente = _eCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public frmAF_Cambio_Ubicacion_Handler ()
	    {
            if (eCliente==0)
            {
                eCliente = Cl_Enumeradores.eCliente_Vzen.GENERAL;
            }
        }

        public void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        

        public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                FrmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                    FrmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos())
                    LimpiarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmAF_Cambio_Ubicacion_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (InfoActiFijo.IdActivoFijo != 0)
                            set_CambioUbicacion_x_Activofijo_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        cmbActivoFijo_EditValueChanged(null, null);
                        set_InfoUbicacion_in_controls();
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

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
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

        public void set_InfoActivo_Fijo(Af_Activo_fijo_Info _InfoAF)
        {
            try
            {
                InfoActiFijo = _InfoAF;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_InfoUbicacion(Af_CambioUbicacion_Activo_Info InfoCambioUbicacion)
        {
            try
            {
                _InfoCambioUbicacion = InfoCambioUbicacion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_combo_activo_fijo()
        {
            try
            {
                cmbActivoFijo.EditValue = _InfoCambioUbicacion.IdActivoFijo;
                dtFechaCompra.Value = _InfoCambioUbicacion.FechaCambio;
                txtMotivoCambio.EditValue = _InfoCambioUbicacion.MotivoCambio;
                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        ucFa_Cliente_x_centro_costo_cmb_Actu.Set_Info_Centro_costo(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucFa_Cliente_x_centro_costo_cmb_Nue.Set_Info_Centro_costo(_InfoCambioUbicacion.IdCentroCosto_Ant);
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:                       
                        cmbSucursal_Actual.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Ant);
                        cmbSucursal_Nueva.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Actu);
                        ucAf_DepartamentoCmb_nueva.set_Info(_InfoCambioUbicacion.IdDepartamento_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Actu);
                        ucAf_DepartamentoCmb1.set_Info(_InfoCambioUbicacion.IdDepartamento_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Ant);
                        cmbUbicacion_Actual.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant);
                        cmbUbicacion_Nueva.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu);
                        ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Ant);
                        break;
                    default:                        
                        cmbSucursal_Actual.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Ant);
                        cmbSucursal_Nueva.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Actu);
                        ucAf_DepartamentoCmb_nueva.set_Info(_InfoCambioUbicacion.IdDepartamento_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Actu);
                        ucAf_DepartamentoCmb1.set_Info(_InfoCambioUbicacion.IdDepartamento_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Ant);
                        cmbUbicacion_Actual.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant);
                        cmbUbicacion_Nueva.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu);
                        ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Ant);
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

        private void set_InfoUbicacion_in_controls()
        {
            try
            {
                cmbActivoFijo.EditValue = _InfoCambioUbicacion.IdActivoFijo;
                dtFechaCompra.Value = _InfoCambioUbicacion.FechaCambio;
                txtMotivoCambio.EditValue = _InfoCambioUbicacion.MotivoCambio;
                txtIdCambio.Text = _InfoCambioUbicacion.IdCambioUbicacion.ToString();
                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        ucFa_Cliente_x_centro_costo_cmb_Actu.Set_Info_Centro_costo(_InfoCambioUbicacion.IdCentroCosto_Ant);
                        ucFa_Cliente_x_centro_costo_cmb_Nue.Set_Info_Centro_costo(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucFa_Cliente_x_centro_costo_cmb_Actu.Set_Info_Centro_costo_sub_centro_costo(_InfoCambioUbicacion.IdCentroCosto_sub_centro_costo_Ant);
                        ucFa_Cliente_x_centro_costo_cmb_Nue.Set_Info_Centro_costo_sub_centro_costo(_InfoCambioUbicacion.IdCentroCosto_sub_centro_costo_Actu);
                        ucaF_Catalogos1.set_CatalogosInfo(_InfoCambioUbicacion.IdUnidadFact_cat);
                        txtValor_Unidades_fac.Text = _InfoCambioUbicacion.Af_ValorUnidad_Actu.ToString();
                        ucAf_Encargado_Actu.set_Info(_InfoCambioUbicacion.IdEncargado_Ant == null ? 0 : (decimal)_InfoCambioUbicacion.IdEncargado_Ant);
                        ucAf_EncargadoNue.set_Info(_InfoCambioUbicacion.IdEncargado_Actu == null ? 0 : (decimal)_InfoCambioUbicacion.IdEncargado_Actu);
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        cmbSucursal_Actual.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Ant);
                        cmbSucursal_Nueva.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Actu);
                        ucAf_DepartamentoCmb_nueva.set_Info(_InfoCambioUbicacion.IdDepartamento_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Actu);
                        ucAf_DepartamentoCmb1.set_Info(_InfoCambioUbicacion.IdDepartamento_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Ant);
                        cmbUbicacion_Actual.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant);
                        cmbUbicacion_Nueva.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu);
                        ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Ant);
                        break;
                    default:
                        cmbSucursal_Actual.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Ant);
                        cmbSucursal_Nueva.set_SucursalInfo(_InfoCambioUbicacion.IdSucursal_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdSucursal_Actu);
                        ucAf_DepartamentoCmb_nueva.set_Info(_InfoCambioUbicacion.IdDepartamento_Actu == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Actu);
                        ucAf_DepartamentoCmb1.set_Info(_InfoCambioUbicacion.IdDepartamento_Ant == null ? 0 : (int)_InfoCambioUbicacion.IdDepartamento_Ant);
                        cmbUbicacion_Actual.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant);
                        cmbUbicacion_Nueva.set_CatalogosInfo(_InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu);
                        ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Actu);
                        ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto(_InfoCambioUbicacion.IdCentroCosto_Ant);
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

        void CargarCombo()
        {
            try
            {
                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        ucFa_Cliente_x_centro_costo_cmb_Actu.Cargar_combos();
                        ucFa_Cliente_x_centro_costo_cmb_Nue.Cargar_combos();
                        ucaF_Catalogos1.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UNIDADES.ToString());
                        ucAf_Encargado_Actu.set_Info(0);
                        ucAf_EncargadoNue.set_Info(0);
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        cmbUbicacion_Actual.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                        cmbUbicacion_Nueva.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                        ucAf_DepartamentoCmb_nueva.cargar();
                        break;
                    default:
                        cmbUbicacion_Actual.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                        cmbUbicacion_Nueva.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
                        ucAf_DepartamentoCmb_nueva.cargar();
                        break;
                }               

                lstActiFijo = busActivo.Get_List_ActivoFijo(param.IdEmpresa, "");
                cmbActivoFijo.Properties.DataSource = lstActiFijo;
                

                if (InfoActiFijo != null)
                {
                    if (InfoActiFijo.IdActivoFijo != 0)
                    {
                        cmbActivoFijo.EditValue = InfoActiFijo.IdActivoFijo;
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

        Boolean GuardarDatos()
        {
            try
            {
                Boolean bolResult = false;
                string msjError = "";
                int IdCambio = 0;
                if (ValidarDatos())
                {
                    Get_Info_CambioUbicacion();
                    get_ActivoFijo();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            bolResult = BusCambioUbicacion.GuardarDB(_InfoCambioUbicacion, ref IdCambio, ref msjError);
                            if (bolResult)
                            {
                                switch (eCliente)
                                {
                                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                        break;
                                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                        break;
                                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                                        bolResult = Reubicar_Punto_cargo();
                                        break;
                                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                        bolResult = busActivo.ModificarDB(InfoActiFijo, ref msjError);
                                        break;
                                    default:
                                        bolResult = busActivo.ModificarDB(InfoActiFijo, ref msjError);
                                        break;
                                }                                
                                txtIdCambio.EditValue = IdCambio;                                
                                if (bolResult)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                                    
                                }
                            }
                            else
                                MessageBox.Show(msjError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _InfoCambioUbicacion = new Af_CambioUbicacion_Activo_Info();
                InfoActiFijo = new Af_Activo_fijo_Info();

                txtIdCambio.EditValue = null;
                cmbActivoFijo.EditValue = null;
                txtMotivoCambio.EditValue = null;

                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        ucFa_Cliente_x_centro_costo_cmb_Actu.Inicializar_Combos();
                        ucFa_Cliente_x_centro_costo_cmb_Nue.Inicializar_Combos();
                        txtValor_Unidades_fac.EditValue = null;
                        ucaF_Catalogos1.Inicializar_Catalogos();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        cmbSucursal_Nueva.Incializar_cmbsucursal();
                        ucAf_DepartamentoCmb_nueva.Inicializar_cmb_departamento();
                        ucAf_DepartamentoCmb1.Inicializar_cmb_departamento();
                        cmbUbicacion_Nueva.Inicializar_Catalogos();
                        cmbUbicacion_Actual.Inicializar_Catalogos();
                        ucCon_CentroCosto_ctas_MoviActual.Inicializar_cmbCentroCosto();
                        ucCon_CentroCosto_ctas_MoviNuevo.Inicializar_cmbCentroCosto();
                        break;
                    default:
                        cmbSucursal_Nueva.Incializar_cmbsucursal();
                        ucAf_DepartamentoCmb_nueva.Inicializar_cmb_departamento();
                        ucAf_DepartamentoCmb1.Inicializar_cmb_departamento();
                        cmbUbicacion_Nueva.Inicializar_Catalogos();
                        cmbUbicacion_Actual.Inicializar_Catalogos();
                        ucCon_CentroCosto_ctas_MoviActual.Inicializar_cmbCentroCosto();
                        ucCon_CentroCosto_ctas_MoviNuevo.Inicializar_cmbCentroCosto();
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

        public Af_CambioUbicacion_Activo_Info Get_Info_CambioUbicacion()
        {
            try
            {
                _InfoCambioUbicacion = new Af_CambioUbicacion_Activo_Info();

                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:                        
                        _InfoCambioUbicacion.IdCentroCosto_Ant = ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo()==null? null : ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo().IdCentroCosto;
                        _InfoCambioUbicacion.IdCentroCosto_Actu = ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo() == null ? null : ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo().IdCentroCosto;
                        _InfoCambioUbicacion.IdCentroCosto_sub_centro_costo_Ant = ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo_sub_centro_costo() == null ? null : ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                        _InfoCambioUbicacion.IdCentroCosto_sub_centro_costo_Actu = ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo_sub_centro_costo() == null ? null : ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                        if (ucaF_Catalogos1.get_CatalogosInfo()!=null) _InfoCambioUbicacion.IdUnidadFact_cat = ucaF_Catalogos1.get_CatalogosInfo().IdCatalogo;
                        if (txtValor_Unidades_fac.Text != "") _InfoCambioUbicacion.Af_ValorUnidad_Actu = Convert.ToDouble(txtValor_Unidades_fac.Text);
                        if (ucAf_Encargado_Actu.get_Info().IdEncargado!=0) _InfoCambioUbicacion.IdEncargado_Ant = ucAf_Encargado_Actu.get_Info().IdEncargado;
                        if (ucAf_EncargadoNue.get_Info().IdEncargado!=0) _InfoCambioUbicacion.IdEncargado_Actu = ucAf_EncargadoNue.get_Info().IdEncargado;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        _InfoCambioUbicacion.IdSucursal_Actu = cmbSucursal_Nueva.get_SucursalInfo().IdSucursal;
                        _InfoCambioUbicacion.IdSucursal_Ant = cmbSucursal_Actual.get_SucursalInfo().IdSucursal;
                        _InfoCambioUbicacion.IdDepartamento_Actu = ucAf_DepartamentoCmb_nueva.get_Info().IdDepartamento;
                        _InfoCambioUbicacion.IdDepartamento_Ant = ucAf_DepartamentoCmb1.get_Info().IdDepartamento;
                        _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu = cmbUbicacion_Nueva.get_CatalogosInfo().IdCatalogo;
                        _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant = cmbUbicacion_Actual.get_CatalogosInfo().IdCatalogo;
                        _InfoCambioUbicacion.IdCentroCosto_Actu = ucCon_CentroCosto_ctas_MoviNuevo.Get_IdCentroCosto();
                        _InfoCambioUbicacion.IdCentroCosto_Ant = ucCon_CentroCosto_ctas_MoviActual.Get_IdCentroCosto();
                        break;
                    default:
                       _InfoCambioUbicacion.IdSucursal_Actu = cmbSucursal_Nueva.get_SucursalInfo().IdSucursal;
                        _InfoCambioUbicacion.IdSucursal_Ant = cmbSucursal_Actual.get_SucursalInfo().IdSucursal;
                        _InfoCambioUbicacion.IdDepartamento_Actu = ucAf_DepartamentoCmb_nueva.get_Info().IdDepartamento;
                        _InfoCambioUbicacion.IdDepartamento_Ant = ucAf_DepartamentoCmb1.get_Info().IdDepartamento;
                        _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu = cmbUbicacion_Nueva.get_CatalogosInfo().IdCatalogo;
                        _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Ant = cmbUbicacion_Actual.get_CatalogosInfo().IdCatalogo;
                        _InfoCambioUbicacion.IdCentroCosto_Actu = ucCon_CentroCosto_ctas_MoviNuevo.Get_IdCentroCosto();
                        _InfoCambioUbicacion.IdCentroCosto_Ant = ucCon_CentroCosto_ctas_MoviActual.Get_IdCentroCosto();
                        break;
                }
                _InfoCambioUbicacion.IdEmpresa = param.IdEmpresa;
                _InfoCambioUbicacion.IdCambioUbicacion = (txtIdCambio.EditValue == null) ? 0 : Convert.ToInt32(txtIdCambio.EditValue);
                _InfoCambioUbicacion.IdActivoFijo = Convert.ToInt32(cmbActivoFijo.EditValue);
                _InfoCambioUbicacion.FechaCambio = dtFechaCompra.Value;
                _InfoCambioUbicacion.MotivoCambio = Convert.ToString(txtMotivoCambio.EditValue);
                _InfoCambioUbicacion.IdUsuario = param.IdUsuario;
                _InfoCambioUbicacion.nom_pc = param.nom_pc;
                _InfoCambioUbicacion.ip = param.ip;

                return _InfoCambioUbicacion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_CambioUbicacion_Activo_Info();
            }
        }

        Boolean ValidarDatos()
        {
            try
            {
                if (dtFechaCompra.Value == null)
                {
                    MessageBox.Show("Por Favor Ingrese la Fecha de Cambio de Ubicación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dtFechaCompra.Focus();
                    return false;
                }

                if (txtMotivoCambio.EditValue == null || txtMotivoCambio.EditValue == "")
                {
                    MessageBox.Show("Por Favor Ingrese el Motivo del Cambio de Ubicación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtMotivoCambio.Focus();
                    return false;
                }
                switch (eCliente)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        if (ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo() == null)
                        {
                            MessageBox.Show("Por Favor Seleccione el nuevo centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.ucFa_Cliente_x_centro_costo_cmb_Nue.Focus();
                            return false;
                        }                       

                        if (ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo_sub_centro_costo() == null)
                        {
                            MessageBox.Show("Por favor seleccione un nuevo sub centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.ucFa_Cliente_x_centro_costo_cmb_Nue.Focus();
                            return false;
                        }
                        else
                        {
                            string idCentro_costo_sub_centro_costo_Ant = "";
                            string idCentro_costo_sub_centro_costo_Nue = "";

                            idCentro_costo_sub_centro_costo_Ant = ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
                            idCentro_costo_sub_centro_costo_Nue = ucFa_Cliente_x_centro_costo_cmb_Nue.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;

                            if (idCentro_costo_sub_centro_costo_Nue.Equals(idCentro_costo_sub_centro_costo_Ant))
                            {
                                MessageBox.Show("Por favor seleccione un sub centro de costo distinto al actual", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.ucFa_Cliente_x_centro_costo_cmb_Nue.Focus();
                                return false;
                            }
                        }

                        if (ucAf_EncargadoNue.get_Info().IdEncargado==0)
                        {
                            MessageBox.Show("Por Favor Seleccione el nuevo encargado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:                        
                        if (cmbSucursal_Nueva.get_SucursalInfo() == null)
                        {
                            MessageBox.Show("Por Favor Seleccione la nueva Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.cmbSucursal_Nueva.Focus();
                            return false;
                        }

                        if (ucCon_CentroCosto_ctas_MoviNuevo.Get_IdCentroCosto() == null || ucCon_CentroCosto_ctas_MoviNuevo.Get_IdCentroCosto() == "")
                        {
                            MessageBox.Show("Por Favor Seleccione el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ucCon_CentroCosto_ctas_MoviNuevo.Focus();
                            return false;
                        }


                        if (cmbUbicacion_Nueva.get_CatalogosInfo() == null)
                        {
                            MessageBox.Show("Por Favor Seleccione la nueva Ubicación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.cmbUbicacion_Nueva.Focus();
                            return false;
                        }

                        if (ucAf_DepartamentoCmb_nueva.get_Info() == null)
                        {
                            MessageBox.Show("Por Favor Seleccione el Departamento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ucAf_DepartamentoCmb_nueva.Focus();
                            return false;
                        }
                        break;
                    default:
                        break;
                }


                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void cmbActivoFijo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivoFijo.EditValue != null)
                {
                    if (lstActiFijo.Count() != 0)
                    {
                        InfoActiFijo = lstActiFijo.Where(q => q.IdActivoFijo == Convert.ToInt32(cmbActivoFijo.EditValue)).First();
                        switch (eCliente)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                break;
                            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                break;
                            case Cl_Enumeradores.eCliente_Vzen.FJ:
                                ucFa_Cliente_x_centro_costo_cmb_Actu.Set_Info_Centro_costo(InfoActiFijo.IdCentroCosto);
                                ucFa_Cliente_x_centro_costo_cmb_Actu.Set_Info_Centro_costo_sub_centro_costo(InfoActiFijo.IdCentroCosto_sub_centro_costo);
                                ucaF_Catalogos1.set_CatalogosInfo(InfoActiFijo.IdUnidadFact_cat);
                                txtValor_Unidades_fac.Text = InfoActiFijo.Af_ValorUnidad_Actu.ToString();
                                ucAf_Encargado_Actu.set_Info(InfoActiFijo.IdEncargado == null ? 0 : (decimal)InfoActiFijo.IdEncargado);
                                break;
                            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                                cmbSucursal_Actual.set_SucursalInfo(InfoActiFijo.IdSucursal);
                                ucAf_DepartamentoCmb1.set_Info(Convert.ToInt32(InfoActiFijo.IdDepartamento));
                                cmbUbicacion_Actual.set_CatalogosInfo(InfoActiFijo.IdTipoCatalogo_Ubicacion);
                                ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto("");
                                ucAf_DepartamentoCmb_nueva.set_Info(0);
                                ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto("");
                                cmbUbicacion_Nueva.set_CatalogosInfo("");
                                break;
                            default:
                                cmbSucursal_Actual.set_SucursalInfo(InfoActiFijo.IdSucursal);
                                ucAf_DepartamentoCmb1.set_Info(Convert.ToInt32(InfoActiFijo.IdDepartamento));
                                cmbUbicacion_Actual.set_CatalogosInfo(InfoActiFijo.IdTipoCatalogo_Ubicacion);
                                ucCon_CentroCosto_ctas_MoviActual.set_IdCentroCosto("");
                                ucAf_DepartamentoCmb_nueva.set_Info(0);
                                ucCon_CentroCosto_ctas_MoviNuevo.set_IdCentroCosto("");
                                cmbUbicacion_Nueva.set_CatalogosInfo("");
                                break;
                        }
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

        public void checkBoxdepartamentNewUbi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxdepartamentNewUbi.Checked == true)
                    ucAf_DepartamentoCmb_nueva.Enabled = true;
                else
                    ucAf_DepartamentoCmb_nueva.Enabled = false;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void checkBoxdepartamentAct_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (checkBoxdepartamentAct.Checked == true)
                    ucAf_DepartamentoCmb1.Enabled = true;
                else
                    ucAf_DepartamentoCmb1.Enabled = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void set_CambioUbicacion_x_Activofijo_in_controls()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntLimpiar = false;
                cmbActivoFijo.EditValue = InfoActiFijo.IdActivoFijo;
                dtFechaCompra.Value = DateTime.Now;
                cmbActivoFijo.Enabled = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Af_Activo_fijo_Info get_ActivoFijo()
        {
            try
            {
                Af_Activo_fijo_Info info = new Af_Activo_fijo_Info();
                info.IdEmpresa = InfoActiFijo.IdEmpresa;
                info.IdActivoFijo = InfoActiFijo.IdActivoFijo;
                info.CodActivoFijo = InfoActiFijo.CodActivoFijo;
                info.IdTipoDepreciacion = InfoActiFijo.IdTipoDepreciacion;
                info.Af_Nombre = InfoActiFijo.Af_Nombre;
                info.IdActijoFijoTipo = InfoActiFijo.IdActijoFijoTipo;
                info.IdCatalogo_Marca = InfoActiFijo.IdCatalogo_Marca;
                info.IdCatalogo_Modelo = InfoActiFijo.IdCatalogo_Modelo;
                info.Af_NumSerie = InfoActiFijo.Af_NumSerie;
                info.IdCatalogo_Color = InfoActiFijo.IdCatalogo_Color;

                info.IdTipoCatalogo_Ubicacion = _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu == null ? InfoActiFijo.IdTipoCatalogo_Ubicacion : _InfoCambioUbicacion.IdTipoCatalogo_Ubicacion_Actu;
                info.IdSucursal = _InfoCambioUbicacion.IdSucursal_Actu == null ? InfoActiFijo.IdSucursal : (int)_InfoCambioUbicacion.IdSucursal_Actu;
                info.IdDepartamento = _InfoCambioUbicacion.IdDepartamento_Actu == null ? InfoActiFijo.IdDepartamento : _InfoCambioUbicacion.IdDepartamento_Actu;

                info.Af_fecha_compra = InfoActiFijo.Af_fecha_compra;
                info.Af_fecha_ini_depre = InfoActiFijo.Af_fecha_ini_depre;
                info.Af_fecha_fin_depre = InfoActiFijo.Af_fecha_ini_depre;
                info.Af_Costo_historico = InfoActiFijo.Af_Costo_historico;
                info.Af_costo_compra = InfoActiFijo.Af_costo_compra;
                info.Af_Vida_Util = InfoActiFijo.Af_Vida_Util;
                info.Af_Meses_depreciar = InfoActiFijo.Af_Meses_depreciar;
                info.Af_porcentaje_deprec = InfoActiFijo.Af_porcentaje_deprec;
                info.Af_observacion = InfoActiFijo.Af_observacion;
                info.Af_NumPlaca = InfoActiFijo.Af_NumPlaca;
                info.Af_Anio_fabrica = InfoActiFijo.Af_Anio_fabrica;
                info.Estado = InfoActiFijo.Estado;

                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;

                info.Af_foto = InfoActiFijo.Af_foto;
                info.Af_DescripcionCorta = InfoActiFijo.Af_DescripcionCorta;

                info.IdPeriodoDeprec = InfoActiFijo.IdPeriodoDeprec;
                info.IdTipoDepreciacion = InfoActiFijo.IdTipoDepreciacion;
                info.Af_Codigo_Parte = InfoActiFijo.Af_Codigo_Parte;
                info.Af_Codigo_Barra = InfoActiFijo.Af_Codigo_Barra;
                info.Af_DescripcionTecnica = InfoActiFijo.Af_DescripcionTecnica;
                info.IdProveedor = InfoActiFijo.IdProveedor;
                info.Af_FechaPoliza = InfoActiFijo.Af_FechaPoliza;
                info.Af_ValorPoliza = InfoActiFijo.Af_ValorPoliza;
                info.Af_ValorVenta = InfoActiFijo.Af_ValorVenta;
                info.Af_NumPoliza = InfoActiFijo.Af_NumPoliza;
                info.Af_Fecha_Venta = InfoActiFijo.Af_Fecha_Venta;
                info.Af_Fecha_Vencimiento = InfoActiFijo.Af_Fecha_Vencimiento;
                info.Af_Fecha_Retiro = InfoActiFijo.Af_Fecha_Retiro;
                info.Estado_Proceso = InfoActiFijo.Estado_Proceso;
                info.Af_ValorSalvamento = InfoActiFijo.Af_ValorSalvamento;
                info.Af_ValorResidual = InfoActiFijo.Af_ValorResidual;

                info.IdEmpresa_oc = InfoActiFijo.IdEmpresa_oc;
                info.IdSucursal_oc = InfoActiFijo.IdSucursal_oc;
                info.IdOrdenCompra = InfoActiFijo.IdOrdenCompra;
                info.Secuencia_oc = InfoActiFijo.Secuencia_oc;
                info.numDocumento = InfoActiFijo.numDocumento;

                info.Cantidad = InfoActiFijo.Cantidad;
                info.Costo_uni = InfoActiFijo.Costo_uni; 
                info.SubTotal = InfoActiFijo.SubTotal;
                info.valor_Iva = InfoActiFijo.valor_Iva;
                info.Total = InfoActiFijo.Total;

                info.IdEmpresa_Ogiro = InfoActiFijo.IdEmpresa_Ogiro;
                info.IdCbteCble_Ogiro = InfoActiFijo.IdCbteCble_Ogiro;
                info.IdTipoCbte_Ogiro = InfoActiFijo.IdTipoCbte_Ogiro;
                info.IdOrden_giro_Tipo = InfoActiFijo.IdOrden_giro_Tipo;

                info.Af_NumSerie_Chasis = InfoActiFijo.Af_NumSerie_Chasis;
                info.Af_NumSerie_Motor = InfoActiFijo.Af_NumSerie_Motor;

                info.IdCategoriaAF = InfoActiFijo.IdCategoriaAF;

                info.IdEncargado = _InfoCambioUbicacion.IdEncargado_Actu == null ? InfoActiFijo.IdEncargado : _InfoCambioUbicacion.IdEncargado_Actu;
                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
                    info.IdEncargado = _InfoCambioUbicacion.IdEncargado_Actu;
                else
                    _InfoCambioUbicacion.IdEncargado_Actu = info.IdEncargado;

                info.IdUnidadFact_cat = InfoActiFijo.IdUnidadFact_cat;
                info.Af_ValorUnidad_Actu = InfoActiFijo.Af_ValorUnidad_Actu;
                info.IdCentroCosto = _InfoCambioUbicacion.IdCentroCosto_Actu;
                info.IdCentroCosto_sub_centro_costo = _InfoCambioUbicacion.IdCentroCosto_sub_centro_costo_Actu;                

                InfoActiFijo = info;
                return InfoActiFijo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Af_Activo_fijo_Info();
            }
        }

        private bool Reubicar_Punto_cargo()
        {
            try
            {
                info_af_x_pc = bus_af_x_pc.Get_Info_x_Activo_fijo(InfoActiFijo.IdEmpresa, InfoActiFijo.IdActivoFijo);
                if (info_af_x_pc.IdPunto_cargo_PC == 0)
                {
                    //--Creo punto de cargo
                    info_Punto_cargo.IdEmpresa = param.IdEmpresa;
                    info_Punto_cargo.nom_punto_cargo = InfoActiFijo.Af_Nombre;
                    info_Punto_cargo.Estado = "A";

                    bus_Punto_cargo.GuardarDB(info_Punto_cargo, param.IdEmpresa);
                }
                else
                {
                    info_Punto_cargo = bus_Punto_cargo.Get_Info_Punto_cargo(param.IdEmpresa, info_af_x_pc.IdPunto_cargo_PC);
                }
                //Relaciono activo fijo con punto de cargo
                info_af_x_pc.IdEmpresa_AF = InfoActiFijo.IdEmpresa;
                info_af_x_pc.IdActivoFijo_AF = InfoActiFijo.IdActivoFijo;
                info_af_x_pc.IdEmpresa_PC = info_Punto_cargo.IdEmpresa;
                info_af_x_pc.IdPunto_cargo_PC = info_Punto_cargo.IdPunto_cargo;

                if (bus_af_x_pc.MergeDB(info_af_x_pc))
                {
                    //Relaciono activo fijo con centro de costo
                    info_af_x_cc.IdEmpresa_AF = InfoActiFijo.IdEmpresa;
                    info_af_x_cc.IdActivoFijo_AF = InfoActiFijo.IdActivoFijo;
                    info_af_x_cc.IdCentroCosto_Scc = InfoActiFijo.IdCentroCosto;
                    info_af_x_cc.IdCentroCosto_sub_centro_costo_Scc = InfoActiFijo.IdCentroCosto_sub_centro_costo;
                    info_af_x_cc.IdEmpresa_Scc = ucFa_Cliente_x_centro_costo_cmb_Actu.Get_Info_Centro_costo().IdEmpresa;

                    if (bus_af_x_cc.MergeDB(info_af_x_cc))
                    {
                        return true;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
    }
}
