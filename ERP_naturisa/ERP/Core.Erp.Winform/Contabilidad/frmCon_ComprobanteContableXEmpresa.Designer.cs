namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_ComprobanteContableXEmpresa
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
            this.gridControlCbteTipo = new DevExpress.XtraGrid.GridControl();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCbteTipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Nemonico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCbteTipoXEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbteTipoXEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoCbte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoCbte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Estado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Interno1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Nemonico1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anul1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDerechaUno = new DevExpress.XtraEditors.SimpleButton();
            this.btnDerechaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIzquierdaTodos = new DevExpress.XtraEditors.SimpleButton();
            this.btnIzquierdaUno = new DevExpress.XtraEditors.SimpleButton();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteTipoXEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteTipoXEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlCbteTipo
            // 
            this.gridControlCbteTipo.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.gridControlCbteTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCbteTipo.Location = new System.Drawing.Point(2, 21);
            this.gridControlCbteTipo.MainView = this.gridViewCbteTipo;
            this.gridControlCbteTipo.Name = "gridControlCbteTipo";
            this.gridControlCbteTipo.Size = new System.Drawing.Size(435, 362);
            this.gridControlCbteTipo.TabIndex = 1;
            this.gridControlCbteTipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbteTipo});
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // gridViewCbteTipo
            // 
            this.gridViewCbteTipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCbte,
            this.colCodTipoCbte,
            this.coltc_TipoCbte,
            this.coltc_Estado,
            this.coltc_Interno,
            this.coltc_Nemonico,
            this.colIdTipoCbte_Anul});
            this.gridViewCbteTipo.GridControl = this.gridControlCbteTipo;
            this.gridViewCbteTipo.Name = "gridViewCbteTipo";
            this.gridViewCbteTipo.OptionsBehavior.Editable = false;
            this.gridViewCbteTipo.OptionsView.ShowGroupPanel = false;
            this.gridViewCbteTipo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdTipoCbte, DevExpress.Data.ColumnSortOrder.Ascending)});
            //this.gridViewCbteTipo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCbteTipo_FocusedRowChanged);
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.Caption = "Id";
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            this.colIdTipoCbte.Visible = true;
            this.colIdTipoCbte.VisibleIndex = 0;
            this.colIdTipoCbte.Width = 41;
            // 
            // colCodTipoCbte
            // 
            this.colCodTipoCbte.Caption = "Codigo";
            this.colCodTipoCbte.FieldName = "CodTipoCbte";
            this.colCodTipoCbte.Name = "colCodTipoCbte";
            this.colCodTipoCbte.Visible = true;
            this.colCodTipoCbte.VisibleIndex = 1;
            this.colCodTipoCbte.Width = 126;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Descripcion";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 2;
            this.coltc_TipoCbte.Width = 199;
            // 
            // coltc_Estado
            // 
            this.coltc_Estado.FieldName = "tc_Estado";
            this.coltc_Estado.Name = "coltc_Estado";
            // 
            // coltc_Interno
            // 
            this.coltc_Interno.FieldName = "tc_Interno";
            this.coltc_Interno.Name = "coltc_Interno";
            // 
            // coltc_Nemonico
            // 
            this.coltc_Nemonico.FieldName = "tc_Nemonico";
            this.coltc_Nemonico.Name = "coltc_Nemonico";
            // 
            // colIdTipoCbte_Anul
            // 
            this.colIdTipoCbte_Anul.FieldName = "IdTipoCbte_Anul";
            this.colIdTipoCbte_Anul.Name = "colIdTipoCbte_Anul";
            // 
            // gridControlCbteTipoXEmpresa
            // 
            this.gridControlCbteTipoXEmpresa.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.gridControlCbteTipoXEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCbteTipoXEmpresa.Location = new System.Drawing.Point(2, 21);
            this.gridControlCbteTipoXEmpresa.MainView = this.gridViewCbteTipoXEmpresa;
            this.gridControlCbteTipoXEmpresa.Name = "gridControlCbteTipoXEmpresa";
            this.gridControlCbteTipoXEmpresa.Size = new System.Drawing.Size(416, 362);
            this.gridControlCbteTipoXEmpresa.TabIndex = 1;
            this.gridControlCbteTipoXEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbteTipoXEmpresa});
            // 
            // gridViewCbteTipoXEmpresa
            // 
            this.gridViewCbteTipoXEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoCbte1,
            this.colCodTipoCbte1,
            this.coltc_TipoCbte1,
            this.coltc_Estado1,
            this.coltc_Interno1,
            this.coltc_Nemonico1,
            this.colIdTipoCbte_Anul1});
            this.gridViewCbteTipoXEmpresa.GridControl = this.gridControlCbteTipoXEmpresa;
            this.gridViewCbteTipoXEmpresa.Name = "gridViewCbteTipoXEmpresa";
            this.gridViewCbteTipoXEmpresa.OptionsBehavior.Editable = false;
            this.gridViewCbteTipoXEmpresa.OptionsView.ShowGroupPanel = false;
            this.gridViewCbteTipoXEmpresa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdTipoCbte1, DevExpress.Data.ColumnSortOrder.Ascending)});
            //this.gridViewCbteTipoXEmpresa.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCbteTipoXEmpresa_FocusedRowChanged);
            // 
            // colIdTipoCbte1
            // 
            this.colIdTipoCbte1.Caption = "Id";
            this.colIdTipoCbte1.FieldName = "IdTipoCbte";
            this.colIdTipoCbte1.Name = "colIdTipoCbte1";
            this.colIdTipoCbte1.Visible = true;
            this.colIdTipoCbte1.VisibleIndex = 0;
            this.colIdTipoCbte1.Width = 91;
            // 
            // colCodTipoCbte1
            // 
            this.colCodTipoCbte1.Caption = "Codigo";
            this.colCodTipoCbte1.FieldName = "CodTipoCbte";
            this.colCodTipoCbte1.Name = "colCodTipoCbte1";
            this.colCodTipoCbte1.Visible = true;
            this.colCodTipoCbte1.VisibleIndex = 1;
            this.colCodTipoCbte1.Width = 442;
            // 
            // coltc_TipoCbte1
            // 
            this.coltc_TipoCbte1.Caption = "Descripcion";
            this.coltc_TipoCbte1.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte1.Name = "coltc_TipoCbte1";
            this.coltc_TipoCbte1.Visible = true;
            this.coltc_TipoCbte1.VisibleIndex = 2;
            this.coltc_TipoCbte1.Width = 625;
            // 
            // coltc_Estado1
            // 
            this.coltc_Estado1.FieldName = "tc_Estado";
            this.coltc_Estado1.Name = "coltc_Estado1";
            // 
            // coltc_Interno1
            // 
            this.coltc_Interno1.FieldName = "tc_Interno";
            this.coltc_Interno1.Name = "coltc_Interno1";
            // 
            // coltc_Nemonico1
            // 
            this.coltc_Nemonico1.FieldName = "tc_Nemonico";
            this.coltc_Nemonico1.Name = "coltc_Nemonico1";
            // 
            // colIdTipoCbte_Anul1
            // 
            this.colIdTipoCbte_Anul1.FieldName = "IdTipoCbte_Anul";
            this.colIdTipoCbte_Anul1.Name = "colIdTipoCbte_Anul1";
            // 
            // btnDerechaUno
            // 
            this.btnDerechaUno.Location = new System.Drawing.Point(13, 100);
            this.btnDerechaUno.Name = "btnDerechaUno";
            this.btnDerechaUno.Size = new System.Drawing.Size(36, 23);
            this.btnDerechaUno.TabIndex = 2;
            this.btnDerechaUno.Text = ">";
            //this.btnDerechaUno.Click += new System.EventHandler(this.btnDerechaUno_Click);
            // 
            // btnDerechaTodos
            // 
            this.btnDerechaTodos.Location = new System.Drawing.Point(13, 144);
            this.btnDerechaTodos.Name = "btnDerechaTodos";
            this.btnDerechaTodos.Size = new System.Drawing.Size(36, 23);
            this.btnDerechaTodos.TabIndex = 2;
            this.btnDerechaTodos.Text = ">>";
            //this.btnDerechaTodos.Click += new System.EventHandler(this.btnDerechaTodos_Click);
            // 
            // BtnIzquierdaTodos
            // 
            this.BtnIzquierdaTodos.Location = new System.Drawing.Point(13, 190);
            this.BtnIzquierdaTodos.Name = "BtnIzquierdaTodos";
            this.BtnIzquierdaTodos.Size = new System.Drawing.Size(36, 23);
            this.BtnIzquierdaTodos.TabIndex = 2;
            this.BtnIzquierdaTodos.Text = "<<";
            //this.BtnIzquierdaTodos.Click += new System.EventHandler(this.BtnIzquierdaTodos_Click);
            // 
            // btnIzquierdaUno
            // 
            this.btnIzquierdaUno.Location = new System.Drawing.Point(13, 232);
            this.btnIzquierdaUno.Name = "btnIzquierdaUno";
            this.btnIzquierdaUno.Size = new System.Drawing.Size(36, 23);
            this.btnIzquierdaUno.TabIndex = 2;
            this.btnIzquierdaUno.Text = "<";
            //this.btnIzquierdaUno.Click += new System.EventHandler(this.btnIzquierdaUno_Click);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(918, 29);
            this.ucGe_Menu.TabIndex = 3;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            //this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(918, 385);
            this.splitContainer1.SplitterDistance = 439;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(55, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 385);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDerechaTodos);
            this.groupBox1.Controls.Add(this.btnDerechaUno);
            this.groupBox1.Controls.Add(this.btnIzquierdaUno);
            this.groupBox1.Controls.Add(this.BtnIzquierdaTodos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(55, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCbteTipo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(439, 385);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Comprobantes Disponibles:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlCbteTipoXEmpresa);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 385);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Comprobantes Asignados:";
            // 
            // frmCon_ComprobanteContableXEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 414);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_ComprobanteContableXEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante Contable Por Empresa";
            //this.Load += new System.EventHandler(this.frmCt_ComprobanteContableXEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteTipoXEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteTipoXEmpresa)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCbteTipo;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbteTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Interno;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Nemonico;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anul;
        private DevExpress.XtraGrid.GridControl gridControlCbteTipoXEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbteTipoXEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbte1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Estado1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Interno1;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Nemonico1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anul1;
        private DevExpress.XtraEditors.SimpleButton btnDerechaUno;
        private DevExpress.XtraEditors.SimpleButton btnDerechaTodos;
        private DevExpress.XtraEditors.SimpleButton BtnIzquierdaTodos;
        private DevExpress.XtraEditors.SimpleButton btnIzquierdaUno;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}