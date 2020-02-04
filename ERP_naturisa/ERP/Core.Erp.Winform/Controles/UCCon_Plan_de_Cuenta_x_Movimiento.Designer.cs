namespace Core.Erp.Winform.Controles
{
    partial class UCCon_Plan_de_Cuenta_x_Movimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCon_Plan_de_Cuenta_x_Movimiento));
            this.cmb_cuentas = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Naturaleza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_acciones = new DevExpress.XtraEditors.DropDownButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cuentas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.MenuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_cuentas
            // 
            this.cmb_cuentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_cuentas.Location = new System.Drawing.Point(3, 6);
            this.cmb_cuentas.Name = "cmb_cuentas";
            this.cmb_cuentas.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmb_cuentas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cuentas.Properties.DisplayMember = "pc_Cuenta2";
            this.cmb_cuentas.Properties.ValueMember = "IdCtaCble";
            this.cmb_cuentas.Properties.View = this.searchLookUpEdit1View;
            this.cmb_cuentas.Size = new System.Drawing.Size(359, 20);
            this.cmb_cuentas.TabIndex = 0;
            this.cmb_cuentas.EditValueChanged += new System.EventHandler(this.cmd_cuentas_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble,
            this.colpc_Cuenta,
            this.colIdCtaCblePadre,
            this.colCuentaPadre,
            this.colpc_Naturaleza,
            this.colIdGrupoCble,
            this.colClave});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.RowAutoHeight = true;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "IdCtaCble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 0;
            this.colIdCtaCble.Width = 105;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "pc_Cuenta";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 2;
            this.colpc_Cuenta.Width = 440;
            // 
            // colIdCtaCblePadre
            // 
            this.colIdCtaCblePadre.Caption = "IdCtaCblePadre";
            this.colIdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.colIdCtaCblePadre.Name = "colIdCtaCblePadre";
            this.colIdCtaCblePadre.Visible = true;
            this.colIdCtaCblePadre.VisibleIndex = 3;
            this.colIdCtaCblePadre.Width = 95;
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.Caption = "CuentaPadre";
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            this.colCuentaPadre.Visible = true;
            this.colCuentaPadre.VisibleIndex = 4;
            this.colCuentaPadre.Width = 265;
            // 
            // colpc_Naturaleza
            // 
            this.colpc_Naturaleza.Caption = "pc_Naturaleza";
            this.colpc_Naturaleza.FieldName = "pc_Naturaleza";
            this.colpc_Naturaleza.Name = "colpc_Naturaleza";
            this.colpc_Naturaleza.Visible = true;
            this.colpc_Naturaleza.VisibleIndex = 5;
            this.colpc_Naturaleza.Width = 73;
            // 
            // colIdGrupoCble
            // 
            this.colIdGrupoCble.Caption = "IdGrupoCble";
            this.colIdGrupoCble.FieldName = "IdGrupoCble";
            this.colIdGrupoCble.Name = "colIdGrupoCble";
            this.colIdGrupoCble.Visible = true;
            this.colIdGrupoCble.VisibleIndex = 6;
            this.colIdGrupoCble.Width = 85;
            // 
            // colClave
            // 
            this.colClave.Caption = "Código";
            this.colClave.FieldName = "pc_clave_corta";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 1;
            this.colClave.Width = 117;
            // 
            // btn_acciones
            // 
            this.btn_acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_acciones.ImageIndex = 2;
            this.btn_acciones.ImageList = this.imageList1;
            this.btn_acciones.Location = new System.Drawing.Point(368, 3);
            this.btn_acciones.Name = "btn_acciones";
            this.btn_acciones.ShowArrowButton = false;
            this.btn_acciones.Size = new System.Drawing.Size(34, 23);
            this.btn_acciones.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(2, "downloads1.ico");
            // 
            // MenuAcciones
            // 
            this.MenuAcciones.AllowDrop = true;
            this.MenuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.MenuAcciones.Name = "MenuAcciones";
            this.MenuAcciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones.Text = "Acciones";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // UCCon_Plan_de_Cuenta_x_Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_acciones);
            this.Controls.Add(this.cmb_cuentas);
            this.Name = "UCCon_Plan_de_Cuenta_x_Movimiento";
            this.Size = new System.Drawing.Size(405, 29);
            this.Load += new System.EventHandler(this.UCCon_Plan_de_Cuenta_x_Movimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cuentas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.MenuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmb_cuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DropDownButton btn_acciones;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Naturaleza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
    }
}
