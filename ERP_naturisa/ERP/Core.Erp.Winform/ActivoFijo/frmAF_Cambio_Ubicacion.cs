using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Cambio_Ubicacion : DevExpress.XtraEditors.XtraForm
    {
        #region Delegados
        public delegate void delegate_FormClosed(object sender, FormClosingEventArgs e);
        public event delegate_FormClosed event_FormClosed;
        #endregion 

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;
        Af_CambioUbicacion_Activo_Info _InfoCambioUbicacion = new Af_CambioUbicacion_Activo_Info();
        Af_Activo_fijo_Info InfoActiFijo = new Af_Activo_fijo_Info();
        #endregion

        frmAF_Cambio_Ubicacion_Handler frmHandler = new frmAF_Cambio_Ubicacion_Handler();

        public frmAF_Cambio_Ubicacion()
        {
            InitializeComponent();

            frmHandler.ucGe_BarraEstadoInferior_Forms1 = this.ucGe_BarraEstadoInferior_Forms1;
            frmHandler.ucGe_Menu = this.ucGe_Menu;
            frmHandler.cmbSucursal_Nueva = this.cmbSucursal_Nueva;
            frmHandler.cmbSucursal_Actual = this.cmbSucursal_Actual;
            frmHandler.cmbActivoFijo = this.cmbActivoFijo;
            frmHandler.gridActivoFijo = this.gridActivoFijo;
            frmHandler.txtMotivoCambio = this.txtMotivoCambio;
            frmHandler.dtFechaCompra = this.dtFechaCompra;
            frmHandler.cmbUbicacion_Actual = this.cmbUbicacion_Actual;
            frmHandler.cmbUbicacion_Nueva = this.cmbUbicacion_Nueva;
            frmHandler.txtIdCambio = this.txtIdCambio;
            frmHandler.ucCon_CentroCosto_ctas_MoviActual = this.ucCon_CentroCosto_ctas_MoviActual;
            frmHandler.checkBoxdepartamentAct = this.checkBoxdepartamentAct;
            frmHandler.ucAf_DepartamentoCmb1 = this.ucAf_DepartamentoCmb1;
            frmHandler.checkBoxdepartamentNewUbi = this.checkBoxdepartamentNewUbi;
            frmHandler.ucCon_CentroCosto_ctas_MoviNuevo = this.ucCon_CentroCosto_ctas_MoviNuevo;
            frmHandler.ucAf_DepartamentoCmb_nueva = this.ucAf_DepartamentoCmb_nueva;

            ucGe_Menu.event_btnGuardar_Click += frmHandler.ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += frmHandler.ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += frmHandler.ucGe_Menu_event_btnSalir_Click;
            event_FormClosed += frmAF_Cambio_Ubicacion_event_FormClosed;
            ucGe_Menu.event_btnlimpiar_Click += frmHandler.ucGe_Menu_event_btnlimpiar_Click;

            this.cmbActivoFijo.EditValueChanged += new System.EventHandler(frmHandler.cmbActivoFijo_EditValueChanged);
            this.checkBoxdepartamentNewUbi.CheckedChanged += new System.EventHandler(frmHandler.checkBoxdepartamentNewUbi_CheckedChanged);
            this.checkBoxdepartamentAct.CheckedChanged += new System.EventHandler(frmHandler.checkBoxdepartamentAct_CheckedChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAF_Cambio_Ubicacion_FormClosing);
            this.Load += new System.EventHandler(frmHandler.frmAF_Cambio_Ubicacion_Load);
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

        private void frmAF_Cambio_Ubicacion_Load(object sender, EventArgs e)
        {
            try
            {
                frmHandler.Set_FrmChildren(this);
                frmHandler.Set_FrmParent(this.MdiParent);
                frmHandler.Set_eCliente(Cl_Enumeradores.eCliente_Vzen.GENERAL);
                frmHandler.setAccion(_Accion);
                frmHandler.set_InfoActivo_Fijo(InfoActiFijo);
                frmHandler.Set_Af_CambioUbicacion_Activo_Info(_InfoCambioUbicacion);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmAF_Cambio_Ubicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_Cambio_Ubicacion_event_FormClosed(sender, e);
                event_FormClosed(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmAF_Cambio_Ubicacion_event_FormClosed(object sender, FormClosingEventArgs e)
        {

        }

        

       

    }
}