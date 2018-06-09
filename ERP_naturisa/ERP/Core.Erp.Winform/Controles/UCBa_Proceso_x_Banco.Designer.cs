namespace Core.Erp.Winform.Controles
{
    partial class UCBa_Proceso_x_Banco
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBa_Proceso_x_Banco));
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbProceso = new System.Windows.Forms.Label();
            this.cmbProceso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Colnom_proceso_bancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdProceso_bancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_proc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Label_Banco = new System.Windows.Forms.Label();
            this.cmb_Banco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colba_Num_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAcciones_Proceso = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colIdBanco_Financiero = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Banco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.MenuAcciones_Proceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 77;
            // 
            // lbProceso
            // 
            this.lbProceso.AutoSize = true;
            this.lbProceso.Location = new System.Drawing.Point(10, 31);
            this.lbProceso.Name = "lbProceso";
            this.lbProceso.Size = new System.Drawing.Size(46, 13);
            this.lbProceso.TabIndex = 126;
            this.lbProceso.Text = "Proceso";
            // 
            // cmbProceso
            // 
            this.cmbProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProceso.Location = new System.Drawing.Point(62, 28);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProceso.Properties.DisplayMember = "nom_proceso_bancario";
            this.cmbProceso.Properties.ValueMember = "IdProceso_bancario_tipo";
            this.cmbProceso.Properties.View = this.gridView1;
            this.cmbProceso.Size = new System.Drawing.Size(307, 20);
            this.cmbProceso.TabIndex = 124;
            this.cmbProceso.EditValueChanged += new System.EventHandler(this.cmbProceso_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Colnom_proceso_bancario,
            this.ColIdProceso_bancario,
            this.coltipo_proc});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "I";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Colnom_proceso_bancario
            // 
            this.Colnom_proceso_bancario.Caption = "Proceso";
            this.Colnom_proceso_bancario.FieldName = "nom_proceso_bancario";
            this.Colnom_proceso_bancario.Name = "Colnom_proceso_bancario";
            this.Colnom_proceso_bancario.Visible = true;
            this.Colnom_proceso_bancario.VisibleIndex = 1;
            this.Colnom_proceso_bancario.Width = 881;
            // 
            // ColIdProceso_bancario
            // 
            this.ColIdProceso_bancario.Caption = "Id Proceso Ban";
            this.ColIdProceso_bancario.FieldName = "IdProceso_bancario_tipo";
            this.ColIdProceso_bancario.Name = "ColIdProceso_bancario";
            this.ColIdProceso_bancario.Visible = true;
            this.ColIdProceso_bancario.VisibleIndex = 0;
            this.ColIdProceso_bancario.Width = 201;
            // 
            // coltipo_proc
            // 
            this.coltipo_proc.Caption = "Tipo_Proc";
            this.coltipo_proc.FieldName = "Tipo_Proc";
            this.coltipo_proc.Name = "coltipo_proc";
            this.coltipo_proc.Visible = true;
            this.coltipo_proc.VisibleIndex = 2;
            this.coltipo_proc.Width = 98;
            // 
            // Label_Banco
            // 
            this.Label_Banco.AutoSize = true;
            this.Label_Banco.Location = new System.Drawing.Point(10, 5);
            this.Label_Banco.Name = "Label_Banco";
            this.Label_Banco.Size = new System.Drawing.Size(38, 13);
            this.Label_Banco.TabIndex = 123;
            this.Label_Banco.Text = "Banco";
            // 
            // cmb_Banco
            // 
            this.cmb_Banco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Banco.Location = new System.Drawing.Point(62, 2);
            this.cmb_Banco.Name = "cmb_Banco";
            this.cmb_Banco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Banco.Properties.DisplayMember = "ba_descripcion2";
            this.cmb_Banco.Properties.ValueMember = "IdBanco";
            this.cmb_Banco.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Banco.Size = new System.Drawing.Size(307, 20);
            this.cmb_Banco.TabIndex = 121;
            this.cmb_Banco.EditValueChanged += new System.EventHandler(this.cmb_Banco_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdBanco,
            this.colba_descripcion,
            this.colba_Num_Cuenta,
            this.colIdCtaCble,
            this.colEstado,
            this.colIdBanco_Financiero});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.colEstado;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "I";
            this.searchLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition4});
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
            this.colIdBanco.Width = 77;
            // 
            // colba_descripcion
            // 
            this.colba_descripcion.Caption = "Banco";
            this.colba_descripcion.FieldName = "ba_descripcion";
            this.colba_descripcion.Name = "colba_descripcion";
            this.colba_descripcion.Visible = true;
            this.colba_descripcion.VisibleIndex = 1;
            this.colba_descripcion.Width = 609;
            // 
            // colba_Num_Cuenta
            // 
            this.colba_Num_Cuenta.Caption = "# Cuenta";
            this.colba_Num_Cuenta.FieldName = "ba_Num_Cuenta";
            this.colba_Num_Cuenta.Name = "colba_Num_Cuenta";
            this.colba_Num_Cuenta.Visible = true;
            this.colba_Num_Cuenta.VisibleIndex = 2;
            this.colba_Num_Cuenta.Width = 233;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 3;
            this.colIdCtaCble.Width = 184;
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
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(125, 22);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consultar.Image")));
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(125, 22);
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // MenuAcciones_Proceso
            // 
            this.MenuAcciones_Proceso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.MenuAcciones_Proceso.Name = "MenuAcciones";
            this.MenuAcciones_Proceso.Size = new System.Drawing.Size(126, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem1.Text = "Nuevo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem2.Text = "Modificar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem3.Text = "Consultar";
            // 
            // colIdBanco_Financiero
            // 
            this.colIdBanco_Financiero.Caption = "IdBanco_Financiero";
            this.colIdBanco_Financiero.FieldName = "IdBanco_Financiero";
            this.colIdBanco_Financiero.Name = "colIdBanco_Financiero";
            this.colIdBanco_Financiero.Visible = true;
            this.colIdBanco_Financiero.VisibleIndex = 4;
            this.colIdBanco_Financiero.Width = 77;
            // 
            // UCBa_Proceso_x_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbProceso);
            this.Controls.Add(this.cmbProceso);
            this.Controls.Add(this.Label_Banco);
            this.Controls.Add(this.cmb_Banco);
            this.Name = "UCBa_Proceso_x_Banco";
            this.Size = new System.Drawing.Size(377, 48);
            this.Load += new System.EventHandler(this.UCBa_Proceso_x_Banco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Banco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.MenuAcciones_Proceso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProceso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label Label_Banco;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colba_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colba_Num_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem btn_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem btn_Modificar;
        private System.Windows.Forms.ToolStripMenuItem btn_Consultar;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_proceso_bancario;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProceso_bancario;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones_Proceso;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbProceso;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_proc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco_Financiero;
    }
}
