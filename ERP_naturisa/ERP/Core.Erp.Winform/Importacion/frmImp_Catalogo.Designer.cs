namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_Catalogo
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
            this.lstbox_TipoCatalogo = new System.Windows.Forms.ListBox();
            this.gridCatalogo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCatalogoImport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Abrebiatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreIngles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.menuTipo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbox_TipoCatalogo
            // 
            this.lstbox_TipoCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_TipoCatalogo.FormattingEnabled = true;
            this.lstbox_TipoCatalogo.Location = new System.Drawing.Point(0, 0);
            this.lstbox_TipoCatalogo.Name = "lstbox_TipoCatalogo";
            this.lstbox_TipoCatalogo.Size = new System.Drawing.Size(249, 482);
            this.lstbox_TipoCatalogo.TabIndex = 1;
            this.lstbox_TipoCatalogo.Click += new System.EventHandler(this.lstbox_TipoCatalogo_Click);
            this.lstbox_TipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedIndexChanged);
            this.lstbox_TipoCatalogo.SelectedValueChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedValueChanged);
            this.lstbox_TipoCatalogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstbox_TipoCatalogo_MouseUp);
            // 
            // gridCatalogo
            // 
            this.gridCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCatalogo.Location = new System.Drawing.Point(0, 95);
            this.gridCatalogo.MainView = this.gridViewCatalogo;
            this.gridCatalogo.Name = "gridCatalogo";
            this.gridCatalogo.Size = new System.Drawing.Size(652, 387);
            this.gridCatalogo.TabIndex = 9;
            this.gridCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatalogo});
            // 
            // gridViewCatalogo
            // 
            this.gridViewCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCatalogoImport,
            this.Nombre,
            this.Estado,
            this.Abrebiatura,
            this.NombreIngles});
            this.gridViewCatalogo.GridControl = this.gridCatalogo;
            this.gridViewCatalogo.Name = "gridViewCatalogo";
            this.gridViewCatalogo.OptionsBehavior.Editable = false;
            this.gridViewCatalogo.OptionsBehavior.ReadOnly = true;
            this.gridViewCatalogo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCatalogo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCatalogo_RowClick);
            this.gridViewCatalogo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCatalogo_RowCellStyle);
            // 
            // IdCatalogoImport
            // 
            this.IdCatalogoImport.Caption = "Id Catalogo";
            this.IdCatalogoImport.FieldName = "IdCatalogoImport";
            this.IdCatalogoImport.Name = "IdCatalogoImport";
            this.IdCatalogoImport.Visible = true;
            this.IdCatalogoImport.VisibleIndex = 0;
            this.IdCatalogoImport.Width = 78;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 124;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 2;
            this.Estado.Width = 52;
            // 
            // Abrebiatura
            // 
            this.Abrebiatura.Caption = "Abrebiatura";
            this.Abrebiatura.FieldName = "Abrebiatura";
            this.Abrebiatura.Name = "Abrebiatura";
            this.Abrebiatura.Visible = true;
            this.Abrebiatura.VisibleIndex = 3;
            this.Abrebiatura.Width = 117;
            // 
            // NombreIngles
            // 
            this.NombreIngles.Caption = "NombreIngles";
            this.NombreIngles.FieldName = "NombreIngles";
            this.NombreIngles.Name = "NombreIngles";
            this.NombreIngles.Visible = true;
            this.NombreIngles.VisibleIndex = 4;
            this.NombreIngles.Width = 127;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 482);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.lstbox_TipoCatalogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(905, 482);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCatalogo);
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 482);
            this.panel2.TabIndex = 11;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 7, 28, 16, 55, 9, 770);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 9, 28, 16, 55, 9, 770);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(652, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 10;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // menuTipo
            // 
            this.menuTipo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuTipo.Name = "menuTipo";
            this.menuTipo.Size = new System.Drawing.Size(153, 70);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // frmImp_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 482);
            this.Controls.Add(this.panel1);
            this.Name = "frmImp_Catalogo";
            this.Text = "Importación Catalogo";
            this.Load += new System.EventHandler(this.frmImp_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuTipo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_TipoCatalogo;
        private DevExpress.XtraGrid.GridControl gridCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn IdCatalogoImport;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Abrebiatura;
        private DevExpress.XtraGrid.Columns.GridColumn NombreIngles;
        private System.Windows.Forms.ContextMenuStrip menuTipo;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}