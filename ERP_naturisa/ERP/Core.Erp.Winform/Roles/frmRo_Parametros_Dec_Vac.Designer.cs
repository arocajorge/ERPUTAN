namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Parametros_Dec_Vac
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
            this.gridControlRubrosIess = new DevExpress.XtraGrid.GridControl();
            this.gridViewRubrosIess = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chked = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_anio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.roConfigSueldoBasicoxanioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsb_anio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsb_valor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlSBanio = new DevExpress.XtraGrid.GridControl();
            this.gridViewSBanio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsb_IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsb_anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsb_valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_GuardarSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubrosIess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrosIess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chked)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_anio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roConfigSueldoBasicoxanioInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSBanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSBanio)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlRubrosIess);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(469, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rubros que se registrarn en el aporte IESS";
            // 
            // gridControlRubrosIess
            // 
            this.gridControlRubrosIess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRubrosIess.Location = new System.Drawing.Point(3, 16);
            this.gridControlRubrosIess.MainView = this.gridViewRubrosIess;
            this.gridControlRubrosIess.Name = "gridControlRubrosIess";
            this.gridControlRubrosIess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chked});
            this.gridControlRubrosIess.Size = new System.Drawing.Size(463, 232);
            this.gridControlRubrosIess.TabIndex = 0;
            this.gridControlRubrosIess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubrosIess});
            // 
            // gridViewRubrosIess
            // 
            this.gridViewRubrosIess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdRubro,
            this.colOrden,
            this.colValor,
            this.colru_descripcion,
            this.colChecked});
            this.gridViewRubrosIess.GridControl = this.gridControlRubrosIess;
            this.gridViewRubrosIess.Name = "gridViewRubrosIess";
            this.gridViewRubrosIess.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubrosIess.OptionsView.ShowGroupPanel = false;
            this.gridViewRubrosIess.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrden, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdRubro
            // 
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            // 
            // colValor
            // 
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colru_descripcion
            // 
            this.colru_descripcion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colru_descripcion.AppearanceHeader.Options.UseFont = true;
            this.colru_descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colru_descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colru_descripcion.Caption = "Rubros";
            this.colru_descripcion.FieldName = "ru_descripcion";
            this.colru_descripcion.Name = "colru_descripcion";
            this.colru_descripcion.Visible = true;
            this.colru_descripcion.VisibleIndex = 0;
            this.colru_descripcion.Width = 220;
            // 
            // colChecked
            // 
            this.colChecked.ColumnEdit = this.chked;
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.ShowCaption = false;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 1;
            this.colChecked.Width = 33;
            // 
            // chked
            // 
            this.chked.AutoHeight = false;
            this.chked.Name = "chked";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 44);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_anio);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 44);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sueldo Básico Actual";
            // 
            // cmb_anio
            // 
            this.cmb_anio.Location = new System.Drawing.Point(3, 16);
            this.cmb_anio.Name = "cmb_anio";
            this.cmb_anio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_anio.Properties.DataSource = this.roConfigSueldoBasicoxanioInfoBindingSource;
            this.cmb_anio.Properties.DisplayMember = "sb_valor";
            this.cmb_anio.Properties.ValueMember = "sb_valor";
            this.cmb_anio.Properties.View = this.searchLookUpEdit1View;
            this.cmb_anio.Size = new System.Drawing.Size(463, 20);
            this.cmb_anio.TabIndex = 3;
            // 
            // roConfigSueldoBasicoxanioInfoBindingSource
            // 
            this.roConfigSueldoBasicoxanioInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Config_SueldoBasico_x_anio_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsb_anio1,
            this.colsb_valor1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colsb_anio1
            // 
            this.colsb_anio1.Caption = "Año";
            this.colsb_anio1.FieldName = "sb_anio";
            this.colsb_anio1.Name = "colsb_anio1";
            this.colsb_anio1.Visible = true;
            this.colsb_anio1.VisibleIndex = 0;
            // 
            // colsb_valor1
            // 
            this.colsb_valor1.Caption = "Sueldo básico";
            this.colsb_valor1.FieldName = "sb_valor";
            this.colsb_valor1.Name = "colsb_valor1";
            this.colsb_valor1.Visible = true;
            this.colsb_valor1.VisibleIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlSBanio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo básico por años";
            // 
            // gridControlSBanio
            // 
            this.gridControlSBanio.DataSource = this.roConfigSueldoBasicoxanioInfoBindingSource;
            this.gridControlSBanio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSBanio.Location = new System.Drawing.Point(3, 16);
            this.gridControlSBanio.MainView = this.gridViewSBanio;
            this.gridControlSBanio.Name = "gridControlSBanio";
            this.gridControlSBanio.Size = new System.Drawing.Size(463, 110);
            this.gridControlSBanio.TabIndex = 0;
            this.gridControlSBanio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSBanio});
            // 
            // gridViewSBanio
            // 
            this.gridViewSBanio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsb_IdRubro,
            this.colsb_anio,
            this.colsb_valor,
            this.colIdUsuario1,
            this.colFecha_Transac1,
            this.colIdUsuarioUltMod1,
            this.colFecha_UltMod1,
            this.colIdUsuarioUltAnu1,
            this.colFecha_UltAnu1,
            this.colnom_pc1,
            this.colip1});
            this.gridViewSBanio.GridControl = this.gridControlSBanio;
            this.gridViewSBanio.Name = "gridViewSBanio";
            // 
            // colsb_IdRubro
            // 
            this.colsb_IdRubro.FieldName = "sb_IdRubro";
            this.colsb_IdRubro.Name = "colsb_IdRubro";
            // 
            // colsb_anio
            // 
            this.colsb_anio.Caption = "Año";
            this.colsb_anio.FieldName = "sb_anio";
            this.colsb_anio.Name = "colsb_anio";
            this.colsb_anio.OptionsColumn.AllowEdit = false;
            this.colsb_anio.Visible = true;
            this.colsb_anio.VisibleIndex = 0;
            // 
            // colsb_valor
            // 
            this.colsb_valor.Caption = "Sueldo básico";
            this.colsb_valor.FieldName = "sb_valor";
            this.colsb_valor.Name = "colsb_valor";
            this.colsb_valor.Visible = true;
            this.colsb_valor.VisibleIndex = 1;
            // 
            // colIdUsuario1
            // 
            this.colIdUsuario1.FieldName = "IdUsuario";
            this.colIdUsuario1.Name = "colIdUsuario1";
            // 
            // colFecha_Transac1
            // 
            this.colFecha_Transac1.FieldName = "Fecha_Transac";
            this.colFecha_Transac1.Name = "colFecha_Transac1";
            // 
            // colIdUsuarioUltMod1
            // 
            this.colIdUsuarioUltMod1.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod1.Name = "colIdUsuarioUltMod1";
            // 
            // colFecha_UltMod1
            // 
            this.colFecha_UltMod1.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod1.Name = "colFecha_UltMod1";
            // 
            // colIdUsuarioUltAnu1
            // 
            this.colIdUsuarioUltAnu1.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu1.Name = "colIdUsuarioUltAnu1";
            // 
            // colFecha_UltAnu1
            // 
            this.colFecha_UltAnu1.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu1.Name = "colFecha_UltAnu1";
            // 
            // colnom_pc1
            // 
            this.colnom_pc1.FieldName = "nom_pc";
            this.colnom_pc1.Name = "colnom_pc1";
            // 
            // colip1
            // 
            this.colip1.FieldName = "ip";
            this.colip1.Name = "colip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_Guardar
            // 
            this.mnu_Guardar.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.mnu_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_Guardar.Name = "mnu_Guardar";
            this.mnu_Guardar.Size = new System.Drawing.Size(69, 22);
            this.mnu_Guardar.Text = "Guardar";
            this.mnu_Guardar.Click += new System.EventHandler(this.mnu_Guardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_GuardarSalir
            // 
            this.mnu_GuardarSalir.Image = global::Core.Erp.Winform.Properties.Resources.Guardar1;
            this.mnu_GuardarSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_GuardarSalir.Name = "mnu_GuardarSalir";
            this.mnu_GuardarSalir.Size = new System.Drawing.Size(103, 22);
            this.mnu_GuardarSalir.Text = "Guardar y Salir";
            this.mnu_GuardarSalir.Click += new System.EventHandler(this.mnu_GuardarSalir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mnu_Salir
            // 
            this.mnu_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnu_Salir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.mnu_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_Salir.Name = "mnu_Salir";
            this.mnu_Salir.Size = new System.Drawing.Size(49, 22);
            this.mnu_Salir.Text = "Salir";
            this.mnu_Salir.Click += new System.EventHandler(this.mnu_Salir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnu_Guardar,
            this.toolStripSeparator2,
            this.mnu_GuardarSalir,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.mnu_Salir,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(469, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmRo_Parametros_Dec_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Parametros_Dec_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros_Dec_Vac";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Parametros_Dec_Vac_KeyPress);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRubrosIess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrosIess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chked)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_anio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roConfigSueldoBasicoxanioInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSBanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSBanio)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlRubrosIess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubrosIess;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colru_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chked;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlSBanio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSBanio;
        private System.Windows.Forms.BindingSource roConfigSueldoBasicoxanioInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsb_IdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colsb_anio;
        private DevExpress.XtraGrid.Columns.GridColumn colsb_valor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu1;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc1;
        private DevExpress.XtraGrid.Columns.GridColumn colip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_anio;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colsb_anio1;
        private DevExpress.XtraGrid.Columns.GridColumn colsb_valor1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnu_Guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mnu_GuardarSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mnu_Salir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}