namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Categoria_Cons
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
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            this.Estado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeListCategorias = new DevExpress.XtraTreeList.TreeList();
            this.ca_Categoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Posicion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ca_indexIcono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoria = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdCategoriaPadre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStripMant = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategorias)).BeginInit();
            this.contextMenuStripMant.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 50;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeListCategorias
            // 
            this.treeListCategorias.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ca_Categoria,
            this.Posicion,
            this.ca_indexIcono,
            this.Estado,
            this.IdCategoria,
            this.IdCategoriaPadre});
            this.treeListCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition3.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.Estado;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[Estado] == \'I\'";
            this.treeListCategorias.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition3});
            this.treeListCategorias.KeyFieldName = "IdCategoria";
            this.treeListCategorias.Location = new System.Drawing.Point(0, 94);
            this.treeListCategorias.Name = "treeListCategorias";
            this.treeListCategorias.OptionsPrint.UsePrintStyles = true;
            this.treeListCategorias.ParentFieldName = "IdCategoriaPadre";
            this.treeListCategorias.Size = new System.Drawing.Size(705, 319);
            this.treeListCategorias.TabIndex = 0;
            this.treeListCategorias.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListCategorias_FocusedNodeChanged);
            this.treeListCategorias.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeListCategorias_MouseUp);
            this.treeListCategorias.StyleChanged += new System.EventHandler(this.treeListCategorias_StyleChanged);
            // 
            // ca_Categoria
            // 
            this.ca_Categoria.Caption = "Categoria";
            this.ca_Categoria.FieldName = "ca_Categoria";
            this.ca_Categoria.MinWidth = 32;
            this.ca_Categoria.Name = "ca_Categoria";
            this.ca_Categoria.OptionsColumn.AllowEdit = false;
            this.ca_Categoria.Visible = true;
            this.ca_Categoria.VisibleIndex = 0;
            this.ca_Categoria.Width = 432;
            // 
            // Posicion
            // 
            this.Posicion.Caption = "Posicion";
            this.Posicion.FieldName = "ca_Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.OptionsColumn.AllowEdit = false;
            this.Posicion.Visible = true;
            this.Posicion.VisibleIndex = 1;
            this.Posicion.Width = 60;
            // 
            // ca_indexIcono
            // 
            this.ca_indexIcono.Caption = "IndexIcono";
            this.ca_indexIcono.FieldName = "ca_indexIcono";
            this.ca_indexIcono.Name = "ca_indexIcono";
            this.ca_indexIcono.OptionsColumn.AllowEdit = false;
            this.ca_indexIcono.Visible = true;
            this.ca_indexIcono.VisibleIndex = 2;
            this.ca_indexIcono.Width = 57;
            // 
            // IdCategoria
            // 
            this.IdCategoria.Caption = "IdCategoria";
            this.IdCategoria.FieldName = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.OptionsColumn.AllowEdit = false;
            this.IdCategoria.Visible = true;
            this.IdCategoria.VisibleIndex = 4;
            this.IdCategoria.Width = 88;
            // 
            // IdCategoriaPadre
            // 
            this.IdCategoriaPadre.Caption = "IdCategoriaPadre";
            this.IdCategoriaPadre.FieldName = "IdCategoriaPadre";
            this.IdCategoriaPadre.Name = "IdCategoriaPadre";
            this.IdCategoriaPadre.OptionsColumn.AllowEdit = false;
            // 
            // contextMenuStripMant
            // 
            this.contextMenuStripMant.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.contextMenuStripMant.Name = "contextMenuStripMant";
            this.contextMenuStripMant.Size = new System.Drawing.Size(126, 48);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 94);
            this.panel2.TabIndex = 5;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 7, 1, 11, 20, 22, 860);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 9, 1, 11, 20, 22, 860);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(705, 94);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // FrmIn_Categoria_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.treeListCategorias);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmIn_Categoria_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Categorias";
            this.Load += new System.EventHandler(this.frmIn_CategoriaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategorias)).EndInit();
            this.contextMenuStripMant.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraTreeList.TreeList treeListCategorias;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMant;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        
        private DevExpress.XtraTreeList.Columns.TreeListColumn ca_Categoria;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Posicion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ca_indexIcono;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoria;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdCategoriaPadre;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}