namespace Core.Erp.Winform.Inventario_Cidersus
{
    partial class FrmIn_CodigoBarra_Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_CodigoBarra_Busqueda));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridCtrlCodBarra = new DevExpress.XtraGrid.GridControl();
            this.gridVwCodBarra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._cmbProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProducto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCodBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwCodBarra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cmbProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.BtnSeleccionar,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(557, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(87, 22);
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridCtrlCodBarra);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 444);
            this.panel1.TabIndex = 6;
            // 
            // gridCtrlCodBarra
            // 
            this.gridCtrlCodBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlCodBarra.Location = new System.Drawing.Point(0, 60);
            this.gridCtrlCodBarra.MainView = this.gridVwCodBarra;
            this.gridCtrlCodBarra.Name = "gridCtrlCodBarra";
            this.gridCtrlCodBarra.Size = new System.Drawing.Size(557, 384);
            this.gridCtrlCodBarra.TabIndex = 3;
            this.gridCtrlCodBarra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwCodBarra});
            this.gridCtrlCodBarra.DoubleClick += new System.EventHandler(this.gridVwCodBarra_DoubleClick);
            // 
            // gridVwCodBarra
            // 
            this.gridVwCodBarra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProducto,
            this.colCodigoBarra,
            this.coldm_cantidad,
            this.colSecuencia,
            this.colIdProducto});
            this.gridVwCodBarra.GridControl = this.gridCtrlCodBarra;
            this.gridVwCodBarra.Name = "gridVwCodBarra";
            this.gridVwCodBarra.OptionsFind.AlwaysVisible = true;
            this.gridVwCodBarra.OptionsView.ShowGroupPanel = false;
            this.gridVwCodBarra.DoubleClick += new System.EventHandler(this.gridVwCodBarra_DoubleClick);
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.OptionsColumn.ReadOnly = true;
            this.colProducto.Width = 238;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.Caption = "Codigo de Barra";
            this.colCodigoBarra.FieldName = "CodigoBarra";
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.OptionsColumn.AllowEdit = false;
            this.colCodigoBarra.OptionsColumn.ReadOnly = true;
            this.colCodigoBarra.Visible = true;
            this.colCodigoBarra.VisibleIndex = 1;
            this.colCodigoBarra.Width = 236;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.OptionsColumn.AllowEdit = false;
            this.coldm_cantidad.OptionsColumn.ReadOnly = true;
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 2;
            this.coldm_cantidad.Width = 32;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.OptionsColumn.ReadOnly = true;
            this.colSecuencia.OptionsColumn.ShowCaption = false;
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 0;
            this.colSecuencia.Width = 33;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cmbProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // _cmbProducto
            // 
            this._cmbProducto.Location = new System.Drawing.Point(115, 21);
            this._cmbProducto.Name = "_cmbProducto";
            this._cmbProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._cmbProducto.Properties.View = this.searchLookUpEdit1View;
            this._cmbProducto.Size = new System.Drawing.Size(400, 20);
            this._cmbProducto.TabIndex = 105;
            this._cmbProducto.EditValueChanged += new System.EventHandler(this._cmbProducto_EditValueChanged);
            this._cmbProducto.Validating += new System.ComponentModel.CancelEventHandler(this._cmbProducto_Validating);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProducto_grid,
            this.colIdProducto_grid});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colProducto_grid
            // 
            this.colProducto_grid.Caption = "Producto";
            this.colProducto_grid.FieldName = "Producto";
            this.colProducto_grid.Name = "colProducto_grid";
            this.colProducto_grid.Visible = true;
            this.colProducto_grid.VisibleIndex = 0;
            this.colProducto_grid.Width = 819;
            // 
            // colIdProducto_grid
            // 
            this.colIdProducto_grid.Caption = "IdProducto";
            this.colIdProducto_grid.FieldName = "IdProducto";
            this.colIdProducto_grid.Name = "colIdProducto_grid";
            this.colIdProducto_grid.Visible = true;
            this.colIdProducto_grid.VisibleIndex = 1;
            this.colIdProducto_grid.Width = 361;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // FrmIn_CodigoBarra_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmIn_CodigoBarra_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Barra Busqueda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_CodigoBarra_Busqueda_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_CodigoBarra_Busqueda_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlCodBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwCodBarra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cmbProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSeleccionar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridCtrlCodBarra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwCodBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraEditors.SearchLookUpEdit _cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_grid;
    }
}