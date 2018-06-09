namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Cobro_x_Anticipo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlTipoCobro = new DevExpress.XtraGrid.GridControl();
            this.cxccobrotipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTipoCobro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlCobroAnticipo = new DevExpress.XtraGrid.GridControl();
            this.cxcCobroTipoxAnticipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCobroAnticipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro_tipo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevius = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllPrevius = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCobro)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobroAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcCobroTipoxAnticipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobroAnticipo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlTipoCobro);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Cobros Disponibles";
            // 
            // gridControlTipoCobro
            // 
            this.gridControlTipoCobro.DataSource = this.cxccobrotipoInfoBindingSource;
            this.gridControlTipoCobro.Location = new System.Drawing.Point(6, 26);
            this.gridControlTipoCobro.MainView = this.gridViewTipoCobro;
            this.gridControlTipoCobro.Name = "gridControlTipoCobro";
            this.gridControlTipoCobro.Size = new System.Drawing.Size(388, 391);
            this.gridControlTipoCobro.TabIndex = 0;
            this.gridControlTipoCobro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoCobro});
            // 
            // cxccobrotipoInfoBindingSource
            // 
            this.cxccobrotipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_tipo_Info);
            // 
            // gridViewTipoCobro
            // 
            this.gridViewTipoCobro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro_tipo,
            this.coltc_descripcion});
            this.gridViewTipoCobro.GridControl = this.gridControlTipoCobro;
            this.gridViewTipoCobro.Name = "gridViewTipoCobro";
            this.gridViewTipoCobro.OptionsBehavior.Editable = false;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.Caption = "Id Tipo de Cobro";
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 0;
            this.colIdCobro_tipo.Width = 99;
            // 
            // coltc_descripcion
            // 
            this.coltc_descripcion.Caption = "Descripción";
            this.coltc_descripcion.FieldName = "tc_descripcion";
            this.coltc_descripcion.Name = "coltc_descripcion";
            this.coltc_descripcion.Visible = true;
            this.coltc_descripcion.VisibleIndex = 1;
            this.coltc_descripcion.Width = 271;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlCobroAnticipo);
            this.groupBox2.Location = new System.Drawing.Point(490, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo De Cobro Asignado";
            // 
            // gridControlCobroAnticipo
            // 
            this.gridControlCobroAnticipo.DataSource = this.cxcCobroTipoxAnticipoInfoBindingSource;
            this.gridControlCobroAnticipo.Location = new System.Drawing.Point(6, 26);
            this.gridControlCobroAnticipo.MainView = this.gridViewCobroAnticipo;
            this.gridControlCobroAnticipo.Name = "gridControlCobroAnticipo";
            this.gridControlCobroAnticipo.Size = new System.Drawing.Size(355, 391);
            this.gridControlCobroAnticipo.TabIndex = 0;
            this.gridControlCobroAnticipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCobroAnticipo});
            // 
            // cxcCobroTipoxAnticipoInfoBindingSource
            // 
            this.cxcCobroTipoxAnticipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_Cobro_Tipo_x_Anticipo_Info);
            // 
            // gridViewCobroAnticipo
            // 
            this.gridViewCobroAnticipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro_tipo1,
            this.colposicion});
            this.gridViewCobroAnticipo.GridControl = this.gridControlCobroAnticipo;
            this.gridViewCobroAnticipo.Name = "gridViewCobroAnticipo";
            this.gridViewCobroAnticipo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewCobroAnticipo_CellValueChanged);
            // 
            // colIdCobro_tipo1
            // 
            this.colIdCobro_tipo1.Caption = "Id Cobro Tipo";
            this.colIdCobro_tipo1.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo1.Name = "colIdCobro_tipo1";
            this.colIdCobro_tipo1.OptionsColumn.AllowEdit = false;
            this.colIdCobro_tipo1.Visible = true;
            this.colIdCobro_tipo1.VisibleIndex = 0;
            this.colIdCobro_tipo1.Width = 113;
            // 
            // colposicion
            // 
            this.colposicion.Caption = "Posición";
            this.colposicion.FieldName = "posicion";
            this.colposicion.Name = "colposicion";
            this.colposicion.Visible = true;
            this.colposicion.VisibleIndex = 1;
            this.colposicion.Width = 224;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(421, 103);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAllNext
            // 
            this.btnAllNext.Location = new System.Drawing.Point(421, 132);
            this.btnAllNext.Name = "btnAllNext";
            this.btnAllNext.Size = new System.Drawing.Size(59, 23);
            this.btnAllNext.TabIndex = 3;
            this.btnAllNext.Text = ">>";
            this.btnAllNext.Click += new System.EventHandler(this.btnAllNext_Click);
            // 
            // btnPrevius
            // 
            this.btnPrevius.Location = new System.Drawing.Point(421, 161);
            this.btnPrevius.Name = "btnPrevius";
            this.btnPrevius.Size = new System.Drawing.Size(59, 23);
            this.btnPrevius.TabIndex = 4;
            this.btnPrevius.Text = "<";
            this.btnPrevius.Click += new System.EventHandler(this.btnPrevius_Click);
            // 
            // btnAllPrevius
            // 
            this.btnAllPrevius.Location = new System.Drawing.Point(421, 190);
            this.btnAllPrevius.Name = "btnAllPrevius";
            this.btnAllPrevius.Size = new System.Drawing.Size(59, 23);
            this.btnAllPrevius.TabIndex = 5;
            this.btnAllPrevius.Text = "<<";
            this.btnAllPrevius.Click += new System.EventHandler(this.btnAllPrevius_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCxc_Cobro_x_Anticipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAllPrevius);
            this.Controls.Add(this.btnPrevius);
            this.Controls.Add(this.btnAllNext);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCxc_Cobro_x_Anticipo";
            this.Text = "Tipo De Cobros Por Anticipo";
            this.Load += new System.EventHandler(this.frmCxc_Cobro_x_Anticipo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTipoCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobrotipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoCobro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCobroAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcCobroTipoxAnticipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCobroAnticipo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlTipoCobro;
        private System.Windows.Forms.BindingSource cxccobrotipoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoCobro;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlCobroAnticipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCobroAnticipo;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnAllNext;
        private DevExpress.XtraEditors.SimpleButton btnPrevius;
        private DevExpress.XtraEditors.SimpleButton btnAllPrevius;
        private System.Windows.Forms.BindingSource cxcCobroTipoxAnticipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo1;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_descripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}