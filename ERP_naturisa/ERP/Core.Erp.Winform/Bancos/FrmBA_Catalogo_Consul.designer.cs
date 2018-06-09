namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Catalogo_Consul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_Catalogo_Consul));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlCatalogo = new DevExpress.XtraGrid.GridControl();
            this.baCatalogoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_NuevoTipoCatalogo = new System.Windows.Forms.ToolStripButton();
            this.btn_ModificarTipoCatalogo = new System.Windows.Forms.ToolStripButton();
            this.btn_ConsultarTipoCatalogo = new System.Windows.Forms.ToolStripButton();
            this.btn_AnularTipoCatalogo = new System.Windows.Forms.ToolStripButton();
            this.btn_SalirTipoCatalogo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lstbox_TipoCatalogo = new System.Windows.Forms.ListBox();
            this.baCatalogoTipoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoTipoinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 421);
            this.panel1.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 421);
            this.panel2.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel4.Controls.Add(this.gridControlCatalogo);
            this.panel4.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 421);
            this.panel4.TabIndex = 45;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 395);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(651, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // gridControlCatalogo
            // 
            this.gridControlCatalogo.DataSource = this.baCatalogoinfoBindingSource;
            this.gridControlCatalogo.Location = new System.Drawing.Point(0, 95);
            this.gridControlCatalogo.MainView = this.gridViewCatalogo;
            this.gridControlCatalogo.Name = "gridControlCatalogo";
            this.gridControlCatalogo.Size = new System.Drawing.Size(651, 300);
            this.gridControlCatalogo.TabIndex = 1;
            this.gridControlCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatalogo});
            // 
            // baCatalogoinfoBindingSource
            // 
            this.baCatalogoinfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_Catalogo_Info);
            // 
            // gridViewCatalogo
            // 
            this.gridViewCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCatalogo,
            this.colIdCatalogo,
            this.colca_orden,
            this.colca_descripcion,
            this.colca_estado});
            this.gridViewCatalogo.GridControl = this.gridControlCatalogo;
            this.gridViewCatalogo.Name = "gridViewCatalogo";
            this.gridViewCatalogo.OptionsBehavior.Editable = false;
            this.gridViewCatalogo.OptionsView.ShowGroupPanel = false;
            this.gridViewCatalogo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCatalogo_RowCellStyle);
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            this.colIdTipoCatalogo.Visible = true;
            this.colIdTipoCatalogo.VisibleIndex = 0;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 1;
            // 
            // colca_orden
            // 
            this.colca_orden.Caption = "Orden";
            this.colca_orden.FieldName = "ca_orden";
            this.colca_orden.Name = "colca_orden";
            this.colca_orden.Visible = true;
            this.colca_orden.VisibleIndex = 3;
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Descripción";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 2;
            // 
            // colca_estado
            // 
            this.colca_estado.Caption = "Estado";
            this.colca_estado.FieldName = "ca_estado";
            this.colca_estado.Name = "colca_estado";
            this.colca_estado.Visible = true;
            this.colca_estado.VisibleIndex = 4;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 3, 2, 11, 24, 51, 564);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 5, 2, 11, 24, 51, 564);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(651, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Controls.Add(this.lstbox_TipoCatalogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 421);
            this.panel3.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_NuevoTipoCatalogo,
            this.btn_ModificarTipoCatalogo,
            this.btn_ConsultarTipoCatalogo,
            this.btn_AnularTipoCatalogo,
            this.btn_SalirTipoCatalogo,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 396);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(226, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btn_NuevoTipoCatalogo
            // 
            this.btn_NuevoTipoCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevoTipoCatalogo.Image")));
            this.btn_NuevoTipoCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NuevoTipoCatalogo.Name = "btn_NuevoTipoCatalogo";
            this.btn_NuevoTipoCatalogo.Size = new System.Drawing.Size(62, 22);
            this.btn_NuevoTipoCatalogo.Text = "Nuevo";
            this.btn_NuevoTipoCatalogo.Click += new System.EventHandler(this.btn_NuevoTipoCatalogo_Click);
            // 
            // btn_ModificarTipoCatalogo
            // 
            this.btn_ModificarTipoCatalogo.Image = global::Core.Erp.Winform.Properties.Resources.FormEdit;
            this.btn_ModificarTipoCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ModificarTipoCatalogo.Name = "btn_ModificarTipoCatalogo";
            this.btn_ModificarTipoCatalogo.Size = new System.Drawing.Size(78, 22);
            this.btn_ModificarTipoCatalogo.Text = "Modificar";
            this.btn_ModificarTipoCatalogo.Click += new System.EventHandler(this.btn_ModificarTipoCatalogo_Click);
            // 
            // btn_ConsultarTipoCatalogo
            // 
            this.btn_ConsultarTipoCatalogo.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btn_ConsultarTipoCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ConsultarTipoCatalogo.Name = "btn_ConsultarTipoCatalogo";
            this.btn_ConsultarTipoCatalogo.Size = new System.Drawing.Size(78, 20);
            this.btn_ConsultarTipoCatalogo.Text = "Consultar";
            // 
            // btn_AnularTipoCatalogo
            // 
            this.btn_AnularTipoCatalogo.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.btn_AnularTipoCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AnularTipoCatalogo.Name = "btn_AnularTipoCatalogo";
            this.btn_AnularTipoCatalogo.Size = new System.Drawing.Size(62, 20);
            this.btn_AnularTipoCatalogo.Text = "Anular";
            // 
            // btn_SalirTipoCatalogo
            // 
            this.btn_SalirTipoCatalogo.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btn_SalirTipoCatalogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SalirTipoCatalogo.Name = "btn_SalirTipoCatalogo";
            this.btn_SalirTipoCatalogo.Size = new System.Drawing.Size(49, 20);
            this.btn_SalirTipoCatalogo.Text = "Salir";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(190, 15);
            this.toolStripLabel2.Text = "                                                             ";
            // 
            // lstbox_TipoCatalogo
            // 
            this.lstbox_TipoCatalogo.DataSource = this.baCatalogoTipoinfoBindingSource;
            this.lstbox_TipoCatalogo.DisplayMember = "tc_Descripcion";
            this.lstbox_TipoCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_TipoCatalogo.FormattingEnabled = true;
            this.lstbox_TipoCatalogo.Location = new System.Drawing.Point(0, 0);
            this.lstbox_TipoCatalogo.Name = "lstbox_TipoCatalogo";
            this.lstbox_TipoCatalogo.Size = new System.Drawing.Size(226, 421);
            this.lstbox_TipoCatalogo.TabIndex = 0;
            this.lstbox_TipoCatalogo.ValueMember = "IdTipoCatalogo";
            this.lstbox_TipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedIndexChanged);
            // 
            // baCatalogoTipoinfoBindingSource
            // 
            this.baCatalogoTipoinfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_CatalogoTipo_info);
            // 
            // FrmBA_Catalogo_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 421);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBA_Catalogo_Consul";
            this.Text = "Banco Catalogo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baCatalogoTipoinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatalogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstbox_TipoCatalogo;
        private System.Windows.Forms.BindingSource baCatalogoTipoinfoBindingSource;
        private System.Windows.Forms.BindingSource baCatalogoinfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btn_NuevoTipoCatalogo;
        private System.Windows.Forms.ToolStripButton btn_ModificarTipoCatalogo;
        private System.Windows.Forms.ToolStripButton btn_ConsultarTipoCatalogo;
        private System.Windows.Forms.ToolStripButton btn_AnularTipoCatalogo;
        private System.Windows.Forms.ToolStripButton btn_SalirTipoCatalogo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;

    }
}