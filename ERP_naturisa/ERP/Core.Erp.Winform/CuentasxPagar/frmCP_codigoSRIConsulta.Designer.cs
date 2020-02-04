namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_codigoSRIConsulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_tipo_codigo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlSRI = new DevExpress.XtraGrid.GridControl();
            this.gridViewSRI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colco_f_valides_desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_f_valides_hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_codigoBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_porRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pn_tipo_codigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 40);
            this.panel1.TabIndex = 3;
            // 
            // pn_tipo_codigo
            // 
            this.pn_tipo_codigo.Location = new System.Drawing.Point(97, 6);
            this.pn_tipo_codigo.Name = "pn_tipo_codigo";
            this.pn_tipo_codigo.Size = new System.Drawing.Size(254, 28);
            this.pn_tipo_codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Codigo SRI:";
            // 
            // gridControlSRI
            // 
            this.gridControlSRI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSRI.Location = new System.Drawing.Point(0, 0);
            this.gridControlSRI.MainView = this.gridViewSRI;
            this.gridControlSRI.Name = "gridControlSRI";
            this.gridControlSRI.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControlSRI.Size = new System.Drawing.Size(986, 348);
            this.gridControlSRI.TabIndex = 3;
            this.gridControlSRI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSRI});
            // 
            // gridViewSRI
            // 
            this.gridViewSRI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colco_f_valides_desde,
            this.colco_f_valides_hasta,
            this.colIdTipoSRI,
            this.colcodigoSRI,
            this.colco_codigoBase,
            this.colco_descripcion,
            this.colco_porRetencion,
            this.colco_estado,
            this.colIdCtaCble,
            this.colIdCodigo_SRI});
            this.gridViewSRI.GridControl = this.gridControlSRI;
            this.gridViewSRI.Name = "gridViewSRI";
            this.gridViewSRI.OptionsBehavior.Editable = false;
            this.gridViewSRI.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewSRI.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSRI.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewSRI_RowCellStyle);
            this.gridViewSRI.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSRI_FocusedRowChanged);
            // 
            // colco_f_valides_desde
            // 
            this.colco_f_valides_desde.Caption = "Vigente Desde";
            this.colco_f_valides_desde.FieldName = "FecValiDesde";
            this.colco_f_valides_desde.Name = "colco_f_valides_desde";
            this.colco_f_valides_desde.Visible = true;
            this.colco_f_valides_desde.VisibleIndex = 0;
            this.colco_f_valides_desde.Width = 138;
            // 
            // colco_f_valides_hasta
            // 
            this.colco_f_valides_hasta.Caption = "Vigente Hasta";
            this.colco_f_valides_hasta.FieldName = "FecValiHasta";
            this.colco_f_valides_hasta.Name = "colco_f_valides_hasta";
            this.colco_f_valides_hasta.Visible = true;
            this.colco_f_valides_hasta.VisibleIndex = 1;
            this.colco_f_valides_hasta.Width = 138;
            // 
            // colIdTipoSRI
            // 
            this.colIdTipoSRI.Caption = "Tipo Código";
            this.colIdTipoSRI.FieldName = "IdTipoSRI";
            this.colIdTipoSRI.Name = "colIdTipoSRI";
            this.colIdTipoSRI.Visible = true;
            this.colIdTipoSRI.VisibleIndex = 3;
            this.colIdTipoSRI.Width = 133;
            // 
            // colcodigoSRI
            // 
            this.colcodigoSRI.Caption = "Código SRI";
            this.colcodigoSRI.FieldName = "codigoSRI";
            this.colcodigoSRI.Name = "colcodigoSRI";
            this.colcodigoSRI.Visible = true;
            this.colcodigoSRI.VisibleIndex = 4;
            this.colcodigoSRI.Width = 84;
            // 
            // colco_codigoBase
            // 
            this.colco_codigoBase.Caption = "Código Base";
            this.colco_codigoBase.FieldName = "co_codigoBase";
            this.colco_codigoBase.Name = "colco_codigoBase";
            this.colco_codigoBase.Visible = true;
            this.colco_codigoBase.VisibleIndex = 5;
            this.colco_codigoBase.Width = 74;
            // 
            // colco_descripcion
            // 
            this.colco_descripcion.Caption = "Descripción";
            this.colco_descripcion.FieldName = "co_descripcion";
            this.colco_descripcion.Name = "colco_descripcion";
            this.colco_descripcion.Visible = true;
            this.colco_descripcion.VisibleIndex = 6;
            this.colco_descripcion.Width = 327;
            // 
            // colco_porRetencion
            // 
            this.colco_porRetencion.Caption = "% Retención";
            this.colco_porRetencion.FieldName = "co_porRetencion";
            this.colco_porRetencion.Name = "colco_porRetencion";
            this.colco_porRetencion.Visible = true;
            this.colco_porRetencion.VisibleIndex = 7;
            this.colco_porRetencion.Width = 90;
            // 
            // colco_estado
            // 
            this.colco_estado.Caption = "Estado";
            this.colco_estado.FieldName = "co_estado";
            this.colco_estado.Name = "colco_estado";
            this.colco_estado.Visible = true;
            this.colco_estado.VisibleIndex = 8;
            this.colco_estado.Width = 102;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colIdCodigo_SRI
            // 
            this.colIdCodigo_SRI.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI.Name = "colIdCodigo_SRI";
            this.colIdCodigo_SRI.Visible = true;
            this.colIdCodigo_SRI.VisibleIndex = 2;
            this.colIdCodigo_SRI.Width = 94;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 8, 18, 16, 29, 9, 706);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 10, 18, 16, 29, 9, 706);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(986, 93);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 6;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 481);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(986, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlSRI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 348);
            this.panel2.TabIndex = 8;
            // 
            // frmCP_codigoSRIConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmCP_codigoSRIConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Codigo SRI";
            this.Load += new System.EventHandler(this.frmCP_codigo_SRI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_tipo_codigo;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.GridControl gridControlSRI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colco_f_valides_desde;
        private DevExpress.XtraGrid.Columns.GridColumn colco_f_valides_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colco_codigoBase;
        private DevExpress.XtraGrid.Columns.GridColumn colco_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_porRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
    }
}