namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_Catalogo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControlCatalogo = new DevExpress.XtraGrid.GridControl();
            this.cxcCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstbox_TipoCatalogo = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNuevo_c = new System.Windows.Forms.ToolStripSplitButton();
            this.btnModificar_c = new System.Windows.Forms.ToolStripSplitButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.statusStrip2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(237, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 459);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControlCatalogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 346);
            this.panel3.TabIndex = 14;
            // 
            // gridControlCatalogo
            // 
            this.gridControlCatalogo.DataSource = this.cxcCatalogoInfoBindingSource;
            this.gridControlCatalogo.Location = new System.Drawing.Point(0, 0);
            this.gridControlCatalogo.MainView = this.gridViewCatalogo;
            this.gridControlCatalogo.Name = "gridControlCatalogo";
            this.gridControlCatalogo.Size = new System.Drawing.Size(698, 346);
            this.gridControlCatalogo.TabIndex = 13;
            this.gridControlCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatalogo});
            // 
            // cxcCatalogoInfoBindingSource
            // 
            this.cxcCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_catalogo_Info);
            // 
            // gridViewCatalogo
            // 
            this.gridViewCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colNombre,
            this.colEstado,
            this.colOrden});
            this.gridViewCatalogo.GridControl = this.gridControlCatalogo;
            this.gridViewCatalogo.Name = "gridViewCatalogo";
            this.gridViewCatalogo.OptionsBehavior.Editable = false;
            this.gridViewCatalogo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCatalogo.OptionsView.ShowGroupPanel = false;
            this.gridViewCatalogo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCatalogo_RowCellStyle);
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 0;
            this.colIdCatalogo.Width = 147;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Descripción";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 510;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 300;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.Visible = true;
            this.colOrden.VisibleIndex = 3;
            this.colOrden.Width = 169;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 437);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(698, 22);
            this.statusStrip2.TabIndex = 16;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 91);
            this.panel4.TabIndex = 15;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 7, 6, 16, 7, 41, 201);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 9, 6, 16, 7, 41, 201);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(698, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lstbox_TipoCatalogo);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 456);
            this.panel2.TabIndex = 0;
            // 
            // lstbox_TipoCatalogo
            // 
            this.lstbox_TipoCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbox_TipoCatalogo.DisplayMember = "Descripcion";
            this.lstbox_TipoCatalogo.FormattingEnabled = true;
            this.lstbox_TipoCatalogo.Location = new System.Drawing.Point(-3, 0);
            this.lstbox_TipoCatalogo.Name = "lstbox_TipoCatalogo";
            this.lstbox_TipoCatalogo.Size = new System.Drawing.Size(236, 433);
            this.lstbox_TipoCatalogo.TabIndex = 12;
            this.lstbox_TipoCatalogo.ValueMember = "IdCatalogo_tipo";
            this.lstbox_TipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_c,
            this.btnModificar_c});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(233, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNuevo_c
            // 
            this.btnNuevo_c.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnNuevo_c.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo_c.Name = "btnNuevo_c";
            this.btnNuevo_c.Size = new System.Drawing.Size(74, 20);
            this.btnNuevo_c.Text = "Nuevo";
            this.btnNuevo_c.ButtonClick += new System.EventHandler(this.btnNuevo_c_ButtonClick);
            this.btnNuevo_c.Click += new System.EventHandler(this.btn_NuevoTipoCatalogo_Click);
            // 
            // btnModificar_c
            // 
            this.btnModificar_c.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btnModificar_c.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar_c.Name = "btnModificar_c";
            this.btnModificar_c.Size = new System.Drawing.Size(90, 20);
            this.btnModificar_c.Text = "Modificar";
            this.btnModificar_c.Click += new System.EventHandler(this.btn_ModificarTipoCatalogo_Click);
            // 
            // frmCxc_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCxc_Catalogo";
            this.Text = "Catalogo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource cxcCatalogoInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnNuevo_c;
        private System.Windows.Forms.ToolStripSplitButton btnModificar_c;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControlCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.ListBox lstbox_TipoCatalogo;
    }
}