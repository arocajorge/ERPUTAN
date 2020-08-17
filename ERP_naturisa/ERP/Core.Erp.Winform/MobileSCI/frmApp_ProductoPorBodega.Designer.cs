namespace Core.Erp.Winform.MobileSCI
{
    partial class frmApp_ProductoPorBodega
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBodega = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcNoAsignado = new DevExpress.XtraGrid.GridControl();
            this.gvNoAsignado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionadoNA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNoAsignar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gcAsignado = new DevExpress.XtraGrid.GridControl();
            this.gvAsignado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeleccionadoA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkSeleccionNA = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkSeleccionA = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNoAsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoAsignado)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsignado)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbBodega);
            this.panel1.Controls.Add(this.cmbSucursal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 98);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bodega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sucursal";
            // 
            // cmbBodega
            // 
            this.cmbBodega.Location = new System.Drawing.Point(281, 52);
            this.cmbBodega.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBodega.Properties.DisplayMember = "bo_Descripcion2";
            this.cmbBodega.Properties.ValueMember = "IdBodega";
            this.cmbBodega.Properties.View = this.gridView1;
            this.cmbBodega.Size = new System.Drawing.Size(567, 22);
            this.cmbBodega.TabIndex = 18;
            this.cmbBodega.EditValueChanged += new System.EventHandler(this.cmbBodega_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "IdBodega";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 240;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre";
            this.gridColumn4.FieldName = "bo_Descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 916;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Location = new System.Drawing.Point(281, 22);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursal.Properties.DisplayMember = "Su_Descripcion2";
            this.cmbSucursal.Properties.ValueMember = "IdSucursal";
            this.cmbSucursal.Properties.View = this.searchLookUpEdit1View;
            this.cmbSucursal.Size = new System.Drawing.Size(567, 22);
            this.cmbSucursal.TabIndex = 17;
            this.cmbSucursal.EditValueChanged += new System.EventHandler(this.cmbSucursal_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn13});
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
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 159;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "Su_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 433;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Codigo";
            this.gridColumn13.FieldName = "codigo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 172;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1145, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Core.Erp.Winform.Properties.Resources.Salir_16_x_16;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcNoAsignado);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 571);
            this.panel2.TabIndex = 2;
            // 
            // gcNoAsignado
            // 
            this.gcNoAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNoAsignado.Location = new System.Drawing.Point(0, 33);
            this.gcNoAsignado.MainView = this.gvNoAsignado;
            this.gcNoAsignado.Name = "gcNoAsignado";
            this.gcNoAsignado.Size = new System.Drawing.Size(739, 538);
            this.gcNoAsignado.TabIndex = 19;
            this.gcNoAsignado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNoAsignado});
            // 
            // gvNoAsignado
            // 
            this.gvNoAsignado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn14,
            this.colSeleccionadoNA});
            this.gvNoAsignado.GridControl = this.gcNoAsignado;
            this.gvNoAsignado.Name = "gvNoAsignado";
            this.gvNoAsignado.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvNoAsignado.OptionsView.ShowAutoFilterRow = true;
            this.gvNoAsignado.OptionsView.ShowGroupPanel = false;
            this.gvNoAsignado.OptionsView.ShowViewCaption = true;
            this.gvNoAsignado.ViewCaption = "Productos no asignados";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Linea";
            this.gridColumn6.FieldName = "nom_linea";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Width = 346;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Producto";
            this.gridColumn7.FieldName = "pr_descripcion";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 797;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ID";
            this.gridColumn8.FieldName = "IdProducto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 118;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Codigo";
            this.gridColumn14.FieldName = "pr_codigo";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            this.gridColumn14.Width = 127;
            // 
            // colSeleccionadoNA
            // 
            this.colSeleccionadoNA.Caption = "*";
            this.colSeleccionadoNA.FieldName = "Seleccionado";
            this.colSeleccionadoNA.Name = "colSeleccionadoNA";
            this.colSeleccionadoNA.Visible = true;
            this.colSeleccionadoNA.VisibleIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNoAsignar);
            this.panel3.Controls.Add(this.btnAsignar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(739, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 571);
            this.panel3.TabIndex = 3;
            // 
            // btnNoAsignar
            // 
            this.btnNoAsignar.Location = new System.Drawing.Point(6, 121);
            this.btnNoAsignar.Name = "btnNoAsignar";
            this.btnNoAsignar.Size = new System.Drawing.Size(64, 48);
            this.btnNoAsignar.TabIndex = 1;
            this.btnNoAsignar.Text = "<<";
            this.btnNoAsignar.UseVisualStyleBackColor = true;
            this.btnNoAsignar.Click += new System.EventHandler(this.btnNoAsignar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(6, 57);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(64, 48);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.Text = ">>";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gcAsignado);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(815, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 571);
            this.panel4.TabIndex = 4;
            // 
            // gcAsignado
            // 
            this.gcAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAsignado.Location = new System.Drawing.Point(0, 33);
            this.gcAsignado.MainView = this.gvAsignado;
            this.gcAsignado.Name = "gcAsignado";
            this.gcAsignado.Size = new System.Drawing.Size(330, 538);
            this.gcAsignado.TabIndex = 20;
            this.gcAsignado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAsignado});
            // 
            // gvAsignado
            // 
            this.gvAsignado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn16,
            this.colSeleccionadoA});
            this.gvAsignado.GridControl = this.gcAsignado;
            this.gvAsignado.Name = "gvAsignado";
            this.gvAsignado.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvAsignado.OptionsView.ShowAutoFilterRow = true;
            this.gvAsignado.OptionsView.ShowGroupPanel = false;
            this.gvAsignado.OptionsView.ShowViewCaption = true;
            this.gvAsignado.ViewCaption = "Productos asignados";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Linea";
            this.gridColumn10.FieldName = "nom_linea";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Width = 346;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Producto";
            this.gridColumn11.FieldName = "pr_descripcion";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 797;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "ID";
            this.gridColumn12.FieldName = "IdProducto";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 118;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Codigo";
            this.gridColumn16.FieldName = "pr_codigo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.Width = 127;
            // 
            // colSeleccionadoA
            // 
            this.colSeleccionadoA.Caption = "*";
            this.colSeleccionadoA.FieldName = "Seleccionado";
            this.colSeleccionadoA.Name = "colSeleccionadoA";
            this.colSeleccionadoA.Visible = true;
            this.colSeleccionadoA.VisibleIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkSeleccionNA);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 33);
            this.panel5.TabIndex = 20;
            // 
            // chkSeleccionNA
            // 
            this.chkSeleccionNA.AutoSize = true;
            this.chkSeleccionNA.Location = new System.Drawing.Point(12, 6);
            this.chkSeleccionNA.Name = "chkSeleccionNA";
            this.chkSeleccionNA.Size = new System.Drawing.Size(143, 21);
            this.chkSeleccionNA.TabIndex = 0;
            this.chkSeleccionNA.Text = "Seleccionar todos";
            this.chkSeleccionNA.UseVisualStyleBackColor = true;
            this.chkSeleccionNA.CheckedChanged += new System.EventHandler(this.chkSeleccionNA_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chkSeleccionA);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 33);
            this.panel6.TabIndex = 21;
            // 
            // chkSeleccionA
            // 
            this.chkSeleccionA.AutoSize = true;
            this.chkSeleccionA.Location = new System.Drawing.Point(12, 6);
            this.chkSeleccionA.Name = "chkSeleccionA";
            this.chkSeleccionA.Size = new System.Drawing.Size(143, 21);
            this.chkSeleccionA.TabIndex = 0;
            this.chkSeleccionA.Text = "Seleccionar todos";
            this.chkSeleccionA.UseVisualStyleBackColor = true;
            this.chkSeleccionA.CheckedChanged += new System.EventHandler(this.chkSeleccionA_CheckedChanged);
            // 
            // frmApp_ProductoPorBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 696);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmApp_ProductoPorBodega";
            this.Text = "Asignación de productos por bodega";
            this.Load += new System.EventHandler(this.frmApp_ProductoPorBodega_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNoAsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNoAsignado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsignado)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gcNoAsignado;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNoAsignado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionadoNA;
        private DevExpress.XtraGrid.GridControl gcAsignado;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAsignado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionadoA;
        private System.Windows.Forms.Button btnNoAsignar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkSeleccionNA;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox chkSeleccionA;
    }
}