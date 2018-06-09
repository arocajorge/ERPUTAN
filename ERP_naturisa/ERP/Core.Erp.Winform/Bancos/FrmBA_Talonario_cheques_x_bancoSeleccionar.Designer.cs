namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Talonario_cheques_x_bancoSeleccionar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_Talonario_cheques_x_bancoSeleccionar));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControltalonario = new DevExpress.XtraGrid.GridControl();
            this.gridViewtalonario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen_Imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagen_Descargar = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltalonario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewtalonario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(594, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControltalonario);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 333);
            this.panel1.TabIndex = 2;
            // 
            // gridControltalonario
            // 
            this.gridControltalonario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControltalonario.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControltalonario.Location = new System.Drawing.Point(0, 3);
            this.gridControltalonario.MainView = this.gridViewtalonario;
            this.gridControltalonario.Name = "gridControltalonario";
            this.gridControltalonario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen_Imprimir,
            this.cmbImagen_Descargar});
            this.gridControltalonario.Size = new System.Drawing.Size(591, 327);
            this.gridControltalonario.TabIndex = 0;
            this.gridControltalonario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewtalonario});
            this.gridControltalonario.Click += new System.EventHandler(this.gridControltalonario_Click);
            this.gridControltalonario.DoubleClick += new System.EventHandler(this.gridControltalonario_DoubleClick);
            // 
            // gridViewtalonario
            // 
            this.gridViewtalonario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsado,
            this.colIdEmpresa,
            this.colIdBanco,
            this.colNum_cheque,
            this.colsecuencia,
            this.colEstado});
            this.gridViewtalonario.CustomizationFormBounds = new System.Drawing.Rectangle(432, 334, 216, 178);
            this.gridViewtalonario.GridControl = this.gridControltalonario;
            this.gridViewtalonario.Name = "gridViewtalonario";
            this.gridViewtalonario.OptionsBehavior.Editable = false;
            this.gridViewtalonario.OptionsFind.AlwaysVisible = true;
            this.gridViewtalonario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewtalonario.OptionsView.ShowGroupPanel = false;
            this.gridViewtalonario.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUsado, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewtalonario.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewtalonario_RowClick);
            this.gridViewtalonario.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewtalonario_RowCellStyle);
            this.gridViewtalonario.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewtalonario_FocusedRowChanged);
            // 
            // colUsado
            // 
            this.colUsado.Caption = "Usado";
            this.colUsado.FieldName = "S_Usado";
            this.colUsado.Name = "colUsado";
            this.colUsado.OptionsColumn.AllowEdit = false;
            this.colUsado.OptionsColumn.AllowSize = false;
            this.colUsado.Visible = true;
            this.colUsado.VisibleIndex = 1;
            this.colUsado.Width = 216;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 65;
            // 
            // colIdBanco
            // 
            this.colIdBanco.Caption = "IdBanco";
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Width = 129;
            // 
            // colNum_cheque
            // 
            this.colNum_cheque.Caption = "# Cheque";
            this.colNum_cheque.FieldName = "Num_cheque";
            this.colNum_cheque.Name = "colNum_cheque";
            this.colNum_cheque.Visible = true;
            this.colNum_cheque.VisibleIndex = 0;
            this.colNum_cheque.Width = 964;
            // 
            // colsecuencia
            // 
            this.colsecuencia.Caption = "secuencia";
            this.colsecuencia.FieldName = "secuencia";
            this.colsecuencia.Name = "colsecuencia";
            this.colsecuencia.Width = 491;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowSize = false;
            this.colEstado.Width = 69;
            // 
            // cmbImagen_Imprimir
            // 
            this.cmbImagen_Imprimir.AutoHeight = false;
            this.cmbImagen_Imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen_Imprimir.Name = "cmbImagen_Imprimir";
            // 
            // cmbImagen_Descargar
            // 
            this.cmbImagen_Descargar.AutoHeight = false;
            this.cmbImagen_Descargar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Descargar.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 1)});
            this.cmbImagen_Descargar.Name = "cmbImagen_Descargar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources._1388723697_1710;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmBA_Talonario_cheques_x_bancoSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 386);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmBA_Talonario_cheques_x_bancoSeleccionar";
            this.Text = "Cheques Disponibles";
            this.Load += new System.EventHandler(this.FrmBA_Talonario_cheques_x_bancoConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControltalonario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewtalonario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControltalonario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewtalonario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colsecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Imprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Descargar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}