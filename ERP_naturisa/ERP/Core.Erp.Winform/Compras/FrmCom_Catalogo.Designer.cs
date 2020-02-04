namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_Catalogo
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNuevo_c = new System.Windows.Forms.ToolStripSplitButton();
            this.btnModificar_c = new System.Windows.Forms.ToolStripSplitButton();
            this.lstbox_TipoCatalogo = new System.Windows.Forms.ListBox();
            this.gridControlCatalogo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbrebiatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_c,
            this.btnModificar_c});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(194, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNuevo_c
            // 
            this.btnNuevo_c.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnNuevo_c.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo_c.Name = "btnNuevo_c";
            this.btnNuevo_c.Size = new System.Drawing.Size(74, 20);
            this.btnNuevo_c.Text = "Nuevo";
            this.btnNuevo_c.Click += new System.EventHandler(this.btnNuevo_c_Click);
            // 
            // btnModificar_c
            // 
            this.btnModificar_c.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btnModificar_c.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar_c.Name = "btnModificar_c";
            this.btnModificar_c.Size = new System.Drawing.Size(90, 20);
            this.btnModificar_c.Text = "Modificar";
            this.btnModificar_c.Click += new System.EventHandler(this.btnModificar_c_Click);
            // 
            // lstbox_TipoCatalogo
            // 
            this.lstbox_TipoCatalogo.DisplayMember = "Descripcion";
            this.lstbox_TipoCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_TipoCatalogo.FormattingEnabled = true;
            this.lstbox_TipoCatalogo.Location = new System.Drawing.Point(0, 0);
            this.lstbox_TipoCatalogo.Name = "lstbox_TipoCatalogo";
            this.lstbox_TipoCatalogo.Size = new System.Drawing.Size(194, 434);
            this.lstbox_TipoCatalogo.TabIndex = 13;
            this.lstbox_TipoCatalogo.ValueMember = "IdCatalogo_tipo";
            this.lstbox_TipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedIndexChanged_1);
            // 
            // gridControlCatalogo
            // 
            this.gridControlCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCatalogo.Location = new System.Drawing.Point(0, 0);
            this.gridControlCatalogo.MainView = this.gridViewCatalogo;
            this.gridControlCatalogo.Name = "gridControlCatalogo";
            this.gridControlCatalogo.Size = new System.Drawing.Size(591, 363);
            this.gridControlCatalogo.TabIndex = 14;
            this.gridControlCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatalogo});
            // 
            // gridViewCatalogo
            // 
            this.gridViewCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodCatalogo,
            this.colNombre,
            this.colAbrebiatura,
            this.colEstado});
            this.gridViewCatalogo.GridControl = this.gridControlCatalogo;
            this.gridViewCatalogo.Name = "gridViewCatalogo";
            this.gridViewCatalogo.OptionsBehavior.Editable = false;
            this.gridViewCatalogo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCatalogo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCatalogo_RowCellStyle_1);
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.Caption = "Código";
            this.colCodCatalogo.FieldName = "IdCatalogocompra";
            this.colCodCatalogo.Name = "colCodCatalogo";
            this.colCodCatalogo.Visible = true;
            this.colCodCatalogo.VisibleIndex = 0;
            this.colCodCatalogo.Width = 151;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 759;
            // 
            // colAbrebiatura
            // 
            this.colAbrebiatura.Caption = "Abrebiatura";
            this.colAbrebiatura.FieldName = "Abrebiatura";
            this.colAbrebiatura.Name = "colAbrebiatura";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 248;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucGe_Menu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(591, 93);
            this.panelControl1.TabIndex = 0;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 3, 17, 15, 38, 23, 187);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 5, 17, 15, 38, 23, 187);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(587, 90);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstbox_TipoCatalogo);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainer1.Size = new System.Drawing.Size(789, 456);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlCatalogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 363);
            this.panel1.TabIndex = 1;
            // 
            // FrmCom_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmCom_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.FrmCom_Catalogo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_TipoCatalogo;
        private DevExpress.XtraGrid.GridControl gridControlCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatalogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnNuevo_c;
        private System.Windows.Forms.ToolStripSplitButton btnModificar_c;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAbrebiatura;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;


    }
}