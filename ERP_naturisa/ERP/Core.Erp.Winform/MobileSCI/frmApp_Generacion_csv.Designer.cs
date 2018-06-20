namespace Core.Erp.Winform.MobileSCI
{
    partial class frmApp_Generacion_csv
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha_fin = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.de_Fecha_ini = new DevExpress.XtraEditors.DateEdit();
            this.cmb_bodega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_generar_csv = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.gc_generacion = new DevExpress.XtraGrid.GridControl();
            this.gv_generacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.A_aprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbRuta = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_fin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_fin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_ini.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_ini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_generacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_generacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cmbRuta);
            this.panelControl1.Controls.Add(this.btnBuscar);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.de_Fecha_fin);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.de_Fecha_ini);
            this.panelControl1.Controls.Add(this.cmb_bodega);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmb_sucursal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 110);
            this.panelControl1.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(522, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 43);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(329, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Hasta:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(329, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Desde:";
            // 
            // de_Fecha_fin
            // 
            this.de_Fecha_fin.EditValue = null;
            this.de_Fecha_fin.Location = new System.Drawing.Point(382, 42);
            this.de_Fecha_fin.Name = "de_Fecha_fin";
            this.de_Fecha_fin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha_fin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha_fin.Size = new System.Drawing.Size(117, 20);
            this.de_Fecha_fin.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bodega";
            // 
            // de_Fecha_ini
            // 
            this.de_Fecha_ini.EditValue = null;
            this.de_Fecha_ini.Location = new System.Drawing.Point(382, 17);
            this.de_Fecha_ini.Name = "de_Fecha_ini";
            this.de_Fecha_ini.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha_ini.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha_ini.Size = new System.Drawing.Size(117, 20);
            this.de_Fecha_ini.TabIndex = 6;
            // 
            // cmb_bodega
            // 
            this.cmb_bodega.Location = new System.Drawing.Point(75, 43);
            this.cmb_bodega.Name = "cmb_bodega";
            this.cmb_bodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_bodega.Properties.DisplayMember = "bo_Descripcion";
            this.cmb_bodega.Properties.ValueMember = "IdBodega";
            this.cmb_bodega.Properties.View = this.gridView1;
            this.cmb_bodega.Size = new System.Drawing.Size(226, 20);
            this.cmb_bodega.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "IdBodega";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Bodega";
            this.gridColumn4.FieldName = "bo_Descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 660;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sucursal";
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(75, 17);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmb_sucursal.Size = new System.Drawing.Size(226, 20);
            this.cmb_sucursal.TabIndex = 3;
            this.cmb_sucursal.EditValueChanged += new System.EventHandler(this.cmb_sucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdSucursal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "Su_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 660;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_generar_csv,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_generar_csv
            // 
            this.btn_generar_csv.Image = global::Core.Erp.Winform.Properties.Resources.Copiar_doc_20_x_20;
            this.btn_generar_csv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_generar_csv.Name = "btn_generar_csv";
            this.btn_generar_csv.Size = new System.Drawing.Size(88, 22);
            this.btn_generar_csv.Text = "Generar csv";
            this.btn_generar_csv.Click += new System.EventHandler(this.btn_generar_csv_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Core.Erp.Winform.Properties.Resources.Salir_16_x_16;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gc_generacion
            // 
            this.gc_generacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_generacion.Location = new System.Drawing.Point(0, 135);
            this.gc_generacion.MainView = this.gv_generacion;
            this.gc_generacion.Name = "gc_generacion";
            this.gc_generacion.Size = new System.Drawing.Size(783, 458);
            this.gc_generacion.TabIndex = 18;
            this.gc_generacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_generacion});
            // 
            // gv_generacion
            // 
            this.gv_generacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.A_aprobacion,
            this.gridColumn18,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_generacion.GridControl = this.gc_generacion;
            this.gv_generacion.Name = "gv_generacion";
            this.gv_generacion.OptionsView.ShowAutoFilterRow = true;
            this.gv_generacion.OptionsView.ShowFooter = true;
            this.gv_generacion.OptionsView.ShowGroupPanel = false;
            this.gv_generacion.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_generacion_CellValueChanging);
            // 
            // A_aprobacion
            // 
            this.A_aprobacion.Caption = "A";
            this.A_aprobacion.FieldName = "Checked_A";
            this.A_aprobacion.Name = "A_aprobacion";
            this.A_aprobacion.Visible = true;
            this.A_aprobacion.VisibleIndex = 0;
            this.A_aprobacion.Width = 59;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Producto";
            this.gridColumn18.FieldName = "pr_descripcion";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 5;
            this.gridColumn18.Width = 330;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Cantidad";
            this.gridColumn20.DisplayFormat.FormatString = "n2";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "cantidad";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad", "{0:n2}")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 9;
            this.gridColumn20.Width = 134;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Sucursal";
            this.gridColumn21.FieldName = "Su_Descripcion";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            this.gridColumn21.Width = 155;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Bodega";
            this.gridColumn22.FieldName = "bo_Descripcion";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            this.gridColumn22.Width = 183;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Fecha";
            this.gridColumn23.DisplayFormat.FormatString = "d";
            this.gridColumn23.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn23.FieldName = "Fecha";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 3;
            this.gridColumn23.Width = 111;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cod. SC";
            this.gridColumn5.FieldName = "CodProduccionSC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 197;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cod. Pro.";
            this.gridColumn6.FieldName = "CodProduccionPro";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 189;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Subcentro";
            this.gridColumn7.FieldName = "nom_subcentro";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 195;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Centro de costo";
            this.gridColumn8.FieldName = "nom_centro";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 181;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 161;
            this.labelControl3.Text = "Ruta File";
            // 
            // cmbRuta
            // 
            this.cmbRuta.Location = new System.Drawing.Point(75, 69);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbRuta.Properties.ReadOnly = true;
            this.cmbRuta.Size = new System.Drawing.Size(424, 20);
            this.cmbRuta.TabIndex = 160;
            this.cmbRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbRuta_ButtonClick);
            // 
            // frmApp_Generacion_csv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 593);
            this.Controls.Add(this.gc_generacion);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmApp_Generacion_csv";
            this.Text = "frmApp_Generacion_csv";
            this.Load += new System.EventHandler(this.frmApp_Generacion_csv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_fin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_fin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_ini.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha_ini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_generacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_generacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRuta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit de_Fecha_fin;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit de_Fecha_ini;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_bodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripButton btn_generar_csv;
        private DevExpress.XtraGrid.GridControl gc_generacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_generacion;
        private DevExpress.XtraGrid.Columns.GridColumn A_aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit cmbRuta;
    }
}