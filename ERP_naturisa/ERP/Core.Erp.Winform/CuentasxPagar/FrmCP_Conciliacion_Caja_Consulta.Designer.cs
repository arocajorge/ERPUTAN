namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Conciliacion_Caja_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCP_Conciliacion_Caja_Consulta));
            this.gridControl_ConciCaja = new DevExpress.XtraGrid.GridControl();
            this.gridView_ConciCaja = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdConciliacion_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_pagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenPago_op = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hacer_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_ingreso_img = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ConciCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ConciCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ingreso_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_ConciCaja
            // 
            this.gridControl_ConciCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ConciCaja.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ConciCaja.MainView = this.gridView_ConciCaja;
            this.gridControl_ConciCaja.Name = "gridControl_ConciCaja";
            this.gridControl_ConciCaja.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_ingreso_img});
            this.gridControl_ConciCaja.Size = new System.Drawing.Size(968, 256);
            this.gridControl_ConciCaja.TabIndex = 8;
            this.gridControl_ConciCaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ConciCaja,
            this.gridView1});
            // 
            // gridView_ConciCaja
            // 
            this.gridView_ConciCaja.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCaja,
            this.colIdConciliacion_Caja,
            this.colca_Descripcion,
            this.colIdUsuario_Responsable,
            this.colFecha,
            this.colValor_pagado,
            this.colnom_Caja,
            this.colnom_Estado,
            this.colIdOrdenPago_op,
            this.ColIdPeriodo,
            this.ColIdCtaCble,
            this.col_hacer_ingreso,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView_ConciCaja.GridControl = this.gridControl_ConciCaja;
            this.gridView_ConciCaja.Images = this.imageList1;
            this.gridView_ConciCaja.Name = "gridView_ConciCaja";
            this.gridView_ConciCaja.OptionsView.ShowAutoFilterRow = true;
            this.gridView_ConciCaja.OptionsView.ShowGroupPanel = false;
            this.gridView_ConciCaja.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdConciliacion_Caja, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView_ConciCaja.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_ConciCaja_RowCellClick);
            this.gridView_ConciCaja.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_ConciCaja_RowCellStyle);
            this.gridView_ConciCaja.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_ConciCaja_FocusedRowChanged);
            // 
            // colIdCaja
            // 
            this.colIdCaja.Caption = "Id Caja";
            this.colIdCaja.FieldName = "IdCaja";
            this.colIdCaja.Name = "colIdCaja";
            this.colIdCaja.OptionsColumn.AllowEdit = false;
            this.colIdCaja.OptionsColumn.ReadOnly = true;
            this.colIdCaja.Width = 47;
            // 
            // colIdConciliacion_Caja
            // 
            this.colIdConciliacion_Caja.Caption = "# Conciliación Caja";
            this.colIdConciliacion_Caja.FieldName = "IdConciliacion_Caja";
            this.colIdConciliacion_Caja.Name = "colIdConciliacion_Caja";
            this.colIdConciliacion_Caja.OptionsColumn.AllowEdit = false;
            this.colIdConciliacion_Caja.OptionsColumn.ReadOnly = true;
            this.colIdConciliacion_Caja.Visible = true;
            this.colIdConciliacion_Caja.VisibleIndex = 0;
            this.colIdConciliacion_Caja.Width = 83;
            // 
            // colca_Descripcion
            // 
            this.colca_Descripcion.Caption = "Observación";
            this.colca_Descripcion.FieldName = "Observacion";
            this.colca_Descripcion.Name = "colca_Descripcion";
            this.colca_Descripcion.OptionsColumn.AllowEdit = false;
            this.colca_Descripcion.OptionsColumn.ReadOnly = true;
            this.colca_Descripcion.Visible = true;
            this.colca_Descripcion.VisibleIndex = 8;
            this.colca_Descripcion.Width = 194;
            // 
            // colIdUsuario_Responsable
            // 
            this.colIdUsuario_Responsable.Caption = "Usuario Responsable";
            this.colIdUsuario_Responsable.FieldName = "IdUsuario_Responsable";
            this.colIdUsuario_Responsable.Name = "colIdUsuario_Responsable";
            this.colIdUsuario_Responsable.OptionsColumn.ReadOnly = true;
            this.colIdUsuario_Responsable.Width = 61;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.OptionsColumn.ReadOnly = true;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 92;
            // 
            // colValor_pagado
            // 
            this.colValor_pagado.Caption = "Valor Pagado";
            this.colValor_pagado.DisplayFormat.FormatString = "n2";
            this.colValor_pagado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor_pagado.FieldName = "Valor_pagado";
            this.colValor_pagado.Name = "colValor_pagado";
            this.colValor_pagado.OptionsColumn.AllowEdit = false;
            this.colValor_pagado.OptionsColumn.ReadOnly = true;
            this.colValor_pagado.Visible = true;
            this.colValor_pagado.VisibleIndex = 5;
            this.colValor_pagado.Width = 92;
            // 
            // colnom_Caja
            // 
            this.colnom_Caja.Caption = "Caja";
            this.colnom_Caja.FieldName = "nom_Caja";
            this.colnom_Caja.Name = "colnom_Caja";
            this.colnom_Caja.OptionsColumn.AllowEdit = false;
            this.colnom_Caja.OptionsColumn.ReadOnly = true;
            this.colnom_Caja.Visible = true;
            this.colnom_Caja.VisibleIndex = 1;
            this.colnom_Caja.Width = 235;
            // 
            // colnom_Estado
            // 
            this.colnom_Estado.Caption = "Estado";
            this.colnom_Estado.FieldName = "nom_Estado";
            this.colnom_Estado.Name = "colnom_Estado";
            this.colnom_Estado.OptionsColumn.AllowEdit = false;
            this.colnom_Estado.OptionsColumn.ReadOnly = true;
            this.colnom_Estado.Visible = true;
            this.colnom_Estado.VisibleIndex = 6;
            this.colnom_Estado.Width = 90;
            // 
            // colIdOrdenPago_op
            // 
            this.colIdOrdenPago_op.Caption = "# OP";
            this.colIdOrdenPago_op.FieldName = "IdOrdenPago_op";
            this.colIdOrdenPago_op.Name = "colIdOrdenPago_op";
            this.colIdOrdenPago_op.OptionsColumn.AllowEdit = false;
            this.colIdOrdenPago_op.OptionsColumn.ReadOnly = true;
            this.colIdOrdenPago_op.Visible = true;
            this.colIdOrdenPago_op.VisibleIndex = 7;
            this.colIdOrdenPago_op.Width = 58;
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "IdPeriodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.OptionsColumn.AllowEdit = false;
            this.ColIdPeriodo.OptionsColumn.ReadOnly = true;
            this.ColIdPeriodo.Width = 57;
            // 
            // ColIdCtaCble
            // 
            this.ColIdCtaCble.Caption = "IdCtaCble";
            this.ColIdCtaCble.FieldName = "IdCtaCble";
            this.ColIdCtaCble.Name = "ColIdCtaCble";
            this.ColIdCtaCble.OptionsColumn.AllowEdit = false;
            this.ColIdCtaCble.OptionsColumn.ReadOnly = true;
            this.ColIdCtaCble.Width = 56;
            // 
            // col_hacer_ingreso
            // 
            this.col_hacer_ingreso.Caption = "*";
            this.col_hacer_ingreso.ColumnEdit = this.cmb_ingreso_img;
            this.col_hacer_ingreso.FieldName = "IdCbteCble_mov_caj";
            this.col_hacer_ingreso.Name = "col_hacer_ingreso";
            this.col_hacer_ingreso.Visible = true;
            this.col_hacer_ingreso.VisibleIndex = 10;
            this.col_hacer_ingreso.Width = 44;
            // 
            // cmb_ingreso_img
            // 
            this.cmb_ingreso_img.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_ingreso_img.AutoHeight = false;
            this.cmb_ingreso_img.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ingreso_img.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", null, 0)});
            this.cmb_ingreso_img.Name = "cmb_ingreso_img";
            this.cmb_ingreso_img.ReadOnly = true;
            this.cmb_ingreso_img.SmallImages = this.imageList1;
            this.cmb_ingreso_img.Click += new System.EventHandler(this.cmb_ingreso_img_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1388723697_1710.ico");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Cbte ing";
            this.gridColumn1.FieldName = "IdCbteCble_mov_caj";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 92;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_ConciCaja;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 156);
            this.panel1.TabIndex = 11;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 2, 22, 8, 40, 54, 228);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 4, 22, 8, 40, 54, 228);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(968, 156);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 412);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(968, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_ConciCaja);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 256);
            this.panel2.TabIndex = 13;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha inicio";
            this.gridColumn2.FieldName = "Fecha_ini";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha fin";
            this.gridColumn3.FieldName = "Fecha_fin";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 102;
            // 
            // frmCP_Conciliacion_Caja_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCP_Conciliacion_Caja_Consulta";
            this.Text = "Consulta Conciliación de Caja";
            this.Load += new System.EventHandler(this.FrmCP_Conciliacion_Caja_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ConciCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ConciCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ingreso_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_ConciCaja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ConciCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdConciliacion_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Responsable;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_pagado;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenPago_op;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_hacer_ingreso;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_ingreso_img;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}