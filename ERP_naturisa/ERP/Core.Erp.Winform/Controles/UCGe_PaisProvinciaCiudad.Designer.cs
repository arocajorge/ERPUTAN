namespace Core.Erp.Winform.Controles
{
    partial class UCGe_PaisProvinciaCiudad
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGe_PaisProvinciaCiudad));
            this.cmbProvincia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPais1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPais = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNacionalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPais = new DevExpress.XtraEditors.LabelControl();
            this.lblProvincia = new DevExpress.XtraEditors.LabelControl();
            this.lblCiudad = new DevExpress.XtraEditors.LabelControl();
            this.cmbCiudad = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProvincia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Acciones = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones_Pais = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoPais = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPais = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPais = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.cmb_Acciones_provi = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones_Provincia = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProvinica = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProvincia = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones_ciudad = new DevExpress.XtraEditors.DropDownButton();
            this.MenuAcciones_Ciudad = new System.Windows.Forms.ContextMenuStrip();
            this.nuevoCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Acciones_parroquia = new DevExpress.XtraEditors.DropDownButton();
            this.cmbParroquia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdParroquia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_parroquia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_parroquia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCiudad_Canton_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblParroquia = new DevExpress.XtraEditors.LabelControl();
            this.MenuAcciones_Parroquia = new System.Windows.Forms.ContextMenuStrip();
            this.nueva_parroquia = new System.Windows.Forms.ToolStripMenuItem();
            this.modificar_parroquia = new System.Windows.Forms.ToolStripMenuItem();
            this.consultar_parroquia = new System.Windows.Forms.ToolStripMenuItem();
            this.panelParroquia = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCiudad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.MenuAcciones_Pais.SuspendLayout();
            this.MenuAcciones_Provincia.SuspendLayout();
            this.MenuAcciones_Ciudad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbParroquia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.MenuAcciones_Parroquia.SuspendLayout();
            this.panelParroquia.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProvincia.Location = new System.Drawing.Point(87, 35);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProvincia.Properties.DisplayMember = "Descripcion";
            this.cmbProvincia.Properties.ValueMember = "IdProvincia";
            this.cmbProvincia.Properties.View = this.gridView1;
            this.cmbProvincia.Size = new System.Drawing.Size(311, 20);
            this.cmbProvincia.TabIndex = 35;
            this.cmbProvincia.EditValueChanged += new System.EventHandler(this.cmbProvincia_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProvincia,
            this.colCodProvincia,
            this.colDescripcion,
            this.colEstado1,
            this.colIdPais1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProvincia
            // 
            this.colIdProvincia.FieldName = "IdProvincia";
            this.colIdProvincia.Name = "colIdProvincia";
            this.colIdProvincia.OptionsColumn.AllowEdit = false;
            this.colIdProvincia.Visible = true;
            this.colIdProvincia.VisibleIndex = 0;
            // 
            // colCodProvincia
            // 
            this.colCodProvincia.FieldName = "CodProvincia";
            this.colCodProvincia.Name = "colCodProvincia";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            // 
            // colIdPais1
            // 
            this.colIdPais1.FieldName = "IdPais";
            this.colIdPais1.Name = "colIdPais1";
            // 
            // cmbPais
            // 
            this.cmbPais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPais.Location = new System.Drawing.Point(86, 3);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPais.Properties.DisplayMember = "Nombre";
            this.cmbPais.Properties.ValueMember = "IdPais";
            this.cmbPais.Properties.View = this.searchLookUpEdit1View;
            this.cmbPais.Size = new System.Drawing.Size(313, 20);
            this.cmbPais.TabIndex = 34;
            this.cmbPais.EditValueChanged += new System.EventHandler(this.cmbPais_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPais,
            this.colCodPais,
            this.colNombre,
            this.colNacionalidad,
            this.colEstado});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNacionalidad, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdPais
            // 
            this.colIdPais.FieldName = "IdPais";
            this.colIdPais.Name = "colIdPais";
            this.colIdPais.OptionsColumn.AllowEdit = false;
            this.colIdPais.Visible = true;
            this.colIdPais.VisibleIndex = 0;
            // 
            // colCodPais
            // 
            this.colCodPais.FieldName = "CodPais";
            this.colCodPais.Name = "colCodPais";
            this.colCodPais.OptionsColumn.AllowEdit = false;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Descripción";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colNacionalidad
            // 
            this.colNacionalidad.FieldName = "Nacionalidad";
            this.colNacionalidad.Name = "colNacionalidad";
            this.colNacionalidad.OptionsColumn.AllowEdit = false;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            // 
            // lblPais
            // 
            this.lblPais.Location = new System.Drawing.Point(7, 6);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(23, 13);
            this.lblPais.TabIndex = 33;
            this.lblPais.Text = "Pais:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.Location = new System.Drawing.Point(7, 32);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(47, 13);
            this.lblProvincia.TabIndex = 32;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.Location = new System.Drawing.Point(7, 64);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(76, 13);
            this.lblCiudad.TabIndex = 31;
            this.lblCiudad.Text = "Ciudad/Canton:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCiudad.Location = new System.Drawing.Point(87, 66);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCiudad.Properties.DisplayMember = "Descripcion";
            this.cmbCiudad.Properties.ValueMember = "IdCiudad";
            this.cmbCiudad.Properties.View = this.gridView2;
            this.cmbCiudad.Size = new System.Drawing.Size(313, 20);
            this.cmbCiudad.TabIndex = 36;
            this.cmbCiudad.EditValueChanged += new System.EventHandler(this.cmbCiudad_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCiudad,
            this.colCodCiudad,
            this.colDescripcion1,
            this.colEstado2,
            this.colIdProvincia1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCiudad
            // 
            this.colIdCiudad.Caption = "Id Ciudad";
            this.colIdCiudad.FieldName = "IdCiudad";
            this.colIdCiudad.Name = "colIdCiudad";
            this.colIdCiudad.Visible = true;
            this.colIdCiudad.VisibleIndex = 0;
            this.colIdCiudad.Width = 129;
            // 
            // colCodCiudad
            // 
            this.colCodCiudad.FieldName = "CodCiudad";
            this.colCodCiudad.Name = "colCodCiudad";
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripción";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 693;
            // 
            // colEstado2
            // 
            this.colEstado2.FieldName = "Estado";
            this.colEstado2.Name = "colEstado2";
            // 
            // colIdProvincia1
            // 
            this.colIdProvincia1.FieldName = "IdProvincia";
            this.colIdProvincia1.Name = "colIdProvincia1";
            // 
            // cmb_Acciones
            // 
            this.cmb_Acciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones.ContextMenuStrip = this.MenuAcciones_Pais;
            this.cmb_Acciones.ImageIndex = 1;
            this.cmb_Acciones.ImageList = this.imageList1;
            this.cmb_Acciones.Location = new System.Drawing.Point(408, 3);
            this.cmb_Acciones.Name = "cmb_Acciones";
            this.cmb_Acciones.ShowArrowButton = false;
            this.cmb_Acciones.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones.TabIndex = 111;
            this.cmb_Acciones.Click += new System.EventHandler(this.cmb_Acciones_Click);
            // 
            // MenuAcciones_Pais
            // 
            this.MenuAcciones_Pais.AllowDrop = true;
            this.MenuAcciones_Pais.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPais,
            this.modificarPais,
            this.consultarPais});
            this.MenuAcciones_Pais.Name = "MenuAcciones";
            this.MenuAcciones_Pais.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones_Pais.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones_Pais.Text = "Acciones";
            // 
            // nuevoPais
            // 
            this.nuevoPais.Image = ((System.Drawing.Image)(resources.GetObject("nuevoPais.Image")));
            this.nuevoPais.Name = "nuevoPais";
            this.nuevoPais.Size = new System.Drawing.Size(125, 22);
            this.nuevoPais.Text = "Nuevo";
            this.nuevoPais.Click += new System.EventHandler(this.nuevoPais_Click);
            // 
            // modificarPais
            // 
            this.modificarPais.Image = ((System.Drawing.Image)(resources.GetObject("modificarPais.Image")));
            this.modificarPais.Name = "modificarPais";
            this.modificarPais.Size = new System.Drawing.Size(125, 22);
            this.modificarPais.Text = "Modificar";
            this.modificarPais.Click += new System.EventHandler(this.modificarPais_Click);
            // 
            // consultarPais
            // 
            this.consultarPais.Image = ((System.Drawing.Image)(resources.GetObject("consultarPais.Image")));
            this.consultarPais.Name = "consultarPais";
            this.consultarPais.Size = new System.Drawing.Size(125, 22);
            this.consultarPais.Text = "Consultar";
            this.consultarPais.Click += new System.EventHandler(this.consultarPais_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empleado.ico");
            this.imageList1.Images.SetKeyName(1, "nuevo_32x32.png");
            this.imageList1.Images.SetKeyName(2, "admin_32x32.png");
            this.imageList1.Images.SetKeyName(3, "downloads1.ico");
            this.imageList1.Images.SetKeyName(4, "ico_insert1.png");
            // 
            // cmb_Acciones_provi
            // 
            this.cmb_Acciones_provi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones_provi.ContextMenuStrip = this.MenuAcciones_Provincia;
            this.cmb_Acciones_provi.ImageIndex = 1;
            this.cmb_Acciones_provi.ImageList = this.imageList1;
            this.cmb_Acciones_provi.Location = new System.Drawing.Point(408, 32);
            this.cmb_Acciones_provi.Name = "cmb_Acciones_provi";
            this.cmb_Acciones_provi.ShowArrowButton = false;
            this.cmb_Acciones_provi.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones_provi.TabIndex = 112;
            this.cmb_Acciones_provi.Click += new System.EventHandler(this.cmb_Acciones_provi_Click);
            // 
            // MenuAcciones_Provincia
            // 
            this.MenuAcciones_Provincia.AllowDrop = true;
            this.MenuAcciones_Provincia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProvincia,
            this.modificarProvinica,
            this.consultarProvincia});
            this.MenuAcciones_Provincia.Name = "MenuAcciones";
            this.MenuAcciones_Provincia.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones_Provincia.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones_Provincia.Text = "Acciones";
            // 
            // nuevoProvincia
            // 
            this.nuevoProvincia.Image = ((System.Drawing.Image)(resources.GetObject("nuevoProvincia.Image")));
            this.nuevoProvincia.Name = "nuevoProvincia";
            this.nuevoProvincia.Size = new System.Drawing.Size(125, 22);
            this.nuevoProvincia.Text = "Nuevo";
            this.nuevoProvincia.Click += new System.EventHandler(this.nuevoProvincia_Click);
            // 
            // modificarProvinica
            // 
            this.modificarProvinica.Image = ((System.Drawing.Image)(resources.GetObject("modificarProvinica.Image")));
            this.modificarProvinica.Name = "modificarProvinica";
            this.modificarProvinica.Size = new System.Drawing.Size(125, 22);
            this.modificarProvinica.Text = "Modificar";
            this.modificarProvinica.Click += new System.EventHandler(this.modificarProvinica_Click);
            // 
            // consultarProvincia
            // 
            this.consultarProvincia.Image = ((System.Drawing.Image)(resources.GetObject("consultarProvincia.Image")));
            this.consultarProvincia.Name = "consultarProvincia";
            this.consultarProvincia.Size = new System.Drawing.Size(125, 22);
            this.consultarProvincia.Text = "Consultar";
            this.consultarProvincia.Click += new System.EventHandler(this.consultarProvincia_Click);
            // 
            // cmb_Acciones_ciudad
            // 
            this.cmb_Acciones_ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones_ciudad.ContextMenuStrip = this.MenuAcciones_Ciudad;
            this.cmb_Acciones_ciudad.ImageIndex = 1;
            this.cmb_Acciones_ciudad.ImageList = this.imageList1;
            this.cmb_Acciones_ciudad.Location = new System.Drawing.Point(408, 64);
            this.cmb_Acciones_ciudad.Name = "cmb_Acciones_ciudad";
            this.cmb_Acciones_ciudad.ShowArrowButton = false;
            this.cmb_Acciones_ciudad.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones_ciudad.TabIndex = 113;
            this.cmb_Acciones_ciudad.Click += new System.EventHandler(this.cmb_Acciones_ciudad_Click);
            // 
            // MenuAcciones_Ciudad
            // 
            this.MenuAcciones_Ciudad.AllowDrop = true;
            this.MenuAcciones_Ciudad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCiudad,
            this.modificarCiudad,
            this.consultarCiudad});
            this.MenuAcciones_Ciudad.Name = "MenuAcciones";
            this.MenuAcciones_Ciudad.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones_Ciudad.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones_Ciudad.Text = "Acciones";
            // 
            // nuevoCiudad
            // 
            this.nuevoCiudad.Image = ((System.Drawing.Image)(resources.GetObject("nuevoCiudad.Image")));
            this.nuevoCiudad.Name = "nuevoCiudad";
            this.nuevoCiudad.Size = new System.Drawing.Size(125, 22);
            this.nuevoCiudad.Text = "Nuevo";
            this.nuevoCiudad.Click += new System.EventHandler(this.nuevoCiudad_Click);
            // 
            // modificarCiudad
            // 
            this.modificarCiudad.Image = ((System.Drawing.Image)(resources.GetObject("modificarCiudad.Image")));
            this.modificarCiudad.Name = "modificarCiudad";
            this.modificarCiudad.Size = new System.Drawing.Size(125, 22);
            this.modificarCiudad.Text = "Modificar";
            this.modificarCiudad.Click += new System.EventHandler(this.modificarCiudad_Click);
            // 
            // consultarCiudad
            // 
            this.consultarCiudad.Image = ((System.Drawing.Image)(resources.GetObject("consultarCiudad.Image")));
            this.consultarCiudad.Name = "consultarCiudad";
            this.consultarCiudad.Size = new System.Drawing.Size(125, 22);
            this.consultarCiudad.Text = "Consultar";
            this.consultarCiudad.Click += new System.EventHandler(this.consultarCiudad_Click);
            // 
            // cmb_Acciones_parroquia
            // 
            this.cmb_Acciones_parroquia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Acciones_parroquia.ContextMenuStrip = this.MenuAcciones_Ciudad;
            this.cmb_Acciones_parroquia.ImageIndex = 1;
            this.cmb_Acciones_parroquia.ImageList = this.imageList1;
            this.cmb_Acciones_parroquia.Location = new System.Drawing.Point(399, 2);
            this.cmb_Acciones_parroquia.Name = "cmb_Acciones_parroquia";
            this.cmb_Acciones_parroquia.ShowArrowButton = false;
            this.cmb_Acciones_parroquia.Size = new System.Drawing.Size(36, 26);
            this.cmb_Acciones_parroquia.TabIndex = 116;
            this.cmb_Acciones_parroquia.Click += new System.EventHandler(this.cmb_Acciones_parroquia_Click);
            // 
            // cmbParroquia
            // 
            this.cmbParroquia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbParroquia.Location = new System.Drawing.Point(80, 3);
            this.cmbParroquia.Name = "cmbParroquia";
            this.cmbParroquia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbParroquia.Properties.DisplayMember = "nom_parroquia";
            this.cmbParroquia.Properties.ValueMember = "IdParroquia";
            this.cmbParroquia.Properties.View = this.gridView3;
            this.cmbParroquia.Size = new System.Drawing.Size(313, 20);
            this.cmbParroquia.TabIndex = 115;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdParroquia,
            this.colcod_parroquia,
            this.colnom_parroquia,
            this.colIdCiudad_Canton_});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdParroquia
            // 
            this.colIdParroquia.Caption = "IdParroquia";
            this.colIdParroquia.FieldName = "IdParroquia";
            this.colIdParroquia.Name = "colIdParroquia";
            this.colIdParroquia.Visible = true;
            this.colIdParroquia.VisibleIndex = 1;
            this.colIdParroquia.Width = 129;
            // 
            // colcod_parroquia
            // 
            this.colcod_parroquia.Caption = "cod_parroquia";
            this.colcod_parroquia.FieldName = "cod_parroquia";
            this.colcod_parroquia.Name = "colcod_parroquia";
            // 
            // colnom_parroquia
            // 
            this.colnom_parroquia.Caption = "Parroquia";
            this.colnom_parroquia.FieldName = "nom_parroquia";
            this.colnom_parroquia.Name = "colnom_parroquia";
            this.colnom_parroquia.Visible = true;
            this.colnom_parroquia.VisibleIndex = 0;
            this.colnom_parroquia.Width = 693;
            // 
            // colIdCiudad_Canton_
            // 
            this.colIdCiudad_Canton_.Caption = "IdCiudad_Canton";
            this.colIdCiudad_Canton_.FieldName = "IdCiudad_Canton";
            this.colIdCiudad_Canton_.Name = "colIdCiudad_Canton_";
            // 
            // lblParroquia
            // 
            this.lblParroquia.Location = new System.Drawing.Point(2, 1);
            this.lblParroquia.Name = "lblParroquia";
            this.lblParroquia.Size = new System.Drawing.Size(50, 13);
            this.lblParroquia.TabIndex = 114;
            this.lblParroquia.Text = "Parroquia:";
            // 
            // MenuAcciones_Parroquia
            // 
            this.MenuAcciones_Parroquia.AllowDrop = true;
            this.MenuAcciones_Parroquia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nueva_parroquia,
            this.modificar_parroquia,
            this.consultar_parroquia});
            this.MenuAcciones_Parroquia.Name = "MenuAcciones";
            this.MenuAcciones_Parroquia.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuAcciones_Parroquia.Size = new System.Drawing.Size(126, 70);
            this.MenuAcciones_Parroquia.Text = "Acciones";
            // 
            // nueva_parroquia
            // 
            this.nueva_parroquia.Image = ((System.Drawing.Image)(resources.GetObject("nueva_parroquia.Image")));
            this.nueva_parroquia.Name = "nueva_parroquia";
            this.nueva_parroquia.Size = new System.Drawing.Size(125, 22);
            this.nueva_parroquia.Text = "Nuevo";
            this.nueva_parroquia.Click += new System.EventHandler(this.nueva_parroquia_Click);
            // 
            // modificar_parroquia
            // 
            this.modificar_parroquia.Image = ((System.Drawing.Image)(resources.GetObject("modificar_parroquia.Image")));
            this.modificar_parroquia.Name = "modificar_parroquia";
            this.modificar_parroquia.Size = new System.Drawing.Size(125, 22);
            this.modificar_parroquia.Text = "Modificar";
            this.modificar_parroquia.Click += new System.EventHandler(this.modificar_parroquia_Click);
            // 
            // consultar_parroquia
            // 
            this.consultar_parroquia.Image = ((System.Drawing.Image)(resources.GetObject("consultar_parroquia.Image")));
            this.consultar_parroquia.Name = "consultar_parroquia";
            this.consultar_parroquia.Size = new System.Drawing.Size(125, 22);
            this.consultar_parroquia.Text = "Consultar";
            this.consultar_parroquia.Click += new System.EventHandler(this.consultar_parroquia_Click);
            // 
            // panelParroquia
            // 
            this.panelParroquia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParroquia.Controls.Add(this.cmbParroquia);
            this.panelParroquia.Controls.Add(this.lblParroquia);
            this.panelParroquia.Controls.Add(this.cmb_Acciones_parroquia);
            this.panelParroquia.Location = new System.Drawing.Point(7, 92);
            this.panelParroquia.Name = "panelParroquia";
            this.panelParroquia.Size = new System.Drawing.Size(442, 31);
            this.panelParroquia.TabIndex = 117;
            // 
            // UCGe_PaisProvinciaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelParroquia);
            this.Controls.Add(this.cmb_Acciones_ciudad);
            this.Controls.Add(this.cmb_Acciones_provi);
            this.Controls.Add(this.cmb_Acciones);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblCiudad);
            this.Name = "UCGe_PaisProvinciaCiudad";
            this.Size = new System.Drawing.Size(452, 132);
            this.Load += new System.EventHandler(this.UCGe_PaisProvinciaCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCiudad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.MenuAcciones_Pais.ResumeLayout(false);
            this.MenuAcciones_Provincia.ResumeLayout(false);
            this.MenuAcciones_Ciudad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbParroquia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.MenuAcciones_Parroquia.ResumeLayout(false);
            this.panelParroquia.ResumeLayout(false);
            this.panelParroquia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais;
        private DevExpress.XtraGrid.Columns.GridColumn colCodPais;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNacionalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.LabelControl lblPais;
        private DevExpress.XtraEditors.LabelControl lblProvincia;
        private DevExpress.XtraEditors.LabelControl lblCiudad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCiudad;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProvincia1;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbProvincia;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbPais;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbCiudad;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones_provi;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones_ciudad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones_Pais;
        private System.Windows.Forms.ToolStripMenuItem nuevoPais;
        private System.Windows.Forms.ToolStripMenuItem modificarPais;
        private System.Windows.Forms.ToolStripMenuItem consultarPais;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones_Provincia;
        private System.Windows.Forms.ToolStripMenuItem nuevoProvincia;
        private System.Windows.Forms.ToolStripMenuItem modificarProvinica;
        private System.Windows.Forms.ToolStripMenuItem consultarProvincia;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones_Ciudad;
        private System.Windows.Forms.ToolStripMenuItem nuevoCiudad;
        private System.Windows.Forms.ToolStripMenuItem modificarCiudad;
        private System.Windows.Forms.ToolStripMenuItem consultarCiudad;
        private DevExpress.XtraEditors.DropDownButton cmb_Acciones_parroquia;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbParroquia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParroquia;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_parroquia;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_parroquia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCiudad_Canton_;
        private DevExpress.XtraEditors.LabelControl lblParroquia;
        private System.Windows.Forms.ContextMenuStrip MenuAcciones_Parroquia;
        private System.Windows.Forms.ToolStripMenuItem nueva_parroquia;
        private System.Windows.Forms.ToolStripMenuItem modificar_parroquia;
        private System.Windows.Forms.ToolStripMenuItem consultar_parroquia;
        private System.Windows.Forms.Panel panelParroquia;
    }
}
