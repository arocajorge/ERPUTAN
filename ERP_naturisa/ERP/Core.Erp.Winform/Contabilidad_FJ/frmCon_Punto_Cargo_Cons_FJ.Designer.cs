namespace Core.Erp.Winform.Contabilidad_FJ
{
    partial class frmCon_Punto_Cargo_Cons_FJ
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Punto_Cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Punto_Cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 485);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(664, 26);
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 3, 25, 10, 43, 6, 398);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 5, 25, 10, 43, 6, 398);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(664, 95);
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
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // 
            // panel_central
            // 
            this.panel_central.Controls.Add(this.gridControl_Punto_Cargo);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 95);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(664, 390);
            this.panel_central.TabIndex = 2;
            // 
            // gridControl_Punto_Cargo
            // 
            this.gridControl_Punto_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Punto_Cargo.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Punto_Cargo.MainView = this.gridView_Punto_Cargo;
            this.gridControl_Punto_Cargo.Name = "gridControl_Punto_Cargo";
            this.gridControl_Punto_Cargo.Size = new System.Drawing.Size(664, 390);
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
            this.ColEstado,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView_Punto_Cargo.GridControl = this.gridControl_Punto_Cargo;
            this.gridView_Punto_Cargo.Name = "gridView_Punto_Cargo";
            this.gridView_Punto_Cargo.OptionsBehavior.Editable = false;
            this.gridView_Punto_Cargo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Punto_Cargo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Punto_Cargo_RowClick);
            this.gridView_Punto_Cargo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Punto_Cargo_RowCellStyle);
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
            this.ColIdPunto_cargo.Width = 65;
            // 
            // ColcodPunto_cargo
            // 
            this.ColcodPunto_cargo.Caption = "Codigo";
            this.ColcodPunto_cargo.FieldName = "codPunto_cargo";
            this.ColcodPunto_cargo.Name = "ColcodPunto_cargo";
            this.ColcodPunto_cargo.Visible = true;
            this.ColcodPunto_cargo.VisibleIndex = 1;
            this.ColcodPunto_cargo.Width = 83;
            // 
            // Colnom_punto_cargo
            // 
            this.Colnom_punto_cargo.Caption = "Nombre";
            this.Colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.Colnom_punto_cargo.Name = "Colnom_punto_cargo";
            this.Colnom_punto_cargo.Visible = true;
            this.Colnom_punto_cargo.VisibleIndex = 2;
            this.Colnom_punto_cargo.Width = 437;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 5;
            this.ColEstado.Width = 123;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Centro de costo";
            this.gridColumn1.FieldName = "info_punto_cargo_Fj.nom_centro";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 209;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Subcentro de costo";
            this.gridColumn2.FieldName = "info_punto_cargo_Fj.nom_subcentro";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 263;
            // 
            // frmCon_Punto_Cargo_Cons_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "frmCon_Punto_Cargo_Cons_FJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta Punto Cargo";
            this.Load += new System.EventHandler(this.frmCon_Punto_Cargo_Cons_Load);
            this.panel_central.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Punto_Cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Punto_Cargo)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}