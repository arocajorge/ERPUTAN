namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Sucursal_PtoVta_cmb
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.cmb_PtoVta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colIdPuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PtoVta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_PtoVta
            // 
            this.cmb_PtoVta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_PtoVta.Location = new System.Drawing.Point(63, 26);
            this.cmb_PtoVta.Name = "cmb_PtoVta";
            this.cmb_PtoVta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_PtoVta.Properties.DisplayMember = "nom_PuntoVta2";
            this.cmb_PtoVta.Properties.ValueMember = "IdPuntoVta";
            this.cmb_PtoVta.Properties.View = this.searchLookUpEdit2View;
            this.cmb_PtoVta.Size = new System.Drawing.Size(411, 20);
            this.cmb_PtoVta.TabIndex = 10;
            this.cmb_PtoVta.EditValueChanged += new System.EventHandler(this.UCIn_Sucursal_Bodega_Event_cmb_PtoVta_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPuntoVta,
            this.colcod_PuntoVta,
            this.colnom_PuntoVta,
            this.colestado_});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colestado_;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.searchLookUpEdit2View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_sucursal.Location = new System.Drawing.Point(63, 3);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmb_sucursal.Size = new System.Drawing.Size(411, 20);
            this.cmb_sucursal.TabIndex = 9;
            this.cmb_sucursal.EditValueChanged += new System.EventHandler(this.UCIn_Sucursal_Bodega_Event_cmb_sucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSucursal,
            this.colSu_Descripcion,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colEstado;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = false;
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pto Venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sucursal:";
            // 
            // colIdPuntoVta
            // 
            this.colIdPuntoVta.Caption = "IdPuntoVta";
            this.colIdPuntoVta.FieldName = "IdPuntoVta";
            this.colIdPuntoVta.Name = "colIdPuntoVta";
            this.colIdPuntoVta.Visible = true;
            this.colIdPuntoVta.VisibleIndex = 2;
            // 
            // colcod_PuntoVta
            // 
            this.colcod_PuntoVta.Caption = "Codigo";
            this.colcod_PuntoVta.FieldName = "cod_PuntoVta";
            this.colcod_PuntoVta.Name = "colcod_PuntoVta";
            this.colcod_PuntoVta.Visible = true;
            this.colcod_PuntoVta.VisibleIndex = 0;
            this.colcod_PuntoVta.Width = 98;
            // 
            // colnom_PuntoVta
            // 
            this.colnom_PuntoVta.Caption = "PuntoVta";
            this.colnom_PuntoVta.FieldName = "nom_PuntoVta";
            this.colnom_PuntoVta.Name = "colnom_PuntoVta";
            this.colnom_PuntoVta.Visible = true;
            this.colnom_PuntoVta.VisibleIndex = 1;
            this.colnom_PuntoVta.Width = 875;
            // 
            // colestado_
            // 
            this.colestado_.Caption = "Estado";
            this.colestado_.FieldName = "estado";
            this.colestado_.Name = "colestado_";
            this.colestado_.Visible = true;
            this.colestado_.VisibleIndex = 3;
            this.colestado_.Width = 108;
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
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 93;
            // 
            // UCFa_Sucursal_PtoCargo_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_PtoVta);
            this.Controls.Add(this.cmb_sucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCFa_Sucursal_PtoCargo_cmb";
            this.Size = new System.Drawing.Size(477, 49);
            this.Load += new System.EventHandler(this.UCFa_Sucursal_PtoCargo_cmb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PtoVta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SearchLookUpEdit cmb_PtoVta;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn colestado_;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}
