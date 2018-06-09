namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Persona_x_Direcciones_Grid
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
            this.gridControl_Direcciones_x_Persona = new DevExpress.XtraGrid.GridControl();
            this.gridView_Direcciones_x_Persona = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_direccion = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnColnom_TipoDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColIdTipoDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumnColcalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColreferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColcod_postal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RichTextEdit_Direccion = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.MemoText_direccion = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Direcciones_x_Persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Direcciones_x_Persona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RichTextEdit_Direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoText_direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Direcciones_x_Persona
            // 
            this.gridControl_Direcciones_x_Persona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Direcciones_x_Persona.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Direcciones_x_Persona.MainView = this.gridView_Direcciones_x_Persona;
            this.gridControl_Direcciones_x_Persona.Name = "gridControl_Direcciones_x_Persona";
            this.gridControl_Direcciones_x_Persona.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_direccion,
            this.RichTextEdit_Direccion,
            this.MemoText_direccion,
            this.repositoryItemMRUEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControl_Direcciones_x_Persona.Size = new System.Drawing.Size(569, 168);
            this.gridControl_Direcciones_x_Persona.TabIndex = 0;
            this.gridControl_Direcciones_x_Persona.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Direcciones_x_Persona});
            this.gridControl_Direcciones_x_Persona.Click += new System.EventHandler(this.gridControl_Direcciones_x_Persona_Click);
            // 
            // gridView_Direcciones_x_Persona
            // 
            this.gridView_Direcciones_x_Persona.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnColTipo,
            this.gridColumnColDireccion,
            this.gridColumnColcalle,
            this.gridColumnColreferencia,
            this.gridColumnColcod_postal,
            this.gridColumnColCiudad});
            this.gridView_Direcciones_x_Persona.GridControl = this.gridControl_Direcciones_x_Persona;
            this.gridView_Direcciones_x_Persona.Name = "gridView_Direcciones_x_Persona";
            this.gridView_Direcciones_x_Persona.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Direcciones_x_Persona.OptionsView.RowAutoHeight = true;
            this.gridView_Direcciones_x_Persona.OptionsView.ShowGroupPanel = false;
            this.gridView_Direcciones_x_Persona.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Direcciones_x_Persona_CellValueChanged);
            this.gridView_Direcciones_x_Persona.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_Direcciones_x_Persona_CellValueChanging);
            // 
            // gridColumnColTipo
            // 
            this.gridColumnColTipo.Caption = "Tipo";
            this.gridColumnColTipo.ColumnEdit = this.cmb_tipo_direccion;
            this.gridColumnColTipo.FieldName = "IdTipoDireccion";
            this.gridColumnColTipo.Name = "gridColumnColTipo";
            this.gridColumnColTipo.Visible = true;
            this.gridColumnColTipo.VisibleIndex = 0;
            this.gridColumnColTipo.Width = 131;
            // 
            // cmb_tipo_direccion
            // 
            this.cmb_tipo_direccion.AutoHeight = false;
            this.cmb_tipo_direccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_direccion.DisplayMember = "nom_TipoDireccion";
            this.cmb_tipo_direccion.Name = "cmb_tipo_direccion";
            this.cmb_tipo_direccion.ValueMember = "IdTipoDireccion";
            this.cmb_tipo_direccion.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnColnom_TipoDireccion,
            this.gridColumnColIdTipoDireccion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnColnom_TipoDireccion
            // 
            this.gridColumnColnom_TipoDireccion.Caption = "Tipo Direccion";
            this.gridColumnColnom_TipoDireccion.FieldName = "nom_TipoDireccion";
            this.gridColumnColnom_TipoDireccion.Name = "gridColumnColnom_TipoDireccion";
            this.gridColumnColnom_TipoDireccion.Visible = true;
            this.gridColumnColnom_TipoDireccion.VisibleIndex = 0;
            this.gridColumnColnom_TipoDireccion.Width = 976;
            // 
            // gridColumnColIdTipoDireccion
            // 
            this.gridColumnColIdTipoDireccion.Caption = "IdTipoDireccion";
            this.gridColumnColIdTipoDireccion.FieldName = "IdTipoDireccion";
            this.gridColumnColIdTipoDireccion.Name = "gridColumnColIdTipoDireccion";
            this.gridColumnColIdTipoDireccion.Width = 204;
            // 
            // gridColumnColDireccion
            // 
            this.gridColumnColDireccion.Caption = "Direccion";
            this.gridColumnColDireccion.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumnColDireccion.FieldName = "Direccion";
            this.gridColumnColDireccion.Name = "gridColumnColDireccion";
            this.gridColumnColDireccion.Visible = true;
            this.gridColumnColDireccion.VisibleIndex = 1;
            this.gridColumnColDireccion.Width = 420;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumnColcalle
            // 
            this.gridColumnColcalle.Caption = "calle";
            this.gridColumnColcalle.FieldName = "calle";
            this.gridColumnColcalle.Name = "gridColumnColcalle";
            // 
            // gridColumnColreferencia
            // 
            this.gridColumnColreferencia.Caption = "referencia";
            this.gridColumnColreferencia.FieldName = "referencia";
            this.gridColumnColreferencia.Name = "gridColumnColreferencia";
            // 
            // gridColumnColcod_postal
            // 
            this.gridColumnColcod_postal.Caption = "codigo Postal";
            this.gridColumnColcod_postal.FieldName = "cod_postal";
            this.gridColumnColcod_postal.Name = "gridColumnColcod_postal";
            // 
            // gridColumnColCiudad
            // 
            this.gridColumnColCiudad.Caption = "Ciudad";
            this.gridColumnColCiudad.FieldName = "Ciudad";
            this.gridColumnColCiudad.Name = "gridColumnColCiudad";
            // 
            // RichTextEdit_Direccion
            // 
            this.RichTextEdit_Direccion.MaxHeight = 1000;
            this.RichTextEdit_Direccion.Name = "RichTextEdit_Direccion";
            this.RichTextEdit_Direccion.OptionsHorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Auto;
            this.RichTextEdit_Direccion.ShowCaretInReadOnly = false;
            // 
            // MemoText_direccion
            // 
            this.MemoText_direccion.AutoHeight = false;
            this.MemoText_direccion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MemoText_direccion.Name = "MemoText_direccion";
            // 
            // repositoryItemMRUEdit1
            // 
            this.repositoryItemMRUEdit1.AutoHeight = false;
            this.repositoryItemMRUEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMRUEdit1.Name = "repositoryItemMRUEdit1";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gridControl_Direcciones_x_Persona);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(569, 168);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // UCGe_Persona_x_Direcciones_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "UCGe_Persona_x_Direcciones_Grid";
            this.Size = new System.Drawing.Size(569, 168);
            this.Load += new System.EventHandler(this.UCGe_Persona_x_Direcciones_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Direcciones_x_Persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Direcciones_x_Persona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RichTextEdit_Direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoText_direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Direcciones_x_Persona;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Direcciones_x_Persona;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColTipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_direccion;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColnom_TipoDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColIdTipoDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColDireccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit RichTextEdit_Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColcalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColreferencia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColcod_postal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColCiudad;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit MemoText_direccion;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}
