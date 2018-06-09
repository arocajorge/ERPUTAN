using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;




namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CentroCostos_Consulta : Form
    {
        frmCon_CentroCostos_Consulta_Handler frmHandler = new frmCon_CentroCostos_Consulta_Handler();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmCon_CentroCostos_Consulta()
        {
            InitializeComponent();
            frmHandler.frmParent = this.MdiParent;
            frmHandler.ucGe_BarraEstadoInferior_Forms = this.ucGe_BarraEstadoInferior_Forms;
            frmHandler.ucGe_Menu_Mantenimiento_x_usuario = this.ucGe_Menu_Mantenimiento_x_usuario;
            frmHandler.treeListPlanCta = this.treeListPlanCta;
            //frmHandler.colCentro_costo = this.colCentro_costo;
            frmHandler.colCentro_costo2 = this.colCentro_costo2;
            frmHandler.colCodCentroCosto = this.colCodCentroCosto;
            frmHandler.colIdCentroCosto = this.colIdCentroCosto;
            frmHandler.colpc_EsMovimiento = this.colpc_EsMovimiento;
            frmHandler.colIdNivel = this.colIdNivel;
            frmHandler.colIdCentroCostoPadre = this.colIdCentroCostoPadre;
            frmHandler.colpc_Estado = this.colpc_Estado;
            frmHandler.IdCtaCble = this.IdCtaCble;


            ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;

            this.Load += new System.EventHandler(frmHandler.frmCon_CentroCostos_Consulta_Load);
            this.treeListPlanCta.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(frmHandler.treeListPlanCta_NodeCellStyle);
            this.treeListPlanCta.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(frmHandler.treeListPlanCta_FocusedNodeChanged);
        }

        private void frmCon_CentroCostos_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                frmHandler.frmParent = this.MdiParent;
                frmHandler.frmChildren = this;
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

        


    }
}
