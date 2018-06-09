using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Cambio_Ubicacion_Consul : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmAF_Cambio_Ubicacion_Consul_Handler frmHandler = new frmAF_Cambio_Ubicacion_Consul_Handler();
        vwAf_CambioUbicacion_Info _Info = new vwAf_CambioUbicacion_Info();

        public frmAF_Cambio_Ubicacion_Consul()
        {

            InitializeComponent();
            frmHandler.gridCambioUbi = this.gridCambioUbi;
            frmHandler.gridViewCambioUbi = this.gridViewCambioUbi;
            frmHandler.ucGe_BarraEstadoInferior_Forms1 = this.ucGe_BarraEstadoInferior_Forms1;
            frmHandler.ucGe_Menu = this.ucGe_Menu;
                        
            ucGe_Menu.event_btnNuevo_ItemClick += frmHandler.ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += frmHandler.ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += frmHandler.ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += frmHandler.ucGe_Menu_event_btnBuscar_Click;

            this.gridViewCambioUbi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(frmHandler.gridViewCambioUbi_RowClick);
            this.gridViewCambioUbi.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(frmHandler.gridViewCambioUbi_RowCellStyle);
            this.Load += new System.EventHandler(frmHandler.frmAF_Cambio_Ubicacion_Consul_Load);
        }        

        private void frmAF_Cambio_Ubicacion_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                frmHandler.Set_FrmChildren(this);
                frmHandler.Set_FrmParent(this.MdiParent);
                frmHandler.Set_eCliente(Cl_Enumeradores.eCliente_Vzen.GENERAL);
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