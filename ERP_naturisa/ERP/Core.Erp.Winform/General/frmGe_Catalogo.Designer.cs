namespace Core.Erp.Winform.General
{
    partial class FrmGe_Catalogo
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
            this.listBoxTipo = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCatalogoTipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewcatalogoTipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoTipoInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewcatalogoTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTipo
            // 
            this.listBoxTipo.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxTipo.DataSource = this.tbCatalogoTipoInfoBindingSource;
            this.listBoxTipo.DisplayMember = "tc_Descripcion";
            this.listBoxTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTipo.FormattingEnabled = true;
            this.listBoxTipo.Location = new System.Drawing.Point(0, 0);
            this.listBoxTipo.Name = "listBoxTipo";
            this.listBoxTipo.Size = new System.Drawing.Size(154, 265);
            this.listBoxTipo.TabIndex = 0;
            this.listBoxTipo.ValueMember = "IdTipoCatalogo";
            this.listBoxTipo.SelectedIndexChanged += new System.EventHandler(this.listBoxTipo_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.anularToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 92);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.anularToolStripMenuItem.Text = "Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // tbCatalogoTipoInfoBindingSource
            // 
            this.tbCatalogoTipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_CatalogoTipo_Info);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxTipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 265);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 265);
            this.panel2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbCatalogoInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 89);
            this.gridControl1.MainView = this.gridViewcatalogoTipo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(489, 176);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewcatalogoTipo});
            // 
            // tbCatalogoInfoBindingSource
            // 
            this.tbCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Catalogo_Info);
            // 
            // gridViewcatalogoTipo
            // 
            this.gridViewcatalogoTipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colCodCatalogo,
            this.colca_descripcion,
            this.colca_estado,
            this.colIdTipoCatalogo,
            this.colca_orden});
            this.gridViewcatalogoTipo.GridControl = this.gridControl1;
            this.gridViewcatalogoTipo.Name = "gridViewcatalogoTipo";
            this.gridViewcatalogoTipo.OptionsBehavior.Editable = false;
            this.gridViewcatalogoTipo.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.Caption = "Codigo";
            this.colCodCatalogo.FieldName = "CodCatalogo";
            this.colCodCatalogo.Name = "colCodCatalogo";
            this.colCodCatalogo.Visible = true;
            this.colCodCatalogo.VisibleIndex = 0;
            this.colCodCatalogo.Width = 91;
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Descripción";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 1;
            this.colca_descripcion.Width = 314;
            // 
            // colca_estado
            // 
            this.colca_estado.Caption = "Estado";
            this.colca_estado.FieldName = "ca_estado";
            this.colca_estado.Name = "colca_estado";
            this.colca_estado.Visible = true;
            this.colca_estado.VisibleIndex = 2;
            this.colca_estado.Width = 66;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colca_orden
            // 
            this.colca_orden.FieldName = "ca_orden";
            this.colca_orden.Name = "colca_orden";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 30, 15, 20, 40, 157);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 30, 15, 20, 40, 157);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(489, 89);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 2;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // FrmGe_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 287);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGe_Catalogo";
            this.Text = "frmGe_Catalogo";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoTipoInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewcatalogoTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewcatalogoTipo;
        private System.Windows.Forms.BindingSource tbCatalogoTipoInfoBindingSource;
        private System.Windows.Forms.BindingSource tbCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}