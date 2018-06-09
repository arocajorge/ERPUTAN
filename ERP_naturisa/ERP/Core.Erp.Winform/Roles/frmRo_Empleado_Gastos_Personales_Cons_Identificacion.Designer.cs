namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Empleado_Gastos_Personales_Cons_Identificacion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridCargaFam = new DevExpress.XtraGrid.GridControl();
            this.roCargaFamiliarInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCafa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoFamiliar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryParentezco = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colca_descripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditNombres = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditCedula = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Sexo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.tbCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Sexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCargaFamiliar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemCheckEditEstado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargaFam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roCargaFamiliarInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCafa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryParentezco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucGe_Menu);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 279);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridCargaFam);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(734, 229);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Identificación del Familiar";
            // 
            // gridCargaFam
            // 
            this.gridCargaFam.DataSource = this.roCargaFamiliarInfoBindingSource;
            this.gridCargaFam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCargaFam.Location = new System.Drawing.Point(3, 16);
            this.gridCargaFam.MainView = this.gridViewCafa;
            this.gridCargaFam.Name = "gridCargaFam";
            this.gridCargaFam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryParentezco,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEditCedula,
            this.repositoryItemTextEditNombres,
            this.repositoryItemCheckEditEstado,
            this.cmb_Sexo});
            this.gridCargaFam.Size = new System.Drawing.Size(728, 210);
            this.gridCargaFam.TabIndex = 12;
            this.gridCargaFam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCafa});
            // 
            // roCargaFamiliarInfoBindingSource
            // 
            this.roCargaFamiliarInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_CargaFamiliar_Info);
            // 
            // gridViewCafa
            // 
            this.gridViewCafa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoFamiliar,
            this.colNombres,
            this.colCedula,
            this.colFechaNacimiento,
            this.colSexo,
            this.colEstado1,
            this.colIdCargaFamiliar,
            this.colIdEmpleado,
            this.colIdEmpresa});
            this.gridViewCafa.CustomizationFormBounds = new System.Drawing.Rectangle(610, 411, 216, 178);
            this.gridViewCafa.GridControl = this.gridCargaFam;
            this.gridViewCafa.Name = "gridViewCafa";
            this.gridViewCafa.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewCafa.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCafa.OptionsView.ShowGroupPanel = false;
            this.gridViewCafa.OptionsView.ShowIndicator = false;
            this.gridViewCafa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTipoFamiliar, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCafa.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCafa_RowCellClick);
            this.gridViewCafa.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewCafa_CellValueChanged);
            this.gridViewCafa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewCafa_KeyDown);
            // 
            // colTipoFamiliar
            // 
            this.colTipoFamiliar.Caption = "Parentezco";
            this.colTipoFamiliar.ColumnEdit = this.repositoryParentezco;
            this.colTipoFamiliar.FieldName = "TipoFamiliar";
            this.colTipoFamiliar.Name = "colTipoFamiliar";
            this.colTipoFamiliar.Visible = true;
            this.colTipoFamiliar.VisibleIndex = 0;
            this.colTipoFamiliar.Width = 121;
            // 
            // repositoryParentezco
            // 
            this.repositoryParentezco.AutoHeight = false;
            this.repositoryParentezco.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryParentezco.DisplayMember = "ca_descripcion";
            this.repositoryParentezco.Name = "repositoryParentezco";
            this.repositoryParentezco.ValueMember = "CodCatalogo";
            this.repositoryParentezco.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_descripcion1});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colca_descripcion1
            // 
            this.colca_descripcion1.Caption = "Elija la Relación:";
            this.colca_descripcion1.FieldName = "ca_descripcion";
            this.colca_descripcion1.Name = "colca_descripcion1";
            this.colca_descripcion1.Visible = true;
            this.colca_descripcion1.VisibleIndex = 0;
            // 
            // colNombres
            // 
            this.colNombres.Caption = "Nombres";
            this.colNombres.ColumnEdit = this.repositoryItemTextEditNombres;
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 1;
            this.colNombres.Width = 251;
            // 
            // repositoryItemTextEditNombres
            // 
            this.repositoryItemTextEditNombres.AutoHeight = false;
            this.repositoryItemTextEditNombres.Mask.EditMask = "[A-Z]{200}";
            this.repositoryItemTextEditNombres.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEditNombres.Name = "repositoryItemTextEditNombres";
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cédula/Ruc";
            this.colCedula.ColumnEdit = this.repositoryItemTextEditCedula;
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 2;
            this.colCedula.Width = 113;
            // 
            // repositoryItemTextEditCedula
            // 
            this.repositoryItemTextEditCedula.AutoHeight = false;
            this.repositoryItemTextEditCedula.Mask.EditMask = "[+]?[0-9]?{13}?";
            this.repositoryItemTextEditCedula.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEditCedula.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEditCedula.Name = "repositoryItemTextEditCedula";
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.Caption = "Fecha Nacimiento";
            this.colFechaNacimiento.FieldName = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Visible = true;
            this.colFechaNacimiento.VisibleIndex = 3;
            // 
            // colSexo
            // 
            this.colSexo.Caption = "Sexo";
            this.colSexo.ColumnEdit = this.cmb_Sexo;
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 4;
            this.colSexo.Width = 91;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.AutoHeight = false;
            this.cmb_Sexo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Sexo.DataSource = this.tbCatalogoInfoBindingSource;
            this.cmb_Sexo.DisplayMember = "ca_descripcion";
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.ValueMember = "CodCatalogo";
            this.cmb_Sexo.View = this.gridView_Sexo;
            // 
            // tbCatalogoInfoBindingSource
            // 
            this.tbCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Catalogo_Info);
            // 
            // gridView_Sexo
            // 
            this.gridView_Sexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colca_descripcion,
            this.colCodCatalogo,
            this.colIdTipoCatalogo,
            this.colIdCatalogo});
            this.gridView_Sexo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_Sexo.Name = "gridView_Sexo";
            this.gridView_Sexo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_Sexo.OptionsView.ShowGroupPanel = false;
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Sexo";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 0;
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.FieldName = "CodCatalogo";
            this.colCodCatalogo.Name = "colCodCatalogo";
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colEstado1
            // 
            this.colEstado1.Caption = "Estado";
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.OptionsColumn.AllowEdit = false;
            this.colEstado1.Visible = true;
            this.colEstado1.VisibleIndex = 5;
            // 
            // colIdCargaFamiliar
            // 
            this.colIdCargaFamiliar.FieldName = "IdCargaFamiliar";
            this.colIdCargaFamiliar.Name = "colIdCargaFamiliar";
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemCheckEditEstado
            // 
            this.repositoryItemCheckEditEstado.AutoHeight = false;
            this.repositoryItemCheckEditEstado.Name = "repositoryItemCheckEditEstado";
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
            this.ucGe_Menu.Location = new System.Drawing.Point(3, 16);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(734, 29);
            this.ucGe_Menu.TabIndex = 71;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
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
            // 
            // frmRo_Empleado_Gastos_Personales_Cons_Identificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(740, 279);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRo_Empleado_Gastos_Personales_Cons_Identificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargas Familiares - Gastos Personales por Identificación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Empleado_Gastos_Personales_Cons_Identificacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCargaFam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roCargaFamiliarInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCafa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryParentezco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridCargaFam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCafa;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoFamiliar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryParentezco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private System.Windows.Forms.BindingSource roCargaFamiliarInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargaFamiliar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditNombres;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditCedula;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Sexo;
        private System.Windows.Forms.BindingSource tbCatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Sexo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;


    }
}