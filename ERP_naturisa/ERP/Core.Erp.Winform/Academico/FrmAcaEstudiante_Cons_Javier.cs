using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaEstudiante_Cons_Javier : Form
    {
        FrmAcaEstudiante_Cons_Handler frmHadler = new FrmAcaEstudiante_Cons_Handler();


        public FrmAcaEstudiante_Cons_Javier()
        {
            InitializeComponent();
                //this.MdiParent
            //
            this.gridViewEstudiante.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(frmHadler.gridViewEstudiante_RowCellStyle);
            this.Load += new System.EventHandler(frmHadler.FrmAcaEstudiante_Cons_Load);
            ucGe_Menu.event_btnSalir_ItemClick += frmHadler.ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += frmHadler.ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += frmHadler.ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += frmHadler.ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += frmHadler.ucGe_Menu_event_btnconsultar_ItemClick;
            this.bntBuscar.Click += new System.EventHandler(frmHadler.bntBuscar_Click);
        }

        private void FrmAcaEstudiante_Cons_Javier_Load(object sender, EventArgs e)
        {
            // asignacion de controles con mis controles de formulario
            frmHadler.gridControlEstudiante = this.gridControlEstudiante;
            frmHadler.gridViewEstudiante = this.gridViewEstudiante;
            frmHadler.FrmMDIParent = this.MdiParent;

        }

        

        



        


        

        

    }
}
