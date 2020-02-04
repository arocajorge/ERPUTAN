namespace Core.Erp.Winform.General
{
    partial class FrmGe_DocuAnuladosConsulta
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
            this.gridControl_DocAnu = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_DocAnu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_DocuTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoDocAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodDocumentoTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_MotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit_tipo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit_motivo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DocAnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_DocAnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_motivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_DocAnu
            // 
            this.gridControl_DocAnu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DocAnu.Location = new System.Drawing.Point(0, 0);
            this.gridControl_DocAnu.MainView = this.UltraGrid_DocAnu;
            this.gridControl_DocAnu.Name = "gridControl_DocAnu";
            this.gridControl_DocAnu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit_tipo,
            this.repositoryItemGridLookUpEdit_motivo});
            this.gridControl_DocAnu.Size = new System.Drawing.Size(806, 213);
            this.gridControl_DocAnu.TabIndex = 6;
            this.gridControl_DocAnu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_DocAnu});
            // 
            // UltraGrid_DocAnu
            // 
            this.UltraGrid_DocAnu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colnom_DocuTipo,
            this.colIdTipoDocAnu,
            this.colFecha,
            this.colSerie,
            this.colcodDocumentoTipo,
            this.colAutorizacion,
            this.colIdMotivoAnu,
            this.colMotivoAnu,
            this.colSerie1,
            this.colSerie2,
            this.colDocumento,
            this.colnom_MotivoAnu});
            this.UltraGrid_DocAnu.GridControl = this.gridControl_DocAnu;
            this.UltraGrid_DocAnu.Name = "UltraGrid_DocAnu";
            this.UltraGrid_DocAnu.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_DocAnu.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_DocAnu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_DocAnu_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colnom_DocuTipo
            // 
            this.colnom_DocuTipo.Caption = "Documento";
            this.colnom_DocuTipo.FieldName = "nom_DocuTipo";
            this.colnom_DocuTipo.Name = "colnom_DocuTipo";
            this.colnom_DocuTipo.OptionsColumn.AllowEdit = false;
            this.colnom_DocuTipo.Visible = true;
            this.colnom_DocuTipo.VisibleIndex = 1;
            this.colnom_DocuTipo.Width = 114;
            // 
            // colIdTipoDocAnu
            // 
            this.colIdTipoDocAnu.Caption = "#Doc. Anu.";
            this.colIdTipoDocAnu.FieldName = "IdTipoDocAnu";
            this.colIdTipoDocAnu.Name = "colIdTipoDocAnu";
            this.colIdTipoDocAnu.OptionsColumn.AllowEdit = false;
            this.colIdTipoDocAnu.Visible = true;
            this.colIdTipoDocAnu.VisibleIndex = 0;
            this.colIdTipoDocAnu.Width = 72;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 6;
            this.colFecha.Width = 64;
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 3;
            this.colSerie.Width = 93;
            // 
            // colcodDocumentoTipo
            // 
            this.colcodDocumentoTipo.FieldName = "codDocumentoTipo";
            this.colcodDocumentoTipo.Name = "colcodDocumentoTipo";
            this.colcodDocumentoTipo.OptionsColumn.AllowEdit = false;
            this.colcodDocumentoTipo.Width = 91;
            // 
            // colAutorizacion
            // 
            this.colAutorizacion.FieldName = "Autorizacion";
            this.colAutorizacion.Name = "colAutorizacion";
            this.colAutorizacion.OptionsColumn.AllowEdit = false;
            this.colAutorizacion.Visible = true;
            this.colAutorizacion.VisibleIndex = 2;
            this.colAutorizacion.Width = 88;
            // 
            // colIdMotivoAnu
            // 
            this.colIdMotivoAnu.FieldName = "IdMotivoAnu";
            this.colIdMotivoAnu.Name = "colIdMotivoAnu";
            this.colIdMotivoAnu.OptionsColumn.AllowEdit = false;
            this.colIdMotivoAnu.Width = 96;
            // 
            // colMotivoAnu
            // 
            this.colMotivoAnu.Caption = "Detalle";
            this.colMotivoAnu.FieldName = "MotivoAnu";
            this.colMotivoAnu.Name = "colMotivoAnu";
            this.colMotivoAnu.OptionsColumn.AllowEdit = false;
            this.colMotivoAnu.Visible = true;
            this.colMotivoAnu.VisibleIndex = 5;
            this.colMotivoAnu.Width = 154;
            // 
            // colSerie1
            // 
            this.colSerie1.FieldName = "Serie1";
            this.colSerie1.Name = "colSerie1";
            // 
            // colSerie2
            // 
            this.colSerie2.FieldName = "Serie2";
            this.colSerie2.Name = "colSerie2";
            // 
            // colDocumento
            // 
            this.colDocumento.Caption = "N° de Documento";
            this.colDocumento.FieldName = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.OptionsColumn.AllowEdit = false;
            this.colDocumento.Visible = true;
            this.colDocumento.VisibleIndex = 4;
            this.colDocumento.Width = 133;
            // 
            // colnom_MotivoAnu
            // 
            this.colnom_MotivoAnu.Caption = "Tipo Motivo Anu";
            this.colnom_MotivoAnu.FieldName = "nom_MotivoAnu";
            this.colnom_MotivoAnu.Name = "colnom_MotivoAnu";
            this.colnom_MotivoAnu.OptionsColumn.AllowEdit = false;
            this.colnom_MotivoAnu.Visible = true;
            this.colnom_MotivoAnu.VisibleIndex = 7;
            this.colnom_MotivoAnu.Width = 70;
            // 
            // repositoryItemGridLookUpEdit_tipo
            // 
            this.repositoryItemGridLookUpEdit_tipo.AutoHeight = false;
            this.repositoryItemGridLookUpEdit_tipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit_tipo.Name = "repositoryItemGridLookUpEdit_tipo";
            this.repositoryItemGridLookUpEdit_tipo.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit_motivo
            // 
            this.repositoryItemGridLookUpEdit_motivo.AutoHeight = false;
            this.repositoryItemGridLookUpEdit_motivo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit_motivo.Name = "repositoryItemGridLookUpEdit_motivo";
            this.repositoryItemGridLookUpEdit_motivo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource
            // 
            this.tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_sis_Documento_Tipo_x_Empresa_Anulados_Info);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 335);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl_DocAnu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 213);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 100);
            this.panel2.TabIndex = 8;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 9, 21, 15, 13, 17, 848);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 11, 21, 15, 13, 17, 848);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(806, 97);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(806, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmGe_DocuAnuladosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 335);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGe_DocuAnuladosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Documentos Anulados";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DocAnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_DocAnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit_motivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_DocAnu;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_DocAnu;
        private System.Windows.Forms.BindingSource tbsisDocumentoTipoxEmpresaAnuladosInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_DocuTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoDocAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colcodDocumentoTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivoAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit_motivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie2;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_MotivoAnu;
    }
}