namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Transferencia_Mantenimiento
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
            this.ucin_motivo_destino = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.UCTipoMoviDestino = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.label7 = new System.Windows.Forms.Label();
            this.ucin_motivo_origen = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.label3 = new System.Windows.Forms.Label();
            this.UCTipoMoviOrigen = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.UCSucursalDestino = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.UCSucursalOrigen = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ucIn_Catalogos_Cmb1 = new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBox = new DevExpress.XtraEditors.GroupControl();
            this.btn_buscar_guia = new DevExpress.XtraEditors.CheckButton();
            this.txtIdGuiaRemision = new DevExpress.XtraEditors.TextEdit();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.txtNumtransferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIng = new DevExpress.XtraEditors.ButtonEdit();
            this.btnEgr = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelDetalleProducto = new System.Windows.Forms.Panel();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomSubCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbUniMedida_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida_cmbgird = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPuntoCargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPunto_cargo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbGridSubCentroCosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubCentroSelect = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpBox)).BeginInit();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdGuiaRemision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIng.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEgr.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelDetalleProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUniMedida_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGridSubCentroCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentroSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucin_motivo_destino
            // 
            this.ucin_motivo_destino.Location = new System.Drawing.Point(584, 44);
            this.ucin_motivo_destino.Name = "ucin_motivo_destino";
            this.ucin_motivo_destino.Size = new System.Drawing.Size(310, 26);
            this.ucin_motivo_destino.TabIndex = 6;
            this.ucin_motivo_destino.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            // 
            // UCTipoMoviDestino
            // 
            this.UCTipoMoviDestino.Enabled = false;
            this.UCTipoMoviDestino.Location = new System.Drawing.Point(582, 16);
            this.UCTipoMoviDestino.Name = "UCTipoMoviDestino";
            this.UCTipoMoviDestino.Size = new System.Drawing.Size(311, 33);
            this.UCTipoMoviDestino.TabIndex = 1;
            this.UCTipoMoviDestino.Visible_buton_Acciones = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Motivo";
            // 
            // ucin_motivo_origen
            // 
            this.ucin_motivo_origen.Location = new System.Drawing.Point(586, 44);
            this.ucin_motivo_origen.Name = "ucin_motivo_origen";
            this.ucin_motivo_origen.Size = new System.Drawing.Size(307, 26);
            this.ucin_motivo_origen.TabIndex = 8;
            this.ucin_motivo_origen.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.EGR;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de movimiento";
            // 
            // UCTipoMoviOrigen
            // 
            this.UCTipoMoviOrigen.Enabled = false;
            this.UCTipoMoviOrigen.Location = new System.Drawing.Point(584, 16);
            this.UCTipoMoviOrigen.Name = "UCTipoMoviOrigen";
            this.UCTipoMoviOrigen.Size = new System.Drawing.Size(308, 33);
            this.UCTipoMoviOrigen.TabIndex = 1;
            this.UCTipoMoviOrigen.Visible_buton_Acciones = true;
            // 
            // UCSucursalDestino
            // 
            this.UCSucursalDestino.Location = new System.Drawing.Point(12, 19);
            this.UCSucursalDestino.Name = "UCSucursalDestino";
            this.UCSucursalDestino.Size = new System.Drawing.Size(459, 51);
            this.UCSucursalDestino.TabIndex = 0;
            this.UCSucursalDestino.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            // 
            // UCSucursalOrigen
            // 
            this.UCSucursalOrigen.Location = new System.Drawing.Point(12, 19);
            this.UCSucursalOrigen.Name = "UCSucursalOrigen";
            this.UCSucursalOrigen.Size = new System.Drawing.Size(459, 51);
            this.UCSucursalOrigen.TabIndex = 0;
            this.UCSucursalOrigen.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            this.UCSucursalOrigen.Event_cmb_sucursal1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_sucursal1_EditValueChanged(this.UCSucursalOrigen_Event_cmb_sucursal1_EditValueChanged_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(424, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Estado";
            // 
            // ucIn_Catalogos_Cmb1
            // 
            this.ucIn_Catalogos_Cmb1.Location = new System.Drawing.Point(463, 36);
            this.ucIn_Catalogos_Cmb1.Name = "ucIn_Catalogos_Cmb1";
            this.ucIn_Catalogos_Cmb1.Size = new System.Drawing.Size(220, 29);
            this.ucIn_Catalogos_Cmb1.TabIndex = 18;
            this.ucIn_Catalogos_Cmb1.Visible_btn_acciones = true;
            this.ucIn_Catalogos_Cmb1.event_delegate_cmbCatalogo_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Catalogos_Cmb.delegate_cmbCatalogo_EditValueChanged(this.ucIn_Catalogos_Cmb1_event_delegate_cmbCatalogo_EditValueChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 20);
            this.txtCodigo.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Observacion:";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btn_buscar_guia);
            this.grpBox.Controls.Add(this.txtIdGuiaRemision);
            this.grpBox.Location = new System.Drawing.Point(689, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(163, 53);
            this.grpBox.TabIndex = 0;
            this.grpBox.Text = "Importar Guia";
            // 
            // btn_buscar_guia
            // 
            this.btn_buscar_guia.Location = new System.Drawing.Point(109, 23);
            this.btn_buscar_guia.Name = "btn_buscar_guia";
            this.btn_buscar_guia.Size = new System.Drawing.Size(41, 23);
            this.btn_buscar_guia.TabIndex = 1;
            this.btn_buscar_guia.Text = "...";
            this.btn_buscar_guia.CheckedChanged += new System.EventHandler(this.btn_buscar_guia_CheckedChanged);
            // 
            // txtIdGuiaRemision
            // 
            this.txtIdGuiaRemision.Location = new System.Drawing.Point(5, 24);
            this.txtIdGuiaRemision.Name = "txtIdGuiaRemision";
            this.txtIdGuiaRemision.Size = new System.Drawing.Size(100, 20);
            this.txtIdGuiaRemision.TabIndex = 15;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(243, 3);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(179, 31);
            this.lblAnulado.TabIndex = 12;
            this.lblAnulado.Text = "***Anulado***";
            this.lblAnulado.Visible = false;
            // 
            // txtNumtransferencia
            // 
            this.txtNumtransferencia.Location = new System.Drawing.Point(108, 14);
            this.txtNumtransferencia.Name = "txtNumtransferencia";
            this.txtNumtransferencia.Size = new System.Drawing.Size(128, 20);
            this.txtNumtransferencia.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "# Transferencia";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(108, 67);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(567, 28);
            this.txtObservacion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(469, 11);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(166, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1, 1);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1016, 24);
            this.ucGe_Menu.TabIndex = 9;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
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
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnIng);
            this.panel2.Controls.Add(this.btnEgr);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.lblAnulado);
            this.panel2.Controls.Add(this.ucIn_Catalogos_Cmb1);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtObservacion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grpBox);
            this.panel2.Controls.Add(this.txtNumtransferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 121);
            this.panel2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "# Ing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "# Egr";
            // 
            // btnIng
            // 
            this.btnIng.Location = new System.Drawing.Point(439, 97);
            this.btnIng.Name = "btnIng";
            this.btnIng.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.btnIng.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnIng.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnIng.Size = new System.Drawing.Size(100, 20);
            this.btnIng.TabIndex = 20;
            this.btnIng.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnIng_ButtonClick);
            // 
            // btnEgr
            // 
            this.btnEgr.Location = new System.Drawing.Point(275, 97);
            this.btnEgr.Name = "btnEgr";
            this.btnEgr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.btnEgr.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEgr.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnEgr.Size = new System.Drawing.Size(100, 20);
            this.btnEgr.TabIndex = 10;
            this.btnEgr.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEgr_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UCSucursalOrigen);
            this.groupBox1.Controls.Add(this.ucin_motivo_origen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UCTipoMoviOrigen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UCSucursalDestino);
            this.groupBox2.Controls.Add(this.ucin_motivo_destino);
            this.groupBox2.Controls.Add(this.UCTipoMoviDestino);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 74);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Motivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de movimiento";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDetalleProducto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle de productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelDetalleProducto
            // 
            this.panelDetalleProducto.Controls.Add(this.gridControlProductos);
            this.panelDetalleProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalleProducto.Location = new System.Drawing.Point(3, 3);
            this.panelDetalleProducto.Name = "panelDetalleProducto";
            this.panelDetalleProducto.Size = new System.Drawing.Size(1002, 135);
            this.panelDetalleProducto.TabIndex = 5;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.cmbCentroCosto_grid,
            this.cmbSubCentroCosto_grid,
            this.cmbUniMedida_grid,
            this.cmbPuntoCargo_grid,
            this.cmbGridSubCentroCosto,
            this.cmbSubCentroSelect});
            this.gridControlProductos.Size = new System.Drawing.Size(1002, 135);
            this.gridControlProductos.TabIndex = 2;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colcod_producto,
            this.coldm_cantidad,
            this.colmv_costo,
            this.coldm_observacion,
            this.colNomSubCentroCosto,
            this.colIdCentroCosto_sub_centro_costo,
            this.colCheck,
            this.col_IdUnidadMedida,
            this.colIdCentroCosto_grid});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProductos_RowCellStyle);
            this.gridViewProductos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProductos_FocusedRowChanged);
            this.gridViewProductos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanged);
            this.gridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyDown);
            this.gridViewProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridViewProductos_KeyPress);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 2;
            this.colIdProducto.Width = 306;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_cmbgrid,
            this.colpr_codigo_cmbgrid,
            this.colpr_descripcion,
            this.colpr_precio_publico,
            this.colpr_stock,
            this.colpr_pedidos,
            this.colpr_ManejaIva,
            this.colpr_costo_promedio,
            this.colpr_peso});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_cmbgrid
            // 
            this.colIdProducto_cmbgrid.Caption = "IdProducto";
            this.colIdProducto_cmbgrid.FieldName = "IdProducto";
            this.colIdProducto_cmbgrid.Name = "colIdProducto_cmbgrid";
            this.colIdProducto_cmbgrid.Width = 86;
            // 
            // colpr_codigo_cmbgrid
            // 
            this.colpr_codigo_cmbgrid.Caption = "Código";
            this.colpr_codigo_cmbgrid.FieldName = "pr_codigo";
            this.colpr_codigo_cmbgrid.Name = "colpr_codigo_cmbgrid";
            this.colpr_codigo_cmbgrid.Visible = true;
            this.colpr_codigo_cmbgrid.VisibleIndex = 0;
            this.colpr_codigo_cmbgrid.Width = 67;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            this.colpr_descripcion.Width = 575;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "P.V.P.";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Width = 67;
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock_Bodega";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Visible = true;
            this.colpr_stock.VisibleIndex = 2;
            this.colpr_stock.Width = 105;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 3;
            this.colpr_pedidos.Width = 105;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Visible = true;
            this.colpr_ManejaIva.VisibleIndex = 4;
            this.colpr_ManejaIva.Width = 105;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 5;
            this.colpr_costo_promedio.Width = 105;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Width = 118;
            // 
            // colcod_producto
            // 
            this.colcod_producto.Caption = "Código";
            this.colcod_producto.FieldName = "cod_producto";
            this.colcod_producto.Name = "colcod_producto";
            this.colcod_producto.OptionsColumn.AllowEdit = false;
            this.colcod_producto.Visible = true;
            this.colcod_producto.VisibleIndex = 1;
            this.colcod_producto.Width = 74;
            // 
            // coldm_cantidad
            // 
            this.coldm_cantidad.Caption = "Cantidad";
            this.coldm_cantidad.FieldName = "dm_cantidad_sinConversion";
            this.coldm_cantidad.Name = "coldm_cantidad";
            this.coldm_cantidad.Visible = true;
            this.coldm_cantidad.VisibleIndex = 4;
            this.coldm_cantidad.Width = 56;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo";
            this.colmv_costo.FieldName = "mv_costo_sinConversion";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.OptionsColumn.AllowEdit = false;
            this.colmv_costo.Width = 54;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación por Producto";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Visible = true;
            this.coldm_observacion.VisibleIndex = 5;
            this.coldm_observacion.Width = 209;
            // 
            // colNomSubCentroCosto
            // 
            this.colNomSubCentroCosto.Caption = "SubCentroCosto";
            this.colNomSubCentroCosto.ColumnEdit = this.cmbSubCentroCosto_grid;
            this.colNomSubCentroCosto.FieldName = "NomSubCentroCosto";
            this.colNomSubCentroCosto.Name = "colNomSubCentroCosto";
            this.colNomSubCentroCosto.Width = 124;
            // 
            // cmbSubCentroCosto_grid
            // 
            this.cmbSubCentroCosto_grid.AutoHeight = false;
            this.cmbSubCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubCentroCosto_grid.Name = "cmbSubCentroCosto_grid";
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Checked";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "Unidad de medida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmbUniMedida_grid;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida_sinConversion";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.Visible = true;
            this.col_IdUnidadMedida.VisibleIndex = 3;
            this.col_IdUnidadMedida.Width = 141;
            // 
            // cmbUniMedida_grid
            // 
            this.cmbUniMedida_grid.AutoHeight = false;
            this.cmbUniMedida_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUniMedida_grid.DisplayMember = "Descripcion";
            this.cmbUniMedida_grid.Name = "cmbUniMedida_grid";
            this.cmbUniMedida_grid.ValueMember = "IdUnidadMedida";
            this.cmbUniMedida_grid.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida_cmbgird,
            this.colDescripcion,
            this.colEstado_cmbgrid});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida_cmbgird
            // 
            this.colIdUnidadMedida_cmbgird.Caption = "Unidad";
            this.colIdUnidadMedida_cmbgird.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida_cmbgird.Name = "colIdUnidadMedida_cmbgird";
            this.colIdUnidadMedida_cmbgird.Visible = true;
            this.colIdUnidadMedida_cmbgird.VisibleIndex = 1;
            this.colIdUnidadMedida_cmbgird.Width = 201;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 777;
            // 
            // colEstado_cmbgrid
            // 
            this.colEstado_cmbgrid.Caption = "Estado";
            this.colEstado_cmbgrid.FieldName = "Estado";
            this.colEstado_cmbgrid.Name = "colEstado_cmbgrid";
            this.colEstado_cmbgrid.Width = 202;
            // 
            // colIdCentroCosto_grid
            // 
            this.colIdCentroCosto_grid.Caption = "Centro costo";
            this.colIdCentroCosto_grid.ColumnEdit = this.cmbCentroCosto_grid;
            this.colIdCentroCosto_grid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_grid.Name = "colIdCentroCosto_grid";
            // 
            // cmbCentroCosto_grid
            // 
            this.cmbCentroCosto_grid.AutoHeight = false;
            this.cmbCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto_grid.Name = "cmbCentroCosto_grid";
            this.cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto_grid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo,
            this.colpc_Estado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "Código";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 179;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Descripción";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 0;
            this.colCentro_costo.Width = 820;
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.Caption = "Estado";
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            this.colpc_Estado.Visible = true;
            this.colpc_Estado.VisibleIndex = 2;
            this.colpc_Estado.Width = 181;
            // 
            // cmbPuntoCargo_grid
            // 
            this.cmbPuntoCargo_grid.AutoHeight = false;
            this.cmbPuntoCargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoCargo_grid.Name = "cmbPuntoCargo_grid";
            this.cmbPuntoCargo_grid.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPunto_cargo_cmbgrid,
            this.colnom_punto_cargo});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPunto_cargo_cmbgrid
            // 
            this.colIdPunto_cargo_cmbgrid.Caption = "Código";
            this.colIdPunto_cargo_cmbgrid.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo_cmbgrid.Name = "colIdPunto_cargo_cmbgrid";
            this.colIdPunto_cargo_cmbgrid.Visible = true;
            this.colIdPunto_cargo_cmbgrid.VisibleIndex = 1;
            this.colIdPunto_cargo_cmbgrid.Width = 293;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Nombre";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 0;
            this.colnom_punto_cargo.Width = 887;
            // 
            // cmbGridSubCentroCosto
            // 
            this.cmbGridSubCentroCosto.AutoHeight = false;
            this.cmbGridSubCentroCosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGridSubCentroCosto.DisplayMember = "costo";
            this.cmbGridSubCentroCosto.Name = "cmbGridSubCentroCosto";
            this.cmbGridSubCentroCosto.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmbGridSubCentroCosto.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdCentroCosto";
            this.gridColumn1.FieldName = "IdCentroCosto";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id Sub Centro Costo";
            this.gridColumn2.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cod. Sub Centro Costo";
            this.gridColumn3.FieldName = "cod_subcentroCosto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sub Centro Costo";
            this.gridColumn4.FieldName = "Centro_costo2";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // cmbSubCentroSelect
            // 
            this.cmbSubCentroSelect.AutoHeight = false;
            this.cmbSubCentroSelect.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubCentroSelect.DisplayMember = "Centro_costo2";
            this.cmbSubCentroSelect.Name = "cmbSubCentroSelect";
            this.cmbSubCentroSelect.ReadOnly = true;
            this.cmbSubCentroSelect.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmbSubCentroSelect.View = this.gridView6;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 293);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 167);
            this.tabControl1.TabIndex = 6;
            // 
            // FrmIn_Transferencia_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 460);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Transferencia_Mantenimiento";
            this.Text = "Transferencias Entre Bodegas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIn_Transferencias_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_Transferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpBox)).EndInit();
            this.grpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIdGuiaRemision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIng.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEgr.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panelDetalleProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUniMedida_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGridSubCentroCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubCentroSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.TextBox txtNumtransferencia;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl grpBox;
        private DevExpress.XtraEditors.CheckButton btn_buscar_guia;
        private DevExpress.XtraEditors.TextEdit txtIdGuiaRemision;
        //private Controles.UCCon_GridDiarioContable GridDiarioContableEgreso;
        //private Controles.UCCon_GridDiarioContable GridDiarioContableIngreso;
        private Controles.UCIn_Sucursal_Bodega UCSucursalDestino;
        private Controles.UCIn_Sucursal_Bodega UCSucursalOrigen;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCIn_TipoMoviInv_Cmb UCTipoMoviDestino;
        private Controles.UCIn_TipoMoviInv_Cmb UCTipoMoviOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Controles.UCIn_MotivoInvCmb ucin_motivo_destino;
        private System.Windows.Forms.Label label7;
        private Controles.UCIn_MotivoInvCmb ucin_motivo_origen;
        private Controles.UCIn_Catalogos_Cmb ucIn_Catalogos_Cmb1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ButtonEdit btnIng;
        private DevExpress.XtraEditors.ButtonEdit btnEgr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelDetalleProducto;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_producto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomSubCentroCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbSubCentroCosto_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbUniMedida_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_cmbgird;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbPuntoCargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbGridSubCentroCosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbSubCentroSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.TabControl tabControl1;

    }
}