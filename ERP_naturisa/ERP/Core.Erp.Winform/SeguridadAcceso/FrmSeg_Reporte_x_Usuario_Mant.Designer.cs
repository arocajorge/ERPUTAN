namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Reporte_x_Usuario_Mant
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkTodo = new System.Windows.Forms.CheckBox();
            this.cmb_usuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblusuario = new System.Windows.Forms.Label();
            this.gridControlReporte = new DevExpress.XtraGrid.GridControl();
            this.gridViewReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodReporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVistaRpt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(948, 29);
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
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
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
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 474);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(948, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 445);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkTodo);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_usuario);
            this.splitContainer1.Panel1.Controls.Add(this.lblusuario);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlReporte);
            this.splitContainer1.Size = new System.Drawing.Size(948, 445);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkTodo
            // 
            this.chkTodo.AutoSize = true;
            this.chkTodo.Location = new System.Drawing.Point(65, 43);
            this.chkTodo.Name = "chkTodo";
            this.chkTodo.Size = new System.Drawing.Size(110, 17);
            this.chkTodo.TabIndex = 2;
            this.chkTodo.Text = "Seleccionar Todo";
            this.chkTodo.UseVisualStyleBackColor = true;
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.Location = new System.Drawing.Point(65, 17);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_usuario.Properties.DisplayMember = "IdUsuario";
            this.cmb_usuario.Properties.ValueMember = "IdUsuario";
            this.cmb_usuario.Properties.View = this.searchLookUpEdit1View;
            this.cmb_usuario.Size = new System.Drawing.Size(284, 20);
            this.cmb_usuario.TabIndex = 1;
            this.cmb_usuario.EditValueChanged += new System.EventHandler(this.cmb_usuario_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre1,
            this.colIdUsuario});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre1
            // 
            this.colNombre1.Caption = "Nombre";
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 1;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.Caption = "IdUsuario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(13, 20);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario:";
            // 
            // gridControlReporte
            // 
            this.gridControlReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReporte.Location = new System.Drawing.Point(0, 0);
            this.gridControlReporte.MainView = this.gridViewReporte;
            this.gridControlReporte.Name = "gridControlReporte";
            this.gridControlReporte.Size = new System.Drawing.Size(948, 379);
            this.gridControlReporte.TabIndex = 0;
            this.gridControlReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReporte});
            this.gridControlReporte.Click += new System.EventHandler(this.gridControlReporte_Click);
            // 
            // gridViewReporte
            // 
            this.gridViewReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodReporte,
            this.colNombre,
            this.colModulo,
            this.colObservacion,
            this.colVistaRpt,
            this.colFormulario,
            this.colCheked});
            this.gridViewReporte.GridControl = this.gridControlReporte;
            this.gridViewReporte.GroupCount = 1;
            this.gridViewReporte.Name = "gridViewReporte";
            this.gridViewReporte.OptionsFind.AlwaysVisible = true;
            this.gridViewReporte.OptionsView.ShowAutoFilterRow = true;
            this.gridViewReporte.OptionsView.ShowGroupPanel = false;
            this.gridViewReporte.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colModulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodReporte
            // 
            this.colCodReporte.Caption = "CodReporte";
            this.colCodReporte.FieldName = "CodReporte";
            this.colCodReporte.Name = "colCodReporte";
            this.colCodReporte.OptionsColumn.AllowEdit = false;
            this.colCodReporte.Visible = true;
            this.colCodReporte.VisibleIndex = 1;
            this.colCodReporte.Width = 84;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "InfoReporte.Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 384;
            // 
            // colModulo
            // 
            this.colModulo.Caption = "Modulo";
            this.colModulo.FieldName = "InfoReporte.Modulo";
            this.colModulo.Name = "colModulo";
            this.colModulo.OptionsColumn.AllowEdit = false;
            this.colModulo.Visible = true;
            this.colModulo.VisibleIndex = 3;
            this.colModulo.Width = 146;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observacion";
            this.colObservacion.FieldName = "InfoReporte.Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 67;
            // 
            // colVistaRpt
            // 
            this.colVistaRpt.Caption = "VistaRpt";
            this.colVistaRpt.FieldName = "InfoReporte.VistaRpt";
            this.colVistaRpt.Name = "colVistaRpt";
            this.colVistaRpt.OptionsColumn.AllowEdit = false;
            this.colVistaRpt.Visible = true;
            this.colVistaRpt.VisibleIndex = 4;
            this.colVistaRpt.Width = 67;
            // 
            // colFormulario
            // 
            this.colFormulario.Caption = "Formulario";
            this.colFormulario.FieldName = "InfoReporte.Formulario";
            this.colFormulario.Name = "colFormulario";
            this.colFormulario.OptionsColumn.AllowEdit = false;
            this.colFormulario.Visible = true;
            this.colFormulario.VisibleIndex = 5;
            this.colFormulario.Width = 74;
            // 
            // colCheked
            // 
            this.colCheked.Caption = "*";
            this.colCheked.FieldName = "InfoReporte.esta_en_base";
            this.colCheked.Name = "colCheked";
            this.colCheked.Visible = true;
            this.colCheked.VisibleIndex = 0;
            this.colCheked.Width = 41;
            // 
            // FrmSeg_Reporte_x_Usuario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmSeg_Reporte_x_Usuario_Mant";
            this.Text = "FrmSeg_Reporte_x_Usuario_Mant";
            this.Load += new System.EventHandler(this.FrmSeg_Reporte_x_Usuario_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_usuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label lblusuario;
        private DevExpress.XtraGrid.GridControl gridControlReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colCodReporte;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colVistaRpt;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn colCheked;
        private System.Windows.Forms.CheckBox chkTodo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
    }
}