namespace Core.Erp.Winform.Controles
{
    partial class UCIn_Sucursal_Bodega
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colEstado_B = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_bodega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bo_cod_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bo_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblBodega = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // colEstado_B
            // 
            this.colEstado_B.Caption = "Estado";
            this.colEstado_B.FieldName = "Estado";
            this.colEstado_B.Name = "colEstado_B";
            this.colEstado_B.Visible = true;
            this.colEstado_B.VisibleIndex = 3;
            this.colEstado_B.Width = 96;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 93;
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.Location = new System.Drawing.Point(77, 32);
            this.cmb_bodega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_bodega.Properties.DisplayMember = "bo_Descripcion";
            this.cmb_bodega.Properties.ValueMember = "IdBodega";
            this.cmb_bodega.Properties.View = this.searchLookUpEdit2View;
            this.cmb_bodega.Size = new System.Drawing.Size(532, 22);
            this.cmb_bodega.TabIndex = 6;
            this.cmb_bodega.EditValueChanged += new System.EventHandler(this.cmb_bodega1_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBodega,
            this.bo_cod_bodega,
            this.bo_Descripcion,
            this.colEstado_B});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.colEstado_B;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = false;
            this.searchLookUpEdit2View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBodega
            // 
            this.colIdBodega.Caption = "IdBodega";
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            this.colIdBodega.Visible = true;
            this.colIdBodega.VisibleIndex = 0;
            this.colIdBodega.Width = 56;
            // 
            // bo_cod_bodega
            // 
            this.bo_cod_bodega.Caption = "Cod. Bodega";
            this.bo_cod_bodega.FieldName = "cod_bodega";
            this.bo_cod_bodega.Name = "bo_cod_bodega";
            this.bo_cod_bodega.Visible = true;
            this.bo_cod_bodega.VisibleIndex = 1;
            this.bo_cod_bodega.Width = 76;
            // 
            // bo_Descripcion
            // 
            this.bo_Descripcion.Caption = "Descripción";
            this.bo_Descripcion.FieldName = "bo_Descripcion";
            this.bo_Descripcion.Name = "bo_Descripcion";
            this.bo_Descripcion.Visible = true;
            this.bo_Descripcion.VisibleIndex = 2;
            this.bo_Descripcion.Width = 820;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(77, 4);
            this.cmb_sucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmb_sucursal.Size = new System.Drawing.Size(532, 22);
            this.cmb_sucursal.TabIndex = 5;
            this.cmb_sucursal.EditValueChanged += new System.EventHandler(this.cmb_sucursal1_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal,
            this.colSu_Descripcion,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colEstado;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = false;
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "IdSucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            this.colIdSucursal.Width = 219;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripción";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 868;
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Location = new System.Drawing.Point(1, 37);
            this.lblBodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(61, 17);
            this.lblBodega.TabIndex = 1;
            this.lblBodega.Text = "Bodega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // UCIn_Sucursal_Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_bodega);
            this.Controls.Add(this.cmb_sucursal);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCIn_Sucursal_Bodega";
            this.Size = new System.Drawing.Size(616, 65);
            this.Load += new System.EventHandler(this.UCIn_Sucursal_Bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBodega;
        public System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_bodega;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn bo_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_B;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn bo_cod_bodega;
    }
}
