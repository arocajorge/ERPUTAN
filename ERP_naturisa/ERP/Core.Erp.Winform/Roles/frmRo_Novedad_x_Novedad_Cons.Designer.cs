namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Novedad_x_Novedad_Cons
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControlCons = new DevExpress.XtraGrid.GridControl();
            this.vwroempleadopornovedadescabeceraInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.dgvListado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfoIngEgre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwroempleadopornovedadescabeceraInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 23, 9, 32, 14, 380);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 23, 9, 32, 14, 380);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(868, 141);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnfiltro_fecha_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnfiltro_fecha_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // gridControlCons
            // 
            this.gridControlCons.DataSource = this.vwroempleadopornovedadescabeceraInfoBindingSource;
            this.gridControlCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCons.Location = new System.Drawing.Point(0, 0);
            this.gridControlCons.MainView = this.dgvListado;
            this.gridControlCons.Name = "gridControlCons";
            this.gridControlCons.Size = new System.Drawing.Size(868, 374);
            this.gridControlCons.TabIndex = 1;
            this.gridControlCons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvListado});
            this.gridControlCons.Click += new System.EventHandler(this.gridControlCons_Click);
            // 
            // vwroempleadopornovedadescabeceraInfoBindingSource
            // 
            this.vwroempleadopornovedadescabeceraInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.vwro_empleado_por_novedades_cabecera_Info);
            // 
            // dgvListado
            // 
            this.dgvListado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTransaccion,
            this.colIdRubro,
            this.colDescripcionRubro,
            this.colTipoNomina,
            this.colDescripcionNomina,
            this.colTipoLiquidacion,
            this.colDescripcionProceso,
            this.colObservacion,
            this.colEstado,
            this.colFecha});
            this.dgvListado.GridControl = this.gridControlCons;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.OptionsBehavior.Editable = false;
            this.dgvListado.OptionsBehavior.ReadOnly = true;
            this.dgvListado.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgvListado_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.Caption = "No.";
            this.colIdTransaccion.FieldName = "IdTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            this.colIdTransaccion.Visible = true;
            this.colIdTransaccion.VisibleIndex = 0;
            this.colIdTransaccion.Width = 58;
            // 
            // colIdRubro
            // 
            this.colIdRubro.FieldName = "IdRubro";
            this.colIdRubro.Name = "colIdRubro";
            // 
            // colDescripcionRubro
            // 
            this.colDescripcionRubro.Caption = "Rubro";
            this.colDescripcionRubro.FieldName = "DescripcionRubro";
            this.colDescripcionRubro.Name = "colDescripcionRubro";
            this.colDescripcionRubro.Visible = true;
            this.colDescripcionRubro.VisibleIndex = 1;
            this.colDescripcionRubro.Width = 165;
            // 
            // colTipoNomina
            // 
            this.colTipoNomina.FieldName = "TipoNomina";
            this.colTipoNomina.Name = "colTipoNomina";
            // 
            // colDescripcionNomina
            // 
            this.colDescripcionNomina.Caption = "Nómina";
            this.colDescripcionNomina.FieldName = "DescripcionNomina";
            this.colDescripcionNomina.Name = "colDescripcionNomina";
            this.colDescripcionNomina.Visible = true;
            this.colDescripcionNomina.VisibleIndex = 2;
            this.colDescripcionNomina.Width = 124;
            // 
            // colTipoLiquidacion
            // 
            this.colTipoLiquidacion.FieldName = "TipoLiquidacion";
            this.colTipoLiquidacion.Name = "colTipoLiquidacion";
            // 
            // colDescripcionProceso
            // 
            this.colDescripcionProceso.Caption = "Proceso";
            this.colDescripcionProceso.FieldName = "DescripcionProceso";
            this.colDescripcionProceso.Name = "colDescripcionProceso";
            this.colDescripcionProceso.Visible = true;
            this.colDescripcionProceso.VisibleIndex = 3;
            this.colDescripcionProceso.Width = 124;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 234;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            this.colEstado.Width = 58;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 6;
            this.colFecha.Width = 87;
            // 
            // colInfoIngEgre
            // 
            this.colInfoIngEgre.FieldName = "InfoIngEgre";
            this.colInfoIngEgre.Name = "colInfoIngEgre";
            this.colInfoIngEgre.Visible = true;
            this.colInfoIngEgre.VisibleIndex = 4;
            // 
            // colEstadoCobro
            // 
            this.colEstadoCobro.FieldName = "EstadoCobro";
            this.colEstadoCobro.Name = "colEstadoCobro";
            this.colEstadoCobro.Visible = true;
            this.colEstadoCobro.VisibleIndex = 8;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 9;
            // 
            // colIco1
            // 
            this.colIco1.FieldName = "Ico1";
            this.colIco1.Name = "colIco1";
            this.colIco1.Visible = true;
            this.colIco1.VisibleIndex = 10;
            // 
            // colIco2
            // 
            this.colIco2.FieldName = "Ico2";
            this.colIco2.Name = "colIco2";
            this.colIco2.Visible = true;
            this.colIco2.VisibleIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlCons);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(868, 529);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 4;
            // 
            // frmRo_Novedad_x_Novedad_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Novedad_x_Novedad_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta - Novedades por Empleados";
            this.Load += new System.EventHandler(this.frmRo_Novedad_x_Novedad_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwroempleadopornovedadescabeceraInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    //    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoIngEgre;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIco1;
        private DevExpress.XtraGrid.Columns.GridColumn colIco2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource vwroempleadopornovedadescabeceraInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlCons;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvListado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionRubro;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionProceso;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}