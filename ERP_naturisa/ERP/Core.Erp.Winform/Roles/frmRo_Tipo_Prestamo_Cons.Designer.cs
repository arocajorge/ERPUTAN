namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Tipo_Prestamo_Cons
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
            this.gridCtrlTprestamo = new DevExpress.XtraGrid.GridControl();
            this.roTipoPrestamoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTprestamo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltp_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltp_Monto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltp_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMotiAnula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTprestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roTipoPrestamoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTprestamo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlTprestamo
            // 
            this.gridCtrlTprestamo.DataSource = this.roTipoPrestamoInfoBindingSource;
            this.gridCtrlTprestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlTprestamo.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlTprestamo.MainView = this.gridViewTprestamo;
            this.gridCtrlTprestamo.Name = "gridCtrlTprestamo";
            this.gridCtrlTprestamo.Size = new System.Drawing.Size(654, 243);
            this.gridCtrlTprestamo.TabIndex = 13;
            this.gridCtrlTprestamo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTprestamo});
            // 
            // roTipoPrestamoInfoBindingSource
            // 
            this.roTipoPrestamoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Tipo_Prestamo_Info);
            // 
            // gridViewTprestamo
            // 
            this.gridViewTprestamo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPrestamo,
            this.coltp_Descripcion,
            this.coltp_Monto,
            this.coltp_Estado,
            this.ColMotiAnula});
            this.gridViewTprestamo.CustomizationFormBounds = new System.Drawing.Rectangle(512, 442, 216, 185);
            this.gridViewTprestamo.GridControl = this.gridCtrlTprestamo;
            this.gridViewTprestamo.Name = "gridViewTprestamo";
            this.gridViewTprestamo.OptionsBehavior.Editable = false;
            this.gridViewTprestamo.OptionsBehavior.ReadOnly = true;
            this.gridViewTprestamo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTprestamo.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewTprestamo_RowStyle);
            this.gridViewTprestamo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTprestamo_FocusedRowChanged);
            // 
            // colIdTipoPrestamo
            // 
            this.colIdTipoPrestamo.Caption = "Código";
            this.colIdTipoPrestamo.FieldName = "IdTipoPrestamo";
            this.colIdTipoPrestamo.Name = "colIdTipoPrestamo";
            this.colIdTipoPrestamo.Visible = true;
            this.colIdTipoPrestamo.VisibleIndex = 0;
            this.colIdTipoPrestamo.Width = 131;
            // 
            // coltp_Descripcion
            // 
            this.coltp_Descripcion.Caption = "Descripción";
            this.coltp_Descripcion.FieldName = "tp_Descripcion";
            this.coltp_Descripcion.Name = "coltp_Descripcion";
            this.coltp_Descripcion.Visible = true;
            this.coltp_Descripcion.VisibleIndex = 1;
            this.coltp_Descripcion.Width = 556;
            // 
            // coltp_Monto
            // 
            this.coltp_Monto.Caption = "Monto";
            this.coltp_Monto.FieldName = "tp_Monto";
            this.coltp_Monto.Name = "coltp_Monto";
            this.coltp_Monto.Visible = true;
            this.coltp_Monto.VisibleIndex = 2;
            this.coltp_Monto.Width = 381;
            // 
            // coltp_Estado
            // 
            this.coltp_Estado.Caption = "Estado";
            this.coltp_Estado.FieldName = "tp_Estado";
            this.coltp_Estado.Name = "coltp_Estado";
            this.coltp_Estado.Visible = true;
            this.coltp_Estado.VisibleIndex = 3;
            this.coltp_Estado.Width = 186;
            // 
            // ColMotiAnula
            // 
            this.ColMotiAnula.Caption = "Motivo anulacion";
            this.ColMotiAnula.FieldName = "MotiAnula";
            this.ColMotiAnula.Name = "ColMotiAnula";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(654, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 94);
            this.panel1.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 10, 2, 20, 45, 35, 496);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 12, 2, 20, 45, 35, 496);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(654, 97);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrlTprestamo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 243);
            this.panel2.TabIndex = 16;
            // 
            // frmRo_Tipo_Prestamo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_Tipo_Prestamo_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tipo Prestamo";
            this.Load += new System.EventHandler(this.frmRo_Tipo_Prestamo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlTprestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roTipoPrestamoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTprestamo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlTprestamo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTprestamo;
        private System.Windows.Forms.BindingSource roTipoPrestamoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn coltp_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coltp_Monto;
        private DevExpress.XtraGrid.Columns.GridColumn coltp_Estado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn ColMotiAnula;
    }
}