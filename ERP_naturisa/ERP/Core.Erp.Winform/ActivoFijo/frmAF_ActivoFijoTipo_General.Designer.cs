namespace Core.Erp.Winform.ActivoFijo
{
    partial class frmAF_ActivoFijoTipo_General
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.dgActivoFijo = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivoFijo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdActijoFijoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Porcentaje_depre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_anio_depreciacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 11, 20, 11, 40, 28, 446);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 1, 20, 11, 40, 28, 446);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1030, 176);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // dgActivoFijo
            // 
            this.dgActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.dgActivoFijo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgActivoFijo.Location = new System.Drawing.Point(0, 176);
            this.dgActivoFijo.MainView = this.gridViewActivoFijo;
            this.dgActivoFijo.Name = "dgActivoFijo";
            this.dgActivoFijo.Size = new System.Drawing.Size(1030, 253);
            this.dgActivoFijo.TabIndex = 2;
            this.dgActivoFijo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivoFijo});
            // 
            // gridViewActivoFijo
            // 
            this.gridViewActivoFijo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colIdActijoFijoTipo,
            this.colCodActivoFijo,
            this.colAf_Descripcion,
            this.colAf_Porcentaje_depre,
            this.colAf_anio_depreciacion});
            this.gridViewActivoFijo.GridControl = this.dgActivoFijo;
            this.gridViewActivoFijo.Name = "gridViewActivoFijo";
            this.gridViewActivoFijo.OptionsBehavior.Editable = false;
            this.gridViewActivoFijo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewActivoFijo.OptionsView.ShowGroupPanel = false;
            this.gridViewActivoFijo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewActivoFijo_RowClick);
            this.gridViewActivoFijo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewActivoFijo_RowCellStyle);
            this.gridViewActivoFijo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewActivoFijo_FocusedRowChanged);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 102;
            // 
            // colIdActijoFijoTipo
            // 
            this.colIdActijoFijoTipo.Caption = "ID";
            this.colIdActijoFijoTipo.FieldName = "IdActivoFijoTipo";
            this.colIdActijoFijoTipo.Name = "colIdActijoFijoTipo";
            this.colIdActijoFijoTipo.Visible = true;
            this.colIdActijoFijoTipo.VisibleIndex = 0;
            this.colIdActijoFijoTipo.Width = 62;
            // 
            // colCodActivoFijo
            // 
            this.colCodActivoFijo.Caption = "Código";
            this.colCodActivoFijo.FieldName = "CodActivoFijo";
            this.colCodActivoFijo.Name = "colCodActivoFijo";
            this.colCodActivoFijo.Visible = true;
            this.colCodActivoFijo.VisibleIndex = 1;
            this.colCodActivoFijo.Width = 170;
            // 
            // colAf_Descripcion
            // 
            this.colAf_Descripcion.Caption = "Descripcion";
            this.colAf_Descripcion.FieldName = "Af_Descripcion";
            this.colAf_Descripcion.Name = "colAf_Descripcion";
            this.colAf_Descripcion.Visible = true;
            this.colAf_Descripcion.VisibleIndex = 2;
            this.colAf_Descripcion.Width = 149;
            // 
            // colAf_Porcentaje_depre
            // 
            this.colAf_Porcentaje_depre.Caption = "% Depreciación";
            this.colAf_Porcentaje_depre.FieldName = "Af_Porcentaje_depre";
            this.colAf_Porcentaje_depre.Name = "colAf_Porcentaje_depre";
            this.colAf_Porcentaje_depre.Visible = true;
            this.colAf_Porcentaje_depre.VisibleIndex = 3;
            this.colAf_Porcentaje_depre.Width = 143;
            // 
            // colAf_anio_depreciacion
            // 
            this.colAf_anio_depreciacion.Caption = "Año";
            this.colAf_anio_depreciacion.FieldName = "Af_anio_depreciacion";
            this.colAf_anio_depreciacion.Name = "colAf_anio_depreciacion";
            this.colAf_anio_depreciacion.Visible = true;
            this.colAf_anio_depreciacion.VisibleIndex = 4;
            this.colAf_anio_depreciacion.Width = 118;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmAF_ActivoFijoTipo_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 451);
            this.Controls.Add(this.dgActivoFijo);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmAF_ActivoFijoTipo_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Tipo Activo Fijo";
            this.Load += new System.EventHandler(this.frmAF_ActivoFijoTipo_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl dgActivoFijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActijoFijoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Porcentaje_depre;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_anio_depreciacion;
    }
}