namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenCompra_x_Detalle_Cons
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl_OC = new DevExpress.XtraGrid.GridControl();
            this.gridView_OC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencia_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_precioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_porc_des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldo_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_medida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbOGiroxOCompra = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOGiroxOCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 402);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(962, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(360, 31);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(359, 5);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaIni.TabIndex = 16;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(504, 6);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 45);
            this.btnConsulta.TabIndex = 15;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha Final:";
            // 
            // gridControl_OC
            // 
            this.gridControl_OC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_OC.Location = new System.Drawing.Point(0, 0);
            this.gridControl_OC.MainView = this.gridView_OC;
            this.gridControl_OC.Name = "gridControl_OC";
            this.gridControl_OC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbOGiroxOCompra});
            this.gridControl_OC.Size = new System.Drawing.Size(962, 311);
            this.gridControl_OC.TabIndex = 3;
            this.gridControl_OC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_OC});
            // 
            // gridView_OC
            // 
            this.gridView_OC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenCompra,
            this.colIdEmpresa_oc,
            this.colIdSucursal_oc,
            this.colSecuencia_oc,
            this.colIdProducto,
            this.coldo_Cantidad,
            this.coldo_precioCompra,
            this.coldo_porc_des,
            this.coldo_descuento,
            this.coldo_subtotal,
            this.coldo_iva,
            this.coldo_total,
            this.coldo_observacion,
            this.colIdUnidadMedida,
            this.colproducto,
            this.colnom_medida,
            this.colReferencia,
            this.colChecked});
            this.gridView_OC.GridControl = this.gridControl_OC;
            this.gridView_OC.GroupCount = 1;
            this.gridView_OC.Name = "gridView_OC";
            this.gridView_OC.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_OC.OptionsView.ShowAutoFilterRow = true;
            this.gridView_OC.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colReferencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_OC.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_OC_RowClick);
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "ID Compra";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 1;
            this.colIdOrdenCompra.Width = 69;
            // 
            // colIdEmpresa_oc
            // 
            this.colIdEmpresa_oc.FieldName = "IdEmpresa";
            this.colIdEmpresa_oc.Name = "colIdEmpresa_oc";
            // 
            // colIdSucursal_oc
            // 
            this.colIdSucursal_oc.FieldName = "IdSucursal";
            this.colIdSucursal_oc.Name = "colIdSucursal_oc";
            // 
            // colSecuencia_oc
            // 
            this.colSecuencia_oc.Caption = "Secuencia";
            this.colSecuencia_oc.FieldName = "Secuencia";
            this.colSecuencia_oc.Name = "colSecuencia_oc";
            this.colSecuencia_oc.OptionsColumn.AllowEdit = false;
            this.colSecuencia_oc.Visible = true;
            this.colSecuencia_oc.VisibleIndex = 3;
            this.colSecuencia_oc.Width = 51;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            // 
            // coldo_Cantidad
            // 
            this.coldo_Cantidad.Caption = "Cantidad";
            this.coldo_Cantidad.FieldName = "do_Cantidad";
            this.coldo_Cantidad.Name = "coldo_Cantidad";
            this.coldo_Cantidad.OptionsColumn.AllowEdit = false;
            this.coldo_Cantidad.Visible = true;
            this.coldo_Cantidad.VisibleIndex = 4;
            this.coldo_Cantidad.Width = 53;
            // 
            // coldo_precioCompra
            // 
            this.coldo_precioCompra.Caption = "Costo";
            this.coldo_precioCompra.FieldName = "do_precioCompra";
            this.coldo_precioCompra.Name = "coldo_precioCompra";
            this.coldo_precioCompra.OptionsColumn.AllowEdit = false;
            this.coldo_precioCompra.Visible = true;
            this.coldo_precioCompra.VisibleIndex = 6;
            this.coldo_precioCompra.Width = 47;
            // 
            // coldo_porc_des
            // 
            this.coldo_porc_des.Caption = "% Desc.";
            this.coldo_porc_des.FieldName = "do_porc_des";
            this.coldo_porc_des.Name = "coldo_porc_des";
            this.coldo_porc_des.OptionsColumn.AllowEdit = false;
            this.coldo_porc_des.Visible = true;
            this.coldo_porc_des.VisibleIndex = 7;
            this.coldo_porc_des.Width = 42;
            // 
            // coldo_descuento
            // 
            this.coldo_descuento.Caption = "Desc.";
            this.coldo_descuento.FieldName = "do_descuento";
            this.coldo_descuento.Name = "coldo_descuento";
            this.coldo_descuento.OptionsColumn.AllowEdit = false;
            this.coldo_descuento.Visible = true;
            this.coldo_descuento.VisibleIndex = 8;
            this.coldo_descuento.Width = 45;
            // 
            // coldo_subtotal
            // 
            this.coldo_subtotal.Caption = "Subtotal";
            this.coldo_subtotal.FieldName = "do_subtotal";
            this.coldo_subtotal.Name = "coldo_subtotal";
            this.coldo_subtotal.OptionsColumn.AllowEdit = false;
            this.coldo_subtotal.Visible = true;
            this.coldo_subtotal.VisibleIndex = 9;
            this.coldo_subtotal.Width = 60;
            // 
            // coldo_iva
            // 
            this.coldo_iva.Caption = "Iva";
            this.coldo_iva.FieldName = "do_iva";
            this.coldo_iva.Name = "coldo_iva";
            this.coldo_iva.OptionsColumn.AllowEdit = false;
            this.coldo_iva.Visible = true;
            this.coldo_iva.VisibleIndex = 10;
            this.coldo_iva.Width = 34;
            // 
            // coldo_total
            // 
            this.coldo_total.Caption = "Total";
            this.coldo_total.FieldName = "do_total";
            this.coldo_total.Name = "coldo_total";
            this.coldo_total.OptionsColumn.AllowEdit = false;
            this.coldo_total.Visible = true;
            this.coldo_total.VisibleIndex = 11;
            this.coldo_total.Width = 70;
            // 
            // coldo_observacion
            // 
            this.coldo_observacion.Caption = "Observación";
            this.coldo_observacion.FieldName = "do_observacion";
            this.coldo_observacion.Name = "coldo_observacion";
            this.coldo_observacion.OptionsColumn.AllowEdit = false;
            this.coldo_observacion.Visible = true;
            this.coldo_observacion.VisibleIndex = 12;
            this.coldo_observacion.Width = 358;
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            // 
            // colproducto
            // 
            this.colproducto.Caption = "Producto";
            this.colproducto.FieldName = "producto";
            this.colproducto.Name = "colproducto";
            this.colproducto.OptionsColumn.AllowEdit = false;
            this.colproducto.Visible = true;
            this.colproducto.VisibleIndex = 2;
            this.colproducto.Width = 224;
            // 
            // colnom_medida
            // 
            this.colnom_medida.Caption = "Uni. Medida";
            this.colnom_medida.FieldName = "nom_medida";
            this.colnom_medida.Name = "colnom_medida";
            this.colnom_medida.OptionsColumn.AllowEdit = false;
            this.colnom_medida.Visible = true;
            this.colnom_medida.VisibleIndex = 5;
            this.colnom_medida.Width = 103;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "Ref:";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 12;
            this.colReferencia.Width = 85;
            // 
            // colChecked
            // 
            this.colChecked.Caption = "*";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.OptionsColumn.AllowEdit = false;
            this.colChecked.OptionsColumn.AllowSize = false;
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            this.colChecked.Width = 41;
            // 
            // cmbOGiroxOCompra
            // 
            this.cmbOGiroxOCompra.AutoHeight = false;
            this.cmbOGiroxOCompra.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOGiroxOCompra.Name = "cmbOGiroxOCompra";
            this.cmbOGiroxOCompra.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(962, 29);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = true;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaFin);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaIni);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsulta);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl_OC);
            this.splitContainer1.Size = new System.Drawing.Size(962, 373);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 5;
            // 
            // FrmCom_OrdenCompra_x_Detalle_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 428);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmCom_OrdenCompra_x_Detalle_Cons";
            this.Text = "Consulta de Ordenes de Compra por Detalle";
            this.Load += new System.EventHandler(this.FrmCom_OrdenCompra_x_Detalle_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOGiroxOCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControl_OC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_OC;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_precioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_porc_des;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_descuento;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_iva;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_total;
        private DevExpress.XtraGrid.Columns.GridColumn coldo_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_medida;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbOGiroxOCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}