namespace Core.Erp.Winform.General
{
    partial class FrmGe_Secuencia_Documento_Talonario_Consulta
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
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colElectronica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Establecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PuntoEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 162);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Check});
            this.gridConsulta.Size = new System.Drawing.Size(863, 250);
            this.gridConsulta.TabIndex = 6;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdEmpresa,
            this.Empresa,
            this.IdSucursal,
            this.Sucursal,
            this.CodDocumentoTipo,
            this.colElectronica,
            this.Establecimiento,
            this.PuntoEmision,
            this.NumDocumento,
            this.FechaCaducidad,
            this.NumAutorizacion,
            this.Usado,
            this.Estado});
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewConsulta_RowClick);
            this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsulta_RowCellStyle);
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "IdEmpresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // Empresa
            // 
            this.Empresa.Caption = "Empresa";
            this.Empresa.FieldName = "NombreEmpresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Visible = true;
            this.Empresa.VisibleIndex = 0;
            // 
            // IdSucursal
            // 
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "NombreSucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            // 
            // CodDocumentoTipo
            // 
            this.CodDocumentoTipo.Caption = "CodDocumentoTipo";
            this.CodDocumentoTipo.FieldName = "CodDocumentoTipo";
            this.CodDocumentoTipo.Name = "CodDocumentoTipo";
            this.CodDocumentoTipo.Visible = true;
            this.CodDocumentoTipo.VisibleIndex = 2;
            // 
            // colElectronica
            // 
            this.colElectronica.Caption = "Electrónica";
            this.colElectronica.ColumnEdit = this.Check;
            this.colElectronica.FieldName = "es_Documento_electronico";
            this.colElectronica.Name = "colElectronica";
            this.colElectronica.Visible = true;
            this.colElectronica.VisibleIndex = 5;
            // 
            // Check
            // 
            this.Check.AutoHeight = false;
            this.Check.Name = "Check";
            // 
            // Establecimiento
            // 
            this.Establecimiento.Caption = "Establecimiento";
            this.Establecimiento.FieldName = "Establecimiento";
            this.Establecimiento.Name = "Establecimiento";
            this.Establecimiento.Visible = true;
            this.Establecimiento.VisibleIndex = 3;
            // 
            // PuntoEmision
            // 
            this.PuntoEmision.Caption = "Punto Emision";
            this.PuntoEmision.FieldName = "PuntoEmision";
            this.PuntoEmision.Name = "PuntoEmision";
            this.PuntoEmision.Visible = true;
            this.PuntoEmision.VisibleIndex = 4;
            // 
            // NumDocumento
            // 
            this.NumDocumento.Caption = "Numero Documento";
            this.NumDocumento.FieldName = "NumDocumento";
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.Visible = true;
            this.NumDocumento.VisibleIndex = 6;
            // 
            // FechaCaducidad
            // 
            this.FechaCaducidad.Caption = "Fecha Caducidad";
            this.FechaCaducidad.FieldName = "FechaCaducidad";
            this.FechaCaducidad.Name = "FechaCaducidad";
            this.FechaCaducidad.Visible = true;
            this.FechaCaducidad.VisibleIndex = 7;
            // 
            // NumAutorizacion
            // 
            this.NumAutorizacion.Caption = "Numero Autorizacion";
            this.NumAutorizacion.FieldName = "NumAutorizacion";
            this.NumAutorizacion.Name = "NumAutorizacion";
            this.NumAutorizacion.Visible = true;
            this.NumAutorizacion.VisibleIndex = 8;
            // 
            // Usado
            // 
            this.Usado.Caption = "Usado";
            this.Usado.FieldName = "Usado";
            this.Usado.Name = "Usado";
            this.Usado.Visible = true;
            this.Usado.VisibleIndex = 9;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
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
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 9, 24, 10, 0, 43, 983);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 11, 24, 10, 0, 43, 983);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(863, 162);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmGe_Secuencia_Documento_Talonario_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 434);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmGe_Secuencia_Documento_Talonario_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo y Secuencia por Documento Consulta";
            this.Load += new System.EventHandler(this.FrmGe_Secuencia_Documento_Talonario_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn CodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn Establecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn PuntoEmision;
        private DevExpress.XtraGrid.Columns.GridColumn NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCaducidad;
        public DevExpress.XtraGrid.Columns.GridColumn Usado;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn NumAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colElectronica;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit Check;
    }
}