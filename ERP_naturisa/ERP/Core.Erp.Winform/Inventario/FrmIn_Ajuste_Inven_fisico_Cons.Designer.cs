namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ajuste_Inven_fisico_Cons
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
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAjusteFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bo_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvAjustes_Cabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DescripcionIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumMovi_Ing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionEngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumMovi_Egr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.Estado.VisibleIndex = 10;
            this.Estado.Width = 53;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.DisplayFormat.FormatString = "d";
            this.Fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 3;
            this.Fecha.Width = 82;
            // 
            // IdAjusteFisico
            // 
            this.IdAjusteFisico.Caption = "#AJuste";
            this.IdAjusteFisico.FieldName = "IdAjusteFisico";
            this.IdAjusteFisico.Name = "IdAjusteFisico";
            this.IdAjusteFisico.OptionsColumn.AllowEdit = false;
            this.IdAjusteFisico.Visible = true;
            this.IdAjusteFisico.VisibleIndex = 2;
            this.IdAjusteFisico.Width = 48;
            // 
            // bo_descripcion
            // 
            this.bo_descripcion.Caption = "Bodega";
            this.bo_descripcion.FieldName = "bo_descripcion";
            this.bo_descripcion.Name = "bo_descripcion";
            this.bo_descripcion.OptionsColumn.AllowEdit = false;
            this.bo_descripcion.Visible = true;
            this.bo_descripcion.VisibleIndex = 1;
            this.bo_descripcion.Width = 52;
            // 
            // su_Descripcion
            // 
            this.su_Descripcion.Caption = "Sucursal";
            this.su_Descripcion.FieldName = "su_Descripcion";
            this.su_Descripcion.Name = "su_Descripcion";
            this.su_Descripcion.Visible = true;
            this.su_Descripcion.VisibleIndex = 0;
            this.su_Descripcion.Width = 53;
            // 
            // gvAjustes_Cabecera
            // 
            this.gvAjustes_Cabecera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.su_Descripcion,
            this.bo_descripcion,
            this.IdAjusteFisico,
            this.DescripcionIngreso,
            this.IdNumMovi_Ing,
            this.DescripcionEngreso,
            this.IdNumMovi_Egr,
            this.Fecha,
            this.Observacion,
            this.IdEstadoAprobacion,
            this.Estado});
            this.gvAjustes_Cabecera.GridControl = this.gridControl;
            this.gvAjustes_Cabecera.Name = "gvAjustes_Cabecera";
            this.gvAjustes_Cabecera.OptionsBehavior.Editable = false;
            this.gvAjustes_Cabecera.OptionsView.ShowAutoFilterRow = true;
            this.gvAjustes_Cabecera.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdAjusteFisico, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvAjustes_Cabecera.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAjustes_Cabecera_RowClick);
            this.gvAjustes_Cabecera.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvAjustes_Cabecera_RowCellStyle);
            // 
            // DescripcionIngreso
            // 
            this.DescripcionIngreso.Caption = "Tipo movimiento Ingreso";
            this.DescripcionIngreso.FieldName = "DescripcionIngreso";
            this.DescripcionIngreso.Name = "DescripcionIngreso";
            this.DescripcionIngreso.Visible = true;
            this.DescripcionIngreso.VisibleIndex = 4;
            this.DescripcionIngreso.Width = 113;
            // 
            // IdNumMovi_Ing
            // 
            this.IdNumMovi_Ing.Caption = "# Mov. Ingreso";
            this.IdNumMovi_Ing.FieldName = "IdNumMovi_Ing";
            this.IdNumMovi_Ing.Name = "IdNumMovi_Ing";
            this.IdNumMovi_Ing.Visible = true;
            this.IdNumMovi_Ing.VisibleIndex = 5;
            this.IdNumMovi_Ing.Width = 81;
            // 
            // DescripcionEngreso
            // 
            this.DescripcionEngreso.Caption = "Tipo movimiento Egreso";
            this.DescripcionEngreso.FieldName = "DescripcionEngreso";
            this.DescripcionEngreso.Name = "DescripcionEngreso";
            this.DescripcionEngreso.Visible = true;
            this.DescripcionEngreso.VisibleIndex = 6;
            this.DescripcionEngreso.Width = 115;
            // 
            // IdNumMovi_Egr
            // 
            this.IdNumMovi_Egr.Caption = "# Movi. Egreso";
            this.IdNumMovi_Egr.FieldName = "IdNumMovi_Egr";
            this.IdNumMovi_Egr.Name = "IdNumMovi_Egr";
            this.IdNumMovi_Egr.Visible = true;
            this.IdNumMovi_Egr.VisibleIndex = 7;
            this.IdNumMovi_Egr.Width = 92;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.OptionsColumn.AllowEdit = false;
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 8;
            this.Observacion.Width = 218;
            // 
            // IdEstadoAprobacion
            // 
            this.IdEstadoAprobacion.Caption = "Estado Aprobación";
            this.IdEstadoAprobacion.FieldName = "Nombre_Estado";
            this.IdEstadoAprobacion.Name = "IdEstadoAprobacion";
            this.IdEstadoAprobacion.Visible = true;
            this.IdEstadoAprobacion.VisibleIndex = 9;
            this.IdEstadoAprobacion.Width = 105;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gvAjustes_Cabecera;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1030, 241);
            this.gridControl.TabIndex = 15;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAjustes_Cabecera});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 153);
            this.panel1.TabIndex = 16;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 8, 22, 12, 3, 11, 489);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 10, 22, 12, 3, 11, 489);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1030, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 241);
            this.panel2.TabIndex = 17;
            // 
            // FrmIn_Ajuste_Inven_fisico_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmIn_Ajuste_Inven_fisico_Cons";
            this.Text = "Consulta Ajuste Fisico";
            this.Load += new System.EventHandler(this.frmIn_AjusteFisico_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAjustes_Cabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdAjusteFisico;
        private DevExpress.XtraGrid.Columns.GridColumn bo_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn su_Descripcion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAjustes_Cabecera;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionEngreso;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumMovi_Ing;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumMovi_Egr;
        private DevExpress.XtraGrid.Columns.GridColumn IdEstadoAprobacion;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}