namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenCompra_Gene_x_Solicitud_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCom_OrdenCompra_Gene_x_Solicitud_Cons));
            this.gridControlOrdComp = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdComp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolicitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colap_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_Comprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrec_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageListIconos = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdComp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlOrdComp
            // 
            this.gridControlOrdComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdComp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlOrdComp.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdComp.MainView = this.gridViewOrdComp;
            this.gridControlOrdComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlOrdComp.Name = "gridControlOrdComp";
            this.gridControlOrdComp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_imprimir});
            this.gridControlOrdComp.Size = new System.Drawing.Size(1237, 282);
            this.gridControlOrdComp.TabIndex = 0;
            this.gridControlOrdComp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdComp});
            // 
            // gridViewOrdComp
            // 
            this.gridViewOrdComp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSu_Descripcion,
            this.coloc_fecha,
            this.colIdOrdenCompra,
            this.colpr_nombre,
            this.colSolicitante,
            this.coloc_observacion,
            this.coltotal,
            this.colap_descripcion,
            this.colNom_Comprador,
            this.colSDepartamento,
            this.colrec_descripcion,
            this.gridColumn1});
            this.gridViewOrdComp.GridControl = this.gridControlOrdComp;
            this.gridViewOrdComp.Images = this.imageListIconos;
            this.gridViewOrdComp.Name = "gridViewOrdComp";
            this.gridViewOrdComp.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrdComp.OptionsView.ShowGroupPanel = false;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.AllowEdit = false;
            this.coloc_fecha.Visible = true;
            this.coloc_fecha.VisibleIndex = 1;
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "IdOrdenCompra";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 2;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.Caption = "Proveedor";
            this.colpr_nombre.FieldName = "pr_nombre";
            this.colpr_nombre.Name = "colpr_nombre";
            this.colpr_nombre.OptionsColumn.AllowEdit = false;
            this.colpr_nombre.Visible = true;
            this.colpr_nombre.VisibleIndex = 3;
            // 
            // colSolicitante
            // 
            this.colSolicitante.Caption = "Solicitante";
            this.colSolicitante.FieldName = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.OptionsColumn.AllowEdit = false;
            this.colSolicitante.Visible = true;
            this.colSolicitante.VisibleIndex = 4;
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.Caption = "Observación";
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            this.coloc_observacion.OptionsColumn.AllowEdit = false;
            this.coloc_observacion.Visible = true;
            this.coloc_observacion.VisibleIndex = 5;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.OptionsColumn.AllowEdit = false;
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 6;
            // 
            // colap_descripcion
            // 
            this.colap_descripcion.Caption = "Apro/Reprob";
            this.colap_descripcion.FieldName = "ap_descripcion";
            this.colap_descripcion.Name = "colap_descripcion";
            this.colap_descripcion.OptionsColumn.AllowEdit = false;
            this.colap_descripcion.Visible = true;
            this.colap_descripcion.VisibleIndex = 7;
            // 
            // colNom_Comprador
            // 
            this.colNom_Comprador.Caption = "Comprador";
            this.colNom_Comprador.FieldName = "Nom_Comprador";
            this.colNom_Comprador.Name = "colNom_Comprador";
            this.colNom_Comprador.OptionsColumn.AllowEdit = false;
            this.colNom_Comprador.Visible = true;
            this.colNom_Comprador.VisibleIndex = 8;
            // 
            // colSDepartamento
            // 
            this.colSDepartamento.Caption = "Departamento";
            this.colSDepartamento.FieldName = "SDepartamento";
            this.colSDepartamento.Name = "colSDepartamento";
            this.colSDepartamento.OptionsColumn.AllowEdit = false;
            this.colSDepartamento.Visible = true;
            this.colSDepartamento.VisibleIndex = 9;
            // 
            // colrec_descripcion
            // 
            this.colrec_descripcion.Caption = "Estado Recibido";
            this.colrec_descripcion.FieldName = "rec_descripcion";
            this.colrec_descripcion.Name = "colrec_descripcion";
            this.colrec_descripcion.OptionsColumn.AllowEdit = false;
            this.colrec_descripcion.Visible = true;
            this.colrec_descripcion.VisibleIndex = 10;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 318);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1237, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1237, 36);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = true;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = false;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_event_btnAprobar_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlOrdComp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 282);
            this.panel1.TabIndex = 5;
            // 
            // imageListIconos
            // 
            this.imageListIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIconos.ImageStream")));
            this.imageListIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIconos.Images.SetKeyName(0, "buscar_doc_64x64.png");
            this.imageListIconos.Images.SetKeyName(1, "Lupa_16x16.png");
            this.imageListIconos.Images.SetKeyName(2, "imprimir_32x32.png");
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.cmb_imprimir;
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.ImageIndex = 2;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // cmb_imprimir
            // 
            this.cmb_imprimir.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_imprimir.AutoHeight = false;
            this.cmb_imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imprimir.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 2)});
            this.cmb_imprimir.LargeImages = this.imageListIconos;
            this.cmb_imprimir.Name = "cmb_imprimir";
            this.cmb_imprimir.ReadOnly = true;
            this.cmb_imprimir.Click += new System.EventHandler(this.cmb_imprimir_Click);
            // 
            // FrmCom_OrdenCompra_Gene_x_Solicitud_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCom_OrdenCompra_Gene_x_Solicitud_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Compras Generadas por Solicitud";
            this.Load += new System.EventHandler(this.FrmCom_OrdenCompra_Gene_x_Solicitud_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdComp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imprimir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrdComp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdComp;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colSolicitante;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colap_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_Comprador;
        private DevExpress.XtraGrid.Columns.GridColumn colSDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colrec_descripcion;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageListIconos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imprimir;
    }
}