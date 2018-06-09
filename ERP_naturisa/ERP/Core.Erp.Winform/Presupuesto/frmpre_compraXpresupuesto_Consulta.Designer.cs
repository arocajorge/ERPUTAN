namespace Core.Erp.Winform.Presupuesto
{
    partial class frmpre_compraXpresupuesto_Consulta
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
            this.gridControl_OC = new DevExpress.XtraGrid.GridControl();
            this.preordencompralocalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_OC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit_prov = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.cpproveedorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colro_Dpto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fecha_aprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Aprueba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario_Reprue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fechaReproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaHoraAnul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoRecepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoAnulacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTerminoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondicionPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preordencompralocalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_prov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_OC
            // 
            this.gridControl_OC.DataSource = this.preordencompralocalInfoBindingSource;
            this.gridControl_OC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_OC.Location = new System.Drawing.Point(0, 0);
            this.gridControl_OC.MainView = this.UltraGrid_OC;
            this.gridControl_OC.Name = "gridControl_OC";
            this.gridControl_OC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit_prov});
            this.gridControl_OC.Size = new System.Drawing.Size(972, 293);
            this.gridControl_OC.TabIndex = 16;
            this.gridControl_OC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_OC});
            // 
            // preordencompralocalInfoBindingSource
            // 
            this.preordencompralocalInfoBindingSource.DataSource = typeof(Core.Erp.Info.Presupuesto.pre_ordencompra_local_Info);
            // 
            // UltraGrid_OC
            // 
            this.UltraGrid_OC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdOrdenCompra,
            this.colIdProveedor,
            this.coloc_NumDocumento,
            this.coloc_fecha,
            this.coloc_observacion,
            this.colEstado,
            this.colIdEstadoAprobacion,
            this.colco_fecha_aprobacion,
            this.colIdUsuario_Aprueba,
            this.colIdUsuario_Reprue,
            this.colco_fechaReproba,
            this.colFecha_Transac,
            this.colFecha_UltMod,
            this.colIdUsuarioUltMod,
            this.colFechaHoraAnul,
            this.colIdUsuarioUltAnu,
            this.colEstadoRecepcion,
            this.colMotivoAnulacion,
            this.colIdTerminoPago,
            this.colFormaEnvio,
            this.colCondicionPago});
            this.UltraGrid_OC.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGrid_OC.GridControl = this.gridControl_OC;
            this.UltraGrid_OC.Name = "UltraGrid_OC";
            this.UltraGrid_OC.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_OC.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_OC.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_OC_RowCellStyle);
            this.UltraGrid_OC.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_OC_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Width = 85;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.OptionsColumn.AllowEdit = false;
            this.colIdSucursal.Width = 85;
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.Caption = "#OrdenCompra";
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.OptionsColumn.AllowEdit = false;
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 0;
            this.colIdOrdenCompra.Width = 82;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "Proveedor";
            this.colIdProveedor.ColumnEdit = this.repositoryItemSearchLookUpEdit_prov;
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.OptionsColumn.AllowEdit = false;
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 1;
            this.colIdProveedor.Width = 224;
            // 
            // repositoryItemSearchLookUpEdit_prov
            // 
            this.repositoryItemSearchLookUpEdit_prov.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit_prov.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit_prov.DataSource = this.cpproveedorInfoBindingSource;
            this.repositoryItemSearchLookUpEdit_prov.DisplayMember = "pr_nombre2";
            this.repositoryItemSearchLookUpEdit_prov.Name = "repositoryItemSearchLookUpEdit_prov";
            this.repositoryItemSearchLookUpEdit_prov.ValueMember = "IdProveedor";
            this.repositoryItemSearchLookUpEdit_prov.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // cpproveedorInfoBindingSource
            // 
            this.cpproveedorInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxPagar.cp_proveedor_Info);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDpto,
            this.colro_Dpto});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDpto
            // 
            this.colIdDpto.FieldName = "IdDpto";
            this.colIdDpto.Name = "colIdDpto";
            this.colIdDpto.Visible = true;
            this.colIdDpto.VisibleIndex = 0;
            // 
            // colro_Dpto
            // 
            this.colro_Dpto.FieldName = "ro_Dpto";
            this.colro_Dpto.Name = "colro_Dpto";
            this.colro_Dpto.Visible = true;
            this.colro_Dpto.VisibleIndex = 1;
            // 
            // coloc_NumDocumento
            // 
            this.coloc_NumDocumento.Caption = "#Documento";
            this.coloc_NumDocumento.FieldName = "oc_NumDocumento";
            this.coloc_NumDocumento.Name = "coloc_NumDocumento";
            this.coloc_NumDocumento.OptionsColumn.AllowEdit = false;
            this.coloc_NumDocumento.Visible = true;
            this.coloc_NumDocumento.VisibleIndex = 2;
            this.coloc_NumDocumento.Width = 73;
            // 
            // coloc_fecha
            // 
            this.coloc_fecha.Caption = "Fecha";
            this.coloc_fecha.FieldName = "oc_fecha";
            this.coloc_fecha.Name = "coloc_fecha";
            this.coloc_fecha.OptionsColumn.AllowEdit = false;
            this.coloc_fecha.Visible = true;
            this.coloc_fecha.VisibleIndex = 3;
            this.coloc_fecha.Width = 76;
            // 
            // coloc_observacion
            // 
            this.coloc_observacion.Caption = "Observación";
            this.coloc_observacion.FieldName = "oc_observacion";
            this.coloc_observacion.Name = "coloc_observacion";
            this.coloc_observacion.OptionsColumn.AllowEdit = false;
            this.coloc_observacion.Visible = true;
            this.coloc_observacion.VisibleIndex = 4;
            this.coloc_observacion.Width = 224;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 80;
            // 
            // colIdEstadoAprobacion
            // 
            this.colIdEstadoAprobacion.FieldName = "IdEstadoAprobacion";
            this.colIdEstadoAprobacion.Name = "colIdEstadoAprobacion";
            this.colIdEstadoAprobacion.OptionsColumn.AllowEdit = false;
            this.colIdEstadoAprobacion.Width = 85;
            // 
            // colco_fecha_aprobacion
            // 
            this.colco_fecha_aprobacion.FieldName = "co_fecha_aprobacion";
            this.colco_fecha_aprobacion.Name = "colco_fecha_aprobacion";
            this.colco_fecha_aprobacion.OptionsColumn.AllowEdit = false;
            this.colco_fecha_aprobacion.Width = 117;
            // 
            // colIdUsuario_Aprueba
            // 
            this.colIdUsuario_Aprueba.FieldName = "IdUsuario_Aprueba";
            this.colIdUsuario_Aprueba.Name = "colIdUsuario_Aprueba";
            this.colIdUsuario_Aprueba.OptionsColumn.AllowEdit = false;
            this.colIdUsuario_Aprueba.Width = 144;
            // 
            // colIdUsuario_Reprue
            // 
            this.colIdUsuario_Reprue.FieldName = "IdUsuario_Reprue";
            this.colIdUsuario_Reprue.Name = "colIdUsuario_Reprue";
            this.colIdUsuario_Reprue.OptionsColumn.AllowEdit = false;
            this.colIdUsuario_Reprue.Width = 137;
            // 
            // colco_fechaReproba
            // 
            this.colco_fechaReproba.FieldName = "co_fechaReproba";
            this.colco_fechaReproba.Name = "colco_fechaReproba";
            this.colco_fechaReproba.OptionsColumn.AllowEdit = false;
            this.colco_fechaReproba.Width = 131;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.OptionsColumn.AllowEdit = false;
            this.colFecha_Transac.Width = 93;
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.OptionsColumn.AllowEdit = false;
            this.colFecha_UltMod.Width = 105;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.OptionsColumn.AllowEdit = false;
            // 
            // colFechaHoraAnul
            // 
            this.colFechaHoraAnul.FieldName = "FechaHoraAnul";
            this.colFechaHoraAnul.Name = "colFechaHoraAnul";
            this.colFechaHoraAnul.OptionsColumn.AllowEdit = false;
            this.colFechaHoraAnul.Width = 113;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.OptionsColumn.AllowEdit = false;
            // 
            // colEstadoRecepcion
            // 
            this.colEstadoRecepcion.FieldName = "EstadoRecepcion";
            this.colEstadoRecepcion.Name = "colEstadoRecepcion";
            this.colEstadoRecepcion.OptionsColumn.AllowEdit = false;
            this.colEstadoRecepcion.Width = 69;
            // 
            // colMotivoAnulacion
            // 
            this.colMotivoAnulacion.FieldName = "MotivoAnulacion";
            this.colMotivoAnulacion.Name = "colMotivoAnulacion";
            this.colMotivoAnulacion.OptionsColumn.AllowEdit = false;
            this.colMotivoAnulacion.Width = 62;
            // 
            // colIdTerminoPago
            // 
            this.colIdTerminoPago.FieldName = "IdTerminoPago";
            this.colIdTerminoPago.Name = "colIdTerminoPago";
            this.colIdTerminoPago.OptionsColumn.AllowEdit = false;
            this.colIdTerminoPago.Width = 66;
            // 
            // colFormaEnvio
            // 
            this.colFormaEnvio.FieldName = "FormaEnvio";
            this.colFormaEnvio.Name = "colFormaEnvio";
            this.colFormaEnvio.OptionsColumn.AllowEdit = false;
            this.colFormaEnvio.Visible = true;
            this.colFormaEnvio.VisibleIndex = 5;
            this.colFormaEnvio.Width = 89;
            // 
            // colCondicionPago
            // 
            this.colCondicionPago.FieldName = "CondicionPago";
            this.colCondicionPago.Name = "colCondicionPago";
            this.colCondicionPago.OptionsColumn.AllowEdit = false;
            this.colCondicionPago.Visible = true;
            this.colCondicionPago.VisibleIndex = 6;
            this.colCondicionPago.Width = 106;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_OC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 293);
            this.panel1.TabIndex = 18;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 6, 11, 40, 4, 138);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 6, 11, 40, 4, 138);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(972, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 19;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // frmpre_compraXpresupuesto_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmpre_compraXpresupuesto_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Orden de Compra por Presupuesto";
            this.Load += new System.EventHandler(this.frmpre_compraXpresupuesto_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preordencompralocalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit_prov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpproveedorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_OC;
        private System.Windows.Forms.BindingSource preordencompralocalInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_OC;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn coloc_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fecha_aprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Aprueba;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario_Reprue;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fechaReproba;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaHoraAnul;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoRecepcion;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoAnulacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTerminoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaEnvio;
        private DevExpress.XtraGrid.Columns.GridColumn colCondicionPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit_prov;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDpto;
        private DevExpress.XtraGrid.Columns.GridColumn colro_Dpto;
        private System.Windows.Forms.BindingSource cpproveedorInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}