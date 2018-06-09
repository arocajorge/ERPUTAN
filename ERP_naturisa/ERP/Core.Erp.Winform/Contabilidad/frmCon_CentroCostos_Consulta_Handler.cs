using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Winform.Contabilidad_FJ;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Contabilidad
{
    public class frmCon_CentroCostos_Consulta_Handler
    {
        #region Iniciar controles
        public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        public System.Windows.Forms.Panel panelMain;
        public DevExpress.XtraTreeList.TreeList treeListPlanCta;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colCentro_costo2;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colIdCentroCostoPadre;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colIdNivel;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colpc_EsMovimiento;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colpc_Estado;
        public DevExpress.XtraTreeList.Columns.TreeListColumn IdCtaCble;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colCodCentroCosto;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colCentro_costo;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colIdCentroCosto;
        #endregion

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ct_Centro_costo_Bus _Centro_costo_Bus = new ct_Centro_costo_Bus();
        ct_Centro_costo_Info _Centro_costo_Info = new ct_Centro_costo_Info();
        List<ct_Centro_costo_Info> _List_centro_costo_Info = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Info _centro_costo_PadreInfo = new ct_Centro_costo_Info();
        private Cl_Enumeradores.eTipo_action _Accion;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string MensajeError = "";
        public Form frmChildren;
        public Form frmParent;
        frmCon_CentroCostos_Man frmMant_cc;
        #endregion
        #region "constructor "
        public frmCon_CentroCostos_Consulta_Handler()
        {
        }
        #endregion

        #region "eventos"
        public void frmCon_CentroCostos_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                    Cargar_Centro_costo_Cuenta();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                treeListPlanCta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmChildren.Close();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Centro_costo_Info.pc_Estado == "I") { MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada) + "la cuenta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

                LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void frmCon_PlanCta_Load(object sender, EventArgs e)
        {
            try
            {
                    Cargar_Centro_costo_Cuenta();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                frmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void btn_salir_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmChildren.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Cargar combo"
        public void Cargar_Centro_costo_Cuenta()
        {
            try
            {

                _List_centro_costo_Info = _Centro_costo_Bus.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);

                this.treeListPlanCta.DataSource = _List_centro_costo_Info;
                treeListPlanCta.ExpandAll();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "llamar formulario"
        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmMant_cc = new frmCon_CentroCostos_Man();
                frmMant_cc.event_frmCon_CentroCostos_Man_FormClosing += frmMant_cc_event_frmCon_CentroCostos_Man_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frmMant_cc.Info_centro_costo = _Centro_costo_Info;
                    frmMant_cc.setAccion(Accion);
                }
                frmMant_cc.MdiParent = frmParent;
                frmMant_cc.Show();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmMant_cc_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar_Centro_costo_Cuenta();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "llenar treelist"
        public void treeListPlanCta_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {

                TreeListNode childNode = (TreeListNode)e.Node;
                
                    _Centro_costo_Info = (ct_Centro_costo_Info)treeListPlanCta.GetDataRecordByNode(childNode);
                    if(_Centro_costo_Info!=null)
                        _centro_costo_PadreInfo = _List_centro_costo_Info.Find(delegate(ct_Centro_costo_Info ca) { return ca.IdCentroCosto == _Centro_costo_Info.IdCentroCostoPadre && ca.IdEmpresa == _Centro_costo_Info.IdEmpresa; });
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void treeListPlanCta_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            try
            {

                if (Convert.ToString(e.Node.GetValue(e.Column.AbsoluteIndex)) == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion
    }
}
