using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaAdmision_Cons : Form
    {

        FrmAcaAdmision_Cons_Handler frmHandler = new FrmAcaAdmision_Cons_Handler();

        public FrmAcaAdmision_Cons()
        {
            InitializeComponent();

            frmHandler.gridControlAdmision = this.gridControlAdmision;
            frmHandler.gvAdmision = this.gvAdmision;

            this.Load += new System.EventHandler(frmHandler.FrmAcaAdmision_Cons_Load);

            this.ucGe_Menu.event_btnNuevo_ItemClick += frmHandler.ucGe_Menu_event_btnNuevo_ItemClick;
            this.ucGe_Menu.event_btnModificar_ItemClick += frmHandler.ucGe_Menu_event_btnModificar_ItemClick;
            this.ucGe_Menu.event_btnconsultar_ItemClick += frmHandler.ucGe_Menu_event_btnconsultar_ItemClick;
            this.ucGe_Menu.event_btnAnular_ItemClick += frmHandler.ucGe_Menu_event_btnAnular_ItemClick;
            this.ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            this.ucGe_Menu.event_btnImprimir_ItemClick += frmHandler.ucGe_Menu_event_btnImprimir_ItemClick;
            gvAdmision.RowStyle += frmHandler.gvAdmision_RowStyle;
            
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void FrmAcaAdmision_Cons_Load(object sender, EventArgs e)
        {

        }

       
    }
}
