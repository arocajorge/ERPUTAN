namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_cbtecble_Plantilla_Consulta
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
            this.griCbte = new DevExpress.XtraGrid.GridControl();
            this.ctcbtecblePlantillaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewCbte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPlantilla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_MotivoAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_FechaAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_FechaTransac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcb_FechaUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.griCbte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctcbtecblePlantillaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbte)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // griCbte
            // 
            this.griCbte.DataSource = this.ctcbtecblePlantillaInfoBindingSource;
            this.griCbte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griCbte.Location = new System.Drawing.Point(0, 0);
            this.griCbte.MainView = this.gridViewCbte;
            this.griCbte.Name = "griCbte";
            this.griCbte.Size = new System.Drawing.Size(722, 329);
            this.griCbte.TabIndex = 14;
            this.griCbte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbte});
            // 
            // ctcbtecblePlantillaInfoBindingSource
            // 
            this.ctcbtecblePlantillaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_cbtecble_Plantilla_Info);
            // 
            // gridViewCbte
            // 
            this.gridViewCbte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTipoCbte,
            this.colIdPlantilla,
            this.colcb_Fecha,
            this.colcb_Observacion,
            this.colcb_Estado,
            this.colIdUsuario,
            this.colIdUsuarioAnu,
            this.colcb_MotivoAnu,
            this.colIdUsuarioUltModi,
            this.colcb_FechaAnu,
            this.colcb_FechaTransac,
            this.colcb_FechaUltModi});
            this.gridViewCbte.GridControl = this.griCbte;
            this.gridViewCbte.Name = "gridViewCbte";
            this.gridViewCbte.OptionsBehavior.Editable = false;
            this.gridViewCbte.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCbte.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewCbte_RowCellClick);
            this.gridViewCbte.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCbte_RowCellStyle);
            this.gridViewCbte.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCbte_FocusedRowChanged);
            this.gridViewCbte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridViewCbte_KeyPress);
            this.gridViewCbte.DoubleClick += new System.EventHandler(this.gridViewCbte_DoubleClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.Caption = "Tipo Cbte.";
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            this.colIdTipoCbte.OptionsColumn.AllowEdit = false;
            this.colIdTipoCbte.Visible = true;
            this.colIdTipoCbte.VisibleIndex = 1;
            this.colIdTipoCbte.Width = 70;
            // 
            // colIdPlantilla
            // 
            this.colIdPlantilla.Caption = "# Plantilla";
            this.colIdPlantilla.FieldName = "IdPlantilla";
            this.colIdPlantilla.Name = "colIdPlantilla";
            this.colIdPlantilla.OptionsColumn.AllowEdit = false;
            this.colIdPlantilla.Visible = true;
            this.colIdPlantilla.VisibleIndex = 0;
            this.colIdPlantilla.Width = 68;
            // 
            // colcb_Fecha
            // 
            this.colcb_Fecha.Caption = "Fecha";
            this.colcb_Fecha.FieldName = "cb_Fecha";
            this.colcb_Fecha.Name = "colcb_Fecha";
            this.colcb_Fecha.OptionsColumn.AllowEdit = false;
            this.colcb_Fecha.Visible = true;
            this.colcb_Fecha.VisibleIndex = 3;
            this.colcb_Fecha.Width = 73;
            // 
            // colcb_Observacion
            // 
            this.colcb_Observacion.Caption = "Observación";
            this.colcb_Observacion.FieldName = "cb_Observacion";
            this.colcb_Observacion.Name = "colcb_Observacion";
            this.colcb_Observacion.OptionsColumn.AllowEdit = false;
            this.colcb_Observacion.Visible = true;
            this.colcb_Observacion.VisibleIndex = 2;
            this.colcb_Observacion.Width = 435;
            // 
            // colcb_Estado
            // 
            this.colcb_Estado.Caption = "Estado";
            this.colcb_Estado.FieldName = "cb_Estado";
            this.colcb_Estado.Name = "colcb_Estado";
            this.colcb_Estado.OptionsColumn.AllowEdit = false;
            this.colcb_Estado.Visible = true;
            this.colcb_Estado.VisibleIndex = 4;
            this.colcb_Estado.Width = 58;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.AllowEdit = false;
            // 
            // colIdUsuarioAnu
            // 
            this.colIdUsuarioAnu.FieldName = "IdUsuarioAnu";
            this.colIdUsuarioAnu.Name = "colIdUsuarioAnu";
            this.colIdUsuarioAnu.OptionsColumn.AllowEdit = false;
            // 
            // colcb_MotivoAnu
            // 
            this.colcb_MotivoAnu.FieldName = "cb_MotivoAnu";
            this.colcb_MotivoAnu.Name = "colcb_MotivoAnu";
            this.colcb_MotivoAnu.OptionsColumn.AllowEdit = false;
            // 
            // colIdUsuarioUltModi
            // 
            this.colIdUsuarioUltModi.FieldName = "IdUsuarioUltModi";
            this.colIdUsuarioUltModi.Name = "colIdUsuarioUltModi";
            this.colIdUsuarioUltModi.OptionsColumn.AllowEdit = false;
            // 
            // colcb_FechaAnu
            // 
            this.colcb_FechaAnu.FieldName = "cb_FechaAnu";
            this.colcb_FechaAnu.Name = "colcb_FechaAnu";
            this.colcb_FechaAnu.OptionsColumn.AllowEdit = false;
            // 
            // colcb_FechaTransac
            // 
            this.colcb_FechaTransac.FieldName = "cb_FechaTransac";
            this.colcb_FechaTransac.Name = "colcb_FechaTransac";
            this.colcb_FechaTransac.OptionsColumn.AllowEdit = false;
            // 
            // colcb_FechaUltModi
            // 
            this.colcb_FechaUltModi.FieldName = "cb_FechaUltModi";
            this.colcb_FechaUltModi.Name = "colcb_FechaUltModi";
            this.colcb_FechaUltModi.OptionsColumn.AllowEdit = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 95);
            this.panel1.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 5, 27, 16, 34, 33, 906);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 7, 27, 16, 34, 33, 906);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(722, 97);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.griCbte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 329);
            this.panel2.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmCon_cbtecble_Plantilla_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCon_cbtecble_Plantilla_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plantillas de Comprobante Contable Consulta";
            this.Load += new System.EventHandler(this.frmCon_cbtecble_Plantilla_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griCbte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctcbtecblePlantillaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl griCbte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbte;
        private System.Windows.Forms.BindingSource ctcbtecblePlantillaInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPlantilla;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_MotivoAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltModi;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_FechaAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_FechaTransac;
        private DevExpress.XtraGrid.Columns.GridColumn colcb_FechaUltModi;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}