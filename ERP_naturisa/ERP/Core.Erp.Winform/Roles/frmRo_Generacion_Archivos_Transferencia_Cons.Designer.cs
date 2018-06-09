namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generacion_Archivos_Transferencia_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRo_Generacion_Archivos_Transferencia_Cons));
            this.gridControlTransferencia = new DevExpress.XtraGrid.GridControl();
            this.roArchivosBancosGeneracionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTransferencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Nomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdProceso_Bancario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Descripcion_Division = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roArchivosBancosGeneracionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlTransferencia
            // 
            this.gridControlTransferencia.DataSource = this.roArchivosBancosGeneracionInfoBindingSource;
            this.gridControlTransferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTransferencia.Location = new System.Drawing.Point(0, 157);
            this.gridControlTransferencia.MainView = this.gridViewTransferencia;
            this.gridControlTransferencia.Name = "gridControlTransferencia";
            this.gridControlTransferencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlTransferencia.Size = new System.Drawing.Size(840, 200);
            this.gridControlTransferencia.TabIndex = 1;
            this.gridControlTransferencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransferencia});
            // 
            // roArchivosBancosGeneracionInfoBindingSource
            // 
            this.roArchivosBancosGeneracionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Archivos_Bancos_Generacion_Info);
            // 
            // gridViewTransferencia
            // 
            this.gridViewTransferencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdArchivo,
            this.Col_Nomina,
            this.Col_IdProceso_Bancario,
            this.Col_Descripcion_Division,
            this.Col_pe_FechaIni,
            this.Col_Valor,
            this.Col_Proceso});
            this.gridViewTransferencia.GridControl = this.gridControlTransferencia;
            this.gridViewTransferencia.Name = "gridViewTransferencia";
            this.gridViewTransferencia.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTransferencia.OptionsView.ShowFooter = true;
            this.gridViewTransferencia.OptionsView.ShowGroupPanel = false;
            this.gridViewTransferencia.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewTransferencia_RowCellClick);
            // 
            // Col_IdArchivo
            // 
            this.Col_IdArchivo.Caption = "Id";
            this.Col_IdArchivo.FieldName = "IdArchivo";
            this.Col_IdArchivo.Name = "Col_IdArchivo";
            this.Col_IdArchivo.Visible = true;
            this.Col_IdArchivo.VisibleIndex = 0;
            this.Col_IdArchivo.Width = 62;
            // 
            // Col_Nomina
            // 
            this.Col_Nomina.Caption = "Nomina";
            this.Col_Nomina.FieldName = "Descripcion";
            this.Col_Nomina.Name = "Col_Nomina";
            this.Col_Nomina.Visible = true;
            this.Col_Nomina.VisibleIndex = 1;
            this.Col_Nomina.Width = 109;
            // 
            // Col_IdProceso_Bancario
            // 
            this.Col_IdProceso_Bancario.Caption = "Proceso";
            this.Col_IdProceso_Bancario.FieldName = "IdProceso_Bancario";
            this.Col_IdProceso_Bancario.Name = "Col_IdProceso_Bancario";
            this.Col_IdProceso_Bancario.Visible = true;
            this.Col_IdProceso_Bancario.VisibleIndex = 5;
            this.Col_IdProceso_Bancario.Width = 179;
            // 
            // Col_Descripcion_Division
            // 
            this.Col_Descripcion_Division.Caption = "Division";
            this.Col_Descripcion_Division.FieldName = "Descripcion_Division";
            this.Col_Descripcion_Division.Name = "Col_Descripcion_Division";
            this.Col_Descripcion_Division.Visible = true;
            this.Col_Descripcion_Division.VisibleIndex = 3;
            this.Col_Descripcion_Division.Width = 179;
            // 
            // Col_pe_FechaIni
            // 
            this.Col_pe_FechaIni.Caption = "Periodo";
            this.Col_pe_FechaIni.FieldName = "Periodo";
            this.Col_pe_FechaIni.Name = "Col_pe_FechaIni";
            this.Col_pe_FechaIni.Visible = true;
            this.Col_pe_FechaIni.VisibleIndex = 4;
            this.Col_pe_FechaIni.Width = 179;
            // 
            // Col_Valor
            // 
            this.Col_Valor.Caption = "Total Archivo";
            this.Col_Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Valor.Visible = true;
            this.Col_Valor.VisibleIndex = 6;
            this.Col_Valor.Width = 193;
            // 
            // Col_Proceso
            // 
            this.Col_Proceso.Caption = "Proceso";
            this.Col_Proceso.FieldName = "DescripcionProcesoNomina";
            this.Col_Proceso.Name = "Col_Proceso";
            this.Col_Proceso.Visible = true;
            this.Col_Proceso.VisibleIndex = 2;
            this.Col_Proceso.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.InitialImage = null;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1386190665_176652.ico");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 157);
            this.panel2.TabIndex = 3;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 5, 15, 16, 27, 8, 494);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 7, 15, 16, 27, 8, 494);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(840, 154);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmRo_Generacion_Archivos_Transferencia_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 379);
            this.Controls.Add(this.gridControlTransferencia);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "frmRo_Generacion_Archivos_Transferencia_Cons";
            this.Text = "Consulta - Generación de Transferencia de Archivos ";
            this.Load += new System.EventHandler(this.frmRo_Generacion_Archivos_Transferencia_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roArchivosBancosGeneracionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTransferencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransferencia;
        private System.Windows.Forms.BindingSource roArchivosBancosGeneracionInfoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Nomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion_Division;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdProceso_Bancario;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdArchivo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Proceso;
    }
}