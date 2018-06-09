namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panePrincipal = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridControlPiezaEsperaSerMovidas = new DevExpress.XtraGrid.GridControl();
            this.gridViewPiezasEsperasSerMovidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColEtapaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEtapaSiguiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPuenteGrua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaYhora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTiempoEspera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.BtnPantallaCompleta = new DevExpress.XtraEditors.SimpleButton();
            this.LbMinutos = new System.Windows.Forms.Label();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.LbFechaHasta = new System.Windows.Forms.Label();
            this.LbFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.timercontadorMinutos = new System.Windows.Forms.Timer(this.components);
            this.timerContadorSegundos = new System.Windows.Forms.Timer(this.components);
            this.timerMinutos = new System.Windows.Forms.Timer(this.components);
            this.panePrincipal.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPiezaEsperaSerMovidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPiezasEsperasSerMovidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = false;
            this.ucGe_Menu.Enabled_bntAnular = false;
            this.ucGe_Menu.Enabled_bntAprobar = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1130, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            // 
            // panePrincipal
            // 
            this.panePrincipal.Controls.Add(this.panelGrid);
            this.panePrincipal.Controls.Add(this.panelFiltro);
            this.panePrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panePrincipal.Location = new System.Drawing.Point(0, 29);
            this.panePrincipal.Name = "panePrincipal";
            this.panePrincipal.Size = new System.Drawing.Size(1130, 473);
            this.panePrincipal.TabIndex = 1;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridControlPiezaEsperaSerMovidas);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 34);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1130, 439);
            this.panelGrid.TabIndex = 1;
            // 
            // gridControlPiezaEsperaSerMovidas
            // 
            this.gridControlPiezaEsperaSerMovidas.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlPiezaEsperaSerMovidas.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlPiezaEsperaSerMovidas.Location = new System.Drawing.Point(0, 0);
            this.gridControlPiezaEsperaSerMovidas.MainView = this.gridViewPiezasEsperasSerMovidas;
            this.gridControlPiezaEsperaSerMovidas.Name = "gridControlPiezaEsperaSerMovidas";
            this.gridControlPiezaEsperaSerMovidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3});
            this.gridControlPiezaEsperaSerMovidas.Size = new System.Drawing.Size(1130, 439);
            this.gridControlPiezaEsperaSerMovidas.TabIndex = 4;
            this.gridControlPiezaEsperaSerMovidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPiezasEsperasSerMovidas});
            // 
            // gridViewPiezasEsperasSerMovidas
            // 
            this.gridViewPiezasEsperasSerMovidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColEtapaInicio,
            this.ColEtapaSiguiente,
            this.ColPuenteGrua,
            this.ColFechaYhora,
            this.ColTiempoEspera});
            this.gridViewPiezasEsperasSerMovidas.GridControl = this.gridControlPiezaEsperaSerMovidas;
            this.gridViewPiezasEsperasSerMovidas.Name = "gridViewPiezasEsperasSerMovidas";
            this.gridViewPiezasEsperasSerMovidas.OptionsFind.AlwaysVisible = true;
            this.gridViewPiezasEsperasSerMovidas.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPiezasEsperasSerMovidas.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPiezasEsperasSerMovidas_RowCellStyle);
            // 
            // ColEtapaInicio
            // 
            this.ColEtapaInicio.Caption = "Ubicacion Pieza";
            this.ColEtapaInicio.FieldName = "EtapaUbucacion";
            this.ColEtapaInicio.Name = "ColEtapaInicio";
            this.ColEtapaInicio.Visible = true;
            this.ColEtapaInicio.VisibleIndex = 0;
            this.ColEtapaInicio.Width = 254;
            // 
            // ColEtapaSiguiente
            // 
            this.ColEtapaSiguiente.Caption = "Etapa Destino";
            this.ColEtapaSiguiente.FieldName = "EtapaSiguiente";
            this.ColEtapaSiguiente.Name = "ColEtapaSiguiente";
            this.ColEtapaSiguiente.Visible = true;
            this.ColEtapaSiguiente.VisibleIndex = 1;
            this.ColEtapaSiguiente.Width = 272;
            // 
            // ColPuenteGrua
            // 
            this.ColPuenteGrua.Caption = "PuenteGrua";
            this.ColPuenteGrua.FieldName = "NomPuenteGrua";
            this.ColPuenteGrua.Name = "ColPuenteGrua";
            this.ColPuenteGrua.Visible = true;
            this.ColPuenteGrua.VisibleIndex = 2;
            this.ColPuenteGrua.Width = 327;
            // 
            // ColFechaYhora
            // 
            this.ColFechaYhora.Caption = "Fecha Y Hora";
            this.ColFechaYhora.FieldName = "FechaTransaccion";
            this.ColFechaYhora.Name = "ColFechaYhora";
            this.ColFechaYhora.Visible = true;
            this.ColFechaYhora.VisibleIndex = 3;
            this.ColFechaYhora.Width = 131;
            // 
            // ColTiempoEspera
            // 
            this.ColTiempoEspera.Caption = "Tiempo en Espera [dd:hh:mm:ss]";
            this.ColTiempoEspera.FieldName = "TiempoEspera";
            this.ColTiempoEspera.Name = "ColTiempoEspera";
            this.ColTiempoEspera.Visible = true;
            this.ColTiempoEspera.VisibleIndex = 4;
            this.ColTiempoEspera.Width = 180;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", false, 3)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.BtnPantallaCompleta);
            this.panelFiltro.Controls.Add(this.LbMinutos);
            this.panelFiltro.Controls.Add(this.BtnBuscar);
            this.panelFiltro.Controls.Add(this.LbFechaHasta);
            this.panelFiltro.Controls.Add(this.LbFechaDesde);
            this.panelFiltro.Controls.Add(this.dtpFechaFin);
            this.panelFiltro.Controls.Add(this.dtpFechaInicio);
            this.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltro.Location = new System.Drawing.Point(0, 0);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(1130, 34);
            this.panelFiltro.TabIndex = 0;
            // 
            // BtnPantallaCompleta
            // 
            this.BtnPantallaCompleta.BackgroundImage = global::Core.Erp.Winform.Properties.Resources._01_Infopath;
            this.BtnPantallaCompleta.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPantallaCompleta.Image = global::Core.Erp.Winform.Properties.Resources._01_Infopath1;
            this.BtnPantallaCompleta.Location = new System.Drawing.Point(1093, 0);
            this.BtnPantallaCompleta.Name = "BtnPantallaCompleta";
            this.BtnPantallaCompleta.Size = new System.Drawing.Size(37, 34);
            this.BtnPantallaCompleta.TabIndex = 113;
            this.BtnPantallaCompleta.Click += new System.EventHandler(this.BtnPantallaCompleta_Click);
            // 
            // LbMinutos
            // 
            this.LbMinutos.AutoSize = true;
            this.LbMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMinutos.ForeColor = System.Drawing.Color.Red;
            this.LbMinutos.Location = new System.Drawing.Point(494, 2);
            this.LbMinutos.Name = "LbMinutos";
            this.LbMinutos.Size = new System.Drawing.Size(85, 29);
            this.LbMinutos.TabIndex = 112;
            this.LbMinutos.Text = "label1";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(406, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(69, 28);
            this.BtnBuscar.TabIndex = 111;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LbFechaHasta
            // 
            this.LbFechaHasta.AutoSize = true;
            this.LbFechaHasta.Location = new System.Drawing.Point(210, 3);
            this.LbFechaHasta.Name = "LbFechaHasta";
            this.LbFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.LbFechaHasta.TabIndex = 110;
            this.LbFechaHasta.Text = "Hasta:";
            // 
            // LbFechaDesde
            // 
            this.LbFechaDesde.AutoSize = true;
            this.LbFechaDesde.Location = new System.Drawing.Point(12, 3);
            this.LbFechaDesde.Name = "LbFechaDesde";
            this.LbFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.LbFechaDesde.TabIndex = 109;
            this.LbFechaDesde.Text = "Desde:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(267, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaFin.TabIndex = 108;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(70, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaInicio.TabIndex = 107;
            // 
            // timercontadorMinutos
            // 
            this.timercontadorMinutos.Enabled = true;
            this.timercontadorMinutos.Interval = 60000;
            this.timercontadorMinutos.Tick += new System.EventHandler(this.timercontadorMinutos_Tick);
            // 
            // timerContadorSegundos
            // 
            this.timerContadorSegundos.Enabled = true;
            this.timerContadorSegundos.Interval = 1000;
            this.timerContadorSegundos.Tick += new System.EventHandler(this.timerContadorSegundos_Tick);
            // 
            // timerMinutos
            // 
            this.timerMinutos.Enabled = true;
            this.timerMinutos.Tick += new System.EventHandler(this.timerMinutos_Tick);
            // 
            // Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 502);
            this.Controls.Add(this.panePrincipal);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua";
            this.Text = "                                                                      Piezas en E" +
    "spera ser Movidas por Puente Grua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Prd_PiezasEspera_SerMovidas_PuenteGrua_Load);
            this.panePrincipal.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPiezaEsperaSerMovidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPiezasEsperasSerMovidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panePrincipal;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label LbFechaHasta;
        private System.Windows.Forms.Label LbFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Panel panelGrid;
        private DevExpress.XtraGrid.GridControl gridControlPiezaEsperaSerMovidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPiezasEsperasSerMovidas;
        private DevExpress.XtraGrid.Columns.GridColumn ColEtapaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn ColEtapaSiguiente;
        private DevExpress.XtraGrid.Columns.GridColumn ColPuenteGrua;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaYhora;
        private DevExpress.XtraGrid.Columns.GridColumn ColTiempoEspera;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
        private System.Windows.Forms.Timer timercontadorMinutos;
        private System.Windows.Forms.Timer timerContadorSegundos;
        private System.Windows.Forms.Timer timerMinutos;
        private System.Windows.Forms.Label LbMinutos;
        private DevExpress.XtraEditors.SimpleButton BtnPantallaCompleta;
    }
}