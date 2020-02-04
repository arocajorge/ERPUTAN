namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Tipo_Movi_Inven_Mantenimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chk_Usadoporsistemas = new System.Windows.Forms.CheckBox();
            this.chek_Estado = new System.Windows.Forms.CheckBox();
            this.rdb_Ingreso = new System.Windows.Forms.RadioButton();
            this.rdb_Egreso = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescCorta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGenerar_Diario = new System.Windows.Forms.CheckBox();
            this.chk_genera_mov_inv = new System.Windows.Forms.CheckBox();
            this.cmbTipoCbte = new Core.Erp.Winform.Controles.UCCon_TipoCbteCble();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.inmoviinventipoxtbbodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewBodega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCtaCble = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidBodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCodTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctCbtecbletipoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_seleccionar_todo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoxtbbodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(338, 10);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(135, 20);
            this.txt_Id.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 10);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(127, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 68);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(369, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // chk_Usadoporsistemas
            // 
            this.chk_Usadoporsistemas.AutoSize = true;
            this.chk_Usadoporsistemas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Usadoporsistemas.Location = new System.Drawing.Point(598, 71);
            this.chk_Usadoporsistemas.Name = "chk_Usadoporsistemas";
            this.chk_Usadoporsistemas.Size = new System.Drawing.Size(113, 17);
            this.chk_Usadoporsistemas.TabIndex = 6;
            this.chk_Usadoporsistemas.Text = "Usado por sistema";
            this.chk_Usadoporsistemas.UseVisualStyleBackColor = true;
            // 
            // chek_Estado
            // 
            this.chek_Estado.AutoSize = true;
            this.chek_Estado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chek_Estado.Location = new System.Drawing.Point(655, 45);
            this.chek_Estado.Name = "chek_Estado";
            this.chek_Estado.Size = new System.Drawing.Size(56, 17);
            this.chek_Estado.TabIndex = 7;
            this.chek_Estado.Tag = "";
            this.chek_Estado.Text = "Activo";
            this.chek_Estado.UseVisualStyleBackColor = true;
            this.chek_Estado.CheckedChanged += new System.EventHandler(this.chek_Estado_CheckedChanged);
            // 
            // rdb_Ingreso
            // 
            this.rdb_Ingreso.AutoSize = true;
            this.rdb_Ingreso.Checked = true;
            this.rdb_Ingreso.Location = new System.Drawing.Point(22, 17);
            this.rdb_Ingreso.Name = "rdb_Ingreso";
            this.rdb_Ingreso.Size = new System.Drawing.Size(81, 17);
            this.rdb_Ingreso.TabIndex = 8;
            this.rdb_Ingreso.TabStop = true;
            this.rdb_Ingreso.Text = "Ingreso ( + )";
            this.rdb_Ingreso.UseVisualStyleBackColor = true;
            // 
            // rdb_Egreso
            // 
            this.rdb_Egreso.AutoSize = true;
            this.rdb_Egreso.Location = new System.Drawing.Point(235, 17);
            this.rdb_Egreso.Name = "rdb_Egreso";
            this.rdb_Egreso.Size = new System.Drawing.Size(76, 17);
            this.rdb_Egreso.TabIndex = 9;
            this.rdb_Egreso.Text = "Egreso ( - )";
            this.rdb_Egreso.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Egreso);
            this.groupBox1.Controls.Add(this.rdb_Ingreso);
            this.groupBox1.Location = new System.Drawing.Point(133, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descripcion Corta";
            // 
            // txtDescCorta
            // 
            this.txtDescCorta.Location = new System.Drawing.Point(133, 94);
            this.txtDescCorta.MaxLength = 10;
            this.txtDescCorta.Name = "txtDescCorta";
            this.txtDescCorta.Size = new System.Drawing.Size(369, 20);
            this.txtDescCorta.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_seleccionar_todo);
            this.panel1.Controls.Add(this.chkGenerar_Diario);
            this.panel1.Controls.Add(this.chk_genera_mov_inv);
            this.panel1.Controls.Add(this.cmbTipoCbte);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.gridControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescCorta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.chek_Estado);
            this.panel1.Controls.Add(this.chk_Usadoporsistemas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 497);
            this.panel1.TabIndex = 15;
            // 
            // chkGenerar_Diario
            // 
            this.chkGenerar_Diario.AutoSize = true;
            this.chkGenerar_Diario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGenerar_Diario.Location = new System.Drawing.Point(547, 122);
            this.chkGenerar_Diario.Name = "chkGenerar_Diario";
            this.chkGenerar_Diario.Size = new System.Drawing.Size(164, 17);
            this.chkGenerar_Diario.TabIndex = 29;
            this.chkGenerar_Diario.Tag = "";
            this.chkGenerar_Diario.Text = "Genera DIARIO CONTABLE:";
            this.chkGenerar_Diario.UseVisualStyleBackColor = true;
            // 
            // chk_genera_mov_inv
            // 
            this.chk_genera_mov_inv.AutoSize = true;
            this.chk_genera_mov_inv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_genera_mov_inv.Location = new System.Drawing.Point(528, 97);
            this.chk_genera_mov_inv.Name = "chk_genera_mov_inv";
            this.chk_genera_mov_inv.Size = new System.Drawing.Size(183, 17);
            this.chk_genera_mov_inv.TabIndex = 28;
            this.chk_genera_mov_inv.Tag = "";
            this.chk_genera_mov_inv.Text = "Genera Movimiento de Inventario";
            this.chk_genera_mov_inv.UseVisualStyleBackColor = true;
            // 
            // cmbTipoCbte
            // 
            this.cmbTipoCbte.Location = new System.Drawing.Point(133, 36);
            this.cmbTipoCbte.Name = "cmbTipoCbte";
            this.cmbTipoCbte.Size = new System.Drawing.Size(369, 26);
            this.cmbTipoCbte.TabIndex = 27;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(479, 10);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(146, 20);
            this.lblAnulado.TabIndex = 16;
            this.lblAnulado.Text = "*** ANULADO ***";
            this.lblAnulado.Visible = false;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.inmoviinventipoxtbbodegaInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 187);
            this.gridControl.MainView = this.gridViewBodega;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCtaCble});
            this.gridControl.Size = new System.Drawing.Size(734, 310);
            this.gridControl.TabIndex = 26;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBodega});
            // 
            // inmoviinventipoxtbbodegaInfoBindingSource
            // 
            this.inmoviinventipoxtbbodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_x_tb_bodega_Info);
            // 
            // gridViewBodega
            // 
            this.gridViewBodega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colSucursal,
            this.colIdSucucursal,
            this.colBodega,
            this.colIdBodega,
            this.colIdCtaCble,
            this.colIdMovi_inven_tipo,
            this.colIdEmpresa,
            this.colidSucursal,
            this.colidBodega1});
            this.gridViewBodega.GridControl = this.gridControl;
            this.gridViewBodega.Name = "gridViewBodega";
            this.gridViewBodega.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBodega.OptionsView.ShowGroupPanel = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 0;
            this.colEstado.Width = 44;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.AllowEdit = false;
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 1;
            this.colSucursal.Width = 189;
            // 
            // colIdSucucursal
            // 
            this.colIdSucucursal.FieldName = "IdSucucursal";
            this.colIdSucucursal.Name = "colIdSucucursal";
            // 
            // colBodega
            // 
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 2;
            this.colBodega.Width = 189;
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.ColumnEdit = this.cmbCtaCble;
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 3;
            this.colIdCtaCble.Width = 197;
            // 
            // cmbCtaCble
            // 
            this.cmbCtaCble.AutoHeight = false;
            this.cmbCtaCble.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCtaCble.DataSource = this.ctPlanctaInfoBindingSource;
            this.cmbCtaCble.DisplayMember = "pc_Cuenta";
            this.cmbCtaCble.Name = "cmbCtaCble";
            this.cmbCtaCble.ValueMember = "IdCtaCble";
            this.cmbCtaCble.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble1,
            this.colpc_Cuenta});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.Caption = "Id Cta.";
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            this.colIdCtaCble1.Visible = true;
            this.colIdCtaCble1.VisibleIndex = 0;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "Descripción";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 1;
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colidSucursal
            // 
            this.colidSucursal.FieldName = "idSucursal";
            this.colidSucursal.Name = "colidSucursal";
            // 
            // colidBodega1
            // 
            this.colidBodega1.FieldName = "idBodega";
            this.colidBodega1.Name = "colidBodega1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Comprobante ";
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // colCodTipoCbte
            // 
            this.colCodTipoCbte.Caption = "Codigo";
            this.colCodTipoCbte.FieldName = "CodTipoCbte";
            this.colCodTipoCbte.Name = "colCodTipoCbte";
            this.colCodTipoCbte.Visible = true;
            this.colCodTipoCbte.VisibleIndex = 0;
            // 
            // colIdTipoCbte_Anul
            // 
            this.colIdTipoCbte_Anul.Caption = "Descripcion";
            this.colIdTipoCbte_Anul.FieldName = "IdTipoCbte_Anul";
            this.colIdTipoCbte_Anul.Name = "colIdTipoCbte_Anul";
            this.colIdTipoCbte_Anul.Visible = true;
            this.colIdTipoCbte_Anul.VisibleIndex = 1;
            // 
            // ctCbtecbletipoInfoBindingSource1
            // 
            this.ctCbtecbletipoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(734, 29);
            this.ucGe_Menu.TabIndex = 16;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
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
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 526);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(734, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 497);
            this.panel2.TabIndex = 18;
            // 
            // chk_seleccionar_todo
            // 
            this.chk_seleccionar_todo.AutoSize = true;
            this.chk_seleccionar_todo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_seleccionar_todo.Location = new System.Drawing.Point(22, 164);
            this.chk_seleccionar_todo.Name = "chk_seleccionar_todo";
            this.chk_seleccionar_todo.Size = new System.Drawing.Size(106, 17);
            this.chk_seleccionar_todo.TabIndex = 30;
            this.chk_seleccionar_todo.Tag = "";
            this.chk_seleccionar_todo.Text = "Seleccionar todo";
            this.chk_seleccionar_todo.UseVisualStyleBackColor = true;
            this.chk_seleccionar_todo.CheckedChanged += new System.EventHandler(this.chk_seleccionar_todo_CheckedChanged);
            // 
            // FrmIn_Tipo_Movi_Inven_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmIn_Tipo_Movi_Inven_Mantenimiento";
            this.Text = "Mantenimiento de Movimiento Tipo Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Tipo_Movi_Inven_Mantenimiento_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Tipo_Movi_Inven_Mantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoxtbbodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chk_Usadoporsistemas;
        private System.Windows.Forms.CheckBox chek_Estado;
        private System.Windows.Forms.RadioButton rdb_Ingreso;
        private System.Windows.Forms.RadioButton rdb_Egreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescCorta;
        private System.Windows.Forms.Panel panel1;
     //   private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        //  private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource2;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anul;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource inmoviinventipoxtbbodegaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colidBodega1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCtaCble;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource1;
        private System.Windows.Forms.Label lblAnulado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCCon_TipoCbteCble cmbTipoCbte;
        private System.Windows.Forms.CheckBox chk_genera_mov_inv;
        private System.Windows.Forms.CheckBox chkGenerar_Diario;
        private System.Windows.Forms.CheckBox chk_seleccionar_todo;
    }
}