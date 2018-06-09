namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlParam_conta_cate = new DevExpress.XtraGrid.GridControl();
            this.gridViewParam_Conta_Cate_ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSubgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_ctaCble = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCtaCble_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Mostrar_relaciones_no_parametrizadas = new System.Windows.Forms.ToolStripButton();
            this.btnMostrar_movimientos = new System.Windows.Forms.ToolStripButton();
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam_conta_cate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam_Conta_Cate_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ctaCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 422);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1201, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlParam_conta_cate);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 422);
            this.panel1.TabIndex = 2;
            // 
            // gridControlParam_conta_cate
            // 
            this.gridControlParam_conta_cate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParam_conta_cate.Location = new System.Drawing.Point(0, 172);
            this.gridControlParam_conta_cate.MainView = this.gridViewParam_Conta_Cate_;
            this.gridControlParam_conta_cate.Name = "gridControlParam_conta_cate";
            this.gridControlParam_conta_cate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_ctaCble});
            this.gridControlParam_conta_cate.Size = new System.Drawing.Size(1201, 250);
            this.gridControlParam_conta_cate.TabIndex = 0;
            this.gridControlParam_conta_cate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParam_Conta_Cate_});
            // 
            // gridViewParam_Conta_Cate_
            // 
            this.gridViewParam_Conta_Cate_.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_categoria,
            this.colnom_linea,
            this.colnom_grupo,
            this.colIdSubgrupo,
            this.colnom_centro_costo,
            this.colnom_sub_centro_costo,
            this.colIdCtaCble});
            this.gridViewParam_Conta_Cate_.GridControl = this.gridControlParam_conta_cate;
            this.gridViewParam_Conta_Cate_.Name = "gridViewParam_Conta_Cate_";
            this.gridViewParam_Conta_Cate_.OptionsView.ShowAutoFilterRow = true;
            this.gridViewParam_Conta_Cate_.OptionsView.ShowGroupPanel = false;
            this.gridViewParam_Conta_Cate_.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewParam_Conta_Cate__CellValueChanged);
            this.gridViewParam_Conta_Cate_.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewParam_Conta_Cate__CellValueChanging);
            // 
            // colnom_categoria
            // 
            this.colnom_categoria.Caption = "Categoria";
            this.colnom_categoria.FieldName = "nom_categoria";
            this.colnom_categoria.Name = "colnom_categoria";
            this.colnom_categoria.OptionsColumn.AllowEdit = false;
            this.colnom_categoria.Visible = true;
            this.colnom_categoria.VisibleIndex = 0;
            this.colnom_categoria.Width = 98;
            // 
            // colnom_linea
            // 
            this.colnom_linea.Caption = "Linea";
            this.colnom_linea.FieldName = "nom_linea";
            this.colnom_linea.Name = "colnom_linea";
            this.colnom_linea.OptionsColumn.AllowEdit = false;
            this.colnom_linea.Visible = true;
            this.colnom_linea.VisibleIndex = 1;
            this.colnom_linea.Width = 123;
            // 
            // colnom_grupo
            // 
            this.colnom_grupo.Caption = "Grupo";
            this.colnom_grupo.FieldName = "nom_grupo";
            this.colnom_grupo.Name = "colnom_grupo";
            this.colnom_grupo.OptionsColumn.AllowEdit = false;
            this.colnom_grupo.Visible = true;
            this.colnom_grupo.VisibleIndex = 2;
            this.colnom_grupo.Width = 125;
            // 
            // colIdSubgrupo
            // 
            this.colIdSubgrupo.Caption = "Subgrupo";
            this.colIdSubgrupo.FieldName = "nom_subgrupo";
            this.colIdSubgrupo.Name = "colIdSubgrupo";
            this.colIdSubgrupo.OptionsColumn.AllowEdit = false;
            this.colIdSubgrupo.Visible = true;
            this.colIdSubgrupo.VisibleIndex = 3;
            this.colIdSubgrupo.Width = 131;
            // 
            // colnom_centro_costo
            // 
            this.colnom_centro_costo.Caption = "Centro Costo";
            this.colnom_centro_costo.FieldName = "nom_centro_costo";
            this.colnom_centro_costo.Name = "colnom_centro_costo";
            this.colnom_centro_costo.OptionsColumn.AllowEdit = false;
            this.colnom_centro_costo.Visible = true;
            this.colnom_centro_costo.VisibleIndex = 4;
            this.colnom_centro_costo.Width = 129;
            // 
            // colnom_sub_centro_costo
            // 
            this.colnom_sub_centro_costo.Caption = "Sub Centro Costo";
            this.colnom_sub_centro_costo.FieldName = "nom_sub_centro_costo";
            this.colnom_sub_centro_costo.Name = "colnom_sub_centro_costo";
            this.colnom_sub_centro_costo.OptionsColumn.AllowEdit = false;
            this.colnom_sub_centro_costo.Visible = true;
            this.colnom_sub_centro_costo.VisibleIndex = 5;
            this.colnom_sub_centro_costo.Width = 127;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "Cta Cble";
            this.colIdCtaCble.ColumnEdit = this.cmb_ctaCble;
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 6;
            this.colIdCtaCble.Width = 401;
            // 
            // cmb_ctaCble
            // 
            this.cmb_ctaCble.AutoHeight = false;
            this.cmb_ctaCble.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ctaCble.DisplayMember = "pc_Cuenta2";
            this.cmb_ctaCble.Name = "cmb_ctaCble";
            this.cmb_ctaCble.ValueMember = "IdCtaCble";
            this.cmb_ctaCble.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCtaCble_1,
            this.colpc_clave_corta,
            this.colpc_Cuenta,
            this.colCuentaPadre});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.RowAutoHeight = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCtaCble_1
            // 
            this.colIdCtaCble_1.Caption = "IdCtaCble";
            this.colIdCtaCble_1.FieldName = "IdCtaCble";
            this.colIdCtaCble_1.Name = "colIdCtaCble_1";
            this.colIdCtaCble_1.Visible = true;
            this.colIdCtaCble_1.VisibleIndex = 0;
            this.colIdCtaCble_1.Width = 205;
            // 
            // colpc_clave_corta
            // 
            this.colpc_clave_corta.Caption = "Clave Corta";
            this.colpc_clave_corta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta.Name = "colpc_clave_corta";
            this.colpc_clave_corta.Visible = true;
            this.colpc_clave_corta.VisibleIndex = 1;
            this.colpc_clave_corta.Width = 158;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "Cuenta";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 2;
            this.colpc_Cuenta.Width = 598;
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.Caption = "CuentaPadre";
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            this.colCuentaPadre.Visible = true;
            this.colCuentaPadre.VisibleIndex = 3;
            this.colCuentaPadre.Width = 219;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMostrar_movimientos,
            this.btn_Mostrar_relaciones_no_parametrizadas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 147);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Mostrar_relaciones_no_parametrizadas
            // 
            this.btn_Mostrar_relaciones_no_parametrizadas.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_docu_16x16;
            this.btn_Mostrar_relaciones_no_parametrizadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Mostrar_relaciones_no_parametrizadas.Name = "btn_Mostrar_relaciones_no_parametrizadas";
            this.btn_Mostrar_relaciones_no_parametrizadas.Size = new System.Drawing.Size(224, 22);
            this.btn_Mostrar_relaciones_no_parametrizadas.Text = "Mostrar relaciones no parametrizadas";
            this.btn_Mostrar_relaciones_no_parametrizadas.Click += new System.EventHandler(this.btn_Mostrar_relaciones_no_parametrizadas_Click);
            // 
            // btnMostrar_movimientos
            // 
            this.btnMostrar_movimientos.Image = global::Core.Erp.Winform.Properties.Resources.buscar;
            this.btnMostrar_movimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrar_movimientos.Name = "btnMostrar_movimientos";
            this.btnMostrar_movimientos.Size = new System.Drawing.Size(144, 22);
            this.btnMostrar_movimientos.Text = "Mostrar movimientos ";
            this.btnMostrar_movimientos.Click += new System.EventHandler(this.btnMostrar_movimientos_Click);
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2016, 10, 22, 11, 23, 36, 799);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2016, 12, 22, 11, 23, 36, 799);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(1201, 147);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 1;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC";
            this.Text = "FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC";
            this.Load += new System.EventHandler(this.FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam_conta_cate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam_Conta_Cate_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ctaCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlParam_conta_cate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParam_Conta_Cate_;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_categoria;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_linea;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSubgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_ctaCble;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Mostrar_relaciones_no_parametrizadas;
        private System.Windows.Forms.ToolStripButton btnMostrar_movimientos;
    }
}