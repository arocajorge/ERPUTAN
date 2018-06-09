namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Cliente_x_centro_costo_cmb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFa_Cliente_x_centro_costo_cmb));
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.lblCentro_costo = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Cliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_Cliente_cli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Centro_costo_cli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente_cli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_cc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCentro_costo_cc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageListAcciones = new System.Windows.Forms.ImageList(this.components);
            this.btnAccion_cc = new DevExpress.XtraEditors.DropDownButton();
            this.MenuCentro_costo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevo_cc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_cc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_cc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccion_cli = new DevExpress.XtraEditors.DropDownButton();
            this.MenuCliente_x_Centro_costo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevo_cli = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_cli = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_cli = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSub_centro_costo = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Sub_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAccion_Scc = new DevExpress.XtraEditors.DropDownButton();
            this.MenuCentro_costo_sub_centro_costo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevo_Scc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_Scc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_Scc = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.MenuCentro_costo.SuspendLayout();
            this.MenuCliente_x_Centro_costo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sub_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.MenuCentro_costo_sub_centro_costo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(3, 6);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCentro_costo
            // 
            this.lblCentro_costo.Location = new System.Drawing.Point(3, 31);
            this.lblCentro_costo.Name = "lblCentro_costo";
            this.lblCentro_costo.Size = new System.Drawing.Size(66, 13);
            this.lblCentro_costo.TabIndex = 1;
            this.lblCentro_costo.Text = "Centro costo:";
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Cliente.Location = new System.Drawing.Point(90, 3);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Cliente.Properties.DisplayMember = "nom_Cliente";
            this.cmb_Cliente.Properties.ValueMember = "IdCliente_cli";
            this.cmb_Cliente.Properties.View = this.searchLookUpEdit1View;
            this.cmb_Cliente.Size = new System.Drawing.Size(324, 20);
            this.cmb_Cliente.TabIndex = 2;
            this.cmb_Cliente.EditValueChanged += new System.EventHandler(this.cmb_Cliente_EditValueChanged);
            this.cmb_Cliente.Click += new System.EventHandler(this.cmb_Cliente_Click);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_Cliente_cli,
            this.colnom_Centro_costo_cli,
            this.colIdCliente_cli,
            this.colIdCentroCosto_cc});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnom_Cliente_cli
            // 
            this.colnom_Cliente_cli.Caption = "Cliente";
            this.colnom_Cliente_cli.FieldName = "nom_Cliente";
            this.colnom_Cliente_cli.Name = "colnom_Cliente_cli";
            this.colnom_Cliente_cli.Visible = true;
            this.colnom_Cliente_cli.VisibleIndex = 0;
            this.colnom_Cliente_cli.Width = 188;
            // 
            // colnom_Centro_costo_cli
            // 
            this.colnom_Centro_costo_cli.Caption = "Centro costo";
            this.colnom_Centro_costo_cli.FieldName = "nom_Centro_costo";
            this.colnom_Centro_costo_cli.Name = "colnom_Centro_costo_cli";
            this.colnom_Centro_costo_cli.Visible = true;
            this.colnom_Centro_costo_cli.VisibleIndex = 1;
            this.colnom_Centro_costo_cli.Width = 180;
            // 
            // colIdCliente_cli
            // 
            this.colIdCliente_cli.Caption = "ID Cliente";
            this.colIdCliente_cli.FieldName = "IdCliente_cli";
            this.colIdCliente_cli.Name = "colIdCliente_cli";
            this.colIdCliente_cli.Visible = true;
            this.colIdCliente_cli.VisibleIndex = 2;
            this.colIdCliente_cli.Width = 67;
            // 
            // colIdCentroCosto_cc
            // 
            this.colIdCentroCosto_cc.Caption = "ID Centro costo";
            this.colIdCentroCosto_cc.FieldName = "IdCentroCosto_cc";
            this.colIdCentroCosto_cc.Name = "colIdCentroCosto_cc";
            this.colIdCentroCosto_cc.Visible = true;
            this.colIdCentroCosto_cc.VisibleIndex = 3;
            this.colIdCentroCosto_cc.Width = 69;
            // 
            // cmb_Centro_costo
            // 
            this.cmb_Centro_costo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Centro_costo.Location = new System.Drawing.Point(90, 28);
            this.cmb_Centro_costo.Name = "cmb_Centro_costo";
            this.cmb_Centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Centro_costo.Properties.DisplayMember = "Centro_costo2";
            this.cmb_Centro_costo.Properties.ValueMember = "IdCentroCosto";
            this.cmb_Centro_costo.Properties.View = this.gridView1;
            this.cmb_Centro_costo.Size = new System.Drawing.Size(324, 20);
            this.cmb_Centro_costo.TabIndex = 3;
            this.cmb_Centro_costo.EditValueChanged += new System.EventHandler(this.cmb_Centro_costo_EditValueChanged);
            this.cmb_Centro_costo.Click += new System.EventHandler(this.cmb_Centro_costo_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCentro_costo_cc,
            this.colIdCentroCosto});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCentro_costo_cc
            // 
            this.colCentro_costo_cc.Caption = "Centro costo";
            this.colCentro_costo_cc.FieldName = "Centro_costo";
            this.colCentro_costo_cc.Name = "colCentro_costo_cc";
            this.colCentro_costo_cc.Visible = true;
            this.colCentro_costo_cc.VisibleIndex = 0;
            this.colCentro_costo_cc.Width = 385;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "ID";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 1;
            this.colIdCentroCosto.Width = 119;
            // 
            // imageListAcciones
            // 
            this.imageListAcciones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAcciones.ImageStream")));
            this.imageListAcciones.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAcciones.Images.SetKeyName(0, "nuevo5_64x64.png");
            this.imageListAcciones.Images.SetKeyName(1, "monificar_32x32.png");
            this.imageListAcciones.Images.SetKeyName(2, "consultar_32x32.png");
            // 
            // btnAccion_cc
            // 
            this.btnAccion_cc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion_cc.ContextMenuStrip = this.MenuCentro_costo;
            this.btnAccion_cc.ImageIndex = 0;
            this.btnAccion_cc.ImageList = this.imageListAcciones;
            this.btnAccion_cc.Location = new System.Drawing.Point(420, 28);
            this.btnAccion_cc.Name = "btnAccion_cc";
            this.btnAccion_cc.ShowArrowButton = false;
            this.btnAccion_cc.Size = new System.Drawing.Size(39, 20);
            this.btnAccion_cc.TabIndex = 4;
            this.btnAccion_cc.Click += new System.EventHandler(this.btnAccion_cc_Click);
            // 
            // MenuCentro_costo
            // 
            this.MenuCentro_costo.AllowDrop = true;
            this.MenuCentro_costo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_cc,
            this.btnModificar_cc,
            this.btnConsultar_cc});
            this.MenuCentro_costo.Name = "MenuCentro_costo";
            this.MenuCentro_costo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuCentro_costo.Size = new System.Drawing.Size(126, 70);
            // 
            // btnNuevo_cc
            // 
            this.btnNuevo_cc.Image = global::Core.Erp.Winform.Properties.Resources.nuevo_32x32;
            this.btnNuevo_cc.Name = "btnNuevo_cc";
            this.btnNuevo_cc.Size = new System.Drawing.Size(125, 22);
            this.btnNuevo_cc.Text = "Nuevo";
            this.btnNuevo_cc.Click += new System.EventHandler(this.btnNuevo_cc_Click);
            // 
            // btnModificar_cc
            // 
            this.btnModificar_cc.Image = global::Core.Erp.Winform.Properties.Resources.editar1_32x32;
            this.btnModificar_cc.Name = "btnModificar_cc";
            this.btnModificar_cc.Size = new System.Drawing.Size(125, 22);
            this.btnModificar_cc.Text = "Modificar";
            this.btnModificar_cc.Click += new System.EventHandler(this.btnModificar_cc_Click);
            // 
            // btnConsultar_cc
            // 
            this.btnConsultar_cc.Image = global::Core.Erp.Winform.Properties.Resources.Buscar1_32X32;
            this.btnConsultar_cc.Name = "btnConsultar_cc";
            this.btnConsultar_cc.Size = new System.Drawing.Size(125, 22);
            this.btnConsultar_cc.Text = "Consultar";
            this.btnConsultar_cc.Click += new System.EventHandler(this.btnConsultar_cc_Click);
            // 
            // btnAccion_cli
            // 
            this.btnAccion_cli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion_cli.ContextMenuStrip = this.MenuCliente_x_Centro_costo;
            this.btnAccion_cli.ImageIndex = 0;
            this.btnAccion_cli.ImageList = this.imageListAcciones;
            this.btnAccion_cli.Location = new System.Drawing.Point(420, 3);
            this.btnAccion_cli.Name = "btnAccion_cli";
            this.btnAccion_cli.ShowArrowButton = false;
            this.btnAccion_cli.Size = new System.Drawing.Size(39, 20);
            this.btnAccion_cli.TabIndex = 5;
            this.btnAccion_cli.Click += new System.EventHandler(this.btnAccion_cli_Click);
            // 
            // MenuCliente_x_Centro_costo
            // 
            this.MenuCliente_x_Centro_costo.AllowDrop = true;
            this.MenuCliente_x_Centro_costo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_cli,
            this.btnModificar_cli,
            this.btnConsultar_cli});
            this.MenuCliente_x_Centro_costo.Name = "MenuCentro_costo";
            this.MenuCliente_x_Centro_costo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuCliente_x_Centro_costo.Size = new System.Drawing.Size(126, 70);
            // 
            // btnNuevo_cli
            // 
            this.btnNuevo_cli.Image = global::Core.Erp.Winform.Properties.Resources.nuevo_32x32;
            this.btnNuevo_cli.Name = "btnNuevo_cli";
            this.btnNuevo_cli.Size = new System.Drawing.Size(125, 22);
            this.btnNuevo_cli.Text = "Nuevo";
            this.btnNuevo_cli.Click += new System.EventHandler(this.btnNuevo_cli_Click);
            // 
            // btnModificar_cli
            // 
            this.btnModificar_cli.Image = global::Core.Erp.Winform.Properties.Resources.editar1_32x32;
            this.btnModificar_cli.Name = "btnModificar_cli";
            this.btnModificar_cli.Size = new System.Drawing.Size(125, 22);
            this.btnModificar_cli.Text = "Modificar";
            this.btnModificar_cli.Click += new System.EventHandler(this.btnModificar_cli_Click);
            // 
            // btnConsultar_cli
            // 
            this.btnConsultar_cli.Image = global::Core.Erp.Winform.Properties.Resources.Buscar1_32X32;
            this.btnConsultar_cli.Name = "btnConsultar_cli";
            this.btnConsultar_cli.Size = new System.Drawing.Size(125, 22);
            this.btnConsultar_cli.Text = "Consultar";
            this.btnConsultar_cli.Click += new System.EventHandler(this.btnConsultar_cli_Click);
            // 
            // lblSub_centro_costo
            // 
            this.lblSub_centro_costo.Location = new System.Drawing.Point(3, 57);
            this.lblSub_centro_costo.Name = "lblSub_centro_costo";
            this.lblSub_centro_costo.Size = new System.Drawing.Size(82, 13);
            this.lblSub_centro_costo.TabIndex = 6;
            this.lblSub_centro_costo.Text = "Subcentro costo:";
            // 
            // cmb_Sub_centro_costo
            // 
            this.cmb_Sub_centro_costo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Sub_centro_costo.Location = new System.Drawing.Point(90, 54);
            this.cmb_Sub_centro_costo.Name = "cmb_Sub_centro_costo";
            this.cmb_Sub_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Sub_centro_costo.Properties.View = this.gridView2;
            this.cmb_Sub_centro_costo.Size = new System.Drawing.Size(324, 20);
            this.cmb_Sub_centro_costo.TabIndex = 7;
            this.cmb_Sub_centro_costo.EditValueChanged += new System.EventHandler(this.cmb_Sub_centro_costo_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sub centro de costo";
            this.gridColumn1.FieldName = "Centro_costo2";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 349;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID Centro costo";
            this.gridColumn3.FieldName = "IdCentroCosto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // btnAccion_Scc
            // 
            this.btnAccion_Scc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion_Scc.ImageIndex = 0;
            this.btnAccion_Scc.ImageList = this.imageListAcciones;
            this.btnAccion_Scc.Location = new System.Drawing.Point(420, 54);
            this.btnAccion_Scc.Name = "btnAccion_Scc";
            this.btnAccion_Scc.ShowArrowButton = false;
            this.btnAccion_Scc.Size = new System.Drawing.Size(39, 20);
            this.btnAccion_Scc.TabIndex = 8;
            this.btnAccion_Scc.Click += new System.EventHandler(this.btnAccion_Scc_Click);
            // 
            // MenuCentro_costo_sub_centro_costo
            // 
            this.MenuCentro_costo_sub_centro_costo.AllowDrop = true;
            this.MenuCentro_costo_sub_centro_costo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_Scc,
            this.btnModificar_Scc,
            this.btnConsultar_Scc});
            this.MenuCentro_costo_sub_centro_costo.Name = "MenuCentro_costo";
            this.MenuCentro_costo_sub_centro_costo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuCentro_costo_sub_centro_costo.Size = new System.Drawing.Size(126, 70);
            // 
            // btnNuevo_Scc
            // 
            this.btnNuevo_Scc.Image = global::Core.Erp.Winform.Properties.Resources.nuevo_32x32;
            this.btnNuevo_Scc.Name = "btnNuevo_Scc";
            this.btnNuevo_Scc.Size = new System.Drawing.Size(125, 22);
            this.btnNuevo_Scc.Text = "Nuevo";
            this.btnNuevo_Scc.Click += new System.EventHandler(this.btnNuevo_Scc_Click);
            // 
            // btnModificar_Scc
            // 
            this.btnModificar_Scc.Image = global::Core.Erp.Winform.Properties.Resources.editar1_32x32;
            this.btnModificar_Scc.Name = "btnModificar_Scc";
            this.btnModificar_Scc.Size = new System.Drawing.Size(125, 22);
            this.btnModificar_Scc.Text = "Modificar";
            this.btnModificar_Scc.Click += new System.EventHandler(this.btnModificar_Scc_Click);
            // 
            // btnConsultar_Scc
            // 
            this.btnConsultar_Scc.Image = global::Core.Erp.Winform.Properties.Resources.Buscar1_32X32;
            this.btnConsultar_Scc.Name = "btnConsultar_Scc";
            this.btnConsultar_Scc.Size = new System.Drawing.Size(125, 22);
            this.btnConsultar_Scc.Text = "Consultar";
            this.btnConsultar_Scc.Click += new System.EventHandler(this.btnConsultar_Scc_Click);
            // 
            // UCFa_Cliente_x_centro_costo_cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAccion_Scc);
            this.Controls.Add(this.cmb_Sub_centro_costo);
            this.Controls.Add(this.lblSub_centro_costo);
            this.Controls.Add(this.btnAccion_cli);
            this.Controls.Add(this.btnAccion_cc);
            this.Controls.Add(this.cmb_Centro_costo);
            this.Controls.Add(this.cmb_Cliente);
            this.Controls.Add(this.lblCentro_costo);
            this.Controls.Add(this.lblCliente);
            this.Name = "UCFa_Cliente_x_centro_costo_cmb";
            this.Size = new System.Drawing.Size(466, 78);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.MenuCentro_costo.ResumeLayout(false);
            this.MenuCliente_x_Centro_costo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sub_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.MenuCentro_costo_sub_centro_costo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraEditors.LabelControl lblCentro_costo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Cliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ImageList imageListAcciones;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Cliente_cli;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Centro_costo_cli;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente_cli;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cc;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo_cc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraEditors.DropDownButton btnAccion_cc;
        private DevExpress.XtraEditors.DropDownButton btnAccion_cli;
        private System.Windows.Forms.ContextMenuStrip MenuCentro_costo;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_cc;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_cc;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_cc;
        private System.Windows.Forms.ContextMenuStrip MenuCliente_x_Centro_costo;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_cli;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_cli;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_cli;
        private DevExpress.XtraEditors.LabelControl lblSub_centro_costo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_Sub_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DropDownButton btnAccion_Scc;
        private System.Windows.Forms.ContextMenuStrip MenuCentro_costo_sub_centro_costo;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_Scc;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_Scc;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_Scc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
