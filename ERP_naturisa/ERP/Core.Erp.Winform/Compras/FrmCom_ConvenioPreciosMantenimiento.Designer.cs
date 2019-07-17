namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_ConvenioPreciosMantenimiento
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
            this.cmbProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblDepartamento = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUnidad = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbTermino = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbComprador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkPaso2 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.chkPaso3 = new DevExpress.XtraEditors.CheckEdit();
            this.chkPaso4 = new DevExpress.XtraEditors.CheckEdit();
            this.txtPrecioUni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorDesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescUni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioFinal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasEntrega = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucMenu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTermino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComprador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescUni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasEntrega.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProducto
            // 
            this.cmbProducto.Location = new System.Drawing.Point(163, 73);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto.Properties.DisplayMember = "pr_descripcion";
            this.cmbProducto.Properties.ValueMember = "IdProducto";
            this.cmbProducto.Properties.View = this.searchLookUpEdit1View;
            this.cmbProducto.Size = new System.Drawing.Size(397, 22);
            this.cmbProducto.TabIndex = 5;
            this.cmbProducto.EditValueChanged += new System.EventHandler(this.cmbProducto_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Location = new System.Drawing.Point(43, 76);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(50, 16);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Producto";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 104);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "U. medida";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.Location = new System.Drawing.Point(163, 101);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnidad.Properties.DisplayMember = "Descripcion";
            this.cmbUnidad.Properties.ValueMember = "IdUnidadMedida";
            this.cmbUnidad.Properties.View = this.gridView1;
            this.cmbUnidad.Size = new System.Drawing.Size(397, 22);
            this.cmbUnidad.TabIndex = 8;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Location = new System.Drawing.Point(163, 129);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor.Properties.DisplayMember = "pe_nombreCompleto";
            this.cmbProveedor.Properties.ValueMember = "IdProveedor";
            this.cmbProveedor.Properties.View = this.gridView2;
            this.cmbProveedor.Size = new System.Drawing.Size(397, 22);
            this.cmbProveedor.TabIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cmbTermino
            // 
            this.cmbTermino.Location = new System.Drawing.Point(163, 157);
            this.cmbTermino.Name = "cmbTermino";
            this.cmbTermino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTermino.Properties.DisplayMember = "Descripcion";
            this.cmbTermino.Properties.ValueMember = "IdTerminoPago";
            this.cmbTermino.Properties.View = this.gridView3;
            this.cmbTermino.Size = new System.Drawing.Size(397, 22);
            this.cmbTermino.TabIndex = 11;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // cmbComprador
            // 
            this.cmbComprador.Location = new System.Drawing.Point(163, 185);
            this.cmbComprador.Name = "cmbComprador";
            this.cmbComprador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbComprador.Properties.DisplayMember = "Descripcion";
            this.cmbComprador.Properties.ValueMember = "IdComprador";
            this.cmbComprador.Properties.View = this.gridView4;
            this.cmbComprador.Size = new System.Drawing.Size(397, 22);
            this.cmbComprador.TabIndex = 12;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Proveedor";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 16);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Término pago";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Comprador";
            // 
            // chkPaso2
            // 
            this.chkPaso2.Location = new System.Drawing.Point(586, 73);
            this.chkPaso2.Name = "chkPaso2";
            this.chkPaso2.Properties.Caption = "Saltar paso 2 -Aprobación de cantidades";
            this.chkPaso2.Size = new System.Drawing.Size(290, 21);
            this.chkPaso2.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(323, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 16);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Valido hasta";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = null;
            this.de_Fecha.Location = new System.Drawing.Point(411, 45);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(149, 22);
            this.de_Fecha.TabIndex = 16;
            // 
            // chkPaso3
            // 
            this.chkPaso3.Location = new System.Drawing.Point(586, 100);
            this.chkPaso3.Name = "chkPaso3";
            this.chkPaso3.Properties.Caption = "Saltar paso 3 - Cotización";
            this.chkPaso3.Size = new System.Drawing.Size(279, 21);
            this.chkPaso3.TabIndex = 19;
            // 
            // chkPaso4
            // 
            this.chkPaso4.Location = new System.Drawing.Point(586, 127);
            this.chkPaso4.Name = "chkPaso4";
            this.chkPaso4.Properties.Caption = "Saltar paso 4 - Aprobación JC";
            this.chkPaso4.Size = new System.Drawing.Size(279, 21);
            this.chkPaso4.TabIndex = 20;
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(163, 213);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.Properties.Mask.BeepOnError = true;
            this.txtPrecioUni.Properties.Mask.EditMask = "c2";
            this.txtPrecioUni.Properties.NullText = "0";
            this.txtPrecioUni.Size = new System.Drawing.Size(115, 22);
            this.txtPrecioUni.TabIndex = 21;
            this.txtPrecioUni.EditValueChanged += new System.EventHandler(this.txtPrecioUni_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(43, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Precio uni.";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 244);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "% Descuento";
            // 
            // txtPorDesc
            // 
            this.txtPorDesc.Location = new System.Drawing.Point(163, 241);
            this.txtPorDesc.Name = "txtPorDesc";
            this.txtPorDesc.Properties.NullText = "0";
            this.txtPorDesc.Size = new System.Drawing.Size(115, 22);
            this.txtPorDesc.TabIndex = 23;
            this.txtPorDesc.EditValueChanged += new System.EventHandler(this.txtPorDesc_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(43, 272);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 16);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Descuento uni.";
            // 
            // txtDescUni
            // 
            this.txtDescUni.Location = new System.Drawing.Point(163, 269);
            this.txtDescUni.Name = "txtDescUni";
            this.txtDescUni.Properties.NullText = "0";
            this.txtDescUni.Properties.ReadOnly = true;
            this.txtDescUni.Size = new System.Drawing.Size(115, 22);
            this.txtDescUni.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(43, 300);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 16);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Precio final";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(163, 297);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Properties.NullText = "0";
            this.txtPrecioFinal.Properties.ReadOnly = true;
            this.txtPrecioFinal.Size = new System.Drawing.Size(115, 22);
            this.txtPrecioFinal.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(323, 216);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(72, 16);
            this.labelControl10.TabIndex = 30;
            this.labelControl10.Text = "Dias entrega";
            // 
            // txtDiasEntrega
            // 
            this.txtDiasEntrega.Location = new System.Drawing.Point(411, 213);
            this.txtDiasEntrega.Name = "txtDiasEntrega";
            this.txtDiasEntrega.Properties.NullText = "0";
            this.txtDiasEntrega.Size = new System.Drawing.Size(149, 22);
            this.txtDiasEntrega.TabIndex = 29;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ID";
            this.gridColumn9.FieldName = "IdComprador";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 185;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Departamento";
            this.gridColumn10.FieldName = "Descripcion";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 1549;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "IdTerminoPago";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 185;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Término pago";
            this.gridColumn8.FieldName = "Descripcion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 1549;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "IdProveedor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 185;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Proveedor";
            this.gridColumn6.FieldName = "pe_nombreCompleto";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 1549;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID";
            this.gridColumn3.FieldName = "IdUnidadMedida";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 185;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Departamento";
            this.gridColumn4.FieldName = "Descripcion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 1549;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 185;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Producto";
            this.gridColumn2.FieldName = "pr_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1549;
            // 
            // ucMenu
            // 
            this.ucMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMenu.Enabled_bnRetImprimir = true;
            this.ucMenu.Enabled_bntAnular = true;
            this.ucMenu.Enabled_bntAprobar = true;
            this.ucMenu.Enabled_bntGuardar_y_Salir = true;
            this.ucMenu.Enabled_bntImprimir = true;
            this.ucMenu.Enabled_bntImprimir_Guia = true;
            this.ucMenu.Enabled_bntLimpiar = true;
            this.ucMenu.Enabled_bntSalir = true;
            this.ucMenu.Enabled_btn_conciliacion_Auto = true;
            this.ucMenu.Enabled_btn_DiseñoReporte = true;
            this.ucMenu.Enabled_btn_Generar_XML = true;
            this.ucMenu.Enabled_btn_Imprimir_Cbte = true;
            this.ucMenu.Enabled_btn_Imprimir_Cheq = true;
            this.ucMenu.Enabled_btn_Imprimir_Reten = true;
            this.ucMenu.Enabled_btnAceptar = true;
            this.ucMenu.Enabled_btnAprobarGuardarSalir = true;
            this.ucMenu.Enabled_btnEstadosOC = true;
            this.ucMenu.Enabled_btnGuardar = true;
            this.ucMenu.Enabled_btnImpFrm = true;
            this.ucMenu.Enabled_btnImpLote = true;
            this.ucMenu.Enabled_btnImpRep = true;
            this.ucMenu.Enabled_btnImprimirSoporte = true;
            this.ucMenu.Enabled_btnproductos = true;
            this.ucMenu.Location = new System.Drawing.Point(0, 0);
            this.ucMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ucMenu.Name = "ucMenu";
            this.ucMenu.Size = new System.Drawing.Size(886, 31);
            this.ucMenu.TabIndex = 0;
            this.ucMenu.Visible_bntAnular = true;
            this.ucMenu.Visible_bntAprobar = false;
            this.ucMenu.Visible_bntDiseñoReporte = false;
            this.ucMenu.Visible_bntGuardar_y_Salir = true;
            this.ucMenu.Visible_bntImprimir = false;
            this.ucMenu.Visible_bntImprimir_Guia = false;
            this.ucMenu.Visible_bntLimpiar = true;
            this.ucMenu.Visible_bntReImprimir = false;
            this.ucMenu.Visible_bntSalir = true;
            this.ucMenu.Visible_btn_Actualizar = false;
            this.ucMenu.Visible_btn_conciliacion_Auto = false;
            this.ucMenu.Visible_btn_Generar_XML = false;
            this.ucMenu.Visible_btn_Imprimir_Cbte = false;
            this.ucMenu.Visible_btn_Imprimir_Cheq = false;
            this.ucMenu.Visible_btn_Imprimir_Reten = false;
            this.ucMenu.Visible_btnAceptar = false;
            this.ucMenu.Visible_btnAprobarGuardarSalir = false;
            this.ucMenu.Visible_btnContabilizar = false;
            this.ucMenu.Visible_btnEstadosOC = false;
            this.ucMenu.Visible_btnGuardar = true;
            this.ucMenu.Visible_btnImpFrm = false;
            this.ucMenu.Visible_btnImpLote = false;
            this.ucMenu.Visible_btnImpRep = false;
            this.ucMenu.Visible_btnImprimirSoporte = false;
            this.ucMenu.Visible_btnModificar = false;
            this.ucMenu.Visible_btnproductos = false;
            this.ucMenu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucMenu_event_btnGuardar_Click);
            this.ucMenu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucMenu_event_btnGuardar_y_Salir_Click);
            this.ucMenu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucMenu_event_btnlimpiar_Click);
            this.ucMenu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucMenu_event_btnAnular_Click);
            this.ucMenu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucMenu_event_btnSalir_Click);
            // 
            // FrmCom_ConvenioPreciosMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 374);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtDiasEntrega);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtDescUni);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPorDesc);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPrecioUni);
            this.Controls.Add(this.chkPaso4);
            this.Controls.Add(this.chkPaso3);
            this.Controls.Add(this.chkPaso2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.de_Fecha);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbComprador);
            this.Controls.Add(this.cmbTermino);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.ucMenu);
            this.Name = "FrmCom_ConvenioPreciosMantenimiento";
            this.Text = "Convenio de precios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCom_ConvenioPreciosMantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmCom_ConvenioPreciosMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTermino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComprador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPaso4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescUni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasEntrega.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucMenu;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbUnidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTermino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbComprador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkPaso2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit de_Fecha;
        private DevExpress.XtraEditors.CheckEdit chkPaso3;
        private DevExpress.XtraEditors.CheckEdit chkPaso4;
        private DevExpress.XtraEditors.TextEdit txtPrecioUni;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPorDesc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtDescUni;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtPrecioFinal;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtDiasEntrega;
    }
}