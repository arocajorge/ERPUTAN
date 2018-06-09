namespace Core.Erp.Winform.Controles
{
    partial class UCInv_Estado_apro_x_Ing_Egr_Inven
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInv_Estado_apro_x_Ing_Egr_Inven));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbEstado_Apro_x_ing_Egr_Inven = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado_Apro_x_ing_Egr_Inven.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "nuevo_32x32.png");
            this.imageList1.Images.SetKeyName(2, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(3, "downloads1.ico");
            this.imageList1.Images.SetKeyName(4, "ico_insert1.png");
            this.imageList1.Images.SetKeyName(5, "agregar2.png");
            // 
            // cmbEstado_Apro_x_ing_Egr_Inven
            // 
            this.cmbEstado_Apro_x_ing_Egr_Inven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstado_Apro_x_ing_Egr_Inven.Location = new System.Drawing.Point(3, 5);
            this.cmbEstado_Apro_x_ing_Egr_Inven.Name = "cmbEstado_Apro_x_ing_Egr_Inven";
            this.cmbEstado_Apro_x_ing_Egr_Inven.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado_Apro_x_ing_Egr_Inven.Properties.DisplayMember = "Descripcion";
            this.cmbEstado_Apro_x_ing_Egr_Inven.Properties.ValueMember = "IdEstadoAproba";
            this.cmbEstado_Apro_x_ing_Egr_Inven.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstado_Apro_x_ing_Egr_Inven.Size = new System.Drawing.Size(242, 20);
            this.cmbEstado_Apro_x_ing_Egr_Inven.TabIndex = 59;
            this.cmbEstado_Apro_x_ing_Egr_Inven.EditValueChanged += new System.EventHandler(this.cmbEstado_Apro_x_ing_Egr_Inven_EditValueChanged);
            this.cmbEstado_Apro_x_ing_Egr_Inven.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEstado_Apro_x_ing_Egr_Inven_Validating);
            this.cmbEstado_Apro_x_ing_Egr_Inven.Validated += new System.EventHandler(this.cmbEstado_Apro_x_ing_Egr_Inven_Validated_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colIdEstadoAproba,
            this.colestado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "*ANULADO*";
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 804;
            // 
            // colIdEstadoAproba
            // 
            this.colIdEstadoAproba.Caption = "IdEstadoAproba";
            this.colIdEstadoAproba.FieldName = "IdEstadoAproba";
            this.colIdEstadoAproba.Name = "colIdEstadoAproba";
            this.colIdEstadoAproba.Visible = true;
            this.colIdEstadoAproba.VisibleIndex = 0;
            this.colIdEstadoAproba.Width = 83;
            // 
            // colestado
            // 
            this.colestado.Caption = "Estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 2;
            // 
            // UCInv_Estado_apro_x_Ing_Egr_Inven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbEstado_Apro_x_ing_Egr_Inven);
            this.Name = "UCInv_Estado_apro_x_Ing_Egr_Inven";
            this.Size = new System.Drawing.Size(248, 34);
            this.Load += new System.EventHandler(this.UCInv_Estado_apro_x_Ing_Egr_Inven_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado_Apro_x_ing_Egr_Inven.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbEstado_Apro_x_ing_Egr_Inven;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}
