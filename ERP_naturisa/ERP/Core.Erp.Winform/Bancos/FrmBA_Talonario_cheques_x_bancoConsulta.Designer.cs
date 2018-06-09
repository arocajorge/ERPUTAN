namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Talonario_cheques_x_bancoConsulta
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControltalonario = new DevExpress.XtraGrid.GridControl();
            this.gridViewtalonario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_cheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTipoCbte_cbtecble_Usado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCbteCble_cbtecble_Usado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbImagen_Imprimir = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.cmbImagen_Descargar = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltalonario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewtalonario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControltalonario);
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 395);
            this.panel1.TabIndex = 1;
            // 
            // gridControltalonario
            // 
            this.gridControltalonario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControltalonario.Location = new System.Drawing.Point(0, 33);
            this.gridControltalonario.MainView = this.gridViewtalonario;
            this.gridControltalonario.Name = "gridControltalonario";
            this.gridControltalonario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbImagen_Imprimir,
            this.cmbImagen_Descargar});
            this.gridControltalonario.Size = new System.Drawing.Size(730, 359);
            this.gridControltalonario.TabIndex = 0;
            this.gridControltalonario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewtalonario});
            // 
            // gridViewtalonario
            // 
            this.gridViewtalonario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsado,
            this.colIdEmpresa,
            this.colBanco,
            this.colNum_cheque,
            this.colsecuencia,
            this.colEstado,
            this.IdTipoCbte_cbtecble_Usado,
            this.IdCbteCble_cbtecble_Usado});
            this.gridViewtalonario.GridControl = this.gridControltalonario;
            this.gridViewtalonario.Name = "gridViewtalonario";
            this.gridViewtalonario.OptionsBehavior.Editable = false;
            this.gridViewtalonario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewtalonario.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewtalonario_RowClick);
            this.gridViewtalonario.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewtalonario_RowCellStyle);
            this.gridViewtalonario.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewtalonario_FocusedRowChanged);
            // 
            // colUsado
            // 
            this.colUsado.FieldName = "Usado";
            this.colUsado.Name = "colUsado";
            this.colUsado.OptionsColumn.AllowEdit = false;
            this.colUsado.OptionsColumn.AllowSize = false;
            this.colUsado.Visible = true;
            this.colUsado.VisibleIndex = 3;
            this.colUsado.Width = 102;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 65;
            // 
            // colBanco
            // 
            this.colBanco.Caption = "Banco";
            this.colBanco.FieldName = "ba_descripcion";
            this.colBanco.Name = "colBanco";
            this.colBanco.Visible = true;
            this.colBanco.VisibleIndex = 0;
            this.colBanco.Width = 316;
            // 
            // colNum_cheque
            // 
            this.colNum_cheque.Caption = "Num_cheque";
            this.colNum_cheque.FieldName = "Num_cheque";
            this.colNum_cheque.Name = "colNum_cheque";
            this.colNum_cheque.Visible = true;
            this.colNum_cheque.VisibleIndex = 1;
            this.colNum_cheque.Width = 316;
            // 
            // colsecuencia
            // 
            this.colsecuencia.Caption = "secuencia";
            this.colsecuencia.FieldName = "secuencia";
            this.colsecuencia.Name = "colsecuencia";
            this.colsecuencia.Visible = true;
            this.colsecuencia.VisibleIndex = 2;
            this.colsecuencia.Width = 226;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.AllowSize = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 133;
            // 
            // IdTipoCbte_cbtecble_Usado
            // 
            this.IdTipoCbte_cbtecble_Usado.Caption = "IdTipoCbte_cbtecble_Usado";
            this.IdTipoCbte_cbtecble_Usado.FieldName = "IdTipoCbte_cbtecble_Usado";
            this.IdTipoCbte_cbtecble_Usado.Name = "IdTipoCbte_cbtecble_Usado";
            this.IdTipoCbte_cbtecble_Usado.Visible = true;
            this.IdTipoCbte_cbtecble_Usado.VisibleIndex = 6;
            // 
            // IdCbteCble_cbtecble_Usado
            // 
            this.IdCbteCble_cbtecble_Usado.Caption = "IdCbteCble_cbtecble_Usado";
            this.IdCbteCble_cbtecble_Usado.FieldName = "IdCbteCble_cbtecble_Usado";
            this.IdCbteCble_cbtecble_Usado.Name = "IdCbteCble_cbtecble_Usado";
            this.IdCbteCble_cbtecble_Usado.Visible = true;
            this.IdCbteCble_cbtecble_Usado.VisibleIndex = 5;
            // 
            // cmbImagen_Imprimir
            // 
            this.cmbImagen_Imprimir.AutoHeight = false;
            this.cmbImagen_Imprimir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Imprimir.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmbImagen_Imprimir.Name = "cmbImagen_Imprimir";
            // 
            // cmbImagen_Descargar
            // 
            this.cmbImagen_Descargar.AutoHeight = false;
            this.cmbImagen_Descargar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImagen_Descargar.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 1)});
            this.cmbImagen_Descargar.Name = "cmbImagen_Descargar";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = false;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 2, 10, 9, 48, 18, 920);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 4, 10, 9, 48, 18, 920);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(730, 116);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // FrmBA_Talonario_cheques_x_bancoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 500);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmBA_Talonario_cheques_x_bancoConsulta";
            this.Text = "FrmBA_Talonario_cheques_x_bancoConsulta";
            this.Load += new System.EventHandler(this.FrmBA_Talonario_cheques_x_bancoConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControltalonario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewtalonario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImagen_Descargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControltalonario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewtalonario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_cheque;
        private DevExpress.XtraGrid.Columns.GridColumn colsecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Imprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbImagen_Descargar;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn IdCbteCble_cbtecble_Usado;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoCbte_cbtecble_Usado;
    }
}