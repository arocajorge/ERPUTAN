namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Administrador_Reporte
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGe_Administrador_Reporte));
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.cmb_image = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridControl_Report = new DevExpress.XtraGrid.GridControl();
            this.gridViewReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodReporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCorto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreProcedureRpt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTablaRpt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass_NomReporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_imagenes = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            this.colCodReporte = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNombre = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNombreCorto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModulo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStoreProcedureRpt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTablaRpt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFormulario = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOrden = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colClass_NomReporte = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colicon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // cmb_image
            // 
            this.cmb_image.Name = "cmb_image";
            // 
            // gridControl_Report
            // 
            this.gridControl_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Report.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Report.MainView = this.gridViewReport;
            this.gridControl_Report.Name = "gridControl_Report";
            this.gridControl_Report.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_imagenes});
            this.gridControl_Report.Size = new System.Drawing.Size(779, 311);
            this.gridControl_Report.TabIndex = 68;
            this.gridControl_Report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReport});
            this.gridControl_Report.Click += new System.EventHandler(this.gridControl_Report_Click);
            // 
            // gridViewReport
            // 
            this.gridViewReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodReporte1,
            this.colNombre1,
            this.colNombreCorto1,
            this.colModulo1,
            this.colStoreProcedureRpt1,
            this.colTablaRpt1,
            this.colFormulario1,
            this.colOrden1,
            this.colClass_NomReporte1,
            this.colObservacion1,
            this.colImagen});
            this.gridViewReport.GridControl = this.gridControl_Report;
            this.gridViewReport.Name = "gridViewReport";
            this.gridViewReport.OptionsDetail.AutoZoomDetail = true;
            this.gridViewReport.OptionsDetail.SmartDetailHeight = true;
            this.gridViewReport.OptionsView.RowAutoHeight = true;
            this.gridViewReport.OptionsView.ShowAutoFilterRow = true;
            this.gridViewReport.OptionsView.ShowGroupPanel = false;
            this.gridViewReport.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewReport_RowCellClick);
            this.gridViewReport.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewReport_FocusedRowChanged);
            this.gridViewReport.DoubleClick += new System.EventHandler(this.gridViewReport_DoubleClick);
            // 
            // colCodReporte1
            // 
            this.colCodReporte1.FieldName = "CodReporte";
            this.colCodReporte1.Name = "colCodReporte1";
            this.colCodReporte1.OptionsColumn.AllowEdit = false;
            this.colCodReporte1.Visible = true;
            this.colCodReporte1.VisibleIndex = 0;
            this.colCodReporte1.Width = 127;
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.OptionsColumn.AllowEdit = false;
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 2;
            this.colNombre1.Width = 320;
            // 
            // colNombreCorto1
            // 
            this.colNombreCorto1.FieldName = "NombreCorto";
            this.colNombreCorto1.Name = "colNombreCorto1";
            this.colNombreCorto1.OptionsColumn.AllowEdit = false;
            this.colNombreCorto1.Width = 131;
            // 
            // colModulo1
            // 
            this.colModulo1.FieldName = "Modulo";
            this.colModulo1.Name = "colModulo1";
            this.colModulo1.OptionsColumn.AllowEdit = false;
            this.colModulo1.Width = 33;
            // 
            // colStoreProcedureRpt1
            // 
            this.colStoreProcedureRpt1.FieldName = "StoreProcedureRpt";
            this.colStoreProcedureRpt1.Name = "colStoreProcedureRpt1";
            this.colStoreProcedureRpt1.OptionsColumn.AllowEdit = false;
            // 
            // colTablaRpt1
            // 
            this.colTablaRpt1.FieldName = "TablaRpt";
            this.colTablaRpt1.Name = "colTablaRpt1";
            this.colTablaRpt1.OptionsColumn.AllowEdit = false;
            // 
            // colFormulario1
            // 
            this.colFormulario1.FieldName = "Formulario";
            this.colFormulario1.Name = "colFormulario1";
            this.colFormulario1.OptionsColumn.AllowEdit = false;
            // 
            // colOrden1
            // 
            this.colOrden1.FieldName = "Orden";
            this.colOrden1.Name = "colOrden1";
            this.colOrden1.OptionsColumn.AllowEdit = false;
            // 
            // colClass_NomReporte1
            // 
            this.colClass_NomReporte1.FieldName = "Class_NomReporte";
            this.colClass_NomReporte1.Name = "colClass_NomReporte1";
            this.colClass_NomReporte1.OptionsColumn.AllowEdit = false;
            // 
            // colObservacion1
            // 
            this.colObservacion1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colObservacion1.FieldName = "Observacion";
            this.colObservacion1.Name = "colObservacion1";
            this.colObservacion1.OptionsColumn.AllowEdit = false;
            this.colObservacion1.Visible = true;
            this.colObservacion1.VisibleIndex = 3;
            this.colObservacion1.Width = 256;
            // 
            // colImagen
            // 
            this.colImagen.Caption = "*";
            this.colImagen.ColumnEdit = this.cmb_imagenes;
            this.colImagen.FieldName = "Se_Muestra_Icono";
            this.colImagen.Name = "colImagen";
            this.colImagen.OptionsColumn.AllowEdit = false;
            this.colImagen.Visible = true;
            this.colImagen.VisibleIndex = 1;
            this.colImagen.Width = 58;
            // 
            // cmb_imagenes
            // 
            this.cmb_imagenes.AutoHeight = false;
            this.cmb_imagenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagenes.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmb_imagenes.LargeImages = this.imageCollection1;
            this.cmb_imagenes.Name = "cmb_imagenes";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "report_grafico_128x128.png");
            // 
            // colCodReporte
            // 
            this.colCodReporte.FieldName = "CodReporte";
            this.colCodReporte.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCodReporte.Name = "colCodReporte";
            this.colCodReporte.OptionsColumn.AllowEdit = false;
            this.colCodReporte.Visible = true;
            this.colCodReporte.Width = 76;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.Width = 138;
            // 
            // colNombreCorto
            // 
            this.colNombreCorto.FieldName = "NombreCorto";
            this.colNombreCorto.Name = "colNombreCorto";
            this.colNombreCorto.OptionsColumn.AllowEdit = false;
            this.colNombreCorto.Visible = true;
            this.colNombreCorto.Width = 102;
            // 
            // colModulo
            // 
            this.colModulo.FieldName = "Modulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.OptionsColumn.AllowEdit = false;
            this.colModulo.Visible = true;
            this.colModulo.Width = 155;
            // 
            // colStoreProcedureRpt
            // 
            this.colStoreProcedureRpt.FieldName = "StoreProcedureRpt";
            this.colStoreProcedureRpt.Name = "colStoreProcedureRpt";
            this.colStoreProcedureRpt.OptionsColumn.AllowEdit = false;
            this.colStoreProcedureRpt.Visible = true;
            this.colStoreProcedureRpt.Width = 105;
            // 
            // colTablaRpt
            // 
            this.colTablaRpt.FieldName = "TablaRpt";
            this.colTablaRpt.Name = "colTablaRpt";
            this.colTablaRpt.OptionsColumn.AllowEdit = false;
            this.colTablaRpt.Visible = true;
            this.colTablaRpt.Width = 105;
            // 
            // colFormulario
            // 
            this.colFormulario.FieldName = "Formulario";
            this.colFormulario.Name = "colFormulario";
            this.colFormulario.OptionsColumn.AllowEdit = false;
            this.colFormulario.Visible = true;
            this.colFormulario.Width = 105;
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            this.colOrden.OptionsColumn.AllowEdit = false;
            this.colOrden.Visible = true;
            this.colOrden.Width = 65;
            // 
            // colClass_NomReporte
            // 
            this.colClass_NomReporte.FieldName = "Class_NomReporte";
            this.colClass_NomReporte.Name = "colClass_NomReporte";
            this.colClass_NomReporte.OptionsColumn.AllowEdit = false;
            this.colClass_NomReporte.Visible = true;
            this.colClass_NomReporte.Width = 103;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.Width = 155;
            // 
            // colicon
            // 
            this.colicon.Caption = "Ver";
            this.colicon.FieldName = "icon";
            this.colicon.Name = "colicon";
            this.colicon.Visible = true;
            this.colicon.Width = 39;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colCodReporte);
            this.gridBand1.Columns.Add(this.colNombre);
            this.gridBand1.Columns.Add(this.colNombreCorto);
            this.gridBand1.Columns.Add(this.colModulo);
            this.gridBand1.Columns.Add(this.colStoreProcedureRpt);
            this.gridBand1.Columns.Add(this.colTablaRpt);
            this.gridBand1.Columns.Add(this.colFormulario);
            this.gridBand1.Columns.Add(this.colOrden);
            this.gridBand1.Columns.Add(this.colClass_NomReporte);
            this.gridBand1.Columns.Add(this.colObservacion);
            this.gridBand1.Columns.Add(this.colicon);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 1148;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 311);
            this.panel1.TabIndex = 70;
            // 
            // UCGe_Administrador_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCGe_Administrador_Reporte";
            this.Size = new System.Drawing.Size(779, 336);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Report;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReport;
        private DevExpress.XtraGrid.Columns.GridColumn colCodReporte1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCorto1;
        private DevExpress.XtraGrid.Columns.GridColumn colModulo1;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreProcedureRpt1;
        private DevExpress.XtraGrid.Columns.GridColumn colTablaRpt1;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulario1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden1;
        private DevExpress.XtraGrid.Columns.GridColumn colClass_NomReporte1;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCodReporte;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNombre;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNombreCorto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModulo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStoreProcedureRpt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTablaRpt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFormulario;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOrden;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colClass_NomReporte;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colObservacion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colicon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit cmb_image;
        private DevExpress.XtraGrid.Columns.GridColumn colImagen;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagenes;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.Panel panel1;
    }
}
