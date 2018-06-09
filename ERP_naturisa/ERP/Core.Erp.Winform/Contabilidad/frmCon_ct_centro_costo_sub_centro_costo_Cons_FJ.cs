using Core.Erp.Business.General;
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

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_ct_centro_costo_sub_centro_costo_Cons_FJ : Form
    {
        frmCon_ct_centro_costo_sub_centro_costo_Cons_Handler frmHandler = new frmCon_ct_centro_costo_sub_centro_costo_Cons_Handler();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public frmCon_ct_centro_costo_sub_centro_costo_Cons_FJ()
        {
            try
            {
                InitializeComponent();

                frmHandler.ucGe_Menu_Mantenimiento_x_usuario = this.ucGe_Menu_Mantenimiento_x_usuario;
                frmHandler.statusStrip1 = this.statusStrip1;
                frmHandler.gridControlSubCentro = this.gridControlSubCentro;
                frmHandler.gridViewSubCentro = this.gridViewSubCentro;
                frmHandler.Set_Cliente_VZEN(Cl_Enumeradores.eCliente_Vzen.FJ);
                // frmMant.event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing += frmMant_event_frmCon_CentroCosto_SubCentroCosto_Mant_FormClosing;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += frmHandler.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

                this.gridViewSubCentro.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(frmHandler.gridViewSubCentro_RowCellStyle);
                this.gridViewSubCentro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(frmHandler.gridViewSubCentro_FocusedRowChanged);
                this.Load += new System.EventHandler(frmHandler.frmCon_ct_centro_costo_sub_centro_costo_Cons_Load);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void frmCon_ct_centro_costo_sub_centro_costo_Cons_FJ_Load(object sender, EventArgs e)
        {
            try
            {
                frmHandler.Set_frmParent(this.MdiParent);
                frmHandler.Set_frmChildren(this);                
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
