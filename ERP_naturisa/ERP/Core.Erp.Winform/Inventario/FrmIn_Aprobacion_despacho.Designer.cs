namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Aprobacion_despacho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Aprobacion_despacho));
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.UCge_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_imprimir_transacciones_aprobadas = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Buscar = new DevExpress.XtraEditors.SimpleButton();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.gridControlDespacho = new DevExpress.XtraGrid.GridControl();
            this.gridViewDespacho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Imagenes = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_imprimir_transacciones_aprobadas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 438);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1029, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // UCge_Menu
            // 
            this.UCge_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCge_Menu.Enabled_bnRetImprimir = true;
            this.UCge_Menu.Enabled_bntAnular = true;
            this.UCge_Menu.Enabled_bntAprobar = true;
            this.UCge_Menu.Enabled_bntGuardar_y_Salir = true;
            this.UCge_Menu.Enabled_bntImprimir = true;
            this.UCge_Menu.Enabled_bntImprimir_Guia = true;
            this.UCge_Menu.Enabled_bntLimpiar = true;
            this.UCge_Menu.Enabled_bntSalir = true;
            this.UCge_Menu.Enabled_btn_conciliacion_Auto = true;
            this.UCge_Menu.Enabled_btn_DiseñoReporte = true;
            this.UCge_Menu.Enabled_btn_Generar_XML = true;
            this.UCge_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.UCge_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.UCge_Menu.Enabled_btn_Imprimir_Reten = true;
            this.UCge_Menu.Enabled_btnAceptar = true;
            this.UCge_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.UCge_Menu.Enabled_btnEstadosOC = true;
            this.UCge_Menu.Enabled_btnGuardar = true;
            this.UCge_Menu.Enabled_btnImpFrm = true;
            this.UCge_Menu.Enabled_btnImpLote = true;
            this.UCge_Menu.Enabled_btnImpRep = true;
            this.UCge_Menu.Enabled_btnImprimirSoporte = true;
            this.UCge_Menu.Enabled_btnproductos = true;
            this.UCge_Menu.Location = new System.Drawing.Point(0, 0);
            this.UCge_Menu.Name = "UCge_Menu";
            this.UCge_Menu.Size = new System.Drawing.Size(1029, 29);
            this.UCge_Menu.TabIndex = 1;
            this.UCge_Menu.Visible_bntAnular = false;
            this.UCge_Menu.Visible_bntAprobar = true;
            this.UCge_Menu.Visible_bntDiseñoReporte = false;
            this.UCge_Menu.Visible_bntGuardar_y_Salir = false;
            this.UCge_Menu.Visible_bntImprimir = false;
            this.UCge_Menu.Visible_bntImprimir_Guia = false;
            this.UCge_Menu.Visible_bntLimpiar = true;
            this.UCge_Menu.Visible_bntReImprimir = false;
            this.UCge_Menu.Visible_bntSalir = true;
            this.UCge_Menu.Visible_btn_Actualizar = false;
            this.UCge_Menu.Visible_btn_conciliacion_Auto = false;
            this.UCge_Menu.Visible_btn_Generar_XML = false;
            this.UCge_Menu.Visible_btn_Imprimir_Cbte = false;
            this.UCge_Menu.Visible_btn_Imprimir_Cheq = false;
            this.UCge_Menu.Visible_btn_Imprimir_Reten = false;
            this.UCge_Menu.Visible_btnAceptar = false;
            this.UCge_Menu.Visible_btnAprobarGuardarSalir = true;
            this.UCge_Menu.Visible_btnEstadosOC = false;
            this.UCge_Menu.Visible_btnGuardar = false;
            this.UCge_Menu.Visible_btnImpFrm = false;
            this.UCge_Menu.Visible_btnImpLote = false;
            this.UCge_Menu.Visible_btnImpRep = false;
            this.UCge_Menu.Visible_btnImprimirSoporte = false;
            this.UCge_Menu.Visible_btnproductos = false;
            this.UCge_Menu.event_btnAprobarGuardarSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobarGuardarSalir_Click(this.UCge_Menu_event_btnAprobarGuardarSalir_Click);
            this.UCge_Menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.UCge_Menu_event_btnlimpiar_Click);
            this.UCge_Menu.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.UCge_Menu_event_btnAprobar_Click);
            this.UCge_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.UCge_Menu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_imprimir_transacciones_aprobadas);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 85);
            this.panel1.TabIndex = 2;
            // 
            // chk_imprimir_transacciones_aprobadas
            // 
            this.chk_imprimir_transacciones_aprobadas.EditValue = true;
            this.chk_imprimir_transacciones_aprobadas.Location = new System.Drawing.Point(611, 30);
            this.chk_imprimir_transacciones_aprobadas.Name = "chk_imprimir_transacciones_aprobadas";
            this.chk_imprimir_transacciones_aprobadas.Properties.Caption = "Imprimir transacciónes aprobadas";
            this.chk_imprimir_transacciones_aprobadas.Size = new System.Drawing.Size(199, 19);
            this.chk_imprimir_transacciones_aprobadas.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(493, 22);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(83, 34);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(12, 13);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(462, 53);
            this.ucIn_Sucursal_Bodega1.TabIndex = 0;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            // 
            // gridControlDespacho
            // 
            this.gridControlDespacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDespacho.Location = new System.Drawing.Point(0, 114);
            this.gridControlDespacho.MainView = this.gridViewDespacho;
            this.gridControlDespacho.Name = "gridControlDespacho";
            this.gridControlDespacho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Imagenes});
            this.gridControlDespacho.Size = new System.Drawing.Size(1029, 324);
            this.gridControlDespacho.TabIndex = 3;
            this.gridControlDespacho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDespacho});
            // 
            // gridViewDespacho
            // 
            this.gridViewDespacho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colSucursal,
            this.colBodega,
            this.gridColumn1,
            this.gridColumn3,
            this.colIdEgr,
            this.gridColumn2,
            this.colReporte});
            this.gridViewDespacho.GridControl = this.gridControlDespacho;
            this.gridViewDespacho.Images = this.imageList1;
            this.gridViewDespacho.Name = "gridViewDespacho";
            this.gridViewDespacho.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDespacho.OptionsView.ShowGroupPanel = false;
            this.gridViewDespacho.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewDespacho_RowCellClick);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Checked";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 38;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "nom_sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.AllowEdit = false;
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 3;
            this.colSucursal.Width = 164;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "nom_bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 4;
            this.colBodega.Width = 180;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo";
            this.gridColumn1.FieldName = "NomTipoMovi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 179;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha";
            this.gridColumn3.FieldName = "cm_fecha";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 112;
            // 
            // colIdEgr
            // 
            this.colIdEgr.Caption = "# Egr";
            this.colIdEgr.FieldName = "num_Trans";
            this.colIdEgr.Name = "colIdEgr";
            this.colIdEgr.OptionsColumn.AllowEdit = false;
            this.colIdEgr.Visible = true;
            this.colIdEgr.VisibleIndex = 1;
            this.colIdEgr.Width = 66;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Observación";
            this.gridColumn2.FieldName = "cm_observacion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 383;
            // 
            // colReporte
            // 
            this.colReporte.ColumnEdit = this.cmb_Imagenes;
            this.colReporte.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colReporte.ImageIndex = 0;
            this.colReporte.Name = "colReporte";
            this.colReporte.OptionsColumn.AllowEdit = false;
            this.colReporte.Visible = true;
            this.colReporte.VisibleIndex = 2;
            this.colReporte.Width = 58;
            // 
            // cmb_Imagenes
            // 
            this.cmb_Imagenes.AutoHeight = false;
            this.cmb_Imagenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Imagenes.Images = this.imageList1;
            this.cmb_Imagenes.Name = "cmb_Imagenes";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Buscar_docu_32x32.png");
            // 
            // FrmIn_Aprobacion_despacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 464);
            this.Controls.Add(this.gridControlDespacho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UCge_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Aprobacion_despacho";
            this.Text = "Aprobación de despacho";
            this.Load += new System.EventHandler(this.FrmIn_Aprobacion_despacho_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_imprimir_transacciones_aprobadas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Imagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant UCge_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDespacho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDespacho;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private DevExpress.XtraEditors.SimpleButton btn_Buscar;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEgr;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.CheckEdit chk_imprimir_transacciones_aprobadas;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn colReporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit cmb_Imagenes;
    }
}