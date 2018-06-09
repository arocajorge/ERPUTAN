namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_AsignarGT_P_ProductivoMantenimiento
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbEtapas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbProcesoProductivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProcesoProductivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridControlSubgrupos = new DevExpress.XtraGrid.GridControl();
            this.gridViewSubgrupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColGrupotrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSubgrupotrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbEtapas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProcesoProductivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubgrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubgrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = false;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = false;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(700, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // PanelSup
            // 
            this.PanelSup.Controls.Add(this.label2);
            this.PanelSup.Controls.Add(this.CmbEtapas);
            this.PanelSup.Controls.Add(this.label1);
            this.PanelSup.Controls.Add(this.CmbProcesoProductivo);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 29);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(700, 58);
            this.PanelSup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EtapasProduccion";
            // 
            // CmbEtapas
            // 
            this.CmbEtapas.Location = new System.Drawing.Point(128, 29);
            this.CmbEtapas.Name = "CmbEtapas";
            this.CmbEtapas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbEtapas.Properties.DisplayMember = "NombreEtapa";
            this.CmbEtapas.Properties.ValueMember = "IdEtapa";
            this.CmbEtapas.Properties.View = this.gridView1;
            this.CmbEtapas.Size = new System.Drawing.Size(549, 20);
            this.CmbEtapas.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEtapa,
            this.ColNombreEtapa});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdEtapa
            // 
            this.ColIdEtapa.Caption = "Id";
            this.ColIdEtapa.FieldName = "IdEtapa";
            this.ColIdEtapa.Name = "ColIdEtapa";
            this.ColIdEtapa.Visible = true;
            this.ColIdEtapa.VisibleIndex = 0;
            this.ColIdEtapa.Width = 57;
            // 
            // ColNombreEtapa
            // 
            this.ColNombreEtapa.Caption = "Nombre Etapa";
            this.ColNombreEtapa.FieldName = "NombreEtapa";
            this.ColNombreEtapa.Name = "ColNombreEtapa";
            this.ColNombreEtapa.Visible = true;
            this.ColNombreEtapa.VisibleIndex = 1;
            this.ColNombreEtapa.Width = 1197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procesos Productivos";
            // 
            // CmbProcesoProductivo
            // 
            this.CmbProcesoProductivo.Location = new System.Drawing.Point(128, 3);
            this.CmbProcesoProductivo.Name = "CmbProcesoProductivo";
            this.CmbProcesoProductivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProcesoProductivo.Properties.DisplayMember = "Nombre";
            this.CmbProcesoProductivo.Properties.ValueMember = "IdProcesoProductivo";
            this.CmbProcesoProductivo.Properties.View = this.gridLookUpEdit1View;
            this.CmbProcesoProductivo.Size = new System.Drawing.Size(549, 20);
            this.CmbProcesoProductivo.TabIndex = 0;
            this.CmbProcesoProductivo.EditValueChanged += new System.EventHandler(this.CmbProcesoProductivo_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProcesoProductivo,
            this.ColNombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdProcesoProductivo
            // 
            this.ColIdProcesoProductivo.Caption = "Id";
            this.ColIdProcesoProductivo.FieldName = "IdProcesoProductivo";
            this.ColIdProcesoProductivo.Name = "ColIdProcesoProductivo";
            this.ColIdProcesoProductivo.Visible = true;
            this.ColIdProcesoProductivo.VisibleIndex = 0;
            this.ColIdProcesoProductivo.Width = 59;
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombre";
            this.ColNombre.FieldName = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 1;
            this.ColNombre.Width = 1195;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridControlSubgrupos);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 87);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(700, 377);
            this.panelGrid.TabIndex = 2;
            // 
            // gridControlSubgrupos
            // 
            this.gridControlSubgrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSubgrupos.Location = new System.Drawing.Point(0, 0);
            this.gridControlSubgrupos.MainView = this.gridViewSubgrupos;
            this.gridControlSubgrupos.Name = "gridControlSubgrupos";
            this.gridControlSubgrupos.Size = new System.Drawing.Size(700, 377);
            this.gridControlSubgrupos.TabIndex = 0;
            this.gridControlSubgrupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSubgrupos});
            // 
            // gridViewSubgrupos
            // 
            this.gridViewSubgrupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColGrupotrabajo,
            this.ColSubgrupotrabajo,
            this.ColCheck});
            this.gridViewSubgrupos.GridControl = this.gridControlSubgrupos;
            this.gridViewSubgrupos.Name = "gridViewSubgrupos";
            this.gridViewSubgrupos.OptionsView.ShowAutoFilterRow = true;
            // 
            // ColGrupotrabajo
            // 
            this.ColGrupotrabajo.Caption = "Grupo Trabajo";
            this.ColGrupotrabajo.FieldName = "NombreGrupos";
            this.ColGrupotrabajo.Name = "ColGrupotrabajo";
            this.ColGrupotrabajo.Visible = true;
            this.ColGrupotrabajo.VisibleIndex = 1;
            this.ColGrupotrabajo.Width = 507;
            // 
            // ColSubgrupotrabajo
            // 
            this.ColSubgrupotrabajo.Caption = "SubGrupo Trabajo";
            this.ColSubgrupotrabajo.FieldName = "NombreSubgrupo";
            this.ColSubgrupotrabajo.Name = "ColSubgrupotrabajo";
            this.ColSubgrupotrabajo.Visible = true;
            this.ColSubgrupotrabajo.VisibleIndex = 2;
            this.ColSubgrupotrabajo.Width = 705;
            // 
            // ColCheck
            // 
            this.ColCheck.Caption = "*";
            this.ColCheck.FieldName = "check";
            this.ColCheck.Name = "ColCheck";
            this.ColCheck.Visible = true;
            this.ColCheck.VisibleIndex = 0;
            this.ColCheck.Width = 42;
            // 
            // FrmPrd_AsignarGT_P_ProductivoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 464);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_AsignarGT_P_ProductivoMantenimiento";
            this.Text = "Asignar Grupo de trabajo a Proceso Productivo";
            this.Load += new System.EventHandler(this.FrmPrd_AsignarGT_P_ProductivoMantenimiento_Load);
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbEtapas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProcesoProductivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubgrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubgrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit CmbProcesoProductivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GridLookUpEdit CmbEtapas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelGrid;
        private DevExpress.XtraGrid.GridControl gridControlSubgrupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSubgrupos;
        private DevExpress.XtraGrid.Columns.GridColumn ColGrupotrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn ColSubgrupotrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn ColCheck;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProcesoProductivo;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
    }
}