namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Empleado_Novedad_Anulacion_Masiva
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel_Sup = new System.Windows.Forms.Panel();
            this.cmbNovedades = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCalendario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecha_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colru_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Detalle = new System.Windows.Forms.Panel();
            this.grdListadoNovedades = new DevExpress.XtraGrid.GridControl();
            this.gridViewListadoNovedades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNovedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomPerComp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubroDescp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfoNovedadDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfoNovedadDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_Sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNovedades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoNovedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListadoNovedades)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(920, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel_Sup
            // 
            this.panel_Sup.Controls.Add(this.cmbNovedades);
            this.panel_Sup.Controls.Add(this.label2);
            this.panel_Sup.Controls.Add(this.label1);
            this.panel_Sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Sup.Location = new System.Drawing.Point(0, 29);
            this.panel_Sup.Name = "panel_Sup";
            this.panel_Sup.Size = new System.Drawing.Size(920, 63);
            this.panel_Sup.TabIndex = 1;
            // 
            // cmbNovedades
            // 
            this.cmbNovedades.EditValue = "";
            this.cmbNovedades.Location = new System.Drawing.Point(256, 37);
            this.cmbNovedades.Name = "cmbNovedades";
            this.cmbNovedades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNovedades.Properties.DisplayMember = "ru_descripcion";
            this.cmbNovedades.Properties.ValueMember = "IdCalendario";
            this.cmbNovedades.Properties.View = this.gridView2;
            this.cmbNovedades.Size = new System.Drawing.Size(509, 20);
            this.cmbNovedades.TabIndex = 64;
            this.cmbNovedades.EditValueChanged += new System.EventHandler(this.cmbNovedades_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCalendario,
            this.ColFecha_,
            this.Colru_descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdCalendario
            // 
            this.ColIdCalendario.Caption = "Id Calendario";
            this.ColIdCalendario.FieldName = "IdCalendario";
            this.ColIdCalendario.Name = "ColIdCalendario";
            this.ColIdCalendario.Visible = true;
            this.ColIdCalendario.VisibleIndex = 0;
            this.ColIdCalendario.Width = 167;
            // 
            // ColFecha_
            // 
            this.ColFecha_.Caption = "Fecha Carga";
            this.ColFecha_.FieldName = "Fecha";
            this.ColFecha_.Name = "ColFecha_";
            this.ColFecha_.Visible = true;
            this.ColFecha_.VisibleIndex = 2;
            this.ColFecha_.Width = 185;
            // 
            // Colru_descripcion
            // 
            this.Colru_descripcion.Caption = "Rubro";
            this.Colru_descripcion.FieldName = "ru_descripcion";
            this.Colru_descripcion.Name = "Colru_descripcion";
            this.Colru_descripcion.Visible = true;
            this.Colru_descripcion.VisibleIndex = 1;
            this.Colru_descripcion.Width = 902;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(402, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciones el Registro que Desea Anular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ANULACION DE NOVEDADES DE FORMA MASIVA";
            // 
            // panel_Detalle
            // 
            this.panel_Detalle.Controls.Add(this.grdListadoNovedades);
            this.panel_Detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Detalle.Location = new System.Drawing.Point(0, 92);
            this.panel_Detalle.Name = "panel_Detalle";
            this.panel_Detalle.Size = new System.Drawing.Size(920, 499);
            this.panel_Detalle.TabIndex = 2;
            // 
            // grdListadoNovedades
            // 
            this.grdListadoNovedades.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grdListadoNovedades.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdListadoNovedades.Location = new System.Drawing.Point(0, 0);
            this.grdListadoNovedades.MainView = this.gridViewListadoNovedades;
            this.grdListadoNovedades.Name = "grdListadoNovedades";
            this.grdListadoNovedades.Size = new System.Drawing.Size(920, 499);
            this.grdListadoNovedades.TabIndex = 11;
            this.grdListadoNovedades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListadoNovedades});
            // 
            // gridViewListadoNovedades
            // 
            this.gridViewListadoNovedades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colIdNovedad,
            this.colNomPerComp,
            this.colFecha,
            this.colRubroDescp,
            this.colEstadoCobro,
            this.colTotalValor,
            this.colEstado,
            this.colInfoNovedadDet,
            this.colInfoNovedadDet1,
            this.ColApellidos,
            this.ColApellido});
            this.gridViewListadoNovedades.GridControl = this.grdListadoNovedades;
            this.gridViewListadoNovedades.Name = "gridViewListadoNovedades";
            this.gridViewListadoNovedades.OptionsBehavior.Editable = false;
            this.gridViewListadoNovedades.OptionsBehavior.ReadOnly = true;
            this.gridViewListadoNovedades.OptionsView.ShowAutoFilterRow = true;
            this.gridViewListadoNovedades.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColApellidos, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 73;
            // 
            // colIdNovedad
            // 
            this.colIdNovedad.Caption = "Número Novedad";
            this.colIdNovedad.FieldName = "IdNovedad";
            this.colIdNovedad.Name = "colIdNovedad";
            this.colIdNovedad.OptionsColumn.AllowEdit = false;
            this.colIdNovedad.Visible = true;
            this.colIdNovedad.VisibleIndex = 1;
            this.colIdNovedad.Width = 92;
            // 
            // colNomPerComp
            // 
            this.colNomPerComp.Caption = "Nombre Completo";
            this.colNomPerComp.FieldName = "NomPerComp";
            this.colNomPerComp.Name = "colNomPerComp";
            this.colNomPerComp.OptionsColumn.AllowEdit = false;
            this.colNomPerComp.Width = 252;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 82;
            // 
            // colRubroDescp
            // 
            this.colRubroDescp.Caption = "Rubro";
            this.colRubroDescp.FieldName = "RubroDescp";
            this.colRubroDescp.Name = "colRubroDescp";
            this.colRubroDescp.OptionsColumn.AllowEdit = false;
            this.colRubroDescp.Visible = true;
            this.colRubroDescp.VisibleIndex = 5;
            this.colRubroDescp.Width = 250;
            // 
            // colEstadoCobro
            // 
            this.colEstadoCobro.Caption = "Estado Cobro";
            this.colEstadoCobro.FieldName = "EstadoCobro";
            this.colEstadoCobro.Name = "colEstadoCobro";
            this.colEstadoCobro.Visible = true;
            this.colEstadoCobro.VisibleIndex = 8;
            // 
            // colTotalValor
            // 
            this.colTotalValor.Caption = "Valor Total";
            this.colTotalValor.FieldName = "TotalValor";
            this.colTotalValor.Name = "colTotalValor";
            this.colTotalValor.OptionsColumn.AllowEdit = false;
            this.colTotalValor.Width = 71;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "InfoNovedadDet.Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 43;
            // 
            // colInfoNovedadDet
            // 
            this.colInfoNovedadDet.Caption = "Fecha de Pago";
            this.colInfoNovedadDet.FieldName = "InfoNovedadDet.FechaPago";
            this.colInfoNovedadDet.Name = "colInfoNovedadDet";
            this.colInfoNovedadDet.OptionsColumn.AllowEdit = false;
            this.colInfoNovedadDet.Visible = true;
            this.colInfoNovedadDet.VisibleIndex = 6;
            this.colInfoNovedadDet.Width = 90;
            // 
            // colInfoNovedadDet1
            // 
            this.colInfoNovedadDet1.Caption = "Valor";
            this.colInfoNovedadDet1.FieldName = "InfoNovedadDet.Valor";
            this.colInfoNovedadDet1.Name = "colInfoNovedadDet1";
            this.colInfoNovedadDet1.OptionsColumn.AllowEdit = false;
            this.colInfoNovedadDet1.Visible = true;
            this.colInfoNovedadDet1.VisibleIndex = 7;
            this.colInfoNovedadDet1.Width = 38;
            // 
            // ColApellidos
            // 
            this.ColApellidos.Caption = "Apellidos";
            this.ColApellidos.FieldName = "InfoPersona.pe_apellido";
            this.ColApellidos.Name = "ColApellidos";
            this.ColApellidos.OptionsColumn.AllowEdit = false;
            this.ColApellidos.Visible = true;
            this.ColApellidos.VisibleIndex = 2;
            // 
            // ColApellido
            // 
            this.ColApellido.Caption = "Nombres";
            this.ColApellido.FieldName = "InfoPersona.pe_nombre";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.OptionsColumn.AllowEdit = false;
            this.ColApellido.Visible = true;
            this.ColApellido.VisibleIndex = 3;
            // 
            // frmRo_Empleado_Novedad_Anulacion_Masiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 591);
            this.Controls.Add(this.panel_Detalle);
            this.Controls.Add(this.panel_Sup);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Empleado_Novedad_Anulacion_Masiva";
            this.Text = "ANULACION MASIVA DE NOVEDAD";
            this.Load += new System.EventHandler(this.frmRo_Empleado_Novedad_Anulacion_Masiva_Load);
            this.panel_Sup.ResumeLayout(false);
            this.panel_Sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNovedades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoNovedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListadoNovedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel_Sup;
        private System.Windows.Forms.Panel panel_Detalle;
        private DevExpress.XtraGrid.GridControl grdListadoNovedades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListadoNovedades;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNovedad;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPerComp;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colRubroDescp;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValor;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet1;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbNovedades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCalendario;
        private DevExpress.XtraGrid.Columns.GridColumn ColFecha_;
        private DevExpress.XtraGrid.Columns.GridColumn Colru_descripcion;
    }
}