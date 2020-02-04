namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_EgresoDeSuministro
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridContro = new DevExpress.XtraGrid.GridControl();
            this.inegresodSuministroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEgresoSumin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroDeCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroDeCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.vwinZonavsctCentroCostoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdZona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSubZona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubzona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoZN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCbleZona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inegresodSuministroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroDeCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwinZonavsctCentroCostoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panelControl1.Controls.Add(this.ucGe_Menu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1129, 419);
            this.panelControl1.TabIndex = 0;
            // 
            // gridContro
            // 
            this.gridContro.DataSource = this.inegresodSuministroInfoBindingSource;
            this.gridContro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContro.Location = new System.Drawing.Point(0, 0);
            this.gridContro.MainView = this.gridView;
            this.gridContro.Name = "gridContro";
            this.gridContro.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCentroDeCosto});
            this.gridContro.Size = new System.Drawing.Size(1125, 360);
            this.gridContro.TabIndex = 0;
            this.gridContro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // inegresodSuministroInfoBindingSource
            // 
            this.inegresodSuministroInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_egreso_d_Suministro_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursa,
            this.colIdBodega,
            this.colIdEgresoSumin,
            this.colIdGasto,
            this.colIdCentroDeCosto,
            this.colIdProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal,
            this.colobservacion,
            this.colIdUsuario,
            this.colFecha_Transa,
            this.colIdUsuarioUltModi,
            this.colFechaUltModi,
            this.colIdUsuarioAnula,
            this.colFechaAnula,
            this.colEstado,
            this.colIdUnico});
            this.gridView.GridControl = this.gridContro;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursa
            // 
            this.colIdSucursa.FieldName = "IdSucursa";
            this.colIdSucursa.Name = "colIdSucursa";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdEgresoSumin
            // 
            this.colIdEgresoSumin.FieldName = "IdEgresoSumin";
            this.colIdEgresoSumin.Name = "colIdEgresoSumin";
            this.colIdEgresoSumin.Width = 122;
            // 
            // colIdGasto
            // 
            this.colIdGasto.FieldName = "IdGasto";
            this.colIdGasto.Name = "colIdGasto";
            this.colIdGasto.Visible = true;
            this.colIdGasto.VisibleIndex = 1;
            this.colIdGasto.Width = 77;
            // 
            // colIdCentroDeCosto
            // 
            this.colIdCentroDeCosto.FieldName = "IdCentroDeCosto";
            this.colIdCentroDeCosto.Name = "colIdCentroDeCosto";
            this.colIdCentroDeCosto.Width = 145;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 2;
            this.colIdProducto.Width = 218;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 77;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 79;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 5;
            this.colSubtotal.Width = 70;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 6;
            this.colobservacion.Width = 327;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transa
            // 
            this.colFecha_Transa.FieldName = "Fecha_Transa";
            this.colFecha_Transa.Name = "colFecha_Transa";
            // 
            // colIdUsuarioUltModi
            // 
            this.colIdUsuarioUltModi.FieldName = "IdUsuarioUltModi";
            this.colIdUsuarioUltModi.Name = "colIdUsuarioUltModi";
            // 
            // colFechaUltModi
            // 
            this.colFechaUltModi.FieldName = "FechaUltModi";
            this.colFechaUltModi.Name = "colFechaUltModi";
            // 
            // colIdUsuarioAnula
            // 
            this.colIdUsuarioAnula.FieldName = "IdUsuarioAnula";
            this.colIdUsuarioAnula.Name = "colIdUsuarioAnula";
            // 
            // colFechaAnula
            // 
            this.colFechaAnula.FieldName = "FechaAnula";
            this.colFechaAnula.Name = "colFechaAnula";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 110;
            // 
            // colIdUnico
            // 
            this.colIdUnico.ColumnEdit = this.cmbCentroDeCosto;
            this.colIdUnico.FieldName = "IdUnico";
            this.colIdUnico.Name = "colIdUnico";
            this.colIdUnico.Visible = true;
            this.colIdUnico.VisibleIndex = 0;
            // 
            // cmbCentroDeCosto
            // 
            this.cmbCentroDeCosto.AutoHeight = false;
            this.cmbCentroDeCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroDeCosto.DataSource = this.vwinZonavsctCentroCostoInfoBindingSource;
            this.cmbCentroDeCosto.DisplayMember = "Subzona";
            this.cmbCentroDeCosto.Name = "cmbCentroDeCosto";
            this.cmbCentroDeCosto.ValueMember = "IDUNICO";
            this.cmbCentroDeCosto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto,
            this.colCentro_costo,
            this.colIdZona,
            this.colZona,
            this.colIdSubZona,
            this.colSubzona,
            this.colCodigoZN,
            this.colIdCtaCbleZona});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colZona, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "Id Centro De Costo";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 0;
            this.colIdCentroCosto.Width = 90;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro de Costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            this.colCentro_costo.Width = 242;
            // 
            // colIdZona
            // 
            this.colIdZona.FieldName = "IdZona";
            this.colIdZona.Name = "colIdZona";
            this.colIdZona.Width = 272;
            // 
            // colZona
            // 
            this.colZona.Caption = "Zona";
            this.colZona.FieldName = "Zona";
            this.colZona.Name = "colZona";
            this.colZona.Visible = true;
            this.colZona.VisibleIndex = 3;
            this.colZona.Width = 285;
            // 
            // colIdSubZona
            // 
            this.colIdSubZona.FieldName = "IdSubZona";
            this.colIdSubZona.Name = "colIdSubZona";
            // 
            // colSubzona
            // 
            this.colSubzona.CustomizationCaption = "Sub-Zona";
            this.colSubzona.FieldName = "Subzona";
            this.colSubzona.Name = "colSubzona";
            this.colSubzona.Visible = true;
            this.colSubzona.VisibleIndex = 2;
            this.colSubzona.Width = 235;
            // 
            // colCodigoZN
            // 
            this.colCodigoZN.CustomizationCaption = "Codigo ";
            this.colCodigoZN.FieldName = "CodigoZN";
            this.colCodigoZN.Name = "colCodigoZN";
            this.colCodigoZN.Visible = true;
            this.colCodigoZN.VisibleIndex = 4;
            this.colCodigoZN.Width = 328;
            // 
            // colIdCtaCbleZona
            // 
            this.colIdCtaCbleZona.FieldName = "IdCtaCbleZona";
            this.colIdCtaCbleZona.Name = "colIdCtaCbleZona";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(2, 2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1125, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(2, 391);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1125, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridContro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 360);
            this.panel1.TabIndex = 3;
            // 
            // FrmIn_EgresoDeSuministro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 419);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmIn_EgresoDeSuministro";
            this.Text = "frmIn_EgresoDeSuministro";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inegresodSuministroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroDeCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwinZonavsctCentroCostoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridContro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource inegresodSuministroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEgresoSumin;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGasto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroDeCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltModi;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUltModi;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioAnula;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAnula;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroDeCosto;
        private System.Windows.Forms.BindingSource vwinZonavsctCentroCostoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdZona;
        private DevExpress.XtraGrid.Columns.GridColumn colZona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubZona;
        private DevExpress.XtraGrid.Columns.GridColumn colSubzona;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoZN;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCbleZona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnico;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}