namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Secuencia_Documento_Talonario_Consulta
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
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 94);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(766, 185);
            this.gridConsulta.TabIndex = 6;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdEmpresa,
            this.IdSucursal,
            this.IdBodega,
            this.CodDocumentoTipo,
            this.Serie1,
            this.Serie2,
            this.FechaCaducidad,
            this.NAutorizacion,
            this.DocInicial,
            this.DocFinal,
            this.DocActual,
            this.Estado,
            this.Sucursal,
            this.Bodega,
            this.Secuencia});
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Bodega, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Sucursal, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.CodDocumentoTipo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.FechaCaducidad, DevExpress.Data.ColumnSortOrder.Descending)});
            //this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewConsulta_RowClick);
            //this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsulta_RowCellStyle);
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "IdEmpresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            // 
            // IdBodega
            // 
            this.IdBodega.Caption = "IdBodega";
            this.IdBodega.FieldName = "IdBodega";
            this.IdBodega.Name = "IdBodega";
            // 
            // CodDocumentoTipo
            // 
            this.CodDocumentoTipo.Caption = "Tipo Doc.";
            this.CodDocumentoTipo.FieldName = "CodDocumentoTipo";
            this.CodDocumentoTipo.Name = "CodDocumentoTipo";
            this.CodDocumentoTipo.Visible = true;
            this.CodDocumentoTipo.VisibleIndex = 0;
            this.CodDocumentoTipo.Width = 62;
            // 
            // Serie1
            // 
            this.Serie1.Caption = "Serie1";
            this.Serie1.FieldName = "Serie1";
            this.Serie1.Name = "Serie1";
            this.Serie1.Visible = true;
            this.Serie1.VisibleIndex = 3;
            this.Serie1.Width = 62;
            // 
            // Serie2
            // 
            this.Serie2.Caption = "Serie2";
            this.Serie2.FieldName = "Serie2";
            this.Serie2.Name = "Serie2";
            this.Serie2.Visible = true;
            this.Serie2.VisibleIndex = 4;
            this.Serie2.Width = 62;
            // 
            // FechaCaducidad
            // 
            this.FechaCaducidad.Caption = "Fecha Caducidad";
            this.FechaCaducidad.FieldName = "FechaCaducidad";
            this.FechaCaducidad.Name = "FechaCaducidad";
            this.FechaCaducidad.Visible = true;
            this.FechaCaducidad.VisibleIndex = 5;
            this.FechaCaducidad.Width = 62;
            // 
            // NAutorizacion
            // 
            this.NAutorizacion.Caption = "# Autorizacion";
            this.NAutorizacion.FieldName = "NAutorizacion";
            this.NAutorizacion.Name = "NAutorizacion";
            this.NAutorizacion.Visible = true;
            this.NAutorizacion.VisibleIndex = 6;
            this.NAutorizacion.Width = 62;
            // 
            // DocInicial
            // 
            this.DocInicial.Caption = "DocInicial";
            this.DocInicial.FieldName = "DocInicial";
            this.DocInicial.Name = "DocInicial";
            this.DocInicial.Visible = true;
            this.DocInicial.VisibleIndex = 7;
            this.DocInicial.Width = 62;
            // 
            // DocFinal
            // 
            this.DocFinal.Caption = "DocFinal";
            this.DocFinal.FieldName = "DocFinal";
            this.DocFinal.Name = "DocFinal";
            this.DocFinal.Visible = true;
            this.DocFinal.VisibleIndex = 8;
            this.DocFinal.Width = 62;
            // 
            // DocActual
            // 
            this.DocActual.Caption = "DocActual";
            this.DocActual.FieldName = "DocActual";
            this.DocActual.Name = "DocActual";
            this.DocActual.Visible = true;
            this.DocActual.VisibleIndex = 9;
            this.DocActual.Width = 87;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            this.Estado.Width = 45;
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            this.Sucursal.Width = 62;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega / Punto Venta";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 2;
            this.Bodega.Width = 62;
            // 
            // Secuencia
            // 
            this.Secuencia.Caption = "Secuencia";
            this.Secuencia.FieldName = "Secuencia";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.Visible = true;
            this.Secuencia.VisibleIndex = 11;
            this.Secuencia.Width = 58;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.consultarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 82);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 6);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 6);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 94);
            this.panel1.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 12;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 13, 36, 42, 935);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 13, 36, 42, 935);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(766, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // frmFa_Secuencia_Documento_Talonario_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 301);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Secuencia_Documento_Talonario_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo y Secuencia por Documento Consulta";
            this.Load += new System.EventHandler(this.frmFA_Secuencia_Documento_Talonario_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn IdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn CodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn Serie1;
        private DevExpress.XtraGrid.Columns.GridColumn Serie2;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn NAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn DocInicial;
        private DevExpress.XtraGrid.Columns.GridColumn DocFinal;
        private DevExpress.XtraGrid.Columns.GridColumn DocActual;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Secuencia;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}