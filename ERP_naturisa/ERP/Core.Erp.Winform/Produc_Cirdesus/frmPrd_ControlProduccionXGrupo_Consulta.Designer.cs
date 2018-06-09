namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class frmPrd_ControlProduccionXGrupo_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrd_ControlProduccionXGrupo_Consulta));
            this.prdControlProduccionObreroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.Panelfiltro = new System.Windows.Forms.Panel();
            this.BtnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.dtpFFin = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFInicio = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.LbGrupotrabajo = new System.Windows.Forms.Label();
            this.CmbGrupoTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CollIdGrupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coolDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColNom_grupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreProcesoProductivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoolNombreEtapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoolNombreProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaHoraInicioFabricacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaHoraFinFabricacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTiempoDuroPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.prdControlProduccionObreroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.panel2.SuspendLayout();
            this.Panelfiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGrupoTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // prdControlProduccionObreroInfoBindingSource
            // 
            this.prdControlProduccionObreroInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.prd_ControlProduccionObrero_Info);
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ucGe_Menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 28);
            this.panel2.TabIndex = 20;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(982, 29);
            this.ucGe_Menu.TabIndex = 21;
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
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // Panelfiltro
            // 
            this.Panelfiltro.Controls.Add(this.BtnBuscar);
            this.Panelfiltro.Controls.Add(this.dtpFFin);
            this.Panelfiltro.Controls.Add(this.label12);
            this.Panelfiltro.Controls.Add(this.dtpFInicio);
            this.Panelfiltro.Controls.Add(this.label11);
            this.Panelfiltro.Controls.Add(this.LbGrupotrabajo);
            this.Panelfiltro.Controls.Add(this.CmbGrupoTrabajo);
            this.Panelfiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelfiltro.Location = new System.Drawing.Point(0, 28);
            this.Panelfiltro.Name = "Panelfiltro";
            this.Panelfiltro.Size = new System.Drawing.Size(984, 40);
            this.Panelfiltro.TabIndex = 21;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBuscar.Image = global::Core.Erp.Winform.Properties.Resources.ventas_icono_64x64;
            this.BtnBuscar.Location = new System.Drawing.Point(909, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 40);
            this.BtnBuscar.TabIndex = 87;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtpFFin
            // 
            this.dtpFFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFFin.Location = new System.Drawing.Point(620, 12);
            this.dtpFFin.Name = "dtpFFin";
            this.dtpFFin.Size = new System.Drawing.Size(151, 20);
            this.dtpFFin.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Hasta:";
            // 
            // dtpFInicio
            // 
            this.dtpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFInicio.Location = new System.Drawing.Point(417, 11);
            this.dtpFInicio.Name = "dtpFInicio";
            this.dtpFInicio.Size = new System.Drawing.Size(151, 20);
            this.dtpFInicio.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Desde:";
            // 
            // LbGrupotrabajo
            // 
            this.LbGrupotrabajo.AutoSize = true;
            this.LbGrupotrabajo.Location = new System.Drawing.Point(3, 11);
            this.LbGrupotrabajo.Name = "LbGrupotrabajo";
            this.LbGrupotrabajo.Size = new System.Drawing.Size(95, 13);
            this.LbGrupotrabajo.TabIndex = 1;
            this.LbGrupotrabajo.Text = "Grupos de Trabajo";
            // 
            // CmbGrupoTrabajo
            // 
            this.CmbGrupoTrabajo.Location = new System.Drawing.Point(104, 8);
            this.CmbGrupoTrabajo.Name = "CmbGrupoTrabajo";
            this.CmbGrupoTrabajo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbGrupoTrabajo.Properties.DisplayMember = "Descripcion";
            this.CmbGrupoTrabajo.Properties.ValueMember = "IdGrupoTrabajo";
            this.CmbGrupoTrabajo.Properties.View = this.gridLookUpEdit1View;
            this.CmbGrupoTrabajo.Size = new System.Drawing.Size(263, 20);
            this.CmbGrupoTrabajo.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CollIdGrupoTrabajo,
            this.coolDescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // CollIdGrupoTrabajo
            // 
            this.CollIdGrupoTrabajo.Caption = "Id Grupo";
            this.CollIdGrupoTrabajo.FieldName = "IdGrupoTrabajo";
            this.CollIdGrupoTrabajo.Name = "CollIdGrupoTrabajo";
            this.CollIdGrupoTrabajo.Visible = true;
            this.CollIdGrupoTrabajo.VisibleIndex = 0;
            // 
            // coolDescripcion
            // 
            this.coolDescripcion.Caption = "Nombre Grupo";
            this.coolDescripcion.FieldName = "Descripcion";
            this.coolDescripcion.Name = "coolDescripcion";
            this.coolDescripcion.Visible = true;
            this.coolDescripcion.VisibleIndex = 1;
            this.coolDescripcion.Width = 1105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 290);
            this.panel1.TabIndex = 22;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.prdControlProduccionObreroInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(984, 290);
            this.gridControl.TabIndex = 16;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNom_grupoTrabajo,
            this.ColNombreProcesoProductivo,
            this.CoolNombreEtapa,
            this.CoolNombreProducto,
            this.ColFechaHoraInicioFabricacion,
            this.ColFechaHoraFinFabricacion,
            this.ColTiempoDuroPP});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(956, 364, 216, 185);
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsPrint.PrintHeader = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowViewCaption = true;
            this.gridView.PaintStyleName = "Skin";
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.CoolNombreEtapa, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.ViewCaption = "Lista de Registros del Control de Producción por Grupo";
            // 
            // ColNom_grupoTrabajo
            // 
            this.ColNom_grupoTrabajo.Caption = "Grupo Trabajo";
            this.ColNom_grupoTrabajo.FieldName = "Nom_grupoTrabajo";
            this.ColNom_grupoTrabajo.Name = "ColNom_grupoTrabajo";
            this.ColNom_grupoTrabajo.Visible = true;
            this.ColNom_grupoTrabajo.VisibleIndex = 0;
            this.ColNom_grupoTrabajo.Width = 257;
            // 
            // ColNombreProcesoProductivo
            // 
            this.ColNombreProcesoProductivo.Caption = "Proceso Productivo";
            this.ColNombreProcesoProductivo.FieldName = "NombreProcesoProductivo";
            this.ColNombreProcesoProductivo.Name = "ColNombreProcesoProductivo";
            this.ColNombreProcesoProductivo.Visible = true;
            this.ColNombreProcesoProductivo.VisibleIndex = 1;
            this.ColNombreProcesoProductivo.Width = 212;
            // 
            // CoolNombreEtapa
            // 
            this.CoolNombreEtapa.Caption = "Etapa Producion";
            this.CoolNombreEtapa.FieldName = "NombreEtapa";
            this.CoolNombreEtapa.Name = "CoolNombreEtapa";
            this.CoolNombreEtapa.Visible = true;
            this.CoolNombreEtapa.VisibleIndex = 2;
            this.CoolNombreEtapa.Width = 155;
            // 
            // CoolNombreProducto
            // 
            this.CoolNombreProducto.Caption = "Producto";
            this.CoolNombreProducto.FieldName = "NombreProducto";
            this.CoolNombreProducto.Name = "CoolNombreProducto";
            this.CoolNombreProducto.Visible = true;
            this.CoolNombreProducto.VisibleIndex = 3;
            this.CoolNombreProducto.Width = 177;
            // 
            // ColFechaHoraInicioFabricacion
            // 
            this.ColFechaHoraInicioFabricacion.Caption = "Fec/Hora [Inicio P.P]";
            this.ColFechaHoraInicioFabricacion.FieldName = "FechaHoraInicioFabricacion";
            this.ColFechaHoraInicioFabricacion.Name = "ColFechaHoraInicioFabricacion";
            this.ColFechaHoraInicioFabricacion.Visible = true;
            this.ColFechaHoraInicioFabricacion.VisibleIndex = 4;
            this.ColFechaHoraInicioFabricacion.Width = 121;
            // 
            // ColFechaHoraFinFabricacion
            // 
            this.ColFechaHoraFinFabricacion.Caption = "Fec/Hora [Termino P.P]";
            this.ColFechaHoraFinFabricacion.FieldName = "FechaHoraFinFabricacion";
            this.ColFechaHoraFinFabricacion.Name = "ColFechaHoraFinFabricacion";
            this.ColFechaHoraFinFabricacion.Visible = true;
            this.ColFechaHoraFinFabricacion.VisibleIndex = 5;
            this.ColFechaHoraFinFabricacion.Width = 121;
            // 
            // ColTiempoDuroPP
            // 
            this.ColTiempoDuroPP.Caption = "Tiempo Duro P.P";
            this.ColTiempoDuroPP.FieldName = "TiempoDuroPP";
            this.ColTiempoDuroPP.Name = "ColTiempoDuroPP";
            this.ColTiempoDuroPP.Visible = true;
            this.ColTiempoDuroPP.VisibleIndex = 6;
            this.ColTiempoDuroPP.Width = 137;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Options.UseImage = true;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // frmPrd_ControlProduccionXGrupo_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panelfiltro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmPrd_ControlProduccionXGrupo_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productividad por Grupo de Trabajo";
            this.Load += new System.EventHandler(this.frmPrd_ControlProduccionXGrupo_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdControlProduccionObreroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Panelfiltro.ResumeLayout(false);
            this.Panelfiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbGrupoTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource prdControlProduccionObreroInfoBindingSource;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel Panelfiltro;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit CmbGrupoTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label LbGrupotrabajo;
        private System.Windows.Forms.DateTimePicker dtpFFin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFInicio;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton BtnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn CollIdGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn coolDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColNom_grupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreProcesoProductivo;
        private DevExpress.XtraGrid.Columns.GridColumn CoolNombreEtapa;
        private DevExpress.XtraGrid.Columns.GridColumn CoolNombreProducto;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaHoraInicioFabricacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaHoraFinFabricacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColTiempoDuroPP;
    }
}