namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_SeguimientoOrdenCompraContable
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbImagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSucursalOC = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtOC = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursalOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.cmbSucursalOC);
            this.panel1.Controls.Add(this.labelControl10);
            this.panel1.Controls.Add(this.txtOC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 66);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1287, 27);
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
            // gcDetalle
            // 
            this.gcDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDetalle.Location = new System.Drawing.Point(0, 93);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen});
            this.gcDetalle.Size = new System.Drawing.Size(1287, 606);
            this.gcDetalle.TabIndex = 2;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn19,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsBehavior.ReadOnly = true;
            this.gvDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // cmbImagen
            // 
            this.cmbImagen.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbImagen.AutoHeight = false;
            this.cmbImagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmbImagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 3)});
            this.cmbImagen.Name = "cmbImagen";
            this.cmbImagen.ReadOnly = true;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(24, 13);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 16);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "Sucursal";
            // 
            // cmbSucursalOC
            // 
            this.cmbSucursalOC.Location = new System.Drawing.Point(24, 32);
            this.cmbSucursalOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSucursalOC.Name = "cmbSucursalOC";
            this.cmbSucursalOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSucursalOC.Properties.DisplayMember = "codigo";
            this.cmbSucursalOC.Properties.ValueMember = "IdSucursal";
            this.cmbSucursalOC.Properties.View = this.gridView5;
            this.cmbSucursalOC.Size = new System.Drawing.Size(143, 22);
            this.cmbSucursalOC.TabIndex = 24;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdSucursal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 273;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sucursal";
            this.gridColumn2.FieldName = "Su_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1188;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 273;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(172, 13);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 16);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Orden de compra";
            // 
            // txtOC
            // 
            this.txtOC.EditValue = "";
            this.txtOC.Location = new System.Drawing.Point(172, 32);
            this.txtOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(100, 22);
            this.txtOC.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_16x16;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# OC";
            this.gridColumn4.FieldName = "CodigoOC";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Secuencia";
            this.gridColumn5.FieldName = "Secuencia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ID";
            this.gridColumn6.FieldName = "IdProducto";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Producto";
            this.gridColumn7.FieldName = "pr_descripcion";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 200;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Cantidad";
            this.gridColumn8.FieldName = "do_Cantidad";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 100;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Precio final";
            this.gridColumn9.FieldName = "do_precioFinal";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 100;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Subtotal";
            this.gridColumn10.FieldName = "do_subtotal";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "I.V.A.";
            this.gridColumn11.FieldName = "do_iva";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            this.gridColumn11.Width = 100;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Total";
            this.gridColumn12.FieldName = "do_total";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 9;
            this.gridColumn12.Width = 100;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn13.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn13.Caption = "Sucursal ingreso";
            this.gridColumn13.FieldName = "Su_Descripcion";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 10;
            this.gridColumn13.Width = 200;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn14.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn14.Caption = "Tipo de movimiento";
            this.gridColumn14.FieldName = "tm_descripcion";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 11;
            this.gridColumn14.Width = 200;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn15.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn15.Caption = "# Movi";
            this.gridColumn15.FieldName = "IdNumMovi";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 12;
            this.gridColumn15.Width = 100;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn16.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn16.Caption = "Fecha ingreso";
            this.gridColumn16.DisplayFormat.FormatString = "d";
            this.gridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn16.FieldName = "cm_fecha";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 13;
            this.gridColumn16.Width = 100;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn17.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn17.Caption = "Cant. ing.";
            this.gridColumn17.FieldName = "dm_cantidad_sinConversion";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 14;
            this.gridColumn17.Width = 100;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn18.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn18.Caption = "# Aprobacion";
            this.gridColumn18.FieldName = "IdAprobacion";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 16;
            this.gridColumn18.Width = 100;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Proveedor";
            this.gridColumn19.FieldName = "pe_nombreCompleto";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 200;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn20.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn20.Caption = "Fecha factura";
            this.gridColumn20.DisplayFormat.FormatString = "d";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn20.FieldName = "Fecha_Factura";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 17;
            this.gridColumn20.Width = 100;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn21.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn21.Caption = "# Factura";
            this.gridColumn21.FieldName = "num_documento";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 18;
            this.gridColumn21.Width = 150;
            // 
            // gridColumn22
            // 
            this.gridColumn22.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn22.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn22.Caption = "Usuario ing.";
            this.gridColumn22.FieldName = "UsuarioIngresa";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 15;
            this.gridColumn22.Width = 100;
            // 
            // gridColumn23
            // 
            this.gridColumn23.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn23.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn23.Caption = "Usuario apro.";
            this.gridColumn23.FieldName = "UsuarioAprobacion";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 19;
            this.gridColumn23.Width = 100;
            // 
            // gridColumn24
            // 
            this.gridColumn24.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn24.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn24.Caption = "Observación";
            this.gridColumn24.FieldName = "ObservacionAprobacion";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 20;
            this.gridColumn24.Width = 200;
            // 
            // FrmCom_SeguimientoOrdenCompraContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 699);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCom_SeguimientoOrdenCompraContable";
            this.Text = "Seguimiento de órdenes de compra ";
            this.Load += new System.EventHandler(this.FrmCom_SeguimientoOrdenCompraContable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursalOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSucursalOC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtOC;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
    }
}