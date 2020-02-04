namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Bancos_cmb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGe_Bancos_cmb));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.cmb_Banco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Banco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 77;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo_128x128.png");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Modificar,
            this.btn_Consultar});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(125, 22);
            this.btn_Nuevo.Text = "Nuevo";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 22);
            this.btn_Modificar.Text = "Modificar";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(125, 22);
            this.btn_Consultar.Text = "Consultar";
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ImageIndex = 0;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(317, 1);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 114;
            this.cmb_Acciones.Visible = false;
            // 
            // cmb_Banco
            // 
            this.cmb_Banco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Banco.Location = new System.Drawing.Point(3, 4);
            this.cmb_Banco.Name = "cmb_Banco";
            this.cmb_Banco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Banco.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Banco.Size = new System.Drawing.Size(308, 20);
            this.cmb_Banco.TabIndex = 113;
            this.cmb_Banco.EditValueChanged += new System.EventHandler(this.cmb_CuentaBanco_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colba_descripcion,
            this.colba_Num_Cuenta,
            this.colIdCtaCble,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "I";
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "Id";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 0;
            this.colIdBanco.Width = 76;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 1;
            this.colba_descripcion.Width = 599;
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.Caption = "# Cuenta";
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            this.colba_Num_Cuenta.Visible = true;
            this.colba_Num_Cuenta.VisibleIndex = 2;
            this.colba_Num_Cuenta.Width = 225;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 3;
            this.colIdCtaCble.Width = 185;
            // 
            // UCGe_Bancos_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmb_Banco);
            this.Name = "UCGe_Bancos_cmb";
            this.Size = new System.Drawing.Size(357, 34);
            this.Load += new System.EventHandler(this.UCGe_Bancos_cmb_Load);
            this.MenuAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Banco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_Consultar;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Banco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}
