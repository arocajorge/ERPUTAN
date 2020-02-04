namespace Core.Erp.Winform.Controles
{
    partial class UCInv_GridCbte_Cble_x_Ing_Egr_Inv
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridCbteCble_Ing_Egr_Inv = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbteCble_Ing_Egr_Inv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCon_GridDiarioContable1 = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCbteCble_Ing_Egr_Inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteCble_Ing_Egr_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainer1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(780, 408);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridCbteCble_Ing_Egr_Inv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucCon_GridDiarioContable1);
            this.splitContainer1.Size = new System.Drawing.Size(776, 404);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 1;
            // 
            // gridCbteCble_Ing_Egr_Inv
            // 
            this.gridCbteCble_Ing_Egr_Inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCbteCble_Ing_Egr_Inv.Location = new System.Drawing.Point(0, 0);
            this.gridCbteCble_Ing_Egr_Inv.MainView = this.gridViewCbteCble_Ing_Egr_Inv;
            this.gridCbteCble_Ing_Egr_Inv.Name = "gridCbteCble_Ing_Egr_Inv";
            this.gridCbteCble_Ing_Egr_Inv.Size = new System.Drawing.Size(776, 147);
            this.gridCbteCble_Ing_Egr_Inv.TabIndex = 0;
            this.gridCbteCble_Ing_Egr_Inv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbteCble_Ing_Egr_Inv});
            // 
            // gridViewCbteCble_Ing_Egr_Inv
            // 
            this.gridViewCbteCble_Ing_Egr_Inv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewCbteCble_Ing_Egr_Inv.GridControl = this.gridCbteCble_Ing_Egr_Inv;
            this.gridViewCbteCble_Ing_Egr_Inv.Name = "gridViewCbteCble_Ing_Egr_Inv";
            this.gridViewCbteCble_Ing_Egr_Inv.OptionsView.ShowGroupPanel = false;
            this.gridViewCbteCble_Ing_Egr_Inv.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCbteCble_Ing_Egr_Inv_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdEmpresa";
            this.gridColumn1.FieldName = "IdEmpresa_CbteCble";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IdTipoCbte";
            this.gridColumn2.FieldName = "IdTipoCbte";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdCbteCble";
            this.gridColumn3.FieldName = "IdCbteCble";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CodCbteCble";
            this.gridColumn4.FieldName = "CodCbteCble";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Periodo";
            this.gridColumn5.FieldName = "IdPeriodo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha";
            this.gridColumn6.FieldName = "cb_Fecha";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "cb_Valor";
            this.gridColumn7.FieldName = "cb_Valor";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Observacion";
            this.gridColumn8.FieldName = "cb_Observacion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // ucCon_GridDiarioContable1
            // 
            this.ucCon_GridDiarioContable1.Visible_Botones = false;
            this.ucCon_GridDiarioContable1.Visible_Cabecera = false;
            this.ucCon_GridDiarioContable1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ucCon_GridDiarioContable1.ListaCtaCble = null;
            this.ucCon_GridDiarioContable1.Location = new System.Drawing.Point(0, 0);
            this.ucCon_GridDiarioContable1.Name = "ucCon_GridDiarioContable1";
            this.ucCon_GridDiarioContable1.Size = new System.Drawing.Size(776, 253);
            this.ucCon_GridDiarioContable1.TabIndex = 0;
            // 
            // UCInv_GridCbte_Cble_x_Ing_Egr_Inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCInv_GridCbte_Cble_x_Ing_Egr_Inv";
            this.Size = new System.Drawing.Size(780, 408);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCbteCble_Ing_Egr_Inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteCble_Ing_Egr_Inv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridCbteCble_Ing_Egr_Inv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbteCble_Ing_Egr_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UCCon_GridDiarioContable ucCon_GridDiarioContable1;
    }
}
