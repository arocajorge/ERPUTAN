namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_Punto_Cargo_Cons
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel_central = new System.Windows.Forms.Panel();
            this.gridControl_Punto_Cargo = new DevExpress.XtraGrid.GridControl();
            this.gridView_Punto_Cargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColcodPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnVaciar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Salir_cons = new System.Windows.Forms.ToolStripButton();
            this.panel_central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Punto_Cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Punto_Cargo)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 3);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(805, 25);
            this.ucGe_BarraEstado.TabIndex = 0;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 12, 20, 15, 36, 34, 571);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 2, 20, 15, 36, 34, 571);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(805, 179);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.gridControl_Punto_Cargo);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 179);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(805, 138);
            this.panel_central.TabIndex = 2;
            // 
            // gridControl_Punto_Cargo
            // 
            this.gridControl_Punto_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Punto_Cargo.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Punto_Cargo.MainView = this.gridView_Punto_Cargo;
            this.gridControl_Punto_Cargo.Name = "gridControl_Punto_Cargo";
            this.gridControl_Punto_Cargo.Size = new System.Drawing.Size(805, 138);
            this.gridControl_Punto_Cargo.TabIndex = 0;
            this.gridControl_Punto_Cargo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Punto_Cargo});
            // 
            // gridView_Punto_Cargo
            // 
            this.gridView_Punto_Cargo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEmpresa,
            this.ColIdPunto_cargo,
            this.ColcodPunto_cargo,
            this.Colnom_punto_cargo,
            this.ColEstado});
            this.gridView_Punto_Cargo.GridControl = this.gridControl_Punto_Cargo;
            this.gridView_Punto_Cargo.Name = "gridView_Punto_Cargo";
            this.gridView_Punto_Cargo.OptionsBehavior.Editable = false;
            this.gridView_Punto_Cargo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Punto_Cargo.OptionsView.ShowGroupPanel = false;
            this.gridView_Punto_Cargo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Punto_Cargo_RowClick);
            this.gridView_Punto_Cargo.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_Punto_Cargo_RowCellClick);
            this.gridView_Punto_Cargo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Punto_Cargo_RowCellStyle);
            this.gridView_Punto_Cargo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Punto_Cargo_FocusedRowChanged);
            this.gridView_Punto_Cargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView_Punto_Cargo_KeyPress);
            this.gridView_Punto_Cargo.DoubleClick += new System.EventHandler(this.gridView_Punto_Cargo_DoubleClick);
            // 
            // ColIdEmpresa
            // 
            this.ColIdEmpresa.Caption = "IdEmpresa";
            this.ColIdEmpresa.FieldName = "IdEmpresa";
            this.ColIdEmpresa.Name = "ColIdEmpresa";
            // 
            // ColIdPunto_cargo
            // 
            this.ColIdPunto_cargo.Caption = "ID";
            this.ColIdPunto_cargo.FieldName = "IdPunto_cargo";
            this.ColIdPunto_cargo.Name = "ColIdPunto_cargo";
            this.ColIdPunto_cargo.Visible = true;
            this.ColIdPunto_cargo.VisibleIndex = 0;
            this.ColIdPunto_cargo.Width = 42;
            // 
            // ColcodPunto_cargo
            // 
            this.ColcodPunto_cargo.Caption = "Codigo";
            this.ColcodPunto_cargo.FieldName = "codPunto_cargo";
            this.ColcodPunto_cargo.Name = "ColcodPunto_cargo";
            this.ColcodPunto_cargo.Visible = true;
            this.ColcodPunto_cargo.VisibleIndex = 1;
            this.ColcodPunto_cargo.Width = 54;
            // 
            // Colnom_punto_cargo
            // 
            this.Colnom_punto_cargo.Caption = "Punto de cargo";
            this.Colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.Colnom_punto_cargo.Name = "Colnom_punto_cargo";
            this.Colnom_punto_cargo.Visible = true;
            this.Colnom_punto_cargo.VisibleIndex = 2;
            this.Colnom_punto_cargo.Width = 416;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 3;
            this.ColEstado.Width = 97;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaciar.Location = new System.Drawing.Point(726, 2);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 1;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.Visible = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_BarraEstado);
            this.panel1.Controls.Add(this.btnVaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 28);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salir_cons});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btn_Salir_cons
            // 
            this.btn_Salir_cons.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Salir_cons.Image = global::Core.Erp.Winform.Properties.Resources.salir_32x32;
            this.btn_Salir_cons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir_cons.Name = "btn_Salir_cons";
            this.btn_Salir_cons.Size = new System.Drawing.Size(49, 22);
            this.btn_Salir_cons.Text = "Salir";
            this.btn_Salir_cons.Click += new System.EventHandler(this.btn_Salir_cons_Click);
            // 
            // frmCon_Punto_Cargo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 345);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCon_Punto_Cargo_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Punto Cargo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_Punto_Cargo_Cons_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCon_Punto_Cargo_Cons_FormClosed);
            this.Load += new System.EventHandler(this.frmCon_Punto_Cargo_Cons_Load);
            this.panel_central.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Punto_Cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Punto_Cargo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel_central;
        private DevExpress.XtraGrid.GridControl gridControl_Punto_Cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Punto_Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPunto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn ColcodPunto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn Colnom_punto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private DevExpress.XtraEditors.SimpleButton btnVaciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Salir_cons;
    }
}