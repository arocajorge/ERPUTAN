namespace Core.Erp.Winform.Controles
{
    partial class UCRo_Historico_Vacaciones
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRo_Historico_Vacaciones));
            this.gridControlHistorico = new DevExpress.XtraGrid.GridControl();
            this.roHistoricoVacacionesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewHistorico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasGanados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasTomados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDiasPendientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHis_Vacaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roHistoricoVacacionesInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlHistorico
            // 
            this.gridControlHistorico.DataSource = this.roHistoricoVacacionesInfoBindingSource;
            this.gridControlHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHistorico.Location = new System.Drawing.Point(0, 0);
            this.gridControlHistorico.MainView = this.gridViewHistorico;
            this.gridControlHistorico.Name = "gridControlHistorico";
            this.gridControlHistorico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1});
            this.gridControlHistorico.Size = new System.Drawing.Size(689, 256);
            this.gridControlHistorico.TabIndex = 0;
            this.gridControlHistorico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistorico});
            // 
            // roHistoricoVacacionesInfoBindingSource
            // 
            this.roHistoricoVacacionesInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_historico_vacaciones_x_empleado_Info);
            // 
            // gridViewHistorico
            // 
            this.gridViewHistorico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipo,
            this.colFechaInicio,
            this.colFechaFin,
            this.colDiasGanados,
            this.colDiasTomados,
            this.colDiasPendientes,
            this.colIco,
            this.colSecuencia,
            this.colIdHis_Vacaciones,
            this.colcheck});
            this.gridViewHistorico.GridControl = this.gridControlHistorico;
            this.gridViewHistorico.Name = "gridViewHistorico";
            this.gridViewHistorico.OptionsView.ShowFooter = true;
            this.gridViewHistorico.OptionsView.ShowGroupPanel = false;
            this.gridViewHistorico.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewHistorico_RowCellClick);
            this.gridViewHistorico.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewHistorico_FocusedRowChanged);
            this.gridViewHistorico.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewHistorico_CellValueChanged);
            this.gridViewHistorico.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewHistorico_CellValueChanging);
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 95;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 2;
            this.colFechaInicio.Width = 95;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 3;
            this.colFechaFin.Width = 95;
            // 
            // colDiasGanados
            // 
            this.colDiasGanados.FieldName = "DiasGanados";
            this.colDiasGanados.Name = "colDiasGanados";
            this.colDiasGanados.OptionsColumn.AllowEdit = false;
            this.colDiasGanados.Visible = true;
            this.colDiasGanados.VisibleIndex = 4;
            this.colDiasGanados.Width = 95;
            // 
            // colDiasTomados
            // 
            this.colDiasTomados.ColumnEdit = this.repositoryItemTextEdit1;
            this.colDiasTomados.FieldName = "DiasTomados";
            this.colDiasTomados.Name = "colDiasTomados";
            this.colDiasTomados.Visible = true;
            this.colDiasTomados.VisibleIndex = 5;
            this.colDiasTomados.Width = 95;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "[+]?[0-99]?{2}";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit1.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colDiasPendientes
            // 
            this.colDiasPendientes.FieldName = "DiasPendientes";
            this.colDiasPendientes.Name = "colDiasPendientes";
            this.colDiasPendientes.OptionsColumn.AllowEdit = false;
            this.colDiasPendientes.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DiasPendientes", "", 0)});
            this.colDiasPendientes.Visible = true;
            this.colDiasPendientes.VisibleIndex = 6;
            this.colDiasPendientes.Width = 147;
            // 
            // colIco
            // 
            this.colIco.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIco.FieldName = "Ico";
            this.colIco.Name = "colIco";
            this.colIco.OptionsColumn.AllowEdit = false;
            this.colIco.OptionsColumn.ShowCaption = false;
            this.colIco.Width = 49;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.OptionsColumn.AllowEdit = false;
            // 
            // colIdHis_Vacaciones
            // 
            this.colIdHis_Vacaciones.FieldName = "IdHis_Vacaciones";
            this.colIdHis_Vacaciones.Name = "colIdHis_Vacaciones";
            // 
            // colcheck
            // 
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "busqueda.jpg");
            // 
            // UCRo_Historico_Vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlHistorico);
            this.Name = "UCRo_Historico_Vacaciones";
            this.Size = new System.Drawing.Size(689, 256);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roHistoricoVacacionesInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlHistorico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistorico;
        private System.Windows.Forms.BindingSource roHistoricoVacacionesInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasGanados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasTomados;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPendientes;
        private DevExpress.XtraGrid.Columns.GridColumn colIco;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHis_Vacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
