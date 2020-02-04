namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Unidad_Medida_Consu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Unidad_Medida_Consu));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel_main = new System.Windows.Forms.Panel();
            this.gridControl_uni_medida = new DevExpress.XtraGrid.GridControl();
            this.gridView_unidad_med = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_alterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsado_en_Movimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Vaciar = new System.Windows.Forms.ToolStripButton();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_uni_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_unidad_med)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 10, 18, 10, 41, 21, 107);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 12, 18, 10, 41, 21, 107);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(639, 97);
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
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 277);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(639, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.gridControl_uni_medida);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 97);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(639, 180);
            this.panel_main.TabIndex = 2;
            // 
            // gridControl_uni_medida
            // 
            this.gridControl_uni_medida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_uni_medida.Location = new System.Drawing.Point(0, 0);
            this.gridControl_uni_medida.MainView = this.gridView_unidad_med;
            this.gridControl_uni_medida.Name = "gridControl_uni_medida";
            this.gridControl_uni_medida.Size = new System.Drawing.Size(639, 180);
            this.gridControl_uni_medida.TabIndex = 0;
            this.gridControl_uni_medida.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_unidad_med});
            this.gridControl_uni_medida.Click += new System.EventHandler(this.gridControl_uni_medida_Click);
            // 
            // gridView_unidad_med
            // 
            this.gridView_unidad_med.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida,
            this.colcod_alterno,
            this.colDescripcion,
            this.colUsado_en_Movimiento,
            this.colEstado});
            this.gridView_unidad_med.GridControl = this.gridControl_uni_medida;
            this.gridView_unidad_med.Name = "gridView_unidad_med";
            this.gridView_unidad_med.OptionsBehavior.Editable = false;
            this.gridView_unidad_med.OptionsView.ShowAutoFilterRow = true;
            this.gridView_unidad_med.OptionsView.ShowGroupPanel = false;
            this.gridView_unidad_med.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_unidad_med_RowCellStyle);
            this.gridView_unidad_med.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_unidad_med_FocusedRowChanged);
            this.gridView_unidad_med.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_unidad_med_KeyDown);
            this.gridView_unidad_med.DoubleClick += new System.EventHandler(this.gridView_unidad_med_DoubleClick);
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Visible = true;
            this.colIdUnidadMedida.VisibleIndex = 0;
            this.colIdUnidadMedida.Width = 128;
            // 
            // colcod_alterno
            // 
            this.colcod_alterno.Caption = "Codigo";
            this.colcod_alterno.FieldName = "cod_alterno";
            this.colcod_alterno.Name = "colcod_alterno";
            this.colcod_alterno.Visible = true;
            this.colcod_alterno.VisibleIndex = 1;
            this.colcod_alterno.Width = 102;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 750;
            // 
            // colUsado_en_Movimiento
            // 
            this.colUsado_en_Movimiento.Caption = "Usado x Movimiento";
            this.colUsado_en_Movimiento.FieldName = "Usado_en_Movimiento";
            this.colUsado_en_Movimiento.Name = "colUsado_en_Movimiento";
            this.colUsado_en_Movimiento.Visible = true;
            this.colUsado_en_Movimiento.VisibleIndex = 3;
            this.colUsado_en_Movimiento.Width = 105;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 95;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Vaciar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 483);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btn_Vaciar
            // 
            this.btn_Vaciar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Vaciar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Vaciar.Image")));
            this.btn_Vaciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Vaciar.Name = "btn_Vaciar";
            this.btn_Vaciar.Size = new System.Drawing.Size(59, 22);
            this.btn_Vaciar.Text = "Vaciar";
            this.btn_Vaciar.Click += new System.EventHandler(this.btn_Vaciar_Click);
            // 
            // FrmIn_Unidad_Medida_Consu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 303);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmIn_Unidad_Medida_Consu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Unidad de Medida";
            this.Load += new System.EventHandler(this.FrmIn_Unidad_Medida_Consu_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_uni_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_unidad_med)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panel_main;
        private DevExpress.XtraGrid.GridControl gridControl_uni_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_unidad_med;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_alterno;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsado_en_Movimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Vaciar;

    }
}