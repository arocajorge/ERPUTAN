namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_MarcaConsulta
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
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnular = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSalir = new System.Windows.Forms.ToolStripButton();
            this.UlGridMarca = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UlGridMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevo,
            this.toolStripButtonModificar,
            this.toolStripButtonConsultar,
            this.toolStripButtonAnular,
            this.toolStripButtonSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNuevo
            // 
            this.toolStripButtonNuevo.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            this.toolStripButtonNuevo.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonNuevo.Text = "Nuevo";
            this.toolStripButtonNuevo.Click += new System.EventHandler(this.toolStripButtonNuevo_Click);
            // 
            // toolStripButtonModificar
            // 
            this.toolStripButtonModificar.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.toolStripButtonModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificar.Name = "toolStripButtonModificar";
            this.toolStripButtonModificar.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonModificar.Text = "Modificar";
            this.toolStripButtonModificar.Click += new System.EventHandler(this.toolStripButtonModificar_Click);
            // 
            // toolStripButtonConsultar
            // 
            this.toolStripButtonConsultar.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.toolStripButtonConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConsultar.Name = "toolStripButtonConsultar";
            this.toolStripButtonConsultar.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonConsultar.Text = "Consultar";
            this.toolStripButtonConsultar.Click += new System.EventHandler(this.toolStripButtonConsultar_Click);
            // 
            // toolStripButtonAnular
            // 
            this.toolStripButtonAnular.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.toolStripButtonAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnular.Name = "toolStripButtonAnular";
            this.toolStripButtonAnular.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonAnular.Text = "Anular";
            this.toolStripButtonAnular.Click += new System.EventHandler(this.toolStripButtonAnular_Click);
            // 
            // toolStripButtonSalir
            // 
            this.toolStripButtonSalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.toolStripButtonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSalir.Name = "toolStripButtonSalir";
            this.toolStripButtonSalir.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonSalir.Text = "&Salir";
            this.toolStripButtonSalir.Click += new System.EventHandler(this.toolStripButtonSalir_Click);
            // 
            // UlGridMarca
            // 
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.UlGridMarca.DisplayLayout.Appearance = appearance13;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 72;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 327;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.UlGridMarca.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.UlGridMarca.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UlGridMarca.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.UlGridMarca.DisplayLayout.GroupByBox.Appearance = appearance14;
            appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UlGridMarca.DisplayLayout.GroupByBox.BandLabelAppearance = appearance15;
            this.UlGridMarca.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.UlGridMarca.DisplayLayout.GroupByBox.Hidden = true;
            appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance16.BackColor2 = System.Drawing.SystemColors.Control;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UlGridMarca.DisplayLayout.GroupByBox.PromptAppearance = appearance16;
            this.UlGridMarca.DisplayLayout.MaxColScrollRegions = 1;
            this.UlGridMarca.DisplayLayout.MaxRowScrollRegions = 1;
            appearance17.BackColor = System.Drawing.SystemColors.Window;
            appearance17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UlGridMarca.DisplayLayout.Override.ActiveCellAppearance = appearance17;
            appearance18.BackColor = System.Drawing.SystemColors.Highlight;
            appearance18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UlGridMarca.DisplayLayout.Override.ActiveRowAppearance = appearance18;
            this.UlGridMarca.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.UlGridMarca.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance19.BackColor = System.Drawing.SystemColors.Window;
            this.UlGridMarca.DisplayLayout.Override.CardAreaAppearance = appearance19;
            appearance20.BorderColor = System.Drawing.Color.Silver;
            appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.UlGridMarca.DisplayLayout.Override.CellAppearance = appearance20;
            this.UlGridMarca.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.UlGridMarca.DisplayLayout.Override.CellPadding = 0;
            appearance21.BackColor = System.Drawing.SystemColors.Control;
            appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance21.BorderColor = System.Drawing.SystemColors.Window;
            this.UlGridMarca.DisplayLayout.Override.GroupByRowAppearance = appearance21;
            appearance22.TextHAlignAsString = "Left";
            this.UlGridMarca.DisplayLayout.Override.HeaderAppearance = appearance22;
            this.UlGridMarca.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.UlGridMarca.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance23.BackColor = System.Drawing.SystemColors.Window;
            appearance23.BorderColor = System.Drawing.Color.Silver;
            this.UlGridMarca.DisplayLayout.Override.RowAppearance = appearance23;
            this.UlGridMarca.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UlGridMarca.DisplayLayout.Override.TemplateAddRowAppearance = appearance24;
            this.UlGridMarca.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.UlGridMarca.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.UlGridMarca.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.UlGridMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UlGridMarca.ExitEditModeOnLeave = false;
            this.UlGridMarca.Location = new System.Drawing.Point(0, 25);
            this.UlGridMarca.Name = "UlGridMarca";
            this.UlGridMarca.Size = new System.Drawing.Size(565, 237);
            this.UlGridMarca.TabIndex = 3;
            this.UlGridMarca.Text = "ultraGrid1";
            this.UlGridMarca.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.UlGridMarca_InitializeLayout);
            this.UlGridMarca.BeforeRowActivate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.UlGridMarca_BeforeRowActivate);
            // 
            // frmIN_MarcaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.UlGridMarca);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmIN_MarcaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Marca";
            this.Load += new System.EventHandler(this.frmIN_MarcaConsulta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UlGridMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevo;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificar;
        private System.Windows.Forms.ToolStripButton toolStripButtonConsultar;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnular;
        private System.Windows.Forms.ToolStripButton toolStripButtonSalir;
        private Infragistics.Win.UltraWinGrid.UltraGrid UlGridMarca;
    }
}