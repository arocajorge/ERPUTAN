namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_TipoNota_consu
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.faTipoNotaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNemonico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInternoSis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeDeclaraSRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faTipoNotaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.faTipoNotaInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 94);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(938, 345);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // faTipoNotaInfoBindingSource
            // 
            this.faTipoNotaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_TipoNota_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTipoNota,
            this.colCodTipoNota,
            this.colTipo,
            this.colno_Descripcion,
            this.colIdCtaCble,
            this.colNemonico,
            this.colInternoSis,
            this.colSeDeclaraSRI,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdTipoNota
            // 
            this.colIdTipoNota.FieldName = "IdTipoNota";
            this.colIdTipoNota.Name = "colIdTipoNota";
            this.colIdTipoNota.Visible = true;
            this.colIdTipoNota.VisibleIndex = 0;
            this.colIdTipoNota.Width = 58;
            // 
            // colCodTipoNota
            // 
            this.colCodTipoNota.Caption = "Codigo";
            this.colCodTipoNota.FieldName = "CodTipoNota";
            this.colCodTipoNota.Name = "colCodTipoNota";
            this.colCodTipoNota.Visible = true;
            this.colCodTipoNota.VisibleIndex = 1;
            this.colCodTipoNota.Width = 120;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 3;
            this.colTipo.Width = 140;
            // 
            // colno_Descripcion
            // 
            this.colno_Descripcion.Caption = "Descripción";
            this.colno_Descripcion.FieldName = "no_Descripcion";
            this.colno_Descripcion.Name = "colno_Descripcion";
            this.colno_Descripcion.Visible = true;
            this.colno_Descripcion.VisibleIndex = 2;
            this.colno_Descripcion.Width = 453;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            // 
            // colNemonico
            // 
            this.colNemonico.Caption = "Nemonico";
            this.colNemonico.FieldName = "Nemonico";
            this.colNemonico.Name = "colNemonico";
            this.colNemonico.Visible = true;
            this.colNemonico.VisibleIndex = 5;
            // 
            // colInternoSis
            // 
            this.colInternoSis.FieldName = "InternoSis";
            this.colInternoSis.Name = "colInternoSis";
            // 
            // colSeDeclaraSRI
            // 
            this.colSeDeclaraSRI.FieldName = "SeDeclaraSRI";
            this.colSeDeclaraSRI.Name = "colSeDeclaraSRI";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 146;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 146;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 149;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 94);
            this.panel1.TabIndex = 4;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 9, 3, 14, 39, 23, 361);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 11, 3, 14, 39, 23, 361);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(938, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmFa_TipoNota_consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 461);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_TipoNota_consu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tipos Notas";
            this.Load += new System.EventHandler(this.frmFA_TipoNota_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faTipoNotaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource faTipoNotaInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoNota;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colno_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colNemonico;
        private DevExpress.XtraGrid.Columns.GridColumn colInternoSis;
        private DevExpress.XtraGrid.Columns.GridColumn colSeDeclaraSRI;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}